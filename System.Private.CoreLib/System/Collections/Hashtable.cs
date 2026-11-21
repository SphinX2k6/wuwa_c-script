using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;

namespace System.Collections
{
	// Token: 0x0200096E RID: 2414
	[NullableContext(1)]
	[Nullable(0)]
	[DebuggerTypeProxy(typeof(Hashtable.HashtableDebugView))]
	[DebuggerDisplay("Count = {Count}")]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class Hashtable : IDictionary, ICollection, IEnumerable, ISerializable, IDeserializationCallback, ICloneable
	{
		// Token: 0x1700134E RID: 4942
		// (get) Token: 0x06009013 RID: 36883 RVA: 0x00164089 File Offset: 0x00162289
		// (set) Token: 0x06009014 RID: 36884 RVA: 0x001640C0 File Offset: 0x001622C0
		[Nullable(2)]
		[Obsolete("Hashtable.hcp has been deprecated. Use the EqualityComparer property instead.")]
		protected IHashCodeProvider hcp
		{
			[NullableContext(2)]
			get
			{
				if (this._keycomparer is CompatibleComparer)
				{
					return ((CompatibleComparer)this._keycomparer).HashCodeProvider;
				}
				if (this._keycomparer == null)
				{
					return null;
				}
				throw new ArgumentException(SR.Arg_CannotMixComparisonInfrastructure);
			}
			[NullableContext(2)]
			set
			{
				CompatibleComparer compatibleComparer = this._keycomparer as CompatibleComparer;
				if (compatibleComparer != null)
				{
					this._keycomparer = new CompatibleComparer(value, compatibleComparer.Comparer);
					return;
				}
				if (this._keycomparer == null)
				{
					this._keycomparer = new CompatibleComparer(value, null);
					return;
				}
				throw new ArgumentException(SR.Arg_CannotMixComparisonInfrastructure);
			}
		}

		// Token: 0x1700134F RID: 4943
		// (get) Token: 0x06009015 RID: 36885 RVA: 0x0016410F File Offset: 0x0016230F
		// (set) Token: 0x06009016 RID: 36886 RVA: 0x00164144 File Offset: 0x00162344
		[Nullable(2)]
		[Obsolete("Hashtable.comparer has been deprecated. Use the KeyComparer properties instead.")]
		protected IComparer comparer
		{
			[NullableContext(2)]
			get
			{
				if (this._keycomparer is CompatibleComparer)
				{
					return ((CompatibleComparer)this._keycomparer).Comparer;
				}
				if (this._keycomparer == null)
				{
					return null;
				}
				throw new ArgumentException(SR.Arg_CannotMixComparisonInfrastructure);
			}
			[NullableContext(2)]
			set
			{
				CompatibleComparer compatibleComparer = this._keycomparer as CompatibleComparer;
				if (compatibleComparer != null)
				{
					this._keycomparer = new CompatibleComparer(compatibleComparer.HashCodeProvider, value);
					return;
				}
				if (this._keycomparer == null)
				{
					this._keycomparer = new CompatibleComparer(null, value);
					return;
				}
				throw new ArgumentException(SR.Arg_CannotMixComparisonInfrastructure);
			}
		}

		// Token: 0x17001350 RID: 4944
		// (get) Token: 0x06009017 RID: 36887 RVA: 0x00164193 File Offset: 0x00162393
		[Nullable(2)]
		protected IEqualityComparer EqualityComparer
		{
			[NullableContext(2)]
			get
			{
				return this._keycomparer;
			}
		}

		// Token: 0x06009018 RID: 36888 RVA: 0x00005ACC File Offset: 0x00003CCC
		internal Hashtable(bool _)
		{
		}

		// Token: 0x06009019 RID: 36889 RVA: 0x0016419B File Offset: 0x0016239B
		public Hashtable() : this(0, 1f)
		{
		}

		// Token: 0x0600901A RID: 36890 RVA: 0x001641A9 File Offset: 0x001623A9
		public Hashtable(int capacity) : this(capacity, 1f)
		{
		}

		// Token: 0x0600901B RID: 36891 RVA: 0x001641B8 File Offset: 0x001623B8
		public Hashtable(int capacity, float loadFactor)
		{
			ArgumentOutOfRangeException.ThrowIfNegative<int>(capacity, "capacity");
			if (loadFactor < 0.1f || loadFactor > 1f)
			{
				throw new ArgumentOutOfRangeException("loadFactor", SR.ArgumentOutOfRange_HashtableLoadFactor);
			}
			this._loadFactor = 0.72f * loadFactor;
			double num = (double)((float)capacity / this._loadFactor);
			if (num > 2147483647.0)
			{
				throw new ArgumentException(SR.Arg_HTCapacityOverflow, "capacity");
			}
			int num2 = (num > 3.0) ? HashHelpers.GetPrime((int)num) : 3;
			this._buckets = new Hashtable.Bucket[num2];
			this._loadsize = (int)(this._loadFactor * (float)num2);
			this._isWriterInProgress = false;
		}

		// Token: 0x0600901C RID: 36892 RVA: 0x00164266 File Offset: 0x00162466
		[NullableContext(2)]
		public Hashtable(int capacity, float loadFactor, IEqualityComparer equalityComparer) : this(capacity, loadFactor)
		{
			this._keycomparer = equalityComparer;
		}

		// Token: 0x0600901D RID: 36893 RVA: 0x00164277 File Offset: 0x00162477
		[NullableContext(2)]
		[Obsolete("This constructor has been deprecated. Use Hashtable(IEqualityComparer) instead.")]
		public Hashtable(IHashCodeProvider hcp, IComparer comparer) : this(0, 1f, hcp, comparer)
		{
		}

		// Token: 0x0600901E RID: 36894 RVA: 0x00164287 File Offset: 0x00162487
		[NullableContext(2)]
		public Hashtable(IEqualityComparer equalityComparer) : this(0, 1f, equalityComparer)
		{
		}

		// Token: 0x0600901F RID: 36895 RVA: 0x00164296 File Offset: 0x00162496
		[NullableContext(2)]
		[Obsolete("This constructor has been deprecated. Use Hashtable(int, IEqualityComparer) instead.")]
		public Hashtable(int capacity, IHashCodeProvider hcp, IComparer comparer) : this(capacity, 1f, hcp, comparer)
		{
		}

		// Token: 0x06009020 RID: 36896 RVA: 0x001642A6 File Offset: 0x001624A6
		[NullableContext(2)]
		public Hashtable(int capacity, IEqualityComparer equalityComparer) : this(capacity, 1f, equalityComparer)
		{
		}

		// Token: 0x06009021 RID: 36897 RVA: 0x001642B5 File Offset: 0x001624B5
		public Hashtable(IDictionary d) : this(d, 1f)
		{
		}

		// Token: 0x06009022 RID: 36898 RVA: 0x001642C3 File Offset: 0x001624C3
		public Hashtable(IDictionary d, float loadFactor) : this(d, loadFactor, null)
		{
		}

		// Token: 0x06009023 RID: 36899 RVA: 0x001642CE File Offset: 0x001624CE
		[NullableContext(2)]
		[Obsolete("This constructor has been deprecated. Use Hashtable(IDictionary, IEqualityComparer) instead.")]
		public Hashtable([Nullable(1)] IDictionary d, IHashCodeProvider hcp, IComparer comparer) : this(d, 1f, hcp, comparer)
		{
		}

		// Token: 0x06009024 RID: 36900 RVA: 0x001642DE File Offset: 0x001624DE
		public Hashtable(IDictionary d, [Nullable(2)] IEqualityComparer equalityComparer) : this(d, 1f, equalityComparer)
		{
		}

		// Token: 0x06009025 RID: 36901 RVA: 0x001642ED File Offset: 0x001624ED
		[NullableContext(2)]
		[Obsolete("This constructor has been deprecated. Use Hashtable(int, float, IEqualityComparer) instead.")]
		public Hashtable(int capacity, float loadFactor, IHashCodeProvider hcp, IComparer comparer) : this(capacity, loadFactor)
		{
			if (hcp != null || comparer != null)
			{
				this._keycomparer = new CompatibleComparer(hcp, comparer);
			}
		}

		// Token: 0x06009026 RID: 36902 RVA: 0x0016430C File Offset: 0x0016250C
		[NullableContext(2)]
		[Obsolete("This constructor has been deprecated. Use Hashtable(IDictionary, float, IEqualityComparer) instead.")]
		public Hashtable([Nullable(1)] IDictionary d, float loadFactor, IHashCodeProvider hcp, IComparer comparer) : this((d != null) ? d.Count : 0, loadFactor, hcp, comparer)
		{
			ArgumentNullException.ThrowIfNull(d, "d");
			IDictionaryEnumerator enumerator = d.GetEnumerator();
			while (enumerator.MoveNext())
			{
				this.Add(enumerator.Key, enumerator.Value);
			}
		}

		// Token: 0x06009027 RID: 36903 RVA: 0x00164360 File Offset: 0x00162560
		public Hashtable(IDictionary d, float loadFactor, [Nullable(2)] IEqualityComparer equalityComparer) : this((d != null) ? d.Count : 0, loadFactor, equalityComparer)
		{
			ArgumentNullException.ThrowIfNull(d, "d");
			IDictionaryEnumerator enumerator = d.GetEnumerator();
			while (enumerator.MoveNext())
			{
				this.Add(enumerator.Key, enumerator.Value);
			}
		}

		// Token: 0x06009028 RID: 36904 RVA: 0x001643AF File Offset: 0x001625AF
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected Hashtable(SerializationInfo info, StreamingContext context)
		{
			HashHelpers.SerializationInfoTable.Add(this, info);
		}

		// Token: 0x06009029 RID: 36905 RVA: 0x001643C4 File Offset: 0x001625C4
		private uint InitHash(object key, int hashsize, out uint seed, out uint incr)
		{
			uint num = (uint)(this.GetHash(key) & int.MaxValue);
			seed = num;
			incr = 1U + seed * 101U % (uint)(hashsize - 1);
			return num;
		}

		// Token: 0x0600902A RID: 36906 RVA: 0x001643F1 File Offset: 0x001625F1
		public virtual void Add(object key, [Nullable(2)] object value)
		{
			this.Insert(key, value, true);
		}

		// Token: 0x0600902B RID: 36907 RVA: 0x001643FC File Offset: 0x001625FC
		public virtual void Clear()
		{
			if (this._count == 0 && this._occupancy == 0)
			{
				return;
			}
			this._isWriterInProgress = true;
			for (int i = 0; i < this._buckets.Length; i++)
			{
				this._buckets[i].hash_coll = 0;
				this._buckets[i].key = null;
				this._buckets[i].val = null;
			}
			this._count = 0;
			this._occupancy = 0;
			this.UpdateVersion();
			this._isWriterInProgress = false;
		}

		// Token: 0x0600902C RID: 36908 RVA: 0x0016448C File Offset: 0x0016268C
		public virtual object Clone()
		{
			Hashtable.Bucket[] buckets = this._buckets;
			Hashtable hashtable = new Hashtable(this._count, this._keycomparer);
			hashtable._version = this._version;
			hashtable._loadFactor = this._loadFactor;
			hashtable._count = 0;
			int i = buckets.Length;
			while (i > 0)
			{
				i--;
				object key = buckets[i].key;
				if (key != null && key != buckets)
				{
					hashtable[key] = buckets[i].val;
				}
			}
			return hashtable;
		}

		// Token: 0x0600902D RID: 36909 RVA: 0x0016450B File Offset: 0x0016270B
		public virtual bool Contains(object key)
		{
			return this.ContainsKey(key);
		}

		// Token: 0x0600902E RID: 36910 RVA: 0x00164514 File Offset: 0x00162714
		public virtual bool ContainsKey(object key)
		{
			ArgumentNullException.ThrowIfNull(key, "key");
			Hashtable.Bucket[] buckets = this._buckets;
			uint num2;
			uint num3;
			uint num = this.InitHash(key, buckets.Length, out num2, out num3);
			int num4 = 0;
			int num5 = (int)(num2 % (uint)buckets.Length);
			for (;;)
			{
				Hashtable.Bucket bucket = buckets[num5];
				if (bucket.key == null)
				{
					break;
				}
				if ((long)(bucket.hash_coll & 2147483647) == (long)((ulong)num) && this.KeyEquals(bucket.key, key))
				{
					return true;
				}
				num5 = (int)(((long)num5 + (long)((ulong)num3)) % (long)((ulong)buckets.Length));
				if (bucket.hash_coll >= 0 || ++num4 >= buckets.Length)
				{
					return false;
				}
			}
			return false;
		}

		// Token: 0x0600902F RID: 36911 RVA: 0x001645AC File Offset: 0x001627AC
		[NullableContext(2)]
		public virtual bool ContainsValue(object value)
		{
			if (value == null)
			{
				int num = this._buckets.Length;
				while (--num >= 0)
				{
					if (this._buckets[num].key != null && this._buckets[num].key != this._buckets && this._buckets[num].val == null)
					{
						return true;
					}
				}
			}
			else
			{
				int num2 = this._buckets.Length;
				while (--num2 >= 0)
				{
					object val = this._buckets[num2].val;
					if (val != null && val.Equals(value))
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06009030 RID: 36912 RVA: 0x00164648 File Offset: 0x00162848
		private void CopyKeys(Array array, int arrayIndex)
		{
			Hashtable.Bucket[] buckets = this._buckets;
			int num = buckets.Length;
			while (--num >= 0)
			{
				object key = buckets[num].key;
				if (key != null && key != this._buckets)
				{
					array.SetValue(key, arrayIndex++);
				}
			}
		}

		// Token: 0x06009031 RID: 36913 RVA: 0x00164690 File Offset: 0x00162890
		private void CopyEntries(Array array, int arrayIndex)
		{
			Hashtable.Bucket[] buckets = this._buckets;
			int num = buckets.Length;
			while (--num >= 0)
			{
				object key = buckets[num].key;
				if (key != null && key != this._buckets)
				{
					DictionaryEntry dictionaryEntry = new DictionaryEntry(key, buckets[num].val);
					array.SetValue(dictionaryEntry, arrayIndex++);
				}
			}
		}

		// Token: 0x06009032 RID: 36914 RVA: 0x001646F4 File Offset: 0x001628F4
		public virtual void CopyTo(Array array, int arrayIndex)
		{
			ArgumentNullException.ThrowIfNull(array, "array");
			if (array.Rank != 1)
			{
				throw new ArgumentException(SR.Arg_RankMultiDimNotSupported, "array");
			}
			ArgumentOutOfRangeException.ThrowIfNegative<int>(arrayIndex, "arrayIndex");
			if (array.Length - arrayIndex < this.Count)
			{
				throw new ArgumentException(SR.Arg_ArrayPlusOffTooSmall);
			}
			this.CopyEntries(array, arrayIndex);
		}

		// Token: 0x06009033 RID: 36915 RVA: 0x00164754 File Offset: 0x00162954
		internal virtual DebugViewDictionaryItem<object, object>[] ToDebugViewDictionaryItemArray()
		{
			DebugViewDictionaryItem<object, object>[] array = new DebugViewDictionaryItem<object, object>[this._count];
			int num = 0;
			Hashtable.Bucket[] buckets = this._buckets;
			int num2 = buckets.Length;
			while (--num2 >= 0)
			{
				object key = buckets[num2].key;
				if (key != null && key != this._buckets)
				{
					array[num++] = new DebugViewDictionaryItem<object, object>(key, buckets[num2].val);
				}
			}
			return array;
		}

		// Token: 0x06009034 RID: 36916 RVA: 0x001647C0 File Offset: 0x001629C0
		private void CopyValues(Array array, int arrayIndex)
		{
			Hashtable.Bucket[] buckets = this._buckets;
			int num = buckets.Length;
			while (--num >= 0)
			{
				object key = buckets[num].key;
				if (key != null && key != this._buckets)
				{
					array.SetValue(buckets[num].val, arrayIndex++);
				}
			}
		}

		// Token: 0x17001351 RID: 4945
		[Nullable(2)]
		public virtual object this[object key]
		{
			[return: Nullable(2)]
			get
			{
				ArgumentNullException.ThrowIfNull(key, "key");
				Hashtable.Bucket[] buckets = this._buckets;
				uint num2;
				uint num3;
				uint num = this.InitHash(key, buckets.Length, out num2, out num3);
				int num4 = 0;
				int num5 = (int)(num2 % (uint)buckets.Length);
				Hashtable.Bucket bucket;
				for (;;)
				{
					SpinWait spinWait = default(SpinWait);
					for (;;)
					{
						int version = this._version;
						bucket = buckets[num5];
						if (!this._isWriterInProgress && version == this._version)
						{
							break;
						}
						spinWait.SpinOnce();
					}
					if (bucket.key == null)
					{
						break;
					}
					if ((long)(bucket.hash_coll & 2147483647) == (long)((ulong)num) && this.KeyEquals(bucket.key, key))
					{
						goto Block_4;
					}
					num5 = (int)(((long)num5 + (long)((ulong)num3)) % (long)((ulong)buckets.Length));
					if (bucket.hash_coll >= 0 || ++num4 >= buckets.Length)
					{
						goto IL_C2;
					}
				}
				return null;
				Block_4:
				return bucket.val;
				IL_C2:
				return null;
			}
			[param: Nullable(2)]
			set
			{
				this.Insert(key, value, false);
			}
		}

		// Token: 0x06009037 RID: 36919 RVA: 0x001648F0 File Offset: 0x00162AF0
		private void expand()
		{
			int newsize = HashHelpers.ExpandPrime(this._buckets.Length);
			this.rehash(newsize);
		}

		// Token: 0x06009038 RID: 36920 RVA: 0x00164912 File Offset: 0x00162B12
		private void rehash()
		{
			this.rehash(this._buckets.Length);
		}

		// Token: 0x06009039 RID: 36921 RVA: 0x00164922 File Offset: 0x00162B22
		private void UpdateVersion()
		{
			this._version++;
		}

		// Token: 0x0600903A RID: 36922 RVA: 0x00164938 File Offset: 0x00162B38
		private void rehash(int newsize)
		{
			this._occupancy = 0;
			Hashtable.Bucket[] array = new Hashtable.Bucket[newsize];
			for (int i = 0; i < this._buckets.Length; i++)
			{
				Hashtable.Bucket bucket = this._buckets[i];
				if (bucket.key != null && bucket.key != this._buckets)
				{
					int hashcode = bucket.hash_coll & int.MaxValue;
					this.putEntry(array, bucket.key, bucket.val, hashcode);
				}
			}
			this._isWriterInProgress = true;
			this._buckets = array;
			this._loadsize = (int)(this._loadFactor * (float)newsize);
			this.UpdateVersion();
			this._isWriterInProgress = false;
		}

		// Token: 0x0600903B RID: 36923 RVA: 0x001649D9 File Offset: 0x00162BD9
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new Hashtable.HashtableEnumerator(this, 3);
		}

		// Token: 0x0600903C RID: 36924 RVA: 0x001649D9 File Offset: 0x00162BD9
		public virtual IDictionaryEnumerator GetEnumerator()
		{
			return new Hashtable.HashtableEnumerator(this, 3);
		}

		// Token: 0x0600903D RID: 36925 RVA: 0x001649E2 File Offset: 0x00162BE2
		protected virtual int GetHash(object key)
		{
			if (this._keycomparer != null)
			{
				return this._keycomparer.GetHashCode(key);
			}
			return key.GetHashCode();
		}

		// Token: 0x17001352 RID: 4946
		// (get) Token: 0x0600903E RID: 36926 RVA: 0x00007B65 File Offset: 0x00005D65
		public virtual bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17001353 RID: 4947
		// (get) Token: 0x0600903F RID: 36927 RVA: 0x00007B65 File Offset: 0x00005D65
		public virtual bool IsFixedSize
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17001354 RID: 4948
		// (get) Token: 0x06009040 RID: 36928 RVA: 0x00007B65 File Offset: 0x00005D65
		public virtual bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06009041 RID: 36929 RVA: 0x001649FF File Offset: 0x00162BFF
		protected virtual bool KeyEquals([Nullable(2)] object item, object key)
		{
			if (this._buckets == item)
			{
				return false;
			}
			if (item == key)
			{
				return true;
			}
			if (this._keycomparer != null)
			{
				return this._keycomparer.Equals(item, key);
			}
			return item != null && item.Equals(key);
		}

		// Token: 0x17001355 RID: 4949
		// (get) Token: 0x06009042 RID: 36930 RVA: 0x00164A34 File Offset: 0x00162C34
		public virtual ICollection Keys
		{
			get
			{
				ICollection result;
				if ((result = this._keys) == null)
				{
					result = (this._keys = new Hashtable.KeyCollection(this));
				}
				return result;
			}
		}

		// Token: 0x17001356 RID: 4950
		// (get) Token: 0x06009043 RID: 36931 RVA: 0x00164A5C File Offset: 0x00162C5C
		public virtual ICollection Values
		{
			get
			{
				ICollection result;
				if ((result = this._values) == null)
				{
					result = (this._values = new Hashtable.ValueCollection(this));
				}
				return result;
			}
		}

		// Token: 0x06009044 RID: 36932 RVA: 0x00164A84 File Offset: 0x00162C84
		private void Insert(object key, object nvalue, bool add)
		{
			ArgumentNullException.ThrowIfNull(key, "key");
			if (this._count >= this._loadsize)
			{
				this.expand();
			}
			else if (this._occupancy > this._loadsize && this._count > 100)
			{
				this.rehash();
			}
			uint num2;
			uint num3;
			uint num = this.InitHash(key, this._buckets.Length, out num2, out num3);
			int num4 = 0;
			int num5 = -1;
			int num6 = (int)(num2 % (uint)this._buckets.Length);
			for (;;)
			{
				if (num5 == -1 && this._buckets[num6].key == this._buckets && this._buckets[num6].hash_coll < 0)
				{
					num5 = num6;
				}
				if (this._buckets[num6].key == null || (this._buckets[num6].key == this._buckets && ((long)this._buckets[num6].hash_coll & (long)((ulong)-2147483648)) == 0L))
				{
					break;
				}
				if ((long)(this._buckets[num6].hash_coll & 2147483647) == (long)((ulong)num) && this.KeyEquals(this._buckets[num6].key, key))
				{
					goto Block_11;
				}
				if (num5 == -1 && this._buckets[num6].hash_coll >= 0)
				{
					Hashtable.Bucket[] buckets = this._buckets;
					int num7 = num6;
					buckets[num7].hash_coll = (buckets[num7].hash_coll | int.MinValue);
					this._occupancy++;
				}
				num6 = (int)(((long)num6 + (long)((ulong)num3)) % (long)((ulong)this._buckets.Length));
				if (++num4 >= this._buckets.Length)
				{
					goto Block_15;
				}
			}
			if (num5 != -1)
			{
				num6 = num5;
			}
			this._isWriterInProgress = true;
			this._buckets[num6].val = nvalue;
			this._buckets[num6].key = key;
			Hashtable.Bucket[] buckets2 = this._buckets;
			int num8 = num6;
			buckets2[num8].hash_coll = (buckets2[num8].hash_coll | (int)num);
			this._count++;
			this.UpdateVersion();
			this._isWriterInProgress = false;
			return;
			Block_11:
			if (add)
			{
				throw new ArgumentException(SR.Format(SR.Argument_AddingDuplicate__, this._buckets[num6].key, key));
			}
			this._isWriterInProgress = true;
			this._buckets[num6].val = nvalue;
			this.UpdateVersion();
			this._isWriterInProgress = false;
			return;
			Block_15:
			if (num5 != -1)
			{
				this._isWriterInProgress = true;
				this._buckets[num5].val = nvalue;
				this._buckets[num5].key = key;
				Hashtable.Bucket[] buckets3 = this._buckets;
				int num9 = num5;
				buckets3[num9].hash_coll = (buckets3[num9].hash_coll | (int)num);
				this._count++;
				this.UpdateVersion();
				this._isWriterInProgress = false;
				return;
			}
			throw new InvalidOperationException(SR.InvalidOperation_HashInsertFailed);
		}

		// Token: 0x06009045 RID: 36933 RVA: 0x00164D4C File Offset: 0x00162F4C
		private void putEntry(Hashtable.Bucket[] newBuckets, object key, object nvalue, int hashcode)
		{
			uint num = (uint)(1 + hashcode * 101 % (newBuckets.Length - 1));
			int num2 = hashcode % newBuckets.Length;
			while (newBuckets[num2].key != null && newBuckets[num2].key != this._buckets)
			{
				if (newBuckets[num2].hash_coll >= 0)
				{
					int num3 = num2;
					newBuckets[num3].hash_coll = (newBuckets[num3].hash_coll | int.MinValue);
					this._occupancy++;
				}
				num2 = (int)(((long)num2 + (long)((ulong)num)) % (long)((ulong)newBuckets.Length));
			}
			newBuckets[num2].val = nvalue;
			newBuckets[num2].key = key;
			int num4 = num2;
			newBuckets[num4].hash_coll = (newBuckets[num4].hash_coll | hashcode);
		}

		// Token: 0x06009046 RID: 36934 RVA: 0x00164E00 File Offset: 0x00163000
		public virtual void Remove(object key)
		{
			ArgumentNullException.ThrowIfNull(key, "key");
			uint num2;
			uint num3;
			uint num = this.InitHash(key, this._buckets.Length, out num2, out num3);
			int num4 = 0;
			int num5 = (int)(num2 % (uint)this._buckets.Length);
			for (;;)
			{
				Hashtable.Bucket bucket = this._buckets[num5];
				if ((long)(bucket.hash_coll & 2147483647) == (long)((ulong)num) && this.KeyEquals(bucket.key, key))
				{
					break;
				}
				num5 = (int)(((long)num5 + (long)((ulong)num3)) % (long)((ulong)this._buckets.Length));
				if (bucket.hash_coll >= 0 || ++num4 >= this._buckets.Length)
				{
					return;
				}
			}
			this._isWriterInProgress = true;
			Hashtable.Bucket[] buckets = this._buckets;
			int num6 = num5;
			buckets[num6].hash_coll = (buckets[num6].hash_coll & int.MinValue);
			if (this._buckets[num5].hash_coll != 0)
			{
				this._buckets[num5].key = this._buckets;
			}
			else
			{
				this._buckets[num5].key = null;
			}
			this._buckets[num5].val = null;
			this._count--;
			this.UpdateVersion();
			this._isWriterInProgress = false;
		}

		// Token: 0x17001357 RID: 4951
		// (get) Token: 0x06009047 RID: 36935 RVA: 0x00007B62 File Offset: 0x00005D62
		public virtual object SyncRoot
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17001358 RID: 4952
		// (get) Token: 0x06009048 RID: 36936 RVA: 0x00164F36 File Offset: 0x00163136
		public virtual int Count
		{
			get
			{
				return this._count;
			}
		}

		// Token: 0x06009049 RID: 36937 RVA: 0x00164F3E File Offset: 0x0016313E
		public static Hashtable Synchronized(Hashtable table)
		{
			ArgumentNullException.ThrowIfNull(table, "table");
			return new Hashtable.SyncHashtable(table);
		}

		// Token: 0x0600904A RID: 36938 RVA: 0x00164F54 File Offset: 0x00163154
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			ArgumentNullException.ThrowIfNull(info, "info");
			object syncRoot = this.SyncRoot;
			lock (syncRoot)
			{
				int version = this._version;
				info.AddValue("LoadFactor", this._loadFactor);
				info.AddValue("Version", this._version);
				IEqualityComparer keycomparer = this._keycomparer;
				if (keycomparer == null)
				{
					info.AddValue("Comparer", null, typeof(IComparer));
					info.AddValue("HashCodeProvider", null, typeof(IHashCodeProvider));
				}
				else if (keycomparer is CompatibleComparer)
				{
					CompatibleComparer compatibleComparer = keycomparer as CompatibleComparer;
					info.AddValue("Comparer", compatibleComparer.Comparer, typeof(IComparer));
					info.AddValue("HashCodeProvider", compatibleComparer.HashCodeProvider, typeof(IHashCodeProvider));
				}
				else
				{
					info.AddValue("KeyComparer", keycomparer, typeof(IEqualityComparer));
				}
				info.AddValue("HashSize", this._buckets.Length);
				object[] array = new object[this._count];
				object[] array2 = new object[this._count];
				this.CopyKeys(array, 0);
				this.CopyValues(array2, 0);
				info.AddValue("Keys", array, typeof(object[]));
				info.AddValue("Values", array2, typeof(object[]));
				if (this._version != version)
				{
					throw new InvalidOperationException(SR.InvalidOperation_EnumFailedVersion);
				}
			}
		}

		// Token: 0x0600904B RID: 36939 RVA: 0x001650F0 File Offset: 0x001632F0
		[NullableContext(2)]
		public virtual void OnDeserialization(object sender)
		{
			if (this._buckets != null)
			{
				return;
			}
			SerializationInfo serializationInfo;
			HashHelpers.SerializationInfoTable.TryGetValue(this, out serializationInfo);
			if (serializationInfo == null)
			{
				throw new SerializationException(SR.Serialization_InvalidOnDeser);
			}
			int num = 0;
			IComparer comparer = null;
			IHashCodeProvider hashCodeProvider = null;
			object[] array = null;
			object[] array2 = null;
			SerializationInfoEnumerator enumerator = serializationInfo.GetEnumerator();
			while (enumerator.MoveNext())
			{
				string name = enumerator.Name;
				if (name != null)
				{
					int length = name.Length;
					switch (length)
					{
					case 4:
						if (name == "Keys")
						{
							array = (object[])serializationInfo.GetValue("Keys", typeof(object[]));
						}
						break;
					case 5:
					case 7:
					case 9:
						break;
					case 6:
						if (name == "Values")
						{
							array2 = (object[])serializationInfo.GetValue("Values", typeof(object[]));
						}
						break;
					case 8:
					{
						char c = name[0];
						if (c != 'C')
						{
							if (c == 'H')
							{
								if (name == "HashSize")
								{
									num = serializationInfo.GetInt32("HashSize");
								}
							}
						}
						else if (name == "Comparer")
						{
							comparer = (IComparer)serializationInfo.GetValue("Comparer", typeof(IComparer));
						}
						break;
					}
					case 10:
						if (name == "LoadFactor")
						{
							this._loadFactor = serializationInfo.GetSingle("LoadFactor");
						}
						break;
					case 11:
						if (name == "KeyComparer")
						{
							this._keycomparer = (IEqualityComparer)serializationInfo.GetValue("KeyComparer", typeof(IEqualityComparer));
						}
						break;
					default:
						if (length == 16)
						{
							if (name == "HashCodeProvider")
							{
								hashCodeProvider = (IHashCodeProvider)serializationInfo.GetValue("HashCodeProvider", typeof(IHashCodeProvider));
							}
						}
						break;
					}
				}
			}
			this._loadsize = (int)(this._loadFactor * (float)num);
			if (this._keycomparer == null && (comparer != null || hashCodeProvider != null))
			{
				this._keycomparer = new CompatibleComparer(hashCodeProvider, comparer);
			}
			this._buckets = new Hashtable.Bucket[num];
			if (array == null)
			{
				throw new SerializationException(SR.Serialization_MissingKeys);
			}
			if (array2 == null)
			{
				throw new SerializationException(SR.Serialization_MissingValues);
			}
			if (array.Length != array2.Length)
			{
				throw new SerializationException(SR.Serialization_KeyValueDifferentSizes);
			}
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] == null)
				{
					throw new SerializationException(SR.Serialization_NullKey);
				}
				this.Insert(array[i], array2[i], true);
			}
			this._version = serializationInfo.GetInt32("Version");
			HashHelpers.SerializationInfoTable.Remove(this);
		}

		// Token: 0x040021F8 RID: 8696
		private Hashtable.Bucket[] _buckets;

		// Token: 0x040021F9 RID: 8697
		private int _count;

		// Token: 0x040021FA RID: 8698
		private int _occupancy;

		// Token: 0x040021FB RID: 8699
		private int _loadsize;

		// Token: 0x040021FC RID: 8700
		private float _loadFactor;

		// Token: 0x040021FD RID: 8701
		private volatile int _version;

		// Token: 0x040021FE RID: 8702
		private volatile bool _isWriterInProgress;

		// Token: 0x040021FF RID: 8703
		private ICollection _keys;

		// Token: 0x04002200 RID: 8704
		private ICollection _values;

		// Token: 0x04002201 RID: 8705
		private IEqualityComparer _keycomparer;

		// Token: 0x0200096F RID: 2415
		private struct Bucket
		{
			// Token: 0x04002202 RID: 8706
			public object key;

			// Token: 0x04002203 RID: 8707
			public object val;

			// Token: 0x04002204 RID: 8708
			public int hash_coll;
		}

		// Token: 0x02000970 RID: 2416
		private sealed class KeyCollection : ICollection, IEnumerable
		{
			// Token: 0x0600904C RID: 36940 RVA: 0x001653C2 File Offset: 0x001635C2
			internal KeyCollection(Hashtable hashtable)
			{
				this._hashtable = hashtable;
			}

			// Token: 0x0600904D RID: 36941 RVA: 0x001653D4 File Offset: 0x001635D4
			public void CopyTo(Array array, int arrayIndex)
			{
				ArgumentNullException.ThrowIfNull(array, "array");
				if (array.Rank != 1)
				{
					throw new ArgumentException(SR.Arg_RankMultiDimNotSupported, "array");
				}
				ArgumentOutOfRangeException.ThrowIfNegative<int>(arrayIndex, "arrayIndex");
				if (array.Length - arrayIndex < this._hashtable._count)
				{
					throw new ArgumentException(SR.Arg_ArrayPlusOffTooSmall);
				}
				this._hashtable.CopyKeys(array, arrayIndex);
			}

			// Token: 0x0600904E RID: 36942 RVA: 0x0016543D File Offset: 0x0016363D
			public IEnumerator GetEnumerator()
			{
				return new Hashtable.HashtableEnumerator(this._hashtable, 1);
			}

			// Token: 0x17001359 RID: 4953
			// (get) Token: 0x0600904F RID: 36943 RVA: 0x0016544B File Offset: 0x0016364B
			public bool IsSynchronized
			{
				get
				{
					return this._hashtable.IsSynchronized;
				}
			}

			// Token: 0x1700135A RID: 4954
			// (get) Token: 0x06009050 RID: 36944 RVA: 0x00165458 File Offset: 0x00163658
			public object SyncRoot
			{
				get
				{
					return this._hashtable.SyncRoot;
				}
			}

			// Token: 0x1700135B RID: 4955
			// (get) Token: 0x06009051 RID: 36945 RVA: 0x00165465 File Offset: 0x00163665
			public int Count
			{
				get
				{
					return this._hashtable._count;
				}
			}

			// Token: 0x04002205 RID: 8709
			private readonly Hashtable _hashtable;
		}

		// Token: 0x02000971 RID: 2417
		private sealed class ValueCollection : ICollection, IEnumerable
		{
			// Token: 0x06009052 RID: 36946 RVA: 0x00165472 File Offset: 0x00163672
			internal ValueCollection(Hashtable hashtable)
			{
				this._hashtable = hashtable;
			}

			// Token: 0x06009053 RID: 36947 RVA: 0x00165484 File Offset: 0x00163684
			public void CopyTo(Array array, int arrayIndex)
			{
				ArgumentNullException.ThrowIfNull(array, "array");
				if (array.Rank != 1)
				{
					throw new ArgumentException(SR.Arg_RankMultiDimNotSupported, "array");
				}
				ArgumentOutOfRangeException.ThrowIfNegative<int>(arrayIndex, "arrayIndex");
				if (array.Length - arrayIndex < this._hashtable._count)
				{
					throw new ArgumentException(SR.Arg_ArrayPlusOffTooSmall);
				}
				this._hashtable.CopyValues(array, arrayIndex);
			}

			// Token: 0x06009054 RID: 36948 RVA: 0x001654ED File Offset: 0x001636ED
			public IEnumerator GetEnumerator()
			{
				return new Hashtable.HashtableEnumerator(this._hashtable, 2);
			}

			// Token: 0x1700135C RID: 4956
			// (get) Token: 0x06009055 RID: 36949 RVA: 0x001654FB File Offset: 0x001636FB
			public bool IsSynchronized
			{
				get
				{
					return this._hashtable.IsSynchronized;
				}
			}

			// Token: 0x1700135D RID: 4957
			// (get) Token: 0x06009056 RID: 36950 RVA: 0x00165508 File Offset: 0x00163708
			public object SyncRoot
			{
				get
				{
					return this._hashtable.SyncRoot;
				}
			}

			// Token: 0x1700135E RID: 4958
			// (get) Token: 0x06009057 RID: 36951 RVA: 0x00165515 File Offset: 0x00163715
			public int Count
			{
				get
				{
					return this._hashtable._count;
				}
			}

			// Token: 0x04002206 RID: 8710
			private readonly Hashtable _hashtable;
		}

		// Token: 0x02000972 RID: 2418
		private sealed class SyncHashtable : Hashtable, IEnumerable
		{
			// Token: 0x06009058 RID: 36952 RVA: 0x00165522 File Offset: 0x00163722
			internal SyncHashtable(Hashtable table) : base(false)
			{
				this._table = table;
			}

			// Token: 0x06009059 RID: 36953 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
			public override void GetObjectData(SerializationInfo info, StreamingContext context)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x1700135F RID: 4959
			// (get) Token: 0x0600905A RID: 36954 RVA: 0x00165532 File Offset: 0x00163732
			public override int Count
			{
				get
				{
					return this._table.Count;
				}
			}

			// Token: 0x17001360 RID: 4960
			// (get) Token: 0x0600905B RID: 36955 RVA: 0x0016553F File Offset: 0x0016373F
			public override bool IsReadOnly
			{
				get
				{
					return this._table.IsReadOnly;
				}
			}

			// Token: 0x17001361 RID: 4961
			// (get) Token: 0x0600905C RID: 36956 RVA: 0x0016554C File Offset: 0x0016374C
			public override bool IsFixedSize
			{
				get
				{
					return this._table.IsFixedSize;
				}
			}

			// Token: 0x17001362 RID: 4962
			// (get) Token: 0x0600905D RID: 36957 RVA: 0x000070DD File Offset: 0x000052DD
			public override bool IsSynchronized
			{
				get
				{
					return true;
				}
			}

			// Token: 0x17001363 RID: 4963
			public override object this[object key]
			{
				get
				{
					return this._table[key];
				}
				set
				{
					object syncRoot = this._table.SyncRoot;
					lock (syncRoot)
					{
						this._table[key] = value;
					}
				}
			}

			// Token: 0x17001364 RID: 4964
			// (get) Token: 0x06009060 RID: 36960 RVA: 0x001655B4 File Offset: 0x001637B4
			public override object SyncRoot
			{
				get
				{
					return this._table.SyncRoot;
				}
			}

			// Token: 0x06009061 RID: 36961 RVA: 0x001655C4 File Offset: 0x001637C4
			public override void Add(object key, object value)
			{
				object syncRoot = this._table.SyncRoot;
				lock (syncRoot)
				{
					this._table.Add(key, value);
				}
			}

			// Token: 0x06009062 RID: 36962 RVA: 0x00165610 File Offset: 0x00163810
			public override void Clear()
			{
				object syncRoot = this._table.SyncRoot;
				lock (syncRoot)
				{
					this._table.Clear();
				}
			}

			// Token: 0x06009063 RID: 36963 RVA: 0x0016565C File Offset: 0x0016385C
			public override bool Contains(object key)
			{
				return this._table.Contains(key);
			}

			// Token: 0x06009064 RID: 36964 RVA: 0x0016566A File Offset: 0x0016386A
			public override bool ContainsKey(object key)
			{
				ArgumentNullException.ThrowIfNull(key, "key");
				return this._table.ContainsKey(key);
			}

			// Token: 0x06009065 RID: 36965 RVA: 0x00165684 File Offset: 0x00163884
			public override bool ContainsValue(object key)
			{
				object syncRoot = this._table.SyncRoot;
				bool result;
				lock (syncRoot)
				{
					result = this._table.ContainsValue(key);
				}
				return result;
			}

			// Token: 0x06009066 RID: 36966 RVA: 0x001656D4 File Offset: 0x001638D4
			public override void CopyTo(Array array, int arrayIndex)
			{
				object syncRoot = this._table.SyncRoot;
				lock (syncRoot)
				{
					this._table.CopyTo(array, arrayIndex);
				}
			}

			// Token: 0x06009067 RID: 36967 RVA: 0x00165720 File Offset: 0x00163920
			public override object Clone()
			{
				object syncRoot = this._table.SyncRoot;
				object result;
				lock (syncRoot)
				{
					result = Hashtable.Synchronized((Hashtable)this._table.Clone());
				}
				return result;
			}

			// Token: 0x06009068 RID: 36968 RVA: 0x00165778 File Offset: 0x00163978
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this._table.GetEnumerator();
			}

			// Token: 0x06009069 RID: 36969 RVA: 0x00165778 File Offset: 0x00163978
			public override IDictionaryEnumerator GetEnumerator()
			{
				return this._table.GetEnumerator();
			}

			// Token: 0x17001365 RID: 4965
			// (get) Token: 0x0600906A RID: 36970 RVA: 0x00165788 File Offset: 0x00163988
			public override ICollection Keys
			{
				get
				{
					object syncRoot = this._table.SyncRoot;
					ICollection keys;
					lock (syncRoot)
					{
						keys = this._table.Keys;
					}
					return keys;
				}
			}

			// Token: 0x17001366 RID: 4966
			// (get) Token: 0x0600906B RID: 36971 RVA: 0x001657D4 File Offset: 0x001639D4
			public override ICollection Values
			{
				get
				{
					object syncRoot = this._table.SyncRoot;
					ICollection values;
					lock (syncRoot)
					{
						values = this._table.Values;
					}
					return values;
				}
			}

			// Token: 0x0600906C RID: 36972 RVA: 0x00165820 File Offset: 0x00163A20
			public override void Remove(object key)
			{
				object syncRoot = this._table.SyncRoot;
				lock (syncRoot)
				{
					this._table.Remove(key);
				}
			}

			// Token: 0x0600906D RID: 36973 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void OnDeserialization(object sender)
			{
			}

			// Token: 0x0600906E RID: 36974 RVA: 0x0016586C File Offset: 0x00163A6C
			internal override DebugViewDictionaryItem<object, object>[] ToDebugViewDictionaryItemArray()
			{
				return this._table.ToDebugViewDictionaryItemArray();
			}

			// Token: 0x04002207 RID: 8711
			private readonly Hashtable _table;
		}

		// Token: 0x02000973 RID: 2419
		private sealed class HashtableEnumerator : IDictionaryEnumerator, IEnumerator, ICloneable
		{
			// Token: 0x0600906F RID: 36975 RVA: 0x00165879 File Offset: 0x00163A79
			internal HashtableEnumerator(Hashtable hashtable, int getObjRetType)
			{
				this._hashtable = hashtable;
				this._bucket = hashtable._buckets.Length;
				this._version = hashtable._version;
				this._current = false;
				this._getObjectRetType = getObjRetType;
			}

			// Token: 0x06009070 RID: 36976 RVA: 0x00007BA1 File Offset: 0x00005DA1
			public object Clone()
			{
				return base.MemberwiseClone();
			}

			// Token: 0x17001367 RID: 4967
			// (get) Token: 0x06009071 RID: 36977 RVA: 0x001658B2 File Offset: 0x00163AB2
			public object Key
			{
				get
				{
					if (!this._current)
					{
						throw new InvalidOperationException(SR.InvalidOperation_EnumNotStarted);
					}
					return this._currentKey;
				}
			}

			// Token: 0x06009072 RID: 36978 RVA: 0x001658D0 File Offset: 0x00163AD0
			public bool MoveNext()
			{
				if (this._version != this._hashtable._version)
				{
					throw new InvalidOperationException(SR.InvalidOperation_EnumFailedVersion);
				}
				while (this._bucket > 0)
				{
					this._bucket--;
					object key = this._hashtable._buckets[this._bucket].key;
					if (key != null && key != this._hashtable._buckets)
					{
						this._currentKey = key;
						this._currentValue = this._hashtable._buckets[this._bucket].val;
						this._current = true;
						return true;
					}
				}
				this._current = false;
				return false;
			}

			// Token: 0x17001368 RID: 4968
			// (get) Token: 0x06009073 RID: 36979 RVA: 0x0016597A File Offset: 0x00163B7A
			public DictionaryEntry Entry
			{
				get
				{
					if (!this._current)
					{
						throw new InvalidOperationException(SR.InvalidOperation_EnumOpCantHappen);
					}
					return new DictionaryEntry(this._currentKey, this._currentValue);
				}
			}

			// Token: 0x17001369 RID: 4969
			// (get) Token: 0x06009074 RID: 36980 RVA: 0x001659A0 File Offset: 0x00163BA0
			public object Current
			{
				get
				{
					if (!this._current)
					{
						throw new InvalidOperationException(SR.InvalidOperation_EnumOpCantHappen);
					}
					if (this._getObjectRetType == 1)
					{
						return this._currentKey;
					}
					if (this._getObjectRetType == 2)
					{
						return this._currentValue;
					}
					return new DictionaryEntry(this._currentKey, this._currentValue);
				}
			}

			// Token: 0x1700136A RID: 4970
			// (get) Token: 0x06009075 RID: 36981 RVA: 0x001659F6 File Offset: 0x00163BF6
			public object Value
			{
				get
				{
					if (!this._current)
					{
						throw new InvalidOperationException(SR.InvalidOperation_EnumOpCantHappen);
					}
					return this._currentValue;
				}
			}

			// Token: 0x06009076 RID: 36982 RVA: 0x00165A14 File Offset: 0x00163C14
			public void Reset()
			{
				if (this._version != this._hashtable._version)
				{
					throw new InvalidOperationException(SR.InvalidOperation_EnumFailedVersion);
				}
				this._current = false;
				this._bucket = this._hashtable._buckets.Length;
				this._currentKey = null;
				this._currentValue = null;
			}

			// Token: 0x04002208 RID: 8712
			private readonly Hashtable _hashtable;

			// Token: 0x04002209 RID: 8713
			private int _bucket;

			// Token: 0x0400220A RID: 8714
			private readonly int _version;

			// Token: 0x0400220B RID: 8715
			private bool _current;

			// Token: 0x0400220C RID: 8716
			private readonly int _getObjectRetType;

			// Token: 0x0400220D RID: 8717
			private object _currentKey;

			// Token: 0x0400220E RID: 8718
			private object _currentValue;
		}

		// Token: 0x02000974 RID: 2420
		internal sealed class HashtableDebugView
		{
			// Token: 0x06009077 RID: 36983 RVA: 0x00165A69 File Offset: 0x00163C69
			public HashtableDebugView(Hashtable hashtable)
			{
				ArgumentNullException.ThrowIfNull(hashtable, "hashtable");
				this._hashtable = hashtable;
			}

			// Token: 0x1700136B RID: 4971
			// (get) Token: 0x06009078 RID: 36984 RVA: 0x00165A83 File Offset: 0x00163C83
			[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
			public DebugViewDictionaryItem<object, object>[] Items
			{
				get
				{
					return this._hashtable.ToDebugViewDictionaryItemArray();
				}
			}

			// Token: 0x0400220F RID: 8719
			private readonly Hashtable _hashtable;
		}
	}
}
