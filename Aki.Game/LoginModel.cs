using System;
using System.Collections.Generic;
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

// Token: 0x02001574 RID: 5492
[NullableContext(2)]
[Nullable(0)]
[Model(0)]
public class LoginModel : ModelBase
{
	// Token: 0x17001476 RID: 5238
	// (get) Token: 0x0600DB70 RID: 56176 RVA: 0x004105DA File Offset: 0x0040E7DA
	public bool IsNewAccount
	{
		get
		{
			return this.IsNewAccountInternal;
		}
	}

	// Token: 0x17001477 RID: 5239
	// (get) Token: 0x0600DB71 RID: 56177 RVA: 0x004105E2 File Offset: 0x0040E7E2
	// (set) Token: 0x0600DB72 RID: 56178 RVA: 0x004105EB File Offset: 0x0040E7EB
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

	// Token: 0x17001478 RID: 5240
	// (get) Token: 0x0600DB73 RID: 56179 RVA: 0x004105F5 File Offset: 0x0040E7F5
	// (set) Token: 0x0600DB74 RID: 56180 RVA: 0x00410606 File Offset: 0x0040E806
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

	// Token: 0x17001479 RID: 5241
	// (get) Token: 0x0600DB75 RID: 56181 RVA: 0x00410610 File Offset: 0x0040E810
	// (set) Token: 0x0600DB76 RID: 56182 RVA: 0x00410621 File Offset: 0x0040E821
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

	// Token: 0x0600DB77 RID: 56183 RVA: 0x0041062B File Offset: 0x0040E82B
	public void ClearDetectionCache()
	{
		this.ConnectFamily = 0;
		this.UdpPort = 0;
		this.ResolvedIp = "";
		this.PingResults = "";
	}

	// Token: 0x1700147A RID: 5242
	// (get) Token: 0x0600DB78 RID: 56184 RVA: 0x00410651 File Offset: 0x0040E851
	// (set) Token: 0x0600DB79 RID: 56185 RVA: 0x00410659 File Offset: 0x0040E859
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

	// Token: 0x1700147B RID: 5243
	// (get) Token: 0x0600DB7A RID: 56186 RVA: 0x00410662 File Offset: 0x0040E862
	// (set) Token: 0x0600DB7B RID: 56187 RVA: 0x0041066A File Offset: 0x0040E86A
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

	// Token: 0x1700147C RID: 5244
	// (get) Token: 0x0600DB7C RID: 56188 RVA: 0x00410673 File Offset: 0x0040E873
	// (set) Token: 0x0600DB7D RID: 56189 RVA: 0x0041067B File Offset: 0x0040E87B
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

	// Token: 0x1700147D RID: 5245
	// (get) Token: 0x0600DB7E RID: 56190 RVA: 0x00410684 File Offset: 0x0040E884
	// (set) Token: 0x0600DB7F RID: 56191 RVA: 0x0041068C File Offset: 0x0040E88C
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

	// Token: 0x1700147E RID: 5246
	// (get) Token: 0x0600DB80 RID: 56192 RVA: 0x00410695 File Offset: 0x0040E895
	// (set) Token: 0x0600DB81 RID: 56193 RVA: 0x0041069D File Offset: 0x0040E89D
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

	// Token: 0x1700147F RID: 5247
	// (get) Token: 0x0600DB82 RID: 56194 RVA: 0x004106A6 File Offset: 0x0040E8A6
	// (set) Token: 0x0600DB83 RID: 56195 RVA: 0x004106AE File Offset: 0x0040E8AE
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

	// Token: 0x0600DB84 RID: 56196 RVA: 0x004106B8 File Offset: 0x0040E8B8
	[NullableContext(1)]
	public static bool IsConfigVersionMismatch(string clientRawValue, int? serverValue)
	{
		int num;
		return int.TryParse(clientRawValue, out num) && serverValue != null && num != serverValue.Value;
	}

	// Token: 0x17001480 RID: 5248
	// (get) Token: 0x0600DB85 RID: 56197 RVA: 0x004106E7 File Offset: 0x0040E8E7
	// (set) Token: 0x0600DB86 RID: 56198 RVA: 0x004106EF File Offset: 0x0040E8EF
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

	// Token: 0x0600DB87 RID: 56199 RVA: 0x004106F8 File Offset: 0x0040E8F8
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

	// Token: 0x0600DB88 RID: 56200 RVA: 0x00410780 File Offset: 0x0040E980
	protected override bool OnClear()
	{
		this.LoginStatus = LoginDefine.ELoginStatus.Init;
		this.SelectedAccountLoginMode = LoginDefine.EAccountLoginMode.NewAccount;
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

	// Token: 0x0600DB89 RID: 56201 RVA: 0x00410860 File Offset: 0x0040EA60
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

	// Token: 0x0600DB8A RID: 56202 RVA: 0x0041092C File Offset: 0x0040EB2C
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

	// Token: 0x0600DB8B RID: 56203 RVA: 0x00410A04 File Offset: 0x0040EC04
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

	// Token: 0x0600DB8C RID: 56204 RVA: 0x00410A5C File Offset: 0x0040EC5C
	[NullableContext(1)]
	public void AddServerInfos(ServerInfo[] serverInfoArray)
	{
		if (this.ServerInfoList == null)
		{
			return;
		}
		foreach (ServerInfo serverInfo in serverInfoArray)
		{
			if (serverInfo.package != null)
			{
				this.ServerInfoList.Add(new ServerConfig(serverInfo.address, "5500", serverInfo.description, serverInfo.order.GetValueOrDefault()));
			}
		}
	}

	// Token: 0x0600DB8D RID: 56205 RVA: 0x00410AC0 File Offset: 0x0040ECC0
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

	// Token: 0x0600DB8E RID: 56206 RVA: 0x00410B48 File Offset: 0x0040ED48
	public void CleanConfig()
	{
		this.SingleMapList = null;
		this.MultiMapList = null;
		this.ServerInfoList = null;
		this.SdkLoginConfig = null;
		this.ServerDataList = null;
	}

	// Token: 0x0600DB8F RID: 56207 RVA: 0x00410B6D File Offset: 0x0040ED6D
	public void SetCreatePlayerTime(double time)
	{
		this.CreatePlayerTime = time;
	}

	// Token: 0x0600DB90 RID: 56208 RVA: 0x00410B76 File Offset: 0x0040ED76
	public double GetCreatePlayerTime()
	{
		return this.CreatePlayerTime;
	}

	// Token: 0x0600DB91 RID: 56209 RVA: 0x00410B7E File Offset: 0x0040ED7E
	public void SetCreatePlayerId(int id)
	{
		this.CreatePlayerId = id;
	}

	// Token: 0x0600DB92 RID: 56210 RVA: 0x00410B87 File Offset: 0x0040ED87
	public int GetCreatePlayerId()
	{
		return this.CreatePlayerId;
	}

	// Token: 0x0600DB93 RID: 56211 RVA: 0x00410B8F File Offset: 0x0040ED8F
	public string GetServerIp()
	{
		return this.ServerIp;
	}

	// Token: 0x0600DB94 RID: 56212 RVA: 0x00410B97 File Offset: 0x0040ED97
	public string GetSourcePlayerAccount()
	{
		return this.SourceAccount;
	}

	// Token: 0x0600DB95 RID: 56213 RVA: 0x00410BA0 File Offset: 0x0040EDA0
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

	// Token: 0x0600DB96 RID: 56214 RVA: 0x00410C0C File Offset: 0x0040EE0C
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

	// Token: 0x0600DB97 RID: 56215 RVA: 0x00410C78 File Offset: 0x0040EE78
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

	// Token: 0x0600DB98 RID: 56216 RVA: 0x00410C9E File Offset: 0x0040EE9E
	public string GetCustomServerPort()
	{
		return this.ServerCustomPort;
	}

	// Token: 0x0600DB99 RID: 56217 RVA: 0x00410CA8 File Offset: 0x0040EEA8
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

	// Token: 0x0600DB9A RID: 56218 RVA: 0x00410D01 File Offset: 0x0040EF01
	public string GetServerName()
	{
		return this.ServerName;
	}

	// Token: 0x0600DB9B RID: 56219 RVA: 0x00410D0C File Offset: 0x0040EF0C
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

	// Token: 0x0600DB9C RID: 56220 RVA: 0x00410D47 File Offset: 0x0040EF47
	public string GetServerId()
	{
		return this.ServerId;
	}

	// Token: 0x0600DB9D RID: 56221 RVA: 0x00410D50 File Offset: 0x0040EF50
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

	// Token: 0x0600DB9E RID: 56222 RVA: 0x00410D9C File Offset: 0x0040EF9C
	public int GetSingleMapId()
	{
		int global = LocalStorage.GetGlobal<int>(ELocalStorageGlobalKey.SingleMapId, -1);
		if (global != -1)
		{
			return global;
		}
		return 0;
	}

	// Token: 0x0600DB9F RID: 56223 RVA: 0x00410DB8 File Offset: 0x0040EFB8
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

	// Token: 0x0600DBA0 RID: 56224 RVA: 0x00410DF8 File Offset: 0x0040EFF8
	public int GetMultiMapId()
	{
		int global = LocalStorage.GetGlobal<int>(ELocalStorageGlobalKey.MultiMapId, -1);
		if (global != -1)
		{
			return global;
		}
		return 0;
	}

	// Token: 0x0600DBA1 RID: 56225 RVA: 0x00410E14 File Offset: 0x0040F014
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

	// Token: 0x0600DBA2 RID: 56226 RVA: 0x00410E54 File Offset: 0x0040F054
	[NullableContext(1)]
	public string GetAccount()
	{
		return LocalStorage.GetGlobal<string>(ELocalStorageGlobalKey.Account, string.Empty) ?? string.Empty;
	}

	// Token: 0x0600DBA3 RID: 56227 RVA: 0x00410E6B File Offset: 0x0040F06B
	[NullableContext(1)]
	public void SetAccount(string account)
	{
		LocalStorage.SetGlobal<string>(ELocalStorageGlobalKey.Account, account);
		this.AddRecentlyAccount(account);
		ThirdPartySdkManager.Instance.SetUserInfo(account);
	}

	// Token: 0x0600DBA4 RID: 56228 RVA: 0x00410E88 File Offset: 0x0040F088
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

	// Token: 0x0600DBA5 RID: 56229 RVA: 0x00410EC2 File Offset: 0x0040F0C2
	public bool GetSelectBoxActive()
	{
		return LocalStorage.GetGlobal<bool>(ELocalStorageGlobalKey.SelectBoxActive, true);
	}

	// Token: 0x0600DBA6 RID: 56230 RVA: 0x00410ECB File Offset: 0x0040F0CB
	public void SetSelectBoxActive(bool selectBoxActive)
	{
		LocalStorage.SetGlobal<bool>(ELocalStorageGlobalKey.SelectBoxActive, selectBoxActive);
	}

	// Token: 0x0600DBA7 RID: 56231 RVA: 0x00410ED5 File Offset: 0x0040F0D5
	public bool GetAutoOpenLoginView()
	{
		return this.AutoOpenLoginView;
	}

	// Token: 0x0600DBA8 RID: 56232 RVA: 0x00410EDD File Offset: 0x0040F0DD
	public void SetAutoOpenLoginView(bool ret)
	{
		this.AutoOpenLoginView = ret;
	}

	// Token: 0x0600DBA9 RID: 56233 RVA: 0x00410EE6 File Offset: 0x0040F0E6
	public LoginDefine.ELoginStatus GetLoginStatus()
	{
		return this.LoginStatus;
	}

	// Token: 0x0600DBAA RID: 56234 RVA: 0x00410EEE File Offset: 0x0040F0EE
	public LoginDefine.ELoginStatus? GetLastFailStatus()
	{
		return this.LastFailStatus;
	}

	// Token: 0x0600DBAB RID: 56235 RVA: 0x00410EF8 File Offset: 0x0040F0F8
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

	// Token: 0x0600DBAC RID: 56236 RVA: 0x00410FE2 File Offset: 0x0040F1E2
	public bool IsLoginStatus(LoginDefine.ELoginStatus loginStatus)
	{
		return this.LoginStatus == loginStatus;
	}

	// Token: 0x0600DBAD RID: 56237 RVA: 0x00410FED File Offset: 0x0040F1ED
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

	// Token: 0x0600DBAE RID: 56238 RVA: 0x00411021 File Offset: 0x0040F221
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

	// Token: 0x0600DBAF RID: 56239 RVA: 0x0041105A File Offset: 0x0040F25A
	public SdkLoginInfo GetSdkLoginInfo()
	{
		return this.SdkLoginInfo;
	}

	// Token: 0x0600DBB0 RID: 56240 RVA: 0x00411062 File Offset: 0x0040F262
	public bool IsSdkLoggedIn()
	{
		return this.SdkLoginState == LoginDefine.ESdkLoginState.Login;
	}

	// Token: 0x0600DBB1 RID: 56241 RVA: 0x0041106D File Offset: 0x0040F26D
	public bool IsSdkLoggingIn()
	{
		return this.SdkLoginState == LoginDefine.ESdkLoginState.LoggingIn;
	}

	// Token: 0x0600DBB2 RID: 56242 RVA: 0x00411078 File Offset: 0x0040F278
	public bool IsSdkLogout()
	{
		return this.SdkLoginState == LoginDefine.ESdkLoginState.Logout;
	}

	// Token: 0x0600DBB3 RID: 56243 RVA: 0x00411083 File Offset: 0x0040F283
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public List<LoginMapConfig> GetSingleMapList()
	{
		return this.SingleMapList;
	}

	// Token: 0x0600DBB4 RID: 56244 RVA: 0x0041108C File Offset: 0x0040F28C
	public int? GetSingleMapIp(int index)
	{
		if (this.SingleMapList != null && index < this.SingleMapList.Count)
		{
			return new int?(this.SingleMapList[index].MapId);
		}
		return null;
	}

	// Token: 0x0600DBB5 RID: 56245 RVA: 0x004110D0 File Offset: 0x0040F2D0
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public List<ServerConfig> GetServerInfoList()
	{
		if (this.ServerInfoList != null)
		{
			List<ServerConfig> list = new List<ServerConfig>(this.ServerInfoList);
			for (int i = 1; i < list.Count; i++)
			{
				ServerConfig serverConfig = list[i];
				int num = i - 1;
				while (num >= 0 && list[num].Order.CompareTo(serverConfig.Order) > 0)
				{
					list[num + 1] = list[num];
					num--;
				}
				list[num + 1] = serverConfig;
			}
			this.ServerInfoList = list;
		}
		return this.ServerInfoList;
	}

	// Token: 0x0600DBB6 RID: 56246 RVA: 0x00411159 File Offset: 0x0040F359
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public List<ServerData> GetServerDataList()
	{
		return this.ServerDataList;
	}

	// Token: 0x0600DBB7 RID: 56247 RVA: 0x00411161 File Offset: 0x0040F361
	public ServerConfig GetServerInfo(int index)
	{
		if (this.ServerInfoList != null && index < this.ServerInfoList.Count)
		{
			return this.ServerInfoList[index];
		}
		return null;
	}

	// Token: 0x0600DBB8 RID: 56248 RVA: 0x00411187 File Offset: 0x0040F387
	public bool HasReconnectInfo()
	{
		return this.ReconnectInfo != null;
	}

	// Token: 0x0600DBB9 RID: 56249 RVA: 0x00411192 File Offset: 0x0040F392
	[NullableContext(1)]
	public void SetReconnectInfo(string token, string host, int port)
	{
		this.ReconnectInfo = new ReconnectInfo(token, host, port);
	}

	// Token: 0x0600DBBA RID: 56250 RVA: 0x004111A2 File Offset: 0x0040F3A2
	[NullableContext(1)]
	public void SetReconnectToken(string token)
	{
		if (this.ReconnectInfo != null)
		{
			this.ReconnectInfo.Token = token;
		}
	}

	// Token: 0x0600DBBB RID: 56251 RVA: 0x004111B8 File Offset: 0x0040F3B8
	public string GetReconnectToken()
	{
		if (this.ReconnectInfo == null)
		{
			return null;
		}
		return this.ReconnectInfo.Token;
	}

	// Token: 0x0600DBBC RID: 56252 RVA: 0x004111CF File Offset: 0x0040F3CF
	public string GetReconnectHost()
	{
		if (this.ReconnectInfo == null)
		{
			return null;
		}
		return this.ReconnectInfo.Host;
	}

	// Token: 0x0600DBBD RID: 56253 RVA: 0x004111E8 File Offset: 0x0040F3E8
	public int? GetReconnectPort()
	{
		if (this.ReconnectInfo == null)
		{
			return null;
		}
		return new int?(this.ReconnectInfo.Port);
	}

	// Token: 0x0600DBBE RID: 56254 RVA: 0x00411217 File Offset: 0x0040F417
	public string GetPlayerName()
	{
		return this.PlayerName;
	}

	// Token: 0x0600DBBF RID: 56255 RVA: 0x0041121F File Offset: 0x0040F41F
	[NullableContext(1)]
	public void SetPlayerName(string playerName)
	{
		this.PlayerName = playerName;
	}

	// Token: 0x0600DBC0 RID: 56256 RVA: 0x00411228 File Offset: 0x0040F428
	public int? GetPlayerSex()
	{
		if (this.PlayerSex == null)
		{
			return null;
		}
		return new int?((int)this.PlayerSex.Value);
	}

	// Token: 0x0600DBC1 RID: 56257 RVA: 0x0041125C File Offset: 0x0040F45C
	public void SetPlayerSex(LoginDefine.ELoginSex playerSex)
	{
		this.PlayerSex = new LoginDefine.ELoginSex?(playerSex);
	}

	// Token: 0x0600DBC2 RID: 56258 RVA: 0x0041126C File Offset: 0x0040F46C
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

	// Token: 0x0600DBC3 RID: 56259 RVA: 0x004112D2 File Offset: 0x0040F4D2
	public bool GetHasCharacter()
	{
		return this.HasCharacter;
	}

	// Token: 0x0600DBC4 RID: 56260 RVA: 0x004112DA File Offset: 0x0040F4DA
	public void SetHasCharacter(bool hasCharacter)
	{
		this.HasCharacter = hasCharacter;
	}

	// Token: 0x0600DBC5 RID: 56261 RVA: 0x004112E3 File Offset: 0x0040F4E3
	public void SetIsNewAccount(bool isNewAccount)
	{
		this.IsNewAccountInternal = isNewAccount;
	}

	// Token: 0x0600DBC6 RID: 56262 RVA: 0x004112EC File Offset: 0x0040F4EC
	public void CleanCreateData()
	{
		this.HasCharacter = false;
		this.PlayerName = string.Empty;
		this.PlayerSex = null;
	}

	// Token: 0x0600DBC7 RID: 56263 RVA: 0x0041130C File Offset: 0x0040F50C
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

	// Token: 0x0600DBC8 RID: 56264 RVA: 0x00411380 File Offset: 0x0040F580
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

	// Token: 0x0600DBC9 RID: 56265 RVA: 0x004113BC File Offset: 0x0040F5BC
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

	// Token: 0x0600DBCA RID: 56266 RVA: 0x00411444 File Offset: 0x0040F644
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

	// Token: 0x0600DBCB RID: 56267 RVA: 0x0041150D File Offset: 0x0040F70D
	public void CleanLoginFailCount(LoginDefine.ECleanFailCountWay way)
	{
		this.SetLoginFailCount(0, false);
		this.SetNextLoginTime(0.0, false);
		this.SetResetLoginFailCountTime(0.0, false);
	}

	// Token: 0x0600DBCC RID: 56268 RVA: 0x00411537 File Offset: 0x0040F737
	public void SetLoginFailCount(int count, bool isLog = true)
	{
		this.LoginFailCount = count;
	}

	// Token: 0x0600DBCD RID: 56269 RVA: 0x00411544 File Offset: 0x0040F744
	private void SetNextLoginTime(double addTime, bool isLog = true)
	{
		this.NextLoginTime = (double)DateTimeOffset.Now.ToUnixTimeMilliseconds() * 0.001;
		if (isLog)
		{
			DateTime dateTime = DateTimeOffset.FromUnixTimeMilliseconds((long)((this.NextLoginTime + addTime) * 1000.0)).DateTime;
		}
	}

	// Token: 0x0600DBCE RID: 56270 RVA: 0x00411594 File Offset: 0x0040F794
	private void SetResetLoginFailCountTime(double addTime, bool isLog = true)
	{
		this.ResetLoginFailCountTime = (double)DateTimeOffset.Now.ToUnixTimeMilliseconds() * 0.001;
		if (isLog)
		{
			DateTime dateTime = DateTimeOffset.FromUnixTimeMilliseconds((long)((this.ResetLoginFailCountTime + addTime) * 1000.0)).DateTime;
		}
	}

	// Token: 0x0600DBCF RID: 56271 RVA: 0x004115E4 File Offset: 0x0040F7E4
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

	// Token: 0x0600DBD0 RID: 56272 RVA: 0x00411680 File Offset: 0x0040F880
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

	// Token: 0x0600DBD1 RID: 56273 RVA: 0x004116F0 File Offset: 0x0040F8F0
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

	// Token: 0x0600DBD2 RID: 56274 RVA: 0x0041177C File Offset: 0x0040F97C
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

	// Token: 0x0600DBD3 RID: 56275 RVA: 0x0041182F File Offset: 0x0040FA2F
	public SdkLoginConfig GetSdkLoginConfig()
	{
		return this.SdkLoginConfig;
	}

	// Token: 0x0600DBD4 RID: 56276 RVA: 0x00411837 File Offset: 0x0040FA37
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

	// Token: 0x0600DBD5 RID: 56277 RVA: 0x00411871 File Offset: 0x0040FA71
	[NullableContext(1)]
	public string GetLoginUserName()
	{
		if (this.SdkLoginConfig == null)
		{
			return string.Empty;
		}
		return this.SdkLoginConfig.UserName;
	}

	// Token: 0x0600DBD6 RID: 56278 RVA: 0x0041188C File Offset: 0x0040FA8C
	[NullableContext(1)]
	public string GetLoginUserNameWithUriEncode()
	{
		if (this.SdkLoginConfig == null)
		{
			return string.Empty;
		}
		return this.SdkLoginConfig.GetLoginUserNameWithUriEncode();
	}

	// Token: 0x0600DBD7 RID: 56279 RVA: 0x004118A7 File Offset: 0x0040FAA7
	[NullableContext(1)]
	public string GetLoginToken()
	{
		if (this.SdkLoginConfig == null)
		{
			return string.Empty;
		}
		return this.SdkLoginConfig.Token;
	}

	// Token: 0x17001481 RID: 5249
	// (get) Token: 0x0600DBD8 RID: 56280 RVA: 0x004118C2 File Offset: 0x0040FAC2
	// (set) Token: 0x0600DBD9 RID: 56281 RVA: 0x004118CA File Offset: 0x0040FACA
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

	// Token: 0x0600DBDA RID: 56282 RVA: 0x004118D3 File Offset: 0x0040FAD3
	public void SetTodayFirstTimeLogin(bool ret)
	{
		this.IfFirstTimeLogin = ret;
	}

	// Token: 0x0600DBDB RID: 56283 RVA: 0x004118DC File Offset: 0x0040FADC
	public bool GetTodayFirstTimeLogin()
	{
		return this.IfFirstTimeLogin;
	}

	// Token: 0x0600DBDC RID: 56284 RVA: 0x004118E4 File Offset: 0x0040FAE4
	public double GetLastLoginTime()
	{
		return LocalStorage.GetPlayer<double>(ELocalStoragePlayerKey.LoginTime, 0.0);
	}

	// Token: 0x0600DBDD RID: 56285 RVA: 0x004118F6 File Offset: 0x0040FAF6
	public void SetLastLoginTime(double time)
	{
		LocalStorage.SetPlayer<double>(ELocalStoragePlayerKey.LoginTime, time);
	}

	// Token: 0x0600DBDE RID: 56286 RVA: 0x00411904 File Offset: 0x0040FB04
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

	// Token: 0x0600DBDF RID: 56287 RVA: 0x0041199A File Offset: 0x0040FB9A
	public void InitRecentlyAccountList()
	{
		this.RecentlyAccountList = LocalStorage.GetGlobal<List<string>>(ELocalStorageGlobalKey.RecentlyAccountList, null);
		if (this.RecentlyAccountList == null)
		{
			this.RecentlyAccountList = new List<string>();
		}
	}

	// Token: 0x0600DBE0 RID: 56288 RVA: 0x004119BD File Offset: 0x0040FBBD
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public List<string> GetRecentlyAccountList()
	{
		return this.RecentlyAccountList;
	}

	// Token: 0x0600DBE1 RID: 56289 RVA: 0x004119C5 File Offset: 0x0040FBC5
	public void SaveRecentlyAccountList()
	{
		if (this.RecentlyAccountList != null)
		{
			LocalStorage.SetGlobal<List<string>>(ELocalStorageGlobalKey.RecentlyAccountList, this.RecentlyAccountList);
		}
	}

	// Token: 0x17001482 RID: 5250
	// (get) Token: 0x0600DBE2 RID: 56290 RVA: 0x004119DD File Offset: 0x0040FBDD
	// (set) Token: 0x0600DBE3 RID: 56291 RVA: 0x004119E5 File Offset: 0x0040FBE5
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

	// Token: 0x0600DBE4 RID: 56292 RVA: 0x004119F9 File Offset: 0x0040FBF9
	public void CreateLoginPromise()
	{
		this.LoginPromiseInternal = new CustomPromise();
	}

	// Token: 0x0600DBE5 RID: 56293 RVA: 0x00411A06 File Offset: 0x0040FC06
	public void FinishLoginPromise()
	{
		CustomPromise loginPromiseInternal = this.LoginPromiseInternal;
		if (loginPromiseInternal == null)
		{
			return;
		}
		loginPromiseInternal.SetResult();
	}

	// Token: 0x0600DBE6 RID: 56294 RVA: 0x00411A18 File Offset: 0x0040FC18
	public UniTask WaitLoginPromise()
	{
		LoginModel.<WaitLoginPromise>d__195 <WaitLoginPromise>d__;
		<WaitLoginPromise>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<WaitLoginPromise>d__.<>4__this = this;
		<WaitLoginPromise>d__.<>1__state = -1;
		<WaitLoginPromise>d__.<>t__builder.Start<LoginModel.<WaitLoginPromise>d__195>(ref <WaitLoginPromise>d__);
		return <WaitLoginPromise>d__.<>t__builder.Task;
	}

	// Token: 0x0600DBE7 RID: 56295 RVA: 0x00411A5B File Offset: 0x0040FC5B
	public bool HasLoginPromise()
	{
		return this.LoginPromiseInternal != null;
	}

	// Token: 0x0600DBE8 RID: 56296 RVA: 0x00411A66 File Offset: 0x0040FC66
	public void CreateAutoLoginPromise()
	{
		this.AutoLoginPromiseInternal = new CustomPromise<bool>();
	}

	// Token: 0x0600DBE9 RID: 56297 RVA: 0x00411A73 File Offset: 0x0040FC73
	public void ClearAutoLoginPromise()
	{
		this.AutoLoginPromiseInternal = null;
	}

	// Token: 0x0600DBEA RID: 56298 RVA: 0x00411A7C File Offset: 0x0040FC7C
	public void FinishAutoLoginPromise(bool value)
	{
		this.AutoLoginPromiseInternal.SetResult(value);
	}

	// Token: 0x0600DBEB RID: 56299 RVA: 0x00411A8C File Offset: 0x0040FC8C
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

	// Token: 0x0600DBEC RID: 56300 RVA: 0x00411ACF File Offset: 0x0040FCCF
	public bool HasAutoLoginPromise()
	{
		return this.AutoLoginPromiseInternal != null;
	}

	// Token: 0x17001483 RID: 5251
	// (get) Token: 0x0600DBED RID: 56301 RVA: 0x00411ADA File Offset: 0x0040FCDA
	// (set) Token: 0x0600DBEE RID: 56302 RVA: 0x00411AE2 File Offset: 0x0040FCE2
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

	// Token: 0x0600DBEF RID: 56303 RVA: 0x00411AEB File Offset: 0x0040FCEB
	public void ClearAutoLoginTimerId()
	{
		if (this.AutoLoginTimerId != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.AutoLoginTimerId);
			this.AutoLoginTimerId = null;
		}
	}

	// Token: 0x0600DBF0 RID: 56304 RVA: 0x00411B10 File Offset: 0x0040FD10
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

	// Token: 0x0600DBF1 RID: 56305 RVA: 0x00411B41 File Offset: 0x0040FD41
	public string CpuInfo()
	{
		return this.CpuInfoInternal;
	}

	// Token: 0x0600DBF2 RID: 56306 RVA: 0x00411B49 File Offset: 0x0040FD49
	public string DeviceInfo()
	{
		return this.DeviceInfoInternal;
	}

	// Token: 0x0600DBF3 RID: 56307 RVA: 0x00411B51 File Offset: 0x0040FD51
	public string DriverDate()
	{
		return this.DriverDateInternal;
	}

	// Token: 0x0600DBF4 RID: 56308 RVA: 0x00411B59 File Offset: 0x0040FD59
	public bool HasBackToGameData()
	{
		return this.BackToGameData != null || UKuroVariableFunctionLibrary.HasStringValue("back_to_game");
	}

	// Token: 0x0600DBF5 RID: 56309 RVA: 0x00411B70 File Offset: 0x0040FD70
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

	// Token: 0x0600DBF6 RID: 56310 RVA: 0x00411BDC File Offset: 0x0040FDDC
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

	// Token: 0x0600DBF7 RID: 56311 RVA: 0x00411C50 File Offset: 0x0040FE50
	[NullableContext(1)]
	public unsafe bool SaveBackToGameData(BackToGameData data, bool reset = false)
	{
		string text = Json.Stringify(data, null);
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

	// Token: 0x0600DBF8 RID: 56312 RVA: 0x00411D84 File Offset: 0x0040FF84
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

	// Token: 0x0600DBF9 RID: 56313 RVA: 0x00411E14 File Offset: 0x00410014
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

	// Token: 0x0600DBFA RID: 56314 RVA: 0x00411E85 File Offset: 0x00410085
	public int BackToGameFailCount()
	{
		return this.TryBackToGameFailCount;
	}

	// Token: 0x0600DBFB RID: 56315 RVA: 0x00411E8D File Offset: 0x0041008D
	public bool CheckBackToGameFailCount()
	{
		this.TryBackToGameFailCount++;
		return this.TryBackToGameFailCount <= this.TryBackToGameMaxCount;
	}

	// Token: 0x17001484 RID: 5252
	// (get) Token: 0x0600DBFC RID: 56316 RVA: 0x00411EAE File Offset: 0x004100AE
	[Nullable(1)]
	public static LoginModel Instance
	{
		[NullableContext(1)]
		get
		{
			return LoginModel._Instance;
		}
	}

	// Token: 0x0600DBFD RID: 56317 RVA: 0x00411EB5 File Offset: 0x004100B5
	[NullableContext(1)]
	public static LoginModel GetOrCreateInstance()
	{
		if (LoginModel._Instance == null)
		{
			LoginModel.CreateInstance();
		}
		return LoginModel._Instance;
	}

	// Token: 0x0600DBFE RID: 56318 RVA: 0x00411EC9 File Offset: 0x004100C9
	public static bool CreateInstance()
	{
		if (LoginModel._Instance != null)
		{
			return true;
		}
		LoginModel._Instance = new LoginModel();
		return true;
	}

	// Token: 0x0600DBFF RID: 56319 RVA: 0x00411EDF File Offset: 0x004100DF
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600DC00 RID: 56320 RVA: 0x00411EE1 File Offset: 0x004100E1
	public static void ResetStaticDefaultValue()
	{
		LoginModel._Instance = null;
	}

	// Token: 0x0600DC01 RID: 56321 RVA: 0x00411EE9 File Offset: 0x004100E9
	static LoginModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(LoginModel.CreateStaticDefaultValue), new Action(LoginModel.ResetStaticDefaultValue));
	}

	// Token: 0x04007A85 RID: 31365
	[Nullable(1)]
	private const string LOADING_WIDGET_KEY = "loading_widget";

	// Token: 0x04007A86 RID: 31366
	[Nullable(1)]
	private const string BACK_TO_GAME_KEY = "back_to_game";

	// Token: 0x04007A87 RID: 31367
	[Nullable(1)]
	public const string STREAM = "Stream";

	// Token: 0x04007A88 RID: 31368
	[Nullable(1)]
	public const string STREAM_MAINLINE = "mainline";

	// Token: 0x04007A89 RID: 31369
	[Nullable(1)]
	public const string DEFAULT_SERVER_IP = "127.0.0.1";

	// Token: 0x04007A8A RID: 31370
	public EBornMode BornMode = EBornMode.PlayLocationDefaultPlayerStart;

	// Token: 0x04007A8B RID: 31371
	public Aki.Protocol.Vector BornLocation;

	// Token: 0x04007A8C RID: 31372
	[Nullable(1)]
	public string Platform = string.Empty;

	// Token: 0x04007A8D RID: 31373
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<LoginMapConfig> SingleMapList;

	// Token: 0x04007A8E RID: 31374
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<LoginMapConfig> MultiMapList;

	// Token: 0x04007A8F RID: 31375
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<ServerConfig> ServerInfoList;

	// Token: 0x04007A90 RID: 31376
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<ServerData> ServerDataList;

	// Token: 0x04007A91 RID: 31377
	private string ServerCustomPort;

	// Token: 0x04007A92 RID: 31378
	private LoginDefine.ELoginStatus LoginStatus;

	// Token: 0x04007A93 RID: 31379
	private LoginDefine.ELoginStatus? LastFailStatus;

	// Token: 0x04007A94 RID: 31380
	private bool AutoOpenLoginView;

	// Token: 0x04007A95 RID: 31381
	private ReconnectInfo ReconnectInfo;

	// Token: 0x04007A96 RID: 31382
	[Nullable(1)]
	private string PlayerName = string.Empty;

	// Token: 0x04007A97 RID: 31383
	private LoginDefine.ELoginSex? PlayerSex;

	// Token: 0x04007A98 RID: 31384
	private bool HasCharacter;

	// Token: 0x04007A99 RID: 31385
	private bool IsNewAccountInternal;

	// Token: 0x04007A9A RID: 31386
	public bool SmokeTestReady;

	// Token: 0x04007A9B RID: 31387
	[Nullable(1)]
	public string CurrentIdStr = string.Empty;

	// Token: 0x04007A9C RID: 31388
	public bool SdkAccountChangeNeedExitFlag;

	// Token: 0x04007A9D RID: 31389
	[Nullable(1)]
	public string ThirdGameAutoLoginId = "-1";

	// Token: 0x04007A9E RID: 31390
	private int RpcInc;

	// Token: 0x04007A9F RID: 31391
	[Nullable(1)]
	private readonly Dictionary<int, TimerHandle> HttpRpcMap = new Dictionary<int, TimerHandle>();

	// Token: 0x04007AA0 RID: 31392
	private SdkLoginConfig SdkLoginConfig;

	// Token: 0x04007AA1 RID: 31393
	private SdkLoginConfig LoginToGameServerSdkLoginConfig;

	// Token: 0x04007AA2 RID: 31394
	private bool IfFirstTimeLogin;

	// Token: 0x04007AA3 RID: 31395
	private double CreatePlayerTime;

	// Token: 0x04007AA4 RID: 31396
	private int CreatePlayerId;

	// Token: 0x04007AA5 RID: 31397
	private string ServerIp;

	// Token: 0x04007AA6 RID: 31398
	private string ServerName;

	// Token: 0x04007AA7 RID: 31399
	private string ServerId = "0";

	// Token: 0x04007AA8 RID: 31400
	private SdkLoginInfo SdkLoginInfo;

	// Token: 0x04007AA9 RID: 31401
	[Nullable(1)]
	public string SdkAccessToken = string.Empty;

	// Token: 0x04007AAA RID: 31402
	public int SdkAccessTokenRunTime;

	// Token: 0x04007AAB RID: 31403
	public bool SdkAccessTokenCountingState;

	// Token: 0x04007AAC RID: 31404
	private LoginDefine.ESdkLoginState SdkLoginState;

	// Token: 0x04007AAD RID: 31405
	public LoginNotice LoginNotice;

	// Token: 0x04007AAE RID: 31406
	private int PublicJsonVersionInternal;

	// Token: 0x04007AAF RID: 31407
	private string SourceAccount;

	// Token: 0x04007AB0 RID: 31408
	public LoginDefine.EAccountLoginMode SelectedAccountLoginMode;

	// Token: 0x04007AB1 RID: 31409
	public double LoginTimeStamp;

	// Token: 0x04007AB2 RID: 31410
	public double HealthTipTime;

	// Token: 0x04007AB3 RID: 31411
	[Nullable(1)]
	public string SelectedUdpHost = "";

	// Token: 0x04007AB4 RID: 31412
	public bool UdpHostPickByDetection;

	// Token: 0x04007AB5 RID: 31413
	public int ConnectFamily;

	// Token: 0x04007AB6 RID: 31414
	public int UdpPort;

	// Token: 0x04007AB7 RID: 31415
	[Nullable(1)]
	public string ResolvedIp = "";

	// Token: 0x04007AB8 RID: 31416
	[Nullable(1)]
	public string PingResults = "";

	// Token: 0x04007AB9 RID: 31417
	[Nullable(1)]
	public string GarPingResults = "";

	// Token: 0x04007ABA RID: 31418
	private int PublicMiscVersionInternal;

	// Token: 0x04007ABB RID: 31419
	private int PublicUniverseEditorVersionInternal;

	// Token: 0x04007ABC RID: 31420
	private string LauncherVersionInternal;

	// Token: 0x04007ABD RID: 31421
	private string ResourceVersionInternal;

	// Token: 0x04007ABE RID: 31422
	private int? ServerUniverseEditorVersionInternal;

	// Token: 0x04007ABF RID: 31423
	private TimerHandle VerifyVersionHandleInternal;

	// Token: 0x04007AC0 RID: 31424
	private LogoutNotify LogoutNotifyInternal;

	// Token: 0x04007AC1 RID: 31425
	private readonly int MaxRecentlyAccountNumber = 10;

	// Token: 0x04007AC2 RID: 31426
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<string> RecentlyAccountList;

	// Token: 0x04007AC3 RID: 31427
	private string LoginTraceIdInternal;

	// Token: 0x04007AC4 RID: 31428
	private CustomPromise LoginPromiseInternal;

	// Token: 0x04007AC5 RID: 31429
	private CustomPromise<bool> AutoLoginPromiseInternal;

	// Token: 0x04007AC6 RID: 31430
	public TimerHandle AutoLoginTimerIdInternal;

	// Token: 0x04007AC7 RID: 31431
	private string CpuInfoInternal;

	// Token: 0x04007AC8 RID: 31432
	private string DeviceInfoInternal;

	// Token: 0x04007AC9 RID: 31433
	private string DriverDateInternal;

	// Token: 0x04007ACA RID: 31434
	private BackToGameData BackToGameData;

	// Token: 0x04007ACB RID: 31435
	private int TryBackToGameFailCount;

	// Token: 0x04007ACC RID: 31436
	public readonly int TryBackToGameMaxCount = 5;

	// Token: 0x04007ACD RID: 31437
	private static LoginModel _Instance;
}
