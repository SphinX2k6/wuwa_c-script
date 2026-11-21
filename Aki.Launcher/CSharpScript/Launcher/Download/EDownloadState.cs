using System;
using CSharpScript.Core.Common;

namespace CSharpScript.Launcher.Download
{
	// Token: 0x020001FA RID: 506
	[EnumExtensions]
	public enum EDownloadState
	{
		// Token: 0x04000848 RID: 2120
		None,
		// Token: 0x04000849 RID: 2121
		HttpError,
		// Token: 0x0400084A RID: 2122
		FileRenameError,
		// Token: 0x0400084B RID: 2123
		ValidateError,
		// Token: 0x0400084C RID: 2124
		OpenToWriteError,
		// Token: 0x0400084D RID: 2125
		NotEnoughSpace,
		// Token: 0x0400084E RID: 2126
		DownloadCanceled,
		// Token: 0x0400084F RID: 2127
		Success,
		// Token: 0x04000850 RID: 2128
		ChangeToCell
	}
}
