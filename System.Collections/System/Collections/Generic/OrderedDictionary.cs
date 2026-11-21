using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Collections.Generic
{
	// Token: 0x02000015 RID: 21
	[NullableContext(1)]
	[Nullable(0)]
	[DebuggerTypeProxy(typeof(IDictionaryDebugView<, >))]
	[DebuggerDisplay("Count = {Count}")]
	public class OrderedDictionary<TKey, [Nullable(2)] TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IReadOnlyDictionary<TKey, TValue>, IReadOnlyCollection<KeyValuePair<TKey, TValue>>, IDictionary, ICollection, IList<KeyValuePair<TKey, TValue>>, IReadOnlyList<KeyValuePair<TKey, TValue>>, IList
	{
		// Token: 0x060000C4 RID: 196 RVA: 0x00004A56 File Offset: 0x00002C56
		public OrderedDictionary() : this(0, null)
		{
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00004A60 File Offset: 0x00002C60
		public OrderedDictionary(int capacity) : this(capacity, null)
		{
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00004A6A File Offset: 0x00002C6A
		public OrderedDictionary([Nullable(new byte[]
		{
			2,
			1
		})] IEqualityComparer<TKey> comparer) : this(0, comparer)
		{
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00004A74 File Offset: 0x00002C74
		public OrderedDictionary(int capacity, [Nullable(new byte[]
		{
			2,
			1
		})] IEqualityComparer<TKey> comparer)
		{
			ArgumentOutOfRangeException.ThrowIfNegative<int>(capacity, "capacity");
			if (capacity > 0)
			{
				this.EnsureBucketsAndEntriesInitialized(capacity);
			}
			if (!typeof(TKey).IsValueType)
			{
				this._comparer = (comparer ?? EqualityComparer<TKey>.Default);
				if (typeof(TKey) == typeof(string))
				{
					IEqualityComparer<string> stringComparer = NonRandomizedStringEqualityComparer.GetStringComparer(this._comparer);
					if (stringComparer != null)
					{
						this._comparer = (IEqualityComparer<TKey>)stringComparer;
						return;
					}
				}
			}
			else if (comparer != null && comparer != EqualityComparer<TKey>.Default)
			{
				this._comparer = comparer;
			}
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00004B07 File Offset: 0x00002D07
		public OrderedDictionary(IDictionary<TKey, TValue> dictionary) : this(dictionary, null)
		{
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00004B11 File Offset: 0x00002D11
		public OrderedDictionary(IDictionary<TKey, TValue> dictionary, [Nullable(new byte[]
		{
			2,
			1
		})] IEqualityComparer<TKey> comparer) : this((dictionary != null) ? dictionary.Count : 0, comparer)
		{
			ArgumentNullException.ThrowIfNull(dictionary, "dictionary");
			this.AddRange(dictionary);
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00004B38 File Offset: 0x00002D38
		public OrderedDictionary([Nullable(new byte[]
		{
			1,
			0,
			1,
			1
		})] IEnumerable<KeyValuePair<TKey, TValue>> collection) : this(collection, null)
		{
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00004B42 File Offset: 0x00002D42
		public OrderedDictionary([Nullable(new byte[]
		{
			1,
			0,
			1,
			1
		})] IEnumerable<KeyValuePair<TKey, TValue>> collection, [Nullable(new byte[]
		{
			2,
			1
		})] IEqualityComparer<TKey> comparer)
		{
			ICollection<KeyValuePair<TKey, TValue>> collection2 = collection as ICollection<KeyValuePair<TKey, TValue>>;
			this..ctor((collection2 != null) ? collection2.Count : 0, comparer);
			ArgumentNullException.ThrowIfNull(collection, "collection");
			this.AddRange(collection);
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00004B6F File Offset: 0x00002D6F
		[MemberNotNull("_buckets")]
		[MemberNotNull("_entries")]
		private void EnsureBucketsAndEntriesInitialized(int capacity)
		{
			this.Resize(HashHelpers.GetPrime(capacity), false);
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000CD RID: 205 RVA: 0x00004B7E File Offset: 0x00002D7E
		public int Capacity
		{
			get
			{
				OrderedDictionary<TKey, TValue>.Entry[] entries = this._entries;
				if (entries == null)
				{
					return 0;
				}
				return entries.Length;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000CE RID: 206 RVA: 0x00004B90 File Offset: 0x00002D90
		public IEqualityComparer<TKey> Comparer
		{
			get
			{
				IEqualityComparer<TKey> comparer = this._comparer;
				if (typeof(TKey) == typeof(string))
				{
					NonRandomizedStringEqualityComparer nonRandomizedStringEqualityComparer = comparer as NonRandomizedStringEqualityComparer;
					IEqualityComparer<TKey> equalityComparer = ((nonRandomizedStringEqualityComparer != null) ? nonRandomizedStringEqualityComparer.GetUnderlyingEqualityComparer() : null) as IEqualityComparer<TKey>;
					if (equalityComparer != null)
					{
						return equalityComparer;
					}
				}
				return comparer ?? EqualityComparer<TKey>.Default;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000CF RID: 207 RVA: 0x00004BE6 File Offset: 0x00002DE6
		public int Count
		{
			get
			{
				return this._count;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x00003925 File Offset: 0x00001B25
		bool ICollection<KeyValuePair<!0, !1>>.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x00003925 File Offset: 0x00001B25
		bool IDictionary.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x00003925 File Offset: 0x00001B25
		bool IList.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x00003925 File Offset: 0x00001B25
		bool IDictionary.IsFixedSize
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x00003925 File Offset: 0x00001B25
		bool IList.IsFixedSize
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x00004BF0 File Offset: 0x00002DF0
		[Nullable(new byte[]
		{
			1,
			0,
			0
		})]
		public OrderedDictionary<TKey, TValue>.KeyCollection Keys
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				0
			})]
			get
			{
				OrderedDictionary<TKey, TValue>.KeyCollection result;
				if ((result = this._keys) == null)
				{
					result = (this._keys = new OrderedDictionary<TKey, TValue>.KeyCollection(this));
				}
				return result;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x00004C16 File Offset: 0x00002E16
		IEnumerable<TKey> IReadOnlyDictionary<!0, !1>.Keys
		{
			get
			{
				return this.Keys;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x00004C16 File Offset: 0x00002E16
		ICollection<TKey> IDictionary<!0, !1>.Keys
		{
			get
			{
				return this.Keys;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x00004C16 File Offset: 0x00002E16
		ICollection IDictionary.Keys
		{
			get
			{
				return this.Keys;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x00004C20 File Offset: 0x00002E20
		[Nullable(new byte[]
		{
			1,
			0,
			0
		})]
		public OrderedDictionary<TKey, TValue>.ValueCollection Values
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				0
			})]
			get
			{
				OrderedDictionary<TKey, TValue>.ValueCollection result;
				if ((result = this._values) == null)
				{
					result = (this._values = new OrderedDictionary<TKey, TValue>.ValueCollection(this));
				}
				return result;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060000DA RID: 218 RVA: 0x00004C46 File Offset: 0x00002E46
		IEnumerable<TValue> IReadOnlyDictionary<!0, !1>.Values
		{
			get
			{
				return this.Values;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060000DB RID: 219 RVA: 0x00004C46 File Offset: 0x00002E46
		ICollection<TValue> IDictionary<!0, !1>.Values
		{
			get
			{
				return this.Values;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060000DC RID: 220 RVA: 0x00004C46 File Offset: 0x00002E46
		ICollection IDictionary.Values
		{
			get
			{
				return this.Values;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060000DD RID: 221 RVA: 0x00003925 File Offset: 0x00001B25
		bool ICollection.IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060000DE RID: 222 RVA: 0x00003922 File Offset: 0x00001B22
		object ICollection.SyncRoot
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000059 RID: 89
		[Nullable(2)]
		object IList.this[int index]
		{
			get
			{
				return this.GetAt(index);
			}
			set
			{
				ArgumentNullException.ThrowIfNull(value, "value");
				if (value is KeyValuePair<TKey, TValue>)
				{
					KeyValuePair<TKey, TValue> keyValuePair = (KeyValuePair<TKey, TValue>)value;
					this.SetAt(index, keyValuePair.Key, keyValuePair.Value);
					return;
				}
				throw new ArgumentException(SR.Format(SR.Arg_WrongType, value, typeof(KeyValuePair<TKey, TValue>)), "value");
			}
		}

		// Token: 0x1700005A RID: 90
		[Nullable(2)]
		object IDictionary.this[object key]
		{
			get
			{
				ArgumentNullException.ThrowIfNull(key, "key");
				if (key is TKey)
				{
					TKey key2 = (TKey)((object)key);
					TValue tvalue;
					if (this.TryGetValue(key2, out tvalue))
					{
						return tvalue;
					}
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
				if (key is TKey)
				{
					TKey key2 = (TKey)((object)key);
					TValue value2 = default(TValue);
					if (value != null)
					{
						if (!(value is TValue))
						{
							throw new ArgumentException(SR.Format(SR.Arg_WrongType, value, typeof(TValue)), "value");
						}
						TValue tvalue = (TValue)((object)value);
						value2 = tvalue;
					}
					this[key2] = value2;
					return;
				}
				throw new ArgumentException(SR.Format(SR.Arg_WrongType, key, typeof(TKey)), "key");
			}
		}

		// Token: 0x1700005B RID: 91
		[Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		KeyValuePair<TKey, TValue> IList<KeyValuePair<!0, !1>>.this[int index]
		{
			get
			{
				return this.GetAt(index);
			}
			set
			{
				this.SetAt(index, value.Key, value.Value);
			}
		}

		// Token: 0x1700005C RID: 92
		[Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		KeyValuePair<TKey, TValue> IReadOnlyList<KeyValuePair<!0, !1>>.this[int index]
		{
			get
			{
				return this.GetAt(index);
			}
		}

		// Token: 0x1700005D RID: 93
		public TValue this[TKey key]
		{
			get
			{
				TValue result;
				if (!this.TryGetValue(key, out result))
				{
					ThrowHelper.ThrowKeyNotFound<TKey>(key);
				}
				return result;
			}
			set
			{
				ArgumentNullException.ThrowIfNull(key, "key");
				this.TryInsert(-1, key, value, InsertionBehavior.OverwriteExisting);
			}
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00004E00 File Offset: 0x00003000
		private bool TryInsert(int index, TKey key, TValue value, InsertionBehavior behavior)
		{
			uint hashCode = 0U;
			uint collisionCount = 0U;
			int i = this.IndexOf(key, ref hashCode, ref collisionCount);
			if (i >= 0)
			{
				if (behavior == InsertionBehavior.OverwriteExisting)
				{
					this._entries[i].Value = value;
					return true;
				}
				if (behavior != InsertionBehavior.ThrowOnExisting)
				{
					return false;
				}
				ThrowHelper.ThrowDuplicateKey<TKey>(key);
			}
			if (index < 0)
			{
				index = this._count;
			}
			if (this._buckets == null)
			{
				this.EnsureBucketsAndEntriesInitialized(0);
			}
			OrderedDictionary<TKey, TValue>.Entry[] entries = this._entries;
			if (entries.Length == this._count)
			{
				this.Resize(HashHelpers.ExpandPrime(entries.Length), false);
				entries = this._entries;
			}
			for (i = this._count - 1; i >= index; i--)
			{
				entries[i + 1] = entries[i];
				this.UpdateBucketIndex(i, 1);
			}
			ref OrderedDictionary<TKey, TValue>.Entry ptr = ref entries[index];
			ptr.HashCode = hashCode;
			ptr.Key = key;
			ptr.Value = value;
			this.PushEntryIntoBucket(ref ptr, index);
			this._count++;
			this._version++;
			this.RehashIfNecessary(collisionCount, entries);
			return true;
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00004F08 File Offset: 0x00003108
		public void Add(TKey key, TValue value)
		{
			ArgumentNullException.ThrowIfNull(key, "key");
			this.TryInsert(-1, key, value, InsertionBehavior.ThrowOnExisting);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00004F25 File Offset: 0x00003125
		public bool TryAdd(TKey key, TValue value)
		{
			ArgumentNullException.ThrowIfNull(key, "key");
			return this.TryInsert(-1, key, value, InsertionBehavior.IgnoreInsertion);
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00004F44 File Offset: 0x00003144
		private void AddRange(IEnumerable<KeyValuePair<TKey, TValue>> collection)
		{
			KeyValuePair<TKey, TValue>[] array = collection as KeyValuePair<TKey, TValue>[];
			if (array != null)
			{
				foreach (KeyValuePair<TKey, TValue> keyValuePair in array)
				{
					this.Add(keyValuePair.Key, keyValuePair.Value);
				}
				return;
			}
			foreach (KeyValuePair<TKey, TValue> keyValuePair2 in collection)
			{
				this.Add(keyValuePair2.Key, keyValuePair2.Value);
			}
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00004FD8 File Offset: 0x000031D8
		public void Clear()
		{
			if (this._buckets != null && this._count != 0)
			{
				Array.Clear(this._buckets, 0, this._buckets.Length);
				Array.Clear(this._entries, 0, this._count);
				this._count = 0;
				this._version++;
			}
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00005030 File Offset: 0x00003230
		public bool ContainsKey(TKey key)
		{
			return this.IndexOf(key) >= 0;
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00005040 File Offset: 0x00003240
		public bool ContainsValue(TValue value)
		{
			int count = this._count;
			OrderedDictionary<TKey, TValue>.Entry[] entries = this._entries;
			if (entries == null)
			{
				return false;
			}
			if (typeof(TValue).IsValueType)
			{
				for (int i = 0; i < count; i++)
				{
					if (EqualityComparer<TValue>.Default.Equals(value, entries[i].Value))
					{
						return true;
					}
				}
			}
			else
			{
				EqualityComparer<TValue> @default = EqualityComparer<TValue>.Default;
				for (int j = 0; j < count; j++)
				{
					if (@default.Equals(value, entries[j].Value))
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x060000EF RID: 239 RVA: 0x000050CC File Offset: 0x000032CC
		[return: Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		public KeyValuePair<TKey, TValue> GetAt(int index)
		{
			if (index >= this._count)
			{
				ThrowHelper.ThrowIndexArgumentOutOfRange();
			}
			ref OrderedDictionary<TKey, TValue>.Entry ptr = ref this._entries[index];
			return new KeyValuePair<TKey, TValue>(ptr.Key, ptr.Value);
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00005108 File Offset: 0x00003308
		public int IndexOf(TKey key)
		{
			ArgumentNullException.ThrowIfNull(key, "key");
			uint num = 0U;
			return this.IndexOf(key, ref num, ref num);
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00005134 File Offset: 0x00003334
		private unsafe int IndexOf(TKey key, ref uint outHashCode, ref uint outCollisionCount)
		{
			uint num = 0U;
			IEqualityComparer<TKey> comparer = this._comparer;
			uint num2;
			int i;
			if (this._buckets != null)
			{
				ref OrderedDictionary<TKey, TValue>.Entry ptr = ref Unsafe.NullRef<OrderedDictionary<TKey, TValue>.Entry>();
				OrderedDictionary<TKey, TValue>.Entry[] entries = this._entries;
				if (typeof(TKey).IsValueType && comparer == null)
				{
					num2 = (uint)key.GetHashCode();
					i = *this.GetBucket(num2) - 1;
					while (i < entries.Length)
					{
						ptr = ref entries[i];
						if (ptr.HashCode == num2 && EqualityComparer<TKey>.Default.Equals(ptr.Key, key))
						{
							goto IL_116;
						}
						i = ptr.Next;
						num += 1U;
						if (num > (uint)entries.Length)
						{
							goto IL_111;
						}
					}
					goto IL_10A;
				}
				num2 = (uint)comparer.GetHashCode(key);
				i = *this.GetBucket(num2) - 1;
				while (i < entries.Length)
				{
					ptr = ref entries[i];
					if (ptr.HashCode == num2 && comparer.Equals(ptr.Key, key))
					{
						goto IL_116;
					}
					i = ptr.Next;
					num += 1U;
					if (num > (uint)entries.Length)
					{
						goto IL_111;
					}
				}
				goto IL_10A;
				IL_111:
				ThrowHelper.ThrowConcurrentOperation();
				goto IL_116;
			}
			num2 = (uint)((comparer != null) ? comparer.GetHashCode(key) : key.GetHashCode());
			num = 0U;
			IL_10A:
			i = -1;
			outCollisionCount = num;
			IL_116:
			outHashCode = num2;
			return i;
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x0000525B File Offset: 0x0000345B
		public void Insert(int index, TKey key, TValue value)
		{
			if (index > this._count)
			{
				ThrowHelper.ThrowIndexArgumentOutOfRange();
			}
			ArgumentNullException.ThrowIfNull(key, "key");
			this.TryInsert(index, key, value, InsertionBehavior.ThrowOnExisting);
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00005288 File Offset: 0x00003488
		public bool Remove(TKey key)
		{
			TValue tvalue;
			return this.Remove(key, out tvalue);
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x000052A0 File Offset: 0x000034A0
		public bool Remove(TKey key, [MaybeNullWhen(false)] out TValue value)
		{
			ArgumentNullException.ThrowIfNull(key, "key");
			int num = this.IndexOf(key);
			if (num >= 0)
			{
				value = this._entries[num].Value;
				this.RemoveAt(num);
				return true;
			}
			value = default(TValue);
			return false;
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x000052F4 File Offset: 0x000034F4
		public void RemoveAt(int index)
		{
			int count = this._count;
			if (index >= count)
			{
				ThrowHelper.ThrowIndexArgumentOutOfRange();
			}
			this.RemoveEntryFromBucket(index);
			OrderedDictionary<TKey, TValue>.Entry[] entries = this._entries;
			for (int i = index + 1; i < count; i++)
			{
				entries[i - 1] = entries[i];
				this.UpdateBucketIndex(i, -1);
			}
			OrderedDictionary<TKey, TValue>.Entry[] array = entries;
			int num = this._count - 1;
			this._count = num;
			array[num] = default(OrderedDictionary<TKey, TValue>.Entry);
			this._version++;
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00005370 File Offset: 0x00003570
		public void SetAt(int index, TValue value)
		{
			if (index >= this._count)
			{
				ThrowHelper.ThrowIndexArgumentOutOfRange();
			}
			this._entries[index].Value = value;
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00005394 File Offset: 0x00003594
		public void SetAt(int index, TKey key, TValue value)
		{
			if (index >= this._count)
			{
				ThrowHelper.ThrowIndexArgumentOutOfRange();
			}
			ArgumentNullException.ThrowIfNull(key, "key");
			ref OrderedDictionary<TKey, TValue>.Entry ptr = ref this._entries[index];
			if (typeof(TKey).IsValueType && this._comparer == null)
			{
				if (EqualityComparer<TKey>.Default.Equals(key, ptr.Key))
				{
					ptr.Value = value;
					return;
				}
			}
			else if (this._comparer.Equals(key, ptr.Key))
			{
				ptr.Value = value;
				return;
			}
			uint hashCode = 0U;
			uint collisionCount = 0U;
			if (this.IndexOf(key, ref hashCode, ref collisionCount) >= 0)
			{
				ThrowHelper.ThrowDuplicateKey<TKey>(key);
			}
			this.RemoveEntryFromBucket(index);
			ptr.HashCode = hashCode;
			ptr.Key = key;
			ptr.Value = value;
			this.PushEntryIntoBucket(ref ptr, index);
			this._version++;
			this.RehashIfNecessary(collisionCount, this._entries);
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00005474 File Offset: 0x00003674
		public int EnsureCapacity(int capacity)
		{
			ArgumentOutOfRangeException.ThrowIfNegative<int>(capacity, "capacity");
			if (this.Capacity < capacity)
			{
				if (this._buckets == null)
				{
					this.EnsureBucketsAndEntriesInitialized(capacity);
				}
				else
				{
					this.Resize(HashHelpers.GetPrime(capacity), false);
				}
				this._version++;
			}
			return this.Capacity;
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x000054C7 File Offset: 0x000036C7
		public void TrimExcess()
		{
			this.TrimExcess(this._count);
		}

		// Token: 0x060000FA RID: 250 RVA: 0x000054D8 File Offset: 0x000036D8
		public void TrimExcess(int capacity)
		{
			ArgumentOutOfRangeException.ThrowIfLessThan<int>(capacity, this.Count, "capacity");
			OrderedDictionary<TKey, TValue>.Entry[] entries = this._entries;
			int num = (entries != null) ? entries.Length : 0;
			capacity = HashHelpers.GetPrime(capacity);
			if (capacity < num)
			{
				this.Resize(capacity, false);
			}
		}

		// Token: 0x060000FB RID: 251 RVA: 0x0000551C File Offset: 0x0000371C
		public bool TryGetValue(TKey key, [MaybeNullWhen(false)] out TValue value)
		{
			ArgumentNullException.ThrowIfNull(key, "key");
			int num = this.IndexOf(key);
			if (num >= 0)
			{
				value = this._entries[num].Value;
				return true;
			}
			value = default(TValue);
			return false;
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00005568 File Offset: 0x00003768
		private void PushEntryIntoBucket(ref OrderedDictionary<TKey, TValue>.Entry entry, int entryIndex)
		{
			ref int bucket = ref this.GetBucket(entry.HashCode);
			entry.Next = bucket - 1;
			bucket = entryIndex + 1;
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00005594 File Offset: 0x00003794
		private void RemoveEntryFromBucket(int entryIndex)
		{
			OrderedDictionary<TKey, TValue>.Entry[] entries = this._entries;
			OrderedDictionary<TKey, TValue>.Entry entry = entries[entryIndex];
			ref int bucket = ref this.GetBucket(entry.HashCode);
			if (bucket == entryIndex + 1)
			{
				bucket = entry.Next + 1;
				return;
			}
			int num = bucket - 1;
			int num2 = 0;
			OrderedDictionary<TKey, TValue>.Entry ptr;
			for (;;)
			{
				ptr = ref entries[num];
				if (ptr.Next == entryIndex)
				{
					break;
				}
				num = ptr.Next;
				if (++num2 > entries.Length)
				{
					ThrowHelper.ThrowConcurrentOperation();
				}
			}
			ptr.Next = entry.Next;
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00005614 File Offset: 0x00003814
		private void UpdateBucketIndex(int entryIndex, int shiftAmount)
		{
			OrderedDictionary<TKey, TValue>.Entry[] entries = this._entries;
			OrderedDictionary<TKey, TValue>.Entry entry = entries[entryIndex];
			ref int bucket = ref this.GetBucket(entry.HashCode);
			if (bucket == entryIndex + 1)
			{
				bucket += shiftAmount;
				return;
			}
			int num = bucket - 1;
			int num2 = 0;
			OrderedDictionary<TKey, TValue>.Entry ptr;
			for (;;)
			{
				ptr = ref entries[num];
				if (ptr.Next == entryIndex)
				{
					break;
				}
				num = ptr.Next;
				if (++num2 > entries.Length)
				{
					ThrowHelper.ThrowConcurrentOperation();
				}
			}
			ptr.Next += shiftAmount;
		}

		// Token: 0x060000FF RID: 255 RVA: 0x0000568D File Offset: 0x0000388D
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void RehashIfNecessary(uint collisionCount, OrderedDictionary<TKey, TValue>.Entry[] entries)
		{
			if (!typeof(TKey).IsValueType && collisionCount > 100U && this._comparer is NonRandomizedStringEqualityComparer)
			{
				this.Resize(entries.Length, true);
			}
		}

		// Token: 0x06000100 RID: 256 RVA: 0x000056BC File Offset: 0x000038BC
		[MemberNotNull("_buckets")]
		[MemberNotNull("_entries")]
		private void Resize(int newSize, bool forceNewHashCodes = false)
		{
			int[] buckets = new int[newSize];
			OrderedDictionary<TKey, TValue>.Entry[] array = new OrderedDictionary<TKey, TValue>.Entry[newSize];
			if (IntPtr.Size == 8)
			{
				this._fastModMultiplier = HashHelpers.GetFastModMultiplier((uint)newSize);
			}
			int count = this._count;
			if (this._entries != null)
			{
				Array.Copy(this._entries, array, count);
			}
			if (!typeof(TKey).IsValueType && forceNewHashCodes)
			{
				IEqualityComparer<TKey> equalityComparer = this._comparer = (IEqualityComparer<TKey>)((NonRandomizedStringEqualityComparer)this._comparer).GetUnderlyingEqualityComparer();
				for (int i = 0; i < count; i++)
				{
					array[i].HashCode = (uint)equalityComparer.GetHashCode(array[i].Key);
				}
			}
			this._buckets = buckets;
			for (int j = 0; j < count; j++)
			{
				this.PushEntryIntoBucket(ref array[j], j);
			}
			this._entries = array;
		}

		// Token: 0x06000101 RID: 257 RVA: 0x0000579C File Offset: 0x0000399C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private ref int GetBucket(uint hashCode)
		{
			int[] buckets = this._buckets;
			if (IntPtr.Size == 8)
			{
				return ref buckets[(int)HashHelpers.FastMod(hashCode, (uint)buckets.Length, this._fastModMultiplier)];
			}
			return ref buckets[(int)(checked((IntPtr)(unchecked((ulong)hashCode % (ulong)((long)buckets.Length)))))];
		}

		// Token: 0x06000102 RID: 258 RVA: 0x000057DC File Offset: 0x000039DC
		[NullableContext(0)]
		public OrderedDictionary<TKey, TValue>.Enumerator GetEnumerator()
		{
			return new OrderedDictionary<TKey, TValue>.Enumerator(this, false);
		}

		// Token: 0x06000103 RID: 259 RVA: 0x000057E8 File Offset: 0x000039E8
		IEnumerator<KeyValuePair<TKey, TValue>> IEnumerable<KeyValuePair<!0, !1>>.GetEnumerator()
		{
			if (this.Count != 0)
			{
				return this.GetEnumerator();
			}
			return EnumerableHelpers.GetEmptyEnumerator<KeyValuePair<TKey, TValue>>();
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00005810 File Offset: 0x00003A10
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<KeyValuePair<!0, !1>>)this).GetEnumerator();
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00005818 File Offset: 0x00003A18
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return new OrderedDictionary<TKey, TValue>.Enumerator(this, true);
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00005828 File Offset: 0x00003A28
		int IList<KeyValuePair<!0, !1>>.IndexOf(KeyValuePair<TKey, TValue> item)
		{
			ArgumentNullException.ThrowIfNull(item.Key, "item");
			int num = this.IndexOf(item.Key);
			if (num >= 0 && EqualityComparer<TValue>.Default.Equals(item.Value, this._entries[num].Value))
			{
				return num;
			}
			return -1;
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00005884 File Offset: 0x00003A84
		void IList<KeyValuePair<!0, !1>>.Insert(int index, KeyValuePair<TKey, TValue> item)
		{
			this.Insert(index, item.Key, item.Value);
		}

		// Token: 0x06000108 RID: 264 RVA: 0x0000589B File Offset: 0x00003A9B
		void ICollection<KeyValuePair<!0, !1>>.Add(KeyValuePair<TKey, TValue> item)
		{
			this.Add(item.Key, item.Value);
		}

		// Token: 0x06000109 RID: 265 RVA: 0x000058B4 File Offset: 0x00003AB4
		bool ICollection<KeyValuePair<!0, !1>>.Contains(KeyValuePair<TKey, TValue> item)
		{
			ArgumentNullException.ThrowIfNull(item.Key, "item");
			TValue x;
			return this.TryGetValue(item.Key, out x) && EqualityComparer<TValue>.Default.Equals(x, item.Value);
		}

		// Token: 0x0600010A RID: 266 RVA: 0x000058FC File Offset: 0x00003AFC
		void ICollection<KeyValuePair<!0, !1>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
		{
			ArgumentNullException.ThrowIfNull(array, "array");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(arrayIndex, "arrayIndex");
			if (array.Length - arrayIndex < this._count)
			{
				throw new ArgumentException(SR.Arg_ArrayPlusOffTooSmall);
			}
			for (int i = 0; i < this._count; i++)
			{
				ref OrderedDictionary<TKey, TValue>.Entry ptr = ref this._entries[i];
				array[arrayIndex++] = new KeyValuePair<TKey, TValue>(ptr.Key, ptr.Value);
			}
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00005974 File Offset: 0x00003B74
		bool ICollection<KeyValuePair<!0, !1>>.Remove(KeyValuePair<TKey, TValue> item)
		{
			TValue x;
			return this.TryGetValue(item.Key, out x) && EqualityComparer<TValue>.Default.Equals(x, item.Value) && this.Remove(item.Key);
		}

		// Token: 0x0600010C RID: 268 RVA: 0x000059B8 File Offset: 0x00003BB8
		void IDictionary.Add(object key, object value)
		{
			ArgumentNullException.ThrowIfNull(key, "key");
			if (default(TValue) != null)
			{
				ArgumentNullException.ThrowIfNull(value, "value");
			}
			if (key is TKey)
			{
				TKey key2 = (TKey)((object)key);
				if (default(TValue) != null)
				{
					ArgumentNullException.ThrowIfNull(value, "value");
				}
				TValue value2 = default(TValue);
				if (value != null)
				{
					if (!(value is TValue))
					{
						throw new ArgumentException(SR.Format(SR.Arg_WrongType, value, typeof(TValue)), "value");
					}
					TValue tvalue = (TValue)((object)value);
					value2 = tvalue;
				}
				this.Add(key2, value2);
				return;
			}
			throw new ArgumentException(SR.Format(SR.Arg_WrongType, key, typeof(TKey)), "key");
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00005A80 File Offset: 0x00003C80
		bool IDictionary.Contains(object key)
		{
			ArgumentNullException.ThrowIfNull(key, "key");
			if (key is TKey)
			{
				TKey key2 = (TKey)((object)key);
				return this.ContainsKey(key2);
			}
			return false;
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00005AB0 File Offset: 0x00003CB0
		void IDictionary.Remove(object key)
		{
			ArgumentNullException.ThrowIfNull(key, "key");
			if (key is TKey)
			{
				TKey key2 = (TKey)((object)key);
				this.Remove(key2);
			}
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00005AE0 File Offset: 0x00003CE0
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
			if (array.Length - index < this._count)
			{
				throw new ArgumentException(SR.Arg_ArrayPlusOffTooSmall);
			}
			KeyValuePair<TKey, TValue>[] array2 = array as KeyValuePair<TKey, TValue>[];
			if (array2 != null)
			{
				((ICollection<KeyValuePair<!0, !1>>)this).CopyTo(array2, index);
				return;
			}
			try
			{
				object[] array3 = array as object[];
				if (array3 == null)
				{
					throw new ArgumentException(SR.Argument_IncompatibleArrayType, "array");
				}
				foreach (KeyValuePair<TKey, TValue> keyValuePair in this)
				{
					array3[index++] = keyValuePair;
				}
			}
			catch (ArrayTypeMismatchException)
			{
				throw new ArgumentException(SR.Argument_IncompatibleArrayType, "array");
			}
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00005BE8 File Offset: 0x00003DE8
		int IList.Add(object value)
		{
			if (value is KeyValuePair<TKey, TValue>)
			{
				KeyValuePair<TKey, TValue> keyValuePair = (KeyValuePair<TKey, TValue>)value;
				this.Add(keyValuePair.Key, keyValuePair.Value);
				return this.Count - 1;
			}
			throw new ArgumentException(SR.Format(SR.Arg_WrongType, value, typeof(KeyValuePair<TKey, TValue>)), "value");
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00005C44 File Offset: 0x00003E44
		bool IList.Contains(object value)
		{
			if (value is KeyValuePair<TKey, TValue>)
			{
				KeyValuePair<TKey, TValue> keyValuePair = (KeyValuePair<TKey, TValue>)value;
				TValue x;
				if (this.TryGetValue(keyValuePair.Key, out x))
				{
					return EqualityComparer<TValue>.Default.Equals(x, keyValuePair.Value);
				}
			}
			return false;
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00005C88 File Offset: 0x00003E88
		int IList.IndexOf(object value)
		{
			if (value is KeyValuePair<TKey, TValue>)
			{
				KeyValuePair<TKey, TValue> item = (KeyValuePair<TKey, TValue>)value;
				return ((IList<KeyValuePair<!0, !1>>)this).IndexOf(item);
			}
			return -1;
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00005CB0 File Offset: 0x00003EB0
		void IList.Insert(int index, object value)
		{
			if (value is KeyValuePair<TKey, TValue>)
			{
				KeyValuePair<TKey, TValue> keyValuePair = (KeyValuePair<TKey, TValue>)value;
				this.Insert(index, keyValuePair.Key, keyValuePair.Value);
				return;
			}
			throw new ArgumentException(SR.Format(SR.Arg_WrongType, value, typeof(KeyValuePair<TKey, TValue>)), "value");
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00005D04 File Offset: 0x00003F04
		void IList.Remove(object value)
		{
			if (value is KeyValuePair<TKey, TValue>)
			{
				KeyValuePair<TKey, TValue> item = (KeyValuePair<TKey, TValue>)value;
				((ICollection<KeyValuePair<!0, !1>>)this).Remove(item);
			}
		}

		// Token: 0x04000021 RID: 33
		private IEqualityComparer<TKey> _comparer;

		// Token: 0x04000022 RID: 34
		private int[] _buckets;

		// Token: 0x04000023 RID: 35
		private OrderedDictionary<TKey, TValue>.Entry[] _entries;

		// Token: 0x04000024 RID: 36
		private int _count;

		// Token: 0x04000025 RID: 37
		private int _version;

		// Token: 0x04000026 RID: 38
		private ulong _fastModMultiplier;

		// Token: 0x04000027 RID: 39
		private OrderedDictionary<TKey, TValue>.KeyCollection _keys;

		// Token: 0x04000028 RID: 40
		private OrderedDictionary<TKey, TValue>.ValueCollection _values;

		// Token: 0x02000016 RID: 22
		private struct Entry
		{
			// Token: 0x04000029 RID: 41
			public int Next;

			// Token: 0x0400002A RID: 42
			public uint HashCode;

			// Token: 0x0400002B RID: 43
			public TKey Key;

			// Token: 0x0400002C RID: 44
			public TValue Value;
		}

		// Token: 0x02000017 RID: 23
		[NullableContext(0)]
		[StructLayout(LayoutKind.Auto)]
		public struct Enumerator : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable, IDictionaryEnumerator
		{
			// Token: 0x06000115 RID: 277 RVA: 0x00005D28 File Offset: 0x00003F28
			internal Enumerator(OrderedDictionary<TKey, TValue> dictionary, bool useDictionaryEntry)
			{
				this._index = 0;
				this.Current = default(KeyValuePair<TKey, TValue>);
				this._dictionary = dictionary;
				this._version = this._dictionary._version;
				this._useDictionaryEntry = useDictionaryEntry;
			}

			// Token: 0x1700005E RID: 94
			// (get) Token: 0x06000116 RID: 278 RVA: 0x00005D5C File Offset: 0x00003F5C
			// (set) Token: 0x06000117 RID: 279 RVA: 0x00005D64 File Offset: 0x00003F64
			[Nullable(new byte[]
			{
				0,
				1,
				1
			})]
			public KeyValuePair<TKey, TValue> Current { [return: Nullable(new byte[]
			{
				0,
				1,
				1
			})] readonly get; private set; }

			// Token: 0x1700005F RID: 95
			// (get) Token: 0x06000118 RID: 280 RVA: 0x00005D70 File Offset: 0x00003F70
			[Nullable(1)]
			object IEnumerator.Current
			{
				get
				{
					if (!this._useDictionaryEntry)
					{
						return this.Current;
					}
					KeyValuePair<TKey, TValue> keyValuePair = this.Current;
					object key = keyValuePair.Key;
					keyValuePair = this.Current;
					return new DictionaryEntry(key, keyValuePair.Value);
				}
			}

			// Token: 0x17000060 RID: 96
			// (get) Token: 0x06000119 RID: 281 RVA: 0x00005DC4 File Offset: 0x00003FC4
			DictionaryEntry IDictionaryEnumerator.Entry
			{
				get
				{
					KeyValuePair<TKey, TValue> keyValuePair = this.Current;
					object key = keyValuePair.Key;
					keyValuePair = this.Current;
					return new DictionaryEntry(key, keyValuePair.Value);
				}
			}

			// Token: 0x17000061 RID: 97
			// (get) Token: 0x0600011A RID: 282 RVA: 0x00005DFC File Offset: 0x00003FFC
			[Nullable(1)]
			object IDictionaryEnumerator.Key
			{
				get
				{
					KeyValuePair<TKey, TValue> keyValuePair = this.Current;
					return keyValuePair.Key;
				}
			}

			// Token: 0x17000062 RID: 98
			// (get) Token: 0x0600011B RID: 283 RVA: 0x00005E1C File Offset: 0x0000401C
			[Nullable(2)]
			object IDictionaryEnumerator.Value
			{
				get
				{
					KeyValuePair<TKey, TValue> keyValuePair = this.Current;
					return keyValuePair.Value;
				}
			}

			// Token: 0x0600011C RID: 284 RVA: 0x00005E3C File Offset: 0x0000403C
			public bool MoveNext()
			{
				OrderedDictionary<TKey, TValue> dictionary = this._dictionary;
				if (this._version != dictionary._version)
				{
					ThrowHelper.ThrowVersionCheckFailed();
				}
				if (this._index < dictionary._count)
				{
					ref OrderedDictionary<TKey, TValue>.Entry ptr = ref dictionary._entries[this._index];
					this.Current = new KeyValuePair<TKey, TValue>(ptr.Key, ptr.Value);
					this._index++;
					return true;
				}
				this.Current = default(KeyValuePair<TKey, TValue>);
				return false;
			}

			// Token: 0x0600011D RID: 285 RVA: 0x00005EBC File Offset: 0x000040BC
			void IEnumerator.Reset()
			{
				if (this._version != this._dictionary._version)
				{
					ThrowHelper.ThrowVersionCheckFailed();
				}
				this._index = 0;
				this.Current = default(KeyValuePair<TKey, TValue>);
			}

			// Token: 0x0600011E RID: 286 RVA: 0x000049AB File Offset: 0x00002BAB
			readonly void IDisposable.Dispose()
			{
			}

			// Token: 0x0400002D RID: 45
			private readonly OrderedDictionary<TKey, TValue> _dictionary;

			// Token: 0x0400002E RID: 46
			private readonly int _version;

			// Token: 0x0400002F RID: 47
			private readonly bool _useDictionaryEntry;

			// Token: 0x04000030 RID: 48
			private int _index;
		}

		// Token: 0x02000018 RID: 24
		[NullableContext(0)]
		[DebuggerTypeProxy(typeof(ICollectionDebugView<>))]
		[DebuggerDisplay("Count = {Count}")]
		public sealed class KeyCollection : IList<TKey>, ICollection<!0>, IEnumerable<!0>, IEnumerable, IReadOnlyList<TKey>, IReadOnlyCollection<TKey>, IList, ICollection
		{
			// Token: 0x0600011F RID: 287 RVA: 0x00005EF7 File Offset: 0x000040F7
			internal KeyCollection(OrderedDictionary<TKey, TValue> dictionary)
			{
				this._dictionary = dictionary;
			}

			// Token: 0x17000063 RID: 99
			// (get) Token: 0x06000120 RID: 288 RVA: 0x00005F06 File Offset: 0x00004106
			public int Count
			{
				get
				{
					return this._dictionary.Count;
				}
			}

			// Token: 0x17000064 RID: 100
			// (get) Token: 0x06000121 RID: 289 RVA: 0x00003ED3 File Offset: 0x000020D3
			bool ICollection<!0>.IsReadOnly
			{
				get
				{
					return true;
				}
			}

			// Token: 0x17000065 RID: 101
			// (get) Token: 0x06000122 RID: 290 RVA: 0x00003ED3 File Offset: 0x000020D3
			bool IList.IsReadOnly
			{
				get
				{
					return true;
				}
			}

			// Token: 0x17000066 RID: 102
			// (get) Token: 0x06000123 RID: 291 RVA: 0x00003925 File Offset: 0x00001B25
			bool IList.IsFixedSize
			{
				get
				{
					return false;
				}
			}

			// Token: 0x17000067 RID: 103
			// (get) Token: 0x06000124 RID: 292 RVA: 0x00003925 File Offset: 0x00001B25
			bool ICollection.IsSynchronized
			{
				get
				{
					return false;
				}
			}

			// Token: 0x17000068 RID: 104
			// (get) Token: 0x06000125 RID: 293 RVA: 0x00005F13 File Offset: 0x00004113
			[Nullable(1)]
			object ICollection.SyncRoot
			{
				get
				{
					return ((ICollection)this._dictionary).SyncRoot;
				}
			}

			// Token: 0x06000126 RID: 294 RVA: 0x00005F20 File Offset: 0x00004120
			[NullableContext(1)]
			public bool Contains(TKey key)
			{
				return this._dictionary.ContainsKey(key);
			}

			// Token: 0x06000127 RID: 295 RVA: 0x00005F30 File Offset: 0x00004130
			bool IList.Contains(object value)
			{
				if (value is TKey)
				{
					TKey key = (TKey)((object)value);
					return this.Contains(key);
				}
				return false;
			}

			// Token: 0x06000128 RID: 296 RVA: 0x00005F58 File Offset: 0x00004158
			[NullableContext(1)]
			public void CopyTo(TKey[] array, int arrayIndex)
			{
				ArgumentNullException.ThrowIfNull(array, "array");
				ArgumentOutOfRangeException.ThrowIfNegative<int>(arrayIndex, "arrayIndex");
				OrderedDictionary<TKey, TValue> dictionary = this._dictionary;
				int count = dictionary._count;
				if (array.Length - arrayIndex < count)
				{
					throw new ArgumentException(SR.Arg_ArrayPlusOffTooSmall, "array");
				}
				OrderedDictionary<TKey, TValue>.Entry[] entries = dictionary._entries;
				for (int i = 0; i < count; i++)
				{
					array[arrayIndex++] = entries[i].Key;
				}
			}

			// Token: 0x06000129 RID: 297 RVA: 0x00005FCC File Offset: 0x000041CC
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
					object[] array3 = array as object[];
					if (array3 == null)
					{
						throw new ArgumentException(SR.Argument_IncompatibleArrayType, "array");
					}
					foreach (TKey tkey in this)
					{
						array3[index++] = tkey;
					}
				}
				catch (ArrayTypeMismatchException)
				{
					throw new ArgumentException(SR.Argument_IncompatibleArrayType, "array");
				}
			}

			// Token: 0x17000069 RID: 105
			[Nullable(1)]
			TKey IList<!0>.this[int index]
			{
				get
				{
					return this._dictionary.GetAt(index).Key;
				}
				set
				{
					throw new NotSupportedException();
				}
			}

			// Token: 0x1700006A RID: 106
			[Nullable(2)]
			object IList.this[int index]
			{
				get
				{
					return this._dictionary.GetAt(index).Key;
				}
				set
				{
					throw new NotSupportedException();
				}
			}

			// Token: 0x1700006B RID: 107
			[Nullable(1)]
			TKey IReadOnlyList<!0>.this[int index]
			{
				get
				{
					return this._dictionary.GetAt(index).Key;
				}
			}

			// Token: 0x0600012F RID: 303 RVA: 0x00006145 File Offset: 0x00004345
			public OrderedDictionary<TKey, TValue>.KeyCollection.Enumerator GetEnumerator()
			{
				return new OrderedDictionary<TKey, TValue>.KeyCollection.Enumerator(this._dictionary);
			}

			// Token: 0x06000130 RID: 304 RVA: 0x00006154 File Offset: 0x00004354
			IEnumerator<TKey> IEnumerable<!0>.GetEnumerator()
			{
				if (this.Count != 0)
				{
					return this.GetEnumerator();
				}
				return EnumerableHelpers.GetEmptyEnumerator<TKey>();
			}

			// Token: 0x06000131 RID: 305 RVA: 0x0000484C File Offset: 0x00002A4C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return ((IEnumerable<!0>)this).GetEnumerator();
			}

			// Token: 0x06000132 RID: 306 RVA: 0x0000617C File Offset: 0x0000437C
			int IList<!0>.IndexOf(TKey item)
			{
				return this._dictionary.IndexOf(item);
			}

			// Token: 0x06000133 RID: 307 RVA: 0x00003EFC File Offset: 0x000020FC
			void ICollection<!0>.Add(TKey item)
			{
				throw new NotSupportedException();
			}

			// Token: 0x06000134 RID: 308 RVA: 0x00003EFC File Offset: 0x000020FC
			void ICollection<!0>.Clear()
			{
				throw new NotSupportedException();
			}

			// Token: 0x06000135 RID: 309 RVA: 0x00003EFC File Offset: 0x000020FC
			void IList<!0>.Insert(int index, TKey item)
			{
				throw new NotSupportedException();
			}

			// Token: 0x06000136 RID: 310 RVA: 0x00003EFC File Offset: 0x000020FC
			bool ICollection<!0>.Remove(TKey item)
			{
				throw new NotSupportedException();
			}

			// Token: 0x06000137 RID: 311 RVA: 0x00003EFC File Offset: 0x000020FC
			void IList<!0>.RemoveAt(int index)
			{
				throw new NotSupportedException();
			}

			// Token: 0x06000138 RID: 312 RVA: 0x00003EFC File Offset: 0x000020FC
			int IList.Add(object value)
			{
				throw new NotSupportedException();
			}

			// Token: 0x06000139 RID: 313 RVA: 0x00003EFC File Offset: 0x000020FC
			void IList.Clear()
			{
				throw new NotSupportedException();
			}

			// Token: 0x0600013A RID: 314 RVA: 0x0000618C File Offset: 0x0000438C
			int IList.IndexOf(object value)
			{
				if (value is TKey)
				{
					TKey key = (TKey)((object)value);
					return this._dictionary.IndexOf(key);
				}
				return -1;
			}

			// Token: 0x0600013B RID: 315 RVA: 0x00003EFC File Offset: 0x000020FC
			void IList.Insert(int index, object value)
			{
				throw new NotSupportedException();
			}

			// Token: 0x0600013C RID: 316 RVA: 0x00003EFC File Offset: 0x000020FC
			void IList.Remove(object value)
			{
				throw new NotSupportedException();
			}

			// Token: 0x0600013D RID: 317 RVA: 0x00003EFC File Offset: 0x000020FC
			void IList.RemoveAt(int index)
			{
				throw new NotSupportedException();
			}

			// Token: 0x04000032 RID: 50
			private readonly OrderedDictionary<TKey, TValue> _dictionary;

			// Token: 0x02000019 RID: 25
			public struct Enumerator : IEnumerator<TKey>, IEnumerator, IDisposable
			{
				// Token: 0x0600013E RID: 318 RVA: 0x000061B8 File Offset: 0x000043B8
				internal Enumerator(OrderedDictionary<TKey, TValue> dictionary)
				{
					this._enumerator = dictionary.GetEnumerator();
				}

				// Token: 0x1700006C RID: 108
				// (get) Token: 0x0600013F RID: 319 RVA: 0x000061C8 File Offset: 0x000043C8
				[Nullable(1)]
				public TKey Current
				{
					[NullableContext(1)]
					get
					{
						KeyValuePair<TKey, TValue> keyValuePair = this._enumerator.Current;
						return keyValuePair.Key;
					}
				}

				// Token: 0x1700006D RID: 109
				// (get) Token: 0x06000140 RID: 320 RVA: 0x000061E8 File Offset: 0x000043E8
				[Nullable(1)]
				object IEnumerator.Current
				{
					get
					{
						return this.Current;
					}
				}

				// Token: 0x06000141 RID: 321 RVA: 0x000061F5 File Offset: 0x000043F5
				public bool MoveNext()
				{
					return this._enumerator.MoveNext();
				}

				// Token: 0x06000142 RID: 322 RVA: 0x00006202 File Offset: 0x00004402
				void IEnumerator.Reset()
				{
					EnumerableHelpers.Reset<OrderedDictionary<TKey, TValue>.Enumerator>(ref this._enumerator);
				}

				// Token: 0x06000143 RID: 323 RVA: 0x000049AB File Offset: 0x00002BAB
				readonly void IDisposable.Dispose()
				{
				}

				// Token: 0x04000033 RID: 51
				private OrderedDictionary<TKey, TValue>.Enumerator _enumerator;
			}
		}

		// Token: 0x0200001A RID: 26
		[NullableContext(0)]
		[DebuggerTypeProxy(typeof(ICollectionDebugView<>))]
		[DebuggerDisplay("Count = {Count}")]
		public sealed class ValueCollection : IList<TValue>, ICollection<TValue>, IEnumerable<TValue>, IEnumerable, IReadOnlyList<TValue>, IReadOnlyCollection<TValue>, IList, ICollection
		{
			// Token: 0x06000144 RID: 324 RVA: 0x0000620F File Offset: 0x0000440F
			internal ValueCollection(OrderedDictionary<TKey, TValue> dictionary)
			{
				this._dictionary = dictionary;
			}

			// Token: 0x1700006E RID: 110
			// (get) Token: 0x06000145 RID: 325 RVA: 0x0000621E File Offset: 0x0000441E
			public int Count
			{
				get
				{
					return this._dictionary.Count;
				}
			}

			// Token: 0x1700006F RID: 111
			// (get) Token: 0x06000146 RID: 326 RVA: 0x00003ED3 File Offset: 0x000020D3
			bool ICollection<!1>.IsReadOnly
			{
				get
				{
					return true;
				}
			}

			// Token: 0x17000070 RID: 112
			// (get) Token: 0x06000147 RID: 327 RVA: 0x00003ED3 File Offset: 0x000020D3
			bool IList.IsReadOnly
			{
				get
				{
					return true;
				}
			}

			// Token: 0x17000071 RID: 113
			// (get) Token: 0x06000148 RID: 328 RVA: 0x00003925 File Offset: 0x00001B25
			bool IList.IsFixedSize
			{
				get
				{
					return false;
				}
			}

			// Token: 0x17000072 RID: 114
			// (get) Token: 0x06000149 RID: 329 RVA: 0x00003925 File Offset: 0x00001B25
			bool ICollection.IsSynchronized
			{
				get
				{
					return false;
				}
			}

			// Token: 0x17000073 RID: 115
			// (get) Token: 0x0600014A RID: 330 RVA: 0x0000622B File Offset: 0x0000442B
			[Nullable(1)]
			object ICollection.SyncRoot
			{
				get
				{
					return ((ICollection)this._dictionary).SyncRoot;
				}
			}

			// Token: 0x0600014B RID: 331 RVA: 0x00006238 File Offset: 0x00004438
			[NullableContext(1)]
			public void CopyTo(TValue[] array, int arrayIndex)
			{
				ArgumentNullException.ThrowIfNull(array, "array");
				ArgumentOutOfRangeException.ThrowIfNegative<int>(arrayIndex, "arrayIndex");
				OrderedDictionary<TKey, TValue> dictionary = this._dictionary;
				int count = dictionary._count;
				if (array.Length - arrayIndex < count)
				{
					throw new ArgumentException(SR.Arg_ArrayPlusOffTooSmall, "array");
				}
				OrderedDictionary<TKey, TValue>.Entry[] entries = dictionary._entries;
				for (int i = 0; i < count; i++)
				{
					array[arrayIndex++] = entries[i].Value;
				}
			}

			// Token: 0x0600014C RID: 332 RVA: 0x000062AA File Offset: 0x000044AA
			public OrderedDictionary<TKey, TValue>.ValueCollection.Enumerator GetEnumerator()
			{
				return new OrderedDictionary<TKey, TValue>.ValueCollection.Enumerator(this._dictionary);
			}

			// Token: 0x17000074 RID: 116
			[Nullable(1)]
			TValue IList<!1>.this[int index]
			{
				get
				{
					return this._dictionary.GetAt(index).Value;
				}
				set
				{
					throw new NotSupportedException();
				}
			}

			// Token: 0x17000075 RID: 117
			[Nullable(1)]
			TValue IReadOnlyList<!1>.this[int index]
			{
				get
				{
					return this._dictionary.GetAt(index).Value;
				}
			}

			// Token: 0x17000076 RID: 118
			[Nullable(2)]
			object IList.this[int index]
			{
				get
				{
					return this._dictionary.GetAt(index).Value;
				}
				set
				{
					throw new NotSupportedException();
				}
			}

			// Token: 0x06000152 RID: 338 RVA: 0x00006326 File Offset: 0x00004526
			bool ICollection<!1>.Contains(TValue item)
			{
				return this._dictionary.ContainsValue(item);
			}

			// Token: 0x06000153 RID: 339 RVA: 0x00006334 File Offset: 0x00004534
			IEnumerator<TValue> IEnumerable<!1>.GetEnumerator()
			{
				if (this.Count != 0)
				{
					return this.GetEnumerator();
				}
				return EnumerableHelpers.GetEmptyEnumerator<TValue>();
			}

			// Token: 0x06000154 RID: 340 RVA: 0x0000635C File Offset: 0x0000455C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return ((IEnumerable<!1>)this).GetEnumerator();
			}

			// Token: 0x06000155 RID: 341 RVA: 0x00006364 File Offset: 0x00004564
			int IList<!1>.IndexOf(TValue item)
			{
				OrderedDictionary<TKey, TValue>.Entry[] entries = this._dictionary._entries;
				if (entries != null)
				{
					int count = this._dictionary._count;
					for (int i = 0; i < count; i++)
					{
						if (EqualityComparer<TValue>.Default.Equals(item, entries[i].Value))
						{
							return i;
						}
					}
				}
				return -1;
			}

			// Token: 0x06000156 RID: 342 RVA: 0x00003EFC File Offset: 0x000020FC
			void ICollection<!1>.Add(TValue item)
			{
				throw new NotSupportedException();
			}

			// Token: 0x06000157 RID: 343 RVA: 0x00003EFC File Offset: 0x000020FC
			void ICollection<!1>.Clear()
			{
				throw new NotSupportedException();
			}

			// Token: 0x06000158 RID: 344 RVA: 0x00003EFC File Offset: 0x000020FC
			void IList<!1>.Insert(int index, TValue item)
			{
				throw new NotSupportedException();
			}

			// Token: 0x06000159 RID: 345 RVA: 0x00003EFC File Offset: 0x000020FC
			bool ICollection<!1>.Remove(TValue item)
			{
				throw new NotSupportedException();
			}

			// Token: 0x0600015A RID: 346 RVA: 0x00003EFC File Offset: 0x000020FC
			void IList<!1>.RemoveAt(int index)
			{
				throw new NotSupportedException();
			}

			// Token: 0x0600015B RID: 347 RVA: 0x00003EFC File Offset: 0x000020FC
			int IList.Add(object value)
			{
				throw new NotSupportedException();
			}

			// Token: 0x0600015C RID: 348 RVA: 0x00003EFC File Offset: 0x000020FC
			void IList.Clear()
			{
				throw new NotSupportedException();
			}

			// Token: 0x0600015D RID: 349 RVA: 0x000063B4 File Offset: 0x000045B4
			bool IList.Contains(object value)
			{
				if (value == null && default(TValue) == null)
				{
					return this._dictionary.ContainsValue(default(TValue));
				}
				if (value is TValue)
				{
					TValue value2 = (TValue)((object)value);
					return this._dictionary.ContainsValue(value2);
				}
				return false;
			}

			// Token: 0x0600015E RID: 350 RVA: 0x00006408 File Offset: 0x00004608
			int IList.IndexOf(object value)
			{
				OrderedDictionary<TKey, TValue>.Entry[] entries = this._dictionary._entries;
				if (entries != null)
				{
					int count = this._dictionary._count;
					if (value == null && default(TValue) == null)
					{
						for (int i = 0; i < count; i++)
						{
							if (entries[i].Value == null)
							{
								return i;
							}
						}
					}
					else if (value is TValue)
					{
						TValue x = (TValue)((object)value);
						for (int j = 0; j < count; j++)
						{
							if (EqualityComparer<TValue>.Default.Equals(x, entries[j].Value))
							{
								return j;
							}
						}
					}
				}
				return -1;
			}

			// Token: 0x0600015F RID: 351 RVA: 0x00003EFC File Offset: 0x000020FC
			void IList.Insert(int index, object value)
			{
				throw new NotSupportedException();
			}

			// Token: 0x06000160 RID: 352 RVA: 0x00003EFC File Offset: 0x000020FC
			void IList.Remove(object value)
			{
				throw new NotSupportedException();
			}

			// Token: 0x06000161 RID: 353 RVA: 0x00003EFC File Offset: 0x000020FC
			void IList.RemoveAt(int index)
			{
				throw new NotSupportedException();
			}

			// Token: 0x06000162 RID: 354 RVA: 0x000064A8 File Offset: 0x000046A8
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
					object[] array3 = array as object[];
					if (array3 == null)
					{
						throw new ArgumentException(SR.Argument_IncompatibleArrayType, "array");
					}
					foreach (TValue tvalue in this)
					{
						array3[index++] = tvalue;
					}
				}
				catch (ArrayTypeMismatchException)
				{
					throw new ArgumentException(SR.Argument_IncompatibleArrayType, "array");
				}
			}

			// Token: 0x04000034 RID: 52
			private readonly OrderedDictionary<TKey, TValue> _dictionary;

			// Token: 0x0200001B RID: 27
			public struct Enumerator : IEnumerator<TValue>, IEnumerator, IDisposable
			{
				// Token: 0x06000163 RID: 355 RVA: 0x000065B4 File Offset: 0x000047B4
				internal Enumerator(OrderedDictionary<TKey, TValue> dictionary)
				{
					this._enumerator = dictionary.GetEnumerator();
				}

				// Token: 0x17000077 RID: 119
				// (get) Token: 0x06000164 RID: 356 RVA: 0x000065C4 File Offset: 0x000047C4
				[Nullable(1)]
				public TValue Current
				{
					[NullableContext(1)]
					get
					{
						KeyValuePair<TKey, TValue> keyValuePair = this._enumerator.Current;
						return keyValuePair.Value;
					}
				}

				// Token: 0x17000078 RID: 120
				// (get) Token: 0x06000165 RID: 357 RVA: 0x000065E4 File Offset: 0x000047E4
				[Nullable(2)]
				object IEnumerator.Current
				{
					get
					{
						return this.Current;
					}
				}

				// Token: 0x06000166 RID: 358 RVA: 0x000065F1 File Offset: 0x000047F1
				public bool MoveNext()
				{
					return this._enumerator.MoveNext();
				}

				// Token: 0x06000167 RID: 359 RVA: 0x000065FE File Offset: 0x000047FE
				void IEnumerator.Reset()
				{
					EnumerableHelpers.Reset<OrderedDictionary<TKey, TValue>.Enumerator>(ref this._enumerator);
				}

				// Token: 0x06000168 RID: 360 RVA: 0x000049AB File Offset: 0x00002BAB
				readonly void IDisposable.Dispose()
				{
				}

				// Token: 0x04000035 RID: 53
				private OrderedDictionary<TKey, TValue>.Enumerator _enumerator;
			}
		}
	}
}
