using System;

namespace CSharpScript.Launcher.Download
{
	// Token: 0x020001FA RID: 506
	public class IPrefixDownloadResult
	{
		// Token: 0x0400082A RID: 2090
		public bool Complete;

		// Token: 0x0400082B RID: 2091
		public float RemainedTime;

		// Token: 0x0400082C RID: 2092
		public float SpendTime;

		// Token: 0x0400082D RID: 2093
		public long DownloadedSize;

		// Token: 0x0400082E RID: 2094
		public long CurrentFileSavedSize;

		// Token: 0x0400082F RID: 2095
		public int? FileIndex;

		// Token: 0x04000830 RID: 2096
		public EDownloadState DownloadState;

		// Token: 0x04000831 RID: 2097
		public int HttpCode;
	}
}
