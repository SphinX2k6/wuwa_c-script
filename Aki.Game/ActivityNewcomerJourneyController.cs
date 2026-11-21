using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Google.Protobuf;

// Token: 0x02000853 RID: 2131
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ActivityNewcomerJourneyController : ActivityControllerBase
{
	// Token: 0x0600608B RID: 24715 RVA: 0x001ECC39 File Offset: 0x001EAE39
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
		EventSystem.Instance.Add<int, IReadOnlyList<int>>(EEventName.OnReceiveActivityData, new Action<int, IReadOnlyList<int>>(this.OnReceiveActivityData));
	}

	// Token: 0x0600608C RID: 24716 RVA: 0x001ECC73 File Offset: 0x001EAE73
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
		EventSystem.Instance.Remove<int, IReadOnlyList<int>>(EEventName.OnReceiveActivityData, new Action<int, IReadOnlyList<int>>(this.OnReceiveActivityData));
	}

	// Token: 0x0600608D RID: 24717 RVA: 0x001ECCAD File Offset: 0x001EAEAD
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.NewbieAdventureTaskUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnNewbieAdventureTaskUpdateNotify));
	}

	// Token: 0x0600608E RID: 24718 RVA: 0x001ECCCC File Offset: 0x001EAECC
	private void OnReceiveActivityData(int type, IReadOnlyList<int> activityIds)
	{
		if (!this.PendingSplashAfterActivitySync)
		{
			return;
		}
		if (type != 2)
		{
			return;
		}
		if (PublicUtil.Instance.GetIsSilentLogin())
		{
			this.PendingSplashAfterActivitySync = false;
			return;
		}
		ActivitySevenDaySignData activitySevenDaySignData = this.TryGetSignInActivityData();
		if (activitySevenDaySignData == null)
		{
			return;
		}
		this.TryPushNewcomerSplash(activitySevenDaySignData, false);
	}

	// Token: 0x0600608F RID: 24719 RVA: 0x001ECD10 File Offset: 0x001EAF10
	private void OnWorldDone()
	{
		if (PublicUtil.Instance.GetIsSilentLogin())
		{
			return;
		}
		ActivitySevenDaySignData activitySevenDaySignData = this.TryGetSignInActivityData();
		if (activitySevenDaySignData == null)
		{
			this.PendingSplashAfterActivitySync = true;
			return;
		}
		this.TryPushNewcomerSplash(activitySevenDaySignData, false);
	}

	// Token: 0x06006090 RID: 24720 RVA: 0x001ECD44 File Offset: 0x001EAF44
	[NullableContext(2)]
	public ActivitySevenDaySignData TryGetSignInActivityData()
	{
		int type = 2;
		List<ActivityBaseData> activitiesByType = ActivityModel.Instance.GetActivitiesByType(type);
		if (activitiesByType == null || activitiesByType.Count <= 0)
		{
			return null;
		}
		ActivitySevenDaySignData activitySevenDaySignData = null;
		foreach (ActivityBaseData activityBaseData in activitiesByType)
		{
			ActivitySevenDaySignData activitySevenDaySignData2 = activityBaseData as ActivitySevenDaySignData;
			if (activitySevenDaySignData2 != null)
			{
				ActivitySign? activitySignById = ActivitySevenDaySignConfig.Instance.GetActivitySignById(activitySevenDaySignData2.Id);
				if (activitySignById != null && activitySignById.Value.Type == 3)
				{
					activitySevenDaySignData = activitySevenDaySignData2;
					break;
				}
			}
		}
		if (activitySevenDaySignData == null)
		{
			return null;
		}
		if (!activitySevenDaySignData.CheckIfInOpenTime())
		{
			return null;
		}
		return activitySevenDaySignData;
	}

	// Token: 0x06006091 RID: 24721 RVA: 0x001ECDF8 File Offset: 0x001EAFF8
	private void TryPushNewcomerSplash(ActivitySevenDaySignData data, bool isInstantly = false)
	{
		int activityId = data.Id;
		if (this.HasShowedSplash(activityId))
		{
			return;
		}
		SplashScreenTask splashScreenTask = new SplashScreenTask(ESplashScreenSourceModuleType.NewcomerActivity, ESplashScreenType.Config, delegate()
		{
			UiManager.Instance.OpenView(EUiViewName.NewcomerSplashView, activityId, null);
			this.SaveShowSplash(activityId);
		});
		SplashScreenController.Instance.PushSplashScreenTask(splashScreenTask, isInstantly);
	}

	// Token: 0x06006092 RID: 24722 RVA: 0x001ECE4E File Offset: 0x001EB04E
	public bool HasShowedSplash(int activityId)
	{
		return ActivityModel.Instance.GetActivityCacheData(activityId, 0, 1, 0, 0) == 1;
	}

	// Token: 0x06006093 RID: 24723 RVA: 0x001ECE62 File Offset: 0x001EB062
	public void SaveShowSplash(int activityId)
	{
		if (!this.HasShowedSplash(activityId))
		{
			ActivityModel.Instance.SaveActivityData(activityId, 1, 0, 0, 1);
		}
	}

	// Token: 0x06006094 RID: 24724 RVA: 0x001ECE7C File Offset: 0x001EB07C
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.NewbieAdventureTaskUpdateNotify);
	}

	// Token: 0x06006095 RID: 24725 RVA: 0x001ECE8E File Offset: 0x001EB08E
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x06006096 RID: 24726 RVA: 0x001ECE90 File Offset: 0x001EB090
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_NewcomerExperienceMain";
	}

	// Token: 0x06006097 RID: 24727 RVA: 0x001ECE97 File Offset: 0x001EB097
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new ActivitySubViewNewcomerJourney();
	}

	// Token: 0x06006098 RID: 24728 RVA: 0x001ECE9E File Offset: 0x001EB09E
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		this.ActivityId = data.Id;
		return new ActivityNewcomerJourneyData();
	}

	// Token: 0x06006099 RID: 24729 RVA: 0x001ECEB1 File Offset: 0x001EB0B1
	public ActivityNewcomerJourneyData GetNewcomerJourneyData()
	{
		return ActivityModel.Instance.GetActivityById(this.ActivityId) as ActivityNewcomerJourneyData;
	}

	// Token: 0x0600609A RID: 24730 RVA: 0x001ECEC8 File Offset: 0x001EB0C8
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x0600609B RID: 24731 RVA: 0x001ECECC File Offset: 0x001EB0CC
	[NullableContext(2)]
	private void OnNewbieAdventureTaskUpdateNotify(IMessage msg, Net.CallbackStatus _)
	{
		NewbieAdventureTaskUpdateNotify newbieAdventureTaskUpdateNotify = (NewbieAdventureTaskUpdateNotify)msg;
		(ActivityModel.Instance.GetActivityById(newbieAdventureTaskUpdateNotify.ActivityId) as ActivityNewcomerJourneyData).UpdateChapterData(newbieAdventureTaskUpdateNotify.Chapter);
		EventSystem.Instance.Emit<int>(EEventName.ActivityViewRefreshCurrent, newbieAdventureTaskUpdateNotify.ActivityId);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, newbieAdventureTaskUpdateNotify.ActivityId);
	}

	// Token: 0x0600609C RID: 24732 RVA: 0x001ECF2C File Offset: 0x001EB12C
	public void GetTaskReward(int activityId, List<int> taskIds)
	{
		NewbieAdventureTaskRewardRequest newbieAdventureTaskRewardRequest = NewbieAdventureTaskRewardRequest.Create();
		newbieAdventureTaskRewardRequest.ActivityId = activityId;
		newbieAdventureTaskRewardRequest.TaskIds.AddRange(taskIds);
		Net.Instance.Call(ERequestMessageId.NewbieAdventureTaskRewardRequest, newbieAdventureTaskRewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			NewbieAdventureTaskRewardResponse newbieAdventureTaskRewardResponse = (NewbieAdventureTaskRewardResponse)msg;
			if (newbieAdventureTaskRewardResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(newbieAdventureTaskRewardResponse.ErrorCode, 15720, null, true, true);
			}
		}, 0);
	}

	// Token: 0x0600609D RID: 24733 RVA: 0x001ECF84 File Offset: 0x001EB184
	public void GetChapterReward(int activityId, int chapterId)
	{
		NewbieAdventureChapterDropRequest newbieAdventureChapterDropRequest = NewbieAdventureChapterDropRequest.Create();
		newbieAdventureChapterDropRequest.ActivityId = activityId;
		newbieAdventureChapterDropRequest.ChapterId = chapterId;
		Net.Instance.Call(ERequestMessageId.NewbieAdventureChapterDropRequest, newbieAdventureChapterDropRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			NewbieAdventureChapterDropResponse newbieAdventureChapterDropResponse = (NewbieAdventureChapterDropResponse)msg;
			if (newbieAdventureChapterDropResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(newbieAdventureChapterDropResponse.ErrorCode, 19337, null, true, true);
			}
		}, 0);
	}

	// Token: 0x0600609E RID: 24734 RVA: 0x001ECFD8 File Offset: 0x001EB1D8
	public void GetSelectRole(int activityId, int chapterId, int roleId)
	{
		NewbieAdventureRoleRewardRequest newbieAdventureRoleRewardRequest = NewbieAdventureRoleRewardRequest.Create();
		newbieAdventureRoleRewardRequest.ActivityId = activityId;
		newbieAdventureRoleRewardRequest.ChapterId = chapterId;
		newbieAdventureRoleRewardRequest.RoleId = roleId;
		Net.Instance.Call(ERequestMessageId.NewbieAdventureRoleRewardRequest, newbieAdventureRoleRewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			NewbieAdventureRoleRewardResponse newbieAdventureRoleRewardResponse = (NewbieAdventureRoleRewardResponse)msg;
			if (newbieAdventureRoleRewardResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(newbieAdventureRoleRewardResponse.ErrorCode, 17073, null, true, true);
			}
		}, 0);
	}

	// Token: 0x17000C04 RID: 3076
	// (get) Token: 0x0600609F RID: 24735 RVA: 0x001ED030 File Offset: 0x001EB230
	public static ActivityNewcomerJourneyController Instance
	{
		get
		{
			return ActivityNewcomerJourneyController._Instance;
		}
	}

	// Token: 0x060060A0 RID: 24736 RVA: 0x001ED037 File Offset: 0x001EB237
	public static ActivityNewcomerJourneyController GetOrCreateInstance()
	{
		if (ActivityNewcomerJourneyController._Instance == null)
		{
			ActivityNewcomerJourneyController.CreateInstance();
		}
		return ActivityNewcomerJourneyController._Instance;
	}

	// Token: 0x060060A1 RID: 24737 RVA: 0x001ED04B File Offset: 0x001EB24B
	public static bool CreateInstance()
	{
		if (ActivityNewcomerJourneyController._Instance != null)
		{
			return true;
		}
		ActivityNewcomerJourneyController._Instance = new ActivityNewcomerJourneyController();
		return true;
	}

	// Token: 0x060060A2 RID: 24738 RVA: 0x001ED061 File Offset: 0x001EB261
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060060A3 RID: 24739 RVA: 0x001ED063 File Offset: 0x001EB263
	public static void ResetStaticDefaultValue()
	{
		ActivityNewcomerJourneyController._Instance = null;
	}

	// Token: 0x060060A4 RID: 24740 RVA: 0x001ED06B File Offset: 0x001EB26B
	static ActivityNewcomerJourneyController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityNewcomerJourneyController.CreateStaticDefaultValue), new Action(ActivityNewcomerJourneyController.ResetStaticDefaultValue));
	}

	// Token: 0x04003F17 RID: 16151
	private const int NEWCOMER_SPLASH_CACHE_KEY = 1;

	// Token: 0x04003F18 RID: 16152
	private bool PendingSplashAfterActivitySync;

	// Token: 0x04003F19 RID: 16153
	private int ActivityId;

	// Token: 0x04003F1A RID: 16154
	[Nullable(2)]
	private static ActivityNewcomerJourneyController _Instance;
}
