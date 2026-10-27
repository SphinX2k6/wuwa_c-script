using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.ItemReward;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Ui;
using Google.Protobuf;
using Google.Protobuf.Collections;

// Token: 0x020013B4 RID: 5044
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ActivityNewPlayerSupportController : ActivityControllerBase
{
	// Token: 0x17000BEF RID: 3055
	// (get) Token: 0x06008E15 RID: 36373 RVA: 0x001EA5E7 File Offset: 0x001E87E7
	[Nullable(2)]
	public ActivityNewPlayerSupportData ActivityData
	{
		[NullableContext(2)]
		get
		{
			return this.ActivityDataInternal;
		}
	}

	// Token: 0x06008E16 RID: 36374 RVA: 0x001EA5F0 File Offset: 0x001E87F0
	protected override bool OnInit()
	{
		bool flag = false;
		if (!Info.Instance.IsBuildShipping)
		{
			flag = LocalStorage.GetGlobal<bool>(ELocalStorageGlobalKey.NewPlayerSupportForbidStartView, false);
		}
		this.ActivityStartConditionMap[ENewPlayerSupportStartCondition.UnForbidStart] = !flag;
		return true;
	}

	// Token: 0x06008E17 RID: 36375 RVA: 0x001EA628 File Offset: 0x001E8828
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
		EventSystem.Instance.Add(EEventName.OnActivityNewPlayerSupportInfoUpdate, new Action(this.OnActivityInfoUpdate));
	}

	// Token: 0x06008E18 RID: 36376 RVA: 0x001EA662 File Offset: 0x001E8862
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
		EventSystem.Instance.Remove(EEventName.OnActivityNewPlayerSupportInfoUpdate, new Action(this.OnActivityInfoUpdate));
	}

	// Token: 0x06008E19 RID: 36377 RVA: 0x001EA69C File Offset: 0x001E889C
	protected override bool OnClear()
	{
		this.ActivityStartConditionMap.Clear();
		return true;
	}

	// Token: 0x06008E1A RID: 36378 RVA: 0x001EA6AA File Offset: 0x001E88AA
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.NewPlayerSupportActivityTaskUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnTaskUpdateNotify));
		Net.Instance.Register(ENotifyMessageId.NewPlayerSupportActivityTrialRoleUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnTrialRoleUpdateNotify));
	}

	// Token: 0x06008E1B RID: 36379 RVA: 0x001EA6E4 File Offset: 0x001E88E4
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.NewPlayerSupportActivityTaskUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.NewPlayerSupportActivityTrialRoleUpdateNotify);
	}

	// Token: 0x06008E1C RID: 36380 RVA: 0x001EA706 File Offset: 0x001E8906
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x06008E1D RID: 36381 RVA: 0x001EA708 File Offset: 0x001E8908
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_BeginnerSupportGuideView";
	}

	// Token: 0x06008E1E RID: 36382 RVA: 0x001EA70F File Offset: 0x001E890F
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new ActivityNewPlayerSupportSubView();
	}

	// Token: 0x06008E1F RID: 36383 RVA: 0x001EA716 File Offset: 0x001E8916
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		this.ActivityDataInternal = new ActivityNewPlayerSupportData();
		return this.ActivityDataInternal;
	}

	// Token: 0x06008E20 RID: 36384 RVA: 0x001EA72C File Offset: 0x001E892C
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

	// Token: 0x06008E21 RID: 36385 RVA: 0x001EA774 File Offset: 0x001E8974
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

	// Token: 0x06008E22 RID: 36386 RVA: 0x001EA7CC File Offset: 0x001E89CC
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

	// Token: 0x06008E23 RID: 36387 RVA: 0x001EA85C File Offset: 0x001E8A5C
	private void OnWorldDone()
	{
		this.ActivityStartConditionMap[ENewPlayerSupportStartCondition.WorldDone] = true;
		this.CheckIsStart(false);
	}

	// Token: 0x06008E24 RID: 36388 RVA: 0x001EA874 File Offset: 0x001E8A74
	private void OnActivityInfoUpdate()
	{
		bool worldDone = GameModeModel.Instance.WorldDone;
		this.ActivityStartConditionMap[ENewPlayerSupportStartCondition.WorldDone] = worldDone;
		ActivityNewPlayerSupportData activityDataInternal = this.ActivityDataInternal;
		bool value = activityDataInternal != null && activityDataInternal.IsActivityFirstShow;
		this.ActivityStartConditionMap[ENewPlayerSupportStartCondition.FirstShow] = value;
		this.CheckIsStart(true);
	}

	// Token: 0x06008E25 RID: 36389 RVA: 0x001EA8C0 File Offset: 0x001E8AC0
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

	// Token: 0x06008E26 RID: 36390 RVA: 0x001EA99C File Offset: 0x001E8B9C
	private void ResetCondition()
	{
		this.ActivityStartConditionMap[ENewPlayerSupportStartCondition.WorldDone] = false;
	}

	// Token: 0x06008E27 RID: 36391 RVA: 0x001EA9AC File Offset: 0x001E8BAC
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(newPlayerSupportRewardTaskResponse.Code, 15261, null, true, true);
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
			CS$<>8__locals1.<>4__this.OpenRewardView(list, roleId.ToList<int>());
		}, 0);
	}

	// Token: 0x06008E28 RID: 36392 RVA: 0x001EAA4C File Offset: 0x001E8C4C
	public void RequestTrialRoleLvUp(int trialRoleId)
	{
		NewPlayerSupportTrialRoleLvUpRequest newPlayerSupportTrialRoleLvUpRequest = NewPlayerSupportTrialRoleLvUpRequest.Create();
		newPlayerSupportTrialRoleLvUpRequest.TrialRoleId = trialRoleId;
		Net.Instance.Call(ERequestMessageId.NewPlayerSupportTrialRoleLvUpRequest, newPlayerSupportTrialRoleLvUpRequest, delegate(IMessage msg, Net.CallbackStatus __)
		{
			NewPlayerSupportTrialRoleLvUpResponse newPlayerSupportTrialRoleLvUpResponse = (NewPlayerSupportTrialRoleLvUpResponse)msg;
			if (newPlayerSupportTrialRoleLvUpResponse.Code != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(newPlayerSupportTrialRoleLvUpResponse.Code, 24698, null, true, true);
				return;
			}
			this.UpdateActivatedTrialRoleInternal(newPlayerSupportTrialRoleLvUpResponse.RoleId, newPlayerSupportTrialRoleLvUpResponse.CurUseRoleInfo);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.ActivityData.Id);
		}, 0);
	}

	// Token: 0x06008E29 RID: 36393 RVA: 0x001EAA84 File Offset: 0x001E8C84
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(newPlayerSupportSetCurUseTrialRoleResponse.Code, 22287, null, true, true);
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

	// Token: 0x06008E2A RID: 36394 RVA: 0x001EAADC File Offset: 0x001E8CDC
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

	// Token: 0x06008E2B RID: 36395 RVA: 0x001EAB60 File Offset: 0x001E8D60
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

	// Token: 0x06008E2C RID: 36396 RVA: 0x001EABB4 File Offset: 0x001E8DB4
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

	// Token: 0x06008E2D RID: 36397 RVA: 0x001EABFE File Offset: 0x001E8DFE
	public void NotifyRedDotRefresh()
	{
		if (this.ActivityDataInternal != null)
		{
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.ActivityDataInternal.Id);
		}
	}

	// Token: 0x06008E2E RID: 36398 RVA: 0x001EAC24 File Offset: 0x001E8E24
	public void SetForbidActivityStart(bool isForbid)
	{
		if (Info.Instance.IsBuildShipping)
		{
			return;
		}
		this.ActivityStartConditionMap[ENewPlayerSupportStartCondition.UnForbidStart] = !isForbid;
		LocalStorage.SetGlobal<bool>(ELocalStorageGlobalKey.NewPlayerSupportForbidStartView, isForbid);
		if (isForbid)
		{
			if (UiManager.Instance.IsViewOpen(EUiViewName.ActivityNewPlayerSupportStartupView))
			{
				UiManager.Instance.CloseView(EUiViewName.ActivityNewPlayerSupportStartupView, null);
				return;
			}
		}
		else
		{
			this.CheckIsStart(false);
		}
	}

	// Token: 0x17000BF0 RID: 3056
	// (get) Token: 0x06008E2F RID: 36399 RVA: 0x001EAC86 File Offset: 0x001E8E86
	public static ActivityNewPlayerSupportController Instance
	{
		get
		{
			return ActivityNewPlayerSupportController._Instance;
		}
	}

	// Token: 0x06008E30 RID: 36400 RVA: 0x001EAC8D File Offset: 0x001E8E8D
	public static ActivityNewPlayerSupportController GetOrCreateInstance()
	{
		if (ActivityNewPlayerSupportController._Instance == null)
		{
			ActivityNewPlayerSupportController.CreateInstance();
		}
		return ActivityNewPlayerSupportController._Instance;
	}

	// Token: 0x06008E31 RID: 36401 RVA: 0x001EACA1 File Offset: 0x001E8EA1
	public static bool CreateInstance()
	{
		if (ActivityNewPlayerSupportController._Instance != null)
		{
			return true;
		}
		ActivityNewPlayerSupportController._Instance = new ActivityNewPlayerSupportController();
		return true;
	}

	// Token: 0x06008E32 RID: 36402 RVA: 0x001EACB7 File Offset: 0x001E8EB7
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06008E33 RID: 36403 RVA: 0x001EACB9 File Offset: 0x001E8EB9
	public static void ResetStaticDefaultValue()
	{
		ActivityNewPlayerSupportController._Instance = null;
	}

	// Token: 0x06008E34 RID: 36404 RVA: 0x001EACC1 File Offset: 0x001E8EC1
	static ActivityNewPlayerSupportController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityNewPlayerSupportController.CreateStaticDefaultValue), new Action(ActivityNewPlayerSupportController.ResetStaticDefaultValue));
	}

	// Token: 0x04003EF4 RID: 16116
	[Nullable(2)]
	private ActivityNewPlayerSupportData ActivityDataInternal;

	// Token: 0x04003EF5 RID: 16117
	private readonly Dictionary<ENewPlayerSupportStartCondition, bool> ActivityStartConditionMap = new Dictionary<ENewPlayerSupportStartCondition, bool>();

	// Token: 0x04003EF6 RID: 16118
	[Nullable(2)]
	private static ActivityNewPlayerSupportController _Instance;
}
