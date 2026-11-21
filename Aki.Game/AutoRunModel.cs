using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x02000BB1 RID: 2993
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class AutoRunModel : ModelBase
{
	// Token: 0x06007C6A RID: 31850 RVA: 0x00268AF0 File Offset: 0x00266CF0
	protected override bool OnInit()
	{
		this.AutoRunMode = EAutoRunMode.Disabled;
		this.GmSkipTreeType = BtType.Invalid;
		this.GmSkipTreeConfigId = 0;
		this.GmSkipNodeId = 0;
		return true;
	}

	// Token: 0x06007C6B RID: 31851 RVA: 0x00268B0F File Offset: 0x00266D0F
	protected override bool OnClear()
	{
		this.ClearAllOverrideTpInfo();
		this.ClearAllGuaranteeTpInfo();
		this.ClearCachedDataLayerInfo();
		return true;
	}

	// Token: 0x06007C6C RID: 31852 RVA: 0x00268B24 File Offset: 0x00266D24
	public EAutoRunState GetAutoRunState()
	{
		return this.AutoRunState;
	}

	// Token: 0x06007C6D RID: 31853 RVA: 0x00268B2C File Offset: 0x00266D2C
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

	// Token: 0x06007C6E RID: 31854 RVA: 0x00268BE1 File Offset: 0x00266DE1
	public bool IsInLogicTreeGmMode()
	{
		return this.AutoRunMode != EAutoRunMode.Disabled && this.AutoRunState == EAutoRunState.Running;
	}

	// Token: 0x06007C6F RID: 31855 RVA: 0x00268BF6 File Offset: 0x00266DF6
	public bool IsInAfterRunningState()
	{
		return this.AutoRunMode != EAutoRunMode.Disabled && this.AutoRunState == EAutoRunState.AfterRunning;
	}

	// Token: 0x06007C70 RID: 31856 RVA: 0x00268C0B File Offset: 0x00266E0B
	public bool IsInServerControlGmMode()
	{
		return this.AutoRunMode == EAutoRunMode.ServerControlledSkip;
	}

	// Token: 0x06007C71 RID: 31857 RVA: 0x00268C16 File Offset: 0x00266E16
	public EAutoRunMode GetAutoRunMode()
	{
		return this.AutoRunMode;
	}

	// Token: 0x06007C72 RID: 31858 RVA: 0x00268C1E File Offset: 0x00266E1E
	public void SetAutoRunMode(EAutoRunMode gmAutoMode, BtType treeType = BtType.Invalid, int treeConfigId = 0, int nodeId = 0)
	{
		this.AutoRunMode = gmAutoMode;
		this.GmSkipTreeType = treeType;
		this.GmSkipTreeConfigId = treeConfigId;
		this.GmSkipNodeId = nodeId;
	}

	// Token: 0x06007C73 RID: 31859 RVA: 0x00268C3D File Offset: 0x00266E3D
	public void StopAutoRunAndClearInfo()
	{
		this.SetAutoRunState(EAutoRunState.Stopped);
		this.ClearAutoRunInfo();
	}

	// Token: 0x06007C74 RID: 31860 RVA: 0x00268C4C File Offset: 0x00266E4C
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

	// Token: 0x06007C75 RID: 31861 RVA: 0x00268C7F File Offset: 0x00266E7F
	public BtType GetGmSkipTreeType()
	{
		return this.GmSkipTreeType;
	}

	// Token: 0x06007C76 RID: 31862 RVA: 0x00268C87 File Offset: 0x00266E87
	public int GetGmSkipTreeConfigId()
	{
		return this.GmSkipTreeConfigId;
	}

	// Token: 0x06007C77 RID: 31863 RVA: 0x00268C8F File Offset: 0x00266E8F
	public int GetGmSkipNodeId()
	{
		return this.GmSkipNodeId;
	}

	// Token: 0x06007C78 RID: 31864 RVA: 0x00268C98 File Offset: 0x00266E98
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

	// Token: 0x06007C79 RID: 31865 RVA: 0x00268CD8 File Offset: 0x00266ED8
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

	// Token: 0x06007C7A RID: 31866 RVA: 0x00268D22 File Offset: 0x00266F22
	public void ClearAllGuaranteeTpInfo()
	{
		this.GuaranteeTpInfos.Clear();
	}

	// Token: 0x06007C7B RID: 31867 RVA: 0x00268D30 File Offset: 0x00266F30
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

	// Token: 0x06007C7C RID: 31868 RVA: 0x00268D70 File Offset: 0x00266F70
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

	// Token: 0x06007C7D RID: 31869 RVA: 0x00268DBA File Offset: 0x00266FBA
	public void ClearAllOverrideTpInfo()
	{
		this.OverrideTpInfos.Clear();
	}

	// Token: 0x06007C7E RID: 31870 RVA: 0x00268DC8 File Offset: 0x00266FC8
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

	// Token: 0x06007C7F RID: 31871 RVA: 0x00268E08 File Offset: 0x00267008
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

	// Token: 0x06007C80 RID: 31872 RVA: 0x00268FEC File Offset: 0x002671EC
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

	// Token: 0x06007C81 RID: 31873 RVA: 0x00269194 File Offset: 0x00267394
	public void ClearCachedDataLayerInfo()
	{
		this.CachedDataLayerInfos.Clear();
	}

	// Token: 0x17000E1B RID: 3611
	// (get) Token: 0x06007C82 RID: 31874 RVA: 0x002691A1 File Offset: 0x002673A1
	public static AutoRunModel Instance
	{
		get
		{
			return AutoRunModel._Instance;
		}
	}

	// Token: 0x06007C83 RID: 31875 RVA: 0x002691A8 File Offset: 0x002673A8
	public static AutoRunModel GetOrCreateInstance()
	{
		if (AutoRunModel._Instance == null)
		{
			AutoRunModel.CreateInstance();
		}
		return AutoRunModel._Instance;
	}

	// Token: 0x06007C84 RID: 31876 RVA: 0x002691BC File Offset: 0x002673BC
	public static bool CreateInstance()
	{
		if (AutoRunModel._Instance != null)
		{
			return true;
		}
		AutoRunModel._Instance = new AutoRunModel();
		return true;
	}

	// Token: 0x06007C85 RID: 31877 RVA: 0x002691D2 File Offset: 0x002673D2
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06007C86 RID: 31878 RVA: 0x002691D4 File Offset: 0x002673D4
	public static void ResetStaticDefaultValue()
	{
		AutoRunModel._Instance = null;
	}

	// Token: 0x06007C87 RID: 31879 RVA: 0x002691DC File Offset: 0x002673DC
	static AutoRunModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(AutoRunModel.CreateStaticDefaultValue), new Action(AutoRunModel.ResetStaticDefaultValue));
	}

	// Token: 0x04004D8D RID: 19853
	private EAutoRunState AutoRunState;

	// Token: 0x04004D8E RID: 19854
	private EAutoRunMode AutoRunMode;

	// Token: 0x04004D8F RID: 19855
	private BtType GmSkipTreeType;

	// Token: 0x04004D90 RID: 19856
	private int GmSkipTreeConfigId;

	// Token: 0x04004D91 RID: 19857
	private int GmSkipNodeId;

	// Token: 0x04004D92 RID: 19858
	public bool ShouldTpAfterSkip;

	// Token: 0x04004D93 RID: 19859
	public bool ShouldFastSkip;

	// Token: 0x04004D94 RID: 19860
	private readonly Dictionary<int, TeleportInfo> OverrideTpInfos = new Dictionary<int, TeleportInfo>();

	// Token: 0x04004D95 RID: 19861
	private readonly Dictionary<int, TeleportInfo> GuaranteeTpInfos = new Dictionary<int, TeleportInfo>();

	// Token: 0x04004D96 RID: 19862
	private readonly Dictionary<int, GmDataLayerInfo> CachedDataLayerInfos = new Dictionary<int, GmDataLayerInfo>();

	// Token: 0x04004D97 RID: 19863
	[Nullable(2)]
	private static AutoRunModel _Instance;
}
