using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Collections.Generic
{
	// Token: 0x020009AD RID: 2477
	[NullableContext(1)]
	[Nullable(0)]
	[DebuggerTypeProxy(typeof(IDictionaryDebugView<, >))]
	[DebuggerDisplay("Count = {Count}")]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class Dictionary<TKey, [Nullable(2)] TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IDictionary, ICollection, IReadOnlyDictionary<TKey, TValue>, IReadOnlyCollection<KeyValuePair<TKey, TValue>>, ISerializable, IDeserializationCallback
	{
		// Token: 0x06009219 RID: 37401 RVA: 0x0016B0B0 File Offset: 0x001692B0
		public Dictionary() : this(0, null)
		{
		}

		// Token: 0x0600921A RID: 37402 RVA: 0x0016B0BA File Offset: 0x001692BA
		public Dictionary(int capacity) : this(capacity, null)
		{
		}

		// Token: 0x0600921B RID: 37403 RVA: 0x0016B0C4 File Offset: 0x001692C4
		public Dictionary([Nullable(new byte[]
		{
			2,
			1
		})] IEqualityComparer<TKey> comparer) : this(0, comparer)
		{
		}

		// Token: 0x0600921C RID: 37404 RVA: 0x0016B0D0 File Offset: 0x001692D0
		public Dictionary(int capacity, [Nullable(new byte[]
		{
			2,
			1
		})] IEqualityComparer<TKey> comparer)
		{
			if (capacity < 0)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.capacity);
			}
			if (capacity > 0)
			{
				this.Initialize(capacity);
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

		// Token: 0x0600921D RID: 37405 RVA: 0x0016B164 File Offset: 0x00169364
		public Dictionary(IDictionary<TKey, TValue> dictionary) : this(dictionary, null)
		{
		}

		// Token: 0x0600921E RID: 37406 RVA: 0x0016B16E File Offset: 0x0016936E
		public Dictionary(IDictionary<TKey, TValue> dictionary, [Nullable(new byte[]
		{
			2,
			1
		})] IEqualityComparer<TKey> comparer) : this((dictionary != null) ? dictionary.Count : 0, comparer)
		{
			if (dictionary == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.dictionary);
			}
			this.AddRange(dictionary);
		}

		// Token: 0x0600921F RID: 37407 RVA: 0x0016B193 File Offset: 0x00169393
		public Dictionary([Nullable(new byte[]
		{
			1,
			0,
			1,
			1
		})] IEnumerable<KeyValuePair<TKey, TValue>> collection) : this(collection, null)
		{
		}

		// Token: 0x06009220 RID: 37408 RVA: 0x0016B19D File Offset: 0x0016939D
		public Dictionary([Nullable(new byte[]
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
			if (collection == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.collection);
			}
			this.AddRange(collection);
		}

		// Token: 0x06009221 RID: 37409 RVA: 0x0016B1CC File Offset: 0x001693CC
		private unsafe void AddRange(IEnumerable<KeyValuePair<TKey, TValue>> enumerable)
		{
			if (!(enumerable.GetType() == typeof(Dictionary<TKey, TValue>)))
			{
				KeyValuePair<TKey, TValue>[] array = enumerable as KeyValuePair<TKey, TValue>[];
				ReadOnlySpan<KeyValuePair<TKey, TValue>> readOnlySpan;
				if (array != null)
				{
					readOnlySpan = array;
				}
				else
				{
					if (!(enumerable.GetType() == typeof(List<KeyValuePair<TKey, TValue>>)))
					{
						foreach (KeyValuePair<TKey, TValue> keyValuePair in enumerable)
						{
							this.Add(keyValuePair.Key, keyValuePair.Value);
						}
						return;
					}
					readOnlySpan = CollectionsMarshal.AsSpan<KeyValuePair<TKey, TValue>>((List<KeyValuePair<TKey, TValue>>)enumerable);
				}
				ReadOnlySpan<KeyValuePair<TKey, TValue>> readOnlySpan2 = readOnlySpan;
				for (int i = 0; i < readOnlySpan2.Length; i++)
				{
					KeyValuePair<TKey, TValue> keyValuePair2 = *readOnlySpan2[i];
					this.Add(keyValuePair2.Key, keyValuePair2.Value);
				}
				return;
			}
			Dictionary<TKey, TValue> dictionary = (Dictionary<TKey, TValue>)enumerable;
			if (dictionary.Count == 0)
			{
				return;
			}
			Dictionary<TKey, TValue>.Entry[] entries = dictionary._entries;
			if (dictionary._comparer == this._comparer)
			{
				this.CopyEntries(entries, dictionary._count);
				return;
			}
			int count = dictionary._count;
			for (int j = 0; j < count; j++)
			{
				if (entries[j].next >= -1)
				{
					this.Add(entries[j].key, entries[j].value);
				}
			}
		}

		// Token: 0x06009222 RID: 37410 RVA: 0x001643AF File Offset: 0x001625AF
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected Dictionary(SerializationInfo info, StreamingContext context)
		{
			HashHelpers.SerializationInfoTable.Add(this, info);
		}

		// Token: 0x170013D7 RID: 5079
		// (get) Token: 0x06009223 RID: 37411 RVA: 0x0016B338 File Offset: 0x00169538
		public IEqualityComparer<TKey> Comparer
		{
			get
			{
				if (typeof(TKey) == typeof(string))
				{
					return (IEqualityComparer<TKey>)IInternalStringEqualityComparer.GetUnderlyingEqualityComparer((IEqualityComparer<string>)this._comparer);
				}
				return this._comparer ?? EqualityComparer<TKey>.Default;
			}
		}

		// Token: 0x170013D8 RID: 5080
		// (get) Token: 0x06009224 RID: 37412 RVA: 0x0016B385 File Offset: 0x00169585
		public int Count
		{
			get
			{
				return this._count - this._freeCount;
			}
		}

		// Token: 0x170013D9 RID: 5081
		// (get) Token: 0x06009225 RID: 37413 RVA: 0x0016B394 File Offset: 0x00169594
		public int Capacity
		{
			get
			{
				Dictionary<TKey, TValue>.Entry[] entries = this._entries;
				if (entries == null)
				{
					return 0;
				}
				return entries.Length;
			}
		}

		// Token: 0x170013DA RID: 5082
		// (get) Token: 0x06009226 RID: 37414 RVA: 0x0016B3A4 File Offset: 0x001695A4
		[Nullable(new byte[]
		{
			1,
			0,
			0
		})]
		public Dictionary<TKey, TValue>.KeyCollection Keys
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				0
			})]
			get
			{
				Dictionary<TKey, TValue>.KeyCollection result;
				if ((result = this._keys) == null)
				{
					result = (this._keys = new Dictionary<TKey, TValue>.KeyCollection(this));
				}
				return result;
			}
		}

		// Token: 0x170013DB RID: 5083
		// (get) Token: 0x06009227 RID: 37415 RVA: 0x0016B3CA File Offset: 0x001695CA
		ICollection<TKey> IDictionary<!0, !1>.Keys
		{
			get
			{
				return this.Keys;
			}
		}

		// Token: 0x170013DC RID: 5084
		// (get) Token: 0x06009228 RID: 37416 RVA: 0x0016B3CA File Offset: 0x001695CA
		IEnumerable<TKey> IReadOnlyDictionary<!0, !1>.Keys
		{
			get
			{
				return this.Keys;
			}
		}

		// Token: 0x170013DD RID: 5085
		// (get) Token: 0x06009229 RID: 37417 RVA: 0x0016B3D4 File Offset: 0x001695D4
		[Nullable(new byte[]
		{
			1,
			0,
			0
		})]
		public Dictionary<TKey, TValue>.ValueCollection Values
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				0
			})]
			get
			{
				Dictionary<TKey, TValue>.ValueCollection result;
				if ((result = this._values) == null)
				{
					result = (this._values = new Dictionary<TKey, TValue>.ValueCollection(this));
				}
				return result;
			}
		}

		// Token: 0x170013DE RID: 5086
		// (get) Token: 0x0600922A RID: 37418 RVA: 0x0016B3FA File Offset: 0x001695FA
		ICollection<TValue> IDictionary<!0, !1>.Values
		{
			get
			{
				return this.Values;
			}
		}

		// Token: 0x170013DF RID: 5087
		// (get) Token: 0x0600922B RID: 37419 RVA: 0x0016B3FA File Offset: 0x001695FA
		IEnumerable<TValue> IReadOnlyDictionary<!0, !1>.Values
		{
			get
			{
				return this.Values;
			}
		}

		// Token: 0x170013E0 RID: 5088
		public TValue this[TKey key]
		{
			get
			{
				ref TValue ptr = ref this.FindValue(key);
				if (!Unsafe.IsNullRef<TValue>(ref ptr))
				{
					return ptr;
				}
				ThrowHelper.ThrowKeyNotFoundException<TKey>(key);
				return default(TValue);
			}
			set
			{
				this.TryInsert(key, value, InsertionBehavior.OverwriteExisting);
			}
		}

		// Token: 0x0600922E RID: 37422 RVA: 0x0016B443 File Offset: 0x00169643
		public void Add(TKey key, TValue value)
		{
			this.TryInsert(key, value, InsertionBehavior.ThrowOnExisting);
		}

		// Token: 0x0600922F RID: 37423 RVA: 0x0016B44F File Offset: 0x0016964F
		void ICollection<KeyValuePair<!0, !1>>.Add(KeyValuePair<TKey, TValue> keyValuePair)
		{
			this.Add(keyValuePair.Key, keyValuePair.Value);
		}

		// Token: 0x06009230 RID: 37424 RVA: 0x0016B468 File Offset: 0x00169668
		bool ICollection<KeyValuePair<!0, !1>>.Contains(KeyValuePair<TKey, TValue> keyValuePair)
		{
			ref TValue ptr = ref this.FindValue(keyValuePair.Key);
			return !Unsafe.IsNullRef<TValue>(ref ptr) && EqualityComparer<TValue>.Default.Equals(ptr, keyValuePair.Value);
		}

		// Token: 0x06009231 RID: 37425 RVA: 0x0016B4A8 File Offset: 0x001696A8
		bool ICollection<KeyValuePair<!0, !1>>.Remove(KeyValuePair<TKey, TValue> keyValuePair)
		{
			ref TValue ptr = ref this.FindValue(keyValuePair.Key);
			if (!Unsafe.IsNullRef<TValue>(ref ptr) && EqualityComparer<TValue>.Default.Equals(ptr, keyValuePair.Value))
			{
				this.Remove(keyValuePair.Key);
				return true;
			}
			return false;
		}

		// Token: 0x06009232 RID: 37426 RVA: 0x0016B4F8 File Offset: 0x001696F8
		public void Clear()
		{
			int count = this._count;
			if (count > 0)
			{
				Array.Clear(this._buckets);
				this._count = 0;
				this._freeList = -1;
				this._freeCount = 0;
				Array.Clear(this._entries, 0, count);
			}
		}

		// Token: 0x06009233 RID: 37427 RVA: 0x0016B53D File Offset: 0x0016973D
		public bool ContainsKey(TKey key)
		{
			return !Unsafe.IsNullRef<TValue>(this.FindValue(key));
		}

		// Token: 0x06009234 RID: 37428 RVA: 0x0016B550 File Offset: 0x00169750
		public bool ContainsValue(TValue value)
		{
			Dictionary<TKey, TValue>.Entry[] entries = this._entries;
			if (value == null)
			{
				for (int i = 0; i < this._count; i++)
				{
					if (entries[i].next >= -1 && entries[i].value == null)
					{
						return true;
					}
				}
			}
			else if (typeof(TValue).IsValueType)
			{
				for (int j = 0; j < this._count; j++)
				{
					if (entries[j].next >= -1 && EqualityComparer<TValue>.Default.Equals(entries[j].value, value))
					{
						return true;
					}
				}
			}
			else
			{
				EqualityComparer<TValue> @default = EqualityComparer<TValue>.Default;
				for (int k = 0; k < this._count; k++)
				{
					if (entries[k].next >= -1 && @default.Equals(entries[k].value, value))
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06009235 RID: 37429 RVA: 0x0016B638 File Offset: 0x00169838
		private void CopyTo(KeyValuePair<TKey, TValue>[] array, int index)
		{
			if (array == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
			}
			if (index > array.Length)
			{
				ThrowHelper.ThrowIndexArgumentOutOfRange_NeedNonNegNumException();
			}
			if (array.Length - index < this.Count)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_ArrayPlusOffTooSmall);
			}
			int count = this._count;
			Dictionary<TKey, TValue>.Entry[] entries = this._entries;
			for (int i = 0; i < count; i++)
			{
				if (entries[i].next >= -1)
				{
					array[index++] = new KeyValuePair<TKey, TValue>(entries[i].key, entries[i].value);
				}
			}
		}

		// Token: 0x06009236 RID: 37430 RVA: 0x0016B6BE File Offset: 0x001698BE
		[NullableContext(0)]
		public Dictionary<TKey, TValue>.Enumerator GetEnumerator()
		{
			return new Dictionary<TKey, TValue>.Enumerator(this, 2);
		}

		// Token: 0x06009237 RID: 37431 RVA: 0x0016B6C8 File Offset: 0x001698C8
		IEnumerator<KeyValuePair<TKey, TValue>> IEnumerable<KeyValuePair<!0, !1>>.GetEnumerator()
		{
			if (this.Count != 0)
			{
				return this.GetEnumerator();
			}
			return GenericEmptyEnumerator<KeyValuePair<TKey, TValue>>.Instance;
		}

		// Token: 0x06009238 RID: 37432 RVA: 0x0016B6F4 File Offset: 0x001698F4
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.info);
			}
			info.AddValue("Version", this._version);
			info.AddValue("Comparer", this.Comparer, typeof(IEqualityComparer<TKey>));
			info.AddValue("HashSize", (this._buckets == null) ? 0 : this._buckets.Length);
			if (this._buckets != null)
			{
				KeyValuePair<TKey, TValue>[] array = new KeyValuePair<TKey, TValue>[this.Count];
				this.CopyTo(array, 0);
				info.AddValue("KeyValuePairs", array, typeof(KeyValuePair<TKey, TValue>[]));
			}
		}

		// Token: 0x06009239 RID: 37433 RVA: 0x0016B788 File Offset: 0x00169988
		internal unsafe ref TValue FindValue(TKey key)
		{
			if (key == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.key);
			}
			ref Dictionary<TKey, TValue>.Entry ptr = ref Unsafe.NullRef<Dictionary<TKey, TValue>.Entry>();
			if (this._buckets == null)
			{
				goto IL_123;
			}
			IEqualityComparer<TKey> comparer = this._comparer;
			if (typeof(TKey).IsValueType && comparer == null)
			{
				uint hashCode = (uint)key.GetHashCode();
				int i = *this.GetBucket(hashCode);
				Dictionary<TKey, TValue>.Entry[] entries = this._entries;
				uint num = 0U;
				i--;
				while (i < entries.Length)
				{
					ptr = ref entries[i];
					if (ptr.hashCode == hashCode && EqualityComparer<TKey>.Default.Equals(ptr.key, key))
					{
						goto IL_11A;
					}
					i = ptr.next;
					num += 1U;
					if (num > (uint)entries.Length)
					{
						goto IL_115;
					}
				}
				goto IL_123;
			}
			uint hashCode2 = (uint)comparer.GetHashCode(key);
			int j = *this.GetBucket(hashCode2);
			Dictionary<TKey, TValue>.Entry[] entries2 = this._entries;
			uint num2 = 0U;
			j--;
			while (j < entries2.Length)
			{
				ptr = ref entries2[j];
				if (ptr.hashCode == hashCode2 && comparer.Equals(ptr.key, key))
				{
					goto IL_11A;
				}
				j = ptr.next;
				num2 += 1U;
				if (num2 > (uint)entries2.Length)
				{
					goto IL_115;
				}
			}
			goto IL_123;
			IL_115:
			ThrowHelper.ThrowInvalidOperationException_ConcurrentOperationsNotSupported();
			IL_11A:
			return ref ptr.value;
			IL_123:
			return Unsafe.NullRef<TValue>();
		}

		// Token: 0x0600923A RID: 37434 RVA: 0x0016B8C0 File Offset: 0x00169AC0
		private int Initialize(int capacity)
		{
			int prime = HashHelpers.GetPrime(capacity);
			int[] buckets = new int[prime];
			Dictionary<TKey, TValue>.Entry[] entries = new Dictionary<TKey, TValue>.Entry[prime];
			this._freeList = -1;
			this._fastModMultiplier = HashHelpers.GetFastModMultiplier((uint)prime);
			this._buckets = buckets;
			this._entries = entries;
			return prime;
		}

		// Token: 0x0600923B RID: 37435 RVA: 0x0016B904 File Offset: 0x00169B04
		private bool TryInsert(TKey key, TValue value, InsertionBehavior behavior)
		{
			if (key == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.key);
			}
			if (this._buckets == null)
			{
				this.Initialize(0);
			}
			Dictionary<TKey, TValue>.Entry[] entries = this._entries;
			IEqualityComparer<TKey> comparer = this._comparer;
			uint num = (uint)((typeof(TKey).IsValueType && comparer == null) ? key.GetHashCode() : comparer.GetHashCode(key));
			uint num2 = 0U;
			ref int bucket = ref this.GetBucket(num);
			int i = bucket - 1;
			if (typeof(TKey).IsValueType && comparer == null)
			{
				while (i < entries.Length)
				{
					if (entries[i].hashCode == num && EqualityComparer<TKey>.Default.Equals(entries[i].key, key))
					{
						if (behavior == InsertionBehavior.OverwriteExisting)
						{
							entries[i].value = value;
							return true;
						}
						if (behavior == InsertionBehavior.ThrowOnExisting)
						{
							ThrowHelper.ThrowAddingDuplicateWithKeyArgumentException<TKey>(key);
						}
						return false;
					}
					else
					{
						i = entries[i].next;
						num2 += 1U;
						if (num2 > (uint)entries.Length)
						{
							ThrowHelper.ThrowInvalidOperationException_ConcurrentOperationsNotSupported();
						}
					}
				}
			}
			else
			{
				while (i < entries.Length)
				{
					if (entries[i].hashCode == num && comparer.Equals(entries[i].key, key))
					{
						if (behavior == InsertionBehavior.OverwriteExisting)
						{
							entries[i].value = value;
							return true;
						}
						if (behavior == InsertionBehavior.ThrowOnExisting)
						{
							ThrowHelper.ThrowAddingDuplicateWithKeyArgumentException<TKey>(key);
						}
						return false;
					}
					else
					{
						i = entries[i].next;
						num2 += 1U;
						if (num2 > (uint)entries.Length)
						{
							ThrowHelper.ThrowInvalidOperationException_ConcurrentOperationsNotSupported();
						}
					}
				}
			}
			int num3;
			if (this._freeCount > 0)
			{
				num3 = this._freeList;
				this._freeList = -3 - entries[this._freeList].next;
				this._freeCount--;
			}
			else
			{
				int count = this._count;
				if (count == entries.Length)
				{
					this.Resize();
					bucket = this.GetBucket(num);
				}
				num3 = count;
				this._count = count + 1;
				entries = this._entries;
			}
			Dictionary<TKey, TValue>.Entry[] array = entries;
			int num4 = num3;
			array[num4].hashCode = num;
			array[num4].next = bucket - 1;
			array[num4].key = key;
			array[num4].value = value;
			bucket = num3 + 1;
			this._version++;
			if (!typeof(TKey).IsValueType && num2 > 100U && comparer is NonRandomizedStringEqualityComparer)
			{
				this.Resize(entries.Length, true);
			}
			return true;
		}

		// Token: 0x0600923C RID: 37436 RVA: 0x0016BB45 File Offset: 0x00169D45
		[return: Nullable(new byte[]
		{
			0,
			0,
			0,
			1
		})]
		public Dictionary<TKey, TValue>.AlternateLookup<TAlternateKey> GetAlternateLookup<TAlternateKey>()
		{
			if (!Dictionary<TKey, TValue>.AlternateLookup<TAlternateKey>.IsCompatibleKey(this))
			{
				ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_IncompatibleComparer);
			}
			return new Dictionary<TKey, TValue>.AlternateLookup<TAlternateKey>(this);
		}

		// Token: 0x0600923D RID: 37437 RVA: 0x0016BB5C File Offset: 0x00169D5C
		public bool TryGetAlternateLookup<TAlternateKey>([Nullable(new byte[]
		{
			0,
			0,
			0,
			1
		})] out Dictionary<TKey, TValue>.AlternateLookup<TAlternateKey> lookup)
		{
			if (Dictionary<TKey, TValue>.AlternateLookup<TAlternateKey>.IsCompatibleKey(this))
			{
				lookup = new Dictionary<TKey, TValue>.AlternateLookup<TAlternateKey>(this);
				return true;
			}
			lookup = default(Dictionary<TKey, TValue>.AlternateLookup<TAlternateKey>);
			return false;
		}

		// Token: 0x0600923E RID: 37438 RVA: 0x0016BB7C File Offset: 0x00169D7C
		[NullableContext(2)]
		public virtual void OnDeserialization(object sender)
		{
			SerializationInfo serializationInfo;
			HashHelpers.SerializationInfoTable.TryGetValue(this, out serializationInfo);
			if (serializationInfo == null)
			{
				return;
			}
			int @int = serializationInfo.GetInt32("Version");
			int int2 = serializationInfo.GetInt32("HashSize");
			this._comparer = (IEqualityComparer<TKey>)serializationInfo.GetValue("Comparer", typeof(IEqualityComparer<TKey>));
			if (int2 != 0)
			{
				this.Initialize(int2);
				KeyValuePair<TKey, TValue>[] array = (KeyValuePair<TKey, TValue>[])serializationInfo.GetValue("KeyValuePairs", typeof(KeyValuePair<TKey, TValue>[]));
				if (array == null)
				{
					ThrowHelper.ThrowSerializationException(ExceptionResource.Serialization_MissingKeys);
				}
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i].Key == null)
					{
						ThrowHelper.ThrowSerializationException(ExceptionResource.Serialization_NullKey);
					}
					this.Add(array[i].Key, array[i].Value);
				}
			}
			else
			{
				this._buckets = null;
			}
			this._version = @int;
			HashHelpers.SerializationInfoTable.Remove(this);
		}

		// Token: 0x0600923F RID: 37439 RVA: 0x0016BC6C File Offset: 0x00169E6C
		private void Resize()
		{
			this.Resize(HashHelpers.ExpandPrime(this._count), false);
		}

		// Token: 0x06009240 RID: 37440 RVA: 0x0016BC80 File Offset: 0x00169E80
		private void Resize(int newSize, bool forceNewHashCodes)
		{
			Dictionary<TKey, TValue>.Entry[] array = new Dictionary<TKey, TValue>.Entry[newSize];
			int count = this._count;
			Array.Copy(this._entries, array, count);
			if (!typeof(TKey).IsValueType && forceNewHashCodes)
			{
				IEqualityComparer<TKey> equalityComparer = this._comparer = (IEqualityComparer<TKey>)((NonRandomizedStringEqualityComparer)this._comparer).GetRandomizedEqualityComparer();
				for (int i = 0; i < count; i++)
				{
					if (array[i].next >= -1)
					{
						array[i].hashCode = (uint)equalityComparer.GetHashCode(array[i].key);
					}
				}
			}
			this._buckets = new int[newSize];
			this._fastModMultiplier = HashHelpers.GetFastModMultiplier((uint)newSize);
			for (int j = 0; j < count; j++)
			{
				if (array[j].next >= -1)
				{
					ref int bucket = ref this.GetBucket(array[j].hashCode);
					array[j].next = bucket - 1;
					bucket = j + 1;
				}
			}
			this._entries = array;
		}

		// Token: 0x06009241 RID: 37441 RVA: 0x0016BD8C File Offset: 0x00169F8C
		public bool Remove(TKey key)
		{
			if (key == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.key);
			}
			if (this._buckets != null)
			{
				uint num = 0U;
				IEqualityComparer<TKey> comparer = this._comparer;
				uint num2 = (uint)((typeof(TKey).IsValueType && comparer == null) ? key.GetHashCode() : comparer.GetHashCode(key));
				ref int bucket = ref this.GetBucket(num2);
				Dictionary<TKey, TValue>.Entry[] entries = this._entries;
				int num3 = -1;
				int i = bucket - 1;
				while (i >= 0)
				{
					ref Dictionary<TKey, TValue>.Entry ptr = ref entries[i];
					if (ptr.hashCode == num2 && ((typeof(TKey).IsValueType && comparer == null) ? EqualityComparer<TKey>.Default.Equals(ptr.key, key) : comparer.Equals(ptr.key, key)))
					{
						if (num3 < 0)
						{
							bucket = ptr.next + 1;
						}
						else
						{
							entries[num3].next = ptr.next;
						}
						ptr.next = -3 - this._freeList;
						if (RuntimeHelpers.IsReferenceOrContainsReferences<TKey>())
						{
							ptr.key = default(TKey);
						}
						if (RuntimeHelpers.IsReferenceOrContainsReferences<TValue>())
						{
							ptr.value = default(TValue);
						}
						this._freeList = i;
						this._freeCount++;
						return true;
					}
					num3 = i;
					i = ptr.next;
					num += 1U;
					if (num > (uint)entries.Length)
					{
						ThrowHelper.ThrowInvalidOperationException_ConcurrentOperationsNotSupported();
					}
				}
			}
			return false;
		}

		// Token: 0x06009242 RID: 37442 RVA: 0x0016BEF4 File Offset: 0x0016A0F4
		public bool Remove(TKey key, [MaybeNullWhen(false)] out TValue value)
		{
			if (key == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.key);
			}
			if (this._buckets != null)
			{
				uint num = 0U;
				IEqualityComparer<TKey> comparer = this._comparer;
				uint num2 = (uint)((typeof(TKey).IsValueType && comparer == null) ? key.GetHashCode() : comparer.GetHashCode(key));
				ref int bucket = ref this.GetBucket(num2);
				Dictionary<TKey, TValue>.Entry[] entries = this._entries;
				int num3 = -1;
				int i = bucket - 1;
				while (i >= 0)
				{
					ref Dictionary<TKey, TValue>.Entry ptr = ref entries[i];
					if (ptr.hashCode == num2 && ((typeof(TKey).IsValueType && comparer == null) ? EqualityComparer<TKey>.Default.Equals(ptr.key, key) : comparer.Equals(ptr.key, key)))
					{
						if (num3 < 0)
						{
							bucket = ptr.next + 1;
						}
						else
						{
							entries[num3].next = ptr.next;
						}
						value = ptr.value;
						ptr.next = -3 - this._freeList;
						if (RuntimeHelpers.IsReferenceOrContainsReferences<TKey>())
						{
							ptr.key = default(TKey);
						}
						if (RuntimeHelpers.IsReferenceOrContainsReferences<TValue>())
						{
							ptr.value = default(TValue);
						}
						this._freeList = i;
						this._freeCount++;
						return true;
					}
					num3 = i;
					i = ptr.next;
					num += 1U;
					if (num > (uint)entries.Length)
					{
						ThrowHelper.ThrowInvalidOperationException_ConcurrentOperationsNotSupported();
					}
				}
			}
			value = default(TValue);
			return false;
		}

		// Token: 0x06009243 RID: 37443 RVA: 0x0016C070 File Offset: 0x0016A270
		public bool TryGetValue(TKey key, [MaybeNullWhen(false)] out TValue value)
		{
			ref TValue ptr = ref this.FindValue(key);
			if (!Unsafe.IsNullRef<TValue>(ref ptr))
			{
				value = ptr;
				return true;
			}
			value = default(TValue);
			return false;
		}

		// Token: 0x06009244 RID: 37444 RVA: 0x0016C0A3 File Offset: 0x0016A2A3
		public bool TryAdd(TKey key, TValue value)
		{
			return this.TryInsert(key, value, InsertionBehavior.None);
		}

		// Token: 0x170013E1 RID: 5089
		// (get) Token: 0x06009245 RID: 37445 RVA: 0x00007B65 File Offset: 0x00005D65
		bool ICollection<KeyValuePair<!0, !1>>.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06009246 RID: 37446 RVA: 0x0016C0AE File Offset: 0x0016A2AE
		void ICollection<KeyValuePair<!0, !1>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int index)
		{
			this.CopyTo(array, index);
		}

		// Token: 0x06009247 RID: 37447 RVA: 0x0016C0B8 File Offset: 0x0016A2B8
		void ICollection.CopyTo(Array array, int index)
		{
			if (array == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
			}
			if (array.Rank != 1)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_RankMultiDimNotSupported);
			}
			if (array.GetLowerBound(0) != 0)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_NonZeroLowerBound);
			}
			if (index > array.Length)
			{
				ThrowHelper.ThrowIndexArgumentOutOfRange_NeedNonNegNumException();
			}
			if (array.Length - index < this.Count)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_ArrayPlusOffTooSmall);
			}
			KeyValuePair<TKey, TValue>[] array2 = array as KeyValuePair<TKey, TValue>[];
			if (array2 != null)
			{
				this.CopyTo(array2, index);
				return;
			}
			DictionaryEntry[] array3 = array as DictionaryEntry[];
			if (array3 != null)
			{
				Dictionary<TKey, TValue>.Entry[] entries = this._entries;
				for (int i = 0; i < this._count; i++)
				{
					if (entries[i].next >= -1)
					{
						array3[index++] = new DictionaryEntry(entries[i].key, entries[i].value);
					}
				}
				return;
			}
			object[] array4 = array as object[];
			if (array4 == null)
			{
				ThrowHelper.ThrowArgumentException_Argument_IncompatibleArrayType();
			}
			try
			{
				int count = this._count;
				Dictionary<TKey, TValue>.Entry[] entries2 = this._entries;
				for (int j = 0; j < count; j++)
				{
					if (entries2[j].next >= -1)
					{
						array4[index++] = new KeyValuePair<TKey, TValue>(entries2[j].key, entries2[j].value);
					}
				}
			}
			catch (ArrayTypeMismatchException)
			{
				ThrowHelper.ThrowArgumentException_Argument_IncompatibleArrayType();
			}
		}

		// Token: 0x06009248 RID: 37448 RVA: 0x00113840 File Offset: 0x00111A40
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<KeyValuePair<!0, !1>>)this).GetEnumerator();
		}

		// Token: 0x06009249 RID: 37449 RVA: 0x0016C218 File Offset: 0x0016A418
		public int EnsureCapacity(int capacity)
		{
			if (capacity < 0)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.capacity);
			}
			int num = (this._entries == null) ? 0 : this._entries.Length;
			if (num >= capacity)
			{
				return num;
			}
			this._version++;
			if (this._buckets == null)
			{
				return this.Initialize(capacity);
			}
			int prime = HashHelpers.GetPrime(capacity);
			this.Resize(prime, false);
			return prime;
		}

		// Token: 0x0600924A RID: 37450 RVA: 0x0016C278 File Offset: 0x0016A478
		public void TrimExcess()
		{
			this.TrimExcess(this.Count);
		}

		// Token: 0x0600924B RID: 37451 RVA: 0x0016C288 File Offset: 0x0016A488
		public void TrimExcess(int capacity)
		{
			if (capacity < this.Count)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.capacity);
			}
			int prime = HashHelpers.GetPrime(capacity);
			Dictionary<TKey, TValue>.Entry[] entries = this._entries;
			int num = (entries == null) ? 0 : entries.Length;
			if (prime >= num)
			{
				return;
			}
			int count = this._count;
			this._version++;
			this.Initialize(prime);
			this.CopyEntries(entries, count);
		}

		// Token: 0x0600924C RID: 37452 RVA: 0x0016C2E8 File Offset: 0x0016A4E8
		private void CopyEntries(Dictionary<TKey, TValue>.Entry[] entries, int count)
		{
			Dictionary<TKey, TValue>.Entry[] entries2 = this._entries;
			int num = 0;
			for (int i = 0; i < count; i++)
			{
				uint hashCode = entries[i].hashCode;
				if (entries[i].next >= -1)
				{
					Dictionary<TKey, TValue>.Entry[] array = entries2;
					int num2 = num;
					array[num2] = entries[i];
					ref int bucket = ref this.GetBucket(hashCode);
					array[num2].next = bucket - 1;
					bucket = num + 1;
					num++;
				}
			}
			this._count = num;
			this._freeCount = 0;
		}

		// Token: 0x170013E2 RID: 5090
		// (get) Token: 0x0600924D RID: 37453 RVA: 0x00007B65 File Offset: 0x00005D65
		bool ICollection.IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170013E3 RID: 5091
		// (get) Token: 0x0600924E RID: 37454 RVA: 0x00007B62 File Offset: 0x00005D62
		object ICollection.SyncRoot
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170013E4 RID: 5092
		// (get) Token: 0x0600924F RID: 37455 RVA: 0x00007B65 File Offset: 0x00005D65
		bool IDictionary.IsFixedSize
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170013E5 RID: 5093
		// (get) Token: 0x06009250 RID: 37456 RVA: 0x00007B65 File Offset: 0x00005D65
		bool IDictionary.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170013E6 RID: 5094
		// (get) Token: 0x06009251 RID: 37457 RVA: 0x0016B3CA File Offset: 0x001695CA
		ICollection IDictionary.Keys
		{
			get
			{
				return this.Keys;
			}
		}

		// Token: 0x170013E7 RID: 5095
		// (get) Token: 0x06009252 RID: 37458 RVA: 0x0016B3FA File Offset: 0x001695FA
		ICollection IDictionary.Values
		{
			get
			{
				return this.Values;
			}
		}

		// Token: 0x170013E8 RID: 5096
		[Nullable(2)]
		object IDictionary.this[object key]
		{
			get
			{
				if (Dictionary<TKey, TValue>.IsCompatibleKey(key))
				{
					ref TValue ptr = ref this.FindValue((TKey)((object)key));
					if (!Unsafe.IsNullRef<TValue>(ref ptr))
					{
						return ptr;
					}
				}
				return null;
			}
			set
			{
				if (key == null)
				{
					ThrowHelper.ThrowArgumentNullException(ExceptionArgument.key);
				}
				ThrowHelper.IfNullAndNullsAreIllegalThenThrow<TValue>(value, ExceptionArgument.value);
				try
				{
					TKey key2 = (TKey)((object)key);
					try
					{
						this[key2] = (TValue)((object)value);
					}
					catch (InvalidCastException)
					{
						ThrowHelper.ThrowWrongValueTypeArgumentException<object>(value, typeof(TValue));
					}
				}
				catch (InvalidCastException)
				{
					ThrowHelper.ThrowWrongKeyTypeArgumentException<object>(key, typeof(TKey));
				}
			}
		}

		// Token: 0x06009255 RID: 37461 RVA: 0x0016C418 File Offset: 0x0016A618
		private static bool IsCompatibleKey(object key)
		{
			if (key == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.key);
			}
			return key is TKey;
		}

		// Token: 0x06009256 RID: 37462 RVA: 0x0016C42C File Offset: 0x0016A62C
		void IDictionary.Add(object key, object value)
		{
			if (key == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.key);
			}
			ThrowHelper.IfNullAndNullsAreIllegalThenThrow<TValue>(value, ExceptionArgument.value);
			try
			{
				TKey key2 = (TKey)((object)key);
				try
				{
					this.Add(key2, (TValue)((object)value));
				}
				catch (InvalidCastException)
				{
					ThrowHelper.ThrowWrongValueTypeArgumentException<object>(value, typeof(TValue));
				}
			}
			catch (InvalidCastException)
			{
				ThrowHelper.ThrowWrongKeyTypeArgumentException<object>(key, typeof(TKey));
			}
		}

		// Token: 0x06009257 RID: 37463 RVA: 0x0016C4A4 File Offset: 0x0016A6A4
		bool IDictionary.Contains(object key)
		{
			return Dictionary<TKey, TValue>.IsCompatibleKey(key) && this.ContainsKey((TKey)((object)key));
		}

		// Token: 0x06009258 RID: 37464 RVA: 0x0016C4BC File Offset: 0x0016A6BC
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return new Dictionary<TKey, TValue>.Enumerator(this, 1);
		}

		// Token: 0x06009259 RID: 37465 RVA: 0x0016C4CA File Offset: 0x0016A6CA
		void IDictionary.Remove(object key)
		{
			if (Dictionary<TKey, TValue>.IsCompatibleKey(key))
			{
				this.Remove((TKey)((object)key));
			}
		}

		// Token: 0x0600925A RID: 37466 RVA: 0x0016C4E4 File Offset: 0x0016A6E4
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private ref int GetBucket(uint hashCode)
		{
			int[] buckets = this._buckets;
			return ref buckets[(int)HashHelpers.FastMod(hashCode, (uint)buckets.Length, this._fastModMultiplier)];
		}

		// Token: 0x04002260 RID: 8800
		private int[] _buckets;

		// Token: 0x04002261 RID: 8801
		private Dictionary<TKey, TValue>.Entry[] _entries;

		// Token: 0x04002262 RID: 8802
		private ulong _fastModMultiplier;

		// Token: 0x04002263 RID: 8803
		private int _count;

		// Token: 0x04002264 RID: 8804
		private int _freeList;

		// Token: 0x04002265 RID: 8805
		private int _freeCount;

		// Token: 0x04002266 RID: 8806
		private int _version;

		// Token: 0x04002267 RID: 8807
		private IEqualityComparer<TKey> _comparer;

		// Token: 0x04002268 RID: 8808
		private Dictionary<TKey, TValue>.KeyCollection _keys;

		// Token: 0x04002269 RID: 8809
		private Dictionary<TKey, TValue>.ValueCollection _values;

		// Token: 0x020009AE RID: 2478
		[Nullable(0)]
		public readonly struct AlternateLookup<TAlternateKey>
		{
			// Token: 0x0600925B RID: 37467 RVA: 0x0016C50D File Offset: 0x0016A70D
			internal AlternateLookup(Dictionary<TKey, TValue> dictionary)
			{
				this.Dictionary = dictionary;
			}

			// Token: 0x170013E9 RID: 5097
			// (get) Token: 0x0600925C RID: 37468 RVA: 0x0016C516 File Offset: 0x0016A716
			public Dictionary<TKey, TValue> Dictionary { get; }

			// Token: 0x170013EA RID: 5098
			public unsafe TValue this[TAlternateKey key]
			{
				get
				{
					TKey tkey;
					ref TValue ptr = ref this.FindValue(key, out tkey);
					if (Unsafe.IsNullRef<TValue>(ref ptr))
					{
						ThrowHelper.ThrowKeyNotFoundException<TKey>(Dictionary<TKey, TValue>.AlternateLookup<TAlternateKey>.GetAlternateComparer(this.Dictionary).Create(key));
					}
					return ptr;
				}
				set
				{
					bool flag;
					*this.GetValueRefOrAddDefault(key, out flag) = value;
				}
			}

			// Token: 0x0600925F RID: 37471 RVA: 0x0016C578 File Offset: 0x0016A778
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			internal static bool IsCompatibleKey(Dictionary<TKey, TValue> dictionary)
			{
				return dictionary._comparer is IAlternateEqualityComparer<TAlternateKey, TKey>;
			}

			// Token: 0x06009260 RID: 37472 RVA: 0x0016C588 File Offset: 0x0016A788
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			internal static IAlternateEqualityComparer<TAlternateKey, TKey> GetAlternateComparer(Dictionary<TKey, TValue> dictionary)
			{
				return Unsafe.As<IAlternateEqualityComparer<TAlternateKey, TKey>>(dictionary._comparer);
			}

			// Token: 0x06009261 RID: 37473 RVA: 0x0016C598 File Offset: 0x0016A798
			public bool TryGetValue(TAlternateKey key, [MaybeNullWhen(false)] out TValue value)
			{
				TKey tkey;
				ref TValue ptr = ref this.FindValue(key, out tkey);
				if (!Unsafe.IsNullRef<TValue>(ref ptr))
				{
					value = ptr;
					return true;
				}
				value = default(TValue);
				return false;
			}

			// Token: 0x06009262 RID: 37474 RVA: 0x0016C5D0 File Offset: 0x0016A7D0
			public bool TryGetValue(TAlternateKey key, [MaybeNullWhen(false)] out TKey actualKey, [MaybeNullWhen(false)] out TValue value)
			{
				ref TValue ptr = ref this.FindValue(key, out actualKey);
				if (!Unsafe.IsNullRef<TValue>(ref ptr))
				{
					value = ptr;
					return true;
				}
				value = default(TValue);
				return false;
			}

			// Token: 0x06009263 RID: 37475 RVA: 0x0016C604 File Offset: 0x0016A804
			public bool ContainsKey(TAlternateKey key)
			{
				TKey tkey;
				return !Unsafe.IsNullRef<TValue>(this.FindValue(key, out tkey));
			}

			// Token: 0x06009264 RID: 37476 RVA: 0x0016C624 File Offset: 0x0016A824
			internal unsafe ref TValue FindValue(TAlternateKey key, [MaybeNullWhen(false)] out TKey actualKey)
			{
				Dictionary<TKey, TValue> dictionary = this.Dictionary;
				IAlternateEqualityComparer<TAlternateKey, TKey> alternateComparer = Dictionary<TKey, TValue>.AlternateLookup<TAlternateKey>.GetAlternateComparer(dictionary);
				ref Dictionary<TKey, TValue>.Entry ptr = ref Unsafe.NullRef<Dictionary<TKey, TValue>.Entry>();
				TValue result;
				if (dictionary._buckets != null)
				{
					uint hashCode = (uint)alternateComparer.GetHashCode(key);
					int i = *dictionary.GetBucket(hashCode);
					Dictionary<TKey, TValue>.Entry[] entries = dictionary._entries;
					uint num = 0U;
					i--;
					while (i < entries.Length)
					{
						ptr = ref entries[i];
						if (ptr.hashCode != hashCode || !alternateComparer.Equals(key, ptr.key))
						{
							i = ptr.next;
							num += 1U;
							if (num <= (uint)entries.Length)
							{
								continue;
							}
							ThrowHelper.ThrowInvalidOperationException_ConcurrentOperationsNotSupported();
						}
						result = ref ptr.value;
						actualKey = ptr.key;
						return ref result;
					}
				}
				result = Unsafe.NullRef<TValue>();
				actualKey = default(TKey);
				return ref result;
			}

			// Token: 0x06009265 RID: 37477 RVA: 0x0016C6E0 File Offset: 0x0016A8E0
			public bool Remove(TAlternateKey key)
			{
				TKey tkey;
				TValue tvalue;
				return this.Remove(key, out tkey, out tvalue);
			}

			// Token: 0x06009266 RID: 37478 RVA: 0x0016C6F8 File Offset: 0x0016A8F8
			public bool Remove(TAlternateKey key, [MaybeNullWhen(false)] out TKey actualKey, [MaybeNullWhen(false)] out TValue value)
			{
				Dictionary<TKey, TValue> dictionary = this.Dictionary;
				IAlternateEqualityComparer<TAlternateKey, TKey> alternateComparer = Dictionary<TKey, TValue>.AlternateLookup<TAlternateKey>.GetAlternateComparer(dictionary);
				if (dictionary._buckets != null)
				{
					uint num = 0U;
					uint hashCode = (uint)alternateComparer.GetHashCode(key);
					ref int bucket = ref dictionary.GetBucket(hashCode);
					Dictionary<TKey, TValue>.Entry[] entries = dictionary._entries;
					int num2 = -1;
					int i = bucket - 1;
					while (i >= 0)
					{
						ref Dictionary<TKey, TValue>.Entry ptr = ref entries[i];
						if (ptr.hashCode == hashCode && alternateComparer.Equals(key, ptr.key))
						{
							if (num2 < 0)
							{
								bucket = ptr.next + 1;
							}
							else
							{
								entries[num2].next = ptr.next;
							}
							actualKey = ptr.key;
							value = ptr.value;
							ptr.next = -3 - dictionary._freeList;
							if (RuntimeHelpers.IsReferenceOrContainsReferences<TKey>())
							{
								ptr.key = default(TKey);
							}
							if (RuntimeHelpers.IsReferenceOrContainsReferences<TValue>())
							{
								ptr.value = default(TValue);
							}
							dictionary._freeList = i;
							dictionary._freeCount++;
							return true;
						}
						num2 = i;
						i = ptr.next;
						num += 1U;
						if (num > (uint)entries.Length)
						{
							ThrowHelper.ThrowInvalidOperationException_ConcurrentOperationsNotSupported();
						}
					}
				}
				actualKey = default(TKey);
				value = default(TValue);
				return false;
			}

			// Token: 0x06009267 RID: 37479 RVA: 0x0016C83C File Offset: 0x0016AA3C
			public bool TryAdd(TAlternateKey key, TValue value)
			{
				bool flag;
				ref TValue valueRefOrAddDefault = ref this.GetValueRefOrAddDefault(key, out flag);
				if (!flag)
				{
					valueRefOrAddDefault = value;
					return true;
				}
				return false;
			}

			// Token: 0x06009268 RID: 37480 RVA: 0x0016C860 File Offset: 0x0016AA60
			internal ref TValue GetValueRefOrAddDefault(TAlternateKey key, out bool exists)
			{
				Dictionary<TKey, TValue> dictionary = this.Dictionary;
				IAlternateEqualityComparer<TAlternateKey, TKey> alternateComparer = Dictionary<TKey, TValue>.AlternateLookup<TAlternateKey>.GetAlternateComparer(dictionary);
				if (dictionary._buckets == null)
				{
					dictionary.Initialize(0);
				}
				Dictionary<TKey, TValue>.Entry[] entries = dictionary._entries;
				uint hashCode = (uint)alternateComparer.GetHashCode(key);
				uint num = 0U;
				ref int bucket = ref dictionary.GetBucket(hashCode);
				int i = bucket - 1;
				while (i < entries.Length)
				{
					if (entries[i].hashCode == hashCode && alternateComparer.Equals(key, entries[i].key))
					{
						exists = true;
						return ref entries[i].value;
					}
					i = entries[i].next;
					num += 1U;
					if (num > (uint)entries.Length)
					{
						ThrowHelper.ThrowInvalidOperationException_ConcurrentOperationsNotSupported();
					}
				}
				TKey tkey = alternateComparer.Create(key);
				if (tkey == null)
				{
					ThrowHelper.ThrowArgumentNullException(ExceptionArgument.key);
				}
				int num2;
				if (dictionary._freeCount > 0)
				{
					num2 = dictionary._freeList;
					dictionary._freeList = -3 - entries[dictionary._freeList].next;
					dictionary._freeCount--;
				}
				else
				{
					int count = dictionary._count;
					if (count == entries.Length)
					{
						dictionary.Resize();
						bucket = dictionary.GetBucket(hashCode);
					}
					num2 = count;
					dictionary._count = count + 1;
					entries = dictionary._entries;
				}
				ref Dictionary<TKey, TValue>.Entry ptr = ref entries[num2];
				ptr.hashCode = hashCode;
				ptr.next = bucket - 1;
				ptr.key = tkey;
				ptr.value = default(TValue);
				bucket = num2 + 1;
				dictionary._version++;
				if (!typeof(TKey).IsValueType && num > 100U && alternateComparer is NonRandomizedStringEqualityComparer)
				{
					dictionary.Resize(entries.Length, true);
					exists = false;
					return dictionary.FindValue(tkey);
				}
				exists = false;
				return ref ptr.value;
			}
		}

		// Token: 0x020009AF RID: 2479
		internal static class CollectionsMarshalHelper
		{
			// Token: 0x06009269 RID: 37481 RVA: 0x0016CA1C File Offset: 0x0016AC1C
			public static ref TValue GetValueRefOrAddDefault(Dictionary<TKey, TValue> dictionary, TKey key, out bool exists)
			{
				if (key == null)
				{
					ThrowHelper.ThrowArgumentNullException(ExceptionArgument.key);
				}
				if (dictionary._buckets == null)
				{
					dictionary.Initialize(0);
				}
				Dictionary<TKey, TValue>.Entry[] entries = dictionary._entries;
				IEqualityComparer<TKey> comparer = dictionary._comparer;
				uint num = (uint)((typeof(TKey).IsValueType && comparer == null) ? key.GetHashCode() : comparer.GetHashCode(key));
				uint num2 = 0U;
				ref int bucket = ref dictionary.GetBucket(num);
				int i = bucket - 1;
				if (typeof(TKey).IsValueType && comparer == null)
				{
					while (i < entries.Length)
					{
						if (entries[i].hashCode == num && EqualityComparer<TKey>.Default.Equals(entries[i].key, key))
						{
							exists = true;
							return ref entries[i].value;
						}
						i = entries[i].next;
						num2 += 1U;
						if (num2 > (uint)entries.Length)
						{
							ThrowHelper.ThrowInvalidOperationException_ConcurrentOperationsNotSupported();
						}
					}
				}
				else
				{
					while (i < entries.Length)
					{
						if (entries[i].hashCode == num && comparer.Equals(entries[i].key, key))
						{
							exists = true;
							return ref entries[i].value;
						}
						i = entries[i].next;
						num2 += 1U;
						if (num2 > (uint)entries.Length)
						{
							ThrowHelper.ThrowInvalidOperationException_ConcurrentOperationsNotSupported();
						}
					}
				}
				int num3;
				if (dictionary._freeCount > 0)
				{
					num3 = dictionary._freeList;
					dictionary._freeList = -3 - entries[dictionary._freeList].next;
					dictionary._freeCount--;
				}
				else
				{
					int count = dictionary._count;
					if (count == entries.Length)
					{
						dictionary.Resize();
						bucket = dictionary.GetBucket(num);
					}
					num3 = count;
					dictionary._count = count + 1;
					entries = dictionary._entries;
				}
				ref Dictionary<TKey, TValue>.Entry ptr = ref entries[num3];
				ptr.hashCode = num;
				ptr.next = bucket - 1;
				ptr.key = key;
				ptr.value = default(TValue);
				bucket = num3 + 1;
				dictionary._version++;
				if (!typeof(TKey).IsValueType && num2 > 100U && comparer is NonRandomizedStringEqualityComparer)
				{
					dictionary.Resize(entries.Length, true);
					exists = false;
					return dictionary.FindValue(key);
				}
				exists = false;
				return ref ptr.value;
			}
		}

		// Token: 0x020009B0 RID: 2480
		private struct Entry
		{
			// Token: 0x0400226B RID: 8811
			public uint hashCode;

			// Token: 0x0400226C RID: 8812
			public int next;

			// Token: 0x0400226D RID: 8813
			public TKey key;

			// Token: 0x0400226E RID: 8814
			public TValue value;
		}

		// Token: 0x020009B1 RID: 2481
		[NullableContext(0)]
		public struct Enumerator : IEnumerator<KeyValuePair<TKey, TValue>>, IDisposable, IEnumerator, IDictionaryEnumerator
		{
			// Token: 0x0600926A RID: 37482 RVA: 0x0016CC5F File Offset: 0x0016AE5F
			internal Enumerator(Dictionary<TKey, TValue> dictionary, int getEnumeratorRetType)
			{
				this._dictionary = dictionary;
				this._version = dictionary._version;
				this._index = 0;
				this._getEnumeratorRetType = getEnumeratorRetType;
				this._current = default(KeyValuePair<TKey, TValue>);
			}

			// Token: 0x0600926B RID: 37483 RVA: 0x0016CC90 File Offset: 0x0016AE90
			public bool MoveNext()
			{
				if (this._version != this._dictionary._version)
				{
					ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion();
				}
				while (this._index < this._dictionary._count)
				{
					Dictionary<TKey, TValue>.Entry[] entries = this._dictionary._entries;
					int index = this._index;
					this._index = index + 1;
					ref Dictionary<TKey, TValue>.Entry ptr = ref entries[index];
					if (ptr.next >= -1)
					{
						this._current = new KeyValuePair<TKey, TValue>(ptr.key, ptr.value);
						return true;
					}
				}
				this._index = this._dictionary._count + 1;
				this._current = default(KeyValuePair<TKey, TValue>);
				return false;
			}

			// Token: 0x170013EB RID: 5099
			// (get) Token: 0x0600926C RID: 37484 RVA: 0x0016CD2E File Offset: 0x0016AF2E
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
					return this._current;
				}
			}

			// Token: 0x0600926D RID: 37485 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public void Dispose()
			{
			}

			// Token: 0x170013EC RID: 5100
			// (get) Token: 0x0600926E RID: 37486 RVA: 0x0016CD38 File Offset: 0x0016AF38
			[Nullable(2)]
			object IEnumerator.Current
			{
				get
				{
					if (this._index == 0 || this._index == this._dictionary._count + 1)
					{
						ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumOpCantHappen();
					}
					if (this._getEnumeratorRetType == 1)
					{
						return new DictionaryEntry(this._current.Key, this._current.Value);
					}
					return new KeyValuePair<TKey, TValue>(this._current.Key, this._current.Value);
				}
			}

			// Token: 0x0600926F RID: 37487 RVA: 0x0016CDBB File Offset: 0x0016AFBB
			void IEnumerator.Reset()
			{
				if (this._version != this._dictionary._version)
				{
					ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion();
				}
				this._index = 0;
				this._current = default(KeyValuePair<TKey, TValue>);
			}

			// Token: 0x170013ED RID: 5101
			// (get) Token: 0x06009270 RID: 37488 RVA: 0x0016CDE8 File Offset: 0x0016AFE8
			DictionaryEntry IDictionaryEnumerator.Entry
			{
				get
				{
					if (this._index == 0 || this._index == this._dictionary._count + 1)
					{
						ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumOpCantHappen();
					}
					return new DictionaryEntry(this._current.Key, this._current.Value);
				}
			}

			// Token: 0x170013EE RID: 5102
			// (get) Token: 0x06009271 RID: 37489 RVA: 0x0016CE3C File Offset: 0x0016B03C
			[Nullable(1)]
			object IDictionaryEnumerator.Key
			{
				get
				{
					if (this._index == 0 || this._index == this._dictionary._count + 1)
					{
						ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumOpCantHappen();
					}
					return this._current.Key;
				}
			}

			// Token: 0x170013EF RID: 5103
			// (get) Token: 0x06009272 RID: 37490 RVA: 0x0016CE70 File Offset: 0x0016B070
			[Nullable(2)]
			object IDictionaryEnumerator.Value
			{
				get
				{
					if (this._index == 0 || this._index == this._dictionary._count + 1)
					{
						ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumOpCantHappen();
					}
					return this._current.Value;
				}
			}

			// Token: 0x0400226F RID: 8815
			private readonly Dictionary<TKey, TValue> _dictionary;

			// Token: 0x04002270 RID: 8816
			private readonly int _version;

			// Token: 0x04002271 RID: 8817
			private int _index;

			// Token: 0x04002272 RID: 8818
			private KeyValuePair<TKey, TValue> _current;

			// Token: 0x04002273 RID: 8819
			private readonly int _getEnumeratorRetType;
		}

		// Token: 0x020009B2 RID: 2482
		[NullableContext(0)]
		[DebuggerTypeProxy(typeof(DictionaryKeyCollectionDebugView<, >))]
		[DebuggerDisplay("Count = {Count}")]
		public sealed class KeyCollection : ICollection<!0>, IEnumerable<!0>, IEnumerable, ICollection, IReadOnlyCollection<TKey>
		{
			// Token: 0x06009273 RID: 37491 RVA: 0x0016CEA4 File Offset: 0x0016B0A4
			[NullableContext(1)]
			public KeyCollection(Dictionary<TKey, TValue> dictionary)
			{
				if (dictionary == null)
				{
					ThrowHelper.ThrowArgumentNullException(ExceptionArgument.dictionary);
				}
				this._dictionary = dictionary;
			}

			// Token: 0x06009274 RID: 37492 RVA: 0x0016CEBC File Offset: 0x0016B0BC
			public Dictionary<TKey, TValue>.KeyCollection.Enumerator GetEnumerator()
			{
				return new Dictionary<TKey, TValue>.KeyCollection.Enumerator(this._dictionary);
			}

			// Token: 0x06009275 RID: 37493 RVA: 0x0016CECC File Offset: 0x0016B0CC
			[NullableContext(1)]
			public void CopyTo(TKey[] array, int index)
			{
				if (array == null)
				{
					ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
				}
				if (index < 0 || index > array.Length)
				{
					ThrowHelper.ThrowIndexArgumentOutOfRange_NeedNonNegNumException();
				}
				if (array.Length - index < this._dictionary.Count)
				{
					ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_ArrayPlusOffTooSmall);
				}
				int count = this._dictionary._count;
				Dictionary<TKey, TValue>.Entry[] entries = this._dictionary._entries;
				for (int i = 0; i < count; i++)
				{
					if (entries[i].next >= -1)
					{
						array[index++] = entries[i].key;
					}
				}
			}

			// Token: 0x170013F0 RID: 5104
			// (get) Token: 0x06009276 RID: 37494 RVA: 0x0016CF54 File Offset: 0x0016B154
			public int Count
			{
				get
				{
					return this._dictionary.Count;
				}
			}

			// Token: 0x170013F1 RID: 5105
			// (get) Token: 0x06009277 RID: 37495 RVA: 0x000070DD File Offset: 0x000052DD
			bool ICollection<!0>.IsReadOnly
			{
				get
				{
					return true;
				}
			}

			// Token: 0x06009278 RID: 37496 RVA: 0x0016CF61 File Offset: 0x0016B161
			void ICollection<!0>.Add(TKey item)
			{
				ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_KeyCollectionSet);
			}

			// Token: 0x06009279 RID: 37497 RVA: 0x0016CF61 File Offset: 0x0016B161
			void ICollection<!0>.Clear()
			{
				ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_KeyCollectionSet);
			}

			// Token: 0x0600927A RID: 37498 RVA: 0x0016CF6A File Offset: 0x0016B16A
			[NullableContext(1)]
			public bool Contains(TKey item)
			{
				return this._dictionary.ContainsKey(item);
			}

			// Token: 0x0600927B RID: 37499 RVA: 0x0016CF78 File Offset: 0x0016B178
			bool ICollection<!0>.Remove(TKey item)
			{
				ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_KeyCollectionSet);
				return false;
			}

			// Token: 0x0600927C RID: 37500 RVA: 0x0016CF84 File Offset: 0x0016B184
			IEnumerator<TKey> IEnumerable<!0>.GetEnumerator()
			{
				if (this.Count != 0)
				{
					return this.GetEnumerator();
				}
				return SZGenericArrayEnumerator<TKey>.Empty;
			}

			// Token: 0x0600927D RID: 37501 RVA: 0x00167000 File Offset: 0x00165200
			IEnumerator IEnumerable.GetEnumerator()
			{
				return ((IEnumerable<!0>)this).GetEnumerator();
			}

			// Token: 0x0600927E RID: 37502 RVA: 0x0016CFB0 File Offset: 0x0016B1B0
			void ICollection.CopyTo(Array array, int index)
			{
				if (array == null)
				{
					ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
				}
				if (array.Rank != 1)
				{
					ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_RankMultiDimNotSupported);
				}
				if (array.GetLowerBound(0) != 0)
				{
					ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_NonZeroLowerBound);
				}
				if (index > array.Length)
				{
					ThrowHelper.ThrowIndexArgumentOutOfRange_NeedNonNegNumException();
				}
				if (array.Length - index < this._dictionary.Count)
				{
					ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_ArrayPlusOffTooSmall);
				}
				TKey[] array2 = array as TKey[];
				if (array2 != null)
				{
					this.CopyTo(array2, index);
					return;
				}
				object[] array3 = array as object[];
				if (array3 == null)
				{
					ThrowHelper.ThrowArgumentException_Argument_IncompatibleArrayType();
				}
				int count = this._dictionary._count;
				Dictionary<TKey, TValue>.Entry[] entries = this._dictionary._entries;
				try
				{
					for (int i = 0; i < count; i++)
					{
						if (entries[i].next >= -1)
						{
							array3[index++] = entries[i].key;
						}
					}
				}
				catch (ArrayTypeMismatchException)
				{
					ThrowHelper.ThrowArgumentException_Argument_IncompatibleArrayType();
				}
			}

			// Token: 0x170013F2 RID: 5106
			// (get) Token: 0x0600927F RID: 37503 RVA: 0x00007B65 File Offset: 0x00005D65
			bool ICollection.IsSynchronized
			{
				get
				{
					return false;
				}
			}

			// Token: 0x170013F3 RID: 5107
			// (get) Token: 0x06009280 RID: 37504 RVA: 0x0016D0A0 File Offset: 0x0016B2A0
			[Nullable(1)]
			object ICollection.SyncRoot
			{
				get
				{
					return ((ICollection)this._dictionary).SyncRoot;
				}
			}

			// Token: 0x04002274 RID: 8820
			private readonly Dictionary<TKey, TValue> _dictionary;

			// Token: 0x020009B3 RID: 2483
			public struct Enumerator : IEnumerator<!0>, IDisposable, IEnumerator
			{
				// Token: 0x06009281 RID: 37505 RVA: 0x0016D0AD File Offset: 0x0016B2AD
				internal Enumerator(Dictionary<TKey, TValue> dictionary)
				{
					this._dictionary = dictionary;
					this._version = dictionary._version;
					this._index = 0;
					this._currentKey = default(TKey);
				}

				// Token: 0x06009282 RID: 37506 RVA: 0x0000FCFA File Offset: 0x0000DEFA
				public void Dispose()
				{
				}

				// Token: 0x06009283 RID: 37507 RVA: 0x0016D0D8 File Offset: 0x0016B2D8
				public bool MoveNext()
				{
					if (this._version != this._dictionary._version)
					{
						ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion();
					}
					while (this._index < this._dictionary._count)
					{
						Dictionary<TKey, TValue>.Entry[] entries = this._dictionary._entries;
						int index = this._index;
						this._index = index + 1;
						ref Dictionary<TKey, TValue>.Entry ptr = ref entries[index];
						if (ptr.next >= -1)
						{
							this._currentKey = ptr.key;
							return true;
						}
					}
					this._index = this._dictionary._count + 1;
					this._currentKey = default(TKey);
					return false;
				}

				// Token: 0x170013F4 RID: 5108
				// (get) Token: 0x06009284 RID: 37508 RVA: 0x0016D16B File Offset: 0x0016B36B
				[Nullable(1)]
				public TKey Current
				{
					[NullableContext(1)]
					get
					{
						return this._currentKey;
					}
				}

				// Token: 0x170013F5 RID: 5109
				// (get) Token: 0x06009285 RID: 37509 RVA: 0x0016D173 File Offset: 0x0016B373
				[Nullable(2)]
				object IEnumerator.Current
				{
					get
					{
						if (this._index == 0 || this._index == this._dictionary._count + 1)
						{
							ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumOpCantHappen();
						}
						return this._currentKey;
					}
				}

				// Token: 0x06009286 RID: 37510 RVA: 0x0016D1A2 File Offset: 0x0016B3A2
				void IEnumerator.Reset()
				{
					if (this._version != this._dictionary._version)
					{
						ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion();
					}
					this._index = 0;
					this._currentKey = default(TKey);
				}

				// Token: 0x04002275 RID: 8821
				private readonly Dictionary<TKey, TValue> _dictionary;

				// Token: 0x04002276 RID: 8822
				private int _index;

				// Token: 0x04002277 RID: 8823
				private readonly int _version;

				// Token: 0x04002278 RID: 8824
				private TKey _currentKey;
			}
		}

		// Token: 0x020009B4 RID: 2484
		[NullableContext(0)]
		[DebuggerTypeProxy(typeof(DictionaryValueCollectionDebugView<, >))]
		[DebuggerDisplay("Count = {Count}")]
		public sealed class ValueCollection : ICollection<TValue>, IEnumerable<TValue>, IEnumerable, ICollection, IReadOnlyCollection<TValue>
		{
			// Token: 0x06009287 RID: 37511 RVA: 0x0016D1CF File Offset: 0x0016B3CF
			[NullableContext(1)]
			public ValueCollection(Dictionary<TKey, TValue> dictionary)
			{
				if (dictionary == null)
				{
					ThrowHelper.ThrowArgumentNullException(ExceptionArgument.dictionary);
				}
				this._dictionary = dictionary;
			}

			// Token: 0x06009288 RID: 37512 RVA: 0x0016D1E7 File Offset: 0x0016B3E7
			public Dictionary<TKey, TValue>.ValueCollection.Enumerator GetEnumerator()
			{
				return new Dictionary<TKey, TValue>.ValueCollection.Enumerator(this._dictionary);
			}

			// Token: 0x06009289 RID: 37513 RVA: 0x0016D1F4 File Offset: 0x0016B3F4
			[NullableContext(1)]
			public void CopyTo(TValue[] array, int index)
			{
				if (array == null)
				{
					ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
				}
				if ((ulong)index > (ulong)((long)array.Length))
				{
					ThrowHelper.ThrowIndexArgumentOutOfRange_NeedNonNegNumException();
				}
				if (array.Length - index < this._dictionary.Count)
				{
					ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_ArrayPlusOffTooSmall);
				}
				int count = this._dictionary._count;
				Dictionary<TKey, TValue>.Entry[] entries = this._dictionary._entries;
				for (int i = 0; i < count; i++)
				{
					if (entries[i].next >= -1)
					{
						array[index++] = entries[i].value;
					}
				}
			}

			// Token: 0x170013F6 RID: 5110
			// (get) Token: 0x0600928A RID: 37514 RVA: 0x0016D27A File Offset: 0x0016B47A
			public int Count
			{
				get
				{
					return this._dictionary.Count;
				}
			}

			// Token: 0x170013F7 RID: 5111
			// (get) Token: 0x0600928B RID: 37515 RVA: 0x000070DD File Offset: 0x000052DD
			bool ICollection<!1>.IsReadOnly
			{
				get
				{
					return true;
				}
			}

			// Token: 0x0600928C RID: 37516 RVA: 0x0016D287 File Offset: 0x0016B487
			void ICollection<!1>.Add(TValue item)
			{
				ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ValueCollectionSet);
			}

			// Token: 0x0600928D RID: 37517 RVA: 0x0016D290 File Offset: 0x0016B490
			bool ICollection<!1>.Remove(TValue item)
			{
				ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ValueCollectionSet);
				return false;
			}

			// Token: 0x0600928E RID: 37518 RVA: 0x0016D287 File Offset: 0x0016B487
			void ICollection<!1>.Clear()
			{
				ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ValueCollectionSet);
			}

			// Token: 0x0600928F RID: 37519 RVA: 0x0016D29A File Offset: 0x0016B49A
			bool ICollection<!1>.Contains(TValue item)
			{
				return this._dictionary.ContainsValue(item);
			}

			// Token: 0x06009290 RID: 37520 RVA: 0x0016D2A8 File Offset: 0x0016B4A8
			IEnumerator<TValue> IEnumerable<!1>.GetEnumerator()
			{
				if (this.Count != 0)
				{
					return this.GetEnumerator();
				}
				return SZGenericArrayEnumerator<TValue>.Empty;
			}

			// Token: 0x06009291 RID: 37521 RVA: 0x0016D2D2 File Offset: 0x0016B4D2
			IEnumerator IEnumerable.GetEnumerator()
			{
				return ((IEnumerable<!1>)this).GetEnumerator();
			}

			// Token: 0x06009292 RID: 37522 RVA: 0x0016D2DC File Offset: 0x0016B4DC
			void ICollection.CopyTo(Array array, int index)
			{
				if (array == null)
				{
					ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
				}
				if (array.Rank != 1)
				{
					ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_RankMultiDimNotSupported);
				}
				if (array.GetLowerBound(0) != 0)
				{
					ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_NonZeroLowerBound);
				}
				if (index > array.Length)
				{
					ThrowHelper.ThrowIndexArgumentOutOfRange_NeedNonNegNumException();
				}
				if (array.Length - index < this._dictionary.Count)
				{
					ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_ArrayPlusOffTooSmall);
				}
				TValue[] array2 = array as TValue[];
				if (array2 != null)
				{
					this.CopyTo(array2, index);
					return;
				}
				object[] array3 = array as object[];
				if (array3 == null)
				{
					ThrowHelper.ThrowArgumentException_Argument_IncompatibleArrayType();
				}
				int count = this._dictionary._count;
				Dictionary<TKey, TValue>.Entry[] entries = this._dictionary._entries;
				try
				{
					for (int i = 0; i < count; i++)
					{
						if (entries[i].next >= -1)
						{
							array3[index++] = entries[i].value;
						}
					}
				}
				catch (ArrayTypeMismatchException)
				{
					ThrowHelper.ThrowArgumentException_Argument_IncompatibleArrayType();
				}
			}

			// Token: 0x170013F8 RID: 5112
			// (get) Token: 0x06009293 RID: 37523 RVA: 0x00007B65 File Offset: 0x00005D65
			bool ICollection.IsSynchronized
			{
				get
				{
					return false;
				}
			}

			// Token: 0x170013F9 RID: 5113
			// (get) Token: 0x06009294 RID: 37524 RVA: 0x0016D3CC File Offset: 0x0016B5CC
			[Nullable(1)]
			object ICollection.SyncRoot
			{
				get
				{
					return ((ICollection)this._dictionary).SyncRoot;
				}
			}

			// Token: 0x04002279 RID: 8825
			private readonly Dictionary<TKey, TValue> _dictionary;

			// Token: 0x020009B5 RID: 2485
			public struct Enumerator : IEnumerator<TValue>, IDisposable, IEnumerator
			{
				// Token: 0x06009295 RID: 37525 RVA: 0x0016D3D9 File Offset: 0x0016B5D9
				internal Enumerator(Dictionary<TKey, TValue> dictionary)
				{
					this._dictionary = dictionary;
					this._version = dictionary._version;
					this._index = 0;
					this._currentValue = default(TValue);
				}

				// Token: 0x06009296 RID: 37526 RVA: 0x0000FCFA File Offset: 0x0000DEFA
				public void Dispose()
				{
				}

				// Token: 0x06009297 RID: 37527 RVA: 0x0016D404 File Offset: 0x0016B604
				public bool MoveNext()
				{
					if (this._version != this._dictionary._version)
					{
						ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion();
					}
					while (this._index < this._dictionary._count)
					{
						Dictionary<TKey, TValue>.Entry[] entries = this._dictionary._entries;
						int index = this._index;
						this._index = index + 1;
						ref Dictionary<TKey, TValue>.Entry ptr = ref entries[index];
						if (ptr.next >= -1)
						{
							this._currentValue = ptr.value;
							return true;
						}
					}
					this._index = this._dictionary._count + 1;
					this._currentValue = default(TValue);
					return false;
				}

				// Token: 0x170013FA RID: 5114
				// (get) Token: 0x06009298 RID: 37528 RVA: 0x0016D497 File Offset: 0x0016B697
				[Nullable(1)]
				public TValue Current
				{
					[NullableContext(1)]
					get
					{
						return this._currentValue;
					}
				}

				// Token: 0x170013FB RID: 5115
				// (get) Token: 0x06009299 RID: 37529 RVA: 0x0016D49F File Offset: 0x0016B69F
				[Nullable(2)]
				object IEnumerator.Current
				{
					get
					{
						if (this._index == 0 || this._index == this._dictionary._count + 1)
						{
							ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumOpCantHappen();
						}
						return this._currentValue;
					}
				}

				// Token: 0x0600929A RID: 37530 RVA: 0x0016D4CE File Offset: 0x0016B6CE
				void IEnumerator.Reset()
				{
					if (this._version != this._dictionary._version)
					{
						ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion();
					}
					this._index = 0;
					this._currentValue = default(TValue);
				}

				// Token: 0x0400227A RID: 8826
				private readonly Dictionary<TKey, TValue> _dictionary;

				// Token: 0x0400227B RID: 8827
				private int _index;

				// Token: 0x0400227C RID: 8828
				private readonly int _version;

				// Token: 0x0400227D RID: 8829
				private TValue _currentValue;
			}
		}
	}
}
