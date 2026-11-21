using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Runtime.Intrinsics.Arm
{
	// Token: 0x02000553 RID: 1363
	[CLSCompliant(false)]
	public abstract class AdvSimd : ArmBase
	{
		// Token: 0x17000D62 RID: 3426
		// (get) Token: 0x0600526A RID: 21098 RVA: 0x00007B65 File Offset: 0x00005D65
		public new static bool IsSupported
		{
			[Intrinsic]
			get
			{
				return false;
			}
		}

		// Token: 0x0600526B RID: 21099 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ushort> Abs(Vector64<short> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600526C RID: 21100 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> Abs(Vector64<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600526D RID: 21101 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<byte> Abs(Vector64<sbyte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600526E RID: 21102 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<float> Abs(Vector64<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600526F RID: 21103 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> Abs(Vector128<short> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005270 RID: 21104 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> Abs(Vector128<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005271 RID: 21105 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> Abs(Vector128<sbyte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005272 RID: 21106 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> Abs(Vector128<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005273 RID: 21107 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> AbsSaturate(Vector64<short> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005274 RID: 21108 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> AbsSaturate(Vector64<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005275 RID: 21109 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<sbyte> AbsSaturate(Vector64<sbyte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005276 RID: 21110 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> AbsSaturate(Vector128<short> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005277 RID: 21111 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> AbsSaturate(Vector128<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005278 RID: 21112 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> AbsSaturate(Vector128<sbyte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005279 RID: 21113 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<double> AbsScalar(Vector64<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600527A RID: 21114 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<float> AbsScalar(Vector64<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600527B RID: 21115 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<float> AbsoluteCompareGreaterThan(Vector64<float> left, Vector64<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600527C RID: 21116 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> AbsoluteCompareGreaterThan(Vector128<float> left, Vector128<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600527D RID: 21117 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<float> AbsoluteCompareGreaterThanOrEqual(Vector64<float> left, Vector64<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600527E RID: 21118 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> AbsoluteCompareGreaterThanOrEqual(Vector128<float> left, Vector128<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600527F RID: 21119 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<float> AbsoluteCompareLessThan(Vector64<float> left, Vector64<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005280 RID: 21120 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> AbsoluteCompareLessThan(Vector128<float> left, Vector128<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005281 RID: 21121 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<float> AbsoluteCompareLessThanOrEqual(Vector64<float> left, Vector64<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005282 RID: 21122 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> AbsoluteCompareLessThanOrEqual(Vector128<float> left, Vector128<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005283 RID: 21123 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<byte> AbsoluteDifference(Vector64<byte> left, Vector64<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005284 RID: 21124 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ushort> AbsoluteDifference(Vector64<short> left, Vector64<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005285 RID: 21125 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> AbsoluteDifference(Vector64<int> left, Vector64<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005286 RID: 21126 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<byte> AbsoluteDifference(Vector64<sbyte> left, Vector64<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005287 RID: 21127 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<float> AbsoluteDifference(Vector64<float> left, Vector64<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005288 RID: 21128 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ushort> AbsoluteDifference(Vector64<ushort> left, Vector64<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005289 RID: 21129 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> AbsoluteDifference(Vector64<uint> left, Vector64<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600528A RID: 21130 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> AbsoluteDifference(Vector128<byte> left, Vector128<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600528B RID: 21131 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> AbsoluteDifference(Vector128<short> left, Vector128<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600528C RID: 21132 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> AbsoluteDifference(Vector128<int> left, Vector128<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600528D RID: 21133 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> AbsoluteDifference(Vector128<sbyte> left, Vector128<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600528E RID: 21134 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> AbsoluteDifference(Vector128<float> left, Vector128<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600528F RID: 21135 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> AbsoluteDifference(Vector128<ushort> left, Vector128<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005290 RID: 21136 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> AbsoluteDifference(Vector128<uint> left, Vector128<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005291 RID: 21137 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<byte> AbsoluteDifferenceAdd(Vector64<byte> addend, Vector64<byte> left, Vector64<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005292 RID: 21138 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> AbsoluteDifferenceAdd(Vector64<short> addend, Vector64<short> left, Vector64<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005293 RID: 21139 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> AbsoluteDifferenceAdd(Vector64<int> addend, Vector64<int> left, Vector64<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005294 RID: 21140 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<sbyte> AbsoluteDifferenceAdd(Vector64<sbyte> addend, Vector64<sbyte> left, Vector64<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005295 RID: 21141 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ushort> AbsoluteDifferenceAdd(Vector64<ushort> addend, Vector64<ushort> left, Vector64<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005296 RID: 21142 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> AbsoluteDifferenceAdd(Vector64<uint> addend, Vector64<uint> left, Vector64<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005297 RID: 21143 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> AbsoluteDifferenceAdd(Vector128<byte> addend, Vector128<byte> left, Vector128<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005298 RID: 21144 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> AbsoluteDifferenceAdd(Vector128<short> addend, Vector128<short> left, Vector128<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005299 RID: 21145 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> AbsoluteDifferenceAdd(Vector128<int> addend, Vector128<int> left, Vector128<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600529A RID: 21146 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> AbsoluteDifferenceAdd(Vector128<sbyte> addend, Vector128<sbyte> left, Vector128<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600529B RID: 21147 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> AbsoluteDifferenceAdd(Vector128<ushort> addend, Vector128<ushort> left, Vector128<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600529C RID: 21148 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> AbsoluteDifferenceAdd(Vector128<uint> addend, Vector128<uint> left, Vector128<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600529D RID: 21149 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> AbsoluteDifferenceWideningLower(Vector64<byte> left, Vector64<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600529E RID: 21150 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> AbsoluteDifferenceWideningLower(Vector64<short> left, Vector64<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600529F RID: 21151 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> AbsoluteDifferenceWideningLower(Vector64<int> left, Vector64<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052A0 RID: 21152 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> AbsoluteDifferenceWideningLower(Vector64<sbyte> left, Vector64<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052A1 RID: 21153 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> AbsoluteDifferenceWideningLower(Vector64<ushort> left, Vector64<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052A2 RID: 21154 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> AbsoluteDifferenceWideningLower(Vector64<uint> left, Vector64<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052A3 RID: 21155 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> AbsoluteDifferenceWideningLowerAndAdd(Vector128<ushort> addend, Vector64<byte> left, Vector64<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052A4 RID: 21156 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> AbsoluteDifferenceWideningLowerAndAdd(Vector128<int> addend, Vector64<short> left, Vector64<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052A5 RID: 21157 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> AbsoluteDifferenceWideningLowerAndAdd(Vector128<long> addend, Vector64<int> left, Vector64<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052A6 RID: 21158 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> AbsoluteDifferenceWideningLowerAndAdd(Vector128<short> addend, Vector64<sbyte> left, Vector64<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052A7 RID: 21159 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> AbsoluteDifferenceWideningLowerAndAdd(Vector128<uint> addend, Vector64<ushort> left, Vector64<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052A8 RID: 21160 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> AbsoluteDifferenceWideningLowerAndAdd(Vector128<ulong> addend, Vector64<uint> left, Vector64<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052A9 RID: 21161 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> AbsoluteDifferenceWideningUpper(Vector128<byte> left, Vector128<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052AA RID: 21162 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> AbsoluteDifferenceWideningUpper(Vector128<short> left, Vector128<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052AB RID: 21163 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> AbsoluteDifferenceWideningUpper(Vector128<int> left, Vector128<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052AC RID: 21164 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> AbsoluteDifferenceWideningUpper(Vector128<sbyte> left, Vector128<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052AD RID: 21165 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> AbsoluteDifferenceWideningUpper(Vector128<ushort> left, Vector128<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052AE RID: 21166 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> AbsoluteDifferenceWideningUpper(Vector128<uint> left, Vector128<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052AF RID: 21167 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> AbsoluteDifferenceWideningUpperAndAdd(Vector128<ushort> addend, Vector128<byte> left, Vector128<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052B0 RID: 21168 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> AbsoluteDifferenceWideningUpperAndAdd(Vector128<int> addend, Vector128<short> left, Vector128<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052B1 RID: 21169 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> AbsoluteDifferenceWideningUpperAndAdd(Vector128<long> addend, Vector128<int> left, Vector128<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052B2 RID: 21170 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> AbsoluteDifferenceWideningUpperAndAdd(Vector128<short> addend, Vector128<sbyte> left, Vector128<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052B3 RID: 21171 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> AbsoluteDifferenceWideningUpperAndAdd(Vector128<uint> addend, Vector128<ushort> left, Vector128<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052B4 RID: 21172 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> AbsoluteDifferenceWideningUpperAndAdd(Vector128<ulong> addend, Vector128<uint> left, Vector128<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052B5 RID: 21173 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<byte> Add(Vector64<byte> left, Vector64<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052B6 RID: 21174 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> Add(Vector64<short> left, Vector64<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052B7 RID: 21175 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> Add(Vector64<int> left, Vector64<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052B8 RID: 21176 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<sbyte> Add(Vector64<sbyte> left, Vector64<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052B9 RID: 21177 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<float> Add(Vector64<float> left, Vector64<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052BA RID: 21178 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ushort> Add(Vector64<ushort> left, Vector64<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052BB RID: 21179 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> Add(Vector64<uint> left, Vector64<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052BC RID: 21180 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> Add(Vector128<byte> left, Vector128<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052BD RID: 21181 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> Add(Vector128<short> left, Vector128<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052BE RID: 21182 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> Add(Vector128<int> left, Vector128<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052BF RID: 21183 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> Add(Vector128<long> left, Vector128<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052C0 RID: 21184 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> Add(Vector128<sbyte> left, Vector128<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052C1 RID: 21185 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> Add(Vector128<float> left, Vector128<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052C2 RID: 21186 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> Add(Vector128<ushort> left, Vector128<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052C3 RID: 21187 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> Add(Vector128<uint> left, Vector128<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052C4 RID: 21188 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> Add(Vector128<ulong> left, Vector128<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052C5 RID: 21189 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<byte> AddHighNarrowingLower(Vector128<ushort> left, Vector128<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052C6 RID: 21190 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> AddHighNarrowingLower(Vector128<int> left, Vector128<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052C7 RID: 21191 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> AddHighNarrowingLower(Vector128<long> left, Vector128<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052C8 RID: 21192 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<sbyte> AddHighNarrowingLower(Vector128<short> left, Vector128<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052C9 RID: 21193 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ushort> AddHighNarrowingLower(Vector128<uint> left, Vector128<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052CA RID: 21194 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> AddHighNarrowingLower(Vector128<ulong> left, Vector128<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052CB RID: 21195 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> AddHighNarrowingUpper(Vector64<byte> lower, Vector128<ushort> left, Vector128<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052CC RID: 21196 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> AddHighNarrowingUpper(Vector64<short> lower, Vector128<int> left, Vector128<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052CD RID: 21197 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> AddHighNarrowingUpper(Vector64<int> lower, Vector128<long> left, Vector128<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052CE RID: 21198 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> AddHighNarrowingUpper(Vector64<sbyte> lower, Vector128<short> left, Vector128<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052CF RID: 21199 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> AddHighNarrowingUpper(Vector64<ushort> lower, Vector128<uint> left, Vector128<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052D0 RID: 21200 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> AddHighNarrowingUpper(Vector64<uint> lower, Vector128<ulong> left, Vector128<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052D1 RID: 21201 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<byte> AddPairwise(Vector64<byte> left, Vector64<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052D2 RID: 21202 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> AddPairwise(Vector64<short> left, Vector64<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052D3 RID: 21203 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> AddPairwise(Vector64<int> left, Vector64<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052D4 RID: 21204 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<sbyte> AddPairwise(Vector64<sbyte> left, Vector64<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052D5 RID: 21205 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<float> AddPairwise(Vector64<float> left, Vector64<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052D6 RID: 21206 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ushort> AddPairwise(Vector64<ushort> left, Vector64<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052D7 RID: 21207 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> AddPairwise(Vector64<uint> left, Vector64<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052D8 RID: 21208 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ushort> AddPairwiseWidening(Vector64<byte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052D9 RID: 21209 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> AddPairwiseWidening(Vector64<short> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052DA RID: 21210 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> AddPairwiseWidening(Vector64<sbyte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052DB RID: 21211 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> AddPairwiseWidening(Vector64<ushort> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052DC RID: 21212 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> AddPairwiseWidening(Vector128<byte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052DD RID: 21213 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> AddPairwiseWidening(Vector128<short> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052DE RID: 21214 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> AddPairwiseWidening(Vector128<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052DF RID: 21215 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> AddPairwiseWidening(Vector128<sbyte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052E0 RID: 21216 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> AddPairwiseWidening(Vector128<ushort> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052E1 RID: 21217 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> AddPairwiseWidening(Vector128<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052E2 RID: 21218 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ushort> AddPairwiseWideningAndAdd(Vector64<ushort> addend, Vector64<byte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052E3 RID: 21219 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> AddPairwiseWideningAndAdd(Vector64<int> addend, Vector64<short> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052E4 RID: 21220 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> AddPairwiseWideningAndAdd(Vector64<short> addend, Vector64<sbyte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052E5 RID: 21221 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> AddPairwiseWideningAndAdd(Vector64<uint> addend, Vector64<ushort> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052E6 RID: 21222 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> AddPairwiseWideningAndAdd(Vector128<ushort> addend, Vector128<byte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052E7 RID: 21223 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> AddPairwiseWideningAndAdd(Vector128<int> addend, Vector128<short> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052E8 RID: 21224 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> AddPairwiseWideningAndAdd(Vector128<long> addend, Vector128<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052E9 RID: 21225 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> AddPairwiseWideningAndAdd(Vector128<short> addend, Vector128<sbyte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052EA RID: 21226 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> AddPairwiseWideningAndAdd(Vector128<uint> addend, Vector128<ushort> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052EB RID: 21227 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> AddPairwiseWideningAndAdd(Vector128<ulong> addend, Vector128<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052EC RID: 21228 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<long> AddPairwiseWideningAndAddScalar(Vector64<long> addend, Vector64<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052ED RID: 21229 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ulong> AddPairwiseWideningAndAddScalar(Vector64<ulong> addend, Vector64<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052EE RID: 21230 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<long> AddPairwiseWideningScalar(Vector64<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052EF RID: 21231 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ulong> AddPairwiseWideningScalar(Vector64<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052F0 RID: 21232 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<byte> AddRoundedHighNarrowingLower(Vector128<ushort> left, Vector128<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052F1 RID: 21233 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> AddRoundedHighNarrowingLower(Vector128<int> left, Vector128<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052F2 RID: 21234 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> AddRoundedHighNarrowingLower(Vector128<long> left, Vector128<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052F3 RID: 21235 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<sbyte> AddRoundedHighNarrowingLower(Vector128<short> left, Vector128<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052F4 RID: 21236 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ushort> AddRoundedHighNarrowingLower(Vector128<uint> left, Vector128<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052F5 RID: 21237 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> AddRoundedHighNarrowingLower(Vector128<ulong> left, Vector128<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052F6 RID: 21238 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> AddRoundedHighNarrowingUpper(Vector64<byte> lower, Vector128<ushort> left, Vector128<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052F7 RID: 21239 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> AddRoundedHighNarrowingUpper(Vector64<short> lower, Vector128<int> left, Vector128<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052F8 RID: 21240 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> AddRoundedHighNarrowingUpper(Vector64<int> lower, Vector128<long> left, Vector128<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052F9 RID: 21241 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> AddRoundedHighNarrowingUpper(Vector64<sbyte> lower, Vector128<short> left, Vector128<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052FA RID: 21242 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> AddRoundedHighNarrowingUpper(Vector64<ushort> lower, Vector128<uint> left, Vector128<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052FB RID: 21243 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> AddRoundedHighNarrowingUpper(Vector64<uint> lower, Vector128<ulong> left, Vector128<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052FC RID: 21244 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<byte> AddSaturate(Vector64<byte> left, Vector64<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052FD RID: 21245 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> AddSaturate(Vector64<short> left, Vector64<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052FE RID: 21246 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> AddSaturate(Vector64<int> left, Vector64<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060052FF RID: 21247 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<sbyte> AddSaturate(Vector64<sbyte> left, Vector64<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005300 RID: 21248 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ushort> AddSaturate(Vector64<ushort> left, Vector64<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005301 RID: 21249 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> AddSaturate(Vector64<uint> left, Vector64<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005302 RID: 21250 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> AddSaturate(Vector128<byte> left, Vector128<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005303 RID: 21251 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> AddSaturate(Vector128<short> left, Vector128<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005304 RID: 21252 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> AddSaturate(Vector128<int> left, Vector128<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005305 RID: 21253 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> AddSaturate(Vector128<long> left, Vector128<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005306 RID: 21254 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> AddSaturate(Vector128<sbyte> left, Vector128<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005307 RID: 21255 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> AddSaturate(Vector128<ushort> left, Vector128<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005308 RID: 21256 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> AddSaturate(Vector128<uint> left, Vector128<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005309 RID: 21257 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> AddSaturate(Vector128<ulong> left, Vector128<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600530A RID: 21258 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<long> AddSaturateScalar(Vector64<long> left, Vector64<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600530B RID: 21259 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ulong> AddSaturateScalar(Vector64<ulong> left, Vector64<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600530C RID: 21260 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<double> AddScalar(Vector64<double> left, Vector64<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600530D RID: 21261 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<long> AddScalar(Vector64<long> left, Vector64<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600530E RID: 21262 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<float> AddScalar(Vector64<float> left, Vector64<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600530F RID: 21263 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ulong> AddScalar(Vector64<ulong> left, Vector64<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005310 RID: 21264 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> AddWideningLower(Vector64<byte> left, Vector64<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005311 RID: 21265 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> AddWideningLower(Vector64<short> left, Vector64<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005312 RID: 21266 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> AddWideningLower(Vector64<int> left, Vector64<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005313 RID: 21267 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> AddWideningLower(Vector64<sbyte> left, Vector64<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005314 RID: 21268 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> AddWideningLower(Vector64<ushort> left, Vector64<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005315 RID: 21269 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> AddWideningLower(Vector64<uint> left, Vector64<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005316 RID: 21270 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> AddWideningLower(Vector128<short> left, Vector64<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005317 RID: 21271 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> AddWideningLower(Vector128<int> left, Vector64<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005318 RID: 21272 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> AddWideningLower(Vector128<long> left, Vector64<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005319 RID: 21273 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> AddWideningLower(Vector128<ushort> left, Vector64<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600531A RID: 21274 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> AddWideningLower(Vector128<uint> left, Vector64<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600531B RID: 21275 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> AddWideningLower(Vector128<ulong> left, Vector64<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600531C RID: 21276 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> AddWideningUpper(Vector128<byte> left, Vector128<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600531D RID: 21277 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> AddWideningUpper(Vector128<short> left, Vector128<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600531E RID: 21278 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> AddWideningUpper(Vector128<short> left, Vector128<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600531F RID: 21279 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> AddWideningUpper(Vector128<int> left, Vector128<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005320 RID: 21280 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> AddWideningUpper(Vector128<int> left, Vector128<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005321 RID: 21281 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> AddWideningUpper(Vector128<long> left, Vector128<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005322 RID: 21282 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> AddWideningUpper(Vector128<sbyte> left, Vector128<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005323 RID: 21283 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> AddWideningUpper(Vector128<ushort> left, Vector128<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005324 RID: 21284 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> AddWideningUpper(Vector128<ushort> left, Vector128<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005325 RID: 21285 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> AddWideningUpper(Vector128<uint> left, Vector128<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005326 RID: 21286 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> AddWideningUpper(Vector128<uint> left, Vector128<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005327 RID: 21287 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> AddWideningUpper(Vector128<ulong> left, Vector128<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005328 RID: 21288 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<byte> And(Vector64<byte> left, Vector64<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005329 RID: 21289 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<double> And(Vector64<double> left, Vector64<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600532A RID: 21290 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> And(Vector64<short> left, Vector64<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600532B RID: 21291 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> And(Vector64<int> left, Vector64<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600532C RID: 21292 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<long> And(Vector64<long> left, Vector64<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600532D RID: 21293 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<sbyte> And(Vector64<sbyte> left, Vector64<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600532E RID: 21294 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<float> And(Vector64<float> left, Vector64<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600532F RID: 21295 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ushort> And(Vector64<ushort> left, Vector64<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005330 RID: 21296 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> And(Vector64<uint> left, Vector64<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005331 RID: 21297 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ulong> And(Vector64<ulong> left, Vector64<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005332 RID: 21298 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> And(Vector128<byte> left, Vector128<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005333 RID: 21299 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> And(Vector128<double> left, Vector128<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005334 RID: 21300 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> And(Vector128<short> left, Vector128<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005335 RID: 21301 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> And(Vector128<int> left, Vector128<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005336 RID: 21302 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> And(Vector128<long> left, Vector128<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005337 RID: 21303 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> And(Vector128<sbyte> left, Vector128<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005338 RID: 21304 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> And(Vector128<float> left, Vector128<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005339 RID: 21305 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> And(Vector128<ushort> left, Vector128<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600533A RID: 21306 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> And(Vector128<uint> left, Vector128<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600533B RID: 21307 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> And(Vector128<ulong> left, Vector128<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600533C RID: 21308 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<byte> BitwiseClear(Vector64<byte> value, Vector64<byte> mask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600533D RID: 21309 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<double> BitwiseClear(Vector64<double> value, Vector64<double> mask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600533E RID: 21310 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> BitwiseClear(Vector64<short> value, Vector64<short> mask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600533F RID: 21311 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> BitwiseClear(Vector64<int> value, Vector64<int> mask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005340 RID: 21312 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<long> BitwiseClear(Vector64<long> value, Vector64<long> mask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005341 RID: 21313 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<sbyte> BitwiseClear(Vector64<sbyte> value, Vector64<sbyte> mask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005342 RID: 21314 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<float> BitwiseClear(Vector64<float> value, Vector64<float> mask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005343 RID: 21315 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ushort> BitwiseClear(Vector64<ushort> value, Vector64<ushort> mask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005344 RID: 21316 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> BitwiseClear(Vector64<uint> value, Vector64<uint> mask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005345 RID: 21317 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ulong> BitwiseClear(Vector64<ulong> value, Vector64<ulong> mask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005346 RID: 21318 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> BitwiseClear(Vector128<byte> value, Vector128<byte> mask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005347 RID: 21319 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> BitwiseClear(Vector128<double> value, Vector128<double> mask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005348 RID: 21320 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> BitwiseClear(Vector128<short> value, Vector128<short> mask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005349 RID: 21321 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> BitwiseClear(Vector128<int> value, Vector128<int> mask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600534A RID: 21322 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> BitwiseClear(Vector128<long> value, Vector128<long> mask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600534B RID: 21323 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> BitwiseClear(Vector128<sbyte> value, Vector128<sbyte> mask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600534C RID: 21324 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> BitwiseClear(Vector128<float> value, Vector128<float> mask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600534D RID: 21325 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> BitwiseClear(Vector128<ushort> value, Vector128<ushort> mask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600534E RID: 21326 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> BitwiseClear(Vector128<uint> value, Vector128<uint> mask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600534F RID: 21327 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> BitwiseClear(Vector128<ulong> value, Vector128<ulong> mask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005350 RID: 21328 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<byte> BitwiseSelect(Vector64<byte> select, Vector64<byte> left, Vector64<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005351 RID: 21329 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<double> BitwiseSelect(Vector64<double> select, Vector64<double> left, Vector64<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005352 RID: 21330 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> BitwiseSelect(Vector64<short> select, Vector64<short> left, Vector64<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005353 RID: 21331 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> BitwiseSelect(Vector64<int> select, Vector64<int> left, Vector64<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005354 RID: 21332 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<long> BitwiseSelect(Vector64<long> select, Vector64<long> left, Vector64<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005355 RID: 21333 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<sbyte> BitwiseSelect(Vector64<sbyte> select, Vector64<sbyte> left, Vector64<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005356 RID: 21334 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<float> BitwiseSelect(Vector64<float> select, Vector64<float> left, Vector64<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005357 RID: 21335 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ushort> BitwiseSelect(Vector64<ushort> select, Vector64<ushort> left, Vector64<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005358 RID: 21336 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> BitwiseSelect(Vector64<uint> select, Vector64<uint> left, Vector64<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005359 RID: 21337 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ulong> BitwiseSelect(Vector64<ulong> select, Vector64<ulong> left, Vector64<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600535A RID: 21338 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> BitwiseSelect(Vector128<byte> select, Vector128<byte> left, Vector128<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600535B RID: 21339 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> BitwiseSelect(Vector128<double> select, Vector128<double> left, Vector128<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600535C RID: 21340 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> BitwiseSelect(Vector128<short> select, Vector128<short> left, Vector128<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600535D RID: 21341 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> BitwiseSelect(Vector128<int> select, Vector128<int> left, Vector128<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600535E RID: 21342 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> BitwiseSelect(Vector128<long> select, Vector128<long> left, Vector128<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600535F RID: 21343 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> BitwiseSelect(Vector128<sbyte> select, Vector128<sbyte> left, Vector128<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005360 RID: 21344 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> BitwiseSelect(Vector128<float> select, Vector128<float> left, Vector128<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005361 RID: 21345 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> BitwiseSelect(Vector128<ushort> select, Vector128<ushort> left, Vector128<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005362 RID: 21346 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> BitwiseSelect(Vector128<uint> select, Vector128<uint> left, Vector128<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005363 RID: 21347 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> BitwiseSelect(Vector128<ulong> select, Vector128<ulong> left, Vector128<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005364 RID: 21348 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<float> Ceiling(Vector64<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005365 RID: 21349 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> Ceiling(Vector128<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005366 RID: 21350 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<double> CeilingScalar(Vector64<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005367 RID: 21351 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<float> CeilingScalar(Vector64<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005368 RID: 21352 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<byte> CompareEqual(Vector64<byte> left, Vector64<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005369 RID: 21353 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> CompareEqual(Vector64<short> left, Vector64<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600536A RID: 21354 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> CompareEqual(Vector64<int> left, Vector64<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600536B RID: 21355 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<sbyte> CompareEqual(Vector64<sbyte> left, Vector64<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600536C RID: 21356 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<float> CompareEqual(Vector64<float> left, Vector64<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600536D RID: 21357 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ushort> CompareEqual(Vector64<ushort> left, Vector64<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600536E RID: 21358 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> CompareEqual(Vector64<uint> left, Vector64<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600536F RID: 21359 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> CompareEqual(Vector128<byte> left, Vector128<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005370 RID: 21360 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> CompareEqual(Vector128<short> left, Vector128<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005371 RID: 21361 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> CompareEqual(Vector128<int> left, Vector128<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005372 RID: 21362 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> CompareEqual(Vector128<sbyte> left, Vector128<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005373 RID: 21363 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> CompareEqual(Vector128<float> left, Vector128<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005374 RID: 21364 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> CompareEqual(Vector128<ushort> left, Vector128<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005375 RID: 21365 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> CompareEqual(Vector128<uint> left, Vector128<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005376 RID: 21366 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<byte> CompareGreaterThan(Vector64<byte> left, Vector64<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005377 RID: 21367 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> CompareGreaterThan(Vector64<short> left, Vector64<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005378 RID: 21368 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> CompareGreaterThan(Vector64<int> left, Vector64<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005379 RID: 21369 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<sbyte> CompareGreaterThan(Vector64<sbyte> left, Vector64<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600537A RID: 21370 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<float> CompareGreaterThan(Vector64<float> left, Vector64<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600537B RID: 21371 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ushort> CompareGreaterThan(Vector64<ushort> left, Vector64<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600537C RID: 21372 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> CompareGreaterThan(Vector64<uint> left, Vector64<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600537D RID: 21373 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> CompareGreaterThan(Vector128<byte> left, Vector128<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600537E RID: 21374 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> CompareGreaterThan(Vector128<short> left, Vector128<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600537F RID: 21375 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> CompareGreaterThan(Vector128<int> left, Vector128<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005380 RID: 21376 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> CompareGreaterThan(Vector128<sbyte> left, Vector128<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005381 RID: 21377 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> CompareGreaterThan(Vector128<float> left, Vector128<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005382 RID: 21378 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> CompareGreaterThan(Vector128<ushort> left, Vector128<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005383 RID: 21379 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> CompareGreaterThan(Vector128<uint> left, Vector128<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005384 RID: 21380 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<byte> CompareGreaterThanOrEqual(Vector64<byte> left, Vector64<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005385 RID: 21381 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> CompareGreaterThanOrEqual(Vector64<short> left, Vector64<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005386 RID: 21382 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> CompareGreaterThanOrEqual(Vector64<int> left, Vector64<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005387 RID: 21383 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<sbyte> CompareGreaterThanOrEqual(Vector64<sbyte> left, Vector64<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005388 RID: 21384 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<float> CompareGreaterThanOrEqual(Vector64<float> left, Vector64<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005389 RID: 21385 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ushort> CompareGreaterThanOrEqual(Vector64<ushort> left, Vector64<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600538A RID: 21386 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> CompareGreaterThanOrEqual(Vector64<uint> left, Vector64<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600538B RID: 21387 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> CompareGreaterThanOrEqual(Vector128<byte> left, Vector128<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600538C RID: 21388 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> CompareGreaterThanOrEqual(Vector128<short> left, Vector128<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600538D RID: 21389 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> CompareGreaterThanOrEqual(Vector128<int> left, Vector128<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600538E RID: 21390 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> CompareGreaterThanOrEqual(Vector128<sbyte> left, Vector128<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600538F RID: 21391 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> CompareGreaterThanOrEqual(Vector128<float> left, Vector128<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005390 RID: 21392 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> CompareGreaterThanOrEqual(Vector128<ushort> left, Vector128<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005391 RID: 21393 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> CompareGreaterThanOrEqual(Vector128<uint> left, Vector128<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005392 RID: 21394 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<byte> CompareLessThan(Vector64<byte> left, Vector64<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005393 RID: 21395 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> CompareLessThan(Vector64<short> left, Vector64<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005394 RID: 21396 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> CompareLessThan(Vector64<int> left, Vector64<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005395 RID: 21397 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<sbyte> CompareLessThan(Vector64<sbyte> left, Vector64<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005396 RID: 21398 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<float> CompareLessThan(Vector64<float> left, Vector64<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005397 RID: 21399 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ushort> CompareLessThan(Vector64<ushort> left, Vector64<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005398 RID: 21400 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> CompareLessThan(Vector64<uint> left, Vector64<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005399 RID: 21401 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> CompareLessThan(Vector128<byte> left, Vector128<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600539A RID: 21402 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> CompareLessThan(Vector128<short> left, Vector128<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600539B RID: 21403 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> CompareLessThan(Vector128<int> left, Vector128<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600539C RID: 21404 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> CompareLessThan(Vector128<sbyte> left, Vector128<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600539D RID: 21405 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> CompareLessThan(Vector128<float> left, Vector128<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600539E RID: 21406 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> CompareLessThan(Vector128<ushort> left, Vector128<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600539F RID: 21407 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> CompareLessThan(Vector128<uint> left, Vector128<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053A0 RID: 21408 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<byte> CompareLessThanOrEqual(Vector64<byte> left, Vector64<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053A1 RID: 21409 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> CompareLessThanOrEqual(Vector64<short> left, Vector64<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053A2 RID: 21410 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> CompareLessThanOrEqual(Vector64<int> left, Vector64<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053A3 RID: 21411 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<sbyte> CompareLessThanOrEqual(Vector64<sbyte> left, Vector64<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053A4 RID: 21412 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<float> CompareLessThanOrEqual(Vector64<float> left, Vector64<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053A5 RID: 21413 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ushort> CompareLessThanOrEqual(Vector64<ushort> left, Vector64<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053A6 RID: 21414 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> CompareLessThanOrEqual(Vector64<uint> left, Vector64<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053A7 RID: 21415 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> CompareLessThanOrEqual(Vector128<byte> left, Vector128<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053A8 RID: 21416 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> CompareLessThanOrEqual(Vector128<short> left, Vector128<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053A9 RID: 21417 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> CompareLessThanOrEqual(Vector128<int> left, Vector128<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053AA RID: 21418 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> CompareLessThanOrEqual(Vector128<sbyte> left, Vector128<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053AB RID: 21419 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> CompareLessThanOrEqual(Vector128<float> left, Vector128<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053AC RID: 21420 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> CompareLessThanOrEqual(Vector128<ushort> left, Vector128<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053AD RID: 21421 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> CompareLessThanOrEqual(Vector128<uint> left, Vector128<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053AE RID: 21422 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<byte> CompareTest(Vector64<byte> left, Vector64<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053AF RID: 21423 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> CompareTest(Vector64<short> left, Vector64<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053B0 RID: 21424 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> CompareTest(Vector64<int> left, Vector64<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053B1 RID: 21425 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<sbyte> CompareTest(Vector64<sbyte> left, Vector64<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053B2 RID: 21426 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<float> CompareTest(Vector64<float> left, Vector64<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053B3 RID: 21427 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ushort> CompareTest(Vector64<ushort> left, Vector64<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053B4 RID: 21428 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> CompareTest(Vector64<uint> left, Vector64<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053B5 RID: 21429 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> CompareTest(Vector128<byte> left, Vector128<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053B6 RID: 21430 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> CompareTest(Vector128<short> left, Vector128<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053B7 RID: 21431 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> CompareTest(Vector128<int> left, Vector128<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053B8 RID: 21432 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> CompareTest(Vector128<sbyte> left, Vector128<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053B9 RID: 21433 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> CompareTest(Vector128<float> left, Vector128<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053BA RID: 21434 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> CompareTest(Vector128<ushort> left, Vector128<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053BB RID: 21435 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> CompareTest(Vector128<uint> left, Vector128<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053BC RID: 21436 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> ConvertToInt32RoundAwayFromZero(Vector64<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053BD RID: 21437 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> ConvertToInt32RoundAwayFromZero(Vector128<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053BE RID: 21438 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> ConvertToInt32RoundAwayFromZeroScalar(Vector64<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053BF RID: 21439 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> ConvertToInt32RoundToEven(Vector64<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053C0 RID: 21440 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> ConvertToInt32RoundToEven(Vector128<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053C1 RID: 21441 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> ConvertToInt32RoundToEvenScalar(Vector64<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053C2 RID: 21442 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> ConvertToInt32RoundToNegativeInfinity(Vector64<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053C3 RID: 21443 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> ConvertToInt32RoundToNegativeInfinity(Vector128<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053C4 RID: 21444 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> ConvertToInt32RoundToNegativeInfinityScalar(Vector64<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053C5 RID: 21445 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> ConvertToInt32RoundToPositiveInfinity(Vector64<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053C6 RID: 21446 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> ConvertToInt32RoundToPositiveInfinity(Vector128<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053C7 RID: 21447 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> ConvertToInt32RoundToPositiveInfinityScalar(Vector64<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053C8 RID: 21448 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> ConvertToInt32RoundToZero(Vector64<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053C9 RID: 21449 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> ConvertToInt32RoundToZero(Vector128<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053CA RID: 21450 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> ConvertToInt32RoundToZeroScalar(Vector64<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053CB RID: 21451 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<float> ConvertToSingle(Vector64<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053CC RID: 21452 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<float> ConvertToSingle(Vector64<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053CD RID: 21453 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> ConvertToSingle(Vector128<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053CE RID: 21454 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> ConvertToSingle(Vector128<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053CF RID: 21455 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<float> ConvertToSingleScalar(Vector64<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053D0 RID: 21456 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<float> ConvertToSingleScalar(Vector64<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053D1 RID: 21457 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> ConvertToUInt32RoundAwayFromZero(Vector64<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053D2 RID: 21458 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> ConvertToUInt32RoundAwayFromZero(Vector128<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053D3 RID: 21459 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> ConvertToUInt32RoundAwayFromZeroScalar(Vector64<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053D4 RID: 21460 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> ConvertToUInt32RoundToEven(Vector64<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053D5 RID: 21461 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> ConvertToUInt32RoundToEven(Vector128<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053D6 RID: 21462 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> ConvertToUInt32RoundToEvenScalar(Vector64<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053D7 RID: 21463 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> ConvertToUInt32RoundToNegativeInfinity(Vector64<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053D8 RID: 21464 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> ConvertToUInt32RoundToNegativeInfinity(Vector128<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053D9 RID: 21465 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> ConvertToUInt32RoundToNegativeInfinityScalar(Vector64<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053DA RID: 21466 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> ConvertToUInt32RoundToPositiveInfinity(Vector64<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053DB RID: 21467 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> ConvertToUInt32RoundToPositiveInfinity(Vector128<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053DC RID: 21468 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> ConvertToUInt32RoundToPositiveInfinityScalar(Vector64<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053DD RID: 21469 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> ConvertToUInt32RoundToZero(Vector64<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053DE RID: 21470 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> ConvertToUInt32RoundToZero(Vector128<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053DF RID: 21471 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> ConvertToUInt32RoundToZeroScalar(Vector64<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053E0 RID: 21472 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<double> DivideScalar(Vector64<double> left, Vector64<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053E1 RID: 21473 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<float> DivideScalar(Vector64<float> left, Vector64<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053E2 RID: 21474 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<byte> DuplicateSelectedScalarToVector64(Vector64<byte> value, [ConstantExpected(Max = 7)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053E3 RID: 21475 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> DuplicateSelectedScalarToVector64(Vector64<short> value, [ConstantExpected(Max = 3)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053E4 RID: 21476 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> DuplicateSelectedScalarToVector64(Vector64<int> value, [ConstantExpected(Max = 1)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053E5 RID: 21477 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<float> DuplicateSelectedScalarToVector64(Vector64<float> value, [ConstantExpected(Max = 1)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053E6 RID: 21478 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<sbyte> DuplicateSelectedScalarToVector64(Vector64<sbyte> value, [ConstantExpected(Max = 7)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053E7 RID: 21479 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ushort> DuplicateSelectedScalarToVector64(Vector64<ushort> value, [ConstantExpected(Max = 3)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053E8 RID: 21480 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> DuplicateSelectedScalarToVector64(Vector64<uint> value, [ConstantExpected(Max = 1)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053E9 RID: 21481 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<byte> DuplicateSelectedScalarToVector64(Vector128<byte> value, [ConstantExpected(Max = 15)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053EA RID: 21482 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> DuplicateSelectedScalarToVector64(Vector128<short> value, [ConstantExpected(Max = 7)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053EB RID: 21483 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> DuplicateSelectedScalarToVector64(Vector128<int> value, [ConstantExpected(Max = 3)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053EC RID: 21484 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<float> DuplicateSelectedScalarToVector64(Vector128<float> value, [ConstantExpected(Max = 3)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053ED RID: 21485 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<sbyte> DuplicateSelectedScalarToVector64(Vector128<sbyte> value, [ConstantExpected(Max = 15)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053EE RID: 21486 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ushort> DuplicateSelectedScalarToVector64(Vector128<ushort> value, [ConstantExpected(Max = 7)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053EF RID: 21487 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> DuplicateSelectedScalarToVector64(Vector128<uint> value, [ConstantExpected(Max = 3)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053F0 RID: 21488 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> DuplicateSelectedScalarToVector128(Vector64<byte> value, [ConstantExpected(Max = 7)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053F1 RID: 21489 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> DuplicateSelectedScalarToVector128(Vector64<short> value, [ConstantExpected(Max = 3)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053F2 RID: 21490 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> DuplicateSelectedScalarToVector128(Vector64<int> value, [ConstantExpected(Max = 1)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053F3 RID: 21491 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> DuplicateSelectedScalarToVector128(Vector64<float> value, [ConstantExpected(Max = 1)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053F4 RID: 21492 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> DuplicateSelectedScalarToVector128(Vector64<sbyte> value, [ConstantExpected(Max = 7)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053F5 RID: 21493 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> DuplicateSelectedScalarToVector128(Vector64<ushort> value, [ConstantExpected(Max = 3)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053F6 RID: 21494 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> DuplicateSelectedScalarToVector128(Vector64<uint> value, [ConstantExpected(Max = 1)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053F7 RID: 21495 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> DuplicateSelectedScalarToVector128(Vector128<byte> value, [ConstantExpected(Max = 15)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053F8 RID: 21496 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> DuplicateSelectedScalarToVector128(Vector128<short> value, [ConstantExpected(Max = 7)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053F9 RID: 21497 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> DuplicateSelectedScalarToVector128(Vector128<int> value, [ConstantExpected(Max = 3)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053FA RID: 21498 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> DuplicateSelectedScalarToVector128(Vector128<float> value, [ConstantExpected(Max = 3)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053FB RID: 21499 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> DuplicateSelectedScalarToVector128(Vector128<sbyte> value, [ConstantExpected(Max = 15)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053FC RID: 21500 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> DuplicateSelectedScalarToVector128(Vector128<ushort> value, [ConstantExpected(Max = 7)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053FD RID: 21501 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> DuplicateSelectedScalarToVector128(Vector128<uint> value, [ConstantExpected(Max = 3)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053FE RID: 21502 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<byte> DuplicateToVector64(byte value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060053FF RID: 21503 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> DuplicateToVector64(short value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005400 RID: 21504 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> DuplicateToVector64(int value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005401 RID: 21505 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<sbyte> DuplicateToVector64(sbyte value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005402 RID: 21506 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<float> DuplicateToVector64(float value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005403 RID: 21507 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ushort> DuplicateToVector64(ushort value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005404 RID: 21508 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> DuplicateToVector64(uint value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005405 RID: 21509 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> DuplicateToVector128(byte value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005406 RID: 21510 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> DuplicateToVector128(short value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005407 RID: 21511 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> DuplicateToVector128(int value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005408 RID: 21512 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> DuplicateToVector128(sbyte value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005409 RID: 21513 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> DuplicateToVector128(float value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600540A RID: 21514 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> DuplicateToVector128(ushort value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600540B RID: 21515 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> DuplicateToVector128(uint value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600540C RID: 21516 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static byte Extract(Vector64<byte> vector, [ConstantExpected(Max = 7)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600540D RID: 21517 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static short Extract(Vector64<short> vector, [ConstantExpected(Max = 3)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600540E RID: 21518 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static int Extract(Vector64<int> vector, [ConstantExpected(Max = 1)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600540F RID: 21519 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static sbyte Extract(Vector64<sbyte> vector, [ConstantExpected(Max = 7)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005410 RID: 21520 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static float Extract(Vector64<float> vector, [ConstantExpected(Max = 1)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005411 RID: 21521 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static ushort Extract(Vector64<ushort> vector, [ConstantExpected(Max = 3)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005412 RID: 21522 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static uint Extract(Vector64<uint> vector, [ConstantExpected(Max = 1)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005413 RID: 21523 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static byte Extract(Vector128<byte> vector, [ConstantExpected(Max = 15)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005414 RID: 21524 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static double Extract(Vector128<double> vector, [ConstantExpected(Max = 1)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005415 RID: 21525 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static short Extract(Vector128<short> vector, [ConstantExpected(Max = 7)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005416 RID: 21526 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static int Extract(Vector128<int> vector, [ConstantExpected(Max = 3)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005417 RID: 21527 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static long Extract(Vector128<long> vector, [ConstantExpected(Max = 1)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005418 RID: 21528 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static sbyte Extract(Vector128<sbyte> vector, [ConstantExpected(Max = 15)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005419 RID: 21529 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static float Extract(Vector128<float> vector, [ConstantExpected(Max = 3)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600541A RID: 21530 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static ushort Extract(Vector128<ushort> vector, [ConstantExpected(Max = 7)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600541B RID: 21531 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static uint Extract(Vector128<uint> vector, [ConstantExpected(Max = 3)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600541C RID: 21532 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static ulong Extract(Vector128<ulong> vector, [ConstantExpected(Max = 1)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600541D RID: 21533 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<byte> ExtractNarrowingLower(Vector128<ushort> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600541E RID: 21534 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> ExtractNarrowingLower(Vector128<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600541F RID: 21535 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> ExtractNarrowingLower(Vector128<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005420 RID: 21536 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<sbyte> ExtractNarrowingLower(Vector128<short> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005421 RID: 21537 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ushort> ExtractNarrowingLower(Vector128<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005422 RID: 21538 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> ExtractNarrowingLower(Vector128<ulong> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005423 RID: 21539 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<byte> ExtractNarrowingSaturateLower(Vector128<ushort> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005424 RID: 21540 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> ExtractNarrowingSaturateLower(Vector128<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005425 RID: 21541 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> ExtractNarrowingSaturateLower(Vector128<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005426 RID: 21542 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<sbyte> ExtractNarrowingSaturateLower(Vector128<short> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005427 RID: 21543 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ushort> ExtractNarrowingSaturateLower(Vector128<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005428 RID: 21544 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> ExtractNarrowingSaturateLower(Vector128<ulong> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005429 RID: 21545 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<byte> ExtractNarrowingSaturateUnsignedLower(Vector128<short> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600542A RID: 21546 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ushort> ExtractNarrowingSaturateUnsignedLower(Vector128<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600542B RID: 21547 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> ExtractNarrowingSaturateUnsignedLower(Vector128<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600542C RID: 21548 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> ExtractNarrowingSaturateUnsignedUpper(Vector64<byte> lower, Vector128<short> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600542D RID: 21549 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> ExtractNarrowingSaturateUnsignedUpper(Vector64<ushort> lower, Vector128<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600542E RID: 21550 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> ExtractNarrowingSaturateUnsignedUpper(Vector64<uint> lower, Vector128<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600542F RID: 21551 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> ExtractNarrowingSaturateUpper(Vector64<byte> lower, Vector128<ushort> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005430 RID: 21552 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> ExtractNarrowingSaturateUpper(Vector64<short> lower, Vector128<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005431 RID: 21553 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> ExtractNarrowingSaturateUpper(Vector64<int> lower, Vector128<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005432 RID: 21554 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> ExtractNarrowingSaturateUpper(Vector64<sbyte> lower, Vector128<short> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005433 RID: 21555 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> ExtractNarrowingSaturateUpper(Vector64<ushort> lower, Vector128<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005434 RID: 21556 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> ExtractNarrowingSaturateUpper(Vector64<uint> lower, Vector128<ulong> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005435 RID: 21557 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> ExtractNarrowingUpper(Vector64<byte> lower, Vector128<ushort> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005436 RID: 21558 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> ExtractNarrowingUpper(Vector64<short> lower, Vector128<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005437 RID: 21559 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> ExtractNarrowingUpper(Vector64<int> lower, Vector128<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005438 RID: 21560 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> ExtractNarrowingUpper(Vector64<sbyte> lower, Vector128<short> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005439 RID: 21561 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> ExtractNarrowingUpper(Vector64<ushort> lower, Vector128<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600543A RID: 21562 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> ExtractNarrowingUpper(Vector64<uint> lower, Vector128<ulong> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600543B RID: 21563 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<byte> ExtractVector64(Vector64<byte> upper, Vector64<byte> lower, [ConstantExpected(Max = 7)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600543C RID: 21564 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> ExtractVector64(Vector64<short> upper, Vector64<short> lower, [ConstantExpected(Max = 3)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600543D RID: 21565 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> ExtractVector64(Vector64<int> upper, Vector64<int> lower, [ConstantExpected(Max = 1)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600543E RID: 21566 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<sbyte> ExtractVector64(Vector64<sbyte> upper, Vector64<sbyte> lower, [ConstantExpected(Max = 7)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600543F RID: 21567 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<float> ExtractVector64(Vector64<float> upper, Vector64<float> lower, [ConstantExpected(Max = 1)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005440 RID: 21568 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ushort> ExtractVector64(Vector64<ushort> upper, Vector64<ushort> lower, [ConstantExpected(Max = 3)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005441 RID: 21569 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> ExtractVector64(Vector64<uint> upper, Vector64<uint> lower, [ConstantExpected(Max = 1)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005442 RID: 21570 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> ExtractVector128(Vector128<byte> upper, Vector128<byte> lower, [ConstantExpected(Max = 15)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005443 RID: 21571 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> ExtractVector128(Vector128<double> upper, Vector128<double> lower, [ConstantExpected(Max = 1)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005444 RID: 21572 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> ExtractVector128(Vector128<short> upper, Vector128<short> lower, [ConstantExpected(Max = 7)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005445 RID: 21573 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> ExtractVector128(Vector128<int> upper, Vector128<int> lower, [ConstantExpected(Max = 3)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005446 RID: 21574 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> ExtractVector128(Vector128<long> upper, Vector128<long> lower, [ConstantExpected(Max = 1)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005447 RID: 21575 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> ExtractVector128(Vector128<sbyte> upper, Vector128<sbyte> lower, [ConstantExpected(Max = 15)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005448 RID: 21576 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> ExtractVector128(Vector128<float> upper, Vector128<float> lower, [ConstantExpected(Max = 3)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005449 RID: 21577 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> ExtractVector128(Vector128<ushort> upper, Vector128<ushort> lower, [ConstantExpected(Max = 7)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600544A RID: 21578 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> ExtractVector128(Vector128<uint> upper, Vector128<uint> lower, [ConstantExpected(Max = 3)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600544B RID: 21579 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> ExtractVector128(Vector128<ulong> upper, Vector128<ulong> lower, [ConstantExpected(Max = 1)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600544C RID: 21580 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<float> Floor(Vector64<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600544D RID: 21581 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> Floor(Vector128<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600544E RID: 21582 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<double> FloorScalar(Vector64<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600544F RID: 21583 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<float> FloorScalar(Vector64<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005450 RID: 21584 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<byte> FusedAddHalving(Vector64<byte> left, Vector64<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005451 RID: 21585 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> FusedAddHalving(Vector64<short> left, Vector64<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005452 RID: 21586 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> FusedAddHalving(Vector64<int> left, Vector64<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005453 RID: 21587 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<sbyte> FusedAddHalving(Vector64<sbyte> left, Vector64<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005454 RID: 21588 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ushort> FusedAddHalving(Vector64<ushort> left, Vector64<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005455 RID: 21589 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> FusedAddHalving(Vector64<uint> left, Vector64<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005456 RID: 21590 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> FusedAddHalving(Vector128<byte> left, Vector128<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005457 RID: 21591 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> FusedAddHalving(Vector128<short> left, Vector128<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005458 RID: 21592 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> FusedAddHalving(Vector128<int> left, Vector128<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005459 RID: 21593 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> FusedAddHalving(Vector128<sbyte> left, Vector128<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600545A RID: 21594 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> FusedAddHalving(Vector128<ushort> left, Vector128<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600545B RID: 21595 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> FusedAddHalving(Vector128<uint> left, Vector128<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600545C RID: 21596 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<byte> FusedAddRoundedHalving(Vector64<byte> left, Vector64<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600545D RID: 21597 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> FusedAddRoundedHalving(Vector64<short> left, Vector64<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600545E RID: 21598 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> FusedAddRoundedHalving(Vector64<int> left, Vector64<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600545F RID: 21599 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<sbyte> FusedAddRoundedHalving(Vector64<sbyte> left, Vector64<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005460 RID: 21600 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ushort> FusedAddRoundedHalving(Vector64<ushort> left, Vector64<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005461 RID: 21601 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> FusedAddRoundedHalving(Vector64<uint> left, Vector64<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005462 RID: 21602 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> FusedAddRoundedHalving(Vector128<byte> left, Vector128<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005463 RID: 21603 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> FusedAddRoundedHalving(Vector128<short> left, Vector128<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005464 RID: 21604 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> FusedAddRoundedHalving(Vector128<int> left, Vector128<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005465 RID: 21605 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> FusedAddRoundedHalving(Vector128<sbyte> left, Vector128<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005466 RID: 21606 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> FusedAddRoundedHalving(Vector128<ushort> left, Vector128<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005467 RID: 21607 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> FusedAddRoundedHalving(Vector128<uint> left, Vector128<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005468 RID: 21608 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<float> FusedMultiplyAdd(Vector64<float> addend, Vector64<float> left, Vector64<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005469 RID: 21609 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> FusedMultiplyAdd(Vector128<float> addend, Vector128<float> left, Vector128<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600546A RID: 21610 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<double> FusedMultiplyAddNegatedScalar(Vector64<double> addend, Vector64<double> left, Vector64<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600546B RID: 21611 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<float> FusedMultiplyAddNegatedScalar(Vector64<float> addend, Vector64<float> left, Vector64<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600546C RID: 21612 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<double> FusedMultiplyAddScalar(Vector64<double> addend, Vector64<double> left, Vector64<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600546D RID: 21613 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<float> FusedMultiplyAddScalar(Vector64<float> addend, Vector64<float> left, Vector64<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600546E RID: 21614 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<float> FusedMultiplySubtract(Vector64<float> minuend, Vector64<float> left, Vector64<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600546F RID: 21615 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> FusedMultiplySubtract(Vector128<float> minuend, Vector128<float> left, Vector128<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005470 RID: 21616 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<double> FusedMultiplySubtractNegatedScalar(Vector64<double> minuend, Vector64<double> left, Vector64<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005471 RID: 21617 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<float> FusedMultiplySubtractNegatedScalar(Vector64<float> minuend, Vector64<float> left, Vector64<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005472 RID: 21618 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<double> FusedMultiplySubtractScalar(Vector64<double> minuend, Vector64<double> left, Vector64<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005473 RID: 21619 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<float> FusedMultiplySubtractScalar(Vector64<float> minuend, Vector64<float> left, Vector64<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005474 RID: 21620 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<byte> FusedSubtractHalving(Vector64<byte> left, Vector64<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005475 RID: 21621 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> FusedSubtractHalving(Vector64<short> left, Vector64<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005476 RID: 21622 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> FusedSubtractHalving(Vector64<int> left, Vector64<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005477 RID: 21623 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<sbyte> FusedSubtractHalving(Vector64<sbyte> left, Vector64<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005478 RID: 21624 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ushort> FusedSubtractHalving(Vector64<ushort> left, Vector64<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005479 RID: 21625 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> FusedSubtractHalving(Vector64<uint> left, Vector64<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600547A RID: 21626 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> FusedSubtractHalving(Vector128<byte> left, Vector128<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600547B RID: 21627 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> FusedSubtractHalving(Vector128<short> left, Vector128<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600547C RID: 21628 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> FusedSubtractHalving(Vector128<int> left, Vector128<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600547D RID: 21629 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> FusedSubtractHalving(Vector128<sbyte> left, Vector128<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600547E RID: 21630 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> FusedSubtractHalving(Vector128<ushort> left, Vector128<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600547F RID: 21631 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> FusedSubtractHalving(Vector128<uint> left, Vector128<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005480 RID: 21632 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<byte> Insert(Vector64<byte> vector, [ConstantExpected(Max = 7)] byte index, byte data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005481 RID: 21633 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> Insert(Vector64<short> vector, [ConstantExpected(Max = 3)] byte index, short data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005482 RID: 21634 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> Insert(Vector64<int> vector, [ConstantExpected(Max = 1)] byte index, int data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005483 RID: 21635 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<sbyte> Insert(Vector64<sbyte> vector, [ConstantExpected(Max = 7)] byte index, sbyte data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005484 RID: 21636 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<float> Insert(Vector64<float> vector, [ConstantExpected(Max = 1)] byte index, float data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005485 RID: 21637 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ushort> Insert(Vector64<ushort> vector, [ConstantExpected(Max = 3)] byte index, ushort data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005486 RID: 21638 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> Insert(Vector64<uint> vector, [ConstantExpected(Max = 1)] byte index, uint data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005487 RID: 21639 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> Insert(Vector128<byte> vector, [ConstantExpected(Max = 15)] byte index, byte data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005488 RID: 21640 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> Insert(Vector128<double> vector, [ConstantExpected(Max = 1)] byte index, double data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005489 RID: 21641 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> Insert(Vector128<short> vector, [ConstantExpected(Max = 7)] byte index, short data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600548A RID: 21642 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> Insert(Vector128<int> vector, [ConstantExpected(Max = 3)] byte index, int data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600548B RID: 21643 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> Insert(Vector128<long> vector, [ConstantExpected(Max = 1)] byte index, long data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600548C RID: 21644 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> Insert(Vector128<sbyte> vector, [ConstantExpected(Max = 15)] byte index, sbyte data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600548D RID: 21645 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> Insert(Vector128<float> vector, [ConstantExpected(Max = 3)] byte index, float data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600548E RID: 21646 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> Insert(Vector128<ushort> vector, [ConstantExpected(Max = 7)] byte index, ushort data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600548F RID: 21647 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> Insert(Vector128<uint> vector, [ConstantExpected(Max = 3)] byte index, uint data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005490 RID: 21648 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> Insert(Vector128<ulong> vector, [ConstantExpected(Max = 1)] byte index, ulong data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005491 RID: 21649 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> InsertScalar(Vector128<double> result, [ConstantExpected(Max = 1)] byte resultIndex, Vector64<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005492 RID: 21650 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> InsertScalar(Vector128<long> result, [ConstantExpected(Max = 1)] byte resultIndex, Vector64<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005493 RID: 21651 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> InsertScalar(Vector128<ulong> result, [ConstantExpected(Max = 1)] byte resultIndex, Vector64<ulong> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005494 RID: 21652 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> LeadingSignCount(Vector64<short> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005495 RID: 21653 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> LeadingSignCount(Vector64<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005496 RID: 21654 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<sbyte> LeadingSignCount(Vector64<sbyte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005497 RID: 21655 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> LeadingSignCount(Vector128<short> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005498 RID: 21656 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> LeadingSignCount(Vector128<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005499 RID: 21657 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> LeadingSignCount(Vector128<sbyte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600549A RID: 21658 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<byte> LeadingZeroCount(Vector64<byte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600549B RID: 21659 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> LeadingZeroCount(Vector64<short> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600549C RID: 21660 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> LeadingZeroCount(Vector64<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600549D RID: 21661 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<sbyte> LeadingZeroCount(Vector64<sbyte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600549E RID: 21662 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ushort> LeadingZeroCount(Vector64<ushort> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600549F RID: 21663 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> LeadingZeroCount(Vector64<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054A0 RID: 21664 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> LeadingZeroCount(Vector128<byte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054A1 RID: 21665 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> LeadingZeroCount(Vector128<short> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054A2 RID: 21666 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> LeadingZeroCount(Vector128<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054A3 RID: 21667 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> LeadingZeroCount(Vector128<sbyte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054A4 RID: 21668 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> LeadingZeroCount(Vector128<ushort> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054A5 RID: 21669 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> LeadingZeroCount(Vector128<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054A6 RID: 21670 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector64<byte> LoadAndInsertScalar(Vector64<byte> value, [ConstantExpected(Max = 7)] byte index, byte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054A7 RID: 21671 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector64<short> LoadAndInsertScalar(Vector64<short> value, [ConstantExpected(Max = 3)] byte index, short* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054A8 RID: 21672 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector64<int> LoadAndInsertScalar(Vector64<int> value, [ConstantExpected(Max = 1)] byte index, int* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054A9 RID: 21673 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector64<sbyte> LoadAndInsertScalar(Vector64<sbyte> value, [ConstantExpected(Max = 7)] byte index, sbyte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054AA RID: 21674 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector64<float> LoadAndInsertScalar(Vector64<float> value, [ConstantExpected(Max = 1)] byte index, float* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054AB RID: 21675 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector64<ushort> LoadAndInsertScalar(Vector64<ushort> value, [ConstantExpected(Max = 3)] byte index, ushort* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054AC RID: 21676 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector64<uint> LoadAndInsertScalar(Vector64<uint> value, [ConstantExpected(Max = 1)] byte index, uint* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054AD RID: 21677 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<byte> LoadAndInsertScalar(Vector128<byte> value, [ConstantExpected(Max = 15)] byte index, byte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054AE RID: 21678 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<double> LoadAndInsertScalar(Vector128<double> value, [ConstantExpected(Max = 1)] byte index, double* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054AF RID: 21679 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<short> LoadAndInsertScalar(Vector128<short> value, [ConstantExpected(Max = 7)] byte index, short* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054B0 RID: 21680 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<int> LoadAndInsertScalar(Vector128<int> value, [ConstantExpected(Max = 3)] byte index, int* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054B1 RID: 21681 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<long> LoadAndInsertScalar(Vector128<long> value, [ConstantExpected(Max = 1)] byte index, long* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054B2 RID: 21682 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<sbyte> LoadAndInsertScalar(Vector128<sbyte> value, [ConstantExpected(Max = 15)] byte index, sbyte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054B3 RID: 21683 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<float> LoadAndInsertScalar(Vector128<float> value, [ConstantExpected(Max = 3)] byte index, float* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054B4 RID: 21684 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<ushort> LoadAndInsertScalar(Vector128<ushort> value, [ConstantExpected(Max = 7)] byte index, ushort* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054B5 RID: 21685 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<uint> LoadAndInsertScalar(Vector128<uint> value, [ConstantExpected(Max = 3)] byte index, uint* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054B6 RID: 21686 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<ulong> LoadAndInsertScalar(Vector128<ulong> value, [ConstantExpected(Max = 1)] byte index, ulong* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054B7 RID: 21687 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[return: TupleElementNames(new string[]
		{
			"Value1",
			"Value2"
		})]
		public unsafe static ValueTuple<Vector64<byte>, Vector64<byte>> LoadAndInsertScalar(ValueTuple<Vector64<byte>, Vector64<byte>> values, [ConstantExpected(Max = 7)] byte index, byte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054B8 RID: 21688 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[return: TupleElementNames(new string[]
		{
			"Value1",
			"Value2"
		})]
		public unsafe static ValueTuple<Vector64<sbyte>, Vector64<sbyte>> LoadAndInsertScalar(ValueTuple<Vector64<sbyte>, Vector64<sbyte>> values, [ConstantExpected(Max = 7)] byte index, sbyte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054B9 RID: 21689 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[return: TupleElementNames(new string[]
		{
			"Value1",
			"Value2"
		})]
		public unsafe static ValueTuple<Vector64<short>, Vector64<short>> LoadAndInsertScalar(ValueTuple<Vector64<short>, Vector64<short>> values, [ConstantExpected(Max = 3)] byte index, short* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054BA RID: 21690 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[return: TupleElementNames(new string[]
		{
			"Value1",
			"Value2"
		})]
		public unsafe static ValueTuple<Vector64<ushort>, Vector64<ushort>> LoadAndInsertScalar(ValueTuple<Vector64<ushort>, Vector64<ushort>> values, [ConstantExpected(Max = 3)] byte index, ushort* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054BB RID: 21691 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[return: TupleElementNames(new string[]
		{
			"Value1",
			"Value2"
		})]
		public unsafe static ValueTuple<Vector64<int>, Vector64<int>> LoadAndInsertScalar(ValueTuple<Vector64<int>, Vector64<int>> values, [ConstantExpected(Max = 1)] byte index, int* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054BC RID: 21692 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[return: TupleElementNames(new string[]
		{
			"Value1",
			"Value2"
		})]
		public unsafe static ValueTuple<Vector64<uint>, Vector64<uint>> LoadAndInsertScalar(ValueTuple<Vector64<uint>, Vector64<uint>> values, [ConstantExpected(Max = 1)] byte index, uint* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054BD RID: 21693 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[return: TupleElementNames(new string[]
		{
			"Value1",
			"Value2"
		})]
		public unsafe static ValueTuple<Vector64<float>, Vector64<float>> LoadAndInsertScalar(ValueTuple<Vector64<float>, Vector64<float>> values, [ConstantExpected(Max = 1)] byte index, float* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054BE RID: 21694 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[return: TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3"
		})]
		public unsafe static ValueTuple<Vector64<byte>, Vector64<byte>, Vector64<byte>> LoadAndInsertScalar(ValueTuple<Vector64<byte>, Vector64<byte>, Vector64<byte>> values, [ConstantExpected(Max = 7)] byte index, byte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054BF RID: 21695 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[return: TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3"
		})]
		public unsafe static ValueTuple<Vector64<sbyte>, Vector64<sbyte>, Vector64<sbyte>> LoadAndInsertScalar(ValueTuple<Vector64<sbyte>, Vector64<sbyte>, Vector64<sbyte>> values, [ConstantExpected(Max = 7)] byte index, sbyte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054C0 RID: 21696 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[return: TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3"
		})]
		public unsafe static ValueTuple<Vector64<short>, Vector64<short>, Vector64<short>> LoadAndInsertScalar(ValueTuple<Vector64<short>, Vector64<short>, Vector64<short>> values, [ConstantExpected(Max = 3)] byte index, short* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054C1 RID: 21697 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[return: TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3"
		})]
		public unsafe static ValueTuple<Vector64<ushort>, Vector64<ushort>, Vector64<ushort>> LoadAndInsertScalar(ValueTuple<Vector64<ushort>, Vector64<ushort>, Vector64<ushort>> values, [ConstantExpected(Max = 3)] byte index, ushort* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054C2 RID: 21698 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[return: TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3"
		})]
		public unsafe static ValueTuple<Vector64<int>, Vector64<int>, Vector64<int>> LoadAndInsertScalar(ValueTuple<Vector64<int>, Vector64<int>, Vector64<int>> values, [ConstantExpected(Max = 1)] byte index, int* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054C3 RID: 21699 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[return: TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3"
		})]
		public unsafe static ValueTuple<Vector64<uint>, Vector64<uint>, Vector64<uint>> LoadAndInsertScalar(ValueTuple<Vector64<uint>, Vector64<uint>, Vector64<uint>> values, [ConstantExpected(Max = 1)] byte index, uint* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054C4 RID: 21700 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[return: TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3"
		})]
		public unsafe static ValueTuple<Vector64<float>, Vector64<float>, Vector64<float>> LoadAndInsertScalar(ValueTuple<Vector64<float>, Vector64<float>, Vector64<float>> values, [ConstantExpected(Max = 1)] byte index, float* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054C5 RID: 21701 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[return: TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3",
			"Value4"
		})]
		public unsafe static ValueTuple<Vector64<byte>, Vector64<byte>, Vector64<byte>, Vector64<byte>> LoadAndInsertScalar(ValueTuple<Vector64<byte>, Vector64<byte>, Vector64<byte>, Vector64<byte>> values, [ConstantExpected(Max = 7)] byte index, byte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054C6 RID: 21702 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[return: TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3",
			"Value4"
		})]
		public unsafe static ValueTuple<Vector64<sbyte>, Vector64<sbyte>, Vector64<sbyte>, Vector64<sbyte>> LoadAndInsertScalar(ValueTuple<Vector64<sbyte>, Vector64<sbyte>, Vector64<sbyte>, Vector64<sbyte>> values, [ConstantExpected(Max = 7)] byte index, sbyte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054C7 RID: 21703 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[return: TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3",
			"Value4"
		})]
		public unsafe static ValueTuple<Vector64<short>, Vector64<short>, Vector64<short>, Vector64<short>> LoadAndInsertScalar(ValueTuple<Vector64<short>, Vector64<short>, Vector64<short>, Vector64<short>> values, [ConstantExpected(Max = 3)] byte index, short* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054C8 RID: 21704 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[return: TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3",
			"Value4"
		})]
		public unsafe static ValueTuple<Vector64<ushort>, Vector64<ushort>, Vector64<ushort>, Vector64<ushort>> LoadAndInsertScalar(ValueTuple<Vector64<ushort>, Vector64<ushort>, Vector64<ushort>, Vector64<ushort>> values, [ConstantExpected(Max = 3)] byte index, ushort* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054C9 RID: 21705 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[return: TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3",
			"Value4"
		})]
		public unsafe static ValueTuple<Vector64<int>, Vector64<int>, Vector64<int>, Vector64<int>> LoadAndInsertScalar(ValueTuple<Vector64<int>, Vector64<int>, Vector64<int>, Vector64<int>> values, [ConstantExpected(Max = 1)] byte index, int* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054CA RID: 21706 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[return: TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3",
			"Value4"
		})]
		public unsafe static ValueTuple<Vector64<uint>, Vector64<uint>, Vector64<uint>, Vector64<uint>> LoadAndInsertScalar(ValueTuple<Vector64<uint>, Vector64<uint>, Vector64<uint>, Vector64<uint>> values, [ConstantExpected(Max = 1)] byte index, uint* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054CB RID: 21707 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[return: TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3",
			"Value4"
		})]
		public unsafe static ValueTuple<Vector64<float>, Vector64<float>, Vector64<float>, Vector64<float>> LoadAndInsertScalar(ValueTuple<Vector64<float>, Vector64<float>, Vector64<float>, Vector64<float>> values, [ConstantExpected(Max = 1)] byte index, float* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054CC RID: 21708 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector64<byte> LoadAndReplicateToVector64(byte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054CD RID: 21709 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector64<short> LoadAndReplicateToVector64(short* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054CE RID: 21710 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector64<int> LoadAndReplicateToVector64(int* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054CF RID: 21711 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector64<sbyte> LoadAndReplicateToVector64(sbyte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054D0 RID: 21712 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector64<float> LoadAndReplicateToVector64(float* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054D1 RID: 21713 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector64<ushort> LoadAndReplicateToVector64(ushort* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054D2 RID: 21714 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector64<uint> LoadAndReplicateToVector64(uint* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054D3 RID: 21715 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<byte> LoadAndReplicateToVector128(byte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054D4 RID: 21716 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<short> LoadAndReplicateToVector128(short* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054D5 RID: 21717 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<int> LoadAndReplicateToVector128(int* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054D6 RID: 21718 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<sbyte> LoadAndReplicateToVector128(sbyte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054D7 RID: 21719 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<float> LoadAndReplicateToVector128(float* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054D8 RID: 21720 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<ushort> LoadAndReplicateToVector128(ushort* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054D9 RID: 21721 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<uint> LoadAndReplicateToVector128(uint* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054DA RID: 21722 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[return: TupleElementNames(new string[]
		{
			"Value1",
			"Value2"
		})]
		public unsafe static ValueTuple<Vector64<byte>, Vector64<byte>> LoadAndReplicateToVector64x2(byte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054DB RID: 21723 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[return: TupleElementNames(new string[]
		{
			"Value1",
			"Value2"
		})]
		public unsafe static ValueTuple<Vector64<sbyte>, Vector64<sbyte>> LoadAndReplicateToVector64x2(sbyte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054DC RID: 21724 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[return: TupleElementNames(new string[]
		{
			"Value1",
			"Value2"
		})]
		public unsafe static ValueTuple<Vector64<short>, Vector64<short>> LoadAndReplicateToVector64x2(short* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054DD RID: 21725 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[return: TupleElementNames(new string[]
		{
			"Value1",
			"Value2"
		})]
		public unsafe static ValueTuple<Vector64<ushort>, Vector64<ushort>> LoadAndReplicateToVector64x2(ushort* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054DE RID: 21726 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[return: TupleElementNames(new string[]
		{
			"Value1",
			"Value2"
		})]
		public unsafe static ValueTuple<Vector64<int>, Vector64<int>> LoadAndReplicateToVector64x2(int* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054DF RID: 21727 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[return: TupleElementNames(new string[]
		{
			"Value1",
			"Value2"
		})]
		public unsafe static ValueTuple<Vector64<uint>, Vector64<uint>> LoadAndReplicateToVector64x2(uint* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054E0 RID: 21728 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[return: TupleElementNames(new string[]
		{
			"Value1",
			"Value2"
		})]
		public unsafe static ValueTuple<Vector64<float>, Vector64<float>> LoadAndReplicateToVector64x2(float* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054E1 RID: 21729 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[return: TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3"
		})]
		public unsafe static ValueTuple<Vector64<byte>, Vector64<byte>, Vector64<byte>> LoadAndReplicateToVector64x3(byte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054E2 RID: 21730 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[return: TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3"
		})]
		public unsafe static ValueTuple<Vector64<sbyte>, Vector64<sbyte>, Vector64<sbyte>> LoadAndReplicateToVector64x3(sbyte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054E3 RID: 21731 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[return: TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3"
		})]
		public unsafe static ValueTuple<Vector64<short>, Vector64<short>, Vector64<short>> LoadAndReplicateToVector64x3(short* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054E4 RID: 21732 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[return: TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3"
		})]
		public unsafe static ValueTuple<Vector64<ushort>, Vector64<ushort>, Vector64<ushort>> LoadAndReplicateToVector64x3(ushort* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054E5 RID: 21733 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[return: TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3"
		})]
		public unsafe static ValueTuple<Vector64<int>, Vector64<int>, Vector64<int>> LoadAndReplicateToVector64x3(int* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054E6 RID: 21734 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[return: TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3"
		})]
		public unsafe static ValueTuple<Vector64<uint>, Vector64<uint>, Vector64<uint>> LoadAndReplicateToVector64x3(uint* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054E7 RID: 21735 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[return: TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3"
		})]
		public unsafe static ValueTuple<Vector64<float>, Vector64<float>, Vector64<float>> LoadAndReplicateToVector64x3(float* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054E8 RID: 21736 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[return: TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3",
			"Value4"
		})]
		public unsafe static ValueTuple<Vector64<byte>, Vector64<byte>, Vector64<byte>, Vector64<byte>> LoadAndReplicateToVector64x4(byte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054E9 RID: 21737 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[return: TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3",
			"Value4"
		})]
		public unsafe static ValueTuple<Vector64<sbyte>, Vector64<sbyte>, Vector64<sbyte>, Vector64<sbyte>> LoadAndReplicateToVector64x4(sbyte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054EA RID: 21738 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[return: TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3",
			"Value4"
		})]
		public unsafe static ValueTuple<Vector64<short>, Vector64<short>, Vector64<short>, Vector64<short>> LoadAndReplicateToVector64x4(short* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054EB RID: 21739 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[return: TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3",
			"Value4"
		})]
		public unsafe static ValueTuple<Vector64<ushort>, Vector64<ushort>, Vector64<ushort>, Vector64<ushort>> LoadAndReplicateToVector64x4(ushort* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054EC RID: 21740 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[return: TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3",
			"Value4"
		})]
		public unsafe static ValueTuple<Vector64<int>, Vector64<int>, Vector64<int>, Vector64<int>> LoadAndReplicateToVector64x4(int* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054ED RID: 21741 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[return: TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3",
			"Value4"
		})]
		public unsafe static ValueTuple<Vector64<uint>, Vector64<uint>, Vector64<uint>, Vector64<uint>> LoadAndReplicateToVector64x4(uint* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054EE RID: 21742 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[return: TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3",
			"Value4"
		})]
		public unsafe static ValueTuple<Vector64<float>, Vector64<float>, Vector64<float>, Vector64<float>> LoadAndReplicateToVector64x4(float* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054EF RID: 21743 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector64<byte> LoadVector64(byte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054F0 RID: 21744 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector64<double> LoadVector64(double* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054F1 RID: 21745 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector64<short> LoadVector64(short* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054F2 RID: 21746 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector64<int> LoadVector64(int* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054F3 RID: 21747 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector64<long> LoadVector64(long* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054F4 RID: 21748 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector64<sbyte> LoadVector64(sbyte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054F5 RID: 21749 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector64<float> LoadVector64(float* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054F6 RID: 21750 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector64<ushort> LoadVector64(ushort* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054F7 RID: 21751 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector64<uint> LoadVector64(uint* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054F8 RID: 21752 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector64<ulong> LoadVector64(ulong* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054F9 RID: 21753 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<byte> LoadVector128(byte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054FA RID: 21754 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<double> LoadVector128(double* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054FB RID: 21755 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<short> LoadVector128(short* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054FC RID: 21756 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<int> LoadVector128(int* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054FD RID: 21757 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<long> LoadVector128(long* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054FE RID: 21758 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<sbyte> LoadVector128(sbyte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060054FF RID: 21759 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<float> LoadVector128(float* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005500 RID: 21760 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<ushort> LoadVector128(ushort* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005501 RID: 21761 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<uint> LoadVector128(uint* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005502 RID: 21762 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector128<ulong> LoadVector128(ulong* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005503 RID: 21763 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[return: TupleElementNames(new string[]
		{
			"Value1",
			"Value2"
		})]
		public unsafe static ValueTuple<Vector64<byte>, Vector64<byte>> Load2xVector64AndUnzip(byte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005504 RID: 21764 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[return: TupleElementNames(new string[]
		{
			"Value1",
			"Value2"
		})]
		public unsafe static ValueTuple<Vector64<sbyte>, Vector64<sbyte>> Load2xVector64AndUnzip(sbyte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005505 RID: 21765 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[return: TupleElementNames(new string[]
		{
			"Value1",
			"Value2"
		})]
		public unsafe static ValueTuple<Vector64<short>, Vector64<short>> Load2xVector64AndUnzip(short* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005506 RID: 21766 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[return: TupleElementNames(new string[]
		{
			"Value1",
			"Value2"
		})]
		public unsafe static ValueTuple<Vector64<ushort>, Vector64<ushort>> Load2xVector64AndUnzip(ushort* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005507 RID: 21767 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[return: TupleElementNames(new string[]
		{
			"Value1",
			"Value2"
		})]
		public unsafe static ValueTuple<Vector64<int>, Vector64<int>> Load2xVector64AndUnzip(int* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005508 RID: 21768 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[return: TupleElementNames(new string[]
		{
			"Value1",
			"Value2"
		})]
		public unsafe static ValueTuple<Vector64<uint>, Vector64<uint>> Load2xVector64AndUnzip(uint* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005509 RID: 21769 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[return: TupleElementNames(new string[]
		{
			"Value1",
			"Value2"
		})]
		public unsafe static ValueTuple<Vector64<float>, Vector64<float>> Load2xVector64AndUnzip(float* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600550A RID: 21770 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[return: TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3"
		})]
		public unsafe static ValueTuple<Vector64<byte>, Vector64<byte>, Vector64<byte>> Load3xVector64AndUnzip(byte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600550B RID: 21771 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[return: TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3"
		})]
		public unsafe static ValueTuple<Vector64<sbyte>, Vector64<sbyte>, Vector64<sbyte>> Load3xVector64AndUnzip(sbyte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600550C RID: 21772 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[return: TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3"
		})]
		public unsafe static ValueTuple<Vector64<short>, Vector64<short>, Vector64<short>> Load3xVector64AndUnzip(short* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600550D RID: 21773 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[return: TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3"
		})]
		public unsafe static ValueTuple<Vector64<ushort>, Vector64<ushort>, Vector64<ushort>> Load3xVector64AndUnzip(ushort* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600550E RID: 21774 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[return: TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3"
		})]
		public unsafe static ValueTuple<Vector64<int>, Vector64<int>, Vector64<int>> Load3xVector64AndUnzip(int* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600550F RID: 21775 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[return: TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3"
		})]
		public unsafe static ValueTuple<Vector64<uint>, Vector64<uint>, Vector64<uint>> Load3xVector64AndUnzip(uint* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005510 RID: 21776 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[return: TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3"
		})]
		public unsafe static ValueTuple<Vector64<float>, Vector64<float>, Vector64<float>> Load3xVector64AndUnzip(float* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005511 RID: 21777 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[return: TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3",
			"Value4"
		})]
		public unsafe static ValueTuple<Vector64<byte>, Vector64<byte>, Vector64<byte>, Vector64<byte>> Load4xVector64AndUnzip(byte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005512 RID: 21778 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[return: TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3",
			"Value4"
		})]
		public unsafe static ValueTuple<Vector64<sbyte>, Vector64<sbyte>, Vector64<sbyte>, Vector64<sbyte>> Load4xVector64AndUnzip(sbyte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005513 RID: 21779 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[return: TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3",
			"Value4"
		})]
		public unsafe static ValueTuple<Vector64<short>, Vector64<short>, Vector64<short>, Vector64<short>> Load4xVector64AndUnzip(short* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005514 RID: 21780 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[return: TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3",
			"Value4"
		})]
		public unsafe static ValueTuple<Vector64<ushort>, Vector64<ushort>, Vector64<ushort>, Vector64<ushort>> Load4xVector64AndUnzip(ushort* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005515 RID: 21781 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[return: TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3",
			"Value4"
		})]
		public unsafe static ValueTuple<Vector64<int>, Vector64<int>, Vector64<int>, Vector64<int>> Load4xVector64AndUnzip(int* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005516 RID: 21782 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[return: TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3",
			"Value4"
		})]
		public unsafe static ValueTuple<Vector64<uint>, Vector64<uint>, Vector64<uint>, Vector64<uint>> Load4xVector64AndUnzip(uint* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005517 RID: 21783 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[return: TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3",
			"Value4"
		})]
		public unsafe static ValueTuple<Vector64<float>, Vector64<float>, Vector64<float>, Vector64<float>> Load4xVector64AndUnzip(float* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005518 RID: 21784 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[return: TupleElementNames(new string[]
		{
			"Value1",
			"Value2"
		})]
		public unsafe static ValueTuple<Vector64<byte>, Vector64<byte>> Load2xVector64(byte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005519 RID: 21785 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[return: TupleElementNames(new string[]
		{
			"Value1",
			"Value2"
		})]
		public unsafe static ValueTuple<Vector64<sbyte>, Vector64<sbyte>> Load2xVector64(sbyte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600551A RID: 21786 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[return: TupleElementNames(new string[]
		{
			"Value1",
			"Value2"
		})]
		public unsafe static ValueTuple<Vector64<short>, Vector64<short>> Load2xVector64(short* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600551B RID: 21787 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[return: TupleElementNames(new string[]
		{
			"Value1",
			"Value2"
		})]
		public unsafe static ValueTuple<Vector64<ushort>, Vector64<ushort>> Load2xVector64(ushort* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600551C RID: 21788 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[return: TupleElementNames(new string[]
		{
			"Value1",
			"Value2"
		})]
		public unsafe static ValueTuple<Vector64<int>, Vector64<int>> Load2xVector64(int* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600551D RID: 21789 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[return: TupleElementNames(new string[]
		{
			"Value1",
			"Value2"
		})]
		public unsafe static ValueTuple<Vector64<uint>, Vector64<uint>> Load2xVector64(uint* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600551E RID: 21790 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[return: TupleElementNames(new string[]
		{
			"Value1",
			"Value2"
		})]
		public unsafe static ValueTuple<Vector64<float>, Vector64<float>> Load2xVector64(float* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600551F RID: 21791 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[return: TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3"
		})]
		public unsafe static ValueTuple<Vector64<byte>, Vector64<byte>, Vector64<byte>> Load3xVector64(byte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005520 RID: 21792 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[return: TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3"
		})]
		public unsafe static ValueTuple<Vector64<sbyte>, Vector64<sbyte>, Vector64<sbyte>> Load3xVector64(sbyte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005521 RID: 21793 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[return: TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3"
		})]
		public unsafe static ValueTuple<Vector64<short>, Vector64<short>, Vector64<short>> Load3xVector64(short* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005522 RID: 21794 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[return: TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3"
		})]
		public unsafe static ValueTuple<Vector64<ushort>, Vector64<ushort>, Vector64<ushort>> Load3xVector64(ushort* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005523 RID: 21795 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[return: TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3"
		})]
		public unsafe static ValueTuple<Vector64<int>, Vector64<int>, Vector64<int>> Load3xVector64(int* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005524 RID: 21796 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[return: TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3"
		})]
		public unsafe static ValueTuple<Vector64<uint>, Vector64<uint>, Vector64<uint>> Load3xVector64(uint* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005525 RID: 21797 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[return: TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3"
		})]
		public unsafe static ValueTuple<Vector64<float>, Vector64<float>, Vector64<float>> Load3xVector64(float* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005526 RID: 21798 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[return: TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3",
			"Value4"
		})]
		public unsafe static ValueTuple<Vector64<byte>, Vector64<byte>, Vector64<byte>, Vector64<byte>> Load4xVector64(byte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005527 RID: 21799 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[return: TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3",
			"Value4"
		})]
		public unsafe static ValueTuple<Vector64<sbyte>, Vector64<sbyte>, Vector64<sbyte>, Vector64<sbyte>> Load4xVector64(sbyte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005528 RID: 21800 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[return: TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3",
			"Value4"
		})]
		public unsafe static ValueTuple<Vector64<short>, Vector64<short>, Vector64<short>, Vector64<short>> Load4xVector64(short* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005529 RID: 21801 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[return: TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3",
			"Value4"
		})]
		public unsafe static ValueTuple<Vector64<ushort>, Vector64<ushort>, Vector64<ushort>, Vector64<ushort>> Load4xVector64(ushort* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600552A RID: 21802 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[return: TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3",
			"Value4"
		})]
		public unsafe static ValueTuple<Vector64<int>, Vector64<int>, Vector64<int>, Vector64<int>> Load4xVector64(int* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600552B RID: 21803 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[return: TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3",
			"Value4"
		})]
		public unsafe static ValueTuple<Vector64<uint>, Vector64<uint>, Vector64<uint>, Vector64<uint>> Load4xVector64(uint* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600552C RID: 21804 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[return: TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3",
			"Value4"
		})]
		public unsafe static ValueTuple<Vector64<float>, Vector64<float>, Vector64<float>, Vector64<float>> Load4xVector64(float* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600552D RID: 21805 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<byte> Max(Vector64<byte> left, Vector64<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600552E RID: 21806 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> Max(Vector64<short> left, Vector64<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600552F RID: 21807 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> Max(Vector64<int> left, Vector64<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005530 RID: 21808 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<sbyte> Max(Vector64<sbyte> left, Vector64<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005531 RID: 21809 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<float> Max(Vector64<float> left, Vector64<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005532 RID: 21810 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ushort> Max(Vector64<ushort> left, Vector64<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005533 RID: 21811 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> Max(Vector64<uint> left, Vector64<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005534 RID: 21812 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> Max(Vector128<byte> left, Vector128<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005535 RID: 21813 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> Max(Vector128<short> left, Vector128<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005536 RID: 21814 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> Max(Vector128<int> left, Vector128<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005537 RID: 21815 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> Max(Vector128<sbyte> left, Vector128<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005538 RID: 21816 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> Max(Vector128<float> left, Vector128<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005539 RID: 21817 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> Max(Vector128<ushort> left, Vector128<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600553A RID: 21818 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> Max(Vector128<uint> left, Vector128<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600553B RID: 21819 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<float> MaxNumber(Vector64<float> left, Vector64<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600553C RID: 21820 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> MaxNumber(Vector128<float> left, Vector128<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600553D RID: 21821 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<double> MaxNumberScalar(Vector64<double> left, Vector64<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600553E RID: 21822 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<float> MaxNumberScalar(Vector64<float> left, Vector64<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600553F RID: 21823 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<byte> MaxPairwise(Vector64<byte> left, Vector64<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005540 RID: 21824 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> MaxPairwise(Vector64<short> left, Vector64<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005541 RID: 21825 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> MaxPairwise(Vector64<int> left, Vector64<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005542 RID: 21826 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<sbyte> MaxPairwise(Vector64<sbyte> left, Vector64<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005543 RID: 21827 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<float> MaxPairwise(Vector64<float> left, Vector64<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005544 RID: 21828 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ushort> MaxPairwise(Vector64<ushort> left, Vector64<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005545 RID: 21829 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> MaxPairwise(Vector64<uint> left, Vector64<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005546 RID: 21830 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<byte> Min(Vector64<byte> left, Vector64<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005547 RID: 21831 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> Min(Vector64<short> left, Vector64<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005548 RID: 21832 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> Min(Vector64<int> left, Vector64<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005549 RID: 21833 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<sbyte> Min(Vector64<sbyte> left, Vector64<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600554A RID: 21834 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<float> Min(Vector64<float> left, Vector64<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600554B RID: 21835 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ushort> Min(Vector64<ushort> left, Vector64<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600554C RID: 21836 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> Min(Vector64<uint> left, Vector64<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600554D RID: 21837 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> Min(Vector128<byte> left, Vector128<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600554E RID: 21838 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> Min(Vector128<short> left, Vector128<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600554F RID: 21839 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> Min(Vector128<int> left, Vector128<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005550 RID: 21840 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> Min(Vector128<sbyte> left, Vector128<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005551 RID: 21841 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> Min(Vector128<float> left, Vector128<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005552 RID: 21842 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> Min(Vector128<ushort> left, Vector128<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005553 RID: 21843 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> Min(Vector128<uint> left, Vector128<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005554 RID: 21844 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<float> MinNumber(Vector64<float> left, Vector64<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005555 RID: 21845 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> MinNumber(Vector128<float> left, Vector128<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005556 RID: 21846 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<double> MinNumberScalar(Vector64<double> left, Vector64<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005557 RID: 21847 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<float> MinNumberScalar(Vector64<float> left, Vector64<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005558 RID: 21848 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<byte> MinPairwise(Vector64<byte> left, Vector64<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005559 RID: 21849 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> MinPairwise(Vector64<short> left, Vector64<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600555A RID: 21850 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> MinPairwise(Vector64<int> left, Vector64<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600555B RID: 21851 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<sbyte> MinPairwise(Vector64<sbyte> left, Vector64<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600555C RID: 21852 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<float> MinPairwise(Vector64<float> left, Vector64<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600555D RID: 21853 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ushort> MinPairwise(Vector64<ushort> left, Vector64<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600555E RID: 21854 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> MinPairwise(Vector64<uint> left, Vector64<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600555F RID: 21855 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<byte> Multiply(Vector64<byte> left, Vector64<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005560 RID: 21856 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> Multiply(Vector64<short> left, Vector64<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005561 RID: 21857 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> Multiply(Vector64<int> left, Vector64<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005562 RID: 21858 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<sbyte> Multiply(Vector64<sbyte> left, Vector64<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005563 RID: 21859 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<float> Multiply(Vector64<float> left, Vector64<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005564 RID: 21860 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ushort> Multiply(Vector64<ushort> left, Vector64<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005565 RID: 21861 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> Multiply(Vector64<uint> left, Vector64<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005566 RID: 21862 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> Multiply(Vector128<byte> left, Vector128<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005567 RID: 21863 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> Multiply(Vector128<short> left, Vector128<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005568 RID: 21864 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> Multiply(Vector128<int> left, Vector128<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005569 RID: 21865 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> Multiply(Vector128<sbyte> left, Vector128<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600556A RID: 21866 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> Multiply(Vector128<float> left, Vector128<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600556B RID: 21867 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> Multiply(Vector128<ushort> left, Vector128<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600556C RID: 21868 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> Multiply(Vector128<uint> left, Vector128<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600556D RID: 21869 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<byte> MultiplyAdd(Vector64<byte> addend, Vector64<byte> left, Vector64<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600556E RID: 21870 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> MultiplyAdd(Vector64<short> addend, Vector64<short> left, Vector64<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600556F RID: 21871 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> MultiplyAdd(Vector64<int> addend, Vector64<int> left, Vector64<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005570 RID: 21872 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<sbyte> MultiplyAdd(Vector64<sbyte> addend, Vector64<sbyte> left, Vector64<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005571 RID: 21873 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ushort> MultiplyAdd(Vector64<ushort> addend, Vector64<ushort> left, Vector64<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005572 RID: 21874 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> MultiplyAdd(Vector64<uint> addend, Vector64<uint> left, Vector64<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005573 RID: 21875 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> MultiplyAdd(Vector128<byte> addend, Vector128<byte> left, Vector128<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005574 RID: 21876 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> MultiplyAdd(Vector128<short> addend, Vector128<short> left, Vector128<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005575 RID: 21877 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> MultiplyAdd(Vector128<int> addend, Vector128<int> left, Vector128<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005576 RID: 21878 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> MultiplyAdd(Vector128<sbyte> addend, Vector128<sbyte> left, Vector128<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005577 RID: 21879 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> MultiplyAdd(Vector128<ushort> addend, Vector128<ushort> left, Vector128<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005578 RID: 21880 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> MultiplyAdd(Vector128<uint> addend, Vector128<uint> left, Vector128<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005579 RID: 21881 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> MultiplyAddByScalar(Vector64<short> addend, Vector64<short> left, Vector64<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600557A RID: 21882 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> MultiplyAddByScalar(Vector64<int> addend, Vector64<int> left, Vector64<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600557B RID: 21883 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ushort> MultiplyAddByScalar(Vector64<ushort> addend, Vector64<ushort> left, Vector64<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600557C RID: 21884 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> MultiplyAddByScalar(Vector64<uint> addend, Vector64<uint> left, Vector64<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600557D RID: 21885 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> MultiplyAddByScalar(Vector128<short> addend, Vector128<short> left, Vector64<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600557E RID: 21886 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> MultiplyAddByScalar(Vector128<int> addend, Vector128<int> left, Vector64<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600557F RID: 21887 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> MultiplyAddByScalar(Vector128<ushort> addend, Vector128<ushort> left, Vector64<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005580 RID: 21888 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> MultiplyAddByScalar(Vector128<uint> addend, Vector128<uint> left, Vector64<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005581 RID: 21889 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> MultiplyAddBySelectedScalar(Vector64<short> addend, Vector64<short> left, Vector64<short> right, [ConstantExpected(Max = 3)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005582 RID: 21890 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> MultiplyAddBySelectedScalar(Vector64<short> addend, Vector64<short> left, Vector128<short> right, [ConstantExpected(Max = 7)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005583 RID: 21891 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> MultiplyAddBySelectedScalar(Vector64<int> addend, Vector64<int> left, Vector64<int> right, [ConstantExpected(Max = 1)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005584 RID: 21892 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> MultiplyAddBySelectedScalar(Vector64<int> addend, Vector64<int> left, Vector128<int> right, [ConstantExpected(Max = 3)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005585 RID: 21893 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ushort> MultiplyAddBySelectedScalar(Vector64<ushort> addend, Vector64<ushort> left, Vector64<ushort> right, [ConstantExpected(Max = 3)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005586 RID: 21894 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ushort> MultiplyAddBySelectedScalar(Vector64<ushort> addend, Vector64<ushort> left, Vector128<ushort> right, [ConstantExpected(Max = 7)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005587 RID: 21895 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> MultiplyAddBySelectedScalar(Vector64<uint> addend, Vector64<uint> left, Vector64<uint> right, [ConstantExpected(Max = 1)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005588 RID: 21896 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> MultiplyAddBySelectedScalar(Vector64<uint> addend, Vector64<uint> left, Vector128<uint> right, [ConstantExpected(Max = 3)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005589 RID: 21897 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> MultiplyAddBySelectedScalar(Vector128<short> addend, Vector128<short> left, Vector64<short> right, [ConstantExpected(Max = 3)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600558A RID: 21898 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> MultiplyAddBySelectedScalar(Vector128<short> addend, Vector128<short> left, Vector128<short> right, [ConstantExpected(Max = 7)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600558B RID: 21899 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> MultiplyAddBySelectedScalar(Vector128<int> addend, Vector128<int> left, Vector64<int> right, [ConstantExpected(Max = 1)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600558C RID: 21900 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> MultiplyAddBySelectedScalar(Vector128<int> addend, Vector128<int> left, Vector128<int> right, [ConstantExpected(Max = 3)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600558D RID: 21901 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> MultiplyAddBySelectedScalar(Vector128<ushort> addend, Vector128<ushort> left, Vector64<ushort> right, [ConstantExpected(Max = 3)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600558E RID: 21902 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> MultiplyAddBySelectedScalar(Vector128<ushort> addend, Vector128<ushort> left, Vector128<ushort> right, [ConstantExpected(Max = 7)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600558F RID: 21903 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> MultiplyAddBySelectedScalar(Vector128<uint> addend, Vector128<uint> left, Vector64<uint> right, [ConstantExpected(Max = 1)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005590 RID: 21904 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> MultiplyAddBySelectedScalar(Vector128<uint> addend, Vector128<uint> left, Vector128<uint> right, [ConstantExpected(Max = 3)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005591 RID: 21905 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> MultiplyByScalar(Vector64<short> left, Vector64<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005592 RID: 21906 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> MultiplyByScalar(Vector64<int> left, Vector64<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005593 RID: 21907 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<float> MultiplyByScalar(Vector64<float> left, Vector64<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005594 RID: 21908 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ushort> MultiplyByScalar(Vector64<ushort> left, Vector64<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005595 RID: 21909 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> MultiplyByScalar(Vector64<uint> left, Vector64<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005596 RID: 21910 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> MultiplyByScalar(Vector128<short> left, Vector64<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005597 RID: 21911 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> MultiplyByScalar(Vector128<int> left, Vector64<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005598 RID: 21912 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> MultiplyByScalar(Vector128<float> left, Vector64<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005599 RID: 21913 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> MultiplyByScalar(Vector128<ushort> left, Vector64<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600559A RID: 21914 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> MultiplyByScalar(Vector128<uint> left, Vector64<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600559B RID: 21915 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> MultiplyBySelectedScalar(Vector64<short> left, Vector64<short> right, [ConstantExpected(Max = 3)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600559C RID: 21916 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> MultiplyBySelectedScalar(Vector64<short> left, Vector128<short> right, [ConstantExpected(Max = 7)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600559D RID: 21917 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> MultiplyBySelectedScalar(Vector64<int> left, Vector64<int> right, [ConstantExpected(Max = 1)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600559E RID: 21918 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> MultiplyBySelectedScalar(Vector64<int> left, Vector128<int> right, [ConstantExpected(Max = 3)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600559F RID: 21919 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<float> MultiplyBySelectedScalar(Vector64<float> left, Vector64<float> right, [ConstantExpected(Max = 1)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055A0 RID: 21920 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<float> MultiplyBySelectedScalar(Vector64<float> left, Vector128<float> right, [ConstantExpected(Max = 3)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055A1 RID: 21921 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ushort> MultiplyBySelectedScalar(Vector64<ushort> left, Vector64<ushort> right, [ConstantExpected(Max = 3)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055A2 RID: 21922 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ushort> MultiplyBySelectedScalar(Vector64<ushort> left, Vector128<ushort> right, [ConstantExpected(Max = 7)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055A3 RID: 21923 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> MultiplyBySelectedScalar(Vector64<uint> left, Vector64<uint> right, [ConstantExpected(Max = 1)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055A4 RID: 21924 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> MultiplyBySelectedScalar(Vector64<uint> left, Vector128<uint> right, [ConstantExpected(Max = 3)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055A5 RID: 21925 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> MultiplyBySelectedScalar(Vector128<short> left, Vector64<short> right, [ConstantExpected(Max = 3)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055A6 RID: 21926 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> MultiplyBySelectedScalar(Vector128<short> left, Vector128<short> right, [ConstantExpected(Max = 7)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055A7 RID: 21927 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> MultiplyBySelectedScalar(Vector128<int> left, Vector64<int> right, [ConstantExpected(Max = 1)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055A8 RID: 21928 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> MultiplyBySelectedScalar(Vector128<int> left, Vector128<int> right, [ConstantExpected(Max = 3)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055A9 RID: 21929 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> MultiplyBySelectedScalar(Vector128<float> left, Vector64<float> right, [ConstantExpected(Max = 1)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055AA RID: 21930 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> MultiplyBySelectedScalar(Vector128<float> left, Vector128<float> right, [ConstantExpected(Max = 3)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055AB RID: 21931 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> MultiplyBySelectedScalar(Vector128<ushort> left, Vector64<ushort> right, [ConstantExpected(Max = 3)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055AC RID: 21932 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> MultiplyBySelectedScalar(Vector128<ushort> left, Vector128<ushort> right, [ConstantExpected(Max = 7)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055AD RID: 21933 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> MultiplyBySelectedScalar(Vector128<uint> left, Vector64<uint> right, [ConstantExpected(Max = 1)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055AE RID: 21934 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> MultiplyBySelectedScalar(Vector128<uint> left, Vector128<uint> right, [ConstantExpected(Max = 3)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055AF RID: 21935 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> MultiplyBySelectedScalarWideningLower(Vector64<short> left, Vector64<short> right, [ConstantExpected(Max = 3)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055B0 RID: 21936 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> MultiplyBySelectedScalarWideningLower(Vector64<short> left, Vector128<short> right, [ConstantExpected(Max = 7)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055B1 RID: 21937 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> MultiplyBySelectedScalarWideningLower(Vector64<int> left, Vector64<int> right, [ConstantExpected(Max = 1)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055B2 RID: 21938 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> MultiplyBySelectedScalarWideningLower(Vector64<int> left, Vector128<int> right, [ConstantExpected(Max = 3)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055B3 RID: 21939 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> MultiplyBySelectedScalarWideningLower(Vector64<ushort> left, Vector64<ushort> right, [ConstantExpected(Max = 3)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055B4 RID: 21940 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> MultiplyBySelectedScalarWideningLower(Vector64<ushort> left, Vector128<ushort> right, [ConstantExpected(Max = 7)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055B5 RID: 21941 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> MultiplyBySelectedScalarWideningLower(Vector64<uint> left, Vector64<uint> right, [ConstantExpected(Max = 1)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055B6 RID: 21942 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> MultiplyBySelectedScalarWideningLower(Vector64<uint> left, Vector128<uint> right, [ConstantExpected(Max = 3)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055B7 RID: 21943 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> MultiplyBySelectedScalarWideningLowerAndAdd(Vector128<int> addend, Vector64<short> left, Vector64<short> right, [ConstantExpected(Max = 3)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055B8 RID: 21944 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> MultiplyBySelectedScalarWideningLowerAndAdd(Vector128<int> addend, Vector64<short> left, Vector128<short> right, [ConstantExpected(Max = 7)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055B9 RID: 21945 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> MultiplyBySelectedScalarWideningLowerAndAdd(Vector128<long> addend, Vector64<int> left, Vector64<int> right, [ConstantExpected(Max = 1)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055BA RID: 21946 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> MultiplyBySelectedScalarWideningLowerAndAdd(Vector128<long> addend, Vector64<int> left, Vector128<int> right, [ConstantExpected(Max = 3)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055BB RID: 21947 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> MultiplyBySelectedScalarWideningLowerAndAdd(Vector128<uint> addend, Vector64<ushort> left, Vector64<ushort> right, [ConstantExpected(Max = 3)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055BC RID: 21948 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> MultiplyBySelectedScalarWideningLowerAndAdd(Vector128<uint> addend, Vector64<ushort> left, Vector128<ushort> right, [ConstantExpected(Max = 7)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055BD RID: 21949 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> MultiplyBySelectedScalarWideningLowerAndAdd(Vector128<ulong> addend, Vector64<uint> left, Vector64<uint> right, [ConstantExpected(Max = 1)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055BE RID: 21950 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> MultiplyBySelectedScalarWideningLowerAndAdd(Vector128<ulong> addend, Vector64<uint> left, Vector128<uint> right, [ConstantExpected(Max = 3)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055BF RID: 21951 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> MultiplyBySelectedScalarWideningLowerAndSubtract(Vector128<int> minuend, Vector64<short> left, Vector64<short> right, [ConstantExpected(Max = 3)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055C0 RID: 21952 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> MultiplyBySelectedScalarWideningLowerAndSubtract(Vector128<int> minuend, Vector64<short> left, Vector128<short> right, [ConstantExpected(Max = 7)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055C1 RID: 21953 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> MultiplyBySelectedScalarWideningLowerAndSubtract(Vector128<long> minuend, Vector64<int> left, Vector64<int> right, [ConstantExpected(Max = 1)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055C2 RID: 21954 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> MultiplyBySelectedScalarWideningLowerAndSubtract(Vector128<long> minuend, Vector64<int> left, Vector128<int> right, [ConstantExpected(Max = 3)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055C3 RID: 21955 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> MultiplyBySelectedScalarWideningLowerAndSubtract(Vector128<uint> minuend, Vector64<ushort> left, Vector64<ushort> right, [ConstantExpected(Max = 3)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055C4 RID: 21956 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> MultiplyBySelectedScalarWideningLowerAndSubtract(Vector128<uint> minuend, Vector64<ushort> left, Vector128<ushort> right, [ConstantExpected(Max = 7)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055C5 RID: 21957 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> MultiplyBySelectedScalarWideningLowerAndSubtract(Vector128<ulong> minuend, Vector64<uint> left, Vector64<uint> right, [ConstantExpected(Max = 1)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055C6 RID: 21958 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> MultiplyBySelectedScalarWideningLowerAndSubtract(Vector128<ulong> minuend, Vector64<uint> left, Vector128<uint> right, [ConstantExpected(Max = 3)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055C7 RID: 21959 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> MultiplyBySelectedScalarWideningUpper(Vector128<short> left, Vector64<short> right, [ConstantExpected(Max = 3)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055C8 RID: 21960 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> MultiplyBySelectedScalarWideningUpper(Vector128<short> left, Vector128<short> right, [ConstantExpected(Max = 7)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055C9 RID: 21961 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> MultiplyBySelectedScalarWideningUpper(Vector128<int> left, Vector64<int> right, [ConstantExpected(Max = 1)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055CA RID: 21962 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> MultiplyBySelectedScalarWideningUpper(Vector128<int> left, Vector128<int> right, [ConstantExpected(Max = 3)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055CB RID: 21963 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> MultiplyBySelectedScalarWideningUpper(Vector128<ushort> left, Vector64<ushort> right, [ConstantExpected(Max = 3)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055CC RID: 21964 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> MultiplyBySelectedScalarWideningUpper(Vector128<ushort> left, Vector128<ushort> right, [ConstantExpected(Max = 7)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055CD RID: 21965 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> MultiplyBySelectedScalarWideningUpper(Vector128<uint> left, Vector64<uint> right, [ConstantExpected(Max = 1)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055CE RID: 21966 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> MultiplyBySelectedScalarWideningUpper(Vector128<uint> left, Vector128<uint> right, [ConstantExpected(Max = 3)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055CF RID: 21967 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> MultiplyBySelectedScalarWideningUpperAndAdd(Vector128<int> addend, Vector128<short> left, Vector64<short> right, [ConstantExpected(Max = 3)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055D0 RID: 21968 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> MultiplyBySelectedScalarWideningUpperAndAdd(Vector128<int> addend, Vector128<short> left, Vector128<short> right, [ConstantExpected(Max = 7)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055D1 RID: 21969 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> MultiplyBySelectedScalarWideningUpperAndAdd(Vector128<long> addend, Vector128<int> left, Vector64<int> right, [ConstantExpected(Max = 1)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055D2 RID: 21970 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> MultiplyBySelectedScalarWideningUpperAndAdd(Vector128<long> addend, Vector128<int> left, Vector128<int> right, [ConstantExpected(Max = 3)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055D3 RID: 21971 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> MultiplyBySelectedScalarWideningUpperAndAdd(Vector128<uint> addend, Vector128<ushort> left, Vector64<ushort> right, [ConstantExpected(Max = 3)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055D4 RID: 21972 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> MultiplyBySelectedScalarWideningUpperAndAdd(Vector128<uint> addend, Vector128<ushort> left, Vector128<ushort> right, [ConstantExpected(Max = 7)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055D5 RID: 21973 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> MultiplyBySelectedScalarWideningUpperAndAdd(Vector128<ulong> addend, Vector128<uint> left, Vector64<uint> right, [ConstantExpected(Max = 1)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055D6 RID: 21974 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> MultiplyBySelectedScalarWideningUpperAndAdd(Vector128<ulong> addend, Vector128<uint> left, Vector128<uint> right, [ConstantExpected(Max = 3)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055D7 RID: 21975 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> MultiplyBySelectedScalarWideningUpperAndSubtract(Vector128<int> minuend, Vector128<short> left, Vector64<short> right, [ConstantExpected(Max = 3)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055D8 RID: 21976 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> MultiplyBySelectedScalarWideningUpperAndSubtract(Vector128<int> minuend, Vector128<short> left, Vector128<short> right, [ConstantExpected(Max = 7)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055D9 RID: 21977 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> MultiplyBySelectedScalarWideningUpperAndSubtract(Vector128<long> minuend, Vector128<int> left, Vector64<int> right, [ConstantExpected(Max = 1)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055DA RID: 21978 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> MultiplyBySelectedScalarWideningUpperAndSubtract(Vector128<long> minuend, Vector128<int> left, Vector128<int> right, [ConstantExpected(Max = 3)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055DB RID: 21979 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> MultiplyBySelectedScalarWideningUpperAndSubtract(Vector128<uint> minuend, Vector128<ushort> left, Vector64<ushort> right, [ConstantExpected(Max = 3)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055DC RID: 21980 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> MultiplyBySelectedScalarWideningUpperAndSubtract(Vector128<uint> minuend, Vector128<ushort> left, Vector128<ushort> right, [ConstantExpected(Max = 7)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055DD RID: 21981 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> MultiplyBySelectedScalarWideningUpperAndSubtract(Vector128<ulong> minuend, Vector128<uint> left, Vector64<uint> right, [ConstantExpected(Max = 1)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055DE RID: 21982 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> MultiplyBySelectedScalarWideningUpperAndSubtract(Vector128<ulong> minuend, Vector128<uint> left, Vector128<uint> right, [ConstantExpected(Max = 3)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055DF RID: 21983 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> MultiplyDoublingByScalarSaturateHigh(Vector64<short> left, Vector64<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055E0 RID: 21984 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> MultiplyDoublingByScalarSaturateHigh(Vector64<int> left, Vector64<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055E1 RID: 21985 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> MultiplyDoublingByScalarSaturateHigh(Vector128<short> left, Vector64<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055E2 RID: 21986 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> MultiplyDoublingByScalarSaturateHigh(Vector128<int> left, Vector64<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055E3 RID: 21987 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> MultiplyDoublingBySelectedScalarSaturateHigh(Vector64<short> left, Vector64<short> right, [ConstantExpected(Max = 3)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055E4 RID: 21988 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> MultiplyDoublingBySelectedScalarSaturateHigh(Vector64<short> left, Vector128<short> right, [ConstantExpected(Max = 7)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055E5 RID: 21989 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> MultiplyDoublingBySelectedScalarSaturateHigh(Vector64<int> left, Vector64<int> right, [ConstantExpected(Max = 1)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055E6 RID: 21990 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> MultiplyDoublingBySelectedScalarSaturateHigh(Vector64<int> left, Vector128<int> right, [ConstantExpected(Max = 3)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055E7 RID: 21991 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> MultiplyDoublingBySelectedScalarSaturateHigh(Vector128<short> left, Vector64<short> right, [ConstantExpected(Max = 3)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055E8 RID: 21992 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> MultiplyDoublingBySelectedScalarSaturateHigh(Vector128<short> left, Vector128<short> right, [ConstantExpected(Max = 7)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055E9 RID: 21993 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> MultiplyDoublingBySelectedScalarSaturateHigh(Vector128<int> left, Vector64<int> right, [ConstantExpected(Max = 1)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055EA RID: 21994 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> MultiplyDoublingBySelectedScalarSaturateHigh(Vector128<int> left, Vector128<int> right, [ConstantExpected(Max = 3)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055EB RID: 21995 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> MultiplyDoublingSaturateHigh(Vector64<short> left, Vector64<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055EC RID: 21996 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> MultiplyDoublingSaturateHigh(Vector64<int> left, Vector64<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055ED RID: 21997 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> MultiplyDoublingSaturateHigh(Vector128<short> left, Vector128<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055EE RID: 21998 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> MultiplyDoublingSaturateHigh(Vector128<int> left, Vector128<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055EF RID: 21999 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> MultiplyDoublingWideningLowerAndAddSaturate(Vector128<int> addend, Vector64<short> left, Vector64<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055F0 RID: 22000 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> MultiplyDoublingWideningLowerAndAddSaturate(Vector128<long> addend, Vector64<int> left, Vector64<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055F1 RID: 22001 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> MultiplyDoublingWideningLowerAndSubtractSaturate(Vector128<int> minuend, Vector64<short> left, Vector64<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055F2 RID: 22002 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> MultiplyDoublingWideningLowerAndSubtractSaturate(Vector128<long> minuend, Vector64<int> left, Vector64<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055F3 RID: 22003 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> MultiplyDoublingWideningLowerByScalarAndAddSaturate(Vector128<int> addend, Vector64<short> left, Vector64<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055F4 RID: 22004 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> MultiplyDoublingWideningLowerByScalarAndAddSaturate(Vector128<long> addend, Vector64<int> left, Vector64<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055F5 RID: 22005 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> MultiplyDoublingWideningLowerByScalarAndSubtractSaturate(Vector128<int> minuend, Vector64<short> left, Vector64<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055F6 RID: 22006 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> MultiplyDoublingWideningLowerByScalarAndSubtractSaturate(Vector128<long> minuend, Vector64<int> left, Vector64<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055F7 RID: 22007 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> MultiplyDoublingWideningLowerBySelectedScalarAndAddSaturate(Vector128<int> addend, Vector64<short> left, Vector64<short> right, [ConstantExpected(Max = 3)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055F8 RID: 22008 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> MultiplyDoublingWideningLowerBySelectedScalarAndAddSaturate(Vector128<int> addend, Vector64<short> left, Vector128<short> right, [ConstantExpected(Max = 7)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055F9 RID: 22009 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> MultiplyDoublingWideningLowerBySelectedScalarAndAddSaturate(Vector128<long> addend, Vector64<int> left, Vector64<int> right, [ConstantExpected(Max = 1)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055FA RID: 22010 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> MultiplyDoublingWideningLowerBySelectedScalarAndAddSaturate(Vector128<long> addend, Vector64<int> left, Vector128<int> right, [ConstantExpected(Max = 3)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055FB RID: 22011 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> MultiplyDoublingWideningLowerBySelectedScalarAndSubtractSaturate(Vector128<int> minuend, Vector64<short> left, Vector64<short> right, [ConstantExpected(Max = 3)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055FC RID: 22012 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> MultiplyDoublingWideningLowerBySelectedScalarAndSubtractSaturate(Vector128<int> minuend, Vector64<short> left, Vector128<short> right, [ConstantExpected(Max = 7)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055FD RID: 22013 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> MultiplyDoublingWideningLowerBySelectedScalarAndSubtractSaturate(Vector128<long> minuend, Vector64<int> left, Vector64<int> right, [ConstantExpected(Max = 1)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055FE RID: 22014 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> MultiplyDoublingWideningLowerBySelectedScalarAndSubtractSaturate(Vector128<long> minuend, Vector64<int> left, Vector128<int> right, [ConstantExpected(Max = 3)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060055FF RID: 22015 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> MultiplyDoublingWideningSaturateLower(Vector64<short> left, Vector64<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005600 RID: 22016 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> MultiplyDoublingWideningSaturateLower(Vector64<int> left, Vector64<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005601 RID: 22017 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> MultiplyDoublingWideningSaturateLowerByScalar(Vector64<short> left, Vector64<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005602 RID: 22018 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> MultiplyDoublingWideningSaturateLowerByScalar(Vector64<int> left, Vector64<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005603 RID: 22019 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> MultiplyDoublingWideningSaturateLowerBySelectedScalar(Vector64<short> left, Vector64<short> right, [ConstantExpected(Max = 3)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005604 RID: 22020 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> MultiplyDoublingWideningSaturateLowerBySelectedScalar(Vector64<short> left, Vector128<short> right, [ConstantExpected(Max = 7)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005605 RID: 22021 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> MultiplyDoublingWideningSaturateLowerBySelectedScalar(Vector64<int> left, Vector64<int> right, [ConstantExpected(Max = 1)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005606 RID: 22022 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> MultiplyDoublingWideningSaturateLowerBySelectedScalar(Vector64<int> left, Vector128<int> right, [ConstantExpected(Max = 3)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005607 RID: 22023 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> MultiplyDoublingWideningSaturateUpper(Vector128<short> left, Vector128<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005608 RID: 22024 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> MultiplyDoublingWideningSaturateUpper(Vector128<int> left, Vector128<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005609 RID: 22025 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> MultiplyDoublingWideningSaturateUpperByScalar(Vector128<short> left, Vector64<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600560A RID: 22026 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> MultiplyDoublingWideningSaturateUpperByScalar(Vector128<int> left, Vector64<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600560B RID: 22027 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> MultiplyDoublingWideningSaturateUpperBySelectedScalar(Vector128<short> left, Vector64<short> right, [ConstantExpected(Max = 3)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600560C RID: 22028 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> MultiplyDoublingWideningSaturateUpperBySelectedScalar(Vector128<short> left, Vector128<short> right, [ConstantExpected(Max = 7)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600560D RID: 22029 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> MultiplyDoublingWideningSaturateUpperBySelectedScalar(Vector128<int> left, Vector64<int> right, [ConstantExpected(Max = 1)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600560E RID: 22030 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> MultiplyDoublingWideningSaturateUpperBySelectedScalar(Vector128<int> left, Vector128<int> right, [ConstantExpected(Max = 3)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600560F RID: 22031 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> MultiplyDoublingWideningUpperAndAddSaturate(Vector128<int> addend, Vector128<short> left, Vector128<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005610 RID: 22032 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> MultiplyDoublingWideningUpperAndAddSaturate(Vector128<long> addend, Vector128<int> left, Vector128<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005611 RID: 22033 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> MultiplyDoublingWideningUpperAndSubtractSaturate(Vector128<int> minuend, Vector128<short> left, Vector128<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005612 RID: 22034 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> MultiplyDoublingWideningUpperAndSubtractSaturate(Vector128<long> minuend, Vector128<int> left, Vector128<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005613 RID: 22035 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> MultiplyDoublingWideningUpperByScalarAndAddSaturate(Vector128<int> addend, Vector128<short> left, Vector64<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005614 RID: 22036 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> MultiplyDoublingWideningUpperByScalarAndAddSaturate(Vector128<long> addend, Vector128<int> left, Vector64<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005615 RID: 22037 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> MultiplyDoublingWideningUpperByScalarAndSubtractSaturate(Vector128<int> minuend, Vector128<short> left, Vector64<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005616 RID: 22038 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> MultiplyDoublingWideningUpperByScalarAndSubtractSaturate(Vector128<long> minuend, Vector128<int> left, Vector64<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005617 RID: 22039 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> MultiplyDoublingWideningUpperBySelectedScalarAndAddSaturate(Vector128<int> addend, Vector128<short> left, Vector64<short> right, [ConstantExpected(Max = 3)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005618 RID: 22040 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> MultiplyDoublingWideningUpperBySelectedScalarAndAddSaturate(Vector128<int> addend, Vector128<short> left, Vector128<short> right, [ConstantExpected(Max = 7)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005619 RID: 22041 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> MultiplyDoublingWideningUpperBySelectedScalarAndAddSaturate(Vector128<long> addend, Vector128<int> left, Vector64<int> right, [ConstantExpected(Max = 1)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600561A RID: 22042 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> MultiplyDoublingWideningUpperBySelectedScalarAndAddSaturate(Vector128<long> addend, Vector128<int> left, Vector128<int> right, [ConstantExpected(Max = 3)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600561B RID: 22043 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> MultiplyDoublingWideningUpperBySelectedScalarAndSubtractSaturate(Vector128<int> minuend, Vector128<short> left, Vector64<short> right, [ConstantExpected(Max = 3)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600561C RID: 22044 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> MultiplyDoublingWideningUpperBySelectedScalarAndSubtractSaturate(Vector128<int> minuend, Vector128<short> left, Vector128<short> right, [ConstantExpected(Max = 7)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600561D RID: 22045 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> MultiplyDoublingWideningUpperBySelectedScalarAndSubtractSaturate(Vector128<long> minuend, Vector128<int> left, Vector64<int> right, [ConstantExpected(Max = 1)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600561E RID: 22046 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> MultiplyDoublingWideningUpperBySelectedScalarAndSubtractSaturate(Vector128<long> minuend, Vector128<int> left, Vector128<int> right, [ConstantExpected(Max = 3)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600561F RID: 22047 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> MultiplyRoundedDoublingByScalarSaturateHigh(Vector64<short> left, Vector64<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005620 RID: 22048 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> MultiplyRoundedDoublingByScalarSaturateHigh(Vector64<int> left, Vector64<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005621 RID: 22049 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> MultiplyRoundedDoublingByScalarSaturateHigh(Vector128<short> left, Vector64<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005622 RID: 22050 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> MultiplyRoundedDoublingByScalarSaturateHigh(Vector128<int> left, Vector64<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005623 RID: 22051 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> MultiplyRoundedDoublingBySelectedScalarSaturateHigh(Vector64<short> left, Vector64<short> right, [ConstantExpected(Max = 3)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005624 RID: 22052 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> MultiplyRoundedDoublingBySelectedScalarSaturateHigh(Vector64<short> left, Vector128<short> right, [ConstantExpected(Max = 7)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005625 RID: 22053 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> MultiplyRoundedDoublingBySelectedScalarSaturateHigh(Vector64<int> left, Vector64<int> right, [ConstantExpected(Max = 1)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005626 RID: 22054 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> MultiplyRoundedDoublingBySelectedScalarSaturateHigh(Vector64<int> left, Vector128<int> right, [ConstantExpected(Max = 3)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005627 RID: 22055 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> MultiplyRoundedDoublingBySelectedScalarSaturateHigh(Vector128<short> left, Vector64<short> right, [ConstantExpected(Max = 3)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005628 RID: 22056 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> MultiplyRoundedDoublingBySelectedScalarSaturateHigh(Vector128<short> left, Vector128<short> right, [ConstantExpected(Max = 7)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005629 RID: 22057 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> MultiplyRoundedDoublingBySelectedScalarSaturateHigh(Vector128<int> left, Vector64<int> right, [ConstantExpected(Max = 1)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600562A RID: 22058 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> MultiplyRoundedDoublingBySelectedScalarSaturateHigh(Vector128<int> left, Vector128<int> right, [ConstantExpected(Max = 3)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600562B RID: 22059 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> MultiplyRoundedDoublingSaturateHigh(Vector64<short> left, Vector64<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600562C RID: 22060 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> MultiplyRoundedDoublingSaturateHigh(Vector64<int> left, Vector64<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600562D RID: 22061 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> MultiplyRoundedDoublingSaturateHigh(Vector128<short> left, Vector128<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600562E RID: 22062 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> MultiplyRoundedDoublingSaturateHigh(Vector128<int> left, Vector128<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600562F RID: 22063 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<double> MultiplyScalar(Vector64<double> left, Vector64<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005630 RID: 22064 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<float> MultiplyScalar(Vector64<float> left, Vector64<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005631 RID: 22065 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<float> MultiplyScalarBySelectedScalar(Vector64<float> left, Vector64<float> right, [ConstantExpected(Max = 1)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005632 RID: 22066 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<float> MultiplyScalarBySelectedScalar(Vector64<float> left, Vector128<float> right, [ConstantExpected(Max = 3)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005633 RID: 22067 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<byte> MultiplySubtract(Vector64<byte> minuend, Vector64<byte> left, Vector64<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005634 RID: 22068 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> MultiplySubtract(Vector64<short> minuend, Vector64<short> left, Vector64<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005635 RID: 22069 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> MultiplySubtract(Vector64<int> minuend, Vector64<int> left, Vector64<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005636 RID: 22070 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<sbyte> MultiplySubtract(Vector64<sbyte> minuend, Vector64<sbyte> left, Vector64<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005637 RID: 22071 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ushort> MultiplySubtract(Vector64<ushort> minuend, Vector64<ushort> left, Vector64<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005638 RID: 22072 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> MultiplySubtract(Vector64<uint> minuend, Vector64<uint> left, Vector64<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005639 RID: 22073 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> MultiplySubtract(Vector128<byte> minuend, Vector128<byte> left, Vector128<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600563A RID: 22074 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> MultiplySubtract(Vector128<short> minuend, Vector128<short> left, Vector128<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600563B RID: 22075 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> MultiplySubtract(Vector128<int> minuend, Vector128<int> left, Vector128<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600563C RID: 22076 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> MultiplySubtract(Vector128<sbyte> minuend, Vector128<sbyte> left, Vector128<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600563D RID: 22077 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> MultiplySubtract(Vector128<ushort> minuend, Vector128<ushort> left, Vector128<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600563E RID: 22078 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> MultiplySubtract(Vector128<uint> minuend, Vector128<uint> left, Vector128<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600563F RID: 22079 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> MultiplySubtractByScalar(Vector64<short> minuend, Vector64<short> left, Vector64<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005640 RID: 22080 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> MultiplySubtractByScalar(Vector64<int> minuend, Vector64<int> left, Vector64<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005641 RID: 22081 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ushort> MultiplySubtractByScalar(Vector64<ushort> minuend, Vector64<ushort> left, Vector64<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005642 RID: 22082 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> MultiplySubtractByScalar(Vector64<uint> minuend, Vector64<uint> left, Vector64<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005643 RID: 22083 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> MultiplySubtractByScalar(Vector128<short> minuend, Vector128<short> left, Vector64<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005644 RID: 22084 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> MultiplySubtractByScalar(Vector128<int> minuend, Vector128<int> left, Vector64<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005645 RID: 22085 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> MultiplySubtractByScalar(Vector128<ushort> minuend, Vector128<ushort> left, Vector64<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005646 RID: 22086 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> MultiplySubtractByScalar(Vector128<uint> minuend, Vector128<uint> left, Vector64<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005647 RID: 22087 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> MultiplySubtractBySelectedScalar(Vector64<short> minuend, Vector64<short> left, Vector64<short> right, [ConstantExpected(Max = 3)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005648 RID: 22088 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> MultiplySubtractBySelectedScalar(Vector64<short> minuend, Vector64<short> left, Vector128<short> right, [ConstantExpected(Max = 7)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005649 RID: 22089 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> MultiplySubtractBySelectedScalar(Vector64<int> minuend, Vector64<int> left, Vector64<int> right, [ConstantExpected(Max = 1)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600564A RID: 22090 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> MultiplySubtractBySelectedScalar(Vector64<int> minuend, Vector64<int> left, Vector128<int> right, [ConstantExpected(Max = 3)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600564B RID: 22091 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ushort> MultiplySubtractBySelectedScalar(Vector64<ushort> minuend, Vector64<ushort> left, Vector64<ushort> right, [ConstantExpected(Max = 3)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600564C RID: 22092 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ushort> MultiplySubtractBySelectedScalar(Vector64<ushort> minuend, Vector64<ushort> left, Vector128<ushort> right, [ConstantExpected(Max = 7)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600564D RID: 22093 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> MultiplySubtractBySelectedScalar(Vector64<uint> minuend, Vector64<uint> left, Vector64<uint> right, [ConstantExpected(Max = 1)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600564E RID: 22094 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> MultiplySubtractBySelectedScalar(Vector64<uint> minuend, Vector64<uint> left, Vector128<uint> right, [ConstantExpected(Max = 3)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600564F RID: 22095 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> MultiplySubtractBySelectedScalar(Vector128<short> minuend, Vector128<short> left, Vector64<short> right, [ConstantExpected(Max = 3)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005650 RID: 22096 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> MultiplySubtractBySelectedScalar(Vector128<short> minuend, Vector128<short> left, Vector128<short> right, [ConstantExpected(Max = 7)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005651 RID: 22097 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> MultiplySubtractBySelectedScalar(Vector128<int> minuend, Vector128<int> left, Vector64<int> right, [ConstantExpected(Max = 1)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005652 RID: 22098 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> MultiplySubtractBySelectedScalar(Vector128<int> minuend, Vector128<int> left, Vector128<int> right, [ConstantExpected(Max = 3)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005653 RID: 22099 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> MultiplySubtractBySelectedScalar(Vector128<ushort> minuend, Vector128<ushort> left, Vector64<ushort> right, [ConstantExpected(Max = 3)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005654 RID: 22100 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> MultiplySubtractBySelectedScalar(Vector128<ushort> minuend, Vector128<ushort> left, Vector128<ushort> right, [ConstantExpected(Max = 7)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005655 RID: 22101 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> MultiplySubtractBySelectedScalar(Vector128<uint> minuend, Vector128<uint> left, Vector64<uint> right, [ConstantExpected(Max = 1)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005656 RID: 22102 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> MultiplySubtractBySelectedScalar(Vector128<uint> minuend, Vector128<uint> left, Vector128<uint> right, [ConstantExpected(Max = 3)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005657 RID: 22103 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> MultiplyWideningLower(Vector64<byte> left, Vector64<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005658 RID: 22104 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> MultiplyWideningLower(Vector64<short> left, Vector64<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005659 RID: 22105 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> MultiplyWideningLower(Vector64<int> left, Vector64<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600565A RID: 22106 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> MultiplyWideningLower(Vector64<sbyte> left, Vector64<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600565B RID: 22107 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> MultiplyWideningLower(Vector64<ushort> left, Vector64<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600565C RID: 22108 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> MultiplyWideningLower(Vector64<uint> left, Vector64<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600565D RID: 22109 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> MultiplyWideningLowerAndAdd(Vector128<ushort> addend, Vector64<byte> left, Vector64<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600565E RID: 22110 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> MultiplyWideningLowerAndAdd(Vector128<int> addend, Vector64<short> left, Vector64<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600565F RID: 22111 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> MultiplyWideningLowerAndAdd(Vector128<long> addend, Vector64<int> left, Vector64<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005660 RID: 22112 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> MultiplyWideningLowerAndAdd(Vector128<short> addend, Vector64<sbyte> left, Vector64<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005661 RID: 22113 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> MultiplyWideningLowerAndAdd(Vector128<uint> addend, Vector64<ushort> left, Vector64<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005662 RID: 22114 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> MultiplyWideningLowerAndAdd(Vector128<ulong> addend, Vector64<uint> left, Vector64<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005663 RID: 22115 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> MultiplyWideningLowerAndSubtract(Vector128<ushort> minuend, Vector64<byte> left, Vector64<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005664 RID: 22116 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> MultiplyWideningLowerAndSubtract(Vector128<int> minuend, Vector64<short> left, Vector64<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005665 RID: 22117 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> MultiplyWideningLowerAndSubtract(Vector128<long> minuend, Vector64<int> left, Vector64<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005666 RID: 22118 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> MultiplyWideningLowerAndSubtract(Vector128<short> minuend, Vector64<sbyte> left, Vector64<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005667 RID: 22119 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> MultiplyWideningLowerAndSubtract(Vector128<uint> minuend, Vector64<ushort> left, Vector64<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005668 RID: 22120 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> MultiplyWideningLowerAndSubtract(Vector128<ulong> minuend, Vector64<uint> left, Vector64<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005669 RID: 22121 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> MultiplyWideningUpper(Vector128<byte> left, Vector128<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600566A RID: 22122 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> MultiplyWideningUpper(Vector128<short> left, Vector128<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600566B RID: 22123 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> MultiplyWideningUpper(Vector128<int> left, Vector128<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600566C RID: 22124 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> MultiplyWideningUpper(Vector128<sbyte> left, Vector128<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600566D RID: 22125 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> MultiplyWideningUpper(Vector128<ushort> left, Vector128<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600566E RID: 22126 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> MultiplyWideningUpper(Vector128<uint> left, Vector128<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600566F RID: 22127 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> MultiplyWideningUpperAndAdd(Vector128<ushort> addend, Vector128<byte> left, Vector128<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005670 RID: 22128 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> MultiplyWideningUpperAndAdd(Vector128<int> addend, Vector128<short> left, Vector128<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005671 RID: 22129 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> MultiplyWideningUpperAndAdd(Vector128<long> addend, Vector128<int> left, Vector128<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005672 RID: 22130 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> MultiplyWideningUpperAndAdd(Vector128<short> addend, Vector128<sbyte> left, Vector128<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005673 RID: 22131 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> MultiplyWideningUpperAndAdd(Vector128<uint> addend, Vector128<ushort> left, Vector128<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005674 RID: 22132 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> MultiplyWideningUpperAndAdd(Vector128<ulong> addend, Vector128<uint> left, Vector128<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005675 RID: 22133 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> MultiplyWideningUpperAndSubtract(Vector128<ushort> minuend, Vector128<byte> left, Vector128<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005676 RID: 22134 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> MultiplyWideningUpperAndSubtract(Vector128<int> minuend, Vector128<short> left, Vector128<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005677 RID: 22135 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> MultiplyWideningUpperAndSubtract(Vector128<long> minuend, Vector128<int> left, Vector128<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005678 RID: 22136 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> MultiplyWideningUpperAndSubtract(Vector128<short> minuend, Vector128<sbyte> left, Vector128<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005679 RID: 22137 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> MultiplyWideningUpperAndSubtract(Vector128<uint> minuend, Vector128<ushort> left, Vector128<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600567A RID: 22138 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> MultiplyWideningUpperAndSubtract(Vector128<ulong> minuend, Vector128<uint> left, Vector128<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600567B RID: 22139 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> Negate(Vector64<short> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600567C RID: 22140 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> Negate(Vector64<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600567D RID: 22141 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<sbyte> Negate(Vector64<sbyte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600567E RID: 22142 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<float> Negate(Vector64<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600567F RID: 22143 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> Negate(Vector128<short> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005680 RID: 22144 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> Negate(Vector128<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005681 RID: 22145 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> Negate(Vector128<sbyte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005682 RID: 22146 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> Negate(Vector128<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005683 RID: 22147 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> NegateSaturate(Vector64<short> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005684 RID: 22148 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> NegateSaturate(Vector64<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005685 RID: 22149 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<sbyte> NegateSaturate(Vector64<sbyte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005686 RID: 22150 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> NegateSaturate(Vector128<short> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005687 RID: 22151 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> NegateSaturate(Vector128<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005688 RID: 22152 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> NegateSaturate(Vector128<sbyte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005689 RID: 22153 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<double> NegateScalar(Vector64<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600568A RID: 22154 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<float> NegateScalar(Vector64<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600568B RID: 22155 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<byte> Not(Vector64<byte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600568C RID: 22156 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<double> Not(Vector64<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600568D RID: 22157 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> Not(Vector64<short> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600568E RID: 22158 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> Not(Vector64<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600568F RID: 22159 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<long> Not(Vector64<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005690 RID: 22160 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<sbyte> Not(Vector64<sbyte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005691 RID: 22161 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<float> Not(Vector64<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005692 RID: 22162 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ushort> Not(Vector64<ushort> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005693 RID: 22163 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> Not(Vector64<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005694 RID: 22164 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ulong> Not(Vector64<ulong> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005695 RID: 22165 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> Not(Vector128<byte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005696 RID: 22166 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> Not(Vector128<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005697 RID: 22167 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> Not(Vector128<short> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005698 RID: 22168 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> Not(Vector128<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005699 RID: 22169 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> Not(Vector128<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600569A RID: 22170 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> Not(Vector128<sbyte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600569B RID: 22171 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> Not(Vector128<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600569C RID: 22172 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> Not(Vector128<ushort> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600569D RID: 22173 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> Not(Vector128<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600569E RID: 22174 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> Not(Vector128<ulong> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600569F RID: 22175 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<byte> Or(Vector64<byte> left, Vector64<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056A0 RID: 22176 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<double> Or(Vector64<double> left, Vector64<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056A1 RID: 22177 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> Or(Vector64<short> left, Vector64<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056A2 RID: 22178 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> Or(Vector64<int> left, Vector64<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056A3 RID: 22179 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<long> Or(Vector64<long> left, Vector64<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056A4 RID: 22180 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<sbyte> Or(Vector64<sbyte> left, Vector64<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056A5 RID: 22181 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<float> Or(Vector64<float> left, Vector64<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056A6 RID: 22182 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ushort> Or(Vector64<ushort> left, Vector64<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056A7 RID: 22183 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> Or(Vector64<uint> left, Vector64<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056A8 RID: 22184 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ulong> Or(Vector64<ulong> left, Vector64<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056A9 RID: 22185 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> Or(Vector128<byte> left, Vector128<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056AA RID: 22186 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> Or(Vector128<double> left, Vector128<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056AB RID: 22187 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> Or(Vector128<short> left, Vector128<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056AC RID: 22188 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> Or(Vector128<int> left, Vector128<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056AD RID: 22189 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> Or(Vector128<long> left, Vector128<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056AE RID: 22190 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> Or(Vector128<sbyte> left, Vector128<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056AF RID: 22191 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> Or(Vector128<float> left, Vector128<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056B0 RID: 22192 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> Or(Vector128<ushort> left, Vector128<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056B1 RID: 22193 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> Or(Vector128<uint> left, Vector128<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056B2 RID: 22194 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> Or(Vector128<ulong> left, Vector128<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056B3 RID: 22195 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<byte> OrNot(Vector64<byte> left, Vector64<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056B4 RID: 22196 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<double> OrNot(Vector64<double> left, Vector64<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056B5 RID: 22197 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> OrNot(Vector64<short> left, Vector64<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056B6 RID: 22198 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> OrNot(Vector64<int> left, Vector64<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056B7 RID: 22199 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<long> OrNot(Vector64<long> left, Vector64<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056B8 RID: 22200 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<sbyte> OrNot(Vector64<sbyte> left, Vector64<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056B9 RID: 22201 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<float> OrNot(Vector64<float> left, Vector64<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056BA RID: 22202 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ushort> OrNot(Vector64<ushort> left, Vector64<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056BB RID: 22203 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> OrNot(Vector64<uint> left, Vector64<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056BC RID: 22204 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ulong> OrNot(Vector64<ulong> left, Vector64<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056BD RID: 22205 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> OrNot(Vector128<byte> left, Vector128<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056BE RID: 22206 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> OrNot(Vector128<double> left, Vector128<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056BF RID: 22207 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> OrNot(Vector128<short> left, Vector128<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056C0 RID: 22208 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> OrNot(Vector128<int> left, Vector128<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056C1 RID: 22209 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> OrNot(Vector128<long> left, Vector128<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056C2 RID: 22210 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> OrNot(Vector128<sbyte> left, Vector128<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056C3 RID: 22211 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> OrNot(Vector128<float> left, Vector128<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056C4 RID: 22212 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> OrNot(Vector128<ushort> left, Vector128<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056C5 RID: 22213 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> OrNot(Vector128<uint> left, Vector128<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056C6 RID: 22214 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> OrNot(Vector128<ulong> left, Vector128<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056C7 RID: 22215 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<byte> PolynomialMultiply(Vector64<byte> left, Vector64<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056C8 RID: 22216 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<sbyte> PolynomialMultiply(Vector64<sbyte> left, Vector64<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056C9 RID: 22217 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> PolynomialMultiply(Vector128<byte> left, Vector128<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056CA RID: 22218 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> PolynomialMultiply(Vector128<sbyte> left, Vector128<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056CB RID: 22219 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> PolynomialMultiplyWideningLower(Vector64<byte> left, Vector64<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056CC RID: 22220 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> PolynomialMultiplyWideningLower(Vector64<sbyte> left, Vector64<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056CD RID: 22221 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> PolynomialMultiplyWideningUpper(Vector128<byte> left, Vector128<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056CE RID: 22222 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> PolynomialMultiplyWideningUpper(Vector128<sbyte> left, Vector128<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056CF RID: 22223 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<byte> PopCount(Vector64<byte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056D0 RID: 22224 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<sbyte> PopCount(Vector64<sbyte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056D1 RID: 22225 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> PopCount(Vector128<byte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056D2 RID: 22226 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> PopCount(Vector128<sbyte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056D3 RID: 22227 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<float> ReciprocalEstimate(Vector64<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056D4 RID: 22228 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> ReciprocalEstimate(Vector64<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056D5 RID: 22229 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> ReciprocalEstimate(Vector128<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056D6 RID: 22230 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> ReciprocalEstimate(Vector128<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056D7 RID: 22231 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<float> ReciprocalSquareRootEstimate(Vector64<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056D8 RID: 22232 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> ReciprocalSquareRootEstimate(Vector64<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056D9 RID: 22233 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> ReciprocalSquareRootEstimate(Vector128<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056DA RID: 22234 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> ReciprocalSquareRootEstimate(Vector128<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056DB RID: 22235 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<float> ReciprocalSquareRootStep(Vector64<float> left, Vector64<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056DC RID: 22236 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> ReciprocalSquareRootStep(Vector128<float> left, Vector128<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056DD RID: 22237 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<float> ReciprocalStep(Vector64<float> left, Vector64<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056DE RID: 22238 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> ReciprocalStep(Vector128<float> left, Vector128<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056DF RID: 22239 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> ReverseElement16(Vector64<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056E0 RID: 22240 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<long> ReverseElement16(Vector64<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056E1 RID: 22241 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> ReverseElement16(Vector64<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056E2 RID: 22242 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ulong> ReverseElement16(Vector64<ulong> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056E3 RID: 22243 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> ReverseElement16(Vector128<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056E4 RID: 22244 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> ReverseElement16(Vector128<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056E5 RID: 22245 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> ReverseElement16(Vector128<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056E6 RID: 22246 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> ReverseElement16(Vector128<ulong> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056E7 RID: 22247 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<long> ReverseElement32(Vector64<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056E8 RID: 22248 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ulong> ReverseElement32(Vector64<ulong> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056E9 RID: 22249 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> ReverseElement32(Vector128<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056EA RID: 22250 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> ReverseElement32(Vector128<ulong> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056EB RID: 22251 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> ReverseElement8(Vector64<short> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056EC RID: 22252 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> ReverseElement8(Vector64<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056ED RID: 22253 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<long> ReverseElement8(Vector64<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056EE RID: 22254 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ushort> ReverseElement8(Vector64<ushort> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056EF RID: 22255 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> ReverseElement8(Vector64<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056F0 RID: 22256 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ulong> ReverseElement8(Vector64<ulong> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056F1 RID: 22257 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> ReverseElement8(Vector128<short> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056F2 RID: 22258 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> ReverseElement8(Vector128<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056F3 RID: 22259 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> ReverseElement8(Vector128<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056F4 RID: 22260 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> ReverseElement8(Vector128<ushort> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056F5 RID: 22261 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> ReverseElement8(Vector128<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056F6 RID: 22262 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> ReverseElement8(Vector128<ulong> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056F7 RID: 22263 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<float> RoundAwayFromZero(Vector64<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056F8 RID: 22264 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> RoundAwayFromZero(Vector128<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056F9 RID: 22265 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<double> RoundAwayFromZeroScalar(Vector64<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056FA RID: 22266 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<float> RoundAwayFromZeroScalar(Vector64<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056FB RID: 22267 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<float> RoundToNearest(Vector64<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056FC RID: 22268 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> RoundToNearest(Vector128<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056FD RID: 22269 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<double> RoundToNearestScalar(Vector64<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056FE RID: 22270 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<float> RoundToNearestScalar(Vector64<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060056FF RID: 22271 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<float> RoundToNegativeInfinity(Vector64<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005700 RID: 22272 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> RoundToNegativeInfinity(Vector128<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005701 RID: 22273 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<double> RoundToNegativeInfinityScalar(Vector64<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005702 RID: 22274 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<float> RoundToNegativeInfinityScalar(Vector64<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005703 RID: 22275 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<float> RoundToPositiveInfinity(Vector64<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005704 RID: 22276 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> RoundToPositiveInfinity(Vector128<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005705 RID: 22277 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<double> RoundToPositiveInfinityScalar(Vector64<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005706 RID: 22278 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<float> RoundToPositiveInfinityScalar(Vector64<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005707 RID: 22279 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<float> RoundToZero(Vector64<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005708 RID: 22280 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> RoundToZero(Vector128<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005709 RID: 22281 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<double> RoundToZeroScalar(Vector64<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600570A RID: 22282 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<float> RoundToZeroScalar(Vector64<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600570B RID: 22283 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> ShiftArithmetic(Vector64<short> value, Vector64<short> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600570C RID: 22284 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> ShiftArithmetic(Vector64<int> value, Vector64<int> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600570D RID: 22285 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<sbyte> ShiftArithmetic(Vector64<sbyte> value, Vector64<sbyte> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600570E RID: 22286 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> ShiftArithmetic(Vector128<short> value, Vector128<short> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600570F RID: 22287 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> ShiftArithmetic(Vector128<int> value, Vector128<int> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005710 RID: 22288 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> ShiftArithmetic(Vector128<long> value, Vector128<long> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005711 RID: 22289 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> ShiftArithmetic(Vector128<sbyte> value, Vector128<sbyte> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005712 RID: 22290 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> ShiftArithmeticRounded(Vector64<short> value, Vector64<short> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005713 RID: 22291 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> ShiftArithmeticRounded(Vector64<int> value, Vector64<int> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005714 RID: 22292 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<sbyte> ShiftArithmeticRounded(Vector64<sbyte> value, Vector64<sbyte> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005715 RID: 22293 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> ShiftArithmeticRounded(Vector128<short> value, Vector128<short> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005716 RID: 22294 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> ShiftArithmeticRounded(Vector128<int> value, Vector128<int> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005717 RID: 22295 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> ShiftArithmeticRounded(Vector128<long> value, Vector128<long> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005718 RID: 22296 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> ShiftArithmeticRounded(Vector128<sbyte> value, Vector128<sbyte> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005719 RID: 22297 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> ShiftArithmeticRoundedSaturate(Vector64<short> value, Vector64<short> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600571A RID: 22298 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> ShiftArithmeticRoundedSaturate(Vector64<int> value, Vector64<int> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600571B RID: 22299 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<sbyte> ShiftArithmeticRoundedSaturate(Vector64<sbyte> value, Vector64<sbyte> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600571C RID: 22300 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> ShiftArithmeticRoundedSaturate(Vector128<short> value, Vector128<short> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600571D RID: 22301 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> ShiftArithmeticRoundedSaturate(Vector128<int> value, Vector128<int> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600571E RID: 22302 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> ShiftArithmeticRoundedSaturate(Vector128<long> value, Vector128<long> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600571F RID: 22303 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> ShiftArithmeticRoundedSaturate(Vector128<sbyte> value, Vector128<sbyte> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005720 RID: 22304 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<long> ShiftArithmeticRoundedSaturateScalar(Vector64<long> value, Vector64<long> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005721 RID: 22305 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<long> ShiftArithmeticRoundedScalar(Vector64<long> value, Vector64<long> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005722 RID: 22306 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> ShiftArithmeticSaturate(Vector64<short> value, Vector64<short> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005723 RID: 22307 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> ShiftArithmeticSaturate(Vector64<int> value, Vector64<int> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005724 RID: 22308 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<sbyte> ShiftArithmeticSaturate(Vector64<sbyte> value, Vector64<sbyte> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005725 RID: 22309 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> ShiftArithmeticSaturate(Vector128<short> value, Vector128<short> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005726 RID: 22310 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> ShiftArithmeticSaturate(Vector128<int> value, Vector128<int> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005727 RID: 22311 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> ShiftArithmeticSaturate(Vector128<long> value, Vector128<long> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005728 RID: 22312 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> ShiftArithmeticSaturate(Vector128<sbyte> value, Vector128<sbyte> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005729 RID: 22313 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<long> ShiftArithmeticSaturateScalar(Vector64<long> value, Vector64<long> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600572A RID: 22314 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<long> ShiftArithmeticScalar(Vector64<long> value, Vector64<long> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600572B RID: 22315 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<byte> ShiftLeftAndInsert(Vector64<byte> left, Vector64<byte> right, [ConstantExpected(Max = 7)] byte shift)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600572C RID: 22316 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> ShiftLeftAndInsert(Vector64<short> left, Vector64<short> right, [ConstantExpected(Max = 15)] byte shift)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600572D RID: 22317 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> ShiftLeftAndInsert(Vector64<int> left, Vector64<int> right, [ConstantExpected(Max = 31)] byte shift)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600572E RID: 22318 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<sbyte> ShiftLeftAndInsert(Vector64<sbyte> left, Vector64<sbyte> right, [ConstantExpected(Max = 7)] byte shift)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600572F RID: 22319 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ushort> ShiftLeftAndInsert(Vector64<ushort> left, Vector64<ushort> right, [ConstantExpected(Max = 15)] byte shift)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005730 RID: 22320 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> ShiftLeftAndInsert(Vector64<uint> left, Vector64<uint> right, [ConstantExpected(Max = 31)] byte shift)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005731 RID: 22321 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> ShiftLeftAndInsert(Vector128<byte> left, Vector128<byte> right, [ConstantExpected(Max = 7)] byte shift)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005732 RID: 22322 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> ShiftLeftAndInsert(Vector128<short> left, Vector128<short> right, [ConstantExpected(Max = 15)] byte shift)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005733 RID: 22323 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> ShiftLeftAndInsert(Vector128<int> left, Vector128<int> right, [ConstantExpected(Max = 31)] byte shift)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005734 RID: 22324 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> ShiftLeftAndInsert(Vector128<long> left, Vector128<long> right, [ConstantExpected(Max = 63)] byte shift)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005735 RID: 22325 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> ShiftLeftAndInsert(Vector128<sbyte> left, Vector128<sbyte> right, [ConstantExpected(Max = 7)] byte shift)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005736 RID: 22326 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> ShiftLeftAndInsert(Vector128<ushort> left, Vector128<ushort> right, [ConstantExpected(Max = 15)] byte shift)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005737 RID: 22327 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> ShiftLeftAndInsert(Vector128<uint> left, Vector128<uint> right, [ConstantExpected(Max = 31)] byte shift)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005738 RID: 22328 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> ShiftLeftAndInsert(Vector128<ulong> left, Vector128<ulong> right, [ConstantExpected(Max = 63)] byte shift)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005739 RID: 22329 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<long> ShiftLeftAndInsertScalar(Vector64<long> left, Vector64<long> right, [ConstantExpected(Max = 63)] byte shift)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600573A RID: 22330 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ulong> ShiftLeftAndInsertScalar(Vector64<ulong> left, Vector64<ulong> right, [ConstantExpected(Max = 63)] byte shift)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600573B RID: 22331 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<byte> ShiftLeftLogical(Vector64<byte> value, [ConstantExpected(Max = 7)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600573C RID: 22332 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> ShiftLeftLogical(Vector64<short> value, [ConstantExpected(Max = 15)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600573D RID: 22333 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> ShiftLeftLogical(Vector64<int> value, [ConstantExpected(Max = 31)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600573E RID: 22334 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<sbyte> ShiftLeftLogical(Vector64<sbyte> value, [ConstantExpected(Max = 7)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600573F RID: 22335 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ushort> ShiftLeftLogical(Vector64<ushort> value, [ConstantExpected(Max = 15)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005740 RID: 22336 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> ShiftLeftLogical(Vector64<uint> value, [ConstantExpected(Max = 31)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005741 RID: 22337 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> ShiftLeftLogical(Vector128<byte> value, [ConstantExpected(Max = 7)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005742 RID: 22338 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> ShiftLeftLogical(Vector128<short> value, [ConstantExpected(Max = 15)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005743 RID: 22339 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> ShiftLeftLogical(Vector128<long> value, [ConstantExpected(Max = 63)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005744 RID: 22340 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> ShiftLeftLogical(Vector128<sbyte> value, [ConstantExpected(Max = 7)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005745 RID: 22341 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> ShiftLeftLogical(Vector128<ushort> value, [ConstantExpected(Max = 15)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005746 RID: 22342 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> ShiftLeftLogical(Vector128<uint> value, [ConstantExpected(Max = 31)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005747 RID: 22343 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> ShiftLeftLogical(Vector128<ulong> value, [ConstantExpected(Max = 63)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005748 RID: 22344 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<byte> ShiftLeftLogicalSaturate(Vector64<byte> value, [ConstantExpected(Max = 7)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005749 RID: 22345 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> ShiftLeftLogicalSaturate(Vector64<short> value, [ConstantExpected(Max = 15)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600574A RID: 22346 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> ShiftLeftLogicalSaturate(Vector64<int> value, [ConstantExpected(Max = 31)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600574B RID: 22347 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<sbyte> ShiftLeftLogicalSaturate(Vector64<sbyte> value, [ConstantExpected(Max = 7)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600574C RID: 22348 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ushort> ShiftLeftLogicalSaturate(Vector64<ushort> value, [ConstantExpected(Max = 15)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600574D RID: 22349 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> ShiftLeftLogicalSaturate(Vector64<uint> value, [ConstantExpected(Max = 31)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600574E RID: 22350 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> ShiftLeftLogicalSaturate(Vector128<byte> value, [ConstantExpected(Max = 7)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600574F RID: 22351 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> ShiftLeftLogicalSaturate(Vector128<short> value, [ConstantExpected(Max = 15)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005750 RID: 22352 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> ShiftLeftLogicalSaturate(Vector128<int> value, [ConstantExpected(Max = 31)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005751 RID: 22353 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> ShiftLeftLogicalSaturate(Vector128<long> value, [ConstantExpected(Max = 63)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005752 RID: 22354 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> ShiftLeftLogicalSaturate(Vector128<sbyte> value, [ConstantExpected(Max = 7)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005753 RID: 22355 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> ShiftLeftLogicalSaturate(Vector128<ushort> value, [ConstantExpected(Max = 15)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005754 RID: 22356 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> ShiftLeftLogicalSaturate(Vector128<uint> value, [ConstantExpected(Max = 31)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005755 RID: 22357 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> ShiftLeftLogicalSaturate(Vector128<ulong> value, [ConstantExpected(Max = 63)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005756 RID: 22358 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<long> ShiftLeftLogicalSaturateScalar(Vector64<long> value, [ConstantExpected(Max = 63)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005757 RID: 22359 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ulong> ShiftLeftLogicalSaturateScalar(Vector64<ulong> value, [ConstantExpected(Max = 63)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005758 RID: 22360 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ushort> ShiftLeftLogicalSaturateUnsigned(Vector64<short> value, [ConstantExpected(Max = 15)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005759 RID: 22361 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> ShiftLeftLogicalSaturateUnsigned(Vector64<int> value, [ConstantExpected(Max = 31)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600575A RID: 22362 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<byte> ShiftLeftLogicalSaturateUnsigned(Vector64<sbyte> value, [ConstantExpected(Max = 7)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600575B RID: 22363 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> ShiftLeftLogicalSaturateUnsigned(Vector128<short> value, [ConstantExpected(Max = 15)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600575C RID: 22364 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> ShiftLeftLogicalSaturateUnsigned(Vector128<int> value, [ConstantExpected(Max = 31)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600575D RID: 22365 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> ShiftLeftLogicalSaturateUnsigned(Vector128<long> value, [ConstantExpected(Max = 63)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600575E RID: 22366 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> ShiftLeftLogicalSaturateUnsigned(Vector128<sbyte> value, [ConstantExpected(Max = 7)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600575F RID: 22367 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ulong> ShiftLeftLogicalSaturateUnsignedScalar(Vector64<long> value, [ConstantExpected(Max = 63)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005760 RID: 22368 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<long> ShiftLeftLogicalScalar(Vector64<long> value, [ConstantExpected(Max = 63)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005761 RID: 22369 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ulong> ShiftLeftLogicalScalar(Vector64<ulong> value, [ConstantExpected(Max = 63)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005762 RID: 22370 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> ShiftLeftLogicalWideningLower(Vector64<byte> value, [ConstantExpected(Max = 7)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005763 RID: 22371 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> ShiftLeftLogicalWideningLower(Vector64<short> value, [ConstantExpected(Max = 15)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005764 RID: 22372 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> ShiftLeftLogicalWideningLower(Vector64<int> value, [ConstantExpected(Max = 31)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005765 RID: 22373 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> ShiftLeftLogicalWideningLower(Vector64<sbyte> value, [ConstantExpected(Max = 7)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005766 RID: 22374 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> ShiftLeftLogicalWideningLower(Vector64<ushort> value, [ConstantExpected(Max = 15)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005767 RID: 22375 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> ShiftLeftLogicalWideningLower(Vector64<uint> value, [ConstantExpected(Max = 31)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005768 RID: 22376 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> ShiftLeftLogicalWideningUpper(Vector128<byte> value, [ConstantExpected(Max = 7)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005769 RID: 22377 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> ShiftLeftLogicalWideningUpper(Vector128<short> value, [ConstantExpected(Max = 15)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600576A RID: 22378 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> ShiftLeftLogicalWideningUpper(Vector128<int> value, [ConstantExpected(Max = 31)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600576B RID: 22379 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> ShiftLeftLogicalWideningUpper(Vector128<sbyte> value, [ConstantExpected(Max = 7)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600576C RID: 22380 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> ShiftLeftLogicalWideningUpper(Vector128<ushort> value, [ConstantExpected(Max = 15)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600576D RID: 22381 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> ShiftLeftLogicalWideningUpper(Vector128<uint> value, [ConstantExpected(Max = 31)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600576E RID: 22382 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<byte> ShiftLogical(Vector64<byte> value, Vector64<sbyte> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600576F RID: 22383 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> ShiftLogical(Vector64<short> value, Vector64<short> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005770 RID: 22384 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> ShiftLogical(Vector64<int> value, Vector64<int> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005771 RID: 22385 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<sbyte> ShiftLogical(Vector64<sbyte> value, Vector64<sbyte> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005772 RID: 22386 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ushort> ShiftLogical(Vector64<ushort> value, Vector64<short> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005773 RID: 22387 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> ShiftLogical(Vector64<uint> value, Vector64<int> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005774 RID: 22388 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> ShiftLogical(Vector128<byte> value, Vector128<sbyte> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005775 RID: 22389 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> ShiftLogical(Vector128<short> value, Vector128<short> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005776 RID: 22390 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> ShiftLogical(Vector128<int> value, Vector128<int> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005777 RID: 22391 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> ShiftLogical(Vector128<long> value, Vector128<long> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005778 RID: 22392 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> ShiftLogical(Vector128<sbyte> value, Vector128<sbyte> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005779 RID: 22393 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> ShiftLogical(Vector128<ushort> value, Vector128<short> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600577A RID: 22394 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> ShiftLogical(Vector128<uint> value, Vector128<int> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600577B RID: 22395 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> ShiftLogical(Vector128<ulong> value, Vector128<long> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600577C RID: 22396 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<byte> ShiftLogicalRounded(Vector64<byte> value, Vector64<sbyte> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600577D RID: 22397 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> ShiftLogicalRounded(Vector64<short> value, Vector64<short> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600577E RID: 22398 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> ShiftLogicalRounded(Vector64<int> value, Vector64<int> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600577F RID: 22399 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<sbyte> ShiftLogicalRounded(Vector64<sbyte> value, Vector64<sbyte> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005780 RID: 22400 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ushort> ShiftLogicalRounded(Vector64<ushort> value, Vector64<short> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005781 RID: 22401 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> ShiftLogicalRounded(Vector64<uint> value, Vector64<int> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005782 RID: 22402 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> ShiftLogicalRounded(Vector128<byte> value, Vector128<sbyte> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005783 RID: 22403 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> ShiftLogicalRounded(Vector128<short> value, Vector128<short> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005784 RID: 22404 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> ShiftLogicalRounded(Vector128<int> value, Vector128<int> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005785 RID: 22405 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> ShiftLogicalRounded(Vector128<long> value, Vector128<long> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005786 RID: 22406 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> ShiftLogicalRounded(Vector128<sbyte> value, Vector128<sbyte> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005787 RID: 22407 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> ShiftLogicalRounded(Vector128<ushort> value, Vector128<short> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005788 RID: 22408 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> ShiftLogicalRounded(Vector128<uint> value, Vector128<int> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005789 RID: 22409 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> ShiftLogicalRounded(Vector128<ulong> value, Vector128<long> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600578A RID: 22410 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<byte> ShiftLogicalRoundedSaturate(Vector64<byte> value, Vector64<sbyte> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600578B RID: 22411 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> ShiftLogicalRoundedSaturate(Vector64<short> value, Vector64<short> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600578C RID: 22412 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> ShiftLogicalRoundedSaturate(Vector64<int> value, Vector64<int> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600578D RID: 22413 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<sbyte> ShiftLogicalRoundedSaturate(Vector64<sbyte> value, Vector64<sbyte> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600578E RID: 22414 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ushort> ShiftLogicalRoundedSaturate(Vector64<ushort> value, Vector64<short> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600578F RID: 22415 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> ShiftLogicalRoundedSaturate(Vector64<uint> value, Vector64<int> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005790 RID: 22416 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> ShiftLogicalRoundedSaturate(Vector128<byte> value, Vector128<sbyte> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005791 RID: 22417 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> ShiftLogicalRoundedSaturate(Vector128<short> value, Vector128<short> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005792 RID: 22418 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> ShiftLogicalRoundedSaturate(Vector128<int> value, Vector128<int> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005793 RID: 22419 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> ShiftLogicalRoundedSaturate(Vector128<long> value, Vector128<long> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005794 RID: 22420 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> ShiftLogicalRoundedSaturate(Vector128<sbyte> value, Vector128<sbyte> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005795 RID: 22421 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> ShiftLogicalRoundedSaturate(Vector128<ushort> value, Vector128<short> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005796 RID: 22422 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> ShiftLogicalRoundedSaturate(Vector128<uint> value, Vector128<int> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005797 RID: 22423 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> ShiftLogicalRoundedSaturate(Vector128<ulong> value, Vector128<long> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005798 RID: 22424 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<long> ShiftLogicalRoundedSaturateScalar(Vector64<long> value, Vector64<long> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005799 RID: 22425 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ulong> ShiftLogicalRoundedSaturateScalar(Vector64<ulong> value, Vector64<long> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600579A RID: 22426 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<long> ShiftLogicalRoundedScalar(Vector64<long> value, Vector64<long> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600579B RID: 22427 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ulong> ShiftLogicalRoundedScalar(Vector64<ulong> value, Vector64<long> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600579C RID: 22428 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<byte> ShiftLogicalSaturate(Vector64<byte> value, Vector64<sbyte> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600579D RID: 22429 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> ShiftLogicalSaturate(Vector64<short> value, Vector64<short> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600579E RID: 22430 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> ShiftLogicalSaturate(Vector64<int> value, Vector64<int> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600579F RID: 22431 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<sbyte> ShiftLogicalSaturate(Vector64<sbyte> value, Vector64<sbyte> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057A0 RID: 22432 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ushort> ShiftLogicalSaturate(Vector64<ushort> value, Vector64<short> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057A1 RID: 22433 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> ShiftLogicalSaturate(Vector64<uint> value, Vector64<int> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057A2 RID: 22434 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> ShiftLogicalSaturate(Vector128<byte> value, Vector128<sbyte> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057A3 RID: 22435 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> ShiftLogicalSaturate(Vector128<short> value, Vector128<short> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057A4 RID: 22436 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> ShiftLogicalSaturate(Vector128<int> value, Vector128<int> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057A5 RID: 22437 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> ShiftLogicalSaturate(Vector128<long> value, Vector128<long> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057A6 RID: 22438 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> ShiftLogicalSaturate(Vector128<sbyte> value, Vector128<sbyte> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057A7 RID: 22439 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> ShiftLogicalSaturate(Vector128<ushort> value, Vector128<short> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057A8 RID: 22440 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> ShiftLogicalSaturate(Vector128<uint> value, Vector128<int> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057A9 RID: 22441 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> ShiftLogicalSaturate(Vector128<ulong> value, Vector128<long> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057AA RID: 22442 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<long> ShiftLogicalSaturateScalar(Vector64<long> value, Vector64<long> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057AB RID: 22443 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ulong> ShiftLogicalSaturateScalar(Vector64<ulong> value, Vector64<long> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057AC RID: 22444 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<long> ShiftLogicalScalar(Vector64<long> value, Vector64<long> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057AD RID: 22445 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ulong> ShiftLogicalScalar(Vector64<ulong> value, Vector64<long> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057AE RID: 22446 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<byte> ShiftRightAndInsert(Vector64<byte> left, Vector64<byte> right, [ConstantExpected(Min = 1, Max = 8)] byte shift)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057AF RID: 22447 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> ShiftRightAndInsert(Vector64<short> left, Vector64<short> right, [ConstantExpected(Min = 1, Max = 16)] byte shift)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057B0 RID: 22448 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> ShiftRightAndInsert(Vector64<int> left, Vector64<int> right, [ConstantExpected(Min = 1, Max = 32)] byte shift)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057B1 RID: 22449 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<sbyte> ShiftRightAndInsert(Vector64<sbyte> left, Vector64<sbyte> right, [ConstantExpected(Min = 1, Max = 8)] byte shift)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057B2 RID: 22450 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ushort> ShiftRightAndInsert(Vector64<ushort> left, Vector64<ushort> right, [ConstantExpected(Min = 1, Max = 16)] byte shift)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057B3 RID: 22451 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> ShiftRightAndInsert(Vector64<uint> left, Vector64<uint> right, [ConstantExpected(Min = 1, Max = 32)] byte shift)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057B4 RID: 22452 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> ShiftRightAndInsert(Vector128<byte> left, Vector128<byte> right, [ConstantExpected(Min = 1, Max = 8)] byte shift)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057B5 RID: 22453 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> ShiftRightAndInsert(Vector128<short> left, Vector128<short> right, [ConstantExpected(Min = 1, Max = 16)] byte shift)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057B6 RID: 22454 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> ShiftRightAndInsert(Vector128<int> left, Vector128<int> right, [ConstantExpected(Min = 1, Max = 32)] byte shift)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057B7 RID: 22455 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> ShiftRightAndInsert(Vector128<long> left, Vector128<long> right, [ConstantExpected(Min = 1, Max = 64)] byte shift)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057B8 RID: 22456 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> ShiftRightAndInsert(Vector128<sbyte> left, Vector128<sbyte> right, [ConstantExpected(Min = 1, Max = 8)] byte shift)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057B9 RID: 22457 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> ShiftRightAndInsert(Vector128<ushort> left, Vector128<ushort> right, [ConstantExpected(Min = 1, Max = 16)] byte shift)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057BA RID: 22458 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> ShiftRightAndInsert(Vector128<uint> left, Vector128<uint> right, [ConstantExpected(Min = 1, Max = 32)] byte shift)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057BB RID: 22459 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> ShiftRightAndInsert(Vector128<ulong> left, Vector128<ulong> right, [ConstantExpected(Min = 1, Max = 64)] byte shift)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057BC RID: 22460 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<long> ShiftRightAndInsertScalar(Vector64<long> left, Vector64<long> right, [ConstantExpected(Min = 1, Max = 64)] byte shift)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057BD RID: 22461 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ulong> ShiftRightAndInsertScalar(Vector64<ulong> left, Vector64<ulong> right, [ConstantExpected(Min = 1, Max = 64)] byte shift)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057BE RID: 22462 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> ShiftRightArithmetic(Vector64<short> value, [ConstantExpected(Min = 1, Max = 16)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057BF RID: 22463 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> ShiftRightArithmetic(Vector64<int> value, [ConstantExpected(Min = 1, Max = 32)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057C0 RID: 22464 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<sbyte> ShiftRightArithmetic(Vector64<sbyte> value, [ConstantExpected(Min = 1, Max = 8)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057C1 RID: 22465 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> ShiftRightArithmetic(Vector128<short> value, [ConstantExpected(Min = 1, Max = 16)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057C2 RID: 22466 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> ShiftRightArithmetic(Vector128<int> value, [ConstantExpected(Min = 1, Max = 32)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057C3 RID: 22467 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> ShiftRightArithmetic(Vector128<long> value, [ConstantExpected(Min = 1, Max = 64)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057C4 RID: 22468 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> ShiftRightArithmetic(Vector128<sbyte> value, [ConstantExpected(Min = 1, Max = 8)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057C5 RID: 22469 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> ShiftRightArithmeticAdd(Vector64<short> addend, Vector64<short> value, [ConstantExpected(Min = 1, Max = 16)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057C6 RID: 22470 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> ShiftRightArithmeticAdd(Vector64<int> addend, Vector64<int> value, [ConstantExpected(Min = 1, Max = 32)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057C7 RID: 22471 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<sbyte> ShiftRightArithmeticAdd(Vector64<sbyte> addend, Vector64<sbyte> value, [ConstantExpected(Min = 1, Max = 8)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057C8 RID: 22472 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> ShiftRightArithmeticAdd(Vector128<short> addend, Vector128<short> value, [ConstantExpected(Min = 1, Max = 16)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057C9 RID: 22473 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> ShiftRightArithmeticAdd(Vector128<int> addend, Vector128<int> value, [ConstantExpected(Min = 1, Max = 32)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057CA RID: 22474 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> ShiftRightArithmeticAdd(Vector128<long> addend, Vector128<long> value, [ConstantExpected(Min = 1, Max = 64)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057CB RID: 22475 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> ShiftRightArithmeticAdd(Vector128<sbyte> addend, Vector128<sbyte> value, [ConstantExpected(Min = 1, Max = 8)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057CC RID: 22476 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<long> ShiftRightArithmeticAddScalar(Vector64<long> addend, Vector64<long> value, [ConstantExpected(Min = 1, Max = 64)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057CD RID: 22477 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> ShiftRightArithmeticNarrowingSaturateLower(Vector128<int> value, [ConstantExpected(Min = 1, Max = 16)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057CE RID: 22478 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> ShiftRightArithmeticNarrowingSaturateLower(Vector128<long> value, [ConstantExpected(Min = 1, Max = 32)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057CF RID: 22479 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<sbyte> ShiftRightArithmeticNarrowingSaturateLower(Vector128<short> value, [ConstantExpected(Min = 1, Max = 8)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057D0 RID: 22480 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<byte> ShiftRightArithmeticNarrowingSaturateUnsignedLower(Vector128<short> value, [ConstantExpected(Min = 1, Max = 8)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057D1 RID: 22481 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ushort> ShiftRightArithmeticNarrowingSaturateUnsignedLower(Vector128<int> value, [ConstantExpected(Min = 1, Max = 16)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057D2 RID: 22482 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> ShiftRightArithmeticNarrowingSaturateUnsignedLower(Vector128<long> value, [ConstantExpected(Min = 1, Max = 32)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057D3 RID: 22483 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> ShiftRightArithmeticNarrowingSaturateUnsignedUpper(Vector64<byte> lower, Vector128<short> value, [ConstantExpected(Min = 1, Max = 8)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057D4 RID: 22484 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> ShiftRightArithmeticNarrowingSaturateUnsignedUpper(Vector64<ushort> lower, Vector128<int> value, [ConstantExpected(Min = 1, Max = 16)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057D5 RID: 22485 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> ShiftRightArithmeticNarrowingSaturateUnsignedUpper(Vector64<uint> lower, Vector128<long> value, [ConstantExpected(Min = 1, Max = 32)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057D6 RID: 22486 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> ShiftRightArithmeticNarrowingSaturateUpper(Vector64<short> lower, Vector128<int> value, [ConstantExpected(Min = 1, Max = 16)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057D7 RID: 22487 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> ShiftRightArithmeticNarrowingSaturateUpper(Vector64<int> lower, Vector128<long> value, [ConstantExpected(Min = 1, Max = 32)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057D8 RID: 22488 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> ShiftRightArithmeticNarrowingSaturateUpper(Vector64<sbyte> lower, Vector128<short> value, [ConstantExpected(Min = 1, Max = 8)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057D9 RID: 22489 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> ShiftRightArithmeticRounded(Vector64<short> value, [ConstantExpected(Min = 1, Max = 16)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057DA RID: 22490 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> ShiftRightArithmeticRounded(Vector64<int> value, [ConstantExpected(Min = 1, Max = 32)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057DB RID: 22491 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<sbyte> ShiftRightArithmeticRounded(Vector64<sbyte> value, [ConstantExpected(Min = 1, Max = 8)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057DC RID: 22492 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> ShiftRightArithmeticRounded(Vector128<short> value, [ConstantExpected(Min = 1, Max = 16)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057DD RID: 22493 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> ShiftRightArithmeticRounded(Vector128<int> value, [ConstantExpected(Min = 1, Max = 32)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057DE RID: 22494 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> ShiftRightArithmeticRounded(Vector128<long> value, [ConstantExpected(Min = 1, Max = 64)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057DF RID: 22495 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> ShiftRightArithmeticRounded(Vector128<sbyte> value, [ConstantExpected(Min = 1, Max = 8)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057E0 RID: 22496 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> ShiftRightArithmeticRoundedAdd(Vector64<short> addend, Vector64<short> value, [ConstantExpected(Min = 1, Max = 16)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057E1 RID: 22497 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> ShiftRightArithmeticRoundedAdd(Vector64<int> addend, Vector64<int> value, [ConstantExpected(Min = 1, Max = 32)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057E2 RID: 22498 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<sbyte> ShiftRightArithmeticRoundedAdd(Vector64<sbyte> addend, Vector64<sbyte> value, [ConstantExpected(Min = 1, Max = 8)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057E3 RID: 22499 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> ShiftRightArithmeticRoundedAdd(Vector128<short> addend, Vector128<short> value, [ConstantExpected(Min = 1, Max = 16)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057E4 RID: 22500 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> ShiftRightArithmeticRoundedAdd(Vector128<int> addend, Vector128<int> value, [ConstantExpected(Min = 1, Max = 32)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057E5 RID: 22501 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> ShiftRightArithmeticRoundedAdd(Vector128<long> addend, Vector128<long> value, [ConstantExpected(Min = 1, Max = 64)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057E6 RID: 22502 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> ShiftRightArithmeticRoundedAdd(Vector128<sbyte> addend, Vector128<sbyte> value, [ConstantExpected(Min = 1, Max = 8)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057E7 RID: 22503 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<long> ShiftRightArithmeticRoundedAddScalar(Vector64<long> addend, Vector64<long> value, [ConstantExpected(Min = 1, Max = 64)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057E8 RID: 22504 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> ShiftRightArithmeticRoundedNarrowingSaturateLower(Vector128<int> value, [ConstantExpected(Min = 1, Max = 16)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057E9 RID: 22505 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> ShiftRightArithmeticRoundedNarrowingSaturateLower(Vector128<long> value, [ConstantExpected(Min = 1, Max = 32)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057EA RID: 22506 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<sbyte> ShiftRightArithmeticRoundedNarrowingSaturateLower(Vector128<short> value, [ConstantExpected(Min = 1, Max = 8)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057EB RID: 22507 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<byte> ShiftRightArithmeticRoundedNarrowingSaturateUnsignedLower(Vector128<short> value, [ConstantExpected(Min = 1, Max = 8)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057EC RID: 22508 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ushort> ShiftRightArithmeticRoundedNarrowingSaturateUnsignedLower(Vector128<int> value, [ConstantExpected(Min = 1, Max = 16)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057ED RID: 22509 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> ShiftRightArithmeticRoundedNarrowingSaturateUnsignedLower(Vector128<long> value, [ConstantExpected(Min = 1, Max = 32)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057EE RID: 22510 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> ShiftRightArithmeticRoundedNarrowingSaturateUnsignedUpper(Vector64<byte> lower, Vector128<short> value, [ConstantExpected(Min = 1, Max = 8)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057EF RID: 22511 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> ShiftRightArithmeticRoundedNarrowingSaturateUnsignedUpper(Vector64<ushort> lower, Vector128<int> value, [ConstantExpected(Min = 1, Max = 16)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057F0 RID: 22512 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> ShiftRightArithmeticRoundedNarrowingSaturateUnsignedUpper(Vector64<uint> lower, Vector128<long> value, [ConstantExpected(Min = 1, Max = 32)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057F1 RID: 22513 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> ShiftRightArithmeticRoundedNarrowingSaturateUpper(Vector64<short> lower, Vector128<int> value, [ConstantExpected(Min = 1, Max = 16)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057F2 RID: 22514 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> ShiftRightArithmeticRoundedNarrowingSaturateUpper(Vector64<int> lower, Vector128<long> value, [ConstantExpected(Min = 1, Max = 32)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057F3 RID: 22515 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> ShiftRightArithmeticRoundedNarrowingSaturateUpper(Vector64<sbyte> lower, Vector128<short> value, [ConstantExpected(Min = 1, Max = 8)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057F4 RID: 22516 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<long> ShiftRightArithmeticRoundedScalar(Vector64<long> value, [ConstantExpected(Min = 1, Max = 64)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057F5 RID: 22517 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<long> ShiftRightArithmeticScalar(Vector64<long> value, [ConstantExpected(Min = 1, Max = 64)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057F6 RID: 22518 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<byte> ShiftRightLogical(Vector64<byte> value, [ConstantExpected(Min = 1, Max = 8)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057F7 RID: 22519 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> ShiftRightLogical(Vector64<short> value, [ConstantExpected(Min = 1, Max = 16)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057F8 RID: 22520 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> ShiftRightLogical(Vector64<int> value, [ConstantExpected(Min = 1, Max = 32)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057F9 RID: 22521 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<sbyte> ShiftRightLogical(Vector64<sbyte> value, [ConstantExpected(Min = 1, Max = 8)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057FA RID: 22522 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ushort> ShiftRightLogical(Vector64<ushort> value, [ConstantExpected(Min = 1, Max = 16)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057FB RID: 22523 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> ShiftRightLogical(Vector64<uint> value, [ConstantExpected(Min = 1, Max = 32)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057FC RID: 22524 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> ShiftRightLogical(Vector128<byte> value, [ConstantExpected(Min = 1, Max = 8)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057FD RID: 22525 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> ShiftRightLogical(Vector128<short> value, [ConstantExpected(Min = 1, Max = 16)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057FE RID: 22526 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> ShiftRightLogical(Vector128<int> value, [ConstantExpected(Min = 1, Max = 32)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060057FF RID: 22527 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> ShiftRightLogical(Vector128<long> value, [ConstantExpected(Min = 1, Max = 64)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005800 RID: 22528 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> ShiftRightLogical(Vector128<sbyte> value, [ConstantExpected(Min = 1, Max = 8)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005801 RID: 22529 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> ShiftRightLogical(Vector128<ushort> value, [ConstantExpected(Min = 1, Max = 16)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005802 RID: 22530 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> ShiftRightLogical(Vector128<uint> value, [ConstantExpected(Min = 1, Max = 32)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005803 RID: 22531 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> ShiftRightLogical(Vector128<ulong> value, [ConstantExpected(Min = 1, Max = 64)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005804 RID: 22532 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<byte> ShiftRightLogicalAdd(Vector64<byte> addend, Vector64<byte> value, [ConstantExpected(Min = 1, Max = 8)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005805 RID: 22533 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> ShiftRightLogicalAdd(Vector64<short> addend, Vector64<short> value, [ConstantExpected(Min = 1, Max = 16)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005806 RID: 22534 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> ShiftRightLogicalAdd(Vector64<int> addend, Vector64<int> value, [ConstantExpected(Min = 1, Max = 32)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005807 RID: 22535 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<sbyte> ShiftRightLogicalAdd(Vector64<sbyte> addend, Vector64<sbyte> value, [ConstantExpected(Min = 1, Max = 8)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005808 RID: 22536 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ushort> ShiftRightLogicalAdd(Vector64<ushort> addend, Vector64<ushort> value, [ConstantExpected(Min = 1, Max = 16)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005809 RID: 22537 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> ShiftRightLogicalAdd(Vector64<uint> addend, Vector64<uint> value, [ConstantExpected(Min = 1, Max = 32)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600580A RID: 22538 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> ShiftRightLogicalAdd(Vector128<byte> addend, Vector128<byte> value, [ConstantExpected(Min = 1, Max = 8)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600580B RID: 22539 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> ShiftRightLogicalAdd(Vector128<short> addend, Vector128<short> value, [ConstantExpected(Min = 1, Max = 16)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600580C RID: 22540 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> ShiftRightLogicalAdd(Vector128<int> addend, Vector128<int> value, [ConstantExpected(Min = 1, Max = 32)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600580D RID: 22541 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> ShiftRightLogicalAdd(Vector128<long> addend, Vector128<long> value, [ConstantExpected(Min = 1, Max = 64)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600580E RID: 22542 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> ShiftRightLogicalAdd(Vector128<sbyte> addend, Vector128<sbyte> value, [ConstantExpected(Min = 1, Max = 8)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600580F RID: 22543 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> ShiftRightLogicalAdd(Vector128<ushort> addend, Vector128<ushort> value, [ConstantExpected(Min = 1, Max = 16)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005810 RID: 22544 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> ShiftRightLogicalAdd(Vector128<uint> addend, Vector128<uint> value, [ConstantExpected(Min = 1, Max = 32)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005811 RID: 22545 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> ShiftRightLogicalAdd(Vector128<ulong> addend, Vector128<ulong> value, [ConstantExpected(Min = 1, Max = 64)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005812 RID: 22546 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<long> ShiftRightLogicalAddScalar(Vector64<long> addend, Vector64<long> value, [ConstantExpected(Min = 1, Max = 64)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005813 RID: 22547 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ulong> ShiftRightLogicalAddScalar(Vector64<ulong> addend, Vector64<ulong> value, [ConstantExpected(Min = 1, Max = 64)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005814 RID: 22548 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<byte> ShiftRightLogicalNarrowingLower(Vector128<ushort> value, [ConstantExpected(Min = 1, Max = 8)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005815 RID: 22549 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> ShiftRightLogicalNarrowingLower(Vector128<int> value, [ConstantExpected(Min = 1, Max = 16)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005816 RID: 22550 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> ShiftRightLogicalNarrowingLower(Vector128<long> value, [ConstantExpected(Min = 1, Max = 32)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005817 RID: 22551 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<sbyte> ShiftRightLogicalNarrowingLower(Vector128<short> value, [ConstantExpected(Min = 1, Max = 8)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005818 RID: 22552 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ushort> ShiftRightLogicalNarrowingLower(Vector128<uint> value, [ConstantExpected(Min = 1, Max = 16)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005819 RID: 22553 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> ShiftRightLogicalNarrowingLower(Vector128<ulong> value, [ConstantExpected(Min = 1, Max = 32)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600581A RID: 22554 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<byte> ShiftRightLogicalNarrowingSaturateLower(Vector128<ushort> value, [ConstantExpected(Min = 1, Max = 8)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600581B RID: 22555 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> ShiftRightLogicalNarrowingSaturateLower(Vector128<int> value, [ConstantExpected(Min = 1, Max = 16)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600581C RID: 22556 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> ShiftRightLogicalNarrowingSaturateLower(Vector128<long> value, [ConstantExpected(Min = 1, Max = 32)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600581D RID: 22557 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<sbyte> ShiftRightLogicalNarrowingSaturateLower(Vector128<short> value, [ConstantExpected(Min = 1, Max = 8)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600581E RID: 22558 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ushort> ShiftRightLogicalNarrowingSaturateLower(Vector128<uint> value, [ConstantExpected(Min = 1, Max = 16)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600581F RID: 22559 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> ShiftRightLogicalNarrowingSaturateLower(Vector128<ulong> value, [ConstantExpected(Min = 1, Max = 32)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005820 RID: 22560 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> ShiftRightLogicalNarrowingSaturateUpper(Vector64<byte> lower, Vector128<ushort> value, [ConstantExpected(Min = 1, Max = 8)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005821 RID: 22561 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> ShiftRightLogicalNarrowingSaturateUpper(Vector64<short> lower, Vector128<int> value, [ConstantExpected(Min = 1, Max = 16)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005822 RID: 22562 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> ShiftRightLogicalNarrowingSaturateUpper(Vector64<int> lower, Vector128<long> value, [ConstantExpected(Min = 1, Max = 32)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005823 RID: 22563 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> ShiftRightLogicalNarrowingSaturateUpper(Vector64<sbyte> lower, Vector128<short> value, [ConstantExpected(Min = 1, Max = 8)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005824 RID: 22564 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> ShiftRightLogicalNarrowingSaturateUpper(Vector64<ushort> lower, Vector128<uint> value, [ConstantExpected(Min = 1, Max = 16)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005825 RID: 22565 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> ShiftRightLogicalNarrowingSaturateUpper(Vector64<uint> lower, Vector128<ulong> value, [ConstantExpected(Min = 1, Max = 32)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005826 RID: 22566 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> ShiftRightLogicalNarrowingUpper(Vector64<byte> lower, Vector128<ushort> value, [ConstantExpected(Min = 1, Max = 8)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005827 RID: 22567 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> ShiftRightLogicalNarrowingUpper(Vector64<short> lower, Vector128<int> value, [ConstantExpected(Min = 1, Max = 16)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005828 RID: 22568 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> ShiftRightLogicalNarrowingUpper(Vector64<int> lower, Vector128<long> value, [ConstantExpected(Min = 1, Max = 32)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005829 RID: 22569 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> ShiftRightLogicalNarrowingUpper(Vector64<sbyte> lower, Vector128<short> value, [ConstantExpected(Min = 1, Max = 8)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600582A RID: 22570 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> ShiftRightLogicalNarrowingUpper(Vector64<ushort> lower, Vector128<uint> value, [ConstantExpected(Min = 1, Max = 16)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600582B RID: 22571 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> ShiftRightLogicalNarrowingUpper(Vector64<uint> lower, Vector128<ulong> value, [ConstantExpected(Min = 1, Max = 32)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600582C RID: 22572 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<byte> ShiftRightLogicalRounded(Vector64<byte> value, [ConstantExpected(Min = 1, Max = 8)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600582D RID: 22573 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> ShiftRightLogicalRounded(Vector64<short> value, [ConstantExpected(Min = 1, Max = 16)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600582E RID: 22574 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> ShiftRightLogicalRounded(Vector64<int> value, [ConstantExpected(Min = 1, Max = 32)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600582F RID: 22575 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<sbyte> ShiftRightLogicalRounded(Vector64<sbyte> value, [ConstantExpected(Min = 1, Max = 8)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005830 RID: 22576 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ushort> ShiftRightLogicalRounded(Vector64<ushort> value, [ConstantExpected(Min = 1, Max = 16)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005831 RID: 22577 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> ShiftRightLogicalRounded(Vector64<uint> value, [ConstantExpected(Min = 1, Max = 32)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005832 RID: 22578 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> ShiftRightLogicalRounded(Vector128<byte> value, [ConstantExpected(Min = 1, Max = 8)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005833 RID: 22579 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> ShiftRightLogicalRounded(Vector128<short> value, [ConstantExpected(Min = 1, Max = 16)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005834 RID: 22580 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> ShiftRightLogicalRounded(Vector128<int> value, [ConstantExpected(Min = 1, Max = 32)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005835 RID: 22581 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> ShiftRightLogicalRounded(Vector128<long> value, [ConstantExpected(Min = 1, Max = 64)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005836 RID: 22582 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> ShiftRightLogicalRounded(Vector128<sbyte> value, [ConstantExpected(Min = 1, Max = 8)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005837 RID: 22583 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> ShiftRightLogicalRounded(Vector128<ushort> value, [ConstantExpected(Min = 1, Max = 16)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005838 RID: 22584 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> ShiftRightLogicalRounded(Vector128<uint> value, [ConstantExpected(Min = 1, Max = 32)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005839 RID: 22585 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> ShiftRightLogicalRounded(Vector128<ulong> value, [ConstantExpected(Min = 1, Max = 64)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600583A RID: 22586 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<byte> ShiftRightLogicalRoundedAdd(Vector64<byte> addend, Vector64<byte> value, [ConstantExpected(Min = 1, Max = 8)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600583B RID: 22587 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> ShiftRightLogicalRoundedAdd(Vector64<short> addend, Vector64<short> value, [ConstantExpected(Min = 1, Max = 16)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600583C RID: 22588 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> ShiftRightLogicalRoundedAdd(Vector64<int> addend, Vector64<int> value, [ConstantExpected(Min = 1, Max = 32)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600583D RID: 22589 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<sbyte> ShiftRightLogicalRoundedAdd(Vector64<sbyte> addend, Vector64<sbyte> value, [ConstantExpected(Min = 1, Max = 8)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600583E RID: 22590 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ushort> ShiftRightLogicalRoundedAdd(Vector64<ushort> addend, Vector64<ushort> value, [ConstantExpected(Min = 1, Max = 16)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600583F RID: 22591 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> ShiftRightLogicalRoundedAdd(Vector64<uint> addend, Vector64<uint> value, [ConstantExpected(Min = 1, Max = 32)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005840 RID: 22592 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> ShiftRightLogicalRoundedAdd(Vector128<byte> addend, Vector128<byte> value, [ConstantExpected(Min = 1, Max = 8)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005841 RID: 22593 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> ShiftRightLogicalRoundedAdd(Vector128<short> addend, Vector128<short> value, [ConstantExpected(Min = 1, Max = 16)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005842 RID: 22594 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> ShiftRightLogicalRoundedAdd(Vector128<int> addend, Vector128<int> value, [ConstantExpected(Min = 1, Max = 32)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005843 RID: 22595 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> ShiftRightLogicalRoundedAdd(Vector128<long> addend, Vector128<long> value, [ConstantExpected(Min = 1, Max = 64)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005844 RID: 22596 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> ShiftRightLogicalRoundedAdd(Vector128<sbyte> addend, Vector128<sbyte> value, [ConstantExpected(Min = 1, Max = 8)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005845 RID: 22597 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> ShiftRightLogicalRoundedAdd(Vector128<ushort> addend, Vector128<ushort> value, [ConstantExpected(Min = 1, Max = 16)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005846 RID: 22598 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> ShiftRightLogicalRoundedAdd(Vector128<uint> addend, Vector128<uint> value, [ConstantExpected(Min = 1, Max = 32)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005847 RID: 22599 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> ShiftRightLogicalRoundedAdd(Vector128<ulong> addend, Vector128<ulong> value, [ConstantExpected(Min = 1, Max = 64)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005848 RID: 22600 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<long> ShiftRightLogicalRoundedAddScalar(Vector64<long> addend, Vector64<long> value, [ConstantExpected(Min = 1, Max = 64)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005849 RID: 22601 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ulong> ShiftRightLogicalRoundedAddScalar(Vector64<ulong> addend, Vector64<ulong> value, [ConstantExpected(Min = 1, Max = 64)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600584A RID: 22602 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<byte> ShiftRightLogicalRoundedNarrowingLower(Vector128<ushort> value, [ConstantExpected(Min = 1, Max = 8)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600584B RID: 22603 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> ShiftRightLogicalRoundedNarrowingLower(Vector128<int> value, [ConstantExpected(Min = 1, Max = 16)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600584C RID: 22604 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> ShiftRightLogicalRoundedNarrowingLower(Vector128<long> value, [ConstantExpected(Min = 1, Max = 32)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600584D RID: 22605 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<sbyte> ShiftRightLogicalRoundedNarrowingLower(Vector128<short> value, [ConstantExpected(Min = 1, Max = 8)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600584E RID: 22606 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ushort> ShiftRightLogicalRoundedNarrowingLower(Vector128<uint> value, [ConstantExpected(Min = 1, Max = 16)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600584F RID: 22607 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> ShiftRightLogicalRoundedNarrowingLower(Vector128<ulong> value, [ConstantExpected(Min = 1, Max = 32)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005850 RID: 22608 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<byte> ShiftRightLogicalRoundedNarrowingSaturateLower(Vector128<ushort> value, [ConstantExpected(Min = 1, Max = 8)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005851 RID: 22609 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[Obsolete("The underlying hardware instruction does not perform a signed saturate narrowing operation, and it always returns an unsigned result. Use the unsigned overload instead.", DiagnosticId = "SYSLIB0055", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		public static Vector64<short> ShiftRightLogicalRoundedNarrowingSaturateLower(Vector128<int> value, [ConstantExpected(Min = 1, Max = 16)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005852 RID: 22610 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[Obsolete("The underlying hardware instruction does not perform a signed saturate narrowing operation, and it always returns an unsigned result. Use the unsigned overload instead.", DiagnosticId = "SYSLIB0055", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		public static Vector64<int> ShiftRightLogicalRoundedNarrowingSaturateLower(Vector128<long> value, [ConstantExpected(Min = 1, Max = 32)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005853 RID: 22611 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[Obsolete("The underlying hardware instruction does not perform a signed saturate narrowing operation, and it always returns an unsigned result. Use the unsigned overload instead.", DiagnosticId = "SYSLIB0055", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		public static Vector64<sbyte> ShiftRightLogicalRoundedNarrowingSaturateLower(Vector128<short> value, [ConstantExpected(Min = 1, Max = 8)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005854 RID: 22612 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ushort> ShiftRightLogicalRoundedNarrowingSaturateLower(Vector128<uint> value, [ConstantExpected(Min = 1, Max = 16)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005855 RID: 22613 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> ShiftRightLogicalRoundedNarrowingSaturateLower(Vector128<ulong> value, [ConstantExpected(Min = 1, Max = 32)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005856 RID: 22614 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> ShiftRightLogicalRoundedNarrowingSaturateUpper(Vector64<byte> lower, Vector128<ushort> value, [ConstantExpected(Min = 1, Max = 8)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005857 RID: 22615 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[Obsolete("The underlying hardware instruction does not perform a signed saturate narrowing operation, and it always returns an unsigned result. Use the unsigned overload instead.", DiagnosticId = "SYSLIB0055", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		public static Vector128<short> ShiftRightLogicalRoundedNarrowingSaturateUpper(Vector64<short> lower, Vector128<int> value, [ConstantExpected(Min = 1, Max = 16)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005858 RID: 22616 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[Obsolete("The underlying hardware instruction does not perform a signed saturate narrowing operation, and it always returns an unsigned result. Use the unsigned overload instead.", DiagnosticId = "SYSLIB0055", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		public static Vector128<int> ShiftRightLogicalRoundedNarrowingSaturateUpper(Vector64<int> lower, Vector128<long> value, [ConstantExpected(Min = 1, Max = 32)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005859 RID: 22617 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[Obsolete("The underlying hardware instruction does not perform a signed saturate narrowing operation, and it always returns an unsigned result. Use the unsigned overload instead.", DiagnosticId = "SYSLIB0055", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		public static Vector128<sbyte> ShiftRightLogicalRoundedNarrowingSaturateUpper(Vector64<sbyte> lower, Vector128<short> value, [ConstantExpected(Min = 1, Max = 8)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600585A RID: 22618 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> ShiftRightLogicalRoundedNarrowingSaturateUpper(Vector64<ushort> lower, Vector128<uint> value, [ConstantExpected(Min = 1, Max = 16)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600585B RID: 22619 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> ShiftRightLogicalRoundedNarrowingSaturateUpper(Vector64<uint> lower, Vector128<ulong> value, [ConstantExpected(Min = 1, Max = 32)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600585C RID: 22620 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> ShiftRightLogicalRoundedNarrowingUpper(Vector64<byte> lower, Vector128<ushort> value, [ConstantExpected(Min = 1, Max = 8)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600585D RID: 22621 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> ShiftRightLogicalRoundedNarrowingUpper(Vector64<short> lower, Vector128<int> value, [ConstantExpected(Min = 1, Max = 16)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600585E RID: 22622 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> ShiftRightLogicalRoundedNarrowingUpper(Vector64<int> lower, Vector128<long> value, [ConstantExpected(Min = 1, Max = 32)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600585F RID: 22623 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> ShiftRightLogicalRoundedNarrowingUpper(Vector64<sbyte> lower, Vector128<short> value, [ConstantExpected(Min = 1, Max = 8)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005860 RID: 22624 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> ShiftRightLogicalRoundedNarrowingUpper(Vector64<ushort> lower, Vector128<uint> value, [ConstantExpected(Min = 1, Max = 16)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005861 RID: 22625 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> ShiftRightLogicalRoundedNarrowingUpper(Vector64<uint> lower, Vector128<ulong> value, [ConstantExpected(Min = 1, Max = 32)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005862 RID: 22626 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<long> ShiftRightLogicalRoundedScalar(Vector64<long> value, [ConstantExpected(Min = 1, Max = 64)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005863 RID: 22627 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ulong> ShiftRightLogicalRoundedScalar(Vector64<ulong> value, [ConstantExpected(Min = 1, Max = 64)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005864 RID: 22628 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<long> ShiftRightLogicalScalar(Vector64<long> value, [ConstantExpected(Min = 1, Max = 64)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005865 RID: 22629 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ulong> ShiftRightLogicalScalar(Vector64<ulong> value, [ConstantExpected(Min = 1, Max = 64)] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005866 RID: 22630 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> SignExtendWideningLower(Vector64<short> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005867 RID: 22631 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> SignExtendWideningLower(Vector64<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005868 RID: 22632 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> SignExtendWideningLower(Vector64<sbyte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005869 RID: 22633 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> SignExtendWideningUpper(Vector128<short> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600586A RID: 22634 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> SignExtendWideningUpper(Vector128<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600586B RID: 22635 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> SignExtendWideningUpper(Vector128<sbyte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600586C RID: 22636 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<double> SqrtScalar(Vector64<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600586D RID: 22637 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<float> SqrtScalar(Vector64<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600586E RID: 22638 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Store(byte* address, Vector64<byte> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600586F RID: 22639 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Store(double* address, Vector64<double> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005870 RID: 22640 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Store(short* address, Vector64<short> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005871 RID: 22641 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Store(int* address, Vector64<int> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005872 RID: 22642 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Store(long* address, Vector64<long> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005873 RID: 22643 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Store(sbyte* address, Vector64<sbyte> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005874 RID: 22644 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Store(float* address, Vector64<float> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005875 RID: 22645 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Store(ushort* address, Vector64<ushort> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005876 RID: 22646 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Store(uint* address, Vector64<uint> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005877 RID: 22647 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Store(ulong* address, Vector64<ulong> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005878 RID: 22648 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Store(byte* address, Vector128<byte> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005879 RID: 22649 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Store(double* address, Vector128<double> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600587A RID: 22650 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Store(short* address, Vector128<short> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600587B RID: 22651 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Store(int* address, Vector128<int> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600587C RID: 22652 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Store(long* address, Vector128<long> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600587D RID: 22653 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Store(sbyte* address, Vector128<sbyte> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600587E RID: 22654 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Store(float* address, Vector128<float> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600587F RID: 22655 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Store(ushort* address, Vector128<ushort> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005880 RID: 22656 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Store(uint* address, Vector128<uint> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005881 RID: 22657 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Store(ulong* address, Vector128<ulong> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005882 RID: 22658 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreSelectedScalar(byte* address, Vector64<byte> value, [ConstantExpected(Max = 7)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005883 RID: 22659 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreSelectedScalar(short* address, Vector64<short> value, [ConstantExpected(Max = 3)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005884 RID: 22660 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreSelectedScalar(int* address, Vector64<int> value, [ConstantExpected(Max = 1)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005885 RID: 22661 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreSelectedScalar(sbyte* address, Vector64<sbyte> value, [ConstantExpected(Max = 7)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005886 RID: 22662 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreSelectedScalar(float* address, Vector64<float> value, [ConstantExpected(Max = 1)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005887 RID: 22663 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreSelectedScalar(ushort* address, Vector64<ushort> value, [ConstantExpected(Max = 3)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005888 RID: 22664 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreSelectedScalar(uint* address, Vector64<uint> value, [ConstantExpected(Max = 1)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005889 RID: 22665 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreSelectedScalar(byte* address, Vector128<byte> value, [ConstantExpected(Max = 15)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600588A RID: 22666 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreSelectedScalar(double* address, Vector128<double> value, [ConstantExpected(Max = 1)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600588B RID: 22667 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreSelectedScalar(short* address, Vector128<short> value, [ConstantExpected(Max = 7)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600588C RID: 22668 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreSelectedScalar(int* address, Vector128<int> value, [ConstantExpected(Max = 3)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600588D RID: 22669 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreSelectedScalar(long* address, Vector128<long> value, [ConstantExpected(Max = 1)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600588E RID: 22670 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreSelectedScalar(sbyte* address, Vector128<sbyte> value, [ConstantExpected(Max = 15)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600588F RID: 22671 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreSelectedScalar(float* address, Vector128<float> value, [ConstantExpected(Max = 3)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005890 RID: 22672 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreSelectedScalar(ushort* address, Vector128<ushort> value, [ConstantExpected(Max = 7)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005891 RID: 22673 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreSelectedScalar(uint* address, Vector128<uint> value, [ConstantExpected(Max = 3)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005892 RID: 22674 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreSelectedScalar(ulong* address, Vector128<ulong> value, [ConstantExpected(Max = 1)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005893 RID: 22675 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreSelectedScalar(byte* address, [TupleElementNames(new string[]
		{
			"value1",
			"value2"
		})] ValueTuple<Vector64<byte>, Vector64<byte>> value, [ConstantExpected(Max = 7)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005894 RID: 22676 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreSelectedScalar(sbyte* address, [TupleElementNames(new string[]
		{
			"value1",
			"value2"
		})] ValueTuple<Vector64<sbyte>, Vector64<sbyte>> value, [ConstantExpected(Max = 7)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005895 RID: 22677 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreSelectedScalar(short* address, [TupleElementNames(new string[]
		{
			"value1",
			"value2"
		})] ValueTuple<Vector64<short>, Vector64<short>> value, [ConstantExpected(Max = 3)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005896 RID: 22678 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreSelectedScalar(ushort* address, [TupleElementNames(new string[]
		{
			"value1",
			"value2"
		})] ValueTuple<Vector64<ushort>, Vector64<ushort>> value, [ConstantExpected(Max = 3)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005897 RID: 22679 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreSelectedScalar(int* address, [TupleElementNames(new string[]
		{
			"value1",
			"value2"
		})] ValueTuple<Vector64<int>, Vector64<int>> value, [ConstantExpected(Max = 1)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005898 RID: 22680 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreSelectedScalar(uint* address, [TupleElementNames(new string[]
		{
			"value1",
			"value2"
		})] ValueTuple<Vector64<uint>, Vector64<uint>> value, [ConstantExpected(Max = 1)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005899 RID: 22681 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreSelectedScalar(float* address, [TupleElementNames(new string[]
		{
			"value1",
			"value2"
		})] ValueTuple<Vector64<float>, Vector64<float>> value, [ConstantExpected(Max = 1)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600589A RID: 22682 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreSelectedScalar(byte* address, [TupleElementNames(new string[]
		{
			"value1",
			"value2",
			"value3"
		})] ValueTuple<Vector64<byte>, Vector64<byte>, Vector64<byte>> value, [ConstantExpected(Max = 7)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600589B RID: 22683 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreSelectedScalar(sbyte* address, [TupleElementNames(new string[]
		{
			"value1",
			"value2",
			"value3"
		})] ValueTuple<Vector64<sbyte>, Vector64<sbyte>, Vector64<sbyte>> value, [ConstantExpected(Max = 7)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600589C RID: 22684 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreSelectedScalar(short* address, [TupleElementNames(new string[]
		{
			"value1",
			"value2",
			"value3"
		})] ValueTuple<Vector64<short>, Vector64<short>, Vector64<short>> value, [ConstantExpected(Max = 3)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600589D RID: 22685 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreSelectedScalar(ushort* address, [TupleElementNames(new string[]
		{
			"value1",
			"value2",
			"value3"
		})] ValueTuple<Vector64<ushort>, Vector64<ushort>, Vector64<ushort>> value, [ConstantExpected(Max = 3)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600589E RID: 22686 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreSelectedScalar(int* address, [TupleElementNames(new string[]
		{
			"value1",
			"value2",
			"value3"
		})] ValueTuple<Vector64<int>, Vector64<int>, Vector64<int>> value, [ConstantExpected(Max = 1)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600589F RID: 22687 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreSelectedScalar(uint* address, [TupleElementNames(new string[]
		{
			"value1",
			"value2",
			"value3"
		})] ValueTuple<Vector64<uint>, Vector64<uint>, Vector64<uint>> value, [ConstantExpected(Max = 1)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058A0 RID: 22688 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreSelectedScalar(float* address, [TupleElementNames(new string[]
		{
			"value1",
			"value2",
			"value3"
		})] ValueTuple<Vector64<float>, Vector64<float>, Vector64<float>> value, [ConstantExpected(Max = 1)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058A1 RID: 22689 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreSelectedScalar(byte* address, [TupleElementNames(new string[]
		{
			"value1",
			"value2",
			"value3",
			"value4"
		})] ValueTuple<Vector64<byte>, Vector64<byte>, Vector64<byte>, Vector64<byte>> value, [ConstantExpected(Max = 7)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058A2 RID: 22690 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreSelectedScalar(sbyte* address, [TupleElementNames(new string[]
		{
			"value1",
			"value2",
			"value3",
			"value4"
		})] ValueTuple<Vector64<sbyte>, Vector64<sbyte>, Vector64<sbyte>, Vector64<sbyte>> value, [ConstantExpected(Max = 7)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058A3 RID: 22691 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreSelectedScalar(short* address, [TupleElementNames(new string[]
		{
			"value1",
			"value2",
			"value3",
			"value4"
		})] ValueTuple<Vector64<short>, Vector64<short>, Vector64<short>, Vector64<short>> value, [ConstantExpected(Max = 3)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058A4 RID: 22692 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreSelectedScalar(ushort* address, [TupleElementNames(new string[]
		{
			"value1",
			"value2",
			"value3",
			"value4"
		})] ValueTuple<Vector64<ushort>, Vector64<ushort>, Vector64<ushort>, Vector64<ushort>> value, [ConstantExpected(Max = 3)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058A5 RID: 22693 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreSelectedScalar(int* address, [TupleElementNames(new string[]
		{
			"value1",
			"value2",
			"value3",
			"value4"
		})] ValueTuple<Vector64<int>, Vector64<int>, Vector64<int>, Vector64<int>> value, [ConstantExpected(Max = 1)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058A6 RID: 22694 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreSelectedScalar(uint* address, [TupleElementNames(new string[]
		{
			"value1",
			"value2",
			"value3",
			"value4"
		})] ValueTuple<Vector64<uint>, Vector64<uint>, Vector64<uint>, Vector64<uint>> value, [ConstantExpected(Max = 1)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058A7 RID: 22695 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreSelectedScalar(float* address, [TupleElementNames(new string[]
		{
			"value1",
			"value2",
			"value3",
			"value4"
		})] ValueTuple<Vector64<float>, Vector64<float>, Vector64<float>, Vector64<float>> value, [ConstantExpected(Max = 1)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058A8 RID: 22696 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreVectorAndZip(byte* address, [TupleElementNames(new string[]
		{
			"Value1",
			"Value2"
		})] ValueTuple<Vector64<byte>, Vector64<byte>> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058A9 RID: 22697 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreVectorAndZip(sbyte* address, [TupleElementNames(new string[]
		{
			"Value1",
			"Value2"
		})] ValueTuple<Vector64<sbyte>, Vector64<sbyte>> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058AA RID: 22698 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreVectorAndZip(short* address, [TupleElementNames(new string[]
		{
			"Value1",
			"Value2"
		})] ValueTuple<Vector64<short>, Vector64<short>> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058AB RID: 22699 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreVectorAndZip(ushort* address, [TupleElementNames(new string[]
		{
			"Value1",
			"Value2"
		})] ValueTuple<Vector64<ushort>, Vector64<ushort>> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058AC RID: 22700 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreVectorAndZip(int* address, [TupleElementNames(new string[]
		{
			"Value1",
			"Value2"
		})] ValueTuple<Vector64<int>, Vector64<int>> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058AD RID: 22701 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreVectorAndZip(uint* address, [TupleElementNames(new string[]
		{
			"Value1",
			"Value2"
		})] ValueTuple<Vector64<uint>, Vector64<uint>> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058AE RID: 22702 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreVectorAndZip(float* address, [TupleElementNames(new string[]
		{
			"Value1",
			"Value2"
		})] ValueTuple<Vector64<float>, Vector64<float>> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058AF RID: 22703 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreVectorAndZip(byte* address, [TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3"
		})] ValueTuple<Vector64<byte>, Vector64<byte>, Vector64<byte>> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058B0 RID: 22704 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreVectorAndZip(sbyte* address, [TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3"
		})] ValueTuple<Vector64<sbyte>, Vector64<sbyte>, Vector64<sbyte>> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058B1 RID: 22705 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreVectorAndZip(short* address, [TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3"
		})] ValueTuple<Vector64<short>, Vector64<short>, Vector64<short>> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058B2 RID: 22706 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreVectorAndZip(ushort* address, [TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3"
		})] ValueTuple<Vector64<ushort>, Vector64<ushort>, Vector64<ushort>> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058B3 RID: 22707 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreVectorAndZip(int* address, [TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3"
		})] ValueTuple<Vector64<int>, Vector64<int>, Vector64<int>> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058B4 RID: 22708 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreVectorAndZip(uint* address, [TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3"
		})] ValueTuple<Vector64<uint>, Vector64<uint>, Vector64<uint>> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058B5 RID: 22709 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreVectorAndZip(float* address, [TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3"
		})] ValueTuple<Vector64<float>, Vector64<float>, Vector64<float>> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058B6 RID: 22710 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreVectorAndZip(byte* address, [TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3",
			"Value4"
		})] ValueTuple<Vector64<byte>, Vector64<byte>, Vector64<byte>, Vector64<byte>> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058B7 RID: 22711 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreVectorAndZip(sbyte* address, [TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3",
			"Value4"
		})] ValueTuple<Vector64<sbyte>, Vector64<sbyte>, Vector64<sbyte>, Vector64<sbyte>> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058B8 RID: 22712 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreVectorAndZip(short* address, [TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3",
			"Value4"
		})] ValueTuple<Vector64<short>, Vector64<short>, Vector64<short>, Vector64<short>> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058B9 RID: 22713 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreVectorAndZip(ushort* address, [TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3",
			"Value4"
		})] ValueTuple<Vector64<ushort>, Vector64<ushort>, Vector64<ushort>, Vector64<ushort>> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058BA RID: 22714 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreVectorAndZip(int* address, [TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3",
			"Value4"
		})] ValueTuple<Vector64<int>, Vector64<int>, Vector64<int>, Vector64<int>> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058BB RID: 22715 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreVectorAndZip(uint* address, [TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3",
			"Value4"
		})] ValueTuple<Vector64<uint>, Vector64<uint>, Vector64<uint>, Vector64<uint>> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058BC RID: 22716 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreVectorAndZip(float* address, [TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3",
			"Value4"
		})] ValueTuple<Vector64<float>, Vector64<float>, Vector64<float>, Vector64<float>> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058BD RID: 22717 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Store(byte* address, [TupleElementNames(new string[]
		{
			"Value1",
			"Value2"
		})] ValueTuple<Vector64<byte>, Vector64<byte>> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058BE RID: 22718 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Store(sbyte* address, [TupleElementNames(new string[]
		{
			"Value1",
			"Value2"
		})] ValueTuple<Vector64<sbyte>, Vector64<sbyte>> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058BF RID: 22719 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Store(short* address, [TupleElementNames(new string[]
		{
			"Value1",
			"Value2"
		})] ValueTuple<Vector64<short>, Vector64<short>> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058C0 RID: 22720 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Store(ushort* address, [TupleElementNames(new string[]
		{
			"Value1",
			"Value2"
		})] ValueTuple<Vector64<ushort>, Vector64<ushort>> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058C1 RID: 22721 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Store(int* address, [TupleElementNames(new string[]
		{
			"Value1",
			"Value2"
		})] ValueTuple<Vector64<int>, Vector64<int>> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058C2 RID: 22722 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Store(uint* address, [TupleElementNames(new string[]
		{
			"Value1",
			"Value2"
		})] ValueTuple<Vector64<uint>, Vector64<uint>> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058C3 RID: 22723 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Store(float* address, [TupleElementNames(new string[]
		{
			"Value1",
			"Value2"
		})] ValueTuple<Vector64<float>, Vector64<float>> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058C4 RID: 22724 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Store(byte* address, [TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3"
		})] ValueTuple<Vector64<byte>, Vector64<byte>, Vector64<byte>> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058C5 RID: 22725 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Store(sbyte* address, [TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3"
		})] ValueTuple<Vector64<sbyte>, Vector64<sbyte>, Vector64<sbyte>> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058C6 RID: 22726 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Store(short* address, [TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3"
		})] ValueTuple<Vector64<short>, Vector64<short>, Vector64<short>> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058C7 RID: 22727 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Store(ushort* address, [TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3"
		})] ValueTuple<Vector64<ushort>, Vector64<ushort>, Vector64<ushort>> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058C8 RID: 22728 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Store(int* address, [TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3"
		})] ValueTuple<Vector64<int>, Vector64<int>, Vector64<int>> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058C9 RID: 22729 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Store(uint* address, [TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3"
		})] ValueTuple<Vector64<uint>, Vector64<uint>, Vector64<uint>> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058CA RID: 22730 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Store(float* address, [TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3"
		})] ValueTuple<Vector64<float>, Vector64<float>, Vector64<float>> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058CB RID: 22731 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Store(byte* address, [TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3",
			"Value4"
		})] ValueTuple<Vector64<byte>, Vector64<byte>, Vector64<byte>, Vector64<byte>> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058CC RID: 22732 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Store(sbyte* address, [TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3",
			"Value4"
		})] ValueTuple<Vector64<sbyte>, Vector64<sbyte>, Vector64<sbyte>, Vector64<sbyte>> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058CD RID: 22733 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Store(short* address, [TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3",
			"Value4"
		})] ValueTuple<Vector64<short>, Vector64<short>, Vector64<short>, Vector64<short>> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058CE RID: 22734 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Store(ushort* address, [TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3",
			"Value4"
		})] ValueTuple<Vector64<ushort>, Vector64<ushort>, Vector64<ushort>, Vector64<ushort>> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058CF RID: 22735 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Store(int* address, [TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3",
			"Value4"
		})] ValueTuple<Vector64<int>, Vector64<int>, Vector64<int>, Vector64<int>> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058D0 RID: 22736 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Store(uint* address, [TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3",
			"Value4"
		})] ValueTuple<Vector64<uint>, Vector64<uint>, Vector64<uint>, Vector64<uint>> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058D1 RID: 22737 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Store(float* address, [TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3",
			"Value4"
		})] ValueTuple<Vector64<float>, Vector64<float>, Vector64<float>, Vector64<float>> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058D2 RID: 22738 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<byte> Subtract(Vector64<byte> left, Vector64<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058D3 RID: 22739 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> Subtract(Vector64<short> left, Vector64<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058D4 RID: 22740 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> Subtract(Vector64<int> left, Vector64<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058D5 RID: 22741 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<sbyte> Subtract(Vector64<sbyte> left, Vector64<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058D6 RID: 22742 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<float> Subtract(Vector64<float> left, Vector64<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058D7 RID: 22743 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ushort> Subtract(Vector64<ushort> left, Vector64<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058D8 RID: 22744 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> Subtract(Vector64<uint> left, Vector64<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058D9 RID: 22745 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> Subtract(Vector128<byte> left, Vector128<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058DA RID: 22746 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> Subtract(Vector128<short> left, Vector128<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058DB RID: 22747 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> Subtract(Vector128<int> left, Vector128<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058DC RID: 22748 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> Subtract(Vector128<long> left, Vector128<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058DD RID: 22749 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> Subtract(Vector128<sbyte> left, Vector128<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058DE RID: 22750 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> Subtract(Vector128<float> left, Vector128<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058DF RID: 22751 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> Subtract(Vector128<ushort> left, Vector128<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058E0 RID: 22752 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> Subtract(Vector128<uint> left, Vector128<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058E1 RID: 22753 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> Subtract(Vector128<ulong> left, Vector128<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058E2 RID: 22754 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<byte> SubtractHighNarrowingLower(Vector128<ushort> left, Vector128<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058E3 RID: 22755 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> SubtractHighNarrowingLower(Vector128<int> left, Vector128<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058E4 RID: 22756 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> SubtractHighNarrowingLower(Vector128<long> left, Vector128<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058E5 RID: 22757 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<sbyte> SubtractHighNarrowingLower(Vector128<short> left, Vector128<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058E6 RID: 22758 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ushort> SubtractHighNarrowingLower(Vector128<uint> left, Vector128<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058E7 RID: 22759 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> SubtractHighNarrowingLower(Vector128<ulong> left, Vector128<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058E8 RID: 22760 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> SubtractHighNarrowingUpper(Vector64<byte> lower, Vector128<ushort> left, Vector128<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058E9 RID: 22761 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> SubtractHighNarrowingUpper(Vector64<short> lower, Vector128<int> left, Vector128<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058EA RID: 22762 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> SubtractHighNarrowingUpper(Vector64<int> lower, Vector128<long> left, Vector128<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058EB RID: 22763 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> SubtractHighNarrowingUpper(Vector64<sbyte> lower, Vector128<short> left, Vector128<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058EC RID: 22764 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> SubtractHighNarrowingUpper(Vector64<ushort> lower, Vector128<uint> left, Vector128<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058ED RID: 22765 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> SubtractHighNarrowingUpper(Vector64<uint> lower, Vector128<ulong> left, Vector128<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058EE RID: 22766 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<byte> SubtractRoundedHighNarrowingLower(Vector128<ushort> left, Vector128<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058EF RID: 22767 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> SubtractRoundedHighNarrowingLower(Vector128<int> left, Vector128<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058F0 RID: 22768 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> SubtractRoundedHighNarrowingLower(Vector128<long> left, Vector128<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058F1 RID: 22769 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<sbyte> SubtractRoundedHighNarrowingLower(Vector128<short> left, Vector128<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058F2 RID: 22770 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ushort> SubtractRoundedHighNarrowingLower(Vector128<uint> left, Vector128<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058F3 RID: 22771 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> SubtractRoundedHighNarrowingLower(Vector128<ulong> left, Vector128<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058F4 RID: 22772 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> SubtractRoundedHighNarrowingUpper(Vector64<byte> lower, Vector128<ushort> left, Vector128<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058F5 RID: 22773 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> SubtractRoundedHighNarrowingUpper(Vector64<short> lower, Vector128<int> left, Vector128<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058F6 RID: 22774 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> SubtractRoundedHighNarrowingUpper(Vector64<int> lower, Vector128<long> left, Vector128<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058F7 RID: 22775 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> SubtractRoundedHighNarrowingUpper(Vector64<sbyte> lower, Vector128<short> left, Vector128<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058F8 RID: 22776 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> SubtractRoundedHighNarrowingUpper(Vector64<ushort> lower, Vector128<uint> left, Vector128<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058F9 RID: 22777 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> SubtractRoundedHighNarrowingUpper(Vector64<uint> lower, Vector128<ulong> left, Vector128<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058FA RID: 22778 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<byte> SubtractSaturate(Vector64<byte> left, Vector64<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058FB RID: 22779 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> SubtractSaturate(Vector64<short> left, Vector64<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058FC RID: 22780 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> SubtractSaturate(Vector64<int> left, Vector64<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058FD RID: 22781 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<sbyte> SubtractSaturate(Vector64<sbyte> left, Vector64<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058FE RID: 22782 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ushort> SubtractSaturate(Vector64<ushort> left, Vector64<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060058FF RID: 22783 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> SubtractSaturate(Vector64<uint> left, Vector64<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005900 RID: 22784 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> SubtractSaturate(Vector128<byte> left, Vector128<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005901 RID: 22785 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> SubtractSaturate(Vector128<short> left, Vector128<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005902 RID: 22786 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> SubtractSaturate(Vector128<int> left, Vector128<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005903 RID: 22787 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> SubtractSaturate(Vector128<long> left, Vector128<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005904 RID: 22788 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> SubtractSaturate(Vector128<sbyte> left, Vector128<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005905 RID: 22789 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> SubtractSaturate(Vector128<ushort> left, Vector128<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005906 RID: 22790 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> SubtractSaturate(Vector128<uint> left, Vector128<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005907 RID: 22791 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> SubtractSaturate(Vector128<ulong> left, Vector128<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005908 RID: 22792 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<long> SubtractSaturateScalar(Vector64<long> left, Vector64<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005909 RID: 22793 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ulong> SubtractSaturateScalar(Vector64<ulong> left, Vector64<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600590A RID: 22794 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<double> SubtractScalar(Vector64<double> left, Vector64<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600590B RID: 22795 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<long> SubtractScalar(Vector64<long> left, Vector64<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600590C RID: 22796 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<float> SubtractScalar(Vector64<float> left, Vector64<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600590D RID: 22797 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ulong> SubtractScalar(Vector64<ulong> left, Vector64<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600590E RID: 22798 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> SubtractWideningLower(Vector64<byte> left, Vector64<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600590F RID: 22799 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> SubtractWideningLower(Vector64<short> left, Vector64<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005910 RID: 22800 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> SubtractWideningLower(Vector64<int> left, Vector64<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005911 RID: 22801 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> SubtractWideningLower(Vector64<sbyte> left, Vector64<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005912 RID: 22802 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> SubtractWideningLower(Vector64<ushort> left, Vector64<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005913 RID: 22803 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> SubtractWideningLower(Vector64<uint> left, Vector64<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005914 RID: 22804 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> SubtractWideningLower(Vector128<short> left, Vector64<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005915 RID: 22805 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> SubtractWideningLower(Vector128<int> left, Vector64<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005916 RID: 22806 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> SubtractWideningLower(Vector128<long> left, Vector64<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005917 RID: 22807 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> SubtractWideningLower(Vector128<ushort> left, Vector64<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005918 RID: 22808 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> SubtractWideningLower(Vector128<uint> left, Vector64<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005919 RID: 22809 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> SubtractWideningLower(Vector128<ulong> left, Vector64<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600591A RID: 22810 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> SubtractWideningUpper(Vector128<byte> left, Vector128<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600591B RID: 22811 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> SubtractWideningUpper(Vector128<short> left, Vector128<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600591C RID: 22812 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> SubtractWideningUpper(Vector128<short> left, Vector128<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600591D RID: 22813 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> SubtractWideningUpper(Vector128<int> left, Vector128<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600591E RID: 22814 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> SubtractWideningUpper(Vector128<int> left, Vector128<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600591F RID: 22815 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> SubtractWideningUpper(Vector128<long> left, Vector128<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005920 RID: 22816 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> SubtractWideningUpper(Vector128<sbyte> left, Vector128<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005921 RID: 22817 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> SubtractWideningUpper(Vector128<ushort> left, Vector128<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005922 RID: 22818 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> SubtractWideningUpper(Vector128<ushort> left, Vector128<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005923 RID: 22819 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> SubtractWideningUpper(Vector128<uint> left, Vector128<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005924 RID: 22820 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> SubtractWideningUpper(Vector128<uint> left, Vector128<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005925 RID: 22821 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> SubtractWideningUpper(Vector128<ulong> left, Vector128<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005926 RID: 22822 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<byte> VectorTableLookup(Vector128<byte> table, Vector64<byte> byteIndexes)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005927 RID: 22823 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<sbyte> VectorTableLookup(Vector128<sbyte> table, Vector64<sbyte> byteIndexes)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005928 RID: 22824 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<byte> VectorTableLookup(ValueTuple<Vector128<byte>, Vector128<byte>> table, Vector64<byte> byteIndexes)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005929 RID: 22825 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<sbyte> VectorTableLookup(ValueTuple<Vector128<sbyte>, Vector128<sbyte>> table, Vector64<sbyte> byteIndexes)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600592A RID: 22826 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<byte> VectorTableLookup(ValueTuple<Vector128<byte>, Vector128<byte>, Vector128<byte>> table, Vector64<byte> byteIndexes)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600592B RID: 22827 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<sbyte> VectorTableLookup(ValueTuple<Vector128<sbyte>, Vector128<sbyte>, Vector128<sbyte>> table, Vector64<sbyte> byteIndexes)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600592C RID: 22828 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<byte> VectorTableLookup(ValueTuple<Vector128<byte>, Vector128<byte>, Vector128<byte>, Vector128<byte>> table, Vector64<byte> byteIndexes)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600592D RID: 22829 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<sbyte> VectorTableLookup(ValueTuple<Vector128<sbyte>, Vector128<sbyte>, Vector128<sbyte>, Vector128<sbyte>> table, Vector64<sbyte> byteIndexes)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600592E RID: 22830 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<byte> VectorTableLookupExtension(Vector64<byte> defaultValues, Vector128<byte> table, Vector64<byte> byteIndexes)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600592F RID: 22831 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<sbyte> VectorTableLookupExtension(Vector64<sbyte> defaultValues, Vector128<sbyte> table, Vector64<sbyte> byteIndexes)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005930 RID: 22832 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<byte> VectorTableLookupExtension(Vector64<byte> defaultValues, ValueTuple<Vector128<byte>, Vector128<byte>> table, Vector64<byte> byteIndexes)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005931 RID: 22833 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<sbyte> VectorTableLookupExtension(Vector64<sbyte> defaultValues, ValueTuple<Vector128<sbyte>, Vector128<sbyte>> table, Vector64<sbyte> byteIndexes)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005932 RID: 22834 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<byte> VectorTableLookupExtension(Vector64<byte> defaultValues, ValueTuple<Vector128<byte>, Vector128<byte>, Vector128<byte>> table, Vector64<byte> byteIndexes)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005933 RID: 22835 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<sbyte> VectorTableLookupExtension(Vector64<sbyte> defaultValues, ValueTuple<Vector128<sbyte>, Vector128<sbyte>, Vector128<sbyte>> table, Vector64<sbyte> byteIndexes)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005934 RID: 22836 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<byte> VectorTableLookupExtension(Vector64<byte> defaultValues, ValueTuple<Vector128<byte>, Vector128<byte>, Vector128<byte>, Vector128<byte>> table, Vector64<byte> byteIndexes)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005935 RID: 22837 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<sbyte> VectorTableLookupExtension(Vector64<sbyte> defaultValues, ValueTuple<Vector128<sbyte>, Vector128<sbyte>, Vector128<sbyte>, Vector128<sbyte>> table, Vector64<sbyte> byteIndexes)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005936 RID: 22838 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<byte> Xor(Vector64<byte> left, Vector64<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005937 RID: 22839 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<double> Xor(Vector64<double> left, Vector64<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005938 RID: 22840 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> Xor(Vector64<short> left, Vector64<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005939 RID: 22841 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> Xor(Vector64<int> left, Vector64<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600593A RID: 22842 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<long> Xor(Vector64<long> left, Vector64<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600593B RID: 22843 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<sbyte> Xor(Vector64<sbyte> left, Vector64<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600593C RID: 22844 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<float> Xor(Vector64<float> left, Vector64<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600593D RID: 22845 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ushort> Xor(Vector64<ushort> left, Vector64<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600593E RID: 22846 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> Xor(Vector64<uint> left, Vector64<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600593F RID: 22847 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<ulong> Xor(Vector64<ulong> left, Vector64<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005940 RID: 22848 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> Xor(Vector128<byte> left, Vector128<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005941 RID: 22849 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> Xor(Vector128<double> left, Vector128<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005942 RID: 22850 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> Xor(Vector128<short> left, Vector128<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005943 RID: 22851 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> Xor(Vector128<int> left, Vector128<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005944 RID: 22852 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> Xor(Vector128<long> left, Vector128<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005945 RID: 22853 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> Xor(Vector128<sbyte> left, Vector128<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005946 RID: 22854 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> Xor(Vector128<float> left, Vector128<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005947 RID: 22855 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> Xor(Vector128<ushort> left, Vector128<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005948 RID: 22856 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> Xor(Vector128<uint> left, Vector128<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005949 RID: 22857 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> Xor(Vector128<ulong> left, Vector128<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600594A RID: 22858 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> ZeroExtendWideningLower(Vector64<byte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600594B RID: 22859 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> ZeroExtendWideningLower(Vector64<short> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600594C RID: 22860 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> ZeroExtendWideningLower(Vector64<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600594D RID: 22861 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> ZeroExtendWideningLower(Vector64<sbyte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600594E RID: 22862 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> ZeroExtendWideningLower(Vector64<ushort> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600594F RID: 22863 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> ZeroExtendWideningLower(Vector64<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005950 RID: 22864 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> ZeroExtendWideningUpper(Vector128<byte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005951 RID: 22865 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> ZeroExtendWideningUpper(Vector128<short> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005952 RID: 22866 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> ZeroExtendWideningUpper(Vector128<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005953 RID: 22867 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> ZeroExtendWideningUpper(Vector128<sbyte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005954 RID: 22868 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> ZeroExtendWideningUpper(Vector128<ushort> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005955 RID: 22869 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> ZeroExtendWideningUpper(Vector128<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x02000554 RID: 1364
		public new abstract class Arm64 : ArmBase.Arm64
		{
			// Token: 0x17000D63 RID: 3427
			// (get) Token: 0x06005956 RID: 22870 RVA: 0x00007B65 File Offset: 0x00005D65
			public new static bool IsSupported
			{
				[Intrinsic]
				get
				{
					return false;
				}
			}

			// Token: 0x06005957 RID: 22871 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<double> Abs(Vector128<double> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005958 RID: 22872 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<ulong> Abs(Vector128<long> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005959 RID: 22873 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<long> AbsSaturate(Vector128<long> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600595A RID: 22874 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<short> AbsSaturateScalar(Vector64<short> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600595B RID: 22875 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<int> AbsSaturateScalar(Vector64<int> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600595C RID: 22876 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<long> AbsSaturateScalar(Vector64<long> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600595D RID: 22877 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<sbyte> AbsSaturateScalar(Vector64<sbyte> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600595E RID: 22878 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<ulong> AbsScalar(Vector64<long> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600595F RID: 22879 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<double> AbsoluteCompareGreaterThan(Vector128<double> left, Vector128<double> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005960 RID: 22880 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<double> AbsoluteCompareGreaterThanScalar(Vector64<double> left, Vector64<double> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005961 RID: 22881 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<float> AbsoluteCompareGreaterThanScalar(Vector64<float> left, Vector64<float> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005962 RID: 22882 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<double> AbsoluteCompareGreaterThanOrEqual(Vector128<double> left, Vector128<double> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005963 RID: 22883 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<double> AbsoluteCompareGreaterThanOrEqualScalar(Vector64<double> left, Vector64<double> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005964 RID: 22884 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<float> AbsoluteCompareGreaterThanOrEqualScalar(Vector64<float> left, Vector64<float> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005965 RID: 22885 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<double> AbsoluteCompareLessThan(Vector128<double> left, Vector128<double> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005966 RID: 22886 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<double> AbsoluteCompareLessThanScalar(Vector64<double> left, Vector64<double> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005967 RID: 22887 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<float> AbsoluteCompareLessThanScalar(Vector64<float> left, Vector64<float> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005968 RID: 22888 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<double> AbsoluteCompareLessThanOrEqual(Vector128<double> left, Vector128<double> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005969 RID: 22889 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<double> AbsoluteCompareLessThanOrEqualScalar(Vector64<double> left, Vector64<double> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600596A RID: 22890 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<float> AbsoluteCompareLessThanOrEqualScalar(Vector64<float> left, Vector64<float> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600596B RID: 22891 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<double> AbsoluteDifference(Vector128<double> left, Vector128<double> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600596C RID: 22892 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<double> AbsoluteDifferenceScalar(Vector64<double> left, Vector64<double> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600596D RID: 22893 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<float> AbsoluteDifferenceScalar(Vector64<float> left, Vector64<float> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600596E RID: 22894 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<double> Add(Vector128<double> left, Vector128<double> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600596F RID: 22895 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<byte> AddAcross(Vector64<byte> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005970 RID: 22896 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<short> AddAcross(Vector64<short> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005971 RID: 22897 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<sbyte> AddAcross(Vector64<sbyte> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005972 RID: 22898 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<ushort> AddAcross(Vector64<ushort> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005973 RID: 22899 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<byte> AddAcross(Vector128<byte> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005974 RID: 22900 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<short> AddAcross(Vector128<short> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005975 RID: 22901 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<int> AddAcross(Vector128<int> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005976 RID: 22902 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<sbyte> AddAcross(Vector128<sbyte> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005977 RID: 22903 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<ushort> AddAcross(Vector128<ushort> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005978 RID: 22904 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<uint> AddAcross(Vector128<uint> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005979 RID: 22905 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<ushort> AddAcrossWidening(Vector64<byte> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600597A RID: 22906 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<int> AddAcrossWidening(Vector64<short> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600597B RID: 22907 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<short> AddAcrossWidening(Vector64<sbyte> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600597C RID: 22908 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<uint> AddAcrossWidening(Vector64<ushort> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600597D RID: 22909 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<ushort> AddAcrossWidening(Vector128<byte> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600597E RID: 22910 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<int> AddAcrossWidening(Vector128<short> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600597F RID: 22911 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<long> AddAcrossWidening(Vector128<int> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005980 RID: 22912 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<short> AddAcrossWidening(Vector128<sbyte> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005981 RID: 22913 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<uint> AddAcrossWidening(Vector128<ushort> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005982 RID: 22914 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<ulong> AddAcrossWidening(Vector128<uint> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005983 RID: 22915 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<byte> AddPairwise(Vector128<byte> left, Vector128<byte> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005984 RID: 22916 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<double> AddPairwise(Vector128<double> left, Vector128<double> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005985 RID: 22917 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<short> AddPairwise(Vector128<short> left, Vector128<short> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005986 RID: 22918 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<int> AddPairwise(Vector128<int> left, Vector128<int> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005987 RID: 22919 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<long> AddPairwise(Vector128<long> left, Vector128<long> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005988 RID: 22920 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<sbyte> AddPairwise(Vector128<sbyte> left, Vector128<sbyte> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005989 RID: 22921 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<float> AddPairwise(Vector128<float> left, Vector128<float> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600598A RID: 22922 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<ushort> AddPairwise(Vector128<ushort> left, Vector128<ushort> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600598B RID: 22923 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<uint> AddPairwise(Vector128<uint> left, Vector128<uint> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600598C RID: 22924 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<ulong> AddPairwise(Vector128<ulong> left, Vector128<ulong> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600598D RID: 22925 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<float> AddPairwiseScalar(Vector64<float> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600598E RID: 22926 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<double> AddPairwiseScalar(Vector128<double> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600598F RID: 22927 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<long> AddPairwiseScalar(Vector128<long> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005990 RID: 22928 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<ulong> AddPairwiseScalar(Vector128<ulong> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005991 RID: 22929 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<byte> AddSaturate(Vector64<byte> left, Vector64<sbyte> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005992 RID: 22930 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<short> AddSaturate(Vector64<short> left, Vector64<ushort> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005993 RID: 22931 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<int> AddSaturate(Vector64<int> left, Vector64<uint> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005994 RID: 22932 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<sbyte> AddSaturate(Vector64<sbyte> left, Vector64<byte> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005995 RID: 22933 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<ushort> AddSaturate(Vector64<ushort> left, Vector64<short> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005996 RID: 22934 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<uint> AddSaturate(Vector64<uint> left, Vector64<int> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005997 RID: 22935 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<byte> AddSaturate(Vector128<byte> left, Vector128<sbyte> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005998 RID: 22936 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<short> AddSaturate(Vector128<short> left, Vector128<ushort> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005999 RID: 22937 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<int> AddSaturate(Vector128<int> left, Vector128<uint> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600599A RID: 22938 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<long> AddSaturate(Vector128<long> left, Vector128<ulong> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600599B RID: 22939 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<sbyte> AddSaturate(Vector128<sbyte> left, Vector128<byte> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600599C RID: 22940 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<ushort> AddSaturate(Vector128<ushort> left, Vector128<short> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600599D RID: 22941 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<uint> AddSaturate(Vector128<uint> left, Vector128<int> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600599E RID: 22942 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<ulong> AddSaturate(Vector128<ulong> left, Vector128<long> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600599F RID: 22943 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<byte> AddSaturateScalar(Vector64<byte> left, Vector64<byte> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059A0 RID: 22944 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<byte> AddSaturateScalar(Vector64<byte> left, Vector64<sbyte> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059A1 RID: 22945 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<short> AddSaturateScalar(Vector64<short> left, Vector64<short> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059A2 RID: 22946 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<short> AddSaturateScalar(Vector64<short> left, Vector64<ushort> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059A3 RID: 22947 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<int> AddSaturateScalar(Vector64<int> left, Vector64<int> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059A4 RID: 22948 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<int> AddSaturateScalar(Vector64<int> left, Vector64<uint> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059A5 RID: 22949 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<long> AddSaturateScalar(Vector64<long> left, Vector64<ulong> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059A6 RID: 22950 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<sbyte> AddSaturateScalar(Vector64<sbyte> left, Vector64<sbyte> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059A7 RID: 22951 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<sbyte> AddSaturateScalar(Vector64<sbyte> left, Vector64<byte> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059A8 RID: 22952 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<ushort> AddSaturateScalar(Vector64<ushort> left, Vector64<ushort> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059A9 RID: 22953 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<ushort> AddSaturateScalar(Vector64<ushort> left, Vector64<short> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059AA RID: 22954 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<uint> AddSaturateScalar(Vector64<uint> left, Vector64<uint> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059AB RID: 22955 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<uint> AddSaturateScalar(Vector64<uint> left, Vector64<int> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059AC RID: 22956 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<ulong> AddSaturateScalar(Vector64<ulong> left, Vector64<long> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059AD RID: 22957 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<double> Ceiling(Vector128<double> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059AE RID: 22958 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<double> CompareEqual(Vector128<double> left, Vector128<double> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059AF RID: 22959 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<long> CompareEqual(Vector128<long> left, Vector128<long> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059B0 RID: 22960 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<ulong> CompareEqual(Vector128<ulong> left, Vector128<ulong> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059B1 RID: 22961 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<double> CompareEqualScalar(Vector64<double> left, Vector64<double> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059B2 RID: 22962 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<long> CompareEqualScalar(Vector64<long> left, Vector64<long> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059B3 RID: 22963 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<float> CompareEqualScalar(Vector64<float> left, Vector64<float> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059B4 RID: 22964 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<ulong> CompareEqualScalar(Vector64<ulong> left, Vector64<ulong> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059B5 RID: 22965 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<double> CompareGreaterThan(Vector128<double> left, Vector128<double> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059B6 RID: 22966 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<long> CompareGreaterThan(Vector128<long> left, Vector128<long> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059B7 RID: 22967 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<ulong> CompareGreaterThan(Vector128<ulong> left, Vector128<ulong> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059B8 RID: 22968 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<double> CompareGreaterThanScalar(Vector64<double> left, Vector64<double> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059B9 RID: 22969 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<long> CompareGreaterThanScalar(Vector64<long> left, Vector64<long> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059BA RID: 22970 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<float> CompareGreaterThanScalar(Vector64<float> left, Vector64<float> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059BB RID: 22971 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<ulong> CompareGreaterThanScalar(Vector64<ulong> left, Vector64<ulong> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059BC RID: 22972 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<double> CompareGreaterThanOrEqual(Vector128<double> left, Vector128<double> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059BD RID: 22973 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<long> CompareGreaterThanOrEqual(Vector128<long> left, Vector128<long> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059BE RID: 22974 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<ulong> CompareGreaterThanOrEqual(Vector128<ulong> left, Vector128<ulong> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059BF RID: 22975 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<double> CompareGreaterThanOrEqualScalar(Vector64<double> left, Vector64<double> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059C0 RID: 22976 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<long> CompareGreaterThanOrEqualScalar(Vector64<long> left, Vector64<long> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059C1 RID: 22977 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<float> CompareGreaterThanOrEqualScalar(Vector64<float> left, Vector64<float> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059C2 RID: 22978 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<ulong> CompareGreaterThanOrEqualScalar(Vector64<ulong> left, Vector64<ulong> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059C3 RID: 22979 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<double> CompareLessThan(Vector128<double> left, Vector128<double> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059C4 RID: 22980 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<long> CompareLessThan(Vector128<long> left, Vector128<long> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059C5 RID: 22981 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<ulong> CompareLessThan(Vector128<ulong> left, Vector128<ulong> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059C6 RID: 22982 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<double> CompareLessThanScalar(Vector64<double> left, Vector64<double> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059C7 RID: 22983 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<long> CompareLessThanScalar(Vector64<long> left, Vector64<long> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059C8 RID: 22984 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<float> CompareLessThanScalar(Vector64<float> left, Vector64<float> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059C9 RID: 22985 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<ulong> CompareLessThanScalar(Vector64<ulong> left, Vector64<ulong> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059CA RID: 22986 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<double> CompareLessThanOrEqual(Vector128<double> left, Vector128<double> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059CB RID: 22987 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<long> CompareLessThanOrEqual(Vector128<long> left, Vector128<long> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059CC RID: 22988 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<ulong> CompareLessThanOrEqual(Vector128<ulong> left, Vector128<ulong> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059CD RID: 22989 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<double> CompareLessThanOrEqualScalar(Vector64<double> left, Vector64<double> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059CE RID: 22990 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<long> CompareLessThanOrEqualScalar(Vector64<long> left, Vector64<long> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059CF RID: 22991 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<float> CompareLessThanOrEqualScalar(Vector64<float> left, Vector64<float> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059D0 RID: 22992 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<ulong> CompareLessThanOrEqualScalar(Vector64<ulong> left, Vector64<ulong> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059D1 RID: 22993 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<double> CompareTest(Vector128<double> left, Vector128<double> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059D2 RID: 22994 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<long> CompareTest(Vector128<long> left, Vector128<long> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059D3 RID: 22995 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<ulong> CompareTest(Vector128<ulong> left, Vector128<ulong> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059D4 RID: 22996 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<double> CompareTestScalar(Vector64<double> left, Vector64<double> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059D5 RID: 22997 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<long> CompareTestScalar(Vector64<long> left, Vector64<long> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059D6 RID: 22998 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<ulong> CompareTestScalar(Vector64<ulong> left, Vector64<ulong> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059D7 RID: 22999 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<double> ConvertToDouble(Vector64<float> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059D8 RID: 23000 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<double> ConvertToDouble(Vector128<long> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059D9 RID: 23001 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<double> ConvertToDouble(Vector128<ulong> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059DA RID: 23002 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<double> ConvertToDoubleScalar(Vector64<long> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059DB RID: 23003 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<double> ConvertToDoubleScalar(Vector64<ulong> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059DC RID: 23004 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<double> ConvertToDoubleUpper(Vector128<float> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059DD RID: 23005 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<long> ConvertToInt64RoundAwayFromZero(Vector128<double> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059DE RID: 23006 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<long> ConvertToInt64RoundAwayFromZeroScalar(Vector64<double> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059DF RID: 23007 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<long> ConvertToInt64RoundToEven(Vector128<double> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059E0 RID: 23008 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<long> ConvertToInt64RoundToEvenScalar(Vector64<double> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059E1 RID: 23009 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<long> ConvertToInt64RoundToNegativeInfinity(Vector128<double> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059E2 RID: 23010 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<long> ConvertToInt64RoundToNegativeInfinityScalar(Vector64<double> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059E3 RID: 23011 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<long> ConvertToInt64RoundToPositiveInfinity(Vector128<double> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059E4 RID: 23012 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<long> ConvertToInt64RoundToPositiveInfinityScalar(Vector64<double> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059E5 RID: 23013 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<long> ConvertToInt64RoundToZero(Vector128<double> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059E6 RID: 23014 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<long> ConvertToInt64RoundToZeroScalar(Vector64<double> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059E7 RID: 23015 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<float> ConvertToSingleLower(Vector128<double> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059E8 RID: 23016 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<float> ConvertToSingleRoundToOddLower(Vector128<double> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059E9 RID: 23017 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<float> ConvertToSingleRoundToOddUpper(Vector64<float> lower, Vector128<double> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059EA RID: 23018 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<float> ConvertToSingleUpper(Vector64<float> lower, Vector128<double> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059EB RID: 23019 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<ulong> ConvertToUInt64RoundAwayFromZero(Vector128<double> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059EC RID: 23020 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<ulong> ConvertToUInt64RoundAwayFromZeroScalar(Vector64<double> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059ED RID: 23021 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<ulong> ConvertToUInt64RoundToEven(Vector128<double> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059EE RID: 23022 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<ulong> ConvertToUInt64RoundToEvenScalar(Vector64<double> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059EF RID: 23023 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<ulong> ConvertToUInt64RoundToNegativeInfinity(Vector128<double> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059F0 RID: 23024 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<ulong> ConvertToUInt64RoundToNegativeInfinityScalar(Vector64<double> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059F1 RID: 23025 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<ulong> ConvertToUInt64RoundToPositiveInfinity(Vector128<double> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059F2 RID: 23026 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<ulong> ConvertToUInt64RoundToPositiveInfinityScalar(Vector64<double> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059F3 RID: 23027 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<ulong> ConvertToUInt64RoundToZero(Vector128<double> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059F4 RID: 23028 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<ulong> ConvertToUInt64RoundToZeroScalar(Vector64<double> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059F5 RID: 23029 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<float> Divide(Vector64<float> left, Vector64<float> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059F6 RID: 23030 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<double> Divide(Vector128<double> left, Vector128<double> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059F7 RID: 23031 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<float> Divide(Vector128<float> left, Vector128<float> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059F8 RID: 23032 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<double> DuplicateSelectedScalarToVector128(Vector128<double> value, [ConstantExpected(Max = 1)] byte index)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059F9 RID: 23033 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<long> DuplicateSelectedScalarToVector128(Vector128<long> value, [ConstantExpected(Max = 1)] byte index)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059FA RID: 23034 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<ulong> DuplicateSelectedScalarToVector128(Vector128<ulong> value, [ConstantExpected(Max = 1)] byte index)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059FB RID: 23035 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<double> DuplicateToVector128(double value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059FC RID: 23036 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<long> DuplicateToVector128(long value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059FD RID: 23037 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<ulong> DuplicateToVector128(ulong value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059FE RID: 23038 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<byte> ExtractNarrowingSaturateScalar(Vector64<ushort> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060059FF RID: 23039 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<short> ExtractNarrowingSaturateScalar(Vector64<int> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A00 RID: 23040 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<int> ExtractNarrowingSaturateScalar(Vector64<long> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A01 RID: 23041 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<sbyte> ExtractNarrowingSaturateScalar(Vector64<short> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A02 RID: 23042 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<ushort> ExtractNarrowingSaturateScalar(Vector64<uint> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A03 RID: 23043 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<uint> ExtractNarrowingSaturateScalar(Vector64<ulong> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A04 RID: 23044 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<byte> ExtractNarrowingSaturateUnsignedScalar(Vector64<short> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A05 RID: 23045 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<ushort> ExtractNarrowingSaturateUnsignedScalar(Vector64<int> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A06 RID: 23046 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<uint> ExtractNarrowingSaturateUnsignedScalar(Vector64<long> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A07 RID: 23047 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<double> Floor(Vector128<double> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A08 RID: 23048 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<double> FusedMultiplyAdd(Vector128<double> addend, Vector128<double> left, Vector128<double> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A09 RID: 23049 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<float> FusedMultiplyAddByScalar(Vector64<float> addend, Vector64<float> left, Vector64<float> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A0A RID: 23050 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<double> FusedMultiplyAddByScalar(Vector128<double> addend, Vector128<double> left, Vector64<double> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A0B RID: 23051 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<float> FusedMultiplyAddByScalar(Vector128<float> addend, Vector128<float> left, Vector64<float> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A0C RID: 23052 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<float> FusedMultiplyAddBySelectedScalar(Vector64<float> addend, Vector64<float> left, Vector64<float> right, [ConstantExpected(Max = 1)] byte rightIndex)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A0D RID: 23053 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<float> FusedMultiplyAddBySelectedScalar(Vector64<float> addend, Vector64<float> left, Vector128<float> right, [ConstantExpected(Max = 3)] byte rightIndex)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A0E RID: 23054 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<double> FusedMultiplyAddBySelectedScalar(Vector128<double> addend, Vector128<double> left, Vector128<double> right, [ConstantExpected(Max = 1)] byte rightIndex)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A0F RID: 23055 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<float> FusedMultiplyAddBySelectedScalar(Vector128<float> addend, Vector128<float> left, Vector64<float> right, [ConstantExpected(Max = 1)] byte rightIndex)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A10 RID: 23056 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<float> FusedMultiplyAddBySelectedScalar(Vector128<float> addend, Vector128<float> left, Vector128<float> right, [ConstantExpected(Max = 3)] byte rightIndex)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A11 RID: 23057 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<double> FusedMultiplyAddScalarBySelectedScalar(Vector64<double> addend, Vector64<double> left, Vector128<double> right, [ConstantExpected(Max = 1)] byte rightIndex)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A12 RID: 23058 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<float> FusedMultiplyAddScalarBySelectedScalar(Vector64<float> addend, Vector64<float> left, Vector64<float> right, [ConstantExpected(Max = 1)] byte rightIndex)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A13 RID: 23059 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<float> FusedMultiplyAddScalarBySelectedScalar(Vector64<float> addend, Vector64<float> left, Vector128<float> right, [ConstantExpected(Max = 3)] byte rightIndex)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A14 RID: 23060 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<double> FusedMultiplySubtract(Vector128<double> minuend, Vector128<double> left, Vector128<double> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A15 RID: 23061 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<float> FusedMultiplySubtractByScalar(Vector64<float> minuend, Vector64<float> left, Vector64<float> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A16 RID: 23062 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<double> FusedMultiplySubtractByScalar(Vector128<double> minuend, Vector128<double> left, Vector64<double> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A17 RID: 23063 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<float> FusedMultiplySubtractByScalar(Vector128<float> minuend, Vector128<float> left, Vector64<float> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A18 RID: 23064 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<float> FusedMultiplySubtractBySelectedScalar(Vector64<float> minuend, Vector64<float> left, Vector64<float> right, [ConstantExpected(Max = 1)] byte rightIndex)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A19 RID: 23065 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<float> FusedMultiplySubtractBySelectedScalar(Vector64<float> minuend, Vector64<float> left, Vector128<float> right, [ConstantExpected(Max = 3)] byte rightIndex)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A1A RID: 23066 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<double> FusedMultiplySubtractBySelectedScalar(Vector128<double> minuend, Vector128<double> left, Vector128<double> right, [ConstantExpected(Max = 1)] byte rightIndex)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A1B RID: 23067 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<float> FusedMultiplySubtractBySelectedScalar(Vector128<float> minuend, Vector128<float> left, Vector64<float> right, [ConstantExpected(Max = 1)] byte rightIndex)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A1C RID: 23068 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<float> FusedMultiplySubtractBySelectedScalar(Vector128<float> minuend, Vector128<float> left, Vector128<float> right, [ConstantExpected(Max = 3)] byte rightIndex)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A1D RID: 23069 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<double> FusedMultiplySubtractScalarBySelectedScalar(Vector64<double> minuend, Vector64<double> left, Vector128<double> right, [ConstantExpected(Max = 1)] byte rightIndex)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A1E RID: 23070 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<float> FusedMultiplySubtractScalarBySelectedScalar(Vector64<float> minuend, Vector64<float> left, Vector64<float> right, [ConstantExpected(Max = 1)] byte rightIndex)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A1F RID: 23071 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<float> FusedMultiplySubtractScalarBySelectedScalar(Vector64<float> minuend, Vector64<float> left, Vector128<float> right, [ConstantExpected(Max = 3)] byte rightIndex)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A20 RID: 23072 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<byte> InsertSelectedScalar(Vector64<byte> result, [ConstantExpected(Max = 7)] byte resultIndex, Vector64<byte> value, [ConstantExpected(Max = 7)] byte valueIndex)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A21 RID: 23073 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<byte> InsertSelectedScalar(Vector64<byte> result, [ConstantExpected(Max = 7)] byte resultIndex, Vector128<byte> value, [ConstantExpected(Max = 15)] byte valueIndex)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A22 RID: 23074 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<short> InsertSelectedScalar(Vector64<short> result, [ConstantExpected(Max = 3)] byte resultIndex, Vector64<short> value, [ConstantExpected(Max = 3)] byte valueIndex)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A23 RID: 23075 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<short> InsertSelectedScalar(Vector64<short> result, [ConstantExpected(Max = 3)] byte resultIndex, Vector128<short> value, [ConstantExpected(Max = 7)] byte valueIndex)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A24 RID: 23076 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<int> InsertSelectedScalar(Vector64<int> result, [ConstantExpected(Max = 1)] byte resultIndex, Vector64<int> value, [ConstantExpected(Max = 1)] byte valueIndex)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A25 RID: 23077 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<int> InsertSelectedScalar(Vector64<int> result, [ConstantExpected(Max = 1)] byte resultIndex, Vector128<int> value, [ConstantExpected(Max = 3)] byte valueIndex)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A26 RID: 23078 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<sbyte> InsertSelectedScalar(Vector64<sbyte> result, [ConstantExpected(Max = 7)] byte resultIndex, Vector64<sbyte> value, [ConstantExpected(Max = 7)] byte valueIndex)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A27 RID: 23079 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<sbyte> InsertSelectedScalar(Vector64<sbyte> result, [ConstantExpected(Max = 7)] byte resultIndex, Vector128<sbyte> value, [ConstantExpected(Max = 15)] byte valueIndex)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A28 RID: 23080 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<float> InsertSelectedScalar(Vector64<float> result, [ConstantExpected(Max = 1)] byte resultIndex, Vector64<float> value, [ConstantExpected(Max = 1)] byte valueIndex)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A29 RID: 23081 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<float> InsertSelectedScalar(Vector64<float> result, [ConstantExpected(Max = 1)] byte resultIndex, Vector128<float> value, [ConstantExpected(Max = 3)] byte valueIndex)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A2A RID: 23082 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<ushort> InsertSelectedScalar(Vector64<ushort> result, [ConstantExpected(Max = 3)] byte resultIndex, Vector64<ushort> value, [ConstantExpected(Max = 3)] byte valueIndex)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A2B RID: 23083 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<ushort> InsertSelectedScalar(Vector64<ushort> result, [ConstantExpected(Max = 3)] byte resultIndex, Vector128<ushort> value, [ConstantExpected(Max = 7)] byte valueIndex)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A2C RID: 23084 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<uint> InsertSelectedScalar(Vector64<uint> result, [ConstantExpected(Max = 1)] byte resultIndex, Vector64<uint> value, [ConstantExpected(Max = 1)] byte valueIndex)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A2D RID: 23085 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<uint> InsertSelectedScalar(Vector64<uint> result, [ConstantExpected(Max = 1)] byte resultIndex, Vector128<uint> value, [ConstantExpected(Max = 3)] byte valueIndex)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A2E RID: 23086 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<byte> InsertSelectedScalar(Vector128<byte> result, [ConstantExpected(Max = 15)] byte resultIndex, Vector64<byte> value, [ConstantExpected(Max = 7)] byte valueIndex)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A2F RID: 23087 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<byte> InsertSelectedScalar(Vector128<byte> result, [ConstantExpected(Max = 15)] byte resultIndex, Vector128<byte> value, [ConstantExpected(Max = 15)] byte valueIndex)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A30 RID: 23088 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<double> InsertSelectedScalar(Vector128<double> result, [ConstantExpected(Max = 1)] byte resultIndex, Vector128<double> value, [ConstantExpected(Max = 1)] byte valueIndex)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A31 RID: 23089 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<short> InsertSelectedScalar(Vector128<short> result, [ConstantExpected(Max = 7)] byte resultIndex, Vector64<short> value, [ConstantExpected(Max = 3)] byte valueIndex)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A32 RID: 23090 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<short> InsertSelectedScalar(Vector128<short> result, [ConstantExpected(Max = 7)] byte resultIndex, Vector128<short> value, [ConstantExpected(Max = 7)] byte valueIndex)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A33 RID: 23091 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<int> InsertSelectedScalar(Vector128<int> result, [ConstantExpected(Max = 3)] byte resultIndex, Vector64<int> value, [ConstantExpected(Max = 1)] byte valueIndex)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A34 RID: 23092 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<int> InsertSelectedScalar(Vector128<int> result, [ConstantExpected(Max = 3)] byte resultIndex, Vector128<int> value, [ConstantExpected(Max = 3)] byte valueIndex)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A35 RID: 23093 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<long> InsertSelectedScalar(Vector128<long> result, [ConstantExpected(Max = 1)] byte resultIndex, Vector128<long> value, [ConstantExpected(Max = 1)] byte valueIndex)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A36 RID: 23094 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<sbyte> InsertSelectedScalar(Vector128<sbyte> result, [ConstantExpected(Max = 15)] byte resultIndex, Vector64<sbyte> value, [ConstantExpected(Max = 7)] byte valueIndex)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A37 RID: 23095 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<sbyte> InsertSelectedScalar(Vector128<sbyte> result, [ConstantExpected(Max = 15)] byte resultIndex, Vector128<sbyte> value, [ConstantExpected(Max = 15)] byte valueIndex)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A38 RID: 23096 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<float> InsertSelectedScalar(Vector128<float> result, [ConstantExpected(Max = 3)] byte resultIndex, Vector64<float> value, [ConstantExpected(Max = 1)] byte valueIndex)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A39 RID: 23097 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<float> InsertSelectedScalar(Vector128<float> result, [ConstantExpected(Max = 3)] byte resultIndex, Vector128<float> value, [ConstantExpected(Max = 3)] byte valueIndex)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A3A RID: 23098 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<ushort> InsertSelectedScalar(Vector128<ushort> result, [ConstantExpected(Max = 7)] byte resultIndex, Vector64<ushort> value, [ConstantExpected(Max = 3)] byte valueIndex)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A3B RID: 23099 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<ushort> InsertSelectedScalar(Vector128<ushort> result, [ConstantExpected(Max = 7)] byte resultIndex, Vector128<ushort> value, [ConstantExpected(Max = 7)] byte valueIndex)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A3C RID: 23100 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<uint> InsertSelectedScalar(Vector128<uint> result, [ConstantExpected(Max = 3)] byte resultIndex, Vector64<uint> value, [ConstantExpected(Max = 1)] byte valueIndex)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A3D RID: 23101 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<uint> InsertSelectedScalar(Vector128<uint> result, [ConstantExpected(Max = 3)] byte resultIndex, Vector128<uint> value, [ConstantExpected(Max = 3)] byte valueIndex)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A3E RID: 23102 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<ulong> InsertSelectedScalar(Vector128<ulong> result, [ConstantExpected(Max = 1)] byte resultIndex, Vector128<ulong> value, [ConstantExpected(Max = 1)] byte valueIndex)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A3F RID: 23103 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})]
			public unsafe static ValueTuple<Vector128<byte>, Vector128<byte>> LoadAndInsertScalar(ValueTuple<Vector128<byte>, Vector128<byte>> values, [ConstantExpected(Max = 15)] byte index, byte* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A40 RID: 23104 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})]
			public unsafe static ValueTuple<Vector128<sbyte>, Vector128<sbyte>> LoadAndInsertScalar(ValueTuple<Vector128<sbyte>, Vector128<sbyte>> values, [ConstantExpected(Max = 15)] byte index, sbyte* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A41 RID: 23105 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})]
			public unsafe static ValueTuple<Vector128<short>, Vector128<short>> LoadAndInsertScalar(ValueTuple<Vector128<short>, Vector128<short>> values, [ConstantExpected(Max = 7)] byte index, short* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A42 RID: 23106 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})]
			public unsafe static ValueTuple<Vector128<ushort>, Vector128<ushort>> LoadAndInsertScalar(ValueTuple<Vector128<ushort>, Vector128<ushort>> values, [ConstantExpected(Max = 7)] byte index, ushort* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A43 RID: 23107 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})]
			public unsafe static ValueTuple<Vector128<int>, Vector128<int>> LoadAndInsertScalar(ValueTuple<Vector128<int>, Vector128<int>> values, [ConstantExpected(Max = 3)] byte index, int* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A44 RID: 23108 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})]
			public unsafe static ValueTuple<Vector128<uint>, Vector128<uint>> LoadAndInsertScalar(ValueTuple<Vector128<uint>, Vector128<uint>> values, [ConstantExpected(Max = 3)] byte index, uint* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A45 RID: 23109 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})]
			public unsafe static ValueTuple<Vector128<long>, Vector128<long>> LoadAndInsertScalar(ValueTuple<Vector128<long>, Vector128<long>> values, [ConstantExpected(Max = 1)] byte index, long* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A46 RID: 23110 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})]
			public unsafe static ValueTuple<Vector128<ulong>, Vector128<ulong>> LoadAndInsertScalar(ValueTuple<Vector128<ulong>, Vector128<ulong>> values, [ConstantExpected(Max = 1)] byte index, ulong* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A47 RID: 23111 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})]
			public unsafe static ValueTuple<Vector128<float>, Vector128<float>> LoadAndInsertScalar(ValueTuple<Vector128<float>, Vector128<float>> values, [ConstantExpected(Max = 3)] byte index, float* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A48 RID: 23112 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})]
			public unsafe static ValueTuple<Vector128<double>, Vector128<double>> LoadAndInsertScalar(ValueTuple<Vector128<double>, Vector128<double>> values, [ConstantExpected(Max = 1)] byte index, double* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A49 RID: 23113 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3"
			})]
			public unsafe static ValueTuple<Vector128<byte>, Vector128<byte>, Vector128<byte>> LoadAndInsertScalar(ValueTuple<Vector128<byte>, Vector128<byte>, Vector128<byte>> values, [ConstantExpected(Max = 15)] byte index, byte* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A4A RID: 23114 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3"
			})]
			public unsafe static ValueTuple<Vector128<sbyte>, Vector128<sbyte>, Vector128<sbyte>> LoadAndInsertScalar(ValueTuple<Vector128<sbyte>, Vector128<sbyte>, Vector128<sbyte>> values, [ConstantExpected(Max = 15)] byte index, sbyte* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A4B RID: 23115 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3"
			})]
			public unsafe static ValueTuple<Vector128<short>, Vector128<short>, Vector128<short>> LoadAndInsertScalar(ValueTuple<Vector128<short>, Vector128<short>, Vector128<short>> values, [ConstantExpected(Max = 7)] byte index, short* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A4C RID: 23116 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3"
			})]
			public unsafe static ValueTuple<Vector128<ushort>, Vector128<ushort>, Vector128<ushort>> LoadAndInsertScalar(ValueTuple<Vector128<ushort>, Vector128<ushort>, Vector128<ushort>> values, [ConstantExpected(Max = 7)] byte index, ushort* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A4D RID: 23117 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3"
			})]
			public unsafe static ValueTuple<Vector128<int>, Vector128<int>, Vector128<int>> LoadAndInsertScalar(ValueTuple<Vector128<int>, Vector128<int>, Vector128<int>> values, [ConstantExpected(Max = 3)] byte index, int* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A4E RID: 23118 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3"
			})]
			public unsafe static ValueTuple<Vector128<uint>, Vector128<uint>, Vector128<uint>> LoadAndInsertScalar(ValueTuple<Vector128<uint>, Vector128<uint>, Vector128<uint>> values, [ConstantExpected(Max = 3)] byte index, uint* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A4F RID: 23119 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3"
			})]
			public unsafe static ValueTuple<Vector128<long>, Vector128<long>, Vector128<long>> LoadAndInsertScalar(ValueTuple<Vector128<long>, Vector128<long>, Vector128<long>> values, [ConstantExpected(Max = 1)] byte index, long* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A50 RID: 23120 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3"
			})]
			public unsafe static ValueTuple<Vector128<ulong>, Vector128<ulong>, Vector128<ulong>> LoadAndInsertScalar(ValueTuple<Vector128<ulong>, Vector128<ulong>, Vector128<ulong>> values, [ConstantExpected(Max = 1)] byte index, ulong* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A51 RID: 23121 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3"
			})]
			public unsafe static ValueTuple<Vector128<float>, Vector128<float>, Vector128<float>> LoadAndInsertScalar(ValueTuple<Vector128<float>, Vector128<float>, Vector128<float>> values, [ConstantExpected(Max = 3)] byte index, float* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A52 RID: 23122 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3"
			})]
			public unsafe static ValueTuple<Vector128<double>, Vector128<double>, Vector128<double>> LoadAndInsertScalar(ValueTuple<Vector128<double>, Vector128<double>, Vector128<double>> values, [ConstantExpected(Max = 1)] byte index, double* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A53 RID: 23123 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3",
				"Value4"
			})]
			public unsafe static ValueTuple<Vector128<byte>, Vector128<byte>, Vector128<byte>, Vector128<byte>> LoadAndInsertScalar(ValueTuple<Vector128<byte>, Vector128<byte>, Vector128<byte>, Vector128<byte>> values, [ConstantExpected(Max = 15)] byte index, byte* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A54 RID: 23124 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3",
				"Value4"
			})]
			public unsafe static ValueTuple<Vector128<sbyte>, Vector128<sbyte>, Vector128<sbyte>, Vector128<sbyte>> LoadAndInsertScalar(ValueTuple<Vector128<sbyte>, Vector128<sbyte>, Vector128<sbyte>, Vector128<sbyte>> values, [ConstantExpected(Max = 15)] byte index, sbyte* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A55 RID: 23125 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3",
				"Value4"
			})]
			public unsafe static ValueTuple<Vector128<short>, Vector128<short>, Vector128<short>, Vector128<short>> LoadAndInsertScalar(ValueTuple<Vector128<short>, Vector128<short>, Vector128<short>, Vector128<short>> values, [ConstantExpected(Max = 7)] byte index, short* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A56 RID: 23126 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3",
				"Value4"
			})]
			public unsafe static ValueTuple<Vector128<ushort>, Vector128<ushort>, Vector128<ushort>, Vector128<ushort>> LoadAndInsertScalar(ValueTuple<Vector128<ushort>, Vector128<ushort>, Vector128<ushort>, Vector128<ushort>> values, [ConstantExpected(Max = 7)] byte index, ushort* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A57 RID: 23127 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3",
				"Value4"
			})]
			public unsafe static ValueTuple<Vector128<int>, Vector128<int>, Vector128<int>, Vector128<int>> LoadAndInsertScalar(ValueTuple<Vector128<int>, Vector128<int>, Vector128<int>, Vector128<int>> values, [ConstantExpected(Max = 3)] byte index, int* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A58 RID: 23128 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3",
				"Value4"
			})]
			public unsafe static ValueTuple<Vector128<uint>, Vector128<uint>, Vector128<uint>, Vector128<uint>> LoadAndInsertScalar(ValueTuple<Vector128<uint>, Vector128<uint>, Vector128<uint>, Vector128<uint>> values, [ConstantExpected(Max = 3)] byte index, uint* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A59 RID: 23129 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3",
				"Value4"
			})]
			public unsafe static ValueTuple<Vector128<long>, Vector128<long>, Vector128<long>, Vector128<long>> LoadAndInsertScalar(ValueTuple<Vector128<long>, Vector128<long>, Vector128<long>, Vector128<long>> values, [ConstantExpected(Max = 1)] byte index, long* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A5A RID: 23130 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3",
				"Value4"
			})]
			public unsafe static ValueTuple<Vector128<ulong>, Vector128<ulong>, Vector128<ulong>, Vector128<ulong>> LoadAndInsertScalar(ValueTuple<Vector128<ulong>, Vector128<ulong>, Vector128<ulong>, Vector128<ulong>> values, [ConstantExpected(Max = 1)] byte index, ulong* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A5B RID: 23131 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3",
				"Value4"
			})]
			public unsafe static ValueTuple<Vector128<float>, Vector128<float>, Vector128<float>, Vector128<float>> LoadAndInsertScalar(ValueTuple<Vector128<float>, Vector128<float>, Vector128<float>, Vector128<float>> values, [ConstantExpected(Max = 3)] byte index, float* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A5C RID: 23132 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3",
				"Value4"
			})]
			public unsafe static ValueTuple<Vector128<double>, Vector128<double>, Vector128<double>, Vector128<double>> LoadAndInsertScalar(ValueTuple<Vector128<double>, Vector128<double>, Vector128<double>, Vector128<double>> values, [ConstantExpected(Max = 1)] byte index, double* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A5D RID: 23133 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static Vector128<double> LoadAndReplicateToVector128(double* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A5E RID: 23134 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static Vector128<long> LoadAndReplicateToVector128(long* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A5F RID: 23135 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static Vector128<ulong> LoadAndReplicateToVector128(ulong* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A60 RID: 23136 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})]
			public unsafe static ValueTuple<Vector128<byte>, Vector128<byte>> LoadAndReplicateToVector128x2(byte* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A61 RID: 23137 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})]
			public unsafe static ValueTuple<Vector128<sbyte>, Vector128<sbyte>> LoadAndReplicateToVector128x2(sbyte* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A62 RID: 23138 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})]
			public unsafe static ValueTuple<Vector128<short>, Vector128<short>> LoadAndReplicateToVector128x2(short* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A63 RID: 23139 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})]
			public unsafe static ValueTuple<Vector128<ushort>, Vector128<ushort>> LoadAndReplicateToVector128x2(ushort* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A64 RID: 23140 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})]
			public unsafe static ValueTuple<Vector128<int>, Vector128<int>> LoadAndReplicateToVector128x2(int* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A65 RID: 23141 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})]
			public unsafe static ValueTuple<Vector128<uint>, Vector128<uint>> LoadAndReplicateToVector128x2(uint* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A66 RID: 23142 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})]
			public unsafe static ValueTuple<Vector128<long>, Vector128<long>> LoadAndReplicateToVector128x2(long* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A67 RID: 23143 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})]
			public unsafe static ValueTuple<Vector128<ulong>, Vector128<ulong>> LoadAndReplicateToVector128x2(ulong* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A68 RID: 23144 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})]
			public unsafe static ValueTuple<Vector128<float>, Vector128<float>> LoadAndReplicateToVector128x2(float* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A69 RID: 23145 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})]
			public unsafe static ValueTuple<Vector128<double>, Vector128<double>> LoadAndReplicateToVector128x2(double* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A6A RID: 23146 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3"
			})]
			public unsafe static ValueTuple<Vector128<byte>, Vector128<byte>, Vector128<byte>> LoadAndReplicateToVector128x3(byte* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A6B RID: 23147 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3"
			})]
			public unsafe static ValueTuple<Vector128<sbyte>, Vector128<sbyte>, Vector128<sbyte>> LoadAndReplicateToVector128x3(sbyte* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A6C RID: 23148 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3"
			})]
			public unsafe static ValueTuple<Vector128<short>, Vector128<short>, Vector128<short>> LoadAndReplicateToVector128x3(short* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A6D RID: 23149 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3"
			})]
			public unsafe static ValueTuple<Vector128<ushort>, Vector128<ushort>, Vector128<ushort>> LoadAndReplicateToVector128x3(ushort* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A6E RID: 23150 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3"
			})]
			public unsafe static ValueTuple<Vector128<int>, Vector128<int>, Vector128<int>> LoadAndReplicateToVector128x3(int* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A6F RID: 23151 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3"
			})]
			public unsafe static ValueTuple<Vector128<uint>, Vector128<uint>, Vector128<uint>> LoadAndReplicateToVector128x3(uint* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A70 RID: 23152 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3"
			})]
			public unsafe static ValueTuple<Vector128<long>, Vector128<long>, Vector128<long>> LoadAndReplicateToVector128x3(long* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A71 RID: 23153 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3"
			})]
			public unsafe static ValueTuple<Vector128<ulong>, Vector128<ulong>, Vector128<ulong>> LoadAndReplicateToVector128x3(ulong* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A72 RID: 23154 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3"
			})]
			public unsafe static ValueTuple<Vector128<float>, Vector128<float>, Vector128<float>> LoadAndReplicateToVector128x3(float* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A73 RID: 23155 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3"
			})]
			public unsafe static ValueTuple<Vector128<double>, Vector128<double>, Vector128<double>> LoadAndReplicateToVector128x3(double* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A74 RID: 23156 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3",
				"Value4"
			})]
			public unsafe static ValueTuple<Vector128<byte>, Vector128<byte>, Vector128<byte>, Vector128<byte>> LoadAndReplicateToVector128x4(byte* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A75 RID: 23157 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3",
				"Value4"
			})]
			public unsafe static ValueTuple<Vector128<sbyte>, Vector128<sbyte>, Vector128<sbyte>, Vector128<sbyte>> LoadAndReplicateToVector128x4(sbyte* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A76 RID: 23158 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3",
				"Value4"
			})]
			public unsafe static ValueTuple<Vector128<short>, Vector128<short>, Vector128<short>, Vector128<short>> LoadAndReplicateToVector128x4(short* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A77 RID: 23159 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3",
				"Value4"
			})]
			public unsafe static ValueTuple<Vector128<ushort>, Vector128<ushort>, Vector128<ushort>, Vector128<ushort>> LoadAndReplicateToVector128x4(ushort* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A78 RID: 23160 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3",
				"Value4"
			})]
			public unsafe static ValueTuple<Vector128<int>, Vector128<int>, Vector128<int>, Vector128<int>> LoadAndReplicateToVector128x4(int* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A79 RID: 23161 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3",
				"Value4"
			})]
			public unsafe static ValueTuple<Vector128<uint>, Vector128<uint>, Vector128<uint>, Vector128<uint>> LoadAndReplicateToVector128x4(uint* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A7A RID: 23162 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3",
				"Value4"
			})]
			public unsafe static ValueTuple<Vector128<long>, Vector128<long>, Vector128<long>, Vector128<long>> LoadAndReplicateToVector128x4(long* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A7B RID: 23163 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3",
				"Value4"
			})]
			public unsafe static ValueTuple<Vector128<ulong>, Vector128<ulong>, Vector128<ulong>, Vector128<ulong>> LoadAndReplicateToVector128x4(ulong* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A7C RID: 23164 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3",
				"Value4"
			})]
			public unsafe static ValueTuple<Vector128<float>, Vector128<float>, Vector128<float>, Vector128<float>> LoadAndReplicateToVector128x4(float* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A7D RID: 23165 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3",
				"Value4"
			})]
			public unsafe static ValueTuple<Vector128<double>, Vector128<double>, Vector128<double>, Vector128<double>> LoadAndReplicateToVector128x4(double* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A7E RID: 23166 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})]
			public unsafe static ValueTuple<Vector64<byte>, Vector64<byte>> LoadPairVector64(byte* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A7F RID: 23167 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})]
			public unsafe static ValueTuple<Vector64<double>, Vector64<double>> LoadPairVector64(double* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A80 RID: 23168 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})]
			public unsafe static ValueTuple<Vector64<short>, Vector64<short>> LoadPairVector64(short* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A81 RID: 23169 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})]
			public unsafe static ValueTuple<Vector64<int>, Vector64<int>> LoadPairVector64(int* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A82 RID: 23170 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})]
			public unsafe static ValueTuple<Vector64<long>, Vector64<long>> LoadPairVector64(long* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A83 RID: 23171 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})]
			public unsafe static ValueTuple<Vector64<sbyte>, Vector64<sbyte>> LoadPairVector64(sbyte* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A84 RID: 23172 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})]
			public unsafe static ValueTuple<Vector64<float>, Vector64<float>> LoadPairVector64(float* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A85 RID: 23173 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})]
			public unsafe static ValueTuple<Vector64<ushort>, Vector64<ushort>> LoadPairVector64(ushort* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A86 RID: 23174 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})]
			public unsafe static ValueTuple<Vector64<uint>, Vector64<uint>> LoadPairVector64(uint* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A87 RID: 23175 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})]
			public unsafe static ValueTuple<Vector64<ulong>, Vector64<ulong>> LoadPairVector64(ulong* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A88 RID: 23176 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})]
			public unsafe static ValueTuple<Vector64<int>, Vector64<int>> LoadPairScalarVector64(int* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A89 RID: 23177 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})]
			public unsafe static ValueTuple<Vector64<float>, Vector64<float>> LoadPairScalarVector64(float* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A8A RID: 23178 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})]
			public unsafe static ValueTuple<Vector64<uint>, Vector64<uint>> LoadPairScalarVector64(uint* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A8B RID: 23179 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})]
			public unsafe static ValueTuple<Vector128<byte>, Vector128<byte>> LoadPairVector128(byte* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A8C RID: 23180 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})]
			public unsafe static ValueTuple<Vector128<double>, Vector128<double>> LoadPairVector128(double* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A8D RID: 23181 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})]
			public unsafe static ValueTuple<Vector128<short>, Vector128<short>> LoadPairVector128(short* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A8E RID: 23182 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})]
			public unsafe static ValueTuple<Vector128<int>, Vector128<int>> LoadPairVector128(int* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A8F RID: 23183 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})]
			public unsafe static ValueTuple<Vector128<long>, Vector128<long>> LoadPairVector128(long* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A90 RID: 23184 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})]
			public unsafe static ValueTuple<Vector128<sbyte>, Vector128<sbyte>> LoadPairVector128(sbyte* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A91 RID: 23185 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})]
			public unsafe static ValueTuple<Vector128<float>, Vector128<float>> LoadPairVector128(float* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A92 RID: 23186 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})]
			public unsafe static ValueTuple<Vector128<ushort>, Vector128<ushort>> LoadPairVector128(ushort* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A93 RID: 23187 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})]
			public unsafe static ValueTuple<Vector128<uint>, Vector128<uint>> LoadPairVector128(uint* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A94 RID: 23188 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})]
			public unsafe static ValueTuple<Vector128<ulong>, Vector128<ulong>> LoadPairVector128(ulong* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A95 RID: 23189 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})]
			public unsafe static ValueTuple<Vector64<byte>, Vector64<byte>> LoadPairVector64NonTemporal(byte* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A96 RID: 23190 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})]
			public unsafe static ValueTuple<Vector64<double>, Vector64<double>> LoadPairVector64NonTemporal(double* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A97 RID: 23191 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})]
			public unsafe static ValueTuple<Vector64<short>, Vector64<short>> LoadPairVector64NonTemporal(short* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A98 RID: 23192 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})]
			public unsafe static ValueTuple<Vector64<int>, Vector64<int>> LoadPairVector64NonTemporal(int* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A99 RID: 23193 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})]
			public unsafe static ValueTuple<Vector64<long>, Vector64<long>> LoadPairVector64NonTemporal(long* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A9A RID: 23194 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})]
			public unsafe static ValueTuple<Vector64<sbyte>, Vector64<sbyte>> LoadPairVector64NonTemporal(sbyte* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A9B RID: 23195 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})]
			public unsafe static ValueTuple<Vector64<float>, Vector64<float>> LoadPairVector64NonTemporal(float* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A9C RID: 23196 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})]
			public unsafe static ValueTuple<Vector64<ushort>, Vector64<ushort>> LoadPairVector64NonTemporal(ushort* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A9D RID: 23197 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})]
			public unsafe static ValueTuple<Vector64<uint>, Vector64<uint>> LoadPairVector64NonTemporal(uint* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A9E RID: 23198 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})]
			public unsafe static ValueTuple<Vector64<ulong>, Vector64<ulong>> LoadPairVector64NonTemporal(ulong* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005A9F RID: 23199 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})]
			public unsafe static ValueTuple<Vector64<int>, Vector64<int>> LoadPairScalarVector64NonTemporal(int* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005AA0 RID: 23200 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})]
			public unsafe static ValueTuple<Vector64<float>, Vector64<float>> LoadPairScalarVector64NonTemporal(float* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005AA1 RID: 23201 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})]
			public unsafe static ValueTuple<Vector64<uint>, Vector64<uint>> LoadPairScalarVector64NonTemporal(uint* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005AA2 RID: 23202 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})]
			public unsafe static ValueTuple<Vector128<byte>, Vector128<byte>> LoadPairVector128NonTemporal(byte* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005AA3 RID: 23203 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})]
			public unsafe static ValueTuple<Vector128<double>, Vector128<double>> LoadPairVector128NonTemporal(double* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005AA4 RID: 23204 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})]
			public unsafe static ValueTuple<Vector128<short>, Vector128<short>> LoadPairVector128NonTemporal(short* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005AA5 RID: 23205 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})]
			public unsafe static ValueTuple<Vector128<int>, Vector128<int>> LoadPairVector128NonTemporal(int* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005AA6 RID: 23206 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})]
			public unsafe static ValueTuple<Vector128<long>, Vector128<long>> LoadPairVector128NonTemporal(long* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005AA7 RID: 23207 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})]
			public unsafe static ValueTuple<Vector128<sbyte>, Vector128<sbyte>> LoadPairVector128NonTemporal(sbyte* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005AA8 RID: 23208 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})]
			public unsafe static ValueTuple<Vector128<float>, Vector128<float>> LoadPairVector128NonTemporal(float* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005AA9 RID: 23209 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})]
			public unsafe static ValueTuple<Vector128<ushort>, Vector128<ushort>> LoadPairVector128NonTemporal(ushort* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005AAA RID: 23210 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})]
			public unsafe static ValueTuple<Vector128<uint>, Vector128<uint>> LoadPairVector128NonTemporal(uint* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005AAB RID: 23211 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})]
			public unsafe static ValueTuple<Vector128<ulong>, Vector128<ulong>> LoadPairVector128NonTemporal(ulong* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005AAC RID: 23212 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})]
			public unsafe static ValueTuple<Vector128<byte>, Vector128<byte>> Load2xVector128AndUnzip(byte* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005AAD RID: 23213 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})]
			public unsafe static ValueTuple<Vector128<sbyte>, Vector128<sbyte>> Load2xVector128AndUnzip(sbyte* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005AAE RID: 23214 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})]
			public unsafe static ValueTuple<Vector128<short>, Vector128<short>> Load2xVector128AndUnzip(short* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005AAF RID: 23215 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})]
			public unsafe static ValueTuple<Vector128<ushort>, Vector128<ushort>> Load2xVector128AndUnzip(ushort* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005AB0 RID: 23216 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})]
			public unsafe static ValueTuple<Vector128<int>, Vector128<int>> Load2xVector128AndUnzip(int* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005AB1 RID: 23217 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})]
			public unsafe static ValueTuple<Vector128<uint>, Vector128<uint>> Load2xVector128AndUnzip(uint* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005AB2 RID: 23218 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})]
			public unsafe static ValueTuple<Vector128<long>, Vector128<long>> Load2xVector128AndUnzip(long* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005AB3 RID: 23219 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})]
			public unsafe static ValueTuple<Vector128<ulong>, Vector128<ulong>> Load2xVector128AndUnzip(ulong* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005AB4 RID: 23220 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})]
			public unsafe static ValueTuple<Vector128<float>, Vector128<float>> Load2xVector128AndUnzip(float* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005AB5 RID: 23221 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})]
			public unsafe static ValueTuple<Vector128<double>, Vector128<double>> Load2xVector128AndUnzip(double* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005AB6 RID: 23222 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3"
			})]
			public unsafe static ValueTuple<Vector128<byte>, Vector128<byte>, Vector128<byte>> Load3xVector128AndUnzip(byte* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005AB7 RID: 23223 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3"
			})]
			public unsafe static ValueTuple<Vector128<sbyte>, Vector128<sbyte>, Vector128<sbyte>> Load3xVector128AndUnzip(sbyte* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005AB8 RID: 23224 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3"
			})]
			public unsafe static ValueTuple<Vector128<short>, Vector128<short>, Vector128<short>> Load3xVector128AndUnzip(short* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005AB9 RID: 23225 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3"
			})]
			public unsafe static ValueTuple<Vector128<ushort>, Vector128<ushort>, Vector128<ushort>> Load3xVector128AndUnzip(ushort* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005ABA RID: 23226 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3"
			})]
			public unsafe static ValueTuple<Vector128<int>, Vector128<int>, Vector128<int>> Load3xVector128AndUnzip(int* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005ABB RID: 23227 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3"
			})]
			public unsafe static ValueTuple<Vector128<uint>, Vector128<uint>, Vector128<uint>> Load3xVector128AndUnzip(uint* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005ABC RID: 23228 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3"
			})]
			public unsafe static ValueTuple<Vector128<long>, Vector128<long>, Vector128<long>> Load3xVector128AndUnzip(long* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005ABD RID: 23229 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3"
			})]
			public unsafe static ValueTuple<Vector128<ulong>, Vector128<ulong>, Vector128<ulong>> Load3xVector128AndUnzip(ulong* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005ABE RID: 23230 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3"
			})]
			public unsafe static ValueTuple<Vector128<float>, Vector128<float>, Vector128<float>> Load3xVector128AndUnzip(float* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005ABF RID: 23231 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3"
			})]
			public unsafe static ValueTuple<Vector128<double>, Vector128<double>, Vector128<double>> Load3xVector128AndUnzip(double* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005AC0 RID: 23232 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3",
				"Value4"
			})]
			public unsafe static ValueTuple<Vector128<byte>, Vector128<byte>, Vector128<byte>, Vector128<byte>> Load4xVector128AndUnzip(byte* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005AC1 RID: 23233 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3",
				"Value4"
			})]
			public unsafe static ValueTuple<Vector128<sbyte>, Vector128<sbyte>, Vector128<sbyte>, Vector128<sbyte>> Load4xVector128AndUnzip(sbyte* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005AC2 RID: 23234 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3",
				"Value4"
			})]
			public unsafe static ValueTuple<Vector128<short>, Vector128<short>, Vector128<short>, Vector128<short>> Load4xVector128AndUnzip(short* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005AC3 RID: 23235 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3",
				"Value4"
			})]
			public unsafe static ValueTuple<Vector128<ushort>, Vector128<ushort>, Vector128<ushort>, Vector128<ushort>> Load4xVector128AndUnzip(ushort* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005AC4 RID: 23236 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3",
				"Value4"
			})]
			public unsafe static ValueTuple<Vector128<int>, Vector128<int>, Vector128<int>, Vector128<int>> Load4xVector128AndUnzip(int* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005AC5 RID: 23237 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3",
				"Value4"
			})]
			public unsafe static ValueTuple<Vector128<uint>, Vector128<uint>, Vector128<uint>, Vector128<uint>> Load4xVector128AndUnzip(uint* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005AC6 RID: 23238 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3",
				"Value4"
			})]
			public unsafe static ValueTuple<Vector128<long>, Vector128<long>, Vector128<long>, Vector128<long>> Load4xVector128AndUnzip(long* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005AC7 RID: 23239 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3",
				"Value4"
			})]
			public unsafe static ValueTuple<Vector128<ulong>, Vector128<ulong>, Vector128<ulong>, Vector128<ulong>> Load4xVector128AndUnzip(ulong* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005AC8 RID: 23240 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3",
				"Value4"
			})]
			public unsafe static ValueTuple<Vector128<float>, Vector128<float>, Vector128<float>, Vector128<float>> Load4xVector128AndUnzip(float* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005AC9 RID: 23241 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3",
				"Value4"
			})]
			public unsafe static ValueTuple<Vector128<double>, Vector128<double>, Vector128<double>, Vector128<double>> Load4xVector128AndUnzip(double* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005ACA RID: 23242 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})]
			public unsafe static ValueTuple<Vector128<byte>, Vector128<byte>> Load2xVector128(byte* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005ACB RID: 23243 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})]
			public unsafe static ValueTuple<Vector128<sbyte>, Vector128<sbyte>> Load2xVector128(sbyte* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005ACC RID: 23244 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})]
			public unsafe static ValueTuple<Vector128<short>, Vector128<short>> Load2xVector128(short* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005ACD RID: 23245 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})]
			public unsafe static ValueTuple<Vector128<ushort>, Vector128<ushort>> Load2xVector128(ushort* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005ACE RID: 23246 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})]
			public unsafe static ValueTuple<Vector128<int>, Vector128<int>> Load2xVector128(int* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005ACF RID: 23247 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})]
			public unsafe static ValueTuple<Vector128<uint>, Vector128<uint>> Load2xVector128(uint* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005AD0 RID: 23248 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})]
			public unsafe static ValueTuple<Vector128<long>, Vector128<long>> Load2xVector128(long* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005AD1 RID: 23249 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})]
			public unsafe static ValueTuple<Vector128<ulong>, Vector128<ulong>> Load2xVector128(ulong* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005AD2 RID: 23250 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})]
			public unsafe static ValueTuple<Vector128<float>, Vector128<float>> Load2xVector128(float* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005AD3 RID: 23251 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})]
			public unsafe static ValueTuple<Vector128<double>, Vector128<double>> Load2xVector128(double* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005AD4 RID: 23252 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3"
			})]
			public unsafe static ValueTuple<Vector128<byte>, Vector128<byte>, Vector128<byte>> Load3xVector128(byte* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005AD5 RID: 23253 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3"
			})]
			public unsafe static ValueTuple<Vector128<sbyte>, Vector128<sbyte>, Vector128<sbyte>> Load3xVector128(sbyte* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005AD6 RID: 23254 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3"
			})]
			public unsafe static ValueTuple<Vector128<short>, Vector128<short>, Vector128<short>> Load3xVector128(short* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005AD7 RID: 23255 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3"
			})]
			public unsafe static ValueTuple<Vector128<ushort>, Vector128<ushort>, Vector128<ushort>> Load3xVector128(ushort* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005AD8 RID: 23256 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3"
			})]
			public unsafe static ValueTuple<Vector128<int>, Vector128<int>, Vector128<int>> Load3xVector128(int* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005AD9 RID: 23257 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3"
			})]
			public unsafe static ValueTuple<Vector128<uint>, Vector128<uint>, Vector128<uint>> Load3xVector128(uint* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005ADA RID: 23258 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3"
			})]
			public unsafe static ValueTuple<Vector128<long>, Vector128<long>, Vector128<long>> Load3xVector128(long* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005ADB RID: 23259 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3"
			})]
			public unsafe static ValueTuple<Vector128<ulong>, Vector128<ulong>, Vector128<ulong>> Load3xVector128(ulong* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005ADC RID: 23260 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3"
			})]
			public unsafe static ValueTuple<Vector128<float>, Vector128<float>, Vector128<float>> Load3xVector128(float* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005ADD RID: 23261 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3"
			})]
			public unsafe static ValueTuple<Vector128<double>, Vector128<double>, Vector128<double>> Load3xVector128(double* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005ADE RID: 23262 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3",
				"Value4"
			})]
			public unsafe static ValueTuple<Vector128<byte>, Vector128<byte>, Vector128<byte>, Vector128<byte>> Load4xVector128(byte* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005ADF RID: 23263 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3",
				"Value4"
			})]
			public unsafe static ValueTuple<Vector128<sbyte>, Vector128<sbyte>, Vector128<sbyte>, Vector128<sbyte>> Load4xVector128(sbyte* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005AE0 RID: 23264 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3",
				"Value4"
			})]
			public unsafe static ValueTuple<Vector128<short>, Vector128<short>, Vector128<short>, Vector128<short>> Load4xVector128(short* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005AE1 RID: 23265 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3",
				"Value4"
			})]
			public unsafe static ValueTuple<Vector128<ushort>, Vector128<ushort>, Vector128<ushort>, Vector128<ushort>> Load4xVector128(ushort* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005AE2 RID: 23266 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3",
				"Value4"
			})]
			public unsafe static ValueTuple<Vector128<int>, Vector128<int>, Vector128<int>, Vector128<int>> Load4xVector128(int* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005AE3 RID: 23267 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3",
				"Value4"
			})]
			public unsafe static ValueTuple<Vector128<uint>, Vector128<uint>, Vector128<uint>, Vector128<uint>> Load4xVector128(uint* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005AE4 RID: 23268 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3",
				"Value4"
			})]
			public unsafe static ValueTuple<Vector128<long>, Vector128<long>, Vector128<long>, Vector128<long>> Load4xVector128(long* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005AE5 RID: 23269 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3",
				"Value4"
			})]
			public unsafe static ValueTuple<Vector128<ulong>, Vector128<ulong>, Vector128<ulong>, Vector128<ulong>> Load4xVector128(ulong* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005AE6 RID: 23270 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3",
				"Value4"
			})]
			public unsafe static ValueTuple<Vector128<float>, Vector128<float>, Vector128<float>, Vector128<float>> Load4xVector128(float* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005AE7 RID: 23271 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[return: TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3",
				"Value4"
			})]
			public unsafe static ValueTuple<Vector128<double>, Vector128<double>, Vector128<double>, Vector128<double>> Load4xVector128(double* address)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005AE8 RID: 23272 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<double> Max(Vector128<double> left, Vector128<double> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005AE9 RID: 23273 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<byte> MaxAcross(Vector64<byte> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005AEA RID: 23274 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<short> MaxAcross(Vector64<short> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005AEB RID: 23275 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<sbyte> MaxAcross(Vector64<sbyte> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005AEC RID: 23276 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<ushort> MaxAcross(Vector64<ushort> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005AED RID: 23277 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<byte> MaxAcross(Vector128<byte> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005AEE RID: 23278 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<short> MaxAcross(Vector128<short> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005AEF RID: 23279 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<int> MaxAcross(Vector128<int> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005AF0 RID: 23280 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<sbyte> MaxAcross(Vector128<sbyte> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005AF1 RID: 23281 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<float> MaxAcross(Vector128<float> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005AF2 RID: 23282 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<ushort> MaxAcross(Vector128<ushort> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005AF3 RID: 23283 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<uint> MaxAcross(Vector128<uint> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005AF4 RID: 23284 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<double> MaxNumber(Vector128<double> left, Vector128<double> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005AF5 RID: 23285 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<float> MaxNumberAcross(Vector128<float> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005AF6 RID: 23286 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<float> MaxNumberPairwise(Vector64<float> left, Vector64<float> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005AF7 RID: 23287 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<double> MaxNumberPairwise(Vector128<double> left, Vector128<double> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005AF8 RID: 23288 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<float> MaxNumberPairwise(Vector128<float> left, Vector128<float> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005AF9 RID: 23289 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<float> MaxNumberPairwiseScalar(Vector64<float> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005AFA RID: 23290 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<double> MaxNumberPairwiseScalar(Vector128<double> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005AFB RID: 23291 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<byte> MaxPairwise(Vector128<byte> left, Vector128<byte> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005AFC RID: 23292 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<double> MaxPairwise(Vector128<double> left, Vector128<double> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005AFD RID: 23293 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<short> MaxPairwise(Vector128<short> left, Vector128<short> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005AFE RID: 23294 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<int> MaxPairwise(Vector128<int> left, Vector128<int> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005AFF RID: 23295 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<sbyte> MaxPairwise(Vector128<sbyte> left, Vector128<sbyte> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B00 RID: 23296 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<float> MaxPairwise(Vector128<float> left, Vector128<float> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B01 RID: 23297 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<ushort> MaxPairwise(Vector128<ushort> left, Vector128<ushort> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B02 RID: 23298 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<uint> MaxPairwise(Vector128<uint> left, Vector128<uint> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B03 RID: 23299 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<float> MaxPairwiseScalar(Vector64<float> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B04 RID: 23300 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<double> MaxPairwiseScalar(Vector128<double> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B05 RID: 23301 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<double> MaxScalar(Vector64<double> left, Vector64<double> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B06 RID: 23302 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<float> MaxScalar(Vector64<float> left, Vector64<float> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B07 RID: 23303 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<double> Min(Vector128<double> left, Vector128<double> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B08 RID: 23304 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<byte> MinAcross(Vector64<byte> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B09 RID: 23305 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<short> MinAcross(Vector64<short> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B0A RID: 23306 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<sbyte> MinAcross(Vector64<sbyte> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B0B RID: 23307 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<ushort> MinAcross(Vector64<ushort> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B0C RID: 23308 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<byte> MinAcross(Vector128<byte> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B0D RID: 23309 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<short> MinAcross(Vector128<short> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B0E RID: 23310 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<int> MinAcross(Vector128<int> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B0F RID: 23311 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<sbyte> MinAcross(Vector128<sbyte> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B10 RID: 23312 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<float> MinAcross(Vector128<float> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B11 RID: 23313 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<ushort> MinAcross(Vector128<ushort> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B12 RID: 23314 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<uint> MinAcross(Vector128<uint> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B13 RID: 23315 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<double> MinNumber(Vector128<double> left, Vector128<double> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B14 RID: 23316 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<float> MinNumberAcross(Vector128<float> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B15 RID: 23317 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<float> MinNumberPairwise(Vector64<float> left, Vector64<float> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B16 RID: 23318 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<double> MinNumberPairwise(Vector128<double> left, Vector128<double> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B17 RID: 23319 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<float> MinNumberPairwise(Vector128<float> left, Vector128<float> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B18 RID: 23320 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<float> MinNumberPairwiseScalar(Vector64<float> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B19 RID: 23321 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<double> MinNumberPairwiseScalar(Vector128<double> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B1A RID: 23322 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<byte> MinPairwise(Vector128<byte> left, Vector128<byte> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B1B RID: 23323 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<double> MinPairwise(Vector128<double> left, Vector128<double> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B1C RID: 23324 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<short> MinPairwise(Vector128<short> left, Vector128<short> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B1D RID: 23325 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<int> MinPairwise(Vector128<int> left, Vector128<int> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B1E RID: 23326 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<sbyte> MinPairwise(Vector128<sbyte> left, Vector128<sbyte> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B1F RID: 23327 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<float> MinPairwise(Vector128<float> left, Vector128<float> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B20 RID: 23328 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<ushort> MinPairwise(Vector128<ushort> left, Vector128<ushort> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B21 RID: 23329 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<uint> MinPairwise(Vector128<uint> left, Vector128<uint> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B22 RID: 23330 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<float> MinPairwiseScalar(Vector64<float> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B23 RID: 23331 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<double> MinPairwiseScalar(Vector128<double> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B24 RID: 23332 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<double> MinScalar(Vector64<double> left, Vector64<double> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B25 RID: 23333 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<float> MinScalar(Vector64<float> left, Vector64<float> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B26 RID: 23334 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<double> Multiply(Vector128<double> left, Vector128<double> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B27 RID: 23335 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<double> MultiplyByScalar(Vector128<double> left, Vector64<double> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B28 RID: 23336 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<double> MultiplyBySelectedScalar(Vector128<double> left, Vector128<double> right, [ConstantExpected(Max = 1)] byte rightIndex)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B29 RID: 23337 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<short> MultiplyDoublingSaturateHighScalar(Vector64<short> left, Vector64<short> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B2A RID: 23338 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<int> MultiplyDoublingSaturateHighScalar(Vector64<int> left, Vector64<int> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B2B RID: 23339 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<short> MultiplyDoublingScalarBySelectedScalarSaturateHigh(Vector64<short> left, Vector64<short> right, [ConstantExpected(Max = 3)] byte rightIndex)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B2C RID: 23340 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<short> MultiplyDoublingScalarBySelectedScalarSaturateHigh(Vector64<short> left, Vector128<short> right, [ConstantExpected(Max = 7)] byte rightIndex)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B2D RID: 23341 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<int> MultiplyDoublingScalarBySelectedScalarSaturateHigh(Vector64<int> left, Vector64<int> right, [ConstantExpected(Max = 1)] byte rightIndex)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B2E RID: 23342 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<int> MultiplyDoublingScalarBySelectedScalarSaturateHigh(Vector64<int> left, Vector128<int> right, [ConstantExpected(Max = 3)] byte rightIndex)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B2F RID: 23343 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<int> MultiplyDoublingWideningAndAddSaturateScalar(Vector64<int> addend, Vector64<short> left, Vector64<short> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B30 RID: 23344 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<long> MultiplyDoublingWideningAndAddSaturateScalar(Vector64<long> addend, Vector64<int> left, Vector64<int> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B31 RID: 23345 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<int> MultiplyDoublingWideningAndSubtractSaturateScalar(Vector64<int> minuend, Vector64<short> left, Vector64<short> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B32 RID: 23346 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<long> MultiplyDoublingWideningAndSubtractSaturateScalar(Vector64<long> minuend, Vector64<int> left, Vector64<int> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B33 RID: 23347 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<int> MultiplyDoublingWideningSaturateScalar(Vector64<short> left, Vector64<short> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B34 RID: 23348 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<long> MultiplyDoublingWideningSaturateScalar(Vector64<int> left, Vector64<int> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B35 RID: 23349 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<int> MultiplyDoublingWideningSaturateScalarBySelectedScalar(Vector64<short> left, Vector64<short> right, [ConstantExpected(Max = 3)] byte rightIndex)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B36 RID: 23350 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<int> MultiplyDoublingWideningSaturateScalarBySelectedScalar(Vector64<short> left, Vector128<short> right, [ConstantExpected(Max = 7)] byte rightIndex)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B37 RID: 23351 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<long> MultiplyDoublingWideningSaturateScalarBySelectedScalar(Vector64<int> left, Vector64<int> right, [ConstantExpected(Max = 1)] byte rightIndex)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B38 RID: 23352 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<long> MultiplyDoublingWideningSaturateScalarBySelectedScalar(Vector64<int> left, Vector128<int> right, [ConstantExpected(Max = 3)] byte rightIndex)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B39 RID: 23353 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<int> MultiplyDoublingWideningScalarBySelectedScalarAndAddSaturate(Vector64<int> addend, Vector64<short> left, Vector64<short> right, [ConstantExpected(Max = 3)] byte rightIndex)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B3A RID: 23354 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<int> MultiplyDoublingWideningScalarBySelectedScalarAndAddSaturate(Vector64<int> addend, Vector64<short> left, Vector128<short> right, [ConstantExpected(Max = 7)] byte rightIndex)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B3B RID: 23355 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<long> MultiplyDoublingWideningScalarBySelectedScalarAndAddSaturate(Vector64<long> addend, Vector64<int> left, Vector64<int> right, [ConstantExpected(Max = 1)] byte rightIndex)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B3C RID: 23356 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<long> MultiplyDoublingWideningScalarBySelectedScalarAndAddSaturate(Vector64<long> addend, Vector64<int> left, Vector128<int> right, [ConstantExpected(Max = 3)] byte rightIndex)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B3D RID: 23357 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<int> MultiplyDoublingWideningScalarBySelectedScalarAndSubtractSaturate(Vector64<int> minuend, Vector64<short> left, Vector64<short> right, [ConstantExpected(Max = 3)] byte rightIndex)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B3E RID: 23358 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<int> MultiplyDoublingWideningScalarBySelectedScalarAndSubtractSaturate(Vector64<int> minuend, Vector64<short> left, Vector128<short> right, [ConstantExpected(Max = 7)] byte rightIndex)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B3F RID: 23359 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<long> MultiplyDoublingWideningScalarBySelectedScalarAndSubtractSaturate(Vector64<long> minuend, Vector64<int> left, Vector64<int> right, [ConstantExpected(Max = 1)] byte rightIndex)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B40 RID: 23360 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<long> MultiplyDoublingWideningScalarBySelectedScalarAndSubtractSaturate(Vector64<long> minuend, Vector64<int> left, Vector128<int> right, [ConstantExpected(Max = 3)] byte rightIndex)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B41 RID: 23361 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<float> MultiplyExtended(Vector64<float> left, Vector64<float> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B42 RID: 23362 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<double> MultiplyExtended(Vector128<double> left, Vector128<double> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B43 RID: 23363 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<float> MultiplyExtended(Vector128<float> left, Vector128<float> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B44 RID: 23364 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<double> MultiplyExtendedByScalar(Vector128<double> left, Vector64<double> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B45 RID: 23365 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<float> MultiplyExtendedBySelectedScalar(Vector64<float> left, Vector64<float> right, [ConstantExpected(Max = 1)] byte rightIndex)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B46 RID: 23366 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<float> MultiplyExtendedBySelectedScalar(Vector64<float> left, Vector128<float> right, [ConstantExpected(Max = 3)] byte rightIndex)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B47 RID: 23367 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<double> MultiplyExtendedBySelectedScalar(Vector128<double> left, Vector128<double> right, [ConstantExpected(Max = 1)] byte rightIndex)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B48 RID: 23368 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<float> MultiplyExtendedBySelectedScalar(Vector128<float> left, Vector64<float> right, [ConstantExpected(Max = 1)] byte rightIndex)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B49 RID: 23369 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<float> MultiplyExtendedBySelectedScalar(Vector128<float> left, Vector128<float> right, [ConstantExpected(Max = 3)] byte rightIndex)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B4A RID: 23370 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<double> MultiplyExtendedScalar(Vector64<double> left, Vector64<double> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B4B RID: 23371 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<float> MultiplyExtendedScalar(Vector64<float> left, Vector64<float> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B4C RID: 23372 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<double> MultiplyExtendedScalarBySelectedScalar(Vector64<double> left, Vector128<double> right, [ConstantExpected(Max = 1)] byte rightIndex)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B4D RID: 23373 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<float> MultiplyExtendedScalarBySelectedScalar(Vector64<float> left, Vector64<float> right, [ConstantExpected(Max = 1)] byte rightIndex)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B4E RID: 23374 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<float> MultiplyExtendedScalarBySelectedScalar(Vector64<float> left, Vector128<float> right, [ConstantExpected(Max = 3)] byte rightIndex)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B4F RID: 23375 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<short> MultiplyRoundedDoublingSaturateHighScalar(Vector64<short> left, Vector64<short> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B50 RID: 23376 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<int> MultiplyRoundedDoublingSaturateHighScalar(Vector64<int> left, Vector64<int> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B51 RID: 23377 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<short> MultiplyRoundedDoublingScalarBySelectedScalarSaturateHigh(Vector64<short> left, Vector64<short> right, [ConstantExpected(Max = 3)] byte rightIndex)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B52 RID: 23378 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<short> MultiplyRoundedDoublingScalarBySelectedScalarSaturateHigh(Vector64<short> left, Vector128<short> right, [ConstantExpected(Max = 7)] byte rightIndex)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B53 RID: 23379 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<int> MultiplyRoundedDoublingScalarBySelectedScalarSaturateHigh(Vector64<int> left, Vector64<int> right, [ConstantExpected(Max = 1)] byte rightIndex)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B54 RID: 23380 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<int> MultiplyRoundedDoublingScalarBySelectedScalarSaturateHigh(Vector64<int> left, Vector128<int> right, [ConstantExpected(Max = 3)] byte rightIndex)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B55 RID: 23381 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<double> MultiplyScalarBySelectedScalar(Vector64<double> left, Vector128<double> right, [ConstantExpected(Max = 1)] byte rightIndex)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B56 RID: 23382 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<double> Negate(Vector128<double> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B57 RID: 23383 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<long> Negate(Vector128<long> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B58 RID: 23384 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<long> NegateSaturate(Vector128<long> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B59 RID: 23385 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<short> NegateSaturateScalar(Vector64<short> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B5A RID: 23386 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<int> NegateSaturateScalar(Vector64<int> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B5B RID: 23387 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<long> NegateSaturateScalar(Vector64<long> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B5C RID: 23388 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<sbyte> NegateSaturateScalar(Vector64<sbyte> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B5D RID: 23389 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<long> NegateScalar(Vector64<long> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B5E RID: 23390 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<double> ReciprocalEstimate(Vector128<double> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B5F RID: 23391 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<double> ReciprocalEstimateScalar(Vector64<double> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B60 RID: 23392 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<float> ReciprocalEstimateScalar(Vector64<float> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B61 RID: 23393 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<double> ReciprocalExponentScalar(Vector64<double> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B62 RID: 23394 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<float> ReciprocalExponentScalar(Vector64<float> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B63 RID: 23395 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<double> ReciprocalSquareRootEstimate(Vector128<double> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B64 RID: 23396 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<double> ReciprocalSquareRootEstimateScalar(Vector64<double> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B65 RID: 23397 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<float> ReciprocalSquareRootEstimateScalar(Vector64<float> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B66 RID: 23398 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<double> ReciprocalSquareRootStep(Vector128<double> left, Vector128<double> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B67 RID: 23399 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<double> ReciprocalSquareRootStepScalar(Vector64<double> left, Vector64<double> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B68 RID: 23400 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<float> ReciprocalSquareRootStepScalar(Vector64<float> left, Vector64<float> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B69 RID: 23401 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<double> ReciprocalStep(Vector128<double> left, Vector128<double> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B6A RID: 23402 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<double> ReciprocalStepScalar(Vector64<double> left, Vector64<double> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B6B RID: 23403 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<float> ReciprocalStepScalar(Vector64<float> left, Vector64<float> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B6C RID: 23404 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<double> RoundAwayFromZero(Vector128<double> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B6D RID: 23405 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<double> RoundToNearest(Vector128<double> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B6E RID: 23406 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<double> RoundToNegativeInfinity(Vector128<double> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B6F RID: 23407 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<double> RoundToPositiveInfinity(Vector128<double> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B70 RID: 23408 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<double> RoundToZero(Vector128<double> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B71 RID: 23409 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<short> ShiftArithmeticRoundedSaturateScalar(Vector64<short> value, Vector64<short> count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B72 RID: 23410 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<int> ShiftArithmeticRoundedSaturateScalar(Vector64<int> value, Vector64<int> count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B73 RID: 23411 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<sbyte> ShiftArithmeticRoundedSaturateScalar(Vector64<sbyte> value, Vector64<sbyte> count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B74 RID: 23412 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<short> ShiftArithmeticSaturateScalar(Vector64<short> value, Vector64<short> count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B75 RID: 23413 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<int> ShiftArithmeticSaturateScalar(Vector64<int> value, Vector64<int> count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B76 RID: 23414 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<sbyte> ShiftArithmeticSaturateScalar(Vector64<sbyte> value, Vector64<sbyte> count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B77 RID: 23415 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<byte> ShiftLeftLogicalSaturateScalar(Vector64<byte> value, [ConstantExpected(Max = 7)] byte count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B78 RID: 23416 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<short> ShiftLeftLogicalSaturateScalar(Vector64<short> value, [ConstantExpected(Max = 15)] byte count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B79 RID: 23417 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<int> ShiftLeftLogicalSaturateScalar(Vector64<int> value, [ConstantExpected(Max = 31)] byte count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B7A RID: 23418 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<sbyte> ShiftLeftLogicalSaturateScalar(Vector64<sbyte> value, [ConstantExpected(Max = 7)] byte count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B7B RID: 23419 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<ushort> ShiftLeftLogicalSaturateScalar(Vector64<ushort> value, [ConstantExpected(Max = 15)] byte count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B7C RID: 23420 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<uint> ShiftLeftLogicalSaturateScalar(Vector64<uint> value, [ConstantExpected(Max = 31)] byte count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B7D RID: 23421 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<ushort> ShiftLeftLogicalSaturateUnsignedScalar(Vector64<short> value, [ConstantExpected(Max = 15)] byte count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B7E RID: 23422 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<uint> ShiftLeftLogicalSaturateUnsignedScalar(Vector64<int> value, [ConstantExpected(Max = 31)] byte count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B7F RID: 23423 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<byte> ShiftLeftLogicalSaturateUnsignedScalar(Vector64<sbyte> value, [ConstantExpected(Max = 7)] byte count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B80 RID: 23424 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<byte> ShiftLogicalRoundedSaturateScalar(Vector64<byte> value, Vector64<sbyte> count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B81 RID: 23425 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<short> ShiftLogicalRoundedSaturateScalar(Vector64<short> value, Vector64<short> count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B82 RID: 23426 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<int> ShiftLogicalRoundedSaturateScalar(Vector64<int> value, Vector64<int> count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B83 RID: 23427 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<sbyte> ShiftLogicalRoundedSaturateScalar(Vector64<sbyte> value, Vector64<sbyte> count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B84 RID: 23428 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<ushort> ShiftLogicalRoundedSaturateScalar(Vector64<ushort> value, Vector64<short> count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B85 RID: 23429 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<uint> ShiftLogicalRoundedSaturateScalar(Vector64<uint> value, Vector64<int> count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B86 RID: 23430 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<byte> ShiftLogicalSaturateScalar(Vector64<byte> value, Vector64<sbyte> count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B87 RID: 23431 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<short> ShiftLogicalSaturateScalar(Vector64<short> value, Vector64<short> count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B88 RID: 23432 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<int> ShiftLogicalSaturateScalar(Vector64<int> value, Vector64<int> count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B89 RID: 23433 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<sbyte> ShiftLogicalSaturateScalar(Vector64<sbyte> value, Vector64<sbyte> count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B8A RID: 23434 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<ushort> ShiftLogicalSaturateScalar(Vector64<ushort> value, Vector64<short> count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B8B RID: 23435 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<uint> ShiftLogicalSaturateScalar(Vector64<uint> value, Vector64<int> count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B8C RID: 23436 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<short> ShiftRightArithmeticNarrowingSaturateScalar(Vector64<int> value, [ConstantExpected(Min = 1, Max = 16)] byte count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B8D RID: 23437 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<int> ShiftRightArithmeticNarrowingSaturateScalar(Vector64<long> value, [ConstantExpected(Min = 1, Max = 32)] byte count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B8E RID: 23438 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<sbyte> ShiftRightArithmeticNarrowingSaturateScalar(Vector64<short> value, [ConstantExpected(Min = 1, Max = 8)] byte count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B8F RID: 23439 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<byte> ShiftRightArithmeticNarrowingSaturateUnsignedScalar(Vector64<short> value, [ConstantExpected(Min = 1, Max = 8)] byte count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B90 RID: 23440 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<ushort> ShiftRightArithmeticNarrowingSaturateUnsignedScalar(Vector64<int> value, [ConstantExpected(Min = 1, Max = 16)] byte count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B91 RID: 23441 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<uint> ShiftRightArithmeticNarrowingSaturateUnsignedScalar(Vector64<long> value, [ConstantExpected(Min = 1, Max = 32)] byte count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B92 RID: 23442 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<short> ShiftRightArithmeticRoundedNarrowingSaturateScalar(Vector64<int> value, [ConstantExpected(Min = 1, Max = 16)] byte count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B93 RID: 23443 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<int> ShiftRightArithmeticRoundedNarrowingSaturateScalar(Vector64<long> value, [ConstantExpected(Min = 1, Max = 32)] byte count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B94 RID: 23444 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<sbyte> ShiftRightArithmeticRoundedNarrowingSaturateScalar(Vector64<short> value, [ConstantExpected(Min = 1, Max = 8)] byte count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B95 RID: 23445 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<byte> ShiftRightArithmeticRoundedNarrowingSaturateUnsignedScalar(Vector64<short> value, [ConstantExpected(Min = 1, Max = 8)] byte count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B96 RID: 23446 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<ushort> ShiftRightArithmeticRoundedNarrowingSaturateUnsignedScalar(Vector64<int> value, [ConstantExpected(Min = 1, Max = 16)] byte count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B97 RID: 23447 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<uint> ShiftRightArithmeticRoundedNarrowingSaturateUnsignedScalar(Vector64<long> value, [ConstantExpected(Min = 1, Max = 32)] byte count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B98 RID: 23448 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<byte> ShiftRightLogicalNarrowingSaturateScalar(Vector64<ushort> value, [ConstantExpected(Min = 1, Max = 8)] byte count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B99 RID: 23449 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<short> ShiftRightLogicalNarrowingSaturateScalar(Vector64<int> value, [ConstantExpected(Min = 1, Max = 16)] byte count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B9A RID: 23450 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<int> ShiftRightLogicalNarrowingSaturateScalar(Vector64<long> value, [ConstantExpected(Min = 1, Max = 32)] byte count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B9B RID: 23451 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<sbyte> ShiftRightLogicalNarrowingSaturateScalar(Vector64<short> value, [ConstantExpected(Min = 1, Max = 8)] byte count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B9C RID: 23452 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<ushort> ShiftRightLogicalNarrowingSaturateScalar(Vector64<uint> value, [ConstantExpected(Min = 1, Max = 16)] byte count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B9D RID: 23453 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<uint> ShiftRightLogicalNarrowingSaturateScalar(Vector64<ulong> value, [ConstantExpected(Min = 1, Max = 32)] byte count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B9E RID: 23454 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<byte> ShiftRightLogicalRoundedNarrowingSaturateScalar(Vector64<ushort> value, [ConstantExpected(Min = 1, Max = 8)] byte count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005B9F RID: 23455 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[Obsolete("The underlying hardware instruction does not perform a signed saturate narrowing operation, and it always returns an unsigned result. Use the unsigned overload instead.", DiagnosticId = "SYSLIB0055", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
			public static Vector64<short> ShiftRightLogicalRoundedNarrowingSaturateScalar(Vector64<int> value, [ConstantExpected(Min = 1, Max = 16)] byte count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BA0 RID: 23456 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[Obsolete("The underlying hardware instruction does not perform a signed saturate narrowing operation, and it always returns an unsigned result. Use the unsigned overload instead.", DiagnosticId = "SYSLIB0055", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
			public static Vector64<int> ShiftRightLogicalRoundedNarrowingSaturateScalar(Vector64<long> value, [ConstantExpected(Min = 1, Max = 32)] byte count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BA1 RID: 23457 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[Obsolete("The underlying hardware instruction does not perform a signed saturate narrowing operation, and it always returns an unsigned result. Use the unsigned overload instead.", DiagnosticId = "SYSLIB0055", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
			public static Vector64<sbyte> ShiftRightLogicalRoundedNarrowingSaturateScalar(Vector64<short> value, [ConstantExpected(Min = 1, Max = 8)] byte count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BA2 RID: 23458 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<ushort> ShiftRightLogicalRoundedNarrowingSaturateScalar(Vector64<uint> value, [ConstantExpected(Min = 1, Max = 16)] byte count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BA3 RID: 23459 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<uint> ShiftRightLogicalRoundedNarrowingSaturateScalar(Vector64<ulong> value, [ConstantExpected(Min = 1, Max = 32)] byte count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BA4 RID: 23460 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<float> Sqrt(Vector64<float> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BA5 RID: 23461 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<double> Sqrt(Vector128<double> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BA6 RID: 23462 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<float> Sqrt(Vector128<float> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BA7 RID: 23463 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StorePair(byte* address, Vector64<byte> value1, Vector64<byte> value2)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BA8 RID: 23464 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StorePair(double* address, Vector64<double> value1, Vector64<double> value2)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BA9 RID: 23465 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StorePair(short* address, Vector64<short> value1, Vector64<short> value2)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BAA RID: 23466 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StorePair(int* address, Vector64<int> value1, Vector64<int> value2)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BAB RID: 23467 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StorePair(long* address, Vector64<long> value1, Vector64<long> value2)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BAC RID: 23468 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StorePair(sbyte* address, Vector64<sbyte> value1, Vector64<sbyte> value2)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BAD RID: 23469 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StorePair(float* address, Vector64<float> value1, Vector64<float> value2)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BAE RID: 23470 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StorePair(ushort* address, Vector64<ushort> value1, Vector64<ushort> value2)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BAF RID: 23471 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StorePair(uint* address, Vector64<uint> value1, Vector64<uint> value2)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BB0 RID: 23472 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StorePair(ulong* address, Vector64<ulong> value1, Vector64<ulong> value2)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BB1 RID: 23473 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StorePair(byte* address, Vector128<byte> value1, Vector128<byte> value2)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BB2 RID: 23474 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StorePair(double* address, Vector128<double> value1, Vector128<double> value2)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BB3 RID: 23475 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StorePair(short* address, Vector128<short> value1, Vector128<short> value2)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BB4 RID: 23476 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StorePair(int* address, Vector128<int> value1, Vector128<int> value2)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BB5 RID: 23477 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StorePair(long* address, Vector128<long> value1, Vector128<long> value2)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BB6 RID: 23478 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StorePair(sbyte* address, Vector128<sbyte> value1, Vector128<sbyte> value2)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BB7 RID: 23479 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StorePair(float* address, Vector128<float> value1, Vector128<float> value2)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BB8 RID: 23480 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StorePair(ushort* address, Vector128<ushort> value1, Vector128<ushort> value2)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BB9 RID: 23481 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StorePair(uint* address, Vector128<uint> value1, Vector128<uint> value2)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BBA RID: 23482 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StorePair(ulong* address, Vector128<ulong> value1, Vector128<ulong> value2)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BBB RID: 23483 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StorePairNonTemporal(byte* address, Vector64<byte> value1, Vector64<byte> value2)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BBC RID: 23484 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StorePairNonTemporal(double* address, Vector64<double> value1, Vector64<double> value2)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BBD RID: 23485 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StorePairNonTemporal(short* address, Vector64<short> value1, Vector64<short> value2)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BBE RID: 23486 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StorePairNonTemporal(int* address, Vector64<int> value1, Vector64<int> value2)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BBF RID: 23487 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StorePairNonTemporal(long* address, Vector64<long> value1, Vector64<long> value2)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BC0 RID: 23488 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StorePairNonTemporal(sbyte* address, Vector64<sbyte> value1, Vector64<sbyte> value2)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BC1 RID: 23489 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StorePairNonTemporal(float* address, Vector64<float> value1, Vector64<float> value2)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BC2 RID: 23490 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StorePairNonTemporal(ushort* address, Vector64<ushort> value1, Vector64<ushort> value2)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BC3 RID: 23491 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StorePairNonTemporal(uint* address, Vector64<uint> value1, Vector64<uint> value2)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BC4 RID: 23492 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StorePairNonTemporal(ulong* address, Vector64<ulong> value1, Vector64<ulong> value2)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BC5 RID: 23493 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StorePairNonTemporal(byte* address, Vector128<byte> value1, Vector128<byte> value2)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BC6 RID: 23494 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StorePairNonTemporal(double* address, Vector128<double> value1, Vector128<double> value2)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BC7 RID: 23495 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StorePairNonTemporal(short* address, Vector128<short> value1, Vector128<short> value2)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BC8 RID: 23496 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StorePairNonTemporal(int* address, Vector128<int> value1, Vector128<int> value2)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BC9 RID: 23497 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StorePairNonTemporal(long* address, Vector128<long> value1, Vector128<long> value2)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BCA RID: 23498 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StorePairNonTemporal(sbyte* address, Vector128<sbyte> value1, Vector128<sbyte> value2)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BCB RID: 23499 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StorePairNonTemporal(float* address, Vector128<float> value1, Vector128<float> value2)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BCC RID: 23500 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StorePairNonTemporal(ushort* address, Vector128<ushort> value1, Vector128<ushort> value2)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BCD RID: 23501 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StorePairNonTemporal(uint* address, Vector128<uint> value1, Vector128<uint> value2)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BCE RID: 23502 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StorePairNonTemporal(ulong* address, Vector128<ulong> value1, Vector128<ulong> value2)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BCF RID: 23503 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StorePairScalar(int* address, Vector64<int> value1, Vector64<int> value2)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BD0 RID: 23504 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StorePairScalar(float* address, Vector64<float> value1, Vector64<float> value2)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BD1 RID: 23505 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StorePairScalar(uint* address, Vector64<uint> value1, Vector64<uint> value2)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BD2 RID: 23506 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StorePairScalarNonTemporal(int* address, Vector64<int> value1, Vector64<int> value2)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BD3 RID: 23507 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StorePairScalarNonTemporal(float* address, Vector64<float> value1, Vector64<float> value2)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BD4 RID: 23508 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StorePairScalarNonTemporal(uint* address, Vector64<uint> value1, Vector64<uint> value2)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BD5 RID: 23509 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StoreSelectedScalar(byte* address, [TupleElementNames(new string[]
			{
				"value1",
				"value2"
			})] ValueTuple<Vector128<byte>, Vector128<byte>> value, [ConstantExpected(Max = 15)] byte index)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BD6 RID: 23510 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StoreSelectedScalar(sbyte* address, [TupleElementNames(new string[]
			{
				"value1",
				"value2"
			})] ValueTuple<Vector128<sbyte>, Vector128<sbyte>> value, [ConstantExpected(Max = 15)] byte index)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BD7 RID: 23511 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StoreSelectedScalar(short* address, [TupleElementNames(new string[]
			{
				"value1",
				"value2"
			})] ValueTuple<Vector128<short>, Vector128<short>> value, [ConstantExpected(Max = 7)] byte index)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BD8 RID: 23512 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StoreSelectedScalar(ushort* address, [TupleElementNames(new string[]
			{
				"value1",
				"value2"
			})] ValueTuple<Vector128<ushort>, Vector128<ushort>> value, [ConstantExpected(Max = 7)] byte index)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BD9 RID: 23513 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StoreSelectedScalar(int* address, [TupleElementNames(new string[]
			{
				"value1",
				"value2"
			})] ValueTuple<Vector128<int>, Vector128<int>> value, [ConstantExpected(Max = 3)] byte index)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BDA RID: 23514 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StoreSelectedScalar(uint* address, [TupleElementNames(new string[]
			{
				"value1",
				"value2"
			})] ValueTuple<Vector128<uint>, Vector128<uint>> value, [ConstantExpected(Max = 3)] byte index)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BDB RID: 23515 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StoreSelectedScalar(long* address, [TupleElementNames(new string[]
			{
				"value1",
				"value2"
			})] ValueTuple<Vector128<long>, Vector128<long>> value, [ConstantExpected(Max = 1)] byte index)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BDC RID: 23516 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StoreSelectedScalar(ulong* address, [TupleElementNames(new string[]
			{
				"value1",
				"value2"
			})] ValueTuple<Vector128<ulong>, Vector128<ulong>> value, [ConstantExpected(Max = 1)] byte index)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BDD RID: 23517 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StoreSelectedScalar(float* address, [TupleElementNames(new string[]
			{
				"value1",
				"value2"
			})] ValueTuple<Vector128<float>, Vector128<float>> value, [ConstantExpected(Max = 3)] byte index)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BDE RID: 23518 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StoreSelectedScalar(double* address, [TupleElementNames(new string[]
			{
				"value1",
				"value2"
			})] ValueTuple<Vector128<double>, Vector128<double>> value, [ConstantExpected(Max = 1)] byte index)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BDF RID: 23519 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StoreSelectedScalar(byte* address, [TupleElementNames(new string[]
			{
				"value1",
				"value2",
				"value3"
			})] ValueTuple<Vector128<byte>, Vector128<byte>, Vector128<byte>> value, [ConstantExpected(Max = 15)] byte index)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BE0 RID: 23520 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StoreSelectedScalar(sbyte* address, [TupleElementNames(new string[]
			{
				"value1",
				"value2",
				"value3"
			})] ValueTuple<Vector128<sbyte>, Vector128<sbyte>, Vector128<sbyte>> value, [ConstantExpected(Max = 15)] byte index)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BE1 RID: 23521 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StoreSelectedScalar(short* address, [TupleElementNames(new string[]
			{
				"value1",
				"value2",
				"value3"
			})] ValueTuple<Vector128<short>, Vector128<short>, Vector128<short>> value, [ConstantExpected(Max = 7)] byte index)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BE2 RID: 23522 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StoreSelectedScalar(ushort* address, [TupleElementNames(new string[]
			{
				"value1",
				"value2",
				"value3"
			})] ValueTuple<Vector128<ushort>, Vector128<ushort>, Vector128<ushort>> value, [ConstantExpected(Max = 7)] byte index)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BE3 RID: 23523 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StoreSelectedScalar(int* address, [TupleElementNames(new string[]
			{
				"value1",
				"value2",
				"value3"
			})] ValueTuple<Vector128<int>, Vector128<int>, Vector128<int>> value, [ConstantExpected(Max = 3)] byte index)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BE4 RID: 23524 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StoreSelectedScalar(uint* address, [TupleElementNames(new string[]
			{
				"value1",
				"value2",
				"value3"
			})] ValueTuple<Vector128<uint>, Vector128<uint>, Vector128<uint>> value, [ConstantExpected(Max = 3)] byte index)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BE5 RID: 23525 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StoreSelectedScalar(long* address, [TupleElementNames(new string[]
			{
				"value1",
				"value2",
				"value3"
			})] ValueTuple<Vector128<long>, Vector128<long>, Vector128<long>> value, [ConstantExpected(Max = 1)] byte index)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BE6 RID: 23526 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StoreSelectedScalar(ulong* address, [TupleElementNames(new string[]
			{
				"value1",
				"value2",
				"value3"
			})] ValueTuple<Vector128<ulong>, Vector128<ulong>, Vector128<ulong>> value, [ConstantExpected(Max = 1)] byte index)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BE7 RID: 23527 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StoreSelectedScalar(float* address, [TupleElementNames(new string[]
			{
				"value1",
				"value2",
				"value3"
			})] ValueTuple<Vector128<float>, Vector128<float>, Vector128<float>> value, [ConstantExpected(Max = 3)] byte index)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BE8 RID: 23528 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StoreSelectedScalar(double* address, [TupleElementNames(new string[]
			{
				"value1",
				"value2",
				"value3"
			})] ValueTuple<Vector128<double>, Vector128<double>, Vector128<double>> value, [ConstantExpected(Max = 1)] byte index)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BE9 RID: 23529 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StoreSelectedScalar(byte* address, [TupleElementNames(new string[]
			{
				"value1",
				"value2",
				"value3",
				"value4"
			})] ValueTuple<Vector128<byte>, Vector128<byte>, Vector128<byte>, Vector128<byte>> value, [ConstantExpected(Max = 15)] byte index)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BEA RID: 23530 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StoreSelectedScalar(sbyte* address, [TupleElementNames(new string[]
			{
				"value1",
				"value2",
				"value3",
				"value4"
			})] ValueTuple<Vector128<sbyte>, Vector128<sbyte>, Vector128<sbyte>, Vector128<sbyte>> value, [ConstantExpected(Max = 15)] byte index)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BEB RID: 23531 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StoreSelectedScalar(short* address, [TupleElementNames(new string[]
			{
				"value1",
				"value2",
				"value3",
				"value4"
			})] ValueTuple<Vector128<short>, Vector128<short>, Vector128<short>, Vector128<short>> value, [ConstantExpected(Max = 7)] byte index)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BEC RID: 23532 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StoreSelectedScalar(ushort* address, [TupleElementNames(new string[]
			{
				"value1",
				"value2",
				"value3",
				"value4"
			})] ValueTuple<Vector128<ushort>, Vector128<ushort>, Vector128<ushort>, Vector128<ushort>> value, [ConstantExpected(Max = 7)] byte index)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BED RID: 23533 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StoreSelectedScalar(int* address, [TupleElementNames(new string[]
			{
				"value1",
				"value2",
				"value3",
				"value4"
			})] ValueTuple<Vector128<int>, Vector128<int>, Vector128<int>, Vector128<int>> value, [ConstantExpected(Max = 3)] byte index)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BEE RID: 23534 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StoreSelectedScalar(uint* address, [TupleElementNames(new string[]
			{
				"value1",
				"value2",
				"value3",
				"value4"
			})] ValueTuple<Vector128<uint>, Vector128<uint>, Vector128<uint>, Vector128<uint>> value, [ConstantExpected(Max = 3)] byte index)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BEF RID: 23535 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StoreSelectedScalar(long* address, [TupleElementNames(new string[]
			{
				"value1",
				"value2",
				"value3",
				"value4"
			})] ValueTuple<Vector128<long>, Vector128<long>, Vector128<long>, Vector128<long>> value, [ConstantExpected(Max = 1)] byte index)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BF0 RID: 23536 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StoreSelectedScalar(ulong* address, [TupleElementNames(new string[]
			{
				"value1",
				"value2",
				"value3",
				"value4"
			})] ValueTuple<Vector128<ulong>, Vector128<ulong>, Vector128<ulong>, Vector128<ulong>> value, [ConstantExpected(Max = 1)] byte index)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BF1 RID: 23537 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StoreSelectedScalar(float* address, [TupleElementNames(new string[]
			{
				"value1",
				"value2",
				"value3",
				"value4"
			})] ValueTuple<Vector128<float>, Vector128<float>, Vector128<float>, Vector128<float>> value, [ConstantExpected(Max = 3)] byte index)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BF2 RID: 23538 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StoreSelectedScalar(double* address, [TupleElementNames(new string[]
			{
				"value1",
				"value2",
				"value3",
				"value4"
			})] ValueTuple<Vector128<double>, Vector128<double>, Vector128<double>, Vector128<double>> value, [ConstantExpected(Max = 1)] byte index)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BF3 RID: 23539 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StoreVectorAndZip(byte* address, [TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})] ValueTuple<Vector128<byte>, Vector128<byte>> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BF4 RID: 23540 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StoreVectorAndZip(sbyte* address, [TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})] ValueTuple<Vector128<sbyte>, Vector128<sbyte>> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BF5 RID: 23541 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StoreVectorAndZip(short* address, [TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})] ValueTuple<Vector128<short>, Vector128<short>> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BF6 RID: 23542 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StoreVectorAndZip(ushort* address, [TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})] ValueTuple<Vector128<ushort>, Vector128<ushort>> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BF7 RID: 23543 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StoreVectorAndZip(int* address, [TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})] ValueTuple<Vector128<int>, Vector128<int>> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BF8 RID: 23544 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StoreVectorAndZip(uint* address, [TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})] ValueTuple<Vector128<uint>, Vector128<uint>> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BF9 RID: 23545 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StoreVectorAndZip(long* address, [TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})] ValueTuple<Vector128<long>, Vector128<long>> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BFA RID: 23546 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StoreVectorAndZip(ulong* address, [TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})] ValueTuple<Vector128<ulong>, Vector128<ulong>> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BFB RID: 23547 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StoreVectorAndZip(float* address, [TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})] ValueTuple<Vector128<float>, Vector128<float>> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BFC RID: 23548 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StoreVectorAndZip(double* address, [TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})] ValueTuple<Vector128<double>, Vector128<double>> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BFD RID: 23549 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StoreVectorAndZip(byte* address, [TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3"
			})] ValueTuple<Vector128<byte>, Vector128<byte>, Vector128<byte>> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BFE RID: 23550 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StoreVectorAndZip(sbyte* address, [TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3"
			})] ValueTuple<Vector128<sbyte>, Vector128<sbyte>, Vector128<sbyte>> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005BFF RID: 23551 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StoreVectorAndZip(short* address, [TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3"
			})] ValueTuple<Vector128<short>, Vector128<short>, Vector128<short>> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C00 RID: 23552 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StoreVectorAndZip(ushort* address, [TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3"
			})] ValueTuple<Vector128<ushort>, Vector128<ushort>, Vector128<ushort>> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C01 RID: 23553 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StoreVectorAndZip(int* address, [TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3"
			})] ValueTuple<Vector128<int>, Vector128<int>, Vector128<int>> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C02 RID: 23554 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StoreVectorAndZip(uint* address, [TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3"
			})] ValueTuple<Vector128<uint>, Vector128<uint>, Vector128<uint>> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C03 RID: 23555 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StoreVectorAndZip(long* address, [TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3"
			})] ValueTuple<Vector128<long>, Vector128<long>, Vector128<long>> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C04 RID: 23556 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StoreVectorAndZip(ulong* address, [TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3"
			})] ValueTuple<Vector128<ulong>, Vector128<ulong>, Vector128<ulong>> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C05 RID: 23557 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StoreVectorAndZip(float* address, [TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3"
			})] ValueTuple<Vector128<float>, Vector128<float>, Vector128<float>> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C06 RID: 23558 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StoreVectorAndZip(double* address, [TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3"
			})] ValueTuple<Vector128<double>, Vector128<double>, Vector128<double>> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C07 RID: 23559 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StoreVectorAndZip(byte* address, [TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3",
				"Value4"
			})] ValueTuple<Vector128<byte>, Vector128<byte>, Vector128<byte>, Vector128<byte>> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C08 RID: 23560 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StoreVectorAndZip(sbyte* address, [TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3",
				"Value4"
			})] ValueTuple<Vector128<sbyte>, Vector128<sbyte>, Vector128<sbyte>, Vector128<sbyte>> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C09 RID: 23561 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StoreVectorAndZip(short* address, [TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3",
				"Value4"
			})] ValueTuple<Vector128<short>, Vector128<short>, Vector128<short>, Vector128<short>> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C0A RID: 23562 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StoreVectorAndZip(ushort* address, [TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3",
				"Value4"
			})] ValueTuple<Vector128<ushort>, Vector128<ushort>, Vector128<ushort>, Vector128<ushort>> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C0B RID: 23563 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StoreVectorAndZip(int* address, [TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3",
				"Value4"
			})] ValueTuple<Vector128<int>, Vector128<int>, Vector128<int>, Vector128<int>> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C0C RID: 23564 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StoreVectorAndZip(uint* address, [TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3",
				"Value4"
			})] ValueTuple<Vector128<uint>, Vector128<uint>, Vector128<uint>, Vector128<uint>> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C0D RID: 23565 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StoreVectorAndZip(long* address, [TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3",
				"Value4"
			})] ValueTuple<Vector128<long>, Vector128<long>, Vector128<long>, Vector128<long>> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C0E RID: 23566 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StoreVectorAndZip(ulong* address, [TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3",
				"Value4"
			})] ValueTuple<Vector128<ulong>, Vector128<ulong>, Vector128<ulong>, Vector128<ulong>> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C0F RID: 23567 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StoreVectorAndZip(float* address, [TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3",
				"Value4"
			})] ValueTuple<Vector128<float>, Vector128<float>, Vector128<float>, Vector128<float>> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C10 RID: 23568 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void StoreVectorAndZip(double* address, [TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3",
				"Value4"
			})] ValueTuple<Vector128<double>, Vector128<double>, Vector128<double>, Vector128<double>> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C11 RID: 23569 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void Store(byte* address, [TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})] ValueTuple<Vector128<byte>, Vector128<byte>> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C12 RID: 23570 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void Store(sbyte* address, [TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})] ValueTuple<Vector128<sbyte>, Vector128<sbyte>> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C13 RID: 23571 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void Store(short* address, [TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})] ValueTuple<Vector128<short>, Vector128<short>> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C14 RID: 23572 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void Store(ushort* address, [TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})] ValueTuple<Vector128<ushort>, Vector128<ushort>> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C15 RID: 23573 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void Store(int* address, [TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})] ValueTuple<Vector128<int>, Vector128<int>> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C16 RID: 23574 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void Store(uint* address, [TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})] ValueTuple<Vector128<uint>, Vector128<uint>> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C17 RID: 23575 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void Store(long* address, [TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})] ValueTuple<Vector128<long>, Vector128<long>> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C18 RID: 23576 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void Store(ulong* address, [TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})] ValueTuple<Vector128<ulong>, Vector128<ulong>> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C19 RID: 23577 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void Store(float* address, [TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})] ValueTuple<Vector128<float>, Vector128<float>> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C1A RID: 23578 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void Store(double* address, [TupleElementNames(new string[]
			{
				"Value1",
				"Value2"
			})] ValueTuple<Vector128<double>, Vector128<double>> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C1B RID: 23579 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void Store(byte* address, [TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3"
			})] ValueTuple<Vector128<byte>, Vector128<byte>, Vector128<byte>> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C1C RID: 23580 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void Store(sbyte* address, [TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3"
			})] ValueTuple<Vector128<sbyte>, Vector128<sbyte>, Vector128<sbyte>> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C1D RID: 23581 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void Store(short* address, [TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3"
			})] ValueTuple<Vector128<short>, Vector128<short>, Vector128<short>> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C1E RID: 23582 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void Store(ushort* address, [TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3"
			})] ValueTuple<Vector128<ushort>, Vector128<ushort>, Vector128<ushort>> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C1F RID: 23583 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void Store(int* address, [TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3"
			})] ValueTuple<Vector128<int>, Vector128<int>, Vector128<int>> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C20 RID: 23584 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void Store(uint* address, [TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3"
			})] ValueTuple<Vector128<uint>, Vector128<uint>, Vector128<uint>> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C21 RID: 23585 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void Store(long* address, [TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3"
			})] ValueTuple<Vector128<long>, Vector128<long>, Vector128<long>> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C22 RID: 23586 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void Store(ulong* address, [TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3"
			})] ValueTuple<Vector128<ulong>, Vector128<ulong>, Vector128<ulong>> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C23 RID: 23587 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void Store(float* address, [TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3"
			})] ValueTuple<Vector128<float>, Vector128<float>, Vector128<float>> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C24 RID: 23588 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void Store(double* address, [TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3"
			})] ValueTuple<Vector128<double>, Vector128<double>, Vector128<double>> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C25 RID: 23589 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void Store(byte* address, [TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3",
				"Value4"
			})] ValueTuple<Vector128<byte>, Vector128<byte>, Vector128<byte>, Vector128<byte>> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C26 RID: 23590 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void Store(sbyte* address, [TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3",
				"Value4"
			})] ValueTuple<Vector128<sbyte>, Vector128<sbyte>, Vector128<sbyte>, Vector128<sbyte>> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C27 RID: 23591 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void Store(short* address, [TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3",
				"Value4"
			})] ValueTuple<Vector128<short>, Vector128<short>, Vector128<short>, Vector128<short>> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C28 RID: 23592 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void Store(ushort* address, [TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3",
				"Value4"
			})] ValueTuple<Vector128<ushort>, Vector128<ushort>, Vector128<ushort>, Vector128<ushort>> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C29 RID: 23593 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void Store(int* address, [TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3",
				"Value4"
			})] ValueTuple<Vector128<int>, Vector128<int>, Vector128<int>, Vector128<int>> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C2A RID: 23594 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void Store(uint* address, [TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3",
				"Value4"
			})] ValueTuple<Vector128<uint>, Vector128<uint>, Vector128<uint>, Vector128<uint>> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C2B RID: 23595 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void Store(long* address, [TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3",
				"Value4"
			})] ValueTuple<Vector128<long>, Vector128<long>, Vector128<long>, Vector128<long>> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C2C RID: 23596 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void Store(ulong* address, [TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3",
				"Value4"
			})] ValueTuple<Vector128<ulong>, Vector128<ulong>, Vector128<ulong>, Vector128<ulong>> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C2D RID: 23597 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void Store(float* address, [TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3",
				"Value4"
			})] ValueTuple<Vector128<float>, Vector128<float>, Vector128<float>, Vector128<float>> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C2E RID: 23598 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public unsafe static void Store(double* address, [TupleElementNames(new string[]
			{
				"Value1",
				"Value2",
				"Value3",
				"Value4"
			})] ValueTuple<Vector128<double>, Vector128<double>, Vector128<double>, Vector128<double>> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C2F RID: 23599 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<double> Subtract(Vector128<double> left, Vector128<double> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C30 RID: 23600 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<byte> SubtractSaturateScalar(Vector64<byte> left, Vector64<byte> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C31 RID: 23601 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<short> SubtractSaturateScalar(Vector64<short> left, Vector64<short> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C32 RID: 23602 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<int> SubtractSaturateScalar(Vector64<int> left, Vector64<int> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C33 RID: 23603 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<sbyte> SubtractSaturateScalar(Vector64<sbyte> left, Vector64<sbyte> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C34 RID: 23604 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<ushort> SubtractSaturateScalar(Vector64<ushort> left, Vector64<ushort> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C35 RID: 23605 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<uint> SubtractSaturateScalar(Vector64<uint> left, Vector64<uint> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C36 RID: 23606 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<byte> ReverseElementBits(Vector64<byte> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C37 RID: 23607 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<sbyte> ReverseElementBits(Vector64<sbyte> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C38 RID: 23608 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<byte> ReverseElementBits(Vector128<byte> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C39 RID: 23609 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<sbyte> ReverseElementBits(Vector128<sbyte> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C3A RID: 23610 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<byte> TransposeEven(Vector64<byte> left, Vector64<byte> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C3B RID: 23611 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<short> TransposeEven(Vector64<short> left, Vector64<short> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C3C RID: 23612 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<int> TransposeEven(Vector64<int> left, Vector64<int> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C3D RID: 23613 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<sbyte> TransposeEven(Vector64<sbyte> left, Vector64<sbyte> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C3E RID: 23614 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<float> TransposeEven(Vector64<float> left, Vector64<float> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C3F RID: 23615 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<ushort> TransposeEven(Vector64<ushort> left, Vector64<ushort> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C40 RID: 23616 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<uint> TransposeEven(Vector64<uint> left, Vector64<uint> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C41 RID: 23617 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<byte> TransposeEven(Vector128<byte> left, Vector128<byte> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C42 RID: 23618 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<double> TransposeEven(Vector128<double> left, Vector128<double> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C43 RID: 23619 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<short> TransposeEven(Vector128<short> left, Vector128<short> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C44 RID: 23620 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<int> TransposeEven(Vector128<int> left, Vector128<int> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C45 RID: 23621 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<long> TransposeEven(Vector128<long> left, Vector128<long> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C46 RID: 23622 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<sbyte> TransposeEven(Vector128<sbyte> left, Vector128<sbyte> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C47 RID: 23623 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<float> TransposeEven(Vector128<float> left, Vector128<float> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C48 RID: 23624 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<ushort> TransposeEven(Vector128<ushort> left, Vector128<ushort> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C49 RID: 23625 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<uint> TransposeEven(Vector128<uint> left, Vector128<uint> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C4A RID: 23626 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<ulong> TransposeEven(Vector128<ulong> left, Vector128<ulong> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C4B RID: 23627 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<byte> TransposeOdd(Vector64<byte> left, Vector64<byte> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C4C RID: 23628 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<short> TransposeOdd(Vector64<short> left, Vector64<short> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C4D RID: 23629 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<int> TransposeOdd(Vector64<int> left, Vector64<int> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C4E RID: 23630 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<sbyte> TransposeOdd(Vector64<sbyte> left, Vector64<sbyte> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C4F RID: 23631 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<float> TransposeOdd(Vector64<float> left, Vector64<float> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C50 RID: 23632 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<ushort> TransposeOdd(Vector64<ushort> left, Vector64<ushort> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C51 RID: 23633 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<uint> TransposeOdd(Vector64<uint> left, Vector64<uint> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C52 RID: 23634 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<byte> TransposeOdd(Vector128<byte> left, Vector128<byte> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C53 RID: 23635 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<double> TransposeOdd(Vector128<double> left, Vector128<double> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C54 RID: 23636 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<short> TransposeOdd(Vector128<short> left, Vector128<short> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C55 RID: 23637 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<int> TransposeOdd(Vector128<int> left, Vector128<int> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C56 RID: 23638 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<long> TransposeOdd(Vector128<long> left, Vector128<long> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C57 RID: 23639 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<sbyte> TransposeOdd(Vector128<sbyte> left, Vector128<sbyte> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C58 RID: 23640 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<float> TransposeOdd(Vector128<float> left, Vector128<float> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C59 RID: 23641 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<ushort> TransposeOdd(Vector128<ushort> left, Vector128<ushort> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C5A RID: 23642 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<uint> TransposeOdd(Vector128<uint> left, Vector128<uint> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C5B RID: 23643 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<ulong> TransposeOdd(Vector128<ulong> left, Vector128<ulong> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C5C RID: 23644 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<byte> UnzipEven(Vector64<byte> left, Vector64<byte> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C5D RID: 23645 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<short> UnzipEven(Vector64<short> left, Vector64<short> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C5E RID: 23646 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<int> UnzipEven(Vector64<int> left, Vector64<int> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C5F RID: 23647 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<sbyte> UnzipEven(Vector64<sbyte> left, Vector64<sbyte> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C60 RID: 23648 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<float> UnzipEven(Vector64<float> left, Vector64<float> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C61 RID: 23649 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<ushort> UnzipEven(Vector64<ushort> left, Vector64<ushort> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C62 RID: 23650 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<uint> UnzipEven(Vector64<uint> left, Vector64<uint> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C63 RID: 23651 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<byte> UnzipEven(Vector128<byte> left, Vector128<byte> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C64 RID: 23652 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<double> UnzipEven(Vector128<double> left, Vector128<double> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C65 RID: 23653 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<short> UnzipEven(Vector128<short> left, Vector128<short> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C66 RID: 23654 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<int> UnzipEven(Vector128<int> left, Vector128<int> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C67 RID: 23655 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<long> UnzipEven(Vector128<long> left, Vector128<long> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C68 RID: 23656 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<sbyte> UnzipEven(Vector128<sbyte> left, Vector128<sbyte> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C69 RID: 23657 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<float> UnzipEven(Vector128<float> left, Vector128<float> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C6A RID: 23658 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<ushort> UnzipEven(Vector128<ushort> left, Vector128<ushort> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C6B RID: 23659 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<uint> UnzipEven(Vector128<uint> left, Vector128<uint> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C6C RID: 23660 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<ulong> UnzipEven(Vector128<ulong> left, Vector128<ulong> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C6D RID: 23661 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<byte> UnzipOdd(Vector64<byte> left, Vector64<byte> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C6E RID: 23662 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<short> UnzipOdd(Vector64<short> left, Vector64<short> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C6F RID: 23663 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<int> UnzipOdd(Vector64<int> left, Vector64<int> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C70 RID: 23664 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<sbyte> UnzipOdd(Vector64<sbyte> left, Vector64<sbyte> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C71 RID: 23665 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<float> UnzipOdd(Vector64<float> left, Vector64<float> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C72 RID: 23666 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<ushort> UnzipOdd(Vector64<ushort> left, Vector64<ushort> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C73 RID: 23667 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<uint> UnzipOdd(Vector64<uint> left, Vector64<uint> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C74 RID: 23668 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<byte> UnzipOdd(Vector128<byte> left, Vector128<byte> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C75 RID: 23669 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<double> UnzipOdd(Vector128<double> left, Vector128<double> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C76 RID: 23670 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<short> UnzipOdd(Vector128<short> left, Vector128<short> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C77 RID: 23671 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<int> UnzipOdd(Vector128<int> left, Vector128<int> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C78 RID: 23672 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<long> UnzipOdd(Vector128<long> left, Vector128<long> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C79 RID: 23673 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<sbyte> UnzipOdd(Vector128<sbyte> left, Vector128<sbyte> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C7A RID: 23674 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<float> UnzipOdd(Vector128<float> left, Vector128<float> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C7B RID: 23675 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<ushort> UnzipOdd(Vector128<ushort> left, Vector128<ushort> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C7C RID: 23676 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<uint> UnzipOdd(Vector128<uint> left, Vector128<uint> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C7D RID: 23677 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<ulong> UnzipOdd(Vector128<ulong> left, Vector128<ulong> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C7E RID: 23678 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<byte> VectorTableLookup(Vector128<byte> table, Vector128<byte> byteIndexes)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C7F RID: 23679 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<sbyte> VectorTableLookup(Vector128<sbyte> table, Vector128<sbyte> byteIndexes)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C80 RID: 23680 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<byte> VectorTableLookup(ValueTuple<Vector128<byte>, Vector128<byte>> table, Vector128<byte> byteIndexes)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C81 RID: 23681 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<sbyte> VectorTableLookup(ValueTuple<Vector128<sbyte>, Vector128<sbyte>> table, Vector128<sbyte> byteIndexes)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C82 RID: 23682 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<byte> VectorTableLookup(ValueTuple<Vector128<byte>, Vector128<byte>, Vector128<byte>> table, Vector128<byte> byteIndexes)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C83 RID: 23683 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<sbyte> VectorTableLookup(ValueTuple<Vector128<sbyte>, Vector128<sbyte>, Vector128<sbyte>> table, Vector128<sbyte> byteIndexes)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C84 RID: 23684 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<byte> VectorTableLookup(ValueTuple<Vector128<byte>, Vector128<byte>, Vector128<byte>, Vector128<byte>> table, Vector128<byte> byteIndexes)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C85 RID: 23685 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<sbyte> VectorTableLookup(ValueTuple<Vector128<sbyte>, Vector128<sbyte>, Vector128<sbyte>, Vector128<sbyte>> table, Vector128<sbyte> byteIndexes)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C86 RID: 23686 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<byte> VectorTableLookupExtension(Vector128<byte> defaultValues, Vector128<byte> table, Vector128<byte> byteIndexes)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C87 RID: 23687 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<sbyte> VectorTableLookupExtension(Vector128<sbyte> defaultValues, Vector128<sbyte> table, Vector128<sbyte> byteIndexes)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C88 RID: 23688 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<byte> VectorTableLookupExtension(Vector128<byte> defaultValues, ValueTuple<Vector128<byte>, Vector128<byte>> table, Vector128<byte> byteIndexes)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C89 RID: 23689 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<sbyte> VectorTableLookupExtension(Vector128<sbyte> defaultValues, ValueTuple<Vector128<sbyte>, Vector128<sbyte>> table, Vector128<sbyte> byteIndexes)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C8A RID: 23690 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<byte> VectorTableLookupExtension(Vector128<byte> defaultValues, ValueTuple<Vector128<byte>, Vector128<byte>, Vector128<byte>> table, Vector128<byte> byteIndexes)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C8B RID: 23691 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<sbyte> VectorTableLookupExtension(Vector128<sbyte> defaultValues, ValueTuple<Vector128<sbyte>, Vector128<sbyte>, Vector128<sbyte>> table, Vector128<sbyte> byteIndexes)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C8C RID: 23692 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<byte> VectorTableLookupExtension(Vector128<byte> defaultValues, ValueTuple<Vector128<byte>, Vector128<byte>, Vector128<byte>, Vector128<byte>> table, Vector128<byte> byteIndexes)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C8D RID: 23693 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<sbyte> VectorTableLookupExtension(Vector128<sbyte> defaultValues, ValueTuple<Vector128<sbyte>, Vector128<sbyte>, Vector128<sbyte>, Vector128<sbyte>> table, Vector128<sbyte> byteIndexes)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C8E RID: 23694 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<byte> ZipHigh(Vector64<byte> left, Vector64<byte> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C8F RID: 23695 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<short> ZipHigh(Vector64<short> left, Vector64<short> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C90 RID: 23696 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<int> ZipHigh(Vector64<int> left, Vector64<int> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C91 RID: 23697 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<sbyte> ZipHigh(Vector64<sbyte> left, Vector64<sbyte> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C92 RID: 23698 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<float> ZipHigh(Vector64<float> left, Vector64<float> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C93 RID: 23699 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<ushort> ZipHigh(Vector64<ushort> left, Vector64<ushort> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C94 RID: 23700 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<uint> ZipHigh(Vector64<uint> left, Vector64<uint> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C95 RID: 23701 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<byte> ZipHigh(Vector128<byte> left, Vector128<byte> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C96 RID: 23702 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<double> ZipHigh(Vector128<double> left, Vector128<double> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C97 RID: 23703 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<short> ZipHigh(Vector128<short> left, Vector128<short> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C98 RID: 23704 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<int> ZipHigh(Vector128<int> left, Vector128<int> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C99 RID: 23705 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<long> ZipHigh(Vector128<long> left, Vector128<long> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C9A RID: 23706 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<sbyte> ZipHigh(Vector128<sbyte> left, Vector128<sbyte> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C9B RID: 23707 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<float> ZipHigh(Vector128<float> left, Vector128<float> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C9C RID: 23708 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<ushort> ZipHigh(Vector128<ushort> left, Vector128<ushort> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C9D RID: 23709 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<uint> ZipHigh(Vector128<uint> left, Vector128<uint> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C9E RID: 23710 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<ulong> ZipHigh(Vector128<ulong> left, Vector128<ulong> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005C9F RID: 23711 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<byte> ZipLow(Vector64<byte> left, Vector64<byte> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005CA0 RID: 23712 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<short> ZipLow(Vector64<short> left, Vector64<short> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005CA1 RID: 23713 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<int> ZipLow(Vector64<int> left, Vector64<int> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005CA2 RID: 23714 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<sbyte> ZipLow(Vector64<sbyte> left, Vector64<sbyte> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005CA3 RID: 23715 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<float> ZipLow(Vector64<float> left, Vector64<float> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005CA4 RID: 23716 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<ushort> ZipLow(Vector64<ushort> left, Vector64<ushort> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005CA5 RID: 23717 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<uint> ZipLow(Vector64<uint> left, Vector64<uint> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005CA6 RID: 23718 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<byte> ZipLow(Vector128<byte> left, Vector128<byte> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005CA7 RID: 23719 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<double> ZipLow(Vector128<double> left, Vector128<double> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005CA8 RID: 23720 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<short> ZipLow(Vector128<short> left, Vector128<short> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005CA9 RID: 23721 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<int> ZipLow(Vector128<int> left, Vector128<int> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005CAA RID: 23722 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<long> ZipLow(Vector128<long> left, Vector128<long> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005CAB RID: 23723 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<sbyte> ZipLow(Vector128<sbyte> left, Vector128<sbyte> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005CAC RID: 23724 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<float> ZipLow(Vector128<float> left, Vector128<float> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005CAD RID: 23725 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<ushort> ZipLow(Vector128<ushort> left, Vector128<ushort> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005CAE RID: 23726 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<uint> ZipLow(Vector128<uint> left, Vector128<uint> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005CAF RID: 23727 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<ulong> ZipLow(Vector128<ulong> left, Vector128<ulong> right)
			{
				throw new PlatformNotSupportedException();
			}
		}
	}
}
