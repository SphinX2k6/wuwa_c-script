using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Collections.Generic
{
	// Token: 0x020009DC RID: 2524
	[NullableContext(1)]
	[Nullable(0)]
	[DebuggerTypeProxy(typeof(QueueDebugView<>))]
	[DebuggerDisplay("Count = {Count}")]
	[TypeForwardedFrom("System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class Queue<[Nullable(2)] T> : IEnumerable<T>, IEnumerable, ICollection, IReadOnlyCollection<T>
	{
		// Token: 0x060093B2 RID: 37810 RVA: 0x001707E3 File Offset: 0x0016E9E3
		public Queue()
		{
			this._array = Array.Empty<T>();
		}

		// Token: 0x060093B3 RID: 37811 RVA: 0x001707F6 File Offset: 0x0016E9F6
		public Queue(int capacity)
		{
			ArgumentOutOfRangeException.ThrowIfNegative<int>(capacity, "capacity");
			this._array = new T[capacity];
		}

		// Token: 0x060093B4 RID: 37812 RVA: 0x00170818 File Offset: 0x0016EA18
		public Queue(IEnumerable<T> collection)
		{
			ArgumentNullException.ThrowIfNull(collection, "collection");
			this._array = EnumerableHelpers.ToArray<T>(collection, out this._size);
			if (this._size != this._array.Length)
			{
				this._tail = this._size;
			}
		}

		// Token: 0x17001424 RID: 5156
		// (get) Token: 0x060093B5 RID: 37813 RVA: 0x00170864 File Offset: 0x0016EA64
		public int Count
		{
			get
			{
				return this._size;
			}
		}

		// Token: 0x17001425 RID: 5157
		// (get) Token: 0x060093B6 RID: 37814 RVA: 0x0017086C File Offset: 0x0016EA6C
		public int Capacity
		{
			get
			{
				return this._array.Length;
			}
		}

		// Token: 0x17001426 RID: 5158
		// (get) Token: 0x060093B7 RID: 37815 RVA: 0x00007B65 File Offset: 0x00005D65
		bool ICollection.IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17001427 RID: 5159
		// (get) Token: 0x060093B8 RID: 37816 RVA: 0x00007B62 File Offset: 0x00005D62
		object ICollection.SyncRoot
		{
			get
			{
				return this;
			}
		}

		// Token: 0x060093B9 RID: 37817 RVA: 0x00170878 File Offset: 0x0016EA78
		public void Clear()
		{
			if (this._size != 0)
			{
				if (RuntimeHelpers.IsReferenceOrContainsReferences<T>())
				{
					if (this._head < this._tail)
					{
						Array.Clear(this._array, this._head, this._size);
					}
					else
					{
						Array.Clear(this._array, this._head, this._array.Length - this._head);
						Array.Clear(this._array, 0, this._tail);
					}
				}
				this._size = 0;
			}
			this._head = 0;
			this._tail = 0;
			this._version++;
		}

		// Token: 0x060093BA RID: 37818 RVA: 0x00170910 File Offset: 0x0016EB10
		public void CopyTo(T[] array, int arrayIndex)
		{
			ArgumentNullException.ThrowIfNull(array, "array");
			if (arrayIndex < 0 || arrayIndex > array.Length)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.arrayIndex, ExceptionResource.ArgumentOutOfRange_IndexMustBeLessOrEqual);
			}
			if (array.Length - arrayIndex < this._size)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidOffLen);
			}
			int num = this._size;
			if (num == 0)
			{
				return;
			}
			int num2 = Math.Min(this._array.Length - this._head, num);
			Array.Copy(this._array, this._head, array, arrayIndex, num2);
			num -= num2;
			if (num > 0)
			{
				Array.Copy(this._array, 0, array, arrayIndex + this._array.Length - this._head, num);
			}
		}

		// Token: 0x060093BB RID: 37819 RVA: 0x001709AC File Offset: 0x0016EBAC
		void ICollection.CopyTo(Array array, int index)
		{
			ArgumentNullException.ThrowIfNull(array, "array");
			if (array.Rank != 1)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_RankMultiDimNotSupported, ExceptionArgument.array);
			}
			if (array.GetLowerBound(0) != 0)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_NonZeroLowerBound, ExceptionArgument.array);
			}
			int length = array.Length;
			if (index < 0 || index > length)
			{
				ThrowHelper.ThrowArgumentOutOfRange_IndexMustBeLessOrEqualException();
			}
			if (length - index < this._size)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidOffLen);
			}
			int num = this._size;
			if (num == 0)
			{
				return;
			}
			try
			{
				int num2 = (this._array.Length - this._head < num) ? (this._array.Length - this._head) : num;
				Array.Copy(this._array, this._head, array, index, num2);
				num -= num2;
				if (num > 0)
				{
					Array.Copy(this._array, 0, array, index + this._array.Length - this._head, num);
				}
			}
			catch (ArrayTypeMismatchException)
			{
				ThrowHelper.ThrowArgumentException_Argument_IncompatibleArrayType();
			}
		}

		// Token: 0x060093BC RID: 37820 RVA: 0x00170A94 File Offset: 0x0016EC94
		public void Enqueue(T item)
		{
			if (this._size == this._array.Length)
			{
				this.Grow(this._size + 1);
			}
			this._array[this._tail] = item;
			this.MoveNext(ref this._tail);
			this._size++;
			this._version++;
		}

		// Token: 0x060093BD RID: 37821 RVA: 0x00170AF9 File Offset: 0x0016ECF9
		[NullableContext(0)]
		public Queue<T>.Enumerator GetEnumerator()
		{
			return new Queue<T>.Enumerator(this);
		}

		// Token: 0x060093BE RID: 37822 RVA: 0x00170B04 File Offset: 0x0016ED04
		IEnumerator<T> IEnumerable<!0>.GetEnumerator()
		{
			if (this.Count != 0)
			{
				return this.GetEnumerator();
			}
			return SZGenericArrayEnumerator<T>.Empty;
		}

		// Token: 0x060093BF RID: 37823 RVA: 0x00167000 File Offset: 0x00165200
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<!0>)this).GetEnumerator();
		}

		// Token: 0x060093C0 RID: 37824 RVA: 0x00170B30 File Offset: 0x0016ED30
		public T Dequeue()
		{
			int head = this._head;
			T[] array = this._array;
			if (this._size == 0)
			{
				this.ThrowForEmptyQueue();
			}
			T result = array[head];
			if (RuntimeHelpers.IsReferenceOrContainsReferences<T>())
			{
				array[head] = default(T);
			}
			this.MoveNext(ref this._head);
			this._size--;
			this._version++;
			return result;
		}

		// Token: 0x060093C1 RID: 37825 RVA: 0x00170BA0 File Offset: 0x0016EDA0
		public bool TryDequeue([MaybeNullWhen(false)] out T result)
		{
			int head = this._head;
			T[] array = this._array;
			if (this._size == 0)
			{
				result = default(T);
				return false;
			}
			result = array[head];
			if (RuntimeHelpers.IsReferenceOrContainsReferences<T>())
			{
				array[head] = default(T);
			}
			this.MoveNext(ref this._head);
			this._size--;
			this._version++;
			return true;
		}

		// Token: 0x060093C2 RID: 37826 RVA: 0x00170C19 File Offset: 0x0016EE19
		public T Peek()
		{
			if (this._size == 0)
			{
				this.ThrowForEmptyQueue();
			}
			return this._array[this._head];
		}

		// Token: 0x060093C3 RID: 37827 RVA: 0x00170C3A File Offset: 0x0016EE3A
		public bool TryPeek([MaybeNullWhen(false)] out T result)
		{
			if (this._size == 0)
			{
				result = default(T);
				return false;
			}
			result = this._array[this._head];
			return true;
		}

		// Token: 0x060093C4 RID: 37828 RVA: 0x00170C68 File Offset: 0x0016EE68
		public bool Contains(T item)
		{
			if (this._size == 0)
			{
				return false;
			}
			if (this._head < this._tail)
			{
				return Array.IndexOf<T>(this._array, item, this._head, this._size) >= 0;
			}
			return Array.IndexOf<T>(this._array, item, this._head, this._array.Length - this._head) >= 0 || Array.IndexOf<T>(this._array, item, 0, this._tail) >= 0;
		}

		// Token: 0x060093C5 RID: 37829 RVA: 0x00170CEC File Offset: 0x0016EEEC
		public T[] ToArray()
		{
			if (this._size == 0)
			{
				return Array.Empty<T>();
			}
			T[] array = new T[this._size];
			if (this._head < this._tail)
			{
				Array.Copy(this._array, this._head, array, 0, this._size);
			}
			else
			{
				Array.Copy(this._array, this._head, array, 0, this._array.Length - this._head);
				Array.Copy(this._array, 0, array, this._array.Length - this._head, this._tail);
			}
			return array;
		}

		// Token: 0x060093C6 RID: 37830 RVA: 0x00170D84 File Offset: 0x0016EF84
		private void SetCapacity(int capacity)
		{
			T[] array = new T[capacity];
			if (this._size > 0)
			{
				if (this._head < this._tail)
				{
					Array.Copy(this._array, this._head, array, 0, this._size);
				}
				else
				{
					Array.Copy(this._array, this._head, array, 0, this._array.Length - this._head);
					Array.Copy(this._array, 0, array, this._array.Length - this._head, this._tail);
				}
			}
			this._array = array;
			this._head = 0;
			this._tail = ((this._size == capacity) ? 0 : this._size);
			this._version++;
		}

		// Token: 0x060093C7 RID: 37831 RVA: 0x00170E44 File Offset: 0x0016F044
		private void MoveNext(ref int index)
		{
			int num = index + 1;
			if (num == this._array.Length)
			{
				num = 0;
			}
			index = num;
		}

		// Token: 0x060093C8 RID: 37832 RVA: 0x00170E66 File Offset: 0x0016F066
		private void ThrowForEmptyQueue()
		{
			throw new InvalidOperationException(SR.InvalidOperation_EmptyQueue);
		}

		// Token: 0x060093C9 RID: 37833 RVA: 0x00170E74 File Offset: 0x0016F074
		public void TrimExcess()
		{
			int num = (int)((double)this._array.Length * 0.9);
			if (this._size < num)
			{
				this.SetCapacity(this._size);
			}
		}

		// Token: 0x060093CA RID: 37834 RVA: 0x00170EAB File Offset: 0x0016F0AB
		public void TrimExcess(int capacity)
		{
			ArgumentOutOfRangeException.ThrowIfNegative<int>(capacity, "capacity");
			ArgumentOutOfRangeException.ThrowIfLessThan<int>(capacity, this._size, "capacity");
			if (capacity == this._array.Length)
			{
				return;
			}
			this.SetCapacity(capacity);
		}

		// Token: 0x060093CB RID: 37835 RVA: 0x00170EDC File Offset: 0x0016F0DC
		public int EnsureCapacity(int capacity)
		{
			ArgumentOutOfRangeException.ThrowIfNegative<int>(capacity, "capacity");
			if (this._array.Length < capacity)
			{
				this.Grow(capacity);
			}
			return this._array.Length;
		}

		// Token: 0x060093CC RID: 37836 RVA: 0x00170F04 File Offset: 0x0016F104
		private void Grow(int capacity)
		{
			int num = 2 * this._array.Length;
			if ((ulong)num > 2147483591UL)
			{
				num = 2147483591;
			}
			num = Math.Max(num, this._array.Length + 4);
			if (num < capacity)
			{
				num = capacity;
			}
			this.SetCapacity(num);
		}

		// Token: 0x040022A4 RID: 8868
		private T[] _array;

		// Token: 0x040022A5 RID: 8869
		private int _head;

		// Token: 0x040022A6 RID: 8870
		private int _tail;

		// Token: 0x040022A7 RID: 8871
		private int _size;

		// Token: 0x040022A8 RID: 8872
		private int _version;

		// Token: 0x020009DD RID: 2525
		[NullableContext(0)]
		public struct Enumerator : IEnumerator<!0>, IDisposable, IEnumerator
		{
			// Token: 0x060093CD RID: 37837 RVA: 0x00170F4A File Offset: 0x0016F14A
			internal Enumerator(Queue<T> q)
			{
				this._q = q;
				this._version = q._version;
				this._index = -1;
				this._currentElement = default(T);
			}

			// Token: 0x060093CE RID: 37838 RVA: 0x00170F72 File Offset: 0x0016F172
			public void Dispose()
			{
				this._index = -2;
				this._currentElement = default(T);
			}

			// Token: 0x060093CF RID: 37839 RVA: 0x00170F88 File Offset: 0x0016F188
			public bool MoveNext()
			{
				if (this._version != this._q._version)
				{
					ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion();
				}
				if (this._index == -2)
				{
					return false;
				}
				this._index++;
				if (this._index == this._q._size)
				{
					this._index = -2;
					this._currentElement = default(T);
					return false;
				}
				T[] array = this._q._array;
				uint num = (uint)array.Length;
				uint num2 = (uint)(this._q._head + this._index);
				if (num2 >= num)
				{
					num2 -= num;
				}
				this._currentElement = array[(int)num2];
				return true;
			}

			// Token: 0x17001428 RID: 5160
			// (get) Token: 0x060093D0 RID: 37840 RVA: 0x00171029 File Offset: 0x0016F229
			[Nullable(1)]
			public T Current
			{
				[NullableContext(1)]
				get
				{
					if (this._index < 0)
					{
						this.ThrowEnumerationNotStartedOrEnded();
					}
					return this._currentElement;
				}
			}

			// Token: 0x060093D1 RID: 37841 RVA: 0x00171040 File Offset: 0x0016F240
			private void ThrowEnumerationNotStartedOrEnded()
			{
				throw new InvalidOperationException((this._index == -1) ? SR.InvalidOperation_EnumNotStarted : SR.InvalidOperation_EnumEnded);
			}

			// Token: 0x17001429 RID: 5161
			// (get) Token: 0x060093D2 RID: 37842 RVA: 0x0017105C File Offset: 0x0016F25C
			[Nullable(2)]
			object IEnumerator.Current
			{
				get
				{
					return this.Current;
				}
			}

			// Token: 0x060093D3 RID: 37843 RVA: 0x00171069 File Offset: 0x0016F269
			void IEnumerator.Reset()
			{
				if (this._version != this._q._version)
				{
					ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion();
				}
				this._index = -1;
				this._currentElement = default(T);
			}

			// Token: 0x040022A9 RID: 8873
			private readonly Queue<T> _q;

			// Token: 0x040022AA RID: 8874
			private readonly int _version;

			// Token: 0x040022AB RID: 8875
			private int _index;

			// Token: 0x040022AC RID: 8876
			private T _currentElement;
		}
	}
}
