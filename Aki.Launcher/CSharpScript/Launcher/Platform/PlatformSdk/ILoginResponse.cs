using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Platform.PlatformSdk
{
	// Token: 0x0200017D RID: 381
	[NullableContext(1)]
	[Nullable(0)]
	public class ILoginResponse
	{
		// Token: 0x0400069B RID: 1691
		public ILoginResponseData data;

		// Token: 0x0400069C RID: 1692
		public int code;

		// Token: 0x0400069D RID: 1693
		public string msg;

		// Token: 0x0400069E RID: 1694
		public long timestamp;
	}
}
