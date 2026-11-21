using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Platform.PlatformSdk
{
	// Token: 0x02000185 RID: 389
	[NullableContext(1)]
	[Nullable(0)]
	public class IRenewAccessTokenResponse
	{
		// Token: 0x040006EB RID: 1771
		public IRenewAccessTokenResponseData data;

		// Token: 0x040006EC RID: 1772
		public int code;

		// Token: 0x040006ED RID: 1773
		public string msg;

		// Token: 0x040006EE RID: 1774
		public long timestamp;
	}
}
