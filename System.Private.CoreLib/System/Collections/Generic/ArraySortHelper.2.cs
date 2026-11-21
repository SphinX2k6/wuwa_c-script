using System;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace System.Collections.Generic
{
	// Token: 0x0200099F RID: 2463
	internal sealed class ArraySortHelper<TKey, TValue> : IArraySortHelper<TKey, TValue>
	{
		// Token: 0x170013D2 RID: 5074
		// (get) Token: 0x060091C1 RID: 37313 RVA: 0x00169573 File Offset: 0x00167773
		public static IArraySortHelper<TKey, TValue> Default
		{
			get
			{
				return ArraySortHelper<TKey, TValue>.s_defaultArraySortHelper;
			}
		}

		// Token: 0x060091C2 RID: 37314 RVA: 0x0016957C File Offset: 0x0016777C
		private static IArraySortHelper<TKey, TValue> CreateArraySortHelper()
		{
			IArraySortHelper<TKey, TValue> result;
			if (typeof(IComparable<TKey>).IsAssignableFrom(typeof(TKey)))
			{
				result = (IArraySortHelper<TKey, TValue>)RuntimeType.CreateInstanceForAnotherGenericParameter((RuntimeType)typeof(GenericArraySortHelper<, >), (RuntimeType)typeof(TKey), (RuntimeType)typeof(TValue));
			}
			else
			{
				result = new ArraySortHelper<TKey, TValue>();
			}
			return result;
		}

		// Token: 0x060091C3 RID: 37315 RVA: 0x001695E8 File Offset: 0x001677E8
		public void Sort(Span<TKey> keys, Span<TValue> values, IComparer<TKey> comparer)
		{
			try
			{
				ArraySortHelper<TKey, TValue>.IntrospectiveSort(keys, values, comparer ?? Comparer<TKey>.Default);
			}
			catch (IndexOutOfRangeException)
			{
				ThrowHelper.ThrowArgumentException_BadComparer(comparer);
			}
			catch (Exception e)
			{
				ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_IComparerFailed, e);
			}
		}

		// Token: 0x060091C4 RID: 37316 RVA: 0x00169638 File Offset: 0x00167838
		private unsafe static void SwapIfGreaterWithValues(Span<TKey> keys, Span<TValue> values, IComparer<TKey> comparer, int i, int j)
		{
			if (comparer.Compare(*keys[i], *keys[j]) > 0)
			{
				TKey tkey = *keys[i];
				*keys[i] = *keys[j];
				*keys[j] = tkey;
				TValue tvalue = *values[i];
				*values[i] = *values[j];
				*values[j] = tvalue;
			}
		}

		// Token: 0x060091C5 RID: 37317 RVA: 0x001696DC File Offset: 0x001678DC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe static void Swap(Span<TKey> keys, Span<TValue> values, int i, int j)
		{
			TKey tkey = *keys[i];
			*keys[i] = *keys[j];
			*keys[j] = tkey;
			TValue tvalue = *values[i];
			*values[i] = *values[j];
			*values[j] = tvalue;
		}

		// Token: 0x060091C6 RID: 37318 RVA: 0x00169755 File Offset: 0x00167955
		internal static void IntrospectiveSort(Span<TKey> keys, Span<TValue> values, IComparer<TKey> comparer)
		{
			if (keys.Length > 1)
			{
				ArraySortHelper<TKey, TValue>.IntroSort(keys, values, 2 * (BitOperations.Log2((uint)keys.Length) + 1), comparer);
			}
		}

		// Token: 0x060091C7 RID: 37319 RVA: 0x0016977C File Offset: 0x0016797C
		private static void IntroSort(Span<TKey> keys, Span<TValue> values, int depthLimit, IComparer<TKey> comparer)
		{
			int i = keys.Length;
			while (i > 1)
			{
				if (i <= 16)
				{
					if (i == 2)
					{
						ArraySortHelper<TKey, TValue>.SwapIfGreaterWithValues(keys, values, comparer, 0, 1);
						return;
					}
					if (i == 3)
					{
						ArraySortHelper<TKey, TValue>.SwapIfGreaterWithValues(keys, values, comparer, 0, 1);
						ArraySortHelper<TKey, TValue>.SwapIfGreaterWithValues(keys, values, comparer, 0, 2);
						ArraySortHelper<TKey, TValue>.SwapIfGreaterWithValues(keys, values, comparer, 1, 2);
						return;
					}
					ArraySortHelper<TKey, TValue>.InsertionSort(keys.Slice(0, i), values.Slice(0, i), comparer);
					return;
				}
				else
				{
					if (depthLimit == 0)
					{
						ArraySortHelper<TKey, TValue>.HeapSort(keys.Slice(0, i), values.Slice(0, i), comparer);
						return;
					}
					depthLimit--;
					int num = ArraySortHelper<TKey, TValue>.PickPivotAndPartition(keys.Slice(0, i), values.Slice(0, i), comparer);
					int num2 = num + 1;
					Span<TKey> keys2 = keys.Slice(num2, i - num2);
					num2 = num + 1;
					ArraySortHelper<TKey, TValue>.IntroSort(keys2, values.Slice(num2, i - num2), depthLimit, comparer);
					i = num;
				}
			}
		}

		// Token: 0x060091C8 RID: 37320 RVA: 0x00169850 File Offset: 0x00167A50
		private unsafe static int PickPivotAndPartition(Span<TKey> keys, Span<TValue> values, IComparer<TKey> comparer)
		{
			int num = keys.Length - 1;
			int num2 = num >> 1;
			ArraySortHelper<TKey, TValue>.SwapIfGreaterWithValues(keys, values, comparer, 0, num2);
			ArraySortHelper<TKey, TValue>.SwapIfGreaterWithValues(keys, values, comparer, 0, num);
			ArraySortHelper<TKey, TValue>.SwapIfGreaterWithValues(keys, values, comparer, num2, num);
			TKey tkey = *keys[num2];
			ArraySortHelper<TKey, TValue>.Swap(keys, values, num2, num - 1);
			int i = 0;
			int num3 = num - 1;
			while (i < num3)
			{
				while (comparer.Compare(*keys[++i], tkey) < 0)
				{
				}
				while (comparer.Compare(tkey, *keys[--num3]) < 0)
				{
				}
				if (i >= num3)
				{
					break;
				}
				ArraySortHelper<TKey, TValue>.Swap(keys, values, i, num3);
			}
			if (i != num - 1)
			{
				ArraySortHelper<TKey, TValue>.Swap(keys, values, i, num - 1);
			}
			return i;
		}

		// Token: 0x060091C9 RID: 37321 RVA: 0x0016990C File Offset: 0x00167B0C
		private static void HeapSort(Span<TKey> keys, Span<TValue> values, IComparer<TKey> comparer)
		{
			int length = keys.Length;
			for (int i = length >> 1; i >= 1; i--)
			{
				ArraySortHelper<TKey, TValue>.DownHeap(keys, values, i, length, comparer);
			}
			for (int j = length; j > 1; j--)
			{
				ArraySortHelper<TKey, TValue>.Swap(keys, values, 0, j - 1);
				ArraySortHelper<TKey, TValue>.DownHeap(keys, values, 1, j - 1, comparer);
			}
		}

		// Token: 0x060091CA RID: 37322 RVA: 0x0016995C File Offset: 0x00167B5C
		private unsafe static void DownHeap(Span<TKey> keys, Span<TValue> values, int i, int n, IComparer<TKey> comparer)
		{
			TKey tkey = *keys[i - 1];
			TValue tvalue = *values[i - 1];
			while (i <= n >> 1)
			{
				int num = 2 * i;
				if (num < n && comparer.Compare(*keys[num - 1], *keys[num]) < 0)
				{
					num++;
				}
				if (comparer.Compare(tkey, *keys[num - 1]) >= 0)
				{
					break;
				}
				*keys[i - 1] = *keys[num - 1];
				*values[i - 1] = *values[num - 1];
				i = num;
			}
			*keys[i - 1] = tkey;
			*values[i - 1] = tvalue;
		}

		// Token: 0x060091CB RID: 37323 RVA: 0x00169A44 File Offset: 0x00167C44
		private unsafe static void InsertionSort(Span<TKey> keys, Span<TValue> values, IComparer<TKey> comparer)
		{
			for (int i = 0; i < keys.Length - 1; i++)
			{
				TKey tkey = *keys[i + 1];
				TValue tvalue = *values[i + 1];
				int num = i;
				while (num >= 0 && comparer.Compare(tkey, *keys[num]) < 0)
				{
					*keys[num + 1] = *keys[num];
					*values[num + 1] = *values[num];
					num--;
				}
				*keys[num + 1] = tkey;
				*values[num + 1] = tvalue;
			}
		}

		// Token: 0x04002258 RID: 8792
		private static readonly IArraySortHelper<TKey, TValue> s_defaultArraySortHelper = ArraySortHelper<TKey, TValue>.CreateArraySortHelper();
	}
}
