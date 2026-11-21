using System;

namespace CSharpScript.Launcher.Download
{
	// Token: 0x020001FF RID: 511
	public class IPrefixDownloadResult
	{
		// Token: 0x0400086A RID: 2154
		public bool Complete;

		// Token: 0x0400086B RID: 2155
		public float RemainedTime;

		// Token: 0x0400086C RID: 2156
		public float SpendTime;

		// Token: 0x0400086D RID: 2157
		public long DownloadedSize;

		// Token: 0x0400086E RID: 2158
		public long CurrentFileSavedSize;

		// Token: 0x0400086F RID: 2159
		public int? FileIndex;

		// Token: 0x04000870 RID: 2160
		public EDownloadState DownloadState;

		// Token: 0x04000871 RID: 2161
		public int HttpCode;
	}
}
