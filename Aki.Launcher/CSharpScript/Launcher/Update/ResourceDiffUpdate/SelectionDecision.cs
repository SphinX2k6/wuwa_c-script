using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Update.ResourceDiffUpdate
{
	// Token: 0x020000A2 RID: 162
	[NullableContext(1)]
	[Nullable(0)]
	public class SelectionDecision
	{
		// Token: 0x04000372 RID: 882
		public long MinSize;

		// Token: 0x04000373 RID: 883
		public long MaxSize;

		// Token: 0x04000374 RID: 884
		public List<ResPackageInfo> MinPacks = new List<ResPackageInfo>();

		// Token: 0x04000375 RID: 885
		public List<ResPackageInfo> MaxPacks = new List<ResPackageInfo>();
	}
}
