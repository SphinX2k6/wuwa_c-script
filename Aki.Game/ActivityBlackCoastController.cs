using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Google.Protobuf;

// Token: 0x0200065C RID: 1628
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ActivityBlackCoastController : ActivityControllerBase
{
	// Token: 0x06004B48 RID: 19272 RVA: 0x0019949E File Offset: 0x0019769E
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.BlackCoastThemeStageUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.StageUpdate));
	}

	// Token: 0x06004B49 RID: 19273 RVA: 0x001994BC File Offset: 0x001976BC
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.BlackCoastThemeStageUpdateNotify);
	}

	// Token: 0x06004B4A RID: 19274 RVA: 0x001994CE File Offset: 0x001976CE
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add<int, int>(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
	}

	// Token: 0x06004B4B RID: 19275 RVA: 0x001994EC File Offset: 0x001976EC
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
	}

	// Token: 0x06004B4C RID: 19276 RVA: 0x0019950C File Offset: 0x0019770C
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

	// Token: 0x06004B4D RID: 19277 RVA: 0x0019955E File Offset: 0x0019775E
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x06004B4E RID: 19278 RVA: 0x00199560 File Offset: 0x00197760
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_ActivityBlackCoast";
	}

	// Token: 0x06004B4F RID: 19279 RVA: 0x00199567 File Offset: 0x00197767
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new ActivitySubViewBlackCoast();
	}

	// Token: 0x06004B50 RID: 19280 RVA: 0x00199570 File Offset: 0x00197770
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

	// Token: 0x06004B51 RID: 19281 RVA: 0x001995EC File Offset: 0x001977EC
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		return new ActivityBlackCoastData();
	}

	// Token: 0x06004B52 RID: 19282 RVA: 0x001995F3 File Offset: 0x001977F3
	public override void OnShowActivityFirstUnlockView(ActivityBaseData data)
	{
		UiManager.Instance.OpenView(EUiViewName.ActivityUnlockTipBlackCoastView, null, null);
	}

	// Token: 0x06004B53 RID: 19283 RVA: 0x00199606 File Offset: 0x00197806
	private List<ActivityBaseData> GetActivityDataList()
	{
		return ActivityModel.Instance.GetCurrentActivitiesByType(25);
	}

	// Token: 0x06004B54 RID: 19284 RVA: 0x00199614 File Offset: 0x00197814
	[NullableContext(2)]
	private void StageUpdate(IMessage msg, Net.CallbackStatus status)
	{
		BlackCoastThemeStageUpdateNotify blackCoastThemeStageUpdateNotify = (BlackCoastThemeStageUpdateNotify)msg;
		foreach (ActivityBaseData activityBaseData in this.GetActivityDataList())
		{
			(activityBaseData as ActivityBlackCoastData).StageUpdate(blackCoastThemeStageUpdateNotify.Stages);
		}
	}

	// Token: 0x06004B55 RID: 19285 RVA: 0x00199678 File Offset: 0x00197878
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(blackCoastThemeActiveRewardResponse.Error, 28050, null, true, true);
				return;
			}
			foreach (ActivityBaseData activityBaseData in this.GetActivityDataList())
			{
				(activityBaseData as ActivityBlackCoastData).SetProgressRewardDataGot(blackCoastThemeActiveRewardResponse.ActiveRewardedIds);
			}
		}, 0);
	}

	// Token: 0x06004B56 RID: 19286 RVA: 0x001996BC File Offset: 0x001978BC
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(blackCoastThemeTaskRewardResponse.Error, 20483, null, true, true);
				return;
			}
			foreach (ActivityBaseData activityBaseData in this.GetActivityDataList())
			{
				(activityBaseData as ActivityBlackCoastData).SetTaskRewardGot(stageId, taskId);
			}
		}, 0);
	}

	// Token: 0x17000A62 RID: 2658
	// (get) Token: 0x06004B57 RID: 19287 RVA: 0x00199713 File Offset: 0x00197913
	public static ActivityBlackCoastController Instance
	{
		get
		{
			return ActivityBlackCoastController._Instance;
		}
	}

	// Token: 0x06004B58 RID: 19288 RVA: 0x0019971A File Offset: 0x0019791A
	public static ActivityBlackCoastController GetOrCreateInstance()
	{
		if (ActivityBlackCoastController._Instance == null)
		{
			ActivityBlackCoastController.CreateInstance();
		}
		return ActivityBlackCoastController._Instance;
	}

	// Token: 0x06004B59 RID: 19289 RVA: 0x0019972E File Offset: 0x0019792E
	public static bool CreateInstance()
	{
		if (ActivityBlackCoastController._Instance != null)
		{
			return true;
		}
		ActivityBlackCoastController._Instance = new ActivityBlackCoastController();
		return true;
	}

	// Token: 0x06004B5A RID: 19290 RVA: 0x00199744 File Offset: 0x00197944
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06004B5B RID: 19291 RVA: 0x00199746 File Offset: 0x00197946
	public static void ResetStaticDefaultValue()
	{
		ActivityBlackCoastController._Instance = null;
	}

	// Token: 0x06004B5C RID: 19292 RVA: 0x0019974E File Offset: 0x0019794E
	static ActivityBlackCoastController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityBlackCoastController.CreateStaticDefaultValue), new Action(ActivityBlackCoastController.ResetStaticDefaultValue));
	}

	// Token: 0x040037B9 RID: 14265
	[Nullable(2)]
	private static ActivityBlackCoastController _Instance;
}
