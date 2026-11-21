using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Buffers
{
	// Token: 0x02000357 RID: 855
	internal sealed class Any1SearchValues<T, TImpl> : SearchValues<T> where T : struct, IEquatable<T> where TImpl : struct, INumber<TImpl>
	{
		// Token: 0x06003B07 RID: 15111 RVA: 0x000C4649 File Offset: 0x000C2849
		public unsafe Any1SearchValues(ReadOnlySpan<TImpl> values)
		{
			this._e0 = *values[0];
		}

		// Token: 0x06003B08 RID: 15112 RVA: 0x000C4664 File Offset: 0x000C2864
		internal unsafe override T[] GetValues()
		{
			TImpl e = this._e0;
			return new T[]
			{
				*(T*)(&e)
			};
		}

		// Token: 0x06003B09 RID: 15113 RVA: 0x000C468D File Offset: 0x000C288D
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal unsafe override bool ContainsCore(T value)
		{
			return *(TImpl*)(&value) == this._e0;
		}

		// Token: 0x06003B0A RID: 15114 RVA: 0x000C46A8 File Offset: 0x000C28A8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override int IndexOfAny(ReadOnlySpan<T> span)
		{
			return SpanHelpers.NonPackedIndexOfValueType<TImpl, SpanHelpers.DontNegate<TImpl>>(Unsafe.As<T, TImpl>(MemoryMarshal.GetReference<T>(span)), this._e0, span.Length);
		}

		// Token: 0x06003B0B RID: 15115 RVA: 0x000C46C7 File Offset: 0x000C28C7
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override int IndexOfAnyExcept(ReadOnlySpan<T> span)
		{
			return SpanHelpers.NonPackedIndexOfValueType<TImpl, SpanHelpers.Negate<TImpl>>(Unsafe.As<T, TImpl>(MemoryMarshal.GetReference<T>(span)), this._e0, span.Length);
		}

		// Token: 0x06003B0C RID: 15116 RVA: 0x000C46E6 File Offset: 0x000C28E6
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override int LastIndexOfAny(ReadOnlySpan<T> span)
		{
			return SpanHelpers.LastIndexOfValueType<TImpl>(Unsafe.As<T, TImpl>(MemoryMarshal.GetReference<T>(span)), this._e0, span.Length);
		}

		// Token: 0x06003B0D RID: 15117 RVA: 0x000C4705 File Offset: 0x000C2905
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override int LastIndexOfAnyExcept(ReadOnlySpan<T> span)
		{
			return SpanHelpers.LastIndexOfAnyExceptValueType<TImpl>(Unsafe.As<T, TImpl>(MemoryMarshal.GetReference<T>(span)), this._e0, span.Length);
		}

		// Token: 0x04000C6D RID: 3181
		private readonly TImpl _e0;
	}
}
