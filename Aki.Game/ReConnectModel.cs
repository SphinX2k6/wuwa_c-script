using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Launcher;
using UnrealEngine;

// Token: 0x02001C3C RID: 7228
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class ReConnectModel : ModelBase
{
	// Token: 0x06011F1E RID: 73502 RVA: 0x00548154 File Offset: 0x00546354
	protected override bool OnInit()
	{
		this.ClearReconnectData();
		this.TotalReConnectCount = 0;
		this.TryReConnectMaxCount = ConfigCommonParamById.GetIntConfig("max_try_reconnect_count").GetValueOrDefault(3);
		this.ReConnectMaxCount = ConfigCommonParamById.GetIntConfig("reconnect_count_per_try").GetValueOrDefault(3);
		this.ServerChannelCloseSeconds = ConfigCommonParamById.GetIntConfig("reconnect_channel_close_seconds").GetValueOrDefault(60);
		this.SilentTimeMs = ConfigCommonParamById.GetIntConfig("reconnect_show_mask_timeout_ms").GetValueOrDefault(1000);
		if (!UKismetSystemLibrary.GetCommandLine().Contains("-InfinityReconnect"))
		{
			this.DebugForeverTryReconnect = false;
		}
		else
		{
			this.DebugForeverTryReconnect = true;
			Log.Instance.Info(ELogModule.Reconnect, ELogAuthor.XMC, "[InfinityReconnect] Enable infinity reconnect.", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		return true;
	}

	// Token: 0x06011F1F RID: 73503 RVA: 0x00548215 File Offset: 0x00546415
	protected override bool OnClear()
	{
		this.ClearReconnectData();
		return true;
	}

	// Token: 0x06011F20 RID: 73504 RVA: 0x0054821E File Offset: 0x0054641E
	public void ClearReconnectData()
	{
		this.ReConnectCount = 0;
		this.TryReconnectCount = 0;
		this.ResetReconnectStatus();
		this.ReconvTraceId = string.Empty;
	}

	// Token: 0x17001B42 RID: 6978
	// (get) Token: 0x06011F21 RID: 73505 RVA: 0x0054823F File Offset: 0x0054643F
	public int ServerChannelCloseTimeMs
	{
		get
		{
			return this.ServerChannelCloseSeconds * 1000;
		}
	}

	// Token: 0x06011F22 RID: 73506 RVA: 0x0054824D File Offset: 0x0054644D
	public void AddRpc(int rpcId)
	{
		this.RpcSet.Add(rpcId);
	}

	// Token: 0x06011F23 RID: 73507 RVA: 0x0054825C File Offset: 0x0054645C
	public void DelRpc(int rpcId)
	{
		this.RpcSet.Remove(rpcId);
	}

	// Token: 0x06011F24 RID: 73508 RVA: 0x0054826B File Offset: 0x0054646B
	public bool IsRpcEmpty()
	{
		return this.RpcSet.Count <= 0;
	}

	// Token: 0x06011F25 RID: 73509 RVA: 0x00548280 File Offset: 0x00546480
	public string GetUnResponsedRpcStr()
	{
		string text = string.Empty;
		foreach (int value in this.RpcSet)
		{
			string str = text;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 1);
			defaultInterpolatedStringHandler.AppendLiteral("[");
			defaultInterpolatedStringHandler.AppendFormatted<int>(value);
			defaultInterpolatedStringHandler.AppendLiteral("]");
			text = str + defaultInterpolatedStringHandler.ToStringAndClear();
		}
		return text;
	}

	// Token: 0x06011F26 RID: 73510 RVA: 0x0054830C File Offset: 0x0054650C
	public bool IsReConnectMaxCount()
	{
		return this.ReConnectCount > this.ReConnectMaxCount;
	}

	// Token: 0x06011F27 RID: 73511 RVA: 0x0054831C File Offset: 0x0054651C
	public int GetReConnectCount()
	{
		return this.ReConnectCount;
	}

	// Token: 0x06011F28 RID: 73512 RVA: 0x00548324 File Offset: 0x00546524
	public void ReSetReConnectCount()
	{
		this.ReConnectCount = 0;
	}

	// Token: 0x06011F29 RID: 73513 RVA: 0x0054832D File Offset: 0x0054652D
	public int AddReConnectCount()
	{
		this.ReConnectCount++;
		this.TotalReConnectCount++;
		return this.ReConnectCount;
	}

	// Token: 0x06011F2A RID: 73514 RVA: 0x00548351 File Offset: 0x00546551
	public bool IsTryMaxCount()
	{
		return !this.DebugForeverTryReconnect && this.TryReconnectCount >= this.TryReConnectMaxCount;
	}

	// Token: 0x06011F2B RID: 73515 RVA: 0x0054836E File Offset: 0x0054656E
	public void AddTryCount()
	{
		this.TryReconnectCount++;
	}

	// Token: 0x06011F2C RID: 73516 RVA: 0x0054837E File Offset: 0x0054657E
	public int GetTryCount()
	{
		return this.TryReconnectCount;
	}

	// Token: 0x17001B43 RID: 6979
	// (get) Token: 0x06011F2D RID: 73517 RVA: 0x00548386 File Offset: 0x00546586
	public int GetTotalReConnectCount
	{
		get
		{
			return this.TotalReConnectCount;
		}
	}

	// Token: 0x06011F2E RID: 73518 RVA: 0x0054838E File Offset: 0x0054658E
	public EReConnectStatus GetReConnectStatus()
	{
		return this.ReConnectStatus;
	}

	// Token: 0x06011F2F RID: 73519 RVA: 0x00548396 File Offset: 0x00546596
	public void ResetReconnectStatus()
	{
		this.ReConnectStatus = EReConnectStatus.NoReConnect;
	}

	// Token: 0x06011F30 RID: 73520 RVA: 0x0054839F File Offset: 0x0054659F
	public void SetReconnectDoing()
	{
		this.ReConnectStatus = EReConnectStatus.ReConnectDoing;
	}

	// Token: 0x06011F31 RID: 73521 RVA: 0x005483A8 File Offset: 0x005465A8
	public void CancelShowMaskTimer()
	{
		if (this.ShowMaskTimer != null)
		{
			TimerSystem.Instance.Remove(this.ShowMaskTimer);
			this.ShowMaskTimer = null;
		}
	}

	// Token: 0x06011F32 RID: 73522 RVA: 0x005483CC File Offset: 0x005465CC
	public void StartShowMaskTimer(Action callback)
	{
		this.ShowMaskTimer = TimerSystem.Instance.Delay(delegate(float _)
		{
			callback();
			this.ShowMaskTimer = null;
		}, (float)this.SilentTimeMs, null, null, true, 1f);
	}

	// Token: 0x06011F33 RID: 73523 RVA: 0x00548418 File Offset: 0x00546618
	public void SetCurIncId()
	{
		this.CurIncId = this.ReConnectIncId;
	}

	// Token: 0x06011F34 RID: 73524 RVA: 0x00548426 File Offset: 0x00546626
	public bool IsReConnectIdSame()
	{
		return this.CurIncId == this.ReConnectIncId;
	}

	// Token: 0x06011F35 RID: 73525 RVA: 0x00548436 File Offset: 0x00546636
	public void AddReConnectIncId()
	{
		this.ReConnectIncId++;
	}

	// Token: 0x17001B44 RID: 6980
	// (get) Token: 0x06011F36 RID: 73526 RVA: 0x00548446 File Offset: 0x00546646
	// (set) Token: 0x06011F37 RID: 73527 RVA: 0x0054844E File Offset: 0x0054664E
	[Nullable(2)]
	public Action DisconnectedFunction
	{
		[NullableContext(2)]
		get
		{
			return this.DisconnectedFunctionInternal;
		}
		[NullableContext(2)]
		set
		{
			this.DisconnectedFunctionInternal = value;
		}
	}

	// Token: 0x17001B45 RID: 6981
	// (get) Token: 0x06011F38 RID: 73528 RVA: 0x00548457 File Offset: 0x00546657
	// (set) Token: 0x06011F39 RID: 73529 RVA: 0x0054845F File Offset: 0x0054665F
	public string ReconvTraceId
	{
		get
		{
			return this.ReconvTraceIdInternal;
		}
		set
		{
			this.ReconvTraceIdInternal = value;
		}
	}

	// Token: 0x17001B46 RID: 6982
	// (get) Token: 0x06011F3A RID: 73530 RVA: 0x00548468 File Offset: 0x00546668
	// (set) Token: 0x06011F3B RID: 73531 RVA: 0x00548470 File Offset: 0x00546670
	public unsafe ENetworkType LastNetworkType
	{
		get
		{
			return this.LastNetworkTypeInternal;
		}
		set
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Reconnect;
			ELogAuthor author = ELogAuthor.MZJ;
			string message = "set LastNetworkType";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("old", this.LastNetworkTypeInternal);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("new", value);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			this.LastNetworkTypeInternal = value;
		}
	}

	// Token: 0x17001B47 RID: 6983
	// (get) Token: 0x06011F3C RID: 73532 RVA: 0x005484E6 File Offset: 0x005466E6
	public UKuroNetworkChange NetworkListener
	{
		get
		{
			if (this.NetworkListenerInternal == null)
			{
				this.NetworkListenerInternal = new UKuroNetworkChange();
			}
			return this.NetworkListenerInternal;
		}
	}

	// Token: 0x17001B48 RID: 6984
	// (get) Token: 0x06011F3D RID: 73533 RVA: 0x00548501 File Offset: 0x00546701
	public static ReConnectModel Instance
	{
		get
		{
			return ReConnectModel._Instance;
		}
	}

	// Token: 0x06011F3E RID: 73534 RVA: 0x00548508 File Offset: 0x00546708
	public static ReConnectModel GetOrCreateInstance()
	{
		if (ReConnectModel._Instance == null)
		{
			ReConnectModel.CreateInstance();
		}
		return ReConnectModel._Instance;
	}

	// Token: 0x06011F3F RID: 73535 RVA: 0x0054851C File Offset: 0x0054671C
	public static bool CreateInstance()
	{
		if (ReConnectModel._Instance != null)
		{
			return true;
		}
		ReConnectModel._Instance = new ReConnectModel();
		return true;
	}

	// Token: 0x06011F40 RID: 73536 RVA: 0x00548532 File Offset: 0x00546732
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06011F41 RID: 73537 RVA: 0x00548534 File Offset: 0x00546734
	public static void ResetStaticDefaultValue()
	{
		ReConnectModel._Instance = null;
	}

	// Token: 0x06011F42 RID: 73538 RVA: 0x0054853C File Offset: 0x0054673C
	static ReConnectModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ReConnectModel.CreateStaticDefaultValue), new Action(ReConnectModel.ResetStaticDefaultValue));
	}

	// Token: 0x04009C7E RID: 40062
	private bool DebugForeverTryReconnect;

	// Token: 0x04009C7F RID: 40063
	private int ReConnectIncId;

	// Token: 0x04009C80 RID: 40064
	private int ReConnectCount;

	// Token: 0x04009C81 RID: 40065
	private int TryReconnectCount;

	// Token: 0x04009C82 RID: 40066
	private EReConnectStatus ReConnectStatus;

	// Token: 0x04009C83 RID: 40067
	private int TotalReConnectCount;

	// Token: 0x04009C84 RID: 40068
	private readonly HashSet<int> RpcSet = new HashSet<int>();

	// Token: 0x04009C85 RID: 40069
	private int TryReConnectMaxCount;

	// Token: 0x04009C86 RID: 40070
	private int ReConnectMaxCount;

	// Token: 0x04009C87 RID: 40071
	private int CurIncId;

	// Token: 0x04009C88 RID: 40072
	[Nullable(2)]
	private TimerHandle ShowMaskTimer;

	// Token: 0x04009C89 RID: 40073
	private int SilentTimeMs = 1000;

	// Token: 0x04009C8A RID: 40074
	private int ServerChannelCloseSeconds = 60;

	// Token: 0x04009C8B RID: 40075
	[Nullable(2)]
	private Action DisconnectedFunctionInternal;

	// Token: 0x04009C8C RID: 40076
	private string ReconvTraceIdInternal = string.Empty;

	// Token: 0x04009C8D RID: 40077
	private ENetworkType LastNetworkTypeInternal = ENetworkType.None;

	// Token: 0x04009C8E RID: 40078
	[Nullable(2)]
	private UKuroNetworkChange NetworkListenerInternal;

	// Token: 0x04009C8F RID: 40079
	[Nullable(2)]
	private static ReConnectModel _Instance;
}
