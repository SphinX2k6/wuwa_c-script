using System;
using System.Buffers;
using System.Runtime.InteropServices;

namespace System.Text
{
	// Token: 0x0200021A RID: 538
	internal class DecoderNLS : Decoder
	{
		// Token: 0x06002987 RID: 10631 RVA: 0x00081AEA File Offset: 0x0007FCEA
		internal DecoderNLS(Encoding encoding)
		{
			this._encoding = encoding;
			this._fallback = this._encoding.DecoderFallback;
			this.Reset();
		}

		// Token: 0x06002988 RID: 10632 RVA: 0x00081B10 File Offset: 0x0007FD10
		public override void Reset()
		{
			this.ClearLeftoverData();
			DecoderFallbackBuffer fallbackBuffer = this._fallbackBuffer;
			if (fallbackBuffer == null)
			{
				return;
			}
			fallbackBuffer.Reset();
		}

		// Token: 0x06002989 RID: 10633 RVA: 0x00081B28 File Offset: 0x0007FD28
		public override int GetCharCount(byte[] bytes, int index, int count)
		{
			return this.GetCharCount(bytes, index, count, false);
		}

		// Token: 0x0600298A RID: 10634 RVA: 0x00081B34 File Offset: 0x0007FD34
		public unsafe override int GetCharCount(byte[] bytes, int index, int count, bool flush)
		{
			ArgumentNullException.ThrowIfNull(bytes, "bytes");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(index, "index");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(count, "count");
			if (bytes.Length - index < count)
			{
				throw new ArgumentOutOfRangeException("bytes", SR.ArgumentOutOfRange_IndexCountBuffer);
			}
			fixed (byte* arrayDataReference = MemoryMarshal.GetArrayDataReference<byte>(bytes))
			{
				byte* ptr = arrayDataReference;
				return this.GetCharCount(ptr + index, count, flush);
			}
		}

		// Token: 0x0600298B RID: 10635 RVA: 0x00081B90 File Offset: 0x0007FD90
		public unsafe override int GetCharCount(byte* bytes, int count, bool flush)
		{
			ArgumentNullException.ThrowIfNull((void*)bytes, "bytes");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(count, "count");
			this._mustFlush = flush;
			this._throwOnOverflow = true;
			return this._encoding.GetCharCount(bytes, count, this);
		}

		// Token: 0x0600298C RID: 10636 RVA: 0x00081BC4 File Offset: 0x0007FDC4
		public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex)
		{
			return this.GetChars(bytes, byteIndex, byteCount, chars, charIndex, false);
		}

		// Token: 0x0600298D RID: 10637 RVA: 0x00081BD4 File Offset: 0x0007FDD4
		public unsafe override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool flush)
		{
			ArgumentNullException.ThrowIfNull(bytes, "bytes");
			ArgumentNullException.ThrowIfNull(chars, "chars");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(byteIndex, "byteIndex");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(byteCount, "byteCount");
			if (bytes.Length - byteIndex < byteCount)
			{
				throw new ArgumentOutOfRangeException("bytes", SR.ArgumentOutOfRange_IndexCountBuffer);
			}
			if (charIndex < 0 || charIndex > chars.Length)
			{
				throw new ArgumentOutOfRangeException("charIndex", SR.ArgumentOutOfRange_IndexMustBeLessOrEqual);
			}
			int charCount = chars.Length - charIndex;
			fixed (byte* arrayDataReference = MemoryMarshal.GetArrayDataReference<byte>(bytes))
			{
				byte* ptr = arrayDataReference;
				fixed (char* arrayDataReference2 = MemoryMarshal.GetArrayDataReference<char>(chars))
				{
					char* ptr2 = arrayDataReference2;
					return this.GetChars(ptr + byteIndex, byteCount, ptr2 + charIndex, charCount, flush);
				}
			}
		}

		// Token: 0x0600298E RID: 10638 RVA: 0x00081C78 File Offset: 0x0007FE78
		public unsafe override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, bool flush)
		{
			ArgumentNullException.ThrowIfNull((void*)bytes, "bytes");
			ArgumentNullException.ThrowIfNull((void*)chars, "chars");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(byteCount, "byteCount");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(charCount, "charCount");
			this._mustFlush = flush;
			this._throwOnOverflow = true;
			return this._encoding.GetChars(bytes, byteCount, chars, charCount, this);
		}

		// Token: 0x0600298F RID: 10639 RVA: 0x00081CD4 File Offset: 0x0007FED4
		public unsafe override void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed)
		{
			ArgumentNullException.ThrowIfNull(bytes, "bytes");
			ArgumentNullException.ThrowIfNull(chars, "chars");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(byteIndex, "byteIndex");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(byteCount, "byteCount");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(charIndex, "charIndex");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(charCount, "charCount");
			if (bytes.Length - byteIndex < byteCount)
			{
				throw new ArgumentOutOfRangeException("bytes", SR.ArgumentOutOfRange_IndexCountBuffer);
			}
			if (chars.Length - charIndex < charCount)
			{
				throw new ArgumentOutOfRangeException("chars", SR.ArgumentOutOfRange_IndexCountBuffer);
			}
			fixed (byte* arrayDataReference = MemoryMarshal.GetArrayDataReference<byte>(bytes))
			{
				byte* ptr = arrayDataReference;
				fixed (char* arrayDataReference2 = MemoryMarshal.GetArrayDataReference<char>(chars))
				{
					char* ptr2 = arrayDataReference2;
					this.Convert(ptr + byteIndex, byteCount, ptr2 + charIndex, charCount, flush, out bytesUsed, out charsUsed, out completed);
				}
			}
		}

		// Token: 0x06002990 RID: 10640 RVA: 0x00081D90 File Offset: 0x0007FF90
		public unsafe override void Convert(byte* bytes, int byteCount, char* chars, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed)
		{
			ArgumentNullException.ThrowIfNull((void*)bytes, "bytes");
			ArgumentNullException.ThrowIfNull((void*)chars, "chars");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(byteCount, "byteCount");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(charCount, "charCount");
			this._mustFlush = flush;
			this._throwOnOverflow = false;
			this._bytesUsed = 0;
			charsUsed = this._encoding.GetChars(bytes, byteCount, chars, charCount, this);
			bytesUsed = this._bytesUsed;
			completed = (bytesUsed == byteCount && (!flush || !this.HasState) && (this._fallbackBuffer == null || this._fallbackBuffer.Remaining == 0));
		}

		// Token: 0x17000843 RID: 2115
		// (get) Token: 0x06002991 RID: 10641 RVA: 0x00081E2E File Offset: 0x0008002E
		public bool MustFlush
		{
			get
			{
				return this._mustFlush;
			}
		}

		// Token: 0x17000844 RID: 2116
		// (get) Token: 0x06002992 RID: 10642 RVA: 0x00081E36 File Offset: 0x00080036
		internal virtual bool HasState
		{
			get
			{
				return this._leftoverByteCount != 0;
			}
		}

		// Token: 0x06002993 RID: 10643 RVA: 0x00081E41 File Offset: 0x00080041
		internal void ClearMustFlush()
		{
			this._mustFlush = false;
		}

		// Token: 0x06002994 RID: 10644 RVA: 0x00081E4C File Offset: 0x0008004C
		internal ReadOnlySpan<byte> GetLeftoverData()
		{
			return MemoryMarshal.AsBytes<int>(new ReadOnlySpan<int>(ref this._leftoverBytes)).Slice(0, this._leftoverByteCount);
		}

		// Token: 0x06002995 RID: 10645 RVA: 0x00081E78 File Offset: 0x00080078
		internal void SetLeftoverData(ReadOnlySpan<byte> bytes)
		{
			bytes.CopyTo(MemoryMarshal.AsBytes<int>(new Span<int>(ref this._leftoverBytes)));
			this._leftoverByteCount = bytes.Length;
		}

		// Token: 0x17000845 RID: 2117
		// (get) Token: 0x06002996 RID: 10646 RVA: 0x00081E36 File Offset: 0x00080036
		internal bool HasLeftoverData
		{
			get
			{
				return this._leftoverByteCount != 0;
			}
		}

		// Token: 0x06002997 RID: 10647 RVA: 0x00081E9E File Offset: 0x0008009E
		internal void ClearLeftoverData()
		{
			this._leftoverByteCount = 0;
		}

		// Token: 0x06002998 RID: 10648 RVA: 0x00081EA8 File Offset: 0x000800A8
		internal unsafe int DrainLeftoverDataForGetCharCount(ReadOnlySpan<byte> bytes, out int bytesConsumed)
		{
			Span<byte> span = new Span<byte>(stackalloc byte[(UIntPtr)4], 4);
			span = span.Slice(0, DecoderNLS.ConcatInto(this.GetLeftoverData(), bytes, span));
			int result = 0;
			Rune rune;
			int num;
			switch (this._encoding.DecodeFirstRune(span, out rune, out num))
			{
			case OperationStatus.Done:
				result = rune.Utf16SequenceLength;
				goto IL_97;
			case OperationStatus.NeedMoreData:
				if (!this.MustFlush)
				{
					goto IL_97;
				}
				break;
			}
			if (base.FallbackBuffer.Fallback(span.Slice(0, num).ToArray(), -this._leftoverByteCount))
			{
				result = this._fallbackBuffer.DrainRemainingDataForGetCharCount();
			}
			IL_97:
			bytesConsumed = num - this._leftoverByteCount;
			return result;
		}

		// Token: 0x06002999 RID: 10649 RVA: 0x00081F58 File Offset: 0x00080158
		internal unsafe int DrainLeftoverDataForGetChars(ReadOnlySpan<byte> bytes, Span<char> chars, out int bytesConsumed)
		{
			Span<byte> span = new Span<byte>(stackalloc byte[(UIntPtr)4], 4);
			span = span.Slice(0, DecoderNLS.ConcatInto(this.GetLeftoverData(), bytes, span));
			int result = 0;
			bool flag = false;
			Rune rune;
			int num;
			switch (this._encoding.DecodeFirstRune(span, out rune, out num))
			{
			case OperationStatus.Done:
				if (rune.TryEncodeToUtf16(chars, out result))
				{
					goto IL_A6;
				}
				goto IL_CA;
			case OperationStatus.NeedMoreData:
				if (!this.MustFlush)
				{
					flag = true;
					goto IL_A6;
				}
				break;
			}
			if (base.FallbackBuffer.Fallback(span.Slice(0, num).ToArray(), -this._leftoverByteCount) && !this._fallbackBuffer.TryDrainRemainingDataForGetChars(chars, out result))
			{
				goto IL_CA;
			}
			IL_A6:
			bytesConsumed = num - this._leftoverByteCount;
			if (flag)
			{
				this.SetLeftoverData(span);
			}
			else
			{
				this.ClearLeftoverData();
			}
			return result;
			IL_CA:
			this._encoding.ThrowCharsOverflow(this, true);
			throw null;
		}

		// Token: 0x0600299A RID: 10650 RVA: 0x00082040 File Offset: 0x00080240
		private unsafe static int ConcatInto(ReadOnlySpan<byte> srcLeft, ReadOnlySpan<byte> srcRight, Span<byte> dest)
		{
			int num = 0;
			for (int i = 0; i < srcLeft.Length; i++)
			{
				if (num >= dest.Length)
				{
					return num;
				}
				*dest[num++] = *srcLeft[i];
			}
			int num2 = 0;
			while (num2 < srcRight.Length && num < dest.Length)
			{
				*dest[num++] = *srcRight[num2];
				num2++;
			}
			return num;
		}

		// Token: 0x0400073F RID: 1855
		private readonly Encoding _encoding;

		// Token: 0x04000740 RID: 1856
		private bool _mustFlush;

		// Token: 0x04000741 RID: 1857
		internal bool _throwOnOverflow;

		// Token: 0x04000742 RID: 1858
		internal int _bytesUsed;

		// Token: 0x04000743 RID: 1859
		private int _leftoverBytes;

		// Token: 0x04000744 RID: 1860
		private int _leftoverByteCount;
	}
}
