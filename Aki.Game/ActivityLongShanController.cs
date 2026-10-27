using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Ui;
using Google.Protobuf;

// Token: 0x0200129F RID: 4767
[NullableContext(1)]
[Nullable(0)]
public class ActivityLongShanController : ActivityControllerBase
{
	// Token: 0x06008299 RID: 33433 RVA: 0x001BB6FC File Offset: 0x001B98FC
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		foreach (ActivityLongShanData activityLongShanData in (from x in ActivityModel.Instance.GetActivitiesByType(13)
		select (ActivityLongShanData)x).ToList<ActivityLongShanData>())
		{
			if (!activityLongShanData.CheckIfInShowTime())
			{
				LongShanActivityConfig? config = ConfigLongShanActivityConfigByActivityId.GetConfig(activityLongShanData.Id, true);
				List<EUiViewName> list = new List<EUiViewName>();
				int? num = (config != null) ? new int?(config.GetValueOrDefault().Type) : null;
				if (num == null)
				{
					goto IL_115;
				}
				switch (num.GetValueOrDefault())
				{
				case 2:
					list = new List<EUiViewName>
					{
						EUiViewName.RoleGrowingMainView,
						EUiViewName.RoleGrowingTaskView
					};
					break;
				case 3:
					list = new List<EUiViewName>
					{
						EUiViewName.SevenHillsMainView,
						EUiViewName.SevenHillsStageTaskView
					};
					break;
				case 4:
					list = new List<EUiViewName>
					{
						EUiViewName.Theme26MainView,
						EUiViewName.Theme26StageTaskView
					};
					break;
				default:
					goto IL_115;
				}
				IL_131:
				foreach (EUiViewName viewName in list)
				{
					if (UiManager.Instance.IsViewOpen(viewName))
					{
						return true;
					}
				}
				continue;
				IL_115:
				list = new List<EUiViewName>
				{
					EUiViewName.Theme26MainView,
					EUiViewName.Theme26StageTaskView
				};
				goto IL_131;
			}
		}
		return false;
	}

	// Token: 0x0600829A RID: 33434 RVA: 0x001BB8D0 File Offset: 0x001B9AD0
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x0600829B RID: 33435 RVA: 0x001BB8D4 File Offset: 0x001B9AD4
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

	// Token: 0x0600829C RID: 33436 RVA: 0x001BB970 File Offset: 0x001B9B70
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

	// Token: 0x0600829D RID: 33437 RVA: 0x001BB9FC File Offset: 0x001B9BFC
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		return new ActivityLongShanData();
	}

	// Token: 0x0600829E RID: 33438 RVA: 0x001BBA04 File Offset: 0x001B9C04
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

	// Token: 0x0600829F RID: 33439 RVA: 0x001BBABA File Offset: 0x001B9CBA
	protected override bool OnInit()
	{
		return true;
	}

	// Token: 0x060082A0 RID: 33440 RVA: 0x001BBABD File Offset: 0x001B9CBD
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.LongShanStageUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnStageUpdate));
	}

	// Token: 0x060082A1 RID: 33441 RVA: 0x001BBADB File Offset: 0x001B9CDB
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.LongShanStageUpdateNotify);
	}

	// Token: 0x060082A2 RID: 33442 RVA: 0x001BBAED File Offset: 0x001B9CED
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add<int, int>(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
	}

	// Token: 0x060082A3 RID: 33443 RVA: 0x001BBB0B File Offset: 0x001B9D0B
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
	}

	// Token: 0x060082A4 RID: 33444 RVA: 0x001BBB29 File Offset: 0x001B9D29
	private List<ActivityLongShanData> GetActivityDataList()
	{
		return (from x in ActivityModel.Instance.GetCurrentActivitiesByType(13)
		select (ActivityLongShanData)x).ToList<ActivityLongShanData>();
	}

	// Token: 0x060082A5 RID: 33445 RVA: 0x001BBB60 File Offset: 0x001B9D60
	public LongShanUiConfig GetActivityUiConfig(int activityId)
	{
		return ConfigLongShanUiConfigById.GetConfig(ConfigLongShanActivityConfigByActivityId.GetConfig(activityId, true).Value.Type, true).Value;
	}

	// Token: 0x060082A6 RID: 33446 RVA: 0x001BBB94 File Offset: 0x001B9D94
	[NullableContext(2)]
	private void OnStageUpdate(IMessage msg, Net.CallbackStatus status)
	{
		LongShanStageUpdateNotify longShanStageUpdateNotify = (LongShanStageUpdateNotify)msg;
		foreach (ActivityLongShanData activityLongShanData in this.GetActivityDataList())
		{
			activityLongShanData.UpdateStage(longShanStageUpdateNotify.Stages.ToArray<LongShanStageInfo>());
		}
	}

	// Token: 0x060082A7 RID: 33447 RVA: 0x001BBBF8 File Offset: 0x001B9DF8
	public void ShowUnlockTip(int stageId)
	{
		string conditionGroupHintText = LevelGeneralCommons.GetConditionGroupHintText(ConfigLongShanStageById.GetConfig(stageId, true).Value.OpenConditionId);
		GenericPromptController.Instance.ShowPromptByItsType<object>(EPromptSubViewType.FloatLinePrompt, new TableTextArgNew(conditionGroupHintText, Array.Empty<object>()), null, null, null, null, null, null, null, false, null);
	}

	// Token: 0x060082A8 RID: 33448 RVA: 0x001BBC54 File Offset: 0x001B9E54
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

	// Token: 0x060082A9 RID: 33449 RVA: 0x001BBD08 File Offset: 0x001B9F08
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(longShanScoreRewardResponse.Error, 26718, null, true, true);
				return;
			}
			(ActivityModel.Instance.GetActivityById(activityId) as ActivityLongShanData).UpdateScoreRewardStatus(longShanScoreRewardResponse.ScoreRewardedIds.ToArray<int>());
		}, 0);
	}

	// Token: 0x060082AA RID: 33450 RVA: 0x001BBD60 File Offset: 0x001B9F60
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

	// Token: 0x17000B2F RID: 2863
	// (get) Token: 0x060082AB RID: 33451 RVA: 0x001BBDD8 File Offset: 0x001B9FD8
	public static ActivityLongShanController Instance
	{
		get
		{
			return ActivityLongShanController._Instance;
		}
	}

	// Token: 0x060082AC RID: 33452 RVA: 0x001BBDDF File Offset: 0x001B9FDF
	public static ActivityLongShanController GetOrCreateInstance()
	{
		if (ActivityLongShanController._Instance == null)
		{
			ActivityLongShanController.CreateInstance();
		}
		return ActivityLongShanController._Instance;
	}

	// Token: 0x060082AD RID: 33453 RVA: 0x001BBDF3 File Offset: 0x001B9FF3
	public static bool CreateInstance()
	{
		if (ActivityLongShanController._Instance != null)
		{
			return true;
		}
		ActivityLongShanController._Instance = new ActivityLongShanController();
		return true;
	}

	// Token: 0x060082AE RID: 33454 RVA: 0x001BBE09 File Offset: 0x001BA009
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060082AF RID: 33455 RVA: 0x001BBE0B File Offset: 0x001BA00B
	public static void ResetStaticDefaultValue()
	{
		ActivityLongShanController._Instance = null;
	}

	// Token: 0x060082B0 RID: 33456 RVA: 0x001BBE13 File Offset: 0x001BA013
	static ActivityLongShanController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityLongShanController.CreateStaticDefaultValue), new Action(ActivityLongShanController.ResetStaticDefaultValue));
	}

	// Token: 0x04003AEF RID: 15087
	[Nullable(2)]
	private static ActivityLongShanController _Instance;
}
