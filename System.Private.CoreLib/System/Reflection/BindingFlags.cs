using System;

namespace System.Reflection
{
	// Token: 0x02000735 RID: 1845
	[Flags]
	public enum BindingFlags
	{
		// Token: 0x04001605 RID: 5637
		Default = 0,
		// Token: 0x04001606 RID: 5638
		IgnoreCase = 1,
		// Token: 0x04001607 RID: 5639
		DeclaredOnly = 2,
		// Token: 0x04001608 RID: 5640
		Instance = 4,
		// Token: 0x04001609 RID: 5641
		Static = 8,
		// Token: 0x0400160A RID: 5642
		Public = 16,
		// Token: 0x0400160B RID: 5643
		NonPublic = 32,
		// Token: 0x0400160C RID: 5644
		FlattenHierarchy = 64,
		// Token: 0x0400160D RID: 5645
		InvokeMethod = 256,
		// Token: 0x0400160E RID: 5646
		CreateInstance = 512,
		// Token: 0x0400160F RID: 5647
		GetField = 1024,
		// Token: 0x04001610 RID: 5648
		SetField = 2048,
		// Token: 0x04001611 RID: 5649
		GetProperty = 4096,
		// Token: 0x04001612 RID: 5650
		SetProperty = 8192,
		// Token: 0x04001613 RID: 5651
		PutDispProperty = 16384,
		// Token: 0x04001614 RID: 5652
		PutRefDispProperty = 32768,
		// Token: 0x04001615 RID: 5653
		ExactBinding = 65536,
		// Token: 0x04001616 RID: 5654
		SuppressChangeType = 131072,
		// Token: 0x04001617 RID: 5655
		OptionalParamBinding = 262144,
		// Token: 0x04001618 RID: 5656
		IgnoreReturn = 16777216,
		// Token: 0x04001619 RID: 5657
		DoNotWrapExceptions = 33554432
	}
}
