using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Launcher;
using UnrealEngine;

// Token: 0x02002751 RID: 10065
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class ReConnectModel : ModelBase
{
	// Token: 0x06014A3B RID: 84539 RVA: 0x005392C0 File Offset: 0x005374C0
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

	// Token: 0x06014A3C RID: 84540 RVA: 0x00539381 File Offset: 0x00537581
	protected override bool OnClear()
	{
		this.ClearReconnectData();
		return true;
	}

	// Token: 0x06014A3D RID: 84541 RVA: 0x0053938A File Offset: 0x0053758A
	public void ClearReconnectData()
	{
		this.ReConnectCount = 0;
		this.TryReconnectCount = 0;
		this.ResetReconnectStatus();
		this.ReconvTraceId = string.Empty;
	}

	// Token: 0x17001B09 RID: 6921
	// (get) Token: 0x06014A3E RID: 84542 RVA: 0x005393AB File Offset: 0x005375AB
	public int ServerChannelCloseTimeMs
	{
		get
		{
			return this.ServerChannelCloseSeconds * 1000;
		}
	}

	// Token: 0x06014A3F RID: 84543 RVA: 0x005393B9 File Offset: 0x005375B9
	public void AddRpc(int rpcId)
	{
		this.RpcSet.Add(rpcId);
	}

	// Token: 0x06014A40 RID: 84544 RVA: 0x005393C8 File Offset: 0x005375C8
	public void DelRpc(int rpcId)
	{
		this.RpcSet.Remove(rpcId);
	}

	// Token: 0x06014A41 RID: 84545 RVA: 0x005393D7 File Offset: 0x005375D7
	public bool IsRpcEmpty()
	{
		return this.RpcSet.Count <= 0;
	}

	// Token: 0x06014A42 RID: 84546 RVA: 0x005393EC File Offset: 0x005375EC
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

	// Token: 0x06014A43 RID: 84547 RVA: 0x00539478 File Offset: 0x00537678
	public bool IsReConnectMaxCount()
	{
		return this.ReConnectCount > this.ReConnectMaxCount;
	}

	// Token: 0x06014A44 RID: 84548 RVA: 0x00539488 File Offset: 0x00537688
	public int GetReConnectCount()
	{
		return this.ReConnectCount;
	}

	// Token: 0x06014A45 RID: 84549 RVA: 0x00539490 File Offset: 0x00537690
	public void ReSetReConnectCount()
	{
		this.ReConnectCount = 0;
	}

	// Token: 0x06014A46 RID: 84550 RVA: 0x00539499 File Offset: 0x00537699
	public int AddReConnectCount()
	{
		this.ReConnectCount++;
		this.TotalReConnectCount++;
		return this.ReConnectCount;
	}

	// Token: 0x06014A47 RID: 84551 RVA: 0x005394BD File Offset: 0x005376BD
	public bool IsTryMaxCount()
	{
		return !this.DebugForeverTryReconnect && this.TryReconnectCount >= this.TryReConnectMaxCount;
	}

	// Token: 0x06014A48 RID: 84552 RVA: 0x005394DA File Offset: 0x005376DA
	public void AddTryCount()
	{
		this.TryReconnectCount++;
	}

	// Token: 0x06014A49 RID: 84553 RVA: 0x005394EA File Offset: 0x005376EA
	public int GetTryCount()
	{
		return this.TryReconnectCount;
	}

	// Token: 0x17001B0A RID: 6922
	// (get) Token: 0x06014A4A RID: 84554 RVA: 0x005394F2 File Offset: 0x005376F2
	public int GetTotalReConnectCount
	{
		get
		{
			return this.TotalReConnectCount;
		}
	}

	// Token: 0x06014A4B RID: 84555 RVA: 0x005394FA File Offset: 0x005376FA
	public EReConnectStatus GetReConnectStatus()
	{
		return this.ReConnectStatus;
	}

	// Token: 0x06014A4C RID: 84556 RVA: 0x00539502 File Offset: 0x00537702
	public void ResetReconnectStatus()
	{
		this.ReConnectStatus = EReConnectStatus.NoReConnect;
	}

	// Token: 0x06014A4D RID: 84557 RVA: 0x0053950B File Offset: 0x0053770B
	public void SetReconnectDoing()
	{
		this.ReConnectStatus = EReConnectStatus.ReConnectDoing;
	}

	// Token: 0x06014A4E RID: 84558 RVA: 0x00539514 File Offset: 0x00537714
	public void CancelShowMaskTimer()
	{
		if (this.ShowMaskTimer != null)
		{
			TimerSystem.Instance.Remove(this.ShowMaskTimer);
			this.ShowMaskTimer = null;
		}
	}

	// Token: 0x06014A4F RID: 84559 RVA: 0x00539538 File Offset: 0x00537738
	public void StartShowMaskTimer(Action callback)
	{
		this.ShowMaskTimer = TimerSystem.Instance.Delay(delegate(float _)
		{
			callback();
			this.ShowMaskTimer = null;
		}, (float)this.SilentTimeMs, null, null, true, 1f);
	}

	// Token: 0x06014A50 RID: 84560 RVA: 0x00539584 File Offset: 0x00537784
	public void SetCurIncId()
	{
		this.CurIncId = this.ReConnectIncId;
	}

	// Token: 0x06014A51 RID: 84561 RVA: 0x00539592 File Offset: 0x00537792
	public bool IsReConnectIdSame()
	{
		return this.CurIncId == this.ReConnectIncId;
	}

	// Token: 0x06014A52 RID: 84562 RVA: 0x005395A2 File Offset: 0x005377A2
	public void AddReConnectIncId()
	{
		this.ReConnectIncId++;
	}

	// Token: 0x17001B0B RID: 6923
	// (get) Token: 0x06014A53 RID: 84563 RVA: 0x005395B2 File Offset: 0x005377B2
	// (set) Token: 0x06014A54 RID: 84564 RVA: 0x005395BA File Offset: 0x005377BA
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

	// Token: 0x17001B0C RID: 6924
	// (get) Token: 0x06014A55 RID: 84565 RVA: 0x005395C3 File Offset: 0x005377C3
	// (set) Token: 0x06014A56 RID: 84566 RVA: 0x005395CB File Offset: 0x005377CB
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

	// Token: 0x17001B0D RID: 6925
	// (get) Token: 0x06014A57 RID: 84567 RVA: 0x005395D4 File Offset: 0x005377D4
	// (set) Token: 0x06014A58 RID: 84568 RVA: 0x005395DC File Offset: 0x005377DC
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

	// Token: 0x17001B0E RID: 6926
	// (get) Token: 0x06014A59 RID: 84569 RVA: 0x00539652 File Offset: 0x00537852
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

	// Token: 0x17001B0F RID: 6927
	// (get) Token: 0x06014A5A RID: 84570 RVA: 0x0053966D File Offset: 0x0053786D
	public static ReConnectModel Instance
	{
		get
		{
			return ReConnectModel._Instance;
		}
	}

	// Token: 0x06014A5B RID: 84571 RVA: 0x00539674 File Offset: 0x00537874
	public static ReConnectModel GetOrCreateInstance()
	{
		if (ReConnectModel._Instance == null)
		{
			ReConnectModel.CreateInstance();
		}
		return ReConnectModel._Instance;
	}

	// Token: 0x06014A5C RID: 84572 RVA: 0x00539688 File Offset: 0x00537888
	public static bool CreateInstance()
	{
		if (ReConnectModel._Instance != null)
		{
			return true;
		}
		ReConnectModel._Instance = new ReConnectModel();
		return true;
	}

	// Token: 0x06014A5D RID: 84573 RVA: 0x0053969E File Offset: 0x0053789E
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06014A5E RID: 84574 RVA: 0x005396A0 File Offset: 0x005378A0
	public static void ResetStaticDefaultValue()
	{
		ReConnectModel._Instance = null;
	}

	// Token: 0x06014A5F RID: 84575 RVA: 0x005396A8 File Offset: 0x005378A8
	static ReConnectModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ReConnectModel.CreateStaticDefaultValue), new Action(ReConnectModel.ResetStaticDefaultValue));
	}

	// Token: 0x04009B25 RID: 39717
	private bool DebugForeverTryReconnect;

	// Token: 0x04009B26 RID: 39718
	private int ReConnectIncId;

	// Token: 0x04009B27 RID: 39719
	private int ReConnectCount;

	// Token: 0x04009B28 RID: 39720
	private int TryReconnectCount;

	// Token: 0x04009B29 RID: 39721
	private EReConnectStatus ReConnectStatus;

	// Token: 0x04009B2A RID: 39722
	private int TotalReConnectCount;

	// Token: 0x04009B2B RID: 39723
	private readonly HashSet<int> RpcSet = new HashSet<int>();

	// Token: 0x04009B2C RID: 39724
	private int TryReConnectMaxCount;

	// Token: 0x04009B2D RID: 39725
	private int ReConnectMaxCount;

	// Token: 0x04009B2E RID: 39726
	private int CurIncId;

	// Token: 0x04009B2F RID: 39727
	[Nullable(2)]
	private TimerHandle ShowMaskTimer;

	// Token: 0x04009B30 RID: 39728
	private int SilentTimeMs = 1000;

	// Token: 0x04009B31 RID: 39729
	private int ServerChannelCloseSeconds = 60;

	// Token: 0x04009B32 RID: 39730
	[Nullable(2)]
	private Action DisconnectedFunctionInternal;

	// Token: 0x04009B33 RID: 39731
	private string ReconvTraceIdInternal = string.Empty;

	// Token: 0x04009B34 RID: 39732
	private ENetworkType LastNetworkTypeInternal = ENetworkType.None;

	// Token: 0x04009B35 RID: 39733
	[Nullable(2)]
	private UKuroNetworkChange NetworkListenerInternal;

	// Token: 0x04009B36 RID: 39734
	[Nullable(2)]
	private static ReConnectModel _Instance;
}
