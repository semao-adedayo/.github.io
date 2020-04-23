using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random search = new Random();
            Console.WriteLine("You are Welcome to number guessing game");
            Console.WriteLine("\nLevels available are: E - Easy, M - Medium, H - Hard\n");
            Console.Write("Please choose your prefered level: ");
            string userGuess = Console.ReadLine();
            
            if (userGuess == "E")
            {
                int searchNumber = search.Next(1, 11);
                int guess;
                int numberofGuesses = 6;
                bool gameOver = false;

                Console.WriteLine("\nYou have selected easy mode: You have to guess a number between 1 to 10");

                int i = 0;
                int a;
                while (i <= 5 && gameOver == false)
                {
                    Console.WriteLine("\nYou have {0} chances left", a = 6 - i);
                    i++;
                    Console.Write("Guess a number:");
                    guess = int.Parse(Console.ReadLine());
                    numberofGuesses--;

                    if (guess != searchNumber && numberofGuesses == 0)
                    {
                        Console.WriteLine("THAT WAS WRONG");
                        gameOver = true;
                    }
                    else if (guess == searchNumber)
                    {
                        Console.WriteLine("YOU GOT IT RIGHT");
                        gameOver = true;
                    }
                }
                Console.WriteLine("\nGAME OVER");
            }
            else if (userGuess == "M")
            {
                int searchNumber = search.Next(1, 21);
                int guess;
                int numberofGuesses = 4;
                bool gameOver = false;

                Console.WriteLine("\nYou have selected medium mode: You have to guess a number between 1 to 20");
                
                int i = 0;
                int a;
                while (i <= 3 && gameOver == false)
                {
                    Console.WriteLine("\nYou have {0} chances left", a = 4 - i);
                    i++;
                    Console.Write("Guess a number:");
                    guess = int.Parse(Console.ReadLine());
                    numberofGuesses--;

                    if (guess != searchNumber && numberofGuesses == 0)
                    {
                        Console.WriteLine("THAT WAS WRONG");
                        gameOver = true;
                    }
                    else if (guess == searchNumber)
                    {
                        Console.WriteLine("YOU GOT IT RIGHT");
                        gameOver = true;
                    }
                }
                Console.WriteLine("\nGAME OVER");
            }
            else if (userGuess == "H")
            {
                int searchNumber = search.Next(1, 51);
                int guess;
                int numberofGuesses = 3;
                bool gameOver = false;

                Console.WriteLine("\nYou have selected hard mode: You have to guess a number between 1 to 50");

                int i = 0;
                int a;
                while (i <= 2 && gameOver == false)
                {
                    Console.WriteLine("\nYou have {0} chances left", a = 3 - i);
                    i++;
                    Console.Write("Guess a number:");
                    guess = int.Parse(Console.ReadLine());
                    numberofGuesses--;

                    if (guess != searchNumber && numberofGuesses == 0)
                    {
                        Console.WriteLine("THAT WAS WRONG");
                        gameOver = true;
                    }
                    else if (guess == searchNumber)
                    {
                        Console.WriteLine("YOU GOT IT RIGHT");
                        gameOver = true;
                    }
                }
                Console.WriteLine("\nGAME OVER");
            }
        }
    }
}
