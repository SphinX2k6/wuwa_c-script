using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Platform.PlatformSdk
{
	// Token: 0x02000181 RID: 385
	[NullableContext(1)]
	[Nullable(0)]
	public class ILoginResponse
	{
		// Token: 0x040006D6 RID: 1750
		public ILoginResponseData data;

		// Token: 0x040006D7 RID: 1751
		public int code;

		// Token: 0x040006D8 RID: 1752
		public string msg;

		// Token: 0x040006D9 RID: 1753
		public long timestamp;
	}
}
