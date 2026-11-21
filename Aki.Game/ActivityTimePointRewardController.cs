using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using Google.Protobuf;

// Token: 0x020009D5 RID: 2517
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ActivityTimePointRewardController : ActivityControllerBase
{
	// Token: 0x06006E02 RID: 28162 RVA: 0x0021F5EE File Offset: 0x0021D7EE
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x06006E03 RID: 28163 RVA: 0x0021F5F0 File Offset: 0x0021D7F0
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

	// Token: 0x06006E04 RID: 28164 RVA: 0x0021F664 File Offset: 0x0021D864
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

	// Token: 0x06006E05 RID: 28165 RVA: 0x0021F6D5 File Offset: 0x0021D8D5
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		return new ActivityTimePointRewardData();
	}

	// Token: 0x06006E06 RID: 28166 RVA: 0x0021F6DC File Offset: 0x0021D8DC
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x06006E07 RID: 28167 RVA: 0x0021F6DF File Offset: 0x0021D8DF
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.TimePointRewardActivityConditionNotify, new Action<IMessage, Net.CallbackStatus>(this.OnTimePointRewardUpdateNotify));
	}

	// Token: 0x06006E08 RID: 28168 RVA: 0x0021F6FD File Offset: 0x0021D8FD
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.TimePointRewardActivityConditionNotify);
	}

	// Token: 0x06006E09 RID: 28169 RVA: 0x0021F710 File Offset: 0x0021D910
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

	// Token: 0x06006E0A RID: 28170 RVA: 0x0021F764 File Offset: 0x0021D964
	public void GetRewardById(int activityId, int id)
	{
		TimePointActivityRewardRequest timePointActivityRewardRequest = TimePointActivityRewardRequest.Create();
		timePointActivityRewardRequest.Id = id;
		Net.Instance.Call(ERequestMessageId.TimePointActivityRewardRequest, timePointActivityRewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			TimePointActivityRewardResponse timePointActivityRewardResponse = (TimePointActivityRewardResponse)msg;
			if (timePointActivityRewardResponse.ErrorCode != ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(timePointActivityRewardResponse.ErrorCode, 18317, null, true, true);
				return;
			}
			(ActivityModel.Instance.GetActivityById(activityId) as ActivityTimePointRewardData).SetRewardToGotState(id);
		}, 0);
	}

	// Token: 0x06006E0B RID: 28171 RVA: 0x0021F7B4 File Offset: 0x0021D9B4
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(timePointActivityBatchRewardResponse.ErrorCode, 18317, null, true, true);
				return;
			}
			ActivityTimePointRewardData activityTimePointRewardData = ActivityModel.Instance.GetActivityById(activityId) as ActivityTimePointRewardData;
			foreach (int rewardToGotState in ids)
			{
				activityTimePointRewardData.SetRewardToGotState(rewardToGotState);
			}
		}, 0);
	}

	// Token: 0x17000D62 RID: 3426
	// (get) Token: 0x06006E0C RID: 28172 RVA: 0x0021F815 File Offset: 0x0021DA15
	public static ActivityTimePointRewardController Instance
	{
		get
		{
			return ActivityTimePointRewardController._Instance;
		}
	}

	// Token: 0x06006E0D RID: 28173 RVA: 0x0021F81C File Offset: 0x0021DA1C
	public static ActivityTimePointRewardController GetOrCreateInstance()
	{
		if (ActivityTimePointRewardController._Instance == null)
		{
			ActivityTimePointRewardController.CreateInstance();
		}
		return ActivityTimePointRewardController._Instance;
	}

	// Token: 0x06006E0E RID: 28174 RVA: 0x0021F830 File Offset: 0x0021DA30
	public static bool CreateInstance()
	{
		if (ActivityTimePointRewardController._Instance != null)
		{
			return true;
		}
		ActivityTimePointRewardController._Instance = new ActivityTimePointRewardController();
		return true;
	}

	// Token: 0x06006E0F RID: 28175 RVA: 0x0021F846 File Offset: 0x0021DA46
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06006E10 RID: 28176 RVA: 0x0021F848 File Offset: 0x0021DA48
	public static void ResetStaticDefaultValue()
	{
		ActivityTimePointRewardController._Instance = null;
	}

	// Token: 0x06006E11 RID: 28177 RVA: 0x0021F850 File Offset: 0x0021DA50
	static ActivityTimePointRewardController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityTimePointRewardController.CreateStaticDefaultValue), new Action(ActivityTimePointRewardController.ResetStaticDefaultValue));
	}

	// Token: 0x0400447A RID: 17530
	public const int TIME_AWARD_SEASON1_ACTIVITY_ID = 102000001;

	// Token: 0x0400447B RID: 17531
	public const int TIME_AWARD_SEASON2_ACTIVITY_ID = 102000002;

	// Token: 0x0400447C RID: 17532
	public const int TIME_AWARD_SEASON4_ACTIVITY_ID = 102000004;

	// Token: 0x0400447D RID: 17533
	public const int TIME_AWARD_2026_SEASON2_ACTIVITY_ID = 102000005;

	// Token: 0x0400447E RID: 17534
	public const int CHECK_IN_REWARD_ACTIVITY_ID = 102000009;

	// Token: 0x0400447F RID: 17535
	[Nullable(2)]
	private static ActivityTimePointRewardController _Instance;
}
