using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using CSharpScript.Launcher.BaseConfig;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200209E RID: 8350
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class LoginServerController : UiControllerBase
{
	// Token: 0x06010795 RID: 67477 RVA: 0x004059BC File Offset: 0x00403BBC
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.WorldDoneAndCloseLoading, this.SaveFirstLogin);
		EventSystem.Instance.Add(EEventName.OnGetPlayerBasicInfo, this.OnGetBasicInfo);
		EventSystem.Instance.Add<int, int, int, int, int, int, int>(EEventName.OnPlayerLevelChanged, this.SaveServerLevel);
	}

	// Token: 0x06010796 RID: 67478 RVA: 0x00405A0C File Offset: 0x00403C0C
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.WorldDoneAndCloseLoading, this.SaveFirstLogin);
		EventSystem.Instance.Remove(EEventName.OnGetPlayerBasicInfo, this.OnGetBasicInfo);
		EventSystem.Instance.Remove<int, int, int, int, int, int, int>(EEventName.OnPlayerLevelChanged, this.SaveServerLevel);
	}

	// Token: 0x06010797 RID: 67479 RVA: 0x00405A5B File Offset: 0x00403C5B
	protected override bool OnInit()
	{
		this.IcmpPingCallBack = DelegateUtils.ToManualReleaseDelegate<FPingCallExDelegate>(this.IcmpCallBack);
		return true;
	}

	// Token: 0x06010798 RID: 67480 RVA: 0x00405A70 File Offset: 0x00403C70
	public void PingAllRegion()
	{
		if (!KuroSdkController.Instance.CanUseSdk() || !KuroSdkController.Instance.GetIfGlobalSdk())
		{
			return;
		}
		List<ILoginServersData> loginServersByClientRegion = LoginServerModel.Instance.GetLoginServersByClientRegion();
		foreach (ILoginServersData data in loginServersByClientRegion)
		{
			LoginServerModel.Instance.AddRegionPingValue(data, 9999f);
		}
		foreach (ILoginServersData loginServersData in loginServersByClientRegion)
		{
			UKuroStaticLibrary.IcmpPing(loginServersData.PingUrl, 2f, this.IcmpPingCallBack);
		}
	}

	// Token: 0x06010799 RID: 67481 RVA: 0x00405B38 File Offset: 0x00403D38
	public void PingGAR()
	{
		string garurl = BaseConfigController.Instance.GetGARUrl();
		if (!string.IsNullOrEmpty(garurl))
		{
			this.PingGARAsync(garurl).Forget();
		}
	}

	// Token: 0x0601079A RID: 67482 RVA: 0x00405B64 File Offset: 0x00403D64
	private UniTask PingGARAsync(string garUrl)
	{
		LoginServerController.<PingGARAsync>d__12 <PingGARAsync>d__;
		<PingGARAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PingGARAsync>d__.<>4__this = this;
		<PingGARAsync>d__.garUrl = garUrl;
		<PingGARAsync>d__.<>1__state = -1;
		<PingGARAsync>d__.<>t__builder.Start<LoginServerController.<PingGARAsync>d__12>(ref <PingGARAsync>d__);
		return <PingGARAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601079B RID: 67483 RVA: 0x00405BB0 File Offset: 0x00403DB0
	public void TryGetServerPlayerInfo()
	{
		if (LoginController.Instance.IsGlobalSdkLoginMode())
		{
			LoginServerController.ELoginGetPlayerInfoEnum loginType = LoginServerController.ELoginGetPlayerInfoEnum.SdkMode;
			SdkLoginConfig sdkLoginConfig = LoginModel.Instance.GetSdkLoginConfig();
			string userId = ((sdkLoginConfig != null) ? sdkLoginConfig.Uid : null) ?? "";
			SdkLoginConfig sdkLoginConfig2 = LoginModel.Instance.GetSdkLoginConfig();
			string userName = ((sdkLoginConfig2 != null) ? sdkLoginConfig2.UserName : null) ?? "";
			SdkLoginConfig sdkLoginConfig3 = LoginModel.Instance.GetSdkLoginConfig();
			this.GetLoginPlayerInfo(loginType, userId, userName, ((sdkLoginConfig3 != null) ? sdkLoginConfig3.Token : null) ?? "", LoginServerModel.Instance.GetCurrentArea());
		}
	}

	// Token: 0x0601079C RID: 67484 RVA: 0x00405C38 File Offset: 0x00403E38
	public void GetLoginPlayerInfo(LoginServerController.ELoginGetPlayerInfoEnum loginType, string userId, string userName, string token, string area)
	{
		if (string.IsNullOrEmpty(userId) || string.IsNullOrEmpty(token))
		{
			return;
		}
		string garurl = PublicUtil.Instance.GetGARUrl((int)loginType, userId, userName, token, area);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.KuroSdk;
		ELogAuthor author = ELogAuthor.YZY;
		string message = "获得GetLoginPlayerInfo";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("url", garurl);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		if (string.IsNullOrEmpty(garurl))
		{
			Log.Instance.Info(ELogModule.KuroSdk, ELogAuthor.YZY, "没有GetLoginPlayerInfo", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		Http.Get(garurl, null, this.SetLoginPlayerInfoData, null);
	}

	// Token: 0x0601079D RID: 67485 RVA: 0x00405CCB File Offset: 0x00403ECB
	protected override bool OnClear()
	{
		if (this.IcmpPingCallBack != null)
		{
			DelegateUtils.ReleaseManualReleaseDelegate(this.IcmpCallBack);
			this.IcmpPingCallBack = null;
		}
		this.GarIpAddress = "";
		return true;
	}

	// Token: 0x17001458 RID: 5208
	// (get) Token: 0x0601079E RID: 67486 RVA: 0x00405CF3 File Offset: 0x00403EF3
	public static LoginServerController Instance
	{
		get
		{
			return LoginServerController._Instance;
		}
	}

	// Token: 0x0601079F RID: 67487 RVA: 0x00405CFA File Offset: 0x00403EFA
	public static LoginServerController GetOrCreateInstance()
	{
		if (LoginServerController._Instance == null)
		{
			LoginServerController.CreateInstance();
		}
		return LoginServerController._Instance;
	}

	// Token: 0x060107A0 RID: 67488 RVA: 0x00405D0E File Offset: 0x00403F0E
	public static bool CreateInstance()
	{
		if (LoginServerController._Instance != null)
		{
			return true;
		}
		LoginServerController._Instance = new LoginServerController();
		return true;
	}

	// Token: 0x060107A1 RID: 67489 RVA: 0x00405D24 File Offset: 0x00403F24
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060107A2 RID: 67490 RVA: 0x00405D26 File Offset: 0x00403F26
	public static void ResetStaticDefaultValue()
	{
		LoginServerController._Instance = null;
	}

	// Token: 0x060107A3 RID: 67491 RVA: 0x00405D2E File Offset: 0x00403F2E
	static LoginServerController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(LoginServerController.CreateStaticDefaultValue), new Action(LoginServerController.ResetStaticDefaultValue));
	}

	// Token: 0x040079D0 RID: 31184
	public const int ICMP_TIME_OUT = 2;

	// Token: 0x040079D1 RID: 31185
	public FPingCallExDelegate IcmpPingCallBack;

	// Token: 0x040079D2 RID: 31186
	private string GarIpAddress = "";

	// Token: 0x040079D3 RID: 31187
	private readonly Action SaveFirstLogin = delegate()
	{
		if (LoginServerModel.Instance.CurrentSelectServerData == null)
		{
			return;
		}
		LoginServerModel instance = LoginServerModel.Instance;
		SdkLoginConfig sdkLoginConfig = LoginModel.Instance.GetSdkLoginConfig();
		instance.SaveFirstLogin(((sdkLoginConfig != null) ? sdkLoginConfig.Uid : null) ?? "", LoginServerModel.Instance.CurrentSelectServerData);
	};

	// Token: 0x040079D4 RID: 31188
	private readonly Action OnGetBasicInfo = delegate()
	{
		if (LoginServerModel.Instance.CurrentSelectServerData == null)
		{
			return;
		}
		LoginServerModel instance = LoginServerModel.Instance;
		SdkLoginConfig sdkLoginConfig = LoginModel.Instance.GetSdkLoginConfig();
		instance.SaveLocalRegionLevel(((sdkLoginConfig != null) ? sdkLoginConfig.Uid : null) ?? "", LoginServerModel.Instance.CurrentSelectServerData.Region, FunctionModel.Instance.GetPlayerLevel().Value);
	};

	// Token: 0x040079D5 RID: 31189
	private readonly Action<int, int, int, int, int, int, int> SaveServerLevel = delegate(int lastLevel, int currentLevel, int currentExp, int lastExp, int addExp, int currentMaxExp, int lastMaxExp)
	{
		if (LoginServerModel.Instance.CurrentSelectServerData == null)
		{
			return;
		}
		LoginServerModel instance = LoginServerModel.Instance;
		SdkLoginConfig sdkLoginConfig = LoginModel.Instance.GetSdkLoginConfig();
		instance.SaveLocalRegionLevel(((sdkLoginConfig != null) ? sdkLoginConfig.Uid : null) ?? "", LoginServerModel.Instance.CurrentSelectServerData.Region, currentLevel);
	};

	// Token: 0x040079D6 RID: 31190
	private readonly Action<string, float, int> IcmpCallBack = delegate(string ipAddress, float time, int responseState)
	{
		if (ipAddress == LoginServerController.Instance.GarIpAddress)
		{
			LoginServerController.Instance.GarIpAddress = "";
			string garPingResults = Json.Stringify<GARPingResult>(new GARPingResult
			{
				IpAddress = ipAddress,
				Time = time
			}, null);
			LoginModel.Instance.GarPingResults = garPingResults;
			return;
		}
		if (KuroSdkController.Instance.GetIfGlobalSdk())
		{
			LoginServerModel.Instance.RefreshIpPing(ipAddress, time);
		}
	};

	// Token: 0x040079D7 RID: 31191
	private readonly Action<bool, int, string> SetLoginPlayerInfoData = delegate(bool success, int code, string data)
	{
		if (code != 200)
		{
			return;
		}
		LoginPlayerInfo loginPlayerInfo = Json.Parse<LoginPlayerInfo>(data, null);
		if (loginPlayerInfo == null)
		{
			return;
		}
		if (loginPlayerInfo.Code != 0)
		{
			return;
		}
		if (loginPlayerInfo.SdkLoginCode != 0)
		{
			return;
		}
		LoginServerModel.Instance.SetPlayerLoginInfo(loginPlayerInfo.UserId, loginPlayerInfo);
		EventSystem.Instance.Emit(EEventName.OnGetLoginPlayerInfo);
	};

	// Token: 0x040079D8 RID: 31192
	[Nullable(2)]
	private static LoginServerController _Instance;

	// Token: 0x02008690 RID: 34448
	[NullableContext(0)]
	public enum ELoginGetPlayerInfoEnum
	{
		// Token: 0x0402BC82 RID: 179330
		TestMode,
		// Token: 0x0402BC83 RID: 179331
		SdkMode
	}
}
