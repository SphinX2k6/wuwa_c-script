using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Google.Protobuf;

// Token: 0x0200139F RID: 5023
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ActivityNewcomerJourneyController : ActivityControllerBase
{
	// Token: 0x06008CF5 RID: 36085 RVA: 0x001E4015 File Offset: 0x001E2215
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
		EventSystem.Instance.Add<int, IReadOnlyList<int>>(EEventName.OnReceiveActivityData, new Action<int, IReadOnlyList<int>>(this.OnReceiveActivityData));
	}

	// Token: 0x06008CF6 RID: 36086 RVA: 0x001E404F File Offset: 0x001E224F
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
		EventSystem.Instance.Remove<int, IReadOnlyList<int>>(EEventName.OnReceiveActivityData, new Action<int, IReadOnlyList<int>>(this.OnReceiveActivityData));
	}

	// Token: 0x06008CF7 RID: 36087 RVA: 0x001E4089 File Offset: 0x001E2289
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.NewbieAdventureTaskUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnNewbieAdventureTaskUpdateNotify));
	}

	// Token: 0x06008CF8 RID: 36088 RVA: 0x001E40A8 File Offset: 0x001E22A8
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

	// Token: 0x06008CF9 RID: 36089 RVA: 0x001E40EC File Offset: 0x001E22EC
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

	// Token: 0x06008CFA RID: 36090 RVA: 0x001E4120 File Offset: 0x001E2320
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

	// Token: 0x06008CFB RID: 36091 RVA: 0x001E41D4 File Offset: 0x001E23D4
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

	// Token: 0x06008CFC RID: 36092 RVA: 0x001E422A File Offset: 0x001E242A
	public bool HasShowedSplash(int activityId)
	{
		return ActivityModel.Instance.GetActivityCacheData(activityId, 0, 1, 0, 0) == 1;
	}

	// Token: 0x06008CFD RID: 36093 RVA: 0x001E423E File Offset: 0x001E243E
	public void SaveShowSplash(int activityId)
	{
		if (!this.HasShowedSplash(activityId))
		{
			ActivityModel.Instance.SaveActivityData(activityId, 1, 0, 0, 1);
		}
	}

	// Token: 0x06008CFE RID: 36094 RVA: 0x001E4258 File Offset: 0x001E2458
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.NewbieAdventureTaskUpdateNotify);
	}

	// Token: 0x06008CFF RID: 36095 RVA: 0x001E426A File Offset: 0x001E246A
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x06008D00 RID: 36096 RVA: 0x001E426C File Offset: 0x001E246C
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_NewcomerExperienceMain";
	}

	// Token: 0x06008D01 RID: 36097 RVA: 0x001E4273 File Offset: 0x001E2473
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new ActivitySubViewNewcomerJourney();
	}

	// Token: 0x06008D02 RID: 36098 RVA: 0x001E427A File Offset: 0x001E247A
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		this.ActivityId = data.Id;
		return new ActivityNewcomerJourneyData();
	}

	// Token: 0x06008D03 RID: 36099 RVA: 0x001E428D File Offset: 0x001E248D
	public ActivityNewcomerJourneyData GetNewcomerJourneyData()
	{
		return ActivityModel.Instance.GetActivityById(this.ActivityId) as ActivityNewcomerJourneyData;
	}

	// Token: 0x06008D04 RID: 36100 RVA: 0x001E42A4 File Offset: 0x001E24A4
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x06008D05 RID: 36101 RVA: 0x001E42A8 File Offset: 0x001E24A8
	[NullableContext(2)]
	private void OnNewbieAdventureTaskUpdateNotify(IMessage msg, Net.CallbackStatus _)
	{
		NewbieAdventureTaskUpdateNotify newbieAdventureTaskUpdateNotify = (NewbieAdventureTaskUpdateNotify)msg;
		(ActivityModel.Instance.GetActivityById(newbieAdventureTaskUpdateNotify.ActivityId) as ActivityNewcomerJourneyData).UpdateChapterData(newbieAdventureTaskUpdateNotify.Chapter.ToList<NewbieAdventureV2ChapterPb>());
		EventSystem.Instance.Emit<int>(EEventName.ActivityViewRefreshCurrent, newbieAdventureTaskUpdateNotify.ActivityId);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, newbieAdventureTaskUpdateNotify.ActivityId);
	}

	// Token: 0x06008D06 RID: 36102 RVA: 0x001E4310 File Offset: 0x001E2510
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(newbieAdventureTaskRewardResponse.ErrorCode, 20663, null, true, true);
			}
		}, 0);
	}

	// Token: 0x06008D07 RID: 36103 RVA: 0x001E4368 File Offset: 0x001E2568
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(newbieAdventureChapterDropResponse.ErrorCode, 20800, null, true, true);
			}
		}, 0);
	}

	// Token: 0x06008D08 RID: 36104 RVA: 0x001E43BC File Offset: 0x001E25BC
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(newbieAdventureRoleRewardResponse.ErrorCode, 25004, null, true, true);
			}
		}, 0);
	}

	// Token: 0x17000BE4 RID: 3044
	// (get) Token: 0x06008D09 RID: 36105 RVA: 0x001E4414 File Offset: 0x001E2614
	public static ActivityNewcomerJourneyController Instance
	{
		get
		{
			return ActivityNewcomerJourneyController._Instance;
		}
	}

	// Token: 0x06008D0A RID: 36106 RVA: 0x001E441B File Offset: 0x001E261B
	public static ActivityNewcomerJourneyController GetOrCreateInstance()
	{
		if (ActivityNewcomerJourneyController._Instance == null)
		{
			ActivityNewcomerJourneyController.CreateInstance();
		}
		return ActivityNewcomerJourneyController._Instance;
	}

	// Token: 0x06008D0B RID: 36107 RVA: 0x001E442F File Offset: 0x001E262F
	public static bool CreateInstance()
	{
		if (ActivityNewcomerJourneyController._Instance != null)
		{
			return true;
		}
		ActivityNewcomerJourneyController._Instance = new ActivityNewcomerJourneyController();
		return true;
	}

	// Token: 0x06008D0C RID: 36108 RVA: 0x001E4445 File Offset: 0x001E2645
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06008D0D RID: 36109 RVA: 0x001E4447 File Offset: 0x001E2647
	public static void ResetStaticDefaultValue()
	{
		ActivityNewcomerJourneyController._Instance = null;
	}

	// Token: 0x06008D0E RID: 36110 RVA: 0x001E444F File Offset: 0x001E264F
	static ActivityNewcomerJourneyController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityNewcomerJourneyController.CreateStaticDefaultValue), new Action(ActivityNewcomerJourneyController.ResetStaticDefaultValue));
	}

	// Token: 0x04003E7F RID: 15999
	private const int NEWCOMER_SPLASH_CACHE_KEY = 1;

	// Token: 0x04003E80 RID: 16000
	private bool PendingSplashAfterActivitySync;

	// Token: 0x04003E81 RID: 16001
	private int ActivityId;

	// Token: 0x04003E82 RID: 16002
	[Nullable(2)]
	private static ActivityNewcomerJourneyController _Instance;
}
