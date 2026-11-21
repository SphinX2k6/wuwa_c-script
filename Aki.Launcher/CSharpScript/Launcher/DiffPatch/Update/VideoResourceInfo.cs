using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.DiffPatch.Update
{
	// Token: 0x02000210 RID: 528
	[NullableContext(1)]
	[Nullable(0)]
	public class VideoResourceInfo
	{
		// Token: 0x06000DBA RID: 3514 RVA: 0x00054658 File Offset: 0x00052858
		public VideoResourceInfo(string RemoteRoute, string LocalPath, string PakFileName, long PakSize, string PakHash, string SigFileName, long SigSize, string SigHash)
		{
		}

		// Token: 0x040008B4 RID: 2228
		public readonly string RemoteRoute = RemoteRoute;

		// Token: 0x040008B5 RID: 2229
		public readonly string LocalPath = LocalPath;

		// Token: 0x040008B6 RID: 2230
		public readonly string PakFileName = PakFileName;

		// Token: 0x040008B7 RID: 2231
		public readonly long PakSize = PakSize;

		// Token: 0x040008B8 RID: 2232
		public readonly string PakHash = PakHash;

		// Token: 0x040008B9 RID: 2233
		public readonly string SigFileName = SigFileName;

		// Token: 0x040008BA RID: 2234
		public readonly long SigSize = SigSize;

		// Token: 0x040008BB RID: 2235
		public readonly string SigHash = SigHash;
	}
}
