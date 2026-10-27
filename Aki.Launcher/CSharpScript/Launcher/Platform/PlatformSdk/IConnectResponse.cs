using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Platform.PlatformSdk
{
	// Token: 0x0200016F RID: 367
	[NullableContext(1)]
	[Nullable(0)]
	public class IConnectResponse
	{
		// Token: 0x04000655 RID: 1621
		public IConnectResponseData data;

		// Token: 0x04000656 RID: 1622
		public int code;

		// Token: 0x04000657 RID: 1623
		public string msg;

		// Token: 0x04000658 RID: 1624
		public long timestamp;
	}
}
