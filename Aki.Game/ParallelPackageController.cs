using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common;
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Launcher.PackageUpdate;
using UnrealEngine;

// Token: 0x02002313 RID: 8979
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ParallelPackageController : ControllerBase
{
	// Token: 0x06011BDC RID: 72668 RVA: 0x0045DFBC File Offset: 0x0045C1BC
	protected override bool OnInit()
	{
		this.InitParallelPackageConfig();
		return true;
	}

	// Token: 0x06011BDD RID: 72669 RVA: 0x0045DFC5 File Offset: 0x0045C1C5
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

	// Token: 0x06011BDE RID: 72670 RVA: 0x0045E000 File Offset: 0x0045C200
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

	// Token: 0x06011BDF RID: 72671 RVA: 0x0045E050 File Offset: 0x0045C250
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

	// Token: 0x06011BE0 RID: 72672 RVA: 0x0045E0B0 File Offset: 0x0045C2B0
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

	// Token: 0x06011BE1 RID: 72673 RVA: 0x0045E15C File Offset: 0x0045C35C
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

	// Token: 0x06011BE2 RID: 72674 RVA: 0x0045E1AC File Offset: 0x0045C3AC
	private string GetCacheParallelPackageVersion()
	{
		string global = LocalStorage.GetGlobal<string>(ELocalStorageGlobalKey.ParallelPackageVersion, null);
		if (global == null)
		{
			return "";
		}
		return global;
	}

	// Token: 0x06011BE3 RID: 72675 RVA: 0x0045E1D0 File Offset: 0x0045C3D0
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

	// Token: 0x06011BE4 RID: 72676 RVA: 0x0045E210 File Offset: 0x0045C410
	public bool CheckParallelPackage()
	{
		if (!Info.Instance.IsMobilePlatform() || this.Config == null)
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

	// Token: 0x06011BE5 RID: 72677 RVA: 0x0045E28C File Offset: 0x0045C48C
	private string GetSplitAppVersion(string version)
	{
		string[] array = version.Split('.', StringSplitOptions.None);
		if (array.Length < 2)
		{
			return version;
		}
		return array[0] + "." + array[1];
	}

	// Token: 0x06011BE6 RID: 72678 RVA: 0x0045E2BC File Offset: 0x0045C4BC
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

	// Token: 0x06011BE7 RID: 72679 RVA: 0x0045E2F8 File Offset: 0x0045C4F8
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

	// Token: 0x06011BE8 RID: 72680 RVA: 0x0045E334 File Offset: 0x0045C534
	private string GetCurrentPlatformParallelPackageVersionText()
	{
		ParallelPackageUrlConfig currentPlatformParallelPackageVersion = this.GetCurrentPlatformParallelPackageVersion();
		if (currentPlatformParallelPackageVersion == null)
		{
			return "";
		}
		return currentPlatformParallelPackageVersion.parentVersion + "_" + currentPlatformParallelPackageVersion.childVersion;
	}

	// Token: 0x06011BE9 RID: 72681 RVA: 0x0045E368 File Offset: 0x0045C568
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

	// Token: 0x06011BEA RID: 72682 RVA: 0x0045E3F4 File Offset: 0x0045C5F4
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

	// Token: 0x170016B0 RID: 5808
	// (get) Token: 0x06011BEB RID: 72683 RVA: 0x0045E576 File Offset: 0x0045C776
	public static ParallelPackageController Instance
	{
		get
		{
			return ParallelPackageController._Instance;
		}
	}

	// Token: 0x06011BEC RID: 72684 RVA: 0x0045E57D File Offset: 0x0045C77D
	public static ParallelPackageController GetOrCreateInstance()
	{
		if (ParallelPackageController._Instance == null)
		{
			ParallelPackageController.CreateInstance();
		}
		return ParallelPackageController._Instance;
	}

	// Token: 0x06011BED RID: 72685 RVA: 0x0045E591 File Offset: 0x0045C791
	public static bool CreateInstance()
	{
		if (ParallelPackageController._Instance != null)
		{
			return true;
		}
		ParallelPackageController._Instance = new ParallelPackageController();
		return true;
	}

	// Token: 0x06011BEE RID: 72686 RVA: 0x0045E5A7 File Offset: 0x0045C7A7
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06011BEF RID: 72687 RVA: 0x0045E5A9 File Offset: 0x0045C7A9
	public static void ResetStaticDefaultValue()
	{
		ParallelPackageController._Instance = null;
	}

	// Token: 0x06011BF0 RID: 72688 RVA: 0x0045E5B1 File Offset: 0x0045C7B1
	static ParallelPackageController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ParallelPackageController.CreateStaticDefaultValue), new Action(ParallelPackageController.ResetStaticDefaultValue));
	}

	// Token: 0x040086A5 RID: 34469
	public bool GmTest;

	// Token: 0x040086A6 RID: 34470
	[Nullable(2)]
	private ParallelPackageConfig Config;

	// Token: 0x040086A7 RID: 34471
	private bool CurrentLoginShowState;

	// Token: 0x040086A8 RID: 34472
	[Nullable(2)]
	private static ParallelPackageController _Instance;
}
