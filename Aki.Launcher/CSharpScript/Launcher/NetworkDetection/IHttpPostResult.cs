using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.NetworkDetection
{
	// Token: 0x020001B0 RID: 432
	public class IHttpPostResult
	{
		// Token: 0x040007A1 RID: 1953
		public bool Success;

		// Token: 0x040007A2 RID: 1954
		public int Code;

		// Token: 0x040007A3 RID: 1955
		[Nullable(1)]
		public string Data = "";
	}
}
