using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Define;
using CSharpScript.Launcher.Platform;
using CSharpScript.Launcher.Util;
using UnrealEngine;

namespace CSharpScript.Launcher.Update
{
	// Token: 0x0200008C RID: 140
	[NullableContext(1)]
	[Nullable(0)]
	public class LanguageVersionMisc : AppVersionMisc
	{
		// Token: 0x06000506 RID: 1286 RVA: 0x0003057B File Offset: 0x0002E77B
		public LanguageVersionMisc(string languageCode)
		{
			this.LanguageCode = languageCode;
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x00030595 File Offset: 0x0002E795
		protected override string GetUpdateVersionKey()
		{
			return "LanguageVersion_" + this.LanguageCode;
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x000305A7 File Offset: 0x0002E7A7
		protected override string GetSaveUpdateVersionKey()
		{
			return "SavedLanguageVersion_" + this.LanguageCode;
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x000305B9 File Offset: 0x0002E7B9
		protected override string GetIndexFilePrefix()
		{
			return "PatchList_" + this.LanguageCode + "_";
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x000305D0 File Offset: 0x0002E7D0
		protected override string GetMountFileName()
		{
			return "Resource_" + this.LanguageCode + "_Mount.txt";
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x000305E7 File Offset: 0x0002E7E7
		public override string GetResType()
		{
			return EResType.Resource.ToEnumString() + "_" + this.LanguageCode;
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x00030600 File Offset: 0x0002E800
		protected override string GetRemoteVersion()
		{
			if (!this.IsSetLangVersion)
			{
				RemoteConfig config = RemoteInfo.Instance.Config;
				if (((config != null) ? config.Versions : null) != null)
				{
					foreach (VersionItem versionItem in RemoteInfo.Instance.Config.Versions)
					{
						if (versionItem.Name == this.LanguageCode)
						{
							this.LangVersion = versionItem;
							break;
						}
					}
				}
				this.IsSetLangVersion = true;
			}
			VersionItem langVersion = this.LangVersion;
			if (langVersion == null)
			{
				return null;
			}
			return langVersion.Version;
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x000306AC File Offset: 0x0002E8AC
		protected override Dictionary<string, string> GetRemoteSha1Map()
		{
			if (!this.IsSetLangVersion)
			{
				RemoteConfig config = RemoteInfo.Instance.Config;
				if (((config != null) ? config.Versions : null) != null)
				{
					foreach (VersionItem versionItem in RemoteInfo.Instance.Config.Versions)
					{
						if (versionItem.Name == this.LanguageCode)
						{
							this.LangVersion = versionItem;
							break;
						}
					}
				}
				this.IsSetLangVersion = true;
			}
			VersionItem langVersion = this.LangVersion;
			if (langVersion == null)
			{
				return null;
			}
			return langVersion.IndexSha1;
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x00030758 File Offset: 0x0002E958
		public override void ClearAllPatchVersion(UObject worldContext)
		{
			base.ClearAllPatchVersion(worldContext);
			LauncherStorageLib.Instance.DeleteDeviceSavedString(this.GetUseLanguageSaveKey());
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x00030772 File Offset: 0x0002E972
		public bool HasMountFile()
		{
			return UBlueprintPathsLibrary.FileExists(base.GetMountFilePath());
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x00030780 File Offset: 0x0002E980
		[NullableContext(0)]
		public ValueTuple<long, long> CalculateLocalSize()
		{
			List<PatchFileInfo> list = base.ReadPatchFileInfoList();
			long num = 0L;
			long num2 = 0L;
			foreach (PatchFileInfo patchFileInfo in list)
			{
				num2 += patchFileInfo.PakSize.GetValueOrDefault();
				num2 += patchFileInfo.SigSize.GetValueOrDefault();
				num2 += patchFileInfo.UtocSize.GetValueOrDefault();
				num2 += patchFileInfo.UcasSize.GetValueOrDefault();
				if (UBlueprintPathsLibrary.FileExists(patchFileInfo.SavePath + EResFile.PAK.ToEnumString()))
				{
					num += patchFileInfo.PakSize.GetValueOrDefault();
				}
				else
				{
					string text = patchFileInfo.SavePath + EResFile.PAK.ToEnumString() + ".download";
					if (UBlueprintPathsLibrary.FileExists(text))
					{
						num += UKuroLauncherLibrary.GetFileSize(text);
					}
				}
				if (UBlueprintPathsLibrary.FileExists(patchFileInfo.SavePath + EResFile.SIG.ToEnumString()))
				{
					num += patchFileInfo.SigSize.GetValueOrDefault();
				}
				else
				{
					string text2 = patchFileInfo.SavePath + EResFile.SIG.ToEnumString() + ".download";
					if (UBlueprintPathsLibrary.FileExists(text2))
					{
						num += UKuroLauncherLibrary.GetFileSize(text2);
					}
				}
				if (UBlueprintPathsLibrary.FileExists(patchFileInfo.SavePath + EResFile.UTOC.ToEnumString()))
				{
					num += patchFileInfo.UtocSize.GetValueOrDefault();
				}
				else
				{
					string text3 = patchFileInfo.SavePath + EResFile.UTOC.ToEnumString() + ".download";
					if (UBlueprintPathsLibrary.FileExists(text3))
					{
						num += UKuroLauncherLibrary.GetFileSize(text3);
					}
				}
				if (UBlueprintPathsLibrary.FileExists(patchFileInfo.SavePath + EResFile.UCAS.ToEnumString()))
				{
					num += patchFileInfo.UcasSize.GetValueOrDefault();
				}
				else
				{
					string text4 = patchFileInfo.SavePath + EResFile.UCAS.ToEnumString() + ".download";
					if (UBlueprintPathsLibrary.FileExists(text4))
					{
						num += UKuroLauncherLibrary.GetFileSize(text4);
					}
				}
			}
			return new ValueTuple<long, long>(num, num2);
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x00030970 File Offset: 0x0002EB70
		public bool NeedUpdate()
		{
			if (Platform.Instance.IsCloudGame())
			{
				return true;
			}
			if (this.LanguageCode == LauncherLanguageLib.Instance.PackageLanguage)
			{
				return true;
			}
			string text = (LauncherStorageLib.Instance.GetDeviceSavedString(this.GetUseLanguageSaveKey(), "") ?? "").Trim();
			return (text != null && text.Length > 0) || (base.HasNewResourceVersionBaseOnPackage() && !base.IsFirstUpdateResources());
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x000309E9 File Offset: 0x0002EBE9
		public override bool NeedCheckAppRestart()
		{
			return false;
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x000309EC File Offset: 0x0002EBEC
		public void DeleteSavedVersion(UObject worldContext)
		{
			LauncherStorageLib.Instance.SetDeviceSavedString(this.GetSaveUpdateVersionKey(), this.PackageVersion);
			LauncherStorageLib.Instance.DeleteDeviceSavedString(this.GetUseLanguageSaveKey());
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x00030A16 File Offset: 0x0002EC16
		private string GetUseLanguageSaveKey()
		{
			return "UseLanguage_" + this.LanguageCode;
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x00030A28 File Offset: 0x0002EC28
		public void SetUseLanguagePackage()
		{
			LauncherStorageLib.Instance.SetDeviceSavedString(this.GetUseLanguageSaveKey(), "1");
		}

		// Token: 0x0400030C RID: 780
		public string LanguageCode = "";

		// Token: 0x0400030D RID: 781
		[Nullable(2)]
		private VersionItem LangVersion;

		// Token: 0x0400030E RID: 782
		private bool IsSetLangVersion;
	}
}
