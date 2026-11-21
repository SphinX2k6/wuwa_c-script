using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Define;

namespace CSharpScript.Launcher.DiffPatch.Data
{
	// Token: 0x02000231 RID: 561
	[NullableContext(1)]
	[Nullable(0)]
	public class LauncherVersionInfo : ResVersionInfo
	{
		// Token: 0x06000E7E RID: 3710 RVA: 0x00058046 File Offset: 0x00056246
		public LauncherVersionInfo(string packageVersion, string remoteVersion, Dictionary<string, string> remoteManifestHashMap) : base(packageVersion, remoteVersion, remoteManifestHashMap)
		{
		}

		// Token: 0x06000E7F RID: 3711 RVA: 0x00058051 File Offset: 0x00056251
		public override string GetResType()
		{
			return EResType.Launcher.ToEnumString();
		}
	}
}
