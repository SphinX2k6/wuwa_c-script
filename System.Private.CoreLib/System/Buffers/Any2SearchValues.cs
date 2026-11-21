using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Buffers
{
	// Token: 0x02000358 RID: 856
	internal sealed class Any2SearchValues<T, TImpl> : SearchValues<T> where T : struct, IEquatable<T> where TImpl : struct, INumber<TImpl>
	{
		// Token: 0x06003B0E RID: 15118 RVA: 0x000C4724 File Offset: 0x000C2924
		public unsafe Any2SearchValues(ReadOnlySpan<TImpl> values)
		{
			TImpl e = *values[0];
			TImpl e2 = *values[1];
			this._e0 = e;
			this._e1 = e2;
		}

		// Token: 0x06003B0F RID: 15119 RVA: 0x000C4764 File Offset: 0x000C2964
		internal unsafe override T[] GetValues()
		{
			TImpl e = this._e0;
			TImpl e2 = this._e1;
			return new T[]
			{
				*(T*)(&e),
				*(T*)(&e2)
			};
		}

		// Token: 0x06003B10 RID: 15120 RVA: 0x000C47A3 File Offset: 0x000C29A3
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal unsafe override bool ContainsCore(T value)
		{
			return *(TImpl*)(&value) == this._e0 || *(TImpl*)(&value) == this._e1;
		}

		// Token: 0x06003B11 RID: 15121 RVA: 0x000C47DB File Offset: 0x000C29DB
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override int IndexOfAny(ReadOnlySpan<T> span)
		{
			return SpanHelpers.NonPackedIndexOfAnyValueType<TImpl, SpanHelpers.DontNegate<TImpl>>(Unsafe.As<T, TImpl>(MemoryMarshal.GetReference<T>(span)), this._e0, this._e1, span.Length);
		}

		// Token: 0x06003B12 RID: 15122 RVA: 0x000C4800 File Offset: 0x000C2A00
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override int IndexOfAnyExcept(ReadOnlySpan<T> span)
		{
			return SpanHelpers.NonPackedIndexOfAnyValueType<TImpl, SpanHelpers.Negate<TImpl>>(Unsafe.As<T, TImpl>(MemoryMarshal.GetReference<T>(span)), this._e0, this._e1, span.Length);
		}

		// Token: 0x06003B13 RID: 15123 RVA: 0x000C4825 File Offset: 0x000C2A25
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override int LastIndexOfAny(ReadOnlySpan<T> span)
		{
			return SpanHelpers.LastIndexOfAnyValueType<TImpl>(Unsafe.As<T, TImpl>(MemoryMarshal.GetReference<T>(span)), this._e0, this._e1, span.Length);
		}

		// Token: 0x06003B14 RID: 15124 RVA: 0x000C484A File Offset: 0x000C2A4A
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override int LastIndexOfAnyExcept(ReadOnlySpan<T> span)
		{
			return SpanHelpers.LastIndexOfAnyExceptValueType<TImpl>(Unsafe.As<T, TImpl>(MemoryMarshal.GetReference<T>(span)), this._e0, this._e1, span.Length);
		}

		// Token: 0x04000C6E RID: 3182
		private readonly TImpl _e0;

		// Token: 0x04000C6F RID: 3183
		private readonly TImpl _e1;
	}
}
