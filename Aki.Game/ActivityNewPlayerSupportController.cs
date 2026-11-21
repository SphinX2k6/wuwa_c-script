using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.ItemReward;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Ui;
using Google.Protobuf;
using Google.Protobuf.Collections;

// Token: 0x02000868 RID: 2152
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ActivityNewPlayerSupportController : ActivityControllerBase
{
	// Token: 0x17000C0F RID: 3087
	// (get) Token: 0x060061AA RID: 25002 RVA: 0x001F314F File Offset: 0x001F134F
	[Nullable(2)]
	public ActivityNewPlayerSupportData ActivityData
	{
		[NullableContext(2)]
		get
		{
			return this.ActivityDataInternal;
		}
	}

	// Token: 0x060061AB RID: 25003 RVA: 0x001F3158 File Offset: 0x001F1358
	protected override bool OnInit()
	{
		bool flag = false;
		this.ActivityStartConditionMap[ENewPlayerSupportStartCondition.UnForbidStart] = !flag;
		return true;
	}

	// Token: 0x060061AC RID: 25004 RVA: 0x001F3178 File Offset: 0x001F1378
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
		EventSystem.Instance.Add(EEventName.OnActivityNewPlayerSupportInfoUpdate, new Action(this.OnActivityInfoUpdate));
	}

	// Token: 0x060061AD RID: 25005 RVA: 0x001F31B2 File Offset: 0x001F13B2
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
		EventSystem.Instance.Remove(EEventName.OnActivityNewPlayerSupportInfoUpdate, new Action(this.OnActivityInfoUpdate));
	}

	// Token: 0x060061AE RID: 25006 RVA: 0x001F31EC File Offset: 0x001F13EC
	protected override bool OnClear()
	{
		this.ActivityStartConditionMap.Clear();
		return true;
	}

	// Token: 0x060061AF RID: 25007 RVA: 0x001F31FA File Offset: 0x001F13FA
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.NewPlayerSupportActivityTaskUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnTaskUpdateNotify));
		Net.Instance.Register(ENotifyMessageId.NewPlayerSupportActivityTrialRoleUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnTrialRoleUpdateNotify));
	}

	// Token: 0x060061B0 RID: 25008 RVA: 0x001F3234 File Offset: 0x001F1434
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.NewPlayerSupportActivityTaskUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.NewPlayerSupportActivityTrialRoleUpdateNotify);
	}

	// Token: 0x060061B1 RID: 25009 RVA: 0x001F3256 File Offset: 0x001F1456
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x060061B2 RID: 25010 RVA: 0x001F3258 File Offset: 0x001F1458
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_BeginnerSupportGuideView";
	}

	// Token: 0x060061B3 RID: 25011 RVA: 0x001F325F File Offset: 0x001F145F
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new ActivityNewPlayerSupportSubView();
	}

	// Token: 0x060061B4 RID: 25012 RVA: 0x001F3266 File Offset: 0x001F1466
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		this.ActivityDataInternal = new ActivityNewPlayerSupportData();
		return this.ActivityDataInternal;
	}

	// Token: 0x060061B5 RID: 25013 RVA: 0x001F327C File Offset: 0x001F147C
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		foreach (EUiViewName viewName in new EUiViewName[]
		{
			EUiViewName.ActivityNewPlayerSupportTrialRoleView
		})
		{
			if (UiManager.Instance.IsViewOpen(viewName))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060061B6 RID: 25014 RVA: 0x001F32C4 File Offset: 0x001F14C4
	[NullableContext(2)]
	private void OnTaskUpdateNotify(IMessage msg, Net.CallbackStatus _)
	{
		NewPlayerSupportActivityTaskUpdateNotify newPlayerSupportActivityTaskUpdateNotify = (NewPlayerSupportActivityTaskUpdateNotify)msg;
		if (this.ActivityDataInternal != null)
		{
			this.ActivityDataInternal.UpdateTaskData(newPlayerSupportActivityTaskUpdateNotify.ConditionTasks);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.ActivityDataInternal.Id);
		}
		EventSystem.Instance.Emit(EEventName.OnActivityNewPlayerSupportTaskUpdate);
	}

	// Token: 0x060061B7 RID: 25015 RVA: 0x001F331C File Offset: 0x001F151C
	[NullableContext(2)]
	private void OnTrialRoleUpdateNotify(IMessage msg, Net.CallbackStatus _)
	{
		NewPlayerSupportActivityTrialRoleUpdateNotify newPlayerSupportActivityTrialRoleUpdateNotify = (NewPlayerSupportActivityTrialRoleUpdateNotify)msg;
		RepeatedField<int> trialRoleId = newPlayerSupportActivityTrialRoleUpdateNotify.TrialRoleId;
		roleInfo curUseRoleInfo = newPlayerSupportActivityTrialRoleUpdateNotify.CurUseRoleInfo;
		foreach (int num in trialRoleId)
		{
			if (curUseRoleInfo != null && curUseRoleInfo.RoleId == num)
			{
				this.UpdateActivatedTrialRoleInternal(num, curUseRoleInfo);
			}
			else
			{
				this.UpdateActivatedTrialRoleInternal(num, null);
			}
		}
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.ActivityDataInternal.Id);
	}

	// Token: 0x060061B8 RID: 25016 RVA: 0x001F33AC File Offset: 0x001F15AC
	private void OnWorldDone()
	{
		this.ActivityStartConditionMap[ENewPlayerSupportStartCondition.WorldDone] = true;
		this.CheckIsStart(false);
	}

	// Token: 0x060061B9 RID: 25017 RVA: 0x001F33C4 File Offset: 0x001F15C4
	private void OnActivityInfoUpdate()
	{
		bool worldDone = GameModeModel.Instance.WorldDone;
		this.ActivityStartConditionMap[ENewPlayerSupportStartCondition.WorldDone] = worldDone;
		ActivityNewPlayerSupportData activityDataInternal = this.ActivityDataInternal;
		bool value = activityDataInternal != null && activityDataInternal.IsActivityFirstShow;
		this.ActivityStartConditionMap[ENewPlayerSupportStartCondition.FirstShow] = value;
		this.CheckIsStart(true);
	}

	// Token: 0x060061BA RID: 25018 RVA: 0x001F3410 File Offset: 0x001F1610
	private void CheckIsStart(bool isInstantly = false)
	{
		if (!PublicUtil.Instance.GetIsSilentLogin())
		{
			ActivityNewPlayerSupportData activityDataInternal = this.ActivityDataInternal;
			if (activityDataInternal == null || !activityDataInternal.AlreadyStartView)
			{
				bool flag = true;
				foreach (object obj in Enum.GetValues(typeof(ENewPlayerSupportStartCondition)))
				{
					ENewPlayerSupportStartCondition key = (ENewPlayerSupportStartCondition)obj;
					bool flag2;
					if (!this.ActivityStartConditionMap.TryGetValue(key, out flag2) || !flag2)
					{
						flag = false;
						break;
					}
				}
				if (!flag)
				{
					this.ResetCondition();
					return;
				}
				SplashScreenTask splashScreenTask = new SplashScreenTask(ESplashScreenSourceModuleType.NewPlayerSupport, ESplashScreenType.Config, delegate()
				{
					UiManager.Instance.OpenView(EUiViewName.ActivityNewPlayerSupportStartupView, null, null);
				});
				SplashScreenController.Instance.PushSplashScreenTask(splashScreenTask, isInstantly);
				return;
			}
		}
		this.ResetCondition();
	}

	// Token: 0x060061BB RID: 25019 RVA: 0x001F34EC File Offset: 0x001F16EC
	private void ResetCondition()
	{
		this.ActivityStartConditionMap[ENewPlayerSupportStartCondition.WorldDone] = false;
	}

	// Token: 0x060061BC RID: 25020 RVA: 0x001F34FC File Offset: 0x001F16FC
	public void RequestRewardTask(int taskId, bool receiveAll = false)
	{
		ActivityNewPlayerSupportController.<>c__DisplayClass21_0 CS$<>8__locals1 = new ActivityNewPlayerSupportController.<>c__DisplayClass21_0();
		CS$<>8__locals1.<>4__this = this;
		if (receiveAll)
		{
			ActivityNewPlayerSupportController.<>c__DisplayClass21_0 CS$<>8__locals2 = CS$<>8__locals1;
			ActivityNewPlayerSupportData activityData = this.ActivityData;
			CS$<>8__locals2.taskIds = (((activityData != null) ? activityData.GetCanReceiveTaskIdList() : null) ?? new List<int>());
		}
		else
		{
			CS$<>8__locals1.taskIds = new List<int>
			{
				taskId
			};
		}
		if (CS$<>8__locals1.taskIds == null || CS$<>8__locals1.taskIds.Count <= 0)
		{
			return;
		}
		NewPlayerSupportRewardTaskRequest newPlayerSupportRewardTaskRequest = NewPlayerSupportRewardTaskRequest.Create();
		newPlayerSupportRewardTaskRequest.TaskIds.AddRange(CS$<>8__locals1.taskIds);
		Net.Instance.Call(ERequestMessageId.NewPlayerSupportRewardTaskRequest, newPlayerSupportRewardTaskRequest, delegate(IMessage msg, Net.CallbackStatus __)
		{
			NewPlayerSupportRewardTaskResponse newPlayerSupportRewardTaskResponse = (NewPlayerSupportRewardTaskResponse)msg;
			if (newPlayerSupportRewardTaskResponse.Code != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(newPlayerSupportRewardTaskResponse.Code, 25832, null, true, true);
				return;
			}
			Dictionary<int, RewardItemData> dictionary = new Dictionary<int, RewardItemData>();
			foreach (int id in CS$<>8__locals1.taskIds)
			{
				ActivityNewPlayerSupportTaskData taskData = CS$<>8__locals1.<>4__this.ActivityDataInternal.GetTaskData(id);
				taskData.SetTaskStatus(ConditionTaskState.ConditionTaskTaken);
				foreach (TItem titem in taskData.GetRewardList())
				{
					int itemId = titem.ItemData.ItemId;
					int count = titem.Count;
					int incId = titem.ItemData.IncId;
					RewardItemData rewardItemData;
					if (dictionary.TryGetValue(itemId, out rewardItemData))
					{
						rewardItemData.Count += count;
					}
					else
					{
						dictionary[itemId] = new RewardItemData(itemId, count, new int?(incId), EDropItemType.Normal);
					}
				}
			}
			List<RewardItemData> list = new List<RewardItemData>();
			foreach (RewardItemData item in dictionary.Values)
			{
				list.Add(item);
			}
			EventSystem.Instance.Emit(EEventName.OnActivityNewPlayerSupportTaskUpdate);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, CS$<>8__locals1.<>4__this.ActivityDataInternal.Id);
			RepeatedField<int> roleId = newPlayerSupportRewardTaskResponse.RoleId;
			foreach (int roleId2 in roleId)
			{
				CS$<>8__locals1.<>4__this.UpdateActivatedTrialRoleInternal(roleId2, null);
			}
			CS$<>8__locals1.<>4__this.OpenRewardView(list, new List<int>(roleId));
		}, 0);
	}

	// Token: 0x060061BD RID: 25021 RVA: 0x001F359C File Offset: 0x001F179C
	public void RequestTrialRoleLvUp(int trialRoleId)
	{
		NewPlayerSupportTrialRoleLvUpRequest newPlayerSupportTrialRoleLvUpRequest = NewPlayerSupportTrialRoleLvUpRequest.Create();
		newPlayerSupportTrialRoleLvUpRequest.TrialRoleId = trialRoleId;
		Net.Instance.Call(ERequestMessageId.NewPlayerSupportTrialRoleLvUpRequest, newPlayerSupportTrialRoleLvUpRequest, delegate(IMessage msg, Net.CallbackStatus __)
		{
			NewPlayerSupportTrialRoleLvUpResponse newPlayerSupportTrialRoleLvUpResponse = (NewPlayerSupportTrialRoleLvUpResponse)msg;
			if (newPlayerSupportTrialRoleLvUpResponse.Code != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(newPlayerSupportTrialRoleLvUpResponse.Code, 22280, null, true, true);
				return;
			}
			this.UpdateActivatedTrialRoleInternal(newPlayerSupportTrialRoleLvUpResponse.RoleId, newPlayerSupportTrialRoleLvUpResponse.CurUseRoleInfo);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.ActivityData.Id);
		}, 0);
	}

	// Token: 0x060061BE RID: 25022 RVA: 0x001F35D4 File Offset: 0x001F17D4
	[NullableContext(2)]
	public void RequestSetCurUseTrialRole(int trialRoleId, Action<int> callback)
	{
		if (RoleUtils.GetTrialRoleType(trialRoleId) != ETrialRoleType.NewbieSupportTrial)
		{
			return;
		}
		NewPlayerSupportSetCurUseTrialRoleRequest newPlayerSupportSetCurUseTrialRoleRequest = NewPlayerSupportSetCurUseTrialRoleRequest.Create();
		newPlayerSupportSetCurUseTrialRoleRequest.TrialRoleId = trialRoleId;
		Net.Instance.Call(ERequestMessageId.NewPlayerSupportSetCurUseTrialRoleRequest, newPlayerSupportSetCurUseTrialRoleRequest, delegate(IMessage msg, Net.CallbackStatus __)
		{
			NewPlayerSupportSetCurUseTrialRoleResponse newPlayerSupportSetCurUseTrialRoleResponse = (NewPlayerSupportSetCurUseTrialRoleResponse)msg;
			if (newPlayerSupportSetCurUseTrialRoleResponse.Code != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(newPlayerSupportSetCurUseTrialRoleResponse.Code, 29875, null, true, true);
				return;
			}
			int roleId = newPlayerSupportSetCurUseTrialRoleResponse.RoleId;
			ActivityNewPlayerSupportData activityData = this.ActivityData;
			if (activityData != null)
			{
				activityData.UpdateCurUseTrialRole(roleId, newPlayerSupportSetCurUseTrialRoleResponse.CurUseRoleInfo);
			}
			Action<int> callback2 = callback;
			if (callback2 != null)
			{
				callback2(roleId);
			}
			EventSystem.Instance.Emit<int>(EEventName.OnActivityNewPlayerSupportCurTrialRoleChange, roleId);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.ActivityDataInternal.Id);
		}, 0);
	}

	// Token: 0x060061BF RID: 25023 RVA: 0x001F362C File Offset: 0x001F182C
	public void OpenTrialRoleView(int? selectedGroupId = null)
	{
		NewPlayerSupportTrialRoleViewModel newPlayerSupportTrialRoleViewModel = new NewPlayerSupportTrialRoleViewModel(ETrialRoleType.NewbieSupportTrial, ConfigCommonParamById.GetStringConfig("NewPlayerSupportTrialRoleIcon"), ConfigCommonParamById.GetStringConfig("NewPlayerSupportTrialRoleTitle"), 465, selectedGroupId);
		newPlayerSupportTrialRoleViewModel.SetRequestTrialRoleLvUpFunc(new Action<int>(this.RequestTrialRoleLvUp));
		newPlayerSupportTrialRoleViewModel.SetRequestSetCurUseTrialRoleFunc(new Action<int, Action<int>>(this.RequestSetCurUseTrialRole));
		Dictionary<int, string> trialRoleUnlockDesc = ActivityNewPlayerSupportConfig.Instance.GetTrialRoleUnlockDesc();
		newPlayerSupportTrialRoleViewModel.SetTrialRoleGroupUnlockDesc(trialRoleUnlockDesc);
		this.ActivityData.SaveTrailRoleEntranceRedDot(false);
		UiManager.Instance.OpenView(EUiViewName.ActivityNewPlayerSupportTrialRoleView, newPlayerSupportTrialRoleViewModel, null);
	}

	// Token: 0x060061C0 RID: 25024 RVA: 0x001F36B0 File Offset: 0x001F18B0
	public void OpenRewardView(List<RewardItemData> rewardDataList, List<int> trialRoleList)
	{
		RewardData<ICommonRewardInfo> rewardData = ItemRewardModel.Instance.RefreshCommonRewardDataFromConfig(1009, EUiViewName.ActivityNewPlayerSupportRewardView, rewardDataList, null, null, null, null, null, true, false);
		if (rewardData == null)
		{
			return;
		}
		ActivityNewPlayerSupportRewardViewParam param = new ActivityNewPlayerSupportRewardViewParam
		{
			RewardData = rewardData,
			TrialRoleList = trialRoleList
		};
		UiManager.Instance.OpenView(EUiViewName.ActivityNewPlayerSupportRewardView, param, null);
	}

	// Token: 0x060061C1 RID: 25025 RVA: 0x001F3704 File Offset: 0x001F1904
	[NullableContext(2)]
	private void UpdateActivatedTrialRoleInternal(int roleId, roleInfo trialRoleInfo = null)
	{
		int? trialRoleGroupId = TrialRoleConfig.Instance.GetTrialRoleGroupId(roleId);
		if (TrialRoleModel.Instance.GetDataByGroupId(trialRoleGroupId.Value).IsLocked())
		{
			this.ActivityData.SaveTrailRoleEntranceRedDot(true);
		}
		this.ActivityData.UpdateActivatedTrialRole(roleId, trialRoleInfo);
	}

	// Token: 0x060061C2 RID: 25026 RVA: 0x001F374E File Offset: 0x001F194E
	public void NotifyRedDotRefresh()
	{
		if (this.ActivityDataInternal != null)
		{
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.ActivityDataInternal.Id);
		}
	}

	// Token: 0x060061C3 RID: 25027 RVA: 0x001F3773 File Offset: 0x001F1973
	public void SetForbidActivityStart(bool isForbid)
	{
	}

	// Token: 0x17000C10 RID: 3088
	// (get) Token: 0x060061C4 RID: 25028 RVA: 0x001F3775 File Offset: 0x001F1975
	public static ActivityNewPlayerSupportController Instance
	{
		get
		{
			return ActivityNewPlayerSupportController._Instance;
		}
	}

	// Token: 0x060061C5 RID: 25029 RVA: 0x001F377C File Offset: 0x001F197C
	public static ActivityNewPlayerSupportController GetOrCreateInstance()
	{
		if (ActivityNewPlayerSupportController._Instance == null)
		{
			ActivityNewPlayerSupportController.CreateInstance();
		}
		return ActivityNewPlayerSupportController._Instance;
	}

	// Token: 0x060061C6 RID: 25030 RVA: 0x001F3790 File Offset: 0x001F1990
	public static bool CreateInstance()
	{
		if (ActivityNewPlayerSupportController._Instance != null)
		{
			return true;
		}
		ActivityNewPlayerSupportController._Instance = new ActivityNewPlayerSupportController();
		return true;
	}

	// Token: 0x060061C7 RID: 25031 RVA: 0x001F37A6 File Offset: 0x001F19A6
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060061C8 RID: 25032 RVA: 0x001F37A8 File Offset: 0x001F19A8
	public static void ResetStaticDefaultValue()
	{
		ActivityNewPlayerSupportController._Instance = null;
	}

	// Token: 0x060061C9 RID: 25033 RVA: 0x001F37B0 File Offset: 0x001F19B0
	static ActivityNewPlayerSupportController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityNewPlayerSupportController.CreateStaticDefaultValue), new Action(ActivityNewPlayerSupportController.ResetStaticDefaultValue));
	}

	// Token: 0x04003F8C RID: 16268
	[Nullable(2)]
	private ActivityNewPlayerSupportData ActivityDataInternal;

	// Token: 0x04003F8D RID: 16269
	private readonly Dictionary<ENewPlayerSupportStartCondition, bool> ActivityStartConditionMap = new Dictionary<ENewPlayerSupportStartCondition, bool>();

	// Token: 0x04003F8E RID: 16270
	[Nullable(2)]
	private static ActivityNewPlayerSupportController _Instance;
}
