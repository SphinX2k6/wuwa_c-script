using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Define;

namespace CSharpScript.Launcher.DiffPatch.Data
{
	// Token: 0x02000232 RID: 562
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleVoiceItemVersionInfo : OptionalDownloadVersionInfo
	{
		// Token: 0x06000E54 RID: 3668 RVA: 0x000556DB File Offset: 0x000538DB
		public RoleVoiceItemVersionInfo(string packageVersion, string remoteVersion, Dictionary<string, string> remoteManifestHash, string packKey) : base(packageVersion, remoteVersion, remoteManifestHash, packKey)
		{
		}

		// Token: 0x06000E55 RID: 3669 RVA: 0x000556E8 File Offset: 0x000538E8
		public override string GetResType()
		{
			return "RoleVoice/" + this.PackKey;
		}

		// Token: 0x06000E56 RID: 3670 RVA: 0x000556FA File Offset: 0x000538FA
		protected override string GetVersionRecordKey()
		{
			return "Version_" + EResType.Optional.ToEnumString() + "_" + this.PackKey;
		}

		// Token: 0x06000E57 RID: 3671 RVA: 0x00055717 File Offset: 0x00053917
		public override string GetManifestFileName()
		{
			return "";
		}

		// Token: 0x06000E58 RID: 3672 RVA: 0x0005571E File Offset: 0x0005391E
		public override bool NeedRecordMount()
		{
			return false;
		}

		// Token: 0x06000E59 RID: 3673 RVA: 0x00055721 File Offset: 0x00053921
		public string GetPackKey()
		{
			return this.PackKey;
		}
	}
}
