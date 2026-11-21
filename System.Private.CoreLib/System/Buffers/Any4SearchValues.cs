using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Buffers
{
	// Token: 0x0200035E RID: 862
	internal sealed class Any4SearchValues<T, TImpl> : SearchValues<T> where T : struct, IEquatable<T> where TImpl : struct, INumber<TImpl>
	{
		// Token: 0x06003B39 RID: 15161 RVA: 0x000C52B0 File Offset: 0x000C34B0
		public unsafe Any4SearchValues(ReadOnlySpan<TImpl> values)
		{
			TImpl e = *values[0];
			TImpl e2 = *values[1];
			TImpl e3 = *values[2];
			TImpl e4 = *values[3];
			this._e0 = e;
			this._e1 = e2;
			this._e2 = e3;
			this._e3 = e4;
		}

		// Token: 0x06003B3A RID: 15162 RVA: 0x000C5318 File Offset: 0x000C3518
		internal unsafe override T[] GetValues()
		{
			TImpl e = this._e0;
			TImpl e2 = this._e1;
			TImpl e3 = this._e2;
			TImpl e4 = this._e3;
			return new T[]
			{
				*(T*)(&e),
				*(T*)(&e2),
				*(T*)(&e3),
				*(T*)(&e4)
			};
		}

		// Token: 0x06003B3B RID: 15163 RVA: 0x000C5384 File Offset: 0x000C3584
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal unsafe override bool ContainsCore(T value)
		{
			return *(TImpl*)(&value) == this._e0 || *(TImpl*)(&value) == this._e1 || *(TImpl*)(&value) == this._e2 || *(TImpl*)(&value) == this._e3;
		}

		// Token: 0x06003B3C RID: 15164 RVA: 0x000C53FD File Offset: 0x000C35FD
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override int IndexOfAny(ReadOnlySpan<T> span)
		{
			return SpanHelpers.IndexOfAnyValueType<TImpl>(Unsafe.As<T, TImpl>(MemoryMarshal.GetReference<T>(span)), this._e0, this._e1, this._e2, this._e3, span.Length);
		}

		// Token: 0x06003B3D RID: 15165 RVA: 0x000C542E File Offset: 0x000C362E
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override int IndexOfAnyExcept(ReadOnlySpan<T> span)
		{
			return SpanHelpers.IndexOfAnyExceptValueType<TImpl>(Unsafe.As<T, TImpl>(MemoryMarshal.GetReference<T>(span)), this._e0, this._e1, this._e2, this._e3, span.Length);
		}

		// Token: 0x06003B3E RID: 15166 RVA: 0x000C545F File Offset: 0x000C365F
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override int LastIndexOfAny(ReadOnlySpan<T> span)
		{
			return SpanHelpers.LastIndexOfAnyValueType<TImpl>(Unsafe.As<T, TImpl>(MemoryMarshal.GetReference<T>(span)), this._e0, this._e1, this._e2, this._e3, span.Length);
		}

		// Token: 0x06003B3F RID: 15167 RVA: 0x000C5490 File Offset: 0x000C3690
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override int LastIndexOfAnyExcept(ReadOnlySpan<T> span)
		{
			return SpanHelpers.LastIndexOfAnyExceptValueType<TImpl>(Unsafe.As<T, TImpl>(MemoryMarshal.GetReference<T>(span)), this._e0, this._e1, this._e2, this._e3, span.Length);
		}

		// Token: 0x04000C7C RID: 3196
		private readonly TImpl _e0;

		// Token: 0x04000C7D RID: 3197
		private readonly TImpl _e1;

		// Token: 0x04000C7E RID: 3198
		private readonly TImpl _e2;

		// Token: 0x04000C7F RID: 3199
		private readonly TImpl _e3;
	}
}
