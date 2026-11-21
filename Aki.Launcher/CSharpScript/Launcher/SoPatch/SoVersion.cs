using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.SoPatch
{
	// Token: 0x02000104 RID: 260
	public class SoVersion
	{
		// Token: 0x040004FD RID: 1277
		public int CurVer = -1;

		// Token: 0x040004FE RID: 1278
		[Nullable(1)]
		public Dictionary<int, VersionInfo> Versions = new Dictionary<int, VersionInfo>();

		// Token: 0x040004FF RID: 1279
		public int UpdateTime = -1;
	}
}
