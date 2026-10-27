using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Define;

namespace CSharpScript.Launcher.DiffPatch.Data
{
	// Token: 0x02000233 RID: 563
	[NullableContext(1)]
	[Nullable(0)]
	public class TierResourceVersionInfo : ResourceVersionInfo
	{
		// Token: 0x06000E5A RID: 3674 RVA: 0x00055729 File Offset: 0x00053929
		public TierResourceVersionInfo(string packageVersion, string remoteVersion, Dictionary<string, string> remoteManifestHashMap, string tierLabel) : base(packageVersion, remoteVersion, remoteManifestHashMap)
		{
			this.TierLabel = tierLabel;
		}

		// Token: 0x06000E5B RID: 3675 RVA: 0x0005573C File Offset: 0x0005393C
		public override string GetResType()
		{
			return EResType.Resource.ToEnumString() + "_" + this.TierLabel;
		}

		// Token: 0x040008F8 RID: 2296
		private readonly string TierLabel;
	}
}
