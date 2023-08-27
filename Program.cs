Console.WriteLine("Введите элементы массива: ");
string[] inputArray = GetArrayFromUser(5);
string[] outputArray = GetOutputArray(inputArray);
Console.WriteLine($"Итоговый массив: {String.Join(", ", outputArray)}");


string[] GetOutputArray (string[] array1)
{
    int sizeOutArray = CountElementsLongerThree(inputArray);
    string[] array2 = new string[sizeOutArray];
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
    return array2;
}

int CountElementsLongerThree (string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <=3)
        {
            count++;
        }
    }
    return count;
}

string[] GetArrayFromUser (int size)
{
    string[] array = new string [size];
    for (int i = 0; i < size; i++)
    {
        array [i] = Console.ReadLine()??"";
    }
    return array;
}
