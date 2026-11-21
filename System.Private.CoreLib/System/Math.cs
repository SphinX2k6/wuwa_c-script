using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
using System.Runtime.Versioning;

namespace System
{
	// Token: 0x02000089 RID: 137
	public static class Math
	{
		// Token: 0x06000472 RID: 1138
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double Acos(double d);

		// Token: 0x06000473 RID: 1139
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double Acosh(double d);

		// Token: 0x06000474 RID: 1140
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double Asin(double d);

		// Token: 0x06000475 RID: 1141
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double Asinh(double d);

		// Token: 0x06000476 RID: 1142
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double Atan(double d);

		// Token: 0x06000477 RID: 1143
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double Atan2(double y, double x);

		// Token: 0x06000478 RID: 1144
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double Atanh(double d);

		// Token: 0x06000479 RID: 1145
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double Cbrt(double d);

		// Token: 0x0600047A RID: 1146
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double Ceiling(double a);

		// Token: 0x0600047B RID: 1147
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double Cos(double d);

		// Token: 0x0600047C RID: 1148
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double Cosh(double value);

		// Token: 0x0600047D RID: 1149
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double Exp(double d);

		// Token: 0x0600047E RID: 1150
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double Floor(double d);

		// Token: 0x0600047F RID: 1151
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double Log(double d);

		// Token: 0x06000480 RID: 1152
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double Log10(double d);

		// Token: 0x06000481 RID: 1153
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double Pow(double x, double y);

		// Token: 0x06000482 RID: 1154
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double Sin(double a);

		// Token: 0x06000483 RID: 1155 RVA: 0x0000FF4F File Offset: 0x0000E14F
		[return: TupleElementNames(new string[]
		{
			"Sin",
			"Cos"
		})]
		public static ValueTuple<double, double> SinCos(double x)
		{
			return new ValueTuple<double, double>(Math.Sin(x), Math.Cos(x));
		}

		// Token: 0x06000484 RID: 1156
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double Sinh(double value);

		// Token: 0x06000485 RID: 1157
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double Sqrt(double d);

		// Token: 0x06000486 RID: 1158
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double Tan(double a);

		// Token: 0x06000487 RID: 1159
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double Tanh(double value);

		// Token: 0x06000488 RID: 1160
		[Intrinsic]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double FusedMultiplyAdd(double x, double y, double z);

		// Token: 0x06000489 RID: 1161
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double Log2(double x);

		// Token: 0x0600048A RID: 1162
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern double ModF(double x, double* intptr);

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x0600048B RID: 1163 RVA: 0x0000FF62 File Offset: 0x0000E162
		private static ReadOnlySpan<double> RoundPower10Double
		{
			get
			{
				return RuntimeHelpers.CreateSpan<double>(fieldof(<PrivateImplementationDetails>.195ABC1ABB69B6BD65F20ACAFA79EED2D330BF513E25C830F24B8A78D87034468).FieldHandle);
			}
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x0000FF6E File Offset: 0x0000E16E
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static short Abs(short value)
		{
			if (value < 0)
			{
				value = -value;
				if (value < 0)
				{
					Math.ThrowNegateTwosCompOverflow();
				}
			}
			return value;
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x0000FF83 File Offset: 0x0000E183
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int Abs(int value)
		{
			if (value < 0)
			{
				value = -value;
				if (value < 0)
				{
					Math.ThrowNegateTwosCompOverflow();
				}
			}
			return value;
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x0000FF97 File Offset: 0x0000E197
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static long Abs(long value)
		{
			if (value < 0L)
			{
				value = -value;
				if (value < 0L)
				{
					Math.ThrowNegateTwosCompOverflow();
				}
			}
			return value;
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x0000FFAD File Offset: 0x0000E1AD
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IntPtr Abs(IntPtr value)
		{
			if (value < (IntPtr)0)
			{
				value = -value;
				if (value < (IntPtr)0)
				{
					Math.ThrowNegateTwosCompOverflow();
				}
			}
			return value;
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x0000FFC3 File Offset: 0x0000E1C3
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static sbyte Abs(sbyte value)
		{
			if (value < 0)
			{
				value = -value;
				if (value < 0)
				{
					Math.ThrowNegateTwosCompOverflow();
				}
			}
			return value;
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x0000FFD8 File Offset: 0x0000E1D8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static decimal Abs(decimal value)
		{
			return decimal.Abs(value);
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x0000FFE0 File Offset: 0x0000E1E0
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double Abs(double value)
		{
			return BitConverter.UInt64BitsToDouble(BitConverter.DoubleToUInt64Bits(value) & 9223372036854775807UL);
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x0000FFF7 File Offset: 0x0000E1F7
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Abs(float value)
		{
			return BitConverter.UInt32BitsToSingle(BitConverter.SingleToUInt32Bits(value) & 2147483647U);
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x0001000A File Offset: 0x0000E20A
		[DoesNotReturn]
		[StackTraceHidden]
		internal static void ThrowNegateTwosCompOverflow()
		{
			throw new OverflowException(SR.Overflow_NegateTwosCompNum);
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x00010016 File Offset: 0x0000E216
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ulong BigMul(uint a, uint b)
		{
			return (ulong)a * (ulong)b;
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x0001001D File Offset: 0x0000E21D
		public static long BigMul(int a, int b)
		{
			return (long)a * (long)b;
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x00010024 File Offset: 0x0000E224
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static ulong BigMul(ulong a, ulong b, out ulong low)
		{
			if (Bmi2.X64.IsSupported)
			{
				ulong num;
				ulong result = Bmi2.X64.MultiplyNoFlags(a, b, &num);
				low = num;
				return result;
			}
			if (false)
			{
			}
			return Math.<BigMul>g__SoftwareFallback|46_0(a, b, out low);
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x00010054 File Offset: 0x0000E254
		public static long BigMul(long a, long b, out long low)
		{
			if (false)
			{
			}
			ulong num2;
			long num = (long)Math.BigMul((ulong)a, (ulong)b, out num2);
			low = (long)num2;
			return num - (a >> 63 & b) - (b >> 63 & a);
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x00010080 File Offset: 0x0000E280
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static UInt128 BigMul(ulong a, ulong b)
		{
			ulong lower;
			return new UInt128(Math.BigMul(a, b, out lower), lower);
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x0001009C File Offset: 0x0000E29C
		public static Int128 BigMul(long a, long b)
		{
			long lower;
			return new Int128((ulong)Math.BigMul(a, b, out lower), (ulong)lower);
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x000100B8 File Offset: 0x0000E2B8
		public static double BitDecrement(double x)
		{
			ulong num = BitConverter.DoubleToUInt64Bits(x);
			if (!double.IsFinite(x))
			{
				if (num != 9218868437227405312UL)
				{
					return x;
				}
				return double.MaxValue;
			}
			else
			{
				if (num == 0UL)
				{
					return -5E-324;
				}
				if (double.IsNegative(x))
				{
					num += 1UL;
				}
				else
				{
					num -= 1UL;
				}
				return BitConverter.UInt64BitsToDouble(num);
			}
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x00010114 File Offset: 0x0000E314
		public static double BitIncrement(double x)
		{
			ulong num = BitConverter.DoubleToUInt64Bits(x);
			if (!double.IsFinite(x))
			{
				if (num != 18442240474082181120UL)
				{
					return x;
				}
				return double.MinValue;
			}
			else
			{
				if (num == 9223372036854775808UL)
				{
					return double.Epsilon;
				}
				if (double.IsNegative(x))
				{
					num -= 1UL;
				}
				else
				{
					num += 1UL;
				}
				return BitConverter.UInt64BitsToDouble(num);
			}
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x00010178 File Offset: 0x0000E378
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double CopySign(double x, double y)
		{
			if (Vector128.IsHardwareAccelerated)
			{
				return Vector128.ConditionalSelect<double>(Vector128.CreateScalarUnsafe(--0.0), Vector128.CreateScalarUnsafe(y), Vector128.CreateScalarUnsafe(x)).ToScalar<double>();
			}
			return Math.<CopySign>g__SoftwareFallback|52_0(x, y);
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x000101B0 File Offset: 0x0000E3B0
		public static int DivRem(int a, int b, out int result)
		{
			int num = a / b;
			result = a - num * b;
			return num;
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x000101CC File Offset: 0x0000E3CC
		public static long DivRem(long a, long b, out long result)
		{
			long num = a / b;
			result = a - num * b;
			return num;
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x000101E8 File Offset: 0x0000E3E8
		[NonVersionable]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: TupleElementNames(new string[]
		{
			"Quotient",
			"Remainder"
		})]
		public static ValueTuple<sbyte, sbyte> DivRem(sbyte left, sbyte right)
		{
			sbyte b = left / right;
			return new ValueTuple<sbyte, sbyte>(b, left - b * right);
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x00010208 File Offset: 0x0000E408
		[NonVersionable]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: TupleElementNames(new string[]
		{
			"Quotient",
			"Remainder"
		})]
		public static ValueTuple<byte, byte> DivRem(byte left, byte right)
		{
			byte b = left / right;
			return new ValueTuple<byte, byte>(b, left - b * right);
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x00010228 File Offset: 0x0000E428
		[NonVersionable]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: TupleElementNames(new string[]
		{
			"Quotient",
			"Remainder"
		})]
		public static ValueTuple<short, short> DivRem(short left, short right)
		{
			short num = left / right;
			return new ValueTuple<short, short>(num, left - num * right);
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x00010248 File Offset: 0x0000E448
		[NonVersionable]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: TupleElementNames(new string[]
		{
			"Quotient",
			"Remainder"
		})]
		public static ValueTuple<ushort, ushort> DivRem(ushort left, ushort right)
		{
			ushort num = left / right;
			return new ValueTuple<ushort, ushort>(num, left - num * right);
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x00010268 File Offset: 0x0000E468
		[NonVersionable]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: TupleElementNames(new string[]
		{
			"Quotient",
			"Remainder"
		})]
		public static ValueTuple<int, int> DivRem(int left, int right)
		{
			int num = left / right;
			return new ValueTuple<int, int>(num, left - num * right);
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x00010284 File Offset: 0x0000E484
		[NonVersionable]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: TupleElementNames(new string[]
		{
			"Quotient",
			"Remainder"
		})]
		public static ValueTuple<uint, uint> DivRem(uint left, uint right)
		{
			uint num = left / right;
			return new ValueTuple<uint, uint>(num, left - num * right);
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x000102A0 File Offset: 0x0000E4A0
		[NonVersionable]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: TupleElementNames(new string[]
		{
			"Quotient",
			"Remainder"
		})]
		public static ValueTuple<long, long> DivRem(long left, long right)
		{
			long num = left / right;
			return new ValueTuple<long, long>(num, left - num * right);
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x000102BC File Offset: 0x0000E4BC
		[NonVersionable]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: TupleElementNames(new string[]
		{
			"Quotient",
			"Remainder"
		})]
		public static ValueTuple<ulong, ulong> DivRem(ulong left, ulong right)
		{
			ulong num = left / right;
			return new ValueTuple<ulong, ulong>(num, left - num * right);
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x000102D8 File Offset: 0x0000E4D8
		[NonVersionable]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: TupleElementNames(new string[]
		{
			"Quotient",
			"Remainder"
		})]
		public static ValueTuple<IntPtr, IntPtr> DivRem(IntPtr left, IntPtr right)
		{
			IntPtr intPtr = left / right;
			return new ValueTuple<IntPtr, IntPtr>(intPtr, left - intPtr * right);
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x000102F4 File Offset: 0x0000E4F4
		[NonVersionable]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: TupleElementNames(new string[]
		{
			"Quotient",
			"Remainder"
		})]
		public static ValueTuple<UIntPtr, UIntPtr> DivRem(UIntPtr left, UIntPtr right)
		{
			UIntPtr uintPtr = left / right;
			return new ValueTuple<UIntPtr, UIntPtr>(uintPtr, left - uintPtr * right);
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x00010310 File Offset: 0x0000E510
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static decimal Ceiling(decimal d)
		{
			return decimal.Ceiling(d);
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x00010318 File Offset: 0x0000E518
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte Clamp(byte value, byte min, byte max)
		{
			if (min > max)
			{
				Math.ThrowMinMaxException<byte>(min, max);
			}
			if (value < min)
			{
				return min;
			}
			if (value > max)
			{
				return max;
			}
			return value;
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x00010332 File Offset: 0x0000E532
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static decimal Clamp(decimal value, decimal min, decimal max)
		{
			if (min > max)
			{
				Math.ThrowMinMaxException<decimal>(min, max);
			}
			if (value < min)
			{
				return min;
			}
			if (value > max)
			{
				return max;
			}
			return value;
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x0001035B File Offset: 0x0000E55B
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double Clamp(double value, double min, double max)
		{
			if (min > max)
			{
				Math.ThrowMinMaxException<double>(min, max);
			}
			if (value < min)
			{
				return min;
			}
			if (value > max)
			{
				return max;
			}
			return value;
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x00010375 File Offset: 0x0000E575
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static short Clamp(short value, short min, short max)
		{
			if (min > max)
			{
				Math.ThrowMinMaxException<short>(min, max);
			}
			if (value < min)
			{
				return min;
			}
			if (value > max)
			{
				return max;
			}
			return value;
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x0001038F File Offset: 0x0000E58F
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int Clamp(int value, int min, int max)
		{
			if (min > max)
			{
				Math.ThrowMinMaxException<int>(min, max);
			}
			if (value < min)
			{
				return min;
			}
			if (value > max)
			{
				return max;
			}
			return value;
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x000103A9 File Offset: 0x0000E5A9
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static long Clamp(long value, long min, long max)
		{
			if (min > max)
			{
				Math.ThrowMinMaxException<long>(min, max);
			}
			if (value < min)
			{
				return min;
			}
			if (value > max)
			{
				return max;
			}
			return value;
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x000103C3 File Offset: 0x0000E5C3
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IntPtr Clamp(IntPtr value, IntPtr min, IntPtr max)
		{
			if (min > max)
			{
				Math.ThrowMinMaxException<IntPtr>(min, max);
			}
			if (value < min)
			{
				return min;
			}
			if (value > max)
			{
				return max;
			}
			return value;
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x000103DD File Offset: 0x0000E5DD
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static sbyte Clamp(sbyte value, sbyte min, sbyte max)
		{
			if (min > max)
			{
				Math.ThrowMinMaxException<sbyte>(min, max);
			}
			if (value < min)
			{
				return min;
			}
			if (value > max)
			{
				return max;
			}
			return value;
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x000103F7 File Offset: 0x0000E5F7
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Clamp(float value, float min, float max)
		{
			if (min > max)
			{
				Math.ThrowMinMaxException<float>(min, max);
			}
			if (value < min)
			{
				return min;
			}
			if (value > max)
			{
				return max;
			}
			return value;
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x00010411 File Offset: 0x0000E611
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ushort Clamp(ushort value, ushort min, ushort max)
		{
			if (min > max)
			{
				Math.ThrowMinMaxException<ushort>(min, max);
			}
			if (value < min)
			{
				return min;
			}
			if (value > max)
			{
				return max;
			}
			return value;
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x0001042B File Offset: 0x0000E62B
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint Clamp(uint value, uint min, uint max)
		{
			if (min > max)
			{
				Math.ThrowMinMaxException<uint>(min, max);
			}
			if (value < min)
			{
				return min;
			}
			if (value > max)
			{
				return max;
			}
			return value;
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x00010445 File Offset: 0x0000E645
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ulong Clamp(ulong value, ulong min, ulong max)
		{
			if (min > max)
			{
				Math.ThrowMinMaxException<ulong>(min, max);
			}
			if (value < min)
			{
				return min;
			}
			if (value > max)
			{
				return max;
			}
			return value;
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x0001045F File Offset: 0x0000E65F
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static UIntPtr Clamp(UIntPtr value, UIntPtr min, UIntPtr max)
		{
			if (min > max)
			{
				Math.ThrowMinMaxException<UIntPtr>(min, max);
			}
			if (value < min)
			{
				return min;
			}
			if (value > max)
			{
				return max;
			}
			return value;
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x00010479 File Offset: 0x0000E679
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static decimal Floor(decimal d)
		{
			return decimal.Floor(d);
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x00010484 File Offset: 0x0000E684
		public static double IEEERemainder(double x, double y)
		{
			if (double.IsNaN(x))
			{
				return x;
			}
			if (double.IsNaN(y))
			{
				return y;
			}
			double num = x % y;
			if (double.IsNaN(num))
			{
				return double.NaN;
			}
			if (num == 0.0 && double.IsNegative(x))
			{
				return --0.0;
			}
			double num2 = num - Math.Abs(y) * (double)Math.Sign(x);
			if (Math.Abs(num2) == Math.Abs(num))
			{
				double num3 = x / y;
				if (Math.Abs(Math.Round(num3)) > Math.Abs(num3))
				{
					return num2;
				}
				return num;
			}
			else
			{
				if (Math.Abs(num2) < Math.Abs(num))
				{
					return num2;
				}
				return num;
			}
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x00010524 File Offset: 0x0000E724
		public static int ILogB(double x)
		{
			if (double.IsNormal(x))
			{
				return (int)x.Exponent;
			}
			if (double.IsZero(x))
			{
				return int.MinValue;
			}
			if (!double.IsFinite(x))
			{
				return int.MaxValue;
			}
			return -1022 - (BitOperations.TrailingZeroCount(x.TrailingSignificand) - 11);
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x00010574 File Offset: 0x0000E774
		public static double Log(double a, double newBase)
		{
			if (double.IsNaN(a))
			{
				return a;
			}
			if (double.IsNaN(newBase))
			{
				return newBase;
			}
			if (newBase == 1.0)
			{
				return double.NaN;
			}
			if (a != 1.0 && (newBase == 0.0 || double.IsPositiveInfinity(newBase)))
			{
				return double.NaN;
			}
			return Math.Log(a) / Math.Log(newBase);
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x000105E2 File Offset: 0x0000E7E2
		[NonVersionable]
		public static byte Max(byte val1, byte val2)
		{
			if (val1 < val2)
			{
				return val2;
			}
			return val1;
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x000105EB File Offset: 0x0000E7EB
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static decimal Max(decimal val1, decimal val2)
		{
			return decimal.Max(val1, val2);
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x000105F4 File Offset: 0x0000E7F4
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double Max(double val1, double val2)
		{
			if (val1 != val2)
			{
				if (double.IsNaN(val1))
				{
					return val1;
				}
				if (val2 >= val1)
				{
					return val2;
				}
				return val1;
			}
			else
			{
				if (!double.IsNegative(val2))
				{
					return val2;
				}
				return val1;
			}
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x000105E2 File Offset: 0x0000E7E2
		[NonVersionable]
		public static short Max(short val1, short val2)
		{
			if (val1 < val2)
			{
				return val2;
			}
			return val1;
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x000105E2 File Offset: 0x0000E7E2
		[NonVersionable]
		public static int Max(int val1, int val2)
		{
			if (val1 < val2)
			{
				return val2;
			}
			return val1;
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x000105E2 File Offset: 0x0000E7E2
		[NonVersionable]
		public static long Max(long val1, long val2)
		{
			if (val1 < val2)
			{
				return val2;
			}
			return val1;
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x000105E2 File Offset: 0x0000E7E2
		[NonVersionable]
		public static IntPtr Max(IntPtr val1, IntPtr val2)
		{
			if (val1 < val2)
			{
				return val2;
			}
			return val1;
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x000105E2 File Offset: 0x0000E7E2
		[CLSCompliant(false)]
		[NonVersionable]
		public static sbyte Max(sbyte val1, sbyte val2)
		{
			if (val1 < val2)
			{
				return val2;
			}
			return val1;
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x00010617 File Offset: 0x0000E817
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Max(float val1, float val2)
		{
			if (val1 != val2)
			{
				if (float.IsNaN(val1))
				{
					return val1;
				}
				if (val2 >= val1)
				{
					return val2;
				}
				return val1;
			}
			else
			{
				if (!float.IsNegative(val2))
				{
					return val2;
				}
				return val1;
			}
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x000105E2 File Offset: 0x0000E7E2
		[CLSCompliant(false)]
		[NonVersionable]
		public static ushort Max(ushort val1, ushort val2)
		{
			if (val1 < val2)
			{
				return val2;
			}
			return val1;
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x0001063A File Offset: 0x0000E83A
		[CLSCompliant(false)]
		[NonVersionable]
		public static uint Max(uint val1, uint val2)
		{
			if (val1 < val2)
			{
				return val2;
			}
			return val1;
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x0001063A File Offset: 0x0000E83A
		[CLSCompliant(false)]
		[NonVersionable]
		public static ulong Max(ulong val1, ulong val2)
		{
			if (val1 < val2)
			{
				return val2;
			}
			return val1;
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x0001063A File Offset: 0x0000E83A
		[CLSCompliant(false)]
		[NonVersionable]
		public static UIntPtr Max(UIntPtr val1, UIntPtr val2)
		{
			if (val1 < val2)
			{
				return val2;
			}
			return val1;
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x00010644 File Offset: 0x0000E844
		[Intrinsic]
		public static double MaxMagnitude(double x, double y)
		{
			double num = Math.Abs(x);
			double num2 = Math.Abs(y);
			if (num > num2 || double.IsNaN(num))
			{
				return x;
			}
			if (num != num2)
			{
				return y;
			}
			if (!double.IsNegative(x))
			{
				return x;
			}
			return y;
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x0001067E File Offset: 0x0000E87E
		[NonVersionable]
		public static byte Min(byte val1, byte val2)
		{
			if (val1 > val2)
			{
				return val2;
			}
			return val1;
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x00010687 File Offset: 0x0000E887
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static decimal Min(decimal val1, decimal val2)
		{
			return decimal.Min(val1, val2);
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x00010690 File Offset: 0x0000E890
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double Min(double val1, double val2)
		{
			if (val1 != val2)
			{
				if (double.IsNaN(val1))
				{
					return val1;
				}
				if (val1 >= val2)
				{
					return val2;
				}
				return val1;
			}
			else
			{
				if (!double.IsNegative(val1))
				{
					return val2;
				}
				return val1;
			}
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x0001067E File Offset: 0x0000E87E
		[NonVersionable]
		public static short Min(short val1, short val2)
		{
			if (val1 > val2)
			{
				return val2;
			}
			return val1;
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x0001067E File Offset: 0x0000E87E
		[NonVersionable]
		public static int Min(int val1, int val2)
		{
			if (val1 > val2)
			{
				return val2;
			}
			return val1;
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x0001067E File Offset: 0x0000E87E
		[NonVersionable]
		public static long Min(long val1, long val2)
		{
			if (val1 > val2)
			{
				return val2;
			}
			return val1;
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x0001067E File Offset: 0x0000E87E
		[NonVersionable]
		public static IntPtr Min(IntPtr val1, IntPtr val2)
		{
			if (val1 > val2)
			{
				return val2;
			}
			return val1;
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x0001067E File Offset: 0x0000E87E
		[CLSCompliant(false)]
		[NonVersionable]
		public static sbyte Min(sbyte val1, sbyte val2)
		{
			if (val1 > val2)
			{
				return val2;
			}
			return val1;
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x000106B3 File Offset: 0x0000E8B3
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Min(float val1, float val2)
		{
			if (val1 != val2)
			{
				if (float.IsNaN(val1))
				{
					return val1;
				}
				if (val1 >= val2)
				{
					return val2;
				}
				return val1;
			}
			else
			{
				if (!float.IsNegative(val1))
				{
					return val2;
				}
				return val1;
			}
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x0001067E File Offset: 0x0000E87E
		[CLSCompliant(false)]
		[NonVersionable]
		public static ushort Min(ushort val1, ushort val2)
		{
			if (val1 > val2)
			{
				return val2;
			}
			return val1;
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x000106D6 File Offset: 0x0000E8D6
		[CLSCompliant(false)]
		[NonVersionable]
		public static uint Min(uint val1, uint val2)
		{
			if (val1 > val2)
			{
				return val2;
			}
			return val1;
		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x000106D6 File Offset: 0x0000E8D6
		[CLSCompliant(false)]
		[NonVersionable]
		public static ulong Min(ulong val1, ulong val2)
		{
			if (val1 > val2)
			{
				return val2;
			}
			return val1;
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x000106D6 File Offset: 0x0000E8D6
		[CLSCompliant(false)]
		[NonVersionable]
		public static UIntPtr Min(UIntPtr val1, UIntPtr val2)
		{
			if (val1 > val2)
			{
				return val2;
			}
			return val1;
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x000106E0 File Offset: 0x0000E8E0
		[Intrinsic]
		public static double MinMagnitude(double x, double y)
		{
			double num = Math.Abs(x);
			double num2 = Math.Abs(y);
			if (num < num2 || double.IsNaN(num))
			{
				return x;
			}
			if (num != num2)
			{
				return y;
			}
			if (!double.IsNegative(x))
			{
				return y;
			}
			return x;
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x0001071A File Offset: 0x0000E91A
		[Intrinsic]
		public static double ReciprocalEstimate(double d)
		{
			return 1.0 / d;
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x00010727 File Offset: 0x0000E927
		[Intrinsic]
		public static double ReciprocalSqrtEstimate(double d)
		{
			return 1.0 / Math.Sqrt(d);
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x00010739 File Offset: 0x0000E939
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static decimal Round(decimal d)
		{
			return decimal.Round(d, 0);
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x00010742 File Offset: 0x0000E942
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static decimal Round(decimal d, int decimals)
		{
			return decimal.Round(d, decimals);
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x0001074B File Offset: 0x0000E94B
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static decimal Round(decimal d, MidpointRounding mode)
		{
			return decimal.Round(d, 0, mode);
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x00010755 File Offset: 0x0000E955
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static decimal Round(decimal d, int decimals, MidpointRounding mode)
		{
			return decimal.Round(d, decimals, mode);
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x00010760 File Offset: 0x0000E960
		[Intrinsic]
		public static double Round(double a)
		{
			if (Math.Abs(a) >= 4503599627370496.0)
			{
				return a;
			}
			double num = Math.CopySign(4503599627370496.0, a);
			return Math.CopySign(a + num - num, a);
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x0001079B File Offset: 0x0000E99B
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double Round(double value, int digits)
		{
			return Math.Round(value, digits, MidpointRounding.ToEven);
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x000107A8 File Offset: 0x0000E9A8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double Round(double value, MidpointRounding mode)
		{
			switch (mode)
			{
			case MidpointRounding.ToEven:
				return Math.Round(value);
			case MidpointRounding.AwayFromZero:
				if (false)
				{
				}
				return Math.Truncate(value + Math.CopySign(0.49999999999999994, value));
			case MidpointRounding.ToZero:
				return Math.Truncate(value);
			case MidpointRounding.ToNegativeInfinity:
				return Math.Floor(value);
			case MidpointRounding.ToPositiveInfinity:
				return Math.Ceiling(value);
			default:
				ThrowHelper.ThrowArgumentException_InvalidEnumValue<MidpointRounding>(mode, "mode");
				return 0.0;
			}
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x0001081C File Offset: 0x0000EA1C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static double Round(double value, int digits, MidpointRounding mode)
		{
			if (digits > 15)
			{
				ThrowHelper.ThrowArgumentOutOfRange_RoundingDigits("digits");
			}
			if (Math.Abs(value) < 10000000000000000.0)
			{
				double num = *Math.RoundPower10Double[digits];
				value = Math.Round(value * num, mode) / num;
			}
			return value;
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x00010867 File Offset: 0x0000EA67
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int Sign(decimal value)
		{
			return decimal.Sign(value);
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x0001086F File Offset: 0x0000EA6F
		public static int Sign(double value)
		{
			if (value < 0.0)
			{
				return -1;
			}
			if (value > 0.0)
			{
				return 1;
			}
			if (value == 0.0)
			{
				return 0;
			}
			throw new ArithmeticException(SR.Arithmetic_NaN);
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x000108A5 File Offset: 0x0000EAA5
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int Sign(short value)
		{
			return Math.Sign((int)value);
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x000108AD File Offset: 0x0000EAAD
		public static int Sign(int value)
		{
			return value >> 31 | (int)((uint)(-(uint)value) >> 31);
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x000108B9 File Offset: 0x0000EAB9
		public static int Sign(long value)
		{
			return (int)(value >> 63 | (long)((ulong)(-(ulong)value) >> 63));
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x000108C6 File Offset: 0x0000EAC6
		public static int Sign(IntPtr value)
		{
			return (int)((long)(value >> (63 & 8 * 8 - 1)) | (long)((ulong)((long)(-(long)value)) >> 63));
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x000108A5 File Offset: 0x0000EAA5
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int Sign(sbyte value)
		{
			return Math.Sign((int)value);
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x000108DF File Offset: 0x0000EADF
		public static int Sign(float value)
		{
			if (value < 0f)
			{
				return -1;
			}
			if (value > 0f)
			{
				return 1;
			}
			if (value == 0f)
			{
				return 0;
			}
			throw new ArithmeticException(SR.Arithmetic_NaN);
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x00010909 File Offset: 0x0000EB09
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static decimal Truncate(decimal d)
		{
			return decimal.Truncate(d);
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x00010911 File Offset: 0x0000EB11
		[Intrinsic]
		public unsafe static double Truncate(double d)
		{
			Math.ModF(d, &d);
			return d;
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x0001091E File Offset: 0x0000EB1E
		[DoesNotReturn]
		internal static void ThrowMinMaxException<T>(T min, T max)
		{
			throw new ArgumentException(SR.Format(SR.Argument_MinMaxValue, min, max));
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x0001093C File Offset: 0x0000EB3C
		public static double ScaleB(double x, int n)
		{
			double num = x;
			if (n > 1023)
			{
				num *= 8.98846567431158E+307;
				n -= 1023;
				if (n > 1023)
				{
					num *= 8.98846567431158E+307;
					n -= 1023;
					if (n > 1023)
					{
						n = 1023;
					}
				}
			}
			else if (n < -1022)
			{
				num *= 2.004168360008973E-292;
				n += 969;
				if (n < -1022)
				{
					num *= 2.004168360008973E-292;
					n += 969;
					if (n < -1022)
					{
						n = -1022;
					}
				}
			}
			double num2 = BitConverter.Int64BitsToDouble((long)(1023 + n) << 52);
			return num * num2;
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x000109F4 File Offset: 0x0000EBF4
		[CompilerGenerated]
		internal static ulong <BigMul>g__SoftwareFallback|46_0(ulong a, ulong b, out ulong low)
		{
			uint num = (uint)a;
			uint num2 = (uint)(a >> 32);
			uint num3 = (uint)b;
			uint num4 = (uint)(b >> 32);
			ulong num5 = (ulong)num * (ulong)num3;
			ulong num6 = (ulong)num2 * (ulong)num3 + (num5 >> 32);
			ulong num7 = (ulong)num * (ulong)num4 + (ulong)((uint)num6);
			low = (num7 << 32 | (ulong)((uint)num5));
			return (ulong)num2 * (ulong)num4 + (num6 >> 32) + (num7 >> 32);
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x00010A4C File Offset: 0x0000EC4C
		[CompilerGenerated]
		internal static double <CopySign>g__SoftwareFallback|52_0(double x, double y)
		{
			ulong num = BitConverter.DoubleToUInt64Bits(x);
			ulong num2 = BitConverter.DoubleToUInt64Bits(y);
			return BitConverter.UInt64BitsToDouble((num & 9223372036854775807UL) | (num2 & 9223372036854775808UL));
		}

		// Token: 0x04000265 RID: 613
		public const double E = 2.718281828459045;

		// Token: 0x04000266 RID: 614
		public const double PI = 3.141592653589793;

		// Token: 0x04000267 RID: 615
		public const double Tau = 6.283185307179586;
	}
}
