using System;

namespace System.Collections.Generic
{
	// Token: 0x02000047 RID: 71
	internal static class EnumerableHelpers
	{
		// Token: 0x06000346 RID: 838 RVA: 0x0000C7A8 File Offset: 0x0000A9A8
		internal static void Reset<T>(ref T enumerator) where T : IEnumerator
		{
			enumerator.Reset();
		}

		// Token: 0x06000347 RID: 839 RVA: 0x0000C7B6 File Offset: 0x0000A9B6
		internal static IEnumerator<T> GetEmptyEnumerator<T>()
		{
			return Array.Empty<T>().GetEnumerator();
		}

		// Token: 0x06000348 RID: 840 RVA: 0x0000C7C4 File Offset: 0x0000A9C4
		internal static T[] ToArray<T>(IEnumerable<T> source, out int length)
		{
			ICollection<T> collection = source as ICollection<T>;
			if (collection != null)
			{
				int count = collection.Count;
				if (count != 0)
				{
					T[] array = new T[count];
					collection.CopyTo(array, 0);
					length = count;
					return array;
				}
			}
			else
			{
				using (IEnumerator<T> enumerator = source.GetEnumerator())
				{
					if (enumerator.MoveNext())
					{
						T[] array2 = new T[4];
						array2[0] = enumerator.Current;
						int num = 1;
						while (enumerator.MoveNext())
						{
							if (num == array2.Length)
							{
								int num2 = num << 1;
								if (num2 > 2147483591)
								{
									num2 = ((2147483591 <= num) ? (num + 1) : 2147483591);
								}
								Array.Resize<T>(ref array2, num2);
							}
							array2[num++] = enumerator.Current;
						}
						length = num;
						return array2;
					}
				}
			}
			length = 0;
			return Array.Empty<T>();
		}
	}
}
