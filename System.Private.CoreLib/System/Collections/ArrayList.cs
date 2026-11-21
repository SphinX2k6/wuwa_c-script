using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Collections
{
	// Token: 0x0200095D RID: 2397
	[NullableContext(1)]
	[Nullable(0)]
	[DebuggerTypeProxy(typeof(ArrayList.ArrayListDebugView))]
	[DebuggerDisplay("Count = {Count}")]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class ArrayList : IList, ICollection, IEnumerable, ICloneable
	{
		// Token: 0x06008EB9 RID: 36537 RVA: 0x00160995 File Offset: 0x0015EB95
		public ArrayList()
		{
			this._items = Array.Empty<object>();
		}

		// Token: 0x06008EBA RID: 36538 RVA: 0x001609A8 File Offset: 0x0015EBA8
		public ArrayList(int capacity)
		{
			if (capacity < 0)
			{
				throw new ArgumentOutOfRangeException("capacity", SR.Format(SR.ArgumentOutOfRange_MustBeNonNegNum, "capacity"));
			}
			if (capacity == 0)
			{
				this._items = Array.Empty<object>();
				return;
			}
			this._items = new object[capacity];
		}

		// Token: 0x06008EBB RID: 36539 RVA: 0x001609F4 File Offset: 0x0015EBF4
		public ArrayList(ICollection c)
		{
			ArgumentNullException.ThrowIfNull(c, "c");
			int count = c.Count;
			if (count == 0)
			{
				this._items = Array.Empty<object>();
				return;
			}
			this._items = new object[count];
			this.AddRange(c);
		}

		// Token: 0x17001308 RID: 4872
		// (get) Token: 0x06008EBC RID: 36540 RVA: 0x00160A3B File Offset: 0x0015EC3B
		// (set) Token: 0x06008EBD RID: 36541 RVA: 0x00160A48 File Offset: 0x0015EC48
		public virtual int Capacity
		{
			get
			{
				return this._items.Length;
			}
			set
			{
				if (value < this._size)
				{
					throw new ArgumentOutOfRangeException("value", SR.ArgumentOutOfRange_SmallCapacity);
				}
				if (value != this._items.Length)
				{
					if (value > 0)
					{
						object[] array = new object[value];
						if (this._size > 0)
						{
							Array.Copy(this._items, array, this._size);
						}
						this._items = array;
						return;
					}
					this._items = new object[4];
				}
			}
		}

		// Token: 0x17001309 RID: 4873
		// (get) Token: 0x06008EBE RID: 36542 RVA: 0x00160AB3 File Offset: 0x0015ECB3
		public virtual int Count
		{
			get
			{
				return this._size;
			}
		}

		// Token: 0x1700130A RID: 4874
		// (get) Token: 0x06008EBF RID: 36543 RVA: 0x00007B65 File Offset: 0x00005D65
		public virtual bool IsFixedSize
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700130B RID: 4875
		// (get) Token: 0x06008EC0 RID: 36544 RVA: 0x00007B65 File Offset: 0x00005D65
		public virtual bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700130C RID: 4876
		// (get) Token: 0x06008EC1 RID: 36545 RVA: 0x00007B65 File Offset: 0x00005D65
		public virtual bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700130D RID: 4877
		// (get) Token: 0x06008EC2 RID: 36546 RVA: 0x00007B62 File Offset: 0x00005D62
		public virtual object SyncRoot
		{
			get
			{
				return this;
			}
		}

		// Token: 0x1700130E RID: 4878
		[Nullable(2)]
		public virtual object this[int index]
		{
			[NullableContext(2)]
			get
			{
				if (index < 0 || index >= this._size)
				{
					throw new ArgumentOutOfRangeException("index", SR.ArgumentOutOfRange_IndexMustBeLess);
				}
				return this._items[index];
			}
			[NullableContext(2)]
			set
			{
				if (index < 0 || index >= this._size)
				{
					throw new ArgumentOutOfRangeException("index", SR.ArgumentOutOfRange_IndexMustBeLess);
				}
				this._items[index] = value;
				this._version++;
			}
		}

		// Token: 0x06008EC5 RID: 36549 RVA: 0x00160B18 File Offset: 0x0015ED18
		public static ArrayList Adapter(IList list)
		{
			ArgumentNullException.ThrowIfNull(list, "list");
			return new ArrayList.IListWrapper(list);
		}

		// Token: 0x06008EC6 RID: 36550 RVA: 0x00160B2C File Offset: 0x0015ED2C
		[NullableContext(2)]
		public virtual int Add(object value)
		{
			if (this._size == this._items.Length)
			{
				this.EnsureCapacity(this._size + 1);
			}
			this._items[this._size] = value;
			this._version++;
			int size = this._size;
			this._size = size + 1;
			return size;
		}

		// Token: 0x06008EC7 RID: 36551 RVA: 0x00160B84 File Offset: 0x0015ED84
		public virtual void AddRange(ICollection c)
		{
			this.InsertRange(this._size, c);
		}

		// Token: 0x06008EC8 RID: 36552 RVA: 0x00160B93 File Offset: 0x0015ED93
		[NullableContext(2)]
		public virtual int BinarySearch(int index, int count, object value, IComparer comparer)
		{
			ArgumentOutOfRangeException.ThrowIfNegative<int>(index, "index");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(count, "count");
			if (this._size - index < count)
			{
				throw new ArgumentException(SR.Argument_InvalidOffLen);
			}
			return Array.BinarySearch(this._items, index, count, value, comparer);
		}

		// Token: 0x06008EC9 RID: 36553 RVA: 0x00160BD1 File Offset: 0x0015EDD1
		[NullableContext(2)]
		public virtual int BinarySearch(object value)
		{
			return this.BinarySearch(0, this.Count, value, null);
		}

		// Token: 0x06008ECA RID: 36554 RVA: 0x00160BE2 File Offset: 0x0015EDE2
		[NullableContext(2)]
		public virtual int BinarySearch(object value, IComparer comparer)
		{
			return this.BinarySearch(0, this.Count, value, comparer);
		}

		// Token: 0x06008ECB RID: 36555 RVA: 0x00160BF3 File Offset: 0x0015EDF3
		public virtual void Clear()
		{
			if (this._size > 0)
			{
				Array.Clear(this._items, 0, this._size);
				this._size = 0;
			}
			this._version++;
		}

		// Token: 0x06008ECC RID: 36556 RVA: 0x00160C28 File Offset: 0x0015EE28
		public virtual object Clone()
		{
			ArrayList arrayList = new ArrayList(this._size);
			arrayList._size = this._size;
			arrayList._version = this._version;
			Array.Copy(this._items, arrayList._items, this._size);
			return arrayList;
		}

		// Token: 0x06008ECD RID: 36557 RVA: 0x00160C71 File Offset: 0x0015EE71
		[NullableContext(2)]
		public virtual bool Contains(object item)
		{
			return Array.IndexOf<object>(this._items, item, 0, this._size) >= 0;
		}

		// Token: 0x06008ECE RID: 36558 RVA: 0x00160C8C File Offset: 0x0015EE8C
		public virtual void CopyTo(Array array)
		{
			this.CopyTo(array, 0);
		}

		// Token: 0x06008ECF RID: 36559 RVA: 0x00160C96 File Offset: 0x0015EE96
		public virtual void CopyTo(Array array, int arrayIndex)
		{
			if (array != null && array.Rank != 1)
			{
				throw new ArgumentException(SR.Arg_RankMultiDimNotSupported, "array");
			}
			Array.Copy(this._items, 0, array, arrayIndex, this._size);
		}

		// Token: 0x06008ED0 RID: 36560 RVA: 0x00160CC8 File Offset: 0x0015EEC8
		public virtual void CopyTo(int index, Array array, int arrayIndex, int count)
		{
			if (this._size - index < count)
			{
				throw new ArgumentException(SR.Argument_InvalidOffLen);
			}
			if (array != null && array.Rank != 1)
			{
				throw new ArgumentException(SR.Arg_RankMultiDimNotSupported, "array");
			}
			Array.Copy(this._items, index, array, arrayIndex, count);
		}

		// Token: 0x06008ED1 RID: 36561 RVA: 0x00160D18 File Offset: 0x0015EF18
		private void EnsureCapacity(int min)
		{
			if (this._items.Length < min)
			{
				int num = (this._items.Length == 0) ? 4 : (this._items.Length * 2);
				if ((ulong)num > 2147483591UL)
				{
					num = 2147483591;
				}
				if (num < min)
				{
					num = min;
				}
				this.Capacity = num;
			}
		}

		// Token: 0x06008ED2 RID: 36562 RVA: 0x00160D64 File Offset: 0x0015EF64
		public static IList FixedSize(IList list)
		{
			ArgumentNullException.ThrowIfNull(list, "list");
			return new ArrayList.FixedSizeList(list);
		}

		// Token: 0x06008ED3 RID: 36563 RVA: 0x00160D77 File Offset: 0x0015EF77
		public static ArrayList FixedSize(ArrayList list)
		{
			ArgumentNullException.ThrowIfNull(list, "list");
			return new ArrayList.FixedSizeArrayList(list);
		}

		// Token: 0x06008ED4 RID: 36564 RVA: 0x00160D8A File Offset: 0x0015EF8A
		public virtual IEnumerator GetEnumerator()
		{
			return new ArrayList.ArrayListEnumeratorSimple(this);
		}

		// Token: 0x06008ED5 RID: 36565 RVA: 0x00160D92 File Offset: 0x0015EF92
		public virtual IEnumerator GetEnumerator(int index, int count)
		{
			ArgumentOutOfRangeException.ThrowIfNegative<int>(index, "index");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(count, "count");
			if (this._size - index < count)
			{
				throw new ArgumentException(SR.Argument_InvalidOffLen);
			}
			return new ArrayList.ArrayListEnumerator(this, index, count);
		}

		// Token: 0x06008ED6 RID: 36566 RVA: 0x00160DC8 File Offset: 0x0015EFC8
		[NullableContext(2)]
		public virtual int IndexOf(object value)
		{
			return Array.IndexOf(this._items, value, 0, this._size);
		}

		// Token: 0x06008ED7 RID: 36567 RVA: 0x00160DDD File Offset: 0x0015EFDD
		[NullableContext(2)]
		public virtual int IndexOf(object value, int startIndex)
		{
			if (startIndex > this._size)
			{
				throw new ArgumentOutOfRangeException("startIndex", SR.ArgumentOutOfRange_IndexMustBeLessOrEqual);
			}
			return Array.IndexOf(this._items, value, startIndex, this._size - startIndex);
		}

		// Token: 0x06008ED8 RID: 36568 RVA: 0x00160E10 File Offset: 0x0015F010
		[NullableContext(2)]
		public virtual int IndexOf(object value, int startIndex, int count)
		{
			if (startIndex > this._size)
			{
				throw new ArgumentOutOfRangeException("startIndex", SR.ArgumentOutOfRange_IndexMustBeLessOrEqual);
			}
			if (count < 0 || startIndex > this._size - count)
			{
				throw new ArgumentOutOfRangeException("count", SR.ArgumentOutOfRange_Count);
			}
			return Array.IndexOf(this._items, value, startIndex, count);
		}

		// Token: 0x06008ED9 RID: 36569 RVA: 0x00160E64 File Offset: 0x0015F064
		[NullableContext(2)]
		public virtual void Insert(int index, object value)
		{
			if (index < 0 || index > this._size)
			{
				throw new ArgumentOutOfRangeException("index", SR.ArgumentOutOfRange_IndexMustBeLessOrEqual);
			}
			if (this._size == this._items.Length)
			{
				this.EnsureCapacity(this._size + 1);
			}
			if (index < this._size)
			{
				Array.Copy(this._items, index, this._items, index + 1, this._size - index);
			}
			this._items[index] = value;
			this._size++;
			this._version++;
		}

		// Token: 0x06008EDA RID: 36570 RVA: 0x00160EF8 File Offset: 0x0015F0F8
		public virtual void InsertRange(int index, ICollection c)
		{
			ArgumentNullException.ThrowIfNull(c, "c");
			if (index < 0 || index > this._size)
			{
				throw new ArgumentOutOfRangeException("index", SR.ArgumentOutOfRange_IndexMustBeLessOrEqual);
			}
			int count = c.Count;
			if (count > 0)
			{
				this.EnsureCapacity(this._size + count);
				if (index < this._size)
				{
					Array.Copy(this._items, index, this._items, index + count, this._size - index);
				}
				object[] array = new object[count];
				c.CopyTo(array, 0);
				array.CopyTo(this._items, index);
				this._size += count;
				this._version++;
			}
		}

		// Token: 0x06008EDB RID: 36571 RVA: 0x00160FA4 File Offset: 0x0015F1A4
		[NullableContext(2)]
		public virtual int LastIndexOf(object value)
		{
			return this.LastIndexOf(value, this._size - 1, this._size);
		}

		// Token: 0x06008EDC RID: 36572 RVA: 0x00160FBB File Offset: 0x0015F1BB
		[NullableContext(2)]
		public virtual int LastIndexOf(object value, int startIndex)
		{
			if (startIndex >= this._size)
			{
				throw new ArgumentOutOfRangeException("startIndex", SR.ArgumentOutOfRange_IndexMustBeLess);
			}
			return this.LastIndexOf(value, startIndex, startIndex + 1);
		}

		// Token: 0x06008EDD RID: 36573 RVA: 0x00160FE4 File Offset: 0x0015F1E4
		[NullableContext(2)]
		public virtual int LastIndexOf(object value, int startIndex, int count)
		{
			if (this.Count != 0)
			{
				ArgumentOutOfRangeException.ThrowIfNegative<int>(startIndex, "startIndex");
				ArgumentOutOfRangeException.ThrowIfNegative<int>(count, "count");
			}
			if (this._size == 0)
			{
				return -1;
			}
			if (startIndex >= this._size || count > startIndex + 1)
			{
				throw new ArgumentOutOfRangeException((startIndex >= this._size) ? "startIndex" : "count", SR.ArgumentOutOfRange_BiggerThanCollection);
			}
			return Array.LastIndexOf(this._items, value, startIndex, count);
		}

		// Token: 0x06008EDE RID: 36574 RVA: 0x00161056 File Offset: 0x0015F256
		public static IList ReadOnly(IList list)
		{
			ArgumentNullException.ThrowIfNull(list, "list");
			return new ArrayList.ReadOnlyList(list);
		}

		// Token: 0x06008EDF RID: 36575 RVA: 0x00161069 File Offset: 0x0015F269
		public static ArrayList ReadOnly(ArrayList list)
		{
			ArgumentNullException.ThrowIfNull(list, "list");
			return new ArrayList.ReadOnlyArrayList(list);
		}

		// Token: 0x06008EE0 RID: 36576 RVA: 0x0016107C File Offset: 0x0015F27C
		[NullableContext(2)]
		public virtual void Remove(object obj)
		{
			int num = this.IndexOf(obj);
			if (num >= 0)
			{
				this.RemoveAt(num);
			}
		}

		// Token: 0x06008EE1 RID: 36577 RVA: 0x0016109C File Offset: 0x0015F29C
		public virtual void RemoveAt(int index)
		{
			if (index < 0 || index >= this._size)
			{
				throw new ArgumentOutOfRangeException("index", SR.ArgumentOutOfRange_IndexMustBeLess);
			}
			this._size--;
			if (index < this._size)
			{
				Array.Copy(this._items, index + 1, this._items, index, this._size - index);
			}
			this._items[this._size] = null;
			this._version++;
		}

		// Token: 0x06008EE2 RID: 36578 RVA: 0x00161118 File Offset: 0x0015F318
		public virtual void RemoveRange(int index, int count)
		{
			ArgumentOutOfRangeException.ThrowIfNegative<int>(index, "index");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(count, "count");
			if (this._size - index < count)
			{
				throw new ArgumentException(SR.Argument_InvalidOffLen);
			}
			if (count > 0)
			{
				int i = this._size;
				this._size -= count;
				if (index < this._size)
				{
					Array.Copy(this._items, index + count, this._items, index, this._size - index);
				}
				while (i > this._size)
				{
					this._items[--i] = null;
				}
				this._version++;
			}
		}

		// Token: 0x06008EE3 RID: 36579 RVA: 0x001611B8 File Offset: 0x0015F3B8
		public static ArrayList Repeat([Nullable(2)] object value, int count)
		{
			ArgumentOutOfRangeException.ThrowIfNegative<int>(count, "count");
			ArrayList arrayList = new ArrayList((count > 4) ? count : 4);
			for (int i = 0; i < count; i++)
			{
				arrayList.Add(value);
			}
			return arrayList;
		}

		// Token: 0x06008EE4 RID: 36580 RVA: 0x001611F3 File Offset: 0x0015F3F3
		public virtual void Reverse()
		{
			this.Reverse(0, this.Count);
		}

		// Token: 0x06008EE5 RID: 36581 RVA: 0x00161204 File Offset: 0x0015F404
		public virtual void Reverse(int index, int count)
		{
			ArgumentOutOfRangeException.ThrowIfNegative<int>(index, "index");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(count, "count");
			if (this._size - index < count)
			{
				throw new ArgumentException(SR.Argument_InvalidOffLen);
			}
			Array.Reverse<object>(this._items, index, count);
			this._version++;
		}

		// Token: 0x06008EE6 RID: 36582 RVA: 0x00161258 File Offset: 0x0015F458
		public virtual void SetRange(int index, ICollection c)
		{
			ArgumentNullException.ThrowIfNull(c, "c");
			int count = c.Count;
			if (index < 0 || index > this._size - count)
			{
				throw new ArgumentOutOfRangeException("index", SR.ArgumentOutOfRange_IndexMustBeLessOrEqual);
			}
			if (count > 0)
			{
				c.CopyTo(this._items, index);
				this._version++;
			}
		}

		// Token: 0x06008EE7 RID: 36583 RVA: 0x001612B5 File Offset: 0x0015F4B5
		public virtual ArrayList GetRange(int index, int count)
		{
			ArgumentOutOfRangeException.ThrowIfNegative<int>(index, "index");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(count, "count");
			if (this._size - index < count)
			{
				throw new ArgumentException(SR.Argument_InvalidOffLen);
			}
			return new ArrayList.Range(this, index, count);
		}

		// Token: 0x06008EE8 RID: 36584 RVA: 0x001612EB File Offset: 0x0015F4EB
		public virtual void Sort()
		{
			this.Sort(0, this.Count, Comparer.Default);
		}

		// Token: 0x06008EE9 RID: 36585 RVA: 0x001612FF File Offset: 0x0015F4FF
		[NullableContext(2)]
		public virtual void Sort(IComparer comparer)
		{
			this.Sort(0, this.Count, comparer);
		}

		// Token: 0x06008EEA RID: 36586 RVA: 0x00161310 File Offset: 0x0015F510
		[NullableContext(2)]
		public virtual void Sort(int index, int count, IComparer comparer)
		{
			ArgumentOutOfRangeException.ThrowIfNegative<int>(index, "index");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(count, "count");
			if (this._size - index < count)
			{
				throw new ArgumentException(SR.Argument_InvalidOffLen);
			}
			Array.Sort(this._items, index, count, comparer);
			this._version++;
		}

		// Token: 0x06008EEB RID: 36587 RVA: 0x00161365 File Offset: 0x0015F565
		public static IList Synchronized(IList list)
		{
			ArgumentNullException.ThrowIfNull(list, "list");
			return new ArrayList.SyncIList(list);
		}

		// Token: 0x06008EEC RID: 36588 RVA: 0x00161378 File Offset: 0x0015F578
		public static ArrayList Synchronized(ArrayList list)
		{
			ArgumentNullException.ThrowIfNull(list, "list");
			return new ArrayList.SyncArrayList(list);
		}

		// Token: 0x06008EED RID: 36589 RVA: 0x0016138C File Offset: 0x0015F58C
		[return: Nullable(new byte[]
		{
			1,
			2
		})]
		public virtual object[] ToArray()
		{
			if (this._size == 0)
			{
				return Array.Empty<object>();
			}
			object[] array = new object[this._size];
			Array.Copy(this._items, array, this._size);
			return array;
		}

		// Token: 0x06008EEE RID: 36590 RVA: 0x001613C8 File Offset: 0x0015F5C8
		[RequiresDynamicCode("The code for an array of the specified type might not be available.")]
		public virtual Array ToArray(Type type)
		{
			ArgumentNullException.ThrowIfNull(type, "type");
			Array array = Array.CreateInstance(type, this._size);
			Array.Copy(this._items, array, this._size);
			return array;
		}

		// Token: 0x06008EEF RID: 36591 RVA: 0x00161400 File Offset: 0x0015F600
		public virtual void TrimToSize()
		{
			this.Capacity = this._size;
		}

		// Token: 0x040021CE RID: 8654
		private object[] _items;

		// Token: 0x040021CF RID: 8655
		private int _size;

		// Token: 0x040021D0 RID: 8656
		private int _version;

		// Token: 0x0200095E RID: 2398
		private sealed class IListWrapper : ArrayList
		{
			// Token: 0x06008EF0 RID: 36592 RVA: 0x0016140E File Offset: 0x0015F60E
			internal IListWrapper(IList list)
			{
				this._list = list;
				this._version = 0;
			}

			// Token: 0x1700130F RID: 4879
			// (get) Token: 0x06008EF1 RID: 36593 RVA: 0x00161424 File Offset: 0x0015F624
			// (set) Token: 0x06008EF2 RID: 36594 RVA: 0x00161431 File Offset: 0x0015F631
			public override int Capacity
			{
				get
				{
					return this._list.Count;
				}
				set
				{
					if (value < this.Count)
					{
						throw new ArgumentOutOfRangeException("value", SR.ArgumentOutOfRange_SmallCapacity);
					}
				}
			}

			// Token: 0x17001310 RID: 4880
			// (get) Token: 0x06008EF3 RID: 36595 RVA: 0x00161424 File Offset: 0x0015F624
			public override int Count
			{
				get
				{
					return this._list.Count;
				}
			}

			// Token: 0x17001311 RID: 4881
			// (get) Token: 0x06008EF4 RID: 36596 RVA: 0x0016144C File Offset: 0x0015F64C
			public override bool IsReadOnly
			{
				get
				{
					return this._list.IsReadOnly;
				}
			}

			// Token: 0x17001312 RID: 4882
			// (get) Token: 0x06008EF5 RID: 36597 RVA: 0x00161459 File Offset: 0x0015F659
			public override bool IsFixedSize
			{
				get
				{
					return this._list.IsFixedSize;
				}
			}

			// Token: 0x17001313 RID: 4883
			// (get) Token: 0x06008EF6 RID: 36598 RVA: 0x00161466 File Offset: 0x0015F666
			public override bool IsSynchronized
			{
				get
				{
					return this._list.IsSynchronized;
				}
			}

			// Token: 0x17001314 RID: 4884
			public override object this[int index]
			{
				get
				{
					return this._list[index];
				}
				set
				{
					this._list[index] = value;
					this._version++;
				}
			}

			// Token: 0x17001315 RID: 4885
			// (get) Token: 0x06008EF9 RID: 36601 RVA: 0x0016149E File Offset: 0x0015F69E
			public override object SyncRoot
			{
				get
				{
					return this._list.SyncRoot;
				}
			}

			// Token: 0x06008EFA RID: 36602 RVA: 0x001614AB File Offset: 0x0015F6AB
			public override int Add(object obj)
			{
				int result = this._list.Add(obj);
				this._version++;
				return result;
			}

			// Token: 0x06008EFB RID: 36603 RVA: 0x001614C7 File Offset: 0x0015F6C7
			public override void AddRange(ICollection c)
			{
				this.InsertRange(this.Count, c);
			}

			// Token: 0x06008EFC RID: 36604 RVA: 0x001614D8 File Offset: 0x0015F6D8
			public override int BinarySearch(int index, int count, object value, IComparer comparer)
			{
				ArgumentOutOfRangeException.ThrowIfNegative<int>(index, "index");
				ArgumentOutOfRangeException.ThrowIfNegative<int>(count, "count");
				if (this.Count - index < count)
				{
					throw new ArgumentException(SR.Argument_InvalidOffLen);
				}
				if (comparer == null)
				{
					comparer = Comparer.Default;
				}
				int i = index;
				int num = index + count - 1;
				while (i <= num)
				{
					int num2 = (i + num) / 2;
					int num3 = comparer.Compare(value, this._list[num2]);
					if (num3 == 0)
					{
						return num2;
					}
					if (num3 < 0)
					{
						num = num2 - 1;
					}
					else
					{
						i = num2 + 1;
					}
				}
				return ~i;
			}

			// Token: 0x06008EFD RID: 36605 RVA: 0x0016155A File Offset: 0x0015F75A
			public override void Clear()
			{
				if (this._list.IsFixedSize)
				{
					throw new NotSupportedException(SR.NotSupported_FixedSizeCollection);
				}
				this._list.Clear();
				this._version++;
			}

			// Token: 0x06008EFE RID: 36606 RVA: 0x0016158D File Offset: 0x0015F78D
			public override object Clone()
			{
				return new ArrayList.IListWrapper(this._list);
			}

			// Token: 0x06008EFF RID: 36607 RVA: 0x0016159A File Offset: 0x0015F79A
			public override bool Contains(object obj)
			{
				return this._list.Contains(obj);
			}

			// Token: 0x06008F00 RID: 36608 RVA: 0x001615A8 File Offset: 0x0015F7A8
			public override void CopyTo(Array array, int index)
			{
				this._list.CopyTo(array, index);
			}

			// Token: 0x06008F01 RID: 36609 RVA: 0x001615B8 File Offset: 0x0015F7B8
			public override void CopyTo(int index, Array array, int arrayIndex, int count)
			{
				ArgumentNullException.ThrowIfNull(array, "array");
				ArgumentOutOfRangeException.ThrowIfNegative<int>(index, "index");
				ArgumentOutOfRangeException.ThrowIfNegative<int>(arrayIndex, "arrayIndex");
				ArgumentOutOfRangeException.ThrowIfNegative<int>(count, "count");
				if (array.Length - arrayIndex < count)
				{
					throw new ArgumentException(SR.Argument_InvalidOffLen);
				}
				if (array.Rank != 1)
				{
					throw new ArgumentException(SR.Arg_RankMultiDimNotSupported, "array");
				}
				if (this._list.Count - index < count)
				{
					throw new ArgumentException(SR.Argument_InvalidOffLen);
				}
				for (int i = index; i < index + count; i++)
				{
					array.SetValue(this._list[i], arrayIndex++);
				}
			}

			// Token: 0x06008F02 RID: 36610 RVA: 0x00161665 File Offset: 0x0015F865
			public override IEnumerator GetEnumerator()
			{
				return this._list.GetEnumerator();
			}

			// Token: 0x06008F03 RID: 36611 RVA: 0x00161672 File Offset: 0x0015F872
			public override IEnumerator GetEnumerator(int index, int count)
			{
				ArgumentOutOfRangeException.ThrowIfNegative<int>(index, "index");
				ArgumentOutOfRangeException.ThrowIfNegative<int>(count, "count");
				if (this._list.Count - index < count)
				{
					throw new ArgumentException(SR.Argument_InvalidOffLen);
				}
				return new ArrayList.IListWrapper.IListWrapperEnumWrapper(this, index, count);
			}

			// Token: 0x06008F04 RID: 36612 RVA: 0x001616AD File Offset: 0x0015F8AD
			public override int IndexOf(object value)
			{
				return this._list.IndexOf(value);
			}

			// Token: 0x06008F05 RID: 36613 RVA: 0x001616BB File Offset: 0x0015F8BB
			public override int IndexOf(object value, int startIndex)
			{
				return this.IndexOf(value, startIndex, this._list.Count - startIndex);
			}

			// Token: 0x06008F06 RID: 36614 RVA: 0x001616D4 File Offset: 0x0015F8D4
			public override int IndexOf(object value, int startIndex, int count)
			{
				if (startIndex < 0 || startIndex > this.Count)
				{
					throw new ArgumentOutOfRangeException("startIndex", SR.ArgumentOutOfRange_IndexMustBeLessOrEqual);
				}
				if (count < 0 || startIndex > this.Count - count)
				{
					throw new ArgumentOutOfRangeException("count", SR.ArgumentOutOfRange_Count);
				}
				int num = startIndex + count;
				if (value == null)
				{
					for (int i = startIndex; i < num; i++)
					{
						if (this._list[i] == null)
						{
							return i;
						}
					}
					return -1;
				}
				for (int j = startIndex; j < num; j++)
				{
					object obj = this._list[j];
					if (obj != null && obj.Equals(value))
					{
						return j;
					}
				}
				return -1;
			}

			// Token: 0x06008F07 RID: 36615 RVA: 0x0016176A File Offset: 0x0015F96A
			public override void Insert(int index, object obj)
			{
				this._list.Insert(index, obj);
				this._version++;
			}

			// Token: 0x06008F08 RID: 36616 RVA: 0x00161788 File Offset: 0x0015F988
			public override void InsertRange(int index, ICollection c)
			{
				ArgumentNullException.ThrowIfNull(c, "c");
				if (index < 0 || index > this.Count)
				{
					throw new ArgumentOutOfRangeException("index", SR.ArgumentOutOfRange_IndexMustBeLessOrEqual);
				}
				if (c.Count > 0)
				{
					ArrayList arrayList = this._list as ArrayList;
					if (arrayList != null)
					{
						arrayList.InsertRange(index, c);
					}
					else
					{
						foreach (object value in c)
						{
							this._list.Insert(index++, value);
						}
					}
					this._version++;
				}
			}

			// Token: 0x06008F09 RID: 36617 RVA: 0x00161815 File Offset: 0x0015FA15
			public override int LastIndexOf(object value)
			{
				return this.LastIndexOf(value, this._list.Count - 1, this._list.Count);
			}

			// Token: 0x06008F0A RID: 36618 RVA: 0x00161836 File Offset: 0x0015FA36
			public override int LastIndexOf(object value, int startIndex)
			{
				return this.LastIndexOf(value, startIndex, startIndex + 1);
			}

			// Token: 0x06008F0B RID: 36619 RVA: 0x00161844 File Offset: 0x0015FA44
			public override int LastIndexOf(object value, int startIndex, int count)
			{
				if (this._list.Count == 0)
				{
					return -1;
				}
				if (startIndex < 0 || startIndex >= this._list.Count)
				{
					throw new ArgumentOutOfRangeException("startIndex", SR.ArgumentOutOfRange_IndexMustBeLess);
				}
				if (count < 0 || count > startIndex + 1)
				{
					throw new ArgumentOutOfRangeException("count", SR.ArgumentOutOfRange_Count);
				}
				int num = startIndex - count + 1;
				if (value == null)
				{
					for (int i = startIndex; i >= num; i--)
					{
						if (this._list[i] == null)
						{
							return i;
						}
					}
					return -1;
				}
				for (int j = startIndex; j >= num; j--)
				{
					object obj = this._list[j];
					if (obj != null && obj.Equals(value))
					{
						return j;
					}
				}
				return -1;
			}

			// Token: 0x06008F0C RID: 36620 RVA: 0x001618EC File Offset: 0x0015FAEC
			public override void Remove(object value)
			{
				int num = this.IndexOf(value);
				if (num >= 0)
				{
					this.RemoveAt(num);
				}
			}

			// Token: 0x06008F0D RID: 36621 RVA: 0x0016190C File Offset: 0x0015FB0C
			public override void RemoveAt(int index)
			{
				this._list.RemoveAt(index);
				this._version++;
			}

			// Token: 0x06008F0E RID: 36622 RVA: 0x00161928 File Offset: 0x0015FB28
			public override void RemoveRange(int index, int count)
			{
				ArgumentOutOfRangeException.ThrowIfNegative<int>(index, "index");
				ArgumentOutOfRangeException.ThrowIfNegative<int>(count, "count");
				if (this._list.Count - index < count)
				{
					throw new ArgumentException(SR.Argument_InvalidOffLen);
				}
				if (count > 0)
				{
					this._version++;
				}
				while (count > 0)
				{
					this._list.RemoveAt(index);
					count--;
				}
			}

			// Token: 0x06008F0F RID: 36623 RVA: 0x00161990 File Offset: 0x0015FB90
			public override void Reverse(int index, int count)
			{
				ArgumentOutOfRangeException.ThrowIfNegative<int>(index, "index");
				ArgumentOutOfRangeException.ThrowIfNegative<int>(count, "count");
				if (this._list.Count - index < count)
				{
					throw new ArgumentException(SR.Argument_InvalidOffLen);
				}
				int i = index;
				int num = index + count - 1;
				while (i < num)
				{
					object value = this._list[i];
					this._list[i++] = this._list[num];
					this._list[num--] = value;
				}
				this._version++;
			}

			// Token: 0x06008F10 RID: 36624 RVA: 0x00161A24 File Offset: 0x0015FC24
			public override void SetRange(int index, ICollection c)
			{
				ArgumentNullException.ThrowIfNull(c, "c");
				if (index < 0 || index > this._list.Count - c.Count)
				{
					throw new ArgumentOutOfRangeException("index", SR.ArgumentOutOfRange_IndexMustBeLessOrEqual);
				}
				if (c.Count > 0)
				{
					foreach (object value in c)
					{
						this._list[index++] = value;
					}
					this._version++;
				}
			}

			// Token: 0x06008F11 RID: 36625 RVA: 0x00161AA4 File Offset: 0x0015FCA4
			public override ArrayList GetRange(int index, int count)
			{
				ArgumentOutOfRangeException.ThrowIfNegative<int>(index, "index");
				ArgumentOutOfRangeException.ThrowIfNegative<int>(count, "count");
				if (this._list.Count - index < count)
				{
					throw new ArgumentException(SR.Argument_InvalidOffLen);
				}
				return new ArrayList.Range(this, index, count);
			}

			// Token: 0x06008F12 RID: 36626 RVA: 0x00161AE0 File Offset: 0x0015FCE0
			public override void Sort(int index, int count, IComparer comparer)
			{
				ArgumentOutOfRangeException.ThrowIfNegative<int>(index, "index");
				ArgumentOutOfRangeException.ThrowIfNegative<int>(count, "count");
				if (this._list.Count - index < count)
				{
					throw new ArgumentException(SR.Argument_InvalidOffLen);
				}
				object[] array = new object[count];
				this.CopyTo(index, array, 0, count);
				Array.Sort(array, 0, count, comparer);
				for (int i = 0; i < count; i++)
				{
					this._list[i + index] = array[i];
				}
				this._version++;
			}

			// Token: 0x06008F13 RID: 36627 RVA: 0x00161B64 File Offset: 0x0015FD64
			public override object[] ToArray()
			{
				if (this.Count == 0)
				{
					return Array.Empty<object>();
				}
				object[] array = new object[this.Count];
				this._list.CopyTo(array, 0);
				return array;
			}

			// Token: 0x06008F14 RID: 36628 RVA: 0x00161B9C File Offset: 0x0015FD9C
			[RequiresDynamicCode("The code for an array of the specified type might not be available.")]
			public override Array ToArray(Type type)
			{
				ArgumentNullException.ThrowIfNull(type, "type");
				Array array = Array.CreateInstance(type, this._list.Count);
				this._list.CopyTo(array, 0);
				return array;
			}

			// Token: 0x06008F15 RID: 36629 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public override void TrimToSize()
			{
			}

			// Token: 0x040021D1 RID: 8657
			private readonly IList _list;

			// Token: 0x0200095F RID: 2399
			private sealed class IListWrapperEnumWrapper : IEnumerator, ICloneable
			{
				// Token: 0x06008F16 RID: 36630 RVA: 0x00161BD4 File Offset: 0x0015FDD4
				internal IListWrapperEnumWrapper(ArrayList.IListWrapper listWrapper, int startIndex, int count)
				{
					this._en = listWrapper.GetEnumerator();
					this._initialStartIndex = startIndex;
					this._initialCount = count;
					while (startIndex-- > 0 && this._en.MoveNext())
					{
					}
					this._remaining = count;
					this._firstCall = true;
				}

				// Token: 0x06008F17 RID: 36631 RVA: 0x00005ACC File Offset: 0x00003CCC
				private IListWrapperEnumWrapper()
				{
				}

				// Token: 0x06008F18 RID: 36632 RVA: 0x00161C28 File Offset: 0x0015FE28
				public object Clone()
				{
					return new ArrayList.IListWrapper.IListWrapperEnumWrapper
					{
						_en = (IEnumerator)((ICloneable)this._en).Clone(),
						_initialStartIndex = this._initialStartIndex,
						_initialCount = this._initialCount,
						_remaining = this._remaining,
						_firstCall = this._firstCall
					};
				}

				// Token: 0x06008F19 RID: 36633 RVA: 0x00161C88 File Offset: 0x0015FE88
				public bool MoveNext()
				{
					if (this._firstCall)
					{
						this._firstCall = false;
						int remaining = this._remaining;
						this._remaining = remaining - 1;
						return remaining > 0 && this._en.MoveNext();
					}
					if (this._remaining < 0)
					{
						return false;
					}
					if (this._en.MoveNext())
					{
						int remaining = this._remaining;
						this._remaining = remaining - 1;
						return remaining > 0;
					}
					return false;
				}

				// Token: 0x17001316 RID: 4886
				// (get) Token: 0x06008F1A RID: 36634 RVA: 0x00161CF4 File Offset: 0x0015FEF4
				public object Current
				{
					get
					{
						if (this._firstCall)
						{
							throw new InvalidOperationException(SR.InvalidOperation_EnumNotStarted);
						}
						if (this._remaining < 0)
						{
							throw new InvalidOperationException(SR.InvalidOperation_EnumEnded);
						}
						return this._en.Current;
					}
				}

				// Token: 0x06008F1B RID: 36635 RVA: 0x00161D28 File Offset: 0x0015FF28
				public void Reset()
				{
					this._en.Reset();
					int initialStartIndex = this._initialStartIndex;
					while (initialStartIndex-- > 0 && this._en.MoveNext())
					{
					}
					this._remaining = this._initialCount;
					this._firstCall = true;
				}

				// Token: 0x040021D2 RID: 8658
				private IEnumerator _en;

				// Token: 0x040021D3 RID: 8659
				private int _remaining;

				// Token: 0x040021D4 RID: 8660
				private int _initialStartIndex;

				// Token: 0x040021D5 RID: 8661
				private int _initialCount;

				// Token: 0x040021D6 RID: 8662
				private bool _firstCall;
			}
		}

		// Token: 0x02000960 RID: 2400
		private sealed class SyncArrayList : ArrayList
		{
			// Token: 0x06008F1C RID: 36636 RVA: 0x00161D6F File Offset: 0x0015FF6F
			internal SyncArrayList(ArrayList list)
			{
				this._list = list;
				this._root = list.SyncRoot;
			}

			// Token: 0x17001317 RID: 4887
			// (get) Token: 0x06008F1D RID: 36637 RVA: 0x00161D8C File Offset: 0x0015FF8C
			// (set) Token: 0x06008F1E RID: 36638 RVA: 0x00161DD4 File Offset: 0x0015FFD4
			public override int Capacity
			{
				get
				{
					object root = this._root;
					int capacity;
					lock (root)
					{
						capacity = this._list.Capacity;
					}
					return capacity;
				}
				set
				{
					object root = this._root;
					lock (root)
					{
						this._list.Capacity = value;
					}
				}
			}

			// Token: 0x17001318 RID: 4888
			// (get) Token: 0x06008F1F RID: 36639 RVA: 0x00161E1C File Offset: 0x0016001C
			public override int Count
			{
				get
				{
					object root = this._root;
					int count;
					lock (root)
					{
						count = this._list.Count;
					}
					return count;
				}
			}

			// Token: 0x17001319 RID: 4889
			// (get) Token: 0x06008F20 RID: 36640 RVA: 0x00161E64 File Offset: 0x00160064
			public override bool IsReadOnly
			{
				get
				{
					return this._list.IsReadOnly;
				}
			}

			// Token: 0x1700131A RID: 4890
			// (get) Token: 0x06008F21 RID: 36641 RVA: 0x00161E71 File Offset: 0x00160071
			public override bool IsFixedSize
			{
				get
				{
					return this._list.IsFixedSize;
				}
			}

			// Token: 0x1700131B RID: 4891
			// (get) Token: 0x06008F22 RID: 36642 RVA: 0x000070DD File Offset: 0x000052DD
			public override bool IsSynchronized
			{
				get
				{
					return true;
				}
			}

			// Token: 0x1700131C RID: 4892
			public override object this[int index]
			{
				get
				{
					object root = this._root;
					object result;
					lock (root)
					{
						result = this._list[index];
					}
					return result;
				}
				set
				{
					object root = this._root;
					lock (root)
					{
						this._list[index] = value;
					}
				}
			}

			// Token: 0x1700131D RID: 4893
			// (get) Token: 0x06008F25 RID: 36645 RVA: 0x00161F10 File Offset: 0x00160110
			public override object SyncRoot
			{
				get
				{
					return this._root;
				}
			}

			// Token: 0x06008F26 RID: 36646 RVA: 0x00161F18 File Offset: 0x00160118
			public override int Add(object value)
			{
				object root = this._root;
				int result;
				lock (root)
				{
					result = this._list.Add(value);
				}
				return result;
			}

			// Token: 0x06008F27 RID: 36647 RVA: 0x00161F60 File Offset: 0x00160160
			public override void AddRange(ICollection c)
			{
				object root = this._root;
				lock (root)
				{
					this._list.AddRange(c);
				}
			}

			// Token: 0x06008F28 RID: 36648 RVA: 0x00161FA8 File Offset: 0x001601A8
			public override int BinarySearch(object value)
			{
				object root = this._root;
				int result;
				lock (root)
				{
					result = this._list.BinarySearch(value);
				}
				return result;
			}

			// Token: 0x06008F29 RID: 36649 RVA: 0x00161FF0 File Offset: 0x001601F0
			public override int BinarySearch(object value, IComparer comparer)
			{
				object root = this._root;
				int result;
				lock (root)
				{
					result = this._list.BinarySearch(value, comparer);
				}
				return result;
			}

			// Token: 0x06008F2A RID: 36650 RVA: 0x0016203C File Offset: 0x0016023C
			public override int BinarySearch(int index, int count, object value, IComparer comparer)
			{
				object root = this._root;
				int result;
				lock (root)
				{
					result = this._list.BinarySearch(index, count, value, comparer);
				}
				return result;
			}

			// Token: 0x06008F2B RID: 36651 RVA: 0x00162088 File Offset: 0x00160288
			public override void Clear()
			{
				object root = this._root;
				lock (root)
				{
					this._list.Clear();
				}
			}

			// Token: 0x06008F2C RID: 36652 RVA: 0x001620D0 File Offset: 0x001602D0
			public override object Clone()
			{
				object root = this._root;
				object result;
				lock (root)
				{
					result = new ArrayList.SyncArrayList((ArrayList)this._list.Clone());
				}
				return result;
			}

			// Token: 0x06008F2D RID: 36653 RVA: 0x00162124 File Offset: 0x00160324
			public override bool Contains(object item)
			{
				object root = this._root;
				bool result;
				lock (root)
				{
					result = this._list.Contains(item);
				}
				return result;
			}

			// Token: 0x06008F2E RID: 36654 RVA: 0x0016216C File Offset: 0x0016036C
			public override void CopyTo(Array array)
			{
				object root = this._root;
				lock (root)
				{
					this._list.CopyTo(array);
				}
			}

			// Token: 0x06008F2F RID: 36655 RVA: 0x001621B4 File Offset: 0x001603B4
			public override void CopyTo(Array array, int index)
			{
				object root = this._root;
				lock (root)
				{
					this._list.CopyTo(array, index);
				}
			}

			// Token: 0x06008F30 RID: 36656 RVA: 0x001621FC File Offset: 0x001603FC
			public override void CopyTo(int index, Array array, int arrayIndex, int count)
			{
				object root = this._root;
				lock (root)
				{
					this._list.CopyTo(index, array, arrayIndex, count);
				}
			}

			// Token: 0x06008F31 RID: 36657 RVA: 0x00162248 File Offset: 0x00160448
			public override IEnumerator GetEnumerator()
			{
				object root = this._root;
				IEnumerator enumerator;
				lock (root)
				{
					enumerator = this._list.GetEnumerator();
				}
				return enumerator;
			}

			// Token: 0x06008F32 RID: 36658 RVA: 0x00162290 File Offset: 0x00160490
			public override IEnumerator GetEnumerator(int index, int count)
			{
				object root = this._root;
				IEnumerator enumerator;
				lock (root)
				{
					enumerator = this._list.GetEnumerator(index, count);
				}
				return enumerator;
			}

			// Token: 0x06008F33 RID: 36659 RVA: 0x001622DC File Offset: 0x001604DC
			public override int IndexOf(object value)
			{
				object root = this._root;
				int result;
				lock (root)
				{
					result = this._list.IndexOf(value);
				}
				return result;
			}

			// Token: 0x06008F34 RID: 36660 RVA: 0x00162324 File Offset: 0x00160524
			public override int IndexOf(object value, int startIndex)
			{
				object root = this._root;
				int result;
				lock (root)
				{
					result = this._list.IndexOf(value, startIndex);
				}
				return result;
			}

			// Token: 0x06008F35 RID: 36661 RVA: 0x00162370 File Offset: 0x00160570
			public override int IndexOf(object value, int startIndex, int count)
			{
				object root = this._root;
				int result;
				lock (root)
				{
					result = this._list.IndexOf(value, startIndex, count);
				}
				return result;
			}

			// Token: 0x06008F36 RID: 36662 RVA: 0x001623BC File Offset: 0x001605BC
			public override void Insert(int index, object value)
			{
				object root = this._root;
				lock (root)
				{
					this._list.Insert(index, value);
				}
			}

			// Token: 0x06008F37 RID: 36663 RVA: 0x00162404 File Offset: 0x00160604
			public override void InsertRange(int index, ICollection c)
			{
				object root = this._root;
				lock (root)
				{
					this._list.InsertRange(index, c);
				}
			}

			// Token: 0x06008F38 RID: 36664 RVA: 0x0016244C File Offset: 0x0016064C
			public override int LastIndexOf(object value)
			{
				object root = this._root;
				int result;
				lock (root)
				{
					result = this._list.LastIndexOf(value);
				}
				return result;
			}

			// Token: 0x06008F39 RID: 36665 RVA: 0x00162494 File Offset: 0x00160694
			public override int LastIndexOf(object value, int startIndex)
			{
				object root = this._root;
				int result;
				lock (root)
				{
					result = this._list.LastIndexOf(value, startIndex);
				}
				return result;
			}

			// Token: 0x06008F3A RID: 36666 RVA: 0x001624E0 File Offset: 0x001606E0
			public override int LastIndexOf(object value, int startIndex, int count)
			{
				object root = this._root;
				int result;
				lock (root)
				{
					result = this._list.LastIndexOf(value, startIndex, count);
				}
				return result;
			}

			// Token: 0x06008F3B RID: 36667 RVA: 0x0016252C File Offset: 0x0016072C
			public override void Remove(object value)
			{
				object root = this._root;
				lock (root)
				{
					this._list.Remove(value);
				}
			}

			// Token: 0x06008F3C RID: 36668 RVA: 0x00162574 File Offset: 0x00160774
			public override void RemoveAt(int index)
			{
				object root = this._root;
				lock (root)
				{
					this._list.RemoveAt(index);
				}
			}

			// Token: 0x06008F3D RID: 36669 RVA: 0x001625BC File Offset: 0x001607BC
			public override void RemoveRange(int index, int count)
			{
				object root = this._root;
				lock (root)
				{
					this._list.RemoveRange(index, count);
				}
			}

			// Token: 0x06008F3E RID: 36670 RVA: 0x00162604 File Offset: 0x00160804
			public override void Reverse(int index, int count)
			{
				object root = this._root;
				lock (root)
				{
					this._list.Reverse(index, count);
				}
			}

			// Token: 0x06008F3F RID: 36671 RVA: 0x0016264C File Offset: 0x0016084C
			public override void SetRange(int index, ICollection c)
			{
				object root = this._root;
				lock (root)
				{
					this._list.SetRange(index, c);
				}
			}

			// Token: 0x06008F40 RID: 36672 RVA: 0x00162694 File Offset: 0x00160894
			public override ArrayList GetRange(int index, int count)
			{
				object root = this._root;
				ArrayList range;
				lock (root)
				{
					range = this._list.GetRange(index, count);
				}
				return range;
			}

			// Token: 0x06008F41 RID: 36673 RVA: 0x001626E0 File Offset: 0x001608E0
			public override void Sort()
			{
				object root = this._root;
				lock (root)
				{
					this._list.Sort();
				}
			}

			// Token: 0x06008F42 RID: 36674 RVA: 0x00162728 File Offset: 0x00160928
			public override void Sort(IComparer comparer)
			{
				object root = this._root;
				lock (root)
				{
					this._list.Sort(comparer);
				}
			}

			// Token: 0x06008F43 RID: 36675 RVA: 0x00162770 File Offset: 0x00160970
			public override void Sort(int index, int count, IComparer comparer)
			{
				object root = this._root;
				lock (root)
				{
					this._list.Sort(index, count, comparer);
				}
			}

			// Token: 0x06008F44 RID: 36676 RVA: 0x001627B8 File Offset: 0x001609B8
			public override object[] ToArray()
			{
				object root = this._root;
				object[] result;
				lock (root)
				{
					result = this._list.ToArray();
				}
				return result;
			}

			// Token: 0x06008F45 RID: 36677 RVA: 0x00162800 File Offset: 0x00160A00
			[RequiresDynamicCode("The code for an array of the specified type might not be available.")]
			public override Array ToArray(Type type)
			{
				object root = this._root;
				Array result;
				lock (root)
				{
					result = this._list.ToArray(type);
				}
				return result;
			}

			// Token: 0x06008F46 RID: 36678 RVA: 0x00162848 File Offset: 0x00160A48
			public override void TrimToSize()
			{
				object root = this._root;
				lock (root)
				{
					this._list.TrimToSize();
				}
			}

			// Token: 0x040021D7 RID: 8663
			private readonly ArrayList _list;

			// Token: 0x040021D8 RID: 8664
			private readonly object _root;
		}

		// Token: 0x02000961 RID: 2401
		private sealed class SyncIList : IList, ICollection, IEnumerable
		{
			// Token: 0x06008F47 RID: 36679 RVA: 0x00162890 File Offset: 0x00160A90
			internal SyncIList(IList list)
			{
				this._list = list;
				this._root = list.SyncRoot;
			}

			// Token: 0x1700131E RID: 4894
			// (get) Token: 0x06008F48 RID: 36680 RVA: 0x001628AC File Offset: 0x00160AAC
			public int Count
			{
				get
				{
					object root = this._root;
					int count;
					lock (root)
					{
						count = this._list.Count;
					}
					return count;
				}
			}

			// Token: 0x1700131F RID: 4895
			// (get) Token: 0x06008F49 RID: 36681 RVA: 0x001628F4 File Offset: 0x00160AF4
			public bool IsReadOnly
			{
				get
				{
					return this._list.IsReadOnly;
				}
			}

			// Token: 0x17001320 RID: 4896
			// (get) Token: 0x06008F4A RID: 36682 RVA: 0x00162901 File Offset: 0x00160B01
			public bool IsFixedSize
			{
				get
				{
					return this._list.IsFixedSize;
				}
			}

			// Token: 0x17001321 RID: 4897
			// (get) Token: 0x06008F4B RID: 36683 RVA: 0x000070DD File Offset: 0x000052DD
			public bool IsSynchronized
			{
				get
				{
					return true;
				}
			}

			// Token: 0x17001322 RID: 4898
			public object this[int index]
			{
				get
				{
					object root = this._root;
					object result;
					lock (root)
					{
						result = this._list[index];
					}
					return result;
				}
				set
				{
					object root = this._root;
					lock (root)
					{
						this._list[index] = value;
					}
				}
			}

			// Token: 0x17001323 RID: 4899
			// (get) Token: 0x06008F4E RID: 36686 RVA: 0x001629A0 File Offset: 0x00160BA0
			public object SyncRoot
			{
				get
				{
					return this._root;
				}
			}

			// Token: 0x06008F4F RID: 36687 RVA: 0x001629A8 File Offset: 0x00160BA8
			public int Add(object value)
			{
				object root = this._root;
				int result;
				lock (root)
				{
					result = this._list.Add(value);
				}
				return result;
			}

			// Token: 0x06008F50 RID: 36688 RVA: 0x001629F0 File Offset: 0x00160BF0
			public void Clear()
			{
				object root = this._root;
				lock (root)
				{
					this._list.Clear();
				}
			}

			// Token: 0x06008F51 RID: 36689 RVA: 0x00162A38 File Offset: 0x00160C38
			public bool Contains(object item)
			{
				object root = this._root;
				bool result;
				lock (root)
				{
					result = this._list.Contains(item);
				}
				return result;
			}

			// Token: 0x06008F52 RID: 36690 RVA: 0x00162A80 File Offset: 0x00160C80
			public void CopyTo(Array array, int index)
			{
				object root = this._root;
				lock (root)
				{
					this._list.CopyTo(array, index);
				}
			}

			// Token: 0x06008F53 RID: 36691 RVA: 0x00162AC8 File Offset: 0x00160CC8
			public IEnumerator GetEnumerator()
			{
				object root = this._root;
				IEnumerator enumerator;
				lock (root)
				{
					enumerator = this._list.GetEnumerator();
				}
				return enumerator;
			}

			// Token: 0x06008F54 RID: 36692 RVA: 0x00162B10 File Offset: 0x00160D10
			public int IndexOf(object value)
			{
				object root = this._root;
				int result;
				lock (root)
				{
					result = this._list.IndexOf(value);
				}
				return result;
			}

			// Token: 0x06008F55 RID: 36693 RVA: 0x00162B58 File Offset: 0x00160D58
			public void Insert(int index, object value)
			{
				object root = this._root;
				lock (root)
				{
					this._list.Insert(index, value);
				}
			}

			// Token: 0x06008F56 RID: 36694 RVA: 0x00162BA0 File Offset: 0x00160DA0
			public void Remove(object value)
			{
				object root = this._root;
				lock (root)
				{
					this._list.Remove(value);
				}
			}

			// Token: 0x06008F57 RID: 36695 RVA: 0x00162BE8 File Offset: 0x00160DE8
			public void RemoveAt(int index)
			{
				object root = this._root;
				lock (root)
				{
					this._list.RemoveAt(index);
				}
			}

			// Token: 0x040021D9 RID: 8665
			private readonly IList _list;

			// Token: 0x040021DA RID: 8666
			private readonly object _root;
		}

		// Token: 0x02000962 RID: 2402
		private sealed class FixedSizeList : IList, ICollection, IEnumerable
		{
			// Token: 0x06008F58 RID: 36696 RVA: 0x00162C30 File Offset: 0x00160E30
			internal FixedSizeList(IList l)
			{
				this._list = l;
			}

			// Token: 0x17001324 RID: 4900
			// (get) Token: 0x06008F59 RID: 36697 RVA: 0x00162C3F File Offset: 0x00160E3F
			public int Count
			{
				get
				{
					return this._list.Count;
				}
			}

			// Token: 0x17001325 RID: 4901
			// (get) Token: 0x06008F5A RID: 36698 RVA: 0x00162C4C File Offset: 0x00160E4C
			public bool IsReadOnly
			{
				get
				{
					return this._list.IsReadOnly;
				}
			}

			// Token: 0x17001326 RID: 4902
			// (get) Token: 0x06008F5B RID: 36699 RVA: 0x000070DD File Offset: 0x000052DD
			public bool IsFixedSize
			{
				get
				{
					return true;
				}
			}

			// Token: 0x17001327 RID: 4903
			// (get) Token: 0x06008F5C RID: 36700 RVA: 0x00162C59 File Offset: 0x00160E59
			public bool IsSynchronized
			{
				get
				{
					return this._list.IsSynchronized;
				}
			}

			// Token: 0x17001328 RID: 4904
			public object this[int index]
			{
				get
				{
					return this._list[index];
				}
				set
				{
					this._list[index] = value;
				}
			}

			// Token: 0x17001329 RID: 4905
			// (get) Token: 0x06008F5F RID: 36703 RVA: 0x00162C83 File Offset: 0x00160E83
			public object SyncRoot
			{
				get
				{
					return this._list.SyncRoot;
				}
			}

			// Token: 0x06008F60 RID: 36704 RVA: 0x00162C90 File Offset: 0x00160E90
			public int Add(object obj)
			{
				throw new NotSupportedException(SR.NotSupported_FixedSizeCollection);
			}

			// Token: 0x06008F61 RID: 36705 RVA: 0x00162C90 File Offset: 0x00160E90
			public void Clear()
			{
				throw new NotSupportedException(SR.NotSupported_FixedSizeCollection);
			}

			// Token: 0x06008F62 RID: 36706 RVA: 0x00162C9C File Offset: 0x00160E9C
			public bool Contains(object obj)
			{
				return this._list.Contains(obj);
			}

			// Token: 0x06008F63 RID: 36707 RVA: 0x00162CAA File Offset: 0x00160EAA
			public void CopyTo(Array array, int index)
			{
				this._list.CopyTo(array, index);
			}

			// Token: 0x06008F64 RID: 36708 RVA: 0x00162CB9 File Offset: 0x00160EB9
			public IEnumerator GetEnumerator()
			{
				return this._list.GetEnumerator();
			}

			// Token: 0x06008F65 RID: 36709 RVA: 0x00162CC6 File Offset: 0x00160EC6
			public int IndexOf(object value)
			{
				return this._list.IndexOf(value);
			}

			// Token: 0x06008F66 RID: 36710 RVA: 0x00162C90 File Offset: 0x00160E90
			public void Insert(int index, object obj)
			{
				throw new NotSupportedException(SR.NotSupported_FixedSizeCollection);
			}

			// Token: 0x06008F67 RID: 36711 RVA: 0x00162C90 File Offset: 0x00160E90
			public void Remove(object value)
			{
				throw new NotSupportedException(SR.NotSupported_FixedSizeCollection);
			}

			// Token: 0x06008F68 RID: 36712 RVA: 0x00162C90 File Offset: 0x00160E90
			public void RemoveAt(int index)
			{
				throw new NotSupportedException(SR.NotSupported_FixedSizeCollection);
			}

			// Token: 0x040021DB RID: 8667
			private readonly IList _list;
		}

		// Token: 0x02000963 RID: 2403
		private sealed class FixedSizeArrayList : ArrayList
		{
			// Token: 0x06008F69 RID: 36713 RVA: 0x00162CD4 File Offset: 0x00160ED4
			internal FixedSizeArrayList(ArrayList l)
			{
				this._list = l;
				this._version = this._list._version;
			}

			// Token: 0x1700132A RID: 4906
			// (get) Token: 0x06008F6A RID: 36714 RVA: 0x00162CF4 File Offset: 0x00160EF4
			public override int Count
			{
				get
				{
					return this._list.Count;
				}
			}

			// Token: 0x1700132B RID: 4907
			// (get) Token: 0x06008F6B RID: 36715 RVA: 0x00162D01 File Offset: 0x00160F01
			public override bool IsReadOnly
			{
				get
				{
					return this._list.IsReadOnly;
				}
			}

			// Token: 0x1700132C RID: 4908
			// (get) Token: 0x06008F6C RID: 36716 RVA: 0x000070DD File Offset: 0x000052DD
			public override bool IsFixedSize
			{
				get
				{
					return true;
				}
			}

			// Token: 0x1700132D RID: 4909
			// (get) Token: 0x06008F6D RID: 36717 RVA: 0x00162D0E File Offset: 0x00160F0E
			public override bool IsSynchronized
			{
				get
				{
					return this._list.IsSynchronized;
				}
			}

			// Token: 0x1700132E RID: 4910
			public override object this[int index]
			{
				get
				{
					return this._list[index];
				}
				set
				{
					this._list[index] = value;
					this._version = this._list._version;
				}
			}

			// Token: 0x1700132F RID: 4911
			// (get) Token: 0x06008F70 RID: 36720 RVA: 0x00162D49 File Offset: 0x00160F49
			public override object SyncRoot
			{
				get
				{
					return this._list.SyncRoot;
				}
			}

			// Token: 0x06008F71 RID: 36721 RVA: 0x00162C90 File Offset: 0x00160E90
			public override int Add(object obj)
			{
				throw new NotSupportedException(SR.NotSupported_FixedSizeCollection);
			}

			// Token: 0x06008F72 RID: 36722 RVA: 0x00162C90 File Offset: 0x00160E90
			public override void AddRange(ICollection c)
			{
				throw new NotSupportedException(SR.NotSupported_FixedSizeCollection);
			}

			// Token: 0x06008F73 RID: 36723 RVA: 0x00162D56 File Offset: 0x00160F56
			public override int BinarySearch(int index, int count, object value, IComparer comparer)
			{
				return this._list.BinarySearch(index, count, value, comparer);
			}

			// Token: 0x17001330 RID: 4912
			// (get) Token: 0x06008F74 RID: 36724 RVA: 0x00162D68 File Offset: 0x00160F68
			// (set) Token: 0x06008F75 RID: 36725 RVA: 0x00162C90 File Offset: 0x00160E90
			public override int Capacity
			{
				get
				{
					return this._list.Capacity;
				}
				set
				{
					throw new NotSupportedException(SR.NotSupported_FixedSizeCollection);
				}
			}

			// Token: 0x06008F76 RID: 36726 RVA: 0x00162C90 File Offset: 0x00160E90
			public override void Clear()
			{
				throw new NotSupportedException(SR.NotSupported_FixedSizeCollection);
			}

			// Token: 0x06008F77 RID: 36727 RVA: 0x00162D75 File Offset: 0x00160F75
			public override object Clone()
			{
				return new ArrayList.FixedSizeArrayList(this._list)
				{
					_list = (ArrayList)this._list.Clone()
				};
			}

			// Token: 0x06008F78 RID: 36728 RVA: 0x00162D98 File Offset: 0x00160F98
			public override bool Contains(object obj)
			{
				return this._list.Contains(obj);
			}

			// Token: 0x06008F79 RID: 36729 RVA: 0x00162DA6 File Offset: 0x00160FA6
			public override void CopyTo(Array array, int index)
			{
				this._list.CopyTo(array, index);
			}

			// Token: 0x06008F7A RID: 36730 RVA: 0x00162DB5 File Offset: 0x00160FB5
			public override void CopyTo(int index, Array array, int arrayIndex, int count)
			{
				this._list.CopyTo(index, array, arrayIndex, count);
			}

			// Token: 0x06008F7B RID: 36731 RVA: 0x00162DC7 File Offset: 0x00160FC7
			public override IEnumerator GetEnumerator()
			{
				return this._list.GetEnumerator();
			}

			// Token: 0x06008F7C RID: 36732 RVA: 0x00162DD4 File Offset: 0x00160FD4
			public override IEnumerator GetEnumerator(int index, int count)
			{
				return this._list.GetEnumerator(index, count);
			}

			// Token: 0x06008F7D RID: 36733 RVA: 0x00162DE3 File Offset: 0x00160FE3
			public override int IndexOf(object value)
			{
				return this._list.IndexOf(value);
			}

			// Token: 0x06008F7E RID: 36734 RVA: 0x00162DF1 File Offset: 0x00160FF1
			public override int IndexOf(object value, int startIndex)
			{
				return this._list.IndexOf(value, startIndex);
			}

			// Token: 0x06008F7F RID: 36735 RVA: 0x00162E00 File Offset: 0x00161000
			public override int IndexOf(object value, int startIndex, int count)
			{
				return this._list.IndexOf(value, startIndex, count);
			}

			// Token: 0x06008F80 RID: 36736 RVA: 0x00162C90 File Offset: 0x00160E90
			public override void Insert(int index, object obj)
			{
				throw new NotSupportedException(SR.NotSupported_FixedSizeCollection);
			}

			// Token: 0x06008F81 RID: 36737 RVA: 0x00162C90 File Offset: 0x00160E90
			public override void InsertRange(int index, ICollection c)
			{
				throw new NotSupportedException(SR.NotSupported_FixedSizeCollection);
			}

			// Token: 0x06008F82 RID: 36738 RVA: 0x00162E10 File Offset: 0x00161010
			public override int LastIndexOf(object value)
			{
				return this._list.LastIndexOf(value);
			}

			// Token: 0x06008F83 RID: 36739 RVA: 0x00162E1E File Offset: 0x0016101E
			public override int LastIndexOf(object value, int startIndex)
			{
				return this._list.LastIndexOf(value, startIndex);
			}

			// Token: 0x06008F84 RID: 36740 RVA: 0x00162E2D File Offset: 0x0016102D
			public override int LastIndexOf(object value, int startIndex, int count)
			{
				return this._list.LastIndexOf(value, startIndex, count);
			}

			// Token: 0x06008F85 RID: 36741 RVA: 0x00162C90 File Offset: 0x00160E90
			public override void Remove(object value)
			{
				throw new NotSupportedException(SR.NotSupported_FixedSizeCollection);
			}

			// Token: 0x06008F86 RID: 36742 RVA: 0x00162C90 File Offset: 0x00160E90
			public override void RemoveAt(int index)
			{
				throw new NotSupportedException(SR.NotSupported_FixedSizeCollection);
			}

			// Token: 0x06008F87 RID: 36743 RVA: 0x00162C90 File Offset: 0x00160E90
			public override void RemoveRange(int index, int count)
			{
				throw new NotSupportedException(SR.NotSupported_FixedSizeCollection);
			}

			// Token: 0x06008F88 RID: 36744 RVA: 0x00162E3D File Offset: 0x0016103D
			public override void SetRange(int index, ICollection c)
			{
				this._list.SetRange(index, c);
				this._version = this._list._version;
			}

			// Token: 0x06008F89 RID: 36745 RVA: 0x00162E5D File Offset: 0x0016105D
			public override ArrayList GetRange(int index, int count)
			{
				ArgumentOutOfRangeException.ThrowIfNegative<int>(index, "index");
				ArgumentOutOfRangeException.ThrowIfNegative<int>(count, "count");
				if (this.Count - index < count)
				{
					throw new ArgumentException(SR.Argument_InvalidOffLen);
				}
				return new ArrayList.Range(this, index, count);
			}

			// Token: 0x06008F8A RID: 36746 RVA: 0x00162E93 File Offset: 0x00161093
			public override void Reverse(int index, int count)
			{
				this._list.Reverse(index, count);
				this._version = this._list._version;
			}

			// Token: 0x06008F8B RID: 36747 RVA: 0x00162EB3 File Offset: 0x001610B3
			public override void Sort(int index, int count, IComparer comparer)
			{
				this._list.Sort(index, count, comparer);
				this._version = this._list._version;
			}

			// Token: 0x06008F8C RID: 36748 RVA: 0x00162ED4 File Offset: 0x001610D4
			public override object[] ToArray()
			{
				return this._list.ToArray();
			}

			// Token: 0x06008F8D RID: 36749 RVA: 0x00162EE1 File Offset: 0x001610E1
			[RequiresDynamicCode("The code for an array of the specified type might not be available.")]
			public override Array ToArray(Type type)
			{
				return this._list.ToArray(type);
			}

			// Token: 0x06008F8E RID: 36750 RVA: 0x00162C90 File Offset: 0x00160E90
			public override void TrimToSize()
			{
				throw new NotSupportedException(SR.NotSupported_FixedSizeCollection);
			}

			// Token: 0x040021DC RID: 8668
			private ArrayList _list;
		}

		// Token: 0x02000964 RID: 2404
		private sealed class ReadOnlyList : IList, ICollection, IEnumerable
		{
			// Token: 0x06008F8F RID: 36751 RVA: 0x00162EEF File Offset: 0x001610EF
			internal ReadOnlyList(IList l)
			{
				this._list = l;
			}

			// Token: 0x17001331 RID: 4913
			// (get) Token: 0x06008F90 RID: 36752 RVA: 0x00162EFE File Offset: 0x001610FE
			public int Count
			{
				get
				{
					return this._list.Count;
				}
			}

			// Token: 0x17001332 RID: 4914
			// (get) Token: 0x06008F91 RID: 36753 RVA: 0x000070DD File Offset: 0x000052DD
			public bool IsReadOnly
			{
				get
				{
					return true;
				}
			}

			// Token: 0x17001333 RID: 4915
			// (get) Token: 0x06008F92 RID: 36754 RVA: 0x000070DD File Offset: 0x000052DD
			public bool IsFixedSize
			{
				get
				{
					return true;
				}
			}

			// Token: 0x17001334 RID: 4916
			// (get) Token: 0x06008F93 RID: 36755 RVA: 0x00162F0B File Offset: 0x0016110B
			public bool IsSynchronized
			{
				get
				{
					return this._list.IsSynchronized;
				}
			}

			// Token: 0x17001335 RID: 4917
			public object this[int index]
			{
				get
				{
					return this._list[index];
				}
				set
				{
					throw new NotSupportedException(SR.NotSupported_ReadOnlyCollection);
				}
			}

			// Token: 0x17001336 RID: 4918
			// (get) Token: 0x06008F96 RID: 36758 RVA: 0x00162F32 File Offset: 0x00161132
			public object SyncRoot
			{
				get
				{
					return this._list.SyncRoot;
				}
			}

			// Token: 0x06008F97 RID: 36759 RVA: 0x00162F26 File Offset: 0x00161126
			public int Add(object obj)
			{
				throw new NotSupportedException(SR.NotSupported_ReadOnlyCollection);
			}

			// Token: 0x06008F98 RID: 36760 RVA: 0x00162F26 File Offset: 0x00161126
			public void Clear()
			{
				throw new NotSupportedException(SR.NotSupported_ReadOnlyCollection);
			}

			// Token: 0x06008F99 RID: 36761 RVA: 0x00162F3F File Offset: 0x0016113F
			public bool Contains(object obj)
			{
				return this._list.Contains(obj);
			}

			// Token: 0x06008F9A RID: 36762 RVA: 0x00162F4D File Offset: 0x0016114D
			public void CopyTo(Array array, int index)
			{
				this._list.CopyTo(array, index);
			}

			// Token: 0x06008F9B RID: 36763 RVA: 0x00162F5C File Offset: 0x0016115C
			public IEnumerator GetEnumerator()
			{
				return this._list.GetEnumerator();
			}

			// Token: 0x06008F9C RID: 36764 RVA: 0x00162F69 File Offset: 0x00161169
			public int IndexOf(object value)
			{
				return this._list.IndexOf(value);
			}

			// Token: 0x06008F9D RID: 36765 RVA: 0x00162F26 File Offset: 0x00161126
			public void Insert(int index, object obj)
			{
				throw new NotSupportedException(SR.NotSupported_ReadOnlyCollection);
			}

			// Token: 0x06008F9E RID: 36766 RVA: 0x00162F26 File Offset: 0x00161126
			public void Remove(object value)
			{
				throw new NotSupportedException(SR.NotSupported_ReadOnlyCollection);
			}

			// Token: 0x06008F9F RID: 36767 RVA: 0x00162F26 File Offset: 0x00161126
			public void RemoveAt(int index)
			{
				throw new NotSupportedException(SR.NotSupported_ReadOnlyCollection);
			}

			// Token: 0x040021DD RID: 8669
			private readonly IList _list;
		}

		// Token: 0x02000965 RID: 2405
		private sealed class ReadOnlyArrayList : ArrayList
		{
			// Token: 0x06008FA0 RID: 36768 RVA: 0x00162F77 File Offset: 0x00161177
			internal ReadOnlyArrayList(ArrayList l)
			{
				this._list = l;
			}

			// Token: 0x17001337 RID: 4919
			// (get) Token: 0x06008FA1 RID: 36769 RVA: 0x00162F86 File Offset: 0x00161186
			public override int Count
			{
				get
				{
					return this._list.Count;
				}
			}

			// Token: 0x17001338 RID: 4920
			// (get) Token: 0x06008FA2 RID: 36770 RVA: 0x000070DD File Offset: 0x000052DD
			public override bool IsReadOnly
			{
				get
				{
					return true;
				}
			}

			// Token: 0x17001339 RID: 4921
			// (get) Token: 0x06008FA3 RID: 36771 RVA: 0x000070DD File Offset: 0x000052DD
			public override bool IsFixedSize
			{
				get
				{
					return true;
				}
			}

			// Token: 0x1700133A RID: 4922
			// (get) Token: 0x06008FA4 RID: 36772 RVA: 0x00162F93 File Offset: 0x00161193
			public override bool IsSynchronized
			{
				get
				{
					return this._list.IsSynchronized;
				}
			}

			// Token: 0x1700133B RID: 4923
			public override object this[int index]
			{
				get
				{
					return this._list[index];
				}
				set
				{
					throw new NotSupportedException(SR.NotSupported_ReadOnlyCollection);
				}
			}

			// Token: 0x1700133C RID: 4924
			// (get) Token: 0x06008FA7 RID: 36775 RVA: 0x00162FAE File Offset: 0x001611AE
			public override object SyncRoot
			{
				get
				{
					return this._list.SyncRoot;
				}
			}

			// Token: 0x06008FA8 RID: 36776 RVA: 0x00162F26 File Offset: 0x00161126
			public override int Add(object obj)
			{
				throw new NotSupportedException(SR.NotSupported_ReadOnlyCollection);
			}

			// Token: 0x06008FA9 RID: 36777 RVA: 0x00162F26 File Offset: 0x00161126
			public override void AddRange(ICollection c)
			{
				throw new NotSupportedException(SR.NotSupported_ReadOnlyCollection);
			}

			// Token: 0x06008FAA RID: 36778 RVA: 0x00162FBB File Offset: 0x001611BB
			public override int BinarySearch(int index, int count, object value, IComparer comparer)
			{
				return this._list.BinarySearch(index, count, value, comparer);
			}

			// Token: 0x1700133D RID: 4925
			// (get) Token: 0x06008FAB RID: 36779 RVA: 0x00162FCD File Offset: 0x001611CD
			// (set) Token: 0x06008FAC RID: 36780 RVA: 0x00162F26 File Offset: 0x00161126
			public override int Capacity
			{
				get
				{
					return this._list.Capacity;
				}
				set
				{
					throw new NotSupportedException(SR.NotSupported_ReadOnlyCollection);
				}
			}

			// Token: 0x06008FAD RID: 36781 RVA: 0x00162F26 File Offset: 0x00161126
			public override void Clear()
			{
				throw new NotSupportedException(SR.NotSupported_ReadOnlyCollection);
			}

			// Token: 0x06008FAE RID: 36782 RVA: 0x00162FDA File Offset: 0x001611DA
			public override object Clone()
			{
				return new ArrayList.ReadOnlyArrayList(this._list)
				{
					_list = (ArrayList)this._list.Clone()
				};
			}

			// Token: 0x06008FAF RID: 36783 RVA: 0x00162FFD File Offset: 0x001611FD
			public override bool Contains(object obj)
			{
				return this._list.Contains(obj);
			}

			// Token: 0x06008FB0 RID: 36784 RVA: 0x0016300B File Offset: 0x0016120B
			public override void CopyTo(Array array, int index)
			{
				this._list.CopyTo(array, index);
			}

			// Token: 0x06008FB1 RID: 36785 RVA: 0x0016301A File Offset: 0x0016121A
			public override void CopyTo(int index, Array array, int arrayIndex, int count)
			{
				this._list.CopyTo(index, array, arrayIndex, count);
			}

			// Token: 0x06008FB2 RID: 36786 RVA: 0x0016302C File Offset: 0x0016122C
			public override IEnumerator GetEnumerator()
			{
				return this._list.GetEnumerator();
			}

			// Token: 0x06008FB3 RID: 36787 RVA: 0x00163039 File Offset: 0x00161239
			public override IEnumerator GetEnumerator(int index, int count)
			{
				return this._list.GetEnumerator(index, count);
			}

			// Token: 0x06008FB4 RID: 36788 RVA: 0x00163048 File Offset: 0x00161248
			public override int IndexOf(object value)
			{
				return this._list.IndexOf(value);
			}

			// Token: 0x06008FB5 RID: 36789 RVA: 0x00163056 File Offset: 0x00161256
			public override int IndexOf(object value, int startIndex)
			{
				return this._list.IndexOf(value, startIndex);
			}

			// Token: 0x06008FB6 RID: 36790 RVA: 0x00163065 File Offset: 0x00161265
			public override int IndexOf(object value, int startIndex, int count)
			{
				return this._list.IndexOf(value, startIndex, count);
			}

			// Token: 0x06008FB7 RID: 36791 RVA: 0x00162F26 File Offset: 0x00161126
			public override void Insert(int index, object obj)
			{
				throw new NotSupportedException(SR.NotSupported_ReadOnlyCollection);
			}

			// Token: 0x06008FB8 RID: 36792 RVA: 0x00162F26 File Offset: 0x00161126
			public override void InsertRange(int index, ICollection c)
			{
				throw new NotSupportedException(SR.NotSupported_ReadOnlyCollection);
			}

			// Token: 0x06008FB9 RID: 36793 RVA: 0x00163075 File Offset: 0x00161275
			public override int LastIndexOf(object value)
			{
				return this._list.LastIndexOf(value);
			}

			// Token: 0x06008FBA RID: 36794 RVA: 0x00163083 File Offset: 0x00161283
			public override int LastIndexOf(object value, int startIndex)
			{
				return this._list.LastIndexOf(value, startIndex);
			}

			// Token: 0x06008FBB RID: 36795 RVA: 0x00163092 File Offset: 0x00161292
			public override int LastIndexOf(object value, int startIndex, int count)
			{
				return this._list.LastIndexOf(value, startIndex, count);
			}

			// Token: 0x06008FBC RID: 36796 RVA: 0x00162F26 File Offset: 0x00161126
			public override void Remove(object value)
			{
				throw new NotSupportedException(SR.NotSupported_ReadOnlyCollection);
			}

			// Token: 0x06008FBD RID: 36797 RVA: 0x00162F26 File Offset: 0x00161126
			public override void RemoveAt(int index)
			{
				throw new NotSupportedException(SR.NotSupported_ReadOnlyCollection);
			}

			// Token: 0x06008FBE RID: 36798 RVA: 0x00162F26 File Offset: 0x00161126
			public override void RemoveRange(int index, int count)
			{
				throw new NotSupportedException(SR.NotSupported_ReadOnlyCollection);
			}

			// Token: 0x06008FBF RID: 36799 RVA: 0x00162F26 File Offset: 0x00161126
			public override void SetRange(int index, ICollection c)
			{
				throw new NotSupportedException(SR.NotSupported_ReadOnlyCollection);
			}

			// Token: 0x06008FC0 RID: 36800 RVA: 0x00162E5D File Offset: 0x0016105D
			public override ArrayList GetRange(int index, int count)
			{
				ArgumentOutOfRangeException.ThrowIfNegative<int>(index, "index");
				ArgumentOutOfRangeException.ThrowIfNegative<int>(count, "count");
				if (this.Count - index < count)
				{
					throw new ArgumentException(SR.Argument_InvalidOffLen);
				}
				return new ArrayList.Range(this, index, count);
			}

			// Token: 0x06008FC1 RID: 36801 RVA: 0x00162F26 File Offset: 0x00161126
			public override void Reverse(int index, int count)
			{
				throw new NotSupportedException(SR.NotSupported_ReadOnlyCollection);
			}

			// Token: 0x06008FC2 RID: 36802 RVA: 0x00162F26 File Offset: 0x00161126
			public override void Sort(int index, int count, IComparer comparer)
			{
				throw new NotSupportedException(SR.NotSupported_ReadOnlyCollection);
			}

			// Token: 0x06008FC3 RID: 36803 RVA: 0x001630A2 File Offset: 0x001612A2
			public override object[] ToArray()
			{
				return this._list.ToArray();
			}

			// Token: 0x06008FC4 RID: 36804 RVA: 0x001630AF File Offset: 0x001612AF
			[RequiresDynamicCode("The code for an array of the specified type might not be available.")]
			public override Array ToArray(Type type)
			{
				return this._list.ToArray(type);
			}

			// Token: 0x06008FC5 RID: 36805 RVA: 0x00162F26 File Offset: 0x00161126
			public override void TrimToSize()
			{
				throw new NotSupportedException(SR.NotSupported_ReadOnlyCollection);
			}

			// Token: 0x040021DE RID: 8670
			private ArrayList _list;
		}

		// Token: 0x02000966 RID: 2406
		private sealed class ArrayListEnumerator : IEnumerator, ICloneable
		{
			// Token: 0x06008FC6 RID: 36806 RVA: 0x001630BD File Offset: 0x001612BD
			internal ArrayListEnumerator(ArrayList list, int index, int count)
			{
				this._list = list;
				this._startIndex = index;
				this._index = index - 1;
				this._endIndex = this._index + count;
				this._version = list._version;
				this._currentElement = null;
			}

			// Token: 0x06008FC7 RID: 36807 RVA: 0x00007BA1 File Offset: 0x00005DA1
			public object Clone()
			{
				return base.MemberwiseClone();
			}

			// Token: 0x06008FC8 RID: 36808 RVA: 0x00163100 File Offset: 0x00161300
			public bool MoveNext()
			{
				if (this._version != this._list._version)
				{
					throw new InvalidOperationException(SR.InvalidOperation_EnumFailedVersion);
				}
				if (this._index < this._endIndex)
				{
					ArrayList list = this._list;
					int index = this._index + 1;
					this._index = index;
					this._currentElement = list[index];
					return true;
				}
				this._index = this._endIndex + 1;
				return false;
			}

			// Token: 0x1700133E RID: 4926
			// (get) Token: 0x06008FC9 RID: 36809 RVA: 0x0016316C File Offset: 0x0016136C
			public object Current
			{
				get
				{
					if (this._index < this._startIndex)
					{
						throw new InvalidOperationException(SR.InvalidOperation_EnumNotStarted);
					}
					if (this._index > this._endIndex)
					{
						throw new InvalidOperationException(SR.InvalidOperation_EnumEnded);
					}
					return this._currentElement;
				}
			}

			// Token: 0x06008FCA RID: 36810 RVA: 0x001631A6 File Offset: 0x001613A6
			public void Reset()
			{
				if (this._version != this._list._version)
				{
					throw new InvalidOperationException(SR.InvalidOperation_EnumFailedVersion);
				}
				this._index = this._startIndex - 1;
			}

			// Token: 0x040021DF RID: 8671
			private readonly ArrayList _list;

			// Token: 0x040021E0 RID: 8672
			private int _index;

			// Token: 0x040021E1 RID: 8673
			private readonly int _endIndex;

			// Token: 0x040021E2 RID: 8674
			private readonly int _version;

			// Token: 0x040021E3 RID: 8675
			private object _currentElement;

			// Token: 0x040021E4 RID: 8676
			private readonly int _startIndex;
		}

		// Token: 0x02000967 RID: 2407
		private sealed class Range : ArrayList
		{
			// Token: 0x06008FCB RID: 36811 RVA: 0x001631D4 File Offset: 0x001613D4
			internal Range(ArrayList list, int index, int count)
			{
				this._baseList = list;
				this._baseIndex = index;
				this._baseSize = count;
				this._baseVersion = list._version;
				this._version = list._version;
			}

			// Token: 0x06008FCC RID: 36812 RVA: 0x00163209 File Offset: 0x00161409
			private void InternalUpdateRange()
			{
				if (this._baseVersion != this._baseList._version)
				{
					throw new InvalidOperationException(SR.InvalidOperation_UnderlyingArrayListChanged);
				}
			}

			// Token: 0x06008FCD RID: 36813 RVA: 0x00163229 File Offset: 0x00161429
			private void InternalUpdateVersion()
			{
				this._baseVersion++;
				this._version++;
			}

			// Token: 0x06008FCE RID: 36814 RVA: 0x00163248 File Offset: 0x00161448
			public override int Add(object value)
			{
				this.InternalUpdateRange();
				this._baseList.Insert(this._baseIndex + this._baseSize, value);
				this.InternalUpdateVersion();
				int baseSize = this._baseSize;
				this._baseSize = baseSize + 1;
				return baseSize;
			}

			// Token: 0x06008FCF RID: 36815 RVA: 0x0016328C File Offset: 0x0016148C
			public override void AddRange(ICollection c)
			{
				ArgumentNullException.ThrowIfNull(c, "c");
				this.InternalUpdateRange();
				int count = c.Count;
				if (count > 0)
				{
					this._baseList.InsertRange(this._baseIndex + this._baseSize, c);
					this.InternalUpdateVersion();
					this._baseSize += count;
				}
			}

			// Token: 0x06008FD0 RID: 36816 RVA: 0x001632E4 File Offset: 0x001614E4
			public override int BinarySearch(int index, int count, object value, IComparer comparer)
			{
				ArgumentOutOfRangeException.ThrowIfNegative<int>(index, "index");
				ArgumentOutOfRangeException.ThrowIfNegative<int>(count, "count");
				if (this._baseSize - index < count)
				{
					throw new ArgumentException(SR.Argument_InvalidOffLen);
				}
				this.InternalUpdateRange();
				int num = this._baseList.BinarySearch(this._baseIndex + index, count, value, comparer);
				if (num >= 0)
				{
					return num - this._baseIndex;
				}
				return num + this._baseIndex;
			}

			// Token: 0x1700133F RID: 4927
			// (get) Token: 0x06008FD1 RID: 36817 RVA: 0x00163350 File Offset: 0x00161550
			// (set) Token: 0x06008FD2 RID: 36818 RVA: 0x00161431 File Offset: 0x0015F631
			public override int Capacity
			{
				get
				{
					return this._baseList.Capacity;
				}
				set
				{
					if (value < this.Count)
					{
						throw new ArgumentOutOfRangeException("value", SR.ArgumentOutOfRange_SmallCapacity);
					}
				}
			}

			// Token: 0x06008FD3 RID: 36819 RVA: 0x0016335D File Offset: 0x0016155D
			public override void Clear()
			{
				this.InternalUpdateRange();
				if (this._baseSize != 0)
				{
					this._baseList.RemoveRange(this._baseIndex, this._baseSize);
					this.InternalUpdateVersion();
					this._baseSize = 0;
				}
			}

			// Token: 0x06008FD4 RID: 36820 RVA: 0x00163391 File Offset: 0x00161591
			public override object Clone()
			{
				this.InternalUpdateRange();
				return new ArrayList.Range(this._baseList, this._baseIndex, this._baseSize)
				{
					_baseList = (ArrayList)this._baseList.Clone()
				};
			}

			// Token: 0x06008FD5 RID: 36821 RVA: 0x001633C8 File Offset: 0x001615C8
			public override bool Contains(object item)
			{
				this.InternalUpdateRange();
				if (item == null)
				{
					for (int i = 0; i < this._baseSize; i++)
					{
						if (this._baseList[this._baseIndex + i] == null)
						{
							return true;
						}
					}
					return false;
				}
				for (int j = 0; j < this._baseSize; j++)
				{
					object obj = this._baseList[this._baseIndex + j];
					if (obj != null && obj.Equals(item))
					{
						return true;
					}
				}
				return false;
			}

			// Token: 0x06008FD6 RID: 36822 RVA: 0x0016343C File Offset: 0x0016163C
			public override void CopyTo(Array array, int index)
			{
				ArgumentNullException.ThrowIfNull(array, "array");
				if (array.Rank != 1)
				{
					throw new ArgumentException(SR.Arg_RankMultiDimNotSupported, "array");
				}
				ArgumentOutOfRangeException.ThrowIfNegative<int>(index, "index");
				if (array.Length - index < this._baseSize)
				{
					throw new ArgumentException(SR.Argument_InvalidOffLen);
				}
				this.InternalUpdateRange();
				this._baseList.CopyTo(this._baseIndex, array, index, this._baseSize);
			}

			// Token: 0x06008FD7 RID: 36823 RVA: 0x001634B4 File Offset: 0x001616B4
			public override void CopyTo(int index, Array array, int arrayIndex, int count)
			{
				ArgumentNullException.ThrowIfNull(array, "array");
				if (array.Rank != 1)
				{
					throw new ArgumentException(SR.Arg_RankMultiDimNotSupported, "array");
				}
				ArgumentOutOfRangeException.ThrowIfNegative<int>(index, "index");
				ArgumentOutOfRangeException.ThrowIfNegative<int>(count, "count");
				if (array.Length - arrayIndex < count)
				{
					throw new ArgumentException(SR.Argument_InvalidOffLen);
				}
				if (this._baseSize - index < count)
				{
					throw new ArgumentException(SR.Argument_InvalidOffLen);
				}
				this.InternalUpdateRange();
				this._baseList.CopyTo(this._baseIndex + index, array, arrayIndex, count);
			}

			// Token: 0x17001340 RID: 4928
			// (get) Token: 0x06008FD8 RID: 36824 RVA: 0x00163547 File Offset: 0x00161747
			public override int Count
			{
				get
				{
					this.InternalUpdateRange();
					return this._baseSize;
				}
			}

			// Token: 0x17001341 RID: 4929
			// (get) Token: 0x06008FD9 RID: 36825 RVA: 0x00163555 File Offset: 0x00161755
			public override bool IsReadOnly
			{
				get
				{
					return this._baseList.IsReadOnly;
				}
			}

			// Token: 0x17001342 RID: 4930
			// (get) Token: 0x06008FDA RID: 36826 RVA: 0x00163562 File Offset: 0x00161762
			public override bool IsFixedSize
			{
				get
				{
					return this._baseList.IsFixedSize;
				}
			}

			// Token: 0x17001343 RID: 4931
			// (get) Token: 0x06008FDB RID: 36827 RVA: 0x0016356F File Offset: 0x0016176F
			public override bool IsSynchronized
			{
				get
				{
					return this._baseList.IsSynchronized;
				}
			}

			// Token: 0x06008FDC RID: 36828 RVA: 0x0016357C File Offset: 0x0016177C
			public override IEnumerator GetEnumerator()
			{
				return this.GetEnumerator(0, this._baseSize);
			}

			// Token: 0x06008FDD RID: 36829 RVA: 0x0016358C File Offset: 0x0016178C
			public override IEnumerator GetEnumerator(int index, int count)
			{
				ArgumentOutOfRangeException.ThrowIfNegative<int>(index, "index");
				ArgumentOutOfRangeException.ThrowIfNegative<int>(count, "count");
				if (this._baseSize - index < count)
				{
					throw new ArgumentException(SR.Argument_InvalidOffLen);
				}
				this.InternalUpdateRange();
				return this._baseList.GetEnumerator(this._baseIndex + index, count);
			}

			// Token: 0x06008FDE RID: 36830 RVA: 0x001635DF File Offset: 0x001617DF
			public override ArrayList GetRange(int index, int count)
			{
				ArgumentOutOfRangeException.ThrowIfNegative<int>(index, "index");
				ArgumentOutOfRangeException.ThrowIfNegative<int>(count, "count");
				if (this._baseSize - index < count)
				{
					throw new ArgumentException(SR.Argument_InvalidOffLen);
				}
				this.InternalUpdateRange();
				return new ArrayList.Range(this, index, count);
			}

			// Token: 0x17001344 RID: 4932
			// (get) Token: 0x06008FDF RID: 36831 RVA: 0x0016361B File Offset: 0x0016181B
			public override object SyncRoot
			{
				get
				{
					return this._baseList.SyncRoot;
				}
			}

			// Token: 0x06008FE0 RID: 36832 RVA: 0x00163628 File Offset: 0x00161828
			public override int IndexOf(object value)
			{
				this.InternalUpdateRange();
				int num = this._baseList.IndexOf(value, this._baseIndex, this._baseSize);
				if (num >= 0)
				{
					return num - this._baseIndex;
				}
				return -1;
			}

			// Token: 0x06008FE1 RID: 36833 RVA: 0x00163664 File Offset: 0x00161864
			public override int IndexOf(object value, int startIndex)
			{
				ArgumentOutOfRangeException.ThrowIfNegative<int>(startIndex, "startIndex");
				if (startIndex > this._baseSize)
				{
					throw new ArgumentOutOfRangeException("startIndex", SR.ArgumentOutOfRange_IndexMustBeLessOrEqual);
				}
				this.InternalUpdateRange();
				int num = this._baseList.IndexOf(value, this._baseIndex + startIndex, this._baseSize - startIndex);
				if (num >= 0)
				{
					return num - this._baseIndex;
				}
				return -1;
			}

			// Token: 0x06008FE2 RID: 36834 RVA: 0x001636C8 File Offset: 0x001618C8
			public override int IndexOf(object value, int startIndex, int count)
			{
				if (startIndex < 0 || startIndex > this._baseSize)
				{
					throw new ArgumentOutOfRangeException("startIndex", SR.ArgumentOutOfRange_IndexMustBeLessOrEqual);
				}
				if (count < 0 || startIndex > this._baseSize - count)
				{
					throw new ArgumentOutOfRangeException("count", SR.ArgumentOutOfRange_Count);
				}
				this.InternalUpdateRange();
				int num = this._baseList.IndexOf(value, this._baseIndex + startIndex, count);
				if (num >= 0)
				{
					return num - this._baseIndex;
				}
				return -1;
			}

			// Token: 0x06008FE3 RID: 36835 RVA: 0x0016373C File Offset: 0x0016193C
			public override void Insert(int index, object value)
			{
				if (index < 0 || index > this._baseSize)
				{
					throw new ArgumentOutOfRangeException("index", SR.ArgumentOutOfRange_IndexMustBeLessOrEqual);
				}
				this.InternalUpdateRange();
				this._baseList.Insert(this._baseIndex + index, value);
				this.InternalUpdateVersion();
				this._baseSize++;
			}

			// Token: 0x06008FE4 RID: 36836 RVA: 0x00163794 File Offset: 0x00161994
			public override void InsertRange(int index, ICollection c)
			{
				if (index < 0 || index > this._baseSize)
				{
					throw new ArgumentOutOfRangeException("index", SR.ArgumentOutOfRange_IndexMustBeLessOrEqual);
				}
				ArgumentNullException.ThrowIfNull(c, "c");
				this.InternalUpdateRange();
				int count = c.Count;
				if (count > 0)
				{
					this._baseList.InsertRange(this._baseIndex + index, c);
					this._baseSize += count;
					this.InternalUpdateVersion();
				}
			}

			// Token: 0x06008FE5 RID: 36837 RVA: 0x00163804 File Offset: 0x00161A04
			public override int LastIndexOf(object value)
			{
				this.InternalUpdateRange();
				int num = this._baseList.LastIndexOf(value, this._baseIndex + this._baseSize - 1, this._baseSize);
				if (num >= 0)
				{
					return num - this._baseIndex;
				}
				return -1;
			}

			// Token: 0x06008FE6 RID: 36838 RVA: 0x00161836 File Offset: 0x0015FA36
			public override int LastIndexOf(object value, int startIndex)
			{
				return this.LastIndexOf(value, startIndex, startIndex + 1);
			}

			// Token: 0x06008FE7 RID: 36839 RVA: 0x00163848 File Offset: 0x00161A48
			public override int LastIndexOf(object value, int startIndex, int count)
			{
				this.InternalUpdateRange();
				if (this._baseSize == 0)
				{
					return -1;
				}
				if (startIndex >= this._baseSize)
				{
					throw new ArgumentOutOfRangeException("startIndex", SR.ArgumentOutOfRange_IndexMustBeLess);
				}
				ArgumentOutOfRangeException.ThrowIfNegative<int>(startIndex, "startIndex");
				int num = this._baseList.LastIndexOf(value, this._baseIndex + startIndex, count);
				if (num >= 0)
				{
					return num - this._baseIndex;
				}
				return -1;
			}

			// Token: 0x06008FE8 RID: 36840 RVA: 0x001638B0 File Offset: 0x00161AB0
			public override void RemoveAt(int index)
			{
				if (index < 0 || index >= this._baseSize)
				{
					throw new ArgumentOutOfRangeException("index", SR.ArgumentOutOfRange_IndexMustBeLess);
				}
				this.InternalUpdateRange();
				this._baseList.RemoveAt(this._baseIndex + index);
				this.InternalUpdateVersion();
				this._baseSize--;
			}

			// Token: 0x06008FE9 RID: 36841 RVA: 0x00163908 File Offset: 0x00161B08
			public override void RemoveRange(int index, int count)
			{
				ArgumentOutOfRangeException.ThrowIfNegative<int>(index, "index");
				ArgumentOutOfRangeException.ThrowIfNegative<int>(count, "count");
				if (this._baseSize - index < count)
				{
					throw new ArgumentException(SR.Argument_InvalidOffLen);
				}
				this.InternalUpdateRange();
				if (count > 0)
				{
					this._baseList.RemoveRange(this._baseIndex + index, count);
					this.InternalUpdateVersion();
					this._baseSize -= count;
				}
			}

			// Token: 0x06008FEA RID: 36842 RVA: 0x00163974 File Offset: 0x00161B74
			public override void Reverse(int index, int count)
			{
				ArgumentOutOfRangeException.ThrowIfNegative<int>(index, "index");
				ArgumentOutOfRangeException.ThrowIfNegative<int>(count, "count");
				if (this._baseSize - index < count)
				{
					throw new ArgumentException(SR.Argument_InvalidOffLen);
				}
				this.InternalUpdateRange();
				this._baseList.Reverse(this._baseIndex + index, count);
				this.InternalUpdateVersion();
			}

			// Token: 0x06008FEB RID: 36843 RVA: 0x001639D0 File Offset: 0x00161BD0
			public override void SetRange(int index, ICollection c)
			{
				this.InternalUpdateRange();
				if (index < 0 || index >= this._baseSize)
				{
					throw new ArgumentOutOfRangeException("index", SR.ArgumentOutOfRange_IndexMustBeLess);
				}
				this._baseList.SetRange(this._baseIndex + index, c);
				if (c.Count > 0)
				{
					this.InternalUpdateVersion();
				}
			}

			// Token: 0x06008FEC RID: 36844 RVA: 0x00163A24 File Offset: 0x00161C24
			public override void Sort(int index, int count, IComparer comparer)
			{
				ArgumentOutOfRangeException.ThrowIfNegative<int>(index, "index");
				ArgumentOutOfRangeException.ThrowIfNegative<int>(count, "count");
				if (this._baseSize - index < count)
				{
					throw new ArgumentException(SR.Argument_InvalidOffLen);
				}
				this.InternalUpdateRange();
				this._baseList.Sort(this._baseIndex + index, count, comparer);
				this.InternalUpdateVersion();
			}

			// Token: 0x17001345 RID: 4933
			public override object this[int index]
			{
				get
				{
					this.InternalUpdateRange();
					if (index < 0 || index >= this._baseSize)
					{
						throw new ArgumentOutOfRangeException("index", SR.ArgumentOutOfRange_IndexMustBeLess);
					}
					return this._baseList[this._baseIndex + index];
				}
				set
				{
					this.InternalUpdateRange();
					if (index < 0 || index >= this._baseSize)
					{
						throw new ArgumentOutOfRangeException("index", SR.ArgumentOutOfRange_IndexMustBeLess);
					}
					this._baseList[this._baseIndex + index] = value;
					this.InternalUpdateVersion();
				}
			}

			// Token: 0x06008FEF RID: 36847 RVA: 0x00163AF8 File Offset: 0x00161CF8
			public override object[] ToArray()
			{
				this.InternalUpdateRange();
				if (this._baseSize == 0)
				{
					return Array.Empty<object>();
				}
				object[] array = new object[this._baseSize];
				this._baseList.CopyTo(this._baseIndex, array, 0, this._baseSize);
				return array;
			}

			// Token: 0x06008FF0 RID: 36848 RVA: 0x00163B40 File Offset: 0x00161D40
			[RequiresDynamicCode("The code for an array of the specified type might not be available.")]
			public override Array ToArray(Type type)
			{
				ArgumentNullException.ThrowIfNull(type, "type");
				this.InternalUpdateRange();
				Array array = Array.CreateInstance(type, this._baseSize);
				this._baseList.CopyTo(this._baseIndex, array, 0, this._baseSize);
				return array;
			}

			// Token: 0x06008FF1 RID: 36849 RVA: 0x00163B85 File Offset: 0x00161D85
			public override void TrimToSize()
			{
				throw new NotSupportedException(SR.NotSupported_RangeCollection);
			}

			// Token: 0x040021E5 RID: 8677
			private ArrayList _baseList;

			// Token: 0x040021E6 RID: 8678
			private readonly int _baseIndex;

			// Token: 0x040021E7 RID: 8679
			private int _baseSize;

			// Token: 0x040021E8 RID: 8680
			private int _baseVersion;
		}

		// Token: 0x02000968 RID: 2408
		private sealed class ArrayListEnumeratorSimple : IEnumerator, ICloneable
		{
			// Token: 0x06008FF2 RID: 36850 RVA: 0x00163B94 File Offset: 0x00161D94
			internal ArrayListEnumeratorSimple(ArrayList list)
			{
				this._list = list;
				this._index = -1;
				this._version = list._version;
				this._isArrayList = (list.GetType() == typeof(ArrayList));
				this._currentElement = ArrayList.ArrayListEnumeratorSimple.s_dummyObject;
			}

			// Token: 0x06008FF3 RID: 36851 RVA: 0x00007BA1 File Offset: 0x00005DA1
			public object Clone()
			{
				return base.MemberwiseClone();
			}

			// Token: 0x06008FF4 RID: 36852 RVA: 0x00163BE8 File Offset: 0x00161DE8
			public bool MoveNext()
			{
				if (this._version != this._list._version)
				{
					throw new InvalidOperationException(SR.InvalidOperation_EnumFailedVersion);
				}
				if (this._isArrayList)
				{
					if (this._index < this._list._size - 1)
					{
						object[] items = this._list._items;
						int num = this._index + 1;
						this._index = num;
						this._currentElement = items[num];
						return true;
					}
					this._currentElement = ArrayList.ArrayListEnumeratorSimple.s_dummyObject;
					this._index = this._list._size;
					return false;
				}
				else
				{
					if (this._index < this._list.Count - 1)
					{
						ArrayList list = this._list;
						int num = this._index + 1;
						this._index = num;
						this._currentElement = list[num];
						return true;
					}
					this._index = this._list.Count;
					this._currentElement = ArrayList.ArrayListEnumeratorSimple.s_dummyObject;
					return false;
				}
			}

			// Token: 0x17001346 RID: 4934
			// (get) Token: 0x06008FF5 RID: 36853 RVA: 0x00163CCC File Offset: 0x00161ECC
			public object Current
			{
				get
				{
					object currentElement = this._currentElement;
					if (ArrayList.ArrayListEnumeratorSimple.s_dummyObject != currentElement)
					{
						return currentElement;
					}
					if (this._index == -1)
					{
						throw new InvalidOperationException(SR.InvalidOperation_EnumNotStarted);
					}
					throw new InvalidOperationException(SR.InvalidOperation_EnumEnded);
				}
			}

			// Token: 0x06008FF6 RID: 36854 RVA: 0x00163D08 File Offset: 0x00161F08
			public void Reset()
			{
				if (this._version != this._list._version)
				{
					throw new InvalidOperationException(SR.InvalidOperation_EnumFailedVersion);
				}
				this._currentElement = ArrayList.ArrayListEnumeratorSimple.s_dummyObject;
				this._index = -1;
			}

			// Token: 0x040021E9 RID: 8681
			private readonly ArrayList _list;

			// Token: 0x040021EA RID: 8682
			private int _index;

			// Token: 0x040021EB RID: 8683
			private readonly int _version;

			// Token: 0x040021EC RID: 8684
			private object _currentElement;

			// Token: 0x040021ED RID: 8685
			private readonly bool _isArrayList;

			// Token: 0x040021EE RID: 8686
			private static readonly object s_dummyObject = new object();
		}

		// Token: 0x02000969 RID: 2409
		internal sealed class ArrayListDebugView
		{
			// Token: 0x06008FF8 RID: 36856 RVA: 0x00163D46 File Offset: 0x00161F46
			public ArrayListDebugView(ArrayList arrayList)
			{
				ArgumentNullException.ThrowIfNull(arrayList, "arrayList");
				this._arrayList = arrayList;
			}

			// Token: 0x17001347 RID: 4935
			// (get) Token: 0x06008FF9 RID: 36857 RVA: 0x00163D60 File Offset: 0x00161F60
			[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
			public object[] Items
			{
				get
				{
					return this._arrayList.ToArray();
				}
			}

			// Token: 0x040021EF RID: 8687
			private readonly ArrayList _arrayList;
		}
	}
}
