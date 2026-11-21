using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Download
{
	// Token: 0x020001FE RID: 510
	[NullableContext(1)]
	[Nullable(0)]
	public class RequestFileInfo
	{
		// Token: 0x04000864 RID: 2148
		public string FileName = "";

		// Token: 0x04000865 RID: 2149
		public string Url = "";

		// Token: 0x04000866 RID: 2150
		public string SavePath = "";

		// Token: 0x04000867 RID: 2151
		public long? Size;

		// Token: 0x04000868 RID: 2152
		public string HashString = "";

		// Token: 0x04000869 RID: 2153
		public bool bUseDownloadCache;
	}
}
