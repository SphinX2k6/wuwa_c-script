using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.DiffPatch.Data
{
	// Token: 0x02000227 RID: 551
	[NullableContext(1)]
	[Nullable(0)]
	public class RequireFileInfo
	{
		// Token: 0x06000E12 RID: 3602 RVA: 0x00054D79 File Offset: 0x00052F79
		public RequireFileInfo(string remoteRoute, string localPath, long size, string hash)
		{
			this.RemoteRoute = remoteRoute;
			this.LocalPath = localPath;
			this.Size = size;
			this.Hash = hash;
		}

		// Token: 0x040008DC RID: 2268
		public readonly string RemoteRoute;

		// Token: 0x040008DD RID: 2269
		public readonly string LocalPath;

		// Token: 0x040008DE RID: 2270
		public readonly long Size;

		// Token: 0x040008DF RID: 2271
		public readonly string Hash;
	}
}
