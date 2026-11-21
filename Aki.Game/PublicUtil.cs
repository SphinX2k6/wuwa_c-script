using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using AkiClient.Game.Aki.Data.Parkour;
using CSharpScript.Core.Common;
using CSharpScript.Game.Define;
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Typing;
using UnrealEngine;

// Token: 0x02000257 RID: 599
[NullableContext(1)]
[Nullable(0)]
public class PublicUtil : Singleton
{
	// Token: 0x060024AC RID: 9388 RVA: 0x000E1C35 File Offset: 0x000DFE35
	public string GetConfigPath(string file)
	{
		return UKismetSystemLibrary.GetProjectDirectory() + file;
	}

	// Token: 0x060024AD RID: 9389 RVA: 0x000E1C44 File Offset: 0x000DFE44
	public bool IsInIpWhiteList([Nullable(new byte[]
	{
		2,
		1
	})] IReadOnlyList<string> whiteList)
	{
		if (whiteList == null)
		{
			return true;
		}
		if (whiteList.Count == 0)
		{
			return false;
		}
		TArray<string> inArr = new TArray<string>();
		UKuroStaticLibrary.GetLocalHostAddresses(ref inArr, false);
		string[] array = inArr.ToArray<string>();
		foreach (string b in whiteList)
		{
			string[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				if (array2[i] == b)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x060024AE RID: 9390 RVA: 0x000E1CD8 File Offset: 0x000DFED8
	public bool GetIfGlobalSdk()
	{
		return BaseConfigController.Instance.GetPublicValue("SdkArea") != "CN";
	}

	// Token: 0x060024AF RID: 9391 RVA: 0x000E1CF3 File Offset: 0x000DFEF3
	public string GetGameId()
	{
		if (this.GetIfGlobalSdk())
		{
			return "G153";
		}
		return "G152";
	}

	// Token: 0x060024B0 RID: 9392 RVA: 0x000E1D08 File Offset: 0x000DFF08
	[return: Nullable(2)]
	public string GetLoginNoticeUrl2(string gameId, string language, string serverId)
	{
		string noticeBaseUrl = this.GetNoticeBaseUrl();
		if (string.IsNullOrEmpty(noticeBaseUrl))
		{
			return null;
		}
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 4);
		defaultInterpolatedStringHandler.AppendFormatted(noticeBaseUrl);
		defaultInterpolatedStringHandler.AppendLiteral("/gm/loginNotice/");
		defaultInterpolatedStringHandler.AppendFormatted(gameId);
		defaultInterpolatedStringHandler.AppendLiteral("/");
		defaultInterpolatedStringHandler.AppendFormatted(serverId);
		defaultInterpolatedStringHandler.AppendLiteral("/");
		defaultInterpolatedStringHandler.AppendFormatted(language);
		defaultInterpolatedStringHandler.AppendLiteral(".json");
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x060024B1 RID: 9393 RVA: 0x000E1D88 File Offset: 0x000DFF88
	[return: Nullable(2)]
	public string GetMarqueeUrl2(string gameId, string serverId)
	{
		string noticeBaseUrl = this.GetNoticeBaseUrl();
		if (string.IsNullOrEmpty(noticeBaseUrl))
		{
			return null;
		}
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(34, 3);
		defaultInterpolatedStringHandler.AppendFormatted(noticeBaseUrl);
		defaultInterpolatedStringHandler.AppendLiteral("/gm/scrollTextNotice/");
		defaultInterpolatedStringHandler.AppendFormatted(gameId);
		defaultInterpolatedStringHandler.AppendLiteral("/");
		defaultInterpolatedStringHandler.AppendFormatted(serverId);
		defaultInterpolatedStringHandler.AppendLiteral("/notice.json");
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x060024B2 RID: 9394 RVA: 0x000E1DF4 File Offset: 0x000DFFF4
	[NullableContext(2)]
	public string GetLoginNoticeUrl()
	{
		string noticeBaseUrl = this.GetNoticeBaseUrl();
		if (string.IsNullOrEmpty(noticeBaseUrl))
		{
			return null;
		}
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 4);
		defaultInterpolatedStringHandler.AppendFormatted(noticeBaseUrl);
		defaultInterpolatedStringHandler.AppendLiteral("/");
		defaultInterpolatedStringHandler.AppendFormatted("com.kurogame.aki.internal");
		defaultInterpolatedStringHandler.AppendLiteral("/");
		defaultInterpolatedStringHandler.AppendFormatted(UKuroLauncherLibrary.GetAppVersion());
		defaultInterpolatedStringHandler.AppendLiteral("/");
		defaultInterpolatedStringHandler.AppendFormatted("LoginNotice.json");
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x060024B3 RID: 9395 RVA: 0x000E1E74 File Offset: 0x000E0074
	[NullableContext(2)]
	public string GetMarqueeUrl()
	{
		string noticeBaseUrl = this.GetNoticeBaseUrl();
		if (string.IsNullOrEmpty(noticeBaseUrl))
		{
			return null;
		}
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 4);
		defaultInterpolatedStringHandler.AppendFormatted(noticeBaseUrl);
		defaultInterpolatedStringHandler.AppendLiteral("/");
		defaultInterpolatedStringHandler.AppendFormatted("com.kurogame.aki.internal");
		defaultInterpolatedStringHandler.AppendLiteral("/");
		defaultInterpolatedStringHandler.AppendFormatted(UKuroLauncherLibrary.GetAppVersion());
		defaultInterpolatedStringHandler.AppendLiteral("/");
		defaultInterpolatedStringHandler.AppendFormatted("ScrollTextNotice.json");
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x060024B4 RID: 9396 RVA: 0x000E1EF4 File Offset: 0x000E00F4
	[NullableContext(2)]
	public string GetNoticeBaseUrl()
	{
		string noticeUrl = BaseConfigController.Instance.GetNoticeUrl();
		if (string.IsNullOrEmpty(noticeUrl))
		{
			if (!GlobalData.IsPlayInEditor)
			{
				string appReleaseType = KuroApplication.GetAppReleaseType();
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.PublicUtil;
				ELogAuthor author = ELogAuthor.ZJC;
				string message = "找不到cdn";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Apptype", appReleaseType);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return null;
		}
		return CdnServerDebugConfig.Instance.TryGetNoticeServerPrefixAddress(noticeUrl);
	}

	// Token: 0x060024B5 RID: 9397 RVA: 0x000E1F5C File Offset: 0x000E015C
	[return: Nullable(2)]
	public string GetGARUrl(int loginType, string userId, string userName, string token, string area)
	{
		string garurl = BaseConfigController.Instance.GetGARUrl();
		if (string.IsNullOrEmpty(garurl))
		{
			return null;
		}
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(65, 6);
		defaultInterpolatedStringHandler.AppendFormatted(garurl);
		defaultInterpolatedStringHandler.AppendLiteral("/UserRegion/GetUserInfo?loginType=");
		defaultInterpolatedStringHandler.AppendFormatted<int>(loginType);
		defaultInterpolatedStringHandler.AppendLiteral("&userId=");
		defaultInterpolatedStringHandler.AppendFormatted(userId);
		defaultInterpolatedStringHandler.AppendLiteral("&token=");
		defaultInterpolatedStringHandler.AppendFormatted(token);
		defaultInterpolatedStringHandler.AppendLiteral("&area=");
		defaultInterpolatedStringHandler.AppendFormatted(area);
		defaultInterpolatedStringHandler.AppendLiteral("&userName=");
		defaultInterpolatedStringHandler.AppendFormatted(userName);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x060024B6 RID: 9398 RVA: 0x000E2000 File Offset: 0x000E0200
	[NullableContext(2)]
	public string GetXboxRegionUrl()
	{
		string garurl = BaseConfigController.Instance.GetGARUrl();
		if (string.IsNullOrEmpty(garurl))
		{
			return null;
		}
		return garurl + "/UserRegion/GetXboxRegion";
	}

	// Token: 0x060024B7 RID: 9399 RVA: 0x000E2030 File Offset: 0x000E0230
	[NullableContext(2)]
	public string SetXboxRegionUrl()
	{
		string garurl = BaseConfigController.Instance.GetGARUrl();
		if (string.IsNullOrEmpty(garurl))
		{
			return null;
		}
		return garurl + "/UserRegion/SetXboxRegion";
	}

	// Token: 0x060024B8 RID: 9400 RVA: 0x000E2060 File Offset: 0x000E0260
	public string GetPublicInfo()
	{
		string stringConfig = ConfigCommonParamById.GetStringConfig("mail_question_key");
		int? id = PlayerInfoModel.Instance.GetId();
		string value = Uri.EscapeDataString(FunctionModel.Instance.GetPlayerName() ?? "");
		string serverId = LoginModel.Instance.GetServerId();
		SdkLoginConfig sdkLoginConfig = LoginModel.Instance.GetSdkLoginConfig();
		string text = ((sdkLoginConfig != null) ? sdkLoginConfig.Token : null) ?? "";
		string value2 = ((sdkLoginConfig != null) ? sdkLoginConfig.Uid : null) ?? "";
		double serverTime = TimeUtil.Instance.GetServerTime();
		text = UKuroStaticLibrary.Base64Encode(text);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(4, 5);
		defaultInterpolatedStringHandler.AppendFormatted<int?>(id);
		defaultInterpolatedStringHandler.AppendLiteral(";");
		defaultInterpolatedStringHandler.AppendFormatted(serverId);
		defaultInterpolatedStringHandler.AppendLiteral(";");
		defaultInterpolatedStringHandler.AppendFormatted(text);
		defaultInterpolatedStringHandler.AppendLiteral(";");
		defaultInterpolatedStringHandler.AppendFormatted<double>(serverTime);
		defaultInterpolatedStringHandler.AppendLiteral(";");
		defaultInterpolatedStringHandler.AppendFormatted(stringConfig);
		string text2 = defaultInterpolatedStringHandler.ToStringAndClear();
		text2 = UKuroStaticLibrary.HashStringWithSHA1(text2);
		string value3 = (!string.IsNullOrEmpty(this.OverridePackageId)) ? this.OverridePackageId : KuroSdkController.Instance.GetPackageId();
		string channelId = KuroSdkController.Instance.GetChannelId();
		defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(84, 9);
		defaultInterpolatedStringHandler.AppendLiteral("playerId=");
		defaultInterpolatedStringHandler.AppendFormatted<int?>(id);
		defaultInterpolatedStringHandler.AppendLiteral("&playerName=");
		defaultInterpolatedStringHandler.AppendFormatted(value);
		defaultInterpolatedStringHandler.AppendLiteral("&serverId=");
		defaultInterpolatedStringHandler.AppendFormatted(serverId);
		defaultInterpolatedStringHandler.AppendLiteral("&token=");
		defaultInterpolatedStringHandler.AppendFormatted(text);
		defaultInterpolatedStringHandler.AppendLiteral("&timestamp=");
		defaultInterpolatedStringHandler.AppendFormatted<double>(serverTime);
		defaultInterpolatedStringHandler.AppendLiteral("&sign=");
		defaultInterpolatedStringHandler.AppendFormatted(text2);
		defaultInterpolatedStringHandler.AppendLiteral("&playerUid=");
		defaultInterpolatedStringHandler.AppendFormatted(value2);
		defaultInterpolatedStringHandler.AppendLiteral("&pkgId=");
		defaultInterpolatedStringHandler.AppendFormatted(value3);
		defaultInterpolatedStringHandler.AppendLiteral("&channelId=");
		defaultInterpolatedStringHandler.AppendFormatted(channelId);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x060024B9 RID: 9401 RVA: 0x000E2264 File Offset: 0x000E0464
	[return: Nullable(2)]
	public string GetExternalUrl(string rootUrl, PublicUtil.EExternalUrlReason reason)
	{
		global::Log instance = global::Log.Instance;
		ELogModule module = ELogModule.PublicUtil;
		ELogAuthor author = ELogAuthor.ZJC;
		string message = "GetExternalUrl";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("rootUrl", rootUrl);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		if (string.IsNullOrEmpty(rootUrl) || string.IsNullOrWhiteSpace(rootUrl))
		{
			return null;
		}
		string publicInfo = this.GetPublicInfo();
		switch (reason)
		{
		case PublicUtil.EExternalUrlReason.Mail:
		{
			string channelId = KuroSdkController.Instance.GetChannelId();
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 3);
			defaultInterpolatedStringHandler.AppendFormatted(rootUrl);
			defaultInterpolatedStringHandler.AppendLiteral("?");
			defaultInterpolatedStringHandler.AppendFormatted(publicInfo);
			defaultInterpolatedStringHandler.AppendLiteral("&channelId=");
			defaultInterpolatedStringHandler.AppendFormatted(channelId);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}
		case PublicUtil.EExternalUrlReason.InviteNewbie:
			return this.AppendPublicInfo(rootUrl, reason);
		case PublicUtil.EExternalUrlReason.GameIntroduction:
		{
			string value = (!string.IsNullOrEmpty(this.OverridePackageId)) ? this.OverridePackageId : KuroSdkController.Instance.GetPackageId();
			string channelId = KuroSdkController.Instance.GetChannelId();
			string value2 = UKuroStaticLibrary.Base64Encode(publicInfo);
			string value3 = KuroSdkController.Instance.GetIfGlobalSdk() ? "global" : "cn";
			string value4 = "game";
			string packageLanguage = LanguageSystem.Instance.PackageLanguage;
			string platformStr = KuroSdkModel.Instance.GetPlatformStr();
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(67, 8);
			defaultInterpolatedStringHandler.AppendFormatted(rootUrl);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted(packageLanguage);
			defaultInterpolatedStringHandler.AppendLiteral("/?login_info=");
			defaultInterpolatedStringHandler.AppendFormatted(value2);
			defaultInterpolatedStringHandler.AppendLiteral("&packageId=");
			defaultInterpolatedStringHandler.AppendFormatted(value);
			defaultInterpolatedStringHandler.AppendLiteral("&channelId=");
			defaultInterpolatedStringHandler.AppendFormatted(channelId);
			defaultInterpolatedStringHandler.AppendLiteral("&svr_area=");
			defaultInterpolatedStringHandler.AppendFormatted(value3);
			defaultInterpolatedStringHandler.AppendLiteral("&entryType=");
			defaultInterpolatedStringHandler.AppendFormatted(value4);
			defaultInterpolatedStringHandler.AppendLiteral("&platform=");
			defaultInterpolatedStringHandler.AppendFormatted(platformStr);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}
		case PublicUtil.EExternalUrlReason.CommonH5:
			return this.AppendPublicInfo(rootUrl, reason);
		case PublicUtil.EExternalUrlReason.MailH5:
			return this.AppendPublicInfo(rootUrl, reason);
		default:
			return null;
		}
	}

	// Token: 0x060024BA RID: 9402 RVA: 0x000E2458 File Offset: 0x000E0658
	private string AppendPublicInfo(string rootUrl, PublicUtil.EExternalUrlReason reason)
	{
		string publicInfo = this.GetPublicInfo();
		string value = (!string.IsNullOrEmpty(this.OverridePackageId)) ? this.OverridePackageId : KuroSdkController.Instance.GetPackageId();
		string channelId = KuroSdkController.Instance.GetChannelId();
		string platformStr = KuroSdkModel.Instance.GetPlatformStr();
		string packageLanguage = LanguageSystem.Instance.PackageLanguage;
		string value2 = UKuroStaticLibrary.Base64Encode(publicInfo);
		string value3 = KuroSdkController.Instance.GetIfGlobalSdk() ? "global" : "cn";
		string value4 = "game";
		if (reason == PublicUtil.EExternalUrlReason.MailH5)
		{
			value4 = "mail";
		}
		string value5 = rootUrl.Contains("?") ? (rootUrl + "&") : (rootUrl + "?");
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(70, 8);
		defaultInterpolatedStringHandler.AppendFormatted(value5);
		defaultInterpolatedStringHandler.AppendLiteral("login_info=");
		defaultInterpolatedStringHandler.AppendFormatted(value2);
		defaultInterpolatedStringHandler.AppendLiteral("&packageId=");
		defaultInterpolatedStringHandler.AppendFormatted(value);
		defaultInterpolatedStringHandler.AppendLiteral("&channelId=");
		defaultInterpolatedStringHandler.AppendFormatted(channelId);
		defaultInterpolatedStringHandler.AppendLiteral("&platform=");
		defaultInterpolatedStringHandler.AppendFormatted(platformStr);
		defaultInterpolatedStringHandler.AppendLiteral("&lang=");
		defaultInterpolatedStringHandler.AppendFormatted(packageLanguage);
		defaultInterpolatedStringHandler.AppendLiteral("&entryType=");
		defaultInterpolatedStringHandler.AppendFormatted(value4);
		defaultInterpolatedStringHandler.AppendLiteral("&svr_area=");
		defaultInterpolatedStringHandler.AppendFormatted(value3);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x060024BB RID: 9403 RVA: 0x000E25B0 File Offset: 0x000E07B0
	public string GetExtendExternalUrl(string originUrl, bool isInternal = true)
	{
		if (string.IsNullOrWhiteSpace(originUrl))
		{
			return "";
		}
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(19, 2);
		defaultInterpolatedStringHandler.AppendFormatted(originUrl);
		defaultInterpolatedStringHandler.AppendLiteral("&isInternalBrowser=");
		defaultInterpolatedStringHandler.AppendFormatted<int>((isInternal > false) ? 1 : 0);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x060024BC RID: 9404 RVA: 0x000E25FC File Offset: 0x000E07FC
	public string GetLocalHost()
	{
		TArray<string> tarray = new TArray<string>();
		UKuroStaticLibrary.GetLocalHostAddresses(ref tarray, false);
		string result = "127.0.0.1";
		if (tarray.Num() > 0)
		{
			result = tarray.Get(0);
		}
		for (int i = 0; i < tarray.Num(); i++)
		{
			string text = tarray.Get(i);
			if (text.StartsWith("10.0."))
			{
				result = text;
			}
		}
		return result;
	}

	// Token: 0x060024BD RID: 9405 RVA: 0x000E2657 File Offset: 0x000E0857
	public string GetConfigTextByKey(string key)
	{
		return ConfigMultiTextLang.GetLocalTextNew(key, null) ?? key;
	}

	// Token: 0x060024BE RID: 9406 RVA: 0x000E2668 File Offset: 0x000E0868
	[NullableContext(2)]
	public string GetConfigTextByTable(ETableText type, int? id)
	{
		string configIdByTable = this.GetConfigIdByTable(type, id);
		return ConfigMultiTextLang.GetLocalTextNew(configIdByTable, null);
	}

	// Token: 0x060024BF RID: 9407 RVA: 0x000E2688 File Offset: 0x000E0888
	[NullableContext(2)]
	public string GetConfigTextByTable(ETableText type, string id)
	{
		string configIdByTable = this.GetConfigIdByTable(type, id);
		return ConfigMultiTextLang.GetLocalTextNew(configIdByTable, null);
	}

	// Token: 0x060024C0 RID: 9408 RVA: 0x000E26A8 File Offset: 0x000E08A8
	public string GetConfigIdByTable(ETableText type, int? id)
	{
		ValueTuple<string, string> valueTuple;
		if (!MultiTextDefine.tableTextMap.TryGetValue(type, out valueTuple))
		{
			return "";
		}
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 3);
		defaultInterpolatedStringHandler.AppendFormatted(valueTuple.Item1);
		defaultInterpolatedStringHandler.AppendFormatted<int?>(id);
		defaultInterpolatedStringHandler.AppendFormatted(valueTuple.Item2);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x060024C1 RID: 9409 RVA: 0x000E26FC File Offset: 0x000E08FC
	public string GetConfigIdByTable(ETableText type, [Nullable(2)] string id)
	{
		ValueTuple<string, string> valueTuple;
		if (!MultiTextDefine.tableTextMap.TryGetValue(type, out valueTuple))
		{
			return "";
		}
		return valueTuple.Item1 + id + valueTuple.Item2;
	}

	// Token: 0x060024C2 RID: 9410 RVA: 0x000E2730 File Offset: 0x000E0930
	[return: Nullable(2)]
	public string GetFlowConfigLocalText(string key)
	{
		return ConfigMultiTextLang.GetLocalTextNew(key, null);
	}

	// Token: 0x060024C3 RID: 9411 RVA: 0x000E2739 File Offset: 0x000E0939
	public void RegisterEditorLocalConfig(bool isReload = false)
	{
	}

	// Token: 0x060024C4 RID: 9412 RVA: 0x000E273C File Offset: 0x000E093C
	public void RegisterFlowTextLocalConfig(string configName)
	{
	}

	// Token: 0x060024C5 RID: 9413 RVA: 0x000E274C File Offset: 0x000E094C
	[return: Nullable(2)]
	public IFlowListInfo GetFlowListInfo(string flowListName)
	{
		return null;
	}

	// Token: 0x060024C6 RID: 9414 RVA: 0x000E275A File Offset: 0x000E095A
	[return: Nullable(2)]
	public SParkourConfig GetParkourConfig(string inConfigId)
	{
		return DataTableUtil.GetDataTableRowFromName<SParkourConfig>(EDataTable.Parkour, inConfigId);
	}

	// Token: 0x060024C7 RID: 9415 RVA: 0x000E2764 File Offset: 0x000E0964
	public bool IsUseTempData()
	{
		if (!GlobalData.IsPlayInEditor && !GlobalData.IsRunWithEditorStartConfig())
		{
			return false;
		}
		if (this.IsUseTemp == null)
		{
			this.GenerateEditorDebugServerConfig();
		}
		return this.IsUseTemp.GetValueOrDefault();
	}

	// Token: 0x060024C8 RID: 9416 RVA: 0x000E2794 File Offset: 0x000E0994
	public bool? IsStartEditorDebugServer()
	{
		if (!GlobalData.IsPlayInEditor && !GlobalData.IsRunWithEditorStartConfig())
		{
			return new bool?(false);
		}
		if (this.IsAutoStartDebugServer == null)
		{
			this.GenerateEditorDebugServerConfig();
		}
		return this.IsAutoStartDebugServer;
	}

	// Token: 0x060024C9 RID: 9417 RVA: 0x000E27C4 File Offset: 0x000E09C4
	public int? GetGameDebugPort()
	{
		if (!GlobalData.IsPlayInEditor && !GlobalData.IsRunWithEditorStartConfig())
		{
			return null;
		}
		if (this.GameDebugport == null)
		{
			this.GenerateEditorDebugServerConfig();
		}
		return this.GameDebugport;
	}

	// Token: 0x060024CA RID: 9418 RVA: 0x000E2804 File Offset: 0x000E0A04
	public int? GetEditorDebugPort()
	{
		if (!GlobalData.IsPlayInEditor && !GlobalData.IsRunWithEditorStartConfig())
		{
			return null;
		}
		if (this.EditorDebugPort == null)
		{
			this.GenerateEditorDebugServerConfig();
		}
		return this.EditorDebugPort;
	}

	// Token: 0x060024CB RID: 9419 RVA: 0x000E2844 File Offset: 0x000E0A44
	private void GenerateEditorDebugServerConfig()
	{
		string text = UBlueprintPathsLibrary.ProjectDir() + "../Config/Raw/Tables/k.可视化编辑/__Temp__/EditorStartConfig.json";
		if (!UBlueprintPathsLibrary.FileExists(text))
		{
			this.IsUseTemp = new bool?(false);
			return;
		}
		string text2 = "";
		if (!UKuroStaticLibrary.LoadFileToString(ref text2, text))
		{
			this.IsUseTemp = new bool?(false);
			return;
		}
		AdaptEditorSaveConfig adaptEditorSaveConfig = Json.Decode<AdaptEditorSaveConfig>(text2, null);
		if (adaptEditorSaveConfig == null)
		{
			this.IsUseTemp = new bool?(false);
			return;
		}
		this.IsUseTemp = new bool?(adaptEditorSaveConfig.UseTemp);
		this.IsAutoStartDebugServer = new bool?(adaptEditorSaveConfig.IsOpenDebugService);
		this.GameDebugport = new int?(adaptEditorSaveConfig.GameClientGmPort);
		this.EditorDebugPort = new int?(adaptEditorSaveConfig.EditorPort);
	}

	// Token: 0x060024CC RID: 9420 RVA: 0x000E28F0 File Offset: 0x000E0AF0
	[NullableContext(2)]
	public AdaptEditorConfig TestLoadEditorConfigData()
	{
		string text = UBlueprintPathsLibrary.ProjectConfigDir() + "../Saved/Editor/JsonConfig/EditorConfig.json";
		if (!UBlueprintPathsLibrary.FileExists(text))
		{
			return null;
		}
		string text2 = "";
		if (!UKuroStaticLibrary.LoadFileToString(ref text2, text))
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Temp;
			ELogAuthor author = ELogAuthor.CWZ;
			string message = "读取本地文件配置失败";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("path", text);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		AdaptEditorConfig adaptEditorConfig = Json.Decode<AdaptEditorConfig>(text2, null);
		if (adaptEditorConfig == null)
		{
			global::Log.Instance.Error(ELogModule.Temp, ELogAuthor.CWZ, "读取本地文件配置失败, 反序列化失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return null;
		}
		return adaptEditorConfig;
	}

	// Token: 0x060024CD RID: 9421 RVA: 0x000E297C File Offset: 0x000E0B7C
	[NullableContext(2)]
	public AdaptEditorConfig TestSaveEditorConfigData(AdaptEditorConfig data = null)
	{
		if (data == null)
		{
			return null;
		}
		string text = Json.Stringify(data, null);
		if (text == null)
		{
			global::Log.Instance.Error(ELogModule.Temp, ELogAuthor.CWZ, "IEditorConfig反序列化失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return data;
		}
		string fileName = UBlueprintPathsLibrary.ProjectConfigDir() + "../Saved/Editor/JsonConfig/EditorConfig.json";
		UKuroStaticLibrary.SaveStringToFile(text, fileName, false);
		return data;
	}

	// Token: 0x060024CE RID: 9422 RVA: 0x000E29D4 File Offset: 0x000E0BD4
	public void SetIsSilentLogin(bool value)
	{
		this.IsSilentLogin = value;
	}

	// Token: 0x060024CF RID: 9423 RVA: 0x000E29DD File Offset: 0x000E0BDD
	public bool GetIsSilentLogin()
	{
		return this.IsSilentLogin;
	}

	// Token: 0x060024D0 RID: 9424 RVA: 0x000E29E8 File Offset: 0x000E0BE8
	[NullableContext(2)]
	[return: Nullable(1)]
	public Transform CreateTransformFromConfig(IVector inPos = null, IVector inRot = null, IVector inScale = null)
	{
		Transform transform = Transform.Create();
		global::Vector location = global::Vector.Create((inPos != null) ? inPos.X : 0.0, (inPos != null) ? inPos.Y : 0.0, (inPos != null) ? inPos.Z : 0.0);
		Rotator rotator = Rotator.Create((float)((inRot != null) ? inRot.Y : 0.0), (float)((inRot != null) ? inRot.Z : 0.0), (float)((inRot != null) ? inRot.X : 0.0));
		global::Vector scale3D = global::Vector.Create((inScale != null) ? inScale.X : 0.0, (inScale != null) ? inScale.Y : 0.0, (inScale != null) ? inScale.Z : 0.0);
		transform.SetLocation(location);
		transform.SetRotation(rotator.Quaternion(null));
		transform.SetScale3D(scale3D);
		return transform;
	}

	// Token: 0x060024D1 RID: 9425 RVA: 0x000E2AE0 File Offset: 0x000E0CE0
	public List<string> GetFiles(string folderPath, [Nullable(2)] string containerStr)
	{
		TArray<string> filesRecursive = UKuroStaticLibrary.GetFilesRecursive(folderPath, "*.*", true, false);
		int num = filesRecursive.Num();
		List<string> list = new List<string>();
		for (int i = 0; i < num; i++)
		{
			string text = filesRecursive.Get(i);
			string fileNameWithoutExtension = this.GetFileNameWithoutExtension(text);
			if (string.IsNullOrEmpty(containerStr) || fileNameWithoutExtension.StartsWith(containerStr))
			{
				list.Add(text);
			}
		}
		return list;
	}

	// Token: 0x060024D2 RID: 9426 RVA: 0x000E2B42 File Offset: 0x000E0D42
	public string GetFileNameWithExtension(string file)
	{
		return UBlueprintPathsLibrary.GetCleanFilename(file);
	}

	// Token: 0x060024D3 RID: 9427 RVA: 0x000E2B4A File Offset: 0x000E0D4A
	public string GetFileNameWithoutExtension(string file)
	{
		return UBlueprintPathsLibrary.GetBaseFilename(file, true);
	}

	// Token: 0x170005B8 RID: 1464
	// (get) Token: 0x060024D4 RID: 9428 RVA: 0x000E2B53 File Offset: 0x000E0D53
	public static PublicUtil Instance
	{
		get
		{
			if (PublicUtil._instance == null)
			{
				PublicUtil._instance = new PublicUtil();
				PublicUtil._instance.OnInit();
			}
			return PublicUtil._instance;
		}
	}

	// Token: 0x060024D5 RID: 9429 RVA: 0x000E2B76 File Offset: 0x000E0D76
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060024D6 RID: 9430 RVA: 0x000E2B78 File Offset: 0x000E0D78
	public static void ResetStaticDefaultValue()
	{
		PublicUtil instance = PublicUtil._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		PublicUtil._instance = null;
	}

	// Token: 0x060024D7 RID: 9431 RVA: 0x000E2B91 File Offset: 0x000E0D91
	static PublicUtil()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PublicUtil.CreateStaticDefaultValue), new Action(PublicUtil.ResetStaticDefaultValue));
	}

	// Token: 0x04002436 RID: 9270
	private bool? IsUseTemp;

	// Token: 0x04002437 RID: 9271
	private bool? IsAutoStartDebugServer;

	// Token: 0x04002438 RID: 9272
	private int? EditorDebugPort;

	// Token: 0x04002439 RID: 9273
	private int? GameDebugport;

	// Token: 0x0400243A RID: 9274
	private readonly MultiTextCsvModule MultiTextCsvModule = new MultiTextCsvModule();

	// Token: 0x0400243B RID: 9275
	private const string PACKAGENAME = "com.kurogame.aki.internal";

	// Token: 0x0400243C RID: 9276
	private const string LOGIN_NOTICE = "LoginNotice.json";

	// Token: 0x0400243D RID: 9277
	private const string SCROLLTEXT_NOTICE = "ScrollTextNotice.json";

	// Token: 0x0400243E RID: 9278
	private bool IsSilentLogin;

	// Token: 0x0400243F RID: 9279
	public string OverridePackageId;

	// Token: 0x04002440 RID: 9280
	public const bool UseDbConfig = true;

	// Token: 0x04002441 RID: 9281
	[Nullable(2)]
	private static PublicUtil _instance;

	// Token: 0x020065D1 RID: 26065
	[NullableContext(0)]
	public enum EExternalUrlReason
	{
		// Token: 0x04021B5E RID: 138078
		Mail,
		// Token: 0x04021B5F RID: 138079
		InviteNewbie,
		// Token: 0x04021B60 RID: 138080
		GameIntroduction,
		// Token: 0x04021B61 RID: 138081
		CommonH5,
		// Token: 0x04021B62 RID: 138082
		MailH5
	}
}
