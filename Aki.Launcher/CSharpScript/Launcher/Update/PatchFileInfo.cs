using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Update
{
	// Token: 0x02000098 RID: 152
	[NullableContext(1)]
	[Nullable(0)]
	public class PatchFileInfo
	{
		// Token: 0x04000359 RID: 857
		public string Name = "";

		// Token: 0x0400035A RID: 858
		public string FileUrl = "";

		// Token: 0x0400035B RID: 859
		public string SavePath = "";

		// Token: 0x0400035C RID: 860
		public bool NeedRestart;

		// Token: 0x0400035D RID: 861
		public int MountType;

		// Token: 0x0400035E RID: 862
		public long? PakSize;

		// Token: 0x0400035F RID: 863
		public string PakSha1 = "";

		// Token: 0x04000360 RID: 864
		public int MountOrder;

		// Token: 0x04000361 RID: 865
		public long? UtocSize;

		// Token: 0x04000362 RID: 866
		public string UtocSha1 = "";

		// Token: 0x04000363 RID: 867
		public long? UcasSize;

		// Token: 0x04000364 RID: 868
		public string UcasSha1 = "";

		// Token: 0x04000365 RID: 869
		public long? SigSize;

		// Token: 0x04000366 RID: 870
		public string SigSha1 = "";
	}
}
