using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Collections.Generic
{
	// Token: 0x02000021 RID: 33
	[NullableContext(1)]
	[Nullable(0)]
	[DebuggerTypeProxy(typeof(IDictionaryDebugView<, >))]
	[DebuggerDisplay("Count = {Count}")]
	[TypeForwardedFrom("System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class SortedDictionary<TKey, [Nullable(2)] TValue> : IDictionary<!0, !1>, ICollection<KeyValuePair<!0, !1>>, IEnumerable<KeyValuePair<!0, !1>>, IEnumerable, IDictionary, ICollection, IReadOnlyDictionary<!0, !1>, IReadOnlyCollection<KeyValuePair<TKey, TValue>>
	{
		// Token: 0x0600019D RID: 413 RVA: 0x000074AC File Offset: 0x000056AC
		public SortedDictionary() : this(null)
		{
		}

		// Token: 0x0600019E RID: 414 RVA: 0x000074B5 File Offset: 0x000056B5
		public SortedDictionary(IDictionary<TKey, TValue> dictionary) : this(dictionary, null)
		{
		}

		// Token: 0x0600019F RID: 415 RVA: 0x000074C0 File Offset: 0x000056C0
		public SortedDictionary(IDictionary<TKey, TValue> dictionary, [Nullable(new byte[]
		{
			2,
			1
		})] IComparer<TKey> comparer)
		{
			ArgumentNullException.ThrowIfNull(dictionary, "dictionary");
			SortedDictionary<TKey, TValue>.KeyValuePairComparer keyValuePairComparer = new SortedDictionary<TKey, TValue>.KeyValuePairComparer(comparer);
			SortedDictionary<TKey, TValue> sortedDictionary = dictionary as SortedDictionary<TKey, TValue>;
			if (sortedDictionary != null)
			{
				SortedDictionary<TKey, TValue>.KeyValuePairComparer keyValuePairComparer2 = sortedDictionary._set.Comparer as SortedDictionary<TKey, TValue>.KeyValuePairComparer;
				if (keyValuePairComparer2 != null && keyValuePairComparer2.keyComparer.Equals(keyValuePairComparer.keyComparer))
				{
					this._set = new TreeSet<KeyValuePair<TKey, TValue>>(sortedDictionary._set, keyValuePairComparer);
					return;
				}
			}
			this._set = new TreeSet<KeyValuePair<TKey, TValue>>(keyValuePairComparer);
			foreach (KeyValuePair<TKey, TValue> item in dictionary)
			{
				this._set.Add(item);
			}
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00007578 File Offset: 0x00005778
		public SortedDictionary([Nullable(new byte[]
		{
			2,
			1
		})] IComparer<TKey> comparer)
		{
			this._set = new TreeSet<KeyValuePair<TKey, TValue>>(new SortedDictionary<TKey, TValue>.KeyValuePairComparer(comparer));
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00007591 File Offset: 0x00005791
		void ICollection<KeyValuePair<!0, !1>>.Add(KeyValuePair<TKey, TValue> keyValuePair)
		{
			this._set.Add(keyValuePair);
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x000075A0 File Offset: 0x000057A0
		bool ICollection<KeyValuePair<!0, !1>>.Contains(KeyValuePair<TKey, TValue> keyValuePair)
		{
			SortedSet<KeyValuePair<TKey, TValue>>.Node node = this._set.FindNode(keyValuePair);
			if (node == null)
			{
				return false;
			}
			if (keyValuePair.Value == null)
			{
				return node.Item.Value == null;
			}
			return EqualityComparer<TValue>.Default.Equals(node.Item.Value, keyValuePair.Value);
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00007604 File Offset: 0x00005804
		bool ICollection<KeyValuePair<!0, !1>>.Remove(KeyValuePair<TKey, TValue> keyValuePair)
		{
			SortedSet<KeyValuePair<TKey, TValue>>.Node node = this._set.FindNode(keyValuePair);
			if (node == null)
			{
				return false;
			}
			if (EqualityComparer<TValue>.Default.Equals(node.Item.Value, keyValuePair.Value))
			{
				this._set.Remove(keyValuePair);
				return true;
			}
			return false;
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060001A4 RID: 420 RVA: 0x00003925 File Offset: 0x00001B25
		bool ICollection<KeyValuePair<!0, !1>>.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000083 RID: 131
		public TValue this[TKey key]
		{
			get
			{
				ArgumentNullException.ThrowIfNull(key, "key");
				SortedSet<KeyValuePair<TKey, TValue>>.Node node = this._set.FindNode(new KeyValuePair<TKey, TValue>(key, default(TValue)));
				if (node == null)
				{
					throw new KeyNotFoundException(SR.Format(SR.Arg_KeyNotFoundWithKey, key.ToString()));
				}
				return node.Item.Value;
			}
			set
			{
				ArgumentNullException.ThrowIfNull(key, "key");
				SortedSet<KeyValuePair<TKey, TValue>>.Node node = this._set.FindNode(new KeyValuePair<TKey, TValue>(key, default(TValue)));
				if (node == null)
				{
					this._set.Add(new KeyValuePair<TKey, TValue>(key, value));
					return;
				}
				node.Item = new KeyValuePair<TKey, TValue>(node.Item.Key, value);
				this._set.UpdateVersion();
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060001A7 RID: 423 RVA: 0x0000772C File Offset: 0x0000592C
		public int Count
		{
			get
			{
				return this._set.Count;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060001A8 RID: 424 RVA: 0x00007739 File Offset: 0x00005939
		public IComparer<TKey> Comparer
		{
			get
			{
				return ((SortedDictionary<TKey, TValue>.KeyValuePairComparer)this._set.Comparer).keyComparer;
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x060001A9 RID: 425 RVA: 0x00007750 File Offset: 0x00005950
		[Nullable(new byte[]
		{
			1,
			0,
			0
		})]
		public SortedDictionary<TKey, TValue>.KeyCollection Keys
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				0
			})]
			get
			{
				SortedDictionary<TKey, TValue>.KeyCollection result;
				if ((result = this._keys) == null)
				{
					result = (this._keys = new SortedDictionary<TKey, TValue>.KeyCollection(this));
				}
				return result;
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060001AA RID: 426 RVA: 0x00007776 File Offset: 0x00005976
		ICollection<TKey> IDictionary<!0, !1>.Keys
		{
			get
			{
				return this.Keys;
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060001AB RID: 427 RVA: 0x00007776 File Offset: 0x00005976
		IEnumerable<TKey> IReadOnlyDictionary<!0, !1>.Keys
		{
			get
			{
				return this.Keys;
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060001AC RID: 428 RVA: 0x00007780 File Offset: 0x00005980
		[Nullable(new byte[]
		{
			1,
			0,
			0
		})]
		public SortedDictionary<TKey, TValue>.ValueCollection Values
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				0
			})]
			get
			{
				SortedDictionary<TKey, TValue>.ValueCollection result;
				if ((result = this._values) == null)
				{
					result = (this._values = new SortedDictionary<TKey, TValue>.ValueCollection(this));
				}
				return result;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060001AD RID: 429 RVA: 0x000077A6 File Offset: 0x000059A6
		ICollection<TValue> IDictionary<!0, !1>.Values
		{
			get
			{
				return this.Values;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060001AE RID: 430 RVA: 0x000077A6 File Offset: 0x000059A6
		IEnumerable<TValue> IReadOnlyDictionary<!0, !1>.Values
		{
			get
			{
				return this.Values;
			}
		}

		// Token: 0x060001AF RID: 431 RVA: 0x000077AE File Offset: 0x000059AE
		public void Add(TKey key, TValue value)
		{
			ArgumentNullException.ThrowIfNull(key, "key");
			this._set.Add(new KeyValuePair<TKey, TValue>(key, value));
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x000077D3 File Offset: 0x000059D3
		public void Clear()
		{
			this._set.Clear();
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x000077E0 File Offset: 0x000059E0
		public bool ContainsKey(TKey key)
		{
			ArgumentNullException.ThrowIfNull(key, "key");
			return this._set.Contains(new KeyValuePair<TKey, TValue>(key, default(TValue)));
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00007818 File Offset: 0x00005A18
		public bool ContainsValue(TValue value)
		{
			bool found = false;
			if (value == null)
			{
				this._set.InOrderTreeWalk(delegate(SortedSet<KeyValuePair<TKey, TValue>>.Node node)
				{
					if (node.Item.Value == null)
					{
						found = true;
						return false;
					}
					return true;
				});
			}
			else
			{
				EqualityComparer<TValue> valueComparer = EqualityComparer<TValue>.Default;
				this._set.InOrderTreeWalk(delegate(SortedSet<KeyValuePair<TKey, TValue>>.Node node)
				{
					if (valueComparer.Equals(node.Item.Value, value))
					{
						found = true;
						return false;
					}
					return true;
				});
			}
			return found;
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00007896 File Offset: 0x00005A96
		public void CopyTo([Nullable(new byte[]
		{
			1,
			0,
			1,
			1
		})] KeyValuePair<TKey, TValue>[] array, int index)
		{
			this._set.CopyTo(array, index);
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x000078A5 File Offset: 0x00005AA5
		[NullableContext(0)]
		public SortedDictionary<TKey, TValue>.Enumerator GetEnumerator()
		{
			return new SortedDictionary<TKey, TValue>.Enumerator(this, 1);
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x000078B0 File Offset: 0x00005AB0
		IEnumerator<KeyValuePair<TKey, TValue>> IEnumerable<KeyValuePair<!0, !1>>.GetEnumerator()
		{
			if (this.Count != 0)
			{
				return this.GetEnumerator();
			}
			return EnumerableHelpers.GetEmptyEnumerator<KeyValuePair<TKey, TValue>>();
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x000078D8 File Offset: 0x00005AD8
		public bool Remove(TKey key)
		{
			ArgumentNullException.ThrowIfNull(key, "key");
			return this._set.Remove(new KeyValuePair<TKey, TValue>(key, default(TValue)));
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00007910 File Offset: 0x00005B10
		public bool TryGetValue(TKey key, [MaybeNullWhen(false)] out TValue value)
		{
			ArgumentNullException.ThrowIfNull(key, "key");
			SortedSet<KeyValuePair<TKey, TValue>>.Node node = this._set.FindNode(new KeyValuePair<TKey, TValue>(key, default(TValue)));
			if (node == null)
			{
				value = default(TValue);
				return false;
			}
			value = node.Item.Value;
			return true;
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00007969 File Offset: 0x00005B69
		void ICollection.CopyTo(Array array, int index)
		{
			((ICollection)this._set).CopyTo(array, index);
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060001B9 RID: 441 RVA: 0x00003925 File Offset: 0x00001B25
		bool IDictionary.IsFixedSize
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060001BA RID: 442 RVA: 0x00003925 File Offset: 0x00001B25
		bool IDictionary.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060001BB RID: 443 RVA: 0x00007776 File Offset: 0x00005976
		ICollection IDictionary.Keys
		{
			get
			{
				return this.Keys;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060001BC RID: 444 RVA: 0x000077A6 File Offset: 0x000059A6
		ICollection IDictionary.Values
		{
			get
			{
				return this.Values;
			}
		}

		// Token: 0x17000090 RID: 144
		[Nullable(2)]
		object IDictionary.this[object key]
		{
			get
			{
				TValue tvalue;
				if (SortedDictionary<TKey, TValue>.IsCompatibleKey(key) && this.TryGetValue((TKey)((object)key), out tvalue))
				{
					return tvalue;
				}
				return null;
			}
			set
			{
				ArgumentNullException.ThrowIfNull(key, "key");
				if (default(TValue) != null)
				{
					ArgumentNullException.ThrowIfNull(value, "value");
				}
				try
				{
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
				catch (InvalidCastException)
				{
					throw new ArgumentException(SR.Format(SR.Arg_WrongType, key, typeof(TKey)), "key");
				}
			}
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00007A54 File Offset: 0x00005C54
		void IDictionary.Add(object key, object value)
		{
			ArgumentNullException.ThrowIfNull(key, "key");
			if (default(TValue) != null)
			{
				ArgumentNullException.ThrowIfNull(value, "value");
			}
			try
			{
				TKey key2 = (TKey)((object)key);
				try
				{
					this.Add(key2, (TValue)((object)value));
				}
				catch (InvalidCastException)
				{
					throw new ArgumentException(SR.Format(SR.Arg_WrongType, value, typeof(TValue)), "value");
				}
			}
			catch (InvalidCastException)
			{
				throw new ArgumentException(SR.Format(SR.Arg_WrongType, key, typeof(TKey)), "key");
			}
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00007B00 File Offset: 0x00005D00
		bool IDictionary.Contains(object key)
		{
			return SortedDictionary<TKey, TValue>.IsCompatibleKey(key) && this.ContainsKey((TKey)((object)key));
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00007B18 File Offset: 0x00005D18
		private static bool IsCompatibleKey(object key)
		{
			ArgumentNullException.ThrowIfNull(key, "key");
			return key is TKey;
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00007B2E File Offset: 0x00005D2E
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return new SortedDictionary<TKey, TValue>.Enumerator(this, 2);
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00007B3C File Offset: 0x00005D3C
		void IDictionary.Remove(object key)
		{
			if (SortedDictionary<TKey, TValue>.IsCompatibleKey(key))
			{
				this.Remove((TKey)((object)key));
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060001C4 RID: 452 RVA: 0x00003925 File Offset: 0x00001B25
		bool ICollection.IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060001C5 RID: 453 RVA: 0x00007B53 File Offset: 0x00005D53
		object ICollection.SyncRoot
		{
			get
			{
				return ((ICollection)this._set).SyncRoot;
			}
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00005810 File Offset: 0x00003A10
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<KeyValuePair<!0, !1>>)this).GetEnumerator();
		}

		// Token: 0x04000046 RID: 70
		[NonSerialized]
		private SortedDictionary<TKey, TValue>.KeyCollection _keys;

		// Token: 0x04000047 RID: 71
		[NonSerialized]
		private SortedDictionary<TKey, TValue>.ValueCollection _values;

		// Token: 0x04000048 RID: 72
		private readonly TreeSet<KeyValuePair<TKey, TValue>> _set;

		// Token: 0x02000022 RID: 34
		[NullableContext(0)]
		public struct Enumerator : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable, IDictionaryEnumerator
		{
			// Token: 0x060001C7 RID: 455 RVA: 0x00007B60 File Offset: 0x00005D60
			internal Enumerator(SortedDictionary<TKey, TValue> dictionary, int getEnumeratorRetType)
			{
				this._treeEnum = dictionary._set.GetEnumerator();
				this._getEnumeratorRetType = getEnumeratorRetType;
			}

			// Token: 0x060001C8 RID: 456 RVA: 0x00007B7A File Offset: 0x00005D7A
			public bool MoveNext()
			{
				return this._treeEnum.MoveNext();
			}

			// Token: 0x060001C9 RID: 457 RVA: 0x00007B87 File Offset: 0x00005D87
			public void Dispose()
			{
				this._treeEnum.Dispose();
			}

			// Token: 0x17000093 RID: 147
			// (get) Token: 0x060001CA RID: 458 RVA: 0x00007B94 File Offset: 0x00005D94
			[Nullable(new byte[]
			{
				0,
				1,
				1
			})]
			public KeyValuePair<TKey, TValue> Current
			{
				[return: Nullable(new byte[]
				{
					0,
					1,
					1
				})]
				get
				{
					return this._treeEnum.Current;
				}
			}

			// Token: 0x17000094 RID: 148
			// (get) Token: 0x060001CB RID: 459 RVA: 0x00007BA1 File Offset: 0x00005DA1
			internal bool NotStartedOrEnded
			{
				get
				{
					return this._treeEnum.NotStartedOrEnded;
				}
			}

			// Token: 0x060001CC RID: 460 RVA: 0x00007BAE File Offset: 0x00005DAE
			internal void Reset()
			{
				this._treeEnum.Reset();
			}

			// Token: 0x060001CD RID: 461 RVA: 0x00007BAE File Offset: 0x00005DAE
			void IEnumerator.Reset()
			{
				this._treeEnum.Reset();
			}

			// Token: 0x17000095 RID: 149
			// (get) Token: 0x060001CE RID: 462 RVA: 0x00007BBC File Offset: 0x00005DBC
			[Nullable(2)]
			object IEnumerator.Current
			{
				get
				{
					if (this.NotStartedOrEnded)
					{
						throw new InvalidOperationException(SR.InvalidOperation_EnumOpCantHappen);
					}
					KeyValuePair<TKey, TValue> keyValuePair;
					if (this._getEnumeratorRetType == 2)
					{
						keyValuePair = this.Current;
						object key = keyValuePair.Key;
						keyValuePair = this.Current;
						return new DictionaryEntry(key, keyValuePair.Value);
					}
					keyValuePair = this.Current;
					TKey key2 = keyValuePair.Key;
					keyValuePair = this.Current;
					return new KeyValuePair<TKey, TValue>(key2, keyValuePair.Value);
				}
			}

			// Token: 0x17000096 RID: 150
			// (get) Token: 0x060001CF RID: 463 RVA: 0x00007C3C File Offset: 0x00005E3C
			[Nullable(1)]
			object IDictionaryEnumerator.Key
			{
				get
				{
					if (this.NotStartedOrEnded)
					{
						throw new InvalidOperationException(SR.InvalidOperation_EnumOpCantHappen);
					}
					KeyValuePair<TKey, TValue> keyValuePair = this.Current;
					return keyValuePair.Key;
				}
			}

			// Token: 0x17000097 RID: 151
			// (get) Token: 0x060001D0 RID: 464 RVA: 0x00007C70 File Offset: 0x00005E70
			[Nullable(2)]
			object IDictionaryEnumerator.Value
			{
				get
				{
					if (this.NotStartedOrEnded)
					{
						throw new InvalidOperationException(SR.InvalidOperation_EnumOpCantHappen);
					}
					KeyValuePair<TKey, TValue> keyValuePair = this.Current;
					return keyValuePair.Value;
				}
			}

			// Token: 0x17000098 RID: 152
			// (get) Token: 0x060001D1 RID: 465 RVA: 0x00007CA4 File Offset: 0x00005EA4
			DictionaryEntry IDictionaryEnumerator.Entry
			{
				get
				{
					if (this.NotStartedOrEnded)
					{
						throw new InvalidOperationException(SR.InvalidOperation_EnumOpCantHappen);
					}
					KeyValuePair<TKey, TValue> keyValuePair = this.Current;
					object key = keyValuePair.Key;
					keyValuePair = this.Current;
					return new DictionaryEntry(key, keyValuePair.Value);
				}
			}

			// Token: 0x04000049 RID: 73
			private SortedSet<KeyValuePair<TKey, TValue>>.Enumerator _treeEnum;

			// Token: 0x0400004A RID: 74
			private readonly int _getEnumeratorRetType;
		}

		// Token: 0x02000023 RID: 35
		[NullableContext(0)]
		[DebuggerTypeProxy(typeof(DictionaryKeyCollectionDebugView<, >))]
		[DebuggerDisplay("Count = {Count}")]
		public sealed class KeyCollection : ICollection<!0>, IEnumerable<!0>, IEnumerable, ICollection, IReadOnlyCollection<TKey>
		{
			// Token: 0x060001D2 RID: 466 RVA: 0x00007CEF File Offset: 0x00005EEF
			[NullableContext(1)]
			public KeyCollection(SortedDictionary<TKey, TValue> dictionary)
			{
				ArgumentNullException.ThrowIfNull(dictionary, "dictionary");
				this._dictionary = dictionary;
			}

			// Token: 0x060001D3 RID: 467 RVA: 0x00007D09 File Offset: 0x00005F09
			public SortedDictionary<TKey, TValue>.KeyCollection.Enumerator GetEnumerator()
			{
				return new SortedDictionary<TKey, TValue>.KeyCollection.Enumerator(this._dictionary);
			}

			// Token: 0x060001D4 RID: 468 RVA: 0x00007D18 File Offset: 0x00005F18
			IEnumerator<TKey> IEnumerable<!0>.GetEnumerator()
			{
				if (this.Count != 0)
				{
					return this.GetEnumerator();
				}
				return EnumerableHelpers.GetEmptyEnumerator<TKey>();
			}

			// Token: 0x060001D5 RID: 469 RVA: 0x0000484C File Offset: 0x00002A4C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return ((IEnumerable<!0>)this).GetEnumerator();
			}

			// Token: 0x060001D6 RID: 470 RVA: 0x00007D40 File Offset: 0x00005F40
			[NullableContext(1)]
			public void CopyTo(TKey[] array, int index)
			{
				ArgumentNullException.ThrowIfNull(array, "array");
				ArgumentOutOfRangeException.ThrowIfNegative<int>(index, "index");
				if (array.Length - index < this.Count)
				{
					throw new ArgumentException(SR.Arg_ArrayPlusOffTooSmall);
				}
				this._dictionary._set.InOrderTreeWalk(delegate(SortedSet<KeyValuePair<TKey, TValue>>.Node node)
				{
					TKey[] array2 = array;
					int index2 = index;
					index = index2 + 1;
					array2[index2] = node.Item.Key;
					return true;
				});
			}

			// Token: 0x060001D7 RID: 471 RVA: 0x00007DC0 File Offset: 0x00005FC0
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
				ArgumentOutOfRangeException.ThrowIfNegative<int>(index, "index");
				if (array.Length - index < this._dictionary.Count)
				{
					throw new ArgumentException(SR.Arg_ArrayPlusOffTooSmall);
				}
				TKey[] array2 = array as TKey[];
				if (array2 != null)
				{
					this.CopyTo(array2, index);
					return;
				}
				try
				{
					object[] objects = (object[])array;
					this._dictionary._set.InOrderTreeWalk(delegate(SortedSet<KeyValuePair<TKey, TValue>>.Node node)
					{
						object[] objects = objects;
						int index2 = index;
						index = index2 + 1;
						objects[index2] = node.Item.Key;
						return true;
					});
				}
				catch (ArrayTypeMismatchException)
				{
					throw new ArgumentException(SR.Argument_IncompatibleArrayType, "array");
				}
			}

			// Token: 0x17000099 RID: 153
			// (get) Token: 0x060001D8 RID: 472 RVA: 0x00007EB4 File Offset: 0x000060B4
			public int Count
			{
				get
				{
					return this._dictionary.Count;
				}
			}

			// Token: 0x1700009A RID: 154
			// (get) Token: 0x060001D9 RID: 473 RVA: 0x00003ED3 File Offset: 0x000020D3
			bool ICollection<!0>.IsReadOnly
			{
				get
				{
					return true;
				}
			}

			// Token: 0x060001DA RID: 474 RVA: 0x00007EC1 File Offset: 0x000060C1
			void ICollection<!0>.Add(TKey item)
			{
				throw new NotSupportedException(SR.NotSupported_KeyCollectionSet);
			}

			// Token: 0x060001DB RID: 475 RVA: 0x00007EC1 File Offset: 0x000060C1
			void ICollection<!0>.Clear()
			{
				throw new NotSupportedException(SR.NotSupported_KeyCollectionSet);
			}

			// Token: 0x060001DC RID: 476 RVA: 0x00007ECD File Offset: 0x000060CD
			[NullableContext(1)]
			public bool Contains(TKey item)
			{
				return this._dictionary.ContainsKey(item);
			}

			// Token: 0x060001DD RID: 477 RVA: 0x00007EC1 File Offset: 0x000060C1
			bool ICollection<!0>.Remove(TKey item)
			{
				throw new NotSupportedException(SR.NotSupported_KeyCollectionSet);
			}

			// Token: 0x1700009B RID: 155
			// (get) Token: 0x060001DE RID: 478 RVA: 0x00003925 File Offset: 0x00001B25
			bool ICollection.IsSynchronized
			{
				get
				{
					return false;
				}
			}

			// Token: 0x1700009C RID: 156
			// (get) Token: 0x060001DF RID: 479 RVA: 0x00007EDB File Offset: 0x000060DB
			[Nullable(1)]
			object ICollection.SyncRoot
			{
				get
				{
					return ((ICollection)this._dictionary).SyncRoot;
				}
			}

			// Token: 0x0400004B RID: 75
			private readonly SortedDictionary<TKey, TValue> _dictionary;

			// Token: 0x02000024 RID: 36
			public struct Enumerator : IEnumerator<TKey>, IEnumerator, IDisposable
			{
				// Token: 0x060001E0 RID: 480 RVA: 0x00007EE8 File Offset: 0x000060E8
				internal Enumerator(SortedDictionary<TKey, TValue> dictionary)
				{
					this._dictEnum = dictionary.GetEnumerator();
				}

				// Token: 0x060001E1 RID: 481 RVA: 0x00007EF6 File Offset: 0x000060F6
				public void Dispose()
				{
					this._dictEnum.Dispose();
				}

				// Token: 0x060001E2 RID: 482 RVA: 0x00007F03 File Offset: 0x00006103
				public bool MoveNext()
				{
					return this._dictEnum.MoveNext();
				}

				// Token: 0x1700009D RID: 157
				// (get) Token: 0x060001E3 RID: 483 RVA: 0x00007F10 File Offset: 0x00006110
				[Nullable(1)]
				public TKey Current
				{
					[NullableContext(1)]
					get
					{
						KeyValuePair<TKey, TValue> keyValuePair = this._dictEnum.Current;
						return keyValuePair.Key;
					}
				}

				// Token: 0x1700009E RID: 158
				// (get) Token: 0x060001E4 RID: 484 RVA: 0x00007F30 File Offset: 0x00006130
				[Nullable(2)]
				object IEnumerator.Current
				{
					get
					{
						if (this._dictEnum.NotStartedOrEnded)
						{
							throw new InvalidOperationException(SR.InvalidOperation_EnumOpCantHappen);
						}
						return this.Current;
					}
				}

				// Token: 0x060001E5 RID: 485 RVA: 0x00007F55 File Offset: 0x00006155
				void IEnumerator.Reset()
				{
					this._dictEnum.Reset();
				}

				// Token: 0x0400004C RID: 76
				private SortedDictionary<TKey, TValue>.Enumerator _dictEnum;
			}
		}

		// Token: 0x02000027 RID: 39
		[NullableContext(0)]
		[DebuggerTypeProxy(typeof(DictionaryValueCollectionDebugView<, >))]
		[DebuggerDisplay("Count = {Count}")]
		public sealed class ValueCollection : ICollection<!1>, IEnumerable<!1>, IEnumerable, ICollection, IReadOnlyCollection<TValue>
		{
			// Token: 0x060001EA RID: 490 RVA: 0x00007FD5 File Offset: 0x000061D5
			[NullableContext(1)]
			public ValueCollection(SortedDictionary<TKey, TValue> dictionary)
			{
				ArgumentNullException.ThrowIfNull(dictionary, "dictionary");
				this._dictionary = dictionary;
			}

			// Token: 0x060001EB RID: 491 RVA: 0x00007FEF File Offset: 0x000061EF
			public SortedDictionary<TKey, TValue>.ValueCollection.Enumerator GetEnumerator()
			{
				return new SortedDictionary<TKey, TValue>.ValueCollection.Enumerator(this._dictionary);
			}

			// Token: 0x060001EC RID: 492 RVA: 0x00007FFC File Offset: 0x000061FC
			IEnumerator<TValue> IEnumerable<!1>.GetEnumerator()
			{
				if (this.Count != 0)
				{
					return this.GetEnumerator();
				}
				return EnumerableHelpers.GetEmptyEnumerator<TValue>();
			}

			// Token: 0x060001ED RID: 493 RVA: 0x0000635C File Offset: 0x0000455C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return ((IEnumerable<!1>)this).GetEnumerator();
			}

			// Token: 0x060001EE RID: 494 RVA: 0x00008024 File Offset: 0x00006224
			[NullableContext(1)]
			public void CopyTo(TValue[] array, int index)
			{
				ArgumentNullException.ThrowIfNull(array, "array");
				ArgumentOutOfRangeException.ThrowIfNegative<int>(index, "index");
				if (array.Length - index < this.Count)
				{
					throw new ArgumentException(SR.Arg_ArrayPlusOffTooSmall);
				}
				this._dictionary._set.InOrderTreeWalk(delegate(SortedSet<KeyValuePair<TKey, TValue>>.Node node)
				{
					TValue[] array2 = array;
					int index2 = index;
					index = index2 + 1;
					array2[index2] = node.Item.Value;
					return true;
				});
			}

			// Token: 0x060001EF RID: 495 RVA: 0x000080A4 File Offset: 0x000062A4
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
				ArgumentOutOfRangeException.ThrowIfNegative<int>(index, "index");
				if (array.Length - index < this._dictionary.Count)
				{
					throw new ArgumentException(SR.Arg_ArrayPlusOffTooSmall);
				}
				TValue[] array2 = array as TValue[];
				if (array2 != null)
				{
					this.CopyTo(array2, index);
					return;
				}
				try
				{
					object[] objects = (object[])array;
					this._dictionary._set.InOrderTreeWalk(delegate(SortedSet<KeyValuePair<TKey, TValue>>.Node node)
					{
						object[] objects = objects;
						int index2 = index;
						index = index2 + 1;
						objects[index2] = node.Item.Value;
						return true;
					});
				}
				catch (ArrayTypeMismatchException)
				{
					throw new ArgumentException(SR.Argument_IncompatibleArrayType, "array");
				}
			}

			// Token: 0x1700009F RID: 159
			// (get) Token: 0x060001F0 RID: 496 RVA: 0x00008198 File Offset: 0x00006398
			public int Count
			{
				get
				{
					return this._dictionary.Count;
				}
			}

			// Token: 0x170000A0 RID: 160
			// (get) Token: 0x060001F1 RID: 497 RVA: 0x00003ED3 File Offset: 0x000020D3
			bool ICollection<!1>.IsReadOnly
			{
				get
				{
					return true;
				}
			}

			// Token: 0x060001F2 RID: 498 RVA: 0x000081A5 File Offset: 0x000063A5
			void ICollection<!1>.Add(TValue item)
			{
				throw new NotSupportedException(SR.NotSupported_ValueCollectionSet);
			}

			// Token: 0x060001F3 RID: 499 RVA: 0x000081A5 File Offset: 0x000063A5
			void ICollection<!1>.Clear()
			{
				throw new NotSupportedException(SR.NotSupported_ValueCollectionSet);
			}

			// Token: 0x060001F4 RID: 500 RVA: 0x000081B1 File Offset: 0x000063B1
			bool ICollection<!1>.Contains(TValue item)
			{
				return this._dictionary.ContainsValue(item);
			}

			// Token: 0x060001F5 RID: 501 RVA: 0x000081A5 File Offset: 0x000063A5
			bool ICollection<!1>.Remove(TValue item)
			{
				throw new NotSupportedException(SR.NotSupported_ValueCollectionSet);
			}

			// Token: 0x170000A1 RID: 161
			// (get) Token: 0x060001F6 RID: 502 RVA: 0x00003925 File Offset: 0x00001B25
			bool ICollection.IsSynchronized
			{
				get
				{
					return false;
				}
			}

			// Token: 0x170000A2 RID: 162
			// (get) Token: 0x060001F7 RID: 503 RVA: 0x000081BF File Offset: 0x000063BF
			[Nullable(1)]
			object ICollection.SyncRoot
			{
				get
				{
					return ((ICollection)this._dictionary).SyncRoot;
				}
			}

			// Token: 0x04000051 RID: 81
			private readonly SortedDictionary<TKey, TValue> _dictionary;

			// Token: 0x02000028 RID: 40
			public struct Enumerator : IEnumerator<TValue>, IEnumerator, IDisposable
			{
				// Token: 0x060001F8 RID: 504 RVA: 0x000081CC File Offset: 0x000063CC
				internal Enumerator(SortedDictionary<TKey, TValue> dictionary)
				{
					this._dictEnum = dictionary.GetEnumerator();
				}

				// Token: 0x060001F9 RID: 505 RVA: 0x000081DA File Offset: 0x000063DA
				public void Dispose()
				{
					this._dictEnum.Dispose();
				}

				// Token: 0x060001FA RID: 506 RVA: 0x000081E7 File Offset: 0x000063E7
				public bool MoveNext()
				{
					return this._dictEnum.MoveNext();
				}

				// Token: 0x170000A3 RID: 163
				// (get) Token: 0x060001FB RID: 507 RVA: 0x000081F4 File Offset: 0x000063F4
				[Nullable(1)]
				public TValue Current
				{
					[NullableContext(1)]
					get
					{
						KeyValuePair<TKey, TValue> keyValuePair = this._dictEnum.Current;
						return keyValuePair.Value;
					}
				}

				// Token: 0x170000A4 RID: 164
				// (get) Token: 0x060001FC RID: 508 RVA: 0x00008214 File Offset: 0x00006414
				[Nullable(2)]
				object IEnumerator.Current
				{
					get
					{
						if (this._dictEnum.NotStartedOrEnded)
						{
							throw new InvalidOperationException(SR.InvalidOperation_EnumOpCantHappen);
						}
						return this.Current;
					}
				}

				// Token: 0x060001FD RID: 509 RVA: 0x00008239 File Offset: 0x00006439
				void IEnumerator.Reset()
				{
					this._dictEnum.Reset();
				}

				// Token: 0x04000052 RID: 82
				private SortedDictionary<TKey, TValue>.Enumerator _dictEnum;
			}
		}

		// Token: 0x0200002B RID: 43
		[NullableContext(2)]
		[Nullable(new byte[]
		{
			0,
			0,
			1,
			1
		})]
		[Serializable]
		public sealed class KeyValuePairComparer : Comparer<KeyValuePair<TKey, TValue>>
		{
			// Token: 0x06000202 RID: 514 RVA: 0x000082B9 File Offset: 0x000064B9
			public KeyValuePairComparer([Nullable(new byte[]
			{
				2,
				1
			})] IComparer<TKey> keyComparer)
			{
				this.keyComparer = (keyComparer ?? Comparer<TKey>.Default);
			}

			// Token: 0x06000203 RID: 515 RVA: 0x000082D1 File Offset: 0x000064D1
			public override int Compare([Nullable(new byte[]
			{
				0,
				1,
				1
			})] KeyValuePair<TKey, TValue> x, [Nullable(new byte[]
			{
				0,
				1,
				1
			})] KeyValuePair<TKey, TValue> y)
			{
				return this.keyComparer.Compare(x.Key, y.Key);
			}

			// Token: 0x06000204 RID: 516 RVA: 0x000082EC File Offset: 0x000064EC
			public override bool Equals(object obj)
			{
				SortedDictionary<TKey, TValue>.KeyValuePairComparer keyValuePairComparer = obj as SortedDictionary<TKey, TValue>.KeyValuePairComparer;
				return keyValuePairComparer != null && (this.keyComparer == keyValuePairComparer.keyComparer || this.keyComparer.Equals(keyValuePairComparer.keyComparer));
			}

			// Token: 0x06000205 RID: 517 RVA: 0x00008326 File Offset: 0x00006526
			public override int GetHashCode()
			{
				return this.keyComparer.GetHashCode();
			}

			// Token: 0x04000057 RID: 87
			internal IComparer<TKey> keyComparer;
		}
	}
}
