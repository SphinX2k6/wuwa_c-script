using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Platform.PlatformSdk
{
	// Token: 0x02000181 RID: 385
	[NullableContext(1)]
	[Nullable(0)]
	public class IRenewAccessTokenResponse
	{
		// Token: 0x040006B0 RID: 1712
		public IRenewAccessTokenResponseData data;

		// Token: 0x040006B1 RID: 1713
		public int code;

		// Token: 0x040006B2 RID: 1714
		public string msg;

		// Token: 0x040006B3 RID: 1715
		public long timestamp;
	}
}
