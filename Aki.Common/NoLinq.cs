using System;
using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Token: 0x0200000F RID: 15
[NullableContext(1)]
[Nullable(0)]
public static class NoLinq
{
	// Token: 0x0600009A RID: 154 RVA: 0x000046DC File Offset: 0x000028DC
	public static IEnumerable<T> Where<[Nullable(2)] T>(IEnumerable<T> source, Func<T, bool> predicate)
	{
		ArgumentNullException.ThrowIfNull(source, "source");
		ArgumentNullException.ThrowIfNull(predicate, "predicate");
		NoLinq.FilteredIterator<T> filteredIterator = source as NoLinq.FilteredIterator<T>;
		if (filteredIterator != null)
		{
			return filteredIterator.Where(predicate);
		}
		T[] array = source as T[];
		if (array != null)
		{
			return new NoLinq.ArrayWhereIterator<T>(array, predicate);
		}
		List<T> list = source as List<T>;
		if (list != null)
		{
			return new NoLinq.ListWhereIterator<T>(list, predicate);
		}
		return new NoLinq.EnumerableWhereIterator<T>(source, predicate);
	}

	// Token: 0x0600009B RID: 155 RVA: 0x0000473C File Offset: 0x0000293C
	public static IEnumerable<TOut> Select<[Nullable(2)] TIn, [Nullable(2)] TOut>(IEnumerable<TIn> source, Func<TIn, TOut> selector)
	{
		ArgumentNullException.ThrowIfNull(source, "source");
		ArgumentNullException.ThrowIfNull(selector, "selector");
		NoLinq.DeferredIterator<TIn> deferredIterator = source as NoLinq.DeferredIterator<TIn>;
		if (deferredIterator != null)
		{
			return deferredIterator.Select<TOut>(selector);
		}
		TIn[] array = source as TIn[];
		if (array != null)
		{
			return new NoLinq.ArraySelectIterator<TIn, TOut>(array, selector);
		}
		List<TIn> list = source as List<TIn>;
		if (list != null)
		{
			return new NoLinq.ListSelectIterator<TIn, TOut>(list, selector);
		}
		IList<TIn> list2 = source as IList<TIn>;
		if (list2 != null)
		{
			return new NoLinq.IListSelectIterator<TIn, TOut>(list2, selector);
		}
		return new NoLinq.EnumerableSelectIterator<TIn, TOut>(source, selector);
	}

	// Token: 0x0600009C RID: 156 RVA: 0x000047B0 File Offset: 0x000029B0
	private unsafe static T TryGetFirstWhere<[Nullable(2)] T>([Nullable(new byte[]
	{
		0,
		1
	})] ReadOnlySpan<T> source, Func<T, bool> predicate, out bool found)
	{
		ReadOnlySpan<T> readOnlySpan = source;
		for (int i = 0; i < readOnlySpan.Length; i++)
		{
			T t = *readOnlySpan[i];
			if (predicate(t))
			{
				found = true;
				return t;
			}
		}
		found = false;
		return default(T);
	}

	// Token: 0x0600009D RID: 157 RVA: 0x000047FC File Offset: 0x000029FC
	public static IEnumerable<TOut> Select<[Nullable(2)] TIn, [Nullable(2)] TOut>(IEnumerable<TIn> source, Func<TIn, int, TOut> selector)
	{
		ArgumentNullException.ThrowIfNull(source, "source");
		ArgumentNullException.ThrowIfNull(selector, "selector");
		TIn[] array = source as TIn[];
		if (array != null)
		{
			return NoLinq.SelectIndexedArrayIterator<TIn, TOut>(array, selector);
		}
		List<TIn> list = source as List<TIn>;
		if (list != null)
		{
			return NoLinq.SelectIndexedListIterator<TIn, TOut>(list, selector);
		}
		return NoLinq.SelectIndexedIterator<TIn, TOut>(source, selector);
	}

	// Token: 0x0600009E RID: 158 RVA: 0x0000484A File Offset: 0x00002A4A
	private static IEnumerable<TOut> SelectIndexedArrayIterator<[Nullable(2)] TIn, [Nullable(2)] TOut>(TIn[] source, Func<TIn, int, TOut> selector)
	{
		NoLinq.<SelectIndexedArrayIterator>d__15<TIn, TOut> <SelectIndexedArrayIterator>d__ = new NoLinq.<SelectIndexedArrayIterator>d__15<TIn, TOut>(-2);
		<SelectIndexedArrayIterator>d__.<>3__source = source;
		<SelectIndexedArrayIterator>d__.<>3__selector = selector;
		return <SelectIndexedArrayIterator>d__;
	}

	// Token: 0x0600009F RID: 159 RVA: 0x00004861 File Offset: 0x00002A61
	private static IEnumerable<TOut> SelectIndexedListIterator<[Nullable(2)] TIn, [Nullable(2)] TOut>(List<TIn> source, Func<TIn, int, TOut> selector)
	{
		NoLinq.<SelectIndexedListIterator>d__16<TIn, TOut> <SelectIndexedListIterator>d__ = new NoLinq.<SelectIndexedListIterator>d__16<TIn, TOut>(-2);
		<SelectIndexedListIterator>d__.<>3__source = source;
		<SelectIndexedListIterator>d__.<>3__selector = selector;
		return <SelectIndexedListIterator>d__;
	}

	// Token: 0x060000A0 RID: 160 RVA: 0x00004878 File Offset: 0x00002A78
	private static IEnumerable<TOut> SelectIndexedIterator<[Nullable(2)] TIn, [Nullable(2)] TOut>(IEnumerable<TIn> source, Func<TIn, int, TOut> selector)
	{
		NoLinq.<SelectIndexedIterator>d__17<TIn, TOut> <SelectIndexedIterator>d__ = new NoLinq.<SelectIndexedIterator>d__17<TIn, TOut>(-2);
		<SelectIndexedIterator>d__.<>3__source = source;
		<SelectIndexedIterator>d__.<>3__selector = selector;
		return <SelectIndexedIterator>d__;
	}

	// Token: 0x060000A1 RID: 161 RVA: 0x0000488F File Offset: 0x00002A8F
	public static IEnumerable<T> OfType<[Nullable(2)] T>(IEnumerable source)
	{
		ArgumentNullException.ThrowIfNull(source, "source");
		return NoLinq.OfTypeIterator<T>(source);
	}

	// Token: 0x060000A2 RID: 162 RVA: 0x000048A2 File Offset: 0x00002AA2
	private static IEnumerable<T> OfTypeIterator<[Nullable(2)] T>(IEnumerable source)
	{
		NoLinq.<OfTypeIterator>d__19<T> <OfTypeIterator>d__ = new NoLinq.<OfTypeIterator>d__19<T>(-2);
		<OfTypeIterator>d__.<>3__source = source;
		return <OfTypeIterator>d__;
	}

	// Token: 0x060000A3 RID: 163 RVA: 0x000048B4 File Offset: 0x00002AB4
	public static List<T> DistinctToList<[Nullable(2)] T>(IEnumerable<T> source)
	{
		ArgumentNullException.ThrowIfNull(source, "source");
		HashSet<T> hashSet = new HashSet<T>();
		List<T> list = new List<T>();
		foreach (T item in source)
		{
			if (hashSet.Add(item))
			{
				list.Add(item);
			}
		}
		return list;
	}

	// Token: 0x060000A4 RID: 164 RVA: 0x00004920 File Offset: 0x00002B20
	public static IEnumerable<T> Distinct<[Nullable(2)] T>(IEnumerable<T> source)
	{
		ArgumentNullException.ThrowIfNull(source, "source");
		return new NoLinq.DistinctQuery<T>(source);
	}

	// Token: 0x060000A5 RID: 165 RVA: 0x00004934 File Offset: 0x00002B34
	public static bool SequenceEqual<[Nullable(2)] T>(IEnumerable<T> first, IEnumerable<T> second)
	{
		ArgumentNullException.ThrowIfNull(first, "first");
		ArgumentNullException.ThrowIfNull(second, "second");
		EqualityComparer<T> @default = EqualityComparer<T>.Default;
		ReadOnlySpan<T> span;
		ReadOnlySpan<T> other;
		if (NoLinq.TryGetSpan<T>(first, out span) && NoLinq.TryGetSpan<T>(second, out other))
		{
			return span.SequenceEqual(other, @default);
		}
		ICollection<T> collection = first as ICollection<T>;
		if (collection != null)
		{
			ICollection<T> collection2 = second as ICollection<T>;
			if (collection2 != null && collection.Count != collection2.Count)
			{
				return false;
			}
		}
		IList<T> list = first as IList<T>;
		if (list != null)
		{
			IList<T> list2 = second as IList<T>;
			if (list2 != null)
			{
				int count = list.Count;
				if (count != list2.Count)
				{
					return false;
				}
				for (int i = 0; i < count; i++)
				{
					if (!@default.Equals(list[i], list2[i]))
					{
						return false;
					}
				}
				return true;
			}
		}
		bool result;
		using (IEnumerator<T> enumerator = first.GetEnumerator())
		{
			using (IEnumerator<T> enumerator2 = second.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (!enumerator2.MoveNext() || !@default.Equals(enumerator.Current, enumerator2.Current))
					{
						return false;
					}
				}
				result = !enumerator2.MoveNext();
			}
		}
		return result;
	}

	// Token: 0x060000A6 RID: 166 RVA: 0x00004A84 File Offset: 0x00002C84
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static bool TryGetSpan<[Nullable(2)] T>(IEnumerable<T> source, [Nullable(new byte[]
	{
		0,
		1
	})] out ReadOnlySpan<T> span)
	{
		if (source.GetType() == typeof(T[]))
		{
			span = Unsafe.As<T[]>(source);
		}
		else
		{
			if (!(source.GetType() == typeof(List<T>)))
			{
				span = default(ReadOnlySpan<T>);
				return false;
			}
			span = CollectionsMarshal.AsSpan<T>(Unsafe.As<List<T>>(source));
		}
		return true;
	}

	// Token: 0x060000A7 RID: 167 RVA: 0x00004AF4 File Offset: 0x00002CF4
	public static T LastOrDefault<[Nullable(2)] T>(IEnumerable<T> source, Func<T, bool> predicate)
	{
		ArgumentNullException.ThrowIfNull(source, "source");
		ArgumentNullException.ThrowIfNull(predicate, "predicate");
		IList<T> list = source as IList<T>;
		if (list != null)
		{
			for (int i = list.Count - 1; i >= 0; i--)
			{
				T t = list[i];
				if (predicate(t))
				{
					return t;
				}
			}
			return default(T);
		}
		T result = default(T);
		foreach (T t2 in source)
		{
			if (predicate(t2))
			{
				result = t2;
			}
		}
		return result;
	}

	// Token: 0x060000A8 RID: 168 RVA: 0x00004BA4 File Offset: 0x00002DA4
	public static T Single<[Nullable(2)] T>(IEnumerable<T> source)
	{
		ArgumentNullException.ThrowIfNull(source, "source");
		IList<T> list = source as IList<T>;
		if (list == null)
		{
			T result;
			using (IEnumerator<T> enumerator = source.GetEnumerator())
			{
				if (!enumerator.MoveNext())
				{
					throw new InvalidOperationException("Sequence contains no elements");
				}
				T t = enumerator.Current;
				if (enumerator.MoveNext())
				{
					throw new InvalidOperationException("Sequence contains more than one element");
				}
				result = t;
			}
			return result;
		}
		if (list.Count == 1)
		{
			return list[0];
		}
		throw new InvalidOperationException((list.Count == 0) ? "Sequence contains no elements" : "Sequence contains more than one element");
	}

	// Token: 0x060000A9 RID: 169 RVA: 0x00004C44 File Offset: 0x00002E44
	public static int Sum(IEnumerable<int> source)
	{
		ArgumentNullException.ThrowIfNull(source, "source");
		ReadOnlySpan<int> source2;
		if (NoLinq.TryGetSpan<int>(source, out source2))
		{
			return NoLinq.SumSpan(source2);
		}
		int num = 0;
		checked
		{
			foreach (int num2 in source)
			{
				num += num2;
			}
			return num;
		}
	}

	// Token: 0x060000AA RID: 170 RVA: 0x00004CA8 File Offset: 0x00002EA8
	[NullableContext(0)]
	private static int SumSpan(ReadOnlySpan<int> source)
	{
		if (!Vector.IsHardwareAccelerated || Vector<int>.Count <= 2 || source.Length < Vector<int>.Count * 4)
		{
			return NoLinq.SumChecked(source);
		}
		return NoLinq.SumVectorized(source);
	}

	// Token: 0x060000AB RID: 171 RVA: 0x00004CD8 File Offset: 0x00002ED8
	[NullableContext(0)]
	private unsafe static int SumVectorized(ReadOnlySpan<int> source)
	{
		ref int reference = ref MemoryMarshal.GetReference<int>(source);
		UIntPtr uintPtr = (UIntPtr)((IntPtr)Vector<int>.Count);
		UIntPtr uintPtr2 = (UIntPtr)((IntPtr)source.Length);
		Vector<int> vector = Vector<int>.Zero;
		Vector<int> right = new Vector<int>(int.MinValue);
		UIntPtr uintPtr3 = (UIntPtr)((IntPtr)0);
		UIntPtr uintPtr4 = uintPtr2 - uintPtr * (UIntPtr)((IntPtr)4);
		for (;;)
		{
			Vector<int> right2 = Vector.LoadUnsafe<int>(ref reference, uintPtr3);
			Vector<int> vector2 = vector + right2;
			Vector<int> left = (vector2 ^ vector) & (vector2 ^ right2);
			right2 = Vector.LoadUnsafe<int>(ref reference, uintPtr3 + uintPtr);
			vector = vector2 + right2;
			Vector<int> left2 = left | ((vector ^ vector2) & (vector ^ right2));
			right2 = Vector.LoadUnsafe<int>(ref reference, uintPtr3 + uintPtr * (UIntPtr)((IntPtr)2));
			vector2 = vector + right2;
			Vector<int> left3 = left2 | ((vector2 ^ vector) & (vector2 ^ right2));
			right2 = Vector.LoadUnsafe<int>(ref reference, uintPtr3 + uintPtr * (UIntPtr)((IntPtr)3));
			vector = vector2 + right2;
			if (((left3 | ((vector ^ vector2) & (vector ^ right2))) & right) != Vector<int>.Zero)
			{
				break;
			}
			uintPtr3 += uintPtr * (UIntPtr)((IntPtr)4);
			if (uintPtr3 >= uintPtr4)
			{
				goto Block_2;
			}
		}
		throw new OverflowException();
		Block_2:
		uintPtr4 = uintPtr2 - uintPtr;
		if (uintPtr3 < uintPtr4)
		{
			Vector<int> left4 = Vector<int>.Zero;
			do
			{
				Vector<int> right3 = Vector.LoadUnsafe<int>(ref reference, uintPtr3);
				Vector<int> vector3 = vector + right3;
				left4 |= ((vector3 ^ vector) & (vector3 ^ right3));
				vector = vector3;
				uintPtr3 += uintPtr;
			}
			while (uintPtr3 < uintPtr4);
			if ((left4 & right) != Vector<int>.Zero)
			{
				throw new OverflowException();
			}
		}
		int num = 0;
		for (int i = 0; i < Vector<int>.Count; i++)
		{
			checked
			{
				num += vector[i];
			}
		}
		while (uintPtr3 < uintPtr2)
		{
			checked
			{
				num += *Unsafe.Add<int>(ref reference, uintPtr3);
			}
			uintPtr3++;
		}
		return num;
	}

	// Token: 0x060000AC RID: 172 RVA: 0x00004EB8 File Offset: 0x000030B8
	[NullableContext(0)]
	private unsafe static int SumChecked(ReadOnlySpan<int> source)
	{
		int num = 0;
		ReadOnlySpan<int> readOnlySpan = source;
		for (int i = 0; i < readOnlySpan.Length; i++)
		{
			int num2 = *readOnlySpan[i];
			checked
			{
				num += num2;
			}
		}
		return num;
	}

	// Token: 0x060000AD RID: 173 RVA: 0x00004EEC File Offset: 0x000030EC
	public static int Sum<[Nullable(2)] T>(IEnumerable<T> source, Func<T, int> selector)
	{
		ArgumentNullException.ThrowIfNull(source, "source");
		ArgumentNullException.ThrowIfNull(selector, "selector");
		int num = 0;
		T[] array = source as T[];
		checked
		{
			if (array != null)
			{
				foreach (T arg in array)
				{
					num += selector(arg);
				}
			}
			else
			{
				List<T> list = source as List<T>;
				if (list != null)
				{
					using (List<T>.Enumerator enumerator = list.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							T arg2 = enumerator.Current;
							num += selector(arg2);
						}
						return num;
					}
				}
				foreach (T arg3 in source)
				{
					num += selector(arg3);
				}
			}
			return num;
		}
	}

	// Token: 0x060000AE RID: 174 RVA: 0x00004FD8 File Offset: 0x000031D8
	public static long Sum<[Nullable(2)] T>(IEnumerable<T> source, Func<T, long> selector)
	{
		ArgumentNullException.ThrowIfNull(source, "source");
		ArgumentNullException.ThrowIfNull(selector, "selector");
		long num = 0L;
		T[] array = source as T[];
		checked
		{
			if (array != null)
			{
				foreach (T arg in array)
				{
					num += selector(arg);
				}
			}
			else
			{
				List<T> list = source as List<T>;
				if (list != null)
				{
					using (List<T>.Enumerator enumerator = list.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							T arg2 = enumerator.Current;
							num += selector(arg2);
						}
						return num;
					}
				}
				foreach (T arg3 in source)
				{
					num += selector(arg3);
				}
			}
			return num;
		}
	}

	// Token: 0x060000AF RID: 175 RVA: 0x000050C4 File Offset: 0x000032C4
	public static int Max(IEnumerable<int> source)
	{
		return NoLinq.Max<int>(source, (int value) => value);
	}

	// Token: 0x060000B0 RID: 176 RVA: 0x000050EC File Offset: 0x000032EC
	public static int Max<[Nullable(2)] T>(IEnumerable<T> source, Func<T, int> selector)
	{
		ArgumentNullException.ThrowIfNull(source, "source");
		ArgumentNullException.ThrowIfNull(selector, "selector");
		int result;
		using (IEnumerator<T> enumerator = source.GetEnumerator())
		{
			if (!enumerator.MoveNext())
			{
				throw new InvalidOperationException("Sequence contains no elements");
			}
			int num = selector(enumerator.Current);
			while (enumerator.MoveNext())
			{
				T arg = enumerator.Current;
				num = Math.Max(num, selector(arg));
			}
			result = num;
		}
		return result;
	}

	// Token: 0x060000B1 RID: 177 RVA: 0x00005174 File Offset: 0x00003374
	public static List<T> TakeToList<[Nullable(2)] T>(IEnumerable<T> source, int count)
	{
		return NoLinq.SkipTakeToList<T>(source, 0, count);
	}

	// Token: 0x060000B2 RID: 178 RVA: 0x00005180 File Offset: 0x00003380
	public static T[] ConcatToArray<[Nullable(2)] T>(IEnumerable<T> first, IEnumerable<T> second)
	{
		ArgumentNullException.ThrowIfNull(first, "first");
		ArgumentNullException.ThrowIfNull(second, "second");
		ICollection<T> collection = first as ICollection<T>;
		if (collection != null)
		{
			ICollection<T> collection2 = second as ICollection<T>;
			if (collection2 != null)
			{
				int count = collection.Count;
				int num = checked(count + collection2.Count);
				if (num == 0)
				{
					return Array.Empty<T>();
				}
				T[] array = new T[num];
				collection.CopyTo(array, 0);
				collection2.CopyTo(array, count);
				return array;
			}
		}
		NoLinq.ScratchBuffer<T> scratchBuffer = default(NoLinq.ScratchBuffer<T>);
		T[] array3;
		using (NoLinq.PooledArrayBuilder<T> pooledArrayBuilder = new NoLinq.PooledArrayBuilder<T>(<PrivateImplementationDetails>.InlineArrayAsSpan<NoLinq.ScratchBuffer<T>, T>(ref scratchBuffer, 8)))
		{
			T[] array2 = first as T[];
			if (array2 != null)
			{
				foreach (T item in array2)
				{
					pooledArrayBuilder.Add(item);
				}
			}
			else
			{
				List<T> list = first as List<T>;
				if (list != null)
				{
					using (List<T>.Enumerator enumerator = list.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							T item2 = enumerator.Current;
							pooledArrayBuilder.Add(item2);
						}
						goto IL_12B;
					}
				}
				foreach (T item3 in first)
				{
					pooledArrayBuilder.Add(item3);
				}
			}
			IL_12B:
			T[] array4 = second as T[];
			if (array4 != null)
			{
				foreach (T item4 in array4)
				{
					pooledArrayBuilder.Add(item4);
				}
			}
			else
			{
				List<T> list2 = second as List<T>;
				if (list2 != null)
				{
					using (List<T>.Enumerator enumerator = list2.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							T item5 = enumerator.Current;
							pooledArrayBuilder.Add(item5);
						}
						goto IL_1D9;
					}
				}
				foreach (T item6 in second)
				{
					pooledArrayBuilder.Add(item6);
				}
			}
			IL_1D9:
			array3 = pooledArrayBuilder.ToArray();
		}
		return array3;
	}

	// Token: 0x060000B3 RID: 179 RVA: 0x000053F8 File Offset: 0x000035F8
	public static HashSet<T> ToHashSet<[Nullable(2)] T>(IEnumerable<T> source)
	{
		return new HashSet<T>(source);
	}

	// Token: 0x060000B4 RID: 180 RVA: 0x00005400 File Offset: 0x00003600
	public static Dictionary<TKey, TValue> ToDictionary<TKey, [Nullable(2)] TValue>([Nullable(new byte[]
	{
		1,
		0,
		1,
		1
	})] IEnumerable<KeyValuePair<TKey, TValue>> source)
	{
		ArgumentNullException.ThrowIfNull(source, "source");
		Dictionary<TKey, TValue> dictionary = new Dictionary<TKey, TValue>(NoLinq.GetCountOrZero<KeyValuePair<TKey, TValue>>(source));
		foreach (KeyValuePair<TKey, TValue> keyValuePair in source)
		{
			dictionary.Add(keyValuePair.Key, keyValuePair.Value);
		}
		return dictionary;
	}

	// Token: 0x060000B5 RID: 181 RVA: 0x00005470 File Offset: 0x00003670
	public static IEnumerable<NoLinq.Group<TKey, T>> GroupBy<[Nullable(2)] T, [Nullable(2)] TKey>(IEnumerable<T> source, Func<T, TKey> keySelector)
	{
		ArgumentNullException.ThrowIfNull(source, "source");
		ArgumentNullException.ThrowIfNull(keySelector, "keySelector");
		return NoLinq.GroupByIterator<T, TKey>(source, keySelector);
	}

	// Token: 0x060000B6 RID: 182 RVA: 0x0000548F File Offset: 0x0000368F
	private static IEnumerable<NoLinq.Group<TKey, T>> GroupByIterator<[Nullable(2)] T, [Nullable(2)] TKey>(IEnumerable<T> source, Func<T, TKey> keySelector)
	{
		NoLinq.<GroupByIterator>d__40<T, TKey> <GroupByIterator>d__ = new NoLinq.<GroupByIterator>d__40<T, TKey>(-2);
		<GroupByIterator>d__.<>3__source = source;
		<GroupByIterator>d__.<>3__keySelector = keySelector;
		return <GroupByIterator>d__;
	}

	// Token: 0x060000B7 RID: 183 RVA: 0x000054A8 File Offset: 0x000036A8
	private static NoLinq.GroupLookup<TKey, T> BuildGroups<[Nullable(2)] T, [Nullable(2)] TKey>(IEnumerable<T> source, Func<T, TKey> keySelector)
	{
		NoLinq.GroupLookup<TKey, T> groupLookup = new NoLinq.GroupLookup<TKey, T>();
		T[] array = source as T[];
		if (array != null)
		{
			foreach (T t in array)
			{
				groupLookup.Add(keySelector(t), t);
			}
		}
		else
		{
			if (source.GetType() == typeof(List<T>))
			{
				using (List<T>.Enumerator enumerator = ((List<T>)source).GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						T t2 = enumerator.Current;
						groupLookup.Add(keySelector(t2), t2);
					}
					return groupLookup;
				}
			}
			foreach (T t3 in source)
			{
				groupLookup.Add(keySelector(t3), t3);
			}
		}
		return groupLookup;
	}

	// Token: 0x060000B8 RID: 184 RVA: 0x000055A4 File Offset: 0x000037A4
	public static Dictionary<TKey, List<T>> GroupByToDictionary<[Nullable(2)] T, TKey>(IEnumerable<T> source, Func<T, TKey> keySelector)
	{
		ArgumentNullException.ThrowIfNull(source, "source");
		ArgumentNullException.ThrowIfNull(keySelector, "keySelector");
		Dictionary<TKey, List<T>> dictionary = new Dictionary<TKey, List<T>>();
		T[] array = source as T[];
		if (array != null)
		{
			foreach (T t in array)
			{
				TKey key = keySelector(t);
				List<T> list;
				if (!dictionary.TryGetValue(key, out list))
				{
					list = new List<T>();
					dictionary.Add(key, list);
				}
				list.Add(t);
			}
		}
		else
		{
			List<T> list2 = source as List<T>;
			if (list2 != null)
			{
				using (List<T>.Enumerator enumerator = list2.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						T t2 = enumerator.Current;
						TKey key2 = keySelector(t2);
						List<T> list3;
						if (!dictionary.TryGetValue(key2, out list3))
						{
							list3 = new List<T>();
							dictionary.Add(key2, list3);
						}
						list3.Add(t2);
					}
					return dictionary;
				}
			}
			foreach (T t3 in source)
			{
				TKey key3 = keySelector(t3);
				List<T> list4;
				if (!dictionary.TryGetValue(key3, out list4))
				{
					list4 = new List<T>();
					dictionary.Add(key3, list4);
				}
				list4.Add(t3);
			}
		}
		return dictionary;
	}

	// Token: 0x060000B9 RID: 185 RVA: 0x00005708 File Offset: 0x00003908
	public static List<TOut> SelectManyToList<[Nullable(2)] TIn, [Nullable(2)] TOut>(IEnumerable<TIn> source, Func<TIn, IEnumerable<TOut>> selector)
	{
		ArgumentNullException.ThrowIfNull(source, "source");
		ArgumentNullException.ThrowIfNull(selector, "selector");
		List<TOut> list = new List<TOut>();
		foreach (TIn arg in source)
		{
			list.AddRange(selector(arg));
		}
		return list;
	}

	// Token: 0x060000BA RID: 186 RVA: 0x00005774 File Offset: 0x00003974
	public static List<T> OrderByThenByThenByToList<[Nullable(2)] T, [Nullable(2)] TKey1, [Nullable(2)] TKey2, [Nullable(2)] TKey3>(IEnumerable<T> source, Func<T, TKey1> key1, Func<T, TKey2> key2, Func<T, TKey3> key3)
	{
		return NoLinq.OrderByThenByThenByToList<T, TKey1, TKey2, TKey3>(source, key1, key2, key3, false);
	}

	// Token: 0x060000BB RID: 187 RVA: 0x00005780 File Offset: 0x00003980
	public static List<T> OrderByDescendingThenByThenByToList<[Nullable(2)] T, [Nullable(2)] TKey1, [Nullable(2)] TKey2, [Nullable(2)] TKey3>(IEnumerable<T> source, Func<T, TKey1> key1, Func<T, TKey2> key2, Func<T, TKey3> key3)
	{
		return NoLinq.OrderByThenByThenByToList<T, TKey1, TKey2, TKey3>(source, key1, key2, key3, true);
	}

	// Token: 0x060000BC RID: 188 RVA: 0x0000578C File Offset: 0x0000398C
	private static List<T> OrderByThenByThenByToList<[Nullable(2)] T, [Nullable(2)] TKey1, [Nullable(2)] TKey2, [Nullable(2)] TKey3>(IEnumerable<T> source, Func<T, TKey1> key1, Func<T, TKey2> key2, Func<T, TKey3> key3, bool descending)
	{
		T[] array;
		int[] sortedOrder = NoLinq.GetSortedOrder<T, TKey1, TKey2, TKey3>(source, key1, key2, key3, descending, out array, true);
		List<T> list = new List<T>(array.Length);
		foreach (int num in sortedOrder)
		{
			list.Add(array[num]);
		}
		return list;
	}

	// Token: 0x060000BD RID: 189 RVA: 0x000057D4 File Offset: 0x000039D4
	private static int[] GetSortedOrder<[Nullable(2)] T, [Nullable(2)] TKey1, [Nullable(2)] TKey2, [Nullable(2)] TKey3>(IEnumerable<T> source, Func<T, TKey1> key1, Func<T, TKey2> key2, Func<T, TKey3> key3, bool descending, out T[] items, bool directMaterialization = true)
	{
		ArgumentNullException.ThrowIfNull(source, "source");
		ArgumentNullException.ThrowIfNull(key1, "key1");
		ArgumentNullException.ThrowIfNull(key2, "key2");
		ArgumentNullException.ThrowIfNull(key3, "key3");
		items = NoLinq.ToArray<T>(source);
		if (items.Length == 0)
		{
			return Array.Empty<int>();
		}
		if (directMaterialization && items.Length == 1)
		{
			return new int[1];
		}
		TKey1[] keys = NoLinq.SelectToArray<T, TKey1>(items, key1);
		TKey2[] keys2 = NoLinq.SelectToArray<T, TKey2>(items, key2);
		TKey3[] keys3 = NoLinq.SelectToArray<T, TKey3>(items, key3);
		int[] array = new int[items.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = i;
		}
		array.AsSpan<int>().Sort(new NoLinq.ThreeKeyComparer<TKey1, TKey2, TKey3>(keys, keys2, keys3, descending));
		return array;
	}

	// Token: 0x060000BE RID: 190 RVA: 0x0000588C File Offset: 0x00003A8C
	public static List<T> OrderByDescendingThenByThenByThenByToList<[Nullable(2)] T, [Nullable(2)] TKey1, [Nullable(2)] TKey2, [Nullable(2)] TKey3, [Nullable(2)] TKey4>(IEnumerable<T> source, Func<T, TKey1> key1, Func<T, TKey2> key2, Func<T, TKey3> key3, Func<T, TKey4> key4)
	{
		ArgumentNullException.ThrowIfNull(source, "source");
		ArgumentNullException.ThrowIfNull(key1, "key1");
		ArgumentNullException.ThrowIfNull(key2, "key2");
		ArgumentNullException.ThrowIfNull(key3, "key3");
		ArgumentNullException.ThrowIfNull(key4, "key4");
		T[] array = NoLinq.ToArray<T>(source);
		if (array.Length == 0)
		{
			return new List<T>();
		}
		if (array.Length == 1)
		{
			return new List<T>
			{
				array[0]
			};
		}
		TKey1[] keys = NoLinq.SelectToArray<T, TKey1>(array, key1);
		TKey2[] keys2 = NoLinq.SelectToArray<T, TKey2>(array, key2);
		TKey3[] keys3 = NoLinq.SelectToArray<T, TKey3>(array, key3);
		TKey4[] keys4 = NoLinq.SelectToArray<T, TKey4>(array, key4);
		int[] array2 = new int[array.Length];
		for (int i = 0; i < array2.Length; i++)
		{
			array2[i] = i;
		}
		array2.AsSpan<int>().Sort(new NoLinq.FourKeyComparer<TKey1, TKey2, TKey3, TKey4>(keys, keys2, keys3, keys4));
		List<T> list = new List<T>(array.Length);
		foreach (int num in array2)
		{
			list.Add(array[num]);
		}
		return list;
	}

	// Token: 0x060000BF RID: 191 RVA: 0x00005990 File Offset: 0x00003B90
	public static List<TOut> OrderByThenBySelectToList<[Nullable(2)] T, [Nullable(2)] TKey1, [Nullable(2)] TKey2, [Nullable(2)] TOut>(IEnumerable<T> source, Func<T, TKey1> key1, Func<T, TKey2> key2, Func<T, TOut> selector)
	{
		ArgumentNullException.ThrowIfNull(key2, "key2");
		ArgumentNullException.ThrowIfNull(selector, "selector");
		T[] array;
		int[] sortedOrder = NoLinq.GetSortedOrder<T, TKey1, TKey2>(source, key1, key2, null, null, out array, false);
		List<TOut> list = new List<TOut>(array.Length);
		foreach (int num in sortedOrder)
		{
			list.Add(selector(array[num]));
		}
		return list;
	}

	// Token: 0x060000C0 RID: 192 RVA: 0x000059F4 File Offset: 0x00003BF4
	public static List<TOut> OrderByDescendingThenByThenBySelectToList<[Nullable(2)] T, [Nullable(2)] TKey1, [Nullable(2)] TKey2, [Nullable(2)] TKey3, [Nullable(2)] TOut>(IEnumerable<T> source, Func<T, TKey1> key1, Func<T, TKey2> key2, Func<T, TKey3> key3, Func<T, TOut> selector)
	{
		ArgumentNullException.ThrowIfNull(selector, "selector");
		T[] array;
		int[] sortedOrder = NoLinq.GetSortedOrder<T, TKey1, TKey2, TKey3>(source, key1, key2, key3, true, out array, false);
		List<TOut> list = new List<TOut>(array.Length);
		foreach (int num in sortedOrder)
		{
			list.Add(selector(array[num]));
		}
		return list;
	}

	// Token: 0x060000C1 RID: 193 RVA: 0x00005A50 File Offset: 0x00003C50
	public static List<T> GroupByOrderByThenByThenByToList<[Nullable(2)] T, [Nullable(2)] TGroupKey, [Nullable(2)] TKey1, [Nullable(2)] TKey2, [Nullable(2)] TKey3>(IEnumerable<T> source, Func<T, TGroupKey> groupKey, Func<T, TKey1> key1, Func<T, TKey2> key2, Func<T, TKey3> key3)
	{
		ArgumentNullException.ThrowIfNull(source, "source");
		ArgumentNullException.ThrowIfNull(groupKey, "groupKey");
		ArgumentNullException.ThrowIfNull(key1, "key1");
		ArgumentNullException.ThrowIfNull(key2, "key2");
		ArgumentNullException.ThrowIfNull(key3, "key3");
		NoLinq.GroupLookup<TGroupKey, T> groupLookup = NoLinq.BuildGroups<T, TGroupKey>(source, groupKey);
		List<T> list = new List<T>(groupLookup.ItemCount);
		NoLinq.Group<TGroupKey, T> last = groupLookup.Last;
		if (last == null)
		{
			return list;
		}
		NoLinq.Group<TGroupKey, T> group = last;
		do
		{
			group = group.Next;
			T[] array;
			foreach (int num in NoLinq.GetSortedOrder<T, TKey1, TKey2, TKey3>(group, key1, key2, key3, false, out array, false))
			{
				list.Add(array[num]);
			}
		}
		while (group != last);
		return list;
	}

	// Token: 0x060000C2 RID: 194 RVA: 0x00005AFC File Offset: 0x00003CFC
	public static List<T> ToList<[Nullable(2)] T>(IEnumerable<T> source)
	{
		ArgumentNullException.ThrowIfNull(source, "source");
		NoLinq.IOrderedQuery<T> orderedQuery = source as NoLinq.IOrderedQuery<T>;
		if (orderedQuery != null)
		{
			return orderedQuery.ToList();
		}
		NoLinq.DistinctQuery<T> distinctQuery = source as NoLinq.DistinctQuery<T>;
		if (distinctQuery != null)
		{
			return distinctQuery.ToList();
		}
		NoLinq.ProjectedIterator<T> projectedIterator = source as NoLinq.ProjectedIterator<T>;
		if (projectedIterator != null)
		{
			return projectedIterator.ToList();
		}
		NoLinq.FilteredIterator<T> filteredIterator = source as NoLinq.FilteredIterator<T>;
		if (filteredIterator != null)
		{
			return filteredIterator.ToList();
		}
		return new List<T>(source);
	}

	// Token: 0x060000C3 RID: 195 RVA: 0x00005B60 File Offset: 0x00003D60
	public static T[] ToArray<[Nullable(2)] T>(IEnumerable<T> source)
	{
		ArgumentNullException.ThrowIfNull(source, "source");
		NoLinq.IOrderedQuery<T> orderedQuery = source as NoLinq.IOrderedQuery<T>;
		if (orderedQuery != null)
		{
			return orderedQuery.ToArray();
		}
		NoLinq.DistinctQuery<T> distinctQuery = source as NoLinq.DistinctQuery<T>;
		if (distinctQuery != null)
		{
			return distinctQuery.ToArray();
		}
		NoLinq.ProjectedIterator<T> projectedIterator = source as NoLinq.ProjectedIterator<T>;
		if (projectedIterator != null)
		{
			return projectedIterator.ToArray();
		}
		NoLinq.FilteredIterator<T> filteredIterator = source as NoLinq.FilteredIterator<T>;
		if (filteredIterator != null)
		{
			return filteredIterator.ToArray();
		}
		NoLinq.ArraySource<T> arraySource = source as NoLinq.ArraySource<T>;
		if (arraySource != null)
		{
			return arraySource.ToArray();
		}
		ICollection<T> collection = source as ICollection<T>;
		if (collection == null)
		{
			NoLinq.ScratchBuffer<T> scratchBuffer = default(NoLinq.ScratchBuffer<T>);
			T[] result;
			using (NoLinq.PooledArrayBuilder<T> pooledArrayBuilder = new NoLinq.PooledArrayBuilder<T>(<PrivateImplementationDetails>.InlineArrayAsSpan<NoLinq.ScratchBuffer<T>, T>(ref scratchBuffer, 8)))
			{
				foreach (T item in source)
				{
					pooledArrayBuilder.Add(item);
				}
				result = pooledArrayBuilder.ToArray();
			}
			return result;
		}
		int count = collection.Count;
		if (count == 0)
		{
			return Array.Empty<T>();
		}
		T[] array = new T[count];
		collection.CopyTo(array, 0);
		return array;
	}

	// Token: 0x060000C4 RID: 196 RVA: 0x00005C80 File Offset: 0x00003E80
	public unsafe static List<T> WhereToList<[Nullable(2)] T>(IEnumerable<T> source, Func<T, bool> predicate)
	{
		ArgumentNullException.ThrowIfNull(source, "source");
		ArgumentNullException.ThrowIfNull(predicate, "predicate");
		NoLinq.ScratchBuffer<T> scratchBuffer = default(NoLinq.ScratchBuffer<T>);
		List<T> result;
		using (NoLinq.PooledArrayBuilder<T> pooledArrayBuilder = new NoLinq.PooledArrayBuilder<T>(<PrivateImplementationDetails>.InlineArrayAsSpan<NoLinq.ScratchBuffer<T>, T>(ref scratchBuffer, 8)))
		{
			T[] array = source as T[];
			if (array != null)
			{
				foreach (T t in array)
				{
					if (predicate(t))
					{
						pooledArrayBuilder.Add(t);
					}
				}
			}
			else
			{
				List<T> list = source as List<T>;
				if (list != null)
				{
					Span<T> span = CollectionsMarshal.AsSpan<T>(list);
					for (int i = 0; i < span.Length; i++)
					{
						T t2 = *span[i];
						if (predicate(t2))
						{
							pooledArrayBuilder.Add(t2);
						}
					}
				}
				else
				{
					foreach (T t3 in source)
					{
						if (predicate(t3))
						{
							pooledArrayBuilder.Add(t3);
						}
					}
				}
			}
			result = pooledArrayBuilder.ToList();
		}
		return result;
	}

	// Token: 0x060000C5 RID: 197 RVA: 0x00005DB8 File Offset: 0x00003FB8
	public static T[] WhereToArray<[Nullable(2)] T>(IEnumerable<T> source, Func<T, bool> predicate)
	{
		ArgumentNullException.ThrowIfNull(source, "source");
		ArgumentNullException.ThrowIfNull(predicate, "predicate");
		T[] array = source as T[];
		if (array != null)
		{
			return NoLinq.WhereSpanToArray<T>(array, predicate);
		}
		List<T> list = source as List<T>;
		if (list != null)
		{
			return NoLinq.WhereSpanToArray<T>(CollectionsMarshal.AsSpan<T>(list), predicate);
		}
		NoLinq.ScratchBuffer<T> scratchBuffer = default(NoLinq.ScratchBuffer<T>);
		T[] result;
		using (NoLinq.PooledArrayBuilder<T> pooledArrayBuilder = new NoLinq.PooledArrayBuilder<T>(<PrivateImplementationDetails>.InlineArrayAsSpan<NoLinq.ScratchBuffer<T>, T>(ref scratchBuffer, 8)))
		{
			foreach (T t in source)
			{
				if (predicate(t))
				{
					pooledArrayBuilder.Add(t);
				}
			}
			result = pooledArrayBuilder.ToArray();
		}
		return result;
	}

	// Token: 0x060000C6 RID: 198 RVA: 0x00005E94 File Offset: 0x00004094
	private static T[] WhereSpanToArray<[Nullable(2)] T>([Nullable(new byte[]
	{
		0,
		1
	})] ReadOnlySpan<T> source, Func<T, bool> predicate)
	{
		NoLinq.ScratchBuffer<T> scratchBuffer = default(NoLinq.ScratchBuffer<T>);
		T[] result;
		using (NoLinq.PooledArrayBuilder<T> pooledArrayBuilder = new NoLinq.PooledArrayBuilder<T>(<PrivateImplementationDetails>.InlineArrayAsSpan<NoLinq.ScratchBuffer<T>, T>(ref scratchBuffer, 8)))
		{
			pooledArrayBuilder.AddWhere(source, predicate);
			result = pooledArrayBuilder.ToArray();
		}
		return result;
	}

	// Token: 0x060000C7 RID: 199 RVA: 0x00005EE4 File Offset: 0x000040E4
	public static List<TOut> SelectToList<[Nullable(2)] TIn, [Nullable(2)] TOut>(IEnumerable<TIn> source, Func<TIn, TOut> selector)
	{
		ArgumentNullException.ThrowIfNull(source, "source");
		ArgumentNullException.ThrowIfNull(selector, "selector");
		NoLinq.FilteredIterator<TIn> filteredIterator = source as NoLinq.FilteredIterator<TIn>;
		if (filteredIterator != null)
		{
			return filteredIterator.SelectToList<TOut>(selector);
		}
		TIn[] array = source as TIn[];
		if (array != null)
		{
			return NoLinq.SelectArrayToList<TIn, TOut>(array, selector);
		}
		List<TIn> list = source as List<TIn>;
		if (list != null)
		{
			return NoLinq.SelectListToList<TIn, TOut>(list, selector);
		}
		List<TOut> list2 = new List<TOut>(NoLinq.GetCountOrZero<TIn>(source));
		foreach (TIn arg in source)
		{
			list2.Add(selector(arg));
		}
		return list2;
	}

	// Token: 0x060000C8 RID: 200 RVA: 0x00005F94 File Offset: 0x00004194
	private unsafe static List<TOut> SelectArrayToList<[Nullable(2)] TIn, [Nullable(2)] TOut>(TIn[] source, Func<TIn, TOut> selector)
	{
		List<TOut> list = new List<TOut>(source.Length);
		CollectionsMarshal.SetCount<TOut>(list, source.Length);
		Span<TOut> span = CollectionsMarshal.AsSpan<TOut>(list);
		for (int i = 0; i < source.Length; i++)
		{
			*span[i] = selector(source[i]);
		}
		return list;
	}

	// Token: 0x060000C9 RID: 201 RVA: 0x00005FE4 File Offset: 0x000041E4
	private unsafe static List<TOut> SelectListToList<[Nullable(2)] TIn, [Nullable(2)] TOut>(List<TIn> source, Func<TIn, TOut> selector)
	{
		ReadOnlySpan<TIn> readOnlySpan = CollectionsMarshal.AsSpan<TIn>(source);
		List<TOut> list = new List<TOut>(readOnlySpan.Length);
		CollectionsMarshal.SetCount<TOut>(list, readOnlySpan.Length);
		Span<TOut> span = CollectionsMarshal.AsSpan<TOut>(list);
		for (int i = 0; i < span.Length; i++)
		{
			*span[i] = selector(*readOnlySpan[i]);
		}
		return list;
	}

	// Token: 0x060000CA RID: 202 RVA: 0x00006054 File Offset: 0x00004254
	public unsafe static TOut[] SelectToArray<[Nullable(2)] TIn, [Nullable(2)] TOut>(IEnumerable<TIn> source, Func<TIn, TOut> selector)
	{
		ArgumentNullException.ThrowIfNull(source, "source");
		ArgumentNullException.ThrowIfNull(selector, "selector");
		NoLinq.FilteredIterator<TIn> filteredIterator = source as NoLinq.FilteredIterator<TIn>;
		if (filteredIterator != null)
		{
			return filteredIterator.SelectToArray<TOut>(selector);
		}
		TIn[] array = source as TIn[];
		if (array != null)
		{
			if (array.Length == 0)
			{
				return Array.Empty<TOut>();
			}
			TOut[] array2 = new TOut[array.Length];
			for (int i = 0; i < array.Length; i++)
			{
				array2[i] = selector(array[i]);
			}
			return array2;
		}
		else
		{
			List<TIn> list = source as List<TIn>;
			if (list == null)
			{
				NoLinq.ScratchBuffer<TOut> scratchBuffer = default(NoLinq.ScratchBuffer<TOut>);
				TOut[] result;
				using (NoLinq.PooledArrayBuilder<TOut> pooledArrayBuilder = new NoLinq.PooledArrayBuilder<TOut>(<PrivateImplementationDetails>.InlineArrayAsSpan<NoLinq.ScratchBuffer<TOut>, TOut>(ref scratchBuffer, 8)))
				{
					foreach (TIn arg in source)
					{
						pooledArrayBuilder.Add(selector(arg));
					}
					result = pooledArrayBuilder.ToArray();
				}
				return result;
			}
			ReadOnlySpan<TIn> readOnlySpan = CollectionsMarshal.AsSpan<TIn>(list);
			if (readOnlySpan.Length == 0)
			{
				return Array.Empty<TOut>();
			}
			TOut[] array3 = new TOut[readOnlySpan.Length];
			for (int j = 0; j < array3.Length; j++)
			{
				array3[j] = selector(*readOnlySpan[j]);
			}
			return array3;
		}
	}

	// Token: 0x060000CB RID: 203 RVA: 0x000061BC File Offset: 0x000043BC
	public static List<T> SkipToList<[Nullable(2)] T>(IEnumerable<T> source, int count)
	{
		ArgumentNullException.ThrowIfNull(source, "source");
		int num = Math.Max(0, count);
		List<T> list = source as List<T>;
		if (list != null)
		{
			int num2 = Math.Min(num, list.Count);
			return list.GetRange(num2, list.Count - num2);
		}
		IList<T> list2 = source as IList<T>;
		if (list2 != null)
		{
			int num3 = Math.Max(0, list2.Count - num);
			List<T> list3 = new List<T>(num3);
			for (int i = 0; i < num3; i++)
			{
				list3.Add(list2[num + i]);
			}
			return list3;
		}
		List<T> list4 = new List<T>(Math.Max(0, NoLinq.GetCountOrZero<T>(source) - num));
		foreach (T item in source)
		{
			if (num == 0)
			{
				list4.Add(item);
			}
			else
			{
				num--;
			}
		}
		return list4;
	}

	// Token: 0x060000CC RID: 204 RVA: 0x000062B0 File Offset: 0x000044B0
	public static List<T> SkipTakeToList<[Nullable(2)] T>(IEnumerable<T> source, int skip, int take)
	{
		ArgumentNullException.ThrowIfNull(source, "source");
		int num = Math.Max(0, skip);
		if (take <= 0)
		{
			return new List<T>();
		}
		List<T> list = source as List<T>;
		if (list != null)
		{
			num = Math.Min(num, list.Count);
			return list.GetRange(num, Math.Min(take, list.Count - num));
		}
		IList<T> list2 = source as IList<T>;
		if (list2 != null)
		{
			num = Math.Min(num, list2.Count);
			int num2 = Math.Min(take, list2.Count - num);
			List<T> list3 = new List<T>(num2);
			for (int i = 0; i < num2; i++)
			{
				list3.Add(list2[num + i]);
			}
			return list3;
		}
		List<T> list4 = new List<T>(Math.Min(take, Math.Max(0, NoLinq.GetCountOrZero<T>(source) - num)));
		foreach (T item in source)
		{
			if (num > 0)
			{
				num--;
			}
			else
			{
				list4.Add(item);
				if (list4.Count == take)
				{
					break;
				}
			}
		}
		return list4;
	}

	// Token: 0x060000CD RID: 205 RVA: 0x000063D0 File Offset: 0x000045D0
	public static List<TOut> SkipSelectToList<[Nullable(2)] TIn, [Nullable(2)] TOut>(IEnumerable<TIn> source, int count, Func<TIn, TOut> selector)
	{
		ArgumentNullException.ThrowIfNull(source, "source");
		ArgumentNullException.ThrowIfNull(selector, "selector");
		int num = Math.Max(0, count);
		List<TOut> list = new List<TOut>(Math.Max(0, NoLinq.GetCountOrZero<TIn>(source) - num));
		foreach (TIn arg in source)
		{
			if (num == 0)
			{
				list.Add(selector(arg));
			}
			else
			{
				num--;
			}
		}
		return list;
	}

	// Token: 0x060000CE RID: 206 RVA: 0x0000645C File Offset: 0x0000465C
	public static T[] SkipToArray<[Nullable(2)] T>(IEnumerable<T> source, int count)
	{
		ArgumentNullException.ThrowIfNull(source, "source");
		int num = Math.Max(0, count);
		T[] array = source as T[];
		if (array != null)
		{
			int num2 = Math.Max(0, array.Length - num);
			if (num2 == 0)
			{
				return Array.Empty<T>();
			}
			T[] array2 = new T[num2];
			Array.Copy(array, num, array2, 0, num2);
			return array2;
		}
		else
		{
			List<T> list = source as List<T>;
			if (list != null)
			{
				int num3 = Math.Max(0, list.Count - num);
				if (num3 == 0)
				{
					return Array.Empty<T>();
				}
				T[] array3 = new T[num3];
				list.CopyTo(num, array3, 0, num3);
				return array3;
			}
			else
			{
				IList<T> list2 = source as IList<T>;
				if (list2 == null)
				{
					NoLinq.ScratchBuffer<T> scratchBuffer = default(NoLinq.ScratchBuffer<T>);
					T[] result;
					using (NoLinq.PooledArrayBuilder<T> pooledArrayBuilder = new NoLinq.PooledArrayBuilder<T>(<PrivateImplementationDetails>.InlineArrayAsSpan<NoLinq.ScratchBuffer<T>, T>(ref scratchBuffer, 8)))
					{
						foreach (T item in source)
						{
							if (num == 0)
							{
								pooledArrayBuilder.Add(item);
							}
							else
							{
								num--;
							}
						}
						result = pooledArrayBuilder.ToArray();
					}
					return result;
				}
				int num4 = Math.Max(0, list2.Count - num);
				if (num4 == 0)
				{
					return Array.Empty<T>();
				}
				T[] array4 = new T[num4];
				for (int i = 0; i < num4; i++)
				{
					array4[i] = list2[num + i];
				}
				return array4;
			}
		}
	}

	// Token: 0x060000CF RID: 207 RVA: 0x000065CC File Offset: 0x000047CC
	public static IEnumerable<T> Skip<[Nullable(2)] T>(IEnumerable<T> source, int count)
	{
		ArgumentNullException.ThrowIfNull(source, "source");
		return NoLinq.SkipIterator<T>(source, Math.Max(0, count));
	}

	// Token: 0x060000D0 RID: 208 RVA: 0x000065E6 File Offset: 0x000047E6
	private static IEnumerable<T> SkipIterator<[Nullable(2)] T>(IEnumerable<T> source, int remaining)
	{
		NoLinq.<SkipIterator>d__71<T> <SkipIterator>d__ = new NoLinq.<SkipIterator>d__71<T>(-2);
		<SkipIterator>d__.<>3__source = source;
		<SkipIterator>d__.<>3__remaining = remaining;
		return <SkipIterator>d__;
	}

	// Token: 0x060000D1 RID: 209 RVA: 0x000065FD File Offset: 0x000047FD
	public static List<T> ConcatToList<[Nullable(2)] T>(IEnumerable<T> first, IEnumerable<T> second)
	{
		ArgumentNullException.ThrowIfNull(first, "first");
		ArgumentNullException.ThrowIfNull(second, "second");
		List<T> list = new List<T>(checked(NoLinq.GetCountOrZero<T>(first) + NoLinq.GetCountOrZero<T>(second)));
		list.AddRange(first);
		list.AddRange(second);
		return list;
	}

	// Token: 0x060000D2 RID: 210 RVA: 0x00006638 File Offset: 0x00004838
	public static List<T> UnionToList<[Nullable(2)] T>(IEnumerable<T> first, IEnumerable<T> second, [Nullable(new byte[]
	{
		2,
		1
	})] IEqualityComparer<T> comparer = null)
	{
		ArgumentNullException.ThrowIfNull(first, "first");
		ArgumentNullException.ThrowIfNull(second, "second");
		HashSet<T> hashSet = new HashSet<T>(comparer);
		NoLinq.ScratchBuffer<T> scratchBuffer = default(NoLinq.ScratchBuffer<T>);
		List<T> result;
		using (NoLinq.PooledArrayBuilder<T> pooledArrayBuilder = new NoLinq.PooledArrayBuilder<T>(<PrivateImplementationDetails>.InlineArrayAsSpan<NoLinq.ScratchBuffer<T>, T>(ref scratchBuffer, 8)))
		{
			foreach (T item in first)
			{
				if (hashSet.Add(item))
				{
					pooledArrayBuilder.Add(item);
				}
			}
			foreach (T item2 in second)
			{
				if (hashSet.Add(item2))
				{
					pooledArrayBuilder.Add(item2);
				}
			}
			result = pooledArrayBuilder.ToList();
		}
		return result;
	}

	// Token: 0x060000D3 RID: 211 RVA: 0x00006728 File Offset: 0x00004928
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public unsafe static int Count<[Nullable(2)] T>(IEnumerable<T> source, Func<T, bool> predicate)
	{
		if (source == null)
		{
			NoLinq.ThrowQueryArgumentNull("source");
		}
		if (predicate == null)
		{
			NoLinq.ThrowQueryArgumentNull("predicate");
		}
		ReadOnlySpan<T> readOnlySpan;
		if (source.GetType() == typeof(T[]))
		{
			readOnlySpan = Unsafe.As<T[]>(source);
		}
		else
		{
			if (!(source.GetType() == typeof(List<T>)))
			{
				return NoLinq.CountEnumerable<T>(source, predicate);
			}
			readOnlySpan = CollectionsMarshal.AsSpan<T>(Unsafe.As<List<T>>(source));
		}
		int num = 0;
		ReadOnlySpan<T> readOnlySpan2 = readOnlySpan;
		for (int i = 0; i < readOnlySpan2.Length; i++)
		{
			T arg = *readOnlySpan2[i];
			if (predicate(arg))
			{
				num++;
			}
		}
		return num;
	}

	// Token: 0x060000D4 RID: 212 RVA: 0x000067DA File Offset: 0x000049DA
	[DoesNotReturn]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void ThrowQueryArgumentNull(string name)
	{
		throw new ArgumentNullException(name);
	}

	// Token: 0x060000D5 RID: 213 RVA: 0x000067E4 File Offset: 0x000049E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static int CountEnumerable<[Nullable(2)] T>(IEnumerable<T> source, Func<T, bool> predicate)
	{
		int num = 0;
		checked
		{
			foreach (T arg in source)
			{
				if (predicate(arg))
				{
					num++;
				}
			}
			return num;
		}
	}

	// Token: 0x060000D6 RID: 214 RVA: 0x00006838 File Offset: 0x00004A38
	[return: TupleElementNames(new string[]
	{
		"Matching",
		"Total"
	})]
	[return: Nullable(0)]
	public static ValueTuple<int, int> CountWhere<[Nullable(2)] T>(IEnumerable<T> source, Func<T, bool> filter, Func<T, bool> predicate)
	{
		ArgumentNullException.ThrowIfNull(source, "source");
		ArgumentNullException.ThrowIfNull(filter, "filter");
		ArgumentNullException.ThrowIfNull(predicate, "predicate");
		int num = 0;
		int num2 = 0;
		checked
		{
			foreach (T arg in source)
			{
				if (filter(arg))
				{
					num2++;
					if (predicate(arg))
					{
						num++;
					}
				}
			}
			return new ValueTuple<int, int>(num, num2);
		}
	}

	// Token: 0x060000D7 RID: 215 RVA: 0x000068C0 File Offset: 0x00004AC0
	public static bool Contains<[Nullable(2)] T>(T[] source, T value)
	{
		ArgumentNullException.ThrowIfNull(source, "source");
		return Array.IndexOf<T>(source, value) >= 0;
	}

	// Token: 0x060000D8 RID: 216 RVA: 0x000068DA File Offset: 0x00004ADA
	public static bool Contains<[Nullable(0)] T>([Nullable(new byte[]
	{
		0,
		1
	})] ReadOnlySpan<T> source, T value) where T : IEquatable<T>
	{
		return source.IndexOf(value) >= 0;
	}

	// Token: 0x060000D9 RID: 217 RVA: 0x000068E9 File Offset: 0x00004AE9
	public static bool Contains<[Nullable(0)] T>([Nullable(new byte[]
	{
		0,
		1
	})] Span<T> source, T value) where T : IEquatable<T>
	{
		return NoLinq.Contains<T>(source, value);
	}

	// Token: 0x060000DA RID: 218 RVA: 0x000068F8 File Offset: 0x00004AF8
	public static List<T> PartitionToList<[Nullable(2)] T>(IEnumerable<T> source, Func<T, bool> predicate)
	{
		ArgumentNullException.ThrowIfNull(source, "source");
		ArgumentNullException.ThrowIfNull(predicate, "predicate");
		NoLinq.ScratchBuffer<T> scratchBuffer = default(NoLinq.ScratchBuffer<T>);
		NoLinq.ScratchBuffer<T> scratchBuffer2 = default(NoLinq.ScratchBuffer<T>);
		NoLinq.PooledArrayBuilder<T> pooledArrayBuilder = new NoLinq.PooledArrayBuilder<T>(<PrivateImplementationDetails>.InlineArrayAsSpan<NoLinq.ScratchBuffer<T>, T>(ref scratchBuffer, 8));
		NoLinq.PooledArrayBuilder<T> pooledArrayBuilder2 = new NoLinq.PooledArrayBuilder<T>(<PrivateImplementationDetails>.InlineArrayAsSpan<NoLinq.ScratchBuffer<T>, T>(ref scratchBuffer2, 8));
		List<T> result2;
		try
		{
			foreach (T t in source)
			{
				if (predicate(t))
				{
					pooledArrayBuilder.Add(t);
				}
				else
				{
					pooledArrayBuilder2.Add(t);
				}
			}
			int num = checked(pooledArrayBuilder2.Count + pooledArrayBuilder.Count);
			List<T> list = new List<T>(num);
			CollectionsMarshal.SetCount<T>(list, num);
			Span<T> result = CollectionsMarshal.AsSpan<T>(list);
			pooledArrayBuilder2.CopyTo(result);
			pooledArrayBuilder.CopyTo(result.Slice(pooledArrayBuilder2.Count));
			result2 = list;
		}
		finally
		{
			pooledArrayBuilder.Dispose();
			pooledArrayBuilder2.Dispose();
		}
		return result2;
	}

	// Token: 0x060000DB RID: 219 RVA: 0x00006A08 File Offset: 0x00004C08
	public static List<T> SortToList<[Nullable(2)] T>(IEnumerable<T> source, Comparison<T> comparison)
	{
		ArgumentNullException.ThrowIfNull(source, "source");
		ArgumentNullException.ThrowIfNull(comparison, "comparison");
		List<T> list = NoLinq.ToList<T>(source);
		NoLinq.SortStable<T>(list, comparison);
		return list;
	}

	// Token: 0x060000DC RID: 220 RVA: 0x00006A2D File Offset: 0x00004C2D
	public static List<T> WhereSortToList<[Nullable(2)] T>(IEnumerable<T> source, Func<T, bool> predicate, Comparison<T> comparison)
	{
		ArgumentNullException.ThrowIfNull(comparison, "comparison");
		List<T> list = NoLinq.WhereToList<T>(source, predicate);
		NoLinq.SortStable<T>(list, comparison);
		return list;
	}

	// Token: 0x060000DD RID: 221 RVA: 0x00006A48 File Offset: 0x00004C48
	public static List<T> WhereOrderByTakeToList<[Nullable(2)] T, [Nullable(2)] TKey>(IEnumerable<T> source, Func<T, bool> predicate, Func<T, TKey> keySelector, int count)
	{
		ArgumentNullException.ThrowIfNull(source, "source");
		ArgumentNullException.ThrowIfNull(predicate, "predicate");
		ArgumentNullException.ThrowIfNull(keySelector, "keySelector");
		if (count <= 0)
		{
			return new List<T>();
		}
		List<NoLinq.RankedItem<T, TKey>> list = new List<NoLinq.RankedItem<T, TKey>>(Math.Min(count, NoLinq.GetCountOrZero<T>(source)));
		Comparer<TKey> comparer = Comparer<TKey>.Default;
		long num = 0L;
		foreach (T t in source)
		{
			if (predicate(t))
			{
				T item2 = t;
				TKey key = keySelector(t);
				long num2 = num;
				num = num2 + 1L;
				NoLinq.RankedItem<T, TKey> rankedItem = new NoLinq.RankedItem<T, TKey>(item2, key, num2);
				if (list.Count < count)
				{
					list.Add(rankedItem);
					int i;
					int num3;
					for (i = list.Count - 1; i > 0; i = num3)
					{
						num3 = (i - 1) / 2;
						if (NoLinq.CompareRanked<T, TKey>(list[num3], rankedItem, comparer) >= 0)
						{
							break;
						}
						list[i] = list[num3];
					}
					list[i] = rankedItem;
				}
				else if (NoLinq.CompareRanked<T, TKey>(rankedItem, list[0], comparer) < 0)
				{
					int j;
					int num4;
					for (j = 0; j < list.Count / 2; j = num4)
					{
						num4 = j * 2 + 1;
						if (num4 + 1 < list.Count && NoLinq.CompareRanked<T, TKey>(list[num4 + 1], list[num4], comparer) > 0)
						{
							num4++;
						}
						if (NoLinq.CompareRanked<T, TKey>(rankedItem, list[num4], comparer) >= 0)
						{
							break;
						}
						list[j] = list[num4];
					}
					list[j] = rankedItem;
				}
			}
		}
		list.Sort((NoLinq.RankedItem<T, TKey> left, NoLinq.RankedItem<T, TKey> right) => NoLinq.CompareRanked<T, TKey>(left, right, comparer));
		return NoLinq.SelectToList<NoLinq.RankedItem<T, TKey>, T>(list, (NoLinq.RankedItem<T, TKey> item) => item.Item);
	}

	// Token: 0x060000DE RID: 222 RVA: 0x00006C48 File Offset: 0x00004E48
	[NullableContext(2)]
	private static int CompareRanked<T, TKey>([Nullable(new byte[]
	{
		0,
		1,
		1
	})] NoLinq.RankedItem<T, TKey> left, [Nullable(new byte[]
	{
		0,
		1,
		1
	})] NoLinq.RankedItem<T, TKey> right, [Nullable(1)] IComparer<TKey> comparer)
	{
		int num = comparer.Compare(left.Key, right.Key);
		if (num == 0)
		{
			return left.Index.CompareTo(right.Index);
		}
		return num;
	}

	// Token: 0x060000DF RID: 223 RVA: 0x00006C80 File Offset: 0x00004E80
	public static List<T> SelectManyToList<[Nullable(2)] T>(IReadOnlyList<List<T>> source)
	{
		ArgumentNullException.ThrowIfNull(source, "source");
		int num = 0;
		for (int i = 0; i < source.Count; i++)
		{
			checked
			{
				num += source[i].Count;
			}
		}
		List<T> list = new List<T>(num);
		for (int j = 0; j < source.Count; j++)
		{
			list.AddRange(source[j]);
		}
		return list;
	}

	// Token: 0x060000E0 RID: 224 RVA: 0x00006CE0 File Offset: 0x00004EE0
	public static TOut[] SelectManyToArray<[Nullable(2)] TIn, [Nullable(2)] TOut>(IEnumerable<TIn> source, Func<TIn, IEnumerable<TOut>> selector)
	{
		ArgumentNullException.ThrowIfNull(source, "source");
		ArgumentNullException.ThrowIfNull(selector, "selector");
		NoLinq.ScratchBuffer<TOut> scratchBuffer = default(NoLinq.ScratchBuffer<TOut>);
		TOut[] result;
		using (NoLinq.PooledArrayBuilder<TOut> pooledArrayBuilder = new NoLinq.PooledArrayBuilder<TOut>(<PrivateImplementationDetails>.InlineArrayAsSpan<NoLinq.ScratchBuffer<TOut>, TOut>(ref scratchBuffer, 8)))
		{
			foreach (TIn arg in source)
			{
				foreach (TOut item in selector(arg))
				{
					pooledArrayBuilder.Add(item);
				}
			}
			result = pooledArrayBuilder.ToArray();
		}
		return result;
	}

	// Token: 0x060000E1 RID: 225 RVA: 0x00006DB4 File Offset: 0x00004FB4
	public static IEnumerable<T> OrderBy<[Nullable(2)] T, [Nullable(2)] TKey>(IEnumerable<T> source, Func<T, TKey> keySelector)
	{
		ArgumentNullException.ThrowIfNull(source, "source");
		ArgumentNullException.ThrowIfNull(keySelector, "keySelector");
		return new NoLinq.OrderedQuery<T, TKey>(source, keySelector);
	}

	// Token: 0x060000E2 RID: 226 RVA: 0x00006DD3 File Offset: 0x00004FD3
	public static List<T> OrderByToList<[Nullable(2)] T, [Nullable(2)] TKey>(IEnumerable<T> source, Func<T, TKey> keySelector)
	{
		return NoLinq.OrderByToList<T, TKey>(source, keySelector, null);
	}

	// Token: 0x060000E3 RID: 227 RVA: 0x00006DDD File Offset: 0x00004FDD
	public static List<T> OrderByToList<[Nullable(2)] T, [Nullable(2)] TKey>(IEnumerable<T> source, Func<T, TKey> keySelector, [Nullable(new byte[]
	{
		2,
		1
	})] IComparer<TKey> comparer)
	{
		return NoLinq.StableSort<T, TKey, TKey>(source, keySelector, null, comparer, null);
	}

	// Token: 0x060000E4 RID: 228 RVA: 0x00006DE9 File Offset: 0x00004FE9
	public static List<T> OrderByDescendingToList<[Nullable(2)] T, [Nullable(2)] TKey>(IEnumerable<T> source, Func<T, TKey> keySelector)
	{
		return NoLinq.OrderByToList<T, TKey>(source, keySelector, NoLinq.DescendingComparer<TKey>.Instance);
	}

	// Token: 0x060000E5 RID: 229 RVA: 0x00006DF7 File Offset: 0x00004FF7
	public static List<T> OrderByThenByToList<[Nullable(2)] T, [Nullable(2)] TKey1, [Nullable(2)] TKey2>(IEnumerable<T> source, Func<T, TKey1> key1, Func<T, TKey2> key2)
	{
		return NoLinq.OrderByThenByToList<T, TKey1, TKey2>(source, key1, key2, null, null);
	}

	// Token: 0x060000E6 RID: 230 RVA: 0x00006E03 File Offset: 0x00005003
	public static List<T> OrderByThenByToList<[Nullable(2)] T, [Nullable(2)] TKey1, [Nullable(2)] TKey2>(IEnumerable<T> source, Func<T, TKey1> key1, Func<T, TKey2> key2, [Nullable(new byte[]
	{
		2,
		1
	})] IComparer<TKey1> comparer1, [Nullable(new byte[]
	{
		2,
		1
	})] IComparer<TKey2> comparer2)
	{
		ArgumentNullException.ThrowIfNull(source, "source");
		ArgumentNullException.ThrowIfNull(key1, "key1");
		ArgumentNullException.ThrowIfNull(key2, "key2");
		return NoLinq.StableSort<T, TKey1, TKey2>(source, key1, key2, comparer1, comparer2);
	}

	// Token: 0x060000E7 RID: 231 RVA: 0x00006E31 File Offset: 0x00005031
	public static List<T> OrderByThenByDescendingToList<[Nullable(2)] T, [Nullable(2)] TKey1, [Nullable(2)] TKey2>(IEnumerable<T> source, Func<T, TKey1> key1, Func<T, TKey2> key2)
	{
		return NoLinq.OrderByThenByToList<T, TKey1, TKey2>(source, key1, key2, null, NoLinq.DescendingComparer<TKey2>.Instance);
	}

	// Token: 0x060000E8 RID: 232 RVA: 0x00006E41 File Offset: 0x00005041
	public static List<T> OrderByDescendingThenByDescendingToList<[Nullable(2)] T, [Nullable(2)] TKey1, [Nullable(2)] TKey2>(IEnumerable<T> source, Func<T, TKey1> key1, Func<T, TKey2> key2)
	{
		return NoLinq.OrderByThenByToList<T, TKey1, TKey2>(source, key1, key2, NoLinq.DescendingComparer<TKey1>.Instance, NoLinq.DescendingComparer<TKey2>.Instance);
	}

	// Token: 0x060000E9 RID: 233 RVA: 0x00006E58 File Offset: 0x00005058
	public static T[] OrderByToArray<[Nullable(2)] T, [Nullable(2)] TKey>(IEnumerable<T> source, Func<T, TKey> keySelector)
	{
		T[] array;
		int[] sortedOrder = NoLinq.GetSortedOrder<T, TKey, TKey>(source, keySelector, null, null, null, out array, true);
		if (array.Length <= 1)
		{
			return array;
		}
		T[] array2 = new T[array.Length];
		for (int i = 0; i < sortedOrder.Length; i++)
		{
			array2[i] = array[sortedOrder[i]];
		}
		return array2;
	}

	// Token: 0x060000EA RID: 234 RVA: 0x00006EA4 File Offset: 0x000050A4
	private static List<T> StableSort<[Nullable(2)] T, [Nullable(2)] TKey1, [Nullable(2)] TKey2>(IEnumerable<T> source, Func<T, TKey1> key1, [Nullable(new byte[]
	{
		2,
		1,
		1
	})] Func<T, TKey2> key2, [Nullable(new byte[]
	{
		2,
		1
	})] IComparer<TKey1> comparer1, [Nullable(new byte[]
	{
		2,
		1
	})] IComparer<TKey2> comparer2)
	{
		T[] array;
		int[] sortedOrder = NoLinq.GetSortedOrder<T, TKey1, TKey2>(source, key1, key2, comparer1, comparer2, out array, true);
		List<T> list = new List<T>(array.Length);
		foreach (int num in sortedOrder)
		{
			list.Add(array[num]);
		}
		return list;
	}

	// Token: 0x060000EB RID: 235 RVA: 0x00006EEC File Offset: 0x000050EC
	private static int[] GetSortedOrder<[Nullable(2)] T, [Nullable(2)] TKey1, [Nullable(2)] TKey2>(IEnumerable<T> source, Func<T, TKey1> key1, [Nullable(new byte[]
	{
		2,
		1,
		1
	})] Func<T, TKey2> key2, [Nullable(new byte[]
	{
		2,
		1
	})] IComparer<TKey1> comparer1, [Nullable(new byte[]
	{
		2,
		1
	})] IComparer<TKey2> comparer2, out T[] items, bool directMaterialization = true)
	{
		ArgumentNullException.ThrowIfNull(source, "source");
		ArgumentNullException.ThrowIfNull(key1, "key1");
		items = NoLinq.ToArray<T>(source);
		int num = items.Length;
		if (num == 0)
		{
			return Array.Empty<int>();
		}
		if (directMaterialization && num == 1)
		{
			return new int[1];
		}
		TKey1[] keys1 = new TKey1[num];
		TKey2[] keys2 = (key2 == null) ? null : new TKey2[num];
		int[] array = new int[num];
		for (int i = 0; i < num; i++)
		{
			keys1[i] = key1(items[i]);
			array[i] = i;
		}
		if (key2 != null)
		{
			for (int j = 0; j < num; j++)
			{
				keys2[j] = key2(items[j]);
			}
		}
		IComparer<TKey1> firstComparer = comparer1 ?? Comparer<TKey1>.Default;
		IComparer<TKey2> secondComparer = comparer2 ?? Comparer<TKey2>.Default;
		Array.Sort<int>(array, delegate(int left, int right)
		{
			int num2 = firstComparer.Compare(keys1[left], keys1[right]);
			if (num2 == 0 && key2 != null)
			{
				num2 = secondComparer.Compare(keys2[left], keys2[right]);
			}
			if (num2 == 0)
			{
				num2 = left - right;
			}
			return num2;
		});
		return array;
	}

	// Token: 0x060000EC RID: 236 RVA: 0x00007008 File Offset: 0x00005208
	public static T FirstOrDefault<[Nullable(2)] T>(IEnumerable<T> source)
	{
		ArgumentNullException.ThrowIfNull(source, "source");
		bool flag;
		return NoLinq.TryGetFirst<T>(source, out flag);
	}

	// Token: 0x060000ED RID: 237 RVA: 0x00007028 File Offset: 0x00005228
	private static T TryGetFirst<[Nullable(2)] T>(IEnumerable<T> source, out bool found)
	{
		NoLinq.DeferredIterator<T> deferredIterator = source as NoLinq.DeferredIterator<T>;
		if (deferredIterator != null)
		{
			return deferredIterator.TryGetFirst(out found);
		}
		IList<T> list = source as IList<T>;
		if (list != null)
		{
			if (list.Count > 0)
			{
				found = true;
				return list[0];
			}
		}
		else
		{
			using (IEnumerator<T> enumerator = source.GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					found = true;
					return enumerator.Current;
				}
			}
		}
		found = false;
		return default(T);
	}

	// Token: 0x060000EE RID: 238 RVA: 0x000070AC File Offset: 0x000052AC
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public unsafe static T FirstOrDefault<[Nullable(2)] T>(IEnumerable<T> source, Func<T, bool> predicate)
	{
		if (source == null)
		{
			NoLinq.ThrowQueryArgumentNull("source");
		}
		if (predicate == null)
		{
			NoLinq.ThrowQueryArgumentNull("predicate");
		}
		ReadOnlySpan<T> readOnlySpan;
		if (source.GetType() == typeof(T[]))
		{
			readOnlySpan = Unsafe.As<T[]>(source);
		}
		else
		{
			if (!(source.GetType() == typeof(List<T>)))
			{
				return NoLinq.FirstOrDefaultEnumerable<T>(source, predicate);
			}
			readOnlySpan = CollectionsMarshal.AsSpan<T>(Unsafe.As<List<T>>(source));
		}
		ReadOnlySpan<T> readOnlySpan2 = readOnlySpan;
		for (int i = 0; i < readOnlySpan2.Length; i++)
		{
			T t = *readOnlySpan2[i];
			if (predicate(t))
			{
				return t;
			}
		}
		return default(T);
	}

	// Token: 0x060000EF RID: 239 RVA: 0x00007164 File Offset: 0x00005364
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static T FirstOrDefaultEnumerable<[Nullable(2)] T>(IEnumerable<T> source, Func<T, bool> predicate)
	{
		foreach (T t in source)
		{
			if (predicate(t))
			{
				return t;
			}
		}
		return default(T);
	}

	// Token: 0x060000F0 RID: 240 RVA: 0x000071C0 File Offset: 0x000053C0
	public unsafe static T First<[Nullable(2)] T>(IEnumerable<T> source, Func<T, bool> predicate)
	{
		ArgumentNullException.ThrowIfNull(source, "source");
		ArgumentNullException.ThrowIfNull(predicate, "predicate");
		ReadOnlySpan<T> readOnlySpan;
		if (NoLinq.TryGetSpan<T>(source, out readOnlySpan))
		{
			ReadOnlySpan<T> readOnlySpan2 = readOnlySpan;
			for (int i = 0; i < readOnlySpan2.Length; i++)
			{
				T t = *readOnlySpan2[i];
				if (predicate(t))
				{
					return t;
				}
			}
		}
		else
		{
			foreach (T t2 in source)
			{
				if (predicate(t2))
				{
					return t2;
				}
			}
		}
		throw new InvalidOperationException("Sequence contains no matching element");
	}

	// Token: 0x060000F1 RID: 241 RVA: 0x00007274 File Offset: 0x00005474
	public static T LastOrDefault<[Nullable(2)] T>(IEnumerable<T> source)
	{
		ArgumentNullException.ThrowIfNull(source, "source");
		IList<T> list = source as IList<T>;
		if (list == null)
		{
			T result = default(T);
			using (IEnumerator<T> enumerator = source.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					result = enumerator.Current;
				}
			}
			return result;
		}
		if (list.Count != 0)
		{
			return list[list.Count - 1];
		}
		return default(T);
	}

	// Token: 0x060000F2 RID: 242 RVA: 0x000072F4 File Offset: 0x000054F4
	public static char LastOrDefault(string source)
	{
		ArgumentNullException.ThrowIfNull(source, "source");
		if (source.Length != 0)
		{
			return source[source.Length - 1];
		}
		return '\0';
	}

	// Token: 0x060000F3 RID: 243 RVA: 0x0000731C File Offset: 0x0000551C
	public static bool Contains<[Nullable(2)] T>(IEnumerable<T> source, T value)
	{
		ArgumentNullException.ThrowIfNull(source, "source");
		ICollection<T> collection = source as ICollection<T>;
		if (collection != null)
		{
			return collection.Contains(value);
		}
		foreach (T x in source)
		{
			if (EqualityComparer<T>.Default.Equals(x, value))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060000F4 RID: 244 RVA: 0x00007390 File Offset: 0x00005590
	public static bool Any<[Nullable(2)] T>(IEnumerable<T> source)
	{
		ArgumentNullException.ThrowIfNull(source, "source");
		ICollection<T> collection = source as ICollection<T>;
		if (collection != null)
		{
			return collection.Count != 0;
		}
		NoLinq.DeferredIterator<T> deferredIterator = source as NoLinq.DeferredIterator<T>;
		if (deferredIterator != null)
		{
			int count = deferredIterator.GetCount(true);
			if (count >= 0)
			{
				return count != 0;
			}
			bool result;
			deferredIterator.TryGetFirst(out result);
			return result;
		}
		else
		{
			IReadOnlyCollection<T> readOnlyCollection = source as IReadOnlyCollection<T>;
			if (readOnlyCollection != null)
			{
				return readOnlyCollection.Count != 0;
			}
			ICollection collection2 = source as ICollection;
			if (collection2 != null)
			{
				return collection2.Count != 0;
			}
			bool result2;
			using (IEnumerator<T> enumerator = source.GetEnumerator())
			{
				result2 = enumerator.MoveNext();
			}
			return result2;
		}
	}

	// Token: 0x060000F5 RID: 245 RVA: 0x00007440 File Offset: 0x00005640
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public unsafe static bool Any<[Nullable(2)] T>(IEnumerable<T> source, Func<T, bool> predicate)
	{
		if (source == null)
		{
			NoLinq.ThrowQueryArgumentNull("source");
		}
		if (predicate == null)
		{
			NoLinq.ThrowQueryArgumentNull("predicate");
		}
		ReadOnlySpan<T> readOnlySpan;
		if (source.GetType() == typeof(T[]))
		{
			readOnlySpan = Unsafe.As<T[]>(source);
		}
		else
		{
			if (!(source.GetType() == typeof(List<T>)))
			{
				return NoLinq.AnyEnumerable<T>(source, predicate);
			}
			readOnlySpan = CollectionsMarshal.AsSpan<T>(Unsafe.As<List<T>>(source));
		}
		ReadOnlySpan<T> readOnlySpan2 = readOnlySpan;
		for (int i = 0; i < readOnlySpan2.Length; i++)
		{
			T arg = *readOnlySpan2[i];
			if (predicate(arg))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060000F6 RID: 246 RVA: 0x000074EC File Offset: 0x000056EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool AnyEnumerable<[Nullable(2)] T>(IEnumerable<T> source, Func<T, bool> predicate)
	{
		foreach (T arg in source)
		{
			if (predicate(arg))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060000F7 RID: 247 RVA: 0x00007540 File Offset: 0x00005740
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public unsafe static bool All<[Nullable(2)] T>(IEnumerable<T> source, Func<T, bool> predicate)
	{
		if (source == null)
		{
			NoLinq.ThrowQueryArgumentNull("source");
		}
		if (predicate == null)
		{
			NoLinq.ThrowQueryArgumentNull("predicate");
		}
		ReadOnlySpan<T> readOnlySpan;
		if (source.GetType() == typeof(T[]))
		{
			readOnlySpan = Unsafe.As<T[]>(source);
		}
		else
		{
			if (!(source.GetType() == typeof(List<T>)))
			{
				return NoLinq.AllEnumerable<T>(source, predicate);
			}
			readOnlySpan = CollectionsMarshal.AsSpan<T>(Unsafe.As<List<T>>(source));
		}
		ReadOnlySpan<T> readOnlySpan2 = readOnlySpan;
		for (int i = 0; i < readOnlySpan2.Length; i++)
		{
			T arg = *readOnlySpan2[i];
			if (!predicate(arg))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x060000F8 RID: 248 RVA: 0x000075EC File Offset: 0x000057EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool AllEnumerable<[Nullable(2)] T>(IEnumerable<T> source, Func<T, bool> predicate)
	{
		foreach (T arg in source)
		{
			if (!predicate(arg))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x060000F9 RID: 249 RVA: 0x00007640 File Offset: 0x00005840
	public static List<TOut> CastToList<[Nullable(2)] TOut>(IEnumerable source)
	{
		ArgumentNullException.ThrowIfNull(source, "source");
		IEnumerable<TOut> enumerable = source as IEnumerable<TOut>;
		if (enumerable != null)
		{
			return NoLinq.ToList<TOut>(enumerable);
		}
		ICollection collection = source as ICollection;
		List<TOut> list = new List<TOut>((collection != null) ? collection.Count : 0);
		foreach (object obj in source)
		{
			list.Add((TOut)((object)obj));
		}
		return list;
	}

	// Token: 0x060000FA RID: 250 RVA: 0x000076D0 File Offset: 0x000058D0
	public static List<T> Repeat<[Nullable(2)] T>(T element, int count)
	{
		List<T> list = new List<T>(count);
		for (int i = 0; i < count; i++)
		{
			list.Add(element);
		}
		return list;
	}

	// Token: 0x060000FB RID: 251 RVA: 0x000076F8 File Offset: 0x000058F8
	public static T[] RepeatToArray<[Nullable(2)] T>(T element, int count)
	{
		ArgumentOutOfRangeException.ThrowIfNegative<int>(count, "count");
		if (count == 0)
		{
			return Array.Empty<T>();
		}
		T[] array = new T[count];
		Array.Fill<T>(array, element);
		return array;
	}

	// Token: 0x060000FC RID: 252 RVA: 0x0000771B File Offset: 0x0000591B
	public static int[] OrderToArray(IEnumerable<int> source)
	{
		int[] array = NoLinq.ToArray<int>(source);
		Array.Sort<int>(array);
		return array;
	}

	// Token: 0x060000FD RID: 253 RVA: 0x00007729 File Offset: 0x00005929
	public static List<T> Prepend<[Nullable(2)] T>(IEnumerable<T> source, T value)
	{
		ArgumentNullException.ThrowIfNull(source, "source");
		List<T> list = new List<T>(checked(NoLinq.GetCountOrZero<T>(source) + 1));
		list.Add(value);
		list.AddRange(source);
		return list;
	}

	// Token: 0x060000FE RID: 254 RVA: 0x00007754 File Offset: 0x00005954
	public unsafe static List<TOut> WhereSelectToList<[Nullable(2)] TIn, [Nullable(2)] TOut>(IEnumerable<TIn> source, Func<TIn, bool> predicate, Func<TIn, TOut> selector)
	{
		ArgumentNullException.ThrowIfNull(source, "source");
		ArgumentNullException.ThrowIfNull(predicate, "predicate");
		ArgumentNullException.ThrowIfNull(selector, "selector");
		NoLinq.ScratchBuffer<TOut> scratchBuffer = default(NoLinq.ScratchBuffer<TOut>);
		List<TOut> result;
		using (NoLinq.PooledArrayBuilder<TOut> pooledArrayBuilder = new NoLinq.PooledArrayBuilder<TOut>(<PrivateImplementationDetails>.InlineArrayAsSpan<NoLinq.ScratchBuffer<TOut>, TOut>(ref scratchBuffer, 8)))
		{
			TIn[] array = source as TIn[];
			if (array != null)
			{
				foreach (TIn arg in array)
				{
					if (predicate(arg))
					{
						pooledArrayBuilder.Add(selector(arg));
					}
				}
			}
			else
			{
				List<TIn> list = source as List<TIn>;
				if (list != null)
				{
					Span<TIn> span = CollectionsMarshal.AsSpan<TIn>(list);
					for (int i = 0; i < span.Length; i++)
					{
						TIn arg2 = *span[i];
						if (predicate(arg2))
						{
							pooledArrayBuilder.Add(selector(arg2));
						}
					}
				}
				else
				{
					foreach (TIn arg3 in source)
					{
						if (predicate(arg3))
						{
							pooledArrayBuilder.Add(selector(arg3));
						}
					}
				}
			}
			result = pooledArrayBuilder.ToList();
		}
		return result;
	}

	// Token: 0x060000FF RID: 255 RVA: 0x000078AC File Offset: 0x00005AAC
	public unsafe static TOut[] WhereSelectToArray<[Nullable(2)] TIn, [Nullable(2)] TOut>(IEnumerable<TIn> source, Func<TIn, bool> predicate, Func<TIn, TOut> selector)
	{
		ArgumentNullException.ThrowIfNull(source, "source");
		ArgumentNullException.ThrowIfNull(predicate, "predicate");
		ArgumentNullException.ThrowIfNull(selector, "selector");
		NoLinq.ScratchBuffer<TOut> scratchBuffer = default(NoLinq.ScratchBuffer<TOut>);
		TOut[] result;
		using (NoLinq.PooledArrayBuilder<TOut> pooledArrayBuilder = new NoLinq.PooledArrayBuilder<TOut>(<PrivateImplementationDetails>.InlineArrayAsSpan<NoLinq.ScratchBuffer<TOut>, TOut>(ref scratchBuffer, 8)))
		{
			TIn[] array = source as TIn[];
			if (array != null)
			{
				foreach (TIn arg in array)
				{
					if (predicate(arg))
					{
						pooledArrayBuilder.Add(selector(arg));
					}
				}
			}
			else
			{
				List<TIn> list = source as List<TIn>;
				if (list != null)
				{
					Span<TIn> span = CollectionsMarshal.AsSpan<TIn>(list);
					for (int i = 0; i < span.Length; i++)
					{
						TIn arg2 = *span[i];
						if (predicate(arg2))
						{
							pooledArrayBuilder.Add(selector(arg2));
						}
					}
				}
				else
				{
					foreach (TIn arg3 in source)
					{
						if (predicate(arg3))
						{
							pooledArrayBuilder.Add(selector(arg3));
						}
					}
				}
			}
			result = pooledArrayBuilder.ToArray();
		}
		return result;
	}

	// Token: 0x06000100 RID: 256 RVA: 0x00007A04 File Offset: 0x00005C04
	public static int FindIndex<[Nullable(2)] T>(IReadOnlyList<T> source, Predicate<T> predicate)
	{
		ArgumentNullException.ThrowIfNull(source, "source");
		ArgumentNullException.ThrowIfNull(predicate, "predicate");
		for (int i = 0; i < source.Count; i++)
		{
			if (predicate(source[i]))
			{
				return i;
			}
		}
		return -1;
	}

	// Token: 0x06000101 RID: 257 RVA: 0x00007A4C File Offset: 0x00005C4C
	public static int IndexOf<[Nullable(2)] T>(IReadOnlyList<T> source, T value)
	{
		ArgumentNullException.ThrowIfNull(source, "source");
		EqualityComparer<T> @default = EqualityComparer<T>.Default;
		for (int i = 0; i < source.Count; i++)
		{
			if (@default.Equals(source[i], value))
			{
				return i;
			}
		}
		return -1;
	}

	// Token: 0x06000102 RID: 258 RVA: 0x00007A90 File Offset: 0x00005C90
	public static void SortStable<[Nullable(2)] T>(List<T> source, Comparison<T> comparison)
	{
		ArgumentNullException.ThrowIfNull(source, "source");
		ArgumentNullException.ThrowIfNull(comparison, "comparison");
		int count = source.Count;
		if (count < 2)
		{
			return;
		}
		if (count <= 16)
		{
			NoLinq.InsertionSort<T>(source, 0, count, comparison);
			return;
		}
		T[] array = ArrayPool<T>.Shared.Rent(count);
		try
		{
			NoLinq.MergeSort<T>(source, array, 0, count, comparison);
		}
		finally
		{
			if (RuntimeHelpers.IsReferenceOrContainsReferences<T>())
			{
				Array.Clear(array, 0, count);
			}
			ArrayPool<T>.Shared.Return(array, false);
		}
	}

	// Token: 0x06000103 RID: 259 RVA: 0x00007B14 File Offset: 0x00005D14
	private static void MergeSort<[Nullable(2)] T>(List<T> source, T[] buffer, int start, int end, Comparison<T> comparison)
	{
		if (end - start <= 16)
		{
			NoLinq.InsertionSort<T>(source, start, end, comparison);
			return;
		}
		int num = start + (end - start) / 2;
		NoLinq.MergeSort<T>(source, buffer, start, num, comparison);
		NoLinq.MergeSort<T>(source, buffer, num, end, comparison);
		if (comparison(source[num], source[num - 1]) >= 0)
		{
			return;
		}
		int i = start;
		int j = num;
		int num2 = start;
		while (i < num)
		{
			if (j >= end)
			{
				break;
			}
			buffer[num2++] = ((comparison(source[j], source[i]) < 0) ? source[j++] : source[i++]);
		}
		while (i < num)
		{
			buffer[num2++] = source[i++];
		}
		while (j < end)
		{
			buffer[num2++] = source[j++];
		}
		for (int k = start; k < end; k++)
		{
			source[k] = buffer[k];
		}
	}

	// Token: 0x06000104 RID: 260 RVA: 0x00007C10 File Offset: 0x00005E10
	private static void InsertionSort<[Nullable(2)] T>(List<T> source, int start, int end, Comparison<T> comparison)
	{
		for (int i = start + 1; i < end; i++)
		{
			T t = source[i];
			int num = i - 1;
			while (num >= start && comparison(t, source[num]) < 0)
			{
				source[num + 1] = source[num];
				num--;
			}
			source[num + 1] = t;
		}
	}

	// Token: 0x06000105 RID: 261 RVA: 0x00007C6C File Offset: 0x00005E6C
	public static Dictionary<TKey, TElement> ToDictionary<[Nullable(2)] TSource, [Nullable(2)] TKey, [Nullable(2)] TElement>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector)
	{
		ArgumentNullException.ThrowIfNull(source, "source");
		ArgumentNullException.ThrowIfNull(keySelector, "keySelector");
		ArgumentNullException.ThrowIfNull(elementSelector, "elementSelector");
		Dictionary<TKey, TElement> dictionary = new Dictionary<TKey, TElement>(NoLinq.GetCountOrZero<TSource>(source));
		TSource[] array = source as TSource[];
		if (array != null)
		{
			foreach (TSource arg in array)
			{
				dictionary.Add(keySelector(arg), elementSelector(arg));
			}
		}
		else
		{
			List<TSource> list = source as List<TSource>;
			if (list != null)
			{
				using (List<TSource>.Enumerator enumerator = list.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						TSource arg2 = enumerator.Current;
						dictionary.Add(keySelector(arg2), elementSelector(arg2));
					}
					return dictionary;
				}
			}
			foreach (TSource arg3 in source)
			{
				dictionary.Add(keySelector(arg3), elementSelector(arg3));
			}
		}
		return dictionary;
	}

	// Token: 0x06000106 RID: 262 RVA: 0x00007D90 File Offset: 0x00005F90
	private static int GetCountOrZero<[Nullable(2)] T>(IEnumerable<T> source)
	{
		ICollection<T> collection = source as ICollection<T>;
		if (collection != null)
		{
			return collection.Count;
		}
		IReadOnlyCollection<T> readOnlyCollection = source as IReadOnlyCollection<T>;
		if (readOnlyCollection == null)
		{
			return 0;
		}
		return readOnlyCollection.Count;
	}

	// Token: 0x02000037 RID: 55
	[Nullable(0)]
	private abstract class DeferredIterator<[Nullable(2)] T> : IEnumerable<!0>, IEnumerable, IEnumerator<!0>, IEnumerator, IDisposable
	{
		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600018C RID: 396 RVA: 0x0000EE2C File Offset: 0x0000D02C
		public T Current
		{
			get
			{
				return this.current;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600018D RID: 397 RVA: 0x0000EE34 File Offset: 0x0000D034
		[Nullable(2)]
		object IEnumerator.Current
		{
			[NullableContext(2)]
			get
			{
				return this.Current;
			}
		}

		// Token: 0x0600018E RID: 398
		protected abstract NoLinq.DeferredIterator<T> Clone();

		// Token: 0x0600018F RID: 399 RVA: 0x0000EE41 File Offset: 0x0000D041
		internal virtual IEnumerable<TOut> Select<[Nullable(2)] TOut>(Func<T, TOut> selector)
		{
			return new NoLinq.EnumerableSelectIterator<T, TOut>(this, selector);
		}

		// Token: 0x06000190 RID: 400 RVA: 0x0000EE4A File Offset: 0x0000D04A
		public IEnumerator<T> GetEnumerator()
		{
			NoLinq.DeferredIterator deferredIterator = (this.state == 0 && this.threadId == Environment.CurrentManagedThreadId) ? this : this.Clone();
			deferredIterator.state = 1;
			return deferredIterator;
		}

		// Token: 0x06000191 RID: 401 RVA: 0x0000EE71 File Offset: 0x0000D071
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x06000192 RID: 402
		public abstract bool MoveNext();

		// Token: 0x06000193 RID: 403 RVA: 0x0000EE7C File Offset: 0x0000D07C
		internal virtual int GetCount(bool onlyIfCheap)
		{
			if (onlyIfCheap)
			{
				return -1;
			}
			int num = 0;
			checked
			{
				foreach (!0 ! in this)
				{
					num++;
				}
				return num;
			}
		}

		// Token: 0x06000194 RID: 404 RVA: 0x0000EECC File Offset: 0x0000D0CC
		internal virtual T TryGetFirst(out bool found)
		{
			T result;
			using (IEnumerator<T> enumerator = this.GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					found = true;
					result = enumerator.Current;
				}
				else
				{
					found = false;
					result = default(T);
				}
			}
			return result;
		}

		// Token: 0x06000195 RID: 405 RVA: 0x0000EF20 File Offset: 0x0000D120
		public virtual void Dispose()
		{
			this.current = default(T);
			this.state = -1;
		}

		// Token: 0x06000196 RID: 406 RVA: 0x0000EF35 File Offset: 0x0000D135
		public void Reset()
		{
			throw new NotSupportedException();
		}

		// Token: 0x04000259 RID: 601
		private readonly int threadId = Environment.CurrentManagedThreadId;

		// Token: 0x0400025A RID: 602
		protected int state;

		// Token: 0x0400025B RID: 603
		protected T current;
	}

	// Token: 0x02000038 RID: 56
	[Nullable(new byte[]
	{
		0,
		1
	})]
	private abstract class FilteredIterator<[Nullable(2)] T> : NoLinq.DeferredIterator<T>
	{
		// Token: 0x06000198 RID: 408 RVA: 0x0000EF4F File Offset: 0x0000D14F
		internal override IEnumerable<TOut> Select<[Nullable(2)] TOut>(Func<T, TOut> selector)
		{
			return new NoLinq.WhereSelectIterator<T, TOut>(this, selector);
		}

		// Token: 0x06000199 RID: 409 RVA: 0x0000EF58 File Offset: 0x0000D158
		internal virtual TOut TryGetFirst<[Nullable(2)] TOut>(Func<T, TOut> selector, out bool found)
		{
			T arg = this.TryGetFirst(out found);
			if (!found)
			{
				return default(TOut);
			}
			return selector(arg);
		}

		// Token: 0x0600019A RID: 410
		internal abstract NoLinq.FilteredIterator<T> Where(Func<T, bool> predicate);

		// Token: 0x0600019B RID: 411
		internal abstract List<T> ToList();

		// Token: 0x0600019C RID: 412
		internal abstract T[] ToArray();

		// Token: 0x0600019D RID: 413
		internal abstract List<TOut> SelectToList<[Nullable(2)] TOut>(Func<T, TOut> selector);

		// Token: 0x0600019E RID: 414
		internal abstract TOut[] SelectToArray<[Nullable(2)] TOut>(Func<T, TOut> selector);
	}

	// Token: 0x02000039 RID: 57
	[Nullable(new byte[]
	{
		0,
		1
	})]
	private abstract class ProjectedIterator<[Nullable(2)] T> : NoLinq.DeferredIterator<T>
	{
		// Token: 0x060001A0 RID: 416
		internal abstract List<T> ToList();

		// Token: 0x060001A1 RID: 417
		internal abstract T[] ToArray();
	}

	// Token: 0x0200003A RID: 58
	[Nullable(new byte[]
	{
		0,
		1
	})]
	private sealed class ArrayWhereIterator<[Nullable(2)] T> : NoLinq.FilteredIterator<T>
	{
		// Token: 0x060001A3 RID: 419 RVA: 0x0000EF92 File Offset: 0x0000D192
		public ArrayWhereIterator(T[] source, Func<T, bool> predicate)
		{
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x0000EFA8 File Offset: 0x0000D1A8
		protected override NoLinq.DeferredIterator<T> Clone()
		{
			return new NoLinq.ArrayWhereIterator<T>(this.<source>P, this.<predicate>P);
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x0000EFBC File Offset: 0x0000D1BC
		internal override NoLinq.FilteredIterator<T> Where(Func<T, bool> next)
		{
			return new NoLinq.ArrayWhereIterator<T>(this.<source>P, (T item) => this.<predicate>P(item) && next(item));
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x0000EFF4 File Offset: 0x0000D1F4
		internal override List<T> ToList()
		{
			return NoLinq.WhereToList<T>(this.<source>P, this.<predicate>P);
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x0000F007 File Offset: 0x0000D207
		internal override T[] ToArray()
		{
			return NoLinq.WhereSpanToArray<T>(this.<source>P, this.<predicate>P);
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x0000F01F File Offset: 0x0000D21F
		internal override T TryGetFirst(out bool found)
		{
			return NoLinq.TryGetFirstWhere<T>(this.<source>P, this.<predicate>P, out found);
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x0000F038 File Offset: 0x0000D238
		internal override List<TOut> SelectToList<[Nullable(2)] TOut>(Func<T, TOut> selector)
		{
			return NoLinq.WhereSelectToList<T, TOut>(this.<source>P, this.<predicate>P, selector);
		}

		// Token: 0x060001AA RID: 426 RVA: 0x0000F04C File Offset: 0x0000D24C
		internal override TOut[] SelectToArray<[Nullable(2)] TOut>(Func<T, TOut> selector)
		{
			return NoLinq.WhereSelectToArray<T, TOut>(this.<source>P, this.<predicate>P, selector);
		}

		// Token: 0x060001AB RID: 427 RVA: 0x0000F060 File Offset: 0x0000D260
		public override bool MoveNext()
		{
			int i = this.state - 1;
			while (i < this.<source>P.Length)
			{
				T t = this.<source>P[i++];
				this.state = i + 1;
				if (this.<predicate>P(t))
				{
					this.current = t;
					return true;
				}
			}
			this.Dispose();
			return false;
		}

		// Token: 0x0400025C RID: 604
		[CompilerGenerated]
		private T[] <source>P = source;

		// Token: 0x0400025D RID: 605
		[CompilerGenerated]
		private Func<T, bool> <predicate>P = predicate;
	}

	// Token: 0x0200003B RID: 59
	[Nullable(new byte[]
	{
		0,
		1
	})]
	private sealed class ListWhereIterator<[Nullable(2)] T> : NoLinq.FilteredIterator<T>
	{
		// Token: 0x060001AC RID: 428 RVA: 0x0000F0BB File Offset: 0x0000D2BB
		public ListWhereIterator(List<T> source, Func<T, bool> predicate)
		{
		}

		// Token: 0x060001AD RID: 429 RVA: 0x0000F0D1 File Offset: 0x0000D2D1
		protected override NoLinq.DeferredIterator<T> Clone()
		{
			return new NoLinq.ListWhereIterator<T>(this.<source>P, this.<predicate>P);
		}

		// Token: 0x060001AE RID: 430 RVA: 0x0000F0E4 File Offset: 0x0000D2E4
		internal override T TryGetFirst(out bool found)
		{
			return NoLinq.TryGetFirstWhere<T>(CollectionsMarshal.AsSpan<T>(this.<source>P), this.<predicate>P, out found);
		}

		// Token: 0x060001AF RID: 431 RVA: 0x0000F104 File Offset: 0x0000D304
		internal override NoLinq.FilteredIterator<T> Where(Func<T, bool> next)
		{
			return new NoLinq.ListWhereIterator<T>(this.<source>P, (T item) => this.<predicate>P(item) && next(item));
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x0000F13C File Offset: 0x0000D33C
		internal override List<T> ToList()
		{
			return NoLinq.WhereToList<T>(this.<source>P, this.<predicate>P);
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x0000F14F File Offset: 0x0000D34F
		internal override T[] ToArray()
		{
			return NoLinq.WhereSpanToArray<T>(CollectionsMarshal.AsSpan<T>(this.<source>P), this.<predicate>P);
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x0000F16C File Offset: 0x0000D36C
		internal override List<TOut> SelectToList<[Nullable(2)] TOut>(Func<T, TOut> selector)
		{
			return NoLinq.WhereSelectToList<T, TOut>(this.<source>P, this.<predicate>P, selector);
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x0000F180 File Offset: 0x0000D380
		internal override TOut[] SelectToArray<[Nullable(2)] TOut>(Func<T, TOut> selector)
		{
			return NoLinq.WhereSelectToArray<T, TOut>(this.<source>P, this.<predicate>P, selector);
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x0000F194 File Offset: 0x0000D394
		public override bool MoveNext()
		{
			if (this.state == 1)
			{
				this.enumerator = this.<source>P.GetEnumerator();
				this.state = 2;
			}
			if (this.state == 2)
			{
				while (this.enumerator.MoveNext())
				{
					T t = this.enumerator.Current;
					if (this.<predicate>P(t))
					{
						this.current = t;
						return true;
					}
				}
			}
			this.Dispose();
			return false;
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x0000F204 File Offset: 0x0000D404
		public override void Dispose()
		{
			this.enumerator.Dispose();
			this.enumerator = default(List<T>.Enumerator);
			base.Dispose();
		}

		// Token: 0x0400025E RID: 606
		[CompilerGenerated]
		private List<T> <source>P = source;

		// Token: 0x0400025F RID: 607
		[CompilerGenerated]
		private Func<T, bool> <predicate>P = predicate;

		// Token: 0x04000260 RID: 608
		[Nullable(new byte[]
		{
			0,
			1
		})]
		private List<T>.Enumerator enumerator;
	}

	// Token: 0x0200003C RID: 60
	[Nullable(new byte[]
	{
		0,
		1
	})]
	private sealed class EnumerableWhereIterator<[Nullable(2)] T> : NoLinq.FilteredIterator<T>
	{
		// Token: 0x060001B6 RID: 438 RVA: 0x0000F223 File Offset: 0x0000D423
		public EnumerableWhereIterator(IEnumerable<T> source, Func<T, bool> predicate)
		{
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x0000F239 File Offset: 0x0000D439
		protected override NoLinq.DeferredIterator<T> Clone()
		{
			return new NoLinq.EnumerableWhereIterator<T>(this.<source>P, this.<predicate>P);
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x0000F24C File Offset: 0x0000D44C
		internal override TOut TryGetFirst<[Nullable(2)] TOut>(Func<T, TOut> selector, out bool found)
		{
			foreach (T arg in this.<source>P)
			{
				if (this.<predicate>P(arg))
				{
					found = true;
					return selector(arg);
				}
			}
			found = false;
			return default(TOut);
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x0000F2BC File Offset: 0x0000D4BC
		internal override T TryGetFirst(out bool found)
		{
			foreach (T t in this.<source>P)
			{
				if (this.<predicate>P(t))
				{
					found = true;
					return t;
				}
			}
			found = false;
			return default(T);
		}

		// Token: 0x060001BA RID: 442 RVA: 0x0000F328 File Offset: 0x0000D528
		internal override NoLinq.FilteredIterator<T> Where(Func<T, bool> next)
		{
			return new NoLinq.EnumerableWhereIterator<T>(this.<source>P, (T item) => this.<predicate>P(item) && next(item));
		}

		// Token: 0x060001BB RID: 443 RVA: 0x0000F360 File Offset: 0x0000D560
		internal override List<T> ToList()
		{
			return NoLinq.WhereToList<T>(this.<source>P, this.<predicate>P);
		}

		// Token: 0x060001BC RID: 444 RVA: 0x0000F373 File Offset: 0x0000D573
		internal override T[] ToArray()
		{
			return NoLinq.WhereToArray<T>(this.<source>P, this.<predicate>P);
		}

		// Token: 0x060001BD RID: 445 RVA: 0x0000F386 File Offset: 0x0000D586
		internal override List<TOut> SelectToList<[Nullable(2)] TOut>(Func<T, TOut> selector)
		{
			return NoLinq.WhereSelectToList<T, TOut>(this.<source>P, this.<predicate>P, selector);
		}

		// Token: 0x060001BE RID: 446 RVA: 0x0000F39A File Offset: 0x0000D59A
		internal override TOut[] SelectToArray<[Nullable(2)] TOut>(Func<T, TOut> selector)
		{
			return NoLinq.WhereSelectToArray<T, TOut>(this.<source>P, this.<predicate>P, selector);
		}

		// Token: 0x060001BF RID: 447 RVA: 0x0000F3B0 File Offset: 0x0000D5B0
		public override bool MoveNext()
		{
			if (this.state == 1)
			{
				this.enumerator = this.<source>P.GetEnumerator();
				this.state = 2;
			}
			if (this.state == 2)
			{
				while (this.enumerator.MoveNext())
				{
					T t = this.enumerator.Current;
					if (this.<predicate>P(t))
					{
						this.current = t;
						return true;
					}
				}
			}
			this.Dispose();
			return false;
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x0000F420 File Offset: 0x0000D620
		public override void Dispose()
		{
			IEnumerator<T> enumerator = this.enumerator;
			if (enumerator != null)
			{
				enumerator.Dispose();
			}
			this.enumerator = null;
			base.Dispose();
		}

		// Token: 0x04000261 RID: 609
		[CompilerGenerated]
		private IEnumerable<T> <source>P = source;

		// Token: 0x04000262 RID: 610
		[CompilerGenerated]
		private Func<T, bool> <predicate>P = predicate;

		// Token: 0x04000263 RID: 611
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private IEnumerator<T> enumerator;
	}

	// Token: 0x0200003D RID: 61
	[Nullable(new byte[]
	{
		0,
		1
	})]
	private sealed class WhereSelectIterator<[Nullable(2)] TIn, [Nullable(2)] TOut> : NoLinq.ProjectedIterator<TOut>
	{
		// Token: 0x060001C1 RID: 449 RVA: 0x0000F440 File Offset: 0x0000D640
		public WhereSelectIterator(NoLinq.FilteredIterator<TIn> source, Func<TIn, TOut> selector)
		{
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x0000F456 File Offset: 0x0000D656
		protected override NoLinq.DeferredIterator<TOut> Clone()
		{
			return new NoLinq.WhereSelectIterator<TIn, TOut>(this.<source>P, this.<selector>P);
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x0000F46C File Offset: 0x0000D66C
		internal override IEnumerable<TNext> Select<[Nullable(2)] TNext>(Func<TOut, TNext> next)
		{
			return new NoLinq.WhereSelectIterator<TIn, TNext>(this.<source>P, ([Nullable(1)] TIn item) => next(this.<selector>P(item)));
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x0000F4A4 File Offset: 0x0000D6A4
		internal override TOut TryGetFirst(out bool found)
		{
			return this.<source>P.TryGetFirst<TOut>(this.<selector>P, out found);
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x0000F4B8 File Offset: 0x0000D6B8
		internal override List<TOut> ToList()
		{
			return this.<source>P.SelectToList<TOut>(this.<selector>P);
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x0000F4CB File Offset: 0x0000D6CB
		internal override TOut[] ToArray()
		{
			return this.<source>P.SelectToArray<TOut>(this.<selector>P);
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x0000F4E0 File Offset: 0x0000D6E0
		public override bool MoveNext()
		{
			if (this.state == 1)
			{
				this.enumerator = this.<source>P.GetEnumerator();
				this.state = 2;
			}
			if (this.state == 2 && this.enumerator.MoveNext())
			{
				this.current = this.<selector>P(this.enumerator.Current);
				return true;
			}
			this.Dispose();
			return false;
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x0000F549 File Offset: 0x0000D749
		public override void Dispose()
		{
			IEnumerator<TIn> enumerator = this.enumerator;
			if (enumerator != null)
			{
				enumerator.Dispose();
			}
			this.enumerator = null;
			base.Dispose();
		}

		// Token: 0x04000264 RID: 612
		[CompilerGenerated]
		private NoLinq.FilteredIterator<TIn> <source>P = source;

		// Token: 0x04000265 RID: 613
		[CompilerGenerated]
		private Func<TIn, TOut> <selector>P = selector;

		// Token: 0x04000266 RID: 614
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private IEnumerator<TIn> enumerator;
	}

	// Token: 0x0200003E RID: 62
	[Nullable(new byte[]
	{
		0,
		1
	})]
	private sealed class ArraySelectIterator<[Nullable(2)] TIn, [Nullable(2)] TOut> : NoLinq.ProjectedIterator<TOut>
	{
		// Token: 0x060001C9 RID: 457 RVA: 0x0000F569 File Offset: 0x0000D769
		public ArraySelectIterator(TIn[] source, Func<TIn, TOut> selector)
		{
		}

		// Token: 0x060001CA RID: 458 RVA: 0x0000F57F File Offset: 0x0000D77F
		protected override NoLinq.DeferredIterator<TOut> Clone()
		{
			return new NoLinq.ArraySelectIterator<TIn, TOut>(this.<source>P, this.<selector>P);
		}

		// Token: 0x060001CB RID: 459 RVA: 0x0000F594 File Offset: 0x0000D794
		internal override IEnumerable<TNext> Select<[Nullable(2)] TNext>(Func<TOut, TNext> next)
		{
			return new NoLinq.ArraySelectIterator<TIn, TNext>(this.<source>P, ([Nullable(1)] TIn item) => next(this.<selector>P(item)));
		}

		// Token: 0x060001CC RID: 460 RVA: 0x0000F5CC File Offset: 0x0000D7CC
		internal override int GetCount(bool onlyIfCheap)
		{
			if (!onlyIfCheap)
			{
				foreach (TIn arg in this.<source>P)
				{
					this.<selector>P(arg);
				}
			}
			return this.<source>P.Length;
		}

		// Token: 0x060001CD RID: 461 RVA: 0x0000F610 File Offset: 0x0000D810
		internal override TOut TryGetFirst(out bool found)
		{
			found = (this.<source>P.Length != 0);
			if (!found)
			{
				return default(TOut);
			}
			return this.<selector>P(this.<source>P[0]);
		}

		// Token: 0x060001CE RID: 462 RVA: 0x0000F64E File Offset: 0x0000D84E
		internal override List<TOut> ToList()
		{
			return NoLinq.SelectArrayToList<TIn, TOut>(this.<source>P, this.<selector>P);
		}

		// Token: 0x060001CF RID: 463 RVA: 0x0000F661 File Offset: 0x0000D861
		internal override TOut[] ToArray()
		{
			return NoLinq.SelectToArray<TIn, TOut>(this.<source>P, this.<selector>P);
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x0000F674 File Offset: 0x0000D874
		public override bool MoveNext()
		{
			int num = this.state - 1;
			if (num < this.<source>P.Length)
			{
				this.state++;
				this.current = this.<selector>P(this.<source>P[num]);
				return true;
			}
			this.Dispose();
			return false;
		}

		// Token: 0x04000267 RID: 615
		[CompilerGenerated]
		private TIn[] <source>P = source;

		// Token: 0x04000268 RID: 616
		[CompilerGenerated]
		private Func<TIn, TOut> <selector>P = selector;
	}

	// Token: 0x0200003F RID: 63
	[Nullable(new byte[]
	{
		0,
		1
	})]
	private sealed class ListSelectIterator<[Nullable(2)] TIn, [Nullable(2)] TOut> : NoLinq.ProjectedIterator<TOut>
	{
		// Token: 0x060001D1 RID: 465 RVA: 0x0000F6C9 File Offset: 0x0000D8C9
		public ListSelectIterator(List<TIn> source, Func<TIn, TOut> selector)
		{
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x0000F6DF File Offset: 0x0000D8DF
		protected override NoLinq.DeferredIterator<TOut> Clone()
		{
			return new NoLinq.ListSelectIterator<TIn, TOut>(this.<source>P, this.<selector>P);
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x0000F6F4 File Offset: 0x0000D8F4
		internal override IEnumerable<TNext> Select<[Nullable(2)] TNext>(Func<TOut, TNext> next)
		{
			return new NoLinq.ListSelectIterator<TIn, TNext>(this.<source>P, ([Nullable(1)] TIn item) => next(this.<selector>P(item)));
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x0000F72C File Offset: 0x0000D92C
		internal override int GetCount(bool onlyIfCheap)
		{
			int count = this.<source>P.Count;
			if (!onlyIfCheap)
			{
				for (int i = 0; i < count; i++)
				{
					this.<selector>P(this.<source>P[i]);
				}
			}
			return count;
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x0000F770 File Offset: 0x0000D970
		internal override TOut TryGetFirst(out bool found)
		{
			found = (this.<source>P.Count != 0);
			if (!found)
			{
				return default(TOut);
			}
			return this.<selector>P(this.<source>P[0]);
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x0000F7B2 File Offset: 0x0000D9B2
		internal override List<TOut> ToList()
		{
			return NoLinq.SelectListToList<TIn, TOut>(this.<source>P, this.<selector>P);
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x0000F7C5 File Offset: 0x0000D9C5
		internal override TOut[] ToArray()
		{
			return NoLinq.SelectToArray<TIn, TOut>(this.<source>P, this.<selector>P);
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x0000F7D8 File Offset: 0x0000D9D8
		public override bool MoveNext()
		{
			if (this.state == 1)
			{
				this.enumerator = this.<source>P.GetEnumerator();
				this.state = 2;
			}
			if (this.state == 2 && this.enumerator.MoveNext())
			{
				this.current = this.<selector>P(this.enumerator.Current);
				return true;
			}
			this.Dispose();
			return false;
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x0000F841 File Offset: 0x0000DA41
		public override void Dispose()
		{
			this.enumerator.Dispose();
			this.enumerator = default(List<TIn>.Enumerator);
			base.Dispose();
		}

		// Token: 0x04000269 RID: 617
		[CompilerGenerated]
		private List<TIn> <source>P = source;

		// Token: 0x0400026A RID: 618
		[CompilerGenerated]
		private Func<TIn, TOut> <selector>P = selector;

		// Token: 0x0400026B RID: 619
		[Nullable(new byte[]
		{
			0,
			1
		})]
		private List<TIn>.Enumerator enumerator;
	}

	// Token: 0x02000040 RID: 64
	[Nullable(new byte[]
	{
		0,
		1
	})]
	private sealed class EnumerableSelectIterator<[Nullable(2)] TIn, [Nullable(2)] TOut> : NoLinq.ProjectedIterator<TOut>
	{
		// Token: 0x060001DA RID: 474 RVA: 0x0000F860 File Offset: 0x0000DA60
		public EnumerableSelectIterator(IEnumerable<TIn> source, Func<TIn, TOut> selector)
		{
		}

		// Token: 0x060001DB RID: 475 RVA: 0x0000F876 File Offset: 0x0000DA76
		protected override NoLinq.DeferredIterator<TOut> Clone()
		{
			return new NoLinq.EnumerableSelectIterator<TIn, TOut>(this.<source>P, this.<selector>P);
		}

		// Token: 0x060001DC RID: 476 RVA: 0x0000F88C File Offset: 0x0000DA8C
		internal override IEnumerable<TNext> Select<[Nullable(2)] TNext>(Func<TOut, TNext> next)
		{
			return new NoLinq.EnumerableSelectIterator<TIn, TNext>(this.<source>P, ([Nullable(1)] TIn item) => next(this.<selector>P(item)));
		}

		// Token: 0x060001DD RID: 477 RVA: 0x0000F8C4 File Offset: 0x0000DAC4
		internal override List<TOut> ToList()
		{
			return NoLinq.SelectToList<TIn, TOut>(this.<source>P, this.<selector>P);
		}

		// Token: 0x060001DE RID: 478 RVA: 0x0000F8D7 File Offset: 0x0000DAD7
		internal override TOut[] ToArray()
		{
			return NoLinq.SelectToArray<TIn, TOut>(this.<source>P, this.<selector>P);
		}

		// Token: 0x060001DF RID: 479 RVA: 0x0000F8EC File Offset: 0x0000DAEC
		internal override int GetCount(bool onlyIfCheap)
		{
			if (onlyIfCheap)
			{
				NoLinq.DeferredIterator<TIn> deferredIterator = this.<source>P as NoLinq.DeferredIterator<TIn>;
				if (deferredIterator != null)
				{
					return deferredIterator.GetCount(true);
				}
			}
			return base.GetCount(onlyIfCheap);
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x0000F91C File Offset: 0x0000DB1C
		internal override TOut TryGetFirst(out bool found)
		{
			NoLinq.DeferredIterator<TIn> deferredIterator = this.<source>P as NoLinq.DeferredIterator<TIn>;
			if (deferredIterator == null)
			{
				TOut result;
				using (IEnumerator<TIn> enumerator = this.<source>P.GetEnumerator())
				{
					if (enumerator.MoveNext())
					{
						found = true;
						result = this.<selector>P(enumerator.Current);
					}
					else
					{
						found = false;
						result = default(TOut);
					}
				}
				return result;
			}
			TIn arg = deferredIterator.TryGetFirst(out found);
			if (!found)
			{
				TOut result = default(TOut);
				return result;
			}
			return this.<selector>P(arg);
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x0000F9B4 File Offset: 0x0000DBB4
		public override bool MoveNext()
		{
			if (this.state == 1)
			{
				this.enumerator = this.<source>P.GetEnumerator();
				this.state = 2;
			}
			if (this.state == 2 && this.enumerator.MoveNext())
			{
				this.current = this.<selector>P(this.enumerator.Current);
				return true;
			}
			this.Dispose();
			return false;
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x0000FA1D File Offset: 0x0000DC1D
		public override void Dispose()
		{
			IEnumerator<TIn> enumerator = this.enumerator;
			if (enumerator != null)
			{
				enumerator.Dispose();
			}
			this.enumerator = null;
			base.Dispose();
		}

		// Token: 0x0400026C RID: 620
		[CompilerGenerated]
		private IEnumerable<TIn> <source>P = source;

		// Token: 0x0400026D RID: 621
		[CompilerGenerated]
		private Func<TIn, TOut> <selector>P = selector;

		// Token: 0x0400026E RID: 622
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private IEnumerator<TIn> enumerator;
	}

	// Token: 0x02000041 RID: 65
	[Nullable(new byte[]
	{
		0,
		1
	})]
	private sealed class IListSelectIterator<[Nullable(2)] TIn, [Nullable(2)] TOut> : NoLinq.ProjectedIterator<TOut>
	{
		// Token: 0x060001E3 RID: 483 RVA: 0x0000FA3D File Offset: 0x0000DC3D
		public IListSelectIterator(IList<TIn> source, Func<TIn, TOut> selector)
		{
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x0000FA53 File Offset: 0x0000DC53
		protected override NoLinq.DeferredIterator<TOut> Clone()
		{
			return new NoLinq.IListSelectIterator<TIn, TOut>(this.<source>P, this.<selector>P);
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x0000FA68 File Offset: 0x0000DC68
		internal override IEnumerable<TNext> Select<[Nullable(2)] TNext>(Func<TOut, TNext> next)
		{
			return new NoLinq.IListSelectIterator<TIn, TNext>(this.<source>P, ([Nullable(1)] TIn item) => next(this.<selector>P(item)));
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x0000FAA0 File Offset: 0x0000DCA0
		internal override int GetCount(bool onlyIfCheap)
		{
			int count = this.<source>P.Count;
			if (!onlyIfCheap)
			{
				for (int i = 0; i < count; i++)
				{
					this.<selector>P(this.<source>P[i]);
				}
			}
			return count;
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x0000FAE4 File Offset: 0x0000DCE4
		internal override TOut TryGetFirst(out bool found)
		{
			found = (this.<source>P.Count != 0);
			if (!found)
			{
				return default(TOut);
			}
			return this.<selector>P(this.<source>P[0]);
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x0000FB28 File Offset: 0x0000DD28
		internal override List<TOut> ToList()
		{
			int count = this.<source>P.Count;
			List<TOut> list = new List<TOut>(count);
			for (int i = 0; i < count; i++)
			{
				list.Add(this.<selector>P(this.<source>P[i]));
			}
			return list;
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x0000FB74 File Offset: 0x0000DD74
		internal override TOut[] ToArray()
		{
			int count = this.<source>P.Count;
			if (count == 0)
			{
				return Array.Empty<TOut>();
			}
			TOut[] array = new TOut[count];
			for (int i = 0; i < count; i++)
			{
				array[i] = this.<selector>P(this.<source>P[i]);
			}
			return array;
		}

		// Token: 0x060001EA RID: 490 RVA: 0x0000FBC8 File Offset: 0x0000DDC8
		public override bool MoveNext()
		{
			if (this.state == 1)
			{
				this.enumerator = this.<source>P.GetEnumerator();
				this.state = 2;
			}
			if (this.state == 2 && this.enumerator.MoveNext())
			{
				this.current = this.<selector>P(this.enumerator.Current);
				return true;
			}
			this.Dispose();
			return false;
		}

		// Token: 0x060001EB RID: 491 RVA: 0x0000FC31 File Offset: 0x0000DE31
		public override void Dispose()
		{
			IEnumerator<TIn> enumerator = this.enumerator;
			if (enumerator != null)
			{
				enumerator.Dispose();
			}
			this.enumerator = null;
			base.Dispose();
		}

		// Token: 0x0400026F RID: 623
		[CompilerGenerated]
		private IList<TIn> <source>P = source;

		// Token: 0x04000270 RID: 624
		[CompilerGenerated]
		private Func<TIn, TOut> <selector>P = selector;

		// Token: 0x04000271 RID: 625
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private IEnumerator<TIn> enumerator;
	}

	// Token: 0x02000042 RID: 66
	[Nullable(new byte[]
	{
		0,
		1
	})]
	private sealed class DistinctQuery<[Nullable(2)] T> : NoLinq.DeferredIterator<T>
	{
		// Token: 0x060001EC RID: 492 RVA: 0x0000FC51 File Offset: 0x0000DE51
		public DistinctQuery(IEnumerable<T> source)
		{
		}

		// Token: 0x060001ED RID: 493 RVA: 0x0000FC60 File Offset: 0x0000DE60
		protected override NoLinq.DeferredIterator<T> Clone()
		{
			return new NoLinq.DistinctQuery<T>(this.<source>P);
		}

		// Token: 0x060001EE RID: 494 RVA: 0x0000FC6D File Offset: 0x0000DE6D
		internal override T TryGetFirst(out bool found)
		{
			return NoLinq.TryGetFirst<T>(this.<source>P, out found);
		}

		// Token: 0x060001EF RID: 495 RVA: 0x0000FC7B File Offset: 0x0000DE7B
		internal List<T> ToList()
		{
			return new List<T>(new HashSet<T>(this.<source>P));
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x0000FC8D File Offset: 0x0000DE8D
		internal T[] ToArray()
		{
			return NoLinq.ToArray<T>(new HashSet<T>(this.<source>P));
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x0000FCA0 File Offset: 0x0000DEA0
		public override bool MoveNext()
		{
			if (this.state != 1)
			{
				if (this.state == 2)
				{
					while (this.enumerator.MoveNext())
					{
						T t = this.enumerator.Current;
						if (this.seen.Add(t))
						{
							this.current = t;
							return true;
						}
					}
				}
				this.Dispose();
				return false;
			}
			this.enumerator = this.<source>P.GetEnumerator();
			if (!this.enumerator.MoveNext())
			{
				this.Dispose();
				return false;
			}
			this.current = this.enumerator.Current;
			this.seen = new HashSet<T>(7);
			this.seen.Add(this.current);
			this.state = 2;
			return true;
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x0000FD56 File Offset: 0x0000DF56
		public override void Dispose()
		{
			IEnumerator<T> enumerator = this.enumerator;
			if (enumerator != null)
			{
				enumerator.Dispose();
			}
			this.enumerator = null;
			this.seen = null;
			base.Dispose();
		}

		// Token: 0x04000272 RID: 626
		[CompilerGenerated]
		private IEnumerable<T> <source>P = source;

		// Token: 0x04000273 RID: 627
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private IEnumerator<T> enumerator;

		// Token: 0x04000274 RID: 628
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private HashSet<T> seen;
	}

	// Token: 0x02000043 RID: 67
	[Nullable(0)]
	private sealed class GroupLookup<[Nullable(2)] TKey, [Nullable(2)] T>
	{
		// Token: 0x060001F3 RID: 499 RVA: 0x0000FD80 File Offset: 0x0000DF80
		internal void Add(TKey key, T item)
		{
			int num = (key == null) ? 0 : (this.comparer.GetHashCode(key) & int.MaxValue);
			int num2 = num % this.buckets.Length;
			NoLinq.Group<TKey, T> group2;
			checked
			{
				for (NoLinq.Group<TKey, T> group = this.buckets[num2]; group != null; group = group.HashNext)
				{
					if (group.HashCode == num && this.comparer.Equals(group.Key, key))
					{
						group.Add(item);
						this.ItemCount++;
						return;
					}
				}
				if (this.groupCount == this.buckets.Length)
				{
					this.Resize();
					num2 = num % this.buckets.Length;
				}
				group2 = new NoLinq.Group<TKey, T>(key, num)
				{
					HashNext = this.buckets[num2]
				};
				this.buckets[num2] = group2;
				if (this.Last == null)
				{
					group2.Next = group2;
				}
				else
				{
					group2.Next = this.Last.Next;
					this.Last.Next = group2;
				}
				this.Last = group2;
			}
			this.groupCount++;
			group2.Add(item);
			checked
			{
				this.ItemCount++;
			}
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x0000FE98 File Offset: 0x0000E098
		private void Resize()
		{
			NoLinq.Group<TKey, T>[] array = new NoLinq.Group<TKey, T>[checked(this.groupCount * 2 + 1)];
			NoLinq.Group<TKey, T> group = this.Last;
			do
			{
				group = group.Next;
				int num = group.HashCode % array.Length;
				group.HashNext = array[num];
				array[num] = group;
			}
			while (group != this.Last);
			this.buckets = array;
		}

		// Token: 0x04000275 RID: 629
		private readonly IEqualityComparer<TKey> comparer = EqualityComparer<TKey>.Default;

		// Token: 0x04000276 RID: 630
		[Nullable(new byte[]
		{
			1,
			2,
			1,
			1
		})]
		private NoLinq.Group<TKey, T>[] buckets = new NoLinq.Group<TKey, T>[7];

		// Token: 0x04000277 RID: 631
		private int groupCount;

		// Token: 0x04000278 RID: 632
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		internal NoLinq.Group<TKey, T> Last;

		// Token: 0x04000279 RID: 633
		internal int ItemCount;
	}

	// Token: 0x02000044 RID: 68
	private interface ArraySource<[Nullable(2)] T>
	{
		// Token: 0x060001F6 RID: 502
		T[] ToArray();
	}

	// Token: 0x02000045 RID: 69
	[Nullable(0)]
	public sealed class Group<[Nullable(2)] TKey, [Nullable(2)] T> : IReadOnlyList<T>, IEnumerable<!1>, IEnumerable, IReadOnlyCollection<T>, NoLinq.ArraySource<T>
	{
		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060001F7 RID: 503 RVA: 0x0000FF0A File Offset: 0x0000E10A
		public TKey Key { get; }

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060001F8 RID: 504 RVA: 0x0000FF12 File Offset: 0x0000E112
		// (set) Token: 0x060001F9 RID: 505 RVA: 0x0000FF1A File Offset: 0x0000E11A
		public int Count { get; private set; }

		// Token: 0x17000034 RID: 52
		public T this[int index]
		{
			get
			{
				if (index >= this.Count)
				{
					throw new ArgumentOutOfRangeException("index");
				}
				if (this.items != null)
				{
					return this.items[index];
				}
				return this.first;
			}
		}

		// Token: 0x060001FB RID: 507 RVA: 0x0000FF54 File Offset: 0x0000E154
		internal Group(TKey key, int hashCode)
		{
			this.Key = key;
			this.HashCode = hashCode;
		}

		// Token: 0x060001FC RID: 508 RVA: 0x0000FF6C File Offset: 0x0000E16C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void Add(T item)
		{
			if (this.Count == 0)
			{
				this.first = item;
			}
			else
			{
				if (this.items == null)
				{
					this.items = new T[2];
					this.items[0] = this.first;
				}
				else if (this.Count == this.items.Length)
				{
					Array.Resize<T>(ref this.items, checked(this.items.Length * 2));
				}
				this.items[this.Count] = item;
			}
			int count = this.Count;
			this.Count = count + 1;
		}

		// Token: 0x060001FD RID: 509 RVA: 0x0000FFFC File Offset: 0x0000E1FC
		public T[] ToArray()
		{
			if (this.Count == 0)
			{
				return Array.Empty<T>();
			}
			T[] array = new T[this.Count];
			array[0] = this.first;
			if (this.Count > 1)
			{
				Array.Copy(this.items, 1, array, 1, this.Count - 1);
			}
			return array;
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00010050 File Offset: 0x0000E250
		[NullableContext(0)]
		public NoLinq.Group<TKey, T>.Enumerator GetEnumerator()
		{
			return new NoLinq.Group<TKey, T>.Enumerator(this);
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00010058 File Offset: 0x0000E258
		IEnumerator<T> IEnumerable<!1>.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00010065 File Offset: 0x0000E265
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x0400027A RID: 634
		private T first;

		// Token: 0x0400027B RID: 635
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private T[] items;

		// Token: 0x0400027C RID: 636
		internal readonly int HashCode;

		// Token: 0x0400027D RID: 637
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		internal NoLinq.Group<TKey, T> HashNext;

		// Token: 0x0400027E RID: 638
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		internal NoLinq.Group<TKey, T> Next;

		// Token: 0x02000071 RID: 113
		[Nullable(0)]
		public struct Enumerator : IEnumerator<!1>, IEnumerator, IDisposable
		{
			// Token: 0x06000294 RID: 660 RVA: 0x000125ED File Offset: 0x000107ED
			internal Enumerator(NoLinq.Group<TKey, T> group)
			{
				this.group = group;
				this.index = -1;
			}

			// Token: 0x17000044 RID: 68
			// (get) Token: 0x06000295 RID: 661 RVA: 0x00012600 File Offset: 0x00010800
			public T Current
			{
				get
				{
					if (this.index < 0 || this.index >= this.group.Count)
					{
						return default(T);
					}
					return this.group[this.index];
				}
			}

			// Token: 0x17000045 RID: 69
			// (get) Token: 0x06000296 RID: 662 RVA: 0x00012644 File Offset: 0x00010844
			[Nullable(2)]
			object IEnumerator.Current
			{
				[NullableContext(2)]
				get
				{
					if (this.index < 0 || this.index >= this.group.Count)
					{
						throw new InvalidOperationException();
					}
					return this.Current;
				}
			}

			// Token: 0x06000297 RID: 663 RVA: 0x0001267E File Offset: 0x0001087E
			public bool MoveNext()
			{
				if (this.index < this.group.Count)
				{
					this.index++;
				}
				return this.index < this.group.Count;
			}

			// Token: 0x06000298 RID: 664 RVA: 0x000126B4 File Offset: 0x000108B4
			public void Reset()
			{
				this.index = -1;
			}

			// Token: 0x06000299 RID: 665 RVA: 0x000126BD File Offset: 0x000108BD
			public void Dispose()
			{
			}

			// Token: 0x04000348 RID: 840
			private readonly NoLinq.Group<TKey, T> group;

			// Token: 0x04000349 RID: 841
			private int index;
		}
	}

	// Token: 0x02000046 RID: 70
	[Nullable(0)]
	private readonly struct ThreeKeyComparer<[Nullable(2)] TKey1, [Nullable(2)] TKey2, [Nullable(2)] TKey3> : IComparer<int>
	{
		// Token: 0x06000201 RID: 513 RVA: 0x00010072 File Offset: 0x0000E272
		internal ThreeKeyComparer(TKey1[] keys1, TKey2[] keys2, TKey3[] keys3, bool descending)
		{
			this.keys1 = keys1;
			this.keys2 = keys2;
			this.keys3 = keys3;
			this.comparer1 = Comparer<TKey1>.Default;
			this.comparer2 = Comparer<TKey2>.Default;
			this.comparer3 = Comparer<TKey3>.Default;
			this.descending = descending;
		}

		// Token: 0x06000202 RID: 514 RVA: 0x000100B4 File Offset: 0x0000E2B4
		public int Compare(int left, int right)
		{
			int num = this.comparer1.Compare(this.keys1[left], this.keys1[right]);
			if (num != 0)
			{
				if (!this.descending)
				{
					return num;
				}
				if (num <= 0)
				{
					return 1;
				}
				return -1;
			}
			else
			{
				num = this.comparer2.Compare(this.keys2[left], this.keys2[right]);
				if (num != 0)
				{
					return num;
				}
				num = this.comparer3.Compare(this.keys3[left], this.keys3[right]);
				if (num == 0)
				{
					return left - right;
				}
				return num;
			}
		}

		// Token: 0x04000281 RID: 641
		private readonly TKey1[] keys1;

		// Token: 0x04000282 RID: 642
		private readonly TKey2[] keys2;

		// Token: 0x04000283 RID: 643
		private readonly TKey3[] keys3;

		// Token: 0x04000284 RID: 644
		private readonly IComparer<TKey1> comparer1;

		// Token: 0x04000285 RID: 645
		private readonly IComparer<TKey2> comparer2;

		// Token: 0x04000286 RID: 646
		private readonly IComparer<TKey3> comparer3;

		// Token: 0x04000287 RID: 647
		private readonly bool descending;
	}

	// Token: 0x02000047 RID: 71
	[Nullable(0)]
	private readonly struct FourKeyComparer<[Nullable(2)] TKey1, [Nullable(2)] TKey2, [Nullable(2)] TKey3, [Nullable(2)] TKey4> : IComparer<int>
	{
		// Token: 0x06000203 RID: 515 RVA: 0x00010150 File Offset: 0x0000E350
		internal FourKeyComparer(TKey1[] keys1, TKey2[] keys2, TKey3[] keys3, TKey4[] keys4)
		{
			this.keys1 = keys1;
			this.keys2 = keys2;
			this.keys3 = keys3;
			this.keys4 = keys4;
			this.comparer1 = Comparer<TKey1>.Default;
			this.comparer2 = Comparer<TKey2>.Default;
			this.comparer3 = Comparer<TKey3>.Default;
			this.comparer4 = Comparer<TKey4>.Default;
		}

		// Token: 0x06000204 RID: 516 RVA: 0x000101A8 File Offset: 0x0000E3A8
		public int Compare(int left, int right)
		{
			int num = this.comparer1.Compare(this.keys1[left], this.keys1[right]);
			if (num != 0)
			{
				if (num <= 0)
				{
					return 1;
				}
				return -1;
			}
			else
			{
				num = this.comparer2.Compare(this.keys2[left], this.keys2[right]);
				if (num != 0)
				{
					return num;
				}
				num = this.comparer3.Compare(this.keys3[left], this.keys3[right]);
				if (num != 0)
				{
					return num;
				}
				num = this.comparer4.Compare(this.keys4[left], this.keys4[right]);
				if (num == 0)
				{
					return left - right;
				}
				return num;
			}
		}

		// Token: 0x04000288 RID: 648
		private readonly TKey1[] keys1;

		// Token: 0x04000289 RID: 649
		private readonly TKey2[] keys2;

		// Token: 0x0400028A RID: 650
		private readonly TKey3[] keys3;

		// Token: 0x0400028B RID: 651
		private readonly TKey4[] keys4;

		// Token: 0x0400028C RID: 652
		private readonly IComparer<TKey1> comparer1;

		// Token: 0x0400028D RID: 653
		private readonly IComparer<TKey2> comparer2;

		// Token: 0x0400028E RID: 654
		private readonly IComparer<TKey3> comparer3;

		// Token: 0x0400028F RID: 655
		private readonly IComparer<TKey4> comparer4;
	}

	// Token: 0x02000048 RID: 72
	[Nullable(0)]
	private readonly struct RankedItem<[Nullable(2)] T, [Nullable(2)] TKey>
	{
		// Token: 0x06000205 RID: 517 RVA: 0x00010262 File Offset: 0x0000E462
		public RankedItem(T item, TKey key, long index)
		{
			this.Item = item;
			this.Key = key;
			this.Index = index;
		}

		// Token: 0x04000290 RID: 656
		public readonly T Item;

		// Token: 0x04000291 RID: 657
		public readonly TKey Key;

		// Token: 0x04000292 RID: 658
		public readonly long Index;
	}

	// Token: 0x02000049 RID: 73
	private interface IOrderedQuery<[Nullable(2)] T>
	{
		// Token: 0x06000206 RID: 518
		List<T> ToList();

		// Token: 0x06000207 RID: 519
		T[] ToArray();
	}

	// Token: 0x0200004A RID: 74
	[Nullable(new byte[]
	{
		0,
		1
	})]
	private sealed class OrderedQuery<[Nullable(2)] T, [Nullable(2)] TKey> : NoLinq.DeferredIterator<T>, NoLinq.IOrderedQuery<T>
	{
		// Token: 0x06000208 RID: 520 RVA: 0x00010279 File Offset: 0x0000E479
		public OrderedQuery(IEnumerable<T> source, Func<T, TKey> keySelector)
		{
		}

		// Token: 0x06000209 RID: 521 RVA: 0x0001028F File Offset: 0x0000E48F
		protected override NoLinq.DeferredIterator<T> Clone()
		{
			return new NoLinq.OrderedQuery<T, TKey>(this.<source>P, this.<keySelector>P);
		}

		// Token: 0x0600020A RID: 522 RVA: 0x000102A4 File Offset: 0x0000E4A4
		internal override int GetCount(bool onlyIfCheap)
		{
			NoLinq.DeferredIterator<T> deferredIterator = this.<source>P as NoLinq.DeferredIterator<T>;
			if (deferredIterator != null)
			{
				return deferredIterator.GetCount(onlyIfCheap);
			}
			ICollection<T> collection = this.<source>P as ICollection<T>;
			if (collection != null)
			{
				return collection.Count;
			}
			ICollection collection2 = this.<source>P as ICollection;
			if (collection2 != null)
			{
				return collection2.Count;
			}
			if (onlyIfCheap)
			{
				return -1;
			}
			int num = 0;
			checked
			{
				foreach (!0 ! in this.<source>P)
				{
					num++;
				}
				return num;
			}
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00010340 File Offset: 0x0000E540
		internal override T TryGetFirst(out bool found)
		{
			T t;
			using (IEnumerator<T> enumerator = this.<source>P.GetEnumerator())
			{
				if (!enumerator.MoveNext())
				{
					found = false;
					t = default(T);
					t = t;
				}
				else
				{
					T t2 = enumerator.Current;
					TKey y = this.<keySelector>P(t2);
					Comparer<TKey> @default = Comparer<TKey>.Default;
					while (enumerator.MoveNext())
					{
						T t3 = enumerator.Current;
						TKey tkey = this.<keySelector>P(t3);
						if (@default.Compare(tkey, y) < 0)
						{
							t2 = t3;
							y = tkey;
						}
					}
					found = true;
					t = t2;
				}
			}
			return t;
		}

		// Token: 0x0600020C RID: 524 RVA: 0x000103E4 File Offset: 0x0000E5E4
		public List<T> ToList()
		{
			return NoLinq.OrderByToList<T, TKey>(this.<source>P, this.<keySelector>P);
		}

		// Token: 0x0600020D RID: 525 RVA: 0x000103F7 File Offset: 0x0000E5F7
		public T[] ToArray()
		{
			return NoLinq.OrderByToArray<T, TKey>(this.<source>P, this.<keySelector>P);
		}

		// Token: 0x0600020E RID: 526 RVA: 0x0001040C File Offset: 0x0000E60C
		public override bool MoveNext()
		{
			if (this.state == 1)
			{
				this.order = NoLinq.GetSortedOrder<T, TKey, TKey>(this.<source>P, this.<keySelector>P, null, null, null, out this.items, false);
				this.state = 2;
			}
			int num = this.state - 2;
			if (this.order != null && num < this.order.Length)
			{
				this.current = this.items[this.order[num]];
				this.state++;
				return true;
			}
			this.Dispose();
			return false;
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00010496 File Offset: 0x0000E696
		public override void Dispose()
		{
			this.items = null;
			this.order = null;
			base.Dispose();
		}

		// Token: 0x04000293 RID: 659
		[CompilerGenerated]
		private IEnumerable<T> <source>P = source;

		// Token: 0x04000294 RID: 660
		[CompilerGenerated]
		private Func<T, TKey> <keySelector>P = keySelector;

		// Token: 0x04000295 RID: 661
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private T[] items;

		// Token: 0x04000296 RID: 662
		[Nullable(2)]
		private int[] order;
	}

	// Token: 0x0200004B RID: 75
	[NullableContext(0)]
	private static class DescendingComparer<[Nullable(2)] T>
	{
		// Token: 0x04000297 RID: 663
		[Nullable(1)]
		public static readonly IComparer<T> Instance = Comparer<T>.Create(delegate(T left, T right)
		{
			int num = Comparer<T>.Default.Compare(left, right);
			if (num == 0)
			{
				return 0;
			}
			if (num <= 0)
			{
				return 1;
			}
			return -1;
		});
	}

	// Token: 0x0200004C RID: 76
	[NullableContext(0)]
	[InlineArray(8)]
	private struct ScratchBuffer<[Nullable(2)] T>
	{
		// Token: 0x04000298 RID: 664
		[Nullable(1)]
		private T item;
	}

	// Token: 0x0200004D RID: 77
	[Nullable(0)]
	[CompilerFeatureRequired("RefStructs")]
	private ref struct PooledArrayBuilder<[Nullable(2)] T>
	{
		// Token: 0x06000211 RID: 529 RVA: 0x000104C8 File Offset: 0x0000E6C8
		public PooledArrayBuilder([Nullable(new byte[]
		{
			0,
			1
		})] Span<T> scratch)
		{
			this = default(NoLinq.PooledArrayBuilder<T>);
			this.scratch = scratch;
			this.current = scratch;
		}

		// Token: 0x06000212 RID: 530 RVA: 0x000104E0 File Offset: 0x0000E6E0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe void Add(T item)
		{
			Span<T> span = this.current;
			int num = this.currentCount;
			if (num < span.Length)
			{
				*span[num] = item;
				this.currentCount = num + 1;
				return;
			}
			this.AddSlow(item);
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00010524 File Offset: 0x0000E724
		public unsafe void AddWhere([Nullable(new byte[]
		{
			0,
			1
		})] ReadOnlySpan<T> source, Func<T, bool> predicate)
		{
			Span<T> span = this.current;
			int num = this.currentCount;
			try
			{
				ReadOnlySpan<T> readOnlySpan = source;
				for (int i = 0; i < readOnlySpan.Length; i++)
				{
					T t = *readOnlySpan[i];
					if (predicate(t))
					{
						if (num < span.Length)
						{
							*span[num++] = t;
						}
						else
						{
							this.currentCount = num;
							this.Grow();
							span = this.current;
							*span[0] = t;
							num = 1;
						}
					}
				}
			}
			finally
			{
				this.currentCount = num;
			}
		}

		// Token: 0x06000214 RID: 532 RVA: 0x000105CC File Offset: 0x0000E7CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe void AddSlow(T item)
		{
			this.Grow();
			*this.current[0] = item;
			this.currentCount = 1;
		}

		// Token: 0x06000215 RID: 533 RVA: 0x000105F0 File Offset: 0x0000E7F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe void Grow()
		{
			int num = checked(this.completedCount + this.currentCount);
			if (num >= Array.MaxLength)
			{
				throw new OutOfMemoryException();
			}
			int minimumLength = (int)Math.Min(Math.Max(16L, (long)this.current.Length * 2L), (long)Array.MaxLength);
			T[] array = ArrayPool<T>.Shared.Rent(minimumLength);
			Span<T[]> span = <PrivateImplementationDetails>.InlineArrayAsSpan<NoLinq.PooledArrayBuilder<T>.Segments, T[]>(ref this.segments, 27);
			int num2 = this.segmentCount;
			this.segmentCount = num2 + 1;
			*span[num2] = array;
			this.completedCount = num;
			this.currentCount = 0;
			this.current = array;
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000216 RID: 534 RVA: 0x0001068E File Offset: 0x0000E88E
		public readonly int Count
		{
			get
			{
				return checked(this.completedCount + this.currentCount);
			}
		}

		// Token: 0x06000217 RID: 535 RVA: 0x000106A0 File Offset: 0x0000E8A0
		public readonly T[] ToArray()
		{
			int num = checked(this.completedCount + this.currentCount);
			if (num == 0)
			{
				return Array.Empty<T>();
			}
			T[] array = new T[num];
			this.CopyTo(array);
			return array;
		}

		// Token: 0x06000218 RID: 536 RVA: 0x000106D8 File Offset: 0x0000E8D8
		public readonly List<T> ToList()
		{
			int num = checked(this.completedCount + this.currentCount);
			List<T> list = new List<T>(num);
			CollectionsMarshal.SetCount<T>(list, num);
			this.CopyTo(CollectionsMarshal.AsSpan<T>(list));
			return list;
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00010710 File Offset: 0x0000E910
		public unsafe readonly void CopyTo([Nullable(new byte[]
		{
			0,
			1
		})] Span<T> result)
		{
			if (this.segmentCount == 0)
			{
				this.current.Slice(0, this.currentCount).CopyTo(result);
				return;
			}
			this.scratch.CopyTo(result);
			int num = this.scratch.Length;
			for (int i = 0; i < this.segmentCount; i++)
			{
				T[] array = *<PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<NoLinq.PooledArrayBuilder<T>.Segments, T[]>(this.segments, 27)[i];
				int num2 = (i == this.segmentCount - 1) ? this.currentCount : array.Length;
				array.AsSpan(0, num2).CopyTo(result.Slice(num));
				num += num2;
			}
		}

		// Token: 0x0600021A RID: 538 RVA: 0x000107BC File Offset: 0x0000E9BC
		public unsafe void Dispose()
		{
			bool flag = RuntimeHelpers.IsReferenceOrContainsReferences<T>();
			for (int i = 0; i < this.segmentCount; i++)
			{
				T[] array = *<PrivateImplementationDetails>.InlineArrayAsSpan<NoLinq.PooledArrayBuilder<T>.Segments, T[]>(ref this.segments, 27)[i];
				if (flag)
				{
					Array.Clear(array, 0, (i == this.segmentCount - 1) ? this.currentCount : array.Length);
				}
				ArrayPool<T>.Shared.Return(array, false);
				*<PrivateImplementationDetails>.InlineArrayAsSpan<NoLinq.PooledArrayBuilder<T>.Segments, T[]>(ref this.segments, 27)[i] = null;
			}
			this.segmentCount = 0;
		}

		// Token: 0x04000299 RID: 665
		[Nullable(0)]
		private NoLinq.PooledArrayBuilder<T>.Segments segments;

		// Token: 0x0400029A RID: 666
		[Nullable(new byte[]
		{
			0,
			1
		})]
		private readonly Span<T> scratch;

		// Token: 0x0400029B RID: 667
		[Nullable(new byte[]
		{
			0,
			1
		})]
		private Span<T> current;

		// Token: 0x0400029C RID: 668
		private int segmentCount;

		// Token: 0x0400029D RID: 669
		private int completedCount;

		// Token: 0x0400029E RID: 670
		private int currentCount;

		// Token: 0x02000073 RID: 115
		[NullableContext(0)]
		[InlineArray(27)]
		private struct Segments
		{
			// Token: 0x0400034B RID: 843
			[Nullable(1)]
			private T[] segment;
		}
	}
}
