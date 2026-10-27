using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Download
{
	// Token: 0x020001F7 RID: 503
	public class UrlPrefixInfo
	{
		// Token: 0x04000811 RID: 2065
		[Nullable(1)]
		public string Address = "";

		// Token: 0x04000812 RID: 2066
		public int Price;

		// Token: 0x04000813 RID: 2067
		public int OriginOrder;

		// Token: 0x04000814 RID: 2068
		public int EvalPoint;

		// Token: 0x04000815 RID: 2069
		public bool IsEvaluated;

		// Token: 0x04000816 RID: 2070
		public float RemainDownloadTime;

		// Token: 0x04000817 RID: 2071
		public long DownloadedSize;

		// Token: 0x04000818 RID: 2072
		public int Speed;
	}
}
