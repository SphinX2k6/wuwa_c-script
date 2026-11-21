using System;

namespace System.Reflection
{
	// Token: 0x02000757 RID: 1879
	[Flags]
	public enum MethodAttributes
	{
		// Token: 0x0400169D RID: 5789
		MemberAccessMask = 7,
		// Token: 0x0400169E RID: 5790
		PrivateScope = 0,
		// Token: 0x0400169F RID: 5791
		Private = 1,
		// Token: 0x040016A0 RID: 5792
		FamANDAssem = 2,
		// Token: 0x040016A1 RID: 5793
		Assembly = 3,
		// Token: 0x040016A2 RID: 5794
		Family = 4,
		// Token: 0x040016A3 RID: 5795
		FamORAssem = 5,
		// Token: 0x040016A4 RID: 5796
		Public = 6,
		// Token: 0x040016A5 RID: 5797
		Static = 16,
		// Token: 0x040016A6 RID: 5798
		Final = 32,
		// Token: 0x040016A7 RID: 5799
		Virtual = 64,
		// Token: 0x040016A8 RID: 5800
		HideBySig = 128,
		// Token: 0x040016A9 RID: 5801
		CheckAccessOnOverride = 512,
		// Token: 0x040016AA RID: 5802
		VtableLayoutMask = 256,
		// Token: 0x040016AB RID: 5803
		ReuseSlot = 0,
		// Token: 0x040016AC RID: 5804
		NewSlot = 256,
		// Token: 0x040016AD RID: 5805
		Abstract = 1024,
		// Token: 0x040016AE RID: 5806
		SpecialName = 2048,
		// Token: 0x040016AF RID: 5807
		PinvokeImpl = 8192,
		// Token: 0x040016B0 RID: 5808
		UnmanagedExport = 8,
		// Token: 0x040016B1 RID: 5809
		RTSpecialName = 4096,
		// Token: 0x040016B2 RID: 5810
		HasSecurity = 16384,
		// Token: 0x040016B3 RID: 5811
		RequireSecObject = 32768,
		// Token: 0x040016B4 RID: 5812
		ReservedMask = 53248
	}
}
