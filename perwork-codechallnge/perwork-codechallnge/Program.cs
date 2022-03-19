using System;

namespace prework_code_challenges
{
    class Program
    {
        static void Main(string[] args)
        {

            
            ScoreGame();

            
           CalculateLeapYear();

            
            TestForPerfectSequence();

            
            GetSumOfRows();

            Console.ReadLine();
        }


        
        // Solution for challenge 1
       

        private static void ComputeScore(int[] chosenArray, int chosenNumber)
        {

            
            int count = 0;
            foreach (int number in chosenArray)
            {
                if (number == chosenNumber)
                {
                    count++;
                }
            }

            int score = count * chosenNumber;

            
            Console.WriteLine($"Your score is {score}!");
        }

        private static void ScoreGame()
        {
            Console.WriteLine("Enter a list of five numbers separated by commas (with no spaces in between).");

            string userNumbers = Console.ReadLine();

            Console.WriteLine($"You selected these numbers: {userNumbers}");

            
            string[] stringArray = userNumbers.Split(",");
            

            int[] arrayifiedNumbers = new int[5];

            arrayifiedNumbers[0] = int.Parse(stringArray[0]);
            arrayifiedNumbers[1] = int.Parse(stringArray[1]);
            arrayifiedNumbers[2] = int.Parse(stringArray[2]);
            arrayifiedNumbers[3] = int.Parse(stringArray[3]);
            arrayifiedNumbers[4] = int.Parse(stringArray[4]);

            
            Console.WriteLine("Enter a number of your choice from among the five numbers you entered.");
            int numberChoice = int.Parse(Console.ReadLine());

            ComputeScore(arrayifiedNumbers, numberChoice);

            Console.WriteLine(" ");
        }


       
        // Solution for challenge 2

        private static void CalculateLeapYear()
        {
            Console.WriteLine("Enter a year to see if it's a leap year.");

            string userGuess = Console.ReadLine();

            int userGuessToInt = int.Parse(userGuess);

            if (userGuessToInt % 4 == 0)
            {
                if (userGuessToInt % 100 == 0)
                {
                    if (userGuessToInt % 400 == 0)
                    {
                        Console.WriteLine("The year you entered is a leap year!");
                    }
                    else
                    {
                        Console.WriteLine("The year you entered isn't a leap year.");
                    }
                }
                else
                {
                    Console.WriteLine("The year you entered is a leap year!");
                }
            }
            else
            {
                Console.WriteLine("The year you entered isn't a leap year.");
            }
            Console.WriteLine(" ");
        }


        
        // Solution for challenge 3
        private static void TestForPerfectSequence()
        {
            Console.WriteLine("Enter a list of non-negative integers to see if they are a perfect sequence. " +
                "(The numbers must be separated by commas with no spaces in between.)");

            
            string userInput = Console.ReadLine();

            
            string[] stringArray = userInput.Split(",");

            
            int[] intArray = new int[stringArray.Length];

           
            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = int.Parse(stringArray[i]);
            }

            
            int productOfElements = 1;
            int sumOfElements = 0;

            
            for (int i = 0; i < intArray.Length; i++)
            {
                productOfElements *= intArray[i];
                sumOfElements += intArray[i];
            }

            
            if (productOfElements == sumOfElements)
            {
                Console.WriteLine("The numbers you entered are a perfect sequence!");
            }
            else
            {
                Console.WriteLine("The numbers you entered are not a perfect sequence.");
            }

            Console.WriteLine(" ");
        }


        
        // Solution for challenge 4
        

        private static void GetSumOfRows()
        {
            Console.WriteLine("Let's create a multidimensional array and sum its rows!");

            
            Console.WriteLine("Enter a positive integer for the number of rows you want in the array.");
            string mDimensionAsString = Console.ReadLine();
            int mDimensionAsInt = int.Parse(mDimensionAsString);
            Console.WriteLine($"Thanks! You entered {mDimensionAsInt}");
            Console.WriteLine($" ");

            
            Console.WriteLine("Enter a positive integer for the number of columns you want in the array.");
            string nDimensionAsString = Console.ReadLine();
            int nDimensionAsInt = int.Parse(nDimensionAsString);
            Console.WriteLine($"Thanks! You entered {nDimensionAsInt}");
            Console.WriteLine($" ");

            
            int[,] userArray = new int[mDimensionAsInt, nDimensionAsInt];

           
            Random newRandNum = new Random();
            for (int i = 0; i < userArray.GetLength(0); i++)
            {
                for (int j = 0; j < userArray.GetLength(1); j++)
                {
                    userArray[i, j] = newRandNum.Next(1, 100);
                }
            }

            
            sumRows(userArray);
        }

        private static void sumRows(int[,] array)
        {
            int[] rowTotalArray = new int[array.GetLength(0)];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                int total = 0;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    total += array[i, j];
                }

                rowTotalArray[i] = total;
            }
            Console.WriteLine($"Here are the sums of the elements in each row of the multidimensional array:");
            Console.WriteLine("[{0}]", string.Join(",", rowTotalArray));
        }
    }
}