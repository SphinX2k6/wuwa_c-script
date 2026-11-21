using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Define;
using CSharpScript.Launcher.Platform;
using CSharpScript.Launcher.Util;

namespace CSharpScript.Launcher.DiffPatch.Data
{
	// Token: 0x02000234 RID: 564
	[NullableContext(1)]
	[Nullable(0)]
	public class LanguageVersionInfo : ResVersionInfo
	{
		// Token: 0x06000E84 RID: 3716 RVA: 0x000580A2 File Offset: 0x000562A2
		public LanguageVersionInfo(string packageVersion, string remoteVersion, Dictionary<string, string> remoteManifestHash, string languageCode) : base(packageVersion, remoteVersion, remoteManifestHash)
		{
			this.LanguageCode = languageCode;
		}

		// Token: 0x06000E85 RID: 3717 RVA: 0x000580C0 File Offset: 0x000562C0
		public override string GetResType()
		{
			return EResType.Lang.ToEnumString() + "_" + this.LanguageCode;
		}

		// Token: 0x06000E86 RID: 3718 RVA: 0x000580D8 File Offset: 0x000562D8
		public override bool IsLangRes()
		{
			return true;
		}

		// Token: 0x06000E87 RID: 3719 RVA: 0x000580DC File Offset: 0x000562DC
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

		// Token: 0x06000E88 RID: 3720 RVA: 0x0005813C File Offset: 0x0005633C
		public override bool RecordUse(bool bUse)
		{
			string value = bUse ? "1" : "";
			return LauncherStorageLib.Instance.SetDeviceSavedString(this.GetUseLanguageSaveKey(), value);
		}

		// Token: 0x06000E89 RID: 3721 RVA: 0x0005816A File Offset: 0x0005636A
		protected override bool ClearUseRecord()
		{
			return LauncherStorageLib.Instance.DeleteDeviceSavedString(this.GetUseLanguageSaveKey());
		}

		// Token: 0x06000E8A RID: 3722 RVA: 0x0005817C File Offset: 0x0005637C
		private string GetUseLanguageSaveKey()
		{
			return "UseLanguage_" + this.LanguageCode;
		}

		// Token: 0x04000938 RID: 2360
		protected readonly string LanguageCode = "";
	}
}
