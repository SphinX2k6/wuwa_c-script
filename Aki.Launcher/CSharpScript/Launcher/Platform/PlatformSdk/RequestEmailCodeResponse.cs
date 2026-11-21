using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Platform.PlatformSdk
{
	// Token: 0x02000140 RID: 320
	public class RequestEmailCodeResponse
	{
		// Token: 0x04000616 RID: 1558
		public bool IfSuccess;

		// Token: 0x04000617 RID: 1559
		public int Code;

		// Token: 0x04000618 RID: 1560
		[Nullable(1)]
		public string Msg = "";
	}
}
