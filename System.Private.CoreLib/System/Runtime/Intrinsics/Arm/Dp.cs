using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Runtime.Intrinsics.Arm
{
	// Token: 0x0200055B RID: 1371
	[CLSCompliant(false)]
	public abstract class Dp : AdvSimd
	{
		// Token: 0x17000D6A RID: 3434
		// (get) Token: 0x06005CD3 RID: 23763 RVA: 0x00007B65 File Offset: 0x00005D65
		public new static bool IsSupported
		{
			[Intrinsic]
			get
			{
				return false;
			}
		}

		// Token: 0x06005CD4 RID: 23764 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> DotProduct(Vector64<int> addend, Vector64<sbyte> left, Vector64<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005CD5 RID: 23765 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> DotProduct(Vector64<uint> addend, Vector64<byte> left, Vector64<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005CD6 RID: 23766 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> DotProduct(Vector128<int> addend, Vector128<sbyte> left, Vector128<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005CD7 RID: 23767 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> DotProduct(Vector128<uint> addend, Vector128<byte> left, Vector128<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005CD8 RID: 23768 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> DotProductBySelectedQuadruplet(Vector64<int> addend, Vector64<sbyte> left, Vector64<sbyte> right, [ConstantExpected(Max = 7)] byte rightScaledIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005CD9 RID: 23769 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> DotProductBySelectedQuadruplet(Vector64<int> addend, Vector64<sbyte> left, Vector128<sbyte> right, [ConstantExpected(Max = 15)] byte rightScaledIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005CDA RID: 23770 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> DotProductBySelectedQuadruplet(Vector64<uint> addend, Vector64<byte> left, Vector64<byte> right, [ConstantExpected(Max = 7)] byte rightScaledIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005CDB RID: 23771 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> DotProductBySelectedQuadruplet(Vector64<uint> addend, Vector64<byte> left, Vector128<byte> right, [ConstantExpected(Max = 15)] byte rightScaledIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005CDC RID: 23772 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> DotProductBySelectedQuadruplet(Vector128<int> addend, Vector128<sbyte> left, Vector128<sbyte> right, [ConstantExpected(Max = 15)] byte rightScaledIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005CDD RID: 23773 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> DotProductBySelectedQuadruplet(Vector128<int> addend, Vector128<sbyte> left, Vector64<sbyte> right, [ConstantExpected(Max = 7)] byte rightScaledIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005CDE RID: 23774 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> DotProductBySelectedQuadruplet(Vector128<uint> addend, Vector128<byte> left, Vector128<byte> right, [ConstantExpected(Max = 15)] byte rightScaledIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005CDF RID: 23775 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> DotProductBySelectedQuadruplet(Vector128<uint> addend, Vector128<byte> left, Vector64<byte> right, [ConstantExpected(Max = 7)] byte rightScaledIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0200055C RID: 1372
		public new abstract class Arm64 : AdvSimd.Arm64
		{
			// Token: 0x17000D6B RID: 3435
			// (get) Token: 0x06005CE0 RID: 23776 RVA: 0x00007B65 File Offset: 0x00005D65
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
