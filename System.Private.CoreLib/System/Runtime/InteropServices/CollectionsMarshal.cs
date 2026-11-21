using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Runtime.InteropServices
{
	// Token: 0x020005B3 RID: 1459
	[NullableContext(1)]
	[Nullable(0)]
	public static class CollectionsMarshal
	{
		// Token: 0x06006FD1 RID: 28625 RVA: 0x0010D4B8 File Offset: 0x0010B6B8
		[NullableContext(2)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Span<T> AsSpan<T>([Nullable(new byte[]
		{
			2,
			1
		})] List<T> list)
		{
			Span<T> result = default(Span<T>);
			if (list != null)
			{
				int size = list._size;
				T[] items = list._items;
				if (size > items.Length)
				{
					ThrowHelper.ThrowInvalidOperationException_ConcurrentOperationsNotSupported();
				}
				result = new Span<T>(MemoryMarshal.GetArrayDataReference<T>(items), size);
			}
			return result;
		}

		// Token: 0x06006FD2 RID: 28626 RVA: 0x0010D4F7 File Offset: 0x0010B6F7
		public static ref TValue GetValueRefOrNullRef<TKey, [Nullable(2)] TValue>(Dictionary<TKey, TValue> dictionary, TKey key)
		{
			return dictionary.FindValue(key);
		}

		// Token: 0x06006FD3 RID: 28627 RVA: 0x0010D500 File Offset: 0x0010B700
		public static ref TValue GetValueRefOrNullRef<TKey, [Nullable(2)] TValue, TAlternateKey>([Nullable(new byte[]
		{
			0,
			1,
			1,
			1
		})] Dictionary<TKey, TValue>.AlternateLookup<TAlternateKey> dictionary, TAlternateKey key)
		{
			TKey tkey;
			return dictionary.FindValue(key, out tkey);
		}

		// Token: 0x06006FD4 RID: 28628 RVA: 0x0010D517 File Offset: 0x0010B717
		[return: Nullable(2)]
		public static ref TValue GetValueRefOrAddDefault<TKey, [Nullable(2)] TValue>(Dictionary<TKey, TValue> dictionary, TKey key, out bool exists)
		{
			return Dictionary<TKey, TValue>.CollectionsMarshalHelper.GetValueRefOrAddDefault(dictionary, key, out exists);
		}

		// Token: 0x06006FD5 RID: 28629 RVA: 0x0010D521 File Offset: 0x0010B721
		[return: Nullable(2)]
		public static ref TValue GetValueRefOrAddDefault<TKey, [Nullable(2)] TValue, TAlternateKey>([Nullable(new byte[]
		{
			0,
			1,
			1,
			1
		})] Dictionary<TKey, TValue>.AlternateLookup<TAlternateKey> dictionary, TAlternateKey key, out bool exists)
		{
			return dictionary.GetValueRefOrAddDefault(key, out exists);
		}

		// Token: 0x06006FD6 RID: 28630 RVA: 0x0010D52C File Offset: 0x0010B72C
		public static void SetCount<[Nullable(2)] T>(List<T> list, int count)
		{
			if (count < 0)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException_NeedNonNegNum("count");
			}
			list._version++;
			if (count > list.Capacity)
			{
				list.Grow(count);
			}
			else if (count < list._size && RuntimeHelpers.IsReferenceOrContainsReferences<T>())
			{
				Array.Clear(list._items, count, list._size - count);
			}
			list._size = count;
		}
	}
}
