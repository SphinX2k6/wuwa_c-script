using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.AdventureGuide;
using CSharpScript.Game.Ui;

// Token: 0x0200207B RID: 8315
[NullableContext(1)]
[Nullable(0)]
public class LoadingModel : ModelBase
{
	// Token: 0x17001437 RID: 5175
	// (get) Token: 0x060105DC RID: 67036 RVA: 0x003FDF04 File Offset: 0x003FC104
	public int TipTime
	{
		get
		{
			if (this.TipsTimeInternal == 0)
			{
				this.TipsTimeInternal = LoadingConfig.Instance.GetLoadingTipsTime();
			}
			return this.TipsTimeInternal;
		}
	}

	// Token: 0x17001438 RID: 5176
	// (get) Token: 0x060105DD RID: 67037 RVA: 0x003FDF24 File Offset: 0x003FC124
	// (set) Token: 0x060105DE RID: 67038 RVA: 0x003FDF2C File Offset: 0x003FC12C
	public bool IsShowUidView
	{
		get
		{
			return this.IsShowUidViewInternal;
		}
		set
		{
			if (value == this.IsShowUidViewInternal)
			{
				return;
			}
			this.IsShowUidViewInternal = value;
			LoadingController.Instance.UpdateUidViewShow();
		}
	}

	// Token: 0x17001439 RID: 5177
	// (get) Token: 0x060105E0 RID: 67040 RVA: 0x003FDF52 File Offset: 0x003FC152
	// (set) Token: 0x060105DF RID: 67039 RVA: 0x003FDF49 File Offset: 0x003FC149
	public int LastInstanceId
	{
		get
		{
			return this.LastInstanceIdInternal;
		}
		set
		{
			this.LastInstanceIdInternal = value;
		}
	}

	// Token: 0x1700143A RID: 5178
	// (get) Token: 0x060105E1 RID: 67041 RVA: 0x003FDF5A File Offset: 0x003FC15A
	public bool IsLoading
	{
		get
		{
			return this.IsLoadingInternal;
		}
	}

	// Token: 0x060105E2 RID: 67042 RVA: 0x003FDF62 File Offset: 0x003FC162
	public void SetIsLoading(bool isLoading)
	{
		if (this.IsLoadingInternal == isLoading)
		{
			return;
		}
		this.IsLoadingInternal = isLoading;
		if (isLoading)
		{
			EventSystem.Instance.Emit(EEventName.OnStartLoadingState);
			return;
		}
		EventSystem.Instance.Emit(EEventName.OnFinishLoadingState);
	}

	// Token: 0x1700143B RID: 5179
	// (get) Token: 0x060105E3 RID: 67043 RVA: 0x003FDF99 File Offset: 0x003FC199
	public bool IsLoadingView
	{
		get
		{
			return this.IsLoadingViewInternal;
		}
	}

	// Token: 0x060105E4 RID: 67044 RVA: 0x003FDFA1 File Offset: 0x003FC1A1
	public void SetIsLoadingView(bool isLoadingView)
	{
		if (this.IsLoadingViewInternal == isLoadingView)
		{
			return;
		}
		this.IsLoadingViewInternal = isLoadingView;
		if (isLoadingView)
		{
			EventSystem.Instance.Emit(EEventName.OnOpenLoadingView);
			return;
		}
		EventSystem.Instance.Emit(EEventName.OnCloseLoadingView);
	}

	// Token: 0x060105E5 RID: 67045 RVA: 0x003FDFD8 File Offset: 0x003FC1D8
	public void SetIsLoginToWorld(bool isLoginToWorld)
	{
		this.IsLoginToWorld = isLoginToWorld;
	}

	// Token: 0x060105E6 RID: 67046 RVA: 0x003FDFE1 File Offset: 0x003FC1E1
	public bool GetIsLoginToWorld()
	{
		bool isLoginToWorld = this.IsLoginToWorld;
		this.IsLoginToWorld = false;
		return isLoginToWorld;
	}

	// Token: 0x060105E7 RID: 67047 RVA: 0x003FDFF0 File Offset: 0x003FC1F0
	public void SetLoadingTexturePath(string loadingPath)
	{
		this.LoadingTexturePathInternal = loadingPath;
	}

	// Token: 0x060105E8 RID: 67048 RVA: 0x003FDFF9 File Offset: 0x003FC1F9
	[NullableContext(2)]
	public string GetLoadingTexturePath()
	{
		return this.LoadingTexturePathInternal;
	}

	// Token: 0x060105E9 RID: 67049 RVA: 0x003FE001 File Offset: 0x003FC201
	public void SetLoadingTitle(string loadingTitle)
	{
		this.LoadingTitleInternal = loadingTitle;
	}

	// Token: 0x060105EA RID: 67050 RVA: 0x003FE00A File Offset: 0x003FC20A
	[NullableContext(2)]
	public string GetLoadingTitle()
	{
		return this.LoadingTitleInternal;
	}

	// Token: 0x060105EB RID: 67051 RVA: 0x003FE012 File Offset: 0x003FC212
	public void SetLoadingTips(string loadingTips)
	{
		this.LoadingTipsInternal = loadingTips;
	}

	// Token: 0x060105EC RID: 67052 RVA: 0x003FE01B File Offset: 0x003FC21B
	[NullableContext(2)]
	public string GetLoadingTips()
	{
		return this.LoadingTipsInternal;
	}

	// Token: 0x060105ED RID: 67053 RVA: 0x003FE024 File Offset: 0x003FC224
	public EUiViewName GetOpenLoadingViewName()
	{
		if (this.CustomLoadingViewType != null && this.CustomLoadingViewType.Value == ECustomScreenLoading.Cyberpunk)
		{
			return EUiViewName.CyberpunkLoadingView;
		}
		if (this.RoleLoadingConfig != null)
		{
			return EUiViewName.RoleLoadingView;
		}
		int instanceId = CreatureModel.Instance.GetInstanceId();
		EUiViewName? loadingViewNameByInstanceId = this.GetLoadingViewNameByInstanceId(instanceId, true);
		if (loadingViewNameByInstanceId != null)
		{
			return loadingViewNameByInstanceId.Value;
		}
		EUiViewName? loadingViewNameByInstanceId2 = this.GetLoadingViewNameByInstanceId(this.LastInstanceId, false);
		if (loadingViewNameByInstanceId2 != null)
		{
			return loadingViewNameByInstanceId2.Value;
		}
		return EUiViewName.LoadingView;
	}

	// Token: 0x060105EE RID: 67054 RVA: 0x003FE0B0 File Offset: 0x003FC2B0
	private EUiViewName? GetLoadingViewNameByInstanceId(int instanceId, bool isEnter)
	{
		if (instanceId <= 0)
		{
			return null;
		}
		InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(instanceId);
		if (config == null)
		{
			return null;
		}
		EUiViewName? loadingViewNameBySpecialCustomType = this.GetLoadingViewNameBySpecialCustomType(instanceId);
		if (loadingViewNameBySpecialCustomType != null)
		{
			return loadingViewNameBySpecialCustomType;
		}
		int instSubType = config.Value.InstSubType;
		LoadingDefine.IDungeonLoadingData valueOrDefault = LoadingDefine.dungeonToLoadingViewMap.GetValueOrDefault((EDungeonSubType)instSubType);
		if (valueOrDefault == null)
		{
			return null;
		}
		if (!isEnter && valueOrDefault.IgnoreExitLoading != null && valueOrDefault.IgnoreExitLoading.Value)
		{
			return null;
		}
		if (valueOrDefault.Filter != null && !valueOrDefault.Filter(instanceId))
		{
			return null;
		}
		if (valueOrDefault.WorldSubType == null)
		{
			return new EUiViewName?(valueOrDefault.View);
		}
		if (valueOrDefault.WorldSubType.Value == (EWorldDungeonSubType)config.Value.WorldDungeonSubType)
		{
			return new EUiViewName?(valueOrDefault.View);
		}
		return null;
	}

	// Token: 0x060105EF RID: 67055 RVA: 0x003FE1D0 File Offset: 0x003FC3D0
	private EUiViewName? GetLoadingViewNameBySpecialCustomType(int instanceId)
	{
		foreach (ISpecialCustomLoadingTypeChecker specialCustomLoadingTypeChecker in this.SpecialCustomLoadingCheckers)
		{
			if (specialCustomLoadingTypeChecker.CanHandle(instanceId))
			{
				return specialCustomLoadingTypeChecker.GetLoadingViewName(instanceId);
			}
		}
		return null;
	}

	// Token: 0x060105F0 RID: 67056 RVA: 0x003FE210 File Offset: 0x003FC410
	public void SetLoadingConfig(IList<LoadingAreaConfig> loadingConfig)
	{
		this.LoadingAreaConfig = loadingConfig;
	}

	// Token: 0x060105F1 RID: 67057 RVA: 0x003FE21C File Offset: 0x003FC41C
	[NullableContext(2)]
	public List<int> GetLoadingConfigId()
	{
		if (this.LoadingAreaConfig == null)
		{
			return null;
		}
		if (this.LoadingAreaConfig.Count <= 0)
		{
			this.LoadingAreaConfig = null;
			return null;
		}
		List<int> list = new List<int>();
		foreach (LoadingAreaConfig other in this.LoadingAreaConfig)
		{
			LoadingAreaConfig loadingAreaConfig = new LoadingAreaConfig(other);
			double serverTimeStamp = TimeUtil.Instance.GetServerTimeStamp();
			long beginTime = loadingAreaConfig.BeginTime;
			long endTime = loadingAreaConfig.EndTime;
			if (serverTimeStamp >= (double)beginTime && serverTimeStamp <= (double)endTime)
			{
				list.Add(loadingAreaConfig.Id);
			}
		}
		this.LoadingAreaConfig = null;
		return list;
	}

	// Token: 0x060105F2 RID: 67058 RVA: 0x003FE2CC File Offset: 0x003FC4CC
	public void SetRoleLoadingConfig(int? id)
	{
		if (id == null)
		{
			return;
		}
		this.RoleLoadingConfig = ConfigCharacterDisplayStyleById.GetConfig(id.Value, true);
	}

	// Token: 0x1700143C RID: 5180
	// (get) Token: 0x060105F3 RID: 67059 RVA: 0x003FE2EB File Offset: 0x003FC4EB
	public CharacterDisplayStyle? RoleLoading
	{
		get
		{
			return this.RoleLoadingConfig;
		}
	}

	// Token: 0x060105F4 RID: 67060 RVA: 0x003FE2F3 File Offset: 0x003FC4F3
	public void ClearRoleLoadingInfo()
	{
		this.RoleLoadingConfig = null;
	}

	// Token: 0x060105F5 RID: 67061 RVA: 0x003FE304 File Offset: 0x003FC504
	public void SetSpecifiedLoadingConfigId(int? id)
	{
		if (id == null)
		{
			return;
		}
		LoadingLevelArea? levelAreaById = LoadingConfig.Instance.GetLevelAreaById(id.Value);
		if (levelAreaById != null)
		{
			this.SpecifiedLoadingConfig = levelAreaById;
		}
	}

	// Token: 0x060105F6 RID: 67062 RVA: 0x003FE33D File Offset: 0x003FC53D
	public LoadingLevelArea? GetSpecifiedLoadingConfig()
	{
		return this.SpecifiedLoadingConfig;
	}

	// Token: 0x060105F7 RID: 67063 RVA: 0x003FE345 File Offset: 0x003FC545
	public void ClearSpecifiedLoadingConfig()
	{
		this.SpecifiedLoadingConfig = null;
	}

	// Token: 0x060105F8 RID: 67064 RVA: 0x003FE353 File Offset: 0x003FC553
	public void SetCustomLoadingViewType(ECustomScreenLoading? type)
	{
		this.CustomLoadingViewType = type;
	}

	// Token: 0x060105F9 RID: 67065 RVA: 0x003FE35C File Offset: 0x003FC55C
	public ECustomScreenLoading? GetCustomLoadingViewType()
	{
		return this.CustomLoadingViewType;
	}

	// Token: 0x060105FA RID: 67066 RVA: 0x003FE364 File Offset: 0x003FC564
	public void SetSpecialCustomLoadingInfo(TransitionWithSpecialCustomLoadingPb loadingPb)
	{
		HonamiStoryCustomLoadingPb honamiStoryCustomLoadingPb = loadingPb.HonamiStoryCustomLoadingPb;
		if (honamiStoryCustomLoadingPb != null)
		{
			HonamiStoryLoadingDataImpl mainTaskLoadingData = new HonamiStoryLoadingDataImpl
			{
				LoadingId = new int?(honamiStoryCustomLoadingPb.LoadingId)
			};
			HonamiStoryModel.Instance.SetMainTaskLoadingData(mainTaskLoadingData);
		}
	}

	// Token: 0x060105FB RID: 67067 RVA: 0x003FE3A0 File Offset: 0x003FC5A0
	public void SetSpecialCustomLoadingInfoByConfig(ITeleportTransitionWithSpecialCustomLoading option)
	{
		IHonamiStoryCustomLoading loadingType = option.LoadingType;
		if (loadingType != null)
		{
			HonamiStoryLoadingDataImpl mainTaskLoadingData = new HonamiStoryLoadingDataImpl
			{
				LoadingId = new int?(loadingType.LoadingId)
			};
			HonamiStoryModel.Instance.SetMainTaskLoadingData(mainTaskLoadingData);
		}
	}

	// Token: 0x060105FC RID: 67068 RVA: 0x003FE3D9 File Offset: 0x003FC5D9
	protected override bool OnClear()
	{
		this.IsLoadingInternal = false;
		this.IsLoadingViewInternal = false;
		this.CustomLoadingViewType = null;
		this.ReachHandleQueue.Clear();
		return true;
	}

	// Token: 0x1700143D RID: 5181
	// (get) Token: 0x060105FD RID: 67069 RVA: 0x003FE401 File Offset: 0x003FC601
	public static LoadingModel Instance
	{
		get
		{
			return LoadingModel._Instance;
		}
	}

	// Token: 0x060105FE RID: 67070 RVA: 0x003FE408 File Offset: 0x003FC608
	public static LoadingModel GetOrCreateInstance()
	{
		if (LoadingModel._Instance == null)
		{
			LoadingModel.CreateInstance();
		}
		return LoadingModel._Instance;
	}

	// Token: 0x060105FF RID: 67071 RVA: 0x003FE41C File Offset: 0x003FC61C
	public static bool CreateInstance()
	{
		if (LoadingModel._Instance != null)
		{
			return true;
		}
		LoadingModel._Instance = new LoadingModel();
		return true;
	}

	// Token: 0x06010600 RID: 67072 RVA: 0x003FE432 File Offset: 0x003FC632
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06010601 RID: 67073 RVA: 0x003FE434 File Offset: 0x003FC634
	public static void ResetStaticDefaultValue()
	{
		LoadingModel._Instance = null;
	}

	// Token: 0x06010602 RID: 67074 RVA: 0x003FE43C File Offset: 0x003FC63C
	static LoadingModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(LoadingModel.CreateStaticDefaultValue), new Action(LoadingModel.ResetStaticDefaultValue));
	}

	// Token: 0x040078DD RID: 30941
	public EScreenEffectType? ScreenEffect;

	// Token: 0x040078DE RID: 30942
	public int TargetTeleportId;

	// Token: 0x040078DF RID: 30943
	private int TipsTimeInternal;

	// Token: 0x040078E0 RID: 30944
	private int LastInstanceIdInternal;

	// Token: 0x040078E1 RID: 30945
	private bool IsShowUidViewInternal = true;

	// Token: 0x040078E2 RID: 30946
	private bool IsLoadingInternal;

	// Token: 0x040078E3 RID: 30947
	public int Speed;

	// Token: 0x040078E4 RID: 30948
	public int SpeedRate = 1;

	// Token: 0x040078E5 RID: 30949
	[TupleElementNames(new string[]
	{
		"Progress",
		"reachHandle"
	})]
	[Nullable(new byte[]
	{
		1,
		0,
		1
	})]
	public Queue<ValueTuple<int, Action>> ReachHandleQueue = new Queue<ValueTuple<int, Action>>(4);

	// Token: 0x040078E6 RID: 30950
	public float CurrentProgress;

	// Token: 0x040078E7 RID: 30951
	public int NextProgress;

	// Token: 0x040078E8 RID: 30952
	private bool IsLoadingViewInternal;

	// Token: 0x040078E9 RID: 30953
	private bool IsLoginToWorld;

	// Token: 0x040078EA RID: 30954
	[Nullable(2)]
	private string LoadingTexturePathInternal;

	// Token: 0x040078EB RID: 30955
	[Nullable(2)]
	public string LoadingTexturePathOverride;

	// Token: 0x040078EC RID: 30956
	[Nullable(2)]
	private string LoadingTitleInternal;

	// Token: 0x040078ED RID: 30957
	[Nullable(2)]
	private string LoadingTipsInternal;

	// Token: 0x040078EE RID: 30958
	private readonly ISpecialCustomLoadingTypeChecker[] SpecialCustomLoadingCheckers = new ISpecialCustomLoadingTypeChecker[]
	{
		new HonamiStoryLoadingChecker(),
		new LordGymLoadingChecker(),
		new RecallInstanceLoadingChecker()
	};

	// Token: 0x040078EF RID: 30959
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private IList<LoadingAreaConfig> LoadingAreaConfig;

	// Token: 0x040078F0 RID: 30960
	private CharacterDisplayStyle? RoleLoadingConfig;

	// Token: 0x040078F1 RID: 30961
	private LoadingLevelArea? SpecifiedLoadingConfig;

	// Token: 0x040078F2 RID: 30962
	private ECustomScreenLoading? CustomLoadingViewType;

	// Token: 0x040078F3 RID: 30963
	private global::ESpecialCustomLoadingType CurSpecialCustomLoadingType = global::ESpecialCustomLoadingType.HonamiStory;

	// Token: 0x040078F4 RID: 30964
	[Nullable(2)]
	private ISpecialCustomLoadingData CurSpecialCustomLoadingData;

	// Token: 0x040078F5 RID: 30965
	[Nullable(2)]
	private static LoadingModel _Instance;
}
