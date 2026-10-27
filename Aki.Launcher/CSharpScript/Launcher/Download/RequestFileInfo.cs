using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Download
{
	// Token: 0x020001F9 RID: 505
	[NullableContext(1)]
	[Nullable(0)]
	public class RequestFileInfo
	{
		// Token: 0x04000824 RID: 2084
		public string FileName = "";

		// Token: 0x04000825 RID: 2085
		public string Url = "";

		// Token: 0x04000826 RID: 2086
		public string SavePath = "";

		// Token: 0x04000827 RID: 2087
		public long? Size;

		// Token: 0x04000828 RID: 2088
		public string HashString = "";

		// Token: 0x04000829 RID: 2089
		public bool bUseDownloadCache;
	}
}
