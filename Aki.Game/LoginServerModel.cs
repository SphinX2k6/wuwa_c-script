using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common;
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Launcher.Platform.PlatformSdk;
using CSharpScript.Launcher.Server;
using UnrealEngine;

// Token: 0x0200157B RID: 5499
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class LoginServerModel : ModelBase
{
	// Token: 0x0600DC19 RID: 56345 RVA: 0x004124C0 File Offset: 0x004106C0
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

	// Token: 0x0600DC1A RID: 56346 RVA: 0x00412518 File Offset: 0x00410718
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

	// Token: 0x0600DC1B RID: 56347 RVA: 0x004125B8 File Offset: 0x004107B8
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

	// Token: 0x0600DC1C RID: 56348 RVA: 0x00412610 File Offset: 0x00410810
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

	// Token: 0x0600DC1D RID: 56349 RVA: 0x00412684 File Offset: 0x00410884
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

	// Token: 0x0600DC1E RID: 56350 RVA: 0x004126E0 File Offset: 0x004108E0
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

	// Token: 0x0600DC1F RID: 56351 RVA: 0x00412754 File Offset: 0x00410954
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

	// Token: 0x0600DC20 RID: 56352 RVA: 0x004127F4 File Offset: 0x004109F4
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

	// Token: 0x0600DC21 RID: 56353 RVA: 0x004129FC File Offset: 0x00410BFC
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

	// Token: 0x0600DC22 RID: 56354 RVA: 0x00412AD0 File Offset: 0x00410CD0
	public bool IsFirstLogin(string sdkUid)
	{
		Dictionary<string, RegionAndIpSt> global = LocalStorage.GetGlobal<Dictionary<string, RegionAndIpSt>>(ELocalStorageGlobalKey.SdkLastTimeLoginData, null);
		return global == null || !global.ContainsKey(sdkUid);
	}

	// Token: 0x0600DC23 RID: 56355 RVA: 0x00412AF8 File Offset: 0x00410CF8
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

	// Token: 0x0600DC24 RID: 56356 RVA: 0x00412B24 File Offset: 0x00410D24
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

	// Token: 0x0600DC25 RID: 56357 RVA: 0x00412BBC File Offset: 0x00410DBC
	public void AddRegionPingValue(ILoginServersData data, float ping)
	{
		this.RegionPingMap[data] = ping;
	}

	// Token: 0x0600DC26 RID: 56358 RVA: 0x00412BCC File Offset: 0x00410DCC
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

	// Token: 0x0600DC27 RID: 56359 RVA: 0x00412C2C File Offset: 0x00410E2C
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

	// Token: 0x0600DC28 RID: 56360 RVA: 0x00412C4C File Offset: 0x00410E4C
	public void SetPlayerLoginInfo(string sdkUid, global::LoginPlayerInfo data)
	{
		this.CurrentLoginPlayerInfoMap[sdkUid] = data;
	}

	// Token: 0x0600DC29 RID: 56361 RVA: 0x00412C5C File Offset: 0x00410E5C
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

	// Token: 0x0600DC2A RID: 56362 RVA: 0x00412CB0 File Offset: 0x00410EB0
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

	// Token: 0x0600DC2B RID: 56363 RVA: 0x00412E04 File Offset: 0x00411004
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

	// Token: 0x0600DC2C RID: 56364 RVA: 0x00412FF0 File Offset: 0x004111F0
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

	// Token: 0x0600DC2D RID: 56365 RVA: 0x00413040 File Offset: 0x00411240
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

	// Token: 0x0600DC2E RID: 56366 RVA: 0x00413098 File Offset: 0x00411298
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

	// Token: 0x0600DC2F RID: 56367 RVA: 0x00413168 File Offset: 0x00411368
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

	// Token: 0x0600DC30 RID: 56368 RVA: 0x004131E8 File Offset: 0x004113E8
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

	// Token: 0x0600DC31 RID: 56369 RVA: 0x00413240 File Offset: 0x00411440
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

	// Token: 0x0600DC32 RID: 56370 RVA: 0x00413288 File Offset: 0x00411488
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

	// Token: 0x0600DC33 RID: 56371 RVA: 0x00413380 File Offset: 0x00411580
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

	// Token: 0x0600DC34 RID: 56372 RVA: 0x004133C9 File Offset: 0x004115C9
	public bool GetIfSetOnlyRegion()
	{
		return this.TrySetRegionState;
	}

	// Token: 0x17001486 RID: 5254
	// (get) Token: 0x0600DC35 RID: 56373 RVA: 0x004133D1 File Offset: 0x004115D1
	public static LoginServerModel Instance
	{
		get
		{
			return LoginServerModel._Instance;
		}
	}

	// Token: 0x0600DC36 RID: 56374 RVA: 0x004133D8 File Offset: 0x004115D8
	public static LoginServerModel GetOrCreateInstance()
	{
		if (LoginServerModel._Instance == null)
		{
			LoginServerModel.CreateInstance();
		}
		return LoginServerModel._Instance;
	}

	// Token: 0x0600DC37 RID: 56375 RVA: 0x004133EC File Offset: 0x004115EC
	public static bool CreateInstance()
	{
		if (LoginServerModel._Instance != null)
		{
			return true;
		}
		LoginServerModel._Instance = new LoginServerModel();
		return true;
	}

	// Token: 0x0600DC38 RID: 56376 RVA: 0x00413402 File Offset: 0x00411602
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600DC39 RID: 56377 RVA: 0x00413404 File Offset: 0x00411604
	public static void ResetStaticDefaultValue()
	{
		LoginServerModel._Instance = null;
	}

	// Token: 0x0600DC3A RID: 56378 RVA: 0x0041340C File Offset: 0x0041160C
	static LoginServerModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(LoginServerModel.CreateStaticDefaultValue), new Action(LoginServerModel.ResetStaticDefaultValue));
	}

	// Token: 0x04007AE5 RID: 31461
	private const string DEFAULTSERVERREGION = "America";

	// Token: 0x04007AE6 RID: 31462
	private const string SEASERVER = "SEA";

	// Token: 0x04007AE7 RID: 31463
	private const string CNSERVERNAME = "Default";

	// Token: 0x04007AE8 RID: 31464
	public const int DEFAULTPING = 9999;

	// Token: 0x04007AE9 RID: 31465
	private readonly Dictionary<string, global::LoginPlayerInfo> CurrentLoginPlayerInfoMap = new Dictionary<string, global::LoginPlayerInfo>();

	// Token: 0x04007AEA RID: 31466
	private readonly Dictionary<ILoginServersData, float> RegionPingMap = new Dictionary<ILoginServersData, float>();

	// Token: 0x04007AEB RID: 31467
	[Nullable(2)]
	public ILoginServersData OnBeginSuggestServerData;

	// Token: 0x04007AEC RID: 31468
	[Nullable(2)]
	public ILoginServersData CurrentSelectServerData;

	// Token: 0x04007AED RID: 31469
	[Nullable(2)]
	public ILoginServersData CurrentUiSelectSeverData;

	// Token: 0x04007AEE RID: 31470
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<ILoginServersData> LoginServerData;

	// Token: 0x04007AEF RID: 31471
	public string OnlyRegion = string.Empty;

	// Token: 0x04007AF0 RID: 31472
	private bool TrySetRegionState;

	// Token: 0x04007AF1 RID: 31473
	[Nullable(2)]
	private static LoginServerModel _Instance;
}
