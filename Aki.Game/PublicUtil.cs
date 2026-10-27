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

// Token: 0x02000253 RID: 595
[NullableContext(1)]
[Nullable(0)]
public class PublicUtil : Singleton
{
	// Token: 0x060023F4 RID: 9204 RVA: 0x000DB6ED File Offset: 0x000D98ED
	public string GetConfigPath(string file)
	{
		return UKismetSystemLibrary.GetProjectDirectory() + file;
	}

	// Token: 0x060023F5 RID: 9205 RVA: 0x000DB6FC File Offset: 0x000D98FC
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

	// Token: 0x060023F6 RID: 9206 RVA: 0x000DB790 File Offset: 0x000D9990
	public bool GetIfGlobalSdk()
	{
		return BaseConfigController.Instance.GetPublicValue("SdkArea") != "CN";
	}

	// Token: 0x060023F7 RID: 9207 RVA: 0x000DB7AB File Offset: 0x000D99AB
	public string GetGameId()
	{
		if (this.GetIfGlobalSdk())
		{
			return "G153";
		}
		return "G152";
	}

	// Token: 0x060023F8 RID: 9208 RVA: 0x000DB7C0 File Offset: 0x000D99C0
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

	// Token: 0x060023F9 RID: 9209 RVA: 0x000DB840 File Offset: 0x000D9A40
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

	// Token: 0x060023FA RID: 9210 RVA: 0x000DB8AC File Offset: 0x000D9AAC
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

	// Token: 0x060023FB RID: 9211 RVA: 0x000DB92C File Offset: 0x000D9B2C
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

	// Token: 0x060023FC RID: 9212 RVA: 0x000DB9AC File Offset: 0x000D9BAC
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

	// Token: 0x060023FD RID: 9213 RVA: 0x000DBA14 File Offset: 0x000D9C14
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

	// Token: 0x060023FE RID: 9214 RVA: 0x000DBAB8 File Offset: 0x000D9CB8
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

	// Token: 0x060023FF RID: 9215 RVA: 0x000DBAE8 File Offset: 0x000D9CE8
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

	// Token: 0x06002400 RID: 9216 RVA: 0x000DBB18 File Offset: 0x000D9D18
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

	// Token: 0x06002401 RID: 9217 RVA: 0x000DBD1C File Offset: 0x000D9F1C
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

	// Token: 0x06002402 RID: 9218 RVA: 0x000DBF10 File Offset: 0x000DA110
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

	// Token: 0x06002403 RID: 9219 RVA: 0x000DC068 File Offset: 0x000DA268
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

	// Token: 0x06002404 RID: 9220 RVA: 0x000DC0B4 File Offset: 0x000DA2B4
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

	// Token: 0x06002405 RID: 9221 RVA: 0x000DC10F File Offset: 0x000DA30F
	public string GetConfigTextByKey(string key)
	{
		if (this.UseDbConfig())
		{
			return ConfigMultiTextLang.GetLocalTextNew(key, null) ?? key;
		}
		return MultiTextCsvModule.Instance.GetLocalText(key) ?? key;
	}

	// Token: 0x06002406 RID: 9222 RVA: 0x000DC138 File Offset: 0x000DA338
	[NullableContext(2)]
	public string GetConfigTextByTable(ETableText type, int? id)
	{
		string configIdByTable = this.GetConfigIdByTable(type, id);
		if (this.UseDbConfig())
		{
			return ConfigMultiTextLang.GetLocalTextNew(configIdByTable, null);
		}
		return MultiTextCsvModule.Instance.GetLocalText(configIdByTable);
	}

	// Token: 0x06002407 RID: 9223 RVA: 0x000DC16C File Offset: 0x000DA36C
	[NullableContext(2)]
	public string GetConfigTextByTable(ETableText type, string id)
	{
		string configIdByTable = this.GetConfigIdByTable(type, id);
		if (this.UseDbConfig())
		{
			return ConfigMultiTextLang.GetLocalTextNew(configIdByTable, null);
		}
		return MultiTextCsvModule.Instance.GetLocalText(configIdByTable);
	}

	// Token: 0x06002408 RID: 9224 RVA: 0x000DC1A0 File Offset: 0x000DA3A0
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

	// Token: 0x06002409 RID: 9225 RVA: 0x000DC1F4 File Offset: 0x000DA3F4
	public string GetConfigIdByTable(ETableText type, [Nullable(2)] string id)
	{
		ValueTuple<string, string> valueTuple;
		if (!MultiTextDefine.tableTextMap.TryGetValue(type, out valueTuple))
		{
			return "";
		}
		return valueTuple.Item1 + id + valueTuple.Item2;
	}

	// Token: 0x0600240A RID: 9226 RVA: 0x000DC228 File Offset: 0x000DA428
	[return: Nullable(2)]
	public string GetFlowConfigLocalText(string key)
	{
		if (this.UseDbConfig())
		{
			return ConfigMultiTextLang.GetLocalTextNew(key, null);
		}
		return MultiTextCsvModule.Instance.GetLocalText(key);
	}

	// Token: 0x0600240B RID: 9227 RVA: 0x000DC245 File Offset: 0x000DA445
	public void RegisterEditorLocalConfig(bool isReload = false)
	{
		if (this.UseDbConfig())
		{
			return;
		}
		MultiTextCsvModule.Instance.RegisterTextLocalConfig(this.GetConfigPath("../Config/Raw/Tables/k.可视化编辑/__Temp__/Csv/TidText.csv"), isReload);
	}

	// Token: 0x0600240C RID: 9228 RVA: 0x000DC268 File Offset: 0x000DA468
	public unsafe void RegisterFlowTextLocalConfig(string configName)
	{
		if (this.UseDbConfig())
		{
			return;
		}
		string text = UKismetSystemLibrary.GetProjectDirectory() + "../Config/Raw/Tables/w.文本库/剧情";
		string text2 = "文本库_" + configName + ".csv";
		TArray<string> filesRecursive = UKuroStaticLibrary.GetFilesRecursive(text, text2, true, false);
		if (filesRecursive.Num() == 0)
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.MultiTextCsvModule;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "无法找到对应文本库表格";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("文本库表格名字", text2);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("目录路径", text);
			instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		MultiTextCsvModule.Instance.RegisterTextLocalConfig(filesRecursive.Get(0), true);
	}

	// Token: 0x0600240D RID: 9229 RVA: 0x000DC31C File Offset: 0x000DA51C
	[return: Nullable(2)]
	public IFlowListInfo GetFlowListInfo(string flowListName)
	{
		if (this.UseDbConfig())
		{
			return null;
		}
		string text = null;
		TArray<string> filesRecursive = UKuroStaticLibrary.GetFilesRecursive(this.GetConfigPath("../Config/Raw/Tables/k.可视化编辑/j.剧情"), flowListName + ".json", true, false);
		if (filesRecursive.Num() == 0)
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Level;
			ELogAuthor author = ELogAuthor.YSQ;
			string message = "[ControllerHolder.PlotController.StartPlotNetwork] 无法找到对应剧情资源";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("flowListName", flowListName);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		string filename = filesRecursive.Get(0);
		UKuroStaticLibrary.LoadFileToString(ref text, filename);
		return Json.Decode<IFlowListInfo>(text, null);
	}

	// Token: 0x0600240E RID: 9230 RVA: 0x000DC39C File Offset: 0x000DA59C
	[return: Nullable(2)]
	public SParkourConfig GetParkourConfig(string inConfigId)
	{
		return DataTableUtil.GetDataTableRowFromName<SParkourConfig>(EDataTable.Parkour, inConfigId);
	}

	// Token: 0x0600240F RID: 9231 RVA: 0x000DC3A6 File Offset: 0x000DA5A6
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

	// Token: 0x06002410 RID: 9232 RVA: 0x000DC3D6 File Offset: 0x000DA5D6
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

	// Token: 0x06002411 RID: 9233 RVA: 0x000DC408 File Offset: 0x000DA608
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

	// Token: 0x06002412 RID: 9234 RVA: 0x000DC448 File Offset: 0x000DA648
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

	// Token: 0x06002413 RID: 9235 RVA: 0x000DC488 File Offset: 0x000DA688
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

	// Token: 0x06002414 RID: 9236 RVA: 0x000DC534 File Offset: 0x000DA734
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

	// Token: 0x06002415 RID: 9237 RVA: 0x000DC5C0 File Offset: 0x000DA7C0
	[NullableContext(2)]
	public AdaptEditorConfig TestSaveEditorConfigData(AdaptEditorConfig data = null)
	{
		if (data == null)
		{
			return null;
		}
		string text = Json.Stringify<AdaptEditorConfig>(data, null);
		if (text == null)
		{
			global::Log.Instance.Error(ELogModule.Temp, ELogAuthor.CWZ, "IEditorConfig反序列化失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return data;
		}
		string fileName = UBlueprintPathsLibrary.ProjectConfigDir() + "../Saved/Editor/JsonConfig/EditorConfig.json";
		UKuroStaticLibrary.SaveStringToFile(text, fileName, false);
		return data;
	}

	// Token: 0x06002416 RID: 9238 RVA: 0x000DC618 File Offset: 0x000DA818
	public bool UseDbConfig()
	{
		return !this.IsUseTempData();
	}

	// Token: 0x06002417 RID: 9239 RVA: 0x000DC623 File Offset: 0x000DA823
	public void SetIsSilentLogin(bool value)
	{
		this.IsSilentLogin = value;
	}

	// Token: 0x06002418 RID: 9240 RVA: 0x000DC62C File Offset: 0x000DA82C
	public bool GetIsSilentLogin()
	{
		return this.IsSilentLogin;
	}

	// Token: 0x06002419 RID: 9241 RVA: 0x000DC634 File Offset: 0x000DA834
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

	// Token: 0x0600241A RID: 9242 RVA: 0x000DC72C File Offset: 0x000DA92C
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

	// Token: 0x0600241B RID: 9243 RVA: 0x000DC78E File Offset: 0x000DA98E
	public string GetFileNameWithExtension(string file)
	{
		return UBlueprintPathsLibrary.GetCleanFilename(file);
	}

	// Token: 0x0600241C RID: 9244 RVA: 0x000DC796 File Offset: 0x000DA996
	public string GetFileNameWithoutExtension(string file)
	{
		return UBlueprintPathsLibrary.GetBaseFilename(file, true);
	}

	// Token: 0x17000591 RID: 1425
	// (get) Token: 0x0600241D RID: 9245 RVA: 0x000DC79F File Offset: 0x000DA99F
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

	// Token: 0x0600241E RID: 9246 RVA: 0x000DC7C2 File Offset: 0x000DA9C2
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600241F RID: 9247 RVA: 0x000DC7C4 File Offset: 0x000DA9C4
	public static void ResetStaticDefaultValue()
	{
		PublicUtil instance = PublicUtil._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		PublicUtil._instance = null;
	}

	// Token: 0x06002420 RID: 9248 RVA: 0x000DC7DD File Offset: 0x000DA9DD
	static PublicUtil()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PublicUtil.CreateStaticDefaultValue), new Action(PublicUtil.ResetStaticDefaultValue));
	}

	// Token: 0x040023B9 RID: 9145
	private bool? IsUseTemp;

	// Token: 0x040023BA RID: 9146
	private bool? IsAutoStartDebugServer;

	// Token: 0x040023BB RID: 9147
	private int? EditorDebugPort;

	// Token: 0x040023BC RID: 9148
	private int? GameDebugport;

	// Token: 0x040023BD RID: 9149
	private readonly MultiTextCsvModule MultiTextCsvModule = new MultiTextCsvModule();

	// Token: 0x040023BE RID: 9150
	private const string PACKAGENAME = "com.kurogame.aki.internal";

	// Token: 0x040023BF RID: 9151
	private const string LOGIN_NOTICE = "LoginNotice.json";

	// Token: 0x040023C0 RID: 9152
	private const string SCROLLTEXT_NOTICE = "ScrollTextNotice.json";

	// Token: 0x040023C1 RID: 9153
	private bool IsSilentLogin;

	// Token: 0x040023C2 RID: 9154
	public string OverridePackageId;

	// Token: 0x040023C3 RID: 9155
	[Nullable(2)]
	private static PublicUtil _instance;

	// Token: 0x02007440 RID: 29760
	[NullableContext(0)]
	public enum EExternalUrlReason
	{
		// Token: 0x04026820 RID: 157728
		Mail,
		// Token: 0x04026821 RID: 157729
		InviteNewbie,
		// Token: 0x04026822 RID: 157730
		GameIntroduction,
		// Token: 0x04026823 RID: 157731
		CommonH5,
		// Token: 0x04026824 RID: 157732
		MailH5
	}
}
