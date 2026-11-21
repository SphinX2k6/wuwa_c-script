using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Update.ResourceDiffUpdate
{
	// Token: 0x020000A5 RID: 165
	[NullableContext(1)]
	[Nullable(0)]
	public class SelectionDecision
	{
		// Token: 0x040003A0 RID: 928
		public long MinSize;

		// Token: 0x040003A1 RID: 929
		public long MaxSize;

		// Token: 0x040003A2 RID: 930
		public List<ResPackageInfo> MinPacks = new List<ResPackageInfo>();

		// Token: 0x040003A3 RID: 931
		public List<ResPackageInfo> MaxPacks = new List<ResPackageInfo>();
	}
}
