using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Text
{
	// Token: 0x0200021D RID: 541
	public abstract class Encoder
	{
		// Token: 0x17000849 RID: 2121
		// (get) Token: 0x060029AB RID: 10667 RVA: 0x000822C2 File Offset: 0x000804C2
		// (set) Token: 0x060029AC RID: 10668 RVA: 0x000822CC File Offset: 0x000804CC
		[Nullable(2)]
		public EncoderFallback Fallback
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

		// Token: 0x1700084A RID: 2122
		// (get) Token: 0x060029AD RID: 10669 RVA: 0x00082318 File Offset: 0x00080518
		[Nullable(1)]
		public EncoderFallbackBuffer FallbackBuffer
		{
			[NullableContext(1)]
			get
			{
				if (this._fallbackBuffer == null)
				{
					this._fallbackBuffer = ((this._fallback != null) ? this._fallback.CreateFallbackBuffer() : EncoderFallback.ReplacementFallback.CreateFallbackBuffer());
				}
				return this._fallbackBuffer;
			}
		}

		// Token: 0x1700084B RID: 2123
		// (get) Token: 0x060029AE RID: 10670 RVA: 0x0008234D File Offset: 0x0008054D
		internal bool InternalHasFallbackBuffer
		{
			get
			{
				return this._fallbackBuffer != null;
			}
		}

		// Token: 0x060029AF RID: 10671 RVA: 0x0008235C File Offset: 0x0008055C
		public virtual void Reset()
		{
			char[] chars = Array.Empty<char>();
			byte[] bytes = new byte[this.GetByteCount(chars, 0, 0, true)];
			this.GetBytes(chars, 0, 0, bytes, 0, true);
			EncoderFallbackBuffer fallbackBuffer = this._fallbackBuffer;
			if (fallbackBuffer == null)
			{
				return;
			}
			fallbackBuffer.Reset();
		}

		// Token: 0x060029B0 RID: 10672
		[NullableContext(1)]
		public abstract int GetByteCount(char[] chars, int index, int count, bool flush);

		// Token: 0x060029B1 RID: 10673 RVA: 0x0008239C File Offset: 0x0008059C
		[CLSCompliant(false)]
		public unsafe virtual int GetByteCount(char* chars, int count, bool flush)
		{
			ArgumentNullException.ThrowIfNull((void*)chars, "chars");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(count, "count");
			char[] array = new char[count];
			for (int i = 0; i < count; i++)
			{
				array[i] = chars[i];
			}
			return this.GetByteCount(array, 0, count, flush);
		}

		// Token: 0x060029B2 RID: 10674 RVA: 0x000823E8 File Offset: 0x000805E8
		public unsafe virtual int GetByteCount(ReadOnlySpan<char> chars, bool flush)
		{
			fixed (char* nonNullPinnableReference = MemoryMarshal.GetNonNullPinnableReference<char>(chars))
			{
				char* chars2 = nonNullPinnableReference;
				return this.GetByteCount(chars2, chars.Length, flush);
			}
		}

		// Token: 0x060029B3 RID: 10675
		[NullableContext(1)]
		public abstract int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, bool flush);

		// Token: 0x060029B4 RID: 10676 RVA: 0x00082410 File Offset: 0x00080610
		[CLSCompliant(false)]
		public unsafe virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, bool flush)
		{
			ArgumentNullException.ThrowIfNull((void*)chars, "chars");
			ArgumentNullException.ThrowIfNull((void*)bytes, "bytes");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(charCount, "charCount");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(byteCount, "byteCount");
			char[] array = new char[charCount];
			for (int i = 0; i < charCount; i++)
			{
				array[i] = chars[i];
			}
			byte[] array2 = new byte[byteCount];
			int bytes2 = this.GetBytes(array, 0, charCount, array2, 0, flush);
			if (bytes2 < byteCount)
			{
				byteCount = bytes2;
			}
			for (int j = 0; j < byteCount; j++)
			{
				bytes[j] = array2[j];
			}
			return byteCount;
		}

		// Token: 0x060029B5 RID: 10677 RVA: 0x000824A4 File Offset: 0x000806A4
		public unsafe virtual int GetBytes(ReadOnlySpan<char> chars, Span<byte> bytes, bool flush)
		{
			fixed (char* nonNullPinnableReference = MemoryMarshal.GetNonNullPinnableReference<char>(chars))
			{
				char* chars2 = nonNullPinnableReference;
				fixed (byte* nonNullPinnableReference2 = MemoryMarshal.GetNonNullPinnableReference<byte>(bytes))
				{
					byte* bytes2 = nonNullPinnableReference2;
					return this.GetBytes(chars2, chars.Length, bytes2, bytes.Length, flush);
				}
			}
		}

		// Token: 0x060029B6 RID: 10678 RVA: 0x000824DC File Offset: 0x000806DC
		[NullableContext(1)]
		public virtual void Convert(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed)
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
			for (charsUsed = charCount; charsUsed > 0; charsUsed /= 2)
			{
				if (this.GetByteCount(chars, charIndex, charsUsed, flush) <= byteCount)
				{
					bytesUsed = this.GetBytes(chars, charIndex, charsUsed, bytes, byteIndex, flush);
					completed = (charsUsed == charCount && (this._fallbackBuffer == null || this._fallbackBuffer.Remaining == 0));
					return;
				}
				flush = false;
			}
			throw new ArgumentException(SR.Argument_ConversionOverflow);
		}

		// Token: 0x060029B7 RID: 10679 RVA: 0x000825D0 File Offset: 0x000807D0
		[CLSCompliant(false)]
		public unsafe virtual void Convert(char* chars, int charCount, byte* bytes, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed)
		{
			ArgumentNullException.ThrowIfNull((void*)chars, "chars");
			ArgumentNullException.ThrowIfNull((void*)bytes, "bytes");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(charCount, "charCount");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(byteCount, "byteCount");
			for (charsUsed = charCount; charsUsed > 0; charsUsed /= 2)
			{
				if (this.GetByteCount(chars, charsUsed, flush) <= byteCount)
				{
					bytesUsed = this.GetBytes(chars, charsUsed, bytes, byteCount, flush);
					completed = (charsUsed == charCount && (this._fallbackBuffer == null || this._fallbackBuffer.Remaining == 0));
					return;
				}
				flush = false;
			}
			throw new ArgumentException(SR.Argument_ConversionOverflow);
		}

		// Token: 0x060029B8 RID: 10680 RVA: 0x00082674 File Offset: 0x00080874
		public unsafe virtual void Convert(ReadOnlySpan<char> chars, Span<byte> bytes, bool flush, out int charsUsed, out int bytesUsed, out bool completed)
		{
			fixed (char* nonNullPinnableReference = MemoryMarshal.GetNonNullPinnableReference<char>(chars))
			{
				char* chars2 = nonNullPinnableReference;
				fixed (byte* nonNullPinnableReference2 = MemoryMarshal.GetNonNullPinnableReference<byte>(bytes))
				{
					byte* bytes2 = nonNullPinnableReference2;
					this.Convert(chars2, chars.Length, bytes2, bytes.Length, flush, out charsUsed, out bytesUsed, out completed);
				}
			}
		}

		// Token: 0x0400074A RID: 1866
		internal EncoderFallback _fallback;

		// Token: 0x0400074B RID: 1867
		internal EncoderFallbackBuffer _fallbackBuffer;
	}
}
