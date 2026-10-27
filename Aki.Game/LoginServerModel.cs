using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common;
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Launcher.Platform.PlatformSdk;
using CSharpScript.Launcher.Server;
using UnrealEngine;

// Token: 0x020020A4 RID: 8356
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class LoginServerModel : ModelBase
{
	// Token: 0x060107AB RID: 67499 RVA: 0x00405EAC File Offset: 0x004040AC
	public string GetCurrentSelectPayServerName()
	{
		string text = BaseConfigController.Instance.GetPublicValue("SdkArea");
		if (text != "CN" && this.CurrentSelectServerData != null)
		{
			text = this.CurrentSelectServerData.Region;
		}
		else
		{
			text = "Default";
		}
		if (StringUtils.IsEmpty(text))
		{
			text = "Default";
		}
		return text;
	}

	// Token: 0x060107AC RID: 67500 RVA: 0x00405F04 File Offset: 0x00404104
	public string GetCurrentSelectServerIp()
	{
		if (!KuroSdkController.Instance.CanUseSdk() && !PlatformSdkManagerNew.Instance.IsSdkOn)
		{
			return LoginModel.Instance.GetServerIp() ?? string.Empty;
		}
		if (LoginController.Instance.IsGlobalSdkLoginMode())
		{
			if (this.CurrentSelectServerData == null)
			{
				return string.Empty;
			}
			return this.CurrentSelectServerData.ip;
		}
		else
		{
			List<ILoginServersData> loginServersByClientRegion = this.GetLoginServersByClientRegion();
			if (loginServersByClientRegion != null && loginServersByClientRegion.Count > 0)
			{
				return loginServersByClientRegion[0].ip;
			}
			Log.Instance.Info(ELogModule.Login, ELogAuthor.YZY, "当前没有服务器，请检查CDN配置", default(ReadOnlySpan<ValueTuple<string, object>>));
			return string.Empty;
		}
	}

	// Token: 0x060107AD RID: 67501 RVA: 0x00405FA4 File Offset: 0x004041A4
	public string GetCurrentSelectServerRegion()
	{
		if (LoginController.Instance.IsGlobalSdkLoginMode())
		{
			if (this.CurrentSelectServerData == null)
			{
				return string.Empty;
			}
			return this.CurrentSelectServerData.Region;
		}
		else
		{
			List<ILoginServersData> loginServersByClientRegion = this.GetLoginServersByClientRegion();
			if (loginServersByClientRegion != null && loginServersByClientRegion.Count > 0)
			{
				return loginServersByClientRegion[0].Region;
			}
			return string.Empty;
		}
	}

	// Token: 0x060107AE RID: 67502 RVA: 0x00405FFC File Offset: 0x004041FC
	public List<string> GetCurrentServerLoginUrl()
	{
		if (LoginController.Instance.IsGlobalSdkLoginMode())
		{
			if (this.CurrentSelectServerData == null)
			{
				return new List<string>();
			}
			return this.CurrentSelectServerData.LoginUrl;
		}
		else
		{
			List<ILoginServersData> loginServersByClientRegion = this.GetLoginServersByClientRegion();
			if (loginServersByClientRegion != null && loginServersByClientRegion.Count > 0)
			{
				return loginServersByClientRegion[0].LoginUrl;
			}
			Log.Instance.Info(ELogModule.Login, ELogAuthor.LRA, "当前没有服务器，请检查CDN配置", default(ReadOnlySpan<ValueTuple<string, object>>));
			return new List<string>();
		}
	}

	// Token: 0x060107AF RID: 67503 RVA: 0x00406070 File Offset: 0x00404270
	public string GetCurrentServerLoginUrlByIndex(int index)
	{
		List<string> currentServerLoginUrl = this.GetCurrentServerLoginUrl();
		if (currentServerLoginUrl == null || currentServerLoginUrl.Count <= 0)
		{
			Log.Instance.Info(ELogModule.Login, ELogAuthor.LRA, "没有可选的LoginUrl", default(ReadOnlySpan<ValueTuple<string, object>>));
			return string.Empty;
		}
		if (index >= currentServerLoginUrl.Count)
		{
			return currentServerLoginUrl[0];
		}
		return currentServerLoginUrl[index];
	}

	// Token: 0x060107B0 RID: 67504 RVA: 0x004060CC File Offset: 0x004042CC
	public string GetCurrentSelectServerName()
	{
		if (LoginController.Instance.IsGlobalSdkLoginMode())
		{
			if (this.CurrentSelectServerData == null)
			{
				return string.Empty;
			}
			return this.CurrentSelectServerData.name;
		}
		else
		{
			List<ILoginServersData> loginServersByClientRegion = this.GetLoginServersByClientRegion();
			if (loginServersByClientRegion != null && loginServersByClientRegion.Count > 0)
			{
				return loginServersByClientRegion[0].name;
			}
			Log.Instance.Info(ELogModule.Login, ELogAuthor.YZY, "当前没有服务器，请检查CDN配置", default(ReadOnlySpan<ValueTuple<string, object>>));
			return string.Empty;
		}
	}

	// Token: 0x060107B1 RID: 67505 RVA: 0x00406140 File Offset: 0x00404340
	public string GetCurrentLoginServerId()
	{
		if (!KuroSdkController.Instance.CanUseSdk() && !PlatformSdkManagerNew.Instance.IsSdkOn)
		{
			return LoginModel.Instance.GetServerId() ?? string.Empty;
		}
		if (LoginController.Instance.IsGlobalSdkLoginMode())
		{
			if (this.CurrentSelectServerData == null)
			{
				return "0";
			}
			return this.CurrentSelectServerData.id;
		}
		else
		{
			List<ILoginServersData> loginServersByClientRegion = this.GetLoginServersByClientRegion();
			if (loginServersByClientRegion != null && loginServersByClientRegion.Count > 0)
			{
				return loginServersByClientRegion[0].id;
			}
			Log.Instance.Info(ELogModule.Login, ELogAuthor.YZY, "当前没有服务器，请检查CDN配置", default(ReadOnlySpan<ValueTuple<string, object>>));
			return "0";
		}
	}

	// Token: 0x060107B2 RID: 67506 RVA: 0x004061E0 File Offset: 0x004043E0
	public List<ILoginServersData> GetLoginServersByClientRegion()
	{
		if (this.LoginServerData != null)
		{
			return this.LoginServerData;
		}
		List<ILoginServersData> list = BaseConfigController.Instance.GetLoginServers() ?? new List<ILoginServersData>();
		List<ILoginServersData> list2 = new List<ILoginServersData>();
		foreach (ILoginServersData loginServersData in list)
		{
			if (this.OnlyRegion != string.Empty)
			{
				if (loginServersData.Region == this.OnlyRegion)
				{
					list2.Add(loginServersData);
				}
			}
			else
			{
				list2.Add(loginServersData);
			}
		}
		if (PlatformSdkManagerNew.Instance.GetPlatformSdk().BlockServerArea())
		{
			this.LoginServerData = new List<ILoginServersData>();
			string sdkCountry = PlatformSdkManagerNew.Instance.GetPlatformSdk().GetSdkCountry();
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Login;
			ELogAuthor author = ELogAuthor.YZY;
			string message = "锁区";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("currentCountryCode", sdkCountry);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			foreach (ILoginServersData loginServersData2 in list2)
			{
				if (!string.IsNullOrEmpty(loginServersData2.Region))
				{
					ServerLimit? serverLimitConfig = LoginConfig.Instance.GetServerLimitConfig(loginServersData2.Region);
					if (serverLimitConfig != null && !string.IsNullOrEmpty(sdkCountry) && serverLimitConfig.Value.CountryCodes.Contains(sdkCountry))
					{
						this.LoginServerData.Add(loginServersData2);
					}
				}
			}
			if (this.LoginServerData.Count == 0)
			{
				foreach (ILoginServersData loginServersData3 in list2)
				{
					if (loginServersData3.Region == "SEA")
					{
						this.LoginServerData.Add(loginServersData3);
						break;
					}
				}
			}
			return this.LoginServerData;
		}
		this.LoginServerData = list2;
		return this.LoginServerData;
	}

	// Token: 0x060107B3 RID: 67507 RVA: 0x004063E8 File Offset: 0x004045E8
	public void SelectCurrentSelectServerByServerId(string serverIp, string serverId)
	{
		LoginModel.Instance.SetServerIp(serverIp, 1);
		List<ILoginServersData> loginServersByClientRegion = this.GetLoginServersByClientRegion();
		if (loginServersByClientRegion != null && loginServersByClientRegion.Count > 0)
		{
			foreach (ILoginServersData loginServersData in loginServersByClientRegion)
			{
				if (loginServersData.id == serverId)
				{
					this.CurrentSelectServerData = loginServersData;
					break;
				}
			}
		}
		LoginModel.Instance.SetServerId(serverId);
		LoginModel.Instance.SetServerName((this.CurrentSelectServerData != null) ? this.CurrentSelectServerData.name : string.Empty);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Login;
		ELogAuthor author = ELogAuthor.YZY;
		string message = "选择服务器";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("serverId", serverId);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x060107B4 RID: 67508 RVA: 0x004064BC File Offset: 0x004046BC
	public bool IsFirstLogin(string sdkUid)
	{
		Dictionary<string, RegionAndIpSt> global = LocalStorage.GetGlobal<Dictionary<string, RegionAndIpSt>>(ELocalStorageGlobalKey.SdkLastTimeLoginData, null);
		return global == null || !global.ContainsKey(sdkUid);
	}

	// Token: 0x060107B5 RID: 67509 RVA: 0x004064E4 File Offset: 0x004046E4
	[return: Nullable(2)]
	public RegionAndIpSt LastTimeLoginData(string sdkUid)
	{
		Dictionary<string, RegionAndIpSt> global = LocalStorage.GetGlobal<Dictionary<string, RegionAndIpSt>>(ELocalStorageGlobalKey.SdkLastTimeLoginData, null);
		if (global != null && global.ContainsKey(sdkUid))
		{
			return global.GetValueOrDefault(sdkUid);
		}
		return null;
	}

	// Token: 0x060107B6 RID: 67510 RVA: 0x00406510 File Offset: 0x00404710
	public void SaveFirstLogin(string sdkUid, ILoginServersData data)
	{
		Dictionary<string, RegionAndIpSt> global = LocalStorage.GetGlobal<Dictionary<string, RegionAndIpSt>>(ELocalStorageGlobalKey.SdkLastTimeLoginData, null);
		Dictionary<string, RegionAndIpSt> dictionary = new Dictionary<string, RegionAndIpSt>();
		if (global != null)
		{
			foreach (KeyValuePair<string, RegionAndIpSt> keyValuePair in global)
			{
				dictionary[keyValuePair.Key] = keyValuePair.Value;
			}
		}
		RegionAndIpSt regionAndIpSt = new RegionAndIpSt();
		regionAndIpSt.Phrase(data.Region, data.ip);
		dictionary[sdkUid] = regionAndIpSt;
		LocalStorage.SetGlobal<Dictionary<string, RegionAndIpSt>>(ELocalStorageGlobalKey.SdkLastTimeLoginData, dictionary);
	}

	// Token: 0x060107B7 RID: 67511 RVA: 0x004065A8 File Offset: 0x004047A8
	public void AddRegionPingValue(ILoginServersData data, float ping)
	{
		this.RegionPingMap[data] = ping;
	}

	// Token: 0x060107B8 RID: 67512 RVA: 0x004065B8 File Offset: 0x004047B8
	public void RefreshIpPing(string ipAddress, float time)
	{
		List<ILoginServersData> list = new List<ILoginServersData>(this.RegionPingMap.Keys);
		int count = list.Count;
		for (int i = 0; i < count; i++)
		{
			if (list[i].PingUrl == ipAddress)
			{
				this.RegionPingMap[list[i]] = time * 1000f;
			}
		}
	}

	// Token: 0x060107B9 RID: 67513 RVA: 0x00406618 File Offset: 0x00404818
	[return: Nullable(2)]
	public global::LoginPlayerInfo GetPlayerLoginInfo(string sdkUid)
	{
		global::LoginPlayerInfo result;
		if (this.CurrentLoginPlayerInfoMap.TryGetValue(sdkUid, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x060107BA RID: 67514 RVA: 0x00406638 File Offset: 0x00404838
	public void SetPlayerLoginInfo(string sdkUid, global::LoginPlayerInfo data)
	{
		this.CurrentLoginPlayerInfoMap[sdkUid] = data;
	}

	// Token: 0x060107BB RID: 67515 RVA: 0x00406648 File Offset: 0x00404848
	[return: Nullable(2)]
	private ILoginServersData FindRegionServerData(RegionAndIpSt data)
	{
		List<ILoginServersData> list = new List<ILoginServersData>(this.RegionPingMap.Keys);
		int count = list.Count;
		for (int i = 0; i < count; i++)
		{
			if (list[i].Region == data.Region)
			{
				return list[i];
			}
		}
		return null;
	}

	// Token: 0x060107BC RID: 67516 RVA: 0x0040669C File Offset: 0x0040489C
	public void InitSuggestData(string sdkUid, [Nullable(new byte[]
	{
		1,
		2
	})] Action<ILoginServersData> callBack)
	{
		if (LauncherServer.Instance.CacheSuggestLoginServerData.GetValueOrDefault(sdkUid) != null)
		{
			ILoginServersData valueOrDefault = LauncherServer.Instance.CacheSuggestLoginServerData.GetValueOrDefault(sdkUid);
			if (this.OnlyRegion == string.Empty || ((valueOrDefault != null) ? valueOrDefault.Region : null) == this.OnlyRegion)
			{
				this.CurrentSelectServerData = valueOrDefault;
				callBack(valueOrDefault);
				LauncherServer.Instance.CacheSuggestLoginServerData.Remove(sdkUid);
				this.OnBeginSuggestServerData = this.CurrentSelectServerData;
				return;
			}
			LauncherServer.Instance.CacheSuggestLoginServerData.Remove(sdkUid);
		}
		this.CurrentSelectServerData = null;
		if (this.OnlyRegion != string.Empty)
		{
			List<ILoginServersData> loginServersByClientRegion = this.GetLoginServersByClientRegion();
			if (loginServersByClientRegion != null && loginServersByClientRegion.Count > 0)
			{
				this.OnBeginSuggestServerData = loginServersByClientRegion[0];
				this.CurrentSelectServerData = loginServersByClientRegion[0];
			}
			if (callBack != null)
			{
				callBack(this.CurrentSelectServerData);
			}
			return;
		}
		RegionAndIpSt suggestServerData = this.GetSuggestServerData(sdkUid);
		this.CurrentSelectServerData = this.FindRegionServerData(suggestServerData);
		this.OnBeginSuggestServerData = this.CurrentSelectServerData;
		if (this.OnBeginSuggestServerData == null)
		{
			List<ILoginServersData> loginServersByClientRegion2 = this.GetLoginServersByClientRegion();
			if (loginServersByClientRegion2 != null && loginServersByClientRegion2.Count > 0)
			{
				this.OnBeginSuggestServerData = loginServersByClientRegion2[0];
				this.CurrentSelectServerData = loginServersByClientRegion2[0];
			}
		}
		if (callBack != null)
		{
			callBack(this.CurrentSelectServerData);
		}
	}

	// Token: 0x060107BD RID: 67517 RVA: 0x004067F0 File Offset: 0x004049F0
	private RegionAndIpSt GetSuggestServerData(string sdkUid)
	{
		List<ILoginServersData> list = new List<ILoginServersData>(this.RegionPingMap.Keys);
		int count = list.Count;
		global::LoginPlayerInfo playerLoginInfo = this.GetPlayerLoginInfo(sdkUid);
		if (playerLoginInfo != null)
		{
			string text = string.Empty;
			if (playerLoginInfo.UserInfos != null && playerLoginInfo.UserInfos.Count > 0)
			{
				int lastOnlineTime = playerLoginInfo.UserInfos[0].LastOnlineTime;
				text = playerLoginInfo.UserInfos[0].Region;
				int count2 = playerLoginInfo.UserInfos.Count;
				for (int i = 0; i < count2; i++)
				{
					if (playerLoginInfo.UserInfos[i].LastOnlineTime > lastOnlineTime)
					{
						text = playerLoginInfo.UserInfos[i].Region;
						lastOnlineTime = playerLoginInfo.UserInfos[i].LastOnlineTime;
					}
				}
			}
			if (text != string.Empty)
			{
				ILoginServersData loginServersData = this.FindRegionData(text);
				if (loginServersData != null)
				{
					RegionAndIpSt regionAndIpSt = new RegionAndIpSt();
					regionAndIpSt.Phrase(loginServersData.Region, loginServersData.ip);
					return regionAndIpSt;
				}
			}
			string recommendRegion = playerLoginInfo.RecommendRegion;
			int j = 0;
			while (j < count)
			{
				if (list[j].Region == recommendRegion)
				{
					if (this.CheckIfAllServerPingHigh())
					{
						RegionAndIpSt regionAndIpSt2 = new RegionAndIpSt();
						regionAndIpSt2.Phrase(list[j].Region, list[j].ip);
						return regionAndIpSt2;
					}
					float num = this.RegionPingMap[list[j]];
					if (num != 0f && num > 100f)
					{
						return this.GetPingMiniData("America");
					}
					RegionAndIpSt regionAndIpSt3 = new RegionAndIpSt();
					regionAndIpSt3.Phrase(list[j].Region, list[j].ip);
					return regionAndIpSt3;
				}
				else
				{
					j++;
				}
			}
			return this.GetPingMiniData("America");
		}
		RegionAndIpSt regionAndIpSt4 = this.LastTimeLoginData(sdkUid);
		if (regionAndIpSt4 != null)
		{
			return regionAndIpSt4;
		}
		return this.GetPingMiniData("America");
	}

	// Token: 0x060107BE RID: 67518 RVA: 0x004069DC File Offset: 0x00404BDC
	[return: Nullable(2)]
	private ILoginServersData FindRegionData(string region)
	{
		List<ILoginServersData> list = new List<ILoginServersData>(this.RegionPingMap.Keys);
		int count = list.Count;
		for (int i = 0; i < count; i++)
		{
			if (list[i].Region == region)
			{
				return list[i];
			}
		}
		return null;
	}

	// Token: 0x060107BF RID: 67519 RVA: 0x00406A2C File Offset: 0x00404C2C
	private bool CheckIfAllServerPingHigh()
	{
		List<ILoginServersData> list = new List<ILoginServersData>(this.RegionPingMap.Keys);
		int count = list.Count;
		for (int i = 0; i < count; i++)
		{
			float num = this.RegionPingMap[list[i]];
			if (num != 0f && num < 100f)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x060107C0 RID: 67520 RVA: 0x00406A84 File Offset: 0x00404C84
	private RegionAndIpSt GetPingMiniData(string defaultServerRegion)
	{
		List<ILoginServersData> list = new List<ILoginServersData>(this.RegionPingMap.Keys);
		int count = list.Count;
		float num = 9999f;
		string ip = string.Empty;
		RegionAndIpSt regionAndIpSt = new RegionAndIpSt();
		for (int i = 0; i < count; i++)
		{
			if (num > this.RegionPingMap[list[i]])
			{
				num = this.RegionPingMap[list[i]];
				regionAndIpSt.Phrase(list[i].Region, list[i].ip);
			}
			if (list[i].Region == defaultServerRegion)
			{
				ip = list[i].ip;
			}
		}
		if (StringUtils.IsEmpty(regionAndIpSt.Ip))
		{
			regionAndIpSt.Phrase(defaultServerRegion, ip);
		}
		return regionAndIpSt;
	}

	// Token: 0x060107C1 RID: 67521 RVA: 0x00406B54 File Offset: 0x00404D54
	public int GetLoginLevel(string sdkUid, string region)
	{
		global::LoginPlayerInfo playerLoginInfo = this.GetPlayerLoginInfo(sdkUid);
		if (playerLoginInfo != null)
		{
			int num = (playerLoginInfo.UserInfos != null) ? playerLoginInfo.UserInfos.Count : 0;
			for (int i = 0; i < num; i++)
			{
				if (playerLoginInfo.UserInfos[i] != null && playerLoginInfo.UserInfos[i].Region == region)
				{
					return playerLoginInfo.UserInfos[i].Level;
				}
			}
			return 0;
		}
		return this.GetLocalRegionLevel(sdkUid, region);
	}

	// Token: 0x060107C2 RID: 67522 RVA: 0x00406BD4 File Offset: 0x00404DD4
	private int GetLocalRegionLevel(string sdkUid, string region)
	{
		Dictionary<string, LocalPlayerIpLevelData[]> global = LocalStorage.GetGlobal<Dictionary<string, LocalPlayerIpLevelData[]>>(ELocalStorageGlobalKey.SdkLevelData, null);
		if (global != null && global.ContainsKey(sdkUid))
		{
			LocalPlayerIpLevelData[] valueOrDefault = global.GetValueOrDefault(sdkUid);
			int num = valueOrDefault.Length;
			for (int i = 0; i < num; i++)
			{
				if (valueOrDefault[i].Region == region)
				{
					return valueOrDefault[i].Level;
				}
			}
			return 0;
		}
		return 0;
	}

	// Token: 0x060107C3 RID: 67523 RVA: 0x00406C2C File Offset: 0x00404E2C
	public string GetCurrentArea()
	{
		string[] array = UKuroStaticLibrary.GetCultureRegion().Split('-', StringSplitOptions.None);
		int num = array.Length;
		if (num <= 1)
		{
			return "US";
		}
		if (!(array[num - 1] == string.Empty))
		{
			return array[num - 1];
		}
		return "US";
	}

	// Token: 0x060107C4 RID: 67524 RVA: 0x00406C74 File Offset: 0x00404E74
	public void SaveLocalRegionLevel(string sdkUid, string region, int level)
	{
		Dictionary<string, LocalPlayerIpLevelData[]> global = LocalStorage.GetGlobal<Dictionary<string, LocalPlayerIpLevelData[]>>(ELocalStorageGlobalKey.SdkLevelData, null);
		Dictionary<string, LocalPlayerIpLevelData[]> dictionary = new Dictionary<string, LocalPlayerIpLevelData[]>();
		if (global != null)
		{
			foreach (KeyValuePair<string, LocalPlayerIpLevelData[]> keyValuePair in global)
			{
				dictionary[keyValuePair.Key] = keyValuePair.Value;
			}
		}
		LocalPlayerIpLevelData[] array;
		if (!dictionary.TryGetValue(sdkUid, out array))
		{
			array = new LocalPlayerIpLevelData[0];
		}
		int num = array.Length;
		bool flag = false;
		for (int i = 0; i < num; i++)
		{
			if (array[i].Region == region)
			{
				array[i].Level = level;
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			array = new List<LocalPlayerIpLevelData>(array)
			{
				new LocalPlayerIpLevelData
				{
					Region = region,
					Level = level
				}
			}.ToArray();
		}
		dictionary[sdkUid] = array;
		LocalStorage.SetGlobal<Dictionary<string, LocalPlayerIpLevelData[]>>(ELocalStorageGlobalKey.SdkLevelData, dictionary);
	}

	// Token: 0x060107C5 RID: 67525 RVA: 0x00406D6C File Offset: 0x00404F6C
	public void SetOnlyRegion(string region)
	{
		this.OnlyRegion = region;
		this.LoginServerData = null;
		this.TrySetRegionState = true;
		Log instance = Log.Instance;
		ELogModule module = ELogModule.KuroSdk;
		ELogAuthor author = ELogAuthor.YZY;
		string message = "GetOnlyRegionInfo";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("region", region);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x060107C6 RID: 67526 RVA: 0x00406DB5 File Offset: 0x00404FB5
	public bool GetIfSetOnlyRegion()
	{
		return this.TrySetRegionState;
	}

	// Token: 0x17001459 RID: 5209
	// (get) Token: 0x060107C7 RID: 67527 RVA: 0x00406DBD File Offset: 0x00404FBD
	public static LoginServerModel Instance
	{
		get
		{
			return LoginServerModel._Instance;
		}
	}

	// Token: 0x060107C8 RID: 67528 RVA: 0x00406DC4 File Offset: 0x00404FC4
	public static LoginServerModel GetOrCreateInstance()
	{
		if (LoginServerModel._Instance == null)
		{
			LoginServerModel.CreateInstance();
		}
		return LoginServerModel._Instance;
	}

	// Token: 0x060107C9 RID: 67529 RVA: 0x00406DD8 File Offset: 0x00404FD8
	public static bool CreateInstance()
	{
		if (LoginServerModel._Instance != null)
		{
			return true;
		}
		LoginServerModel._Instance = new LoginServerModel();
		return true;
	}

	// Token: 0x060107CA RID: 67530 RVA: 0x00406DEE File Offset: 0x00404FEE
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060107CB RID: 67531 RVA: 0x00406DF0 File Offset: 0x00404FF0
	public static void ResetStaticDefaultValue()
	{
		LoginServerModel._Instance = null;
	}

	// Token: 0x060107CC RID: 67532 RVA: 0x00406DF8 File Offset: 0x00404FF8
	static LoginServerModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(LoginServerModel.CreateStaticDefaultValue), new Action(LoginServerModel.ResetStaticDefaultValue));
	}

	// Token: 0x040079E7 RID: 31207
	private const string DEFAULTSERVERREGION = "America";

	// Token: 0x040079E8 RID: 31208
	private const string SEASERVER = "SEA";

	// Token: 0x040079E9 RID: 31209
	private const string CNSERVERNAME = "Default";

	// Token: 0x040079EA RID: 31210
	public const int DEFAULTPING = 9999;

	// Token: 0x040079EB RID: 31211
	private readonly Dictionary<string, global::LoginPlayerInfo> CurrentLoginPlayerInfoMap = new Dictionary<string, global::LoginPlayerInfo>();

	// Token: 0x040079EC RID: 31212
	private readonly Dictionary<ILoginServersData, float> RegionPingMap = new Dictionary<ILoginServersData, float>();

	// Token: 0x040079ED RID: 31213
	[Nullable(2)]
	public ILoginServersData OnBeginSuggestServerData;

	// Token: 0x040079EE RID: 31214
	[Nullable(2)]
	public ILoginServersData CurrentSelectServerData;

	// Token: 0x040079EF RID: 31215
	[Nullable(2)]
	public ILoginServersData CurrentUiSelectSeverData;

	// Token: 0x040079F0 RID: 31216
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<ILoginServersData> LoginServerData;

	// Token: 0x040079F1 RID: 31217
	public string OnlyRegion = string.Empty;

	// Token: 0x040079F2 RID: 31218
	private bool TrySetRegionState;

	// Token: 0x040079F3 RID: 31219
	[Nullable(2)]
	private static LoginServerModel _Instance;
}
