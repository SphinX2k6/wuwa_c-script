using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System
{
	// Token: 0x020000D5 RID: 213
	[NullableContext(1)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[DebuggerTypeProxy(typeof(ICollectionDebugView<>))]
	[DebuggerDisplay("Count = {Count}")]
	[Serializable]
	public readonly struct ArraySegment<[Nullable(2)] T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
	{
		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000A16 RID: 2582 RVA: 0x0001EB40 File Offset: 0x0001CD40
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static ArraySegment<T> Empty { [return: Nullable(new byte[]
		{
			0,
			1
		})] get; } = new ArraySegment<T>(new T[0]);

		// Token: 0x06000A17 RID: 2583 RVA: 0x0001EB47 File Offset: 0x0001CD47
		public ArraySegment(T[] array)
		{
			if (array == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
			}
			this._array = array;
			this._offset = 0;
			this._count = array.Length;
		}

		// Token: 0x06000A18 RID: 2584 RVA: 0x0001EB69 File Offset: 0x0001CD69
		public ArraySegment(T[] array, int offset, int count)
		{
			if (array == null || offset > array.Length || count > array.Length - offset)
			{
				ThrowHelper.ThrowArraySegmentCtorValidationFailedExceptions(array, offset, count);
			}
			this._array = array;
			this._offset = offset;
			this._count = count;
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x06000A19 RID: 2585 RVA: 0x0001EB99 File Offset: 0x0001CD99
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public T[] Array
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				return this._array;
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x06000A1A RID: 2586 RVA: 0x0001EBA1 File Offset: 0x0001CDA1
		public int Offset
		{
			get
			{
				return this._offset;
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x06000A1B RID: 2587 RVA: 0x0001EBA9 File Offset: 0x0001CDA9
		public int Count
		{
			get
			{
				return this._count;
			}
		}

		// Token: 0x17000107 RID: 263
		public T this[int index]
		{
			get
			{
				if (index >= this._count)
				{
					ThrowHelper.ThrowArgumentOutOfRange_IndexMustBeLessException();
				}
				return this._array[this._offset + index];
			}
			set
			{
				if (index >= this._count)
				{
					ThrowHelper.ThrowArgumentOutOfRange_IndexMustBeLessException();
				}
				this._array[this._offset + index] = value;
			}
		}

		// Token: 0x06000A1E RID: 2590 RVA: 0x0001EBF8 File Offset: 0x0001CDF8
		[NullableContext(0)]
		public ArraySegment<T>.Enumerator GetEnumerator()
		{
			this.ThrowInvalidOperationIfDefault();
			return new ArraySegment<T>.Enumerator(this);
		}

		// Token: 0x06000A1F RID: 2591 RVA: 0x0001EC0B File Offset: 0x0001CE0B
		public override int GetHashCode()
		{
			if (this._array != null)
			{
				return HashCode.Combine<int, int, int>(this._offset, this._count, this._array.GetHashCode());
			}
			return 0;
		}

		// Token: 0x06000A20 RID: 2592 RVA: 0x0001EC33 File Offset: 0x0001CE33
		public void CopyTo(T[] destination)
		{
			this.CopyTo(destination, 0);
		}

		// Token: 0x06000A21 RID: 2593 RVA: 0x0001EC3D File Offset: 0x0001CE3D
		public void CopyTo(T[] destination, int destinationIndex)
		{
			this.ThrowInvalidOperationIfDefault();
			System.Array.Copy(this._array, this._offset, destination, destinationIndex, this._count);
		}

		// Token: 0x06000A22 RID: 2594 RVA: 0x0001EC60 File Offset: 0x0001CE60
		public void CopyTo([Nullable(new byte[]
		{
			0,
			1
		})] ArraySegment<T> destination)
		{
			this.ThrowInvalidOperationIfDefault();
			destination.ThrowInvalidOperationIfDefault();
			if (this._count > destination._count)
			{
				ThrowHelper.ThrowArgumentException_DestinationTooShort();
			}
			System.Array.Copy(this._array, this._offset, destination._array, destination._offset, this._count);
		}

		// Token: 0x06000A23 RID: 2595 RVA: 0x0001ECB0 File Offset: 0x0001CEB0
		[NullableContext(2)]
		public override bool Equals([NotNullWhen(true)] object obj)
		{
			if (obj is ArraySegment<T>)
			{
				ArraySegment<T> obj2 = (ArraySegment<T>)obj;
				return this.Equals(obj2);
			}
			return false;
		}

		// Token: 0x06000A24 RID: 2596 RVA: 0x0001ECD5 File Offset: 0x0001CED5
		public bool Equals([Nullable(new byte[]
		{
			0,
			1
		})] ArraySegment<T> obj)
		{
			return obj._array == this._array && obj._offset == this._offset && obj._count == this._count;
		}

		// Token: 0x06000A25 RID: 2597 RVA: 0x0001ED03 File Offset: 0x0001CF03
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public ArraySegment<T> Slice(int index)
		{
			this.ThrowInvalidOperationIfDefault();
			if (index > this._count)
			{
				ThrowHelper.ThrowArgumentOutOfRange_IndexMustBeLessOrEqualException();
			}
			return new ArraySegment<T>(this._array, this._offset + index, this._count - index);
		}

		// Token: 0x06000A26 RID: 2598 RVA: 0x0001ED34 File Offset: 0x0001CF34
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public ArraySegment<T> Slice(int index, int count)
		{
			this.ThrowInvalidOperationIfDefault();
			if (index > this._count || count > this._count - index)
			{
				ThrowHelper.ThrowArgumentOutOfRange_IndexMustBeLessOrEqualException();
			}
			return new ArraySegment<T>(this._array, this._offset + index, count);
		}

		// Token: 0x06000A27 RID: 2599 RVA: 0x0001ED6C File Offset: 0x0001CF6C
		public T[] ToArray()
		{
			this.ThrowInvalidOperationIfDefault();
			if (this._count == 0)
			{
				return ArraySegment<T>.Empty._array;
			}
			T[] array = new T[this._count];
			System.Array.Copy(this._array, this._offset, array, 0, this._count);
			return array;
		}

		// Token: 0x06000A28 RID: 2600 RVA: 0x0001EDB8 File Offset: 0x0001CFB8
		public static bool operator ==([Nullable(new byte[]
		{
			0,
			1
		})] ArraySegment<T> a, [Nullable(new byte[]
		{
			0,
			1
		})] ArraySegment<T> b)
		{
			return a.Equals(b);
		}

		// Token: 0x06000A29 RID: 2601 RVA: 0x0001EDC2 File Offset: 0x0001CFC2
		public static bool operator !=([Nullable(new byte[]
		{
			0,
			1
		})] ArraySegment<T> a, [Nullable(new byte[]
		{
			0,
			1
		})] ArraySegment<T> b)
		{
			return !(a == b);
		}

		// Token: 0x06000A2A RID: 2602 RVA: 0x0001EDD0 File Offset: 0x0001CFD0
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static implicit operator ArraySegment<T>(T[] array)
		{
			if (array == null)
			{
				return default(ArraySegment<T>);
			}
			return new ArraySegment<T>(array);
		}

		// Token: 0x17000108 RID: 264
		T IList<!0>.this[int index]
		{
			get
			{
				this.ThrowInvalidOperationIfDefault();
				if (index < 0 || index >= this._count)
				{
					ThrowHelper.ThrowArgumentOutOfRange_IndexMustBeLessException();
				}
				return this._array[this._offset + index];
			}
			set
			{
				this.ThrowInvalidOperationIfDefault();
				if (index < 0 || index >= this._count)
				{
					ThrowHelper.ThrowArgumentOutOfRange_IndexMustBeLessException();
				}
				this._array[this._offset + index] = value;
			}
		}

		// Token: 0x06000A2D RID: 2605 RVA: 0x0001EE4C File Offset: 0x0001D04C
		int IList<!0>.IndexOf(T item)
		{
			this.ThrowInvalidOperationIfDefault();
			int num = System.Array.IndexOf<T>(this._array, item, this._offset, this._count);
			if (num < 0)
			{
				return -1;
			}
			return num - this._offset;
		}

		// Token: 0x06000A2E RID: 2606 RVA: 0x0001EE86 File Offset: 0x0001D086
		void IList<!0>.Insert(int index, T item)
		{
			ThrowHelper.ThrowNotSupportedException();
		}

		// Token: 0x06000A2F RID: 2607 RVA: 0x0001EE86 File Offset: 0x0001D086
		void IList<!0>.RemoveAt(int index)
		{
			ThrowHelper.ThrowNotSupportedException();
		}

		// Token: 0x17000109 RID: 265
		T IReadOnlyList<!0>.this[int index]
		{
			get
			{
				this.ThrowInvalidOperationIfDefault();
				if (index < 0 || index >= this._count)
				{
					ThrowHelper.ThrowArgumentOutOfRange_IndexMustBeLessException();
				}
				return this._array[this._offset + index];
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x06000A31 RID: 2609 RVA: 0x000070DD File Offset: 0x000052DD
		bool ICollection<!0>.IsReadOnly
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000A32 RID: 2610 RVA: 0x0001EE86 File Offset: 0x0001D086
		void ICollection<!0>.Add(T item)
		{
			ThrowHelper.ThrowNotSupportedException();
		}

		// Token: 0x06000A33 RID: 2611 RVA: 0x0001EE86 File Offset: 0x0001D086
		void ICollection<!0>.Clear()
		{
			ThrowHelper.ThrowNotSupportedException();
		}

		// Token: 0x06000A34 RID: 2612 RVA: 0x0001EE8D File Offset: 0x0001D08D
		bool ICollection<!0>.Contains(T item)
		{
			this.ThrowInvalidOperationIfDefault();
			return System.Array.IndexOf<T>(this._array, item, this._offset, this._count) >= 0;
		}

		// Token: 0x06000A35 RID: 2613 RVA: 0x0001EEB3 File Offset: 0x0001D0B3
		bool ICollection<!0>.Remove(T item)
		{
			ThrowHelper.ThrowNotSupportedException();
			return false;
		}

		// Token: 0x06000A36 RID: 2614 RVA: 0x0001EEBC File Offset: 0x0001D0BC
		IEnumerator<T> IEnumerable<!0>.GetEnumerator()
		{
			this.ThrowInvalidOperationIfDefault();
			if (this.Count != 0)
			{
				return new ArraySegment<T>.Enumerator(this);
			}
			return SZGenericArrayEnumerator<T>.Empty;
		}

		// Token: 0x06000A37 RID: 2615 RVA: 0x0001EEF1 File Offset: 0x0001D0F1
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<!0>)this).GetEnumerator();
		}

		// Token: 0x06000A38 RID: 2616 RVA: 0x0001EF03 File Offset: 0x0001D103
		private void ThrowInvalidOperationIfDefault()
		{
			if (this._array == null)
			{
				ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_NullArray);
			}
		}

		// Token: 0x040002E1 RID: 737
		private readonly T[] _array;

		// Token: 0x040002E2 RID: 738
		private readonly int _offset;

		// Token: 0x040002E3 RID: 739
		private readonly int _count;

		// Token: 0x020000D6 RID: 214
		[NullableContext(0)]
		public struct Enumerator : IEnumerator<T>, IDisposable, IEnumerator
		{
			// Token: 0x06000A3A RID: 2618 RVA: 0x0001EF26 File Offset: 0x0001D126
			internal Enumerator(ArraySegment<T> arraySegment)
			{
				this._array = arraySegment.Array;
				this._start = arraySegment.Offset;
				this._end = arraySegment.Offset + arraySegment.Count;
				this._current = arraySegment.Offset - 1;
			}

			// Token: 0x06000A3B RID: 2619 RVA: 0x0001EF66 File Offset: 0x0001D166
			public bool MoveNext()
			{
				if (this._current < this._end)
				{
					this._current++;
					return this._current < this._end;
				}
				return false;
			}

			// Token: 0x1700010B RID: 267
			// (get) Token: 0x06000A3C RID: 2620 RVA: 0x0001EF94 File Offset: 0x0001D194
			[Nullable(1)]
			public T Current
			{
				[NullableContext(1)]
				get
				{
					if (this._current < this._start)
					{
						ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumNotStarted();
					}
					if (this._current >= this._end)
					{
						ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumEnded();
					}
					return this._array[this._current];
				}
			}

			// Token: 0x1700010C RID: 268
			// (get) Token: 0x06000A3D RID: 2621 RVA: 0x0001EFCD File Offset: 0x0001D1CD
			[Nullable(2)]
			object IEnumerator.Current
			{
				get
				{
					return this.Current;
				}
			}

			// Token: 0x06000A3E RID: 2622 RVA: 0x0001EFDA File Offset: 0x0001D1DA
			void IEnumerator.Reset()
			{
				this._current = this._start - 1;
			}

			// Token: 0x06000A3F RID: 2623 RVA: 0x0000FCFA File Offset: 0x0000DEFA
			public void Dispose()
			{
			}

			// Token: 0x040002E4 RID: 740
			private readonly T[] _array;

			// Token: 0x040002E5 RID: 741
			private readonly int _start;

			// Token: 0x040002E6 RID: 742
			private readonly int _end;

			// Token: 0x040002E7 RID: 743
			private int _current;
		}
	}
}
