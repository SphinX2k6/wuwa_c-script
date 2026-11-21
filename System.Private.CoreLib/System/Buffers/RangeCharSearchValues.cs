using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Buffers
{
	// Token: 0x02000370 RID: 880
	internal sealed class RangeCharSearchValues<TShouldUsePacked> : SearchValues<char> where TShouldUsePacked : struct, SearchValues.IRuntimeConst
	{
		// Token: 0x06003BAE RID: 15278 RVA: 0x000C6958 File Offset: 0x000C4B58
		public RangeCharSearchValues(char lowInclusive, char highInclusive)
		{
			char rangeInclusive = highInclusive - lowInclusive;
			this._lowInclusive = lowInclusive;
			this._rangeInclusive = rangeInclusive;
			this._highInclusive = highInclusive;
			this._lowUint = (uint)lowInclusive;
			this._highMinusLow = (uint)(highInclusive - lowInclusive);
		}

		// Token: 0x06003BAF RID: 15279 RVA: 0x000C699C File Offset: 0x000C4B9C
		internal override char[] GetValues()
		{
			char[] array = new char[(int)(this._rangeInclusive + '\u0001')];
			int lowInclusive = (int)this._lowInclusive;
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = (char)(lowInclusive + i);
			}
			return array;
		}

		// Token: 0x06003BB0 RID: 15280 RVA: 0x000C69D4 File Offset: 0x000C4BD4
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override bool ContainsCore(char value)
		{
			return (uint)value - this._lowUint <= this._highMinusLow;
		}

		// Token: 0x06003BB1 RID: 15281 RVA: 0x000C69EC File Offset: 0x000C4BEC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal unsafe override int IndexOfAny(ReadOnlySpan<char> span)
		{
			if (!PackedSpanHelpers.PackedIndexOfIsSupported || !SearchValues.IRuntimeConst.Value)
			{
				return SpanHelpers.NonPackedIndexOfAnyInRangeUnsignedNumber<ushort, SpanHelpers.DontNegate<ushort>>(Unsafe.As<char, ushort>(MemoryMarshal.GetReference<char>(span)), *Unsafe.As<char, ushort>(ref this._lowInclusive), *Unsafe.As<char, ushort>(ref this._highInclusive), span.Length);
			}
			return PackedSpanHelpers.IndexOfAnyInRange(MemoryMarshal.GetReference<char>(span), this._lowInclusive, this._rangeInclusive, span.Length);
		}

		// Token: 0x06003BB2 RID: 15282 RVA: 0x000C6A5C File Offset: 0x000C4C5C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal unsafe override int IndexOfAnyExcept(ReadOnlySpan<char> span)
		{
			if (!PackedSpanHelpers.PackedIndexOfIsSupported || !SearchValues.IRuntimeConst.Value)
			{
				return SpanHelpers.NonPackedIndexOfAnyInRangeUnsignedNumber<ushort, SpanHelpers.Negate<ushort>>(Unsafe.As<char, ushort>(MemoryMarshal.GetReference<char>(span)), *Unsafe.As<char, ushort>(ref this._lowInclusive), *Unsafe.As<char, ushort>(ref this._highInclusive), span.Length);
			}
			return PackedSpanHelpers.IndexOfAnyExceptInRange(MemoryMarshal.GetReference<char>(span), this._lowInclusive, this._rangeInclusive, span.Length);
		}

		// Token: 0x06003BB3 RID: 15283 RVA: 0x000C6ACB File Offset: 0x000C4CCB
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override int LastIndexOfAny(ReadOnlySpan<char> span)
		{
			return span.LastIndexOfAnyInRange(this._lowInclusive, this._highInclusive);
		}

		// Token: 0x06003BB4 RID: 15284 RVA: 0x000C6ADF File Offset: 0x000C4CDF
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override int LastIndexOfAnyExcept(ReadOnlySpan<char> span)
		{
			return span.LastIndexOfAnyExceptInRange(this._lowInclusive, this._highInclusive);
		}

		// Token: 0x04000C91 RID: 3217
		private readonly char _rangeInclusive;

		// Token: 0x04000C92 RID: 3218
		private char _lowInclusive;

		// Token: 0x04000C93 RID: 3219
		private char _highInclusive;

		// Token: 0x04000C94 RID: 3220
		private readonly uint _lowUint;

		// Token: 0x04000C95 RID: 3221
		private readonly uint _highMinusLow;
	}
}
