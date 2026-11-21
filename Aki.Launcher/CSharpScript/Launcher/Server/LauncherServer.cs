using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Launcher.HotPatchKuroSdk;
using CSharpScript.Launcher.Platform.PlatformSdk;
using CSharpScript.Launcher.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Launcher.Server
{
	// Token: 0x02000113 RID: 275
	[NullableContext(1)]
	[Nullable(0)]
	public class LauncherServer : Singleton
	{
		// Token: 0x060008D3 RID: 2259 RVA: 0x00042024 File Offset: 0x00040224
		public void PingAllRegion()
		{
			if (!HotPatchKuroSdk.Instance.CanUseSdk() || !HotPatchKuroSdk.Instance.GetIfGlobalSdk())
			{
				return;
			}
			List<ILoginServersData> loginServersByClientRegion = this.GetLoginServersByClientRegion();
			for (int i = 0; i < loginServersByClientRegion.Count; i++)
			{
				ILoginServersData key = loginServersByClientRegion[i];
				this.RegionPingMap[key] = 9999;
			}
			this.CurrentPingCount = 0;
			FPingCallExDelegate fpingCallExDelegate = DelegateUtils.ToManualReleaseDelegate<FPingCallExDelegate>(new Action<string, float, int>(this.IcmpCallBack));
			this.IcmpPingCallBack = new Action<string, float, int>(this.IcmpCallBack);
			for (int j = 0; j < loginServersByClientRegion.Count; j++)
			{
				ILoginServersData loginServersData = loginServersByClientRegion[j];
				LauncherLog instance = LauncherLog.Instance;
				string message = "尝试ping";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ipAddress", loginServersData.PingUrl);
				instance.Debug(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				UKuroStaticLibrary.IcmpPing(loginServersData.PingUrl, 2f, fpingCallExDelegate);
			}
		}

		// Token: 0x060008D4 RID: 2260 RVA: 0x00042104 File Offset: 0x00040304
		private unsafe void IcmpCallBack(string ipAddress, float time, int responseState)
		{
			List<ILoginServersData> list = new List<ILoginServersData>(this.RegionPingMap.Keys);
			int count = list.Count;
			for (int i = 0; i < count; i++)
			{
				if (list[i].PingUrl == ipAddress)
				{
					LauncherLog instance = LauncherLog.Instance;
					string message = "RefreshIpPing";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Region", list[i].Region);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("time", time * 1000f);
					instance.Debug(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					this.RegionPingMap[list[i]] = (int)(time * 1000f);
					break;
				}
			}
			this.CurrentPingCount++;
			if (this.CurrentPingCount == list.Count)
			{
				DelegateUtils.ReleaseManualReleaseDelegate(new Action<string, float, int>(this.IcmpCallBack));
				this.IcmpPingCallBack = null;
			}
			LauncherLog instance2 = LauncherLog.Instance;
			string message2 = "IcmpCallBack";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("ipAddress", ipAddress);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("time", time);
			instance2.Debug(message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
		}

		// Token: 0x060008D5 RID: 2261 RVA: 0x00042264 File Offset: 0x00040464
		public List<ILoginServersData> GetLoginServersByClientRegion()
		{
			if (this.LoginServerData != null)
			{
				return this.LoginServerData;
			}
			List<ILoginServersData> loginServers = BaseConfigController.Instance.GetLoginServers();
			if (PlatformSdkManagerNew.Instance.GetPlatformSdk().BlockServerArea())
			{
				List<ILoginServersData> list = new List<ILoginServersData>();
				string sdkCountry = PlatformSdkManagerNew.Instance.GetPlatformSdk().GetSdkCountry();
				LauncherLog instance = LauncherLog.Instance;
				string message = "锁区";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("currentCountryCode", sdkCountry);
				instance.Info(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				if (loginServers != null)
				{
					for (int i = 0; i < loginServers.Count; i++)
					{
						ILoginServersData loginServersData = loginServers[i];
						if (loginServersData.Region != null && loginServersData.Region.Length != 0)
						{
							string[] serverLimitConfig = LauncherServerDefine.Instance.GetServerLimitConfig(loginServersData.Region);
							if (serverLimitConfig != null && serverLimitConfig.Length != 0 && sdkCountry != null && sdkCountry.Length > 0)
							{
								bool flag = false;
								for (int j = 0; j < serverLimitConfig.Length; j++)
								{
									if (serverLimitConfig[j] == sdkCountry)
									{
										flag = true;
										break;
									}
								}
								if (flag)
								{
									list.Add(loginServersData);
								}
							}
						}
					}
				}
				if (list.Count == 0 && loginServers != null)
				{
					for (int k = 0; k < loginServers.Count; k++)
					{
						ILoginServersData loginServersData2 = loginServers[k];
						if (loginServersData2.Region == "SEA")
						{
							list.Add(loginServersData2);
							break;
						}
					}
				}
				this.LoginServerData = list;
				return this.LoginServerData;
			}
			this.LoginServerData = ((loginServers != null) ? new List<ILoginServersData>(loginServers) : new List<ILoginServersData>());
			return this.LoginServerData;
		}

		// Token: 0x060008D6 RID: 2262 RVA: 0x000423E8 File Offset: 0x000405E8
		public void RequestLoginPlayerInfo(ELoginGetPlayerInfoEnum loginType, string userId, string userName, string token, [Nullable(new byte[]
		{
			1,
			2
		})] Action<LoginPlayerInfo> callBack, int currentTryCount = 0)
		{
			if (this.CacheLauncherServerGarMap.ContainsKey((int)loginType))
			{
				callBack(this.CacheLauncherServerGarMap[(int)loginType]);
				return;
			}
			string currentArea = this.GetCurrentArea();
			string garurl = this.GetGARUrl((int)loginType, userId, userName, token, currentArea);
			if (garurl == null)
			{
				LauncherLog.Instance.Info("GetGARUrl is null", default(ReadOnlySpan<ValueTuple<string, object>>));
				callBack(null);
				return;
			}
			LauncherLog instance = LauncherLog.Instance;
			string message = "GetLoginPlayerInfo";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("url", garurl);
			instance.Info(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.RequestGARInfo(loginType, userId, userName, token, currentArea, garurl, callBack, currentTryCount).Forget();
		}

		// Token: 0x060008D7 RID: 2263 RVA: 0x00042488 File Offset: 0x00040688
		public string GetCurrentArea()
		{
			string[] array = UKuroStaticLibrary.GetCultureRegion().Split('-', StringSplitOptions.None);
			int num = array.Length;
			if (num <= 1)
			{
				return "US";
			}
			if (array[num - 1].Length != 0)
			{
				return array[num - 1];
			}
			return "US";
		}

		// Token: 0x060008D8 RID: 2264 RVA: 0x000424C8 File Offset: 0x000406C8
		private UniTask RequestGARInfo(ELoginGetPlayerInfoEnum loginType, string userId, string userName, string token, string area, string url, [Nullable(new byte[]
		{
			1,
			2
		})] Action<LoginPlayerInfo> callBack, int currentTryCount)
		{
			LauncherServer.<RequestGARInfo>d__10 <RequestGARInfo>d__;
			<RequestGARInfo>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RequestGARInfo>d__.<>4__this = this;
			<RequestGARInfo>d__.loginType = loginType;
			<RequestGARInfo>d__.userId = userId;
			<RequestGARInfo>d__.userName = userName;
			<RequestGARInfo>d__.token = token;
			<RequestGARInfo>d__.area = area;
			<RequestGARInfo>d__.url = url;
			<RequestGARInfo>d__.callBack = callBack;
			<RequestGARInfo>d__.currentTryCount = currentTryCount;
			<RequestGARInfo>d__.<>1__state = -1;
			<RequestGARInfo>d__.<>t__builder.Start<LauncherServer.<RequestGARInfo>d__10>(ref <RequestGARInfo>d__);
			return <RequestGARInfo>d__.<>t__builder.Task;
		}

		// Token: 0x060008D9 RID: 2265 RVA: 0x00042550 File Offset: 0x00040750
		[return: Nullable(2)]
		private string GetGARUrl(int loginType, string userId, string userName, string token, string area)
		{
			string garurl = BaseConfigController.Instance.GetGARUrl();
			if (garurl == null)
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

		// Token: 0x060008DA RID: 2266 RVA: 0x000425EC File Offset: 0x000407EC
		public void RequestSuggestServerData(string userId, string userName, string token, Action<ILoginServersData> callBack)
		{
			if (!HotPatchKuroSdk.Instance.GetIfGlobalSdk())
			{
				ILoginServersData loginServersData = this.GetLoginServersByClientRegion()[0];
				this.CacheSuggestLoginServerData[userId] = loginServersData;
				callBack(loginServersData);
				return;
			}
			this.RequestLoginPlayerInfo(ELoginGetPlayerInfoEnum.SdkMode, userId, userName, token, delegate(LoginPlayerInfo data)
			{
				ILoginServersData loginServersData2 = this.GetSuggestServerData(userId, data);
				if (loginServersData2 == null)
				{
					List<ILoginServersData> loginServersByClientRegion = this.GetLoginServersByClientRegion();
					LauncherLog.Instance.Debug("没有找到推荐服务器，使用默认服务器", default(ReadOnlySpan<ValueTuple<string, object>>));
					loginServersData2 = loginServersByClientRegion[0];
				}
				this.CacheSuggestLoginServerData[userId] = loginServersData2;
				callBack(loginServersData2);
			}, 0);
		}

		// Token: 0x060008DB RID: 2267 RVA: 0x0004266C File Offset: 0x0004086C
		[NullableContext(2)]
		private ILoginServersData GetSuggestServerData([Nullable(1)] string sdkUid, LoginPlayerInfo playerLoginData)
		{
			List<ILoginServersData> list = new List<ILoginServersData>(this.RegionPingMap.Keys);
			int count = list.Count;
			LauncherLog.Instance.Debug("GetSuggestServerData", default(ReadOnlySpan<ValueTuple<string, object>>));
			if (playerLoginData != null)
			{
				string text = "";
				if (playerLoginData.UserInfos != null && playerLoginData.UserInfos.Count > 0)
				{
					long lastOnlineTime = playerLoginData.UserInfos[0].LastOnlineTime;
					text = playerLoginData.UserInfos[0].Region;
					int count2 = playerLoginData.UserInfos.Count;
					for (int i = 0; i < count2; i++)
					{
						if (playerLoginData.UserInfos[i].LastOnlineTime > lastOnlineTime)
						{
							text = playerLoginData.UserInfos[i].Region;
							lastOnlineTime = playerLoginData.UserInfos[i].LastOnlineTime;
						}
					}
				}
				if (text != null && text.Length > 0)
				{
					ILoginServersData loginServersData = this.FindRegionData(text);
					if (loginServersData != null)
					{
						LauncherLog instance = LauncherLog.Instance;
						string message = "recommendRegion";
						ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("recommendRegion", text);
						instance.Debug(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
						return loginServersData;
					}
				}
				string recommendRegion = playerLoginData.RecommendRegion;
				int j = 0;
				while (j < count)
				{
					if (list[j].Region == recommendRegion)
					{
						if (this.CheckIfAllServerPingHigh())
						{
							LauncherLog instance2 = LauncherLog.Instance;
							string message2 = "PingHigh";
							ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>(list[j].Region, list[j].ip);
							instance2.Debug(message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
							return list[j];
						}
						int num;
						if (this.RegionPingMap.TryGetValue(list[j], out num) && num > 100)
						{
							LauncherLog.Instance.Debug("this.RegionPingMap.get(keys[i]) > 100", default(ReadOnlySpan<ValueTuple<string, object>>));
							return this.FindRegionData(this.GetPingMiniRegion("America"));
						}
						LauncherLog.Instance.Debug("返回推荐", default(ReadOnlySpan<ValueTuple<string, object>>));
						return list[j];
					}
					else
					{
						j++;
					}
				}
				return this.FindRegionData(this.GetPingMiniRegion("America"));
			}
			string text2 = this.LastTimeLoginRegion(sdkUid);
			if (text2 != null)
			{
				LauncherLog instance3 = LauncherLog.Instance;
				string message3 = "没有服务器信息拿本地登录信息";
				ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("data", text2);
				instance3.Debug(message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
				return this.FindRegionData(text2);
			}
			LauncherLog.Instance.Debug("没有拿到服务器推荐返回低Ping", default(ReadOnlySpan<ValueTuple<string, object>>));
			return this.FindRegionData(this.GetPingMiniRegion("America"));
		}

		// Token: 0x060008DC RID: 2268 RVA: 0x000428F0 File Offset: 0x00040AF0
		[return: Nullable(2)]
		private unsafe string LastTimeLoginRegion(string sdkUid)
		{
			Dictionary<string, string> global = LauncherStorageLib.Instance.GetGlobal<Dictionary<string, string>>(ELauncherStorageGlobalKey.SdkLastTimeLoginRegion, null);
			if (global != null && global.ContainsKey(sdkUid))
			{
				LauncherLog instance = LauncherLog.Instance;
				string message = "LastTimeLoginData";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("sdkId", sdkUid);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("result?.get(sdkUid).Region", global[sdkUid]);
				instance.Debug(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return global[sdkUid];
			}
			return null;
		}

		// Token: 0x060008DD RID: 2269 RVA: 0x00042978 File Offset: 0x00040B78
		public void SaveLoginRegion(string sdkUid, string region)
		{
			Dictionary<string, string> global = LauncherStorageLib.Instance.GetGlobal<Dictionary<string, string>>(ELauncherStorageGlobalKey.SdkLastTimeLoginRegion, null);
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			if (global != null)
			{
				foreach (KeyValuePair<string, string> keyValuePair in global)
				{
					dictionary[keyValuePair.Key] = keyValuePair.Value;
				}
			}
			dictionary[sdkUid] = region;
			LauncherStorageLib.Instance.SetGlobal<Dictionary<string, string>>(ELauncherStorageGlobalKey.SdkLastTimeLoginRegion, dictionary);
		}

		// Token: 0x060008DE RID: 2270 RVA: 0x00042A00 File Offset: 0x00040C00
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

		// Token: 0x060008DF RID: 2271 RVA: 0x00042A50 File Offset: 0x00040C50
		private bool CheckIfAllServerPingHigh()
		{
			List<ILoginServersData> list = new List<ILoginServersData>(this.RegionPingMap.Keys);
			int count = list.Count;
			for (int i = 0; i < count; i++)
			{
				int num;
				if (this.RegionPingMap.TryGetValue(list[i], out num) && num < 100)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060008E0 RID: 2272 RVA: 0x00042AA0 File Offset: 0x00040CA0
		private string GetPingMiniRegion(string defaultServerRegion)
		{
			List<ILoginServersData> list = new List<ILoginServersData>(this.RegionPingMap.Keys);
			int count = list.Count;
			int num = 9999;
			string text = "";
			for (int i = 0; i < count; i++)
			{
				LauncherLog instance = LauncherLog.Instance;
				string message = "区域ping";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ping", this.RegionPingMap[list[i]].ToString());
				instance.Debug(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				if (num > this.RegionPingMap[list[i]])
				{
					num = this.RegionPingMap[list[i]];
					text = list[i].Region;
					LauncherLog instance2 = LauncherLog.Instance;
					string message2 = "尝试选择低Ping";
					ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>(list[i].Region, num);
					instance2.Debug(message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				}
			}
			if (text == null || text.Length == 0)
			{
				LauncherLog.Instance.Debug("找不到低ping，用默认服务器", default(ReadOnlySpan<ValueTuple<string, object>>));
				text = defaultServerRegion;
			}
			return text;
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x060008E1 RID: 2273 RVA: 0x00042BB4 File Offset: 0x00040DB4
		public static LauncherServer Instance
		{
			get
			{
				if (LauncherServer._instance == null)
				{
					LauncherServer._instance = new LauncherServer();
					LauncherServer._instance.OnInit();
				}
				return LauncherServer._instance;
			}
		}

		// Token: 0x060008E2 RID: 2274 RVA: 0x00042BD7 File Offset: 0x00040DD7
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060008E3 RID: 2275 RVA: 0x00042BD9 File Offset: 0x00040DD9
		public static void ResetStaticDefaultValue()
		{
			LauncherServer instance = LauncherServer._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			LauncherServer._instance = null;
		}

		// Token: 0x060008E4 RID: 2276 RVA: 0x00042BF2 File Offset: 0x00040DF2
		static LauncherServer()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LauncherServer.CreateStaticDefaultValue), new Action(LauncherServer.ResetStaticDefaultValue));
		}

		// Token: 0x04000538 RID: 1336
		private readonly Dictionary<int, LoginPlayerInfo> CacheLauncherServerGarMap = new Dictionary<int, LoginPlayerInfo>();

		// Token: 0x04000539 RID: 1337
		private readonly Dictionary<ILoginServersData, int> RegionPingMap = new Dictionary<ILoginServersData, int>();

		// Token: 0x0400053A RID: 1338
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ILoginServersData> LoginServerData;

		// Token: 0x0400053B RID: 1339
		private int CurrentPingCount;

		// Token: 0x0400053C RID: 1340
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<string, float, int> IcmpPingCallBack;

		// Token: 0x0400053D RID: 1341
		public Dictionary<string, ILoginServersData> CacheSuggestLoginServerData = new Dictionary<string, ILoginServersData>();

		// Token: 0x0400053E RID: 1342
		[Nullable(2)]
		private static LauncherServer _instance;
	}
}
