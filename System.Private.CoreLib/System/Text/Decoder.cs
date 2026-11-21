using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Text
{
	// Token: 0x02000214 RID: 532
	public abstract class Decoder
	{
		// Token: 0x17000838 RID: 2104
		// (get) Token: 0x0600294E RID: 10574 RVA: 0x0008122B File Offset: 0x0007F42B
		// (set) Token: 0x0600294F RID: 10575 RVA: 0x00081234 File Offset: 0x0007F434
		[Nullable(2)]
		public DecoderFallback Fallback
		{
			[NullableContext(2)]
			get
			{
				return this._fallback;
			}
			[NullableContext(2)]
			set
			{
				ArgumentNullException.ThrowIfNull(value, "value");
				if (this._fallbackBuffer != null && this._fallbackBuffer.Remaining > 0)
				{
					throw new ArgumentException(SR.Argument_FallbackBufferNotEmpty, "value");
				}
				this._fallback = value;
				this._fallbackBuffer = null;
			}
		}

		// Token: 0x17000839 RID: 2105
		// (get) Token: 0x06002950 RID: 10576 RVA: 0x00081280 File Offset: 0x0007F480
		[Nullable(1)]
		public DecoderFallbackBuffer FallbackBuffer
		{
			[NullableContext(1)]
			get
			{
				if (this._fallbackBuffer == null)
				{
					this._fallbackBuffer = ((this._fallback != null) ? this._fallback.CreateFallbackBuffer() : DecoderFallback.ReplacementFallback.CreateFallbackBuffer());
				}
				return this._fallbackBuffer;
			}
		}

		// Token: 0x1700083A RID: 2106
		// (get) Token: 0x06002951 RID: 10577 RVA: 0x000812B5 File Offset: 0x0007F4B5
		internal bool InternalHasFallbackBuffer
		{
			get
			{
				return this._fallbackBuffer != null;
			}
		}

		// Token: 0x06002952 RID: 10578 RVA: 0x000812C4 File Offset: 0x0007F4C4
		public virtual void Reset()
		{
			byte[] bytes = Array.Empty<byte>();
			char[] chars = new char[this.GetCharCount(bytes, 0, 0, true)];
			this.GetChars(bytes, 0, 0, chars, 0, true);
			DecoderFallbackBuffer fallbackBuffer = this._fallbackBuffer;
			if (fallbackBuffer == null)
			{
				return;
			}
			fallbackBuffer.Reset();
		}

		// Token: 0x06002953 RID: 10579
		[NullableContext(1)]
		public abstract int GetCharCount(byte[] bytes, int index, int count);

		// Token: 0x06002954 RID: 10580 RVA: 0x00081304 File Offset: 0x0007F504
		[NullableContext(1)]
		public virtual int GetCharCount(byte[] bytes, int index, int count, bool flush)
		{
			return this.GetCharCount(bytes, index, count);
		}

		// Token: 0x06002955 RID: 10581 RVA: 0x00081310 File Offset: 0x0007F510
		[CLSCompliant(false)]
		public unsafe virtual int GetCharCount(byte* bytes, int count, bool flush)
		{
			ArgumentNullException.ThrowIfNull((void*)bytes, "bytes");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(count, "count");
			byte[] array = new byte[count];
			for (int i = 0; i < count; i++)
			{
				array[i] = bytes[i];
			}
			return this.GetCharCount(array, 0, count);
		}

		// Token: 0x06002956 RID: 10582 RVA: 0x00081358 File Offset: 0x0007F558
		public unsafe virtual int GetCharCount(ReadOnlySpan<byte> bytes, bool flush)
		{
			fixed (byte* nonNullPinnableReference = MemoryMarshal.GetNonNullPinnableReference<byte>(bytes))
			{
				byte* bytes2 = nonNullPinnableReference;
				return this.GetCharCount(bytes2, bytes.Length, flush);
			}
		}

		// Token: 0x06002957 RID: 10583
		[NullableContext(1)]
		public abstract int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);

		// Token: 0x06002958 RID: 10584 RVA: 0x0008137E File Offset: 0x0007F57E
		[NullableContext(1)]
		public virtual int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool flush)
		{
			return this.GetChars(bytes, byteIndex, byteCount, chars, charIndex);
		}

		// Token: 0x06002959 RID: 10585 RVA: 0x00081390 File Offset: 0x0007F590
		[CLSCompliant(false)]
		public unsafe virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount, bool flush)
		{
			ArgumentNullException.ThrowIfNull((void*)bytes, "bytes");
			ArgumentNullException.ThrowIfNull((void*)chars, "chars");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(byteCount, "byteCount");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(charCount, "charCount");
			byte[] array = new byte[byteCount];
			for (int i = 0; i < byteCount; i++)
			{
				array[i] = bytes[i];
			}
			char[] array2 = new char[charCount];
			int chars2 = this.GetChars(array, 0, byteCount, array2, 0, flush);
			if (chars2 < charCount)
			{
				charCount = chars2;
			}
			for (int j = 0; j < charCount; j++)
			{
				chars[j] = array2[j];
			}
			return charCount;
		}

		// Token: 0x0600295A RID: 10586 RVA: 0x00081424 File Offset: 0x0007F624
		public unsafe virtual int GetChars(ReadOnlySpan<byte> bytes, Span<char> chars, bool flush)
		{
			fixed (byte* nonNullPinnableReference = MemoryMarshal.GetNonNullPinnableReference<byte>(bytes))
			{
				byte* bytes2 = nonNullPinnableReference;
				fixed (char* nonNullPinnableReference2 = MemoryMarshal.GetNonNullPinnableReference<char>(chars))
				{
					char* chars2 = nonNullPinnableReference2;
					return this.GetChars(bytes2, bytes.Length, chars2, chars.Length, flush);
				}
			}
		}

		// Token: 0x0600295B RID: 10587 RVA: 0x0008145C File Offset: 0x0007F65C
		[NullableContext(1)]
		public virtual void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed)
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
			for (bytesUsed = byteCount; bytesUsed > 0; bytesUsed /= 2)
			{
				if (this.GetCharCount(bytes, byteIndex, bytesUsed, flush) <= charCount)
				{
					charsUsed = this.GetChars(bytes, byteIndex, bytesUsed, chars, charIndex, flush);
					completed = (bytesUsed == byteCount && (this._fallbackBuffer == null || this._fallbackBuffer.Remaining == 0));
					return;
				}
				flush = false;
			}
			throw new ArgumentException(SR.Argument_ConversionOverflow);
		}

		// Token: 0x0600295C RID: 10588 RVA: 0x00081550 File Offset: 0x0007F750
		[CLSCompliant(false)]
		public unsafe virtual void Convert(byte* bytes, int byteCount, char* chars, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed)
		{
			ArgumentNullException.ThrowIfNull((void*)bytes, "bytes");
			ArgumentNullException.ThrowIfNull((void*)chars, "chars");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(byteCount, "byteCount");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(charCount, "charCount");
			for (bytesUsed = byteCount; bytesUsed > 0; bytesUsed /= 2)
			{
				if (this.GetCharCount(bytes, bytesUsed, flush) <= charCount)
				{
					charsUsed = this.GetChars(bytes, bytesUsed, chars, charCount, flush);
					completed = (bytesUsed == byteCount && (this._fallbackBuffer == null || this._fallbackBuffer.Remaining == 0));
					return;
				}
				flush = false;
			}
			throw new ArgumentException(SR.Argument_ConversionOverflow);
		}

		// Token: 0x0600295D RID: 10589 RVA: 0x000815F4 File Offset: 0x0007F7F4
		public unsafe virtual void Convert(ReadOnlySpan<byte> bytes, Span<char> chars, bool flush, out int bytesUsed, out int charsUsed, out bool completed)
		{
			fixed (byte* nonNullPinnableReference = MemoryMarshal.GetNonNullPinnableReference<byte>(bytes))
			{
				byte* bytes2 = nonNullPinnableReference;
				fixed (char* nonNullPinnableReference2 = MemoryMarshal.GetNonNullPinnableReference<char>(chars))
				{
					char* chars2 = nonNullPinnableReference2;
					this.Convert(bytes2, bytes.Length, chars2, chars.Length, flush, out bytesUsed, out charsUsed, out completed);
				}
			}
		}

		// Token: 0x04000735 RID: 1845
		internal DecoderFallback _fallback;

		// Token: 0x04000736 RID: 1846
		internal DecoderFallbackBuffer _fallbackBuffer;
	}
}
