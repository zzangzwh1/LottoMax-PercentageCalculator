namespace LottoMax_PercentageCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] lotto2024WinningNumber = {
    new int[] {1, 4, 18, 19, 23, 28, 29, 43},   // May 31, 2024
    new int[] {2, 6, 9, 21, 22, 32, 43, 3},     // May 28, 2024
    new int[] {1, 6, 9, 11, 31, 39, 50, 35},    // May 24, 2024
    new int[] {1, 4, 6, 7, 34, 40, 46, 2},      // May 21, 2024
    new int[] {5, 13, 27, 28, 32, 45, 50, 44},  // May 17, 2024
    new int[] {10, 15, 18, 27, 28, 32, 43, 8},  // May 14, 2024
    new int[] {2, 4, 14, 28, 29, 30, 43, 34},   // May 10, 2024
    new int[] {3, 22, 32, 43, 46, 47, 48, 49},  // May 7, 2024
    new int[] {3, 5, 16, 20, 31, 34, 38, 17},   // May 3, 2024
    new int[] {5, 8, 18, 21, 23, 31, 48, 40},   // April 30, 2024
    new int[] {2, 3, 23, 36, 38, 40, 48, 42},   // April 26, 2024
    new int[] {7, 14, 17, 26, 29, 38, 39, 18},  // April 23, 2024
    new int[] {6, 7, 14, 15, 28, 39, 42, 37},   // April 19, 2024
    new int[] {15, 19, 22, 28, 34, 36, 46, 25}, // April 16, 2024
    new int[] {17, 25, 30, 35, 36, 44, 50, 10}, // April 12, 2024
    new int[] {4, 5, 22, 30, 44, 46, 50, 34},   // April 9, 2024
    new int[] {4, 8, 18, 24, 26, 35, 46, 5},    // April 5, 2024
    new int[] {11, 23, 36, 38, 42, 43, 49, 27}, // April 2, 2024
    new int[] {1, 14, 17, 19, 23, 42, 48, 39},  // March 29, 2024
    new int[] {21, 24, 25, 26, 31, 42, 43, 30}, // March 26, 2024
    new int[] {2, 7, 19, 28, 36, 37, 44, 10},   // March 22, 2024
    new int[] {3, 16, 19, 21, 24, 40, 46, 39},  // March 19, 2024
    new int[] {22, 24, 31, 33, 39, 45, 46, 2},  // March 15, 2024
    new int[] {3, 15, 20, 21, 23, 24, 34, 38},  // March 12, 2024
    new int[] {1, 3, 6, 19, 21, 33, 47, 10},    // March 8, 2024
    new int[] {2, 4, 7, 25, 33, 43, 49, 38},    // March 5, 2024
            };

            int[] mostFrequentNumbers = FindMostFrequentNumbers(lotto2024WinningNumber);

            // Print the most frequent number at each index
            for (int i = 0; i < mostFrequentNumbers.Length; i++)
            {
                Console.WriteLine($"Most frequent number at index {i}: {mostFrequentNumbers[i]}");
            }


            Console.ReadLine();
        }
        static int[] FindMostFrequentNumbers(int[][] numbers)
        {
            int[] mostFrequentNumbers = new int[numbers[0].Length];

            for (int i = 0; i < numbers[0].Length; i++)
            {
                // Count occurrences of each number at this index
                Dictionary<int, int> frequencyMap = new Dictionary<int, int>();
                int maxFrequency = 0;
                int mostFrequentNumber = 0;

                for (int j = 0; j < numbers.Length; j++)
                {
                    int currentNumber = numbers[j][i];
                    int frequency;
                    if (frequencyMap.TryGetValue(currentNumber, out frequency))
                        frequency++;
                    else
                        frequency = 1;

                    frequencyMap[currentNumber] = frequency;
                    if (frequency > maxFrequency)
                    {
                        maxFrequency = frequency;
                        mostFrequentNumber = currentNumber;
                    }
                }

                mostFrequentNumbers[i] = mostFrequentNumber;
            }

            return mostFrequentNumbers;
        }
    }
}
