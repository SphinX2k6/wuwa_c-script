using System;

namespace System.Runtime.Intrinsics.Arm
{
	// Token: 0x02000552 RID: 1362
	public enum SvePrefetchType : byte
	{
		// Token: 0x040011DE RID: 4574
		LoadL1Temporal,
		// Token: 0x040011DF RID: 4575
		LoadL1NonTemporal,
		// Token: 0x040011E0 RID: 4576
		LoadL2Temporal,
		// Token: 0x040011E1 RID: 4577
		LoadL2NonTemporal,
		// Token: 0x040011E2 RID: 4578
		LoadL3Temporal,
		// Token: 0x040011E3 RID: 4579
		LoadL3NonTemporal,
		// Token: 0x040011E4 RID: 4580
		StoreL1Temporal = 8,
		// Token: 0x040011E5 RID: 4581
		StoreL1NonTemporal,
		// Token: 0x040011E6 RID: 4582
		StoreL2Temporal,
		// Token: 0x040011E7 RID: 4583
		StoreL2NonTemporal,
		// Token: 0x040011E8 RID: 4584
		StoreL3Temporal,
		// Token: 0x040011E9 RID: 4585
		StoreL3NonTemporal
	}
}
