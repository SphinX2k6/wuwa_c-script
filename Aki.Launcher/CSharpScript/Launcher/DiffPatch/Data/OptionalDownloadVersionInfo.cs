using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Define;

namespace CSharpScript.Launcher.DiffPatch.Data
{
	// Token: 0x02000233 RID: 563
	[NullableContext(1)]
	[Nullable(0)]
	public class OptionalDownloadVersionInfo : ResVersionInfo
	{
		// Token: 0x06000E82 RID: 3714 RVA: 0x0005806C File Offset: 0x0005626C
		public OptionalDownloadVersionInfo(string packageVersion, string remoteVersion, Dictionary<string, string> remoteManifestHash, string packKey) : base(packageVersion, remoteVersion, remoteManifestHash)
		{
			this.PackKey = packKey;
		}

		// Token: 0x06000E83 RID: 3715 RVA: 0x0005808A File Offset: 0x0005628A
		public override string GetResType()
		{
			return EResType.Optional.ToEnumString() + "_" + this.PackKey;
		}

		// Token: 0x04000937 RID: 2359
		protected readonly string PackKey = "";
	}
}
