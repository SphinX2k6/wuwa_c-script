using System;

namespace System.Reflection
{
	// Token: 0x02000759 RID: 1881
	public enum MethodImplAttributes
	{
		// Token: 0x040016B6 RID: 5814
		CodeTypeMask = 3,
		// Token: 0x040016B7 RID: 5815
		IL = 0,
		// Token: 0x040016B8 RID: 5816
		Native,
		// Token: 0x040016B9 RID: 5817
		OPTIL,
		// Token: 0x040016BA RID: 5818
		Runtime,
		// Token: 0x040016BB RID: 5819
		ManagedMask,
		// Token: 0x040016BC RID: 5820
		Unmanaged = 4,
		// Token: 0x040016BD RID: 5821
		Managed = 0,
		// Token: 0x040016BE RID: 5822
		ForwardRef = 16,
		// Token: 0x040016BF RID: 5823
		PreserveSig = 128,
		// Token: 0x040016C0 RID: 5824
		InternalCall = 4096,
		// Token: 0x040016C1 RID: 5825
		Synchronized = 32,
		// Token: 0x040016C2 RID: 5826
		NoInlining = 8,
		// Token: 0x040016C3 RID: 5827
		AggressiveInlining = 256,
		// Token: 0x040016C4 RID: 5828
		NoOptimization = 64,
		// Token: 0x040016C5 RID: 5829
		AggressiveOptimization = 512,
		// Token: 0x040016C6 RID: 5830
		MaxMethodImplVal = 65535
	}
}
