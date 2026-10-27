using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Define;
using CSharpScript.Launcher.Platform;
using CSharpScript.Launcher.Util;
using UnrealEngine;

namespace CSharpScript.Launcher.Update
{
	// Token: 0x02000089 RID: 137
	[NullableContext(1)]
	[Nullable(0)]
	public class LanguageVersionMisc : AppVersionMisc
	{
		// Token: 0x060004EF RID: 1263 RVA: 0x0002F013 File Offset: 0x0002D213
		public LanguageVersionMisc(string languageCode)
		{
			this.LanguageCode = languageCode;
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x0002F02D File Offset: 0x0002D22D
		protected override string GetUpdateVersionKey()
		{
			return "LanguageVersion_" + this.LanguageCode;
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x0002F03F File Offset: 0x0002D23F
		protected override string GetSaveUpdateVersionKey()
		{
			return "SavedLanguageVersion_" + this.LanguageCode;
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x0002F051 File Offset: 0x0002D251
		protected override string GetIndexFilePrefix()
		{
			return "PatchList_" + this.LanguageCode + "_";
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x0002F068 File Offset: 0x0002D268
		protected override string GetMountFileName()
		{
			return "Resource_" + this.LanguageCode + "_Mount.txt";
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x0002F07F File Offset: 0x0002D27F
		public override string GetResType()
		{
			return EResType.Resource.ToEnumString() + "_" + this.LanguageCode;
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x0002F098 File Offset: 0x0002D298
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

		// Token: 0x060004F6 RID: 1270 RVA: 0x0002F144 File Offset: 0x0002D344
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

		// Token: 0x060004F7 RID: 1271 RVA: 0x0002F1F0 File Offset: 0x0002D3F0
		public override void ClearAllPatchVersion(UObject worldContext)
		{
			base.ClearAllPatchVersion(worldContext);
			LauncherStorageLib.Instance.DeleteDeviceSavedString(this.GetUseLanguageSaveKey());
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x0002F20A File Offset: 0x0002D40A
		public bool HasMountFile()
		{
			return UBlueprintPathsLibrary.FileExists(base.GetMountFilePath());
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x0002F218 File Offset: 0x0002D418
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

		// Token: 0x060004FA RID: 1274 RVA: 0x0002F408 File Offset: 0x0002D608
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

		// Token: 0x060004FB RID: 1275 RVA: 0x0002F481 File Offset: 0x0002D681
		public override bool NeedCheckAppRestart()
		{
			return false;
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x0002F484 File Offset: 0x0002D684
		public void DeleteSavedVersion(UObject worldContext)
		{
			LauncherStorageLib.Instance.SetDeviceSavedString(this.GetSaveUpdateVersionKey(), this.PackageVersion);
			LauncherStorageLib.Instance.DeleteDeviceSavedString(this.GetUseLanguageSaveKey());
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x0002F4AE File Offset: 0x0002D6AE
		private string GetUseLanguageSaveKey()
		{
			return "UseLanguage_" + this.LanguageCode;
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x0002F4C0 File Offset: 0x0002D6C0
		public void SetUseLanguagePackage()
		{
			LauncherStorageLib.Instance.SetDeviceSavedString(this.GetUseLanguageSaveKey(), "1");
		}

		// Token: 0x040002DE RID: 734
		public string LanguageCode = "";

		// Token: 0x040002DF RID: 735
		[Nullable(2)]
		private VersionItem LangVersion;

		// Token: 0x040002E0 RID: 736
		private bool IsSetLangVersion;
	}
}
