using System;

namespace System.Runtime.InteropServices.Marshalling
{
	// Token: 0x0200061A RID: 1562
	public enum MarshalMode
	{
		// Token: 0x04001378 RID: 4984
		Default,
		// Token: 0x04001379 RID: 4985
		ManagedToUnmanagedIn,
		// Token: 0x0400137A RID: 4986
		ManagedToUnmanagedRef,
		// Token: 0x0400137B RID: 4987
		ManagedToUnmanagedOut,
		// Token: 0x0400137C RID: 4988
		UnmanagedToManagedIn,
		// Token: 0x0400137D RID: 4989
		UnmanagedToManagedRef,
		// Token: 0x0400137E RID: 4990
		UnmanagedToManagedOut,
		// Token: 0x0400137F RID: 4991
		ElementIn,
		// Token: 0x04001380 RID: 4992
		ElementRef,
		// Token: 0x04001381 RID: 4993
		ElementOut
	}
}
