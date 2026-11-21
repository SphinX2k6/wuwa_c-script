using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Buffers
{
	// Token: 0x0200035F RID: 863
	internal sealed class Any5SearchValues<T, TImpl> : SearchValues<T> where T : struct, IEquatable<T> where TImpl : struct, INumber<TImpl>
	{
		// Token: 0x06003B40 RID: 15168 RVA: 0x000C54C4 File Offset: 0x000C36C4
		public unsafe Any5SearchValues(ReadOnlySpan<TImpl> values)
		{
			TImpl e = *values[0];
			TImpl e2 = *values[1];
			TImpl e3 = *values[2];
			TImpl e4 = *values[3];
			TImpl e5 = *values[4];
			this._e0 = e;
			this._e1 = e2;
			this._e2 = e3;
			this._e3 = e4;
			this._e4 = e5;
		}

		// Token: 0x06003B41 RID: 15169 RVA: 0x000C5544 File Offset: 0x000C3744
		internal unsafe override T[] GetValues()
		{
			TImpl e = this._e0;
			TImpl e2 = this._e1;
			TImpl e3 = this._e2;
			TImpl e4 = this._e3;
			TImpl e5 = this._e4;
			return new T[]
			{
				*(T*)(&e),
				*(T*)(&e2),
				*(T*)(&e3),
				*(T*)(&e4),
				*(T*)(&e5)
			};
		}

		// Token: 0x06003B42 RID: 15170 RVA: 0x000C55C8 File Offset: 0x000C37C8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal unsafe override bool ContainsCore(T value)
		{
			return *(TImpl*)(&value) == this._e0 || *(TImpl*)(&value) == this._e1 || *(TImpl*)(&value) == this._e2 || *(TImpl*)(&value) == this._e3 || *(TImpl*)(&value) == this._e4;
		}

		// Token: 0x06003B43 RID: 15171 RVA: 0x000C565C File Offset: 0x000C385C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override int IndexOfAny(ReadOnlySpan<T> span)
		{
			return SpanHelpers.IndexOfAnyValueType<TImpl>(Unsafe.As<T, TImpl>(MemoryMarshal.GetReference<T>(span)), this._e0, this._e1, this._e2, this._e3, this._e4, span.Length);
		}

		// Token: 0x06003B44 RID: 15172 RVA: 0x000C5693 File Offset: 0x000C3893
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override int IndexOfAnyExcept(ReadOnlySpan<T> span)
		{
			return SpanHelpers.IndexOfAnyExceptValueType<TImpl>(Unsafe.As<T, TImpl>(MemoryMarshal.GetReference<T>(span)), this._e0, this._e1, this._e2, this._e3, this._e4, span.Length);
		}

		// Token: 0x06003B45 RID: 15173 RVA: 0x000C56CA File Offset: 0x000C38CA
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override int LastIndexOfAny(ReadOnlySpan<T> span)
		{
			return SpanHelpers.LastIndexOfAnyValueType<TImpl>(Unsafe.As<T, TImpl>(MemoryMarshal.GetReference<T>(span)), this._e0, this._e1, this._e2, this._e3, this._e4, span.Length);
		}

		// Token: 0x06003B46 RID: 15174 RVA: 0x000C5701 File Offset: 0x000C3901
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override int LastIndexOfAnyExcept(ReadOnlySpan<T> span)
		{
			return SpanHelpers.LastIndexOfAnyExceptValueType<TImpl>(Unsafe.As<T, TImpl>(MemoryMarshal.GetReference<T>(span)), this._e0, this._e1, this._e2, this._e3, this._e4, span.Length);
		}

		// Token: 0x04000C80 RID: 3200
		private readonly TImpl _e0;

		// Token: 0x04000C81 RID: 3201
		private readonly TImpl _e1;

		// Token: 0x04000C82 RID: 3202
		private readonly TImpl _e2;

		// Token: 0x04000C83 RID: 3203
		private readonly TImpl _e3;

		// Token: 0x04000C84 RID: 3204
		private readonly TImpl _e4;
	}
}
