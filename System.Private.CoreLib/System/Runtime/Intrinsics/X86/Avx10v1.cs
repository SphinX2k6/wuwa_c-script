using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Runtime.Intrinsics.X86
{
	// Token: 0x0200056F RID: 1391
	[CLSCompliant(false)]
	public abstract class Avx10v1 : Avx2
	{
		// Token: 0x17000D7C RID: 3452
		// (get) Token: 0x06006570 RID: 25968 RVA: 0x00007B65 File Offset: 0x00005D65
		public new static bool IsSupported
		{
			[Intrinsic]
			get
			{
				return false;
			}
		}

		// Token: 0x06006571 RID: 25969 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> Abs(Vector128<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006572 RID: 25970 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ulong> Abs(Vector256<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006573 RID: 25971 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> AddScalar(Vector128<double> left, Vector128<double> right, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006574 RID: 25972 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> AddScalar(Vector128<float> left, Vector128<float> right, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006575 RID: 25973 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> AlignRight32(Vector128<int> left, Vector128<int> right, [ConstantExpected] byte mask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006576 RID: 25974 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> AlignRight32(Vector128<uint> left, Vector128<uint> right, [ConstantExpected] byte mask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006577 RID: 25975 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<int> AlignRight32(Vector256<int> left, Vector256<int> right, [ConstantExpected] byte mask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006578 RID: 25976 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<uint> AlignRight32(Vector256<uint> left, Vector256<uint> right, [ConstantExpected] byte mask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006579 RID: 25977 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> AlignRight64(Vector128<long> left, Vector128<long> right, [ConstantExpected] byte mask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600657A RID: 25978 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> AlignRight64(Vector128<ulong> left, Vector128<ulong> right, [ConstantExpected] byte mask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600657B RID: 25979 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<long> AlignRight64(Vector256<long> left, Vector256<long> right, [ConstantExpected] byte mask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600657C RID: 25980 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ulong> AlignRight64(Vector256<ulong> left, Vector256<ulong> right, [ConstantExpected] byte mask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600657D RID: 25981 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> BroadcastPairScalarToVector128(Vector128<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600657E RID: 25982 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> BroadcastPairScalarToVector128(Vector128<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600657F RID: 25983 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<float> BroadcastPairScalarToVector256(Vector128<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006580 RID: 25984 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<int> BroadcastPairScalarToVector256(Vector128<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006581 RID: 25985 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<uint> BroadcastPairScalarToVector256(Vector128<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006582 RID: 25986 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> CompareGreaterThan(Vector128<byte> left, Vector128<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006583 RID: 25987 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> CompareGreaterThan(Vector128<uint> left, Vector128<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006584 RID: 25988 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> CompareGreaterThan(Vector128<ulong> left, Vector128<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006585 RID: 25989 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> CompareGreaterThan(Vector128<ushort> left, Vector128<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006586 RID: 25990 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<byte> CompareGreaterThan(Vector256<byte> left, Vector256<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006587 RID: 25991 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<uint> CompareGreaterThan(Vector256<uint> left, Vector256<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006588 RID: 25992 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ulong> CompareGreaterThan(Vector256<ulong> left, Vector256<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006589 RID: 25993 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ushort> CompareGreaterThan(Vector256<ushort> left, Vector256<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600658A RID: 25994 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> CompareGreaterThanOrEqual(Vector128<byte> left, Vector128<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600658B RID: 25995 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> CompareGreaterThanOrEqual(Vector128<int> left, Vector128<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600658C RID: 25996 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> CompareGreaterThanOrEqual(Vector128<long> left, Vector128<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600658D RID: 25997 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> CompareGreaterThanOrEqual(Vector128<sbyte> left, Vector128<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600658E RID: 25998 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> CompareGreaterThanOrEqual(Vector128<short> left, Vector128<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600658F RID: 25999 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> CompareGreaterThanOrEqual(Vector128<uint> left, Vector128<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006590 RID: 26000 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> CompareGreaterThanOrEqual(Vector128<ulong> left, Vector128<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006591 RID: 26001 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> CompareGreaterThanOrEqual(Vector128<ushort> left, Vector128<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006592 RID: 26002 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<byte> CompareGreaterThanOrEqual(Vector256<byte> left, Vector256<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006593 RID: 26003 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<int> CompareGreaterThanOrEqual(Vector256<int> left, Vector256<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006594 RID: 26004 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<long> CompareGreaterThanOrEqual(Vector256<long> left, Vector256<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006595 RID: 26005 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<sbyte> CompareGreaterThanOrEqual(Vector256<sbyte> left, Vector256<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006596 RID: 26006 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<short> CompareGreaterThanOrEqual(Vector256<short> left, Vector256<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006597 RID: 26007 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<uint> CompareGreaterThanOrEqual(Vector256<uint> left, Vector256<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006598 RID: 26008 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ulong> CompareGreaterThanOrEqual(Vector256<ulong> left, Vector256<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006599 RID: 26009 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ushort> CompareGreaterThanOrEqual(Vector256<ushort> left, Vector256<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600659A RID: 26010 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public new static Vector128<int> CompareLessThan(Vector128<int> left, Vector128<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600659B RID: 26011 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public new static Vector128<sbyte> CompareLessThan(Vector128<sbyte> left, Vector128<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600659C RID: 26012 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public new static Vector128<short> CompareLessThan(Vector128<short> left, Vector128<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600659D RID: 26013 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> CompareLessThan(Vector128<byte> left, Vector128<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600659E RID: 26014 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> CompareLessThan(Vector128<long> left, Vector128<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600659F RID: 26015 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> CompareLessThan(Vector128<uint> left, Vector128<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065A0 RID: 26016 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> CompareLessThan(Vector128<ulong> left, Vector128<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065A1 RID: 26017 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> CompareLessThan(Vector128<ushort> left, Vector128<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065A2 RID: 26018 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<byte> CompareLessThan(Vector256<byte> left, Vector256<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065A3 RID: 26019 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<int> CompareLessThan(Vector256<int> left, Vector256<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065A4 RID: 26020 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<long> CompareLessThan(Vector256<long> left, Vector256<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065A5 RID: 26021 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<sbyte> CompareLessThan(Vector256<sbyte> left, Vector256<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065A6 RID: 26022 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<short> CompareLessThan(Vector256<short> left, Vector256<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065A7 RID: 26023 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<uint> CompareLessThan(Vector256<uint> left, Vector256<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065A8 RID: 26024 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ulong> CompareLessThan(Vector256<ulong> left, Vector256<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065A9 RID: 26025 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ushort> CompareLessThan(Vector256<ushort> left, Vector256<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065AA RID: 26026 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> CompareLessThanOrEqual(Vector128<byte> left, Vector128<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065AB RID: 26027 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> CompareLessThanOrEqual(Vector128<int> left, Vector128<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065AC RID: 26028 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> CompareLessThanOrEqual(Vector128<long> left, Vector128<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065AD RID: 26029 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> CompareLessThanOrEqual(Vector128<sbyte> left, Vector128<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065AE RID: 26030 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> CompareLessThanOrEqual(Vector128<short> left, Vector128<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065AF RID: 26031 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> CompareLessThanOrEqual(Vector128<uint> left, Vector128<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065B0 RID: 26032 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> CompareLessThanOrEqual(Vector128<ulong> left, Vector128<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065B1 RID: 26033 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> CompareLessThanOrEqual(Vector128<ushort> left, Vector128<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065B2 RID: 26034 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<byte> CompareLessThanOrEqual(Vector256<byte> left, Vector256<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065B3 RID: 26035 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<int> CompareLessThanOrEqual(Vector256<int> left, Vector256<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065B4 RID: 26036 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<long> CompareLessThanOrEqual(Vector256<long> left, Vector256<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065B5 RID: 26037 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<sbyte> CompareLessThanOrEqual(Vector256<sbyte> left, Vector256<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065B6 RID: 26038 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<short> CompareLessThanOrEqual(Vector256<short> left, Vector256<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065B7 RID: 26039 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<uint> CompareLessThanOrEqual(Vector256<uint> left, Vector256<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065B8 RID: 26040 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ulong> CompareLessThanOrEqual(Vector256<ulong> left, Vector256<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065B9 RID: 26041 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ushort> CompareLessThanOrEqual(Vector256<ushort> left, Vector256<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065BA RID: 26042 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> CompareNotEqual(Vector128<byte> left, Vector128<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065BB RID: 26043 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> CompareNotEqual(Vector128<int> left, Vector128<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065BC RID: 26044 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> CompareNotEqual(Vector128<long> left, Vector128<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065BD RID: 26045 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> CompareNotEqual(Vector128<sbyte> left, Vector128<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065BE RID: 26046 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> CompareNotEqual(Vector128<short> left, Vector128<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065BF RID: 26047 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> CompareNotEqual(Vector128<uint> left, Vector128<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065C0 RID: 26048 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> CompareNotEqual(Vector128<ulong> left, Vector128<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065C1 RID: 26049 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> CompareNotEqual(Vector128<ushort> left, Vector128<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065C2 RID: 26050 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<byte> CompareNotEqual(Vector256<byte> left, Vector256<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065C3 RID: 26051 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<int> CompareNotEqual(Vector256<int> left, Vector256<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065C4 RID: 26052 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<long> CompareNotEqual(Vector256<long> left, Vector256<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065C5 RID: 26053 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<sbyte> CompareNotEqual(Vector256<sbyte> left, Vector256<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065C6 RID: 26054 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<short> CompareNotEqual(Vector256<short> left, Vector256<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065C7 RID: 26055 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<uint> CompareNotEqual(Vector256<uint> left, Vector256<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065C8 RID: 26056 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ulong> CompareNotEqual(Vector256<ulong> left, Vector256<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065C9 RID: 26057 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ushort> CompareNotEqual(Vector256<ushort> left, Vector256<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065CA RID: 26058 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> ConvertScalarToVector128Double(Vector128<double> upper, uint value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065CB RID: 26059 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> ConvertScalarToVector128Single(Vector128<float> upper, int value, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065CC RID: 26060 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> ConvertScalarToVector128Single(Vector128<float> upper, uint value, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065CD RID: 26061 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> ConvertScalarToVector128Single(Vector128<float> upper, uint value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065CE RID: 26062 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> ConvertScalarToVector128Single(Vector128<float> upper, Vector128<double> value, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065CF RID: 26063 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static int ConvertToInt32(Vector128<double> value, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065D0 RID: 26064 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static int ConvertToInt32(Vector128<float> value, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065D1 RID: 26065 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static uint ConvertToUInt32(Vector128<double> value, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065D2 RID: 26066 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static uint ConvertToUInt32(Vector128<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065D3 RID: 26067 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static uint ConvertToUInt32(Vector128<float> value, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065D4 RID: 26068 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static uint ConvertToUInt32(Vector128<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065D5 RID: 26069 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static uint ConvertToUInt32WithTruncation(Vector128<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065D6 RID: 26070 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static uint ConvertToUInt32WithTruncation(Vector128<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065D7 RID: 26071 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> ConvertToVector128Byte(Vector128<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065D8 RID: 26072 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> ConvertToVector128Byte(Vector128<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065D9 RID: 26073 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> ConvertToVector128Byte(Vector128<short> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065DA RID: 26074 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> ConvertToVector128Byte(Vector128<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065DB RID: 26075 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> ConvertToVector128Byte(Vector128<ulong> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065DC RID: 26076 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> ConvertToVector128Byte(Vector128<ushort> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065DD RID: 26077 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> ConvertToVector128Byte(Vector256<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065DE RID: 26078 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> ConvertToVector128Byte(Vector256<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065DF RID: 26079 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> ConvertToVector128Byte(Vector256<short> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065E0 RID: 26080 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> ConvertToVector128Byte(Vector256<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065E1 RID: 26081 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> ConvertToVector128Byte(Vector256<ulong> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065E2 RID: 26082 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> ConvertToVector128Byte(Vector256<ushort> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065E3 RID: 26083 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> ConvertToVector128ByteWithSaturation(Vector128<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065E4 RID: 26084 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> ConvertToVector128ByteWithSaturation(Vector128<ulong> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065E5 RID: 26085 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> ConvertToVector128ByteWithSaturation(Vector128<ushort> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065E6 RID: 26086 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> ConvertToVector128ByteWithSaturation(Vector256<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065E7 RID: 26087 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> ConvertToVector128ByteWithSaturation(Vector256<ulong> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065E8 RID: 26088 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> ConvertToVector128ByteWithSaturation(Vector256<ushort> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065E9 RID: 26089 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> ConvertToVector128Double(Vector128<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065EA RID: 26090 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> ConvertToVector128Double(Vector128<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065EB RID: 26091 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> ConvertToVector128Double(Vector128<ulong> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065EC RID: 26092 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> ConvertToVector128Int16(Vector128<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065ED RID: 26093 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> ConvertToVector128Int16(Vector128<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065EE RID: 26094 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> ConvertToVector128Int16(Vector128<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065EF RID: 26095 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> ConvertToVector128Int16(Vector128<ulong> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065F0 RID: 26096 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> ConvertToVector128Int16(Vector256<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065F1 RID: 26097 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> ConvertToVector128Int16(Vector256<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065F2 RID: 26098 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> ConvertToVector128Int16(Vector256<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065F3 RID: 26099 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> ConvertToVector128Int16(Vector256<ulong> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065F4 RID: 26100 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> ConvertToVector128Int16WithSaturation(Vector128<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065F5 RID: 26101 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> ConvertToVector128Int16WithSaturation(Vector128<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065F6 RID: 26102 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> ConvertToVector128Int16WithSaturation(Vector256<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065F7 RID: 26103 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> ConvertToVector128Int16WithSaturation(Vector256<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065F8 RID: 26104 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> ConvertToVector128Int32(Vector128<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065F9 RID: 26105 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> ConvertToVector128Int32(Vector128<ulong> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065FA RID: 26106 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> ConvertToVector128Int32(Vector256<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065FB RID: 26107 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> ConvertToVector128Int32(Vector256<ulong> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065FC RID: 26108 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> ConvertToVector128Int32WithSaturation(Vector128<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065FD RID: 26109 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> ConvertToVector128Int32WithSaturation(Vector256<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065FE RID: 26110 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> ConvertToVector128Int64(Vector128<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060065FF RID: 26111 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> ConvertToVector128Int64(Vector128<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006600 RID: 26112 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> ConvertToVector128Int64WithTruncation(Vector128<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006601 RID: 26113 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> ConvertToVector128Int64WithTruncation(Vector128<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006602 RID: 26114 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> ConvertToVector128SByte(Vector128<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006603 RID: 26115 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> ConvertToVector128SByte(Vector128<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006604 RID: 26116 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> ConvertToVector128SByte(Vector128<short> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006605 RID: 26117 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> ConvertToVector128SByte(Vector128<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006606 RID: 26118 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> ConvertToVector128SByte(Vector128<ulong> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006607 RID: 26119 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> ConvertToVector128SByte(Vector128<ushort> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006608 RID: 26120 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> ConvertToVector128SByte(Vector256<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006609 RID: 26121 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> ConvertToVector128SByte(Vector256<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600660A RID: 26122 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> ConvertToVector128SByte(Vector256<short> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600660B RID: 26123 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> ConvertToVector128SByte(Vector256<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600660C RID: 26124 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> ConvertToVector128SByte(Vector256<ulong> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600660D RID: 26125 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> ConvertToVector128SByte(Vector256<ushort> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600660E RID: 26126 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> ConvertToVector128SByteWithSaturation(Vector128<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600660F RID: 26127 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> ConvertToVector128SByteWithSaturation(Vector128<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006610 RID: 26128 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> ConvertToVector128SByteWithSaturation(Vector128<short> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006611 RID: 26129 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> ConvertToVector128SByteWithSaturation(Vector256<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006612 RID: 26130 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> ConvertToVector128SByteWithSaturation(Vector256<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006613 RID: 26131 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> ConvertToVector128SByteWithSaturation(Vector256<short> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006614 RID: 26132 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> ConvertToVector128Single(Vector128<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006615 RID: 26133 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> ConvertToVector128Single(Vector128<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006616 RID: 26134 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> ConvertToVector128Single(Vector128<ulong> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006617 RID: 26135 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> ConvertToVector128Single(Vector256<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006618 RID: 26136 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> ConvertToVector128Single(Vector256<ulong> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006619 RID: 26137 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> ConvertToVector128UInt16(Vector128<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600661A RID: 26138 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> ConvertToVector128UInt16(Vector128<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600661B RID: 26139 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> ConvertToVector128UInt16(Vector128<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600661C RID: 26140 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> ConvertToVector128UInt16(Vector128<ulong> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600661D RID: 26141 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> ConvertToVector128UInt16(Vector256<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600661E RID: 26142 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> ConvertToVector128UInt16(Vector256<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600661F RID: 26143 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> ConvertToVector128UInt16(Vector256<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006620 RID: 26144 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> ConvertToVector128UInt16(Vector256<ulong> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006621 RID: 26145 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> ConvertToVector128UInt16WithSaturation(Vector128<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006622 RID: 26146 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> ConvertToVector128UInt16WithSaturation(Vector128<ulong> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006623 RID: 26147 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> ConvertToVector128UInt16WithSaturation(Vector256<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006624 RID: 26148 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> ConvertToVector128UInt16WithSaturation(Vector256<ulong> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006625 RID: 26149 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> ConvertToVector128UInt32(Vector128<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006626 RID: 26150 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> ConvertToVector128UInt32(Vector128<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006627 RID: 26151 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> ConvertToVector128UInt32(Vector128<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006628 RID: 26152 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> ConvertToVector128UInt32(Vector128<ulong> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006629 RID: 26153 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> ConvertToVector128UInt32(Vector256<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600662A RID: 26154 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> ConvertToVector128UInt32(Vector256<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600662B RID: 26155 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> ConvertToVector128UInt32(Vector256<ulong> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600662C RID: 26156 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> ConvertToVector128UInt32WithSaturation(Vector128<ulong> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600662D RID: 26157 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> ConvertToVector128UInt32WithSaturation(Vector256<ulong> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600662E RID: 26158 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> ConvertToVector128UInt32WithTruncation(Vector128<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600662F RID: 26159 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> ConvertToVector128UInt32WithTruncation(Vector128<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006630 RID: 26160 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> ConvertToVector128UInt32WithTruncation(Vector256<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006631 RID: 26161 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> ConvertToVector128UInt64(Vector128<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006632 RID: 26162 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> ConvertToVector128UInt64(Vector128<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006633 RID: 26163 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> ConvertToVector128UInt64WithTruncation(Vector128<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006634 RID: 26164 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> ConvertToVector128UInt64WithTruncation(Vector128<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006635 RID: 26165 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<double> ConvertToVector256Double(Vector128<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006636 RID: 26166 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<double> ConvertToVector256Double(Vector256<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006637 RID: 26167 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<double> ConvertToVector256Double(Vector256<ulong> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006638 RID: 26168 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<long> ConvertToVector256Int64(Vector128<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006639 RID: 26169 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<long> ConvertToVector256Int64(Vector256<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600663A RID: 26170 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<long> ConvertToVector256Int64WithTruncation(Vector128<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600663B RID: 26171 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<long> ConvertToVector256Int64WithTruncation(Vector256<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600663C RID: 26172 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<float> ConvertToVector256Single(Vector256<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600663D RID: 26173 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<uint> ConvertToVector256UInt32(Vector256<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600663E RID: 26174 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<uint> ConvertToVector256UInt32WithTruncation(Vector256<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600663F RID: 26175 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ulong> ConvertToVector256UInt64(Vector128<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006640 RID: 26176 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ulong> ConvertToVector256UInt64(Vector256<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006641 RID: 26177 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ulong> ConvertToVector256UInt64WithTruncation(Vector128<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006642 RID: 26178 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ulong> ConvertToVector256UInt64WithTruncation(Vector256<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006643 RID: 26179 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> DetectConflicts(Vector128<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006644 RID: 26180 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> DetectConflicts(Vector128<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006645 RID: 26181 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> DetectConflicts(Vector128<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006646 RID: 26182 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> DetectConflicts(Vector128<ulong> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006647 RID: 26183 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<int> DetectConflicts(Vector256<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006648 RID: 26184 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<long> DetectConflicts(Vector256<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006649 RID: 26185 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<uint> DetectConflicts(Vector256<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600664A RID: 26186 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ulong> DetectConflicts(Vector256<ulong> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600664B RID: 26187 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> DivideScalar(Vector128<double> left, Vector128<double> right, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600664C RID: 26188 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> DivideScalar(Vector128<float> left, Vector128<float> right, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600664D RID: 26189 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> Fixup(Vector128<double> left, Vector128<double> right, Vector128<long> table, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600664E RID: 26190 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> Fixup(Vector128<float> left, Vector128<float> right, Vector128<int> table, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600664F RID: 26191 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<double> Fixup(Vector256<double> left, Vector256<double> right, Vector256<long> table, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006650 RID: 26192 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<float> Fixup(Vector256<float> left, Vector256<float> right, Vector256<int> table, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006651 RID: 26193 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> FixupScalar(Vector128<double> left, Vector128<double> right, Vector128<long> table, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006652 RID: 26194 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> FixupScalar(Vector128<float> left, Vector128<float> right, Vector128<int> table, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006653 RID: 26195 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> FusedMultiplyAddNegatedScalar(Vector128<double> a, Vector128<double> b, Vector128<double> c, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006654 RID: 26196 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> FusedMultiplyAddNegatedScalar(Vector128<float> a, Vector128<float> b, Vector128<float> c, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006655 RID: 26197 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> FusedMultiplyAddScalar(Vector128<double> a, Vector128<double> b, Vector128<double> c, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006656 RID: 26198 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> FusedMultiplyAddScalar(Vector128<float> a, Vector128<float> b, Vector128<float> c, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006657 RID: 26199 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> FusedMultiplySubtractNegatedScalar(Vector128<double> a, Vector128<double> b, Vector128<double> c, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006658 RID: 26200 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> FusedMultiplySubtractNegatedScalar(Vector128<float> a, Vector128<float> b, Vector128<float> c, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006659 RID: 26201 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> FusedMultiplySubtractScalar(Vector128<double> a, Vector128<double> b, Vector128<double> c, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600665A RID: 26202 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> FusedMultiplySubtractScalar(Vector128<float> a, Vector128<float> b, Vector128<float> c, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600665B RID: 26203 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> GetExponent(Vector128<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600665C RID: 26204 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> GetExponent(Vector128<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600665D RID: 26205 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<double> GetExponent(Vector256<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600665E RID: 26206 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<float> GetExponent(Vector256<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600665F RID: 26207 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> GetExponentScalar(Vector128<double> upper, Vector128<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006660 RID: 26208 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> GetExponentScalar(Vector128<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006661 RID: 26209 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> GetExponentScalar(Vector128<float> upper, Vector128<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006662 RID: 26210 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> GetExponentScalar(Vector128<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006663 RID: 26211 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> GetMantissa(Vector128<double> value, [ConstantExpected(Max = 15)] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006664 RID: 26212 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> GetMantissa(Vector128<float> value, [ConstantExpected(Max = 15)] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006665 RID: 26213 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<double> GetMantissa(Vector256<double> value, [ConstantExpected(Max = 15)] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006666 RID: 26214 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<float> GetMantissa(Vector256<float> value, [ConstantExpected(Max = 15)] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006667 RID: 26215 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> GetMantissaScalar(Vector128<double> upper, Vector128<double> value, [ConstantExpected(Max = 15)] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006668 RID: 26216 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> GetMantissaScalar(Vector128<double> value, [ConstantExpected(Max = 15)] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006669 RID: 26217 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> GetMantissaScalar(Vector128<float> upper, Vector128<float> value, [ConstantExpected(Max = 15)] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600666A RID: 26218 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> GetMantissaScalar(Vector128<float> value, [ConstantExpected(Max = 15)] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600666B RID: 26219 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> LeadingZeroCount(Vector128<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600666C RID: 26220 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> LeadingZeroCount(Vector128<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600666D RID: 26221 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> LeadingZeroCount(Vector128<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600666E RID: 26222 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> LeadingZeroCount(Vector128<ulong> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600666F RID: 26223 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<int> LeadingZeroCount(Vector256<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006670 RID: 26224 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<long> LeadingZeroCount(Vector256<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006671 RID: 26225 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<uint> LeadingZeroCount(Vector256<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006672 RID: 26226 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ulong> LeadingZeroCount(Vector256<ulong> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006673 RID: 26227 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> Max(Vector128<long> left, Vector128<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006674 RID: 26228 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> Max(Vector128<ulong> left, Vector128<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006675 RID: 26229 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<long> Max(Vector256<long> left, Vector256<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006676 RID: 26230 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ulong> Max(Vector256<ulong> left, Vector256<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006677 RID: 26231 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> Min(Vector128<long> left, Vector128<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006678 RID: 26232 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> Min(Vector128<ulong> left, Vector128<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006679 RID: 26233 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<long> Min(Vector256<long> left, Vector256<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600667A RID: 26234 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ulong> Min(Vector256<ulong> left, Vector256<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600667B RID: 26235 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> MultiplyLow(Vector128<long> left, Vector128<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600667C RID: 26236 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> MultiplyLow(Vector128<ulong> left, Vector128<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600667D RID: 26237 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<long> MultiplyLow(Vector256<long> left, Vector256<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600667E RID: 26238 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ulong> MultiplyLow(Vector256<ulong> left, Vector256<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600667F RID: 26239 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> MultiplyScalar(Vector128<double> left, Vector128<double> right, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006680 RID: 26240 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> MultiplyScalar(Vector128<float> left, Vector128<float> right, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006681 RID: 26241 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> MultiShift(Vector128<byte> control, Vector128<ulong> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006682 RID: 26242 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> MultiShift(Vector128<sbyte> control, Vector128<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006683 RID: 26243 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<byte> MultiShift(Vector256<byte> control, Vector256<ulong> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006684 RID: 26244 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<sbyte> MultiShift(Vector256<sbyte> control, Vector256<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006685 RID: 26245 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<short> PermuteVar16x16(Vector256<short> left, Vector256<short> control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006686 RID: 26246 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ushort> PermuteVar16x16(Vector256<ushort> left, Vector256<ushort> control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006687 RID: 26247 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<short> PermuteVar16x16x2(Vector256<short> lower, Vector256<short> indices, Vector256<short> upper)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006688 RID: 26248 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ushort> PermuteVar16x16x2(Vector256<ushort> lower, Vector256<ushort> indices, Vector256<ushort> upper)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006689 RID: 26249 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> PermuteVar16x8(Vector128<byte> left, Vector128<byte> control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600668A RID: 26250 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> PermuteVar16x8(Vector128<sbyte> left, Vector128<sbyte> control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600668B RID: 26251 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> PermuteVar16x8x2(Vector128<byte> lower, Vector128<byte> indices, Vector128<byte> upper)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600668C RID: 26252 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> PermuteVar16x8x2(Vector128<sbyte> lower, Vector128<sbyte> indices, Vector128<sbyte> upper)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600668D RID: 26253 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> PermuteVar2x64x2(Vector128<double> lower, Vector128<long> indices, Vector128<double> upper)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600668E RID: 26254 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> PermuteVar2x64x2(Vector128<long> lower, Vector128<long> indices, Vector128<long> upper)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600668F RID: 26255 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> PermuteVar2x64x2(Vector128<ulong> lower, Vector128<ulong> indices, Vector128<ulong> upper)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006690 RID: 26256 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<byte> PermuteVar32x8(Vector256<byte> left, Vector256<byte> control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006691 RID: 26257 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<sbyte> PermuteVar32x8(Vector256<sbyte> left, Vector256<sbyte> control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006692 RID: 26258 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<byte> PermuteVar32x8x2(Vector256<byte> lower, Vector256<byte> indices, Vector256<byte> upper)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006693 RID: 26259 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<sbyte> PermuteVar32x8x2(Vector256<sbyte> lower, Vector256<sbyte> indices, Vector256<sbyte> upper)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006694 RID: 26260 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> PermuteVar4x32x2(Vector128<float> lower, Vector128<int> indices, Vector128<float> upper)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006695 RID: 26261 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> PermuteVar4x32x2(Vector128<int> lower, Vector128<int> indices, Vector128<int> upper)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006696 RID: 26262 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> PermuteVar4x32x2(Vector128<uint> lower, Vector128<uint> indices, Vector128<uint> upper)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006697 RID: 26263 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<double> PermuteVar4x64(Vector256<double> value, Vector256<long> control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006698 RID: 26264 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<long> PermuteVar4x64(Vector256<long> value, Vector256<long> control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006699 RID: 26265 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ulong> PermuteVar4x64(Vector256<ulong> value, Vector256<ulong> control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600669A RID: 26266 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<double> PermuteVar4x64x2(Vector256<double> lower, Vector256<long> indices, Vector256<double> upper)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600669B RID: 26267 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<long> PermuteVar4x64x2(Vector256<long> lower, Vector256<long> indices, Vector256<long> upper)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600669C RID: 26268 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ulong> PermuteVar4x64x2(Vector256<ulong> lower, Vector256<ulong> indices, Vector256<ulong> upper)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600669D RID: 26269 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> PermuteVar8x16(Vector128<short> left, Vector128<short> control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600669E RID: 26270 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> PermuteVar8x16(Vector128<ushort> left, Vector128<ushort> control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600669F RID: 26271 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> PermuteVar8x16x2(Vector128<short> lower, Vector128<short> indices, Vector128<short> upper)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066A0 RID: 26272 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> PermuteVar8x16x2(Vector128<ushort> lower, Vector128<ushort> indices, Vector128<ushort> upper)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066A1 RID: 26273 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<float> PermuteVar8x32x2(Vector256<float> lower, Vector256<int> indices, Vector256<float> upper)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066A2 RID: 26274 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<int> PermuteVar8x32x2(Vector256<int> lower, Vector256<int> indices, Vector256<int> upper)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066A3 RID: 26275 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<uint> PermuteVar8x32x2(Vector256<uint> lower, Vector256<uint> indices, Vector256<uint> upper)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066A4 RID: 26276 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> Range(Vector128<double> left, Vector128<double> right, [ConstantExpected(Max = 15)] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066A5 RID: 26277 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> Range(Vector128<float> left, Vector128<float> right, [ConstantExpected(Max = 15)] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066A6 RID: 26278 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<double> Range(Vector256<double> left, Vector256<double> right, [ConstantExpected(Max = 15)] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066A7 RID: 26279 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<float> Range(Vector256<float> left, Vector256<float> right, [ConstantExpected(Max = 15)] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066A8 RID: 26280 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> RangeScalar(Vector128<double> left, Vector128<double> right, [ConstantExpected(Max = 15)] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066A9 RID: 26281 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> RangeScalar(Vector128<float> left, Vector128<float> right, [ConstantExpected(Max = 15)] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066AA RID: 26282 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> Reciprocal14(Vector128<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066AB RID: 26283 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> Reciprocal14(Vector128<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066AC RID: 26284 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<double> Reciprocal14(Vector256<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066AD RID: 26285 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<float> Reciprocal14(Vector256<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066AE RID: 26286 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> Reciprocal14Scalar(Vector128<double> upper, Vector128<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066AF RID: 26287 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> Reciprocal14Scalar(Vector128<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066B0 RID: 26288 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> Reciprocal14Scalar(Vector128<float> upper, Vector128<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066B1 RID: 26289 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> Reciprocal14Scalar(Vector128<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066B2 RID: 26290 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> ReciprocalSqrt14(Vector128<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066B3 RID: 26291 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> ReciprocalSqrt14(Vector128<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066B4 RID: 26292 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<double> ReciprocalSqrt14(Vector256<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066B5 RID: 26293 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<float> ReciprocalSqrt14(Vector256<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066B6 RID: 26294 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> ReciprocalSqrt14Scalar(Vector128<double> upper, Vector128<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066B7 RID: 26295 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> ReciprocalSqrt14Scalar(Vector128<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066B8 RID: 26296 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> ReciprocalSqrt14Scalar(Vector128<float> upper, Vector128<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066B9 RID: 26297 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> ReciprocalSqrt14Scalar(Vector128<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066BA RID: 26298 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> Reduce(Vector128<double> value, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066BB RID: 26299 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> Reduce(Vector128<float> value, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066BC RID: 26300 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<double> Reduce(Vector256<double> value, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066BD RID: 26301 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<float> Reduce(Vector256<float> value, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066BE RID: 26302 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> ReduceScalar(Vector128<double> upper, Vector128<double> value, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066BF RID: 26303 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> ReduceScalar(Vector128<double> value, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066C0 RID: 26304 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> ReduceScalar(Vector128<float> upper, Vector128<float> value, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066C1 RID: 26305 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> ReduceScalar(Vector128<float> value, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066C2 RID: 26306 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> RotateLeft(Vector128<int> value, [ConstantExpected] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066C3 RID: 26307 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> RotateLeft(Vector128<long> value, [ConstantExpected] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066C4 RID: 26308 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> RotateLeft(Vector128<uint> value, [ConstantExpected] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066C5 RID: 26309 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> RotateLeft(Vector128<ulong> value, [ConstantExpected] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066C6 RID: 26310 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<int> RotateLeft(Vector256<int> value, [ConstantExpected] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066C7 RID: 26311 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<long> RotateLeft(Vector256<long> value, [ConstantExpected] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066C8 RID: 26312 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<uint> RotateLeft(Vector256<uint> value, [ConstantExpected] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066C9 RID: 26313 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ulong> RotateLeft(Vector256<ulong> value, [ConstantExpected] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066CA RID: 26314 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> RotateLeftVariable(Vector128<int> value, Vector128<uint> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066CB RID: 26315 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> RotateLeftVariable(Vector128<long> value, Vector128<ulong> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066CC RID: 26316 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> RotateLeftVariable(Vector128<uint> value, Vector128<uint> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066CD RID: 26317 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> RotateLeftVariable(Vector128<ulong> value, Vector128<ulong> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066CE RID: 26318 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<int> RotateLeftVariable(Vector256<int> value, Vector256<uint> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066CF RID: 26319 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<long> RotateLeftVariable(Vector256<long> value, Vector256<ulong> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066D0 RID: 26320 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<uint> RotateLeftVariable(Vector256<uint> value, Vector256<uint> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066D1 RID: 26321 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ulong> RotateLeftVariable(Vector256<ulong> value, Vector256<ulong> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066D2 RID: 26322 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> RotateRight(Vector128<int> value, [ConstantExpected] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066D3 RID: 26323 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> RotateRight(Vector128<long> value, [ConstantExpected] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066D4 RID: 26324 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> RotateRight(Vector128<uint> value, [ConstantExpected] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066D5 RID: 26325 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> RotateRight(Vector128<ulong> value, [ConstantExpected] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066D6 RID: 26326 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<int> RotateRight(Vector256<int> value, [ConstantExpected] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066D7 RID: 26327 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<long> RotateRight(Vector256<long> value, [ConstantExpected] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066D8 RID: 26328 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<uint> RotateRight(Vector256<uint> value, [ConstantExpected] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066D9 RID: 26329 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ulong> RotateRight(Vector256<ulong> value, [ConstantExpected] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066DA RID: 26330 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> RotateRightVariable(Vector128<int> value, Vector128<uint> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066DB RID: 26331 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> RotateRightVariable(Vector128<long> value, Vector128<ulong> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066DC RID: 26332 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> RotateRightVariable(Vector128<uint> value, Vector128<uint> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066DD RID: 26333 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> RotateRightVariable(Vector128<ulong> value, Vector128<ulong> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066DE RID: 26334 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<int> RotateRightVariable(Vector256<int> value, Vector256<uint> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066DF RID: 26335 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<long> RotateRightVariable(Vector256<long> value, Vector256<ulong> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066E0 RID: 26336 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<uint> RotateRightVariable(Vector256<uint> value, Vector256<uint> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066E1 RID: 26337 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ulong> RotateRightVariable(Vector256<ulong> value, Vector256<ulong> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066E2 RID: 26338 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> RoundScale(Vector128<double> value, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066E3 RID: 26339 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> RoundScale(Vector128<float> value, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066E4 RID: 26340 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<double> RoundScale(Vector256<double> value, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066E5 RID: 26341 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<float> RoundScale(Vector256<float> value, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066E6 RID: 26342 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> RoundScaleScalar(Vector128<double> upper, Vector128<double> value, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066E7 RID: 26343 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> RoundScaleScalar(Vector128<double> value, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066E8 RID: 26344 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> RoundScaleScalar(Vector128<float> upper, Vector128<float> value, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066E9 RID: 26345 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> RoundScaleScalar(Vector128<float> value, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066EA RID: 26346 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> Scale(Vector128<double> left, Vector128<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066EB RID: 26347 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> Scale(Vector128<float> left, Vector128<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066EC RID: 26348 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<double> Scale(Vector256<double> left, Vector256<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066ED RID: 26349 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<float> Scale(Vector256<float> left, Vector256<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066EE RID: 26350 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> ScaleScalar(Vector128<double> left, Vector128<double> right, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066EF RID: 26351 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> ScaleScalar(Vector128<double> left, Vector128<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066F0 RID: 26352 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> ScaleScalar(Vector128<float> left, Vector128<float> right, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066F1 RID: 26353 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> ScaleScalar(Vector128<float> left, Vector128<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066F2 RID: 26354 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> ShiftLeftLogicalVariable(Vector128<short> value, Vector128<ushort> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066F3 RID: 26355 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> ShiftLeftLogicalVariable(Vector128<ushort> value, Vector128<ushort> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066F4 RID: 26356 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<short> ShiftLeftLogicalVariable(Vector256<short> value, Vector256<ushort> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066F5 RID: 26357 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ushort> ShiftLeftLogicalVariable(Vector256<ushort> value, Vector256<ushort> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066F6 RID: 26358 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> ShiftRightArithmetic(Vector128<long> value, [ConstantExpected] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066F7 RID: 26359 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> ShiftRightArithmetic(Vector128<long> value, Vector128<long> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066F8 RID: 26360 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<long> ShiftRightArithmetic(Vector256<long> value, [ConstantExpected] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066F9 RID: 26361 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<long> ShiftRightArithmetic(Vector256<long> value, Vector128<long> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066FA RID: 26362 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> ShiftRightArithmeticVariable(Vector128<long> value, Vector128<ulong> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066FB RID: 26363 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> ShiftRightArithmeticVariable(Vector128<short> value, Vector128<ushort> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066FC RID: 26364 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<long> ShiftRightArithmeticVariable(Vector256<long> value, Vector256<ulong> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066FD RID: 26365 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<short> ShiftRightArithmeticVariable(Vector256<short> value, Vector256<ushort> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066FE RID: 26366 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> ShiftRightLogicalVariable(Vector128<short> value, Vector128<ushort> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060066FF RID: 26367 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> ShiftRightLogicalVariable(Vector128<ushort> value, Vector128<ushort> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006700 RID: 26368 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<short> ShiftRightLogicalVariable(Vector256<short> value, Vector256<ushort> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006701 RID: 26369 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ushort> ShiftRightLogicalVariable(Vector256<ushort> value, Vector256<ushort> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006702 RID: 26370 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<double> Shuffle2x128(Vector256<double> left, Vector256<double> right, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006703 RID: 26371 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<float> Shuffle2x128(Vector256<float> left, Vector256<float> right, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006704 RID: 26372 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<int> Shuffle2x128(Vector256<int> left, Vector256<int> right, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006705 RID: 26373 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<long> Shuffle2x128(Vector256<long> left, Vector256<long> right, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006706 RID: 26374 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<uint> Shuffle2x128(Vector256<uint> left, Vector256<uint> right, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006707 RID: 26375 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ulong> Shuffle2x128(Vector256<ulong> left, Vector256<ulong> right, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006708 RID: 26376 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> SqrtScalar(Vector128<double> upper, Vector128<double> value, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006709 RID: 26377 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> SqrtScalar(Vector128<float> upper, Vector128<float> value, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600670A RID: 26378 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> SubtractScalar(Vector128<double> left, Vector128<double> right, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600670B RID: 26379 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> SubtractScalar(Vector128<float> left, Vector128<float> right, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600670C RID: 26380 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> SumAbsoluteDifferencesInBlock32(Vector128<byte> left, Vector128<byte> right, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600670D RID: 26381 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ushort> SumAbsoluteDifferencesInBlock32(Vector256<byte> left, Vector256<byte> right, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600670E RID: 26382 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> TernaryLogic(Vector128<byte> a, Vector128<byte> b, Vector128<byte> c, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600670F RID: 26383 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> TernaryLogic(Vector128<double> a, Vector128<double> b, Vector128<double> c, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006710 RID: 26384 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> TernaryLogic(Vector128<float> a, Vector128<float> b, Vector128<float> c, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006711 RID: 26385 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> TernaryLogic(Vector128<int> a, Vector128<int> b, Vector128<int> c, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006712 RID: 26386 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> TernaryLogic(Vector128<long> a, Vector128<long> b, Vector128<long> c, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006713 RID: 26387 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> TernaryLogic(Vector128<sbyte> a, Vector128<sbyte> b, Vector128<sbyte> c, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006714 RID: 26388 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> TernaryLogic(Vector128<short> a, Vector128<short> b, Vector128<short> c, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006715 RID: 26389 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> TernaryLogic(Vector128<uint> a, Vector128<uint> b, Vector128<uint> c, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006716 RID: 26390 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> TernaryLogic(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006717 RID: 26391 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> TernaryLogic(Vector128<ushort> a, Vector128<ushort> b, Vector128<ushort> c, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006718 RID: 26392 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<byte> TernaryLogic(Vector256<byte> a, Vector256<byte> b, Vector256<byte> c, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006719 RID: 26393 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<double> TernaryLogic(Vector256<double> a, Vector256<double> b, Vector256<double> c, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600671A RID: 26394 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<float> TernaryLogic(Vector256<float> a, Vector256<float> b, Vector256<float> c, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600671B RID: 26395 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<int> TernaryLogic(Vector256<int> a, Vector256<int> b, Vector256<int> c, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600671C RID: 26396 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<long> TernaryLogic(Vector256<long> a, Vector256<long> b, Vector256<long> c, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600671D RID: 26397 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<sbyte> TernaryLogic(Vector256<sbyte> a, Vector256<sbyte> b, Vector256<sbyte> c, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600671E RID: 26398 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<short> TernaryLogic(Vector256<short> a, Vector256<short> b, Vector256<short> c, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600671F RID: 26399 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<uint> TernaryLogic(Vector256<uint> a, Vector256<uint> b, Vector256<uint> c, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006720 RID: 26400 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ulong> TernaryLogic(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006721 RID: 26401 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ushort> TernaryLogic(Vector256<ushort> a, Vector256<ushort> b, Vector256<ushort> c, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x02000570 RID: 1392
		public new abstract class X64 : Avx2.X64
		{
			// Token: 0x17000D7D RID: 3453
			// (get) Token: 0x06006722 RID: 26402 RVA: 0x00007B65 File Offset: 0x00005D65
			public new static bool IsSupported
			{
				[Intrinsic]
				get
				{
					return false;
				}
			}

			// Token: 0x06006723 RID: 26403 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<float> ConvertScalarToVector128Single(Vector128<float> upper, ulong value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006724 RID: 26404 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<float> ConvertScalarToVector128Single(Vector128<float> upper, long value, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006725 RID: 26405 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<float> ConvertScalarToVector128Single(Vector128<float> upper, ulong value, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006726 RID: 26406 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<double> ConvertScalarToVector128Double(Vector128<double> upper, ulong value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006727 RID: 26407 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<double> ConvertScalarToVector128Double(Vector128<double> upper, long value, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006728 RID: 26408 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<double> ConvertScalarToVector128Double(Vector128<double> upper, ulong value, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006729 RID: 26409 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static long ConvertToInt64(Vector128<float> value, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600672A RID: 26410 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static long ConvertToInt64(Vector128<double> value, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600672B RID: 26411 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static ulong ConvertToUInt64(Vector128<float> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600672C RID: 26412 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static ulong ConvertToUInt64(Vector128<float> value, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600672D RID: 26413 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static ulong ConvertToUInt64(Vector128<double> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600672E RID: 26414 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static ulong ConvertToUInt64(Vector128<double> value, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600672F RID: 26415 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static ulong ConvertToUInt64WithTruncation(Vector128<float> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006730 RID: 26416 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static ulong ConvertToUInt64WithTruncation(Vector128<double> value)
			{
				throw new PlatformNotSupportedException();
			}
		}

		// Token: 0x02000571 RID: 1393
		public abstract class V512 : Avx512BW
		{
			// Token: 0x17000D7E RID: 3454
			// (get) Token: 0x06006731 RID: 26417 RVA: 0x00007B65 File Offset: 0x00005D65
			public new static bool IsSupported
			{
				[Intrinsic]
				get
				{
					return false;
				}
			}

			// Token: 0x06006732 RID: 26418 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector512<int> DetectConflicts(Vector512<int> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006733 RID: 26419 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector512<uint> DetectConflicts(Vector512<uint> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006734 RID: 26420 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector512<long> DetectConflicts(Vector512<long> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006735 RID: 26421 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector512<ulong> DetectConflicts(Vector512<ulong> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006736 RID: 26422 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector512<int> LeadingZeroCount(Vector512<int> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006737 RID: 26423 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector512<uint> LeadingZeroCount(Vector512<uint> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006738 RID: 26424 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector512<long> LeadingZeroCount(Vector512<long> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006739 RID: 26425 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector512<ulong> LeadingZeroCount(Vector512<ulong> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600673A RID: 26426 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector512<float> And(Vector512<float> left, Vector512<float> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600673B RID: 26427 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector512<double> And(Vector512<double> left, Vector512<double> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600673C RID: 26428 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector512<float> AndNot(Vector512<float> left, Vector512<float> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600673D RID: 26429 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector512<double> AndNot(Vector512<double> left, Vector512<double> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600673E RID: 26430 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector512<int> BroadcastPairScalarToVector512(Vector128<int> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600673F RID: 26431 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector512<uint> BroadcastPairScalarToVector512(Vector128<uint> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006740 RID: 26432 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector512<float> BroadcastPairScalarToVector512(Vector128<float> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006741 RID: 26433 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static Vector512<long> BroadcastVector128ToVector512(long* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006742 RID: 26434 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static Vector512<ulong> BroadcastVector128ToVector512(ulong* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006743 RID: 26435 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static Vector512<double> BroadcastVector128ToVector512(double* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006744 RID: 26436 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static Vector512<int> BroadcastVector256ToVector512(int* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006745 RID: 26437 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static Vector512<uint> BroadcastVector256ToVector512(uint* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006746 RID: 26438 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static Vector512<float> BroadcastVector256ToVector512(float* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006747 RID: 26439 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<float> ConvertToVector256Single(Vector512<long> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006748 RID: 26440 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<float> ConvertToVector256Single(Vector512<ulong> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006749 RID: 26441 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<float> ConvertToVector256Single(Vector512<long> value, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600674A RID: 26442 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<float> ConvertToVector256Single(Vector512<ulong> value, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600674B RID: 26443 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector512<double> ConvertToVector512Double(Vector512<long> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600674C RID: 26444 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector512<double> ConvertToVector512Double(Vector512<ulong> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600674D RID: 26445 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector512<double> ConvertToVector512Double(Vector512<long> value, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600674E RID: 26446 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector512<double> ConvertToVector512Double(Vector512<ulong> value, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600674F RID: 26447 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector512<long> ConvertToVector512Int64(Vector256<float> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006750 RID: 26448 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector512<long> ConvertToVector512Int64(Vector512<double> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006751 RID: 26449 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector512<long> ConvertToVector512Int64(Vector256<float> value, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006752 RID: 26450 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector512<long> ConvertToVector512Int64(Vector512<double> value, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006753 RID: 26451 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector512<long> ConvertToVector512Int64WithTruncation(Vector256<float> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006754 RID: 26452 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector512<long> ConvertToVector512Int64WithTruncation(Vector512<double> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006755 RID: 26453 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector512<ulong> ConvertToVector512UInt64(Vector256<float> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006756 RID: 26454 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector512<ulong> ConvertToVector512UInt64(Vector512<double> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006757 RID: 26455 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector512<ulong> ConvertToVector512UInt64(Vector256<float> value, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006758 RID: 26456 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector512<ulong> ConvertToVector512UInt64(Vector512<double> value, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006759 RID: 26457 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector512<ulong> ConvertToVector512UInt64WithTruncation(Vector256<float> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600675A RID: 26458 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector512<ulong> ConvertToVector512UInt64WithTruncation(Vector512<double> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600675B RID: 26459 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public new static Vector128<long> ExtractVector128(Vector512<long> value, [ConstantExpected] byte index)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600675C RID: 26460 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public new static Vector128<ulong> ExtractVector128(Vector512<ulong> value, [ConstantExpected] byte index)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600675D RID: 26461 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public new static Vector128<double> ExtractVector128(Vector512<double> value, [ConstantExpected] byte index)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600675E RID: 26462 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public new static Vector256<int> ExtractVector256(Vector512<int> value, [ConstantExpected] byte index)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600675F RID: 26463 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public new static Vector256<uint> ExtractVector256(Vector512<uint> value, [ConstantExpected] byte index)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006760 RID: 26464 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public new static Vector256<float> ExtractVector256(Vector512<float> value, [ConstantExpected] byte index)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006761 RID: 26465 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public new static Vector512<long> InsertVector128(Vector512<long> value, Vector128<long> data, [ConstantExpected] byte index)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006762 RID: 26466 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public new static Vector512<ulong> InsertVector128(Vector512<ulong> value, Vector128<ulong> data, [ConstantExpected] byte index)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006763 RID: 26467 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public new static Vector512<double> InsertVector128(Vector512<double> value, Vector128<double> data, [ConstantExpected] byte index)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006764 RID: 26468 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public new static Vector512<int> InsertVector256(Vector512<int> value, Vector256<int> data, [ConstantExpected] byte index)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006765 RID: 26469 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public new static Vector512<uint> InsertVector256(Vector512<uint> value, Vector256<uint> data, [ConstantExpected] byte index)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006766 RID: 26470 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public new static Vector512<float> InsertVector256(Vector512<float> value, Vector256<float> data, [ConstantExpected] byte index)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006767 RID: 26471 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector512<long> MultiplyLow(Vector512<long> left, Vector512<long> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006768 RID: 26472 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector512<ulong> MultiplyLow(Vector512<ulong> left, Vector512<ulong> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006769 RID: 26473 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector512<byte> MultiShift(Vector512<byte> control, Vector512<ulong> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600676A RID: 26474 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector512<sbyte> MultiShift(Vector512<sbyte> control, Vector512<long> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600676B RID: 26475 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector512<float> Or(Vector512<float> left, Vector512<float> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600676C RID: 26476 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector512<double> Or(Vector512<double> left, Vector512<double> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600676D RID: 26477 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector512<float> Range(Vector512<float> left, Vector512<float> right, [ConstantExpected(Max = 15)] byte control)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600676E RID: 26478 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector512<double> Range(Vector512<double> left, Vector512<double> right, [ConstantExpected(Max = 15)] byte control)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600676F RID: 26479 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector512<float> Reduce(Vector512<float> value, [ConstantExpected] byte control)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006770 RID: 26480 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector512<double> Reduce(Vector512<double> value, [ConstantExpected] byte control)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006771 RID: 26481 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector512<float> Xor(Vector512<float> left, Vector512<float> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006772 RID: 26482 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector512<double> Xor(Vector512<double> left, Vector512<double> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006773 RID: 26483 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector512<sbyte> PermuteVar64x8(Vector512<sbyte> left, Vector512<sbyte> control)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006774 RID: 26484 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector512<byte> PermuteVar64x8(Vector512<byte> left, Vector512<byte> control)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006775 RID: 26485 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector512<byte> PermuteVar64x8x2(Vector512<byte> lower, Vector512<byte> indices, Vector512<byte> upper)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006776 RID: 26486 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector512<sbyte> PermuteVar64x8x2(Vector512<sbyte> lower, Vector512<sbyte> indices, Vector512<sbyte> upper)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x02000572 RID: 1394
			[Intrinsic]
			public new abstract class X64 : Avx512BW.X64
			{
				// Token: 0x17000D7F RID: 3455
				// (get) Token: 0x06006777 RID: 26487 RVA: 0x00007B65 File Offset: 0x00005D65
				public new static bool IsSupported
				{
					[Intrinsic]
					get
					{
						return false;
					}
				}
			}
		}
	}
}
