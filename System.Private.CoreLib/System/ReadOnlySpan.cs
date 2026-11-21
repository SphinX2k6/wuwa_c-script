using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using System.Runtime.Versioning;

namespace System
{
	// Token: 0x0200019D RID: 413
	[NullableContext(1)]
	[Nullable(0)]
	[CompilerFeatureRequired("RefStructs")]
	[DebuggerTypeProxy(typeof(SpanDebugView<>))]
	[DebuggerDisplay("{ToString(),raw}")]
	[NonVersionable]
	[NativeMarshalling(typeof(ReadOnlySpanMarshaller<, >))]
	[Intrinsic]
	public readonly ref struct ReadOnlySpan<[Nullable(2)] T>
	{
		// Token: 0x06001AA1 RID: 6817 RVA: 0x00056D3F File Offset: 0x00054F3F
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public ReadOnlySpan([Nullable(new byte[]
		{
			2,
			1
		})] T[] array)
		{
			if (array == null)
			{
				this = default(ReadOnlySpan<T>);
				return;
			}
			this._reference = MemoryMarshal.GetArrayDataReference<T>(array);
			this._length = array.Length;
		}

		// Token: 0x06001AA2 RID: 6818 RVA: 0x00056D64 File Offset: 0x00054F64
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public ReadOnlySpan([Nullable(new byte[]
		{
			2,
			1
		})] T[] array, int start, int length)
		{
			if (array == null)
			{
				if (start != 0 || length != 0)
				{
					ThrowHelper.ThrowArgumentOutOfRangeException();
				}
				this = default(ReadOnlySpan<T>);
				return;
			}
			if ((ulong)start + (ulong)length > (ulong)array.Length)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException();
			}
			this._reference = Unsafe.Add<T>(MemoryMarshal.GetArrayDataReference<T>(array), (IntPtr)((UIntPtr)start));
			this._length = length;
		}

		// Token: 0x06001AA3 RID: 6819 RVA: 0x00056DB1 File Offset: 0x00054FB1
		[NullableContext(0)]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe ReadOnlySpan(void* pointer, int length)
		{
			if (RuntimeHelpers.IsReferenceOrContainsReferences<T>())
			{
				ThrowHelper.ThrowInvalidTypeWithPointersNotSupported(typeof(T));
			}
			if (length < 0)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException();
			}
			this._reference = ref *(T*)pointer;
			this._length = length;
		}

		// Token: 0x06001AA4 RID: 6820 RVA: 0x00056DE0 File Offset: 0x00054FE0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public ReadOnlySpan([RequiresLocation] [In] ref T reference)
		{
			this._reference = Unsafe.AsRef<T>(ref reference);
			this._length = 1;
		}

		// Token: 0x06001AA5 RID: 6821 RVA: 0x00056DF5 File Offset: 0x00054FF5
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal ReadOnlySpan(ref T reference, int length)
		{
			this._reference = ref reference;
			this._length = length;
		}

		// Token: 0x170002B7 RID: 695
		public T this[int index]
		{
			[Intrinsic]
			[NonVersionable]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				if (index >= this._length)
				{
					ThrowHelper.ThrowIndexOutOfRangeException();
				}
				return Unsafe.Add<T>(this._reference, (IntPtr)((UIntPtr)index));
			}
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x06001AA7 RID: 6823 RVA: 0x00056E22 File Offset: 0x00055022
		public int Length
		{
			[Intrinsic]
			[NonVersionable]
			get
			{
				return this._length;
			}
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x06001AA8 RID: 6824 RVA: 0x00056E2A File Offset: 0x0005502A
		public bool IsEmpty
		{
			[NonVersionable]
			get
			{
				return this._length == 0;
			}
		}

		// Token: 0x06001AA9 RID: 6825 RVA: 0x00056E35 File Offset: 0x00055035
		public static bool operator !=([Nullable(new byte[]
		{
			0,
			1
		})] ReadOnlySpan<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] ReadOnlySpan<T> right)
		{
			return !(left == right);
		}

		// Token: 0x06001AAA RID: 6826 RVA: 0x00056E41 File Offset: 0x00055041
		[NullableContext(2)]
		[Obsolete("Equals() on ReadOnlySpan will always throw an exception. Use the equality operator instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			throw new NotSupportedException(SR.NotSupported_CannotCallEqualsOnSpan);
		}

		// Token: 0x06001AAB RID: 6827 RVA: 0x00056E4D File Offset: 0x0005504D
		[Obsolete("GetHashCode() on ReadOnlySpan will always throw an exception.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			throw new NotSupportedException(SR.NotSupported_CannotCallGetHashCodeOnSpan);
		}

		// Token: 0x06001AAC RID: 6828 RVA: 0x00056E59 File Offset: 0x00055059
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static implicit operator ReadOnlySpan<T>([Nullable(new byte[]
		{
			2,
			1
		})] T[] array)
		{
			return new ReadOnlySpan<T>(array);
		}

		// Token: 0x06001AAD RID: 6829 RVA: 0x00056E61 File Offset: 0x00055061
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static implicit operator ReadOnlySpan<T>([Nullable(new byte[]
		{
			0,
			1
		})] ArraySegment<T> segment)
		{
			return new ReadOnlySpan<T>(segment.Array, segment.Offset, segment.Count);
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x06001AAE RID: 6830 RVA: 0x00056E80 File Offset: 0x00055080
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static ReadOnlySpan<T> Empty
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return default(ReadOnlySpan<T>);
			}
		}

		// Token: 0x06001AAF RID: 6831 RVA: 0x00056E96 File Offset: 0x00055096
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static ReadOnlySpan<T> CastUp<[Nullable(2)] TDerived>([Nullable(new byte[]
		{
			0,
			1
		})] ReadOnlySpan<TDerived> items) where TDerived : class, T
		{
			return new ReadOnlySpan<T>(Unsafe.As<TDerived, T>(items._reference), items.Length);
		}

		// Token: 0x06001AB0 RID: 6832 RVA: 0x00056EB0 File Offset: 0x000550B0
		[NullableContext(0)]
		public ReadOnlySpan<T>.Enumerator GetEnumerator()
		{
			return new ReadOnlySpan<T>.Enumerator(this);
		}

		// Token: 0x06001AB1 RID: 6833 RVA: 0x00056EC0 File Offset: 0x000550C0
		[EditorBrowsable(EditorBrowsableState.Never)]
		public ref readonly T GetPinnableReference()
		{
			ref T result = ref Unsafe.NullRef<T>();
			if (this._length != 0)
			{
				result = this._reference;
			}
			return ref result;
		}

		// Token: 0x06001AB2 RID: 6834 RVA: 0x00056EE3 File Offset: 0x000550E3
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void CopyTo([Nullable(new byte[]
		{
			0,
			1
		})] Span<T> destination)
		{
			if (this._length <= destination.Length)
			{
				Buffer.Memmove<T>(destination._reference, this._reference, (UIntPtr)this._length);
				return;
			}
			ThrowHelper.ThrowArgumentException_DestinationTooShort();
		}

		// Token: 0x06001AB3 RID: 6835 RVA: 0x00056F14 File Offset: 0x00055114
		public bool TryCopyTo([Nullable(new byte[]
		{
			0,
			1
		})] Span<T> destination)
		{
			bool result = false;
			if (this._length <= destination.Length)
			{
				Buffer.Memmove<T>(destination._reference, this._reference, (UIntPtr)this._length);
				result = true;
			}
			return result;
		}

		// Token: 0x06001AB4 RID: 6836 RVA: 0x00056F4E File Offset: 0x0005514E
		public static bool operator ==([Nullable(new byte[]
		{
			0,
			1
		})] ReadOnlySpan<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] ReadOnlySpan<T> right)
		{
			return left._length == right._length && Unsafe.AreSame<T>(left._reference, right._reference);
		}

		// Token: 0x06001AB5 RID: 6837 RVA: 0x00056F74 File Offset: 0x00055174
		public override string ToString()
		{
			if (typeof(T) == typeof(char))
			{
				return new string(new ReadOnlySpan<char>(Unsafe.As<T, char>(this._reference), this._length));
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 2);
			defaultInterpolatedStringHandler.AppendLiteral("System.ReadOnlySpan<");
			defaultInterpolatedStringHandler.AppendFormatted(typeof(T).Name);
			defaultInterpolatedStringHandler.AppendLiteral(">[");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this._length);
			defaultInterpolatedStringHandler.AppendLiteral("]");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x06001AB6 RID: 6838 RVA: 0x00057010 File Offset: 0x00055210
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public ReadOnlySpan<T> Slice(int start)
		{
			if (start > this._length)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException();
			}
			return new ReadOnlySpan<T>(Unsafe.Add<T>(this._reference, (IntPtr)((UIntPtr)start)), this._length - start);
		}

		// Token: 0x06001AB7 RID: 6839 RVA: 0x0005703A File Offset: 0x0005523A
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public ReadOnlySpan<T> Slice(int start, int length)
		{
			if ((ulong)start + (ulong)length > (ulong)this._length)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException();
			}
			return new ReadOnlySpan<T>(Unsafe.Add<T>(this._reference, (IntPtr)((UIntPtr)start)), length);
		}

		// Token: 0x06001AB8 RID: 6840 RVA: 0x00057062 File Offset: 0x00055262
		public T[] ToArray()
		{
			if (this._length == 0)
			{
				return Array.Empty<T>();
			}
			T[] array = new T[this._length];
			Buffer.Memmove<T>(MemoryMarshal.GetArrayDataReference<T>(array), this._reference, (UIntPtr)this._length);
			return array;
		}

		// Token: 0x0400055D RID: 1373
		internal unsafe readonly T* _reference;

		// Token: 0x0400055E RID: 1374
		private readonly int _length;

		// Token: 0x0200019E RID: 414
		[Nullable(0)]
		[CompilerFeatureRequired("RefStructs")]
		public ref struct Enumerator
		{
			// Token: 0x06001AB9 RID: 6841 RVA: 0x00057095 File Offset: 0x00055295
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			internal Enumerator(ReadOnlySpan<T> span)
			{
				this._span = span;
				this._index = -1;
			}

			// Token: 0x06001ABA RID: 6842 RVA: 0x000570A8 File Offset: 0x000552A8
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public bool MoveNext()
			{
				int num = this._index + 1;
				if (num < this._span.Length)
				{
					this._index = num;
					return true;
				}
				return false;
			}

			// Token: 0x170002BB RID: 699
			// (get) Token: 0x06001ABB RID: 6843 RVA: 0x000570D6 File Offset: 0x000552D6
			public ref readonly T Current
			{
				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				get
				{
					return this._span[this._index];
				}
			}

			// Token: 0x0400055F RID: 1375
			private readonly ReadOnlySpan<T> _span;

			// Token: 0x04000560 RID: 1376
			private int _index;
		}
	}
}
