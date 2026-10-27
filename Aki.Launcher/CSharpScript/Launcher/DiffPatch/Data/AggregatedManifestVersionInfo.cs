using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.DiffPatch.Data
{
	// Token: 0x02000230 RID: 560
	[NullableContext(1)]
	[Nullable(0)]
	public class AggregatedManifestVersionInfo : ResVersionInfo
	{
		// Token: 0x06000E4A RID: 3658 RVA: 0x00055686 File Offset: 0x00053886
		public AggregatedManifestVersionInfo(string packageVersion, string remoteVersion, Dictionary<string, string> remoteManifestHashMap) : base(packageVersion, remoteVersion, remoteManifestHashMap)
		{
		}

		// Token: 0x06000E4B RID: 3659 RVA: 0x00055691 File Offset: 0x00053891
		public override string GetResType()
		{
			return "Aggregated";
		}

		// Token: 0x06000E4C RID: 3660 RVA: 0x00055698 File Offset: 0x00053898
		public override string GetManifestFileName()
		{
			return "ManifestAggregated";
		}
	}
}
