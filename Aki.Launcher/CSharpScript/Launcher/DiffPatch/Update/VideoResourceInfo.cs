using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.DiffPatch.Update
{
	// Token: 0x0200020B RID: 523
	[NullableContext(1)]
	[Nullable(0)]
	public class VideoResourceInfo
	{
		// Token: 0x06000D79 RID: 3449 RVA: 0x00051B64 File Offset: 0x0004FD64
		public VideoResourceInfo(string RemoteRoute, string LocalPath, string PakFileName, long PakSize, string PakHash, string SigFileName, long SigSize, string SigHash)
		{
		}

		// Token: 0x04000873 RID: 2163
		public readonly string RemoteRoute = RemoteRoute;

		// Token: 0x04000874 RID: 2164
		public readonly string LocalPath = LocalPath;

		// Token: 0x04000875 RID: 2165
		public readonly string PakFileName = PakFileName;

		// Token: 0x04000876 RID: 2166
		public readonly long PakSize = PakSize;

		// Token: 0x04000877 RID: 2167
		public readonly string PakHash = PakHash;

		// Token: 0x04000878 RID: 2168
		public readonly string SigFileName = SigFileName;

		// Token: 0x04000879 RID: 2169
		public readonly long SigSize = SigSize;

		// Token: 0x0400087A RID: 2170
		public readonly string SigHash = SigHash;
	}
}
