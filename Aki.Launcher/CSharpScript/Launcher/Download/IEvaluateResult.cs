using System;

namespace CSharpScript.Launcher.Download
{
	// Token: 0x02000200 RID: 512
	public class IEvaluateResult
	{
		// Token: 0x04000872 RID: 2162
		public bool Complete;

		// Token: 0x04000873 RID: 2163
		public int FileIndex;

		// Token: 0x04000874 RID: 2164
		public long CurrentFileSavedSize;

		// Token: 0x04000875 RID: 2165
		public EDownloadState DownloadState;

		// Token: 0x04000876 RID: 2166
		public int HttpCode;

		// Token: 0x04000877 RID: 2167
		public bool Skipped;
	}
}
