using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Define;

namespace CSharpScript.Launcher.DiffPatch.Data
{
	// Token: 0x0200022D RID: 557
	[NullableContext(1)]
	[Nullable(0)]
	public class ResourceVersionInfo : ResVersionInfo
	{
		// Token: 0x06000E3F RID: 3647 RVA: 0x00055551 File Offset: 0x00053751
		public ResourceVersionInfo(string packageVersion, string remoteVersion, Dictionary<string, string> remoteManifestHashMap) : base(packageVersion, remoteVersion, remoteManifestHashMap)
		{
		}

		// Token: 0x06000E40 RID: 3648 RVA: 0x0005555C File Offset: 0x0005375C
		public override string GetResType()
		{
			return EResType.Resource.ToEnumString();
		}
	}
}
