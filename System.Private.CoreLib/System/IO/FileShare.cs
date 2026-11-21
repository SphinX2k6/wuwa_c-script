using System;

namespace System.IO
{
	// Token: 0x020007F7 RID: 2039
	[Flags]
	public enum FileShare
	{
		// Token: 0x04001BA2 RID: 7074
		None = 0,
		// Token: 0x04001BA3 RID: 7075
		Read = 1,
		// Token: 0x04001BA4 RID: 7076
		Write = 2,
		// Token: 0x04001BA5 RID: 7077
		ReadWrite = 3,
		// Token: 0x04001BA6 RID: 7078
		Delete = 4,
		// Token: 0x04001BA7 RID: 7079
		Inheritable = 16
	}
}
