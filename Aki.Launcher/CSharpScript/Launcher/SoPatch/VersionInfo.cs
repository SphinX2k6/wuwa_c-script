using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.SoPatch
{
	// Token: 0x02000106 RID: 262
	[NullableContext(2)]
	[Nullable(0)]
	public class VersionInfo
	{
		// Token: 0x04000503 RID: 1283
		public int VerNum;

		// Token: 0x04000504 RID: 1284
		public bool IsPublished;

		// Token: 0x04000505 RID: 1285
		[Nullable(1)]
		public List<MobileFilter> Filters = new List<MobileFilter>();

		// Token: 0x04000506 RID: 1286
		public GrayInfo Gray;

		// Token: 0x04000507 RID: 1287
		public SoPatchFileInfo PatchInfo;
	}
}
