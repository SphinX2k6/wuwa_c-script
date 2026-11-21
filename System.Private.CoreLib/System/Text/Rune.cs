using System;
using System.Buffers;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text.Unicode;

namespace System.Text
{
	// Token: 0x02000234 RID: 564
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	public readonly struct Rune : IComparable, IComparable<Rune>, IEquatable<Rune>, ISpanFormattable, IFormattable, IUtf8SpanFormattable
	{
		// Token: 0x1700088B RID: 2187
		// (get) Token: 0x06002AFE RID: 11006 RVA: 0x00086D1E File Offset: 0x00084F1E
		private unsafe static ReadOnlySpan<byte> AsciiCharInfo
		{
			get
			{
				return new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.2F3EFC9595514E83DED03093C4F3E3C781A650E1AAB8CA350537CD1A47E1EE8E), 128);
			}
		}

		// Token: 0x06002AFF RID: 11007 RVA: 0x00086D30 File Offset: 0x00084F30
		public Rune(char ch)
		{
			if (UnicodeUtility.IsSurrogateCodePoint((uint)ch))
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.ch);
			}
			this._value = (uint)ch;
		}

		// Token: 0x06002B00 RID: 11008 RVA: 0x00086D55 File Offset: 0x00084F55
		public Rune(char highSurrogate, char lowSurrogate)
		{
			this = new Rune((uint)char.ConvertToUtf32(highSurrogate, lowSurrogate), false);
		}

		// Token: 0x06002B01 RID: 11009 RVA: 0x00086D65 File Offset: 0x00084F65
		public Rune(int value)
		{
			this = new Rune((uint)value);
		}

		// Token: 0x06002B02 RID: 11010 RVA: 0x00086D6E File Offset: 0x00084F6E
		[CLSCompliant(false)]
		public Rune(uint value)
		{
			if (!UnicodeUtility.IsValidUnicodeScalar(value))
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.value);
			}
			this._value = value;
		}

		// Token: 0x06002B03 RID: 11011 RVA: 0x00086D85 File Offset: 0x00084F85
		private Rune(uint scalarValue, bool _)
		{
			this._value = scalarValue;
		}

		// Token: 0x06002B04 RID: 11012 RVA: 0x00086D8E File Offset: 0x00084F8E
		public static bool operator ==(Rune left, Rune right)
		{
			return left._value == right._value;
		}

		// Token: 0x06002B05 RID: 11013 RVA: 0x00086D9E File Offset: 0x00084F9E
		public static bool operator !=(Rune left, Rune right)
		{
			return left._value != right._value;
		}

		// Token: 0x06002B06 RID: 11014 RVA: 0x00086DB1 File Offset: 0x00084FB1
		public static bool operator <(Rune left, Rune right)
		{
			return left._value < right._value;
		}

		// Token: 0x06002B07 RID: 11015 RVA: 0x00086DC1 File Offset: 0x00084FC1
		public static bool operator <=(Rune left, Rune right)
		{
			return left._value <= right._value;
		}

		// Token: 0x06002B08 RID: 11016 RVA: 0x00086DD4 File Offset: 0x00084FD4
		public static bool operator >(Rune left, Rune right)
		{
			return left._value > right._value;
		}

		// Token: 0x06002B09 RID: 11017 RVA: 0x00086DE4 File Offset: 0x00084FE4
		public static bool operator >=(Rune left, Rune right)
		{
			return left._value >= right._value;
		}

		// Token: 0x06002B0A RID: 11018 RVA: 0x00086DF7 File Offset: 0x00084FF7
		public static explicit operator Rune(char ch)
		{
			return new Rune(ch);
		}

		// Token: 0x06002B0B RID: 11019 RVA: 0x00086DFF File Offset: 0x00084FFF
		[CLSCompliant(false)]
		public static explicit operator Rune(uint value)
		{
			return new Rune(value);
		}

		// Token: 0x06002B0C RID: 11020 RVA: 0x00086E07 File Offset: 0x00085007
		public static explicit operator Rune(int value)
		{
			return new Rune(value);
		}

		// Token: 0x1700088C RID: 2188
		// (get) Token: 0x06002B0D RID: 11021 RVA: 0x00086E10 File Offset: 0x00085010
		[Nullable(1)]
		private string DebuggerDisplay
		{
			get
			{
				IFormatProvider invariantCulture = CultureInfo.InvariantCulture;
				IFormatProvider provider = invariantCulture;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 2, invariantCulture);
				defaultInterpolatedStringHandler.AppendLiteral("U+");
				defaultInterpolatedStringHandler.AppendFormatted<uint>(this._value, "X4");
				defaultInterpolatedStringHandler.AppendLiteral(" '");
				defaultInterpolatedStringHandler.AppendFormatted(Rune.IsValid(this._value) ? this.ToString() : "�");
				defaultInterpolatedStringHandler.AppendLiteral("'");
				return string.Create(provider, ref defaultInterpolatedStringHandler);
			}
		}

		// Token: 0x1700088D RID: 2189
		// (get) Token: 0x06002B0E RID: 11022 RVA: 0x00086E92 File Offset: 0x00085092
		public bool IsAscii
		{
			get
			{
				return UnicodeUtility.IsAsciiCodePoint(this._value);
			}
		}

		// Token: 0x1700088E RID: 2190
		// (get) Token: 0x06002B0F RID: 11023 RVA: 0x00086E9F File Offset: 0x0008509F
		public bool IsBmp
		{
			get
			{
				return UnicodeUtility.IsBmpCodePoint(this._value);
			}
		}

		// Token: 0x1700088F RID: 2191
		// (get) Token: 0x06002B10 RID: 11024 RVA: 0x00086EAC File Offset: 0x000850AC
		public int Plane
		{
			get
			{
				return UnicodeUtility.GetPlane(this._value);
			}
		}

		// Token: 0x17000890 RID: 2192
		// (get) Token: 0x06002B11 RID: 11025 RVA: 0x00086EB9 File Offset: 0x000850B9
		public static Rune ReplacementChar
		{
			get
			{
				return Rune.UnsafeCreate(65533U);
			}
		}

		// Token: 0x17000891 RID: 2193
		// (get) Token: 0x06002B12 RID: 11026 RVA: 0x00086EC5 File Offset: 0x000850C5
		public int Utf16SequenceLength
		{
			get
			{
				return UnicodeUtility.GetUtf16SequenceLength(this._value);
			}
		}

		// Token: 0x17000892 RID: 2194
		// (get) Token: 0x06002B13 RID: 11027 RVA: 0x00086ED2 File Offset: 0x000850D2
		public int Utf8SequenceLength
		{
			get
			{
				return UnicodeUtility.GetUtf8SequenceLength(this._value);
			}
		}

		// Token: 0x17000893 RID: 2195
		// (get) Token: 0x06002B14 RID: 11028 RVA: 0x00086EDF File Offset: 0x000850DF
		public int Value
		{
			get
			{
				return (int)this._value;
			}
		}

		// Token: 0x06002B15 RID: 11029 RVA: 0x00086EE8 File Offset: 0x000850E8
		private unsafe static Rune ChangeCaseCultureAware(Rune rune, TextInfo textInfo, bool toUpper)
		{
			Span<char> span = new Span<char>(stackalloc byte[(UIntPtr)4], 2);
			Span<char> destination = new Span<char>(stackalloc byte[(UIntPtr)4], 2);
			int length = rune.EncodeToUtf16(span);
			span = span.Slice(0, length);
			destination = destination.Slice(0, length);
			if (toUpper)
			{
				textInfo.ChangeCaseToUpper(span, destination);
			}
			else
			{
				textInfo.ChangeCaseToLower(span, destination);
			}
			if (rune.IsBmp)
			{
				return Rune.UnsafeCreate((uint)(*destination[0]));
			}
			return Rune.UnsafeCreate(UnicodeUtility.GetScalarFromUtf16SurrogatePair((uint)(*destination[0]), (uint)(*destination[1])));
		}

		// Token: 0x06002B16 RID: 11030 RVA: 0x00086F7B File Offset: 0x0008517B
		public int CompareTo(Rune other)
		{
			return this.Value - other.Value;
		}

		// Token: 0x06002B17 RID: 11031 RVA: 0x00086F8C File Offset: 0x0008518C
		public unsafe static OperationStatus DecodeFromUtf16(ReadOnlySpan<char> source, out Rune result, out int charsConsumed)
		{
			if (!source.IsEmpty)
			{
				char c = (char)(*source[0]);
				if (Rune.TryCreate(c, out result))
				{
					charsConsumed = 1;
					return OperationStatus.Done;
				}
				if (source.Length > 1)
				{
					char lowSurrogate = (char)(*source[1]);
					if (Rune.TryCreate(c, lowSurrogate, out result))
					{
						charsConsumed = 2;
						return OperationStatus.Done;
					}
				}
				else if (char.IsHighSurrogate(c))
				{
					goto IL_4C;
				}
				charsConsumed = 1;
				result = Rune.ReplacementChar;
				return OperationStatus.InvalidData;
			}
			IL_4C:
			charsConsumed = source.Length;
			result = Rune.ReplacementChar;
			return OperationStatus.NeedMoreData;
		}

		// Token: 0x06002B18 RID: 11032 RVA: 0x0008700C File Offset: 0x0008520C
		public unsafe static OperationStatus DecodeFromUtf8(ReadOnlySpan<byte> source, out Rune result, out int bytesConsumed)
		{
			int num = 0;
			if (!source.IsEmpty)
			{
				uint num2 = (uint)(*source[0]);
				if (UnicodeUtility.IsAsciiCodePoint(num2))
				{
					bytesConsumed = 1;
					result = Rune.UnsafeCreate(num2);
					return OperationStatus.Done;
				}
				num = 1;
				if (UnicodeUtility.IsInRangeInclusive(num2, 194U, 244U))
				{
					num2 = num2 - 194U << 6;
					if (source.Length <= 1)
					{
						goto IL_153;
					}
					int num3 = (int)((sbyte)(*source[1]));
					if (num3 < -64)
					{
						num2 += (uint)num3;
						num2 += 128U;
						num2 += 128U;
						if (num2 >= 2048U)
						{
							if (!UnicodeUtility.IsInRangeInclusive(num2, 2080U, 3343U) || UnicodeUtility.IsInRangeInclusive(num2, 2912U, 2943U) || UnicodeUtility.IsInRangeInclusive(num2, 3072U, 3087U))
							{
								goto IL_163;
							}
							num = 2;
							if (source.Length <= 2)
							{
								goto IL_153;
							}
							num3 = (int)((sbyte)(*source[2]));
							if (num3 >= -64)
							{
								goto IL_163;
							}
							num2 <<= 6;
							num2 += (uint)num3;
							num2 += 128U;
							num2 -= 131072U;
							if (num2 > 65535U)
							{
								num = 3;
								if (source.Length <= 3)
								{
									goto IL_153;
								}
								num3 = (int)((sbyte)(*source[3]));
								if (num3 >= -64)
								{
									goto IL_163;
								}
								num2 <<= 6;
								num2 += (uint)num3;
								num2 += 128U;
								num2 -= 4194304U;
							}
						}
						bytesConsumed = num + 1;
						result = Rune.UnsafeCreate(num2);
						return OperationStatus.Done;
					}
				}
				IL_163:
				bytesConsumed = num;
				result = Rune.ReplacementChar;
				return OperationStatus.InvalidData;
			}
			IL_153:
			bytesConsumed = num;
			result = Rune.ReplacementChar;
			return OperationStatus.NeedMoreData;
		}

		// Token: 0x06002B19 RID: 11033 RVA: 0x0008718C File Offset: 0x0008538C
		public unsafe static OperationStatus DecodeLastFromUtf16(ReadOnlySpan<char> source, out Rune result, out int charsConsumed)
		{
			int num = source.Length - 1;
			if (num < source.Length)
			{
				char c = (char)(*source[num]);
				if (Rune.TryCreate(c, out result))
				{
					charsConsumed = 1;
					return OperationStatus.Done;
				}
				if (char.IsLowSurrogate(c))
				{
					num--;
					if (num < source.Length && Rune.TryCreate((char)(*source[num]), c, out result))
					{
						charsConsumed = 2;
						return OperationStatus.Done;
					}
					charsConsumed = 1;
					result = Rune.ReplacementChar;
					return OperationStatus.InvalidData;
				}
			}
			charsConsumed = (int)((uint)(-(uint)source.Length) >> 31);
			result = Rune.ReplacementChar;
			return OperationStatus.NeedMoreData;
		}

		// Token: 0x06002B1A RID: 11034 RVA: 0x0008721C File Offset: 0x0008541C
		public unsafe static OperationStatus DecodeLastFromUtf8(ReadOnlySpan<byte> source, out Rune value, out int bytesConsumed)
		{
			int num = source.Length - 1;
			if (num >= source.Length)
			{
				value = Rune.ReplacementChar;
				bytesConsumed = 0;
				return OperationStatus.NeedMoreData;
			}
			uint num2 = (uint)(*source[num]);
			if (UnicodeUtility.IsAsciiCodePoint(num2))
			{
				bytesConsumed = 1;
				value = Rune.UnsafeCreate(num2);
				return OperationStatus.Done;
			}
			if (((byte)num2 & 64) != 0)
			{
				return Rune.DecodeFromUtf8(source.Slice(num), out value, out bytesConsumed);
			}
			int i = 3;
			while (i > 0)
			{
				num--;
				if (num >= source.Length)
				{
					break;
				}
				if ((sbyte)(*source[num]) < -64)
				{
					i--;
				}
				else
				{
					source = source.Slice(num);
					Rune rune;
					int num3;
					OperationStatus result = Rune.DecodeFromUtf8(source, out rune, out num3);
					if (num3 == source.Length)
					{
						bytesConsumed = num3;
						value = rune;
						return result;
					}
					break;
				}
			}
			value = Rune.ReplacementChar;
			bytesConsumed = 1;
			return OperationStatus.InvalidData;
		}

		// Token: 0x06002B1B RID: 11035 RVA: 0x000872F4 File Offset: 0x000854F4
		public int EncodeToUtf16(Span<char> destination)
		{
			int result;
			if (!this.TryEncodeToUtf16(destination, out result))
			{
				ThrowHelper.ThrowArgumentException_DestinationTooShort();
			}
			return result;
		}

		// Token: 0x06002B1C RID: 11036 RVA: 0x00087314 File Offset: 0x00085514
		public int EncodeToUtf8(Span<byte> destination)
		{
			int result;
			if (!this.TryEncodeToUtf8(destination, out result))
			{
				ThrowHelper.ThrowArgumentException_DestinationTooShort();
			}
			return result;
		}

		// Token: 0x06002B1D RID: 11037 RVA: 0x00087334 File Offset: 0x00085534
		[NullableContext(2)]
		public override bool Equals([NotNullWhen(true)] object obj)
		{
			if (obj is Rune)
			{
				Rune other = (Rune)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06002B1E RID: 11038 RVA: 0x00087359 File Offset: 0x00085559
		public bool Equals(Rune other)
		{
			return this == other;
		}

		// Token: 0x06002B1F RID: 11039 RVA: 0x00087367 File Offset: 0x00085567
		public override int GetHashCode()
		{
			return this.Value;
		}

		// Token: 0x06002B20 RID: 11040 RVA: 0x0008736F File Offset: 0x0008556F
		[NullableContext(1)]
		public static Rune GetRuneAt(string input, int index)
		{
			int num = Rune.ReadRuneFromString(input, index);
			if (num < 0)
			{
				ThrowHelper.ThrowArgumentException_CannotExtractScalar(ExceptionArgument.index);
			}
			return Rune.UnsafeCreate((uint)num);
		}

		// Token: 0x06002B21 RID: 11041 RVA: 0x00087388 File Offset: 0x00085588
		public static bool IsValid(int value)
		{
			return Rune.IsValid((uint)value);
		}

		// Token: 0x06002B22 RID: 11042 RVA: 0x00087390 File Offset: 0x00085590
		[CLSCompliant(false)]
		public static bool IsValid(uint value)
		{
			return UnicodeUtility.IsValidUnicodeScalar(value);
		}

		// Token: 0x06002B23 RID: 11043 RVA: 0x00087398 File Offset: 0x00085598
		internal unsafe static int ReadFirstRuneFromUtf16Buffer(ReadOnlySpan<char> input)
		{
			if (input.IsEmpty)
			{
				return -1;
			}
			uint num = (uint)(*input[0]);
			if (UnicodeUtility.IsSurrogateCodePoint(num))
			{
				if (!UnicodeUtility.IsHighSurrogateCodePoint(num))
				{
					return -1;
				}
				if (input.Length <= 1)
				{
					return -1;
				}
				uint num2 = (uint)(*input[1]);
				if (!UnicodeUtility.IsLowSurrogateCodePoint(num2))
				{
					return -1;
				}
				num = UnicodeUtility.GetScalarFromUtf16SurrogatePair(num, num2);
			}
			return (int)num;
		}

		// Token: 0x06002B24 RID: 11044 RVA: 0x000873F8 File Offset: 0x000855F8
		private static int ReadRuneFromString(string input, int index)
		{
			if (input == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.input);
			}
			if (index >= input.Length)
			{
				ThrowHelper.ThrowArgumentOutOfRange_IndexMustBeLessException();
			}
			uint num = (uint)input[index];
			if (UnicodeUtility.IsSurrogateCodePoint(num))
			{
				if (!UnicodeUtility.IsHighSurrogateCodePoint(num))
				{
					return -1;
				}
				index++;
				if (index >= input.Length)
				{
					return -1;
				}
				uint num2 = (uint)input[index];
				if (!UnicodeUtility.IsLowSurrogateCodePoint(num2))
				{
					return -1;
				}
				num = UnicodeUtility.GetScalarFromUtf16SurrogatePair(num, num2);
			}
			return (int)num;
		}

		// Token: 0x06002B25 RID: 11045 RVA: 0x00087464 File Offset: 0x00085664
		[NullableContext(1)]
		public override string ToString()
		{
			if (this.IsBmp)
			{
				return string.CreateFromChar((char)this._value);
			}
			char c;
			char c2;
			UnicodeUtility.GetUtf16SurrogatesFromSupplementaryPlaneScalar(this._value, out c, out c2);
			return string.CreateFromChar(c, c2);
		}

		// Token: 0x06002B26 RID: 11046 RVA: 0x0008749C File Offset: 0x0008569C
		bool ISpanFormattable.TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider)
		{
			return this.TryEncodeToUtf16(destination, out charsWritten);
		}

		// Token: 0x06002B27 RID: 11047 RVA: 0x000874A6 File Offset: 0x000856A6
		bool IUtf8SpanFormattable.TryFormat(Span<byte> utf8Destination, out int bytesWritten, ReadOnlySpan<char> format, IFormatProvider provider)
		{
			return this.TryEncodeToUtf8(utf8Destination, out bytesWritten);
		}

		// Token: 0x06002B28 RID: 11048 RVA: 0x000874B0 File Offset: 0x000856B0
		string IFormattable.ToString(string format, IFormatProvider formatProvider)
		{
			return this.ToString();
		}

		// Token: 0x06002B29 RID: 11049 RVA: 0x000874C0 File Offset: 0x000856C0
		public static bool TryCreate(char ch, out Rune result)
		{
			if (!UnicodeUtility.IsSurrogateCodePoint((uint)ch))
			{
				result = Rune.UnsafeCreate((uint)ch);
				return true;
			}
			result = default(Rune);
			return false;
		}

		// Token: 0x06002B2A RID: 11050 RVA: 0x000874F0 File Offset: 0x000856F0
		public static bool TryCreate(char highSurrogate, char lowSurrogate, out Rune result)
		{
			uint num = (uint)(highSurrogate - '\ud800');
			uint num2 = (uint)(lowSurrogate - '\udc00');
			if ((num | num2) <= 1023U)
			{
				result = Rune.UnsafeCreate((num << 10) + (uint)(lowSurrogate - '\udc00') + 65536U);
				return true;
			}
			result = default(Rune);
			return false;
		}

		// Token: 0x06002B2B RID: 11051 RVA: 0x0008753E File Offset: 0x0008573E
		public static bool TryCreate(int value, out Rune result)
		{
			return Rune.TryCreate((uint)value, out result);
		}

		// Token: 0x06002B2C RID: 11052 RVA: 0x00087547 File Offset: 0x00085747
		[CLSCompliant(false)]
		public static bool TryCreate(uint value, out Rune result)
		{
			if (UnicodeUtility.IsValidUnicodeScalar(value))
			{
				result = Rune.UnsafeCreate(value);
				return true;
			}
			result = default(Rune);
			return false;
		}

		// Token: 0x06002B2D RID: 11053 RVA: 0x00087567 File Offset: 0x00085767
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool TryEncodeToUtf16(Span<char> destination, out int charsWritten)
		{
			return Rune.TryEncodeToUtf16(this, destination, out charsWritten);
		}

		// Token: 0x06002B2E RID: 11054 RVA: 0x00087578 File Offset: 0x00085778
		private unsafe static bool TryEncodeToUtf16(Rune value, Span<char> destination, out int charsWritten)
		{
			if (!destination.IsEmpty)
			{
				if (value.IsBmp)
				{
					*destination[0] = (char)value._value;
					charsWritten = 1;
					return true;
				}
				if (destination.Length > 1)
				{
					UnicodeUtility.GetUtf16SurrogatesFromSupplementaryPlaneScalar(value._value, destination[0], destination[1]);
					charsWritten = 2;
					return true;
				}
			}
			charsWritten = 0;
			return false;
		}

		// Token: 0x06002B2F RID: 11055 RVA: 0x000875DA File Offset: 0x000857DA
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool TryEncodeToUtf8(Span<byte> destination, out int bytesWritten)
		{
			return Rune.TryEncodeToUtf8(this, destination, out bytesWritten);
		}

		// Token: 0x06002B30 RID: 11056 RVA: 0x000875EC File Offset: 0x000857EC
		private unsafe static bool TryEncodeToUtf8(Rune value, Span<byte> destination, out int bytesWritten)
		{
			if (!destination.IsEmpty)
			{
				if (value.IsAscii)
				{
					*destination[0] = (byte)value._value;
					bytesWritten = 1;
					return true;
				}
				if (destination.Length > 1)
				{
					if ((long)value.Value <= 2047L)
					{
						*destination[0] = (byte)(value._value + 12288U >> 6);
						*destination[1] = (byte)((value._value & 63U) + 128U);
						bytesWritten = 2;
						return true;
					}
					if (destination.Length > 2)
					{
						if ((long)value.Value <= 65535L)
						{
							*destination[0] = (byte)(value._value + 917504U >> 12);
							*destination[1] = (byte)(((value._value & 4032U) >> 6) + 128U);
							*destination[2] = (byte)((value._value & 63U) + 128U);
							bytesWritten = 3;
							return true;
						}
						if (destination.Length > 3)
						{
							*destination[0] = (byte)(value._value + 62914560U >> 18);
							*destination[1] = (byte)(((value._value & 258048U) >> 12) + 128U);
							*destination[2] = (byte)(((value._value & 4032U) >> 6) + 128U);
							*destination[3] = (byte)((value._value & 63U) + 128U);
							bytesWritten = 4;
							return true;
						}
					}
				}
			}
			bytesWritten = 0;
			return false;
		}

		// Token: 0x06002B31 RID: 11057 RVA: 0x0008776C File Offset: 0x0008596C
		[NullableContext(1)]
		public static bool TryGetRuneAt(string input, int index, out Rune value)
		{
			int num = Rune.ReadRuneFromString(input, index);
			if (num >= 0)
			{
				value = Rune.UnsafeCreate((uint)num);
				return true;
			}
			value = default(Rune);
			return false;
		}

		// Token: 0x06002B32 RID: 11058 RVA: 0x0008779B File Offset: 0x0008599B
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static Rune UnsafeCreate(uint scalarValue)
		{
			return new Rune(scalarValue, false);
		}

		// Token: 0x06002B33 RID: 11059 RVA: 0x000877A4 File Offset: 0x000859A4
		public static double GetNumericValue(Rune value)
		{
			if (!value.IsAscii)
			{
				return CharUnicodeInfo.GetNumericValue(value.Value);
			}
			uint num = value._value - 48U;
			if (num > 9U)
			{
				return -1.0;
			}
			return num;
		}

		// Token: 0x06002B34 RID: 11060 RVA: 0x000877E4 File Offset: 0x000859E4
		public unsafe static UnicodeCategory GetUnicodeCategory(Rune value)
		{
			if (value.IsAscii)
			{
				return (UnicodeCategory)(*Rune.AsciiCharInfo[value.Value] & 31);
			}
			return Rune.GetUnicodeCategoryNonAscii(value);
		}

		// Token: 0x06002B35 RID: 11061 RVA: 0x00087819 File Offset: 0x00085A19
		private static UnicodeCategory GetUnicodeCategoryNonAscii(Rune value)
		{
			return CharUnicodeInfo.GetUnicodeCategory(value.Value);
		}

		// Token: 0x06002B36 RID: 11062 RVA: 0x00087827 File Offset: 0x00085A27
		private static bool IsCategoryLetter(UnicodeCategory category)
		{
			return UnicodeUtility.IsInRangeInclusive((uint)category, 0U, 4U);
		}

		// Token: 0x06002B37 RID: 11063 RVA: 0x00087831 File Offset: 0x00085A31
		private static bool IsCategoryLetterOrDecimalDigit(UnicodeCategory category)
		{
			return UnicodeUtility.IsInRangeInclusive((uint)category, 0U, 4U) || category == UnicodeCategory.DecimalDigitNumber;
		}

		// Token: 0x06002B38 RID: 11064 RVA: 0x00087843 File Offset: 0x00085A43
		private static bool IsCategoryNumber(UnicodeCategory category)
		{
			return UnicodeUtility.IsInRangeInclusive((uint)category, 8U, 10U);
		}

		// Token: 0x06002B39 RID: 11065 RVA: 0x0008784E File Offset: 0x00085A4E
		private static bool IsCategoryPunctuation(UnicodeCategory category)
		{
			return UnicodeUtility.IsInRangeInclusive((uint)category, 18U, 24U);
		}

		// Token: 0x06002B3A RID: 11066 RVA: 0x0008785A File Offset: 0x00085A5A
		private static bool IsCategorySeparator(UnicodeCategory category)
		{
			return UnicodeUtility.IsInRangeInclusive((uint)category, 11U, 13U);
		}

		// Token: 0x06002B3B RID: 11067 RVA: 0x00087866 File Offset: 0x00085A66
		private static bool IsCategorySymbol(UnicodeCategory category)
		{
			return UnicodeUtility.IsInRangeInclusive((uint)category, 25U, 28U);
		}

		// Token: 0x06002B3C RID: 11068 RVA: 0x00087872 File Offset: 0x00085A72
		public static bool IsControl(Rune value)
		{
			return (value._value + 1U & 4294967167U) <= 32U;
		}

		// Token: 0x06002B3D RID: 11069 RVA: 0x00087889 File Offset: 0x00085A89
		public static bool IsDigit(Rune value)
		{
			if (value.IsAscii)
			{
				return UnicodeUtility.IsInRangeInclusive(value._value, 48U, 57U);
			}
			return Rune.GetUnicodeCategoryNonAscii(value) == UnicodeCategory.DecimalDigitNumber;
		}

		// Token: 0x06002B3E RID: 11070 RVA: 0x000878AD File Offset: 0x00085AAD
		public static bool IsLetter(Rune value)
		{
			if (value.IsAscii)
			{
				return (value._value - 65U & 4294967263U) <= 25U;
			}
			return Rune.IsCategoryLetter(Rune.GetUnicodeCategoryNonAscii(value));
		}

		// Token: 0x06002B3F RID: 11071 RVA: 0x000878D8 File Offset: 0x00085AD8
		public unsafe static bool IsLetterOrDigit(Rune value)
		{
			if (value.IsAscii)
			{
				return (*Rune.AsciiCharInfo[value.Value] & 64) > 0;
			}
			return Rune.IsCategoryLetterOrDecimalDigit(Rune.GetUnicodeCategoryNonAscii(value));
		}

		// Token: 0x06002B40 RID: 11072 RVA: 0x00087915 File Offset: 0x00085B15
		public static bool IsLower(Rune value)
		{
			if (value.IsAscii)
			{
				return UnicodeUtility.IsInRangeInclusive(value._value, 97U, 122U);
			}
			return Rune.GetUnicodeCategoryNonAscii(value) == UnicodeCategory.LowercaseLetter;
		}

		// Token: 0x06002B41 RID: 11073 RVA: 0x00087939 File Offset: 0x00085B39
		public static bool IsNumber(Rune value)
		{
			if (value.IsAscii)
			{
				return UnicodeUtility.IsInRangeInclusive(value._value, 48U, 57U);
			}
			return Rune.IsCategoryNumber(Rune.GetUnicodeCategoryNonAscii(value));
		}

		// Token: 0x06002B42 RID: 11074 RVA: 0x0008795F File Offset: 0x00085B5F
		public static bool IsPunctuation(Rune value)
		{
			return Rune.IsCategoryPunctuation(Rune.GetUnicodeCategory(value));
		}

		// Token: 0x06002B43 RID: 11075 RVA: 0x0008796C File Offset: 0x00085B6C
		public static bool IsSeparator(Rune value)
		{
			return Rune.IsCategorySeparator(Rune.GetUnicodeCategory(value));
		}

		// Token: 0x06002B44 RID: 11076 RVA: 0x00087979 File Offset: 0x00085B79
		public static bool IsSymbol(Rune value)
		{
			return Rune.IsCategorySymbol(Rune.GetUnicodeCategory(value));
		}

		// Token: 0x06002B45 RID: 11077 RVA: 0x00087986 File Offset: 0x00085B86
		public static bool IsUpper(Rune value)
		{
			if (value.IsAscii)
			{
				return UnicodeUtility.IsInRangeInclusive(value._value, 65U, 90U);
			}
			return Rune.GetUnicodeCategoryNonAscii(value) == UnicodeCategory.UppercaseLetter;
		}

		// Token: 0x06002B46 RID: 11078 RVA: 0x000879AC File Offset: 0x00085BAC
		public unsafe static bool IsWhiteSpace(Rune value)
		{
			if (value.IsAscii)
			{
				return (*Rune.AsciiCharInfo[value.Value] & 128) > 0;
			}
			return value.IsBmp && CharUnicodeInfo.GetIsWhiteSpace((char)value._value);
		}

		// Token: 0x06002B47 RID: 11079 RVA: 0x000879F8 File Offset: 0x00085BF8
		[NullableContext(1)]
		public static Rune ToLower(Rune value, CultureInfo culture)
		{
			if (culture == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.culture);
			}
			if (GlobalizationMode.Invariant)
			{
				return Rune.ToLowerInvariant(value);
			}
			return Rune.ChangeCaseCultureAware(value, culture.TextInfo, false);
		}

		// Token: 0x06002B48 RID: 11080 RVA: 0x00087A1F File Offset: 0x00085C1F
		public static Rune ToLowerInvariant(Rune value)
		{
			if (value.IsAscii)
			{
				return Rune.UnsafeCreate(Utf16Utility.ConvertAllAsciiCharsInUInt32ToLowercase(value._value));
			}
			if (GlobalizationMode.Invariant)
			{
				return Rune.UnsafeCreate(CharUnicodeInfo.ToLower(value._value));
			}
			return Rune.ChangeCaseCultureAware(value, TextInfo.Invariant, false);
		}

		// Token: 0x06002B49 RID: 11081 RVA: 0x00087A5F File Offset: 0x00085C5F
		[NullableContext(1)]
		public static Rune ToUpper(Rune value, CultureInfo culture)
		{
			if (culture == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.culture);
			}
			if (GlobalizationMode.Invariant)
			{
				return Rune.ToUpperInvariant(value);
			}
			return Rune.ChangeCaseCultureAware(value, culture.TextInfo, true);
		}

		// Token: 0x06002B4A RID: 11082 RVA: 0x00087A86 File Offset: 0x00085C86
		public static Rune ToUpperInvariant(Rune value)
		{
			if (value.IsAscii)
			{
				return Rune.UnsafeCreate(Utf16Utility.ConvertAllAsciiCharsInUInt32ToUppercase(value._value));
			}
			if (GlobalizationMode.Invariant)
			{
				return Rune.UnsafeCreate(CharUnicodeInfo.ToUpper(value._value));
			}
			return Rune.ChangeCaseCultureAware(value, TextInfo.Invariant, true);
		}

		// Token: 0x06002B4B RID: 11083 RVA: 0x00087AC8 File Offset: 0x00085CC8
		int IComparable.CompareTo(object obj)
		{
			if (obj == null)
			{
				return 1;
			}
			if (obj is Rune)
			{
				Rune other = (Rune)obj;
				return this.CompareTo(other);
			}
			throw new ArgumentException(SR.Arg_MustBeRune);
		}

		// Token: 0x04000791 RID: 1937
		private readonly uint _value;
	}
}
