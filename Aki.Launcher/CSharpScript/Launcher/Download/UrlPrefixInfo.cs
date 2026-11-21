using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Download
{
	// Token: 0x020001FC RID: 508
	public class UrlPrefixInfo
	{
		// Token: 0x04000851 RID: 2129
		[Nullable(1)]
		public string Address = "";

		// Token: 0x04000852 RID: 2130
		public int Price;

		// Token: 0x04000853 RID: 2131
		public int OriginOrder;

		// Token: 0x04000854 RID: 2132
		public int EvalPoint;

		// Token: 0x04000855 RID: 2133
		public bool IsEvaluated;

		// Token: 0x04000856 RID: 2134
		public float RemainDownloadTime;

		// Token: 0x04000857 RID: 2135
		public long DownloadedSize;

		// Token: 0x04000858 RID: 2136
		public int Speed;
	}
}
