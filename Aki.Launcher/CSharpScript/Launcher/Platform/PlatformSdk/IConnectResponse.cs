using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Platform.PlatformSdk
{
	// Token: 0x02000173 RID: 371
	[NullableContext(1)]
	[Nullable(0)]
	public class IConnectResponse
	{
		// Token: 0x04000690 RID: 1680
		public IConnectResponseData data;

		// Token: 0x04000691 RID: 1681
		public int code;

		// Token: 0x04000692 RID: 1682
		public string msg;

		// Token: 0x04000693 RID: 1683
		public long timestamp;
	}
}
