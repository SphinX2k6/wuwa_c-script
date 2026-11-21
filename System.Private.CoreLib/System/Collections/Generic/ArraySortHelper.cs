using System;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace System.Collections.Generic
{
	// Token: 0x0200099C RID: 2460
	internal sealed class ArraySortHelper<T> : IArraySortHelper<T>
	{
		// Token: 0x170013D1 RID: 5073
		// (get) Token: 0x060091A3 RID: 37283 RVA: 0x001683E1 File Offset: 0x001665E1
		public static IArraySortHelper<T> Default
		{
			get
			{
				return ArraySortHelper<T>.s_defaultArraySortHelper;
			}
		}

		// Token: 0x060091A4 RID: 37284 RVA: 0x001683E8 File Offset: 0x001665E8
		private static IArraySortHelper<T> CreateArraySortHelper()
		{
			IArraySortHelper<T> result;
			if (typeof(IComparable<T>).IsAssignableFrom(typeof(T)))
			{
				result = (IArraySortHelper<T>)RuntimeType.CreateInstanceForAnotherGenericParameter((RuntimeType)typeof(GenericArraySortHelper<>), (RuntimeType)typeof(T), null);
			}
			else
			{
				result = new ArraySortHelper<T>();
			}
			return result;
		}

		// Token: 0x060091A5 RID: 37285 RVA: 0x00168444 File Offset: 0x00166644
		public void Sort(Span<T> keys, IComparer<T> comparer)
		{
			try
			{
				if (comparer == null)
				{
					comparer = Comparer<T>.Default;
				}
				ArraySortHelper<T>.IntrospectiveSort(keys, new Comparison<T>(comparer.Compare));
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

		// Token: 0x060091A6 RID: 37286 RVA: 0x001684A0 File Offset: 0x001666A0
		public int BinarySearch(T[] array, int index, int length, T value, IComparer<T> comparer)
		{
			int result;
			try
			{
				if (comparer == null)
				{
					comparer = Comparer<T>.Default;
				}
				result = ArraySortHelper<T>.InternalBinarySearch(array, index, length, value, comparer);
			}
			catch (Exception e)
			{
				ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_IComparerFailed, e);
				result = 0;
			}
			return result;
		}

		// Token: 0x060091A7 RID: 37287 RVA: 0x001684E8 File Offset: 0x001666E8
		internal static void Sort(Span<T> keys, Comparison<T> comparer)
		{
			try
			{
				ArraySortHelper<T>.IntrospectiveSort(keys, comparer);
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

		// Token: 0x060091A8 RID: 37288 RVA: 0x00168530 File Offset: 0x00166730
		internal static int InternalBinarySearch(T[] array, int index, int length, T value, IComparer<T> comparer)
		{
			int i = index;
			int num = index + length - 1;
			while (i <= num)
			{
				int num2 = i + (num - i >> 1);
				int num3 = comparer.Compare(array[num2], value);
				if (num3 == 0)
				{
					return num2;
				}
				if (num3 < 0)
				{
					i = num2 + 1;
				}
				else
				{
					num = num2 - 1;
				}
			}
			return ~i;
		}

		// Token: 0x060091A9 RID: 37289 RVA: 0x00168578 File Offset: 0x00166778
		private unsafe static void SwapIfGreater(Span<T> keys, Comparison<T> comparer, int i, int j)
		{
			if (comparer(*keys[i], *keys[j]) > 0)
			{
				T t = *keys[i];
				*keys[i] = *keys[j];
				*keys[j] = t;
			}
		}

		// Token: 0x060091AA RID: 37290 RVA: 0x001685E0 File Offset: 0x001667E0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe static void Swap(Span<T> a, int i, int j)
		{
			T t = *a[i];
			*a[i] = *a[j];
			*a[j] = t;
		}

		// Token: 0x060091AB RID: 37291 RVA: 0x00168623 File Offset: 0x00166823
		internal static void IntrospectiveSort(Span<T> keys, Comparison<T> comparer)
		{
			if (keys.Length > 1)
			{
				ArraySortHelper<T>.IntroSort(keys, 2 * (BitOperations.Log2((uint)keys.Length) + 1), comparer);
			}
		}

		// Token: 0x060091AC RID: 37292 RVA: 0x00168648 File Offset: 0x00166848
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void IntroSort(Span<T> keys, int depthLimit, Comparison<T> comparer)
		{
			int i = keys.Length;
			while (i > 1)
			{
				if (i <= 16)
				{
					if (i == 2)
					{
						ArraySortHelper<T>.SwapIfGreater(keys, comparer, 0, 1);
						return;
					}
					if (i == 3)
					{
						ArraySortHelper<T>.SwapIfGreater(keys, comparer, 0, 1);
						ArraySortHelper<T>.SwapIfGreater(keys, comparer, 0, 2);
						ArraySortHelper<T>.SwapIfGreater(keys, comparer, 1, 2);
						return;
					}
					ArraySortHelper<T>.InsertionSort(keys.Slice(0, i), comparer);
					return;
				}
				else
				{
					if (depthLimit == 0)
					{
						ArraySortHelper<T>.HeapSort(keys.Slice(0, i), comparer);
						return;
					}
					depthLimit--;
					int num = ArraySortHelper<T>.PickPivotAndPartition(keys.Slice(0, i), comparer);
					int num2 = num + 1;
					ArraySortHelper<T>.IntroSort(keys.Slice(num2, i - num2), depthLimit, comparer);
					i = num;
				}
			}
		}

		// Token: 0x060091AD RID: 37293 RVA: 0x001686EC File Offset: 0x001668EC
		private unsafe static int PickPivotAndPartition(Span<T> keys, Comparison<T> comparer)
		{
			int num = keys.Length - 1;
			int num2 = num >> 1;
			ArraySortHelper<T>.SwapIfGreater(keys, comparer, 0, num2);
			ArraySortHelper<T>.SwapIfGreater(keys, comparer, 0, num);
			ArraySortHelper<T>.SwapIfGreater(keys, comparer, num2, num);
			T t = *keys[num2];
			ArraySortHelper<T>.Swap(keys, num2, num - 1);
			int i = 0;
			int num3 = num - 1;
			while (i < num3)
			{
				while (comparer(*keys[++i], t) < 0)
				{
				}
				while (comparer(t, *keys[--num3]) < 0)
				{
				}
				if (i >= num3)
				{
					break;
				}
				ArraySortHelper<T>.Swap(keys, i, num3);
			}
			if (i != num - 1)
			{
				ArraySortHelper<T>.Swap(keys, i, num - 1);
			}
			return i;
		}

		// Token: 0x060091AE RID: 37294 RVA: 0x001687A0 File Offset: 0x001669A0
		private static void HeapSort(Span<T> keys, Comparison<T> comparer)
		{
			int length = keys.Length;
			for (int i = length >> 1; i >= 1; i--)
			{
				ArraySortHelper<T>.DownHeap(keys, i, length, comparer);
			}
			for (int j = length; j > 1; j--)
			{
				ArraySortHelper<T>.Swap(keys, 0, j - 1);
				ArraySortHelper<T>.DownHeap(keys, 1, j - 1, comparer);
			}
		}

		// Token: 0x060091AF RID: 37295 RVA: 0x001687F0 File Offset: 0x001669F0
		private unsafe static void DownHeap(Span<T> keys, int i, int n, Comparison<T> comparer)
		{
			T t = *keys[i - 1];
			while (i <= n >> 1)
			{
				int num = 2 * i;
				if (num < n && comparer(*keys[num - 1], *keys[num]) < 0)
				{
					num++;
				}
				if (comparer(t, *keys[num - 1]) >= 0)
				{
					break;
				}
				*keys[i - 1] = *keys[num - 1];
				i = num;
			}
			*keys[i - 1] = t;
		}

		// Token: 0x060091B0 RID: 37296 RVA: 0x00168890 File Offset: 0x00166A90
		private unsafe static void InsertionSort(Span<T> keys, Comparison<T> comparer)
		{
			for (int i = 0; i < keys.Length - 1; i++)
			{
				T t = *keys[i + 1];
				int num = i;
				while (num >= 0 && comparer(t, *keys[num]) < 0)
				{
					*keys[num + 1] = *keys[num];
					num--;
				}
				*keys[num + 1] = t;
			}
		}

		// Token: 0x04002257 RID: 8791
		private static readonly IArraySortHelper<T> s_defaultArraySortHelper = ArraySortHelper<T>.CreateArraySortHelper();
	}
}
