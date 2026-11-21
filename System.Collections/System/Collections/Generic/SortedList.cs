using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Collections.Generic
{
	// Token: 0x0200002F RID: 47
	[NullableContext(1)]
	[Nullable(0)]
	[DebuggerTypeProxy(typeof(IDictionaryDebugView<, >))]
	[DebuggerDisplay("Count = {Count}")]
	[TypeForwardedFrom("System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class SortedList<TKey, [Nullable(2)] TValue> : IDictionary<!0, !1>, ICollection<KeyValuePair<!0, !1>>, IEnumerable<KeyValuePair<!0, !1>>, IEnumerable, IDictionary, ICollection, IReadOnlyDictionary<!0, !1>, IReadOnlyCollection<KeyValuePair<TKey, TValue>>
	{
		// Token: 0x0600020F RID: 527 RVA: 0x000083E9 File Offset: 0x000065E9
		public SortedList()
		{
			this.keys = Array.Empty<TKey>();
			this.values = Array.Empty<TValue>();
			this._size = 0;
			this.comparer = Comparer<TKey>.Default;
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00008419 File Offset: 0x00006619
		public SortedList(int capacity)
		{
			ArgumentOutOfRangeException.ThrowIfNegative<int>(capacity, "capacity");
			this.keys = new TKey[capacity];
			this.values = new TValue[capacity];
			this.comparer = Comparer<TKey>.Default;
		}

		// Token: 0x06000211 RID: 529 RVA: 0x0000844F File Offset: 0x0000664F
		public SortedList([Nullable(new byte[]
		{
			2,
			1
		})] IComparer<TKey> comparer) : this()
		{
			if (comparer != null)
			{
				this.comparer = comparer;
			}
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00008461 File Offset: 0x00006661
		public SortedList(int capacity, [Nullable(new byte[]
		{
			2,
			1
		})] IComparer<TKey> comparer) : this(comparer)
		{
			this.Capacity = capacity;
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00008471 File Offset: 0x00006671
		public SortedList(IDictionary<TKey, TValue> dictionary) : this(dictionary, null)
		{
		}

		// Token: 0x06000214 RID: 532 RVA: 0x0000847C File Offset: 0x0000667C
		public SortedList(IDictionary<TKey, TValue> dictionary, [Nullable(new byte[]
		{
			2,
			1
		})] IComparer<TKey> comparer)
		{
			if (dictionary == null)
			{
				throw new ArgumentNullException("dictionary");
			}
			this..ctor(dictionary.Count, comparer);
			int count = dictionary.Count;
			if (count != 0)
			{
				TKey[] array = this.keys;
				dictionary.Keys.CopyTo(array, 0);
				dictionary.Values.CopyTo(this.values, 0);
				if (count > 1)
				{
					comparer = this.Comparer;
					Array.Sort<TKey, TValue>(array, this.values, comparer);
					for (int i = 1; i < array.Length; i++)
					{
						if (comparer.Compare(array[i - 1], array[i]) == 0)
						{
							throw new ArgumentException(SR.Format(SR.Argument_AddingDuplicate, array[i]));
						}
					}
				}
			}
			this._size = count;
		}

		// Token: 0x06000215 RID: 533 RVA: 0x0000853C File Offset: 0x0000673C
		public void Add(TKey key, TValue value)
		{
			ArgumentNullException.ThrowIfNull(key, "key");
			int num = Array.BinarySearch<TKey>(this.keys, 0, this._size, key, this.comparer);
			if (num >= 0)
			{
				throw new ArgumentException(SR.Format(SR.Argument_AddingDuplicate, key), "key");
			}
			this.Insert(~num, key, value);
		}

		// Token: 0x06000216 RID: 534 RVA: 0x0000859C File Offset: 0x0000679C
		void ICollection<KeyValuePair<!0, !1>>.Add(KeyValuePair<TKey, TValue> keyValuePair)
		{
			this.Add(keyValuePair.Key, keyValuePair.Value);
		}

		// Token: 0x06000217 RID: 535 RVA: 0x000085B4 File Offset: 0x000067B4
		bool ICollection<KeyValuePair<!0, !1>>.Contains(KeyValuePair<TKey, TValue> keyValuePair)
		{
			int num = this.IndexOfKey(keyValuePair.Key);
			return num >= 0 && EqualityComparer<TValue>.Default.Equals(this.values[num], keyValuePair.Value);
		}

		// Token: 0x06000218 RID: 536 RVA: 0x000085F8 File Offset: 0x000067F8
		bool ICollection<KeyValuePair<!0, !1>>.Remove(KeyValuePair<TKey, TValue> keyValuePair)
		{
			int num = this.IndexOfKey(keyValuePair.Key);
			if (num >= 0 && EqualityComparer<TValue>.Default.Equals(this.values[num], keyValuePair.Value))
			{
				this.RemoveAt(num);
				return true;
			}
			return false;
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000219 RID: 537 RVA: 0x00008640 File Offset: 0x00006840
		// (set) Token: 0x0600021A RID: 538 RVA: 0x0000864C File Offset: 0x0000684C
		public int Capacity
		{
			get
			{
				return this.keys.Length;
			}
			set
			{
				if (value != this.keys.Length)
				{
					if (value < this._size)
					{
						throw new ArgumentOutOfRangeException("value", value, SR.ArgumentOutOfRange_SmallCapacity);
					}
					if (value > 0)
					{
						TKey[] destinationArray = new TKey[value];
						TValue[] destinationArray2 = new TValue[value];
						if (this._size > 0)
						{
							Array.Copy(this.keys, destinationArray, this._size);
							Array.Copy(this.values, destinationArray2, this._size);
						}
						this.keys = destinationArray;
						this.values = destinationArray2;
						return;
					}
					this.keys = Array.Empty<TKey>();
					this.values = Array.Empty<TValue>();
				}
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x0600021B RID: 539 RVA: 0x000086EA File Offset: 0x000068EA
		public IComparer<TKey> Comparer
		{
			get
			{
				return this.comparer;
			}
		}

		// Token: 0x0600021C RID: 540 RVA: 0x000086F4 File Offset: 0x000068F4
		void IDictionary.Add(object key, object value)
		{
			ArgumentNullException.ThrowIfNull(key, "key");
			if (default(TValue) != null)
			{
				ArgumentNullException.ThrowIfNull(value, "value");
			}
			if (!(key is TKey))
			{
				throw new ArgumentException(SR.Format(SR.Arg_WrongType, key, typeof(TKey)), "key");
			}
			if (!(value is TValue) && value != null)
			{
				throw new ArgumentException(SR.Format(SR.Arg_WrongType, value, typeof(TValue)), "value");
			}
			this.Add((TKey)((object)key), (TValue)((object)value));
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x0600021D RID: 541 RVA: 0x0000878C File Offset: 0x0000698C
		public int Count
		{
			get
			{
				return this._size;
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x0600021E RID: 542 RVA: 0x00008794 File Offset: 0x00006994
		public IList<TKey> Keys
		{
			get
			{
				return this.GetKeyListHelper();
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x0600021F RID: 543 RVA: 0x00008794 File Offset: 0x00006994
		ICollection<TKey> IDictionary<!0, !1>.Keys
		{
			get
			{
				return this.GetKeyListHelper();
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000220 RID: 544 RVA: 0x00008794 File Offset: 0x00006994
		ICollection IDictionary.Keys
		{
			get
			{
				return this.GetKeyListHelper();
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000221 RID: 545 RVA: 0x00008794 File Offset: 0x00006994
		IEnumerable<TKey> IReadOnlyDictionary<!0, !1>.Keys
		{
			get
			{
				return this.GetKeyListHelper();
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000222 RID: 546 RVA: 0x0000879C File Offset: 0x0000699C
		public IList<TValue> Values
		{
			get
			{
				return this.GetValueListHelper();
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000223 RID: 547 RVA: 0x0000879C File Offset: 0x0000699C
		ICollection<TValue> IDictionary<!0, !1>.Values
		{
			get
			{
				return this.GetValueListHelper();
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000224 RID: 548 RVA: 0x0000879C File Offset: 0x0000699C
		ICollection IDictionary.Values
		{
			get
			{
				return this.GetValueListHelper();
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000225 RID: 549 RVA: 0x0000879C File Offset: 0x0000699C
		IEnumerable<TValue> IReadOnlyDictionary<!0, !1>.Values
		{
			get
			{
				return this.GetValueListHelper();
			}
		}

		// Token: 0x06000226 RID: 550 RVA: 0x000087A4 File Offset: 0x000069A4
		private SortedList<TKey, TValue>.KeyList GetKeyListHelper()
		{
			SortedList<TKey, TValue>.KeyList result;
			if ((result = this.keyList) == null)
			{
				result = (this.keyList = new SortedList<TKey, TValue>.KeyList(this));
			}
			return result;
		}

		// Token: 0x06000227 RID: 551 RVA: 0x000087CC File Offset: 0x000069CC
		private SortedList<TKey, TValue>.ValueList GetValueListHelper()
		{
			SortedList<TKey, TValue>.ValueList result;
			if ((result = this.valueList) == null)
			{
				result = (this.valueList = new SortedList<TKey, TValue>.ValueList(this));
			}
			return result;
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000228 RID: 552 RVA: 0x00003925 File Offset: 0x00001B25
		bool ICollection<KeyValuePair<!0, !1>>.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000229 RID: 553 RVA: 0x00003925 File Offset: 0x00001B25
		bool IDictionary.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x0600022A RID: 554 RVA: 0x00003925 File Offset: 0x00001B25
		bool IDictionary.IsFixedSize
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x0600022B RID: 555 RVA: 0x00003925 File Offset: 0x00001B25
		bool ICollection.IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x0600022C RID: 556 RVA: 0x00003922 File Offset: 0x00001B22
		object ICollection.SyncRoot
		{
			get
			{
				return this;
			}
		}

		// Token: 0x0600022D RID: 557 RVA: 0x000087F4 File Offset: 0x000069F4
		public void Clear()
		{
			this.version++;
			if (RuntimeHelpers.IsReferenceOrContainsReferences<TKey>())
			{
				Array.Clear(this.keys, 0, this._size);
			}
			if (RuntimeHelpers.IsReferenceOrContainsReferences<TValue>())
			{
				Array.Clear(this.values, 0, this._size);
			}
			this._size = 0;
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00008848 File Offset: 0x00006A48
		bool IDictionary.Contains(object key)
		{
			return SortedList<TKey, TValue>.IsCompatibleKey(key) && this.ContainsKey((TKey)((object)key));
		}

		// Token: 0x0600022F RID: 559 RVA: 0x00008860 File Offset: 0x00006A60
		public bool ContainsKey(TKey key)
		{
			return this.IndexOfKey(key) >= 0;
		}

		// Token: 0x06000230 RID: 560 RVA: 0x0000886F File Offset: 0x00006A6F
		public bool ContainsValue(TValue value)
		{
			return this.IndexOfValue(value) >= 0;
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00008880 File Offset: 0x00006A80
		void ICollection<KeyValuePair<!0, !1>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
		{
			ArgumentNullException.ThrowIfNull(array, "array");
			if (arrayIndex < 0 || arrayIndex > array.Length)
			{
				throw new ArgumentOutOfRangeException("arrayIndex", arrayIndex, SR.ArgumentOutOfRange_IndexMustBeLessOrEqual);
			}
			if (array.Length - arrayIndex < this.Count)
			{
				throw new ArgumentException(SR.Arg_ArrayPlusOffTooSmall);
			}
			for (int i = 0; i < this.Count; i++)
			{
				KeyValuePair<TKey, TValue> keyValuePair = new KeyValuePair<TKey, TValue>(this.keys[i], this.values[i]);
				array[arrayIndex + i] = keyValuePair;
			}
		}

		// Token: 0x06000232 RID: 562 RVA: 0x0000890C File Offset: 0x00006B0C
		void ICollection.CopyTo(Array array, int index)
		{
			ArgumentNullException.ThrowIfNull(array, "array");
			if (array.Rank != 1)
			{
				throw new ArgumentException(SR.Arg_RankMultiDimNotSupported, "array");
			}
			if (array.GetLowerBound(0) != 0)
			{
				throw new ArgumentException(SR.Arg_NonZeroLowerBound, "array");
			}
			if (index < 0 || index > array.Length)
			{
				throw new ArgumentOutOfRangeException("index", index, SR.ArgumentOutOfRange_IndexMustBeLessOrEqual);
			}
			if (array.Length - index < this.Count)
			{
				throw new ArgumentException(SR.Arg_ArrayPlusOffTooSmall);
			}
			KeyValuePair<TKey, TValue>[] array2 = array as KeyValuePair<TKey, TValue>[];
			if (array2 != null)
			{
				for (int i = 0; i < this.Count; i++)
				{
					array2[i + index] = new KeyValuePair<TKey, TValue>(this.keys[i], this.values[i]);
				}
				return;
			}
			object[] array3 = array as object[];
			if (array3 == null)
			{
				throw new ArgumentException(SR.Argument_IncompatibleArrayType, "array");
			}
			try
			{
				for (int j = 0; j < this.Count; j++)
				{
					array3[j + index] = new KeyValuePair<TKey, TValue>(this.keys[j], this.values[j]);
				}
			}
			catch (ArrayTypeMismatchException)
			{
				throw new ArgumentException(SR.Argument_IncompatibleArrayType, "array");
			}
		}

		// Token: 0x06000233 RID: 563 RVA: 0x00008A4C File Offset: 0x00006C4C
		private void EnsureCapacity(int min)
		{
			int num = (this.keys.Length == 0) ? 4 : (this.keys.Length * 2);
			if ((ulong)num > (ulong)((long)Array.MaxLength))
			{
				num = Array.MaxLength;
			}
			if (num < min)
			{
				num = min;
			}
			this.Capacity = num;
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00008A8D File Offset: 0x00006C8D
		public TValue GetValueAtIndex(int index)
		{
			if (index < 0 || index >= this._size)
			{
				throw new ArgumentOutOfRangeException("index", index, SR.ArgumentOutOfRange_IndexMustBeLess);
			}
			return this.values[index];
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00008ABE File Offset: 0x00006CBE
		public void SetValueAtIndex(int index, TValue value)
		{
			if (index < 0 || index >= this._size)
			{
				throw new ArgumentOutOfRangeException("index", index, SR.ArgumentOutOfRange_IndexMustBeLess);
			}
			this.values[index] = value;
			this.version++;
		}

		// Token: 0x06000236 RID: 566 RVA: 0x00008AFE File Offset: 0x00006CFE
		[return: Nullable(new byte[]
		{
			1,
			0,
			1,
			1
		})]
		public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			return new SortedList<TKey, TValue>.Enumerator(this, 1);
		}

		// Token: 0x06000237 RID: 567 RVA: 0x00008B0C File Offset: 0x00006D0C
		IEnumerator<KeyValuePair<TKey, TValue>> IEnumerable<KeyValuePair<!0, !1>>.GetEnumerator()
		{
			if (this.Count != 0)
			{
				return this.GetEnumerator();
			}
			return EnumerableHelpers.GetEmptyEnumerator<KeyValuePair<TKey, TValue>>();
		}

		// Token: 0x06000238 RID: 568 RVA: 0x00008B22 File Offset: 0x00006D22
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return new SortedList<TKey, TValue>.Enumerator(this, 2);
		}

		// Token: 0x06000239 RID: 569 RVA: 0x00005810 File Offset: 0x00003A10
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<KeyValuePair<!0, !1>>)this).GetEnumerator();
		}

		// Token: 0x0600023A RID: 570 RVA: 0x00008B30 File Offset: 0x00006D30
		public TKey GetKeyAtIndex(int index)
		{
			if (index < 0 || index >= this._size)
			{
				throw new ArgumentOutOfRangeException("index", index, SR.ArgumentOutOfRange_IndexMustBeLess);
			}
			return this.keys[index];
		}

		// Token: 0x170000B5 RID: 181
		public TValue this[TKey key]
		{
			get
			{
				int num = this.IndexOfKey(key);
				if (num >= 0)
				{
					return this.values[num];
				}
				throw new KeyNotFoundException(SR.Format(SR.Arg_KeyNotFoundWithKey, key.ToString()));
			}
			set
			{
				ArgumentNullException.ThrowIfNull(key, "key");
				int num = Array.BinarySearch<TKey>(this.keys, 0, this._size, key, this.comparer);
				if (num >= 0)
				{
					this.values[num] = value;
					this.version++;
					return;
				}
				this.Insert(~num, key, value);
			}
		}

		// Token: 0x170000B6 RID: 182
		[Nullable(2)]
		object IDictionary.this[object key]
		{
			get
			{
				if (SortedList<TKey, TValue>.IsCompatibleKey(key))
				{
					int num = this.IndexOfKey((TKey)((object)key));
					if (num >= 0)
					{
						return this.values[num];
					}
				}
				return null;
			}
			set
			{
				if (!SortedList<TKey, TValue>.IsCompatibleKey(key))
				{
					throw new ArgumentNullException("key");
				}
				if (default(TValue) != null)
				{
					ArgumentNullException.ThrowIfNull(value, "value");
				}
				TKey key2 = (TKey)((object)key);
				try
				{
					this[key2] = (TValue)((object)value);
				}
				catch (InvalidCastException)
				{
					throw new ArgumentException(SR.Format(SR.Arg_WrongType, value, typeof(TValue)), "value");
				}
			}
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00008CCC File Offset: 0x00006ECC
		public int IndexOfKey(TKey key)
		{
			ArgumentNullException.ThrowIfNull(key, "key");
			int num = Array.BinarySearch<TKey>(this.keys, 0, this._size, key, this.comparer);
			if (num < 0)
			{
				return -1;
			}
			return num;
		}

		// Token: 0x06000240 RID: 576 RVA: 0x00008D0A File Offset: 0x00006F0A
		public int IndexOfValue(TValue value)
		{
			return Array.IndexOf<TValue>(this.values, value, 0, this._size);
		}

		// Token: 0x06000241 RID: 577 RVA: 0x00008D20 File Offset: 0x00006F20
		private void Insert(int index, TKey key, TValue value)
		{
			if (this._size == this.keys.Length)
			{
				this.EnsureCapacity(this._size + 1);
			}
			if (index < this._size)
			{
				Array.Copy(this.keys, index, this.keys, index + 1, this._size - index);
				Array.Copy(this.values, index, this.values, index + 1, this._size - index);
			}
			this.keys[index] = key;
			this.values[index] = value;
			this._size++;
			this.version++;
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00008DC4 File Offset: 0x00006FC4
		public bool TryGetValue(TKey key, [MaybeNullWhen(false)] out TValue value)
		{
			int num = this.IndexOfKey(key);
			if (num >= 0)
			{
				value = this.values[num];
				return true;
			}
			value = default(TValue);
			return false;
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00008DFC File Offset: 0x00006FFC
		public void RemoveAt(int index)
		{
			if (index < 0 || index >= this._size)
			{
				throw new ArgumentOutOfRangeException("index", index, SR.ArgumentOutOfRange_IndexMustBeLess);
			}
			this._size--;
			if (index < this._size)
			{
				Array.Copy(this.keys, index + 1, this.keys, index, this._size - index);
				Array.Copy(this.values, index + 1, this.values, index, this._size - index);
			}
			if (RuntimeHelpers.IsReferenceOrContainsReferences<TKey>())
			{
				this.keys[this._size] = default(TKey);
			}
			if (RuntimeHelpers.IsReferenceOrContainsReferences<TValue>())
			{
				this.values[this._size] = default(TValue);
			}
			this.version++;
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00008ED0 File Offset: 0x000070D0
		public bool Remove(TKey key)
		{
			int num = this.IndexOfKey(key);
			if (num >= 0)
			{
				this.RemoveAt(num);
			}
			return num >= 0;
		}

		// Token: 0x06000245 RID: 581 RVA: 0x00008EF7 File Offset: 0x000070F7
		void IDictionary.Remove(object key)
		{
			if (SortedList<TKey, TValue>.IsCompatibleKey(key))
			{
				this.Remove((TKey)((object)key));
			}
		}

		// Token: 0x06000246 RID: 582 RVA: 0x00008F10 File Offset: 0x00007110
		public void TrimExcess()
		{
			int num = (int)((double)this.keys.Length * 0.9);
			if (this._size < num)
			{
				this.Capacity = this._size;
			}
		}

		// Token: 0x06000247 RID: 583 RVA: 0x00007B18 File Offset: 0x00005D18
		private static bool IsCompatibleKey(object key)
		{
			ArgumentNullException.ThrowIfNull(key, "key");
			return key is TKey;
		}

		// Token: 0x0400005C RID: 92
		private TKey[] keys;

		// Token: 0x0400005D RID: 93
		private TValue[] values;

		// Token: 0x0400005E RID: 94
		private int _size;

		// Token: 0x0400005F RID: 95
		private int version;

		// Token: 0x04000060 RID: 96
		private readonly IComparer<TKey> comparer;

		// Token: 0x04000061 RID: 97
		private SortedList<TKey, TValue>.KeyList keyList;

		// Token: 0x04000062 RID: 98
		private SortedList<TKey, TValue>.ValueList valueList;

		// Token: 0x02000030 RID: 48
		private struct Enumerator : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable, IDictionaryEnumerator
		{
			// Token: 0x06000248 RID: 584 RVA: 0x00008F47 File Offset: 0x00007147
			internal Enumerator(SortedList<TKey, TValue> sortedList, int getEnumeratorRetType)
			{
				this._sortedList = sortedList;
				this._index = 0;
				this._version = this._sortedList.version;
				this._getEnumeratorRetType = getEnumeratorRetType;
				this._key = default(TKey);
				this._value = default(TValue);
			}

			// Token: 0x06000249 RID: 585 RVA: 0x00008F87 File Offset: 0x00007187
			public void Dispose()
			{
				this._index = 0;
				this._key = default(TKey);
				this._value = default(TValue);
			}

			// Token: 0x170000B7 RID: 183
			// (get) Token: 0x0600024A RID: 586 RVA: 0x00008FA8 File Offset: 0x000071A8
			object IDictionaryEnumerator.Key
			{
				get
				{
					if (this._index == 0 || this._index == this._sortedList.Count + 1)
					{
						throw new InvalidOperationException(SR.InvalidOperation_EnumOpCantHappen);
					}
					return this._key;
				}
			}

			// Token: 0x0600024B RID: 587 RVA: 0x00008FE0 File Offset: 0x000071E0
			public bool MoveNext()
			{
				if (this._version != this._sortedList.version)
				{
					throw new InvalidOperationException(SR.InvalidOperation_EnumFailedVersion);
				}
				if (this._index < this._sortedList.Count)
				{
					this._key = this._sortedList.keys[this._index];
					this._value = this._sortedList.values[this._index];
					this._index++;
					return true;
				}
				this._index = this._sortedList.Count + 1;
				this._key = default(TKey);
				this._value = default(TValue);
				return false;
			}

			// Token: 0x170000B8 RID: 184
			// (get) Token: 0x0600024C RID: 588 RVA: 0x00009094 File Offset: 0x00007294
			DictionaryEntry IDictionaryEnumerator.Entry
			{
				get
				{
					if (this._index == 0 || this._index == this._sortedList.Count + 1)
					{
						throw new InvalidOperationException(SR.InvalidOperation_EnumOpCantHappen);
					}
					return new DictionaryEntry(this._key, this._value);
				}
			}

			// Token: 0x170000B9 RID: 185
			// (get) Token: 0x0600024D RID: 589 RVA: 0x000090E4 File Offset: 0x000072E4
			public KeyValuePair<TKey, TValue> Current
			{
				get
				{
					return new KeyValuePair<TKey, TValue>(this._key, this._value);
				}
			}

			// Token: 0x170000BA RID: 186
			// (get) Token: 0x0600024E RID: 590 RVA: 0x000090F8 File Offset: 0x000072F8
			object IEnumerator.Current
			{
				get
				{
					if (this._index == 0 || this._index == this._sortedList.Count + 1)
					{
						throw new InvalidOperationException(SR.InvalidOperation_EnumOpCantHappen);
					}
					if (this._getEnumeratorRetType == 2)
					{
						return new DictionaryEntry(this._key, this._value);
					}
					return new KeyValuePair<TKey, TValue>(this._key, this._value);
				}
			}

			// Token: 0x170000BB RID: 187
			// (get) Token: 0x0600024F RID: 591 RVA: 0x0000916D File Offset: 0x0000736D
			object IDictionaryEnumerator.Value
			{
				get
				{
					if (this._index == 0 || this._index == this._sortedList.Count + 1)
					{
						throw new InvalidOperationException(SR.InvalidOperation_EnumOpCantHappen);
					}
					return this._value;
				}
			}

			// Token: 0x06000250 RID: 592 RVA: 0x000091A2 File Offset: 0x000073A2
			void IEnumerator.Reset()
			{
				if (this._version != this._sortedList.version)
				{
					throw new InvalidOperationException(SR.InvalidOperation_EnumFailedVersion);
				}
				this._index = 0;
				this._key = default(TKey);
				this._value = default(TValue);
			}

			// Token: 0x04000063 RID: 99
			private readonly SortedList<TKey, TValue> _sortedList;

			// Token: 0x04000064 RID: 100
			private TKey _key;

			// Token: 0x04000065 RID: 101
			private TValue _value;

			// Token: 0x04000066 RID: 102
			private int _index;

			// Token: 0x04000067 RID: 103
			private readonly int _version;

			// Token: 0x04000068 RID: 104
			private readonly int _getEnumeratorRetType;
		}

		// Token: 0x02000031 RID: 49
		private sealed class SortedListKeyEnumerator : IEnumerator<TKey>, IEnumerator, IDisposable
		{
			// Token: 0x06000251 RID: 593 RVA: 0x000091E1 File Offset: 0x000073E1
			internal SortedListKeyEnumerator(SortedList<TKey, TValue> sortedList)
			{
				this._sortedList = sortedList;
				this._version = sortedList.version;
			}

			// Token: 0x06000252 RID: 594 RVA: 0x000091FC File Offset: 0x000073FC
			public void Dispose()
			{
				this._index = 0;
				this._currentKey = default(TKey);
			}

			// Token: 0x06000253 RID: 595 RVA: 0x00009214 File Offset: 0x00007414
			public bool MoveNext()
			{
				if (this._version != this._sortedList.version)
				{
					throw new InvalidOperationException(SR.InvalidOperation_EnumFailedVersion);
				}
				if (this._index < this._sortedList.Count)
				{
					this._currentKey = this._sortedList.keys[this._index];
					this._index++;
					return true;
				}
				this._index = this._sortedList.Count + 1;
				this._currentKey = default(TKey);
				return false;
			}

			// Token: 0x170000BC RID: 188
			// (get) Token: 0x06000254 RID: 596 RVA: 0x0000929E File Offset: 0x0000749E
			public TKey Current
			{
				get
				{
					return this._currentKey;
				}
			}

			// Token: 0x170000BD RID: 189
			// (get) Token: 0x06000255 RID: 597 RVA: 0x000092A6 File Offset: 0x000074A6
			object IEnumerator.Current
			{
				get
				{
					if (this._index == 0 || this._index == this._sortedList.Count + 1)
					{
						throw new InvalidOperationException(SR.InvalidOperation_EnumOpCantHappen);
					}
					return this._currentKey;
				}
			}

			// Token: 0x06000256 RID: 598 RVA: 0x000092DB File Offset: 0x000074DB
			void IEnumerator.Reset()
			{
				if (this._version != this._sortedList.version)
				{
					throw new InvalidOperationException(SR.InvalidOperation_EnumFailedVersion);
				}
				this._index = 0;
				this._currentKey = default(TKey);
			}

			// Token: 0x04000069 RID: 105
			private readonly SortedList<TKey, TValue> _sortedList;

			// Token: 0x0400006A RID: 106
			private int _index;

			// Token: 0x0400006B RID: 107
			private readonly int _version;

			// Token: 0x0400006C RID: 108
			private TKey _currentKey;
		}

		// Token: 0x02000032 RID: 50
		private sealed class SortedListValueEnumerator : IEnumerator<TValue>, IEnumerator, IDisposable
		{
			// Token: 0x06000257 RID: 599 RVA: 0x0000930E File Offset: 0x0000750E
			internal SortedListValueEnumerator(SortedList<TKey, TValue> sortedList)
			{
				this._sortedList = sortedList;
				this._version = sortedList.version;
			}

			// Token: 0x06000258 RID: 600 RVA: 0x00009329 File Offset: 0x00007529
			public void Dispose()
			{
				this._index = 0;
				this._currentValue = default(TValue);
			}

			// Token: 0x06000259 RID: 601 RVA: 0x00009340 File Offset: 0x00007540
			public bool MoveNext()
			{
				if (this._version != this._sortedList.version)
				{
					throw new InvalidOperationException(SR.InvalidOperation_EnumFailedVersion);
				}
				if (this._index < this._sortedList.Count)
				{
					this._currentValue = this._sortedList.values[this._index];
					this._index++;
					return true;
				}
				this._index = this._sortedList.Count + 1;
				this._currentValue = default(TValue);
				return false;
			}

			// Token: 0x170000BE RID: 190
			// (get) Token: 0x0600025A RID: 602 RVA: 0x000093CA File Offset: 0x000075CA
			public TValue Current
			{
				get
				{
					return this._currentValue;
				}
			}

			// Token: 0x170000BF RID: 191
			// (get) Token: 0x0600025B RID: 603 RVA: 0x000093D2 File Offset: 0x000075D2
			object IEnumerator.Current
			{
				get
				{
					if (this._index == 0 || this._index == this._sortedList.Count + 1)
					{
						throw new InvalidOperationException(SR.InvalidOperation_EnumOpCantHappen);
					}
					return this._currentValue;
				}
			}

			// Token: 0x0600025C RID: 604 RVA: 0x00009407 File Offset: 0x00007607
			void IEnumerator.Reset()
			{
				if (this._version != this._sortedList.version)
				{
					throw new InvalidOperationException(SR.InvalidOperation_EnumFailedVersion);
				}
				this._index = 0;
				this._currentValue = default(TValue);
			}

			// Token: 0x0400006D RID: 109
			private readonly SortedList<TKey, TValue> _sortedList;

			// Token: 0x0400006E RID: 110
			private int _index;

			// Token: 0x0400006F RID: 111
			private readonly int _version;

			// Token: 0x04000070 RID: 112
			private TValue _currentValue;
		}

		// Token: 0x02000033 RID: 51
		[Nullable(0)]
		[DebuggerTypeProxy(typeof(DictionaryKeyCollectionDebugView<, >))]
		[DebuggerDisplay("Count = {Count}")]
		[Serializable]
		public sealed class KeyList : IList<!0>, ICollection<!0>, IEnumerable<!0>, IEnumerable, ICollection
		{
			// Token: 0x0600025D RID: 605 RVA: 0x0000943A File Offset: 0x0000763A
			internal KeyList(SortedList<TKey, TValue> dictionary)
			{
				this._dict = dictionary;
			}

			// Token: 0x170000C0 RID: 192
			// (get) Token: 0x0600025E RID: 606 RVA: 0x00009449 File Offset: 0x00007649
			public int Count
			{
				get
				{
					return this._dict._size;
				}
			}

			// Token: 0x170000C1 RID: 193
			// (get) Token: 0x0600025F RID: 607 RVA: 0x00003ED3 File Offset: 0x000020D3
			public bool IsReadOnly
			{
				get
				{
					return true;
				}
			}

			// Token: 0x170000C2 RID: 194
			// (get) Token: 0x06000260 RID: 608 RVA: 0x00003925 File Offset: 0x00001B25
			bool ICollection.IsSynchronized
			{
				get
				{
					return false;
				}
			}

			// Token: 0x170000C3 RID: 195
			// (get) Token: 0x06000261 RID: 609 RVA: 0x00009456 File Offset: 0x00007656
			object ICollection.SyncRoot
			{
				get
				{
					return ((ICollection)this._dict).SyncRoot;
				}
			}

			// Token: 0x06000262 RID: 610 RVA: 0x00009463 File Offset: 0x00007663
			public void Add(TKey key)
			{
				throw new NotSupportedException(SR.NotSupported_SortedListNestedWrite);
			}

			// Token: 0x06000263 RID: 611 RVA: 0x00009463 File Offset: 0x00007663
			public void Clear()
			{
				throw new NotSupportedException(SR.NotSupported_SortedListNestedWrite);
			}

			// Token: 0x06000264 RID: 612 RVA: 0x0000946F File Offset: 0x0000766F
			public bool Contains(TKey key)
			{
				return this._dict.ContainsKey(key);
			}

			// Token: 0x06000265 RID: 613 RVA: 0x0000947D File Offset: 0x0000767D
			public void CopyTo(TKey[] array, int arrayIndex)
			{
				Array.Copy(this._dict.keys, 0, array, arrayIndex, this._dict.Count);
			}

			// Token: 0x06000266 RID: 614 RVA: 0x000094A0 File Offset: 0x000076A0
			void ICollection.CopyTo(Array array, int arrayIndex)
			{
				if (array != null && array.Rank != 1)
				{
					throw new ArgumentException(SR.Arg_RankMultiDimNotSupported, "array");
				}
				try
				{
					Array.Copy(this._dict.keys, 0, array, arrayIndex, this._dict.Count);
				}
				catch (ArrayTypeMismatchException)
				{
					throw new ArgumentException(SR.Argument_IncompatibleArrayType, "array");
				}
			}

			// Token: 0x06000267 RID: 615 RVA: 0x00009463 File Offset: 0x00007663
			public void Insert(int index, TKey value)
			{
				throw new NotSupportedException(SR.NotSupported_SortedListNestedWrite);
			}

			// Token: 0x170000C4 RID: 196
			public TKey this[int index]
			{
				get
				{
					return this._dict.GetKeyAtIndex(index);
				}
				set
				{
					throw new NotSupportedException(SR.NotSupported_KeyCollectionSet);
				}
			}

			// Token: 0x0600026A RID: 618 RVA: 0x0000951C File Offset: 0x0000771C
			public IEnumerator<TKey> GetEnumerator()
			{
				if (this.Count != 0)
				{
					return new SortedList<TKey, TValue>.SortedListKeyEnumerator(this._dict);
				}
				return EnumerableHelpers.GetEmptyEnumerator<TKey>();
			}

			// Token: 0x0600026B RID: 619 RVA: 0x00009544 File Offset: 0x00007744
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.GetEnumerator();
			}

			// Token: 0x0600026C RID: 620 RVA: 0x0000954C File Offset: 0x0000774C
			public int IndexOf(TKey key)
			{
				ArgumentNullException.ThrowIfNull(key, "key");
				int num = Array.BinarySearch<TKey>(this._dict.keys, 0, this._dict.Count, key, this._dict.comparer);
				if (num >= 0)
				{
					return num;
				}
				return -1;
			}

			// Token: 0x0600026D RID: 621 RVA: 0x00009463 File Offset: 0x00007663
			public bool Remove(TKey key)
			{
				throw new NotSupportedException(SR.NotSupported_SortedListNestedWrite);
			}

			// Token: 0x0600026E RID: 622 RVA: 0x00009463 File Offset: 0x00007663
			public void RemoveAt(int index)
			{
				throw new NotSupportedException(SR.NotSupported_SortedListNestedWrite);
			}

			// Token: 0x04000071 RID: 113
			private readonly SortedList<TKey, TValue> _dict;
		}

		// Token: 0x02000034 RID: 52
		[Nullable(0)]
		[DebuggerTypeProxy(typeof(DictionaryValueCollectionDebugView<, >))]
		[DebuggerDisplay("Count = {Count}")]
		[Serializable]
		public sealed class ValueList : IList<!1>, ICollection<!1>, IEnumerable<!1>, IEnumerable, ICollection
		{
			// Token: 0x0600026F RID: 623 RVA: 0x00009599 File Offset: 0x00007799
			internal ValueList(SortedList<TKey, TValue> dictionary)
			{
				this._dict = dictionary;
			}

			// Token: 0x170000C5 RID: 197
			// (get) Token: 0x06000270 RID: 624 RVA: 0x000095A8 File Offset: 0x000077A8
			public int Count
			{
				get
				{
					return this._dict._size;
				}
			}

			// Token: 0x170000C6 RID: 198
			// (get) Token: 0x06000271 RID: 625 RVA: 0x00003ED3 File Offset: 0x000020D3
			public bool IsReadOnly
			{
				get
				{
					return true;
				}
			}

			// Token: 0x170000C7 RID: 199
			// (get) Token: 0x06000272 RID: 626 RVA: 0x00003925 File Offset: 0x00001B25
			bool ICollection.IsSynchronized
			{
				get
				{
					return false;
				}
			}

			// Token: 0x170000C8 RID: 200
			// (get) Token: 0x06000273 RID: 627 RVA: 0x000095B5 File Offset: 0x000077B5
			object ICollection.SyncRoot
			{
				get
				{
					return ((ICollection)this._dict).SyncRoot;
				}
			}

			// Token: 0x06000274 RID: 628 RVA: 0x00009463 File Offset: 0x00007663
			public void Add(TValue key)
			{
				throw new NotSupportedException(SR.NotSupported_SortedListNestedWrite);
			}

			// Token: 0x06000275 RID: 629 RVA: 0x00009463 File Offset: 0x00007663
			public void Clear()
			{
				throw new NotSupportedException(SR.NotSupported_SortedListNestedWrite);
			}

			// Token: 0x06000276 RID: 630 RVA: 0x000095C2 File Offset: 0x000077C2
			public bool Contains(TValue value)
			{
				return this._dict.ContainsValue(value);
			}

			// Token: 0x06000277 RID: 631 RVA: 0x000095D0 File Offset: 0x000077D0
			public void CopyTo(TValue[] array, int arrayIndex)
			{
				Array.Copy(this._dict.values, 0, array, arrayIndex, this._dict.Count);
			}

			// Token: 0x06000278 RID: 632 RVA: 0x000095F0 File Offset: 0x000077F0
			void ICollection.CopyTo(Array array, int index)
			{
				if (array != null && array.Rank != 1)
				{
					throw new ArgumentException(SR.Arg_RankMultiDimNotSupported, "array");
				}
				try
				{
					Array.Copy(this._dict.values, 0, array, index, this._dict.Count);
				}
				catch (ArrayTypeMismatchException)
				{
					throw new ArgumentException(SR.Argument_IncompatibleArrayType, "array");
				}
			}

			// Token: 0x06000279 RID: 633 RVA: 0x00009463 File Offset: 0x00007663
			public void Insert(int index, TValue value)
			{
				throw new NotSupportedException(SR.NotSupported_SortedListNestedWrite);
			}

			// Token: 0x170000C9 RID: 201
			public TValue this[int index]
			{
				get
				{
					return this._dict.GetValueAtIndex(index);
				}
				set
				{
					throw new NotSupportedException(SR.NotSupported_SortedListNestedWrite);
				}
			}

			// Token: 0x0600027C RID: 636 RVA: 0x0000966C File Offset: 0x0000786C
			public IEnumerator<TValue> GetEnumerator()
			{
				if (this.Count != 0)
				{
					return new SortedList<TKey, TValue>.SortedListValueEnumerator(this._dict);
				}
				return EnumerableHelpers.GetEmptyEnumerator<TValue>();
			}

			// Token: 0x0600027D RID: 637 RVA: 0x00009694 File Offset: 0x00007894
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.GetEnumerator();
			}

			// Token: 0x0600027E RID: 638 RVA: 0x0000969C File Offset: 0x0000789C
			public int IndexOf(TValue value)
			{
				return Array.IndexOf<TValue>(this._dict.values, value, 0, this._dict.Count);
			}

			// Token: 0x0600027F RID: 639 RVA: 0x00009463 File Offset: 0x00007663
			public bool Remove(TValue value)
			{
				throw new NotSupportedException(SR.NotSupported_SortedListNestedWrite);
			}

			// Token: 0x06000280 RID: 640 RVA: 0x00009463 File Offset: 0x00007663
			public void RemoveAt(int index)
			{
				throw new NotSupportedException(SR.NotSupported_SortedListNestedWrite);
			}

			// Token: 0x04000072 RID: 114
			private readonly SortedList<TKey, TValue> _dict;
		}
	}
}
