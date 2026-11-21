using System;
using System.Runtime.CompilerServices;

namespace System.Runtime.Intrinsics.Arm
{
	// Token: 0x02000559 RID: 1369
	[CLSCompliant(false)]
	public abstract class Crc32 : ArmBase
	{
		// Token: 0x17000D68 RID: 3432
		// (get) Token: 0x06005CC9 RID: 23753 RVA: 0x00007B65 File Offset: 0x00005D65
		public new static bool IsSupported
		{
			[Intrinsic]
			get
			{
				return false;
			}
		}

		// Token: 0x06005CCA RID: 23754 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static uint ComputeCrc32(uint crc, byte data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005CCB RID: 23755 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static uint ComputeCrc32(uint crc, ushort data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005CCC RID: 23756 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static uint ComputeCrc32(uint crc, uint data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005CCD RID: 23757 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static uint ComputeCrc32C(uint crc, byte data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005CCE RID: 23758 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static uint ComputeCrc32C(uint crc, ushort data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005CCF RID: 23759 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static uint ComputeCrc32C(uint crc, uint data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0200055A RID: 1370
		public new abstract class Arm64 : ArmBase.Arm64
		{
			// Token: 0x17000D69 RID: 3433
			// (get) Token: 0x06005CD0 RID: 23760 RVA: 0x00007B65 File Offset: 0x00005D65
			public new static bool IsSupported
			{
				[Intrinsic]
				get
				{
					return false;
				}
			}

			// Token: 0x06005CD1 RID: 23761 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static uint ComputeCrc32(uint crc, ulong data)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005CD2 RID: 23762 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static uint ComputeCrc32C(uint crc, ulong data)
			{
				throw new PlatformNotSupportedException();
			}
		}
	}
}
