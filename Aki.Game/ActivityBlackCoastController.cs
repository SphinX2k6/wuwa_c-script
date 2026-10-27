using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Google.Protobuf;

// Token: 0x020011A8 RID: 4520
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ActivityBlackCoastController : ActivityControllerBase
{
	// Token: 0x060077B1 RID: 30641 RVA: 0x001908BA File Offset: 0x0018EABA
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.BlackCoastThemeStageUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.StageUpdate));
	}

	// Token: 0x060077B2 RID: 30642 RVA: 0x001908D8 File Offset: 0x0018EAD8
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.BlackCoastThemeStageUpdateNotify);
	}

	// Token: 0x060077B3 RID: 30643 RVA: 0x001908EA File Offset: 0x0018EAEA
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add<int, int>(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
	}

	// Token: 0x060077B4 RID: 30644 RVA: 0x00190908 File Offset: 0x0018EB08
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
	}

	// Token: 0x060077B5 RID: 30645 RVA: 0x00190928 File Offset: 0x0018EB28
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		foreach (EUiViewName viewName in new EUiViewName[]
		{
			EUiViewName.BlackCoastActivityMainView,
			EUiViewName.BlackCoastActivityTaskView
		})
		{
			if (UiManager.Instance.IsViewOpen(viewName))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060077B6 RID: 30646 RVA: 0x0019097A File Offset: 0x0018EB7A
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x060077B7 RID: 30647 RVA: 0x0019097C File Offset: 0x0018EB7C
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_ActivityBlackCoast";
	}

	// Token: 0x060077B8 RID: 30648 RVA: 0x00190983 File Offset: 0x0018EB83
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new ActivitySubViewBlackCoast();
	}

	// Token: 0x060077B9 RID: 30649 RVA: 0x0019098C File Offset: 0x0018EB8C
	private void OnCommonItemCountAnyChange(int configId, int count)
	{
		List<ActivityBaseData> activityDataList = this.GetActivityDataList();
		if (activityDataList.Count == 0)
		{
			return;
		}
		foreach (ActivityBaseData activityBaseData in activityDataList)
		{
			if ((activityBaseData as ActivityBlackCoastData).GetProgressItemId == configId)
			{
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, activityBaseData.Id);
			}
		}
	}

	// Token: 0x060077BA RID: 30650 RVA: 0x00190A08 File Offset: 0x0018EC08
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		return new ActivityBlackCoastData();
	}

	// Token: 0x060077BB RID: 30651 RVA: 0x00190A0F File Offset: 0x0018EC0F
	public override void OnShowActivityFirstUnlockView(ActivityBaseData data)
	{
		UiManager.Instance.OpenView(EUiViewName.ActivityUnlockTipBlackCoastView, null, null);
	}

	// Token: 0x060077BC RID: 30652 RVA: 0x00190A22 File Offset: 0x0018EC22
	private List<ActivityBaseData> GetActivityDataList()
	{
		return ActivityModel.Instance.GetCurrentActivitiesByType(25);
	}

	// Token: 0x060077BD RID: 30653 RVA: 0x00190A30 File Offset: 0x0018EC30
	[NullableContext(2)]
	private void StageUpdate(IMessage msg, Net.CallbackStatus status)
	{
		BlackCoastThemeStageUpdateNotify blackCoastThemeStageUpdateNotify = (BlackCoastThemeStageUpdateNotify)msg;
		foreach (ActivityBaseData activityBaseData in this.GetActivityDataList())
		{
			(activityBaseData as ActivityBlackCoastData).StageUpdate(blackCoastThemeStageUpdateNotify.Stages.ToArray<BlackCoastThemeStageInfo>());
		}
	}

	// Token: 0x060077BE RID: 30654 RVA: 0x00190A98 File Offset: 0x0018EC98
	public void RequestDataProgressReward(int activityId, int[] ids)
	{
		BlackCoastThemeActiveRewardRequest blackCoastThemeActiveRewardRequest = BlackCoastThemeActiveRewardRequest.Create();
		blackCoastThemeActiveRewardRequest.ActivityId = activityId;
		blackCoastThemeActiveRewardRequest.ActiveRewardIds.AddRange(ids);
		Net.Instance.Call(ERequestMessageId.BlackCoastThemeActiveRewardRequest, blackCoastThemeActiveRewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			BlackCoastThemeActiveRewardResponse blackCoastThemeActiveRewardResponse = (BlackCoastThemeActiveRewardResponse)msg;
			if (blackCoastThemeActiveRewardResponse == null)
			{
				return;
			}
			if (blackCoastThemeActiveRewardResponse.Error != ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(blackCoastThemeActiveRewardResponse.Error, 28700, null, true, true);
				return;
			}
			foreach (ActivityBaseData activityBaseData in this.GetActivityDataList())
			{
				(activityBaseData as ActivityBlackCoastData).SetProgressRewardDataGot(blackCoastThemeActiveRewardResponse.ActiveRewardedIds.ToArray<int>());
			}
		}, 0);
	}

	// Token: 0x060077BF RID: 30655 RVA: 0x00190ADC File Offset: 0x0018ECDC
	public void RequestTaskReward(int stageId, int taskId)
	{
		BlackCoastThemeTaskRewardRequest blackCoastThemeTaskRewardRequest = BlackCoastThemeTaskRewardRequest.Create();
		blackCoastThemeTaskRewardRequest.TaskId = taskId;
		Net.Instance.Call(ERequestMessageId.BlackCoastThemeTaskRewardRequest, blackCoastThemeTaskRewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			BlackCoastThemeTaskRewardResponse blackCoastThemeTaskRewardResponse = (BlackCoastThemeTaskRewardResponse)msg;
			if (blackCoastThemeTaskRewardResponse == null)
			{
				return;
			}
			if (blackCoastThemeTaskRewardResponse.Error != ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(blackCoastThemeTaskRewardResponse.Error, 28490, null, true, true);
				return;
			}
			foreach (ActivityBaseData activityBaseData in this.GetActivityDataList())
			{
				(activityBaseData as ActivityBlackCoastData).SetTaskRewardGot(stageId, taskId);
			}
		}, 0);
	}

	// Token: 0x17000A42 RID: 2626
	// (get) Token: 0x060077C0 RID: 30656 RVA: 0x00190B33 File Offset: 0x0018ED33
	public static ActivityBlackCoastController Instance
	{
		get
		{
			return ActivityBlackCoastController._Instance;
		}
	}

	// Token: 0x060077C1 RID: 30657 RVA: 0x00190B3A File Offset: 0x0018ED3A
	public static ActivityBlackCoastController GetOrCreateInstance()
	{
		if (ActivityBlackCoastController._Instance == null)
		{
			ActivityBlackCoastController.CreateInstance();
		}
		return ActivityBlackCoastController._Instance;
	}

	// Token: 0x060077C2 RID: 30658 RVA: 0x00190B4E File Offset: 0x0018ED4E
	public static bool CreateInstance()
	{
		if (ActivityBlackCoastController._Instance != null)
		{
			return true;
		}
		ActivityBlackCoastController._Instance = new ActivityBlackCoastController();
		return true;
	}

	// Token: 0x060077C3 RID: 30659 RVA: 0x00190B64 File Offset: 0x0018ED64
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060077C4 RID: 30660 RVA: 0x00190B66 File Offset: 0x0018ED66
	public static void ResetStaticDefaultValue()
	{
		ActivityBlackCoastController._Instance = null;
	}

	// Token: 0x060077C5 RID: 30661 RVA: 0x00190B6E File Offset: 0x0018ED6E
	static ActivityBlackCoastController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityBlackCoastController.CreateStaticDefaultValue), new Action(ActivityBlackCoastController.ResetStaticDefaultValue));
	}

	// Token: 0x04003720 RID: 14112
	[Nullable(2)]
	private static ActivityBlackCoastController _Instance;
}
