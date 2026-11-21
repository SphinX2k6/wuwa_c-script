using System;

namespace System.IO
{
	// Token: 0x020007F6 RID: 2038
	[Flags]
	public enum FileOptions
	{
		// Token: 0x04001B9A RID: 7066
		None = 0,
		// Token: 0x04001B9B RID: 7067
		WriteThrough = -2147483648,
		// Token: 0x04001B9C RID: 7068
		Asynchronous = 1073741824,
		// Token: 0x04001B9D RID: 7069
		RandomAccess = 268435456,
		// Token: 0x04001B9E RID: 7070
		DeleteOnClose = 67108864,
		// Token: 0x04001B9F RID: 7071
		SequentialScan = 134217728,
		// Token: 0x04001BA0 RID: 7072
		Encrypted = 16384
	}
}
