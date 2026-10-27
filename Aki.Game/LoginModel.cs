using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using AkiClient.Game.Aki.Data.Server.Struct;
using AkiClient.Game.Aki.UI.Module.Loading.View;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Launcher.Platform.PlatformSdk;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200209D RID: 8349
[NullableContext(2)]
[Nullable(0)]
[Model(0)]
public class LoginModel : ModelBase
{
	// Token: 0x17001449 RID: 5193
	// (get) Token: 0x06010702 RID: 67330 RVA: 0x0040400A File Offset: 0x0040220A
	public bool IsNewAccount
	{
		get
		{
			return this.IsNewAccountInternal;
		}
	}

	// Token: 0x1700144A RID: 5194
	// (get) Token: 0x06010703 RID: 67331 RVA: 0x00404012 File Offset: 0x00402212
	// (set) Token: 0x06010704 RID: 67332 RVA: 0x0040401B File Offset: 0x0040221B
	private int LoginFailCount
	{
		get
		{
			return LocalStorage.GetGlobal<int>(ELocalStorageGlobalKey.LoginFailCount, 0);
		}
		set
		{
			LocalStorage.SetGlobal<int>(ELocalStorageGlobalKey.LoginFailCount, value);
		}
	}

	// Token: 0x1700144B RID: 5195
	// (get) Token: 0x06010705 RID: 67333 RVA: 0x00404025 File Offset: 0x00402225
	// (set) Token: 0x06010706 RID: 67334 RVA: 0x00404036 File Offset: 0x00402236
	private double NextLoginTime
	{
		get
		{
			return LocalStorage.GetGlobal<double>(ELocalStorageGlobalKey.NextLoginTime, 0.0);
		}
		set
		{
			LocalStorage.SetGlobal<double>(ELocalStorageGlobalKey.NextLoginTime, value);
		}
	}

	// Token: 0x1700144C RID: 5196
	// (get) Token: 0x06010707 RID: 67335 RVA: 0x00404040 File Offset: 0x00402240
	// (set) Token: 0x06010708 RID: 67336 RVA: 0x00404051 File Offset: 0x00402251
	private double ResetLoginFailCountTime
	{
		get
		{
			return LocalStorage.GetGlobal<double>(ELocalStorageGlobalKey.ResetLoginFailCountTime, 0.0);
		}
		set
		{
			LocalStorage.SetGlobal<double>(ELocalStorageGlobalKey.ResetLoginFailCountTime, value);
		}
	}

	// Token: 0x06010709 RID: 67337 RVA: 0x0040405B File Offset: 0x0040225B
	public void ClearDetectionCache()
	{
		this.ConnectFamily = 0;
		this.UdpPort = 0;
		this.ResolvedIp = "";
		this.PingResults = "";
	}

	// Token: 0x1700144D RID: 5197
	// (get) Token: 0x0601070A RID: 67338 RVA: 0x00404081 File Offset: 0x00402281
	// (set) Token: 0x0601070B RID: 67339 RVA: 0x00404089 File Offset: 0x00402289
	public int PublicJsonVersion
	{
		get
		{
			return this.PublicJsonVersionInternal;
		}
		set
		{
			this.PublicJsonVersionInternal = value;
		}
	}

	// Token: 0x1700144E RID: 5198
	// (get) Token: 0x0601070C RID: 67340 RVA: 0x00404092 File Offset: 0x00402292
	// (set) Token: 0x0601070D RID: 67341 RVA: 0x0040409A File Offset: 0x0040229A
	public int PublicMiscVersion
	{
		get
		{
			return this.PublicMiscVersionInternal;
		}
		set
		{
			this.PublicMiscVersionInternal = value;
		}
	}

	// Token: 0x1700144F RID: 5199
	// (get) Token: 0x0601070E RID: 67342 RVA: 0x004040A3 File Offset: 0x004022A3
	// (set) Token: 0x0601070F RID: 67343 RVA: 0x004040AB File Offset: 0x004022AB
	public int PublicUniverseEditorVersion
	{
		get
		{
			return this.PublicUniverseEditorVersionInternal;
		}
		set
		{
			this.PublicUniverseEditorVersionInternal = value;
		}
	}

	// Token: 0x17001450 RID: 5200
	// (get) Token: 0x06010710 RID: 67344 RVA: 0x004040B4 File Offset: 0x004022B4
	// (set) Token: 0x06010711 RID: 67345 RVA: 0x004040BC File Offset: 0x004022BC
	public string LauncherVersion
	{
		get
		{
			return this.LauncherVersionInternal;
		}
		set
		{
			this.LauncherVersionInternal = value;
		}
	}

	// Token: 0x17001451 RID: 5201
	// (get) Token: 0x06010712 RID: 67346 RVA: 0x004040C5 File Offset: 0x004022C5
	// (set) Token: 0x06010713 RID: 67347 RVA: 0x004040CD File Offset: 0x004022CD
	public string ResourceVersion
	{
		get
		{
			return this.ResourceVersionInternal;
		}
		set
		{
			this.ResourceVersionInternal = value;
		}
	}

	// Token: 0x17001452 RID: 5202
	// (get) Token: 0x06010714 RID: 67348 RVA: 0x004040D6 File Offset: 0x004022D6
	// (set) Token: 0x06010715 RID: 67349 RVA: 0x004040DE File Offset: 0x004022DE
	public int? ServerUniverseEditorVersion
	{
		get
		{
			return this.ServerUniverseEditorVersionInternal;
		}
		set
		{
			this.ServerUniverseEditorVersionInternal = value;
		}
	}

	// Token: 0x06010716 RID: 67350 RVA: 0x004040E8 File Offset: 0x004022E8
	[NullableContext(1)]
	public static bool IsConfigVersionMismatch(string clientRawValue, int? serverValue)
	{
		int num;
		return int.TryParse(clientRawValue, out num) && serverValue != null && num != serverValue.Value;
	}

	// Token: 0x17001453 RID: 5203
	// (get) Token: 0x06010717 RID: 67351 RVA: 0x00404117 File Offset: 0x00402317
	// (set) Token: 0x06010718 RID: 67352 RVA: 0x0040411F File Offset: 0x0040231F
	public TimerHandle VerifyConfigVersionHandle
	{
		get
		{
			return this.VerifyVersionHandleInternal;
		}
		set
		{
			this.VerifyVersionHandleInternal = value;
		}
	}

	// Token: 0x06010719 RID: 67353 RVA: 0x00404128 File Offset: 0x00402328
	protected override bool OnInit()
	{
		this.BornMode = EBornMode.PlayLocationDefaultPlayerStart;
		this.BornLocation = Aki.Protocol.Vector.Create();
		this.LoginStatus = LoginDefine.ELoginStatus.Init;
		this.SdkLoginState = LoginDefine.ESdkLoginState.Logout;
		this.CpuInfoInternal = UKuroStaticLibrary.GetDeviceCPU();
		this.DeviceInfoInternal = UKuroRenderingRuntimeBPPluginBPLibrary.GetRHIDeviceName();
		this.DriverDateInternal = UKuroRenderingRuntimeBPPluginBPLibrary.GetRHIDriverDate();
		if (this.DriverDateInternal == null || this.DriverDateInternal.Length == 0)
		{
			this.DriverDateInternal = "Unknown";
		}
		this.HealthTipTime = (double)ConfigCommonParamById.GetIntConfig("HealthTipTime").GetValueOrDefault();
		return true;
	}

	// Token: 0x0601071A RID: 67354 RVA: 0x004041B0 File Offset: 0x004023B0
	protected override bool OnClear()
	{
		this.LoginStatus = LoginDefine.ELoginStatus.Init;
		this.SdkLoginState = LoginDefine.ESdkLoginState.Logout;
		this.SingleMapList = new List<LoginMapConfig>();
		this.MultiMapList = new List<LoginMapConfig>();
		this.ServerInfoList = new List<ServerConfig>();
		this.ServerDataList = new List<ServerData>();
		this.LoginStatus = LoginDefine.ELoginStatus.Init;
		this.AutoOpenLoginView = false;
		this.PlayerName = string.Empty;
		this.PlayerSex = null;
		this.HasCharacter = false;
		this.LastFailStatus = null;
		this.PublicJsonVersionInternal = 0;
		this.PublicMiscVersionInternal = 0;
		this.PublicUniverseEditorVersionInternal = 0;
		this.LauncherVersionInternal = null;
		this.ResourceVersionInternal = null;
		this.ServerUniverseEditorVersionInternal = null;
		this.CpuInfoInternal = null;
		this.DeviceInfoInternal = null;
		this.DriverDateInternal = null;
		this.RpcInc = 0;
		this.HttpRpcMap.Clear();
		return true;
	}

	// Token: 0x0601071B RID: 67355 RVA: 0x00404288 File Offset: 0x00402488
	public void InitConfig()
	{
		if (this.SingleMapList == null || this.MultiMapList == null || this.ServerInfoList == null)
		{
			this.SingleMapList = new List<LoginMapConfig>();
			this.MultiMapList = new List<LoginMapConfig>();
			this.ServerInfoList = new List<ServerConfig>();
			this.ServerDataList = new List<ServerData>();
			IReadOnlyList<InstanceDungeon> allInstanceDungeon = LoginConfig.Instance.GetAllInstanceDungeon();
			if (allInstanceDungeon != null)
			{
				foreach (InstanceDungeon instanceDungeon in allInstanceDungeon)
				{
					string text = LoginConfig.Instance.GetInstanceDungeonNameById(instanceDungeon.MapName);
					if (text == null)
					{
						text = string.Empty;
					}
					this.SingleMapList.Add(new LoginMapConfig(instanceDungeon.Id, text));
				}
			}
		}
	}

	// Token: 0x0601071C RID: 67356 RVA: 0x00404354 File Offset: 0x00402554
	public void AddServerInfoByCdn()
	{
		if (this.ServerInfoList == null)
		{
			return;
		}
		List<ILoginServersData> loginServersByClientRegion = LoginServerModel.Instance.GetLoginServersByClientRegion();
		if (loginServersByClientRegion == null)
		{
			Log.Instance.Error(ELogModule.Login, ELogAuthor.XXJ, "拿不到CDN返回的服务器数据", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (loginServersByClientRegion.Count <= 0)
		{
			Log.Instance.Info(ELogModule.Login, ELogAuthor.XXJ, "CDN的服务器数据列表为空", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		foreach (ILoginServersData loginServersData in loginServersByClientRegion)
		{
			ServerConfig serverConfig = new ServerConfig(loginServersData.ip, "5500", loginServersData.name, 0);
			this.ServerInfoList.Add(serverConfig);
			this.ServerDataList.Add(new ServerData(serverConfig));
		}
	}

	// Token: 0x0601071D RID: 67357 RVA: 0x0040442C File Offset: 0x0040262C
	public void AddExtraServer()
	{
		TArray<string> tarray = UKuroStaticLibrary.LoadFileToStringArray(UBlueprintPathsLibrary.ProjectConfigDir() + "/ServerConfig.json");
		if (tarray.Num() <= 0)
		{
			return;
		}
		for (int i = 0; i < tarray.Num(); i++)
		{
			ServerConfig item = Json.Parse<ServerConfig>(tarray.Get(i), null);
			this.ServerInfoList.Add(item);
		}
	}

	// Token: 0x0601071E RID: 67358 RVA: 0x00404484 File Offset: 0x00402684
	[NullableContext(1)]
	public void AddServerInfos(ServerInfo[] serverInfoArray)
	{
		if (this.ServerInfoList == null)
		{
			return;
		}
		bool isPlayInEditor = Info.Instance.IsPlayInEditor;
		foreach (ServerInfo serverInfo in serverInfoArray)
		{
			if ((isPlayInEditor && serverInfo.editor != null) || (!isPlayInEditor && serverInfo.package != null))
			{
				this.ServerInfoList.Add(new ServerConfig(serverInfo.address, "5500", serverInfo.description, serverInfo.order.GetValueOrDefault()));
			}
		}
	}

	// Token: 0x0601071F RID: 67359 RVA: 0x00404508 File Offset: 0x00402708
	public void AddDataTableServers()
	{
		if (this.ServerInfoList == null)
		{
			return;
		}
		if (GlobalData.World != null)
		{
			foreach (SServerInfo sserverInfo in DataTableUtil.GetDataTableAllRow<SServerInfo>(EDataTable.ServerInfo))
			{
				this.ServerInfoList.Add(new ServerConfig(sserverInfo.IP, sserverInfo.Port, sserverInfo.Name, sserverInfo.Order));
			}
		}
	}

	// Token: 0x06010720 RID: 67360 RVA: 0x00404590 File Offset: 0x00402790
	public void CleanConfig()
	{
		this.SingleMapList = null;
		this.MultiMapList = null;
		this.ServerInfoList = null;
		this.SdkLoginConfig = null;
		this.ServerDataList = null;
	}

	// Token: 0x06010721 RID: 67361 RVA: 0x004045B5 File Offset: 0x004027B5
	public void SetCreatePlayerTime(double time)
	{
		this.CreatePlayerTime = time;
	}

	// Token: 0x06010722 RID: 67362 RVA: 0x004045BE File Offset: 0x004027BE
	public double GetCreatePlayerTime()
	{
		return this.CreatePlayerTime;
	}

	// Token: 0x06010723 RID: 67363 RVA: 0x004045C6 File Offset: 0x004027C6
	public void SetCreatePlayerId(int id)
	{
		this.CreatePlayerId = id;
	}

	// Token: 0x06010724 RID: 67364 RVA: 0x004045CF File Offset: 0x004027CF
	public int GetCreatePlayerId()
	{
		return this.CreatePlayerId;
	}

	// Token: 0x06010725 RID: 67365 RVA: 0x004045D7 File Offset: 0x004027D7
	public string GetServerIp()
	{
		return this.ServerIp;
	}

	// Token: 0x06010726 RID: 67366 RVA: 0x004045DF File Offset: 0x004027DF
	public string GetSourcePlayerAccount()
	{
		return this.SourceAccount;
	}

	// Token: 0x06010727 RID: 67367 RVA: 0x004045E8 File Offset: 0x004027E8
	[NullableContext(1)]
	public unsafe void SetServerIp(string serverIp, int reason)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Login;
		ELogAuthor author = ELogAuthor.ZJC;
		string message = "保存服务器IP";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("serverIp", serverIp);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("reason", reason);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		this.ServerIp = serverIp;
	}

	// Token: 0x06010728 RID: 67368 RVA: 0x00404654 File Offset: 0x00402854
	public unsafe void TrySetCustomServerPort(string port, int reason)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Login;
		ELogAuthor author = ELogAuthor.ZJC;
		string message = "自定义服务器Port";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("port", port);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("reason", reason);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		this.ServerCustomPort = port;
	}

	// Token: 0x06010729 RID: 67369 RVA: 0x004046C0 File Offset: 0x004028C0
	[NullableContext(1)]
	public string TryGetRealServerPort()
	{
		string customServerPort = this.GetCustomServerPort();
		if (customServerPort != null)
		{
			this.ServerCustomPort = null;
			return customServerPort;
		}
		return this.GetServerPort();
	}

	// Token: 0x0601072A RID: 67370 RVA: 0x004046E6 File Offset: 0x004028E6
	public string GetCustomServerPort()
	{
		return this.ServerCustomPort;
	}

	// Token: 0x0601072B RID: 67371 RVA: 0x004046F0 File Offset: 0x004028F0
	[NullableContext(1)]
	public string GetServerPort()
	{
		string result = "5500";
		string[] array = UKismetSystemLibrary.GetCommandLine().Split(' ', StringSplitOptions.None);
		int num = Array.IndexOf<string>(array, "-LocalGameServerStartPort");
		if (num == -1)
		{
			return result;
		}
		if (num + 1 >= array.Length)
		{
			return result;
		}
		int num2;
		if (!int.TryParse(array[num + 1], out num2))
		{
			return result;
		}
		return (num2 + 1).ToString();
	}

	// Token: 0x0601072C RID: 67372 RVA: 0x00404749 File Offset: 0x00402949
	public string GetServerName()
	{
		return this.ServerName;
	}

	// Token: 0x0601072D RID: 67373 RVA: 0x00404754 File Offset: 0x00402954
	[NullableContext(1)]
	public void SetServerName(string serverName)
	{
		this.ServerName = serverName;
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Login;
		ELogAuthor author = ELogAuthor.YZY;
		string message = "当前选择服务器Name";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("serverId", serverName);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x0601072E RID: 67374 RVA: 0x0040478F File Offset: 0x0040298F
	public string GetServerId()
	{
		return this.ServerId;
	}

	// Token: 0x0601072F RID: 67375 RVA: 0x00404798 File Offset: 0x00402998
	[NullableContext(1)]
	public void SetServerId(string serverId)
	{
		this.ServerId = serverId;
		EventSystem.Instance.Emit(EEventName.OnSetLoginServerId);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Login;
		ELogAuthor author = ELogAuthor.YZY;
		string message = "当前选择服务器Id";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("serverId", serverId);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x06010730 RID: 67376 RVA: 0x004047E4 File Offset: 0x004029E4
	public int GetSingleMapId()
	{
		int global = LocalStorage.GetGlobal<int>(ELocalStorageGlobalKey.SingleMapId, -1);
		if (global != -1)
		{
			return global;
		}
		return 0;
	}

	// Token: 0x06010731 RID: 67377 RVA: 0x00404800 File Offset: 0x00402A00
	public void SetSingleMapId(int singleMapId)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Login;
		ELogAuthor author = ELogAuthor.ZJC;
		string message = "保存单人副本id";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("singleMapId", singleMapId);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		LocalStorage.SetGlobal<int>(ELocalStorageGlobalKey.SingleMapId, singleMapId);
	}

	// Token: 0x06010732 RID: 67378 RVA: 0x00404840 File Offset: 0x00402A40
	public int GetMultiMapId()
	{
		int global = LocalStorage.GetGlobal<int>(ELocalStorageGlobalKey.MultiMapId, -1);
		if (global != -1)
		{
			return global;
		}
		return 0;
	}

	// Token: 0x06010733 RID: 67379 RVA: 0x0040485C File Offset: 0x00402A5C
	public void SetMultiMapId(int multiMapId)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Login;
		ELogAuthor author = ELogAuthor.ZJC;
		string message = "保存多人副本id";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("multiMapId", multiMapId);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		LocalStorage.SetGlobal<int>(ELocalStorageGlobalKey.MultiMapId, multiMapId);
	}

	// Token: 0x06010734 RID: 67380 RVA: 0x0040489C File Offset: 0x00402A9C
	[NullableContext(1)]
	public string GetAccount()
	{
		return LocalStorage.GetGlobal<string>(ELocalStorageGlobalKey.Account, string.Empty) ?? string.Empty;
	}

	// Token: 0x06010735 RID: 67381 RVA: 0x004048B3 File Offset: 0x00402AB3
	[NullableContext(1)]
	public void SetAccount(string account)
	{
		LocalStorage.SetGlobal<string>(ELocalStorageGlobalKey.Account, account);
		this.AddRecentlyAccount(account);
		ThirdPartySdkManager.Instance.SetUserInfo(account);
	}

	// Token: 0x06010736 RID: 67382 RVA: 0x004048D0 File Offset: 0x00402AD0
	[NullableContext(1)]
	public void SetSourceAccount(string account)
	{
		this.SourceAccount = account;
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Login;
		ELogAuthor author = ELogAuthor.LJQ;
		string message = "设置复制账号";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("目标账号:", account);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x06010737 RID: 67383 RVA: 0x0040490A File Offset: 0x00402B0A
	public bool GetSelectBoxActive()
	{
		return LocalStorage.GetGlobal<bool>(ELocalStorageGlobalKey.SelectBoxActive, true);
	}

	// Token: 0x06010738 RID: 67384 RVA: 0x00404913 File Offset: 0x00402B13
	public void SetSelectBoxActive(bool selectBoxActive)
	{
		LocalStorage.SetGlobal<bool>(ELocalStorageGlobalKey.SelectBoxActive, selectBoxActive);
	}

	// Token: 0x06010739 RID: 67385 RVA: 0x0040491D File Offset: 0x00402B1D
	public bool GetAutoOpenLoginView()
	{
		return this.AutoOpenLoginView;
	}

	// Token: 0x0601073A RID: 67386 RVA: 0x00404925 File Offset: 0x00402B25
	public void SetAutoOpenLoginView(bool ret)
	{
		this.AutoOpenLoginView = ret;
	}

	// Token: 0x0601073B RID: 67387 RVA: 0x0040492E File Offset: 0x00402B2E
	public LoginDefine.ELoginStatus GetLoginStatus()
	{
		return this.LoginStatus;
	}

	// Token: 0x0601073C RID: 67388 RVA: 0x00404936 File Offset: 0x00402B36
	public LoginDefine.ELoginStatus? GetLastFailStatus()
	{
		return this.LastFailStatus;
	}

	// Token: 0x0601073D RID: 67389 RVA: 0x00404940 File Offset: 0x00402B40
	public unsafe void SetLoginStatus(LoginDefine.ELoginStatus loginStatus, bool userLogout = false)
	{
		if (loginStatus == this.LoginStatus)
		{
			return;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Login;
		ELogAuthor author = ELogAuthor.ZJC;
		string message = "LoginProcedure-登录状态变化";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Before", this.LoginStatus.ToString());
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("After", loginStatus.ToString());
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		if (this.LoginStatus != LoginDefine.ELoginStatus.Init && loginStatus == LoginDefine.ELoginStatus.Init)
		{
			Log.Instance.Warn(ELogModule.Login, ELogAuthor.LRA, "LoginProcedure-登录失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			Heartbeat.Instance.StopHeartBeat(HeartbeatDefine.EStopHeartbeat.LoginStatusInit);
			this.LastFailStatus = new LoginDefine.ELoginStatus?(this.LoginStatus);
		}
		else
		{
			this.LastFailStatus = null;
		}
		this.LoginStatus = loginStatus;
		EventSystem.Instance.Emit(EEventName.LoginStatusChange);
	}

	// Token: 0x0601073E RID: 67390 RVA: 0x00404A2A File Offset: 0x00402C2A
	public bool IsLoginStatus(LoginDefine.ELoginStatus loginStatus)
	{
		return this.LoginStatus == loginStatus;
	}

	// Token: 0x0601073F RID: 67391 RVA: 0x00404A35 File Offset: 0x00402C35
	public void SetSdkLoginState(LoginDefine.ESdkLoginState state)
	{
		this.SdkLoginState = state;
		if (state == LoginDefine.ESdkLoginState.Logout)
		{
			if (this.SdkLoginConfig != null)
			{
				this.SetSdkLoginConfig(string.Empty, string.Empty, string.Empty);
			}
			this.ThirdGameAutoLoginId = "-1";
		}
	}

	// Token: 0x06010740 RID: 67392 RVA: 0x00404A69 File Offset: 0x00402C69
	[NullableContext(1)]
	public void SetSdkLoginInfo(string loginCode, string uid, string username)
	{
		if (this.SdkLoginInfo == null)
		{
			this.SdkLoginInfo = new SdkLoginInfo();
		}
		this.SdkLoginInfo.LoginCode = loginCode;
		this.SdkLoginInfo.Uid = uid;
		this.SdkLoginInfo.UserName = username;
	}

	// Token: 0x06010741 RID: 67393 RVA: 0x00404AA2 File Offset: 0x00402CA2
	public SdkLoginInfo GetSdkLoginInfo()
	{
		return this.SdkLoginInfo;
	}

	// Token: 0x06010742 RID: 67394 RVA: 0x00404AAA File Offset: 0x00402CAA
	public bool IsSdkLoggedIn()
	{
		return this.SdkLoginState == LoginDefine.ESdkLoginState.Login;
	}

	// Token: 0x06010743 RID: 67395 RVA: 0x00404AB5 File Offset: 0x00402CB5
	public bool IsSdkLoggingIn()
	{
		return this.SdkLoginState == LoginDefine.ESdkLoginState.LoggingIn;
	}

	// Token: 0x06010744 RID: 67396 RVA: 0x00404AC0 File Offset: 0x00402CC0
	public bool IsSdkLogout()
	{
		return this.SdkLoginState == LoginDefine.ESdkLoginState.Logout;
	}

	// Token: 0x06010745 RID: 67397 RVA: 0x00404ACB File Offset: 0x00402CCB
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public List<LoginMapConfig> GetSingleMapList()
	{
		return this.SingleMapList;
	}

	// Token: 0x06010746 RID: 67398 RVA: 0x00404AD4 File Offset: 0x00402CD4
	public int? GetSingleMapIp(int index)
	{
		if (this.SingleMapList != null && index < this.SingleMapList.Count)
		{
			return new int?(this.SingleMapList[index].MapId);
		}
		return null;
	}

	// Token: 0x06010747 RID: 67399 RVA: 0x00404B18 File Offset: 0x00402D18
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public List<ServerConfig> GetServerInfoList()
	{
		if (this.ServerInfoList != null)
		{
			this.ServerInfoList = (from x in this.ServerInfoList
			orderby x.Order
			select x).ToList<ServerConfig>();
		}
		return this.ServerInfoList;
	}

	// Token: 0x06010748 RID: 67400 RVA: 0x00404B68 File Offset: 0x00402D68
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public List<ServerData> GetServerDataList()
	{
		return this.ServerDataList;
	}

	// Token: 0x06010749 RID: 67401 RVA: 0x00404B70 File Offset: 0x00402D70
	public ServerConfig GetServerInfo(int index)
	{
		if (this.ServerInfoList != null && index < this.ServerInfoList.Count)
		{
			return this.ServerInfoList[index];
		}
		return null;
	}

	// Token: 0x0601074A RID: 67402 RVA: 0x00404B96 File Offset: 0x00402D96
	public bool HasReconnectInfo()
	{
		return this.ReconnectInfo != null;
	}

	// Token: 0x0601074B RID: 67403 RVA: 0x00404BA1 File Offset: 0x00402DA1
	[NullableContext(1)]
	public void SetReconnectInfo(string token, string host, int port)
	{
		this.ReconnectInfo = new ReconnectInfo(token, host, port);
	}

	// Token: 0x0601074C RID: 67404 RVA: 0x00404BB1 File Offset: 0x00402DB1
	[NullableContext(1)]
	public void SetReconnectToken(string token)
	{
		if (this.ReconnectInfo != null)
		{
			this.ReconnectInfo.Token = token;
		}
	}

	// Token: 0x0601074D RID: 67405 RVA: 0x00404BC7 File Offset: 0x00402DC7
	public string GetReconnectToken()
	{
		if (this.ReconnectInfo == null)
		{
			return null;
		}
		return this.ReconnectInfo.Token;
	}

	// Token: 0x0601074E RID: 67406 RVA: 0x00404BDE File Offset: 0x00402DDE
	public string GetReconnectHost()
	{
		if (this.ReconnectInfo == null)
		{
			return null;
		}
		return this.ReconnectInfo.Host;
	}

	// Token: 0x0601074F RID: 67407 RVA: 0x00404BF8 File Offset: 0x00402DF8
	public int? GetReconnectPort()
	{
		if (this.ReconnectInfo == null)
		{
			return null;
		}
		return new int?(this.ReconnectInfo.Port);
	}

	// Token: 0x06010750 RID: 67408 RVA: 0x00404C27 File Offset: 0x00402E27
	public string GetPlayerName()
	{
		return this.PlayerName;
	}

	// Token: 0x06010751 RID: 67409 RVA: 0x00404C2F File Offset: 0x00402E2F
	[NullableContext(1)]
	public void SetPlayerName(string playerName)
	{
		this.PlayerName = playerName;
	}

	// Token: 0x06010752 RID: 67410 RVA: 0x00404C38 File Offset: 0x00402E38
	public int? GetPlayerSex()
	{
		if (this.PlayerSex == null)
		{
			return null;
		}
		return new int?((int)this.PlayerSex.Value);
	}

	// Token: 0x06010753 RID: 67411 RVA: 0x00404C6C File Offset: 0x00402E6C
	public void SetPlayerSex(LoginDefine.ELoginSex playerSex)
	{
		this.PlayerSex = new LoginDefine.ELoginSex?(playerSex);
	}

	// Token: 0x06010754 RID: 67412 RVA: 0x00404C7C File Offset: 0x00402E7C
	public bool IsPlayerSexValid(int? playerSex)
	{
		int? num = playerSex;
		if (playerSex == null)
		{
			num = ((this.PlayerSex != null) ? new int?((int)this.PlayerSex.Value) : null);
		}
		if (num.GetValueOrDefault() != 1)
		{
			int? num2 = num;
			int num3 = 0;
			if (!(num2.GetValueOrDefault() == num3 & num2 != null))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06010755 RID: 67413 RVA: 0x00404CE2 File Offset: 0x00402EE2
	public bool GetHasCharacter()
	{
		return this.HasCharacter;
	}

	// Token: 0x06010756 RID: 67414 RVA: 0x00404CEA File Offset: 0x00402EEA
	public void SetHasCharacter(bool hasCharacter)
	{
		this.HasCharacter = hasCharacter;
	}

	// Token: 0x06010757 RID: 67415 RVA: 0x00404CF3 File Offset: 0x00402EF3
	public void SetIsNewAccount(bool isNewAccount)
	{
		this.IsNewAccountInternal = isNewAccount;
	}

	// Token: 0x06010758 RID: 67416 RVA: 0x00404CFC File Offset: 0x00402EFC
	public void CleanCreateData()
	{
		this.HasCharacter = false;
		this.PlayerName = string.Empty;
		this.PlayerSex = null;
	}

	// Token: 0x06010759 RID: 67417 RVA: 0x00404D1C File Offset: 0x00402F1C
	[NullableContext(1)]
	public int SetRpcHttp(Action callback, int timeoutMs)
	{
		LoginModel.<>c__DisplayClass157_0 CS$<>8__locals1 = new LoginModel.<>c__DisplayClass157_0();
		CS$<>8__locals1.<>4__this = this;
		CS$<>8__locals1.callback = callback;
		LoginModel.<>c__DisplayClass157_0 CS$<>8__locals2 = CS$<>8__locals1;
		int num = this.RpcInc + 1;
		this.RpcInc = num;
		CS$<>8__locals2.rpcId = num;
		TimerHandle value = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
		{
			if (CS$<>8__locals1.<>4__this.IsLoginStatus(LoginDefine.ELoginStatus.LoginHttp))
			{
				CS$<>8__locals1.<>4__this.HttpRpcMap.Remove(CS$<>8__locals1.rpcId);
				CS$<>8__locals1.callback();
			}
		}, (float)timeoutMs, null, null, true, 1f);
		this.HttpRpcMap[CS$<>8__locals1.rpcId] = value;
		return CS$<>8__locals1.rpcId;
	}

	// Token: 0x0601075A RID: 67418 RVA: 0x00404D90 File Offset: 0x00402F90
	public bool CleanRpcHttp(int rpcId)
	{
		TimerHandle handle;
		if (this.HttpRpcMap.TryGetValue(rpcId, out handle))
		{
			TimerSystem.GameplayTimeInstance.Remove(handle);
			this.HttpRpcMap.Remove(rpcId);
			return true;
		}
		return false;
	}

	// Token: 0x0601075B RID: 67419 RVA: 0x00404DCC File Offset: 0x00402FCC
	public void AddLoginFailCount()
	{
		if (this.LoginFailCount == 0)
		{
			int? loginFailResetTime = LoginConfig.Instance.GetLoginFailResetTime();
			this.SetResetLoginFailCountTime(((loginFailResetTime != null) ? new double?((double)loginFailResetTime.GetValueOrDefault()) : null).Value, true);
		}
		this.SetLoginFailCount(this.LoginFailCount + 1, true);
		double? num = new double?((double)LoginConfig.Instance.GetLoginFailParam(this.LoginFailCount));
		this.SetNextLoginTime(num.Value, true);
	}

	// Token: 0x0601075C RID: 67420 RVA: 0x00404E54 File Offset: 0x00403054
	public bool IsThisTimeCanLogin()
	{
		double num = (double)DateTimeOffset.Now.ToUnixTimeMilliseconds() * 0.001;
		if (this.LoginFailCount > 0)
		{
			int? loginFailResetTime = LoginConfig.Instance.GetLoginFailResetTime();
			double? num2 = (loginFailResetTime != null) ? new double?((double)loginFailResetTime.GetValueOrDefault()) : null;
			if (num >= this.ResetLoginFailCountTime + num2.Value)
			{
				this.CleanLoginFailCount(LoginDefine.ECleanFailCountWay.RefreshTime);
				return true;
			}
		}
		double? num3 = new double?(this.NextLoginTime + (double)LoginConfig.Instance.GetLoginFailParam(this.LoginFailCount));
		if (num >= num3.Value)
		{
			return true;
		}
		DateTime dateTime = DateTimeOffset.FromUnixTimeMilliseconds((long)(num3.Value * 1000.0)).DateTime;
		return false;
	}

	// Token: 0x0601075D RID: 67421 RVA: 0x00404F1D File Offset: 0x0040311D
	public void CleanLoginFailCount(LoginDefine.ECleanFailCountWay way)
	{
		this.SetLoginFailCount(0, false);
		this.SetNextLoginTime(0.0, false);
		this.SetResetLoginFailCountTime(0.0, false);
	}

	// Token: 0x0601075E RID: 67422 RVA: 0x00404F47 File Offset: 0x00403147
	public void SetLoginFailCount(int count, bool isLog = true)
	{
		this.LoginFailCount = count;
	}

	// Token: 0x0601075F RID: 67423 RVA: 0x00404F54 File Offset: 0x00403154
	private void SetNextLoginTime(double addTime, bool isLog = true)
	{
		this.NextLoginTime = (double)DateTimeOffset.Now.ToUnixTimeMilliseconds() * 0.001;
		if (isLog)
		{
			DateTime dateTime = DateTimeOffset.FromUnixTimeMilliseconds((long)((this.NextLoginTime + addTime) * 1000.0)).DateTime;
		}
	}

	// Token: 0x06010760 RID: 67424 RVA: 0x00404FA4 File Offset: 0x004031A4
	private void SetResetLoginFailCountTime(double addTime, bool isLog = true)
	{
		this.ResetLoginFailCountTime = (double)DateTimeOffset.Now.ToUnixTimeMilliseconds() * 0.001;
		if (isLog)
		{
			DateTime dateTime = DateTimeOffset.FromUnixTimeMilliseconds((long)((this.ResetLoginFailCountTime + addTime) * 1000.0)).DateTime;
		}
	}

	// Token: 0x06010761 RID: 67425 RVA: 0x00404FF4 File Offset: 0x004031F4
	public void FixLoginFailInfo()
	{
		double num = (double)DateTimeOffset.Now.ToUnixTimeMilliseconds() * 0.001;
		if (this.ResetLoginFailCountTime > num)
		{
			int? loginFailResetTime = LoginConfig.Instance.GetLoginFailResetTime();
			this.SetResetLoginFailCountTime(((loginFailResetTime != null) ? new double?((double)loginFailResetTime.GetValueOrDefault()) : null).Value, true);
		}
		if (this.NextLoginTime > num)
		{
			double? num2 = new double?((double)LoginConfig.Instance.GetLoginFailParam(this.LoginFailCount));
			this.SetNextLoginTime(num2.Value, true);
		}
	}

	// Token: 0x06010762 RID: 67426 RVA: 0x00405090 File Offset: 0x00403290
	[NullableContext(1)]
	public unsafe void SetSdkLoginConfig(string uId, string userName, string token)
	{
		this.SdkLoginConfig = new SdkLoginConfig(uId, userName, token);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Login;
		ELogAuthor author = ELogAuthor.YZY;
		string message = "设置SDK登录配置";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("uId", uId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("userName", userName);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
	}

	// Token: 0x06010763 RID: 67427 RVA: 0x00405100 File Offset: 0x00403300
	public bool CheckLoginToGameServerSdkConfigIfSame()
	{
		if (this.SdkLoginConfig != null && this.LoginToGameServerSdkLoginConfig != null)
		{
			if (this.SdkLoginConfig.Uid != this.LoginToGameServerSdkLoginConfig.Uid || this.SdkLoginConfig.UserName != this.LoginToGameServerSdkLoginConfig.UserName || this.SdkLoginConfig.Token != this.LoginToGameServerSdkLoginConfig.Token)
			{
				this.SdkAccountChangeNeedExitFlag = true;
			}
			else
			{
				this.SdkAccountChangeNeedExitFlag = false;
			}
		}
		return this.SdkAccountChangeNeedExitFlag;
	}

	// Token: 0x06010764 RID: 67428 RVA: 0x0040518C File Offset: 0x0040338C
	public unsafe void CacheCurrentSdkLoginConfig()
	{
		if (this.SdkLoginConfig != null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Login;
			ELogAuthor author = ELogAuthor.YZY;
			string message = "缓存当前登录服务器SDK登录配置";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("uId", this.SdkLoginConfig.Uid);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("userName", this.SdkLoginConfig.UserName);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			this.LoginToGameServerSdkLoginConfig = new SdkLoginConfig(this.SdkLoginConfig.Uid, this.SdkLoginConfig.UserName, this.SdkLoginConfig.Token);
			return;
		}
		this.LoginToGameServerSdkLoginConfig = null;
	}

	// Token: 0x06010765 RID: 67429 RVA: 0x0040523F File Offset: 0x0040343F
	public SdkLoginConfig GetSdkLoginConfig()
	{
		return this.SdkLoginConfig;
	}

	// Token: 0x06010766 RID: 67430 RVA: 0x00405247 File Offset: 0x00403447
	[NullableContext(1)]
	public string GetLoginUid()
	{
		if (!KuroSdkController.Instance.CanUseSdk() && !PlatformSdkManagerNew.Instance.IsSdkOn)
		{
			return this.GetAccount();
		}
		if (this.SdkLoginConfig == null)
		{
			return string.Empty;
		}
		return this.SdkLoginConfig.Uid;
	}

	// Token: 0x06010767 RID: 67431 RVA: 0x00405281 File Offset: 0x00403481
	[NullableContext(1)]
	public string GetLoginUserName()
	{
		if (this.SdkLoginConfig == null)
		{
			return string.Empty;
		}
		return this.SdkLoginConfig.UserName;
	}

	// Token: 0x06010768 RID: 67432 RVA: 0x0040529C File Offset: 0x0040349C
	[NullableContext(1)]
	public string GetLoginUserNameWithUriEncode()
	{
		if (this.SdkLoginConfig == null)
		{
			return string.Empty;
		}
		return this.SdkLoginConfig.GetLoginUserNameWithUriEncode();
	}

	// Token: 0x06010769 RID: 67433 RVA: 0x004052B7 File Offset: 0x004034B7
	[NullableContext(1)]
	public string GetLoginToken()
	{
		if (this.SdkLoginConfig == null)
		{
			return string.Empty;
		}
		return this.SdkLoginConfig.Token;
	}

	// Token: 0x17001454 RID: 5204
	// (get) Token: 0x0601076A RID: 67434 RVA: 0x004052D2 File Offset: 0x004034D2
	// (set) Token: 0x0601076B RID: 67435 RVA: 0x004052DA File Offset: 0x004034DA
	public LogoutNotify LogoutNotify
	{
		get
		{
			return this.LogoutNotifyInternal;
		}
		set
		{
			this.LogoutNotifyInternal = value;
		}
	}

	// Token: 0x0601076C RID: 67436 RVA: 0x004052E3 File Offset: 0x004034E3
	public void SetTodayFirstTimeLogin(bool ret)
	{
		this.IfFirstTimeLogin = ret;
	}

	// Token: 0x0601076D RID: 67437 RVA: 0x004052EC File Offset: 0x004034EC
	public bool GetTodayFirstTimeLogin()
	{
		return this.IfFirstTimeLogin;
	}

	// Token: 0x0601076E RID: 67438 RVA: 0x004052F4 File Offset: 0x004034F4
	public double GetLastLoginTime()
	{
		return LocalStorage.GetPlayer<double>(ELocalStoragePlayerKey.LoginTime, 0.0);
	}

	// Token: 0x0601076F RID: 67439 RVA: 0x00405306 File Offset: 0x00403506
	public void SetLastLoginTime(double time)
	{
		LocalStorage.SetPlayer<double>(ELocalStoragePlayerKey.LoginTime, time);
	}

	// Token: 0x06010770 RID: 67440 RVA: 0x00405314 File Offset: 0x00403514
	[NullableContext(1)]
	public void AddRecentlyAccount(string name)
	{
		if (StringUtils.IsEmpty(name))
		{
			return;
		}
		if (this.RecentlyAccountList == null)
		{
			this.RecentlyAccountList = new List<string>();
		}
		while (this.RecentlyAccountList.Count >= this.MaxRecentlyAccountNumber)
		{
			this.RecentlyAccountList.RemoveAt(0);
		}
		int num = -1;
		for (int i = 0; i < this.RecentlyAccountList.Count; i++)
		{
			if (this.RecentlyAccountList[i] == name)
			{
				num = i;
				break;
			}
		}
		if (num != -1)
		{
			this.RecentlyAccountList.RemoveAt(num);
		}
		this.RecentlyAccountList.Add(name);
	}

	// Token: 0x06010771 RID: 67441 RVA: 0x004053AA File Offset: 0x004035AA
	public void InitRecentlyAccountList()
	{
		this.RecentlyAccountList = LocalStorage.GetGlobal<List<string>>(ELocalStorageGlobalKey.RecentlyAccountList, null);
		if (this.RecentlyAccountList == null)
		{
			this.RecentlyAccountList = new List<string>();
		}
	}

	// Token: 0x06010772 RID: 67442 RVA: 0x004053CD File Offset: 0x004035CD
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public List<string> GetRecentlyAccountList()
	{
		return this.RecentlyAccountList;
	}

	// Token: 0x06010773 RID: 67443 RVA: 0x004053D5 File Offset: 0x004035D5
	public void SaveRecentlyAccountList()
	{
		if (this.RecentlyAccountList != null)
		{
			LocalStorage.SetGlobal<List<string>>(ELocalStorageGlobalKey.RecentlyAccountList, this.RecentlyAccountList);
		}
	}

	// Token: 0x17001455 RID: 5205
	// (get) Token: 0x06010774 RID: 67444 RVA: 0x004053ED File Offset: 0x004035ED
	// (set) Token: 0x06010775 RID: 67445 RVA: 0x004053F5 File Offset: 0x004035F5
	public string LoginTraceId
	{
		get
		{
			return this.LoginTraceIdInternal;
		}
		set
		{
			this.LoginTraceIdInternal = value;
			NetInfo.Instance.LoginTraceId = value;
		}
	}

	// Token: 0x06010776 RID: 67446 RVA: 0x00405409 File Offset: 0x00403609
	public void CreateLoginPromise()
	{
		this.LoginPromiseInternal = new CustomPromise();
	}

	// Token: 0x06010777 RID: 67447 RVA: 0x00405416 File Offset: 0x00403616
	public void FinishLoginPromise()
	{
		CustomPromise loginPromiseInternal = this.LoginPromiseInternal;
		if (loginPromiseInternal == null)
		{
			return;
		}
		loginPromiseInternal.SetResult();
	}

	// Token: 0x06010778 RID: 67448 RVA: 0x00405428 File Offset: 0x00403628
	public UniTask WaitLoginPromise()
	{
		LoginModel.<WaitLoginPromise>d__195 <WaitLoginPromise>d__;
		<WaitLoginPromise>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<WaitLoginPromise>d__.<>4__this = this;
		<WaitLoginPromise>d__.<>1__state = -1;
		<WaitLoginPromise>d__.<>t__builder.Start<LoginModel.<WaitLoginPromise>d__195>(ref <WaitLoginPromise>d__);
		return <WaitLoginPromise>d__.<>t__builder.Task;
	}

	// Token: 0x06010779 RID: 67449 RVA: 0x0040546B File Offset: 0x0040366B
	public bool HasLoginPromise()
	{
		return this.LoginPromiseInternal != null;
	}

	// Token: 0x0601077A RID: 67450 RVA: 0x00405476 File Offset: 0x00403676
	public void CreateAutoLoginPromise()
	{
		this.AutoLoginPromiseInternal = new CustomPromise<bool>();
	}

	// Token: 0x0601077B RID: 67451 RVA: 0x00405483 File Offset: 0x00403683
	public void ClearAutoLoginPromise()
	{
		this.AutoLoginPromiseInternal = null;
	}

	// Token: 0x0601077C RID: 67452 RVA: 0x0040548C File Offset: 0x0040368C
	public void FinishAutoLoginPromise(bool value)
	{
		this.AutoLoginPromiseInternal.SetResult(value);
	}

	// Token: 0x0601077D RID: 67453 RVA: 0x0040549C File Offset: 0x0040369C
	[NullableContext(0)]
	public UniTask<bool?> WaitAutoLoginPromise()
	{
		LoginModel.<WaitAutoLoginPromise>d__201 <WaitAutoLoginPromise>d__;
		<WaitAutoLoginPromise>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool?>.Create();
		<WaitAutoLoginPromise>d__.<>4__this = this;
		<WaitAutoLoginPromise>d__.<>1__state = -1;
		<WaitAutoLoginPromise>d__.<>t__builder.Start<LoginModel.<WaitAutoLoginPromise>d__201>(ref <WaitAutoLoginPromise>d__);
		return <WaitAutoLoginPromise>d__.<>t__builder.Task;
	}

	// Token: 0x0601077E RID: 67454 RVA: 0x004054DF File Offset: 0x004036DF
	public bool HasAutoLoginPromise()
	{
		return this.AutoLoginPromiseInternal != null;
	}

	// Token: 0x17001456 RID: 5206
	// (get) Token: 0x0601077F RID: 67455 RVA: 0x004054EA File Offset: 0x004036EA
	// (set) Token: 0x06010780 RID: 67456 RVA: 0x004054F2 File Offset: 0x004036F2
	public TimerHandle AutoLoginTimerId
	{
		get
		{
			return this.AutoLoginTimerIdInternal;
		}
		set
		{
			this.AutoLoginTimerIdInternal = value;
		}
	}

	// Token: 0x06010781 RID: 67457 RVA: 0x004054FB File Offset: 0x004036FB
	public void ClearAutoLoginTimerId()
	{
		if (this.AutoLoginTimerId != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.AutoLoginTimerId);
			this.AutoLoginTimerId = null;
		}
	}

	// Token: 0x06010782 RID: 67458 RVA: 0x00405520 File Offset: 0x00403720
	[NullableContext(1)]
	public string GetWaterMarkPath()
	{
		string text = UKuroLauncherLibrary.GameSavedDir() + "Logs/TmpData";
		if (Info.Instance.IsPs5Platform())
		{
			return text.ToLower();
		}
		return text;
	}

	// Token: 0x06010783 RID: 67459 RVA: 0x00405551 File Offset: 0x00403751
	public string CpuInfo()
	{
		return this.CpuInfoInternal;
	}

	// Token: 0x06010784 RID: 67460 RVA: 0x00405559 File Offset: 0x00403759
	public string DeviceInfo()
	{
		return this.DeviceInfoInternal;
	}

	// Token: 0x06010785 RID: 67461 RVA: 0x00405561 File Offset: 0x00403761
	public string DriverDate()
	{
		return this.DriverDateInternal;
	}

	// Token: 0x06010786 RID: 67462 RVA: 0x00405569 File Offset: 0x00403769
	public bool HasBackToGameData()
	{
		return this.BackToGameData != null || UKuroVariableFunctionLibrary.HasStringValue("back_to_game");
	}

	// Token: 0x06010787 RID: 67463 RVA: 0x00405580 File Offset: 0x00403780
	[NullableContext(1)]
	public unsafe bool SaveKuroVariableStringValue(string key, string jsonData)
	{
		if (!UKuroVariableFunctionLibrary.SetStringValue(key, jsonData))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Login;
			ELogAuthor author = ELogAuthor.YZY;
			string message = "[BackToGame] SetStringValue失败";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("key", key);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("jsonData", jsonData);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return false;
		}
		return true;
	}

	// Token: 0x06010788 RID: 67464 RVA: 0x004055EC File Offset: 0x004037EC
	[NullableContext(1)]
	public bool SaveKuroVariableObject(string key, [Nullable(2)] UObject @object)
	{
		if (@object == null || !@object.IsValid())
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Login;
			ELogAuthor author = ELogAuthor.YZY;
			string message = "[BackToGame] SaveKuroVariableObject Object无效";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("key", key);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		if (!UKuroVariableFunctionLibrary.SetObject(key, @object))
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Login;
			ELogAuthor author2 = ELogAuthor.YZY;
			string message2 = "[BackToGame] SetObject失败";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("key", key);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return false;
		}
		return true;
	}

	// Token: 0x06010789 RID: 67465 RVA: 0x00405660 File Offset: 0x00403860
	[NullableContext(1)]
	public unsafe bool SaveBackToGameData(BackToGameData data, bool reset = false)
	{
		string text = Json.Stringify<BackToGameData>(data, null);
		if (reset)
		{
			if (UKuroVariableFunctionLibrary.HasStringValue("back_to_game"))
			{
				UKuroVariableFunctionLibrary.RemoveStringValue("back_to_game");
			}
			if (UKuroVariableFunctionLibrary.HasObject("loading_widget"))
			{
				UKuroVariableFunctionLibrary.RemoveObject("loading_widget");
			}
		}
		if (data.LoadingWidget != null && data.LoadingWidget.IsValid() && !this.SaveKuroVariableObject("loading_widget", data.LoadingWidget))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Login;
			ELogAuthor author = ELogAuthor.LFJW;
			string message = "[BackToGame] SetObject重复设置参数";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("backToGame", text);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("key", "loading_widget");
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return false;
		}
		if (!this.SaveKuroVariableStringValue("back_to_game", text))
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Login;
			ELogAuthor author2 = ELogAuthor.LFJW;
			string message2 = "[BackToGame] SetStringValue重复设置参数";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("backToGame", text);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("key", "back_to_game");
			instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			return false;
		}
		this.BackToGameData = data;
		return true;
	}

	// Token: 0x0601078A RID: 67466 RVA: 0x00405794 File Offset: 0x00403994
	public bool RemoveBackToGameData()
	{
		if (this.BackToGameData == null)
		{
			return true;
		}
		UKuroVariableFunctionLibrary.RemoveObject("loading_widget");
		if (!UKuroVariableFunctionLibrary.RemoveStringValue("back_to_game"))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Login;
			ELogAuthor author = ELogAuthor.LFJW;
			string message = "[BackToGame] RemoveStringValue失败";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("key", "back_to_game");
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		this.BackToGameData = null;
		this.TryBackToGameFailCount = 0;
		AudioSystem.Instance.SetState("reconnect_auto_login", "not_in_auto_login", true);
		UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.FEstimation.Enable 1", null);
		return true;
	}

	// Token: 0x0601078B RID: 67467 RVA: 0x00405824 File Offset: 0x00403A24
	public BackToGameData GetBackToGameData()
	{
		if (this.BackToGameData != null)
		{
			return this.BackToGameData;
		}
		string text = string.Empty;
		string text2 = text;
		if (!UKuroVariableFunctionLibrary.GetStringValue("back_to_game", ref text2))
		{
			return null;
		}
		text = text2;
		if (string.IsNullOrEmpty(text))
		{
			return null;
		}
		BackToGameData backToGameData = Json.Parse<BackToGameData>(text, null);
		UObject uobject = null;
		if (UKuroVariableFunctionLibrary.GetObject("loading_widget", ref uobject))
		{
			backToGameData.LoadingWidget = (uobject as WBP_UILoading_C);
		}
		this.BackToGameData = backToGameData;
		return this.BackToGameData;
	}

	// Token: 0x0601078C RID: 67468 RVA: 0x00405895 File Offset: 0x00403A95
	public int BackToGameFailCount()
	{
		return this.TryBackToGameFailCount;
	}

	// Token: 0x0601078D RID: 67469 RVA: 0x0040589D File Offset: 0x00403A9D
	public bool CheckBackToGameFailCount()
	{
		this.TryBackToGameFailCount++;
		return this.TryBackToGameFailCount <= this.TryBackToGameMaxCount;
	}

	// Token: 0x17001457 RID: 5207
	// (get) Token: 0x0601078E RID: 67470 RVA: 0x004058BE File Offset: 0x00403ABE
	[Nullable(1)]
	public static LoginModel Instance
	{
		[NullableContext(1)]
		get
		{
			return LoginModel._Instance;
		}
	}

	// Token: 0x0601078F RID: 67471 RVA: 0x004058C5 File Offset: 0x00403AC5
	[NullableContext(1)]
	public static LoginModel GetOrCreateInstance()
	{
		if (LoginModel._Instance == null)
		{
			LoginModel.CreateInstance();
		}
		return LoginModel._Instance;
	}

	// Token: 0x06010790 RID: 67472 RVA: 0x004058D9 File Offset: 0x00403AD9
	public static bool CreateInstance()
	{
		if (LoginModel._Instance != null)
		{
			return true;
		}
		LoginModel._Instance = new LoginModel();
		return true;
	}

	// Token: 0x06010791 RID: 67473 RVA: 0x004058EF File Offset: 0x00403AEF
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06010792 RID: 67474 RVA: 0x004058F1 File Offset: 0x00403AF1
	public static void ResetStaticDefaultValue()
	{
		LoginModel._Instance = null;
	}

	// Token: 0x06010793 RID: 67475 RVA: 0x004058F9 File Offset: 0x00403AF9
	static LoginModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(LoginModel.CreateStaticDefaultValue), new Action(LoginModel.ResetStaticDefaultValue));
	}

	// Token: 0x04007987 RID: 31111
	[Nullable(1)]
	private const string LOADING_WIDGET_KEY = "loading_widget";

	// Token: 0x04007988 RID: 31112
	[Nullable(1)]
	private const string BACK_TO_GAME_KEY = "back_to_game";

	// Token: 0x04007989 RID: 31113
	[Nullable(1)]
	public const string STREAM = "Stream";

	// Token: 0x0400798A RID: 31114
	[Nullable(1)]
	public const string STREAM_MAINLINE = "mainline";

	// Token: 0x0400798B RID: 31115
	[Nullable(1)]
	public const string DEFAULT_SERVER_IP = "127.0.0.1";

	// Token: 0x0400798C RID: 31116
	public EBornMode BornMode = EBornMode.PlayLocationDefaultPlayerStart;

	// Token: 0x0400798D RID: 31117
	public Aki.Protocol.Vector BornLocation;

	// Token: 0x0400798E RID: 31118
	[Nullable(1)]
	public string Platform = string.Empty;

	// Token: 0x0400798F RID: 31119
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<LoginMapConfig> SingleMapList;

	// Token: 0x04007990 RID: 31120
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<LoginMapConfig> MultiMapList;

	// Token: 0x04007991 RID: 31121
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<ServerConfig> ServerInfoList;

	// Token: 0x04007992 RID: 31122
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<ServerData> ServerDataList;

	// Token: 0x04007993 RID: 31123
	private string ServerCustomPort;

	// Token: 0x04007994 RID: 31124
	private LoginDefine.ELoginStatus LoginStatus;

	// Token: 0x04007995 RID: 31125
	private LoginDefine.ELoginStatus? LastFailStatus;

	// Token: 0x04007996 RID: 31126
	private bool AutoOpenLoginView;

	// Token: 0x04007997 RID: 31127
	private ReconnectInfo ReconnectInfo;

	// Token: 0x04007998 RID: 31128
	[Nullable(1)]
	private string PlayerName = string.Empty;

	// Token: 0x04007999 RID: 31129
	private LoginDefine.ELoginSex? PlayerSex;

	// Token: 0x0400799A RID: 31130
	private bool HasCharacter;

	// Token: 0x0400799B RID: 31131
	private bool IsNewAccountInternal;

	// Token: 0x0400799C RID: 31132
	public bool SmokeTestReady;

	// Token: 0x0400799D RID: 31133
	[Nullable(1)]
	public string CurrentIdStr = string.Empty;

	// Token: 0x0400799E RID: 31134
	public bool SdkAccountChangeNeedExitFlag;

	// Token: 0x0400799F RID: 31135
	[Nullable(1)]
	public string ThirdGameAutoLoginId = "-1";

	// Token: 0x040079A0 RID: 31136
	private int RpcInc;

	// Token: 0x040079A1 RID: 31137
	[Nullable(1)]
	private readonly Dictionary<int, TimerHandle> HttpRpcMap = new Dictionary<int, TimerHandle>();

	// Token: 0x040079A2 RID: 31138
	private SdkLoginConfig SdkLoginConfig;

	// Token: 0x040079A3 RID: 31139
	private SdkLoginConfig LoginToGameServerSdkLoginConfig;

	// Token: 0x040079A4 RID: 31140
	private bool IfFirstTimeLogin;

	// Token: 0x040079A5 RID: 31141
	private double CreatePlayerTime;

	// Token: 0x040079A6 RID: 31142
	private int CreatePlayerId;

	// Token: 0x040079A7 RID: 31143
	private string ServerIp;

	// Token: 0x040079A8 RID: 31144
	private string ServerName;

	// Token: 0x040079A9 RID: 31145
	private string ServerId = "0";

	// Token: 0x040079AA RID: 31146
	private SdkLoginInfo SdkLoginInfo;

	// Token: 0x040079AB RID: 31147
	[Nullable(1)]
	public string SdkAccessToken = string.Empty;

	// Token: 0x040079AC RID: 31148
	public int SdkAccessTokenRunTime;

	// Token: 0x040079AD RID: 31149
	public bool SdkAccessTokenCountingState;

	// Token: 0x040079AE RID: 31150
	private LoginDefine.ESdkLoginState SdkLoginState;

	// Token: 0x040079AF RID: 31151
	public LoginNotice LoginNotice;

	// Token: 0x040079B0 RID: 31152
	private int PublicJsonVersionInternal;

	// Token: 0x040079B1 RID: 31153
	private string SourceAccount;

	// Token: 0x040079B2 RID: 31154
	public bool IsCopyAccount;

	// Token: 0x040079B3 RID: 31155
	public double LoginTimeStamp;

	// Token: 0x040079B4 RID: 31156
	public double HealthTipTime;

	// Token: 0x040079B5 RID: 31157
	[Nullable(1)]
	public string SelectedUdpHost = "";

	// Token: 0x040079B6 RID: 31158
	public bool UdpHostPickByDetection;

	// Token: 0x040079B7 RID: 31159
	public int ConnectFamily;

	// Token: 0x040079B8 RID: 31160
	public int UdpPort;

	// Token: 0x040079B9 RID: 31161
	[Nullable(1)]
	public string ResolvedIp = "";

	// Token: 0x040079BA RID: 31162
	[Nullable(1)]
	public string PingResults = "";

	// Token: 0x040079BB RID: 31163
	[Nullable(1)]
	public string GarPingResults = "";

	// Token: 0x040079BC RID: 31164
	private int PublicMiscVersionInternal;

	// Token: 0x040079BD RID: 31165
	private int PublicUniverseEditorVersionInternal;

	// Token: 0x040079BE RID: 31166
	private string LauncherVersionInternal;

	// Token: 0x040079BF RID: 31167
	private string ResourceVersionInternal;

	// Token: 0x040079C0 RID: 31168
	private int? ServerUniverseEditorVersionInternal;

	// Token: 0x040079C1 RID: 31169
	private TimerHandle VerifyVersionHandleInternal;

	// Token: 0x040079C2 RID: 31170
	private LogoutNotify LogoutNotifyInternal;

	// Token: 0x040079C3 RID: 31171
	private readonly int MaxRecentlyAccountNumber = 10;

	// Token: 0x040079C4 RID: 31172
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<string> RecentlyAccountList;

	// Token: 0x040079C5 RID: 31173
	private string LoginTraceIdInternal;

	// Token: 0x040079C6 RID: 31174
	private CustomPromise LoginPromiseInternal;

	// Token: 0x040079C7 RID: 31175
	private CustomPromise<bool> AutoLoginPromiseInternal;

	// Token: 0x040079C8 RID: 31176
	public TimerHandle AutoLoginTimerIdInternal;

	// Token: 0x040079C9 RID: 31177
	private string CpuInfoInternal;

	// Token: 0x040079CA RID: 31178
	private string DeviceInfoInternal;

	// Token: 0x040079CB RID: 31179
	private string DriverDateInternal;

	// Token: 0x040079CC RID: 31180
	private BackToGameData BackToGameData;

	// Token: 0x040079CD RID: 31181
	private int TryBackToGameFailCount;

	// Token: 0x040079CE RID: 31182
	public readonly int TryBackToGameMaxCount = 5;

	// Token: 0x040079CF RID: 31183
	private static LoginModel _Instance;
}
