using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Platform.PlatformSdk
{
	// Token: 0x0200013C RID: 316
	public class RequestEmailCodeResponse
	{
		// Token: 0x040005DB RID: 1499
		public bool IfSuccess;

		// Token: 0x040005DC RID: 1500
		public int Code;

		// Token: 0x040005DD RID: 1501
		[Nullable(1)]
		public string Msg = "";
	}
}
