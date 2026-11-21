using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Google.Protobuf;

// Token: 0x0200079B RID: 1947
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ActivityMoonChasingController : ActivityControllerBase
{
	// Token: 0x06005932 RID: 22834 RVA: 0x001D017C File Offset: 0x001CE37C
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

	// Token: 0x06005933 RID: 22835 RVA: 0x001D02A4 File Offset: 0x001CE4A4
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x06005934 RID: 22836 RVA: 0x001D02A6 File Offset: 0x001CE4A6
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_ActivityMoonChasingMain";
	}

	// Token: 0x06005935 RID: 22837 RVA: 0x001D02AD File Offset: 0x001CE4AD
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new ActivitySubViewMoonChasing();
	}

	// Token: 0x06005936 RID: 22838 RVA: 0x001D02B4 File Offset: 0x001CE4B4
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		if (!this.IsActivityOn)
		{
			this.InitMoonChasingData();
			this.IsActivityOn = true;
		}
		return new ActivityMoonChasingData();
	}

	// Token: 0x06005937 RID: 22839 RVA: 0x001D02D0 File Offset: 0x001CE4D0
	public override void OnShowActivityFirstUnlockView(ActivityBaseData data)
	{
		ActivityMoonChasingData activityMoonChasingData = data as ActivityMoonChasingData;
		if (activityMoonChasingData != null && activityMoonChasingData.ActivityFlowState == EMoonChasingActivityFlow.Activity)
		{
			UiManager.Instance.OpenView(EUiViewName.ActivityUnlockTipMoonChasingView, null, null);
		}
	}

	// Token: 0x06005938 RID: 22840 RVA: 0x001D02FC File Offset: 0x001CE4FC
	public void RefreshActivityRedDot()
	{
		foreach (ActivityBaseData activityBaseData in ActivityModel.Instance.GetCurrentActivitiesByType(17))
		{
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, activityBaseData.Id);
		}
	}

	// Token: 0x06005939 RID: 22841 RVA: 0x001D0364 File Offset: 0x001CE564
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(trackMoonActivityRewardResponse.ErrorCode, 24303, null, true, true);
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

	// Token: 0x0600593A RID: 22842 RVA: 0x001D03C0 File Offset: 0x001CE5C0
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

	// Token: 0x0600593B RID: 22843 RVA: 0x001D0424 File Offset: 0x001CE624
	private void InitMoonChasingData()
	{
		MoonChasingController.Instance.TrackMoonAllDataRequest();
	}

	// Token: 0x17000B98 RID: 2968
	// (get) Token: 0x0600593C RID: 22844 RVA: 0x001D0431 File Offset: 0x001CE631
	public static ActivityMoonChasingController Instance
	{
		get
		{
			return ActivityMoonChasingController._Instance;
		}
	}

	// Token: 0x0600593D RID: 22845 RVA: 0x001D0438 File Offset: 0x001CE638
	public static ActivityMoonChasingController GetOrCreateInstance()
	{
		if (ActivityMoonChasingController._Instance == null)
		{
			ActivityMoonChasingController.CreateInstance();
		}
		return ActivityMoonChasingController._Instance;
	}

	// Token: 0x0600593E RID: 22846 RVA: 0x001D044C File Offset: 0x001CE64C
	public static bool CreateInstance()
	{
		if (ActivityMoonChasingController._Instance != null)
		{
			return true;
		}
		ActivityMoonChasingController._Instance = new ActivityMoonChasingController();
		return true;
	}

	// Token: 0x0600593F RID: 22847 RVA: 0x001D0462 File Offset: 0x001CE662
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06005940 RID: 22848 RVA: 0x001D0464 File Offset: 0x001CE664
	public static void ResetStaticDefaultValue()
	{
		ActivityMoonChasingController._Instance = null;
	}

	// Token: 0x06005941 RID: 22849 RVA: 0x001D046C File Offset: 0x001CE66C
	static ActivityMoonChasingController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityMoonChasingController.CreateStaticDefaultValue), new Action(ActivityMoonChasingController.ResetStaticDefaultValue));
	}

	// Token: 0x04003C8D RID: 15501
	private bool IsActivityOn;

	// Token: 0x04003C8E RID: 15502
	[Nullable(2)]
	private static ActivityMoonChasingController _Instance;
}
