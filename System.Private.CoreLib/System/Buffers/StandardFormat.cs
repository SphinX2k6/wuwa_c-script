using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Buffers
{
	// Token: 0x02000349 RID: 841
	public readonly struct StandardFormat : IEquatable<StandardFormat>
	{
		// Token: 0x17000B16 RID: 2838
		// (get) Token: 0x06003AB8 RID: 15032 RVA: 0x000C35D5 File Offset: 0x000C17D5
		public char Symbol
		{
			get
			{
				return (char)this._format;
			}
		}

		// Token: 0x17000B17 RID: 2839
		// (get) Token: 0x06003AB9 RID: 15033 RVA: 0x000C35DD File Offset: 0x000C17DD
		public byte Precision
		{
			get
			{
				return this._precision;
			}
		}

		// Token: 0x17000B18 RID: 2840
		// (get) Token: 0x06003ABA RID: 15034 RVA: 0x000C35E5 File Offset: 0x000C17E5
		public bool HasPrecision
		{
			get
			{
				return this._precision != byte.MaxValue;
			}
		}

		// Token: 0x17000B19 RID: 2841
		// (get) Token: 0x06003ABB RID: 15035 RVA: 0x000C35F7 File Offset: 0x000C17F7
		internal byte PrecisionOrZero
		{
			get
			{
				if (this._precision == 255)
				{
					return 0;
				}
				return this._precision;
			}
		}

		// Token: 0x17000B1A RID: 2842
		// (get) Token: 0x06003ABC RID: 15036 RVA: 0x000C360E File Offset: 0x000C180E
		public bool IsDefault
		{
			get
			{
				return (this._format | this._precision) == 0;
			}
		}

		// Token: 0x06003ABD RID: 15037 RVA: 0x000C3620 File Offset: 0x000C1820
		public StandardFormat(char symbol, byte precision = 255)
		{
			if (precision != 255 && precision > 99)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException_PrecisionTooLarge();
			}
			if (symbol != (char)((byte)symbol))
			{
				ThrowHelper.ThrowArgumentOutOfRangeException_SymbolDoesNotFit();
			}
			this._format = (byte)symbol;
			this._precision = precision;
		}

		// Token: 0x06003ABE RID: 15038 RVA: 0x000C364D File Offset: 0x000C184D
		public static implicit operator StandardFormat(char symbol)
		{
			return new StandardFormat(symbol, byte.MaxValue);
		}

		// Token: 0x06003ABF RID: 15039 RVA: 0x000C365C File Offset: 0x000C185C
		public static StandardFormat Parse([StringSyntax("NumericFormat")] ReadOnlySpan<char> format)
		{
			StandardFormat result;
			StandardFormat.ParseHelper(format, out result, true);
			return result;
		}

		// Token: 0x06003AC0 RID: 15040 RVA: 0x000C3674 File Offset: 0x000C1874
		[NullableContext(2)]
		public static StandardFormat Parse([StringSyntax("NumericFormat")] string format)
		{
			if (format != null)
			{
				return StandardFormat.Parse(format.AsSpan());
			}
			return default(StandardFormat);
		}

		// Token: 0x06003AC1 RID: 15041 RVA: 0x000C3699 File Offset: 0x000C1899
		public static bool TryParse([StringSyntax("NumericFormat")] ReadOnlySpan<char> format, out StandardFormat result)
		{
			return StandardFormat.ParseHelper(format, out result, false);
		}

		// Token: 0x06003AC2 RID: 15042 RVA: 0x000C36A4 File Offset: 0x000C18A4
		private unsafe static bool ParseHelper(ReadOnlySpan<char> format, out StandardFormat standardFormat, bool throws = false)
		{
			standardFormat = default(StandardFormat);
			if (format.Length == 0)
			{
				return true;
			}
			char symbol = (char)(*format[0]);
			byte precision;
			if (format.Length == 1)
			{
				precision = byte.MaxValue;
			}
			else
			{
				uint num = 0U;
				int i = 1;
				while (i < format.Length)
				{
					uint num2 = (uint)(*format[i] - 48);
					if (num2 > 9U)
					{
						if (!throws)
						{
							return false;
						}
						throw new FormatException(SR.Format(SR.Argument_CannotParsePrecision, 99));
					}
					else
					{
						num = num * 10U + num2;
						if (num > 99U)
						{
							if (!throws)
							{
								return false;
							}
							throw new FormatException(SR.Format(SR.Argument_PrecisionTooLarge, 99));
						}
						else
						{
							i++;
						}
					}
				}
				precision = (byte)num;
			}
			standardFormat = new StandardFormat(symbol, precision);
			return true;
		}

		// Token: 0x06003AC3 RID: 15043 RVA: 0x000C3760 File Offset: 0x000C1960
		[NullableContext(2)]
		public override bool Equals([NotNullWhen(true)] object obj)
		{
			if (obj is StandardFormat)
			{
				StandardFormat other = (StandardFormat)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06003AC4 RID: 15044 RVA: 0x000C3785 File Offset: 0x000C1985
		public override int GetHashCode()
		{
			return this._format.GetHashCode() ^ this._precision.GetHashCode();
		}

		// Token: 0x06003AC5 RID: 15045 RVA: 0x000C379E File Offset: 0x000C199E
		public bool Equals(StandardFormat other)
		{
			return this._format == other._format && this._precision == other._precision;
		}

		// Token: 0x06003AC6 RID: 15046 RVA: 0x000C37C0 File Offset: 0x000C19C0
		[NullableContext(1)]
		public unsafe override string ToString()
		{
			Span<char> destination = new Span<char>(stackalloc byte[(UIntPtr)6], 3);
			return new string(this.Format(destination));
		}

		// Token: 0x06003AC7 RID: 15047 RVA: 0x000C37EC File Offset: 0x000C19EC
		internal unsafe Span<char> Format(Span<char> destination)
		{
			char symbol = this.Symbol;
			if (symbol == '\0' || destination.Length != 3)
			{
				return default(Span<char>);
			}
			*destination[0] = symbol;
			uint num = (uint)this.Precision;
			if (num == 255U)
			{
				return destination.Slice(0, 1);
			}
			if (num >= 10U)
			{
				ValueTuple<uint, uint> valueTuple = Math.DivRem(num, 10U);
				uint item = valueTuple.Item1;
				num = valueTuple.Item2;
				*destination[1] = (char)(48U + item % 10U);
				*destination[2] = (char)(48U + num);
				return destination;
			}
			*destination[1] = (char)(48U + num);
			return destination.Slice(0, 2);
		}

		// Token: 0x06003AC8 RID: 15048 RVA: 0x000C388F File Offset: 0x000C1A8F
		public static bool operator ==(StandardFormat left, StandardFormat right)
		{
			return left.Equals(right);
		}

		// Token: 0x06003AC9 RID: 15049 RVA: 0x000C3899 File Offset: 0x000C1A99
		public static bool operator !=(StandardFormat left, StandardFormat right)
		{
			return !left.Equals(right);
		}

		// Token: 0x04000C49 RID: 3145
		public const byte NoPrecision = 255;

		// Token: 0x04000C4A RID: 3146
		public const byte MaxPrecision = 99;

		// Token: 0x04000C4B RID: 3147
		private readonly byte _format;

		// Token: 0x04000C4C RID: 3148
		private readonly byte _precision;
	}
}
