using System;

namespace CSharpScript.Launcher.Download
{
	// Token: 0x020001FB RID: 507
	public class IEvaluateResult
	{
		// Token: 0x04000832 RID: 2098
		public bool Complete;

		// Token: 0x04000833 RID: 2099
		public int FileIndex;

		// Token: 0x04000834 RID: 2100
		public long CurrentFileSavedSize;

		// Token: 0x04000835 RID: 2101
		public EDownloadState DownloadState;

		// Token: 0x04000836 RID: 2102
		public int HttpCode;

		// Token: 0x04000837 RID: 2103
		public bool Skipped;
	}
}
