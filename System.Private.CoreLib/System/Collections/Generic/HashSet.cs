using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System.Collections.Generic
{
	// Token: 0x020009BD RID: 2493
	[NullableContext(1)]
	[Nullable(0)]
	[DebuggerTypeProxy(typeof(ICollectionDebugView<>))]
	[DebuggerDisplay("Count = {Count}")]
	[TypeForwardedFrom("System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class HashSet<[Nullable(2)] T> : ICollection<T>, IEnumerable<T>, IEnumerable, ISet<T>, IReadOnlyCollection<T>, IReadOnlySet<T>, ISerializable, IDeserializationCallback
	{
		// Token: 0x060092C3 RID: 37571 RVA: 0x0016D746 File Offset: 0x0016B946
		public HashSet() : this(null)
		{
		}

		// Token: 0x060092C4 RID: 37572 RVA: 0x0016D750 File Offset: 0x0016B950
		public HashSet([Nullable(new byte[]
		{
			2,
			1
		})] IEqualityComparer<T> comparer)
		{
			if (!typeof(T).IsValueType)
			{
				this._comparer = (comparer ?? EqualityComparer<T>.Default);
				if (typeof(T) == typeof(string))
				{
					IEqualityComparer<string> stringComparer = NonRandomizedStringEqualityComparer.GetStringComparer(this._comparer);
					if (stringComparer != null)
					{
						this._comparer = (IEqualityComparer<T>)stringComparer;
						return;
					}
				}
			}
			else if (comparer != null && comparer != EqualityComparer<T>.Default)
			{
				this._comparer = comparer;
			}
		}

		// Token: 0x060092C5 RID: 37573 RVA: 0x0016D7CD File Offset: 0x0016B9CD
		public HashSet(int capacity) : this(capacity, null)
		{
		}

		// Token: 0x060092C6 RID: 37574 RVA: 0x0016D7D7 File Offset: 0x0016B9D7
		public HashSet(IEnumerable<T> collection) : this(collection, null)
		{
		}

		// Token: 0x060092C7 RID: 37575 RVA: 0x0016D7E4 File Offset: 0x0016B9E4
		public HashSet(IEnumerable<T> collection, [Nullable(new byte[]
		{
			2,
			1
		})] IEqualityComparer<T> comparer) : this(comparer)
		{
			if (collection == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.collection);
			}
			HashSet<T> hashSet = collection as HashSet<T>;
			if (hashSet != null && HashSet<T>.EffectiveEqualityComparersAreEqual(this, hashSet))
			{
				this.ConstructFrom(hashSet);
				return;
			}
			ICollection<T> collection2 = collection as ICollection<!0>;
			if (collection2 != null)
			{
				int count = collection2.Count;
				if (count > 0)
				{
					this.Initialize(count);
				}
			}
			this.UnionWith(collection);
			if (this._count > 0 && this._entries.Length / this._count > 3)
			{
				this.TrimExcess();
			}
		}

		// Token: 0x060092C8 RID: 37576 RVA: 0x0016D862 File Offset: 0x0016BA62
		public HashSet(int capacity, [Nullable(new byte[]
		{
			2,
			1
		})] IEqualityComparer<T> comparer) : this(comparer)
		{
			if (capacity < 0)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.capacity);
			}
			if (capacity > 0)
			{
				this.Initialize(capacity);
			}
		}

		// Token: 0x060092C9 RID: 37577 RVA: 0x001643AF File Offset: 0x001625AF
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected HashSet(SerializationInfo info, StreamingContext context)
		{
			HashHelpers.SerializationInfoTable.Add(this, info);
		}

		// Token: 0x060092CA RID: 37578 RVA: 0x0016D884 File Offset: 0x0016BA84
		private void ConstructFrom(HashSet<T> source)
		{
			if (source.Count == 0)
			{
				return;
			}
			int num = source._buckets.Length;
			if (HashHelpers.ExpandPrime(source.Count + 1) >= num)
			{
				this._buckets = (int[])source._buckets.Clone();
				this._entries = (HashSet<T>.Entry[])source._entries.Clone();
				this._freeList = source._freeList;
				this._freeCount = source._freeCount;
				this._count = source._count;
				this._fastModMultiplier = source._fastModMultiplier;
				return;
			}
			this.Initialize(source.Count);
			HashSet<T>.Entry[] entries = source._entries;
			for (int i = 0; i < source._count; i++)
			{
				ref HashSet<T>.Entry ptr = ref entries[i];
				if (ptr.Next >= -1)
				{
					int num2;
					this.AddIfNotPresent(ptr.Value, out num2);
				}
			}
		}

		// Token: 0x060092CB RID: 37579 RVA: 0x0016D958 File Offset: 0x0016BB58
		void ICollection<!0>.Add(T item)
		{
			int num;
			this.AddIfNotPresent(item, out num);
		}

		// Token: 0x060092CC RID: 37580 RVA: 0x0016D970 File Offset: 0x0016BB70
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

		// Token: 0x060092CD RID: 37581 RVA: 0x0016D9B5 File Offset: 0x0016BBB5
		public bool Contains(T item)
		{
			return this.FindItemIndex(item) >= 0;
		}

		// Token: 0x060092CE RID: 37582 RVA: 0x0016D9C4 File Offset: 0x0016BBC4
		private unsafe int FindItemIndex(T item)
		{
			if (this._buckets != null)
			{
				HashSet<T>.Entry[] entries = this._entries;
				uint num = 0U;
				IEqualityComparer<T> comparer = this._comparer;
				if (typeof(T).IsValueType && comparer == null)
				{
					int hashCode = item.GetHashCode();
					int i = *this.GetBucketRef(hashCode) - 1;
					while (i >= 0)
					{
						ref HashSet<T>.Entry ptr = ref entries[i];
						if (ptr.HashCode == hashCode && EqualityComparer<T>.Default.Equals(ptr.Value, item))
						{
							return i;
						}
						i = ptr.Next;
						num += 1U;
						if (num > (uint)entries.Length)
						{
							ThrowHelper.ThrowInvalidOperationException_ConcurrentOperationsNotSupported();
						}
					}
				}
				else
				{
					int num2 = (item != null) ? comparer.GetHashCode(item) : 0;
					int j = *this.GetBucketRef(num2) - 1;
					while (j >= 0)
					{
						ref HashSet<T>.Entry ptr2 = ref entries[j];
						if (ptr2.HashCode == num2 && comparer.Equals(ptr2.Value, item))
						{
							return j;
						}
						j = ptr2.Next;
						num += 1U;
						if (num > (uint)entries.Length)
						{
							ThrowHelper.ThrowInvalidOperationException_ConcurrentOperationsNotSupported();
						}
					}
				}
			}
			return -1;
		}

		// Token: 0x060092CF RID: 37583 RVA: 0x0016DAD0 File Offset: 0x0016BCD0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private ref int GetBucketRef(int hashCode)
		{
			int[] buckets = this._buckets;
			return ref buckets[(int)HashHelpers.FastMod((uint)hashCode, (uint)buckets.Length, this._fastModMultiplier)];
		}

		// Token: 0x060092D0 RID: 37584 RVA: 0x0016DAFC File Offset: 0x0016BCFC
		public bool Remove(T item)
		{
			if (this._buckets != null)
			{
				HashSet<T>.Entry[] entries = this._entries;
				uint num = 0U;
				int num2 = -1;
				IEqualityComparer<T> comparer = this._comparer;
				int num3 = (typeof(T).IsValueType && comparer == null) ? item.GetHashCode() : ((item != null) ? comparer.GetHashCode(item) : 0);
				ref int bucketRef = ref this.GetBucketRef(num3);
				int i = bucketRef - 1;
				while (i >= 0)
				{
					ref HashSet<T>.Entry ptr = ref entries[i];
					if (ptr.HashCode == num3 && ((comparer != null) ? comparer.Equals(ptr.Value, item) : EqualityComparer<T>.Default.Equals(ptr.Value, item)))
					{
						if (num2 < 0)
						{
							bucketRef = ptr.Next + 1;
						}
						else
						{
							entries[num2].Next = ptr.Next;
						}
						ptr.Next = -3 - this._freeList;
						if (RuntimeHelpers.IsReferenceOrContainsReferences<T>())
						{
							ptr.Value = default(T);
						}
						this._freeList = i;
						this._freeCount++;
						return true;
					}
					num2 = i;
					i = ptr.Next;
					num += 1U;
					if (num > (uint)entries.Length)
					{
						ThrowHelper.ThrowInvalidOperationException_ConcurrentOperationsNotSupported();
					}
				}
			}
			return false;
		}

		// Token: 0x170013FE RID: 5118
		// (get) Token: 0x060092D1 RID: 37585 RVA: 0x0016DC37 File Offset: 0x0016BE37
		public int Count
		{
			get
			{
				return this._count - this._freeCount;
			}
		}

		// Token: 0x170013FF RID: 5119
		// (get) Token: 0x060092D2 RID: 37586 RVA: 0x0016DC46 File Offset: 0x0016BE46
		public int Capacity
		{
			get
			{
				HashSet<T>.Entry[] entries = this._entries;
				if (entries == null)
				{
					return 0;
				}
				return entries.Length;
			}
		}

		// Token: 0x17001400 RID: 5120
		// (get) Token: 0x060092D3 RID: 37587 RVA: 0x00007B65 File Offset: 0x00005D65
		bool ICollection<!0>.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060092D4 RID: 37588 RVA: 0x0016DC56 File Offset: 0x0016BE56
		[NullableContext(2)]
		[return: Nullable(new byte[]
		{
			0,
			0,
			1
		})]
		public HashSet<T>.AlternateLookup<TAlternate> GetAlternateLookup<TAlternate>()
		{
			if (!HashSet<T>.AlternateLookup<TAlternate>.IsCompatibleItem(this))
			{
				ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_IncompatibleComparer);
			}
			return new HashSet<T>.AlternateLookup<TAlternate>(this);
		}

		// Token: 0x060092D5 RID: 37589 RVA: 0x0016DC6D File Offset: 0x0016BE6D
		[NullableContext(2)]
		public bool TryGetAlternateLookup<TAlternate>([Nullable(new byte[]
		{
			0,
			0,
			1
		})] out HashSet<T>.AlternateLookup<TAlternate> lookup)
		{
			if (HashSet<T>.AlternateLookup<TAlternate>.IsCompatibleItem(this))
			{
				lookup = new HashSet<T>.AlternateLookup<TAlternate>(this);
				return true;
			}
			lookup = default(HashSet<T>.AlternateLookup<TAlternate>);
			return false;
		}

		// Token: 0x060092D6 RID: 37590 RVA: 0x0016DC8D File Offset: 0x0016BE8D
		[NullableContext(0)]
		public HashSet<T>.Enumerator GetEnumerator()
		{
			return new HashSet<T>.Enumerator(this);
		}

		// Token: 0x060092D7 RID: 37591 RVA: 0x0016DC98 File Offset: 0x0016BE98
		IEnumerator<T> IEnumerable<!0>.GetEnumerator()
		{
			if (this.Count != 0)
			{
				return this.GetEnumerator();
			}
			return SZGenericArrayEnumerator<T>.Empty;
		}

		// Token: 0x060092D8 RID: 37592 RVA: 0x00167000 File Offset: 0x00165200
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<!0>)this).GetEnumerator();
		}

		// Token: 0x060092D9 RID: 37593 RVA: 0x0016DCC4 File Offset: 0x0016BEC4
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.info);
			}
			info.AddValue("Version", this._version);
			info.AddValue("Comparer", this.Comparer, typeof(IEqualityComparer<T>));
			info.AddValue("Capacity", (this._buckets == null) ? 0 : this._buckets.Length);
			if (this._buckets != null)
			{
				T[] array = new T[this.Count];
				this.CopyTo(array);
				info.AddValue("Elements", array, typeof(T[]));
			}
		}

		// Token: 0x060092DA RID: 37594 RVA: 0x0016DD58 File Offset: 0x0016BF58
		[NullableContext(2)]
		public virtual void OnDeserialization(object sender)
		{
			SerializationInfo serializationInfo;
			HashHelpers.SerializationInfoTable.TryGetValue(this, out serializationInfo);
			if (serializationInfo == null)
			{
				return;
			}
			int @int = serializationInfo.GetInt32("Capacity");
			this._comparer = (IEqualityComparer<T>)serializationInfo.GetValue("Comparer", typeof(IEqualityComparer<T>));
			this._freeList = -1;
			this._freeCount = 0;
			if (@int != 0)
			{
				this._buckets = new int[@int];
				this._entries = new HashSet<T>.Entry[@int];
				this._fastModMultiplier = HashHelpers.GetFastModMultiplier((uint)@int);
				T[] array = (T[])serializationInfo.GetValue("Elements", typeof(T[]));
				if (array == null)
				{
					ThrowHelper.ThrowSerializationException(ExceptionResource.Serialization_MissingKeys);
				}
				for (int i = 0; i < array.Length; i++)
				{
					int num;
					this.AddIfNotPresent(array[i], out num);
				}
			}
			else
			{
				this._buckets = null;
			}
			this._version = serializationInfo.GetInt32("Version");
			HashHelpers.SerializationInfoTable.Remove(this);
		}

		// Token: 0x060092DB RID: 37595 RVA: 0x0016DE44 File Offset: 0x0016C044
		public bool Add(T item)
		{
			int num;
			return this.AddIfNotPresent(item, out num);
		}

		// Token: 0x060092DC RID: 37596 RVA: 0x0016DE5C File Offset: 0x0016C05C
		public bool TryGetValue(T equalValue, [MaybeNullWhen(false)] out T actualValue)
		{
			if (this._buckets != null)
			{
				int num = this.FindItemIndex(equalValue);
				if (num >= 0)
				{
					actualValue = this._entries[num].Value;
					return true;
				}
			}
			actualValue = default(T);
			return false;
		}

		// Token: 0x060092DD RID: 37597 RVA: 0x0016DEA0 File Offset: 0x0016C0A0
		public void UnionWith(IEnumerable<T> other)
		{
			if (other == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.other);
			}
			foreach (T value in other)
			{
				int num;
				this.AddIfNotPresent(value, out num);
			}
		}

		// Token: 0x060092DE RID: 37598 RVA: 0x0016DEF8 File Offset: 0x0016C0F8
		public void IntersectWith(IEnumerable<T> other)
		{
			if (other == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.other);
			}
			if (this.Count == 0 || other == this)
			{
				return;
			}
			ICollection<T> collection = other as ICollection<!0>;
			if (collection != null)
			{
				if (collection.Count == 0)
				{
					this.Clear();
					return;
				}
				HashSet<T> hashSet = other as HashSet<T>;
				if (hashSet != null && HashSet<T>.EqualityComparersAreEqual(this, hashSet))
				{
					this.IntersectWithHashSetWithSameComparer(hashSet);
					return;
				}
			}
			this.IntersectWithEnumerable(other);
		}

		// Token: 0x060092DF RID: 37599 RVA: 0x0016DF58 File Offset: 0x0016C158
		public void ExceptWith(IEnumerable<T> other)
		{
			if (other == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.other);
			}
			if (this.Count == 0)
			{
				return;
			}
			if (other == this)
			{
				this.Clear();
				return;
			}
			foreach (T item in other)
			{
				this.Remove(item);
			}
		}

		// Token: 0x060092E0 RID: 37600 RVA: 0x0016DFC0 File Offset: 0x0016C1C0
		public void SymmetricExceptWith(IEnumerable<T> other)
		{
			if (other == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.other);
			}
			if (this.Count == 0)
			{
				this.UnionWith(other);
				return;
			}
			if (other == this)
			{
				this.Clear();
				return;
			}
			HashSet<T> hashSet = other as HashSet<T>;
			if (hashSet != null && HashSet<T>.EqualityComparersAreEqual(this, hashSet))
			{
				this.SymmetricExceptWithUniqueHashSet(hashSet);
				return;
			}
			this.SymmetricExceptWithEnumerable(other);
		}

		// Token: 0x060092E1 RID: 37601 RVA: 0x0016E014 File Offset: 0x0016C214
		public bool IsSubsetOf(IEnumerable<T> other)
		{
			if (other == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.other);
			}
			if (this.Count == 0 || other == this)
			{
				return true;
			}
			ICollection<T> collection = other as ICollection<!0>;
			if (collection != null)
			{
				if (this.Count > collection.Count)
				{
					return false;
				}
				HashSet<T> hashSet = other as HashSet<T>;
				if (hashSet != null && HashSet<T>.EqualityComparersAreEqual(this, hashSet))
				{
					return this.IsSubsetOfHashSetWithSameComparer(hashSet);
				}
			}
			ValueTuple<int, int> valueTuple = this.CheckUniqueAndUnfoundElements(other, false);
			int item = valueTuple.Item1;
			int item2 = valueTuple.Item2;
			return item == this.Count && item2 >= 0;
		}

		// Token: 0x060092E2 RID: 37602 RVA: 0x0016E098 File Offset: 0x0016C298
		public bool IsProperSubsetOf(IEnumerable<T> other)
		{
			if (other == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.other);
			}
			if (other == this)
			{
				return false;
			}
			ICollection<T> collection = other as ICollection<!0>;
			if (collection != null)
			{
				if (collection.Count <= this.Count)
				{
					return false;
				}
				if (this.Count == 0)
				{
					return true;
				}
				HashSet<T> hashSet = other as HashSet<T>;
				if (hashSet != null && HashSet<T>.EqualityComparersAreEqual(this, hashSet))
				{
					return this.IsSubsetOfHashSetWithSameComparer(hashSet);
				}
			}
			ValueTuple<int, int> valueTuple = this.CheckUniqueAndUnfoundElements(other, false);
			int item = valueTuple.Item1;
			int item2 = valueTuple.Item2;
			return item == this.Count && item2 > 0;
		}

		// Token: 0x060092E3 RID: 37603 RVA: 0x0016E118 File Offset: 0x0016C318
		public bool IsSupersetOf(IEnumerable<T> other)
		{
			if (other == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.other);
			}
			if (other == this)
			{
				return true;
			}
			ICollection<T> collection = other as ICollection<!0>;
			if (collection != null)
			{
				if (collection.Count == 0)
				{
					return true;
				}
				HashSet<T> hashSet = other as HashSet<T>;
				if (hashSet != null && HashSet<T>.EqualityComparersAreEqual(this, hashSet) && hashSet.Count > this.Count)
				{
					return false;
				}
			}
			foreach (T item in other)
			{
				if (!this.Contains(item))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060092E4 RID: 37604 RVA: 0x0016E1B4 File Offset: 0x0016C3B4
		public bool IsProperSupersetOf(IEnumerable<T> other)
		{
			if (other == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.other);
			}
			if (this.Count == 0 || other == this)
			{
				return false;
			}
			ICollection<T> collection = other as ICollection<!0>;
			if (collection != null)
			{
				if (collection.Count == 0)
				{
					return true;
				}
				HashSet<T> hashSet = other as HashSet<T>;
				if (hashSet != null && HashSet<T>.EqualityComparersAreEqual(this, hashSet))
				{
					return hashSet.Count < this.Count && hashSet.IsSubsetOfHashSetWithSameComparer(this);
				}
			}
			ValueTuple<int, int> valueTuple = this.CheckUniqueAndUnfoundElements(other, true);
			int item = valueTuple.Item1;
			int item2 = valueTuple.Item2;
			return item < this.Count && item2 == 0;
		}

		// Token: 0x060092E5 RID: 37605 RVA: 0x0016E23C File Offset: 0x0016C43C
		public bool Overlaps(IEnumerable<T> other)
		{
			if (other == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.other);
			}
			if (this.Count == 0)
			{
				return false;
			}
			if (other == this)
			{
				return true;
			}
			foreach (T item in other)
			{
				if (this.Contains(item))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060092E6 RID: 37606 RVA: 0x0016E2A8 File Offset: 0x0016C4A8
		public bool SetEquals(IEnumerable<T> other)
		{
			if (other == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.other);
			}
			if (other == this)
			{
				return true;
			}
			ICollection<T> collection = other as ICollection<!0>;
			if (collection != null)
			{
				if (this.Count == 0)
				{
					return collection.Count == 0;
				}
				HashSet<T> hashSet = other as HashSet<T>;
				if (hashSet != null && HashSet<T>.EqualityComparersAreEqual(this, hashSet))
				{
					return this.Count == hashSet.Count && this.IsSubsetOfHashSetWithSameComparer(hashSet);
				}
				if (this.Count > collection.Count)
				{
					return false;
				}
			}
			ValueTuple<int, int> valueTuple = this.CheckUniqueAndUnfoundElements(other, true);
			int item = valueTuple.Item1;
			int item2 = valueTuple.Item2;
			return item == this.Count && item2 == 0;
		}

		// Token: 0x060092E7 RID: 37607 RVA: 0x0016E340 File Offset: 0x0016C540
		public void CopyTo(T[] array)
		{
			this.CopyTo(array, 0, this.Count);
		}

		// Token: 0x060092E8 RID: 37608 RVA: 0x0016E350 File Offset: 0x0016C550
		public void CopyTo(T[] array, int arrayIndex)
		{
			this.CopyTo(array, arrayIndex, this.Count);
		}

		// Token: 0x060092E9 RID: 37609 RVA: 0x0016E360 File Offset: 0x0016C560
		public void CopyTo(T[] array, int arrayIndex, int count)
		{
			if (array == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
			}
			ArgumentOutOfRangeException.ThrowIfNegative<int>(arrayIndex, "arrayIndex");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(count, "count");
			if (arrayIndex > array.Length || count > array.Length - arrayIndex)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_ArrayPlusOffTooSmall);
			}
			HashSet<T>.Entry[] entries = this._entries;
			int num = 0;
			while (num < this._count && count != 0)
			{
				ref HashSet<T>.Entry ptr = ref entries[num];
				if (ptr.Next >= -1)
				{
					array[arrayIndex++] = ptr.Value;
					count--;
				}
				num++;
			}
		}

		// Token: 0x060092EA RID: 37610 RVA: 0x0016E3E4 File Offset: 0x0016C5E4
		public int RemoveWhere(Predicate<T> match)
		{
			if (match == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.match);
			}
			HashSet<T>.Entry[] entries = this._entries;
			int num = 0;
			for (int i = 0; i < this._count; i++)
			{
				ref HashSet<T>.Entry ptr = ref entries[i];
				if (ptr.Next >= -1)
				{
					T value = ptr.Value;
					if (match(value) && this.Remove(value))
					{
						num++;
					}
				}
			}
			return num;
		}

		// Token: 0x17001401 RID: 5121
		// (get) Token: 0x060092EB RID: 37611 RVA: 0x0016E448 File Offset: 0x0016C648
		public IEqualityComparer<T> Comparer
		{
			get
			{
				if (typeof(T) == typeof(string))
				{
					return (IEqualityComparer<T>)IInternalStringEqualityComparer.GetUnderlyingEqualityComparer((IEqualityComparer<string>)this._comparer);
				}
				return this._comparer ?? EqualityComparer<T>.Default;
			}
		}

		// Token: 0x17001402 RID: 5122
		// (get) Token: 0x060092EC RID: 37612 RVA: 0x0016E495 File Offset: 0x0016C695
		internal IEqualityComparer<T> EffectiveComparer
		{
			get
			{
				return this._comparer ?? EqualityComparer<T>.Default;
			}
		}

		// Token: 0x060092ED RID: 37613 RVA: 0x0016E4A8 File Offset: 0x0016C6A8
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
			if (this._buckets == null)
			{
				return this.Initialize(capacity);
			}
			int prime = HashHelpers.GetPrime(capacity);
			this.Resize(prime, false);
			return prime;
		}

		// Token: 0x060092EE RID: 37614 RVA: 0x0016E4FA File Offset: 0x0016C6FA
		private void Resize()
		{
			this.Resize(HashHelpers.ExpandPrime(this._count), false);
		}

		// Token: 0x060092EF RID: 37615 RVA: 0x0016E510 File Offset: 0x0016C710
		private void Resize(int newSize, bool forceNewHashCodes)
		{
			HashSet<T>.Entry[] array = new HashSet<T>.Entry[newSize];
			int count = this._count;
			Array.Copy(this._entries, array, count);
			if (!typeof(T).IsValueType && forceNewHashCodes)
			{
				IEqualityComparer<T> equalityComparer = this._comparer = (IEqualityComparer<T>)((NonRandomizedStringEqualityComparer)this._comparer).GetRandomizedEqualityComparer();
				for (int i = 0; i < count; i++)
				{
					ref HashSet<T>.Entry ptr = ref array[i];
					if (ptr.Next >= -1)
					{
						ptr.HashCode = ((ptr.Value != null) ? equalityComparer.GetHashCode(ptr.Value) : 0);
					}
				}
			}
			this._buckets = new int[newSize];
			this._fastModMultiplier = HashHelpers.GetFastModMultiplier((uint)newSize);
			for (int j = 0; j < count; j++)
			{
				ref HashSet<T>.Entry ptr2 = ref array[j];
				if (ptr2.Next >= -1)
				{
					ref int bucketRef = ref this.GetBucketRef(ptr2.HashCode);
					ptr2.Next = bucketRef - 1;
					bucketRef = j + 1;
				}
			}
			this._entries = array;
		}

		// Token: 0x060092F0 RID: 37616 RVA: 0x0016E61B File Offset: 0x0016C81B
		public void TrimExcess()
		{
			this.TrimExcess(this.Count);
		}

		// Token: 0x060092F1 RID: 37617 RVA: 0x0016E62C File Offset: 0x0016C82C
		public void TrimExcess(int capacity)
		{
			ArgumentOutOfRangeException.ThrowIfLessThan<int>(capacity, this.Count, "capacity");
			int prime = HashHelpers.GetPrime(capacity);
			HashSet<T>.Entry[] entries = this._entries;
			int num = (entries == null) ? 0 : entries.Length;
			if (prime >= num)
			{
				return;
			}
			int count = this._count;
			this._version++;
			this.Initialize(prime);
			HashSet<T>.Entry[] entries2 = this._entries;
			int num2 = 0;
			for (int i = 0; i < count; i++)
			{
				int hashCode = entries[i].HashCode;
				if (entries[i].Next >= -1)
				{
					HashSet<T>.Entry[] array = entries2;
					int num3 = num2;
					array[num3] = entries[i];
					ref int bucketRef = ref this.GetBucketRef(hashCode);
					array[num3].Next = bucketRef - 1;
					bucketRef = num2 + 1;
					num2++;
				}
			}
			this._count = num2;
			this._freeCount = 0;
		}

		// Token: 0x060092F2 RID: 37618 RVA: 0x0016E705 File Offset: 0x0016C905
		public static IEqualityComparer<HashSet<T>> CreateSetComparer()
		{
			return new HashSetEqualityComparer<T>();
		}

		// Token: 0x060092F3 RID: 37619 RVA: 0x0016E70C File Offset: 0x0016C90C
		private int Initialize(int capacity)
		{
			int prime = HashHelpers.GetPrime(capacity);
			int[] buckets = new int[prime];
			HashSet<T>.Entry[] entries = new HashSet<T>.Entry[prime];
			this._freeList = -1;
			this._buckets = buckets;
			this._entries = entries;
			this._fastModMultiplier = HashHelpers.GetFastModMultiplier((uint)prime);
			return prime;
		}

		// Token: 0x060092F4 RID: 37620 RVA: 0x0016E750 File Offset: 0x0016C950
		private bool AddIfNotPresent(T value, out int location)
		{
			if (this._buckets == null)
			{
				this.Initialize(0);
			}
			HashSet<T>.Entry[] entries = this._entries;
			IEqualityComparer<T> comparer = this._comparer;
			uint num = 0U;
			ref int ptr = ref Unsafe.NullRef<int>();
			int num2;
			if (typeof(T).IsValueType && comparer == null)
			{
				num2 = value.GetHashCode();
				ptr = this.GetBucketRef(num2);
				int i = ptr - 1;
				while (i >= 0)
				{
					ref HashSet<T>.Entry ptr2 = ref entries[i];
					if (ptr2.HashCode == num2 && EqualityComparer<T>.Default.Equals(ptr2.Value, value))
					{
						location = i;
						return false;
					}
					i = ptr2.Next;
					num += 1U;
					if (num > (uint)entries.Length)
					{
						ThrowHelper.ThrowInvalidOperationException_ConcurrentOperationsNotSupported();
					}
				}
			}
			else
			{
				num2 = ((value != null) ? comparer.GetHashCode(value) : 0);
				ptr = this.GetBucketRef(num2);
				int j = ptr - 1;
				while (j >= 0)
				{
					ref HashSet<T>.Entry ptr3 = ref entries[j];
					if (ptr3.HashCode == num2 && comparer.Equals(ptr3.Value, value))
					{
						location = j;
						return false;
					}
					j = ptr3.Next;
					num += 1U;
					if (num > (uint)entries.Length)
					{
						ThrowHelper.ThrowInvalidOperationException_ConcurrentOperationsNotSupported();
					}
				}
			}
			int num3;
			if (this._freeCount > 0)
			{
				num3 = this._freeList;
				this._freeCount--;
				this._freeList = -3 - entries[this._freeList].Next;
			}
			else
			{
				int count = this._count;
				if (count == entries.Length)
				{
					this.Resize();
					ptr = this.GetBucketRef(num2);
				}
				num3 = count;
				this._count = count + 1;
				entries = this._entries;
			}
			HashSet<T>.Entry[] array = entries;
			int num4 = num3;
			array[num4].HashCode = num2;
			array[num4].Next = ptr - 1;
			array[num4].Value = value;
			ptr = num3 + 1;
			this._version++;
			location = num3;
			if (!typeof(T).IsValueType && num > 100U && comparer is NonRandomizedStringEqualityComparer)
			{
				this.Resize(entries.Length, true);
				location = this.FindItemIndex(value);
			}
			return true;
		}

		// Token: 0x060092F5 RID: 37621 RVA: 0x0016E94C File Offset: 0x0016CB4C
		internal bool IsSubsetOfHashSetWithSameComparer(HashSet<T> other)
		{
			foreach (T item in this)
			{
				if (!other.Contains(item))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060092F6 RID: 37622 RVA: 0x0016E9A4 File Offset: 0x0016CBA4
		private void IntersectWithHashSetWithSameComparer(HashSet<T> other)
		{
			HashSet<T>.Entry[] entries = this._entries;
			for (int i = 0; i < this._count; i++)
			{
				ref HashSet<T>.Entry ptr = ref entries[i];
				if (ptr.Next >= -1)
				{
					T value = ptr.Value;
					if (!other.Contains(value))
					{
						this.Remove(value);
					}
				}
			}
		}

		// Token: 0x060092F7 RID: 37623 RVA: 0x0016E9F4 File Offset: 0x0016CBF4
		private unsafe void IntersectWithEnumerable(IEnumerable<T> other)
		{
			int count = this._count;
			int num = BitHelper.ToIntArrayLength(count);
			Span<int> span = new Span<int>(stackalloc byte[(UIntPtr)400], 100);
			BitHelper bitHelper = (num <= 100) ? new BitHelper(span.Slice(0, num), true) : new BitHelper(new int[num], false);
			foreach (T item in other)
			{
				int num2 = this.FindItemIndex(item);
				if (num2 >= 0)
				{
					bitHelper.MarkBit(num2);
				}
			}
			for (int i = 0; i < count; i++)
			{
				ref HashSet<T>.Entry ptr = ref this._entries[i];
				if (ptr.Next >= -1 && !bitHelper.IsMarked(i))
				{
					this.Remove(ptr.Value);
				}
			}
		}

		// Token: 0x060092F8 RID: 37624 RVA: 0x0016EADC File Offset: 0x0016CCDC
		private void SymmetricExceptWithUniqueHashSet(HashSet<T> other)
		{
			foreach (T t in other)
			{
				if (!this.Remove(t))
				{
					int num;
					this.AddIfNotPresent(t, out num);
				}
			}
		}

		// Token: 0x060092F9 RID: 37625 RVA: 0x0016EB38 File Offset: 0x0016CD38
		private unsafe void SymmetricExceptWithEnumerable(IEnumerable<T> other)
		{
			int count = this._count;
			int num = BitHelper.ToIntArrayLength(count);
			Span<int> span = new Span<int>(stackalloc byte[(UIntPtr)200], 50);
			BitHelper bitHelper = (num <= 50) ? new BitHelper(span.Slice(0, num), true) : new BitHelper(new int[num], false);
			Span<int> span2 = new Span<int>(stackalloc byte[(UIntPtr)200], 50);
			BitHelper bitHelper2 = (num <= 50) ? new BitHelper(span2.Slice(0, num), true) : new BitHelper(new int[num], false);
			foreach (T value in other)
			{
				int num2;
				if (this.AddIfNotPresent(value, out num2))
				{
					bitHelper2.MarkBit(num2);
				}
				else if (num2 < count && !bitHelper2.IsMarked(num2))
				{
					bitHelper.MarkBit(num2);
				}
			}
			for (int i = 0; i < count; i++)
			{
				if (bitHelper.IsMarked(i))
				{
					this.Remove(this._entries[i].Value);
				}
			}
		}

		// Token: 0x060092FA RID: 37626 RVA: 0x0016EC64 File Offset: 0x0016CE64
		[return: TupleElementNames(new string[]
		{
			"UniqueCount",
			"UnfoundCount"
		})]
		private unsafe ValueTuple<int, int> CheckUniqueAndUnfoundElements(IEnumerable<T> other, bool returnIfUnfound)
		{
			if (this._count == 0)
			{
				int num = 0;
				using (IEnumerator<T> enumerator = other.GetEnumerator())
				{
					if (enumerator.MoveNext())
					{
						!0 ! = enumerator.Current;
						num++;
					}
				}
				return new ValueTuple<int, int>(0, num);
			}
			int num2 = BitHelper.ToIntArrayLength(this._count);
			Span<int> span = new Span<int>(stackalloc byte[(UIntPtr)400], 100);
			BitHelper bitHelper = (num2 <= 100) ? new BitHelper(span.Slice(0, num2), true) : new BitHelper(new int[num2], false);
			int num3 = 0;
			int num4 = 0;
			foreach (T item in other)
			{
				int num5 = this.FindItemIndex(item);
				if (num5 >= 0)
				{
					if (!bitHelper.IsMarked(num5))
					{
						bitHelper.MarkBit(num5);
						num4++;
					}
				}
				else
				{
					num3++;
					if (returnIfUnfound)
					{
						break;
					}
				}
			}
			return new ValueTuple<int, int>(num4, num3);
		}

		// Token: 0x060092FB RID: 37627 RVA: 0x0016ED84 File Offset: 0x0016CF84
		internal static bool EqualityComparersAreEqual(HashSet<T> set1, HashSet<T> set2)
		{
			return set1.Comparer.Equals(set2.Comparer);
		}

		// Token: 0x060092FC RID: 37628 RVA: 0x0016ED97 File Offset: 0x0016CF97
		internal static bool EffectiveEqualityComparersAreEqual(HashSet<T> set1, HashSet<T> set2)
		{
			return set1.EffectiveComparer.Equals(set2.EffectiveComparer);
		}

		// Token: 0x04002282 RID: 8834
		private int[] _buckets;

		// Token: 0x04002283 RID: 8835
		private HashSet<T>.Entry[] _entries;

		// Token: 0x04002284 RID: 8836
		private ulong _fastModMultiplier;

		// Token: 0x04002285 RID: 8837
		private int _count;

		// Token: 0x04002286 RID: 8838
		private int _freeList;

		// Token: 0x04002287 RID: 8839
		private int _freeCount;

		// Token: 0x04002288 RID: 8840
		private int _version;

		// Token: 0x04002289 RID: 8841
		private IEqualityComparer<T> _comparer;

		// Token: 0x020009BE RID: 2494
		[Nullable(0)]
		public struct AlternateLookup<[Nullable(2)] TAlternate>
		{
			// Token: 0x060092FD RID: 37629 RVA: 0x0016EDAA File Offset: 0x0016CFAA
			internal AlternateLookup(HashSet<T> set)
			{
				this.Set = set;
			}

			// Token: 0x17001403 RID: 5123
			// (get) Token: 0x060092FE RID: 37630 RVA: 0x0016EDB3 File Offset: 0x0016CFB3
			public readonly HashSet<T> Set { get; }

			// Token: 0x060092FF RID: 37631 RVA: 0x0016EDBB File Offset: 0x0016CFBB
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			internal static bool IsCompatibleItem(HashSet<T> set)
			{
				return set._comparer is IAlternateEqualityComparer<TAlternate, T>;
			}

			// Token: 0x06009300 RID: 37632 RVA: 0x0016EDCB File Offset: 0x0016CFCB
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			internal static IAlternateEqualityComparer<TAlternate, T> GetAlternateComparer(HashSet<T> set)
			{
				return Unsafe.As<IAlternateEqualityComparer<TAlternate, T>>(set._comparer);
			}

			// Token: 0x06009301 RID: 37633 RVA: 0x0016EDD8 File Offset: 0x0016CFD8
			public bool Add(TAlternate item)
			{
				HashSet<T> set = this.Set;
				IAlternateEqualityComparer<TAlternate, T> alternateComparer = HashSet<T>.AlternateLookup<TAlternate>.GetAlternateComparer(set);
				if (set._buckets == null)
				{
					set.Initialize(0);
				}
				HashSet<T>.Entry[] entries = set._entries;
				uint num = 0U;
				ref int ptr = ref Unsafe.NullRef<int>();
				int hashCode = alternateComparer.GetHashCode(item);
				ptr = set.GetBucketRef(hashCode);
				int i = ptr - 1;
				while (i >= 0)
				{
					ref HashSet<T>.Entry ptr2 = ref entries[i];
					if (ptr2.HashCode == hashCode && alternateComparer.Equals(item, ptr2.Value))
					{
						return false;
					}
					i = ptr2.Next;
					num += 1U;
					if (num > (uint)entries.Length)
					{
						ThrowHelper.ThrowInvalidOperationException_ConcurrentOperationsNotSupported();
					}
				}
				T value = alternateComparer.Create(item);
				int num2;
				if (set._freeCount > 0)
				{
					num2 = set._freeList;
					set._freeCount--;
					set._freeList = -3 - entries[set._freeList].Next;
				}
				else
				{
					int count = set._count;
					if (count == entries.Length)
					{
						set.Resize();
						ptr = set.GetBucketRef(hashCode);
					}
					num2 = count;
					set._count = count + 1;
					entries = set._entries;
				}
				HashSet<T>.Entry[] array = entries;
				int num3 = num2;
				array[num3].HashCode = hashCode;
				array[num3].Next = ptr - 1;
				array[num3].Value = value;
				ptr = num2 + 1;
				set._version++;
				if (!typeof(T).IsValueType && num > 100U && alternateComparer is NonRandomizedStringEqualityComparer)
				{
					set.Resize(entries.Length, true);
				}
				return true;
			}

			// Token: 0x06009302 RID: 37634 RVA: 0x0016EF4C File Offset: 0x0016D14C
			public bool Remove(TAlternate item)
			{
				HashSet<T> set = this.Set;
				IAlternateEqualityComparer<TAlternate, T> alternateComparer = HashSet<T>.AlternateLookup<TAlternate>.GetAlternateComparer(set);
				if (set._buckets != null)
				{
					HashSet<T>.Entry[] entries = set._entries;
					uint num = 0U;
					int num2 = -1;
					int num3 = (item != null) ? alternateComparer.GetHashCode(item) : 0;
					ref int bucketRef = ref set.GetBucketRef(num3);
					int i = bucketRef - 1;
					while (i >= 0)
					{
						ref HashSet<T>.Entry ptr = ref entries[i];
						if (ptr.HashCode == num3 && alternateComparer.Equals(item, ptr.Value))
						{
							if (num2 < 0)
							{
								bucketRef = ptr.Next + 1;
							}
							else
							{
								entries[num2].Next = ptr.Next;
							}
							ptr.Next = -3 - set._freeList;
							if (RuntimeHelpers.IsReferenceOrContainsReferences<T>())
							{
								ptr.Value = default(T);
							}
							set._freeList = i;
							set._freeCount++;
							return true;
						}
						num2 = i;
						i = ptr.Next;
						num += 1U;
						if (num > (uint)entries.Length)
						{
							ThrowHelper.ThrowInvalidOperationException_ConcurrentOperationsNotSupported();
						}
					}
				}
				return false;
			}

			// Token: 0x06009303 RID: 37635 RVA: 0x0016F055 File Offset: 0x0016D255
			public bool Contains(TAlternate item)
			{
				return !Unsafe.IsNullRef<T>(this.FindValue(item));
			}

			// Token: 0x06009304 RID: 37636 RVA: 0x0016F068 File Offset: 0x0016D268
			public bool TryGetValue(TAlternate equalValue, [MaybeNullWhen(false)] out T actualValue)
			{
				ref readonly T ptr = ref this.FindValue(equalValue);
				if (!Unsafe.IsNullRef<T>(ref ptr))
				{
					actualValue = ptr;
					return true;
				}
				actualValue = default(T);
				return false;
			}

			// Token: 0x06009305 RID: 37637 RVA: 0x0016F09C File Offset: 0x0016D29C
			internal unsafe ref readonly T FindValue(TAlternate item)
			{
				HashSet<T> set = this.Set;
				IAlternateEqualityComparer<TAlternate, T> alternateComparer = HashSet<T>.AlternateLookup<TAlternate>.GetAlternateComparer(set);
				ref HashSet<T>.Entry ptr = ref Unsafe.NullRef<HashSet<T>.Entry>();
				if (set._buckets != null)
				{
					int hashCode = alternateComparer.GetHashCode(item);
					int i = *set.GetBucketRef(hashCode);
					HashSet<T>.Entry[] entries = set._entries;
					uint num = 0U;
					i--;
					while (i < entries.Length)
					{
						ptr = ref entries[i];
						if (ptr.HashCode != hashCode || !alternateComparer.Equals(item, ptr.Value))
						{
							i = ptr.Next;
							num += 1U;
							if (num <= (uint)entries.Length)
							{
								continue;
							}
							ThrowHelper.ThrowInvalidOperationException_ConcurrentOperationsNotSupported();
						}
						return ref ptr.Value;
					}
				}
				return Unsafe.NullRef<T>();
			}
		}

		// Token: 0x020009BF RID: 2495
		private struct Entry
		{
			// Token: 0x0400228B RID: 8843
			public int HashCode;

			// Token: 0x0400228C RID: 8844
			public int Next;

			// Token: 0x0400228D RID: 8845
			public T Value;
		}

		// Token: 0x020009C0 RID: 2496
		[NullableContext(0)]
		public struct Enumerator : IEnumerator<!0>, IDisposable, IEnumerator
		{
			// Token: 0x06009306 RID: 37638 RVA: 0x0016F140 File Offset: 0x0016D340
			internal Enumerator(HashSet<T> hashSet)
			{
				this._hashSet = hashSet;
				this._version = hashSet._version;
				this._index = 0;
				this._current = default(T);
			}

			// Token: 0x06009307 RID: 37639 RVA: 0x0016F168 File Offset: 0x0016D368
			public bool MoveNext()
			{
				if (this._version != this._hashSet._version)
				{
					ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion();
				}
				while (this._index < this._hashSet._count)
				{
					HashSet<T>.Entry[] entries = this._hashSet._entries;
					int index = this._index;
					this._index = index + 1;
					ref HashSet<T>.Entry ptr = ref entries[index];
					if (ptr.Next >= -1)
					{
						this._current = ptr.Value;
						return true;
					}
				}
				this._index = this._hashSet._count + 1;
				this._current = default(T);
				return false;
			}

			// Token: 0x17001404 RID: 5124
			// (get) Token: 0x06009308 RID: 37640 RVA: 0x0016F1FB File Offset: 0x0016D3FB
			[Nullable(1)]
			public T Current
			{
				[NullableContext(1)]
				get
				{
					return this._current;
				}
			}

			// Token: 0x06009309 RID: 37641 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public void Dispose()
			{
			}

			// Token: 0x17001405 RID: 5125
			// (get) Token: 0x0600930A RID: 37642 RVA: 0x0016F203 File Offset: 0x0016D403
			[Nullable(2)]
			object IEnumerator.Current
			{
				get
				{
					if (this._index == 0 || this._index == this._hashSet._count + 1)
					{
						ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumOpCantHappen();
					}
					return this._current;
				}
			}

			// Token: 0x0600930B RID: 37643 RVA: 0x0016F232 File Offset: 0x0016D432
			void IEnumerator.Reset()
			{
				if (this._version != this._hashSet._version)
				{
					ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion();
				}
				this._index = 0;
				this._current = default(T);
			}

			// Token: 0x0400228E RID: 8846
			private readonly HashSet<T> _hashSet;

			// Token: 0x0400228F RID: 8847
			private readonly int _version;

			// Token: 0x04002290 RID: 8848
			private int _index;

			// Token: 0x04002291 RID: 8849
			private T _current;
		}
	}
}
