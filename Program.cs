


/* напишите цикл , который принимакт на вход 2 числа A B и возводит A в натуральную степень  B
int Prompt(string message)
{
    
    string readInput = System.Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}
int Power(int powerBase, int exponent)
{
    int power = 1;
    for (int i = 0; i < exponent; i++)
    {
        power *= powerBase;
    }
    return power;
}
bool ValideteExponent(int exponent)
{
    if (exponent < 0)
    {
        System.Console.WriteLine("Показатель не должен быть меньше нуля");
        return false;
    }
    return true;
}
int powerBase = Prompt("Введите основание: ");
int exponent = Prompt("Введите показатель: ");
if (ValideteExponent(exponent))
{
    System.Console.WriteLine($"число{powerBase} в степени {exponent} равно {Power(powerBase, exponent)}");
}

Напишите программу которая принимает на вход число и выдает сумму чисел в числе.
*/

int Prompt(string message)
{
    System.Console.Write(message);
    string readInput = System.Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}
int SumAllDigit(int number)
{
    int result = 0;
    while (number > 0)
    {
        result += number 10 %;
        number = number / 10;
    }
    return result;
}
int number = Prompt("Ввведите число: ");
System.Console.Write($"сумма всех чисел в цифре {number}) = {SumAllDigit(number)}");
