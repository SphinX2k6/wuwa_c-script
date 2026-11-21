using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Text
{
	// Token: 0x02000244 RID: 580
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class UTF32Encoding : Encoding
	{
		// Token: 0x06002C4A RID: 11338 RVA: 0x0008CC13 File Offset: 0x0008AE13
		public UTF32Encoding() : this(false, true)
		{
		}

		// Token: 0x06002C4B RID: 11339 RVA: 0x0008CC1D File Offset: 0x0008AE1D
		public UTF32Encoding(bool bigEndian, bool byteOrderMark) : base(bigEndian ? 12001 : 12000)
		{
			this._bigEndian = bigEndian;
			this._emitUTF32ByteOrderMark = byteOrderMark;
		}

		// Token: 0x06002C4C RID: 11340 RVA: 0x0008CC42 File Offset: 0x0008AE42
		public UTF32Encoding(bool bigEndian, bool byteOrderMark, bool throwOnInvalidCharacters) : this(bigEndian, byteOrderMark)
		{
			this._isThrowException = throwOnInvalidCharacters;
			if (this._isThrowException)
			{
				this.SetDefaultFallbacks();
			}
		}

		// Token: 0x06002C4D RID: 11341 RVA: 0x0008CC64 File Offset: 0x0008AE64
		internal sealed override void SetDefaultFallbacks()
		{
			if (this._isThrowException)
			{
				this.encoderFallback = EncoderFallback.ExceptionFallback;
				this.decoderFallback = DecoderFallback.ExceptionFallback;
				return;
			}
			this.encoderFallback = new EncoderReplacementFallback("�");
			this.decoderFallback = new DecoderReplacementFallback("�");
		}

		// Token: 0x06002C4E RID: 11342 RVA: 0x0008CCB0 File Offset: 0x0008AEB0
		public unsafe override int GetByteCount(char[] chars, int index, int count)
		{
			ArgumentNullException.ThrowIfNull(chars, "chars");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(index, "index");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(count, "count");
			if (chars.Length - index < count)
			{
				throw new ArgumentOutOfRangeException("chars", SR.ArgumentOutOfRange_IndexCountBuffer);
			}
			if (count == 0)
			{
				return 0;
			}
			char* ptr;
			if (chars == null || chars.Length == 0)
			{
				ptr = null;
			}
			else
			{
				ptr = &chars[0];
			}
			return this.GetByteCount(ptr + index, count, null);
		}

		// Token: 0x06002C4F RID: 11343 RVA: 0x0008CD24 File Offset: 0x0008AF24
		public unsafe override int GetByteCount(string s)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			char* ptr;
			if (s == null)
			{
				ptr = null;
			}
			else
			{
				fixed (char* pinnableReference = s.GetPinnableReference())
				{
					ptr = pinnableReference;
				}
			}
			char* pChars = ptr;
			return this.GetByteCount(pChars, s.Length, null);
		}

		// Token: 0x06002C50 RID: 11344 RVA: 0x0008B4AE File Offset: 0x000896AE
		[NullableContext(0)]
		[CLSCompliant(false)]
		public unsafe override int GetByteCount(char* chars, int count)
		{
			ArgumentNullException.ThrowIfNull((void*)chars, "chars");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(count, "count");
			return this.GetByteCount(chars, count, null);
		}

		// Token: 0x06002C51 RID: 11345 RVA: 0x0008CD5C File Offset: 0x0008AF5C
		public unsafe override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex)
		{
			ArgumentNullException.ThrowIfNull(s, "s");
			ArgumentNullException.ThrowIfNull(bytes, "bytes");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(charIndex, "charIndex");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(charCount, "charCount");
			if (s.Length - charIndex < charCount)
			{
				throw new ArgumentOutOfRangeException("s", SR.ArgumentOutOfRange_IndexCount);
			}
			if (byteIndex < 0 || byteIndex > bytes.Length)
			{
				throw new ArgumentOutOfRangeException("byteIndex", SR.ArgumentOutOfRange_IndexMustBeLessOrEqual);
			}
			int byteCount = bytes.Length - byteIndex;
			char* ptr;
			if (s == null)
			{
				ptr = null;
			}
			else
			{
				fixed (char* pinnableReference = s.GetPinnableReference())
				{
					ptr = pinnableReference;
				}
			}
			char* ptr2 = ptr;
			fixed (byte* arrayDataReference = MemoryMarshal.GetArrayDataReference<byte>(bytes))
			{
				byte* ptr3 = arrayDataReference;
				return this.GetBytes(ptr2 + charIndex, charCount, ptr3 + byteIndex, byteCount, null);
			}
		}

		// Token: 0x06002C52 RID: 11346 RVA: 0x0008CE08 File Offset: 0x0008B008
		public unsafe override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex)
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
			if (charCount == 0)
			{
				return 0;
			}
			int byteCount = bytes.Length - byteIndex;
			char* ptr;
			if (chars == null || chars.Length == 0)
			{
				ptr = null;
			}
			else
			{
				ptr = &chars[0];
			}
			fixed (byte* arrayDataReference = MemoryMarshal.GetArrayDataReference<byte>(bytes))
			{
				byte* ptr2 = arrayDataReference;
				return this.GetBytes(ptr + charIndex, charCount, ptr2 + byteIndex, byteCount, null);
			}
		}

		// Token: 0x06002C53 RID: 11347 RVA: 0x0008B630 File Offset: 0x00089830
		[NullableContext(0)]
		[CLSCompliant(false)]
		public unsafe override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount)
		{
			ArgumentNullException.ThrowIfNull((void*)chars, "chars");
			ArgumentNullException.ThrowIfNull((void*)bytes, "bytes");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(charCount, "charCount");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(byteCount, "byteCount");
			return this.GetBytes(chars, charCount, bytes, byteCount, null);
		}

		// Token: 0x06002C54 RID: 11348 RVA: 0x0008CEBC File Offset: 0x0008B0BC
		public unsafe override int GetCharCount(byte[] bytes, int index, int count)
		{
			ArgumentNullException.ThrowIfNull(bytes, "bytes");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(index, "index");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(count, "count");
			if (bytes.Length - index < count)
			{
				throw new ArgumentOutOfRangeException("bytes", SR.ArgumentOutOfRange_IndexCountBuffer);
			}
			if (count == 0)
			{
				return 0;
			}
			byte* ptr;
			if (bytes == null || bytes.Length == 0)
			{
				ptr = null;
			}
			else
			{
				ptr = &bytes[0];
			}
			return this.GetCharCount(ptr + index, count, null);
		}

		// Token: 0x06002C55 RID: 11349 RVA: 0x0008B6DA File Offset: 0x000898DA
		[NullableContext(0)]
		[CLSCompliant(false)]
		public unsafe override int GetCharCount(byte* bytes, int count)
		{
			ArgumentNullException.ThrowIfNull((void*)bytes, "bytes");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(count, "count");
			return this.GetCharCount(bytes, count, null);
		}

		// Token: 0x06002C56 RID: 11350 RVA: 0x0008CF2C File Offset: 0x0008B12C
		public unsafe override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex)
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
			if (byteCount == 0)
			{
				return 0;
			}
			int charCount = chars.Length - charIndex;
			byte* ptr;
			if (bytes == null || bytes.Length == 0)
			{
				ptr = null;
			}
			else
			{
				ptr = &bytes[0];
			}
			fixed (char* arrayDataReference = MemoryMarshal.GetArrayDataReference<char>(chars))
			{
				char* ptr2 = arrayDataReference;
				return this.GetChars(ptr + byteIndex, byteCount, ptr2 + charIndex, charCount, null);
			}
		}

		// Token: 0x06002C57 RID: 11351 RVA: 0x0008B7B0 File Offset: 0x000899B0
		[NullableContext(0)]
		[CLSCompliant(false)]
		public unsafe override int GetChars(byte* bytes, int byteCount, char* chars, int charCount)
		{
			ArgumentNullException.ThrowIfNull((void*)bytes, "bytes");
			ArgumentNullException.ThrowIfNull((void*)chars, "chars");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(charCount, "charCount");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(byteCount, "byteCount");
			return this.GetChars(bytes, byteCount, chars, charCount, null);
		}

		// Token: 0x06002C58 RID: 11352 RVA: 0x0008CFE0 File Offset: 0x0008B1E0
		public unsafe override string GetString(byte[] bytes, int index, int count)
		{
			ArgumentNullException.ThrowIfNull(bytes, "bytes");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(index, "index");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(count, "count");
			if (bytes.Length - index < count)
			{
				throw new ArgumentOutOfRangeException("bytes", SR.ArgumentOutOfRange_IndexCountBuffer);
			}
			if (count == 0)
			{
				return string.Empty;
			}
			byte* ptr;
			if (bytes == null || bytes.Length == 0)
			{
				ptr = null;
			}
			else
			{
				ptr = &bytes[0];
			}
			return string.CreateStringFromEncoding(ptr + index, count, this);
		}

		// Token: 0x06002C59 RID: 11353 RVA: 0x0008D054 File Offset: 0x0008B254
		internal unsafe override int GetByteCount(char* chars, int count, EncoderNLS encoder)
		{
			char* ptr = chars + count;
			char* charStart = chars;
			int num = 0;
			char c = '\0';
			EncoderFallbackBuffer encoderFallbackBuffer;
			if (encoder != null)
			{
				c = encoder._charLeftOver;
				encoderFallbackBuffer = encoder.FallbackBuffer;
				if (encoderFallbackBuffer.Remaining > 0)
				{
					string argument_EncoderFallbackNotEmpty = SR.Argument_EncoderFallbackNotEmpty;
					object encodingName = this.EncodingName;
					EncoderFallback fallback = encoder.Fallback;
					throw new ArgumentException(SR.Format(argument_EncoderFallbackNotEmpty, encodingName, ((fallback != null) ? fallback.GetType().ToString() : null) ?? string.Empty));
				}
			}
			else
			{
				encoderFallbackBuffer = this.encoderFallback.CreateFallbackBuffer();
			}
			encoderFallbackBuffer.InternalInitialize(charStart, ptr, encoder, false);
			for (;;)
			{
				char c2;
				if ((c2 = encoderFallbackBuffer.InternalGetNextChar()) == '\0' && chars >= ptr)
				{
					if ((encoder != null && !encoder.MustFlush) || c <= '\0')
					{
						break;
					}
					char* ptr2 = chars;
					encoderFallbackBuffer.InternalFallback(c, ref ptr2);
					chars = ptr2;
					c = '\0';
				}
				else
				{
					if (c2 == '\0')
					{
						c2 = *chars;
						chars++;
					}
					if (c != '\0')
					{
						if (char.IsLowSurrogate(c2))
						{
							c = '\0';
							num += 4;
						}
						else
						{
							chars--;
							char* ptr2 = chars;
							encoderFallbackBuffer.InternalFallback(c, ref ptr2);
							chars = ptr2;
							c = '\0';
						}
					}
					else if (char.IsHighSurrogate(c2))
					{
						c = c2;
					}
					else if (char.IsLowSurrogate(c2))
					{
						char* ptr2 = chars;
						encoderFallbackBuffer.InternalFallback(c2, ref ptr2);
						chars = ptr2;
					}
					else
					{
						num += 4;
					}
				}
			}
			if (num < 0)
			{
				throw new ArgumentOutOfRangeException("count", SR.ArgumentOutOfRange_GetByteCountOverflow);
			}
			return num;
		}

		// Token: 0x06002C5A RID: 11354 RVA: 0x0008D194 File Offset: 0x0008B394
		internal unsafe override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder)
		{
			char* ptr = chars;
			char* ptr2 = chars + charCount;
			byte* ptr3 = bytes;
			byte* ptr4 = bytes + byteCount;
			char c = '\0';
			EncoderFallbackBuffer encoderFallbackBuffer;
			if (encoder != null)
			{
				c = encoder._charLeftOver;
				encoderFallbackBuffer = encoder.FallbackBuffer;
				if (encoder._throwOnOverflow && encoderFallbackBuffer.Remaining > 0)
				{
					string argument_EncoderFallbackNotEmpty = SR.Argument_EncoderFallbackNotEmpty;
					object encodingName = this.EncodingName;
					EncoderFallback fallback = encoder.Fallback;
					throw new ArgumentException(SR.Format(argument_EncoderFallbackNotEmpty, encodingName, (fallback != null) ? fallback.GetType() : null));
				}
			}
			else
			{
				encoderFallbackBuffer = this.encoderFallback.CreateFallbackBuffer();
			}
			encoderFallbackBuffer.InternalInitialize(ptr, ptr2, encoder, true);
			for (;;)
			{
				char c2;
				char* ptr5;
				if ((c2 = encoderFallbackBuffer.InternalGetNextChar()) != '\0' || chars < ptr2)
				{
					if (c2 == '\0')
					{
						c2 = *chars;
						chars++;
					}
					if (c != '\0')
					{
						if (!char.IsLowSurrogate(c2))
						{
							chars--;
							ptr5 = chars;
							encoderFallbackBuffer.InternalFallback(c, ref ptr5);
							chars = ptr5;
							c = '\0';
							continue;
						}
						uint surrogate = UTF32Encoding.GetSurrogate(c, c2);
						c = '\0';
						if (bytes + 3 >= ptr4)
						{
							if (encoderFallbackBuffer.bFallingBack)
							{
								encoderFallbackBuffer.MovePrevious();
								encoderFallbackBuffer.MovePrevious();
							}
							else
							{
								chars -= 2;
							}
							base.ThrowBytesOverflow(encoder, bytes == ptr3);
							c = '\0';
						}
						else
						{
							if (this._bigEndian)
							{
								*(bytes++) = 0;
								*(bytes++) = (byte)(surrogate >> 16);
								*(bytes++) = (byte)(surrogate >> 8);
								*(bytes++) = (byte)surrogate;
								continue;
							}
							*(bytes++) = (byte)surrogate;
							*(bytes++) = (byte)(surrogate >> 8);
							*(bytes++) = (byte)(surrogate >> 16);
							*(bytes++) = 0;
							continue;
						}
					}
					else
					{
						if (char.IsHighSurrogate(c2))
						{
							c = c2;
							continue;
						}
						if (char.IsLowSurrogate(c2))
						{
							ptr5 = chars;
							encoderFallbackBuffer.InternalFallback(c2, ref ptr5);
							chars = ptr5;
							continue;
						}
						if (bytes + 3 >= ptr4)
						{
							if (encoderFallbackBuffer.bFallingBack)
							{
								encoderFallbackBuffer.MovePrevious();
							}
							else
							{
								chars--;
							}
							base.ThrowBytesOverflow(encoder, bytes == ptr3);
						}
						else
						{
							if (this._bigEndian)
							{
								*(bytes++) = 0;
								*(bytes++) = 0;
								*(bytes++) = (byte)(c2 >> 8);
								*(bytes++) = (byte)c2;
								continue;
							}
							*(bytes++) = (byte)c2;
							*(bytes++) = (byte)(c2 >> 8);
							*(bytes++) = 0;
							*(bytes++) = 0;
							continue;
						}
					}
				}
				if ((encoder != null && !encoder.MustFlush) || c <= '\0')
				{
					break;
				}
				ptr5 = chars;
				encoderFallbackBuffer.InternalFallback(c, ref ptr5);
				chars = ptr5;
				c = '\0';
			}
			if (encoder != null)
			{
				encoder._charLeftOver = c;
				encoder._charsUsed = (int)((long)(chars - ptr));
			}
			return (int)((long)(bytes - ptr3));
		}

		// Token: 0x06002C5B RID: 11355 RVA: 0x0008D434 File Offset: 0x0008B634
		internal unsafe override int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder)
		{
			UTF32Encoding.UTF32Decoder utf32Decoder = (UTF32Encoding.UTF32Decoder)baseDecoder;
			int num = 0;
			byte* ptr = bytes + count;
			byte* byteStart = bytes;
			int i = 0;
			uint num2 = 0U;
			DecoderFallbackBuffer decoderFallbackBuffer;
			if (utf32Decoder != null)
			{
				i = utf32Decoder.readByteCount;
				num2 = (uint)utf32Decoder.iChar;
				decoderFallbackBuffer = utf32Decoder.FallbackBuffer;
			}
			else
			{
				decoderFallbackBuffer = this.decoderFallback.CreateFallbackBuffer();
			}
			decoderFallbackBuffer.InternalInitialize(byteStart, null);
			while (bytes < ptr && num >= 0)
			{
				if (this._bigEndian)
				{
					num2 <<= 8;
					num2 += (uint)(*(bytes++));
				}
				else
				{
					num2 >>= 8;
					num2 += (uint)((uint)(*(bytes++)) << 24);
				}
				i++;
				if (i >= 4)
				{
					i = 0;
					if (num2 > 1114111U || (num2 >= 55296U && num2 <= 57343U))
					{
						byte[] bytes2;
						if (this._bigEndian)
						{
							bytes2 = new byte[]
							{
								(byte)(num2 >> 24),
								(byte)(num2 >> 16),
								(byte)(num2 >> 8),
								(byte)num2
							};
						}
						else
						{
							bytes2 = new byte[]
							{
								(byte)num2,
								(byte)(num2 >> 8),
								(byte)(num2 >> 16),
								(byte)(num2 >> 24)
							};
						}
						num += decoderFallbackBuffer.InternalFallback(bytes2, bytes);
						num2 = 0U;
					}
					else
					{
						if (num2 >= 65536U)
						{
							num++;
						}
						num++;
						num2 = 0U;
					}
				}
			}
			if (i > 0 && (utf32Decoder == null || utf32Decoder.MustFlush))
			{
				byte[] array = new byte[i];
				if (this._bigEndian)
				{
					while (i > 0)
					{
						array[--i] = (byte)num2;
						num2 >>= 8;
					}
				}
				else
				{
					while (i > 0)
					{
						array[--i] = (byte)(num2 >> 24);
						num2 <<= 8;
					}
				}
				num += decoderFallbackBuffer.InternalFallback(array, bytes);
			}
			if (num < 0)
			{
				throw new ArgumentOutOfRangeException("count", SR.ArgumentOutOfRange_GetByteCountOverflow);
			}
			return num;
		}

		// Token: 0x06002C5C RID: 11356 RVA: 0x0008D5F4 File Offset: 0x0008B7F4
		internal unsafe override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS baseDecoder)
		{
			UTF32Encoding.UTF32Decoder utf32Decoder = (UTF32Encoding.UTF32Decoder)baseDecoder;
			char* ptr = chars;
			char* ptr2 = chars + charCount;
			byte* ptr3 = bytes;
			byte* ptr4 = bytes + byteCount;
			int num = 0;
			uint num2 = 0U;
			DecoderFallbackBuffer decoderFallbackBuffer;
			if (utf32Decoder != null)
			{
				num = utf32Decoder.readByteCount;
				num2 = (uint)utf32Decoder.iChar;
				decoderFallbackBuffer = baseDecoder.FallbackBuffer;
			}
			else
			{
				decoderFallbackBuffer = this.decoderFallback.CreateFallbackBuffer();
			}
			decoderFallbackBuffer.InternalInitialize(bytes, chars + charCount);
			while (bytes < ptr4)
			{
				if (this._bigEndian)
				{
					num2 <<= 8;
					num2 += (uint)(*(bytes++));
				}
				else
				{
					num2 >>= 8;
					num2 += (uint)((uint)(*(bytes++)) << 24);
				}
				num++;
				if (num >= 4)
				{
					num = 0;
					if (num2 > 1114111U || (num2 >= 55296U && num2 <= 57343U))
					{
						byte[] bytes2;
						if (this._bigEndian)
						{
							bytes2 = new byte[]
							{
								(byte)(num2 >> 24),
								(byte)(num2 >> 16),
								(byte)(num2 >> 8),
								(byte)num2
							};
						}
						else
						{
							bytes2 = new byte[]
							{
								(byte)num2,
								(byte)(num2 >> 8),
								(byte)(num2 >> 16),
								(byte)(num2 >> 24)
							};
						}
						char* ptr5 = chars;
						bool flag = decoderFallbackBuffer.InternalFallback(bytes2, bytes, ref ptr5);
						chars = ptr5;
						if (!flag)
						{
							bytes -= 4;
							num2 = 0U;
							decoderFallbackBuffer.InternalReset();
							base.ThrowCharsOverflow(utf32Decoder, chars == ptr);
							break;
						}
						num2 = 0U;
					}
					else
					{
						if (num2 >= 65536U)
						{
							if ((long)(ptr2 - chars) < 2L)
							{
								bytes -= 4;
								num2 = 0U;
								base.ThrowCharsOverflow(utf32Decoder, chars == ptr);
								break;
							}
							*(chars++) = UTF32Encoding.GetHighSurrogate(num2);
							num2 = (uint)UTF32Encoding.GetLowSurrogate(num2);
						}
						else if (chars >= ptr2)
						{
							bytes -= 4;
							num2 = 0U;
							base.ThrowCharsOverflow(utf32Decoder, chars == ptr);
							break;
						}
						*(chars++) = (char)num2;
						num2 = 0U;
					}
				}
			}
			if (num > 0 && (utf32Decoder == null || utf32Decoder.MustFlush))
			{
				byte[] array = new byte[num];
				int i = num;
				if (this._bigEndian)
				{
					while (i > 0)
					{
						array[--i] = (byte)num2;
						num2 >>= 8;
					}
				}
				else
				{
					while (i > 0)
					{
						array[--i] = (byte)(num2 >> 24);
						num2 <<= 8;
					}
				}
				char* ptr5 = chars;
				bool flag2 = decoderFallbackBuffer.InternalFallback(array, bytes, ref ptr5);
				chars = ptr5;
				if (!flag2)
				{
					decoderFallbackBuffer.InternalReset();
					base.ThrowCharsOverflow(utf32Decoder, chars == ptr);
				}
				else
				{
					num = 0;
					num2 = 0U;
				}
			}
			if (utf32Decoder != null)
			{
				utf32Decoder.iChar = (int)num2;
				utf32Decoder.readByteCount = num;
				utf32Decoder._bytesUsed = (int)((long)(bytes - ptr3));
			}
			return (int)((long)(chars - ptr));
		}

		// Token: 0x06002C5D RID: 11357 RVA: 0x0008D879 File Offset: 0x0008BA79
		private static uint GetSurrogate(char cHigh, char cLow)
		{
			return (uint)((cHigh - '\ud800') * 'Ѐ' + (cLow - '\udc00')) + 65536U;
		}

		// Token: 0x06002C5E RID: 11358 RVA: 0x0008D896 File Offset: 0x0008BA96
		private static char GetHighSurrogate(uint iChar)
		{
			return (char)((iChar - 65536U) / 1024U + 55296U);
		}

		// Token: 0x06002C5F RID: 11359 RVA: 0x0008D8AC File Offset: 0x0008BAAC
		private static char GetLowSurrogate(uint iChar)
		{
			return (char)((iChar - 65536U) % 1024U + 56320U);
		}

		// Token: 0x06002C60 RID: 11360 RVA: 0x0008D8C2 File Offset: 0x0008BAC2
		public override Decoder GetDecoder()
		{
			return new UTF32Encoding.UTF32Decoder(this);
		}

		// Token: 0x06002C61 RID: 11361 RVA: 0x00080E23 File Offset: 0x0007F023
		public override Encoder GetEncoder()
		{
			return new EncoderNLS(this);
		}

		// Token: 0x06002C62 RID: 11362 RVA: 0x0008D8CC File Offset: 0x0008BACC
		public override int GetMaxByteCount(int charCount)
		{
			ArgumentOutOfRangeException.ThrowIfNegative<int>(charCount, "charCount");
			long num = (long)charCount + 1L;
			if (base.EncoderFallback.MaxCharCount > 1)
			{
				num *= (long)base.EncoderFallback.MaxCharCount;
			}
			num *= 4L;
			if (num > 2147483647L)
			{
				throw new ArgumentOutOfRangeException("charCount", SR.ArgumentOutOfRange_GetByteCountOverflow);
			}
			return (int)num;
		}

		// Token: 0x06002C63 RID: 11363 RVA: 0x0008D928 File Offset: 0x0008BB28
		public override int GetMaxCharCount(int byteCount)
		{
			ArgumentOutOfRangeException.ThrowIfNegative<int>(byteCount, "byteCount");
			int num = byteCount / 2 + 2;
			if (base.DecoderFallback.MaxCharCount > 2)
			{
				num *= base.DecoderFallback.MaxCharCount;
				num /= 2;
			}
			if (num > 2147483647)
			{
				throw new ArgumentOutOfRangeException("byteCount", SR.ArgumentOutOfRange_GetCharCountOverflow);
			}
			return num;
		}

		// Token: 0x06002C64 RID: 11364 RVA: 0x0008D980 File Offset: 0x0008BB80
		public override byte[] GetPreamble()
		{
			if (!this._emitUTF32ByteOrderMark)
			{
				return Array.Empty<byte>();
			}
			if (this._bigEndian)
			{
				return new byte[]
				{
					0,
					0,
					254,
					byte.MaxValue
				};
			}
			byte[] array = new byte[4];
			array[0] = byte.MaxValue;
			array[1] = 254;
			return array;
		}

		// Token: 0x170008A5 RID: 2213
		// (get) Token: 0x06002C65 RID: 11365 RVA: 0x0008D9D0 File Offset: 0x0008BBD0
		[Nullable(0)]
		public unsafe override ReadOnlySpan<byte> Preamble
		{
			[NullableContext(0)]
			get
			{
				if (base.GetType() != typeof(UTF32Encoding))
				{
					return new ReadOnlySpan<byte>(this.GetPreamble());
				}
				if (!this._emitUTF32ByteOrderMark)
				{
					return default(ReadOnlySpan<byte>);
				}
				if (!this._bigEndian)
				{
					return new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.0B856F2A1EA6FE59346BEC325DFE906BFA23BABE05EB10AC9FE7F5B46196AE71), 4);
				}
				return new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.F083DD8458E610A6B9650AC3F9C98822968EEDE9219C3424BE5FC457A290C50C), 4);
			}
		}

		// Token: 0x06002C66 RID: 11366 RVA: 0x0008DA34 File Offset: 0x0008BC34
		[NullableContext(2)]
		public override bool Equals([NotNullWhen(true)] object value)
		{
			UTF32Encoding utf32Encoding = value as UTF32Encoding;
			return utf32Encoding != null && (this._emitUTF32ByteOrderMark == utf32Encoding._emitUTF32ByteOrderMark && this._bigEndian == utf32Encoding._bigEndian && base.EncoderFallback.Equals(utf32Encoding.EncoderFallback)) && base.DecoderFallback.Equals(utf32Encoding.DecoderFallback);
		}

		// Token: 0x06002C67 RID: 11367 RVA: 0x0008DA8F File Offset: 0x0008BC8F
		public override int GetHashCode()
		{
			return base.EncoderFallback.GetHashCode() + base.DecoderFallback.GetHashCode() + this.CodePage + (this._emitUTF32ByteOrderMark ? 4 : 0) + (this._bigEndian ? 8 : 0);
		}

		// Token: 0x040007D8 RID: 2008
		internal static readonly UTF32Encoding s_default = new UTF32Encoding(false, true);

		// Token: 0x040007D9 RID: 2009
		internal static readonly UTF32Encoding s_bigEndianDefault = new UTF32Encoding(true, true);

		// Token: 0x040007DA RID: 2010
		private readonly bool _emitUTF32ByteOrderMark;

		// Token: 0x040007DB RID: 2011
		private readonly bool _isThrowException;

		// Token: 0x040007DC RID: 2012
		private readonly bool _bigEndian;

		// Token: 0x02000245 RID: 581
		private sealed class UTF32Decoder : DecoderNLS
		{
			// Token: 0x06002C69 RID: 11369 RVA: 0x0008DAE3 File Offset: 0x0008BCE3
			public UTF32Decoder(UTF32Encoding encoding) : base(encoding)
			{
			}

			// Token: 0x06002C6A RID: 11370 RVA: 0x0008DAEC File Offset: 0x0008BCEC
			public override void Reset()
			{
				this.iChar = 0;
				this.readByteCount = 0;
				DecoderFallbackBuffer fallbackBuffer = this._fallbackBuffer;
				if (fallbackBuffer == null)
				{
					return;
				}
				fallbackBuffer.Reset();
			}

			// Token: 0x170008A6 RID: 2214
			// (get) Token: 0x06002C6B RID: 11371 RVA: 0x0008DB0C File Offset: 0x0008BD0C
			internal override bool HasState
			{
				get
				{
					return this.readByteCount != 0;
				}
			}

			// Token: 0x040007DD RID: 2013
			internal int iChar;

			// Token: 0x040007DE RID: 2014
			internal int readByteCount;
		}
	}
}
