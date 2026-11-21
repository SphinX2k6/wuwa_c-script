using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common;
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Launcher.PackageUpdate;
using UnrealEngine;

// Token: 0x020017F8 RID: 6136
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ParallelPackageController : ControllerBase
{
	// Token: 0x0600F08A RID: 61578 RVA: 0x0046AFEB File Offset: 0x004691EB
	protected override bool OnInit()
	{
		this.InitParallelPackageConfig();
		return true;
	}

	// Token: 0x0600F08B RID: 61579 RVA: 0x0046AFF4 File Offset: 0x004691F4
	public void TestParallelPackage()
	{
		this.GmTest = true;
		BaseConfigController.Instance.GetCdnReturnConfigInfo().ParallelPackageDescUrl = new IUpdateUrl
		{
			MainUrl = "https://gm-test.aki-game.com/force_update/OptionalUpdate.json",
			SubUrl = "https://gm-test.aki-game.com/force_update/OptionalUpdate.json"
		};
		this.InitParallelPackageConfig();
	}

	// Token: 0x0600F08C RID: 61580 RVA: 0x0046B030 File Offset: 0x00469230
	private void InitParallelPackageConfig()
	{
		string appParallel = UKuroLauncherLibrary.GetAppParallel();
		Log instance = Log.Instance;
		ELogModule module = ELogModule.KuroSdk;
		ELogAuthor author = ELogAuthor.YZY;
		string message = "InitParallelPackageConfig";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("parallelName", appParallel);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		this.GetParallelPackageConfig(false, new Action<bool, string>(this.OnInitParallelPackageConfig));
	}

	// Token: 0x0600F08D RID: 61581 RVA: 0x0046B080 File Offset: 0x00469280
	public void RefreshCdnConfigAndCheckVersion(Action<bool> onNeedUpdate)
	{
		this.GetParallelPackageConfig(false, delegate(bool state, string data)
		{
			this.OnInitParallelPackageConfig(state, data);
			onNeedUpdate(this.CheckParallelPackageVersionOnly());
		});
	}

	// Token: 0x0600F08E RID: 61582 RVA: 0x0046B0B4 File Offset: 0x004692B4
	private void HttpGetInfo(string url, Action<bool, int, string> callBack, int currentTryCount = 0)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.KuroSdk;
		ELogAuthor author = ELogAuthor.YZY;
		string message = "InitParallelPackageConfig";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("url", url);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		Http.Get(url, null, delegate(bool success, int code, string data)
		{
			if (!success || code != 200)
			{
				callBack(false, code, data);
				return;
			}
			callBack(true, code, data);
		}, null);
	}

	// Token: 0x0600F08F RID: 61583 RVA: 0x0046B114 File Offset: 0x00469314
	private void GetParallelPackageConfig(bool switchUrl, Action<bool, string> onGetConfig)
	{
		string url = "";
		EntryJson cdnReturnConfigInfo = BaseConfigController.Instance.GetCdnReturnConfigInfo();
		if (cdnReturnConfigInfo == null)
		{
			Log.Instance.Error(ELogModule.KuroSdk, ELogAuthor.LRX, "CDN return config info is null!!", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		url = ((cdnReturnConfigInfo.ParallelPackageDescUrl != null) ? (switchUrl ? cdnReturnConfigInfo.ParallelPackageDescUrl.MainUrl : cdnReturnConfigInfo.ParallelPackageDescUrl.SubUrl) : "");
		this.HttpGetInfo(url, delegate(bool state, int code, string data)
		{
			if (state)
			{
				onGetConfig(state, data);
				return;
			}
			if (switchUrl)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.KuroSdk;
				ELogAuthor author = ELogAuthor.YZY;
				string message = "InitParallelPackageConfig";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Failed to get parallel package config", url);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				onGetConfig(state, data);
				return;
			}
			this.GetParallelPackageConfig(true, onGetConfig);
		}, 0);
	}

	// Token: 0x0600F090 RID: 61584 RVA: 0x0046B1C0 File Offset: 0x004693C0
	private void OnInitParallelPackageConfig(bool state, string data)
	{
		if (!state)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.KuroSdk;
			ELogAuthor author = ELogAuthor.YZY;
			string message = "InitParallelPackageConfig fail";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(data, BaseConfigController.Instance.GetCdnReturnConfigInfo().ParallelPackageDescUrl);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		this.Config = Json.Parse<ParallelPackageConfig>(data, null);
	}

	// Token: 0x0600F091 RID: 61585 RVA: 0x0046B210 File Offset: 0x00469410
	private string GetCacheParallelPackageVersion()
	{
		string global = LocalStorage.GetGlobal<string>(ELocalStorageGlobalKey.ParallelPackageVersion, null);
		if (global == null)
		{
			return "";
		}
		return global;
	}

	// Token: 0x0600F092 RID: 61586 RVA: 0x0046B234 File Offset: 0x00469434
	public bool CheckParallelPackageWithCache()
	{
		if (this.GmTest)
		{
			return true;
		}
		if (this.CurrentLoginShowState)
		{
			return false;
		}
		string cacheParallelPackageVersion = this.GetCacheParallelPackageVersion();
		return !(this.GetCurrentPlatformParallelPackageVersionText() == cacheParallelPackageVersion) && this.CheckParallelPackage();
	}

	// Token: 0x0600F093 RID: 61587 RVA: 0x0046B272 File Offset: 0x00469472
	public bool CheckParallelPackage()
	{
		return Info.Instance.IsMobilePlatform() && this.CheckParallelPackageVersionOnly();
	}

	// Token: 0x0600F094 RID: 61588 RVA: 0x0046B288 File Offset: 0x00469488
	public bool CheckParallelPackageVersionOnly()
	{
		if (this.Config == null)
		{
			return false;
		}
		ParallelPackageUrlConfig currentPlatformParallelPackageVersion = this.GetCurrentPlatformParallelPackageVersion();
		if (currentPlatformParallelPackageVersion == null)
		{
			return false;
		}
		string parentVersion = currentPlatformParallelPackageVersion.parentVersion;
		string childVersion = currentPlatformParallelPackageVersion.childVersion;
		string appVersion = UKuroLauncherLibrary.GetAppVersion();
		float num;
		float num2;
		return !(this.GetSplitAppVersion(parentVersion) != this.GetSplitAppVersion(appVersion)) && float.TryParse(childVersion, out num) && float.TryParse(UKuroLauncherLibrary.GetAppChangeList(), out num2) && num > num2;
	}

	// Token: 0x0600F095 RID: 61589 RVA: 0x0046B2F8 File Offset: 0x004694F8
	private string GetSplitAppVersion(string version)
	{
		string[] array = version.Split('.', StringSplitOptions.None);
		if (array.Length < 2)
		{
			return version;
		}
		return array[0] + "." + array[1];
	}

	// Token: 0x0600F096 RID: 61590 RVA: 0x0046B328 File Offset: 0x00469528
	private string GetPackageUpdateContentByLanguageCode(string languageCode)
	{
		Dictionary<string, ParallelPackageLanguageContent> languageConfig = this.Config.languageConfig;
		if (languageConfig == null)
		{
			return "";
		}
		ParallelPackageLanguageContent parallelPackageLanguageContent;
		if (!languageConfig.TryGetValue(languageCode, out parallelPackageLanguageContent))
		{
			return "";
		}
		return parallelPackageLanguageContent.content;
	}

	// Token: 0x0600F097 RID: 61591 RVA: 0x0046B364 File Offset: 0x00469564
	private string GetPackageUpdateTitleByLanguageCode(string languageCode)
	{
		Dictionary<string, ParallelPackageLanguageContent> languageConfig = this.Config.languageConfig;
		if (languageConfig == null)
		{
			return "";
		}
		ParallelPackageLanguageContent parallelPackageLanguageContent;
		if (!languageConfig.TryGetValue(languageCode, out parallelPackageLanguageContent))
		{
			return "";
		}
		return parallelPackageLanguageContent.title;
	}

	// Token: 0x0600F098 RID: 61592 RVA: 0x0046B3A0 File Offset: 0x004695A0
	private string GetCurrentPlatformParallelPackageVersionText()
	{
		ParallelPackageUrlConfig currentPlatformParallelPackageVersion = this.GetCurrentPlatformParallelPackageVersion();
		if (currentPlatformParallelPackageVersion == null)
		{
			return "";
		}
		return currentPlatformParallelPackageVersion.parentVersion + "_" + currentPlatformParallelPackageVersion.childVersion;
	}

	// Token: 0x0600F099 RID: 61593 RVA: 0x0046B3D4 File Offset: 0x004695D4
	[NullableContext(2)]
	private ParallelPackageUrlConfig GetCurrentPlatformParallelPackageVersion()
	{
		if (this.Config == null || this.Config.version == 0)
		{
			return null;
		}
		string b = PublicUtil.Instance.OverridePackageId ?? KuroSdkController.Instance.GetPackageId();
		if (this.Config.packageConfig == null)
		{
			return null;
		}
		int count = this.Config.packageConfig.Count;
		for (int i = 0; i < count; i++)
		{
			ParallelPackageUrlConfig parallelPackageUrlConfig = this.Config.packageConfig[i];
			if (parallelPackageUrlConfig.packageId == b)
			{
				return parallelPackageUrlConfig;
			}
		}
		return null;
	}

	// Token: 0x0600F09A RID: 61594 RVA: 0x0046B460 File Offset: 0x00469660
	public void TryShowParallelPackageUpdateConfirmBox(ParallelPackageDownloadBoxShowReason reason)
	{
		if (!this.CheckParallelPackageWithCache())
		{
			return;
		}
		this.CurrentLoginShowState = true;
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.ParallelPackageUpdate);
		string packageLanguage = LanguageSystem.Instance.PackageLanguage;
		string text = this.GetPackageUpdateTitleByLanguageCode(packageLanguage);
		string text2 = this.GetPackageUpdateContentByLanguageCode(packageLanguage);
		if (text == "")
		{
			text = (ConfigMultiTextLang.GetLocalTextNew("ParallelPackageUpdateDefaultTitle", null) ?? "");
		}
		if (text2 == "")
		{
			text2 = (ConfigMultiTextLang.GetLocalTextNew("ParallelPackageUpdateDefaultDesc", null) ?? "");
		}
		confirmBoxDataNew.SetTitle(text);
		confirmBoxDataNew.SetTextArgs(new string[]
		{
			text2
		});
		confirmBoxDataNew.HasToggle = true;
		confirmBoxDataNew.ToggleTextKey = "ParallelPackageVersionTip";
		bool toggleState = false;
		confirmBoxDataNew.SetToggleFunction(delegate(bool isSelectOn)
		{
			toggleState = isSelectOn;
		});
		confirmBoxDataNew.CanExecuteCloseFunc = ((int selectedIndex) => selectedIndex != 2);
		confirmBoxDataNew.FunctionMap.Add(2, delegate
		{
			PackageUpdateController.Instance.TryOpenParallelPackageUpdateUrl();
			int i_type = (reason == ParallelPackageDownloadBoxShowReason.Auto) ? 1 : 3;
			ParallelDownloadConfirmBoxOperation parallelDownloadConfirmBoxOperation = new ParallelDownloadConfirmBoxOperation();
			parallelDownloadConfirmBoxOperation.i_type = i_type;
			LogReportController.Instance.LogReport(parallelDownloadConfirmBoxOperation);
		});
		confirmBoxDataNew.FunctionMap.Add(1, delegate
		{
			ParallelDownloadConfirmBoxOperation parallelDownloadConfirmBoxOperation = new ParallelDownloadConfirmBoxOperation();
			parallelDownloadConfirmBoxOperation.i_type = 2;
			LogReportController.Instance.LogReport(parallelDownloadConfirmBoxOperation);
		});
		confirmBoxDataNew.SetCloseFunction(delegate
		{
			if (toggleState)
			{
				string currentPlatformParallelPackageVersionText = this.GetCurrentPlatformParallelPackageVersionText();
				LocalStorage.SetGlobal<string>(ELocalStorageGlobalKey.ParallelPackageVersion, currentPlatformParallelPackageVersionText);
			}
		});
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		if (reason == ParallelPackageDownloadBoxShowReason.Auto)
		{
			AutoShowParallelDownloadConfirmBox logData = new AutoShowParallelDownloadConfirmBox();
			LogReportController.Instance.LogReport(logData);
		}
	}

	// Token: 0x170016EA RID: 5866
	// (get) Token: 0x0600F09B RID: 61595 RVA: 0x0046B5E2 File Offset: 0x004697E2
	public static ParallelPackageController Instance
	{
		get
		{
			return ParallelPackageController._Instance;
		}
	}

	// Token: 0x0600F09C RID: 61596 RVA: 0x0046B5E9 File Offset: 0x004697E9
	public static ParallelPackageController GetOrCreateInstance()
	{
		if (ParallelPackageController._Instance == null)
		{
			ParallelPackageController.CreateInstance();
		}
		return ParallelPackageController._Instance;
	}

	// Token: 0x0600F09D RID: 61597 RVA: 0x0046B5FD File Offset: 0x004697FD
	public static bool CreateInstance()
	{
		if (ParallelPackageController._Instance != null)
		{
			return true;
		}
		ParallelPackageController._Instance = new ParallelPackageController();
		return true;
	}

	// Token: 0x0600F09E RID: 61598 RVA: 0x0046B613 File Offset: 0x00469813
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600F09F RID: 61599 RVA: 0x0046B615 File Offset: 0x00469815
	public static void ResetStaticDefaultValue()
	{
		ParallelPackageController._Instance = null;
	}

	// Token: 0x0600F0A0 RID: 61600 RVA: 0x0046B61D File Offset: 0x0046981D
	static ParallelPackageController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ParallelPackageController.CreateStaticDefaultValue), new Action(ParallelPackageController.ResetStaticDefaultValue));
	}

	// Token: 0x040087E8 RID: 34792
	public bool GmTest;

	// Token: 0x040087E9 RID: 34793
	[Nullable(2)]
	private ParallelPackageConfig Config;

	// Token: 0x040087EA RID: 34794
	private bool CurrentLoginShowState;

	// Token: 0x040087EB RID: 34795
	[Nullable(2)]
	private static ParallelPackageController _Instance;
}
