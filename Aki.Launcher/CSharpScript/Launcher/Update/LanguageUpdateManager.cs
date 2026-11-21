using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.DiffPatch.Update;
using CSharpScript.Launcher.Download;
using CSharpScript.Launcher.Util;
using UnrealEngine;

namespace CSharpScript.Launcher.Update
{
	// Token: 0x02000091 RID: 145
	[NullableContext(1)]
	[Nullable(0)]
	public class LanguageUpdateManager : Singleton
	{
		// Token: 0x06000532 RID: 1330 RVA: 0x00031088 File Offset: 0x0002F288
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

		// Token: 0x06000533 RID: 1331 RVA: 0x0003125C File Offset: 0x0002F45C
		public List<int> GetAllLanguageTypeForAudio()
		{
			return this.AllLanguageType;
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x00031264 File Offset: 0x0002F464
		public List<LanguageVersionMisc> GetAllLanguagesVersionMisc()
		{
			List<LanguageVersionMisc> list = new List<LanguageVersionMisc>();
			foreach (KeyValuePair<string, LanguageUpdater> keyValuePair in this.UpdaterMap)
			{
				list.Add(keyValuePair.Value.VersionMisc);
			}
			return list;
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x000312CC File Offset: 0x0002F4CC
		public LanguageUpdater GetUpdater(string languageCode)
		{
			return this.UpdaterMap[languageCode];
		}

		// Token: 0x06000536 RID: 1334 RVA: 0x000312DC File Offset: 0x0002F4DC
		public void StopAllDownload()
		{
			foreach (KeyValuePair<string, LanguageUpdater> keyValuePair in this.UpdaterMap)
			{
				keyValuePair.Value.Pause();
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000537 RID: 1335 RVA: 0x00031334 File Offset: 0x0002F534
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

		// Token: 0x06000538 RID: 1336 RVA: 0x00031357 File Offset: 0x0002F557
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x00031359 File Offset: 0x0002F559
		public static void ResetStaticDefaultValue()
		{
			LanguageUpdateManager instance = LanguageUpdateManager._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			LanguageUpdateManager._instance = null;
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x00031372 File Offset: 0x0002F572
		static LanguageUpdateManager()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LanguageUpdateManager.CreateStaticDefaultValue), new Action(LanguageUpdateManager.ResetStaticDefaultValue));
		}

		// Token: 0x04000323 RID: 803
		private bool Initialized;

		// Token: 0x04000324 RID: 804
		private readonly Dictionary<string, LanguageUpdater> UpdaterMap = new Dictionary<string, LanguageUpdater>();

		// Token: 0x04000325 RID: 805
		private readonly List<int> AllLanguageType = new List<int>();

		// Token: 0x04000326 RID: 806
		[Nullable(2)]
		private static LanguageUpdateManager _instance;
	}
}
