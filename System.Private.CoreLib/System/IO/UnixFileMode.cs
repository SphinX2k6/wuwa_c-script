using System;

namespace System.IO
{
	// Token: 0x0200084B RID: 2123
	[Flags]
	public enum UnixFileMode
	{
		// Token: 0x04001D56 RID: 7510
		None = 0,
		// Token: 0x04001D57 RID: 7511
		OtherExecute = 1,
		// Token: 0x04001D58 RID: 7512
		OtherWrite = 2,
		// Token: 0x04001D59 RID: 7513
		OtherRead = 4,
		// Token: 0x04001D5A RID: 7514
		GroupExecute = 8,
		// Token: 0x04001D5B RID: 7515
		GroupWrite = 16,
		// Token: 0x04001D5C RID: 7516
		GroupRead = 32,
		// Token: 0x04001D5D RID: 7517
		UserExecute = 64,
		// Token: 0x04001D5E RID: 7518
		UserWrite = 128,
		// Token: 0x04001D5F RID: 7519
		UserRead = 256,
		// Token: 0x04001D60 RID: 7520
		StickyBit = 512,
		// Token: 0x04001D61 RID: 7521
		SetGroup = 1024,
		// Token: 0x04001D62 RID: 7522
		SetUser = 2048
	}
}
