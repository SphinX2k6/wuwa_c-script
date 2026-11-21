using System;
using System.Runtime.CompilerServices;

namespace System.Runtime.Intrinsics.Arm
{
	// Token: 0x0200055F RID: 1375
	[CLSCompliant(false)]
	public abstract class Sha1 : ArmBase
	{
		// Token: 0x17000D6E RID: 3438
		// (get) Token: 0x06005D07 RID: 23815 RVA: 0x00007B65 File Offset: 0x00005D65
		public new static bool IsSupported
		{
			[Intrinsic]
			get
			{
				return false;
			}
		}

		// Token: 0x06005D08 RID: 23816 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<uint> FixedRotate(Vector64<uint> hash_e)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D09 RID: 23817 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> HashUpdateChoose(Vector128<uint> hash_abcd, Vector64<uint> hash_e, Vector128<uint> wk)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D0A RID: 23818 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> HashUpdateMajority(Vector128<uint> hash_abcd, Vector64<uint> hash_e, Vector128<uint> wk)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D0B RID: 23819 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> HashUpdateParity(Vector128<uint> hash_abcd, Vector64<uint> hash_e, Vector128<uint> wk)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D0C RID: 23820 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> ScheduleUpdate0(Vector128<uint> w0_3, Vector128<uint> w4_7, Vector128<uint> w8_11)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D0D RID: 23821 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> ScheduleUpdate1(Vector128<uint> tw0_3, Vector128<uint> w12_15)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x02000560 RID: 1376
		public new abstract class Arm64 : ArmBase.Arm64
		{
			// Token: 0x17000D6F RID: 3439
			// (get) Token: 0x06005D0E RID: 23822 RVA: 0x00007B65 File Offset: 0x00005D65
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
