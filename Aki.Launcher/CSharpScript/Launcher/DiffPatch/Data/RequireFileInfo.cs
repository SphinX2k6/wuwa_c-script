using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.DiffPatch.Data
{
	// Token: 0x0200022C RID: 556
	[NullableContext(1)]
	[Nullable(0)]
	public class RequireFileInfo
	{
		// Token: 0x06000E53 RID: 3667 RVA: 0x00057883 File Offset: 0x00055A83
		public RequireFileInfo(string remoteRoute, string localPath, long size, string hash)
		{
			this.RemoteRoute = remoteRoute;
			this.LocalPath = localPath;
			this.Size = size;
			this.Hash = hash;
		}

		// Token: 0x0400091E RID: 2334
		public readonly string RemoteRoute;

		// Token: 0x0400091F RID: 2335
		public readonly string LocalPath;

		// Token: 0x04000920 RID: 2336
		public readonly long Size;

		// Token: 0x04000921 RID: 2337
		public readonly string Hash;
	}
}
