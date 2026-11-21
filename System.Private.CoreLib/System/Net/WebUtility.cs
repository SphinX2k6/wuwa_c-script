using System;
using System.Buffers;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace System.Net
{
	// Token: 0x020002BD RID: 701
	[NullableContext(2)]
	[Nullable(0)]
	public static class WebUtility
	{
		// Token: 0x06003386 RID: 13190 RVA: 0x000A3A4C File Offset: 0x000A1C4C
		[return: NotNullIfNotNull("value")]
		public unsafe static string HtmlEncode(string value)
		{
			ReadOnlySpan<char> input = value.AsSpan();
			int num = WebUtility.IndexOfHtmlEncodingChar(input);
			if (num < 0)
			{
				return value;
			}
			ValueStringBuilder valueStringBuilder;
			if (input.Length < 80)
			{
				Span<char> initialBuffer = new Span<char>(stackalloc byte[(UIntPtr)512], 256);
				valueStringBuilder = new ValueStringBuilder(initialBuffer);
			}
			else
			{
				valueStringBuilder = new ValueStringBuilder(input.Length + 200);
			}
			ValueStringBuilder valueStringBuilder2 = valueStringBuilder;
			valueStringBuilder2.Append(input.Slice(0, num));
			WebUtility.HtmlEncode(input.Slice(num), ref valueStringBuilder2);
			return valueStringBuilder2.ToString();
		}

		// Token: 0x06003387 RID: 13191 RVA: 0x000A3ADC File Offset: 0x000A1CDC
		[NullableContext(1)]
		public unsafe static void HtmlEncode([Nullable(2)] string value, TextWriter output)
		{
			ArgumentNullException.ThrowIfNull(output, "output");
			ReadOnlySpan<char> input = value.AsSpan();
			int num = WebUtility.IndexOfHtmlEncodingChar(input);
			if (num < 0)
			{
				output.Write(value);
				return;
			}
			ValueStringBuilder valueStringBuilder;
			if (input.Length < 80)
			{
				Span<char> initialBuffer = new Span<char>(stackalloc byte[(UIntPtr)512], 256);
				valueStringBuilder = new ValueStringBuilder(initialBuffer);
			}
			else
			{
				valueStringBuilder = new ValueStringBuilder(input.Length + 200);
			}
			ValueStringBuilder valueStringBuilder2 = valueStringBuilder;
			valueStringBuilder2.Append(input.Slice(0, num));
			WebUtility.HtmlEncode(input.Slice(num), ref valueStringBuilder2);
			output.Write(valueStringBuilder2.AsSpan());
			valueStringBuilder2.Dispose();
		}

		// Token: 0x06003388 RID: 13192 RVA: 0x000A3B84 File Offset: 0x000A1D84
		private unsafe static void HtmlEncode(ReadOnlySpan<char> input, ref ValueStringBuilder output)
		{
			for (int i = 0; i < input.Length; i++)
			{
				char c = (char)(*input[i]);
				if (c <= '>')
				{
					if (c <= '&')
					{
						if (c == '"')
						{
							output.Append("&quot;");
							goto IL_13C;
						}
						if (c == '&')
						{
							output.Append("&amp;");
							goto IL_13C;
						}
					}
					else
					{
						if (c == '\'')
						{
							output.Append("&#39;");
							goto IL_13C;
						}
						if (c == '<')
						{
							output.Append("&lt;");
							goto IL_13C;
						}
						if (c == '>')
						{
							output.Append("&gt;");
							goto IL_13C;
						}
					}
					output.Append(c);
				}
				else
				{
					int num = -1;
					if (char.IsBetween(c, '\u00a0', 'ÿ'))
					{
						num = (int)c;
					}
					else if (char.IsSurrogate(c))
					{
						Rune rune;
						if (i + 1 < input.Length && Rune.TryCreate(c, (char)(*input[i + 1]), out rune))
						{
							num = rune.Value;
							i++;
						}
						else
						{
							c = '�';
						}
					}
					if (num >= 0)
					{
						output.Append("&#");
						Span<char> destination = output.AppendSpan(10);
						int num2;
						num.TryFormat(destination, out num2, default(ReadOnlySpan<char>), null);
						output.Length -= 10 - num2;
						output.Append(';');
					}
					else
					{
						output.Append(c);
					}
				}
				IL_13C:;
			}
		}

		// Token: 0x06003389 RID: 13193 RVA: 0x000A3CE0 File Offset: 0x000A1EE0
		[return: NotNullIfNotNull("value")]
		public unsafe static string HtmlDecode(string value)
		{
			ReadOnlySpan<char> span = value.AsSpan();
			int num = span.IndexOf('&');
			if (num < 0)
			{
				return value;
			}
			ValueStringBuilder valueStringBuilder;
			if (span.Length <= 256)
			{
				Span<char> initialBuffer = new Span<char>(stackalloc byte[(UIntPtr)512], 256);
				valueStringBuilder = new ValueStringBuilder(initialBuffer);
			}
			else
			{
				valueStringBuilder = new ValueStringBuilder(span.Length);
			}
			ValueStringBuilder valueStringBuilder2 = valueStringBuilder;
			valueStringBuilder2.Append(span.Slice(0, num));
			WebUtility.HtmlDecode(span.Slice(num), ref valueStringBuilder2);
			return valueStringBuilder2.ToString();
		}

		// Token: 0x0600338A RID: 13194 RVA: 0x000A3D6C File Offset: 0x000A1F6C
		[NullableContext(1)]
		public unsafe static void HtmlDecode([Nullable(2)] string value, TextWriter output)
		{
			ArgumentNullException.ThrowIfNull(output, "output");
			ReadOnlySpan<char> span = value.AsSpan();
			int num = span.IndexOf('&');
			if (num < 0)
			{
				output.Write(value);
				return;
			}
			ValueStringBuilder valueStringBuilder;
			if (span.Length <= 256)
			{
				Span<char> initialBuffer = new Span<char>(stackalloc byte[(UIntPtr)512], 256);
				valueStringBuilder = new ValueStringBuilder(initialBuffer);
			}
			else
			{
				valueStringBuilder = new ValueStringBuilder(span.Length);
			}
			ValueStringBuilder valueStringBuilder2 = valueStringBuilder;
			valueStringBuilder2.Append(span.Slice(0, num));
			WebUtility.HtmlDecode(span.Slice(num), ref valueStringBuilder2);
			output.Write(valueStringBuilder2.AsSpan());
			valueStringBuilder2.Dispose();
		}

		// Token: 0x0600338B RID: 13195 RVA: 0x000A3E10 File Offset: 0x000A2010
		private unsafe static void HtmlDecode(ReadOnlySpan<char> input, ref ValueStringBuilder output)
		{
			int i = 0;
			while (i < input.Length)
			{
				char c = (char)(*input[i]);
				if (c != '&')
				{
					goto IL_12D;
				}
				ReadOnlySpan<char> span = input.Slice(i + 1);
				int num = span.IndexOfAny(';', '&');
				if (num < 0 || *span[num] != 59)
				{
					goto IL_12D;
				}
				int num2 = i + 1 + num;
				if (num > 1 && *span[0] == 35)
				{
					uint num3;
					if (!((*span[1] == 120 || *span[1] == 88) ? uint.TryParse(span.Slice(2, num - 2), NumberStyles.AllowHexSpecifier, CultureInfo.InvariantCulture, out num3) : uint.TryParse(span.Slice(1, num - 1), NumberStyles.Integer, CultureInfo.InvariantCulture, out num3)) || !UnicodeUtility.IsValidUnicodeScalar(num3))
					{
						goto IL_12D;
					}
					if (UnicodeUtility.IsBmpCodePoint(num3))
					{
						output.Append((char)num3);
					}
					else
					{
						char c2;
						char c3;
						UnicodeUtility.GetUtf16SurrogatesFromSupplementaryPlaneScalar(num3, out c2, out c3);
						output.Append(c2);
						output.Append(c3);
					}
					i = num2;
				}
				else
				{
					ReadOnlySpan<char> readOnlySpan = span.Slice(0, num);
					i = num2;
					char c4 = WebUtility.HtmlEntities.Lookup(readOnlySpan);
					if (c4 != '\0')
					{
						c = c4;
						goto IL_12D;
					}
					output.Append('&');
					output.Append(readOnlySpan);
					output.Append(';');
				}
				IL_134:
				i++;
				continue;
				IL_12D:
				output.Append(c);
				goto IL_134;
			}
		}

		// Token: 0x0600338C RID: 13196 RVA: 0x000A3F64 File Offset: 0x000A2164
		private unsafe static int IndexOfHtmlEncodingChar(ReadOnlySpan<char> input)
		{
			for (int i = input.IndexOfAnyExcept(WebUtility.s_htmlAsciiNonEncodingChars); i < input.Length; i++)
			{
				char c = (char)(*input[i]);
				if (c <= '>')
				{
					if (c == '<' || c == '>' || c == '"' || c == '\'' || c == '&')
					{
						return i;
					}
				}
				else if (char.IsBetween(c, '\u00a0', 'ÿ') || char.IsSurrogate(c))
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x0600338D RID: 13197 RVA: 0x000A3FD4 File Offset: 0x000A21D4
		[return: NotNullIfNotNull("value")]
		public unsafe static string UrlEncode(string value)
		{
			if (value == null)
			{
				return null;
			}
			int num = 0;
			bool flag = false;
			for (int i = value.AsSpan().IndexOfAnyExcept(WebUtility.s_safeUrlChars); i < value.Length; i++)
			{
				char c = value[i];
				if (!WebUtility.IsUrlSafe(c))
				{
					if (c == ' ')
					{
						flag = true;
					}
					else
					{
						num++;
					}
				}
			}
			if (num != 0)
			{
				int byteCount = Encoding.UTF8.GetByteCount(value);
				int num2 = (byteCount - (value.Length - num)) * 2;
				return string.Create<ValueTuple<string, int>>(byteCount + num2, new ValueTuple<string, int>(value, byteCount), delegate(Span<char> dest, [TupleElementNames(new string[]
				{
					"value",
					"byteCount"
				})] ValueTuple<string, int> state)
				{
					Span<byte> span = MemoryMarshal.AsBytes<char>(dest).Slice(dest.Length * 2 - state.Item2);
					Encoding.UTF8.GetBytes(state.Item1, span);
					int num3 = 0;
					Span<byte> span2 = span;
					for (int j = 0; j < span2.Length; j++)
					{
						byte b = *span2[j];
						char c2 = (char)b;
						if (WebUtility.IsUrlSafe(c2))
						{
							*dest[num3++] = c2;
						}
						else if (c2 == ' ')
						{
							*dest[num3++] = '+';
						}
						else
						{
							*dest[num3++] = '%';
							*dest[num3++] = HexConverter.ToCharUpper(b >> 4);
							*dest[num3++] = HexConverter.ToCharUpper((int)b);
						}
					}
				});
			}
			if (!flag)
			{
				return value;
			}
			return value.Replace(' ', '+');
		}

		// Token: 0x0600338E RID: 13198 RVA: 0x000A408C File Offset: 0x000A228C
		[return: NotNullIfNotNull("value")]
		public unsafe static byte[] UrlEncodeToBytes(byte[] value, int offset, int count)
		{
			if (!WebUtility.ValidateUrlEncodingParameters(value, offset, count))
			{
				return null;
			}
			ReadOnlySpan<byte> readOnlySpan = value.AsSpan(offset, count);
			int num = 0;
			bool flag = false;
			for (int i = readOnlySpan.IndexOfAnyExcept(WebUtility.s_safeUrlBytes); i < readOnlySpan.Length; i++)
			{
				byte b = *readOnlySpan[i];
				if (!WebUtility.IsUrlSafe(b))
				{
					if (b == 32)
					{
						flag = true;
					}
					else
					{
						num++;
					}
				}
			}
			byte[] array;
			if (num == 0)
			{
				array = readOnlySpan.ToArray();
				if (flag)
				{
					array.AsSpan<byte>().Replace(32, 43);
				}
				return array;
			}
			int num2 = 0;
			array = new byte[count + num * 2];
			ReadOnlySpan<byte> readOnlySpan2 = readOnlySpan;
			for (int j = 0; j < readOnlySpan2.Length; j++)
			{
				byte b2 = *readOnlySpan2[j];
				if (WebUtility.IsUrlSafe(b2))
				{
					array[num2++] = b2;
				}
				else if (b2 == 32)
				{
					array[num2++] = 43;
				}
				else
				{
					array[num2++] = 37;
					array[num2++] = (byte)HexConverter.ToCharUpper(b2 >> 4);
					array[num2++] = (byte)HexConverter.ToCharUpper((int)b2);
				}
			}
			return array;
		}

		// Token: 0x0600338F RID: 13199 RVA: 0x000A41A8 File Offset: 0x000A23A8
		[return: NotNullIfNotNull("value")]
		private static string UrlDecodeInternal(string value, Encoding encoding)
		{
			if (string.IsNullOrEmpty(value))
			{
				return value;
			}
			int length = value.Length;
			WebUtility.UrlDecoder urlDecoder = new WebUtility.UrlDecoder(length, encoding);
			bool flag = false;
			bool flag2 = false;
			int i = 0;
			while (i < length)
			{
				char c = value[i];
				if (c == '+')
				{
					flag2 = true;
					c = ' ';
					goto IL_96;
				}
				if (c != '%' || i >= length - 2)
				{
					goto IL_96;
				}
				int num = HexConverter.FromChar((int)value[i + 1]);
				int num2 = HexConverter.FromChar((int)value[i + 2]);
				if ((num | num2) == 255)
				{
					goto IL_96;
				}
				byte b = (byte)(num << 4 | num2);
				i += 2;
				urlDecoder.AddByte(b);
				flag = true;
				IL_B5:
				i++;
				continue;
				IL_96:
				if ((c & 'ﾀ') == '\0')
				{
					urlDecoder.AddByte((byte)c);
					goto IL_B5;
				}
				urlDecoder.AddChar(c);
				goto IL_B5;
			}
			if (flag)
			{
				return urlDecoder.GetString();
			}
			if (flag2)
			{
				return value.Replace('+', ' ');
			}
			return value;
		}

		// Token: 0x06003390 RID: 13200 RVA: 0x000A4294 File Offset: 0x000A2494
		[return: NotNullIfNotNull("bytes")]
		private static byte[] UrlDecodeInternal(byte[] bytes, int offset, int count)
		{
			if (!WebUtility.ValidateUrlEncodingParameters(bytes, offset, count))
			{
				return null;
			}
			int num = 0;
			byte[] array = new byte[count];
			for (int i = 0; i < count; i++)
			{
				int num2 = offset + i;
				byte b = bytes[num2];
				if (b == 43)
				{
					b = 32;
				}
				else if (b == 37 && i < count - 2)
				{
					int num3 = HexConverter.FromChar((int)bytes[num2 + 1]);
					int num4 = HexConverter.FromChar((int)bytes[num2 + 2]);
					if ((num3 | num4) != 255)
					{
						b = (byte)(num3 << 4 | num4);
						i += 2;
					}
				}
				array[num++] = b;
			}
			if (num < array.Length)
			{
				Array.Resize<byte>(ref array, num);
			}
			return array;
		}

		// Token: 0x06003391 RID: 13201 RVA: 0x000A432D File Offset: 0x000A252D
		[return: NotNullIfNotNull("encodedValue")]
		public static string UrlDecode(string encodedValue)
		{
			return WebUtility.UrlDecodeInternal(encodedValue, Encoding.UTF8);
		}

		// Token: 0x06003392 RID: 13202 RVA: 0x000A433A File Offset: 0x000A253A
		[return: NotNullIfNotNull("encodedValue")]
		public static byte[] UrlDecodeToBytes(byte[] encodedValue, int offset, int count)
		{
			return WebUtility.UrlDecodeInternal(encodedValue, offset, count);
		}

		// Token: 0x06003393 RID: 13203 RVA: 0x000A4344 File Offset: 0x000A2544
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool IsUrlSafe(char ch)
		{
			return WebUtility.s_safeUrlChars.Contains(ch);
		}

		// Token: 0x06003394 RID: 13204 RVA: 0x000A4351 File Offset: 0x000A2551
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool IsUrlSafe(byte ch)
		{
			return WebUtility.s_safeUrlBytes.Contains(ch);
		}

		// Token: 0x06003395 RID: 13205 RVA: 0x000A4360 File Offset: 0x000A2560
		private static bool ValidateUrlEncodingParameters(byte[] bytes, int offset, int count)
		{
			if (bytes == null && count == 0)
			{
				return false;
			}
			ArgumentNullException.ThrowIfNull(bytes, "bytes");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(offset, "offset");
			ArgumentOutOfRangeException.ThrowIfGreaterThan<int>(offset, bytes.Length, "offset");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(count, "count");
			ArgumentOutOfRangeException.ThrowIfGreaterThan<int>(count, bytes.Length - offset, "count");
			return true;
		}

		// Token: 0x040008F5 RID: 2293
		private static readonly SearchValues<char> s_htmlAsciiNonEncodingChars = SearchValues.Create("\0\u0001\u0002\u0003\u0004\u0005\u0006\a\b\t\n\v\f\r\u000e\u000f\u0010\u0011\u0012\u0013\u0014\u0015\u0016\u0017\u0018\u0019\u001a\u001b\u001c\u001d\u001e\u001f !#$%()*+,-./0123456789:;=?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_`abcdefghijklmnopqrstuvwxyz{|}~\u007f");

		// Token: 0x040008F6 RID: 2294
		private static readonly SearchValues<char> s_safeUrlChars = SearchValues.Create("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-_.!*()");

		// Token: 0x040008F7 RID: 2295
		private static readonly SearchValues<byte> s_safeUrlBytes = SearchValues.Create(new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.48CF27E7B6F3E5873CE22F10D7308072661B0E0500AEB9AB62664F7BF40CD71E), 69));

		// Token: 0x020002BE RID: 702
		private struct UrlDecoder
		{
			// Token: 0x06003397 RID: 13207 RVA: 0x000A43F8 File Offset: 0x000A25F8
			private void FlushBytes()
			{
				if (this._charBuffer == null)
				{
					this._charBuffer = new char[this._bufferSize];
				}
				this._numChars += this._encoding.GetChars(this._byteBuffer, 0, this._numBytes, this._charBuffer, this._numChars);
				this._numBytes = 0;
			}

			// Token: 0x06003398 RID: 13208 RVA: 0x000A4456 File Offset: 0x000A2656
			internal UrlDecoder(int bufferSize, Encoding encoding)
			{
				this._bufferSize = bufferSize;
				this._encoding = encoding;
				this._charBuffer = null;
				this._numChars = 0;
				this._numBytes = 0;
				this._byteBuffer = null;
			}

			// Token: 0x06003399 RID: 13209 RVA: 0x000A4484 File Offset: 0x000A2684
			internal void AddChar(char ch)
			{
				if (this._numBytes > 0)
				{
					this.FlushBytes();
				}
				if (this._charBuffer == null)
				{
					this._charBuffer = new char[this._bufferSize];
				}
				char[] charBuffer = this._charBuffer;
				int numChars = this._numChars;
				this._numChars = numChars + 1;
				charBuffer[numChars] = ch;
			}

			// Token: 0x0600339A RID: 13210 RVA: 0x000A44D4 File Offset: 0x000A26D4
			internal void AddByte(byte b)
			{
				if (this._byteBuffer == null)
				{
					this._byteBuffer = new byte[this._bufferSize];
				}
				byte[] byteBuffer = this._byteBuffer;
				int numBytes = this._numBytes;
				this._numBytes = numBytes + 1;
				byteBuffer[numBytes] = b;
			}

			// Token: 0x0600339B RID: 13211 RVA: 0x000A4513 File Offset: 0x000A2713
			internal string GetString()
			{
				if (this._numBytes > 0)
				{
					this.FlushBytes();
				}
				return new string(this._charBuffer, 0, this._numChars);
			}

			// Token: 0x040008F8 RID: 2296
			private readonly int _bufferSize;

			// Token: 0x040008F9 RID: 2297
			private int _numChars;

			// Token: 0x040008FA RID: 2298
			private char[] _charBuffer;

			// Token: 0x040008FB RID: 2299
			private int _numBytes;

			// Token: 0x040008FC RID: 2300
			private byte[] _byteBuffer;

			// Token: 0x040008FD RID: 2301
			private readonly Encoding _encoding;
		}

		// Token: 0x020002BF RID: 703
		private static class HtmlEntities
		{
			// Token: 0x0600339C RID: 13212 RVA: 0x000A4538 File Offset: 0x000A2738
			private unsafe static Dictionary<ulong, char> InitializeLookupTable()
			{
				ReadOnlySpan<byte> source = new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.FC11181D54518B4070498BC8F6F4D626A4B6185740F39701CB73177AF6C09F3E), 2530);
				Dictionary<ulong, char> dictionary = new Dictionary<ulong, char>(source.Length / 10);
				while (!source.IsEmpty)
				{
					ulong key = BinaryPrimitives.ReadUInt64LittleEndian(source);
					char value = (char)BinaryPrimitives.ReadUInt16LittleEndian(source.Slice(8));
					dictionary[key] = value;
					source = source.Slice(10);
				}
				return dictionary;
			}

			// Token: 0x0600339D RID: 13213 RVA: 0x000A459C File Offset: 0x000A279C
			public static char Lookup(ReadOnlySpan<char> entity)
			{
				if (entity.Length <= 8)
				{
					char result;
					WebUtility.HtmlEntities.s_lookupTable.TryGetValue(WebUtility.HtmlEntities.ToUInt64Key(entity), out result);
					return result;
				}
				return '\0';
			}

			// Token: 0x0600339E RID: 13214 RVA: 0x000A45CC File Offset: 0x000A27CC
			private unsafe static ulong ToUInt64Key(ReadOnlySpan<char> entity)
			{
				ulong num = 0UL;
				for (int i = 0; i < entity.Length; i++)
				{
					if (*entity[i] > 255)
					{
						return 0UL;
					}
					num = (num << 8 | (ulong)(*entity[i]));
				}
				return num;
			}

			// Token: 0x040008FE RID: 2302
			private static readonly Dictionary<ulong, char> s_lookupTable = WebUtility.HtmlEntities.InitializeLookupTable();
		}
	}
}
