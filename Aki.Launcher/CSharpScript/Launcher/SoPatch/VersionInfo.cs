using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.SoPatch
{
	// Token: 0x02000102 RID: 258
	[NullableContext(2)]
	[Nullable(0)]
	public class VersionInfo
	{
		// Token: 0x040004C8 RID: 1224
		public int VerNum;

		// Token: 0x040004C9 RID: 1225
		public bool IsPublished;

		// Token: 0x040004CA RID: 1226
		[Nullable(1)]
		public List<MobileFilter> Filters = new List<MobileFilter>();

		// Token: 0x040004CB RID: 1227
		public GrayInfo Gray;

		// Token: 0x040004CC RID: 1228
		public SoPatchFileInfo PatchInfo;
	}
}
