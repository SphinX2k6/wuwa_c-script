using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Text
{
	// Token: 0x02000246 RID: 582
	[NullableContext(1)]
	[Nullable(0)]
	public class UTF7Encoding : Encoding
	{
		// Token: 0x06002C6C RID: 11372 RVA: 0x0008DB17 File Offset: 0x0008BD17
		[Obsolete("The UTF-7 encoding is insecure and should not be used. Consider using UTF-8 instead.", DiagnosticId = "SYSLIB0001", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		public UTF7Encoding() : this(false)
		{
		}

		// Token: 0x06002C6D RID: 11373 RVA: 0x0008DB20 File Offset: 0x0008BD20
		[Obsolete("The UTF-7 encoding is insecure and should not be used. Consider using UTF-8 instead.", DiagnosticId = "SYSLIB0001", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		public UTF7Encoding(bool allowOptionals) : base(65000)
		{
			this._allowOptionals = allowOptionals;
			this.MakeTables();
		}

		// Token: 0x06002C6E RID: 11374 RVA: 0x0008DB3C File Offset: 0x0008BD3C
		[MemberNotNull("_base64Bytes")]
		[MemberNotNull("_base64Values")]
		[MemberNotNull("_directEncode")]
		private unsafe void MakeTables()
		{
			this._base64Bytes = new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.B549D027496B9C80494809966F74EBF09C8A21512D7F2152230A26AC65016653), 64).ToArray();
			this._base64Values = new sbyte[128];
			for (int i = 0; i < 128; i++)
			{
				this._base64Values[i] = -1;
			}
			for (int j = 0; j < 64; j++)
			{
				this._base64Values[(int)this._base64Bytes[j]] = (sbyte)j;
			}
			ReadOnlySpan<byte> readOnlySpan = new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.161FF9315F900FC9578ADAFA5B618B430781B780CEE9E2FDBDFDAAE40427AE83), 75);
			this._directEncode = new bool[128];
			ReadOnlySpan<byte> readOnlySpan2 = readOnlySpan;
			for (int k = 0; k < readOnlySpan2.Length; k++)
			{
				byte b = *readOnlySpan2[k];
				this._directEncode[(int)b] = true;
			}
			if (this._allowOptionals)
			{
				readOnlySpan2 = new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.33A6AF701A72C1AF7122253086021A7AADD4A7FABE398D50109F51ADC1BE0A08), 20);
				for (int k = 0; k < readOnlySpan2.Length; k++)
				{
					byte b2 = *readOnlySpan2[k];
					this._directEncode[(int)b2] = true;
				}
			}
		}

		// Token: 0x06002C6F RID: 11375 RVA: 0x0008DC2A File Offset: 0x0008BE2A
		internal sealed override void SetDefaultFallbacks()
		{
			this.encoderFallback = new EncoderReplacementFallback(string.Empty);
			this.decoderFallback = new UTF7Encoding.DecoderUTF7Fallback();
		}

		// Token: 0x06002C70 RID: 11376 RVA: 0x0008DC48 File Offset: 0x0008BE48
		[NullableContext(2)]
		public override bool Equals([NotNullWhen(true)] object value)
		{
			UTF7Encoding utf7Encoding = value as UTF7Encoding;
			return utf7Encoding != null && (this._allowOptionals == utf7Encoding._allowOptionals && base.EncoderFallback.Equals(utf7Encoding.EncoderFallback)) && base.DecoderFallback.Equals(utf7Encoding.DecoderFallback);
		}

		// Token: 0x06002C71 RID: 11377 RVA: 0x0008DC95 File Offset: 0x0008BE95
		public override int GetHashCode()
		{
			return this.CodePage + base.EncoderFallback.GetHashCode() + base.DecoderFallback.GetHashCode();
		}

		// Token: 0x06002C72 RID: 11378 RVA: 0x0008DCB8 File Offset: 0x0008BEB8
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

		// Token: 0x06002C73 RID: 11379 RVA: 0x0008DD2C File Offset: 0x0008BF2C
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

		// Token: 0x06002C74 RID: 11380 RVA: 0x0008B4AE File Offset: 0x000896AE
		[NullableContext(0)]
		[CLSCompliant(false)]
		public unsafe override int GetByteCount(char* chars, int count)
		{
			ArgumentNullException.ThrowIfNull((void*)chars, "chars");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(count, "count");
			return this.GetByteCount(chars, count, null);
		}

		// Token: 0x06002C75 RID: 11381 RVA: 0x0008DD64 File Offset: 0x0008BF64
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

		// Token: 0x06002C76 RID: 11382 RVA: 0x0008DE10 File Offset: 0x0008C010
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

		// Token: 0x06002C77 RID: 11383 RVA: 0x0008B630 File Offset: 0x00089830
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

		// Token: 0x06002C78 RID: 11384 RVA: 0x0008DEC4 File Offset: 0x0008C0C4
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

		// Token: 0x06002C79 RID: 11385 RVA: 0x0008B6DA File Offset: 0x000898DA
		[NullableContext(0)]
		[CLSCompliant(false)]
		public unsafe override int GetCharCount(byte* bytes, int count)
		{
			ArgumentNullException.ThrowIfNull((void*)bytes, "bytes");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(count, "count");
			return this.GetCharCount(bytes, count, null);
		}

		// Token: 0x06002C7A RID: 11386 RVA: 0x0008DF34 File Offset: 0x0008C134
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

		// Token: 0x06002C7B RID: 11387 RVA: 0x0008B7B0 File Offset: 0x000899B0
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

		// Token: 0x06002C7C RID: 11388 RVA: 0x0008DFE8 File Offset: 0x0008C1E8
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

		// Token: 0x06002C7D RID: 11389 RVA: 0x0008E059 File Offset: 0x0008C259
		internal unsafe sealed override int GetByteCount(char* chars, int count, EncoderNLS baseEncoder)
		{
			return this.GetBytes(chars, count, null, 0, baseEncoder);
		}

		// Token: 0x06002C7E RID: 11390 RVA: 0x0008E068 File Offset: 0x0008C268
		internal unsafe sealed override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS baseEncoder)
		{
			UTF7Encoding.Encoder encoder = (UTF7Encoding.Encoder)baseEncoder;
			int num = 0;
			int i = -1;
			Encoding.EncodingByteBuffer encodingByteBuffer = new Encoding.EncodingByteBuffer(this, encoder, bytes, byteCount, chars, charCount);
			if (encoder != null)
			{
				num = encoder.bits;
				i = encoder.bitCount;
				while (i >= 6)
				{
					i -= 6;
					if (!encodingByteBuffer.AddByte(this._base64Bytes[num >> i & 63]))
					{
						base.ThrowBytesOverflow(encoder, encodingByteBuffer.Count == 0);
					}
				}
			}
			while (encodingByteBuffer.MoreData)
			{
				char nextChar = encodingByteBuffer.GetNextChar();
				if (nextChar < '\u0080' && this._directEncode[(int)nextChar])
				{
					if (i >= 0)
					{
						if (i > 0)
						{
							if (!encodingByteBuffer.AddByte(this._base64Bytes[num << 6 - i & 63]))
							{
								break;
							}
							i = 0;
						}
						if (!encodingByteBuffer.AddByte(45))
						{
							break;
						}
						i = -1;
					}
					if (!encodingByteBuffer.AddByte((byte)nextChar))
					{
						break;
					}
				}
				else if (i < 0 && nextChar == '+')
				{
					if (!encodingByteBuffer.AddByte(43, 45))
					{
						break;
					}
				}
				else
				{
					if (i < 0)
					{
						if (!encodingByteBuffer.AddByte(43))
						{
							break;
						}
						i = 0;
					}
					num = (num << 16 | (int)nextChar);
					i += 16;
					while (i >= 6)
					{
						i -= 6;
						if (!encodingByteBuffer.AddByte(this._base64Bytes[num >> i & 63]))
						{
							i += 6;
							encodingByteBuffer.GetNextChar();
							break;
						}
					}
					if (i >= 6)
					{
						break;
					}
				}
			}
			if (i >= 0 && (encoder == null || encoder.MustFlush))
			{
				if (i > 0 && encodingByteBuffer.AddByte(this._base64Bytes[num << 6 - i & 63]))
				{
					i = 0;
				}
				if (encodingByteBuffer.AddByte(45))
				{
					num = 0;
					i = -1;
				}
				else
				{
					encodingByteBuffer.GetNextChar();
				}
			}
			if (bytes != null && encoder != null)
			{
				encoder.bits = num;
				encoder.bitCount = i;
				encoder._charsUsed = encodingByteBuffer.CharsUsed;
			}
			return encodingByteBuffer.Count;
		}

		// Token: 0x06002C7F RID: 11391 RVA: 0x0008E219 File Offset: 0x0008C419
		internal unsafe sealed override int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder)
		{
			return this.GetChars(bytes, count, null, 0, baseDecoder);
		}

		// Token: 0x06002C80 RID: 11392 RVA: 0x0008E228 File Offset: 0x0008C428
		internal unsafe sealed override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS baseDecoder)
		{
			UTF7Encoding.Decoder decoder = (UTF7Encoding.Decoder)baseDecoder;
			Encoding.EncodingCharBuffer encodingCharBuffer = new Encoding.EncodingCharBuffer(this, decoder, chars, charCount, bytes, byteCount);
			int num = 0;
			int num2 = -1;
			bool flag = false;
			if (decoder != null)
			{
				num = decoder.bits;
				num2 = decoder.bitCount;
				flag = decoder.firstByte;
			}
			if (num2 >= 16)
			{
				if (!encodingCharBuffer.AddChar((char)(num >> num2 - 16 & 65535)))
				{
					base.ThrowCharsOverflow(decoder, true);
				}
				num2 -= 16;
			}
			while (encodingCharBuffer.MoreData)
			{
				byte nextByte = encodingCharBuffer.GetNextByte();
				int num3;
				if (num2 >= 0)
				{
					sbyte b;
					if (nextByte < 128 && (b = this._base64Values[(int)nextByte]) >= 0)
					{
						flag = false;
						num = (num << 6 | (int)((byte)b));
						num2 += 6;
						if (num2 < 16)
						{
							continue;
						}
						num3 = (num >> num2 - 16 & 65535);
						num2 -= 16;
					}
					else
					{
						num2 = -1;
						if (nextByte != 45)
						{
							if (!encodingCharBuffer.Fallback(nextByte))
							{
								break;
							}
							continue;
						}
						else
						{
							if (!flag)
							{
								continue;
							}
							num3 = 43;
						}
					}
				}
				else
				{
					if (nextByte == 43)
					{
						num2 = 0;
						flag = true;
						continue;
					}
					if (nextByte >= 128)
					{
						if (!encodingCharBuffer.Fallback(nextByte))
						{
							break;
						}
						continue;
					}
					else
					{
						num3 = (int)nextByte;
					}
				}
				if (num3 >= 0 && !encodingCharBuffer.AddChar((char)num3))
				{
					if (num2 >= 0)
					{
						encodingCharBuffer.AdjustBytes(1);
						num2 += 16;
						break;
					}
					break;
				}
			}
			if (chars != null && decoder != null)
			{
				if (decoder.MustFlush)
				{
					decoder.bits = 0;
					decoder.bitCount = -1;
					decoder.firstByte = false;
				}
				else
				{
					decoder.bits = num;
					decoder.bitCount = num2;
					decoder.firstByte = flag;
				}
				decoder._bytesUsed = encodingCharBuffer.BytesUsed;
			}
			return encodingCharBuffer.Count;
		}

		// Token: 0x06002C81 RID: 11393 RVA: 0x0008E3AC File Offset: 0x0008C5AC
		public override System.Text.Decoder GetDecoder()
		{
			return new UTF7Encoding.Decoder(this);
		}

		// Token: 0x06002C82 RID: 11394 RVA: 0x0008E3B4 File Offset: 0x0008C5B4
		public override System.Text.Encoder GetEncoder()
		{
			return new UTF7Encoding.Encoder(this);
		}

		// Token: 0x06002C83 RID: 11395 RVA: 0x0008E3BC File Offset: 0x0008C5BC
		public override int GetMaxByteCount(int charCount)
		{
			ArgumentOutOfRangeException.ThrowIfNegative<int>(charCount, "charCount");
			long num = (long)charCount * 3L + 2L;
			if (num > 2147483647L)
			{
				throw new ArgumentOutOfRangeException("charCount", SR.ArgumentOutOfRange_GetByteCountOverflow);
			}
			return (int)num;
		}

		// Token: 0x06002C84 RID: 11396 RVA: 0x0008E3EC File Offset: 0x0008C5EC
		public override int GetMaxCharCount(int byteCount)
		{
			ArgumentOutOfRangeException.ThrowIfNegative<int>(byteCount, "byteCount");
			int num = byteCount;
			if (num == 0)
			{
				num = 1;
			}
			return num;
		}

		// Token: 0x040007DF RID: 2015
		internal static readonly UTF7Encoding s_default = new UTF7Encoding();

		// Token: 0x040007E0 RID: 2016
		private byte[] _base64Bytes;

		// Token: 0x040007E1 RID: 2017
		private sbyte[] _base64Values;

		// Token: 0x040007E2 RID: 2018
		private bool[] _directEncode;

		// Token: 0x040007E3 RID: 2019
		private readonly bool _allowOptionals;

		// Token: 0x02000247 RID: 583
		private sealed class Decoder : DecoderNLS
		{
			// Token: 0x06002C86 RID: 11398 RVA: 0x0008DAE3 File Offset: 0x0008BCE3
			public Decoder(UTF7Encoding encoding) : base(encoding)
			{
			}

			// Token: 0x06002C87 RID: 11399 RVA: 0x0008E418 File Offset: 0x0008C618
			public override void Reset()
			{
				this.bits = 0;
				this.bitCount = -1;
				this.firstByte = false;
				DecoderFallbackBuffer fallbackBuffer = this._fallbackBuffer;
				if (fallbackBuffer == null)
				{
					return;
				}
				fallbackBuffer.Reset();
			}

			// Token: 0x170008A7 RID: 2215
			// (get) Token: 0x06002C88 RID: 11400 RVA: 0x0008E43F File Offset: 0x0008C63F
			internal override bool HasState
			{
				get
				{
					return this.bitCount != -1;
				}
			}

			// Token: 0x040007E4 RID: 2020
			internal int bits;

			// Token: 0x040007E5 RID: 2021
			internal int bitCount;

			// Token: 0x040007E6 RID: 2022
			internal bool firstByte;
		}

		// Token: 0x02000248 RID: 584
		private sealed class Encoder : EncoderNLS
		{
			// Token: 0x06002C89 RID: 11401 RVA: 0x0008E44D File Offset: 0x0008C64D
			public Encoder(UTF7Encoding encoding) : base(encoding)
			{
			}

			// Token: 0x06002C8A RID: 11402 RVA: 0x0008E456 File Offset: 0x0008C656
			public override void Reset()
			{
				this.bitCount = -1;
				this.bits = 0;
				EncoderFallbackBuffer fallbackBuffer = this._fallbackBuffer;
				if (fallbackBuffer == null)
				{
					return;
				}
				fallbackBuffer.Reset();
			}

			// Token: 0x170008A8 RID: 2216
			// (get) Token: 0x06002C8B RID: 11403 RVA: 0x0008E476 File Offset: 0x0008C676
			internal override bool HasState
			{
				get
				{
					return this.bits != 0 || this.bitCount != -1;
				}
			}

			// Token: 0x040007E7 RID: 2023
			internal int bits;

			// Token: 0x040007E8 RID: 2024
			internal int bitCount;
		}

		// Token: 0x02000249 RID: 585
		private sealed class DecoderUTF7Fallback : DecoderFallback
		{
			// Token: 0x06002C8C RID: 11404 RVA: 0x0008E48E File Offset: 0x0008C68E
			public override DecoderFallbackBuffer CreateFallbackBuffer()
			{
				return new UTF7Encoding.DecoderUTF7FallbackBuffer();
			}

			// Token: 0x170008A9 RID: 2217
			// (get) Token: 0x06002C8D RID: 11405 RVA: 0x000070DD File Offset: 0x000052DD
			public override int MaxCharCount
			{
				get
				{
					return 1;
				}
			}

			// Token: 0x06002C8E RID: 11406 RVA: 0x0008E495 File Offset: 0x0008C695
			public override bool Equals([NotNullWhen(true)] object value)
			{
				return value is UTF7Encoding.DecoderUTF7Fallback;
			}

			// Token: 0x06002C8F RID: 11407 RVA: 0x0008E4A0 File Offset: 0x0008C6A0
			public override int GetHashCode()
			{
				return 984;
			}
		}

		// Token: 0x0200024A RID: 586
		private sealed class DecoderUTF7FallbackBuffer : DecoderFallbackBuffer
		{
			// Token: 0x06002C91 RID: 11409 RVA: 0x0008E4A8 File Offset: 0x0008C6A8
			public override bool Fallback(byte[] bytesUnknown, int index)
			{
				this.cFallback = (char)bytesUnknown[0];
				if (this.cFallback == '\0')
				{
					return false;
				}
				this.iCount = (this.iSize = 1);
				return true;
			}

			// Token: 0x06002C92 RID: 11410 RVA: 0x0008E4DC File Offset: 0x0008C6DC
			public override char GetNextChar()
			{
				int num = this.iCount;
				this.iCount = num - 1;
				if (num > 0)
				{
					return this.cFallback;
				}
				return '\0';
			}

			// Token: 0x06002C93 RID: 11411 RVA: 0x0008E505 File Offset: 0x0008C705
			public override bool MovePrevious()
			{
				if (this.iCount >= 0)
				{
					this.iCount++;
				}
				return this.iCount >= 0 && this.iCount <= this.iSize;
			}

			// Token: 0x170008AA RID: 2218
			// (get) Token: 0x06002C94 RID: 11412 RVA: 0x0008E53A File Offset: 0x0008C73A
			public override int Remaining
			{
				get
				{
					if (this.iCount <= 0)
					{
						return 0;
					}
					return this.iCount;
				}
			}

			// Token: 0x06002C95 RID: 11413 RVA: 0x0008E54D File Offset: 0x0008C74D
			public override void Reset()
			{
				this.iCount = -1;
				this.byteStart = null;
			}

			// Token: 0x06002C96 RID: 11414 RVA: 0x0008E55E File Offset: 0x0008C75E
			internal unsafe override int InternalFallback(byte[] bytes, byte* pBytes)
			{
				if (bytes.Length != 1)
				{
					throw new ArgumentException(SR.Argument_InvalidCharSequenceNoIndex);
				}
				return (bytes[0] > 0) ? 1 : 0;
			}

			// Token: 0x040007E9 RID: 2025
			private char cFallback;

			// Token: 0x040007EA RID: 2026
			private int iCount = -1;

			// Token: 0x040007EB RID: 2027
			private int iSize;
		}
	}
}
