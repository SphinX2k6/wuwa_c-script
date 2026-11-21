using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace System.Collections.Generic
{
	// Token: 0x020009DA RID: 2522
	[NullableContext(1)]
	[Nullable(0)]
	[DebuggerTypeProxy(typeof(ICollectionDebugView<>))]
	[DebuggerDisplay("Count = {Count}")]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class List<[Nullable(2)] T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IList, ICollection, IReadOnlyList<!0>, IReadOnlyCollection<T>
	{
		// Token: 0x0600935E RID: 37726 RVA: 0x0016F63B File Offset: 0x0016D83B
		public List()
		{
			this._items = List<T>.s_emptyArray;
		}

		// Token: 0x0600935F RID: 37727 RVA: 0x0016F64E File Offset: 0x0016D84E
		public List(int capacity)
		{
			if (capacity < 0)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.capacity, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
			}
			if (capacity == 0)
			{
				this._items = List<T>.s_emptyArray;
				return;
			}
			this._items = new T[capacity];
		}

		// Token: 0x06009360 RID: 37728 RVA: 0x0016F680 File Offset: 0x0016D880
		public List(IEnumerable<T> collection)
		{
			if (collection == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.collection);
			}
			ICollection<T> collection2 = collection as ICollection<!0>;
			if (collection2 == null)
			{
				this._items = List<T>.s_emptyArray;
				foreach (!0 item in collection)
				{
					this.Add(item);
				}
				return;
			}
			int count = collection2.Count;
			if (count == 0)
			{
				this._items = List<T>.s_emptyArray;
				return;
			}
			this._items = new T[count];
			collection2.CopyTo(this._items, 0);
			this._size = count;
		}

		// Token: 0x17001419 RID: 5145
		// (get) Token: 0x06009361 RID: 37729 RVA: 0x0016F724 File Offset: 0x0016D924
		// (set) Token: 0x06009362 RID: 37730 RVA: 0x0016F730 File Offset: 0x0016D930
		public int Capacity
		{
			get
			{
				return this._items.Length;
			}
			set
			{
				if (value < this._size)
				{
					ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.value, ExceptionResource.ArgumentOutOfRange_SmallCapacity);
				}
				if (value != this._items.Length)
				{
					if (value > 0)
					{
						T[] array = new T[value];
						if (this._size > 0)
						{
							Array.Copy(this._items, array, this._size);
						}
						this._items = array;
						return;
					}
					this._items = List<T>.s_emptyArray;
				}
			}
		}

		// Token: 0x1700141A RID: 5146
		// (get) Token: 0x06009363 RID: 37731 RVA: 0x0016F792 File Offset: 0x0016D992
		public int Count
		{
			get
			{
				return this._size;
			}
		}

		// Token: 0x1700141B RID: 5147
		// (get) Token: 0x06009364 RID: 37732 RVA: 0x00007B65 File Offset: 0x00005D65
		bool IList.IsFixedSize
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700141C RID: 5148
		// (get) Token: 0x06009365 RID: 37733 RVA: 0x00007B65 File Offset: 0x00005D65
		bool ICollection<!0>.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700141D RID: 5149
		// (get) Token: 0x06009366 RID: 37734 RVA: 0x00007B65 File Offset: 0x00005D65
		bool IList.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700141E RID: 5150
		// (get) Token: 0x06009367 RID: 37735 RVA: 0x00007B65 File Offset: 0x00005D65
		bool ICollection.IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700141F RID: 5151
		// (get) Token: 0x06009368 RID: 37736 RVA: 0x00007B62 File Offset: 0x00005D62
		object ICollection.SyncRoot
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17001420 RID: 5152
		public T this[int index]
		{
			get
			{
				if (index >= this._size)
				{
					ThrowHelper.ThrowArgumentOutOfRange_IndexMustBeLessException();
				}
				return this._items[index];
			}
			set
			{
				if (index >= this._size)
				{
					ThrowHelper.ThrowArgumentOutOfRange_IndexMustBeLessException();
				}
				this._items[index] = value;
				this._version++;
			}
		}

		// Token: 0x0600936B RID: 37739 RVA: 0x0016F7E4 File Offset: 0x0016D9E4
		private static bool IsCompatibleObject(object value)
		{
			return value is T || (value == null && default(T) == null);
		}

		// Token: 0x17001421 RID: 5153
		[Nullable(2)]
		object IList.this[int index]
		{
			get
			{
				return this[index];
			}
			set
			{
				ThrowHelper.IfNullAndNullsAreIllegalThenThrow<T>(value, ExceptionArgument.value);
				try
				{
					this[index] = (T)((object)value);
				}
				catch (InvalidCastException)
				{
					ThrowHelper.ThrowWrongValueTypeArgumentException<object>(value, typeof(T));
				}
			}
		}

		// Token: 0x0600936E RID: 37742 RVA: 0x0016F868 File Offset: 0x0016DA68
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Add(T item)
		{
			this._version++;
			T[] items = this._items;
			int size = this._size;
			if (size < items.Length)
			{
				this._size = size + 1;
				items[size] = item;
				return;
			}
			this.AddWithResize(item);
		}

		// Token: 0x0600936F RID: 37743 RVA: 0x0016F8B0 File Offset: 0x0016DAB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void AddWithResize(T item)
		{
			int size = this._size;
			this.Grow(size + 1);
			this._size = size + 1;
			this._items[size] = item;
		}

		// Token: 0x06009370 RID: 37744 RVA: 0x0016F8E4 File Offset: 0x0016DAE4
		int IList.Add(object item)
		{
			ThrowHelper.IfNullAndNullsAreIllegalThenThrow<T>(item, ExceptionArgument.item);
			try
			{
				this.Add((T)((object)item));
			}
			catch (InvalidCastException)
			{
				ThrowHelper.ThrowWrongValueTypeArgumentException<object>(item, typeof(T));
			}
			return this.Count - 1;
		}

		// Token: 0x06009371 RID: 37745 RVA: 0x0016F934 File Offset: 0x0016DB34
		public void AddRange(IEnumerable<T> collection)
		{
			if (collection == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.collection);
			}
			ICollection<T> collection2 = collection as ICollection<!0>;
			if (collection2 != null)
			{
				int count = collection2.Count;
				if (count > 0)
				{
					if (this._items.Length - this._size < count)
					{
						this.Grow(checked(this._size + count));
					}
					collection2.CopyTo(this._items, this._size);
					this._size += count;
					this._version++;
					return;
				}
			}
			else
			{
				foreach (!0 item in collection)
				{
					this.Add(item);
				}
			}
		}

		// Token: 0x06009372 RID: 37746 RVA: 0x0016F9E8 File Offset: 0x0016DBE8
		public ReadOnlyCollection<T> AsReadOnly()
		{
			return new ReadOnlyCollection<T>(this);
		}

		// Token: 0x06009373 RID: 37747 RVA: 0x0016F9F0 File Offset: 0x0016DBF0
		public int BinarySearch(int index, int count, T item, [Nullable(new byte[]
		{
			2,
			1
		})] IComparer<T> comparer)
		{
			if (index < 0)
			{
				ThrowHelper.ThrowIndexArgumentOutOfRange_NeedNonNegNumException();
			}
			if (count < 0)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.count, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
			}
			if (this._size - index < count)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidOffLen);
			}
			return Array.BinarySearch<T>(this._items, index, count, item, comparer);
		}

		// Token: 0x06009374 RID: 37748 RVA: 0x0016FA2A File Offset: 0x0016DC2A
		public int BinarySearch(T item)
		{
			return this.BinarySearch(0, this.Count, item, null);
		}

		// Token: 0x06009375 RID: 37749 RVA: 0x0016FA3B File Offset: 0x0016DC3B
		public int BinarySearch(T item, [Nullable(new byte[]
		{
			2,
			1
		})] IComparer<T> comparer)
		{
			return this.BinarySearch(0, this.Count, item, comparer);
		}

		// Token: 0x06009376 RID: 37750 RVA: 0x0016FA4C File Offset: 0x0016DC4C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Clear()
		{
			this._version++;
			if (RuntimeHelpers.IsReferenceOrContainsReferences<T>())
			{
				int size = this._size;
				this._size = 0;
				if (size > 0)
				{
					Array.Clear(this._items, 0, size);
					return;
				}
			}
			else
			{
				this._size = 0;
			}
		}

		// Token: 0x06009377 RID: 37751 RVA: 0x0016FA95 File Offset: 0x0016DC95
		public bool Contains(T item)
		{
			return this._size != 0 && this.IndexOf(item) >= 0;
		}

		// Token: 0x06009378 RID: 37752 RVA: 0x0016FAAE File Offset: 0x0016DCAE
		bool IList.Contains(object item)
		{
			return List<T>.IsCompatibleObject(item) && this.Contains((T)((object)item));
		}

		// Token: 0x06009379 RID: 37753 RVA: 0x0016FAC8 File Offset: 0x0016DCC8
		public List<TOutput> ConvertAll<[Nullable(2)] TOutput>(Converter<T, TOutput> converter)
		{
			if (converter == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.converter);
			}
			List<TOutput> list = new List<TOutput>(this._size);
			for (int i = 0; i < this._size; i++)
			{
				list._items[i] = converter(this._items[i]);
			}
			list._size = this._size;
			return list;
		}

		// Token: 0x0600937A RID: 37754 RVA: 0x0016FB27 File Offset: 0x0016DD27
		public void CopyTo(T[] array)
		{
			this.CopyTo(array, 0);
		}

		// Token: 0x0600937B RID: 37755 RVA: 0x0016FB34 File Offset: 0x0016DD34
		void ICollection.CopyTo(Array array, int arrayIndex)
		{
			if (array != null && array.Rank != 1)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_RankMultiDimNotSupported);
			}
			try
			{
				Array.Copy(this._items, 0, array, arrayIndex, this._size);
			}
			catch (ArrayTypeMismatchException)
			{
				ThrowHelper.ThrowArgumentException_Argument_IncompatibleArrayType();
			}
		}

		// Token: 0x0600937C RID: 37756 RVA: 0x0016FB84 File Offset: 0x0016DD84
		public void CopyTo(int index, T[] array, int arrayIndex, int count)
		{
			if (this._size - index < count)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidOffLen);
			}
			Array.Copy(this._items, index, array, arrayIndex, count);
		}

		// Token: 0x0600937D RID: 37757 RVA: 0x0016FBA9 File Offset: 0x0016DDA9
		public void CopyTo(T[] array, int arrayIndex)
		{
			Array.Copy(this._items, 0, array, arrayIndex, this._size);
		}

		// Token: 0x0600937E RID: 37758 RVA: 0x0016FBBF File Offset: 0x0016DDBF
		public int EnsureCapacity(int capacity)
		{
			if (capacity < 0)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.capacity, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
			}
			if (this._items.Length < capacity)
			{
				this.Grow(capacity);
			}
			return this._items.Length;
		}

		// Token: 0x0600937F RID: 37759 RVA: 0x0016FBE8 File Offset: 0x0016DDE8
		internal void Grow(int capacity)
		{
			this.Capacity = this.GetNewCapacity(capacity);
		}

		// Token: 0x06009380 RID: 37760 RVA: 0x0016FBF8 File Offset: 0x0016DDF8
		private void GrowForInsertion(int indexToInsert, int insertionCount = 1)
		{
			int capacity = checked(this._size + insertionCount);
			T[] array = new T[this.GetNewCapacity(capacity)];
			if (indexToInsert != 0)
			{
				Array.Copy(this._items, array, indexToInsert);
			}
			if (this._size != indexToInsert)
			{
				Array.Copy(this._items, indexToInsert, array, indexToInsert + insertionCount, this._size - indexToInsert);
			}
			this._items = array;
		}

		// Token: 0x06009381 RID: 37761 RVA: 0x0016FC54 File Offset: 0x0016DE54
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private int GetNewCapacity(int capacity)
		{
			int num = (this._items.Length == 0) ? 4 : (2 * this._items.Length);
			if ((ulong)num > 2147483591UL)
			{
				num = 2147483591;
			}
			if (num < capacity)
			{
				num = capacity;
			}
			return num;
		}

		// Token: 0x06009382 RID: 37762 RVA: 0x0016FC8F File Offset: 0x0016DE8F
		public bool Exists(Predicate<T> match)
		{
			return this.FindIndex(match) != -1;
		}

		// Token: 0x06009383 RID: 37763 RVA: 0x0016FCA0 File Offset: 0x0016DEA0
		[return: Nullable(2)]
		public T Find(Predicate<T> match)
		{
			if (match == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.match);
			}
			for (int i = 0; i < this._size; i++)
			{
				if (match(this._items[i]))
				{
					return this._items[i];
				}
			}
			return default(T);
		}

		// Token: 0x06009384 RID: 37764 RVA: 0x0016FCF4 File Offset: 0x0016DEF4
		public List<T> FindAll(Predicate<T> match)
		{
			if (match == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.match);
			}
			List<T> list = new List<T>();
			for (int i = 0; i < this._size; i++)
			{
				if (match(this._items[i]))
				{
					list.Add(this._items[i]);
				}
			}
			return list;
		}

		// Token: 0x06009385 RID: 37765 RVA: 0x0016FD49 File Offset: 0x0016DF49
		public int FindIndex(Predicate<T> match)
		{
			return this.FindIndex(0, this._size, match);
		}

		// Token: 0x06009386 RID: 37766 RVA: 0x0016FD59 File Offset: 0x0016DF59
		public int FindIndex(int startIndex, Predicate<T> match)
		{
			return this.FindIndex(startIndex, this._size - startIndex, match);
		}

		// Token: 0x06009387 RID: 37767 RVA: 0x0016FD6C File Offset: 0x0016DF6C
		public int FindIndex(int startIndex, int count, Predicate<T> match)
		{
			if (startIndex > this._size)
			{
				ThrowHelper.ThrowStartIndexArgumentOutOfRange_ArgumentOutOfRange_IndexMustBeLessOrEqual();
			}
			if (count < 0 || startIndex > this._size - count)
			{
				ThrowHelper.ThrowCountArgumentOutOfRange_ArgumentOutOfRange_Count();
			}
			if (match == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.match);
			}
			int num = startIndex + count;
			for (int i = startIndex; i < num; i++)
			{
				if (match(this._items[i]))
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x06009388 RID: 37768 RVA: 0x0016FDCC File Offset: 0x0016DFCC
		[return: Nullable(2)]
		public T FindLast(Predicate<T> match)
		{
			if (match == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.match);
			}
			for (int i = this._size - 1; i >= 0; i--)
			{
				if (match(this._items[i]))
				{
					return this._items[i];
				}
			}
			return default(T);
		}

		// Token: 0x06009389 RID: 37769 RVA: 0x0016FE20 File Offset: 0x0016E020
		public int FindLastIndex(Predicate<T> match)
		{
			return this.FindLastIndex(this._size - 1, this._size, match);
		}

		// Token: 0x0600938A RID: 37770 RVA: 0x0016FE37 File Offset: 0x0016E037
		public int FindLastIndex(int startIndex, Predicate<T> match)
		{
			return this.FindLastIndex(startIndex, startIndex + 1, match);
		}

		// Token: 0x0600938B RID: 37771 RVA: 0x0016FE44 File Offset: 0x0016E044
		public int FindLastIndex(int startIndex, int count, Predicate<T> match)
		{
			if (match == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.match);
			}
			if (this._size == 0)
			{
				if (startIndex != -1)
				{
					ThrowHelper.ThrowStartIndexArgumentOutOfRange_ArgumentOutOfRange_IndexMustBeLess();
				}
			}
			else if (startIndex >= this._size)
			{
				ThrowHelper.ThrowStartIndexArgumentOutOfRange_ArgumentOutOfRange_IndexMustBeLess();
			}
			if (count < 0 || startIndex - count + 1 < 0)
			{
				ThrowHelper.ThrowCountArgumentOutOfRange_ArgumentOutOfRange_Count();
			}
			int num = startIndex - count;
			for (int i = startIndex; i > num; i--)
			{
				if (match(this._items[i]))
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x0600938C RID: 37772 RVA: 0x0016FEB4 File Offset: 0x0016E0B4
		public void ForEach(Action<T> action)
		{
			if (action == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.action);
			}
			int version = this._version;
			int num = 0;
			while (num < this._size && version == this._version)
			{
				action(this._items[num]);
				num++;
			}
			if (version != this._version)
			{
				ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion();
			}
		}

		// Token: 0x0600938D RID: 37773 RVA: 0x0016FF0C File Offset: 0x0016E10C
		[NullableContext(0)]
		public List<T>.Enumerator GetEnumerator()
		{
			return new List<T>.Enumerator(this);
		}

		// Token: 0x0600938E RID: 37774 RVA: 0x0016FF14 File Offset: 0x0016E114
		IEnumerator<T> IEnumerable<!0>.GetEnumerator()
		{
			if (this.Count != 0)
			{
				return this.GetEnumerator();
			}
			return SZGenericArrayEnumerator<T>.Empty;
		}

		// Token: 0x0600938F RID: 37775 RVA: 0x00167000 File Offset: 0x00165200
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<!0>)this).GetEnumerator();
		}

		// Token: 0x06009390 RID: 37776 RVA: 0x0016FF40 File Offset: 0x0016E140
		public List<T> GetRange(int index, int count)
		{
			if (index < 0)
			{
				ThrowHelper.ThrowIndexArgumentOutOfRange_NeedNonNegNumException();
			}
			if (count < 0)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.count, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
			}
			if (this._size - index < count)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidOffLen);
			}
			List<T> list = new List<T>(count);
			Array.Copy(this._items, index, list._items, 0, count);
			list._size = count;
			return list;
		}

		// Token: 0x06009391 RID: 37777 RVA: 0x0016FF98 File Offset: 0x0016E198
		public List<T> Slice(int start, int length)
		{
			return this.GetRange(start, length);
		}

		// Token: 0x06009392 RID: 37778 RVA: 0x0016FFA2 File Offset: 0x0016E1A2
		public int IndexOf(T item)
		{
			return Array.IndexOf<T>(this._items, item, 0, this._size);
		}

		// Token: 0x06009393 RID: 37779 RVA: 0x0016FFB7 File Offset: 0x0016E1B7
		int IList.IndexOf(object item)
		{
			if (List<T>.IsCompatibleObject(item))
			{
				return this.IndexOf((T)((object)item));
			}
			return -1;
		}

		// Token: 0x06009394 RID: 37780 RVA: 0x0016FFCF File Offset: 0x0016E1CF
		public int IndexOf(T item, int index)
		{
			if (index > this._size)
			{
				ThrowHelper.ThrowArgumentOutOfRange_IndexMustBeLessOrEqualException();
			}
			return Array.IndexOf<T>(this._items, item, index, this._size - index);
		}

		// Token: 0x06009395 RID: 37781 RVA: 0x0016FFF4 File Offset: 0x0016E1F4
		public int IndexOf(T item, int index, int count)
		{
			if (index > this._size)
			{
				ThrowHelper.ThrowArgumentOutOfRange_IndexMustBeLessOrEqualException();
			}
			if (count < 0 || index > this._size - count)
			{
				ThrowHelper.ThrowCountArgumentOutOfRange_ArgumentOutOfRange_Count();
			}
			return Array.IndexOf<T>(this._items, item, index, count);
		}

		// Token: 0x06009396 RID: 37782 RVA: 0x00170028 File Offset: 0x0016E228
		public void Insert(int index, T item)
		{
			if (index > this._size)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index, ExceptionResource.ArgumentOutOfRange_ListInsert);
			}
			if (this._size == this._items.Length)
			{
				this.GrowForInsertion(index, 1);
			}
			else if (index < this._size)
			{
				Array.Copy(this._items, index, this._items, index + 1, this._size - index);
			}
			this._items[index] = item;
			this._size++;
			this._version++;
		}

		// Token: 0x06009397 RID: 37783 RVA: 0x001700B0 File Offset: 0x0016E2B0
		void IList.Insert(int index, object item)
		{
			ThrowHelper.IfNullAndNullsAreIllegalThenThrow<T>(item, ExceptionArgument.item);
			try
			{
				this.Insert(index, (T)((object)item));
			}
			catch (InvalidCastException)
			{
				ThrowHelper.ThrowWrongValueTypeArgumentException<object>(item, typeof(T));
			}
		}

		// Token: 0x06009398 RID: 37784 RVA: 0x001700F8 File Offset: 0x0016E2F8
		public void InsertRange(int index, IEnumerable<T> collection)
		{
			if (collection == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.collection);
			}
			if (index > this._size)
			{
				ThrowHelper.ThrowArgumentOutOfRange_IndexMustBeLessOrEqualException();
			}
			ICollection<T> collection2 = collection as ICollection<!0>;
			if (collection2 != null)
			{
				int count = collection2.Count;
				if (count > 0)
				{
					if (this._items.Length - this._size < count)
					{
						this.GrowForInsertion(index, count);
					}
					else if (index < this._size)
					{
						Array.Copy(this._items, index, this._items, index + count, this._size - index);
					}
					if (this == collection2)
					{
						Array.Copy(this._items, 0, this._items, index, index);
						Array.Copy(this._items, index + count, this._items, index * 2, this._size - index);
					}
					else
					{
						collection2.CopyTo(this._items, index);
					}
					this._size += count;
					this._version++;
					return;
				}
			}
			else
			{
				foreach (!0 item in collection)
				{
					this.Insert(index++, item);
				}
			}
		}

		// Token: 0x06009399 RID: 37785 RVA: 0x0017021C File Offset: 0x0016E41C
		public int LastIndexOf(T item)
		{
			if (this._size == 0)
			{
				return -1;
			}
			return this.LastIndexOf(item, this._size - 1, this._size);
		}

		// Token: 0x0600939A RID: 37786 RVA: 0x0017023D File Offset: 0x0016E43D
		public int LastIndexOf(T item, int index)
		{
			if (index >= this._size)
			{
				ThrowHelper.ThrowArgumentOutOfRange_IndexMustBeLessException();
			}
			return this.LastIndexOf(item, index, index + 1);
		}

		// Token: 0x0600939B RID: 37787 RVA: 0x00170258 File Offset: 0x0016E458
		public int LastIndexOf(T item, int index, int count)
		{
			if (this.Count != 0 && index < 0)
			{
				ThrowHelper.ThrowIndexArgumentOutOfRange_NeedNonNegNumException();
			}
			if (this.Count != 0 && count < 0)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.count, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
			}
			if (this._size == 0)
			{
				return -1;
			}
			if (index >= this._size)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index, ExceptionResource.ArgumentOutOfRange_BiggerThanCollection);
			}
			if (count > index + 1)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.count, ExceptionResource.ArgumentOutOfRange_BiggerThanCollection);
			}
			return Array.LastIndexOf<T>(this._items, item, index, count);
		}

		// Token: 0x0600939C RID: 37788 RVA: 0x001702C4 File Offset: 0x0016E4C4
		public bool Remove(T item)
		{
			int num = this.IndexOf(item);
			if (num >= 0)
			{
				this.RemoveAt(num);
				return true;
			}
			return false;
		}

		// Token: 0x0600939D RID: 37789 RVA: 0x001702E7 File Offset: 0x0016E4E7
		void IList.Remove(object item)
		{
			if (List<T>.IsCompatibleObject(item))
			{
				this.Remove((T)((object)item));
			}
		}

		// Token: 0x0600939E RID: 37790 RVA: 0x00170300 File Offset: 0x0016E500
		public int RemoveAll(Predicate<T> match)
		{
			if (match == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.match);
			}
			int num = 0;
			while (num < this._size && !match(this._items[num]))
			{
				num++;
			}
			if (num >= this._size)
			{
				return 0;
			}
			int i = num + 1;
			while (i < this._size)
			{
				while (i < this._size && match(this._items[i]))
				{
					i++;
				}
				if (i < this._size)
				{
					this._items[num++] = this._items[i++];
				}
			}
			if (RuntimeHelpers.IsReferenceOrContainsReferences<T>())
			{
				Array.Clear(this._items, num, this._size - num);
			}
			int result = this._size - num;
			this._size = num;
			this._version++;
			return result;
		}

		// Token: 0x0600939F RID: 37791 RVA: 0x001703D8 File Offset: 0x0016E5D8
		public void RemoveAt(int index)
		{
			if (index >= this._size)
			{
				ThrowHelper.ThrowArgumentOutOfRange_IndexMustBeLessException();
			}
			this._size--;
			if (index < this._size)
			{
				Array.Copy(this._items, index + 1, this._items, index, this._size - index);
			}
			if (RuntimeHelpers.IsReferenceOrContainsReferences<T>())
			{
				this._items[this._size] = default(T);
			}
			this._version++;
		}

		// Token: 0x060093A0 RID: 37792 RVA: 0x00170458 File Offset: 0x0016E658
		public void RemoveRange(int index, int count)
		{
			if (index < 0)
			{
				ThrowHelper.ThrowIndexArgumentOutOfRange_NeedNonNegNumException();
			}
			if (count < 0)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.count, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
			}
			if (this._size - index < count)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidOffLen);
			}
			if (count > 0)
			{
				this._size -= count;
				if (index < this._size)
				{
					Array.Copy(this._items, index + count, this._items, index, this._size - index);
				}
				this._version++;
				if (RuntimeHelpers.IsReferenceOrContainsReferences<T>())
				{
					Array.Clear(this._items, this._size, count);
				}
			}
		}

		// Token: 0x060093A1 RID: 37793 RVA: 0x001704EC File Offset: 0x0016E6EC
		public void Reverse()
		{
			this.Reverse(0, this.Count);
		}

		// Token: 0x060093A2 RID: 37794 RVA: 0x001704FC File Offset: 0x0016E6FC
		public void Reverse(int index, int count)
		{
			if (index < 0)
			{
				ThrowHelper.ThrowIndexArgumentOutOfRange_NeedNonNegNumException();
			}
			if (count < 0)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.count, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
			}
			if (this._size - index < count)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidOffLen);
			}
			if (count > 1)
			{
				Array.Reverse<T>(this._items, index, count);
			}
			this._version++;
		}

		// Token: 0x060093A3 RID: 37795 RVA: 0x00170550 File Offset: 0x0016E750
		public void Sort()
		{
			this.Sort(0, this.Count, null);
		}

		// Token: 0x060093A4 RID: 37796 RVA: 0x00170560 File Offset: 0x0016E760
		public void Sort([Nullable(new byte[]
		{
			2,
			1
		})] IComparer<T> comparer)
		{
			this.Sort(0, this.Count, comparer);
		}

		// Token: 0x060093A5 RID: 37797 RVA: 0x00170570 File Offset: 0x0016E770
		public void Sort(int index, int count, [Nullable(new byte[]
		{
			2,
			1
		})] IComparer<T> comparer)
		{
			if (index < 0)
			{
				ThrowHelper.ThrowIndexArgumentOutOfRange_NeedNonNegNumException();
			}
			if (count < 0)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.count, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
			}
			if (this._size - index < count)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidOffLen);
			}
			if (count > 1)
			{
				Array.Sort<T>(this._items, index, count, comparer);
			}
			this._version++;
		}

		// Token: 0x060093A6 RID: 37798 RVA: 0x001705C5 File Offset: 0x0016E7C5
		public void Sort(Comparison<T> comparison)
		{
			if (comparison == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.comparison);
			}
			if (this._size > 1)
			{
				ArraySortHelper<T>.Sort(new Span<T>(this._items, 0, this._size), comparison);
			}
			this._version++;
		}

		// Token: 0x060093A7 RID: 37799 RVA: 0x00170600 File Offset: 0x0016E800
		public T[] ToArray()
		{
			if (this._size == 0)
			{
				return List<T>.s_emptyArray;
			}
			T[] array = new T[this._size];
			Array.Copy(this._items, array, this._size);
			return array;
		}

		// Token: 0x060093A8 RID: 37800 RVA: 0x0017063C File Offset: 0x0016E83C
		public void TrimExcess()
		{
			int num = (int)((double)this._items.Length * 0.9);
			if (this._size < num)
			{
				this.Capacity = this._size;
			}
		}

		// Token: 0x060093A9 RID: 37801 RVA: 0x00170674 File Offset: 0x0016E874
		public bool TrueForAll(Predicate<T> match)
		{
			if (match == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.match);
			}
			for (int i = 0; i < this._size; i++)
			{
				if (!match(this._items[i]))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0400229C RID: 8860
		internal T[] _items;

		// Token: 0x0400229D RID: 8861
		internal int _size;

		// Token: 0x0400229E RID: 8862
		internal int _version;

		// Token: 0x0400229F RID: 8863
		private static readonly T[] s_emptyArray = new T[0];

		// Token: 0x020009DB RID: 2523
		[NullableContext(0)]
		public struct Enumerator : IEnumerator<!0>, IDisposable, IEnumerator
		{
			// Token: 0x060093AB RID: 37803 RVA: 0x001706C0 File Offset: 0x0016E8C0
			internal Enumerator(List<T> list)
			{
				this._list = list;
				this._index = 0;
				this._version = list._version;
				this._current = default(T);
			}

			// Token: 0x060093AC RID: 37804 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public void Dispose()
			{
			}

			// Token: 0x060093AD RID: 37805 RVA: 0x001706E8 File Offset: 0x0016E8E8
			public bool MoveNext()
			{
				List<T> list = this._list;
				if (this._version == list._version && this._index < list._size)
				{
					this._current = list._items[this._index];
					this._index++;
					return true;
				}
				return this.MoveNextRare();
			}

			// Token: 0x060093AE RID: 37806 RVA: 0x00170745 File Offset: 0x0016E945
			private bool MoveNextRare()
			{
				if (this._version != this._list._version)
				{
					ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion();
				}
				this._index = this._list._size + 1;
				this._current = default(T);
				return false;
			}

			// Token: 0x17001422 RID: 5154
			// (get) Token: 0x060093AF RID: 37807 RVA: 0x0017077F File Offset: 0x0016E97F
			[Nullable(1)]
			public T Current
			{
				[NullableContext(1)]
				get
				{
					return this._current;
				}
			}

			// Token: 0x17001423 RID: 5155
			// (get) Token: 0x060093B0 RID: 37808 RVA: 0x00170787 File Offset: 0x0016E987
			[Nullable(2)]
			object IEnumerator.Current
			{
				get
				{
					if (this._index == 0 || this._index == this._list._size + 1)
					{
						ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumOpCantHappen();
					}
					return this.Current;
				}
			}

			// Token: 0x060093B1 RID: 37809 RVA: 0x001707B6 File Offset: 0x0016E9B6
			void IEnumerator.Reset()
			{
				if (this._version != this._list._version)
				{
					ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion();
				}
				this._index = 0;
				this._current = default(T);
			}

			// Token: 0x040022A0 RID: 8864
			private readonly List<T> _list;

			// Token: 0x040022A1 RID: 8865
			private int _index;

			// Token: 0x040022A2 RID: 8866
			private readonly int _version;

			// Token: 0x040022A3 RID: 8867
			private T _current;
		}
	}
}
