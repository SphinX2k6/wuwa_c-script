using System;
using System.Buffers.Binary;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;

namespace System.Runtime.InteropServices
{
	// Token: 0x020005E3 RID: 1507
	[Intrinsic]
	[NonVersionable]
	public readonly struct NFloat : IBinaryFloatingPointIeee754<NFloat>, IBinaryNumber<NFloat>, IBitwiseOperators<NFloat, NFloat, NFloat>, INumber<NFloat>, IComparable, IComparable<NFloat>, IComparisonOperators<NFloat, NFloat, bool>, IEqualityOperators<NFloat, NFloat, bool>, IModulusOperators<NFloat, NFloat, NFloat>, INumberBase<NFloat>, IAdditionOperators<NFloat, NFloat, NFloat>, IAdditiveIdentity<NFloat, NFloat>, IDecrementOperators<NFloat>, IDivisionOperators<NFloat, NFloat, NFloat>, IEquatable<NFloat>, IIncrementOperators<NFloat>, IMultiplicativeIdentity<NFloat, NFloat>, IMultiplyOperators<NFloat, NFloat, NFloat>, ISpanFormattable, IFormattable, ISpanParsable<NFloat>, IParsable<NFloat>, ISubtractionOperators<NFloat, NFloat, NFloat>, IUnaryPlusOperators<NFloat, NFloat>, IUnaryNegationOperators<NFloat, NFloat>, IUtf8SpanFormattable, IUtf8SpanParsable<NFloat>, IFloatingPointIeee754<NFloat>, IExponentialFunctions<NFloat>, IFloatingPointConstants<NFloat>, IFloatingPoint<NFloat>, ISignedNumber<NFloat>, IHyperbolicFunctions<NFloat>, ILogarithmicFunctions<NFloat>, IPowerFunctions<NFloat>, IRootFunctions<NFloat>, ITrigonometricFunctions<NFloat>, IMinMaxValue<NFloat>
	{
		// Token: 0x06007066 RID: 28774 RVA: 0x0010DEA2 File Offset: 0x0010C0A2
		[NonVersionable]
		public NFloat(float value)
		{
			this._value = (double)value;
		}

		// Token: 0x06007067 RID: 28775 RVA: 0x0010DEA2 File Offset: 0x0010C0A2
		[NonVersionable]
		public NFloat(double value)
		{
			this._value = value;
		}

		// Token: 0x17000DD8 RID: 3544
		// (get) Token: 0x06007068 RID: 28776 RVA: 0x0010DEAC File Offset: 0x0010C0AC
		public static NFloat Epsilon
		{
			[NonVersionable]
			get
			{
				return new NFloat(double.Epsilon);
			}
		}

		// Token: 0x17000DD9 RID: 3545
		// (get) Token: 0x06007069 RID: 28777 RVA: 0x0010DEBC File Offset: 0x0010C0BC
		public static NFloat MaxValue
		{
			[NonVersionable]
			get
			{
				return new NFloat(double.MaxValue);
			}
		}

		// Token: 0x17000DDA RID: 3546
		// (get) Token: 0x0600706A RID: 28778 RVA: 0x0010DECC File Offset: 0x0010C0CC
		public static NFloat MinValue
		{
			[NonVersionable]
			get
			{
				return new NFloat(double.MinValue);
			}
		}

		// Token: 0x17000DDB RID: 3547
		// (get) Token: 0x0600706B RID: 28779 RVA: 0x0010DEDC File Offset: 0x0010C0DC
		public static NFloat NaN
		{
			[NonVersionable]
			get
			{
				return new NFloat(double.NaN);
			}
		}

		// Token: 0x17000DDC RID: 3548
		// (get) Token: 0x0600706C RID: 28780 RVA: 0x0010DEEC File Offset: 0x0010C0EC
		public static NFloat NegativeInfinity
		{
			[NonVersionable]
			get
			{
				return new NFloat(double.NegativeInfinity);
			}
		}

		// Token: 0x17000DDD RID: 3549
		// (get) Token: 0x0600706D RID: 28781 RVA: 0x0010DEFC File Offset: 0x0010C0FC
		public static NFloat PositiveInfinity
		{
			[NonVersionable]
			get
			{
				return new NFloat(double.PositiveInfinity);
			}
		}

		// Token: 0x17000DDE RID: 3550
		// (get) Token: 0x0600706E RID: 28782 RVA: 0x0002EBDD File Offset: 0x0002CDDD
		public static int Size
		{
			[NonVersionable]
			get
			{
				return 8;
			}
		}

		// Token: 0x17000DDF RID: 3551
		// (get) Token: 0x0600706F RID: 28783 RVA: 0x0010DF0C File Offset: 0x0010C10C
		public double Value
		{
			[NonVersionable]
			get
			{
				return this._value;
			}
		}

		// Token: 0x06007070 RID: 28784 RVA: 0x00007B62 File Offset: 0x00005D62
		[NonVersionable]
		public static NFloat operator +(NFloat value)
		{
			return value;
		}

		// Token: 0x06007071 RID: 28785 RVA: 0x0010DF14 File Offset: 0x0010C114
		[NonVersionable]
		public static NFloat operator -(NFloat value)
		{
			return new NFloat(-value._value);
		}

		// Token: 0x06007072 RID: 28786 RVA: 0x0010DF22 File Offset: 0x0010C122
		[NonVersionable]
		public static NFloat operator ++(NFloat value)
		{
			return new NFloat(value._value + 1.0);
		}

		// Token: 0x06007073 RID: 28787 RVA: 0x0010DF39 File Offset: 0x0010C139
		[NonVersionable]
		public static NFloat operator --(NFloat value)
		{
			return new NFloat(value._value - 1.0);
		}

		// Token: 0x06007074 RID: 28788 RVA: 0x0010DF50 File Offset: 0x0010C150
		[NonVersionable]
		public static NFloat operator +(NFloat left, NFloat right)
		{
			return new NFloat(left._value + right._value);
		}

		// Token: 0x06007075 RID: 28789 RVA: 0x0010DF64 File Offset: 0x0010C164
		[NonVersionable]
		public static NFloat operator -(NFloat left, NFloat right)
		{
			return new NFloat(left._value - right._value);
		}

		// Token: 0x06007076 RID: 28790 RVA: 0x0010DF78 File Offset: 0x0010C178
		[NonVersionable]
		public static NFloat operator *(NFloat left, NFloat right)
		{
			return new NFloat(left._value * right._value);
		}

		// Token: 0x06007077 RID: 28791 RVA: 0x0010DF8C File Offset: 0x0010C18C
		[NonVersionable]
		public static NFloat operator /(NFloat left, NFloat right)
		{
			return new NFloat(left._value / right._value);
		}

		// Token: 0x06007078 RID: 28792 RVA: 0x0010DFA0 File Offset: 0x0010C1A0
		[NonVersionable]
		public static NFloat operator %(NFloat left, NFloat right)
		{
			return new NFloat(left._value % right._value);
		}

		// Token: 0x06007079 RID: 28793 RVA: 0x0010DFB4 File Offset: 0x0010C1B4
		[NonVersionable]
		public static bool operator ==(NFloat left, NFloat right)
		{
			return left._value == right._value;
		}

		// Token: 0x0600707A RID: 28794 RVA: 0x0010DFC4 File Offset: 0x0010C1C4
		[NonVersionable]
		public static bool operator !=(NFloat left, NFloat right)
		{
			return left._value != right._value;
		}

		// Token: 0x0600707B RID: 28795 RVA: 0x0010DFD7 File Offset: 0x0010C1D7
		[NonVersionable]
		public static bool operator <(NFloat left, NFloat right)
		{
			return left._value < right._value;
		}

		// Token: 0x0600707C RID: 28796 RVA: 0x0010DFE7 File Offset: 0x0010C1E7
		[NonVersionable]
		public static bool operator <=(NFloat left, NFloat right)
		{
			return left._value <= right._value;
		}

		// Token: 0x0600707D RID: 28797 RVA: 0x0010DFFA File Offset: 0x0010C1FA
		[NonVersionable]
		public static bool operator >(NFloat left, NFloat right)
		{
			return left._value > right._value;
		}

		// Token: 0x0600707E RID: 28798 RVA: 0x0010E00A File Offset: 0x0010C20A
		[NonVersionable]
		public static bool operator >=(NFloat left, NFloat right)
		{
			return left._value >= right._value;
		}

		// Token: 0x0600707F RID: 28799 RVA: 0x0010E01D File Offset: 0x0010C21D
		[NonVersionable]
		public static explicit operator NFloat(decimal value)
		{
			return new NFloat((double)value);
		}

		// Token: 0x06007080 RID: 28800 RVA: 0x0010E02B File Offset: 0x0010C22B
		[NonVersionable]
		public static explicit operator NFloat(double value)
		{
			return new NFloat(value);
		}

		// Token: 0x06007081 RID: 28801 RVA: 0x0010E034 File Offset: 0x0010C234
		[NonVersionable]
		public static explicit operator byte(NFloat value)
		{
			return (byte)value._value;
		}

		// Token: 0x06007082 RID: 28802 RVA: 0x0010E03D File Offset: 0x0010C23D
		[NonVersionable]
		public static byte op_CheckedExplicit(NFloat value)
		{
			return checked((byte)value._value);
		}

		// Token: 0x06007083 RID: 28803 RVA: 0x0010E046 File Offset: 0x0010C246
		[NonVersionable]
		public static explicit operator char(NFloat value)
		{
			return (char)value._value;
		}

		// Token: 0x06007084 RID: 28804 RVA: 0x0010E04F File Offset: 0x0010C24F
		[NonVersionable]
		public static char op_CheckedExplicit(NFloat value)
		{
			return checked((char)value._value);
		}

		// Token: 0x06007085 RID: 28805 RVA: 0x0010E058 File Offset: 0x0010C258
		[NonVersionable]
		public static explicit operator decimal(NFloat value)
		{
			return (decimal)value._value;
		}

		// Token: 0x06007086 RID: 28806 RVA: 0x0010E065 File Offset: 0x0010C265
		[NonVersionable]
		public static explicit operator Half(NFloat value)
		{
			return (Half)value._value;
		}

		// Token: 0x06007087 RID: 28807 RVA: 0x0010E072 File Offset: 0x0010C272
		[NonVersionable]
		public static explicit operator short(NFloat value)
		{
			return (short)value._value;
		}

		// Token: 0x06007088 RID: 28808 RVA: 0x0010E07B File Offset: 0x0010C27B
		[NonVersionable]
		public static short op_CheckedExplicit(NFloat value)
		{
			return checked((short)value._value);
		}

		// Token: 0x06007089 RID: 28809 RVA: 0x0010E084 File Offset: 0x0010C284
		[NonVersionable]
		public static explicit operator int(NFloat value)
		{
			return (int)value._value;
		}

		// Token: 0x0600708A RID: 28810 RVA: 0x0010E08D File Offset: 0x0010C28D
		[NonVersionable]
		public static int op_CheckedExplicit(NFloat value)
		{
			return checked((int)value._value);
		}

		// Token: 0x0600708B RID: 28811 RVA: 0x0010E096 File Offset: 0x0010C296
		[NonVersionable]
		public static explicit operator long(NFloat value)
		{
			return (long)value._value;
		}

		// Token: 0x0600708C RID: 28812 RVA: 0x0010E09F File Offset: 0x0010C29F
		[NonVersionable]
		public static long op_CheckedExplicit(NFloat value)
		{
			return checked((long)value._value);
		}

		// Token: 0x0600708D RID: 28813 RVA: 0x0010E0A8 File Offset: 0x0010C2A8
		[NonVersionable]
		public static explicit operator Int128(NFloat value)
		{
			return (Int128)value._value;
		}

		// Token: 0x0600708E RID: 28814 RVA: 0x0010E0B5 File Offset: 0x0010C2B5
		[NonVersionable]
		public static Int128 op_CheckedExplicit(NFloat value)
		{
			return Int128.op_CheckedExplicit(value._value);
		}

		// Token: 0x0600708F RID: 28815 RVA: 0x0010E0C2 File Offset: 0x0010C2C2
		[NonVersionable]
		public static explicit operator IntPtr(NFloat value)
		{
			return (IntPtr)value._value;
		}

		// Token: 0x06007090 RID: 28816 RVA: 0x0010E0CB File Offset: 0x0010C2CB
		[NonVersionable]
		public static IntPtr op_CheckedExplicit(NFloat value)
		{
			return checked((IntPtr)value._value);
		}

		// Token: 0x06007091 RID: 28817 RVA: 0x0010E0D4 File Offset: 0x0010C2D4
		[NonVersionable]
		[CLSCompliant(false)]
		public static explicit operator sbyte(NFloat value)
		{
			return (sbyte)value._value;
		}

		// Token: 0x06007092 RID: 28818 RVA: 0x0010E0DD File Offset: 0x0010C2DD
		[NonVersionable]
		[CLSCompliant(false)]
		public static sbyte op_CheckedExplicit(NFloat value)
		{
			return checked((sbyte)value._value);
		}

		// Token: 0x06007093 RID: 28819 RVA: 0x0010E0E6 File Offset: 0x0010C2E6
		[NonVersionable]
		public static explicit operator float(NFloat value)
		{
			return (float)value._value;
		}

		// Token: 0x06007094 RID: 28820 RVA: 0x0010E046 File Offset: 0x0010C246
		[NonVersionable]
		[CLSCompliant(false)]
		public static explicit operator ushort(NFloat value)
		{
			return (ushort)value._value;
		}

		// Token: 0x06007095 RID: 28821 RVA: 0x0010E04F File Offset: 0x0010C24F
		[NonVersionable]
		[CLSCompliant(false)]
		public static ushort op_CheckedExplicit(NFloat value)
		{
			return checked((ushort)value._value);
		}

		// Token: 0x06007096 RID: 28822 RVA: 0x0010E0EF File Offset: 0x0010C2EF
		[NonVersionable]
		[CLSCompliant(false)]
		public static explicit operator uint(NFloat value)
		{
			return (uint)value._value;
		}

		// Token: 0x06007097 RID: 28823 RVA: 0x0010E0F8 File Offset: 0x0010C2F8
		[NonVersionable]
		[CLSCompliant(false)]
		public static uint op_CheckedExplicit(NFloat value)
		{
			return checked((uint)value._value);
		}

		// Token: 0x06007098 RID: 28824 RVA: 0x0010E101 File Offset: 0x0010C301
		[NonVersionable]
		[CLSCompliant(false)]
		public static explicit operator ulong(NFloat value)
		{
			return (ulong)value._value;
		}

		// Token: 0x06007099 RID: 28825 RVA: 0x0010E10A File Offset: 0x0010C30A
		[NonVersionable]
		[CLSCompliant(false)]
		public static ulong op_CheckedExplicit(NFloat value)
		{
			return checked((ulong)value._value);
		}

		// Token: 0x0600709A RID: 28826 RVA: 0x0010E113 File Offset: 0x0010C313
		[NonVersionable]
		[CLSCompliant(false)]
		public static explicit operator UInt128(NFloat value)
		{
			return (UInt128)value._value;
		}

		// Token: 0x0600709B RID: 28827 RVA: 0x0010E120 File Offset: 0x0010C320
		[NonVersionable]
		[CLSCompliant(false)]
		public static UInt128 op_CheckedExplicit(NFloat value)
		{
			return UInt128.op_CheckedExplicit(value._value);
		}

		// Token: 0x0600709C RID: 28828 RVA: 0x0010E12D File Offset: 0x0010C32D
		[NonVersionable]
		[CLSCompliant(false)]
		public static explicit operator UIntPtr(NFloat value)
		{
			return (UIntPtr)value._value;
		}

		// Token: 0x0600709D RID: 28829 RVA: 0x0010E136 File Offset: 0x0010C336
		[NonVersionable]
		[CLSCompliant(false)]
		public static UIntPtr op_CheckedExplicit(NFloat value)
		{
			return checked((UIntPtr)value._value);
		}

		// Token: 0x0600709E RID: 28830 RVA: 0x0010E02B File Offset: 0x0010C22B
		[NonVersionable]
		public static implicit operator NFloat(byte value)
		{
			return new NFloat((double)value);
		}

		// Token: 0x0600709F RID: 28831 RVA: 0x0010E02B File Offset: 0x0010C22B
		[NonVersionable]
		public static implicit operator NFloat(char value)
		{
			return new NFloat((double)value);
		}

		// Token: 0x060070A0 RID: 28832 RVA: 0x0010E13F File Offset: 0x0010C33F
		[NonVersionable]
		public static implicit operator NFloat(Half value)
		{
			return (float)value;
		}

		// Token: 0x060070A1 RID: 28833 RVA: 0x0010E02B File Offset: 0x0010C22B
		[NonVersionable]
		public static implicit operator NFloat(short value)
		{
			return new NFloat((double)value);
		}

		// Token: 0x060070A2 RID: 28834 RVA: 0x0010E02B File Offset: 0x0010C22B
		[NonVersionable]
		public static implicit operator NFloat(int value)
		{
			return new NFloat((double)value);
		}

		// Token: 0x060070A3 RID: 28835 RVA: 0x0010E02B File Offset: 0x0010C22B
		[NonVersionable]
		public static implicit operator NFloat(long value)
		{
			return new NFloat((double)value);
		}

		// Token: 0x060070A4 RID: 28836 RVA: 0x0010E14D File Offset: 0x0010C34D
		[NonVersionable]
		public static explicit operator NFloat(Int128 value)
		{
			if (Int128.IsNegative(value))
			{
				value = -value;
				return -(NFloat)((UInt128)value);
			}
			return (NFloat)((UInt128)value);
		}

		// Token: 0x060070A5 RID: 28837 RVA: 0x0010E02B File Offset: 0x0010C22B
		[NonVersionable]
		public static implicit operator NFloat(IntPtr value)
		{
			return new NFloat((double)value);
		}

		// Token: 0x060070A6 RID: 28838 RVA: 0x0010E02B File Offset: 0x0010C22B
		[NonVersionable]
		[CLSCompliant(false)]
		public static implicit operator NFloat(sbyte value)
		{
			return new NFloat((double)value);
		}

		// Token: 0x060070A7 RID: 28839 RVA: 0x0010E02B File Offset: 0x0010C22B
		[NonVersionable]
		public static implicit operator NFloat(float value)
		{
			return new NFloat((double)value);
		}

		// Token: 0x060070A8 RID: 28840 RVA: 0x0010E02B File Offset: 0x0010C22B
		[NonVersionable]
		[CLSCompliant(false)]
		public static implicit operator NFloat(ushort value)
		{
			return new NFloat((double)value);
		}

		// Token: 0x060070A9 RID: 28841 RVA: 0x0010E17B File Offset: 0x0010C37B
		[NonVersionable]
		[CLSCompliant(false)]
		public static implicit operator NFloat(uint value)
		{
			return new NFloat(value);
		}

		// Token: 0x060070AA RID: 28842 RVA: 0x0010E17B File Offset: 0x0010C37B
		[NonVersionable]
		[CLSCompliant(false)]
		public static implicit operator NFloat(ulong value)
		{
			return new NFloat(value);
		}

		// Token: 0x060070AB RID: 28843 RVA: 0x0010E185 File Offset: 0x0010C385
		[NonVersionable]
		[CLSCompliant(false)]
		public static explicit operator NFloat(UInt128 value)
		{
			return (NFloat)((double)value);
		}

		// Token: 0x060070AC RID: 28844 RVA: 0x0010E17B File Offset: 0x0010C37B
		[NonVersionable]
		[CLSCompliant(false)]
		public static implicit operator NFloat(UIntPtr value)
		{
			return new NFloat(value);
		}

		// Token: 0x060070AD RID: 28845 RVA: 0x0010E193 File Offset: 0x0010C393
		public static implicit operator double(NFloat value)
		{
			return value._value;
		}

		// Token: 0x060070AE RID: 28846 RVA: 0x0010E19C File Offset: 0x0010C39C
		[NonVersionable]
		public static bool IsFinite(NFloat value)
		{
			return double.IsFinite(value._value);
		}

		// Token: 0x060070AF RID: 28847 RVA: 0x0010E1A9 File Offset: 0x0010C3A9
		[NonVersionable]
		public static bool IsInfinity(NFloat value)
		{
			return double.IsInfinity(value._value);
		}

		// Token: 0x060070B0 RID: 28848 RVA: 0x0010E1B6 File Offset: 0x0010C3B6
		[NonVersionable]
		public static bool IsNaN(NFloat value)
		{
			return double.IsNaN(value._value);
		}

		// Token: 0x060070B1 RID: 28849 RVA: 0x0010E1C3 File Offset: 0x0010C3C3
		[NonVersionable]
		public static bool IsNegative(NFloat value)
		{
			return double.IsNegative(value._value);
		}

		// Token: 0x060070B2 RID: 28850 RVA: 0x0010E1D0 File Offset: 0x0010C3D0
		[NonVersionable]
		public static bool IsNegativeInfinity(NFloat value)
		{
			return double.IsNegativeInfinity(value._value);
		}

		// Token: 0x060070B3 RID: 28851 RVA: 0x0010E1DD File Offset: 0x0010C3DD
		[NonVersionable]
		public static bool IsNormal(NFloat value)
		{
			return double.IsNormal(value._value);
		}

		// Token: 0x060070B4 RID: 28852 RVA: 0x0010E1EA File Offset: 0x0010C3EA
		[NonVersionable]
		public static bool IsPositiveInfinity(NFloat value)
		{
			return double.IsPositiveInfinity(value._value);
		}

		// Token: 0x060070B5 RID: 28853 RVA: 0x0010E1F7 File Offset: 0x0010C3F7
		[NonVersionable]
		public static bool IsSubnormal(NFloat value)
		{
			return double.IsSubnormal(value._value);
		}

		// Token: 0x060070B6 RID: 28854 RVA: 0x0010E204 File Offset: 0x0010C404
		[NullableContext(1)]
		public static NFloat Parse(string s)
		{
			return new NFloat(double.Parse(s));
		}

		// Token: 0x060070B7 RID: 28855 RVA: 0x0010E211 File Offset: 0x0010C411
		[NullableContext(1)]
		public static NFloat Parse(string s, NumberStyles style)
		{
			return new NFloat(double.Parse(s, style));
		}

		// Token: 0x060070B8 RID: 28856 RVA: 0x0010E21F File Offset: 0x0010C41F
		[NullableContext(1)]
		public static NFloat Parse(string s, [Nullable(2)] IFormatProvider provider)
		{
			return new NFloat(double.Parse(s, provider));
		}

		// Token: 0x060070B9 RID: 28857 RVA: 0x0010E22D File Offset: 0x0010C42D
		[NullableContext(1)]
		public static NFloat Parse(string s, NumberStyles style, [Nullable(2)] IFormatProvider provider)
		{
			return new NFloat(double.Parse(s, style, provider));
		}

		// Token: 0x060070BA RID: 28858 RVA: 0x0010E23C File Offset: 0x0010C43C
		public static NFloat Parse(ReadOnlySpan<char> s, NumberStyles style = NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent, [Nullable(2)] IFormatProvider provider = null)
		{
			return new NFloat(double.Parse(s, style, provider));
		}

		// Token: 0x060070BB RID: 28859 RVA: 0x0010E24B File Offset: 0x0010C44B
		[NullableContext(2)]
		public static bool TryParse([NotNullWhen(true)] string s, out NFloat result)
		{
			Unsafe.SkipInit<NFloat>(out result);
			return double.TryParse(s, Unsafe.As<NFloat, double>(ref result));
		}

		// Token: 0x060070BC RID: 28860 RVA: 0x0010E25F File Offset: 0x0010C45F
		public static bool TryParse(ReadOnlySpan<char> s, out NFloat result)
		{
			Unsafe.SkipInit<NFloat>(out result);
			return double.TryParse(s, Unsafe.As<NFloat, double>(ref result));
		}

		// Token: 0x060070BD RID: 28861 RVA: 0x0010E273 File Offset: 0x0010C473
		public static bool TryParse(ReadOnlySpan<byte> utf8Text, out NFloat result)
		{
			Unsafe.SkipInit<NFloat>(out result);
			return double.TryParse(utf8Text, Unsafe.As<NFloat, double>(ref result));
		}

		// Token: 0x060070BE RID: 28862 RVA: 0x0010E287 File Offset: 0x0010C487
		[NullableContext(2)]
		public static bool TryParse([NotNullWhen(true)] string s, NumberStyles style, IFormatProvider provider, out NFloat result)
		{
			Unsafe.SkipInit<NFloat>(out result);
			return double.TryParse(s, style, provider, Unsafe.As<NFloat, double>(ref result));
		}

		// Token: 0x060070BF RID: 28863 RVA: 0x0010E29D File Offset: 0x0010C49D
		public static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, [Nullable(2)] IFormatProvider provider, out NFloat result)
		{
			Unsafe.SkipInit<NFloat>(out result);
			return double.TryParse(s, style, provider, Unsafe.As<NFloat, double>(ref result));
		}

		// Token: 0x060070C0 RID: 28864 RVA: 0x0010E2B4 File Offset: 0x0010C4B4
		[NullableContext(2)]
		public int CompareTo(object obj)
		{
			if (obj is NFloat)
			{
				NFloat other = (NFloat)obj;
				return this.CompareTo(other);
			}
			if (obj == null)
			{
				return 1;
			}
			throw new ArgumentException(SR.Arg_MustBeNFloat);
		}

		// Token: 0x060070C1 RID: 28865 RVA: 0x0010E2E7 File Offset: 0x0010C4E7
		public int CompareTo(NFloat other)
		{
			return this._value.CompareTo(other._value);
		}

		// Token: 0x060070C2 RID: 28866 RVA: 0x0010E2FC File Offset: 0x0010C4FC
		[NullableContext(2)]
		public override bool Equals([NotNullWhen(true)] object obj)
		{
			if (obj is NFloat)
			{
				NFloat other = (NFloat)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x060070C3 RID: 28867 RVA: 0x0010E321 File Offset: 0x0010C521
		public bool Equals(NFloat other)
		{
			return this._value.Equals(other._value);
		}

		// Token: 0x060070C4 RID: 28868 RVA: 0x0010E334 File Offset: 0x0010C534
		public override int GetHashCode()
		{
			return this._value.GetHashCode();
		}

		// Token: 0x060070C5 RID: 28869 RVA: 0x0010E341 File Offset: 0x0010C541
		[NullableContext(1)]
		public override string ToString()
		{
			return this._value.ToString();
		}

		// Token: 0x060070C6 RID: 28870 RVA: 0x0010E34E File Offset: 0x0010C54E
		[NullableContext(1)]
		public string ToString([Nullable(2)] [StringSyntax("NumericFormat")] string format)
		{
			return this._value.ToString(format);
		}

		// Token: 0x060070C7 RID: 28871 RVA: 0x0010E35C File Offset: 0x0010C55C
		[NullableContext(1)]
		public string ToString([Nullable(2)] IFormatProvider provider)
		{
			return this._value.ToString(provider);
		}

		// Token: 0x060070C8 RID: 28872 RVA: 0x0010E36A File Offset: 0x0010C56A
		[NullableContext(2)]
		[return: Nullable(1)]
		public string ToString([StringSyntax("NumericFormat")] string format, IFormatProvider provider)
		{
			return this._value.ToString(format, provider);
		}

		// Token: 0x060070C9 RID: 28873 RVA: 0x0010E379 File Offset: 0x0010C579
		public bool TryFormat(Span<char> destination, out int charsWritten, [StringSyntax("NumericFormat")] ReadOnlySpan<char> format = default(ReadOnlySpan<char>), [Nullable(2)] IFormatProvider provider = null)
		{
			return this._value.TryFormat(destination, out charsWritten, format, provider);
		}

		// Token: 0x060070CA RID: 28874 RVA: 0x0010E38B File Offset: 0x0010C58B
		public bool TryFormat(Span<byte> utf8Destination, out int bytesWritten, [StringSyntax("NumericFormat")] ReadOnlySpan<char> format = default(ReadOnlySpan<char>), [Nullable(2)] IFormatProvider provider = null)
		{
			return this._value.TryFormat(utf8Destination, out bytesWritten, format, provider);
		}

		// Token: 0x17000DE0 RID: 3552
		// (get) Token: 0x060070CB RID: 28875 RVA: 0x0010E39D File Offset: 0x0010C59D
		NFloat IAdditiveIdentity<NFloat, NFloat>.AdditiveIdentity
		{
			get
			{
				return new NFloat(0.0);
			}
		}

		// Token: 0x17000DE1 RID: 3553
		// (get) Token: 0x060070CC RID: 28876 RVA: 0x0010E3AD File Offset: 0x0010C5AD
		NFloat IBinaryNumber<NFloat>.AllBitsSet
		{
			[NonVersionable]
			get
			{
				return (NFloat)BitConverter.UInt64BitsToDouble(ulong.MaxValue);
			}
		}

		// Token: 0x060070CD RID: 28877 RVA: 0x0010E3BB File Offset: 0x0010C5BB
		public static bool IsPow2(NFloat value)
		{
			return double.IsPow2(value._value);
		}

		// Token: 0x060070CE RID: 28878 RVA: 0x0010E3C8 File Offset: 0x0010C5C8
		public static NFloat Log2(NFloat value)
		{
			return new NFloat(double.Log2(value._value));
		}

		// Token: 0x060070CF RID: 28879 RVA: 0x0010E3DA File Offset: 0x0010C5DA
		NFloat IBitwiseOperators<NFloat, NFloat, NFloat>.op_BitwiseAnd(NFloat left, NFloat right)
		{
			return new NFloat(BitConverter.UInt64BitsToDouble(BitConverter.DoubleToUInt64Bits(left._value) & BitConverter.DoubleToUInt64Bits(right._value)));
		}

		// Token: 0x060070D0 RID: 28880 RVA: 0x0010E3FD File Offset: 0x0010C5FD
		NFloat IBitwiseOperators<NFloat, NFloat, NFloat>.op_BitwiseOr(NFloat left, NFloat right)
		{
			return new NFloat(BitConverter.UInt64BitsToDouble(BitConverter.DoubleToUInt64Bits(left._value) | BitConverter.DoubleToUInt64Bits(right._value)));
		}

		// Token: 0x060070D1 RID: 28881 RVA: 0x0010E420 File Offset: 0x0010C620
		NFloat IBitwiseOperators<NFloat, NFloat, NFloat>.op_ExclusiveOr(NFloat left, NFloat right)
		{
			return new NFloat(BitConverter.UInt64BitsToDouble(BitConverter.DoubleToUInt64Bits(left._value) ^ BitConverter.DoubleToUInt64Bits(right._value)));
		}

		// Token: 0x060070D2 RID: 28882 RVA: 0x0010E443 File Offset: 0x0010C643
		NFloat IBitwiseOperators<NFloat, NFloat, NFloat>.op_OnesComplement(NFloat value)
		{
			return new NFloat(BitConverter.UInt64BitsToDouble(~BitConverter.DoubleToUInt64Bits(value._value)));
		}

		// Token: 0x060070D3 RID: 28883 RVA: 0x0010E45B File Offset: 0x0010C65B
		public static NFloat Exp(NFloat x)
		{
			return new NFloat(double.Exp(x._value));
		}

		// Token: 0x060070D4 RID: 28884 RVA: 0x0010E46D File Offset: 0x0010C66D
		public static NFloat ExpM1(NFloat x)
		{
			return new NFloat(double.ExpM1(x._value));
		}

		// Token: 0x060070D5 RID: 28885 RVA: 0x0010E47F File Offset: 0x0010C67F
		public static NFloat Exp2(NFloat x)
		{
			return new NFloat(double.Exp2(x._value));
		}

		// Token: 0x060070D6 RID: 28886 RVA: 0x0010E491 File Offset: 0x0010C691
		public static NFloat Exp2M1(NFloat x)
		{
			return new NFloat(double.Exp2M1(x._value));
		}

		// Token: 0x060070D7 RID: 28887 RVA: 0x0010E4A3 File Offset: 0x0010C6A3
		public static NFloat Exp10(NFloat x)
		{
			return new NFloat(double.Exp10(x._value));
		}

		// Token: 0x060070D8 RID: 28888 RVA: 0x0010E4B5 File Offset: 0x0010C6B5
		public static NFloat Exp10M1(NFloat x)
		{
			return new NFloat(double.Exp10M1(x._value));
		}

		// Token: 0x060070D9 RID: 28889 RVA: 0x0010E4C7 File Offset: 0x0010C6C7
		public static NFloat Ceiling(NFloat x)
		{
			return new NFloat(double.Ceiling(x._value));
		}

		// Token: 0x060070DA RID: 28890 RVA: 0x0010E4D9 File Offset: 0x0010C6D9
		[NullableContext(1)]
		public static TInteger ConvertToInteger<[Nullable(0)] TInteger>(NFloat value) where TInteger : IBinaryInteger<TInteger>
		{
			return INumberBase<TInteger>.CreateSaturating<NFloat>(value);
		}

		// Token: 0x060070DB RID: 28891 RVA: 0x0010E4D9 File Offset: 0x0010C6D9
		[NullableContext(1)]
		public static TInteger ConvertToIntegerNative<[Nullable(0)] TInteger>(NFloat value) where TInteger : IBinaryInteger<TInteger>
		{
			return INumberBase<TInteger>.CreateSaturating<NFloat>(value);
		}

		// Token: 0x060070DC RID: 28892 RVA: 0x0010E4E7 File Offset: 0x0010C6E7
		public static NFloat Floor(NFloat x)
		{
			return new NFloat(double.Floor(x._value));
		}

		// Token: 0x060070DD RID: 28893 RVA: 0x0010E4F9 File Offset: 0x0010C6F9
		public static NFloat Round(NFloat x)
		{
			return new NFloat(double.Round(x._value));
		}

		// Token: 0x060070DE RID: 28894 RVA: 0x0010E50B File Offset: 0x0010C70B
		public static NFloat Round(NFloat x, int digits)
		{
			return new NFloat(double.Round(x._value, digits));
		}

		// Token: 0x060070DF RID: 28895 RVA: 0x0010E51E File Offset: 0x0010C71E
		public static NFloat Round(NFloat x, MidpointRounding mode)
		{
			return new NFloat(double.Round(x._value, mode));
		}

		// Token: 0x060070E0 RID: 28896 RVA: 0x0010E531 File Offset: 0x0010C731
		public static NFloat Round(NFloat x, int digits, MidpointRounding mode)
		{
			return new NFloat(double.Round(x._value, digits, mode));
		}

		// Token: 0x060070E1 RID: 28897 RVA: 0x0010E545 File Offset: 0x0010C745
		public static NFloat Truncate(NFloat x)
		{
			return new NFloat(double.Truncate(x._value));
		}

		// Token: 0x060070E2 RID: 28898 RVA: 0x000201B4 File Offset: 0x0001E3B4
		int IFloatingPoint<NFloat>.GetExponentByteCount()
		{
			return 2;
		}

		// Token: 0x060070E3 RID: 28899 RVA: 0x0010E558 File Offset: 0x0010C758
		int IFloatingPoint<NFloat>.GetExponentShortestBitLength()
		{
			short exponent = this._value.Exponent;
			if (exponent >= 0)
			{
				return (int)(16 - short.LeadingZeroCount(exponent));
			}
			return (int)(17 - short.LeadingZeroCount(~exponent));
		}

		// Token: 0x060070E4 RID: 28900 RVA: 0x0002EBDD File Offset: 0x0002CDDD
		int IFloatingPoint<NFloat>.GetSignificandByteCount()
		{
			return 8;
		}

		// Token: 0x060070E5 RID: 28901 RVA: 0x0002EBE0 File Offset: 0x0002CDE0
		int IFloatingPoint<NFloat>.GetSignificandBitLength()
		{
			return 53;
		}

		// Token: 0x060070E6 RID: 28902 RVA: 0x0010E58C File Offset: 0x0010C78C
		bool IFloatingPoint<NFloat>.TryWriteExponentBigEndian(Span<byte> destination, out int bytesWritten)
		{
			if (destination.Length >= 2)
			{
				short value = this._value.Exponent;
				bool isLittleEndian = BitConverter.IsLittleEndian;
				value = BinaryPrimitives.ReverseEndianness(value);
				Unsafe.WriteUnaligned<short>(MemoryMarshal.GetReference<byte>(destination), value);
				bytesWritten = 2;
				return true;
			}
			bytesWritten = 0;
			return false;
		}

		// Token: 0x060070E7 RID: 28903 RVA: 0x0010E5D4 File Offset: 0x0010C7D4
		bool IFloatingPoint<NFloat>.TryWriteExponentLittleEndian(Span<byte> destination, out int bytesWritten)
		{
			if (destination.Length >= 2)
			{
				short exponent = this._value.Exponent;
				if (!BitConverter.IsLittleEndian)
				{
				}
				Unsafe.WriteUnaligned<short>(MemoryMarshal.GetReference<byte>(destination), exponent);
				bytesWritten = 2;
				return true;
			}
			bytesWritten = 0;
			return false;
		}

		// Token: 0x060070E8 RID: 28904 RVA: 0x0010E614 File Offset: 0x0010C814
		bool IFloatingPoint<NFloat>.TryWriteSignificandBigEndian(Span<byte> destination, out int bytesWritten)
		{
			if (destination.Length >= 8)
			{
				ulong value = this._value.Significand;
				bool isLittleEndian = BitConverter.IsLittleEndian;
				value = BinaryPrimitives.ReverseEndianness(value);
				Unsafe.WriteUnaligned<ulong>(MemoryMarshal.GetReference<byte>(destination), value);
				bytesWritten = 8;
				return true;
			}
			bytesWritten = 0;
			return false;
		}

		// Token: 0x060070E9 RID: 28905 RVA: 0x0010E65C File Offset: 0x0010C85C
		bool IFloatingPoint<NFloat>.TryWriteSignificandLittleEndian(Span<byte> destination, out int bytesWritten)
		{
			if (destination.Length >= 8)
			{
				ulong significand = this._value.Significand;
				if (!BitConverter.IsLittleEndian)
				{
				}
				Unsafe.WriteUnaligned<ulong>(MemoryMarshal.GetReference<byte>(destination), significand);
				bytesWritten = 8;
				return true;
			}
			bytesWritten = 0;
			return false;
		}

		// Token: 0x17000DE2 RID: 3554
		// (get) Token: 0x060070EA RID: 28906 RVA: 0x0010E69B File Offset: 0x0010C89B
		public static NFloat E
		{
			get
			{
				return new NFloat(2.718281828459045);
			}
		}

		// Token: 0x17000DE3 RID: 3555
		// (get) Token: 0x060070EB RID: 28907 RVA: 0x0010E6AB File Offset: 0x0010C8AB
		public static NFloat Pi
		{
			get
			{
				return new NFloat(3.141592653589793);
			}
		}

		// Token: 0x17000DE4 RID: 3556
		// (get) Token: 0x060070EC RID: 28908 RVA: 0x0010E6BB File Offset: 0x0010C8BB
		public static NFloat Tau
		{
			get
			{
				return new NFloat(6.283185307179586);
			}
		}

		// Token: 0x17000DE5 RID: 3557
		// (get) Token: 0x060070ED RID: 28909 RVA: 0x0010E6CB File Offset: 0x0010C8CB
		public static NFloat NegativeZero
		{
			get
			{
				return new NFloat(--0.0);
			}
		}

		// Token: 0x060070EE RID: 28910 RVA: 0x0010E6DB File Offset: 0x0010C8DB
		public static NFloat Atan2(NFloat y, NFloat x)
		{
			return new NFloat(double.Atan2(y._value, x._value));
		}

		// Token: 0x060070EF RID: 28911 RVA: 0x0010E6F3 File Offset: 0x0010C8F3
		public static NFloat Atan2Pi(NFloat y, NFloat x)
		{
			return new NFloat(double.Atan2Pi(y._value, x._value));
		}

		// Token: 0x060070F0 RID: 28912 RVA: 0x0010E70B File Offset: 0x0010C90B
		public static NFloat BitDecrement(NFloat x)
		{
			return new NFloat(double.BitDecrement(x._value));
		}

		// Token: 0x060070F1 RID: 28913 RVA: 0x0010E71D File Offset: 0x0010C91D
		public static NFloat BitIncrement(NFloat x)
		{
			return new NFloat(double.BitIncrement(x._value));
		}

		// Token: 0x060070F2 RID: 28914 RVA: 0x0010E72F File Offset: 0x0010C92F
		public static NFloat FusedMultiplyAdd(NFloat left, NFloat right, NFloat addend)
		{
			return new NFloat(double.FusedMultiplyAdd(left._value, right._value, addend._value));
		}

		// Token: 0x060070F3 RID: 28915 RVA: 0x0010E74D File Offset: 0x0010C94D
		public static NFloat Ieee754Remainder(NFloat left, NFloat right)
		{
			return new NFloat(double.Ieee754Remainder(left._value, right._value));
		}

		// Token: 0x060070F4 RID: 28916 RVA: 0x0010E765 File Offset: 0x0010C965
		public static int ILogB(NFloat x)
		{
			return double.ILogB(x._value);
		}

		// Token: 0x060070F5 RID: 28917 RVA: 0x0010E772 File Offset: 0x0010C972
		public static NFloat Lerp(NFloat value1, NFloat value2, NFloat amount)
		{
			return new NFloat(double.Lerp(value1._value, value2._value, amount._value));
		}

		// Token: 0x060070F6 RID: 28918 RVA: 0x0010E790 File Offset: 0x0010C990
		public static NFloat ReciprocalEstimate(NFloat x)
		{
			return new NFloat(double.ReciprocalEstimate(x._value));
		}

		// Token: 0x060070F7 RID: 28919 RVA: 0x0010E7A2 File Offset: 0x0010C9A2
		public static NFloat ReciprocalSqrtEstimate(NFloat x)
		{
			return new NFloat(double.ReciprocalSqrtEstimate(x._value));
		}

		// Token: 0x060070F8 RID: 28920 RVA: 0x0010E7B4 File Offset: 0x0010C9B4
		public static NFloat ScaleB(NFloat x, int n)
		{
			return new NFloat(double.ScaleB(x._value, n));
		}

		// Token: 0x060070F9 RID: 28921 RVA: 0x0010E7C7 File Offset: 0x0010C9C7
		public static NFloat Acosh(NFloat x)
		{
			return new NFloat(double.Acosh(x._value));
		}

		// Token: 0x060070FA RID: 28922 RVA: 0x0010E7D9 File Offset: 0x0010C9D9
		public static NFloat Asinh(NFloat x)
		{
			return new NFloat(double.Asinh(x._value));
		}

		// Token: 0x060070FB RID: 28923 RVA: 0x0010E7EB File Offset: 0x0010C9EB
		public static NFloat Atanh(NFloat x)
		{
			return new NFloat(double.Atanh(x._value));
		}

		// Token: 0x060070FC RID: 28924 RVA: 0x0010E7FD File Offset: 0x0010C9FD
		public static NFloat Cosh(NFloat x)
		{
			return new NFloat(double.Cosh(x._value));
		}

		// Token: 0x060070FD RID: 28925 RVA: 0x0010E80F File Offset: 0x0010CA0F
		public static NFloat Sinh(NFloat x)
		{
			return new NFloat(double.Sinh(x._value));
		}

		// Token: 0x060070FE RID: 28926 RVA: 0x0010E821 File Offset: 0x0010CA21
		public static NFloat Tanh(NFloat x)
		{
			return new NFloat(double.Tanh(x._value));
		}

		// Token: 0x060070FF RID: 28927 RVA: 0x0010E833 File Offset: 0x0010CA33
		public static NFloat Log(NFloat x)
		{
			return new NFloat(double.Log(x._value));
		}

		// Token: 0x06007100 RID: 28928 RVA: 0x0010E845 File Offset: 0x0010CA45
		public static NFloat Log(NFloat x, NFloat newBase)
		{
			return new NFloat(double.Log(x._value, newBase._value));
		}

		// Token: 0x06007101 RID: 28929 RVA: 0x0010E85D File Offset: 0x0010CA5D
		public static NFloat LogP1(NFloat x)
		{
			return new NFloat(double.LogP1(x._value));
		}

		// Token: 0x06007102 RID: 28930 RVA: 0x0010E86F File Offset: 0x0010CA6F
		public static NFloat Log2P1(NFloat x)
		{
			return new NFloat(double.Log2P1(x._value));
		}

		// Token: 0x06007103 RID: 28931 RVA: 0x0010E881 File Offset: 0x0010CA81
		public static NFloat Log10(NFloat x)
		{
			return new NFloat(double.Log10(x._value));
		}

		// Token: 0x06007104 RID: 28932 RVA: 0x0010E893 File Offset: 0x0010CA93
		public static NFloat Log10P1(NFloat x)
		{
			return new NFloat(double.Log10P1(x._value));
		}

		// Token: 0x17000DE6 RID: 3558
		// (get) Token: 0x06007105 RID: 28933 RVA: 0x0010E8A5 File Offset: 0x0010CAA5
		NFloat IMultiplicativeIdentity<NFloat, NFloat>.MultiplicativeIdentity
		{
			get
			{
				return new NFloat(1.0);
			}
		}

		// Token: 0x06007106 RID: 28934 RVA: 0x0010E8B5 File Offset: 0x0010CAB5
		public static NFloat Clamp(NFloat value, NFloat min, NFloat max)
		{
			return new NFloat(double.Clamp(value._value, min._value, max._value));
		}

		// Token: 0x06007107 RID: 28935 RVA: 0x0010E8D3 File Offset: 0x0010CAD3
		public static NFloat CopySign(NFloat value, NFloat sign)
		{
			return new NFloat(double.CopySign(value._value, sign._value));
		}

		// Token: 0x06007108 RID: 28936 RVA: 0x0010E8EB File Offset: 0x0010CAEB
		public static NFloat Max(NFloat x, NFloat y)
		{
			return new NFloat(double.Max(x._value, y._value));
		}

		// Token: 0x06007109 RID: 28937 RVA: 0x0010E903 File Offset: 0x0010CB03
		public static NFloat MaxNumber(NFloat x, NFloat y)
		{
			return new NFloat(double.MaxNumber(x._value, y._value));
		}

		// Token: 0x0600710A RID: 28938 RVA: 0x0010E91B File Offset: 0x0010CB1B
		public static NFloat Min(NFloat x, NFloat y)
		{
			return new NFloat(double.Min(x._value, y._value));
		}

		// Token: 0x0600710B RID: 28939 RVA: 0x0010E933 File Offset: 0x0010CB33
		public static NFloat MinNumber(NFloat x, NFloat y)
		{
			return new NFloat(double.MinNumber(x._value, y._value));
		}

		// Token: 0x0600710C RID: 28940 RVA: 0x0010E94B File Offset: 0x0010CB4B
		public static int Sign(NFloat value)
		{
			return double.Sign(value._value);
		}

		// Token: 0x17000DE7 RID: 3559
		// (get) Token: 0x0600710D RID: 28941 RVA: 0x0010E8A5 File Offset: 0x0010CAA5
		NFloat INumberBase<NFloat>.One
		{
			get
			{
				return new NFloat(1.0);
			}
		}

		// Token: 0x17000DE8 RID: 3560
		// (get) Token: 0x0600710E RID: 28942 RVA: 0x000201B4 File Offset: 0x0001E3B4
		int INumberBase<NFloat>.Radix
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x17000DE9 RID: 3561
		// (get) Token: 0x0600710F RID: 28943 RVA: 0x0010E39D File Offset: 0x0010C59D
		NFloat INumberBase<NFloat>.Zero
		{
			get
			{
				return new NFloat(0.0);
			}
		}

		// Token: 0x06007110 RID: 28944 RVA: 0x0010E958 File Offset: 0x0010CB58
		public static NFloat Abs(NFloat value)
		{
			return new NFloat(double.Abs(value._value));
		}

		// Token: 0x06007111 RID: 28945 RVA: 0x0010E96C File Offset: 0x0010CB6C
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static NFloat CreateChecked<[Nullable(0)] TOther>(TOther value) where TOther : INumberBase<TOther>
		{
			NFloat result;
			if (typeof(TOther) == typeof(NFloat))
			{
				result = (NFloat)((object)value);
			}
			else if (!NFloat.TryConvertFrom<TOther>(value, out result) && !INumberBase<TOther>.TryConvertToChecked<NFloat>(value, out result))
			{
				ThrowHelper.ThrowNotSupportedException();
			}
			return result;
		}

		// Token: 0x06007112 RID: 28946 RVA: 0x0010E9C4 File Offset: 0x0010CBC4
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static NFloat CreateSaturating<[Nullable(0)] TOther>(TOther value) where TOther : INumberBase<TOther>
		{
			NFloat result;
			if (typeof(TOther) == typeof(NFloat))
			{
				result = (NFloat)((object)value);
			}
			else if (!NFloat.TryConvertFrom<TOther>(value, out result) && !INumberBase<TOther>.TryConvertToSaturating<NFloat>(value, out result))
			{
				ThrowHelper.ThrowNotSupportedException();
			}
			return result;
		}

		// Token: 0x06007113 RID: 28947 RVA: 0x0010EA1C File Offset: 0x0010CC1C
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static NFloat CreateTruncating<[Nullable(0)] TOther>(TOther value) where TOther : INumberBase<TOther>
		{
			NFloat result;
			if (typeof(TOther) == typeof(NFloat))
			{
				result = (NFloat)((object)value);
			}
			else if (!NFloat.TryConvertFrom<TOther>(value, out result) && !INumberBase<TOther>.TryConvertToTruncating<NFloat>(value, out result))
			{
				ThrowHelper.ThrowNotSupportedException();
			}
			return result;
		}

		// Token: 0x06007114 RID: 28948 RVA: 0x000070DD File Offset: 0x000052DD
		bool INumberBase<NFloat>.IsCanonical(NFloat value)
		{
			return true;
		}

		// Token: 0x06007115 RID: 28949 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<NFloat>.IsComplexNumber(NFloat value)
		{
			return false;
		}

		// Token: 0x06007116 RID: 28950 RVA: 0x0010EA72 File Offset: 0x0010CC72
		public static bool IsEvenInteger(NFloat value)
		{
			return double.IsEvenInteger(value._value);
		}

		// Token: 0x06007117 RID: 28951 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<NFloat>.IsImaginaryNumber(NFloat value)
		{
			return false;
		}

		// Token: 0x06007118 RID: 28952 RVA: 0x0010EA7F File Offset: 0x0010CC7F
		public static bool IsInteger(NFloat value)
		{
			return double.IsInteger(value._value);
		}

		// Token: 0x06007119 RID: 28953 RVA: 0x0010EA8C File Offset: 0x0010CC8C
		public static bool IsOddInteger(NFloat value)
		{
			return double.IsOddInteger(value._value);
		}

		// Token: 0x0600711A RID: 28954 RVA: 0x0010EA99 File Offset: 0x0010CC99
		public static bool IsPositive(NFloat value)
		{
			return double.IsPositive(value._value);
		}

		// Token: 0x0600711B RID: 28955 RVA: 0x0010EAA6 File Offset: 0x0010CCA6
		public static bool IsRealNumber(NFloat value)
		{
			return double.IsRealNumber(value._value);
		}

		// Token: 0x0600711C RID: 28956 RVA: 0x0010EAB3 File Offset: 0x0010CCB3
		bool INumberBase<NFloat>.IsZero(NFloat value)
		{
			return value == 0;
		}

		// Token: 0x0600711D RID: 28957 RVA: 0x0010EAC1 File Offset: 0x0010CCC1
		public static NFloat MaxMagnitude(NFloat x, NFloat y)
		{
			return new NFloat(double.MaxMagnitude(x._value, y._value));
		}

		// Token: 0x0600711E RID: 28958 RVA: 0x0010EAD9 File Offset: 0x0010CCD9
		public static NFloat MaxMagnitudeNumber(NFloat x, NFloat y)
		{
			return new NFloat(double.MaxMagnitudeNumber(x._value, y._value));
		}

		// Token: 0x0600711F RID: 28959 RVA: 0x0010EAF1 File Offset: 0x0010CCF1
		public static NFloat MinMagnitude(NFloat x, NFloat y)
		{
			return new NFloat(double.MinMagnitude(x._value, y._value));
		}

		// Token: 0x06007120 RID: 28960 RVA: 0x0010EB09 File Offset: 0x0010CD09
		public static NFloat MinMagnitudeNumber(NFloat x, NFloat y)
		{
			return new NFloat(double.MinMagnitudeNumber(x._value, y._value));
		}

		// Token: 0x06007121 RID: 28961 RVA: 0x0010EB21 File Offset: 0x0010CD21
		public static NFloat MultiplyAddEstimate(NFloat left, NFloat right, NFloat addend)
		{
			return new NFloat(double.MultiplyAddEstimate(left._value, right._value, addend._value));
		}

		// Token: 0x06007122 RID: 28962 RVA: 0x0010EB3F File Offset: 0x0010CD3F
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<NFloat>.TryConvertFromChecked<TOther>(TOther value, out NFloat result) where TOther : INumberBase<TOther>
		{
			return NFloat.TryConvertFrom<TOther>(value, out result);
		}

		// Token: 0x06007123 RID: 28963 RVA: 0x0010EB3F File Offset: 0x0010CD3F
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<NFloat>.TryConvertFromSaturating<TOther>(TOther value, out NFloat result) where TOther : INumberBase<TOther>
		{
			return NFloat.TryConvertFrom<TOther>(value, out result);
		}

		// Token: 0x06007124 RID: 28964 RVA: 0x0010EB3F File Offset: 0x0010CD3F
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<NFloat>.TryConvertFromTruncating<TOther>(TOther value, out NFloat result) where TOther : INumberBase<TOther>
		{
			return NFloat.TryConvertFrom<TOther>(value, out result);
		}

		// Token: 0x06007125 RID: 28965 RVA: 0x0010EB48 File Offset: 0x0010CD48
		private static bool TryConvertFrom<TOther>(TOther value, out NFloat result) where TOther : INumberBase<TOther>
		{
			if (typeof(TOther) == typeof(byte))
			{
				byte value2 = (byte)((object)value);
				result = value2;
				return true;
			}
			if (typeof(TOther) == typeof(char))
			{
				char value3 = (char)((object)value);
				result = value3;
				return true;
			}
			if (typeof(TOther) == typeof(decimal))
			{
				decimal value4 = (decimal)((object)value);
				result = (NFloat)value4;
				return true;
			}
			if (typeof(TOther) == typeof(double))
			{
				double value5 = (double)((object)value);
				result = (NFloat)value5;
				return true;
			}
			if (typeof(TOther) == typeof(Half))
			{
				Half value6 = (Half)((object)value);
				result = value6;
				return true;
			}
			if (typeof(TOther) == typeof(short))
			{
				short value7 = (short)((object)value);
				result = value7;
				return true;
			}
			if (typeof(TOther) == typeof(int))
			{
				int value8 = (int)((object)value);
				result = value8;
				return true;
			}
			if (typeof(TOther) == typeof(long))
			{
				long value9 = (long)((object)value);
				result = value9;
				return true;
			}
			if (typeof(TOther) == typeof(Int128))
			{
				Int128 value10 = (Int128)((object)value);
				result = (NFloat)value10;
				return true;
			}
			if (typeof(TOther) == typeof(IntPtr))
			{
				IntPtr value11 = (IntPtr)((object)value);
				result = value11;
				return true;
			}
			if (typeof(TOther) == typeof(sbyte))
			{
				sbyte value12 = (sbyte)((object)value);
				result = value12;
				return true;
			}
			if (typeof(TOther) == typeof(float))
			{
				float value13 = (float)((object)value);
				result = value13;
				return true;
			}
			if (typeof(TOther) == typeof(ushort))
			{
				ushort value14 = (ushort)((object)value);
				result = value14;
				return true;
			}
			if (typeof(TOther) == typeof(uint))
			{
				uint value15 = (uint)((object)value);
				result = value15;
				return true;
			}
			if (typeof(TOther) == typeof(ulong))
			{
				ulong value16 = (ulong)((object)value);
				result = value16;
				return true;
			}
			if (typeof(TOther) == typeof(UInt128))
			{
				UInt128 value17 = (UInt128)((object)value);
				result = (NFloat)value17;
				return true;
			}
			if (typeof(TOther) == typeof(UIntPtr))
			{
				UIntPtr value18 = (UIntPtr)((object)value);
				result = value18;
				return true;
			}
			result = default(NFloat);
			return false;
		}

		// Token: 0x06007126 RID: 28966 RVA: 0x0010EEFC File Offset: 0x0010D0FC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<NFloat>.TryConvertToChecked<TOther>(NFloat value, [MaybeNullWhen(false)] out TOther result) where TOther : INumberBase<TOther>
		{
			if (typeof(TOther) == typeof(byte))
			{
				byte b = NFloat.op_CheckedExplicit(value);
				result = (TOther)((object)b);
				return true;
			}
			if (typeof(TOther) == typeof(char))
			{
				char c = NFloat.op_CheckedExplicit(value);
				result = (TOther)((object)c);
				return true;
			}
			if (typeof(TOther) == typeof(decimal))
			{
				decimal num = (decimal)value;
				result = (TOther)((object)num);
				return true;
			}
			if (typeof(TOther) == typeof(double))
			{
				double num2 = value;
				result = (TOther)((object)num2);
				return true;
			}
			if (typeof(TOther) == typeof(Half))
			{
				Half half = (Half)value;
				result = (TOther)((object)half);
				return true;
			}
			if (typeof(TOther) == typeof(short))
			{
				short num3 = NFloat.op_CheckedExplicit(value);
				result = (TOther)((object)num3);
				return true;
			}
			if (typeof(TOther) == typeof(int))
			{
				int num4 = NFloat.op_CheckedExplicit(value);
				result = (TOther)((object)num4);
				return true;
			}
			if (typeof(TOther) == typeof(long))
			{
				long num5 = NFloat.op_CheckedExplicit(value);
				result = (TOther)((object)num5);
				return true;
			}
			if (typeof(TOther) == typeof(Int128))
			{
				Int128 @int = NFloat.op_CheckedExplicit(value);
				result = (TOther)((object)@int);
				return true;
			}
			if (typeof(TOther) == typeof(IntPtr))
			{
				IntPtr intPtr = NFloat.op_CheckedExplicit(value);
				result = (TOther)((object)intPtr);
				return true;
			}
			if (typeof(TOther) == typeof(sbyte))
			{
				sbyte b2 = NFloat.op_CheckedExplicit(value);
				result = (TOther)((object)b2);
				return true;
			}
			if (typeof(TOther) == typeof(float))
			{
				float num6 = (float)value;
				result = (TOther)((object)num6);
				return true;
			}
			if (typeof(TOther) == typeof(ushort))
			{
				ushort num7 = NFloat.op_CheckedExplicit(value);
				result = (TOther)((object)num7);
				return true;
			}
			if (typeof(TOther) == typeof(uint))
			{
				uint num8 = NFloat.op_CheckedExplicit(value);
				result = (TOther)((object)num8);
				return true;
			}
			if (typeof(TOther) == typeof(ulong))
			{
				ulong num9 = NFloat.op_CheckedExplicit(value);
				result = (TOther)((object)num9);
				return true;
			}
			if (typeof(TOther) == typeof(UInt128))
			{
				UInt128 @uint = NFloat.op_CheckedExplicit(value);
				result = (TOther)((object)@uint);
				return true;
			}
			if (typeof(TOther) == typeof(UIntPtr))
			{
				UIntPtr uintPtr = NFloat.op_CheckedExplicit(value);
				result = (TOther)((object)uintPtr);
				return true;
			}
			result = default(TOther);
			return false;
		}

		// Token: 0x06007127 RID: 28967 RVA: 0x0010F2B1 File Offset: 0x0010D4B1
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<NFloat>.TryConvertToSaturating<TOther>(NFloat value, [MaybeNullWhen(false)] out TOther result) where TOther : INumberBase<TOther>
		{
			return NFloat.TryConvertTo<TOther>(value, out result);
		}

		// Token: 0x06007128 RID: 28968 RVA: 0x0010F2B1 File Offset: 0x0010D4B1
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<NFloat>.TryConvertToTruncating<TOther>(NFloat value, [MaybeNullWhen(false)] out TOther result) where TOther : INumberBase<TOther>
		{
			return NFloat.TryConvertTo<TOther>(value, out result);
		}

		// Token: 0x06007129 RID: 28969 RVA: 0x0010F2BC File Offset: 0x0010D4BC
		private static bool TryConvertTo<TOther>(NFloat value, [MaybeNullWhen(false)] out TOther result) where TOther : INumberBase<TOther>
		{
			if (typeof(TOther) == typeof(byte))
			{
				byte b = (value >= byte.MaxValue) ? byte.MaxValue : ((value <= 0) ? 0 : ((byte)value));
				result = (TOther)((object)b);
				return true;
			}
			if (typeof(TOther) == typeof(char))
			{
				char c = (value >= char.MaxValue) ? char.MaxValue : ((value <= '\0') ? '\0' : ((char)value));
				result = (TOther)((object)c);
				return true;
			}
			if (typeof(TOther) == typeof(decimal))
			{
				decimal num = (value >= 7.9228163E+28f) ? decimal.MaxValue : ((value <= -7.9228163E+28f) ? decimal.MinValue : (NFloat.IsNaN(value) ? 0.0m : ((decimal)value)));
				result = (TOther)((object)num);
				return true;
			}
			if (typeof(TOther) == typeof(double))
			{
				double num2 = value;
				result = (TOther)((object)num2);
				return true;
			}
			if (typeof(TOther) == typeof(Half))
			{
				Half half = (Half)value;
				result = (TOther)((object)half);
				return true;
			}
			if (typeof(TOther) == typeof(short))
			{
				short num3 = (value >= short.MaxValue) ? short.MaxValue : ((value <= short.MinValue) ? short.MinValue : ((short)value));
				result = (TOther)((object)num3);
				return true;
			}
			if (typeof(TOther) == typeof(int))
			{
				int num4 = (value >= int.MaxValue) ? int.MaxValue : ((value <= int.MinValue) ? int.MinValue : ((int)value));
				result = (TOther)((object)num4);
				return true;
			}
			if (typeof(TOther) == typeof(long))
			{
				long num5 = (value >= long.MaxValue) ? long.MaxValue : ((value <= long.MinValue) ? long.MinValue : ((long)value));
				result = (TOther)((object)num5);
				return true;
			}
			if (typeof(TOther) == typeof(Int128))
			{
				Int128 @int = (value >= 1.7014118346046923E+38) ? Int128.MaxValue : ((value <= -1.7014118346046923E+38) ? Int128.MinValue : ((Int128)value));
				result = (TOther)((object)@int);
				return true;
			}
			if (typeof(TOther) == typeof(IntPtr))
			{
				IntPtr intPtr = (value >= IntPtr.MaxValue) ? IntPtr.MaxValue : ((value <= IntPtr.MinValue) ? IntPtr.MinValue : ((IntPtr)value));
				result = (TOther)((object)intPtr);
				return true;
			}
			if (typeof(TOther) == typeof(sbyte))
			{
				sbyte b2 = (value >= sbyte.MaxValue) ? sbyte.MaxValue : ((value <= sbyte.MinValue) ? sbyte.MinValue : ((sbyte)value));
				result = (TOther)((object)b2);
				return true;
			}
			if (typeof(TOther) == typeof(float))
			{
				float num6 = (float)value;
				result = (TOther)((object)num6);
				return true;
			}
			if (typeof(TOther) == typeof(ushort))
			{
				ushort num7 = (value >= ushort.MaxValue) ? ushort.MaxValue : ((value <= 0) ? 0 : ((ushort)value));
				result = (TOther)((object)num7);
				return true;
			}
			if (typeof(TOther) == typeof(uint))
			{
				uint num8 = (value >= uint.MaxValue) ? uint.MaxValue : ((value <= 0U) ? 0U : ((uint)value));
				result = (TOther)((object)num8);
				return true;
			}
			if (typeof(TOther) == typeof(ulong))
			{
				ulong num9 = (value >= ulong.MaxValue) ? ulong.MaxValue : ((value <= 0UL) ? 0UL : (NFloat.IsNaN(value) ? 0UL : ((ulong)value)));
				result = (TOther)((object)num9);
				return true;
			}
			if (typeof(TOther) == typeof(UInt128))
			{
				UInt128 @uint = (value >= 3.402823669209385E+38) ? UInt128.MaxValue : ((value <= 0.0) ? UInt128.MinValue : ((UInt128)value));
				result = (TOther)((object)@uint);
				return true;
			}
			if (typeof(TOther) == typeof(UIntPtr))
			{
				UIntPtr uintPtr = (value >= ulong.MaxValue) ? ((UIntPtr)(-1L)) : ((UIntPtr)((value <= 0UL) ? ((IntPtr)0) : ((IntPtr)((UIntPtr)value))));
				result = (TOther)((object)uintPtr);
				return true;
			}
			result = default(TOther);
			return false;
		}

		// Token: 0x0600712A RID: 28970 RVA: 0x0010F918 File Offset: 0x0010DB18
		[NullableContext(2)]
		public static bool TryParse([NotNullWhen(true)] string s, IFormatProvider provider, out NFloat result)
		{
			return NFloat.TryParse(s, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent, provider, out result);
		}

		// Token: 0x0600712B RID: 28971 RVA: 0x0010F927 File Offset: 0x0010DB27
		public static NFloat Pow(NFloat x, NFloat y)
		{
			return new NFloat(double.Pow(x._value, y._value));
		}

		// Token: 0x0600712C RID: 28972 RVA: 0x0010F93F File Offset: 0x0010DB3F
		public static NFloat Cbrt(NFloat x)
		{
			return new NFloat(double.Cbrt(x._value));
		}

		// Token: 0x0600712D RID: 28973 RVA: 0x0010F951 File Offset: 0x0010DB51
		public static NFloat Hypot(NFloat x, NFloat y)
		{
			return new NFloat(double.Hypot(x._value, y._value));
		}

		// Token: 0x0600712E RID: 28974 RVA: 0x0010F969 File Offset: 0x0010DB69
		public static NFloat RootN(NFloat x, int n)
		{
			return new NFloat(double.RootN(x._value, n));
		}

		// Token: 0x0600712F RID: 28975 RVA: 0x0010F97C File Offset: 0x0010DB7C
		public static NFloat Sqrt(NFloat x)
		{
			return new NFloat(double.Sqrt(x._value));
		}

		// Token: 0x17000DEA RID: 3562
		// (get) Token: 0x06007130 RID: 28976 RVA: 0x0010F98E File Offset: 0x0010DB8E
		NFloat ISignedNumber<NFloat>.NegativeOne
		{
			get
			{
				return new NFloat(-1.0);
			}
		}

		// Token: 0x06007131 RID: 28977 RVA: 0x0010F99E File Offset: 0x0010DB9E
		public static NFloat Parse(ReadOnlySpan<char> s, [Nullable(2)] IFormatProvider provider)
		{
			return NFloat.Parse(s, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent, provider);
		}

		// Token: 0x06007132 RID: 28978 RVA: 0x0010F9AC File Offset: 0x0010DBAC
		public static bool TryParse(ReadOnlySpan<char> s, [Nullable(2)] IFormatProvider provider, out NFloat result)
		{
			return NFloat.TryParse(s, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent, provider, out result);
		}

		// Token: 0x06007133 RID: 28979 RVA: 0x0010F9BB File Offset: 0x0010DBBB
		public static NFloat Acos(NFloat x)
		{
			return new NFloat(double.Acos(x._value));
		}

		// Token: 0x06007134 RID: 28980 RVA: 0x0010F9CD File Offset: 0x0010DBCD
		public static NFloat AcosPi(NFloat x)
		{
			return new NFloat(double.AcosPi(x._value));
		}

		// Token: 0x06007135 RID: 28981 RVA: 0x0010F9DF File Offset: 0x0010DBDF
		public static NFloat Asin(NFloat x)
		{
			return new NFloat(double.Asin(x._value));
		}

		// Token: 0x06007136 RID: 28982 RVA: 0x0010F9F1 File Offset: 0x0010DBF1
		public static NFloat AsinPi(NFloat x)
		{
			return new NFloat(double.AsinPi(x._value));
		}

		// Token: 0x06007137 RID: 28983 RVA: 0x0010FA03 File Offset: 0x0010DC03
		public static NFloat Atan(NFloat x)
		{
			return new NFloat(double.Atan(x._value));
		}

		// Token: 0x06007138 RID: 28984 RVA: 0x0010FA15 File Offset: 0x0010DC15
		public static NFloat AtanPi(NFloat x)
		{
			return new NFloat(double.AtanPi(x._value));
		}

		// Token: 0x06007139 RID: 28985 RVA: 0x0010FA27 File Offset: 0x0010DC27
		public static NFloat Cos(NFloat x)
		{
			return new NFloat(double.Cos(x._value));
		}

		// Token: 0x0600713A RID: 28986 RVA: 0x0010FA39 File Offset: 0x0010DC39
		public static NFloat CosPi(NFloat x)
		{
			return new NFloat(double.CosPi(x._value));
		}

		// Token: 0x0600713B RID: 28987 RVA: 0x0010FA4B File Offset: 0x0010DC4B
		public static NFloat DegreesToRadians(NFloat degrees)
		{
			return new NFloat(double.DegreesToRadians(degrees._value));
		}

		// Token: 0x0600713C RID: 28988 RVA: 0x0010FA5D File Offset: 0x0010DC5D
		public static NFloat RadiansToDegrees(NFloat radians)
		{
			return new NFloat(double.RadiansToDegrees(radians._value));
		}

		// Token: 0x0600713D RID: 28989 RVA: 0x0010FA6F File Offset: 0x0010DC6F
		public static NFloat Sin(NFloat x)
		{
			return new NFloat(double.Sin(x._value));
		}

		// Token: 0x0600713E RID: 28990 RVA: 0x0010FA84 File Offset: 0x0010DC84
		[return: TupleElementNames(new string[]
		{
			"Sin",
			"Cos"
		})]
		public static ValueTuple<NFloat, NFloat> SinCos(NFloat x)
		{
			ValueTuple<double, double> valueTuple = double.SinCos(x._value);
			double item = valueTuple.Item1;
			double item2 = valueTuple.Item2;
			return new ValueTuple<NFloat, NFloat>(new NFloat(item), new NFloat(item2));
		}

		// Token: 0x0600713F RID: 28991 RVA: 0x0010FABC File Offset: 0x0010DCBC
		[return: TupleElementNames(new string[]
		{
			"SinPi",
			"CosPi"
		})]
		public static ValueTuple<NFloat, NFloat> SinCosPi(NFloat x)
		{
			ValueTuple<double, double> valueTuple = double.SinCosPi(x._value);
			double item = valueTuple.Item1;
			double item2 = valueTuple.Item2;
			return new ValueTuple<NFloat, NFloat>(new NFloat(item), new NFloat(item2));
		}

		// Token: 0x06007140 RID: 28992 RVA: 0x0010FAF2 File Offset: 0x0010DCF2
		public static NFloat SinPi(NFloat x)
		{
			return new NFloat(double.SinPi(x._value));
		}

		// Token: 0x06007141 RID: 28993 RVA: 0x0010FB04 File Offset: 0x0010DD04
		public static NFloat Tan(NFloat x)
		{
			return new NFloat(double.Tan(x._value));
		}

		// Token: 0x06007142 RID: 28994 RVA: 0x0010FB16 File Offset: 0x0010DD16
		public static NFloat TanPi(NFloat x)
		{
			return new NFloat(double.TanPi(x._value));
		}

		// Token: 0x06007143 RID: 28995 RVA: 0x0010FB28 File Offset: 0x0010DD28
		public static NFloat Parse(ReadOnlySpan<byte> utf8Text, NumberStyles style = NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent, [Nullable(2)] IFormatProvider provider = null)
		{
			return new NFloat(double.Parse(utf8Text, style, provider));
		}

		// Token: 0x06007144 RID: 28996 RVA: 0x0010FB37 File Offset: 0x0010DD37
		public static bool TryParse(ReadOnlySpan<byte> utf8Text, NumberStyles style, [Nullable(2)] IFormatProvider provider, out NFloat result)
		{
			Unsafe.SkipInit<NFloat>(out result);
			return double.TryParse(utf8Text, style, provider, Unsafe.As<NFloat, double>(ref result));
		}

		// Token: 0x06007145 RID: 28997 RVA: 0x0010FB4D File Offset: 0x0010DD4D
		public static NFloat Parse(ReadOnlySpan<byte> utf8Text, [Nullable(2)] IFormatProvider provider)
		{
			return NFloat.Parse(utf8Text, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent, provider);
		}

		// Token: 0x06007146 RID: 28998 RVA: 0x0010FB5B File Offset: 0x0010DD5B
		public static bool TryParse(ReadOnlySpan<byte> utf8Text, [Nullable(2)] IFormatProvider provider, out NFloat result)
		{
			return NFloat.TryParse(utf8Text, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent, provider, out result);
		}

		// Token: 0x040012B1 RID: 4785
		private readonly double _value;
	}
}
