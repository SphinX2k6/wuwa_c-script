using System;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace System.Collections.Generic
{
	// Token: 0x020009A0 RID: 2464
	internal sealed class GenericArraySortHelper<TKey, TValue> : IArraySortHelper<TKey, TValue> where TKey : IComparable<TKey>
	{
		// Token: 0x060091CE RID: 37326 RVA: 0x00169B14 File Offset: 0x00167D14
		public void Sort(Span<TKey> keys, Span<TValue> values, IComparer<TKey> comparer)
		{
			try
			{
				if (comparer == null || comparer == Comparer<TKey>.Default)
				{
					if (keys.Length > 1)
					{
						if (typeof(TKey) == typeof(double) || typeof(TKey) == typeof(float) || typeof(TKey) == typeof(Half))
						{
							int num = SortUtils.MoveNansToFront<TKey, TValue>(keys, values);
							if (num == keys.Length)
							{
								return;
							}
							keys = keys.Slice(num);
							values = values.Slice(num);
						}
						GenericArraySortHelper<TKey, TValue>.IntroSort(keys, values, 2 * (BitOperations.Log2((uint)keys.Length) + 1));
					}
				}
				else
				{
					ArraySortHelper<TKey, TValue>.IntrospectiveSort(keys, values, comparer);
				}
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

		// Token: 0x060091CF RID: 37327 RVA: 0x00169C08 File Offset: 0x00167E08
		private unsafe static void SwapIfGreaterWithValues(Span<TKey> keys, Span<TValue> values, int i, int j)
		{
			ref TKey ptr = ref keys[i];
			if (ptr != null && GenericArraySortHelper<TKey, TValue>.GreaterThan(ref ptr, keys[j]))
			{
				TKey tkey = ptr;
				*keys[i] = *keys[j];
				*keys[j] = tkey;
				TValue tvalue = *values[i];
				*values[i] = *values[j];
				*values[j] = tvalue;
			}
		}

		// Token: 0x060091D0 RID: 37328 RVA: 0x00169CA0 File Offset: 0x00167EA0
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

		// Token: 0x060091D1 RID: 37329 RVA: 0x00169D1C File Offset: 0x00167F1C
		private static void IntroSort(Span<TKey> keys, Span<TValue> values, int depthLimit)
		{
			int i = keys.Length;
			while (i > 1)
			{
				if (i <= 16)
				{
					if (i == 2)
					{
						GenericArraySortHelper<TKey, TValue>.SwapIfGreaterWithValues(keys, values, 0, 1);
						return;
					}
					if (i == 3)
					{
						GenericArraySortHelper<TKey, TValue>.SwapIfGreaterWithValues(keys, values, 0, 1);
						GenericArraySortHelper<TKey, TValue>.SwapIfGreaterWithValues(keys, values, 0, 2);
						GenericArraySortHelper<TKey, TValue>.SwapIfGreaterWithValues(keys, values, 1, 2);
						return;
					}
					GenericArraySortHelper<TKey, TValue>.InsertionSort(keys.Slice(0, i), values.Slice(0, i));
					return;
				}
				else
				{
					if (depthLimit == 0)
					{
						GenericArraySortHelper<TKey, TValue>.HeapSort(keys.Slice(0, i), values.Slice(0, i));
						return;
					}
					depthLimit--;
					int num = GenericArraySortHelper<TKey, TValue>.PickPivotAndPartition(keys.Slice(0, i), values.Slice(0, i));
					int num2 = num + 1;
					Span<TKey> keys2 = keys.Slice(num2, i - num2);
					num2 = num + 1;
					GenericArraySortHelper<TKey, TValue>.IntroSort(keys2, values.Slice(num2, i - num2), depthLimit);
					i = num;
				}
			}
		}

		// Token: 0x060091D2 RID: 37330 RVA: 0x00169DE8 File Offset: 0x00167FE8
		private unsafe static int PickPivotAndPartition(Span<TKey> keys, Span<TValue> values)
		{
			int num = keys.Length - 1;
			int num2 = num >> 1;
			GenericArraySortHelper<TKey, TValue>.SwapIfGreaterWithValues(keys, values, 0, num2);
			GenericArraySortHelper<TKey, TValue>.SwapIfGreaterWithValues(keys, values, 0, num);
			GenericArraySortHelper<TKey, TValue>.SwapIfGreaterWithValues(keys, values, num2, num);
			TKey tkey = *keys[num2];
			GenericArraySortHelper<TKey, TValue>.Swap(keys, values, num2, num - 1);
			int i = 0;
			int j = num - 1;
			while (i < j)
			{
				if (tkey == null)
				{
					while (i < num - 1 && *keys[++i] == null)
					{
					}
					while (j > 0)
					{
						if (*keys[--j] == null)
						{
							break;
						}
					}
				}
				else
				{
					while (GenericArraySortHelper<TKey, TValue>.GreaterThan(ref tkey, keys[++i]))
					{
					}
					while (GenericArraySortHelper<TKey, TValue>.LessThan(ref tkey, keys[--j]))
					{
					}
				}
				if (i >= j)
				{
					break;
				}
				GenericArraySortHelper<TKey, TValue>.Swap(keys, values, i, j);
			}
			if (i != num - 1)
			{
				GenericArraySortHelper<TKey, TValue>.Swap(keys, values, i, num - 1);
			}
			return i;
		}

		// Token: 0x060091D3 RID: 37331 RVA: 0x00169EE0 File Offset: 0x001680E0
		private static void HeapSort(Span<TKey> keys, Span<TValue> values)
		{
			int length = keys.Length;
			for (int i = length >> 1; i >= 1; i--)
			{
				GenericArraySortHelper<TKey, TValue>.DownHeap(keys, values, i, length);
			}
			for (int j = length; j > 1; j--)
			{
				GenericArraySortHelper<TKey, TValue>.Swap(keys, values, 0, j - 1);
				GenericArraySortHelper<TKey, TValue>.DownHeap(keys, values, 1, j - 1);
			}
		}

		// Token: 0x060091D4 RID: 37332 RVA: 0x00169F30 File Offset: 0x00168130
		private unsafe static void DownHeap(Span<TKey> keys, Span<TValue> values, int i, int n)
		{
			TKey tkey = *keys[i - 1];
			TValue tvalue = *values[i - 1];
			while (i <= n >> 1)
			{
				int num = 2 * i;
				if (num < n && (*keys[num - 1] == null || GenericArraySortHelper<TKey, TValue>.LessThan(keys[num - 1], keys[num])))
				{
					num++;
				}
				if (*keys[num - 1] == null || !GenericArraySortHelper<TKey, TValue>.LessThan(ref tkey, keys[num - 1]))
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

		// Token: 0x060091D5 RID: 37333 RVA: 0x0016A030 File Offset: 0x00168230
		private unsafe static void InsertionSort(Span<TKey> keys, Span<TValue> values)
		{
			for (int i = 0; i < keys.Length - 1; i++)
			{
				TKey tkey = *keys[i + 1];
				TValue tvalue = *values[i + 1];
				int num = i;
				while (num >= 0 && (tkey == null || GenericArraySortHelper<TKey, TValue>.LessThan(ref tkey, keys[num])))
				{
					*keys[num + 1] = *keys[num];
					*values[num + 1] = *values[num];
					num--;
				}
				*keys[num + 1] = tkey;
				*values[num + 1] = tvalue;
			}
		}

		// Token: 0x060091D6 RID: 37334 RVA: 0x0016A0F4 File Offset: 0x001682F4
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool LessThan(ref TKey left, ref TKey right)
		{
			if (typeof(TKey) == typeof(byte))
			{
				return (byte)((object)left) < (byte)((object)right);
			}
			if (typeof(TKey) == typeof(sbyte))
			{
				return (sbyte)((object)left) < (sbyte)((object)right);
			}
			if (typeof(TKey) == typeof(ushort))
			{
				return (ushort)((object)left) < (ushort)((object)right);
			}
			if (typeof(TKey) == typeof(short))
			{
				return (short)((object)left) < (short)((object)right);
			}
			if (typeof(TKey) == typeof(uint))
			{
				return (uint)((object)left) < (uint)((object)right);
			}
			if (typeof(TKey) == typeof(int))
			{
				return (int)((object)left) < (int)((object)right);
			}
			if (typeof(TKey) == typeof(ulong))
			{
				return (ulong)((object)left) < (ulong)((object)right);
			}
			if (typeof(TKey) == typeof(long))
			{
				return (long)((object)left) < (long)((object)right);
			}
			if (typeof(TKey) == typeof(UIntPtr))
			{
				return (UIntPtr)((object)left) < (UIntPtr)((object)right);
			}
			if (typeof(TKey) == typeof(IntPtr))
			{
				return (IntPtr)((object)left) < (IntPtr)((object)right);
			}
			if (typeof(TKey) == typeof(float))
			{
				return (float)((object)left) < (float)((object)right);
			}
			if (typeof(TKey) == typeof(double))
			{
				return (double)((object)left) < (double)((object)right);
			}
			if (typeof(TKey) == typeof(Half))
			{
				return (Half)((object)left) < (Half)((object)right);
			}
			return left.CompareTo(right) < 0;
		}

		// Token: 0x060091D7 RID: 37335 RVA: 0x0016A440 File Offset: 0x00168640
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool GreaterThan(ref TKey left, ref TKey right)
		{
			if (typeof(TKey) == typeof(byte))
			{
				return (byte)((object)left) > (byte)((object)right);
			}
			if (typeof(TKey) == typeof(sbyte))
			{
				return (sbyte)((object)left) > (sbyte)((object)right);
			}
			if (typeof(TKey) == typeof(ushort))
			{
				return (ushort)((object)left) > (ushort)((object)right);
			}
			if (typeof(TKey) == typeof(short))
			{
				return (short)((object)left) > (short)((object)right);
			}
			if (typeof(TKey) == typeof(uint))
			{
				return (uint)((object)left) > (uint)((object)right);
			}
			if (typeof(TKey) == typeof(int))
			{
				return (int)((object)left) > (int)((object)right);
			}
			if (typeof(TKey) == typeof(ulong))
			{
				return (ulong)((object)left) > (ulong)((object)right);
			}
			if (typeof(TKey) == typeof(long))
			{
				return (long)((object)left) > (long)((object)right);
			}
			if (typeof(TKey) == typeof(UIntPtr))
			{
				return (UIntPtr)((object)left) > (UIntPtr)((object)right);
			}
			if (typeof(TKey) == typeof(IntPtr))
			{
				return (IntPtr)((object)left) > (IntPtr)((object)right);
			}
			if (typeof(TKey) == typeof(float))
			{
				return (float)((object)left) > (float)((object)right);
			}
			if (typeof(TKey) == typeof(double))
			{
				return (double)((object)left) > (double)((object)right);
			}
			if (typeof(TKey) == typeof(Half))
			{
				return (Half)((object)left) > (Half)((object)right);
			}
			return left.CompareTo(right) > 0;
		}
	}
}
