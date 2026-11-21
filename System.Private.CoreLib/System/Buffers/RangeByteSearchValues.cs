using System;
using System.Runtime.CompilerServices;

namespace System.Buffers
{
	// Token: 0x0200036F RID: 879
	internal sealed class RangeByteSearchValues : SearchValues<byte>
	{
		// Token: 0x06003BA7 RID: 15271 RVA: 0x000C6880 File Offset: 0x000C4A80
		public RangeByteSearchValues(byte lowInclusive, byte highInclusive)
		{
			this._lowInclusive = lowInclusive;
			this._highInclusive = highInclusive;
			this._lowUint = (uint)lowInclusive;
			this._highMinusLow = (uint)(highInclusive - lowInclusive);
		}

		// Token: 0x06003BA8 RID: 15272 RVA: 0x000C68B8 File Offset: 0x000C4AB8
		internal override byte[] GetValues()
		{
			byte[] array = new byte[this._highMinusLow + 1U];
			int lowInclusive = (int)this._lowInclusive;
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = (byte)(lowInclusive + i);
			}
			return array;
		}

		// Token: 0x06003BA9 RID: 15273 RVA: 0x000C68F0 File Offset: 0x000C4AF0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override bool ContainsCore(byte value)
		{
			return (uint)value - this._lowUint <= this._highMinusLow;
		}

		// Token: 0x06003BAA RID: 15274 RVA: 0x000C6905 File Offset: 0x000C4B05
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override int IndexOfAny(ReadOnlySpan<byte> span)
		{
			return span.IndexOfAnyInRange(this._lowInclusive, this._highInclusive);
		}

		// Token: 0x06003BAB RID: 15275 RVA: 0x000C6919 File Offset: 0x000C4B19
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override int IndexOfAnyExcept(ReadOnlySpan<byte> span)
		{
			return span.IndexOfAnyExceptInRange(this._lowInclusive, this._highInclusive);
		}

		// Token: 0x06003BAC RID: 15276 RVA: 0x000C692D File Offset: 0x000C4B2D
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override int LastIndexOfAny(ReadOnlySpan<byte> span)
		{
			return span.LastIndexOfAnyInRange(this._lowInclusive, this._highInclusive);
		}

		// Token: 0x06003BAD RID: 15277 RVA: 0x000C6941 File Offset: 0x000C4B41
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal override int LastIndexOfAnyExcept(ReadOnlySpan<byte> span)
		{
			return span.LastIndexOfAnyExceptInRange(this._lowInclusive, this._highInclusive);
		}

		// Token: 0x04000C8D RID: 3213
		private readonly byte _lowInclusive;

		// Token: 0x04000C8E RID: 3214
		private readonly byte _highInclusive;

		// Token: 0x04000C8F RID: 3215
		private readonly uint _lowUint;

		// Token: 0x04000C90 RID: 3216
		private readonly uint _highMinusLow;
	}
}
