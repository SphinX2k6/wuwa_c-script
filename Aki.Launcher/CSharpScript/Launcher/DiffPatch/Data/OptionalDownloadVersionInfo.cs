using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Define;

namespace CSharpScript.Launcher.DiffPatch.Data
{
	// Token: 0x0200022E RID: 558
	[NullableContext(1)]
	[Nullable(0)]
	public class OptionalDownloadVersionInfo : ResVersionInfo
	{
		// Token: 0x06000E41 RID: 3649 RVA: 0x00055564 File Offset: 0x00053764
		public OptionalDownloadVersionInfo(string packageVersion, string remoteVersion, Dictionary<string, string> remoteManifestHash, string packKey) : base(packageVersion, remoteVersion, remoteManifestHash)
		{
			this.PackKey = packKey;
		}

		// Token: 0x06000E42 RID: 3650 RVA: 0x00055582 File Offset: 0x00053782
		public override string GetResType()
		{
			return EResType.Optional.ToEnumString() + "_" + this.PackKey;
		}

		// Token: 0x040008F5 RID: 2293
		protected readonly string PackKey = "";
	}
}
