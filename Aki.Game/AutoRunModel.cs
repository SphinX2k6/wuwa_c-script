using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x020016F9 RID: 5881
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class AutoRunModel : ModelBase
{
	// Token: 0x0600A88A RID: 43146 RVA: 0x0025E6D4 File Offset: 0x0025C8D4
	protected override bool OnInit()
	{
		this.AutoRunMode = EAutoRunMode.Disabled;
		this.GmSkipTreeType = BtType.Invalid;
		this.GmSkipTreeConfigId = 0;
		this.GmSkipNodeId = 0;
		return true;
	}

	// Token: 0x0600A88B RID: 43147 RVA: 0x0025E6F3 File Offset: 0x0025C8F3
	protected override bool OnClear()
	{
		this.ClearAllOverrideTpInfo();
		this.ClearAllGuaranteeTpInfo();
		this.ClearCachedDataLayerInfo();
		return true;
	}

	// Token: 0x0600A88C RID: 43148 RVA: 0x0025E708 File Offset: 0x0025C908
	public EAutoRunState GetAutoRunState()
	{
		return this.AutoRunState;
	}

	// Token: 0x0600A88D RID: 43149 RVA: 0x0025E710 File Offset: 0x0025C910
	public unsafe void SetAutoRunState(EAutoRunState autoRunState)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Gm;
		ELogAuthor author = ELogAuthor.ZYL;
		string message = "[Gm一键推进] AutoRunState改变";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("原AutoRunState", this.AutoRunState);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("新AutoRunState", autoRunState);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		if (this.AutoRunState != autoRunState)
		{
			this.AutoRunState = autoRunState;
			SundryModel.Instance.IsBlockTips = this.IsInLogicTreeGmMode();
			GuideModel.Instance.SetGmLock(this.IsInLogicTreeGmMode());
			EventSystem.Instance.Emit<EAutoRunState>(EEventName.GmAutoModeChange, autoRunState);
		}
	}

	// Token: 0x0600A88E RID: 43150 RVA: 0x0025E7C5 File Offset: 0x0025C9C5
	public bool IsInLogicTreeGmMode()
	{
		return this.AutoRunMode != EAutoRunMode.Disabled && this.AutoRunState == EAutoRunState.Running;
	}

	// Token: 0x0600A88F RID: 43151 RVA: 0x0025E7DA File Offset: 0x0025C9DA
	public bool IsInAfterRunningState()
	{
		return this.AutoRunMode != EAutoRunMode.Disabled && this.AutoRunState == EAutoRunState.AfterRunning;
	}

	// Token: 0x0600A890 RID: 43152 RVA: 0x0025E7EF File Offset: 0x0025C9EF
	public bool IsInServerControlGmMode()
	{
		return this.AutoRunMode == EAutoRunMode.ServerControlledSkip;
	}

	// Token: 0x0600A891 RID: 43153 RVA: 0x0025E7FA File Offset: 0x0025C9FA
	public EAutoRunMode GetAutoRunMode()
	{
		return this.AutoRunMode;
	}

	// Token: 0x0600A892 RID: 43154 RVA: 0x0025E802 File Offset: 0x0025CA02
	public void SetAutoRunMode(EAutoRunMode gmAutoMode, BtType treeType = BtType.Invalid, int treeConfigId = 0, int nodeId = 0)
	{
		this.AutoRunMode = gmAutoMode;
		this.GmSkipTreeType = treeType;
		this.GmSkipTreeConfigId = treeConfigId;
		this.GmSkipNodeId = nodeId;
	}

	// Token: 0x0600A893 RID: 43155 RVA: 0x0025E821 File Offset: 0x0025CA21
	public void StopAutoRunAndClearInfo()
	{
		this.SetAutoRunState(EAutoRunState.Stopped);
		this.ClearAutoRunInfo();
	}

	// Token: 0x0600A894 RID: 43156 RVA: 0x0025E830 File Offset: 0x0025CA30
	public void ClearAutoRunInfo()
	{
		this.SetAutoRunMode(EAutoRunMode.Disabled, BtType.Invalid, 0, 0);
		this.ShouldFastSkip = false;
		this.ShouldTpAfterSkip = false;
		this.ShouldTpAfterSkip = false;
		this.ClearAllOverrideTpInfo();
		this.ClearAllGuaranteeTpInfo();
		this.ClearCachedDataLayerInfo();
	}

	// Token: 0x0600A895 RID: 43157 RVA: 0x0025E863 File Offset: 0x0025CA63
	public BtType GetGmSkipTreeType()
	{
		return this.GmSkipTreeType;
	}

	// Token: 0x0600A896 RID: 43158 RVA: 0x0025E86B File Offset: 0x0025CA6B
	public int GetGmSkipTreeConfigId()
	{
		return this.GmSkipTreeConfigId;
	}

	// Token: 0x0600A897 RID: 43159 RVA: 0x0025E873 File Offset: 0x0025CA73
	public int GetGmSkipNodeId()
	{
		return this.GmSkipNodeId;
	}

	// Token: 0x0600A898 RID: 43160 RVA: 0x0025E87C File Offset: 0x0025CA7C
	[NullableContext(2)]
	public TeleportInfo GetGuaranteeTpInfo(int? instanceId = null)
	{
		int key = instanceId ?? CreatureModel.Instance.GetInstanceId();
		TeleportInfo result;
		if (!this.GuaranteeTpInfos.TryGetValue(key, out result))
		{
			return null;
		}
		return result;
	}

	// Token: 0x0600A899 RID: 43161 RVA: 0x0025E8BC File Offset: 0x0025CABC
	[NullableContext(2)]
	public void SetGuaranteeTpInfo(TeleportInfo tpInfo, int? instanceId = null)
	{
		int key = instanceId ?? CreatureModel.Instance.GetInstanceId();
		if (tpInfo != null)
		{
			this.GuaranteeTpInfos[key] = tpInfo;
			return;
		}
		this.GuaranteeTpInfos.Remove(key);
	}

	// Token: 0x0600A89A RID: 43162 RVA: 0x0025E906 File Offset: 0x0025CB06
	public void ClearAllGuaranteeTpInfo()
	{
		this.GuaranteeTpInfos.Clear();
	}

	// Token: 0x0600A89B RID: 43163 RVA: 0x0025E914 File Offset: 0x0025CB14
	[NullableContext(2)]
	public TeleportInfo GetOverrideTpInfo(int? instanceId = null)
	{
		int key = instanceId ?? CreatureModel.Instance.GetInstanceId();
		TeleportInfo result;
		if (!this.OverrideTpInfos.TryGetValue(key, out result))
		{
			return null;
		}
		return result;
	}

	// Token: 0x0600A89C RID: 43164 RVA: 0x0025E954 File Offset: 0x0025CB54
	[NullableContext(2)]
	public void SetOverrideTpInfo(TeleportInfo tpInfo, int? instanceId = null)
	{
		int key = instanceId ?? CreatureModel.Instance.GetInstanceId();
		if (tpInfo != null)
		{
			this.OverrideTpInfos[key] = tpInfo;
			return;
		}
		this.OverrideTpInfos.Remove(key);
	}

	// Token: 0x0600A89D RID: 43165 RVA: 0x0025E99E File Offset: 0x0025CB9E
	public void ClearAllOverrideTpInfo()
	{
		this.OverrideTpInfos.Clear();
	}

	// Token: 0x0600A89E RID: 43166 RVA: 0x0025E9AC File Offset: 0x0025CBAC
	[NullableContext(2)]
	public GmDataLayerInfo GetCachedDataLayerInfo(int? instanceId = null)
	{
		int key = instanceId ?? CreatureModel.Instance.GetInstanceId();
		GmDataLayerInfo result;
		if (!this.CachedDataLayerInfos.TryGetValue(key, out result))
		{
			return null;
		}
		return result;
	}

	// Token: 0x0600A89F RID: 43167 RVA: 0x0025E9EC File Offset: 0x0025CBEC
	public void UpdateCachedDataLayerInfo(IList<int> newLoads, IList<int> newUnloads, int? instanceId = null)
	{
		if (newLoads.Count == 0 && newUnloads.Count == 0)
		{
			return;
		}
		int key = instanceId ?? CreatureModel.Instance.GetInstanceId();
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		foreach (int p0Id in newLoads)
		{
			DataLayerConfig? config = ConfigDataLayerConfigById.GetConfig(p0Id, true);
			if (config != null)
			{
				list.Add(config.Value.DataLayer);
			}
		}
		foreach (int p0Id2 in newUnloads)
		{
			DataLayerConfig? config2 = ConfigDataLayerConfigById.GetConfig(p0Id2, true);
			if (config2 != null)
			{
				list2.Add(config2.Value.DataLayer);
			}
		}
		GmDataLayerInfo gmDataLayerInfo2;
		GmDataLayerInfo gmDataLayerInfo = this.CachedDataLayerInfos.TryGetValue(key, out gmDataLayerInfo2) ? gmDataLayerInfo2 : null;
		if (gmDataLayerInfo == null)
		{
			gmDataLayerInfo = new GmDataLayerInfo(new HashSet<string>(), new HashSet<string>());
			this.CachedDataLayerInfos[key] = gmDataLayerInfo;
		}
		foreach (string item in list)
		{
			gmDataLayerInfo.LoadDataLayers.Add(item);
			gmDataLayerInfo.UnloadDataLayers.Remove(item);
		}
		foreach (string item2 in list2)
		{
			gmDataLayerInfo.UnloadDataLayers.Add(item2);
			gmDataLayerInfo.LoadDataLayers.Remove(item2);
		}
	}

	// Token: 0x0600A8A0 RID: 43168 RVA: 0x0025EBD0 File Offset: 0x0025CDD0
	public void UpdateCachedDataLayerInfo(IList<string> newLoads, IList<string> newUnloads, int? instanceId = null)
	{
		if (newLoads.Count == 0 && newUnloads.Count == 0)
		{
			return;
		}
		int key = instanceId ?? CreatureModel.Instance.GetInstanceId();
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		foreach (string item in newLoads)
		{
			list.Add(item);
		}
		foreach (string item2 in newUnloads)
		{
			list2.Add(item2);
		}
		GmDataLayerInfo gmDataLayerInfo2;
		GmDataLayerInfo gmDataLayerInfo = this.CachedDataLayerInfos.TryGetValue(key, out gmDataLayerInfo2) ? gmDataLayerInfo2 : null;
		if (gmDataLayerInfo == null)
		{
			gmDataLayerInfo = new GmDataLayerInfo(new HashSet<string>(), new HashSet<string>());
			this.CachedDataLayerInfos[key] = gmDataLayerInfo;
		}
		foreach (string item3 in list)
		{
			gmDataLayerInfo.LoadDataLayers.Add(item3);
			gmDataLayerInfo.UnloadDataLayers.Remove(item3);
		}
		foreach (string item4 in list2)
		{
			gmDataLayerInfo.UnloadDataLayers.Add(item4);
			gmDataLayerInfo.LoadDataLayers.Remove(item4);
		}
	}

	// Token: 0x0600A8A1 RID: 43169 RVA: 0x0025ED78 File Offset: 0x0025CF78
	public void ClearCachedDataLayerInfo()
	{
		this.CachedDataLayerInfos.Clear();
	}

	// Token: 0x17000DFA RID: 3578
	// (get) Token: 0x0600A8A2 RID: 43170 RVA: 0x0025ED85 File Offset: 0x0025CF85
	public static AutoRunModel Instance
	{
		get
		{
			return AutoRunModel._Instance;
		}
	}

	// Token: 0x0600A8A3 RID: 43171 RVA: 0x0025ED8C File Offset: 0x0025CF8C
	public static AutoRunModel GetOrCreateInstance()
	{
		if (AutoRunModel._Instance == null)
		{
			AutoRunModel.CreateInstance();
		}
		return AutoRunModel._Instance;
	}

	// Token: 0x0600A8A4 RID: 43172 RVA: 0x0025EDA0 File Offset: 0x0025CFA0
	public static bool CreateInstance()
	{
		if (AutoRunModel._Instance != null)
		{
			return true;
		}
		AutoRunModel._Instance = new AutoRunModel();
		return true;
	}

	// Token: 0x0600A8A5 RID: 43173 RVA: 0x0025EDB6 File Offset: 0x0025CFB6
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600A8A6 RID: 43174 RVA: 0x0025EDB8 File Offset: 0x0025CFB8
	public static void ResetStaticDefaultValue()
	{
		AutoRunModel._Instance = null;
	}

	// Token: 0x0600A8A7 RID: 43175 RVA: 0x0025EDC0 File Offset: 0x0025CFC0
	static AutoRunModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(AutoRunModel.CreateStaticDefaultValue), new Action(AutoRunModel.ResetStaticDefaultValue));
	}

	// Token: 0x04004CE6 RID: 19686
	private EAutoRunState AutoRunState;

	// Token: 0x04004CE7 RID: 19687
	private EAutoRunMode AutoRunMode;

	// Token: 0x04004CE8 RID: 19688
	private BtType GmSkipTreeType;

	// Token: 0x04004CE9 RID: 19689
	private int GmSkipTreeConfigId;

	// Token: 0x04004CEA RID: 19690
	private int GmSkipNodeId;

	// Token: 0x04004CEB RID: 19691
	public bool ShouldTpAfterSkip;

	// Token: 0x04004CEC RID: 19692
	public bool ShouldFastSkip;

	// Token: 0x04004CED RID: 19693
	private readonly Dictionary<int, TeleportInfo> OverrideTpInfos = new Dictionary<int, TeleportInfo>();

	// Token: 0x04004CEE RID: 19694
	private readonly Dictionary<int, TeleportInfo> GuaranteeTpInfos = new Dictionary<int, TeleportInfo>();

	// Token: 0x04004CEF RID: 19695
	private readonly Dictionary<int, GmDataLayerInfo> CachedDataLayerInfos = new Dictionary<int, GmDataLayerInfo>();

	// Token: 0x04004CF0 RID: 19696
	[Nullable(2)]
	private static AutoRunModel _Instance;
}
