using System;

namespace System.Collections.Generic
{
	// Token: 0x020009A7 RID: 2471
	internal static class SortUtils
	{
		// Token: 0x060091FF RID: 37375 RVA: 0x0016AC78 File Offset: 0x00168E78
		public unsafe static int MoveNansToFront<TKey, TValue>(Span<TKey> keys, Span<TValue> values)
		{
			int num = 0;
			for (int i = 0; i < keys.Length; i++)
			{
				if ((typeof(TKey) == typeof(double) && double.IsNaN((double)((object)(*keys[i])))) || (typeof(TKey) == typeof(float) && float.IsNaN((float)((object)(*keys[i])))) || (typeof(TKey) == typeof(Half) && Half.IsNaN((Half)((object)(*keys[i])))))
				{
					TKey tkey = *keys[num];
					*keys[num] = *keys[i];
					*keys[i] = tkey;
					if (i < values.Length)
					{
						TValue tvalue = *values[num];
						*values[num] = *values[i];
						*values[i] = tvalue;
					}
					num++;
				}
			}
			return num;
		}
	}
}
