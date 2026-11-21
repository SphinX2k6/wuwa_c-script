using System;

namespace System.IO
{
	// Token: 0x020007F2 RID: 2034
	[Flags]
	public enum FileAttributes
	{
		// Token: 0x04001B7F RID: 7039
		None = 0,
		// Token: 0x04001B80 RID: 7040
		ReadOnly = 1,
		// Token: 0x04001B81 RID: 7041
		Hidden = 2,
		// Token: 0x04001B82 RID: 7042
		System = 4,
		// Token: 0x04001B83 RID: 7043
		Directory = 16,
		// Token: 0x04001B84 RID: 7044
		Archive = 32,
		// Token: 0x04001B85 RID: 7045
		Device = 64,
		// Token: 0x04001B86 RID: 7046
		Normal = 128,
		// Token: 0x04001B87 RID: 7047
		Temporary = 256,
		// Token: 0x04001B88 RID: 7048
		SparseFile = 512,
		// Token: 0x04001B89 RID: 7049
		ReparsePoint = 1024,
		// Token: 0x04001B8A RID: 7050
		Compressed = 2048,
		// Token: 0x04001B8B RID: 7051
		Offline = 4096,
		// Token: 0x04001B8C RID: 7052
		NotContentIndexed = 8192,
		// Token: 0x04001B8D RID: 7053
		Encrypted = 16384,
		// Token: 0x04001B8E RID: 7054
		IntegrityStream = 32768,
		// Token: 0x04001B8F RID: 7055
		NoScrubData = 131072
	}
}
