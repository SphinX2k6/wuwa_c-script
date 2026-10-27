using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Platform.PlatformSdk
{
	// Token: 0x0200017F RID: 383
	[NullableContext(1)]
	[Nullable(0)]
	public class IGetAccessTokenResponse
	{
		// Token: 0x040006AA RID: 1706
		public IGetAccessTokenResponseData data;

		// Token: 0x040006AB RID: 1707
		public int code;

		// Token: 0x040006AC RID: 1708
		public string msg;

		// Token: 0x040006AD RID: 1709
		public long timestamp;
	}
}
