using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Define;

namespace CSharpScript.Launcher.DiffPatch.Data
{
	// Token: 0x02000238 RID: 568
	[NullableContext(1)]
	[Nullable(0)]
	public class TierResourceVersionInfo : ResourceVersionInfo
	{
		// Token: 0x06000E9B RID: 3739 RVA: 0x00058231 File Offset: 0x00056431
		public TierResourceVersionInfo(string packageVersion, string remoteVersion, Dictionary<string, string> remoteManifestHashMap, string tierLabel) : base(packageVersion, remoteVersion, remoteManifestHashMap)
		{
			this.TierLabel = tierLabel;
		}

		// Token: 0x06000E9C RID: 3740 RVA: 0x00058244 File Offset: 0x00056444
		public override string GetResType()
		{
			return EResType.Resource.ToEnumString() + "_" + this.TierLabel;
		}

		// Token: 0x0400093A RID: 2362
		private readonly string TierLabel;
	}
}
