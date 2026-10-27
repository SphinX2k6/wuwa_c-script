using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.NetworkDetection
{
	// Token: 0x020001AC RID: 428
	public class IHttpPostResult
	{
		// Token: 0x04000764 RID: 1892
		public bool Success;

		// Token: 0x04000765 RID: 1893
		public int Code;

		// Token: 0x04000766 RID: 1894
		[Nullable(1)]
		public string Data = "";
	}
}
