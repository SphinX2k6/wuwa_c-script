using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.NetworkDetection
{
	// Token: 0x020001AB RID: 427
	public class IPingResult
	{
		// Token: 0x04000761 RID: 1889
		[Nullable(1)]
		public string IpAddress = "";

		// Token: 0x04000762 RID: 1890
		public float Time;

		// Token: 0x04000763 RID: 1891
		public int ResponseState;
	}
}
