using System;
using CSharpScript.Core.Common;

namespace CSharpScript.Launcher.Download
{
	// Token: 0x020001F5 RID: 501
	[EnumExtensions]
	public enum EDownloadState
	{
		// Token: 0x04000808 RID: 2056
		None,
		// Token: 0x04000809 RID: 2057
		HttpError,
		// Token: 0x0400080A RID: 2058
		FileRenameError,
		// Token: 0x0400080B RID: 2059
		ValidateError,
		// Token: 0x0400080C RID: 2060
		OpenToWriteError,
		// Token: 0x0400080D RID: 2061
		NotEnoughSpace,
		// Token: 0x0400080E RID: 2062
		DownloadCanceled,
		// Token: 0x0400080F RID: 2063
		Success,
		// Token: 0x04000810 RID: 2064
		ChangeToCell
	}
}
