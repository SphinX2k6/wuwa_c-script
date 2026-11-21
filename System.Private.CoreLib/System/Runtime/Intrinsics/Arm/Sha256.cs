using System;
using System.Runtime.CompilerServices;

namespace System.Runtime.Intrinsics.Arm
{
	// Token: 0x02000561 RID: 1377
	[CLSCompliant(false)]
	public abstract class Sha256 : ArmBase
	{
		// Token: 0x17000D70 RID: 3440
		// (get) Token: 0x06005D0F RID: 23823 RVA: 0x00007B65 File Offset: 0x00005D65
		public new static bool IsSupported
		{
			[Intrinsic]
			get
			{
				return false;
			}
		}

		// Token: 0x06005D10 RID: 23824 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> HashUpdate1(Vector128<uint> hash_abcd, Vector128<uint> hash_efgh, Vector128<uint> wk)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D11 RID: 23825 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> HashUpdate2(Vector128<uint> hash_efgh, Vector128<uint> hash_abcd, Vector128<uint> wk)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D12 RID: 23826 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> ScheduleUpdate0(Vector128<uint> w0_3, Vector128<uint> w4_7)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D13 RID: 23827 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> ScheduleUpdate1(Vector128<uint> w0_3, Vector128<uint> w8_11, Vector128<uint> w12_15)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x02000562 RID: 1378
		public new abstract class Arm64 : ArmBase.Arm64
		{
			// Token: 0x17000D71 RID: 3441
			// (get) Token: 0x06005D14 RID: 23828 RVA: 0x00007B65 File Offset: 0x00005D65
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
