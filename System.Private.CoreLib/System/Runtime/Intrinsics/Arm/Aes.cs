using System;
using System.Runtime.CompilerServices;

namespace System.Runtime.Intrinsics.Arm
{
	// Token: 0x02000555 RID: 1365
	[CLSCompliant(false)]
	public abstract class Aes : ArmBase
	{
		// Token: 0x17000D64 RID: 3428
		// (get) Token: 0x06005CB0 RID: 23728 RVA: 0x00007B65 File Offset: 0x00005D65
		public new static bool IsSupported
		{
			[Intrinsic]
			get
			{
				return false;
			}
		}

		// Token: 0x06005CB1 RID: 23729 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> Decrypt(Vector128<byte> value, Vector128<byte> roundKey)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005CB2 RID: 23730 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> Encrypt(Vector128<byte> value, Vector128<byte> roundKey)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005CB3 RID: 23731 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> InverseMixColumns(Vector128<byte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005CB4 RID: 23732 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> MixColumns(Vector128<byte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005CB5 RID: 23733 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> PolynomialMultiplyWideningLower(Vector64<long> left, Vector64<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005CB6 RID: 23734 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> PolynomialMultiplyWideningLower(Vector64<ulong> left, Vector64<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005CB7 RID: 23735 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> PolynomialMultiplyWideningUpper(Vector128<long> left, Vector128<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005CB8 RID: 23736 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> PolynomialMultiplyWideningUpper(Vector128<ulong> left, Vector128<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x02000556 RID: 1366
		public new abstract class Arm64 : ArmBase.Arm64
		{
			// Token: 0x17000D65 RID: 3429
			// (get) Token: 0x06005CB9 RID: 23737 RVA: 0x00007B65 File Offset: 0x00005D65
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
