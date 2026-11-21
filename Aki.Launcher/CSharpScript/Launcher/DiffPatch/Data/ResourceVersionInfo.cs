using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Define;

namespace CSharpScript.Launcher.DiffPatch.Data
{
	// Token: 0x02000232 RID: 562
	[NullableContext(1)]
	[Nullable(0)]
	public class ResourceVersionInfo : ResVersionInfo
	{
		// Token: 0x06000E80 RID: 3712 RVA: 0x00058059 File Offset: 0x00056259
		public ResourceVersionInfo(string packageVersion, string remoteVersion, Dictionary<string, string> remoteManifestHashMap) : base(packageVersion, remoteVersion, remoteManifestHashMap)
		{
		}

		// Token: 0x06000E81 RID: 3713 RVA: 0x00058064 File Offset: 0x00056264
		public override string GetResType()
		{
			return EResType.Resource.ToEnumString();
		}
	}
}
