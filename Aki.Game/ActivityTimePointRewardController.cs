using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using Google.Protobuf;

// Token: 0x0200151D RID: 5405
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ActivityTimePointRewardController : ActivityControllerBase
{
	// Token: 0x06009A24 RID: 39460 RVA: 0x00215852 File Offset: 0x00213A52
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x06009A25 RID: 39461 RVA: 0x00215854 File Offset: 0x00213A54
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		if (data.Id == 102000001)
		{
			return "UiItem_ActivityTimePointReward";
		}
		if (data.Id == 102000002)
		{
			return "UiItem_WelfareInfoA";
		}
		if (data.Id == 102000004)
		{
			return "UiItem_WelfareBgC";
		}
		if (data.Id == 102000005)
		{
			return "UiItem_WelfareInfoB";
		}
		if (data.Id == 102000009)
		{
			return "UiItem_Welfare37";
		}
		return "UiItem_ActivityTimePointReward";
	}

	// Token: 0x06009A26 RID: 39462 RVA: 0x002158C8 File Offset: 0x00213AC8
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		if (data.Id == 102000001)
		{
			return new ActivitySubViewTimePointReward();
		}
		if (data.Id == 102000002)
		{
			return new CelebrationAwardSubView();
		}
		if (data.Id == 102000004)
		{
			return new MoonCelebrationAwardSubView();
		}
		if (data.Id == 102000005)
		{
			return new AnniversaryCelebrationAwardSubView();
		}
		if (data.Id == 102000009)
		{
			return new ActivitySubViewCheckInReward();
		}
		return new ActivitySubViewTimePointReward();
	}

	// Token: 0x06009A27 RID: 39463 RVA: 0x00215939 File Offset: 0x00213B39
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		return new ActivityTimePointRewardData();
	}

	// Token: 0x06009A28 RID: 39464 RVA: 0x00215940 File Offset: 0x00213B40
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x06009A29 RID: 39465 RVA: 0x00215943 File Offset: 0x00213B43
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.TimePointRewardActivityConditionNotify, new Action<IMessage, Net.CallbackStatus>(this.OnTimePointRewardUpdateNotify));
	}

	// Token: 0x06009A2A RID: 39466 RVA: 0x00215961 File Offset: 0x00213B61
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.TimePointRewardActivityConditionNotify);
	}

	// Token: 0x06009A2B RID: 39467 RVA: 0x00215974 File Offset: 0x00213B74
	[NullableContext(2)]
	private void OnTimePointRewardUpdateNotify(IMessage msg, Net.CallbackStatus status)
	{
		TimePointRewardActivityConditionNotify timePointRewardActivityConditionNotify = (TimePointRewardActivityConditionNotify)msg;
		ActivityTimePointRewardData activityTimePointRewardData = ActivityModel.Instance.GetActivityById(102000009) as ActivityTimePointRewardData;
		if (activityTimePointRewardData == null)
		{
			return;
		}
		activityTimePointRewardData.OnTimePointRewardUpdate(timePointRewardActivityConditionNotify.Data, 102000009);
		EventSystem.Instance.Emit<int>(EEventName.ActivityViewRefreshCurrent, activityTimePointRewardData.Id);
	}

	// Token: 0x06009A2C RID: 39468 RVA: 0x002159C8 File Offset: 0x00213BC8
	public void GetRewardById(int activityId, int id)
	{
		TimePointActivityRewardRequest timePointActivityRewardRequest = TimePointActivityRewardRequest.Create();
		timePointActivityRewardRequest.Id = id;
		Net.Instance.Call(ERequestMessageId.TimePointActivityRewardRequest, timePointActivityRewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			TimePointActivityRewardResponse timePointActivityRewardResponse = (TimePointActivityRewardResponse)msg;
			if (timePointActivityRewardResponse.ErrorCode != ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(timePointActivityRewardResponse.ErrorCode, 28642, null, true, true);
				return;
			}
			(ActivityModel.Instance.GetActivityById(activityId) as ActivityTimePointRewardData).SetRewardToGotState(id);
		}, 0);
	}

	// Token: 0x06009A2D RID: 39469 RVA: 0x00215A18 File Offset: 0x00213C18
	public void GetBatchRewardById(int activityId, List<int> ids)
	{
		TimePointActivityBatchRewardRequest timePointActivityBatchRewardRequest = TimePointActivityBatchRewardRequest.Create();
		timePointActivityBatchRewardRequest.ActivityId = activityId;
		timePointActivityBatchRewardRequest.Ids.AddRange(ids);
		Net.Instance.Call(ERequestMessageId.TimePointActivityBatchRewardRequest, timePointActivityBatchRewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			TimePointActivityBatchRewardResponse timePointActivityBatchRewardResponse = (TimePointActivityBatchRewardResponse)msg;
			if (timePointActivityBatchRewardResponse.ErrorCode != ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(timePointActivityBatchRewardResponse.ErrorCode, 28642, null, true, true);
				return;
			}
			ActivityTimePointRewardData activityTimePointRewardData = ActivityModel.Instance.GetActivityById(activityId) as ActivityTimePointRewardData;
			foreach (int rewardToGotState in ids)
			{
				activityTimePointRewardData.SetRewardToGotState(rewardToGotState);
			}
		}, 0);
	}

	// Token: 0x17000D41 RID: 3393
	// (get) Token: 0x06009A2E RID: 39470 RVA: 0x00215A79 File Offset: 0x00213C79
	public static ActivityTimePointRewardController Instance
	{
		get
		{
			return ActivityTimePointRewardController._Instance;
		}
	}

	// Token: 0x06009A2F RID: 39471 RVA: 0x00215A80 File Offset: 0x00213C80
	public static ActivityTimePointRewardController GetOrCreateInstance()
	{
		if (ActivityTimePointRewardController._Instance == null)
		{
			ActivityTimePointRewardController.CreateInstance();
		}
		return ActivityTimePointRewardController._Instance;
	}

	// Token: 0x06009A30 RID: 39472 RVA: 0x00215A94 File Offset: 0x00213C94
	public static bool CreateInstance()
	{
		if (ActivityTimePointRewardController._Instance != null)
		{
			return true;
		}
		ActivityTimePointRewardController._Instance = new ActivityTimePointRewardController();
		return true;
	}

	// Token: 0x06009A31 RID: 39473 RVA: 0x00215AAA File Offset: 0x00213CAA
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06009A32 RID: 39474 RVA: 0x00215AAC File Offset: 0x00213CAC
	public static void ResetStaticDefaultValue()
	{
		ActivityTimePointRewardController._Instance = null;
	}

	// Token: 0x06009A33 RID: 39475 RVA: 0x00215AB4 File Offset: 0x00213CB4
	static ActivityTimePointRewardController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityTimePointRewardController.CreateStaticDefaultValue), new Action(ActivityTimePointRewardController.ResetStaticDefaultValue));
	}

	// Token: 0x040043D4 RID: 17364
	public const int TIME_AWARD_SEASON1_ACTIVITY_ID = 102000001;

	// Token: 0x040043D5 RID: 17365
	public const int TIME_AWARD_SEASON2_ACTIVITY_ID = 102000002;

	// Token: 0x040043D6 RID: 17366
	public const int TIME_AWARD_SEASON4_ACTIVITY_ID = 102000004;

	// Token: 0x040043D7 RID: 17367
	public const int TIME_AWARD_2026_SEASON2_ACTIVITY_ID = 102000005;

	// Token: 0x040043D8 RID: 17368
	public const int CHECK_IN_REWARD_ACTIVITY_ID = 102000009;

	// Token: 0x040043D9 RID: 17369
	[Nullable(2)]
	private static ActivityTimePointRewardController _Instance;
}
