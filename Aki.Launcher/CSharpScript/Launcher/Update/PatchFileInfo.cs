using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Update
{
	// Token: 0x02000095 RID: 149
	[NullableContext(1)]
	[Nullable(0)]
	public class PatchFileInfo
	{
		// Token: 0x0400032B RID: 811
		public string Name = "";

		// Token: 0x0400032C RID: 812
		public string FileUrl = "";

		// Token: 0x0400032D RID: 813
		public string SavePath = "";

		// Token: 0x0400032E RID: 814
		public bool NeedRestart;

		// Token: 0x0400032F RID: 815
		public int MountType;

		// Token: 0x04000330 RID: 816
		public long? PakSize;

		// Token: 0x04000331 RID: 817
		public string PakSha1 = "";

		// Token: 0x04000332 RID: 818
		public int MountOrder;

		// Token: 0x04000333 RID: 819
		public long? UtocSize;

		// Token: 0x04000334 RID: 820
		public string UtocSha1 = "";

		// Token: 0x04000335 RID: 821
		public long? UcasSize;

		// Token: 0x04000336 RID: 822
		public string UcasSha1 = "";

		// Token: 0x04000337 RID: 823
		public long? SigSize;

		// Token: 0x04000338 RID: 824
		public string SigSha1 = "";
	}
}
