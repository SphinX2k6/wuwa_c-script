using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Google.Protobuf;

// Token: 0x0200165B RID: 5723
[NullableContext(1)]
[Nullable(0)]
public class WuWuLogisticsActivityController : ActivityControllerBase
{
	// Token: 0x0600A145 RID: 41285 RVA: 0x00239522 File Offset: 0x00237722
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.WuWuTaskUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnWuWuTaskUpdateNotify));
		Net.Instance.Register(ENotifyMessageId.ThemeCeleWuWuTaskNotify, new Action<IMessage, Net.CallbackStatus>(this.OnThemeCeleWuWuTaskNotify));
	}

	// Token: 0x0600A146 RID: 41286 RVA: 0x0023955C File Offset: 0x0023775C
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.WuWuTaskUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.ThemeCeleWuWuTaskNotify);
	}

	// Token: 0x0600A147 RID: 41287 RVA: 0x0023957E File Offset: 0x0023777E
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.CrossDay, new Action(this.OnUpdatePackData));
	}

	// Token: 0x0600A148 RID: 41288 RVA: 0x0023959C File Offset: 0x0023779C
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.CrossDay, new Action(this.OnUpdatePackData));
	}

	// Token: 0x0600A149 RID: 41289 RVA: 0x002395BA File Offset: 0x002377BA
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x0600A14A RID: 41290 RVA: 0x002395BC File Offset: 0x002377BC
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_WuwuLogisticsActivityMain";
	}

	// Token: 0x0600A14B RID: 41291 RVA: 0x002395C3 File Offset: 0x002377C3
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new WuWuLogisticsActivitySubView();
	}

	// Token: 0x0600A14C RID: 41292 RVA: 0x002395CA File Offset: 0x002377CA
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		this.ActivityId = data.Id;
		return new WuWuLogisticsActivityData();
	}

	// Token: 0x0600A14D RID: 41293 RVA: 0x002395DD File Offset: 0x002377DD
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x0600A14E RID: 41294 RVA: 0x002395E0 File Offset: 0x002377E0
	[NullableContext(2)]
	public WuWuLogisticsActivityData GetActivityData()
	{
		return ActivityModel.Instance.GetActivityById(this.ActivityId) as WuWuLogisticsActivityData;
	}

	// Token: 0x0600A14F RID: 41295 RVA: 0x002395F8 File Offset: 0x002377F8
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

	// Token: 0x0600A150 RID: 41296 RVA: 0x00239658 File Offset: 0x00237858
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

	// Token: 0x0600A151 RID: 41297 RVA: 0x002396B8 File Offset: 0x002378B8
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

	// Token: 0x0600A152 RID: 41298 RVA: 0x00239708 File Offset: 0x00237908
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(wuWuTaskRewardResponse.ErrorCode, 29886, null, true, true);
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

	// Token: 0x0600A153 RID: 41299 RVA: 0x00239798 File Offset: 0x00237998
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(wuWuPackageRewardResponse.ErrorCode, 20803, null, true, true);
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

	// Token: 0x17000D99 RID: 3481
	// (get) Token: 0x0600A154 RID: 41300 RVA: 0x002397E8 File Offset: 0x002379E8
	public static WuWuLogisticsActivityController Instance
	{
		get
		{
			return WuWuLogisticsActivityController._Instance;
		}
	}

	// Token: 0x0600A155 RID: 41301 RVA: 0x002397EF File Offset: 0x002379EF
	public static WuWuLogisticsActivityController GetOrCreateInstance()
	{
		if (WuWuLogisticsActivityController._Instance == null)
		{
			WuWuLogisticsActivityController.CreateInstance();
		}
		return WuWuLogisticsActivityController._Instance;
	}

	// Token: 0x0600A156 RID: 41302 RVA: 0x00239803 File Offset: 0x00237A03
	public static bool CreateInstance()
	{
		if (WuWuLogisticsActivityController._Instance != null)
		{
			return true;
		}
		WuWuLogisticsActivityController._Instance = new WuWuLogisticsActivityController();
		return true;
	}

	// Token: 0x0600A157 RID: 41303 RVA: 0x00239819 File Offset: 0x00237A19
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600A158 RID: 41304 RVA: 0x0023981B File Offset: 0x00237A1B
	public static void ResetStaticDefaultValue()
	{
		WuWuLogisticsActivityController._Instance = null;
	}

	// Token: 0x0600A159 RID: 41305 RVA: 0x00239823 File Offset: 0x00237A23
	static WuWuLogisticsActivityController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(WuWuLogisticsActivityController.CreateStaticDefaultValue), new Action(WuWuLogisticsActivityController.ResetStaticDefaultValue));
	}

	// Token: 0x0400495D RID: 18781
	public int ActivityId;

	// Token: 0x0400495E RID: 18782
	[Nullable(2)]
	private static WuWuLogisticsActivityController _Instance;
}
