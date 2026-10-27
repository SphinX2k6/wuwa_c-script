using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Update.ResourceDiffUpdate
{
	// Token: 0x0200009E RID: 158
	[NullableContext(1)]
	[Nullable(0)]
	public class PackClassification
	{
		// Token: 0x04000365 RID: 869
		public List<ResPackageInfo> MinPacks = new List<ResPackageInfo>();

		// Token: 0x04000366 RID: 870
		public List<ResPackageInfo> MaxPacks = new List<ResPackageInfo>();

		// Token: 0x04000367 RID: 871
		public long MinSize;

		// Token: 0x04000368 RID: 872
		public long MaxSize;
	}
}
