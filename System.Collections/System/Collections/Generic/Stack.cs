using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Collections.Generic
{
	// Token: 0x02000043 RID: 67
	[NullableContext(1)]
	[Nullable(0)]
	[DebuggerTypeProxy(typeof(StackDebugView<>))]
	[DebuggerDisplay("Count = {Count}")]
	[TypeForwardedFrom("System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class Stack<[Nullable(2)] T> : IEnumerable<!0>, IEnumerable, ICollection, IReadOnlyCollection<T>
	{
		// Token: 0x0600031F RID: 799 RVA: 0x0000C038 File Offset: 0x0000A238
		public Stack()
		{
			this._array = Array.Empty<T>();
		}

		// Token: 0x06000320 RID: 800 RVA: 0x0000C04B File Offset: 0x0000A24B
		public Stack(int capacity)
		{
			ArgumentOutOfRangeException.ThrowIfNegative<int>(capacity, "capacity");
			this._array = new T[capacity];
		}

		// Token: 0x06000321 RID: 801 RVA: 0x0000C06A File Offset: 0x0000A26A
		public Stack(IEnumerable<T> collection)
		{
			ArgumentNullException.ThrowIfNull(collection, "collection");
			this._array = EnumerableHelpers.ToArray<T>(collection, out this._size);
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000322 RID: 802 RVA: 0x0000C08F File Offset: 0x0000A28F
		public int Count
		{
			get
			{
				return this._size;
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000323 RID: 803 RVA: 0x0000C097 File Offset: 0x0000A297
		public int Capacity
		{
			get
			{
				return this._array.Length;
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000324 RID: 804 RVA: 0x00003925 File Offset: 0x00001B25
		bool ICollection.IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000325 RID: 805 RVA: 0x00003922 File Offset: 0x00001B22
		object ICollection.SyncRoot
		{
			get
			{
				return this;
			}
		}

		// Token: 0x06000326 RID: 806 RVA: 0x0000C0A1 File Offset: 0x0000A2A1
		public void Clear()
		{
			if (RuntimeHelpers.IsReferenceOrContainsReferences<T>())
			{
				Array.Clear(this._array, 0, this._size);
			}
			this._size = 0;
			this._version++;
		}

		// Token: 0x06000327 RID: 807 RVA: 0x0000C0D1 File Offset: 0x0000A2D1
		public bool Contains(T item)
		{
			return this._size != 0 && Array.LastIndexOf<T>(this._array, item, this._size - 1) != -1;
		}

		// Token: 0x06000328 RID: 808 RVA: 0x0000C0F8 File Offset: 0x0000A2F8
		public void CopyTo(T[] array, int arrayIndex)
		{
			ArgumentNullException.ThrowIfNull(array, "array");
			if (arrayIndex < 0 || arrayIndex > array.Length)
			{
				throw new ArgumentOutOfRangeException("arrayIndex", arrayIndex, SR.ArgumentOutOfRange_IndexMustBeLessOrEqual);
			}
			if (array.Length - arrayIndex < this._size)
			{
				throw new ArgumentException(SR.Argument_InvalidOffLen);
			}
			int i = 0;
			int num = arrayIndex + this._size;
			while (i < this._size)
			{
				array[--num] = this._array[i++];
			}
		}

		// Token: 0x06000329 RID: 809 RVA: 0x0000C17C File Offset: 0x0000A37C
		void ICollection.CopyTo(Array array, int arrayIndex)
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
			if (arrayIndex < 0 || arrayIndex > array.Length)
			{
				throw new ArgumentOutOfRangeException("arrayIndex", arrayIndex, SR.ArgumentOutOfRange_IndexMustBeLessOrEqual);
			}
			if (array.Length - arrayIndex < this._size)
			{
				throw new ArgumentException(SR.Argument_InvalidOffLen);
			}
			try
			{
				Array.Copy(this._array, 0, array, arrayIndex, this._size);
				Array.Reverse(array, arrayIndex, this._size);
			}
			catch (ArrayTypeMismatchException)
			{
				throw new ArgumentException(SR.Argument_IncompatibleArrayType, "array");
			}
		}

		// Token: 0x0600032A RID: 810 RVA: 0x0000C24C File Offset: 0x0000A44C
		[NullableContext(0)]
		public Stack<T>.Enumerator GetEnumerator()
		{
			return new Stack<T>.Enumerator(this);
		}

		// Token: 0x0600032B RID: 811 RVA: 0x0000C254 File Offset: 0x0000A454
		IEnumerator<T> IEnumerable<!0>.GetEnumerator()
		{
			if (this.Count != 0)
			{
				return this.GetEnumerator();
			}
			return EnumerableHelpers.GetEmptyEnumerator<T>();
		}

		// Token: 0x0600032C RID: 812 RVA: 0x0000484C File Offset: 0x00002A4C
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<!0>)this).GetEnumerator();
		}

		// Token: 0x0600032D RID: 813 RVA: 0x0000C27C File Offset: 0x0000A47C
		public void TrimExcess()
		{
			int num = (int)((double)this._array.Length * 0.9);
			if (this._size < num)
			{
				Array.Resize<T>(ref this._array, this._size);
			}
		}

		// Token: 0x0600032E RID: 814 RVA: 0x0000C2B8 File Offset: 0x0000A4B8
		public void TrimExcess(int capacity)
		{
			ArgumentOutOfRangeException.ThrowIfNegative<int>(capacity, "capacity");
			ArgumentOutOfRangeException.ThrowIfLessThan<int>(capacity, this._size, "capacity");
			if (capacity == this._array.Length)
			{
				return;
			}
			Array.Resize<T>(ref this._array, capacity);
		}

		// Token: 0x0600032F RID: 815 RVA: 0x0000C2F0 File Offset: 0x0000A4F0
		public T Peek()
		{
			int num = this._size - 1;
			T[] array = this._array;
			if (num >= array.Length)
			{
				this.ThrowForEmptyStack();
			}
			return array[num];
		}

		// Token: 0x06000330 RID: 816 RVA: 0x0000C320 File Offset: 0x0000A520
		public bool TryPeek([MaybeNullWhen(false)] out T result)
		{
			int num = this._size - 1;
			T[] array = this._array;
			if (num >= array.Length)
			{
				result = default(T);
				return false;
			}
			result = array[num];
			return true;
		}

		// Token: 0x06000331 RID: 817 RVA: 0x0000C35C File Offset: 0x0000A55C
		public T Pop()
		{
			int num = this._size - 1;
			T[] array = this._array;
			if (num >= array.Length)
			{
				this.ThrowForEmptyStack();
			}
			this._version++;
			this._size = num;
			T result = array[num];
			if (RuntimeHelpers.IsReferenceOrContainsReferences<T>())
			{
				array[num] = default(T);
			}
			return result;
		}

		// Token: 0x06000332 RID: 818 RVA: 0x0000C3B8 File Offset: 0x0000A5B8
		public bool TryPop([MaybeNullWhen(false)] out T result)
		{
			int num = this._size - 1;
			T[] array = this._array;
			if (num >= array.Length)
			{
				result = default(T);
				return false;
			}
			this._version++;
			this._size = num;
			result = array[num];
			if (RuntimeHelpers.IsReferenceOrContainsReferences<T>())
			{
				array[num] = default(T);
			}
			return true;
		}

		// Token: 0x06000333 RID: 819 RVA: 0x0000C420 File Offset: 0x0000A620
		public void Push(T item)
		{
			int size = this._size;
			T[] array = this._array;
			if (size < array.Length)
			{
				array[size] = item;
				this._version++;
				this._size = size + 1;
				return;
			}
			this.PushWithResize(item);
		}

		// Token: 0x06000334 RID: 820 RVA: 0x0000C468 File Offset: 0x0000A668
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void PushWithResize(T item)
		{
			this.Grow(this._size + 1);
			this._array[this._size] = item;
			this._version++;
			this._size++;
		}

		// Token: 0x06000335 RID: 821 RVA: 0x0000C4A6 File Offset: 0x0000A6A6
		public int EnsureCapacity(int capacity)
		{
			ArgumentOutOfRangeException.ThrowIfNegative<int>(capacity, "capacity");
			if (this._array.Length < capacity)
			{
				this.Grow(capacity);
			}
			return this._array.Length;
		}

		// Token: 0x06000336 RID: 822 RVA: 0x0000C4D0 File Offset: 0x0000A6D0
		private void Grow(int capacity)
		{
			int num = (this._array.Length == 0) ? 4 : (2 * this._array.Length);
			if ((ulong)num > (ulong)((long)Array.MaxLength))
			{
				num = Array.MaxLength;
			}
			if (num < capacity)
			{
				num = capacity;
			}
			Array.Resize<T>(ref this._array, num);
		}

		// Token: 0x06000337 RID: 823 RVA: 0x0000C518 File Offset: 0x0000A718
		public T[] ToArray()
		{
			if (this._size == 0)
			{
				return Array.Empty<T>();
			}
			T[] array = new T[this._size];
			for (int i = 0; i < this._size; i++)
			{
				array[i] = this._array[this._size - i - 1];
			}
			return array;
		}

		// Token: 0x06000338 RID: 824 RVA: 0x0000C56D File Offset: 0x0000A76D
		private void ThrowForEmptyStack()
		{
			throw new InvalidOperationException(SR.InvalidOperation_EmptyStack);
		}

		// Token: 0x040000A0 RID: 160
		private T[] _array;

		// Token: 0x040000A1 RID: 161
		private int _size;

		// Token: 0x040000A2 RID: 162
		private int _version;

		// Token: 0x02000044 RID: 68
		[NullableContext(0)]
		public struct Enumerator : IEnumerator<!0>, IEnumerator, IDisposable
		{
			// Token: 0x06000339 RID: 825 RVA: 0x0000C579 File Offset: 0x0000A779
			internal Enumerator(Stack<T> stack)
			{
				this._stack = stack;
				this._version = stack._version;
				this._index = -2;
				this._currentElement = default(T);
			}

			// Token: 0x0600033A RID: 826 RVA: 0x0000C5A2 File Offset: 0x0000A7A2
			public void Dispose()
			{
				this._index = -1;
			}

			// Token: 0x0600033B RID: 827 RVA: 0x0000C5AC File Offset: 0x0000A7AC
			public bool MoveNext()
			{
				if (this._version != this._stack._version)
				{
					throw new InvalidOperationException(SR.InvalidOperation_EnumFailedVersion);
				}
				if (this._index == -2)
				{
					this._index = this._stack._size - 1;
					bool flag = this._index >= 0;
					if (flag)
					{
						this._currentElement = this._stack._array[this._index];
					}
					return flag;
				}
				if (this._index == -1)
				{
					return false;
				}
				int num = this._index - 1;
				this._index = num;
				bool flag2 = num >= 0;
				if (flag2)
				{
					this._currentElement = this._stack._array[this._index];
					return flag2;
				}
				this._currentElement = default(T);
				return flag2;
			}

			// Token: 0x170000E6 RID: 230
			// (get) Token: 0x0600033C RID: 828 RVA: 0x0000C66E File Offset: 0x0000A86E
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

			// Token: 0x0600033D RID: 829 RVA: 0x0000C685 File Offset: 0x0000A885
			private void ThrowEnumerationNotStartedOrEnded()
			{
				throw new InvalidOperationException((this._index == -2) ? SR.InvalidOperation_EnumNotStarted : SR.InvalidOperation_EnumEnded);
			}

			// Token: 0x170000E7 RID: 231
			// (get) Token: 0x0600033E RID: 830 RVA: 0x0000C6A2 File Offset: 0x0000A8A2
			[Nullable(2)]
			object IEnumerator.Current
			{
				get
				{
					return this.Current;
				}
			}

			// Token: 0x0600033F RID: 831 RVA: 0x0000C6AF File Offset: 0x0000A8AF
			void IEnumerator.Reset()
			{
				if (this._version != this._stack._version)
				{
					throw new InvalidOperationException(SR.InvalidOperation_EnumFailedVersion);
				}
				this._index = -2;
				this._currentElement = default(T);
			}

			// Token: 0x040000A3 RID: 163
			private readonly Stack<T> _stack;

			// Token: 0x040000A4 RID: 164
			private readonly int _version;

			// Token: 0x040000A5 RID: 165
			private int _index;

			// Token: 0x040000A6 RID: 166
			private T _currentElement;
		}
	}
}
