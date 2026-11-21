using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Define;

namespace CSharpScript.Launcher.DiffPatch.Data
{
	// Token: 0x02000237 RID: 567
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleVoiceItemVersionInfo : OptionalDownloadVersionInfo
	{
		// Token: 0x06000E95 RID: 3733 RVA: 0x000581E3 File Offset: 0x000563E3
		public RoleVoiceItemVersionInfo(string packageVersion, string remoteVersion, Dictionary<string, string> remoteManifestHash, string packKey) : base(packageVersion, remoteVersion, remoteManifestHash, packKey)
		{
		}

		// Token: 0x06000E96 RID: 3734 RVA: 0x000581F0 File Offset: 0x000563F0
		public override string GetResType()
		{
			return "RoleVoice/" + this.PackKey;
		}

		// Token: 0x06000E97 RID: 3735 RVA: 0x00058202 File Offset: 0x00056402
		protected override string GetVersionRecordKey()
		{
			return "Version_" + EResType.Optional.ToEnumString() + "_" + this.PackKey;
		}

		// Token: 0x06000E98 RID: 3736 RVA: 0x0005821F File Offset: 0x0005641F
		public override string GetManifestFileName()
		{
			return "";
		}

		// Token: 0x06000E99 RID: 3737 RVA: 0x00058226 File Offset: 0x00056426
		public override bool NeedRecordMount()
		{
			return false;
		}

		// Token: 0x06000E9A RID: 3738 RVA: 0x00058229 File Offset: 0x00056429
		public string GetPackKey()
		{
			return this.PackKey;
		}
	}
}
