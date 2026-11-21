using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Platform.PlatformSdk
{
	// Token: 0x02000131 RID: 305
	[NullableContext(1)]
	[Nullable(0)]
	public class IPlatformData
	{
		// Token: 0x040005D2 RID: 1490
		public string projectId;

		// Token: 0x040005D3 RID: 1491
		public string channelId;

		// Token: 0x040005D4 RID: 1492
		public string platform;

		// Token: 0x040005D5 RID: 1493
		public string version;

		// Token: 0x040005D6 RID: 1494
		public string sdkVersion;

		// Token: 0x040005D7 RID: 1495
		public string sdkServerVersion;

		// Token: 0x040005D8 RID: 1496
		public IPlatformReleaseData Development;

		// Token: 0x040005D9 RID: 1497
		public IPlatformReleaseData PreRelease;

		// Token: 0x040005DA RID: 1498
		public IPlatformReleaseData Release;
	}
}
