using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using System.Runtime.Versioning;

namespace System
{
	// Token: 0x020001A4 RID: 420
	[NullableContext(1)]
	[Nullable(0)]
	[CompilerFeatureRequired("RefStructs")]
	[DebuggerTypeProxy(typeof(SpanDebugView<>))]
	[DebuggerDisplay("{ToString(),raw}")]
	[NonVersionable]
	[NativeMarshalling(typeof(SpanMarshaller<, >))]
	[Intrinsic]
	public readonly ref struct Span<[Nullable(2)] T>
	{
		// Token: 0x06001C3A RID: 7226 RVA: 0x00059E78 File Offset: 0x00058078
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Span([Nullable(new byte[]
		{
			2,
			1
		})] T[] array)
		{
			if (array == null)
			{
				this = default(Span<T>);
				return;
			}
			if (!typeof(T).IsValueType && array.GetType() != typeof(T[]))
			{
				ThrowHelper.ThrowArrayTypeMismatchException();
			}
			this._reference = MemoryMarshal.GetArrayDataReference<T>(array);
			this._length = array.Length;
		}

		// Token: 0x06001C3B RID: 7227 RVA: 0x00059ED4 File Offset: 0x000580D4
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Span([Nullable(new byte[]
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
				this = default(Span<T>);
				return;
			}
			if (!typeof(T).IsValueType && array.GetType() != typeof(T[]))
			{
				ThrowHelper.ThrowArrayTypeMismatchException();
			}
			if ((ulong)start + (ulong)length > (ulong)array.Length)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException();
			}
			this._reference = Unsafe.Add<T>(MemoryMarshal.GetArrayDataReference<T>(array), (IntPtr)((UIntPtr)start));
			this._length = length;
		}

		// Token: 0x06001C3C RID: 7228 RVA: 0x00059F4E File Offset: 0x0005814E
		[NullableContext(0)]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe Span(void* pointer, int length)
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

		// Token: 0x06001C3D RID: 7229 RVA: 0x00059F7D File Offset: 0x0005817D
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Span(ref T reference)
		{
			this._reference = ref reference;
			this._length = 1;
		}

		// Token: 0x06001C3E RID: 7230 RVA: 0x00059F8D File Offset: 0x0005818D
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal Span(ref T reference, int length)
		{
			this._reference = ref reference;
			this._length = length;
		}

		// Token: 0x170002F8 RID: 760
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

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x06001C40 RID: 7232 RVA: 0x00059FBA File Offset: 0x000581BA
		public int Length
		{
			[Intrinsic]
			[NonVersionable]
			get
			{
				return this._length;
			}
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x06001C41 RID: 7233 RVA: 0x00059FC2 File Offset: 0x000581C2
		public bool IsEmpty
		{
			[NonVersionable]
			get
			{
				return this._length == 0;
			}
		}

		// Token: 0x06001C42 RID: 7234 RVA: 0x00059FCD File Offset: 0x000581CD
		public static bool operator !=([Nullable(new byte[]
		{
			0,
			1
		})] Span<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Span<T> right)
		{
			return !(left == right);
		}

		// Token: 0x06001C43 RID: 7235 RVA: 0x00056E41 File Offset: 0x00055041
		[NullableContext(2)]
		[Obsolete("Equals() on Span will always throw an exception. Use the equality operator instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			throw new NotSupportedException(SR.NotSupported_CannotCallEqualsOnSpan);
		}

		// Token: 0x06001C44 RID: 7236 RVA: 0x00056E4D File Offset: 0x0005504D
		[Obsolete("GetHashCode() on Span will always throw an exception.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			throw new NotSupportedException(SR.NotSupported_CannotCallGetHashCodeOnSpan);
		}

		// Token: 0x06001C45 RID: 7237 RVA: 0x00059FD9 File Offset: 0x000581D9
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static implicit operator Span<T>([Nullable(new byte[]
		{
			2,
			1
		})] T[] array)
		{
			return new Span<T>(array);
		}

		// Token: 0x06001C46 RID: 7238 RVA: 0x00059FE1 File Offset: 0x000581E1
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static implicit operator Span<T>([Nullable(new byte[]
		{
			0,
			1
		})] ArraySegment<T> segment)
		{
			return new Span<T>(segment.Array, segment.Offset, segment.Count);
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06001C47 RID: 7239 RVA: 0x0005A000 File Offset: 0x00058200
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static Span<T> Empty
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return default(Span<T>);
			}
		}

		// Token: 0x06001C48 RID: 7240 RVA: 0x0005A016 File Offset: 0x00058216
		[NullableContext(0)]
		public Span<T>.Enumerator GetEnumerator()
		{
			return new Span<T>.Enumerator(this);
		}

		// Token: 0x06001C49 RID: 7241 RVA: 0x0005A024 File Offset: 0x00058224
		[EditorBrowsable(EditorBrowsableState.Never)]
		public ref T GetPinnableReference()
		{
			ref T result = ref Unsafe.NullRef<T>();
			if (this._length != 0)
			{
				result = this._reference;
			}
			return ref result;
		}

		// Token: 0x06001C4A RID: 7242 RVA: 0x0005A048 File Offset: 0x00058248
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Clear()
		{
			if (RuntimeHelpers.IsReferenceOrContainsReferences<T>())
			{
				SpanHelpers.ClearWithReferences(Unsafe.As<T, IntPtr>(this._reference), (UIntPtr)this._length * (UIntPtr)((IntPtr)(sizeof(T) / 8)));
				return;
			}
			SpanHelpers.ClearWithoutReferences(Unsafe.As<T, byte>(this._reference), (UIntPtr)this._length * (UIntPtr)((IntPtr)sizeof(T)));
		}

		// Token: 0x06001C4B RID: 7243 RVA: 0x0005A0A1 File Offset: 0x000582A1
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Fill(T value)
		{
			SpanHelpers.Fill<T>(this._reference, (UIntPtr)this._length, value);
		}

		// Token: 0x06001C4C RID: 7244 RVA: 0x0005A0B6 File Offset: 0x000582B6
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

		// Token: 0x06001C4D RID: 7245 RVA: 0x0005A0E8 File Offset: 0x000582E8
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

		// Token: 0x06001C4E RID: 7246 RVA: 0x0005A122 File Offset: 0x00058322
		public static bool operator ==([Nullable(new byte[]
		{
			0,
			1
		})] Span<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Span<T> right)
		{
			return left._length == right._length && Unsafe.AreSame<T>(left._reference, right._reference);
		}

		// Token: 0x06001C4F RID: 7247 RVA: 0x0005A147 File Offset: 0x00058347
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static implicit operator ReadOnlySpan<T>([Nullable(new byte[]
		{
			0,
			1
		})] Span<T> span)
		{
			return new ReadOnlySpan<T>(span._reference, span._length);
		}

		// Token: 0x06001C50 RID: 7248 RVA: 0x0005A15C File Offset: 0x0005835C
		public override string ToString()
		{
			if (typeof(T) == typeof(char))
			{
				return new string(new ReadOnlySpan<char>(Unsafe.As<T, char>(this._reference), this._length));
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 2);
			defaultInterpolatedStringHandler.AppendLiteral("System.Span<");
			defaultInterpolatedStringHandler.AppendFormatted(typeof(T).Name);
			defaultInterpolatedStringHandler.AppendLiteral(">[");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this._length);
			defaultInterpolatedStringHandler.AppendLiteral("]");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x06001C51 RID: 7249 RVA: 0x0005A1F8 File Offset: 0x000583F8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public Span<T> Slice(int start)
		{
			if (start > this._length)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException();
			}
			return new Span<T>(Unsafe.Add<T>(this._reference, (IntPtr)((UIntPtr)start)), this._length - start);
		}

		// Token: 0x06001C52 RID: 7250 RVA: 0x0005A222 File Offset: 0x00058422
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public Span<T> Slice(int start, int length)
		{
			if ((ulong)start + (ulong)length > (ulong)this._length)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException();
			}
			return new Span<T>(Unsafe.Add<T>(this._reference, (IntPtr)((UIntPtr)start)), length);
		}

		// Token: 0x06001C53 RID: 7251 RVA: 0x0005A24A File Offset: 0x0005844A
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
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

		// Token: 0x04000571 RID: 1393
		internal unsafe readonly T* _reference;

		// Token: 0x04000572 RID: 1394
		private readonly int _length;

		// Token: 0x020001A5 RID: 421
		[Nullable(0)]
		[CompilerFeatureRequired("RefStructs")]
		public ref struct Enumerator
		{
			// Token: 0x06001C54 RID: 7252 RVA: 0x0005A27D File Offset: 0x0005847D
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			internal Enumerator(Span<T> span)
			{
				this._span = span;
				this._index = -1;
			}

			// Token: 0x06001C55 RID: 7253 RVA: 0x0005A290 File Offset: 0x00058490
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

			// Token: 0x170002FC RID: 764
			// (get) Token: 0x06001C56 RID: 7254 RVA: 0x0005A2BE File Offset: 0x000584BE
			public ref T Current
			{
				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				get
				{
					return this._span[this._index];
				}
			}

			// Token: 0x04000573 RID: 1395
			private readonly Span<T> _span;

			// Token: 0x04000574 RID: 1396
			private int _index;
		}
	}
}
