using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Google.Protobuf;

// Token: 0x02000B13 RID: 2835
[NullableContext(1)]
[Nullable(0)]
public class WuWuLogisticsActivityController : ActivityControllerBase
{
	// Token: 0x06007523 RID: 29987 RVA: 0x002433BE File Offset: 0x002415BE
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.WuWuTaskUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnWuWuTaskUpdateNotify));
		Net.Instance.Register(ENotifyMessageId.ThemeCeleWuWuTaskNotify, new Action<IMessage, Net.CallbackStatus>(this.OnThemeCeleWuWuTaskNotify));
	}

	// Token: 0x06007524 RID: 29988 RVA: 0x002433F8 File Offset: 0x002415F8
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.WuWuTaskUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.ThemeCeleWuWuTaskNotify);
	}

	// Token: 0x06007525 RID: 29989 RVA: 0x0024341A File Offset: 0x0024161A
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.CrossDay, new Action(this.OnUpdatePackData));
	}

	// Token: 0x06007526 RID: 29990 RVA: 0x00243438 File Offset: 0x00241638
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.CrossDay, new Action(this.OnUpdatePackData));
	}

	// Token: 0x06007527 RID: 29991 RVA: 0x00243456 File Offset: 0x00241656
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x06007528 RID: 29992 RVA: 0x00243458 File Offset: 0x00241658
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_WuwuLogisticsActivityMain";
	}

	// Token: 0x06007529 RID: 29993 RVA: 0x0024345F File Offset: 0x0024165F
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new WuWuLogisticsActivitySubView();
	}

	// Token: 0x0600752A RID: 29994 RVA: 0x00243466 File Offset: 0x00241666
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		this.ActivityId = data.Id;
		return new WuWuLogisticsActivityData();
	}

	// Token: 0x0600752B RID: 29995 RVA: 0x00243479 File Offset: 0x00241679
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x0600752C RID: 29996 RVA: 0x0024347C File Offset: 0x0024167C
	[NullableContext(2)]
	public WuWuLogisticsActivityData GetActivityData()
	{
		return ActivityModel.Instance.GetActivityById(this.ActivityId) as WuWuLogisticsActivityData;
	}

	// Token: 0x0600752D RID: 29997 RVA: 0x00243494 File Offset: 0x00241694
	[NullableContext(2)]
	private void OnWuWuTaskUpdateNotify(IMessage msg, Net.CallbackStatus status)
	{
		WuWuTaskUpdateNotify wuWuTaskUpdateNotify = (WuWuTaskUpdateNotify)msg;
		if (wuWuTaskUpdateNotify == null || wuWuTaskUpdateNotify.Task == null)
		{
			return;
		}
		WuWuLogisticsActivityData activityData = this.GetActivityData();
		if (activityData == null)
		{
			return;
		}
		activityData.UpdateTaskData(wuWuTaskUpdateNotify.Task, 0);
		EventSystem.Instance.Emit(EEventName.WuWuLogisticsTaskUpdate);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.ActivityId);
	}

	// Token: 0x0600752E RID: 29998 RVA: 0x002434F4 File Offset: 0x002416F4
	[NullableContext(2)]
	private void OnThemeCeleWuWuTaskNotify(IMessage msg, Net.CallbackStatus status)
	{
		ThemeCeleWuWuTaskNotify themeCeleWuWuTaskNotify = (ThemeCeleWuWuTaskNotify)msg;
		if (themeCeleWuWuTaskNotify == null || themeCeleWuWuTaskNotify.Task == null)
		{
			return;
		}
		WuWuLogisticsActivityData activityData = this.GetActivityData();
		if (activityData == null)
		{
			return;
		}
		activityData.UpdateTaskData(themeCeleWuWuTaskNotify.Task, 0);
		EventSystem.Instance.Emit(EEventName.WuWuLogisticsTaskUpdate);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.ActivityId);
	}

	// Token: 0x0600752F RID: 29999 RVA: 0x00243554 File Offset: 0x00241754
	private void OnUpdatePackData()
	{
		WuWuLogisticsActivityData activityData = this.GetActivityData();
		if (activityData == null)
		{
			return;
		}
		if (activityData.HasFirstUnlockPack())
		{
			if (UiManager.Instance.IsViewOpen(EUiViewName.WuWuLogisticsMissionView))
			{
				activityData.SetFirstOpenFalse();
				return;
			}
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.ActivityId);
		}
	}

	// Token: 0x06007530 RID: 30000 RVA: 0x002435A4 File Offset: 0x002417A4
	public void RequestTaskReward(List<int> taskIds)
	{
		WuWuTaskRewardRequest wuWuTaskRewardRequest = new WuWuTaskRewardRequest();
		foreach (int item in taskIds)
		{
			wuWuTaskRewardRequest.Ids.Add(item);
		}
		Net.Instance.Call(ERequestMessageId.WuWuTaskRewardRequest, wuWuTaskRewardRequest, delegate(IMessage msg, Net.CallbackStatus status)
		{
			WuWuTaskRewardResponse wuWuTaskRewardResponse = (WuWuTaskRewardResponse)msg;
			if (wuWuTaskRewardResponse == null)
			{
				return;
			}
			if (wuWuTaskRewardResponse.ErrorCode != ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(wuWuTaskRewardResponse.ErrorCode, 20425, null, true, true);
				return;
			}
			WuWuLogisticsActivityData activityData = this.GetActivityData();
			if (activityData != null)
			{
				foreach (int taskId in taskIds)
				{
					WuWuTaskData taskById = activityData.GetTaskById(taskId);
					if (taskById != null)
					{
						taskById.State = EWuWuTaskState.Taken;
					}
				}
				EventSystem.Instance.Emit(EEventName.WuWuLogisticsTaskUpdate);
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.ActivityId);
				EventSystem.Instance.Emit<int>(EEventName.ActivityViewRefreshCurrent, this.ActivityId);
			}
		}, 0);
	}

	// Token: 0x06007531 RID: 30001 RVA: 0x00243634 File Offset: 0x00241834
	public void RequestTaskPackageReward(int wrapId)
	{
		WuWuPackageRewardRequest wuWuPackageRewardRequest = new WuWuPackageRewardRequest();
		wuWuPackageRewardRequest.WrapId = wrapId;
		Net.Instance.Call(ERequestMessageId.WuWuPackageRewardRequest, wuWuPackageRewardRequest, delegate(IMessage msg, Net.CallbackStatus status)
		{
			WuWuPackageRewardResponse wuWuPackageRewardResponse = (WuWuPackageRewardResponse)msg;
			if (wuWuPackageRewardResponse == null)
			{
				return;
			}
			if (wuWuPackageRewardResponse.ErrorCode != ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(wuWuPackageRewardResponse.ErrorCode, 17971, null, true, true);
				return;
			}
			WuWuLogisticsActivityData wuWuLogisticsActivityData = ActivityModel.Instance.GetActivityById(this.ActivityId) as WuWuLogisticsActivityData;
			if (wuWuLogisticsActivityData != null)
			{
				WuWuTaskPackData taskPackById = wuWuLogisticsActivityData.GetTaskPackById(wrapId);
				if (taskPackById != null)
				{
					taskPackById.HadReward = true;
				}
				EventSystem.Instance.Emit(EEventName.WuWuLogisticsTaskUpdate);
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.ActivityId);
				EventSystem.Instance.Emit<int>(EEventName.ActivityViewRefreshCurrent, this.ActivityId);
			}
		}, 0);
	}

	// Token: 0x17000DBA RID: 3514
	// (get) Token: 0x06007532 RID: 30002 RVA: 0x00243684 File Offset: 0x00241884
	public static WuWuLogisticsActivityController Instance
	{
		get
		{
			return WuWuLogisticsActivityController._Instance;
		}
	}

	// Token: 0x06007533 RID: 30003 RVA: 0x0024368B File Offset: 0x0024188B
	public static WuWuLogisticsActivityController GetOrCreateInstance()
	{
		if (WuWuLogisticsActivityController._Instance == null)
		{
			WuWuLogisticsActivityController.CreateInstance();
		}
		return WuWuLogisticsActivityController._Instance;
	}

	// Token: 0x06007534 RID: 30004 RVA: 0x0024369F File Offset: 0x0024189F
	public static bool CreateInstance()
	{
		if (WuWuLogisticsActivityController._Instance != null)
		{
			return true;
		}
		WuWuLogisticsActivityController._Instance = new WuWuLogisticsActivityController();
		return true;
	}

	// Token: 0x06007535 RID: 30005 RVA: 0x002436B5 File Offset: 0x002418B5
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06007536 RID: 30006 RVA: 0x002436B7 File Offset: 0x002418B7
	public static void ResetStaticDefaultValue()
	{
		WuWuLogisticsActivityController._Instance = null;
	}

	// Token: 0x06007537 RID: 30007 RVA: 0x002436BF File Offset: 0x002418BF
	static WuWuLogisticsActivityController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(WuWuLogisticsActivityController.CreateStaticDefaultValue), new Action(WuWuLogisticsActivityController.ResetStaticDefaultValue));
	}

	// Token: 0x04004A03 RID: 18947
	public int ActivityId;

	// Token: 0x04004A04 RID: 18948
	[Nullable(2)]
	private static WuWuLogisticsActivityController _Instance;
}
