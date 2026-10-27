using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.DiffPatch.Update;
using CSharpScript.Launcher.Download;
using CSharpScript.Launcher.Util;
using UnrealEngine;

namespace CSharpScript.Launcher.Update
{
	// Token: 0x0200008E RID: 142
	[NullableContext(1)]
	[Nullable(0)]
	public class LanguageUpdateManager : Singleton
	{
		// Token: 0x0600051B RID: 1307 RVA: 0x0002FB20 File Offset: 0x0002DD20
		public void Init(UObject worldContext)
		{
			if (this.Initialized)
			{
				return;
			}
			AppPathMisc appPathMisc = new AppPathMisc();
			foreach (LaunchLangDefine launchLangDefine in LauncherLanguageLib.Instance.GetAllLanguageDefines())
			{
				if (!this.UpdaterMap.ContainsKey(launchLangDefine.AudioCode))
				{
					LanguageUpdater languageUpdater = new LanguageUpdater();
					languageUpdater.LanguageCode = launchLangDefine.AudioCode;
					languageUpdater.Downloader = new UrlPrefixDownload();
					languageUpdater.VersionMisc = new LanguageVersionMisc(languageUpdater.LanguageCode);
					LanguageUpdateUiEvent uiEvent = null;
					UpdateReportEvent reportEvent = new UpdateReportEvent("in-game-" + languageUpdater.LanguageCode);
					uiEvent = new LanguageUpdateUiEvent();
					languageUpdater.DiffResInfo = ResPackageInfo.GetLanguageInfo(languageUpdater.LanguageCode);
					ResPackageInfo languageInfo = ResPackageInfo.GetLanguageInfo(languageUpdater.LanguageCode);
					List<ResPackageInfo> list = new List<ResPackageInfo>
					{
						languageInfo
					};
					foreach (KeyValuePair<string, ResPackageInfo> keyValuePair in ResPackageInfo.RoleVoiceInfos)
					{
						string[] array = keyValuePair.Key.Split('_', StringSplitOptions.None);
						if (array[array.Length - 1] == languageUpdater.LanguageCode)
						{
							list.Add(keyValuePair.Value);
							languageUpdater.RoleVoiceResInfos.Add(keyValuePair.Value);
						}
					}
					languageUpdater.DiffUpdater = new DiffUpdate(list, languageUpdater.Downloader, uiEvent, reportEvent, true, EUpdateType.IndependentLang);
					this.UpdaterMap[languageUpdater.LanguageCode] = languageUpdater;
					languageUpdater.Init(worldContext, uiEvent);
					this.AllLanguageType.Add(launchLangDefine.LanguageType);
				}
			}
			this.Initialized = true;
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x0002FCF4 File Offset: 0x0002DEF4
		public List<int> GetAllLanguageTypeForAudio()
		{
			return this.AllLanguageType;
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x0002FCFC File Offset: 0x0002DEFC
		public List<LanguageVersionMisc> GetAllLanguagesVersionMisc()
		{
			List<LanguageVersionMisc> list = new List<LanguageVersionMisc>();
			foreach (KeyValuePair<string, LanguageUpdater> keyValuePair in this.UpdaterMap)
			{
				list.Add(keyValuePair.Value.VersionMisc);
			}
			return list;
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x0002FD64 File Offset: 0x0002DF64
		public LanguageUpdater GetUpdater(string languageCode)
		{
			return this.UpdaterMap[languageCode];
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x0002FD74 File Offset: 0x0002DF74
		public void StopAllDownload()
		{
			foreach (KeyValuePair<string, LanguageUpdater> keyValuePair in this.UpdaterMap)
			{
				keyValuePair.Value.Pause();
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000520 RID: 1312 RVA: 0x0002FDCC File Offset: 0x0002DFCC
		public static LanguageUpdateManager Instance
		{
			get
			{
				if (LanguageUpdateManager._instance == null)
				{
					LanguageUpdateManager._instance = new LanguageUpdateManager();
					LanguageUpdateManager._instance.OnInit();
				}
				return LanguageUpdateManager._instance;
			}
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x0002FDEF File Offset: 0x0002DFEF
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x0002FDF1 File Offset: 0x0002DFF1
		public static void ResetStaticDefaultValue()
		{
			LanguageUpdateManager instance = LanguageUpdateManager._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			LanguageUpdateManager._instance = null;
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x0002FE0A File Offset: 0x0002E00A
		static LanguageUpdateManager()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LanguageUpdateManager.CreateStaticDefaultValue), new Action(LanguageUpdateManager.ResetStaticDefaultValue));
		}

		// Token: 0x040002F5 RID: 757
		private bool Initialized;

		// Token: 0x040002F6 RID: 758
		private readonly Dictionary<string, LanguageUpdater> UpdaterMap = new Dictionary<string, LanguageUpdater>();

		// Token: 0x040002F7 RID: 759
		private readonly List<int> AllLanguageType = new List<int>();

		// Token: 0x040002F8 RID: 760
		[Nullable(2)]
		private static LanguageUpdateManager _instance;
	}
}
