using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.AdventureGuide;
using CSharpScript.Game.Ui;

// Token: 0x0200154E RID: 5454
[NullableContext(1)]
[Nullable(0)]
public class LoadingModel : ModelBase
{
	// Token: 0x17001464 RID: 5220
	// (get) Token: 0x0600DA44 RID: 55876 RVA: 0x0040A34C File Offset: 0x0040854C
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

	// Token: 0x17001465 RID: 5221
	// (get) Token: 0x0600DA45 RID: 55877 RVA: 0x0040A36C File Offset: 0x0040856C
	// (set) Token: 0x0600DA46 RID: 55878 RVA: 0x0040A374 File Offset: 0x00408574
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

	// Token: 0x17001466 RID: 5222
	// (get) Token: 0x0600DA48 RID: 55880 RVA: 0x0040A39A File Offset: 0x0040859A
	// (set) Token: 0x0600DA47 RID: 55879 RVA: 0x0040A391 File Offset: 0x00408591
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

	// Token: 0x17001467 RID: 5223
	// (get) Token: 0x0600DA49 RID: 55881 RVA: 0x0040A3A2 File Offset: 0x004085A2
	public bool IsLoading
	{
		get
		{
			return this.IsLoadingInternal;
		}
	}

	// Token: 0x0600DA4A RID: 55882 RVA: 0x0040A3AA File Offset: 0x004085AA
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

	// Token: 0x17001468 RID: 5224
	// (get) Token: 0x0600DA4B RID: 55883 RVA: 0x0040A3E1 File Offset: 0x004085E1
	public bool IsLoadingView
	{
		get
		{
			return this.IsLoadingViewInternal;
		}
	}

	// Token: 0x0600DA4C RID: 55884 RVA: 0x0040A3E9 File Offset: 0x004085E9
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

	// Token: 0x0600DA4D RID: 55885 RVA: 0x0040A420 File Offset: 0x00408620
	public void SetIsLoginToWorld(bool isLoginToWorld)
	{
		this.IsLoginToWorld = isLoginToWorld;
	}

	// Token: 0x0600DA4E RID: 55886 RVA: 0x0040A429 File Offset: 0x00408629
	public bool GetIsLoginToWorld()
	{
		bool isLoginToWorld = this.IsLoginToWorld;
		this.IsLoginToWorld = false;
		return isLoginToWorld;
	}

	// Token: 0x0600DA4F RID: 55887 RVA: 0x0040A438 File Offset: 0x00408638
	public void SetLoadingTexturePath(string loadingPath)
	{
		this.LoadingTexturePathInternal = loadingPath;
	}

	// Token: 0x0600DA50 RID: 55888 RVA: 0x0040A441 File Offset: 0x00408641
	[NullableContext(2)]
	public string GetLoadingTexturePath()
	{
		return this.LoadingTexturePathInternal;
	}

	// Token: 0x0600DA51 RID: 55889 RVA: 0x0040A449 File Offset: 0x00408649
	public void SetLoadingTitle(string loadingTitle)
	{
		this.LoadingTitleInternal = loadingTitle;
	}

	// Token: 0x0600DA52 RID: 55890 RVA: 0x0040A452 File Offset: 0x00408652
	[NullableContext(2)]
	public string GetLoadingTitle()
	{
		return this.LoadingTitleInternal;
	}

	// Token: 0x0600DA53 RID: 55891 RVA: 0x0040A45A File Offset: 0x0040865A
	public void SetLoadingTips(string loadingTips)
	{
		this.LoadingTipsInternal = loadingTips;
	}

	// Token: 0x0600DA54 RID: 55892 RVA: 0x0040A463 File Offset: 0x00408663
	[NullableContext(2)]
	public string GetLoadingTips()
	{
		return this.LoadingTipsInternal;
	}

	// Token: 0x0600DA55 RID: 55893 RVA: 0x0040A46C File Offset: 0x0040866C
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

	// Token: 0x0600DA56 RID: 55894 RVA: 0x0040A4F8 File Offset: 0x004086F8
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

	// Token: 0x0600DA57 RID: 55895 RVA: 0x0040A618 File Offset: 0x00408818
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

	// Token: 0x0600DA58 RID: 55896 RVA: 0x0040A658 File Offset: 0x00408858
	public void SetLoadingConfig(IList<LoadingAreaConfig> loadingConfig)
	{
		this.LoadingAreaConfig = loadingConfig;
	}

	// Token: 0x0600DA59 RID: 55897 RVA: 0x0040A664 File Offset: 0x00408864
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

	// Token: 0x0600DA5A RID: 55898 RVA: 0x0040A714 File Offset: 0x00408914
	public void SetRoleLoadingConfig(int? id)
	{
		if (id == null)
		{
			return;
		}
		this.RoleLoadingConfig = ConfigCharacterDisplayStyleById.GetConfig(id.Value, true);
	}

	// Token: 0x17001469 RID: 5225
	// (get) Token: 0x0600DA5B RID: 55899 RVA: 0x0040A733 File Offset: 0x00408933
	public CharacterDisplayStyle? RoleLoading
	{
		get
		{
			return this.RoleLoadingConfig;
		}
	}

	// Token: 0x0600DA5C RID: 55900 RVA: 0x0040A73B File Offset: 0x0040893B
	public void ClearRoleLoadingInfo()
	{
		this.RoleLoadingConfig = null;
	}

	// Token: 0x0600DA5D RID: 55901 RVA: 0x0040A74C File Offset: 0x0040894C
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

	// Token: 0x0600DA5E RID: 55902 RVA: 0x0040A785 File Offset: 0x00408985
	public LoadingLevelArea? GetSpecifiedLoadingConfig()
	{
		return this.SpecifiedLoadingConfig;
	}

	// Token: 0x0600DA5F RID: 55903 RVA: 0x0040A78D File Offset: 0x0040898D
	public void ClearSpecifiedLoadingConfig()
	{
		this.SpecifiedLoadingConfig = null;
	}

	// Token: 0x0600DA60 RID: 55904 RVA: 0x0040A79B File Offset: 0x0040899B
	public void SetCustomLoadingViewType(ECustomScreenLoading? type)
	{
		this.CustomLoadingViewType = type;
	}

	// Token: 0x0600DA61 RID: 55905 RVA: 0x0040A7A4 File Offset: 0x004089A4
	public ECustomScreenLoading? GetCustomLoadingViewType()
	{
		return this.CustomLoadingViewType;
	}

	// Token: 0x0600DA62 RID: 55906 RVA: 0x0040A7AC File Offset: 0x004089AC
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

	// Token: 0x0600DA63 RID: 55907 RVA: 0x0040A7E8 File Offset: 0x004089E8
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

	// Token: 0x0600DA64 RID: 55908 RVA: 0x0040A821 File Offset: 0x00408A21
	protected override bool OnClear()
	{
		this.IsLoadingInternal = false;
		this.IsLoadingViewInternal = false;
		this.CustomLoadingViewType = null;
		this.ReachHandleQueue.Clear();
		return true;
	}

	// Token: 0x1700146A RID: 5226
	// (get) Token: 0x0600DA65 RID: 55909 RVA: 0x0040A849 File Offset: 0x00408A49
	public static LoadingModel Instance
	{
		get
		{
			return LoadingModel._Instance;
		}
	}

	// Token: 0x0600DA66 RID: 55910 RVA: 0x0040A850 File Offset: 0x00408A50
	public static LoadingModel GetOrCreateInstance()
	{
		if (LoadingModel._Instance == null)
		{
			LoadingModel.CreateInstance();
		}
		return LoadingModel._Instance;
	}

	// Token: 0x0600DA67 RID: 55911 RVA: 0x0040A864 File Offset: 0x00408A64
	public static bool CreateInstance()
	{
		if (LoadingModel._Instance != null)
		{
			return true;
		}
		LoadingModel._Instance = new LoadingModel();
		return true;
	}

	// Token: 0x0600DA68 RID: 55912 RVA: 0x0040A87A File Offset: 0x00408A7A
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600DA69 RID: 55913 RVA: 0x0040A87C File Offset: 0x00408A7C
	public static void ResetStaticDefaultValue()
	{
		LoadingModel._Instance = null;
	}

	// Token: 0x0600DA6A RID: 55914 RVA: 0x0040A884 File Offset: 0x00408A84
	static LoadingModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(LoadingModel.CreateStaticDefaultValue), new Action(LoadingModel.ResetStaticDefaultValue));
	}

	// Token: 0x040079C6 RID: 31174
	public EScreenEffectType? ScreenEffect;

	// Token: 0x040079C7 RID: 31175
	public int TargetTeleportId;

	// Token: 0x040079C8 RID: 31176
	private int TipsTimeInternal;

	// Token: 0x040079C9 RID: 31177
	private int LastInstanceIdInternal;

	// Token: 0x040079CA RID: 31178
	private bool IsShowUidViewInternal = true;

	// Token: 0x040079CB RID: 31179
	private bool IsLoadingInternal;

	// Token: 0x040079CC RID: 31180
	public int Speed;

	// Token: 0x040079CD RID: 31181
	public int SpeedRate = 1;

	// Token: 0x040079CE RID: 31182
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

	// Token: 0x040079CF RID: 31183
	public float CurrentProgress;

	// Token: 0x040079D0 RID: 31184
	public int NextProgress;

	// Token: 0x040079D1 RID: 31185
	private bool IsLoadingViewInternal;

	// Token: 0x040079D2 RID: 31186
	private bool IsLoginToWorld;

	// Token: 0x040079D3 RID: 31187
	[Nullable(2)]
	private string LoadingTexturePathInternal;

	// Token: 0x040079D4 RID: 31188
	[Nullable(2)]
	public string LoadingTexturePathOverride;

	// Token: 0x040079D5 RID: 31189
	[Nullable(2)]
	private string LoadingTitleInternal;

	// Token: 0x040079D6 RID: 31190
	[Nullable(2)]
	private string LoadingTipsInternal;

	// Token: 0x040079D7 RID: 31191
	private readonly ISpecialCustomLoadingTypeChecker[] SpecialCustomLoadingCheckers = new ISpecialCustomLoadingTypeChecker[]
	{
		new HonamiStoryLoadingChecker(),
		new LordGymLoadingChecker(),
		new RecallInstanceLoadingChecker()
	};

	// Token: 0x040079D8 RID: 31192
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private IList<LoadingAreaConfig> LoadingAreaConfig;

	// Token: 0x040079D9 RID: 31193
	private CharacterDisplayStyle? RoleLoadingConfig;

	// Token: 0x040079DA RID: 31194
	private LoadingLevelArea? SpecifiedLoadingConfig;

	// Token: 0x040079DB RID: 31195
	private ECustomScreenLoading? CustomLoadingViewType;

	// Token: 0x040079DC RID: 31196
	private global::ESpecialCustomLoadingType CurSpecialCustomLoadingType = global::ESpecialCustomLoadingType.HonamiStory;

	// Token: 0x040079DD RID: 31197
	[Nullable(2)]
	private ISpecialCustomLoadingData CurSpecialCustomLoadingData;

	// Token: 0x040079DE RID: 31198
	[Nullable(2)]
	private static LoadingModel _Instance;
}
