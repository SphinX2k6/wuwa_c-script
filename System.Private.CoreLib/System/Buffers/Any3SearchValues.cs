using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Buffers
{
	// Token: 0x02000359 RID: 857
	internal sealed class Any3SearchValues<T, TImpl> : SearchValues<T> where T : struct, IEquatable<T> where TImpl : struct, INumber<TImpl>
	{
		// Token: 0x06003B15 RID: 15125 RVA: 0x000C4870 File Offset: 0x000C2A70
		public unsafe Any3SearchValues(ReadOnlySpan<TImpl> values)
		{
			TImpl e = *values[0];
			TImpl e2 = *values[1];
			TImpl e3 = *values[2];
			this._e0 = e;
			this._e1 = e2;
			this._e2 = e3;
		}

		// Token: 0x06003B16 RID: 15126 RVA: 0x000C48C4 File Offset: 0x000C2AC4
		internal unsafe override T[] GetValues()
		{
			TImpl e = this._e0;
			TImpl e2 = this._e1;
			TImpl e3 = this._e2;
			return new T[]
			{
				*(T*)(&e),
				*(T*)(&e2),
				*(T*)(&e3)
			};
		}

		// Token: 0x06003B17 RID: 15127 RVA: 0x000C491C File Offset: 0x000C2B1C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal unsafe override bool ContainsCore(T value)
		{
			return *(TImpl*)(&value) == this._e0 || *(TImpl*)(&value) == this._e1 || *(TImpl*)(&value) == this._e2;
		}

		// Token: 0x06003B18 RID: 15128 RVA: 0x000C497A File Offset: 0x000C2B7A
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override int IndexOfAny(ReadOnlySpan<T> span)
		{
			return SpanHelpers.NonPackedIndexOfAnyValueType<TImpl, SpanHelpers.DontNegate<TImpl>>(Unsafe.As<T, TImpl>(MemoryMarshal.GetReference<T>(span)), this._e0, this._e1, this._e2, span.Length);
		}

		// Token: 0x06003B19 RID: 15129 RVA: 0x000C49A5 File Offset: 0x000C2BA5
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override int IndexOfAnyExcept(ReadOnlySpan<T> span)
		{
			return SpanHelpers.NonPackedIndexOfAnyValueType<TImpl, SpanHelpers.Negate<TImpl>>(Unsafe.As<T, TImpl>(MemoryMarshal.GetReference<T>(span)), this._e0, this._e1, this._e2, span.Length);
		}

		// Token: 0x06003B1A RID: 15130 RVA: 0x000C49D0 File Offset: 0x000C2BD0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override int LastIndexOfAny(ReadOnlySpan<T> span)
		{
			return SpanHelpers.LastIndexOfAnyValueType<TImpl>(Unsafe.As<T, TImpl>(MemoryMarshal.GetReference<T>(span)), this._e0, this._e1, this._e2, span.Length);
		}

		// Token: 0x06003B1B RID: 15131 RVA: 0x000C49FB File Offset: 0x000C2BFB
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override int LastIndexOfAnyExcept(ReadOnlySpan<T> span)
		{
			return SpanHelpers.LastIndexOfAnyExceptValueType<TImpl>(Unsafe.As<T, TImpl>(MemoryMarshal.GetReference<T>(span)), this._e0, this._e1, this._e2, span.Length);
		}

		// Token: 0x04000C70 RID: 3184
		private readonly TImpl _e0;

		// Token: 0x04000C71 RID: 3185
		private readonly TImpl _e1;

		// Token: 0x04000C72 RID: 3186
		private readonly TImpl _e2;
	}
}
