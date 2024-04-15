// See https://aka.ms/new-console-template for more information
using System;


// *******************************************************
// Q1
// *******************************************************
/* Console.WriteLine("Hello, World!");


string testPath = @"E:Net\vonntestconsole\vonncmdtest\vonncommandtest\testing_text.txt";
string readFile = File.ReadAllText(testPath);

Console.WriteLine(readFile);
*/



// *******************************************************
// Q2
// *******************************************************
/* 


try
{
    int numericInt = int.Parse(Console.ReadLine());

    Console.WriteLine(CheckNumberRange(numericInt));
} catch
{
    Console.WriteLine("Error!");
}


string CheckNumberRange(int pNum)
{
    if (pNum >= 0 && pNum <= 1000)
    {
        return "YEY";
    }
    else
    {
        throw new Exception("Number should be greater than equal to Zero and less than equal to 1000");
    }
}

*/


// *******************************************************
// Q3
// *******************************************************

/* 
int GetArrayAvg(int[] pNums)
{

    if (pNums.Length <= 0)
        throw new Exception("No Empty Array");

    int sumOfAll = 0;
    for (int i = 0; i < pNums.Length; i++)
    {
        sumOfAll += pNums[i];
    }

    return sumOfAll / pNums.Length;
}

bool tryGetAverage = false;
int[] desiredNumbers = [];
while (tryGetAverage == false)
{
    string myLine = Console.ReadLine();

    if (myLine == null)
    {
        tryGetAverage = true;
    } else
    {
        desiredNumbers.Append(int.Parse(myLine));
    }
        

    
}


GetArrayAvg(desiredNumbers);

*/


// *******************************************************
// Q4
// *******************************************************

/* 
try
{
    int myLine = int.Parse(Console.ReadLine());
    Console.WriteLine("myLine");
} catch
{
    Console.WriteLine("invalid");
}
*/

// *******************************************************
// Q5
// *******************************************************
/*
void GetArrayAvg(Int32[] pNums)
{

    if (pNums.Length <= 0)
        throw new Exception("No Empty Array");

    for (int i = 0; i < pNums.Length; i++)
    {
        if (pNums[i] <= Int32.MinValue && pNums[i] >= Int32.MaxValue)
        {
            
        } else
        {
            throw new Exception("Integer not in range");
        }
    }

    Console.WriteLine("All numbers in range");


}


try
{
    bool isReading = true;
    int[] allNumbers = [];
    while (isReading)
    {
        int myNumber = int.Parse(Console.ReadLine());
        if (myNumber == null)
        {
            isReading = false;
            break;
        }
        allNumbers.Append(myNumber);
    }
    GetArrayAvg(allNumbers);


}
catch (Exception err)
{
    Console.WriteLine(err);
}
*/

// *******************************************************
// Q6 
// *******************************************************
/* 
int DivideTwoNumbers(int pNum1, int pNum2)
{
    if (pNum2 == 0)
    {
        throw new DivideByZeroException();
    }
    return pNum1 / pNum2;
}

Console.WriteLine("Input num1: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Input num2: ");
int num2 = int.Parse(Console.ReadLine());
try
{
    Console.WriteLine("The answer is " + DivideTwoNumbers(num1, num2));
} catch(Exception err)
{
    Console.WriteLine(err);
}
*/



// *******************************************************
// Q7
// *******************************************************

/* 
DateTime GenerateDateTime(string ddmmyyyy)
{
    DateTime convertToDT = DateTime.Parse(ddmmyyyy);

    if (convertToDT == null) throw new Exception("cannot convert to DateTime");

    return convertToDT;
}

Console.WriteLine("input DD/MM/YYYY");
try {
    Console.WriteLine(GenerateDateTime(Console.ReadLine()));
} catch (Exception ex) {
    Console.WriteLine(ex);
}

*/

// *******************************************************
// Q8
// *******************************************************

/* 
double GetSqrRoot(int pNum)
{

    if (pNum < 0)
    {
        throw new Exception("Must be greater than -1");
    }
    double newValue = Math.Sqrt(pNum);
    return newValue;
}
Console.WriteLine("input Number to  be Rooted: ");
try
{
    Console.WriteLine(GetSqrRoot(int.Parse(Console.ReadLine())));
}
catch (Exception ex)
{
    Console.WriteLine(ex);
}
*/