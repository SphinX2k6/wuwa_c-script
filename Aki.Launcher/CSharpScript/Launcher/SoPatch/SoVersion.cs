using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.SoPatch
{
	// Token: 0x02000100 RID: 256
	public class SoVersion
	{
		// Token: 0x040004C2 RID: 1218
		public int CurVer = -1;

		// Token: 0x040004C3 RID: 1219
		[Nullable(1)]
		public Dictionary<int, VersionInfo> Versions = new Dictionary<int, VersionInfo>();

		// Token: 0x040004C4 RID: 1220
		public int UpdateTime = -1;
	}
}
