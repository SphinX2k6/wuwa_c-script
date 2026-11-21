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

// Token: 0x02001575 RID: 5493
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class LoginServerController : UiControllerBase
{
	// Token: 0x0600DC03 RID: 56323 RVA: 0x00411FAC File Offset: 0x004101AC
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.WorldDoneAndCloseLoading, this.SaveFirstLogin);
		EventSystem.Instance.Add(EEventName.OnGetPlayerBasicInfo, this.OnGetBasicInfo);
		EventSystem.Instance.Add<int, int, int, int, int, int, int>(EEventName.OnPlayerLevelChanged, this.SaveServerLevel);
	}

	// Token: 0x0600DC04 RID: 56324 RVA: 0x00411FFC File Offset: 0x004101FC
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.WorldDoneAndCloseLoading, this.SaveFirstLogin);
		EventSystem.Instance.Remove(EEventName.OnGetPlayerBasicInfo, this.OnGetBasicInfo);
		EventSystem.Instance.Remove<int, int, int, int, int, int, int>(EEventName.OnPlayerLevelChanged, this.SaveServerLevel);
	}

	// Token: 0x0600DC05 RID: 56325 RVA: 0x0041204B File Offset: 0x0041024B
	protected override bool OnInit()
	{
		this.IcmpPingCallBack = DelegateUtils.ToManualReleaseDelegate<FPingCallExDelegate>(this.IcmpCallBack);
		return true;
	}

	// Token: 0x0600DC06 RID: 56326 RVA: 0x00412060 File Offset: 0x00410260
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

	// Token: 0x0600DC07 RID: 56327 RVA: 0x00412128 File Offset: 0x00410328
	public void PingGAR()
	{
		string garurl = BaseConfigController.Instance.GetGARUrl();
		if (!string.IsNullOrEmpty(garurl))
		{
			this.PingGARAsync(garurl).Forget();
		}
	}

	// Token: 0x0600DC08 RID: 56328 RVA: 0x00412154 File Offset: 0x00410354
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

	// Token: 0x0600DC09 RID: 56329 RVA: 0x004121A0 File Offset: 0x004103A0
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

	// Token: 0x0600DC0A RID: 56330 RVA: 0x00412228 File Offset: 0x00410428
	public void GetLoginPlayerInfo(LoginServerController.ELoginGetPlayerInfoEnum loginType, string userId, string userName, string token, string area)
	{
		if (string.IsNullOrEmpty(userId) || string.IsNullOrEmpty(token))
		{
			return;
		}
		long garUrlVersion = BaseConfigController.Instance.GarUrlVersion;
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
		Http.Get(garurl, null, delegate(bool success, int code, string data)
		{
			BaseConfigController.Instance.SetGARRequestResult(success && code == 200, garUrlVersion);
			this.SetLoginPlayerInfoData(success, code, data);
		}, null);
	}

	// Token: 0x0600DC0B RID: 56331 RVA: 0x004122DF File Offset: 0x004104DF
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

	// Token: 0x17001485 RID: 5253
	// (get) Token: 0x0600DC0C RID: 56332 RVA: 0x00412307 File Offset: 0x00410507
	public static LoginServerController Instance
	{
		get
		{
			return LoginServerController._Instance;
		}
	}

	// Token: 0x0600DC0D RID: 56333 RVA: 0x0041230E File Offset: 0x0041050E
	public static LoginServerController GetOrCreateInstance()
	{
		if (LoginServerController._Instance == null)
		{
			LoginServerController.CreateInstance();
		}
		return LoginServerController._Instance;
	}

	// Token: 0x0600DC0E RID: 56334 RVA: 0x00412322 File Offset: 0x00410522
	public static bool CreateInstance()
	{
		if (LoginServerController._Instance != null)
		{
			return true;
		}
		LoginServerController._Instance = new LoginServerController();
		return true;
	}

	// Token: 0x0600DC0F RID: 56335 RVA: 0x00412338 File Offset: 0x00410538
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600DC10 RID: 56336 RVA: 0x0041233A File Offset: 0x0041053A
	public static void ResetStaticDefaultValue()
	{
		LoginServerController._Instance = null;
	}

	// Token: 0x0600DC11 RID: 56337 RVA: 0x00412342 File Offset: 0x00410542
	static LoginServerController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(LoginServerController.CreateStaticDefaultValue), new Action(LoginServerController.ResetStaticDefaultValue));
	}

	// Token: 0x04007ACE RID: 31438
	public const int ICMP_TIME_OUT = 2;

	// Token: 0x04007ACF RID: 31439
	public FPingCallExDelegate IcmpPingCallBack;

	// Token: 0x04007AD0 RID: 31440
	private string GarIpAddress = "";

	// Token: 0x04007AD1 RID: 31441
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

	// Token: 0x04007AD2 RID: 31442
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

	// Token: 0x04007AD3 RID: 31443
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

	// Token: 0x04007AD4 RID: 31444
	private readonly Action<string, float, int> IcmpCallBack = delegate(string ipAddress, float time, int responseState)
	{
		if (ipAddress == LoginServerController.Instance.GarIpAddress)
		{
			LoginServerController.Instance.GarIpAddress = "";
			string garPingResults = Json.Stringify(new GARPingResult
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

	// Token: 0x04007AD5 RID: 31445
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

	// Token: 0x04007AD6 RID: 31446
	[Nullable(2)]
	private static LoginServerController _Instance;

	// Token: 0x02007818 RID: 30744
	[NullableContext(0)]
	public enum ELoginGetPlayerInfoEnum
	{
		// Token: 0x04026F95 RID: 159637
		TestMode,
		// Token: 0x04026F96 RID: 159638
		SdkMode
	}
}
