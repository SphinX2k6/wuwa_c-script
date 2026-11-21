using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Update.ResourceDiffUpdate
{
	// Token: 0x020000A1 RID: 161
	[NullableContext(1)]
	[Nullable(0)]
	public class PackClassification
	{
		// Token: 0x04000393 RID: 915
		public List<ResPackageInfo> MinPacks = new List<ResPackageInfo>();

		// Token: 0x04000394 RID: 916
		public List<ResPackageInfo> MaxPacks = new List<ResPackageInfo>();

		// Token: 0x04000395 RID: 917
		public long MinSize;

		// Token: 0x04000396 RID: 918
		public long MaxSize;
	}
}
