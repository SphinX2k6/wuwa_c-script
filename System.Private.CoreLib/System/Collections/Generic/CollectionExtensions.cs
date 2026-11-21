using System;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Collections.Generic
{
	// Token: 0x020009A8 RID: 2472
	[NullableContext(1)]
	[Nullable(0)]
	public static class CollectionExtensions
	{
		// Token: 0x06009200 RID: 37376 RVA: 0x0016ADC8 File Offset: 0x00168FC8
		[NullableContext(2)]
		public static TValue GetValueOrDefault<TKey, TValue>([Nullable(1)] this IReadOnlyDictionary<TKey, TValue> dictionary, [Nullable(1)] TKey key)
		{
			return dictionary.GetValueOrDefault(key, default(TValue));
		}

		// Token: 0x06009201 RID: 37377 RVA: 0x0016ADE8 File Offset: 0x00168FE8
		public static TValue GetValueOrDefault<[Nullable(2)] TKey, [Nullable(2)] TValue>(this IReadOnlyDictionary<TKey, TValue> dictionary, TKey key, TValue defaultValue)
		{
			if (dictionary == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.dictionary);
			}
			TValue result;
			if (!dictionary.TryGetValue(key, out result))
			{
				return defaultValue;
			}
			return result;
		}

		// Token: 0x06009202 RID: 37378 RVA: 0x0016AE0C File Offset: 0x0016900C
		public static bool TryAdd<[Nullable(2)] TKey, [Nullable(2)] TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, TValue value)
		{
			if (dictionary == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.dictionary);
			}
			if (!dictionary.ContainsKey(key))
			{
				dictionary.Add(key, value);
				return true;
			}
			return false;
		}

		// Token: 0x06009203 RID: 37379 RVA: 0x0016AE2B File Offset: 0x0016902B
		public static bool Remove<[Nullable(2)] TKey, [Nullable(2)] TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, [MaybeNullWhen(false)] out TValue value)
		{
			if (dictionary == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.dictionary);
			}
			if (dictionary.TryGetValue(key, out value))
			{
				dictionary.Remove(key);
				return true;
			}
			value = default(TValue);
			return false;
		}

		// Token: 0x06009204 RID: 37380 RVA: 0x0016AE52 File Offset: 0x00169052
		public static ReadOnlyCollection<T> AsReadOnly<[Nullable(2)] T>(this IList<T> list)
		{
			return new ReadOnlyCollection<T>(list);
		}

		// Token: 0x06009205 RID: 37381 RVA: 0x0016AE5A File Offset: 0x0016905A
		public static ReadOnlyDictionary<TKey, TValue> AsReadOnly<TKey, [Nullable(2)] TValue>(this IDictionary<TKey, TValue> dictionary)
		{
			return new ReadOnlyDictionary<TKey, TValue>(dictionary);
		}

		// Token: 0x06009206 RID: 37382 RVA: 0x0016AE64 File Offset: 0x00169064
		public static void AddRange<[Nullable(2)] T>(this List<T> list, [ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			1
		})] ReadOnlySpan<T> source)
		{
			if (list == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.list);
			}
			if (!source.IsEmpty)
			{
				if (list._items.Length - list._size < source.Length)
				{
					list.Grow(checked(list._size + source.Length));
				}
				source.CopyTo(list._items.AsSpan(list._size));
				list._size += source.Length;
				list._version++;
			}
		}

		// Token: 0x06009207 RID: 37383 RVA: 0x0016AEEC File Offset: 0x001690EC
		public static void InsertRange<[Nullable(2)] T>(this List<T> list, int index, [ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			1
		})] ReadOnlySpan<T> source)
		{
			if (list == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.list);
			}
			if (index > list._size)
			{
				ThrowHelper.ThrowArgumentOutOfRange_IndexMustBeLessOrEqualException();
			}
			if (!source.IsEmpty)
			{
				if (list._items.Length - list._size < source.Length)
				{
					list.Grow(checked(list._size + source.Length));
				}
				if (index < list._size)
				{
					Array.Copy(list._items, index, list._items, index + source.Length, list._size - index);
				}
				source.CopyTo(list._items.AsSpan(index));
				list._size += source.Length;
				list._version++;
			}
		}

		// Token: 0x06009208 RID: 37384 RVA: 0x0016AFAC File Offset: 0x001691AC
		public static void CopyTo<[Nullable(2)] T>(this List<T> list, [Nullable(new byte[]
		{
			0,
			1
		})] Span<T> destination)
		{
			if (list == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.list);
			}
			new ReadOnlySpan<T>(list._items, 0, list._size).CopyTo(destination);
		}
	}
}
