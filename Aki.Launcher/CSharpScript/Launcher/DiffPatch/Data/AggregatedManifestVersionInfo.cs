using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.DiffPatch.Data
{
	// Token: 0x02000235 RID: 565
	[NullableContext(1)]
	[Nullable(0)]
	public class AggregatedManifestVersionInfo : ResVersionInfo
	{
		// Token: 0x06000E8B RID: 3723 RVA: 0x0005818E File Offset: 0x0005638E
		public AggregatedManifestVersionInfo(string packageVersion, string remoteVersion, Dictionary<string, string> remoteManifestHashMap) : base(packageVersion, remoteVersion, remoteManifestHashMap)
		{
		}

		// Token: 0x06000E8C RID: 3724 RVA: 0x00058199 File Offset: 0x00056399
		public override string GetResType()
		{
			return "Aggregated";
		}

		// Token: 0x06000E8D RID: 3725 RVA: 0x000581A0 File Offset: 0x000563A0
		public override string GetManifestFileName()
		{
			return "ManifestAggregated";
		}
	}
}
