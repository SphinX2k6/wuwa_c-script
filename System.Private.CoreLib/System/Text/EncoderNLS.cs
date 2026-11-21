using System;
using System.Buffers;
using System.Runtime.InteropServices;

namespace System.Text
{
	// Token: 0x02000225 RID: 549
	internal class EncoderNLS : Encoder
	{
		// Token: 0x060029F5 RID: 10741 RVA: 0x00082E4F File Offset: 0x0008104F
		internal EncoderNLS(Encoding encoding)
		{
			this._encoding = encoding;
			this._fallback = this._encoding.EncoderFallback;
			this.Reset();
		}

		// Token: 0x060029F6 RID: 10742 RVA: 0x00082E75 File Offset: 0x00081075
		public override void Reset()
		{
			this._charLeftOver = '\0';
			EncoderFallbackBuffer fallbackBuffer = this._fallbackBuffer;
			if (fallbackBuffer == null)
			{
				return;
			}
			fallbackBuffer.Reset();
		}

		// Token: 0x060029F7 RID: 10743 RVA: 0x00082E90 File Offset: 0x00081090
		public unsafe override int GetByteCount(char[] chars, int index, int count, bool flush)
		{
			ArgumentNullException.ThrowIfNull(chars, "chars");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(index, "index");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(count, "count");
			if (chars.Length - index < count)
			{
				throw new ArgumentOutOfRangeException("chars", SR.ArgumentOutOfRange_IndexCountBuffer);
			}
			int byteCount;
			fixed (char* arrayDataReference = MemoryMarshal.GetArrayDataReference<char>(chars))
			{
				char* ptr = arrayDataReference;
				byteCount = this.GetByteCount(ptr + index, count, flush);
			}
			return byteCount;
		}

		// Token: 0x060029F8 RID: 10744 RVA: 0x00082EF2 File Offset: 0x000810F2
		public unsafe override int GetByteCount(char* chars, int count, bool flush)
		{
			ArgumentNullException.ThrowIfNull((void*)chars, "chars");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(count, "count");
			this._mustFlush = flush;
			this._throwOnOverflow = true;
			return this._encoding.GetByteCount(chars, count, this);
		}

		// Token: 0x060029F9 RID: 10745 RVA: 0x00082F28 File Offset: 0x00081128
		public unsafe override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, bool flush)
		{
			ArgumentNullException.ThrowIfNull(chars, "chars");
			ArgumentNullException.ThrowIfNull(bytes, "bytes");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(charIndex, "charIndex");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(charCount, "charCount");
			if (chars.Length - charIndex < charCount)
			{
				throw new ArgumentOutOfRangeException("chars", SR.ArgumentOutOfRange_IndexCountBuffer);
			}
			if (byteIndex < 0 || byteIndex > bytes.Length)
			{
				throw new ArgumentOutOfRangeException("byteIndex", SR.ArgumentOutOfRange_IndexMustBeLessOrEqual);
			}
			int byteCount = bytes.Length - byteIndex;
			fixed (char* arrayDataReference = MemoryMarshal.GetArrayDataReference<char>(chars))
			{
				char* ptr = arrayDataReference;
				fixed (byte* arrayDataReference2 = MemoryMarshal.GetArrayDataReference<byte>(bytes))
				{
					byte* ptr2 = arrayDataReference2;
					return this.GetBytes(ptr + charIndex, charCount, ptr2 + byteIndex, byteCount, flush);
				}
			}
		}

		// Token: 0x060029FA RID: 10746 RVA: 0x00082FCC File Offset: 0x000811CC
		public unsafe override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, bool flush)
		{
			ArgumentNullException.ThrowIfNull((void*)chars, "chars");
			ArgumentNullException.ThrowIfNull((void*)bytes, "bytes");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(byteCount, "byteCount");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(charCount, "charCount");
			this._mustFlush = flush;
			this._throwOnOverflow = true;
			return this._encoding.GetBytes(chars, charCount, bytes, byteCount, this);
		}

		// Token: 0x060029FB RID: 10747 RVA: 0x00083028 File Offset: 0x00081228
		public unsafe override void Convert(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed)
		{
			ArgumentNullException.ThrowIfNull(chars, "chars");
			ArgumentNullException.ThrowIfNull(bytes, "bytes");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(charIndex, "charIndex");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(charCount, "charCount");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(byteIndex, "byteIndex");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(byteCount, "byteCount");
			if (chars.Length - charIndex < charCount)
			{
				throw new ArgumentOutOfRangeException("chars", SR.ArgumentOutOfRange_IndexCountBuffer);
			}
			if (bytes.Length - byteIndex < byteCount)
			{
				throw new ArgumentOutOfRangeException("bytes", SR.ArgumentOutOfRange_IndexCountBuffer);
			}
			fixed (char* arrayDataReference = MemoryMarshal.GetArrayDataReference<char>(chars))
			{
				char* ptr = arrayDataReference;
				fixed (byte* arrayDataReference2 = MemoryMarshal.GetArrayDataReference<byte>(bytes))
				{
					byte* ptr2 = arrayDataReference2;
					this.Convert(ptr + charIndex, charCount, ptr2 + byteIndex, byteCount, flush, out charsUsed, out bytesUsed, out completed);
				}
			}
		}

		// Token: 0x060029FC RID: 10748 RVA: 0x000830E4 File Offset: 0x000812E4
		public unsafe override void Convert(char* chars, int charCount, byte* bytes, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed)
		{
			ArgumentNullException.ThrowIfNull((void*)chars, "chars");
			ArgumentNullException.ThrowIfNull((void*)bytes, "bytes");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(charCount, "charCount");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(byteCount, "byteCount");
			this._mustFlush = flush;
			this._throwOnOverflow = false;
			this._charsUsed = 0;
			bytesUsed = this._encoding.GetBytes(chars, charCount, bytes, byteCount, this);
			charsUsed = this._charsUsed;
			completed = (charsUsed == charCount && (!flush || !this.HasState) && (this._fallbackBuffer == null || this._fallbackBuffer.Remaining == 0));
		}

		// Token: 0x17000859 RID: 2137
		// (get) Token: 0x060029FD RID: 10749 RVA: 0x00083182 File Offset: 0x00081382
		public Encoding Encoding
		{
			get
			{
				return this._encoding;
			}
		}

		// Token: 0x1700085A RID: 2138
		// (get) Token: 0x060029FE RID: 10750 RVA: 0x0008318A File Offset: 0x0008138A
		public bool MustFlush
		{
			get
			{
				return this._mustFlush;
			}
		}

		// Token: 0x1700085B RID: 2139
		// (get) Token: 0x060029FF RID: 10751 RVA: 0x00083192 File Offset: 0x00081392
		internal bool HasLeftoverData
		{
			get
			{
				return this._charLeftOver != '\0' || (this._fallbackBuffer != null && this._fallbackBuffer.Remaining > 0);
			}
		}

		// Token: 0x1700085C RID: 2140
		// (get) Token: 0x06002A00 RID: 10752 RVA: 0x000831B6 File Offset: 0x000813B6
		internal virtual bool HasState
		{
			get
			{
				return this._charLeftOver > '\0';
			}
		}

		// Token: 0x06002A01 RID: 10753 RVA: 0x000831C1 File Offset: 0x000813C1
		internal void ClearMustFlush()
		{
			this._mustFlush = false;
		}

		// Token: 0x06002A02 RID: 10754 RVA: 0x000831CC File Offset: 0x000813CC
		internal unsafe int DrainLeftoverDataForGetByteCount(ReadOnlySpan<char> chars, out int charsConsumed)
		{
			if (this._fallbackBuffer != null && this._fallbackBuffer.Remaining > 0)
			{
				throw new ArgumentException(SR.Format(SR.Argument_EncoderFallbackNotEmpty, this.Encoding.EncodingName, this._fallbackBuffer.GetType()));
			}
			charsConsumed = 0;
			if (this._charLeftOver == '\0')
			{
				return 0;
			}
			char c = '\0';
			if (chars.IsEmpty)
			{
				if (!this.MustFlush)
				{
					return 0;
				}
			}
			else
			{
				c = (char)(*chars[0]);
			}
			Rune value;
			if (Rune.TryCreate(this._charLeftOver, c, out value))
			{
				charsConsumed = 1;
				int result;
				if (this._encoding.TryGetByteCount(value, out result))
				{
					return result;
				}
				base.FallbackBuffer.Fallback(this._charLeftOver, c, -1);
			}
			else
			{
				base.FallbackBuffer.Fallback(this._charLeftOver, -1);
			}
			return this._fallbackBuffer.DrainRemainingDataForGetByteCount();
		}

		// Token: 0x06002A03 RID: 10755 RVA: 0x0008329C File Offset: 0x0008149C
		internal unsafe bool TryDrainLeftoverDataForGetBytes(ReadOnlySpan<char> chars, Span<byte> bytes, out int charsConsumed, out int bytesWritten)
		{
			charsConsumed = 0;
			bytesWritten = 0;
			if (this._charLeftOver != '\0')
			{
				char c = '\0';
				if (chars.IsEmpty)
				{
					if (!this.MustFlush)
					{
						charsConsumed = 0;
						bytesWritten = 0;
						return true;
					}
				}
				else
				{
					c = (char)(*chars[0]);
				}
				char charLeftOver = this._charLeftOver;
				this._charLeftOver = '\0';
				Rune value;
				if (Rune.TryCreate(charLeftOver, c, out value))
				{
					charsConsumed = 1;
					switch (this._encoding.EncodeRune(value, bytes, out bytesWritten))
					{
					case OperationStatus.Done:
						return true;
					case OperationStatus.DestinationTooSmall:
						this._encoding.ThrowBytesOverflow(this, true);
						break;
					case OperationStatus.InvalidData:
						base.FallbackBuffer.Fallback(charLeftOver, c, -1);
						break;
					}
				}
				else
				{
					base.FallbackBuffer.Fallback(charLeftOver, -1);
				}
			}
			return this._fallbackBuffer == null || this._fallbackBuffer.Remaining <= 0 || this._fallbackBuffer.TryDrainRemainingDataForGetBytes(bytes, out bytesWritten);
		}

		// Token: 0x0400075E RID: 1886
		internal char _charLeftOver;

		// Token: 0x0400075F RID: 1887
		private readonly Encoding _encoding;

		// Token: 0x04000760 RID: 1888
		private bool _mustFlush;

		// Token: 0x04000761 RID: 1889
		internal bool _throwOnOverflow;

		// Token: 0x04000762 RID: 1890
		internal int _charsUsed;
	}
}
