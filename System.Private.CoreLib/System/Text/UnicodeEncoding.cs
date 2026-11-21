using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Text
{
	// Token: 0x02000241 RID: 577
	[NullableContext(1)]
	[Nullable(0)]
	public class UnicodeEncoding : Encoding
	{
		// Token: 0x06002C1E RID: 11294 RVA: 0x0008B36A File Offset: 0x0008956A
		public UnicodeEncoding() : this(false, true)
		{
		}

		// Token: 0x06002C1F RID: 11295 RVA: 0x0008B374 File Offset: 0x00089574
		public UnicodeEncoding(bool bigEndian, bool byteOrderMark) : base(bigEndian ? 1201 : 1200)
		{
			this.bigEndian = bigEndian;
			this.byteOrderMark = byteOrderMark;
		}

		// Token: 0x06002C20 RID: 11296 RVA: 0x0008B399 File Offset: 0x00089599
		public UnicodeEncoding(bool bigEndian, bool byteOrderMark, bool throwOnInvalidBytes) : this(bigEndian, byteOrderMark)
		{
			this.isThrowException = throwOnInvalidBytes;
			if (this.isThrowException)
			{
				this.SetDefaultFallbacks();
			}
		}

		// Token: 0x06002C21 RID: 11297 RVA: 0x0008B3B8 File Offset: 0x000895B8
		internal sealed override void SetDefaultFallbacks()
		{
			if (this.isThrowException)
			{
				this.encoderFallback = EncoderFallback.ExceptionFallback;
				this.decoderFallback = DecoderFallback.ExceptionFallback;
				return;
			}
			this.encoderFallback = new EncoderReplacementFallback("�");
			this.decoderFallback = new DecoderReplacementFallback("�");
		}

		// Token: 0x06002C22 RID: 11298 RVA: 0x0008B404 File Offset: 0x00089604
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

		// Token: 0x06002C23 RID: 11299 RVA: 0x0008B478 File Offset: 0x00089678
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

		// Token: 0x06002C24 RID: 11300 RVA: 0x0008B4AE File Offset: 0x000896AE
		[NullableContext(0)]
		[CLSCompliant(false)]
		public unsafe override int GetByteCount(char* chars, int count)
		{
			ArgumentNullException.ThrowIfNull((void*)chars, "chars");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(count, "count");
			return this.GetByteCount(chars, count, null);
		}

		// Token: 0x06002C25 RID: 11301 RVA: 0x0008B4D0 File Offset: 0x000896D0
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

		// Token: 0x06002C26 RID: 11302 RVA: 0x0008B57C File Offset: 0x0008977C
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

		// Token: 0x06002C27 RID: 11303 RVA: 0x0008B630 File Offset: 0x00089830
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

		// Token: 0x06002C28 RID: 11304 RVA: 0x0008B66C File Offset: 0x0008986C
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

		// Token: 0x06002C29 RID: 11305 RVA: 0x0008B6DA File Offset: 0x000898DA
		[NullableContext(0)]
		[CLSCompliant(false)]
		public unsafe override int GetCharCount(byte* bytes, int count)
		{
			ArgumentNullException.ThrowIfNull((void*)bytes, "bytes");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(count, "count");
			return this.GetCharCount(bytes, count, null);
		}

		// Token: 0x06002C2A RID: 11306 RVA: 0x0008B6FC File Offset: 0x000898FC
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

		// Token: 0x06002C2B RID: 11307 RVA: 0x0008B7B0 File Offset: 0x000899B0
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

		// Token: 0x06002C2C RID: 11308 RVA: 0x0008B7EC File Offset: 0x000899EC
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

		// Token: 0x06002C2D RID: 11309 RVA: 0x0008B860 File Offset: 0x00089A60
		internal unsafe sealed override int GetByteCount(char* chars, int count, EncoderNLS encoder)
		{
			int num = count << 1;
			if (num < 0)
			{
				throw new ArgumentOutOfRangeException("count", SR.ArgumentOutOfRange_GetByteCountOverflow);
			}
			char* charStart = chars;
			char* ptr = chars + count;
			char c = '\0';
			bool flag = false;
			EncoderFallbackBuffer encoderFallbackBuffer = null;
			if (encoder != null)
			{
				c = encoder._charLeftOver;
				if (c > '\0')
				{
					num += 2;
				}
				if (encoder.InternalHasFallbackBuffer)
				{
					encoderFallbackBuffer = encoder.FallbackBuffer;
					if (encoderFallbackBuffer.Remaining > 0)
					{
						string argument_EncoderFallbackNotEmpty = SR.Argument_EncoderFallbackNotEmpty;
						object encodingName = this.EncodingName;
						EncoderFallback fallback = encoder.Fallback;
						throw new ArgumentException(SR.Format(argument_EncoderFallbackNotEmpty, encodingName, (fallback != null) ? fallback.GetType() : null));
					}
					encoderFallbackBuffer.InternalInitialize(charStart, ptr, encoder, false);
				}
			}
			for (;;)
			{
				char c2;
				char* ptr4;
				if ((c2 = ((encoderFallbackBuffer == null) ? '\0' : encoderFallbackBuffer.InternalGetNextChar())) != '\0' || chars < ptr)
				{
					if (c2 == '\0')
					{
						if ((this.bigEndian ^ BitConverter.IsLittleEndian) && (chars & 7L) == null && c == '\0')
						{
							ulong* ptr2 = (ulong*)(ptr - 3);
							ulong* ptr3;
							for (ptr3 = (ulong*)chars; ptr3 < ptr2; ptr3++)
							{
								if ((9223512776490647552UL & *ptr3) != 0UL)
								{
									ulong num2 = (17870556004450629632UL & *ptr3) ^ 15564677810327967744UL;
									if ((num2 & 18446462598732840960UL) == 0UL || (num2 & 281470681743360UL) == 0UL || (num2 & (ulong)-65536) == 0UL || (num2 & 65535UL) == 0UL)
									{
										long num3 = (long)(18158790778715962368UL & *ptr3);
										if (!BitConverter.IsLittleEndian)
										{
										}
										if (num3 != -2593835887162763264L)
										{
											break;
										}
									}
								}
							}
							chars = (char*)ptr3;
							if (chars >= ptr)
							{
								goto IL_28F;
							}
						}
						c2 = *chars;
						chars++;
					}
					else
					{
						num += 2;
					}
					if (c2 >= '\ud800' && c2 <= '\udfff')
					{
						if (c2 <= '\udbff')
						{
							if (c > '\0')
							{
								chars--;
								num -= 2;
								if (encoderFallbackBuffer == null)
								{
									encoderFallbackBuffer = ((encoder == null) ? this.encoderFallback.CreateFallbackBuffer() : encoder.FallbackBuffer);
									encoderFallbackBuffer.InternalInitialize(charStart, ptr, encoder, false);
								}
								ptr4 = chars;
								encoderFallbackBuffer.InternalFallback(c, ref ptr4);
								chars = ptr4;
								c = '\0';
								continue;
							}
							c = c2;
							continue;
						}
						else
						{
							if (c == '\0')
							{
								num -= 2;
								if (encoderFallbackBuffer == null)
								{
									encoderFallbackBuffer = ((encoder == null) ? this.encoderFallback.CreateFallbackBuffer() : encoder.FallbackBuffer);
									encoderFallbackBuffer.InternalInitialize(charStart, ptr, encoder, false);
								}
								ptr4 = chars;
								encoderFallbackBuffer.InternalFallback(c2, ref ptr4);
								chars = ptr4;
								continue;
							}
							c = '\0';
							continue;
						}
					}
					else
					{
						if (c > '\0')
						{
							chars--;
							if (encoderFallbackBuffer == null)
							{
								encoderFallbackBuffer = ((encoder == null) ? this.encoderFallback.CreateFallbackBuffer() : encoder.FallbackBuffer);
								encoderFallbackBuffer.InternalInitialize(charStart, ptr, encoder, false);
							}
							ptr4 = chars;
							encoderFallbackBuffer.InternalFallback(c, ref ptr4);
							chars = ptr4;
							num -= 2;
							c = '\0';
							continue;
						}
						continue;
					}
				}
				IL_28F:
				if (c <= '\0')
				{
					return num;
				}
				num -= 2;
				if (encoder != null && !encoder.MustFlush)
				{
					return num;
				}
				if (flag)
				{
					break;
				}
				if (encoderFallbackBuffer == null)
				{
					encoderFallbackBuffer = ((encoder == null) ? this.encoderFallback.CreateFallbackBuffer() : encoder.FallbackBuffer);
					encoderFallbackBuffer.InternalInitialize(charStart, ptr, encoder, false);
				}
				ptr4 = chars;
				encoderFallbackBuffer.InternalFallback(c, ref ptr4);
				chars = ptr4;
				c = '\0';
				flag = true;
			}
			throw new ArgumentException(SR.Format(SR.Argument_RecursiveFallback, c), "chars");
		}

		// Token: 0x06002C2E RID: 11310 RVA: 0x0008BB74 File Offset: 0x00089D74
		internal unsafe sealed override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder)
		{
			char c = '\0';
			bool flag = false;
			byte* ptr = bytes + byteCount;
			char* ptr2 = chars + charCount;
			byte* ptr3 = bytes;
			char* ptr4 = chars;
			EncoderFallbackBuffer encoderFallbackBuffer = null;
			if (encoder != null)
			{
				c = encoder._charLeftOver;
				if (encoder.InternalHasFallbackBuffer)
				{
					encoderFallbackBuffer = encoder.FallbackBuffer;
					if (encoderFallbackBuffer.Remaining > 0 && encoder._throwOnOverflow)
					{
						string argument_EncoderFallbackNotEmpty = SR.Argument_EncoderFallbackNotEmpty;
						object encodingName = this.EncodingName;
						EncoderFallback fallback = encoder.Fallback;
						throw new ArgumentException(SR.Format(argument_EncoderFallbackNotEmpty, encodingName, (fallback != null) ? fallback.GetType() : null));
					}
					encoderFallbackBuffer.InternalInitialize(ptr4, ptr2, encoder, false);
				}
			}
			for (;;)
			{
				char c2;
				char* ptr8;
				if ((c2 = ((encoderFallbackBuffer == null) ? '\0' : encoderFallbackBuffer.InternalGetNextChar())) != '\0' || chars < ptr2)
				{
					if (c2 == '\0')
					{
						if ((this.bigEndian ^ BitConverter.IsLittleEndian) && (chars & 7L) == null && c == '\0')
						{
							ulong* ptr5 = (ulong*)(chars - 3 + (((long)(ptr - bytes) >> 1 < (long)(ptr2 - chars)) ? ((long)(ptr - bytes) >> 1) : ((long)(ptr2 - chars))) * 2L / 8L);
							ulong* ptr6 = (ulong*)chars;
							ulong* ptr7 = (ulong*)bytes;
							while (ptr6 < ptr5)
							{
								if ((9223512776490647552UL & *ptr6) != 0UL)
								{
									ulong num = (17870556004450629632UL & *ptr6) ^ 15564677810327967744UL;
									if ((num & 18446462598732840960UL) == 0UL || (num & 281470681743360UL) == 0UL || (num & (ulong)-65536) == 0UL || (num & 65535UL) == 0UL)
									{
										long num2 = (long)(18158790778715962368UL & *ptr6);
										if (!BitConverter.IsLittleEndian)
										{
										}
										if (num2 != -2593835887162763264L)
										{
											break;
										}
									}
								}
								Unsafe.WriteUnaligned<ulong>((void*)ptr7, *ptr6);
								ptr6++;
								ptr7++;
							}
							chars = (char*)ptr6;
							bytes = (byte*)ptr7;
							if (chars >= ptr2)
							{
								goto IL_399;
							}
						}
						c2 = *chars;
						chars++;
					}
					if (c2 >= '\ud800' && c2 <= '\udfff')
					{
						if (c2 <= '\udbff')
						{
							if (c > '\0')
							{
								chars--;
								if (encoderFallbackBuffer == null)
								{
									encoderFallbackBuffer = ((encoder == null) ? this.encoderFallback.CreateFallbackBuffer() : encoder.FallbackBuffer);
									encoderFallbackBuffer.InternalInitialize(ptr4, ptr2, encoder, true);
								}
								ptr8 = chars;
								encoderFallbackBuffer.InternalFallback(c, ref ptr8);
								chars = ptr8;
								c = '\0';
								continue;
							}
							c = c2;
							continue;
						}
						else
						{
							if (c == '\0')
							{
								if (encoderFallbackBuffer == null)
								{
									encoderFallbackBuffer = ((encoder == null) ? this.encoderFallback.CreateFallbackBuffer() : encoder.FallbackBuffer);
									encoderFallbackBuffer.InternalInitialize(ptr4, ptr2, encoder, true);
								}
								ptr8 = chars;
								encoderFallbackBuffer.InternalFallback(c2, ref ptr8);
								chars = ptr8;
								continue;
							}
							if (bytes + 3 >= ptr)
							{
								if (encoderFallbackBuffer != null && encoderFallbackBuffer.bFallingBack)
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
								goto IL_399;
							}
							if (this.bigEndian)
							{
								*(bytes++) = (byte)(c >> 8);
								*(bytes++) = (byte)c;
							}
							else
							{
								*(bytes++) = (byte)c;
								*(bytes++) = (byte)(c >> 8);
							}
							c = '\0';
						}
					}
					else if (c > '\0')
					{
						chars--;
						if (encoderFallbackBuffer == null)
						{
							encoderFallbackBuffer = ((encoder == null) ? this.encoderFallback.CreateFallbackBuffer() : encoder.FallbackBuffer);
							encoderFallbackBuffer.InternalInitialize(ptr4, ptr2, encoder, true);
						}
						ptr8 = chars;
						encoderFallbackBuffer.InternalFallback(c, ref ptr8);
						chars = ptr8;
						c = '\0';
						continue;
					}
					if (bytes + 1 >= ptr)
					{
						if (encoderFallbackBuffer != null && encoderFallbackBuffer.bFallingBack)
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
						if (this.bigEndian)
						{
							*(bytes++) = (byte)(c2 >> 8);
							*(bytes++) = (byte)c2;
							continue;
						}
						*(bytes++) = (byte)c2;
						*(bytes++) = (byte)(c2 >> 8);
						continue;
					}
				}
				IL_399:
				if (c <= '\0' || (encoder != null && !encoder.MustFlush))
				{
					goto IL_40F;
				}
				if (flag)
				{
					break;
				}
				if (encoderFallbackBuffer == null)
				{
					encoderFallbackBuffer = ((encoder == null) ? this.encoderFallback.CreateFallbackBuffer() : encoder.FallbackBuffer);
					encoderFallbackBuffer.InternalInitialize(ptr4, ptr2, encoder, true);
				}
				ptr8 = chars;
				encoderFallbackBuffer.InternalFallback(c, ref ptr8);
				chars = ptr8;
				c = '\0';
				flag = true;
			}
			throw new ArgumentException(SR.Format(SR.Argument_RecursiveFallback, c), "chars");
			IL_40F:
			if (encoder != null)
			{
				encoder._charLeftOver = c;
				encoder._charsUsed = (int)((long)(chars - ptr4));
			}
			return (int)((long)(bytes - ptr3));
		}

		// Token: 0x06002C2F RID: 11311 RVA: 0x0008BFB4 File Offset: 0x0008A1B4
		internal unsafe sealed override int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder)
		{
			UnicodeEncoding.Decoder decoder = (UnicodeEncoding.Decoder)baseDecoder;
			byte* ptr = bytes + count;
			byte* byteStart = bytes;
			int num = -1;
			char c = '\0';
			int num2 = count >> 1;
			DecoderFallbackBuffer decoderFallbackBuffer = null;
			if (decoder != null)
			{
				num = decoder.lastByte;
				c = decoder.lastChar;
				if (c > '\0')
				{
					num2++;
				}
				if (num >= 0 && (count & 1) == 1)
				{
					num2++;
				}
			}
			while (bytes < ptr)
			{
				if ((this.bigEndian ^ BitConverter.IsLittleEndian) && (bytes & 7L) == null && num == -1 && c == '\0')
				{
					ulong* ptr2 = (ulong*)(ptr - 7);
					ulong* ptr3;
					for (ptr3 = (ulong*)bytes; ptr3 < ptr2; ptr3++)
					{
						if ((9223512776490647552UL & *ptr3) != 0UL)
						{
							ulong num3 = (17870556004450629632UL & *ptr3) ^ 15564677810327967744UL;
							if ((num3 & 18446462598732840960UL) == 0UL || (num3 & 281470681743360UL) == 0UL || (num3 & (ulong)-65536) == 0UL || (num3 & 65535UL) == 0UL)
							{
								long num4 = (long)(18158790778715962368UL & *ptr3);
								if (!BitConverter.IsLittleEndian)
								{
								}
								if (num4 != -2593835887162763264L)
								{
									break;
								}
							}
						}
					}
					bytes = (byte*)ptr3;
					if (bytes >= ptr)
					{
						break;
					}
				}
				if (num < 0)
				{
					num = (int)(*(bytes++));
					if (bytes >= ptr)
					{
						break;
					}
				}
				char c2;
				if (this.bigEndian)
				{
					c2 = (char)(num << 8 | (int)(*(bytes++)));
				}
				else
				{
					c2 = (char)((int)(*(bytes++)) << 8 | num);
				}
				num = -1;
				if (c2 >= '\ud800' && c2 <= '\udfff')
				{
					if (c2 <= '\udbff')
					{
						if (c > '\0')
						{
							num2--;
							byte[] bytes2;
							if (this.bigEndian)
							{
								bytes2 = new byte[]
								{
									(byte)(c >> 8),
									(byte)c
								};
							}
							else
							{
								bytes2 = new byte[]
								{
									(byte)c,
									(byte)(c >> 8)
								};
							}
							if (decoderFallbackBuffer == null)
							{
								decoderFallbackBuffer = ((decoder == null) ? this.decoderFallback.CreateFallbackBuffer() : decoder.FallbackBuffer);
								decoderFallbackBuffer.InternalInitialize(byteStart, null);
							}
							num2 += decoderFallbackBuffer.InternalFallback(bytes2, bytes);
						}
						c = c2;
					}
					else if (c == '\0')
					{
						num2--;
						byte[] bytes3;
						if (this.bigEndian)
						{
							bytes3 = new byte[]
							{
								(byte)(c2 >> 8),
								(byte)c2
							};
						}
						else
						{
							bytes3 = new byte[]
							{
								(byte)c2,
								(byte)(c2 >> 8)
							};
						}
						if (decoderFallbackBuffer == null)
						{
							decoderFallbackBuffer = ((decoder == null) ? this.decoderFallback.CreateFallbackBuffer() : decoder.FallbackBuffer);
							decoderFallbackBuffer.InternalInitialize(byteStart, null);
						}
						num2 += decoderFallbackBuffer.InternalFallback(bytes3, bytes);
					}
					else
					{
						c = '\0';
					}
				}
				else if (c > '\0')
				{
					num2--;
					byte[] bytes4;
					if (this.bigEndian)
					{
						bytes4 = new byte[]
						{
							(byte)(c >> 8),
							(byte)c
						};
					}
					else
					{
						bytes4 = new byte[]
						{
							(byte)c,
							(byte)(c >> 8)
						};
					}
					if (decoderFallbackBuffer == null)
					{
						decoderFallbackBuffer = ((decoder == null) ? this.decoderFallback.CreateFallbackBuffer() : decoder.FallbackBuffer);
						decoderFallbackBuffer.InternalInitialize(byteStart, null);
					}
					num2 += decoderFallbackBuffer.InternalFallback(bytes4, bytes);
					c = '\0';
				}
			}
			if (decoder == null || decoder.MustFlush)
			{
				if (c > '\0')
				{
					num2--;
					byte[] bytes5;
					if (this.bigEndian)
					{
						bytes5 = new byte[]
						{
							(byte)(c >> 8),
							(byte)c
						};
					}
					else
					{
						bytes5 = new byte[]
						{
							(byte)c,
							(byte)(c >> 8)
						};
					}
					if (decoderFallbackBuffer == null)
					{
						decoderFallbackBuffer = ((decoder == null) ? this.decoderFallback.CreateFallbackBuffer() : decoder.FallbackBuffer);
						decoderFallbackBuffer.InternalInitialize(byteStart, null);
					}
					num2 += decoderFallbackBuffer.InternalFallback(bytes5, bytes);
					c = '\0';
				}
				if (num >= 0)
				{
					if (decoderFallbackBuffer == null)
					{
						decoderFallbackBuffer = ((decoder == null) ? this.decoderFallback.CreateFallbackBuffer() : decoder.FallbackBuffer);
						decoderFallbackBuffer.InternalInitialize(byteStart, null);
					}
					num2 += decoderFallbackBuffer.InternalFallback(new byte[]
					{
						(byte)num
					}, bytes);
				}
			}
			if (c > '\0')
			{
				num2--;
			}
			return num2;
		}

		// Token: 0x06002C30 RID: 11312 RVA: 0x0008C3A0 File Offset: 0x0008A5A0
		internal unsafe sealed override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS baseDecoder)
		{
			UnicodeEncoding.Decoder decoder = (UnicodeEncoding.Decoder)baseDecoder;
			int num = -1;
			char c = '\0';
			if (decoder != null)
			{
				num = decoder.lastByte;
				c = decoder.lastChar;
			}
			DecoderFallbackBuffer decoderFallbackBuffer = null;
			byte* ptr = bytes + byteCount;
			char* ptr2 = chars + charCount;
			byte* ptr3 = bytes;
			char* ptr4 = chars;
			while (bytes < ptr)
			{
				if ((this.bigEndian ^ BitConverter.IsLittleEndian) && (chars & 7L) == null && num == -1 && c == '\0')
				{
					ulong* ptr5 = (ulong*)(bytes - 7 + (IntPtr)(((long)(ptr - bytes) >> 1 < (long)(ptr2 - chars)) ? ((long)(ptr - bytes)) : ((long)(ptr2 - chars) << 1)) / 8);
					ulong* ptr6 = (ulong*)bytes;
					ulong* ptr7 = (ulong*)chars;
					while (ptr6 < ptr5)
					{
						if ((9223512776490647552UL & *ptr6) != 0UL)
						{
							ulong num2 = (17870556004450629632UL & *ptr6) ^ 15564677810327967744UL;
							if ((num2 & 18446462598732840960UL) == 0UL || (num2 & 281470681743360UL) == 0UL || (num2 & (ulong)-65536) == 0UL || (num2 & 65535UL) == 0UL)
							{
								long num3 = (long)(18158790778715962368UL & *ptr6);
								if (!BitConverter.IsLittleEndian)
								{
								}
								if (num3 != -2593835887162763264L)
								{
									break;
								}
							}
						}
						Unsafe.WriteUnaligned<ulong>((void*)ptr7, *ptr6);
						ptr6++;
						ptr7++;
					}
					chars = (char*)ptr7;
					bytes = (byte*)ptr6;
					if (bytes >= ptr)
					{
						break;
					}
				}
				if (num < 0)
				{
					num = (int)(*(bytes++));
				}
				else
				{
					char c2;
					if (this.bigEndian)
					{
						c2 = (char)(num << 8 | (int)(*(bytes++)));
					}
					else
					{
						c2 = (char)((int)(*(bytes++)) << 8 | num);
					}
					num = -1;
					if (c2 >= '\ud800' && c2 <= '\udfff')
					{
						if (c2 <= '\udbff')
						{
							if (c > '\0')
							{
								byte[] bytes2;
								if (this.bigEndian)
								{
									bytes2 = new byte[]
									{
										(byte)(c >> 8),
										(byte)c
									};
								}
								else
								{
									bytes2 = new byte[]
									{
										(byte)c,
										(byte)(c >> 8)
									};
								}
								if (decoderFallbackBuffer == null)
								{
									decoderFallbackBuffer = ((decoder == null) ? this.decoderFallback.CreateFallbackBuffer() : decoder.FallbackBuffer);
									decoderFallbackBuffer.InternalInitialize(ptr3, ptr2);
								}
								char* ptr8 = chars;
								bool flag = decoderFallbackBuffer.InternalFallback(bytes2, bytes, ref ptr8);
								chars = ptr8;
								if (!flag)
								{
									bytes -= 2;
									decoderFallbackBuffer.InternalReset();
									base.ThrowCharsOverflow(decoder, chars == ptr4);
									break;
								}
							}
							c = c2;
							continue;
						}
						if (c == '\0')
						{
							byte[] bytes3;
							if (this.bigEndian)
							{
								bytes3 = new byte[]
								{
									(byte)(c2 >> 8),
									(byte)c2
								};
							}
							else
							{
								bytes3 = new byte[]
								{
									(byte)c2,
									(byte)(c2 >> 8)
								};
							}
							if (decoderFallbackBuffer == null)
							{
								decoderFallbackBuffer = ((decoder == null) ? this.decoderFallback.CreateFallbackBuffer() : decoder.FallbackBuffer);
								decoderFallbackBuffer.InternalInitialize(ptr3, ptr2);
							}
							char* ptr8 = chars;
							bool flag2 = decoderFallbackBuffer.InternalFallback(bytes3, bytes, ref ptr8);
							chars = ptr8;
							if (!flag2)
							{
								bytes -= 2;
								decoderFallbackBuffer.InternalReset();
								base.ThrowCharsOverflow(decoder, chars == ptr4);
								break;
							}
							continue;
						}
						else
						{
							if ((long)(ptr2 - chars) < 2L)
							{
								bytes -= 2;
								base.ThrowCharsOverflow(decoder, chars == ptr4);
								break;
							}
							*(chars++) = c;
							c = '\0';
						}
					}
					else if (c > '\0')
					{
						byte[] bytes4;
						if (this.bigEndian)
						{
							bytes4 = new byte[]
							{
								(byte)(c >> 8),
								(byte)c
							};
						}
						else
						{
							bytes4 = new byte[]
							{
								(byte)c,
								(byte)(c >> 8)
							};
						}
						if (decoderFallbackBuffer == null)
						{
							decoderFallbackBuffer = ((decoder == null) ? this.decoderFallback.CreateFallbackBuffer() : decoder.FallbackBuffer);
							decoderFallbackBuffer.InternalInitialize(ptr3, ptr2);
						}
						char* ptr8 = chars;
						bool flag3 = decoderFallbackBuffer.InternalFallback(bytes4, bytes, ref ptr8);
						chars = ptr8;
						if (!flag3)
						{
							bytes -= 2;
							decoderFallbackBuffer.InternalReset();
							base.ThrowCharsOverflow(decoder, chars == ptr4);
							break;
						}
						c = '\0';
					}
					if (chars >= ptr2)
					{
						bytes -= 2;
						base.ThrowCharsOverflow(decoder, chars == ptr4);
						break;
					}
					*(chars++) = c2;
				}
			}
			if (decoder == null || decoder.MustFlush)
			{
				if (c > '\0')
				{
					byte[] bytes5;
					if (this.bigEndian)
					{
						bytes5 = new byte[]
						{
							(byte)(c >> 8),
							(byte)c
						};
					}
					else
					{
						bytes5 = new byte[]
						{
							(byte)c,
							(byte)(c >> 8)
						};
					}
					if (decoderFallbackBuffer == null)
					{
						decoderFallbackBuffer = ((decoder == null) ? this.decoderFallback.CreateFallbackBuffer() : decoder.FallbackBuffer);
						decoderFallbackBuffer.InternalInitialize(ptr3, ptr2);
					}
					char* ptr8 = chars;
					bool flag4 = decoderFallbackBuffer.InternalFallback(bytes5, bytes, ref ptr8);
					chars = ptr8;
					if (!flag4)
					{
						bytes -= 2;
						if (num >= 0)
						{
							bytes--;
						}
						decoderFallbackBuffer.InternalReset();
						base.ThrowCharsOverflow(decoder, chars == ptr4);
						bytes += 2;
						if (num >= 0)
						{
							bytes++;
							goto IL_4CA;
						}
						goto IL_4CA;
					}
					else
					{
						c = '\0';
					}
				}
				if (num >= 0)
				{
					if (decoderFallbackBuffer == null)
					{
						decoderFallbackBuffer = ((decoder == null) ? this.decoderFallback.CreateFallbackBuffer() : decoder.FallbackBuffer);
						decoderFallbackBuffer.InternalInitialize(ptr3, ptr2);
					}
					char* ptr8 = chars;
					bool flag5 = decoderFallbackBuffer.InternalFallback(new byte[]
					{
						(byte)num
					}, bytes, ref ptr8);
					chars = ptr8;
					if (!flag5)
					{
						bytes--;
						decoderFallbackBuffer.InternalReset();
						base.ThrowCharsOverflow(decoder, chars == ptr4);
						bytes++;
					}
					else
					{
						num = -1;
					}
				}
			}
			IL_4CA:
			if (decoder != null)
			{
				decoder._bytesUsed = (int)((long)(bytes - ptr3));
				decoder.lastChar = c;
				decoder.lastByte = num;
			}
			return (int)((long)(chars - ptr4));
		}

		// Token: 0x06002C31 RID: 11313 RVA: 0x00080E23 File Offset: 0x0007F023
		public override Encoder GetEncoder()
		{
			return new EncoderNLS(this);
		}

		// Token: 0x06002C32 RID: 11314 RVA: 0x0008C89E File Offset: 0x0008AA9E
		public override System.Text.Decoder GetDecoder()
		{
			return new UnicodeEncoding.Decoder(this);
		}

		// Token: 0x06002C33 RID: 11315 RVA: 0x0008C8A8 File Offset: 0x0008AAA8
		public override byte[] GetPreamble()
		{
			if (!this.byteOrderMark)
			{
				return Array.Empty<byte>();
			}
			if (this.bigEndian)
			{
				return new byte[]
				{
					254,
					byte.MaxValue
				};
			}
			return new byte[]
			{
				byte.MaxValue,
				254
			};
		}

		// Token: 0x170008A3 RID: 2211
		// (get) Token: 0x06002C34 RID: 11316 RVA: 0x0008C8F8 File Offset: 0x0008AAF8
		[Nullable(0)]
		public unsafe override ReadOnlySpan<byte> Preamble
		{
			[NullableContext(0)]
			get
			{
				if (base.GetType() != typeof(UnicodeEncoding))
				{
					return new ReadOnlySpan<byte>(this.GetPreamble());
				}
				if (!this.byteOrderMark)
				{
					return default(ReadOnlySpan<byte>);
				}
				if (!this.bigEndian)
				{
					return new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.B3D510EF04275CA8E698E5B3CBB0ECE3949EF9252F0CDC839E9EE347409A2209), 2);
				}
				return new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.F197692810D457E297FCE9C5653B02581FF99A50852370F29D7E5FE47D9D37E6), 2);
			}
		}

		// Token: 0x06002C35 RID: 11317 RVA: 0x0008C95C File Offset: 0x0008AB5C
		public override int GetMaxByteCount(int charCount)
		{
			ArgumentOutOfRangeException.ThrowIfNegative<int>(charCount, "charCount");
			long num = (long)charCount + 1L;
			if (base.EncoderFallback.MaxCharCount > 1)
			{
				num *= (long)base.EncoderFallback.MaxCharCount;
			}
			num <<= 1;
			if (num > 2147483647L)
			{
				throw new ArgumentOutOfRangeException("charCount", SR.ArgumentOutOfRange_GetByteCountOverflow);
			}
			return (int)num;
		}

		// Token: 0x06002C36 RID: 11318 RVA: 0x0008C9B8 File Offset: 0x0008ABB8
		public override int GetMaxCharCount(int byteCount)
		{
			ArgumentOutOfRangeException.ThrowIfNegative<int>(byteCount, "byteCount");
			long num = (long)(byteCount >> 1) + (long)(byteCount & 1) + 1L;
			if (base.DecoderFallback.MaxCharCount > 1)
			{
				num *= (long)base.DecoderFallback.MaxCharCount;
			}
			if (num > 2147483647L)
			{
				throw new ArgumentOutOfRangeException("byteCount", SR.ArgumentOutOfRange_GetCharCountOverflow);
			}
			return (int)num;
		}

		// Token: 0x06002C37 RID: 11319 RVA: 0x0008CA18 File Offset: 0x0008AC18
		[NullableContext(2)]
		public override bool Equals([NotNullWhen(true)] object value)
		{
			UnicodeEncoding unicodeEncoding = value as UnicodeEncoding;
			return unicodeEncoding != null && (this.CodePage == unicodeEncoding.CodePage && this.byteOrderMark == unicodeEncoding.byteOrderMark && this.bigEndian == unicodeEncoding.bigEndian && base.EncoderFallback.Equals(unicodeEncoding.EncoderFallback)) && base.DecoderFallback.Equals(unicodeEncoding.DecoderFallback);
		}

		// Token: 0x06002C38 RID: 11320 RVA: 0x0008CA81 File Offset: 0x0008AC81
		public override int GetHashCode()
		{
			return this.CodePage + base.EncoderFallback.GetHashCode() + base.DecoderFallback.GetHashCode() + (this.byteOrderMark ? 4 : 0) + (this.bigEndian ? 8 : 0);
		}

		// Token: 0x040007D0 RID: 2000
		internal static readonly UnicodeEncoding s_bigEndianDefault = new UnicodeEncoding(true, true);

		// Token: 0x040007D1 RID: 2001
		internal static readonly UnicodeEncoding s_littleEndianDefault = new UnicodeEncoding(false, true);

		// Token: 0x040007D2 RID: 2002
		private readonly bool isThrowException;

		// Token: 0x040007D3 RID: 2003
		private readonly bool bigEndian;

		// Token: 0x040007D4 RID: 2004
		private readonly bool byteOrderMark;

		// Token: 0x040007D5 RID: 2005
		public const int CharSize = 2;

		// Token: 0x02000242 RID: 578
		private sealed class Decoder : DecoderNLS
		{
			// Token: 0x06002C3A RID: 11322 RVA: 0x0008CAD5 File Offset: 0x0008ACD5
			public Decoder(UnicodeEncoding encoding) : base(encoding)
			{
			}

			// Token: 0x06002C3B RID: 11323 RVA: 0x0008CAE5 File Offset: 0x0008ACE5
			public override void Reset()
			{
				this.lastByte = -1;
				this.lastChar = '\0';
				DecoderFallbackBuffer fallbackBuffer = this._fallbackBuffer;
				if (fallbackBuffer == null)
				{
					return;
				}
				fallbackBuffer.Reset();
			}

			// Token: 0x170008A4 RID: 2212
			// (get) Token: 0x06002C3C RID: 11324 RVA: 0x0008CB05 File Offset: 0x0008AD05
			internal override bool HasState
			{
				get
				{
					return this.lastByte != -1 || this.lastChar > '\0';
				}
			}

			// Token: 0x040007D6 RID: 2006
			internal int lastByte = -1;

			// Token: 0x040007D7 RID: 2007
			internal char lastChar;
		}
	}
}
