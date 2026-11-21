using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Platform.PlatformSdk
{
	// Token: 0x02000183 RID: 387
	[NullableContext(1)]
	[Nullable(0)]
	public class IGetAccessTokenResponse
	{
		// Token: 0x040006E5 RID: 1765
		public IGetAccessTokenResponseData data;

		// Token: 0x040006E6 RID: 1766
		public int code;

		// Token: 0x040006E7 RID: 1767
		public string msg;

		// Token: 0x040006E8 RID: 1768
		public long timestamp;
	}
}
