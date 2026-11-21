using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.NetworkDetection
{
	// Token: 0x020001AF RID: 431
	public class IPingResult
	{
		// Token: 0x0400079E RID: 1950
		[Nullable(1)]
		public string IpAddress = "";

		// Token: 0x0400079F RID: 1951
		public float Time;

		// Token: 0x040007A0 RID: 1952
		public int ResponseState;
	}
}
