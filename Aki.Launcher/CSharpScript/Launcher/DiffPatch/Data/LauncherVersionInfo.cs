using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Define;

namespace CSharpScript.Launcher.DiffPatch.Data
{
	// Token: 0x0200022C RID: 556
	[NullableContext(1)]
	[Nullable(0)]
	public class LauncherVersionInfo : ResVersionInfo
	{
		// Token: 0x06000E3D RID: 3645 RVA: 0x0005553E File Offset: 0x0005373E
		public LauncherVersionInfo(string packageVersion, string remoteVersion, Dictionary<string, string> remoteManifestHashMap) : base(packageVersion, remoteVersion, remoteManifestHashMap)
		{
		}

		// Token: 0x06000E3E RID: 3646 RVA: 0x00055549 File Offset: 0x00053749
		public override string GetResType()
		{
			return EResType.Launcher.ToEnumString();
		}
	}
}
