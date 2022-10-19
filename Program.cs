// Задача 68: Задайте значения M и N. Напишите программу, которая найдёт наибольший общий делитель (НОД) этих чисел с помощью рекурсии.

Console.Clear();
Console.WriteLine("Программа выдаёт наибольший общий делитель (НОД) для натуральных чисел M и N с помощью рекурсии");

int first = 0;
first = AskForInput("меньшее");
int second = AskForInput("большее");
int nod = first;

System.Console.WriteLine($"\nНаибольший общий делитель (НОД) для натуральных чисел {first} и {second} - {PrintNOD(first, second, nod)}");


//////////////////////////// функции ////////////////////////////////////////////////////


int AskForInput(string str)
{
    while (true)
    {
        Console.Write($"\nНапишите {str} натуральное число:");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            if (number > 0 && number > first) 
            {
                return number;
                break;
            }
            else Console.WriteLine($"Некорректно указано {str} натуральное число!\n");
        }
        else Console.WriteLine($"Некорректно указано {str} натуральное число!\n");
    }
}

int PrintNOD(int first, int second, int nod)
{
    return second % nod == 0 && first % nod == 0 ? nod : PrintNOD(first, second, nod - 1);    
}



