using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Define;
using CSharpScript.Launcher.Platform;
using CSharpScript.Launcher.Util;

namespace CSharpScript.Launcher.DiffPatch.Data
{
	// Token: 0x0200022F RID: 559
	[NullableContext(1)]
	[Nullable(0)]
	public class LanguageVersionInfo : ResVersionInfo
	{
		// Token: 0x06000E43 RID: 3651 RVA: 0x0005559A File Offset: 0x0005379A
		public LanguageVersionInfo(string packageVersion, string remoteVersion, Dictionary<string, string> remoteManifestHash, string languageCode) : base(packageVersion, remoteVersion, remoteManifestHash)
		{
			this.LanguageCode = languageCode;
		}

		// Token: 0x06000E44 RID: 3652 RVA: 0x000555B8 File Offset: 0x000537B8
		public override string GetResType()
		{
			return EResType.Lang.ToEnumString() + "_" + this.LanguageCode;
		}

		// Token: 0x06000E45 RID: 3653 RVA: 0x000555D0 File Offset: 0x000537D0
		public override bool IsLangRes()
		{
			return true;
		}

		// Token: 0x06000E46 RID: 3654 RVA: 0x000555D4 File Offset: 0x000537D4
		public override bool SkipUpdate()
		{
			if (Platform.Instance.IsCloudGame())
			{
				return false;
			}
			if (this.LanguageCode == LauncherLanguageLib.Instance.GetPackageAudioLanguage())
			{
				return false;
			}
			string text = LauncherStorageLib.Instance.GetDeviceSavedString(this.GetUseLanguageSaveKey(), "").Trim();
			return text == null || text.Length <= 0;
		}

		// Token: 0x06000E47 RID: 3655 RVA: 0x00055634 File Offset: 0x00053834
		public override bool RecordUse(bool bUse)
		{
			string value = bUse ? "1" : "";
			return LauncherStorageLib.Instance.SetDeviceSavedString(this.GetUseLanguageSaveKey(), value);
		}

		// Token: 0x06000E48 RID: 3656 RVA: 0x00055662 File Offset: 0x00053862
		protected override bool ClearUseRecord()
		{
			return LauncherStorageLib.Instance.DeleteDeviceSavedString(this.GetUseLanguageSaveKey());
		}

		// Token: 0x06000E49 RID: 3657 RVA: 0x00055674 File Offset: 0x00053874
		private string GetUseLanguageSaveKey()
		{
			return "UseLanguage_" + this.LanguageCode;
		}

		// Token: 0x040008F6 RID: 2294
		protected readonly string LanguageCode = "";
	}
}
