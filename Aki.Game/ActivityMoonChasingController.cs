using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Google.Protobuf;

// Token: 0x020012E7 RID: 4839
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ActivityMoonChasingController : ActivityControllerBase
{
	// Token: 0x06008597 RID: 34199 RVA: 0x001C7310 File Offset: 0x001C5510
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		foreach (ActivityBaseData activityBaseData in ActivityModel.Instance.GetActivitiesByType(17))
		{
			ActivityMoonChasingData activityMoonChasingData = activityBaseData as ActivityMoonChasingData;
			EUiViewName[] array;
			if (activityMoonChasingData != null && activityMoonChasingData.ActivityFlowState == EMoonChasingActivityFlow.Activity)
			{
				array = new EUiViewName[]
				{
					EUiViewName.MoonChasingMainView,
					EUiViewName.RewardMainView,
					EUiViewName.MoonChasingHandbookView,
					EUiViewName.BusinessMainView,
					EUiViewName.BusinessHelperView,
					EUiViewName.MoonChasingTaskView
				};
			}
			else
			{
				array = new EUiViewName[]
				{
					EUiViewName.MoonChasingMemoryView,
					EUiViewName.MoonChasingMemoryDetailView,
					EUiViewName.RewardMainView,
					EUiViewName.MoonChasingHandbookView
				};
			}
			foreach (EUiViewName viewName in array)
			{
				if (UiManager.Instance.IsViewOpen(viewName))
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x06008598 RID: 34200 RVA: 0x001C7438 File Offset: 0x001C5638
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x06008599 RID: 34201 RVA: 0x001C743A File Offset: 0x001C563A
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_ActivityMoonChasingMain";
	}

	// Token: 0x0600859A RID: 34202 RVA: 0x001C7441 File Offset: 0x001C5641
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new ActivitySubViewMoonChasing();
	}

	// Token: 0x0600859B RID: 34203 RVA: 0x001C7448 File Offset: 0x001C5648
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		if (!this.IsActivityOn)
		{
			this.InitMoonChasingData();
			this.IsActivityOn = true;
		}
		return new ActivityMoonChasingData();
	}

	// Token: 0x0600859C RID: 34204 RVA: 0x001C7464 File Offset: 0x001C5664
	public override void OnShowActivityFirstUnlockView(ActivityBaseData data)
	{
		ActivityMoonChasingData activityMoonChasingData = data as ActivityMoonChasingData;
		if (activityMoonChasingData != null && activityMoonChasingData.ActivityFlowState == EMoonChasingActivityFlow.Activity)
		{
			UiManager.Instance.OpenView(EUiViewName.ActivityUnlockTipMoonChasingView, null, null);
		}
	}

	// Token: 0x0600859D RID: 34205 RVA: 0x001C7490 File Offset: 0x001C5690
	public void RefreshActivityRedDot()
	{
		foreach (ActivityBaseData activityBaseData in ActivityModel.Instance.GetCurrentActivitiesByType(17))
		{
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, activityBaseData.Id);
		}
	}

	// Token: 0x0600859E RID: 34206 RVA: 0x001C74F8 File Offset: 0x001C56F8
	public void TrackMoonActivityTargetRewardRequest(int activityId, int id)
	{
		TrackMoonActivityRewardRequest trackMoonActivityRewardRequest = TrackMoonActivityRewardRequest.Create();
		trackMoonActivityRewardRequest.Id = id;
		trackMoonActivityRewardRequest.ActivityId = activityId;
		Net.Instance.Call(ERequestMessageId.TrackMoonActivityRewardRequest, trackMoonActivityRewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			TrackMoonActivityRewardResponse trackMoonActivityRewardResponse = (TrackMoonActivityRewardResponse)msg;
			if (trackMoonActivityRewardResponse == null)
			{
				return;
			}
			if (trackMoonActivityRewardResponse.ErrorCode != ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(trackMoonActivityRewardResponse.ErrorCode, 18470, null, true, true);
				return;
			}
			ActivityMoonChasingData activityMoonChasingData = ActivityModel.Instance.GetActivityById(activityId) as ActivityMoonChasingData;
			if (activityMoonChasingData == null)
			{
				return;
			}
			activityMoonChasingData.SetRewardState(id, EActivityTaskState.FinishedAndClaimed);
		}, 0);
	}

	// Token: 0x0600859F RID: 34207 RVA: 0x001C7554 File Offset: 0x001C5754
	public void CheckIsActivityClose()
	{
		using (List<ActivityBaseData>.Enumerator enumerator = ActivityModel.Instance.GetActivitiesByType(17).GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.CheckIfClose())
				{
					ActivityController.Instance.ShowActivityRefreshAndBackToBattleView();
					break;
				}
			}
		}
	}

	// Token: 0x060085A0 RID: 34208 RVA: 0x001C75B8 File Offset: 0x001C57B8
	private void InitMoonChasingData()
	{
		MoonChasingController.Instance.TrackMoonAllDataRequest();
	}

	// Token: 0x17000B78 RID: 2936
	// (get) Token: 0x060085A1 RID: 34209 RVA: 0x001C75C5 File Offset: 0x001C57C5
	public static ActivityMoonChasingController Instance
	{
		get
		{
			return ActivityMoonChasingController._Instance;
		}
	}

	// Token: 0x060085A2 RID: 34210 RVA: 0x001C75CC File Offset: 0x001C57CC
	public static ActivityMoonChasingController GetOrCreateInstance()
	{
		if (ActivityMoonChasingController._Instance == null)
		{
			ActivityMoonChasingController.CreateInstance();
		}
		return ActivityMoonChasingController._Instance;
	}

	// Token: 0x060085A3 RID: 34211 RVA: 0x001C75E0 File Offset: 0x001C57E0
	public static bool CreateInstance()
	{
		if (ActivityMoonChasingController._Instance != null)
		{
			return true;
		}
		ActivityMoonChasingController._Instance = new ActivityMoonChasingController();
		return true;
	}

	// Token: 0x060085A4 RID: 34212 RVA: 0x001C75F6 File Offset: 0x001C57F6
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060085A5 RID: 34213 RVA: 0x001C75F8 File Offset: 0x001C57F8
	public static void ResetStaticDefaultValue()
	{
		ActivityMoonChasingController._Instance = null;
	}

	// Token: 0x060085A6 RID: 34214 RVA: 0x001C7600 File Offset: 0x001C5800
	static ActivityMoonChasingController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityMoonChasingController.CreateStaticDefaultValue), new Action(ActivityMoonChasingController.ResetStaticDefaultValue));
	}

	// Token: 0x04003BF5 RID: 15349
	private bool IsActivityOn;

	// Token: 0x04003BF6 RID: 15350
	[Nullable(2)]
	private static ActivityMoonChasingController _Instance;
}
