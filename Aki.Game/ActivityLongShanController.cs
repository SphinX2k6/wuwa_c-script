using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Ui;
using Google.Protobuf;

// Token: 0x02000753 RID: 1875
[NullableContext(1)]
[Nullable(0)]
public class ActivityLongShanController : ActivityControllerBase
{
	// Token: 0x06005630 RID: 22064 RVA: 0x001C43C8 File Offset: 0x001C25C8
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		List<ActivityBaseData> activitiesByType = ActivityModel.Instance.GetActivitiesByType(13);
		List<ActivityLongShanData> list = new List<ActivityLongShanData>();
		foreach (ActivityBaseData activityBaseData in activitiesByType)
		{
			list.Add((ActivityLongShanData)activityBaseData);
		}
		foreach (ActivityLongShanData activityLongShanData in list)
		{
			if (!activityLongShanData.CheckIfInShowTime())
			{
				LongShanActivityConfig? config = ConfigLongShanActivityConfigByActivityId.GetConfig(activityLongShanData.Id, true);
				List<EUiViewName> list2 = new List<EUiViewName>();
				int? num = (config != null) ? new int?(config.GetValueOrDefault().Type) : null;
				if (num == null)
				{
					goto IL_130;
				}
				switch (num.GetValueOrDefault())
				{
				case 2:
					list2 = new List<EUiViewName>
					{
						EUiViewName.RoleGrowingMainView,
						EUiViewName.RoleGrowingTaskView
					};
					break;
				case 3:
					list2 = new List<EUiViewName>
					{
						EUiViewName.SevenHillsMainView,
						EUiViewName.SevenHillsStageTaskView
					};
					break;
				case 4:
					list2 = new List<EUiViewName>
					{
						EUiViewName.Theme26MainView,
						EUiViewName.Theme26StageTaskView
					};
					break;
				default:
					goto IL_130;
				}
				IL_14D:
				foreach (EUiViewName viewName in list2)
				{
					if (UiManager.Instance.IsViewOpen(viewName))
					{
						return true;
					}
				}
				continue;
				IL_130:
				list2 = new List<EUiViewName>
				{
					EUiViewName.Theme26MainView,
					EUiViewName.Theme26StageTaskView
				};
				goto IL_14D;
			}
		}
		return false;
	}

	// Token: 0x06005631 RID: 22065 RVA: 0x001C45D0 File Offset: 0x001C27D0
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x06005632 RID: 22066 RVA: 0x001C45D4 File Offset: 0x001C27D4
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		LongShanActivityConfig? config = ConfigLongShanActivityConfigByActivityId.GetConfig(data.Id, true);
		int? num = (config != null) ? new int?(config.GetValueOrDefault().Type) : null;
		if (num != null)
		{
			switch (num.GetValueOrDefault())
			{
			case 1:
				return "UiItem_LongshanMain";
			case 2:
				return "UiItem_ActivityRoleGrowing";
			case 3:
				return "UiItem_QiQiuGuide";
			case 4:
				return "UiItem_ActivityThemeGuide26";
			}
		}
		return this.GetActivityUiConfig(data.Id).SubViewId;
	}

	// Token: 0x06005633 RID: 22067 RVA: 0x001C4670 File Offset: 0x001C2870
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		LongShanActivityConfig? config = ConfigLongShanActivityConfigByActivityId.GetConfig(data.Id, true);
		int? num = (config != null) ? new int?(config.GetValueOrDefault().Type) : null;
		if (num != null)
		{
			switch (num.GetValueOrDefault())
			{
			case 1:
				return new ActivitySubViewLongShan();
			case 2:
				return new ActivitySubViewRoleGrowing();
			case 3:
				return new ActivitySubViewSevenHills();
			case 4:
				return new ActivitySubViewTheme26();
			}
		}
		return new ActivitySubViewTheme26();
	}

	// Token: 0x06005634 RID: 22068 RVA: 0x001C46FC File Offset: 0x001C28FC
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		return new ActivityLongShanData();
	}

	// Token: 0x06005635 RID: 22069 RVA: 0x001C4704 File Offset: 0x001C2904
	public override void OnShowActivityFirstUnlockView(ActivityBaseData data)
	{
		LongShanActivityConfig? config = ConfigLongShanActivityConfigByActivityId.GetConfig(data.Id, true);
		int? num = (config != null) ? new int?(config.GetValueOrDefault().Type) : null;
		if (num != null)
		{
			switch (num.GetValueOrDefault())
			{
			case 1:
				UiManager.Instance.OpenView(EUiViewName.LongShanUnlockView, null, null);
				return;
			case 3:
				UiManager.Instance.OpenView(EUiViewName.ActivityUnlockTipSevenHillsView, null, null);
				return;
			case 4:
				UiManager.Instance.OpenView(EUiViewName.Theme26UnlockTipView, data, null);
				return;
			}
		}
		UiManager.Instance.OpenView(EUiViewName.Theme26UnlockTipView, data, null);
	}

	// Token: 0x06005636 RID: 22070 RVA: 0x001C47BA File Offset: 0x001C29BA
	protected override bool OnInit()
	{
		return true;
	}

	// Token: 0x06005637 RID: 22071 RVA: 0x001C47BD File Offset: 0x001C29BD
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.LongShanStageUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnStageUpdate));
	}

	// Token: 0x06005638 RID: 22072 RVA: 0x001C47DB File Offset: 0x001C29DB
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.LongShanStageUpdateNotify);
	}

	// Token: 0x06005639 RID: 22073 RVA: 0x001C47ED File Offset: 0x001C29ED
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add<int, int>(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
	}

	// Token: 0x0600563A RID: 22074 RVA: 0x001C480B File Offset: 0x001C2A0B
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
	}

	// Token: 0x0600563B RID: 22075 RVA: 0x001C482C File Offset: 0x001C2A2C
	private List<ActivityLongShanData> GetActivityDataList()
	{
		List<ActivityBaseData> currentActivitiesByType = ActivityModel.Instance.GetCurrentActivitiesByType(13);
		List<ActivityLongShanData> list = new List<ActivityLongShanData>();
		foreach (ActivityBaseData activityBaseData in currentActivitiesByType)
		{
			list.Add((ActivityLongShanData)activityBaseData);
		}
		return list;
	}

	// Token: 0x0600563C RID: 22076 RVA: 0x001C4894 File Offset: 0x001C2A94
	public LongShanUiConfig GetActivityUiConfig(int activityId)
	{
		return ConfigLongShanUiConfigById.GetConfig(ConfigLongShanActivityConfigByActivityId.GetConfig(activityId, true).Value.Type, true).Value;
	}

	// Token: 0x0600563D RID: 22077 RVA: 0x001C48C8 File Offset: 0x001C2AC8
	[NullableContext(2)]
	private void OnStageUpdate(IMessage msg, Net.CallbackStatus status)
	{
		LongShanStageUpdateNotify longShanStageUpdateNotify = (LongShanStageUpdateNotify)msg;
		foreach (ActivityLongShanData activityLongShanData in this.GetActivityDataList())
		{
			activityLongShanData.UpdateStage(longShanStageUpdateNotify.Stages);
		}
	}

	// Token: 0x0600563E RID: 22078 RVA: 0x001C4928 File Offset: 0x001C2B28
	public void ShowUnlockTip(int stageId)
	{
		string conditionGroupHintText = LevelGeneralCommons.GetConditionGroupHintText(ConfigLongShanStageById.GetConfig(stageId, true).Value.OpenConditionId);
		GenericPromptController.Instance.ShowPromptByItsType<object>(EPromptSubViewType.FloatLinePrompt, new TableTextArgNew(conditionGroupHintText, Array.Empty<object>()), null, null, null, null, null, null, null, false, null);
	}

	// Token: 0x0600563F RID: 22079 RVA: 0x001C4984 File Offset: 0x001C2B84
	public void TakeTaskReward(int taskId)
	{
		int stageId = ConfigLongShanTaskById.GetConfig(taskId, true).Value.StageId;
		List<ActivityLongShanData> activityDataList = this.GetActivityDataList();
		List<int> list = new List<int>();
		for (int i = 0; i < activityDataList.Count; i++)
		{
			List<int> finishedAndUnclaimedTasksByStageId = activityDataList[i].GetFinishedAndUnclaimedTasksByStageId(stageId);
			if (finishedAndUnclaimedTasksByStageId.Count > 0)
			{
				list.AddRange(finishedAndUnclaimedTasksByStageId);
				break;
			}
		}
		Action<IMessage, Net.CallbackStatus> handle = delegate(IMessage msg, Net.CallbackStatus _)
		{
			LongShanTaskRewardResponse longShanTaskRewardResponse = (LongShanTaskRewardResponse)msg;
			if (longShanTaskRewardResponse == null)
			{
				return;
			}
			if (longShanTaskRewardResponse.Error != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(longShanTaskRewardResponse.Error, EResponseMessageId.LongShanTaskRewardResponse, null, true, true);
			}
		};
		LongShanTaskRewardRequest longShanTaskRewardRequest = LongShanTaskRewardRequest.Create();
		longShanTaskRewardRequest.TaskIds.AddRange(list);
		Net.Instance.Call(ERequestMessageId.LongShanTaskRewardRequest, longShanTaskRewardRequest, handle, 0);
	}

	// Token: 0x06005640 RID: 22080 RVA: 0x001C4A38 File Offset: 0x001C2C38
	public void RequestScoreReward(int activityId, List<int> rewardIds)
	{
		LongShanScoreRewardRequest longShanScoreRewardRequest = LongShanScoreRewardRequest.Create();
		longShanScoreRewardRequest.ActivityId = activityId;
		longShanScoreRewardRequest.Ids.AddRange(rewardIds);
		Net.Instance.Call(ERequestMessageId.LongShanScoreRewardRequest, longShanScoreRewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			LongShanScoreRewardResponse longShanScoreRewardResponse = (LongShanScoreRewardResponse)msg;
			if (longShanScoreRewardResponse == null)
			{
				return;
			}
			if (longShanScoreRewardResponse.Error != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(longShanScoreRewardResponse.Error, 29191, null, true, true);
				return;
			}
			(ActivityModel.Instance.GetActivityById(activityId) as ActivityLongShanData).UpdateScoreRewardStatus(longShanScoreRewardResponse.ScoreRewardedIds);
		}, 0);
	}

	// Token: 0x06005641 RID: 22081 RVA: 0x001C4A90 File Offset: 0x001C2C90
	private void OnCommonItemCountAnyChange(int configId, int count)
	{
		List<ActivityLongShanData> activityDataList = this.GetActivityDataList();
		if (activityDataList.Count == 0)
		{
			return;
		}
		foreach (ActivityLongShanData activityLongShanData in activityDataList)
		{
			if (activityLongShanData.ScoreItemId == configId)
			{
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, activityLongShanData.Id);
			}
		}
	}

	// Token: 0x17000B4F RID: 2895
	// (get) Token: 0x06005642 RID: 22082 RVA: 0x001C4B08 File Offset: 0x001C2D08
	public static ActivityLongShanController Instance
	{
		get
		{
			return ActivityLongShanController._Instance;
		}
	}

	// Token: 0x06005643 RID: 22083 RVA: 0x001C4B0F File Offset: 0x001C2D0F
	public static ActivityLongShanController GetOrCreateInstance()
	{
		if (ActivityLongShanController._Instance == null)
		{
			ActivityLongShanController.CreateInstance();
		}
		return ActivityLongShanController._Instance;
	}

	// Token: 0x06005644 RID: 22084 RVA: 0x001C4B23 File Offset: 0x001C2D23
	public static bool CreateInstance()
	{
		if (ActivityLongShanController._Instance != null)
		{
			return true;
		}
		ActivityLongShanController._Instance = new ActivityLongShanController();
		return true;
	}

	// Token: 0x06005645 RID: 22085 RVA: 0x001C4B39 File Offset: 0x001C2D39
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06005646 RID: 22086 RVA: 0x001C4B3B File Offset: 0x001C2D3B
	public static void ResetStaticDefaultValue()
	{
		ActivityLongShanController._Instance = null;
	}

	// Token: 0x06005647 RID: 22087 RVA: 0x001C4B43 File Offset: 0x001C2D43
	static ActivityLongShanController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityLongShanController.CreateStaticDefaultValue), new Action(ActivityLongShanController.ResetStaticDefaultValue));
	}

	// Token: 0x04003B87 RID: 15239
	[Nullable(2)]
	private static ActivityLongShanController _Instance;
}
