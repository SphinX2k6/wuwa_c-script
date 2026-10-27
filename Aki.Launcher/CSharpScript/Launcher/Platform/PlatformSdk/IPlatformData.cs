using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Platform.PlatformSdk
{
	// Token: 0x0200012D RID: 301
	[NullableContext(1)]
	[Nullable(0)]
	public class IPlatformData
	{
		// Token: 0x04000597 RID: 1431
		public string projectId;

		// Token: 0x04000598 RID: 1432
		public string channelId;

		// Token: 0x04000599 RID: 1433
		public string platform;

		// Token: 0x0400059A RID: 1434
		public string version;

		// Token: 0x0400059B RID: 1435
		public string sdkVersion;

		// Token: 0x0400059C RID: 1436
		public string sdkServerVersion;

		// Token: 0x0400059D RID: 1437
		public IPlatformReleaseData Development;

		// Token: 0x0400059E RID: 1438
		public IPlatformReleaseData PreRelease;

		// Token: 0x0400059F RID: 1439
		public IPlatformReleaseData Release;
	}
}
