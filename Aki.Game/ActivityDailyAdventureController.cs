using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using Google.Protobuf;

// Token: 0x0200120B RID: 4619
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ActivityDailyAdventureController : ActivityControllerBase
{
	// Token: 0x06007BA9 RID: 31657 RVA: 0x001A160D File Offset: 0x0019F80D
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x06007BAA RID: 31658 RVA: 0x001A1610 File Offset: 0x0019F810
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x06007BAB RID: 31659 RVA: 0x001A1612 File Offset: 0x0019F812
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_ActivityDailyAdventure";
	}

	// Token: 0x06007BAC RID: 31660 RVA: 0x001A1619 File Offset: 0x0019F819
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new ActivitySubViewDailyAdventure();
	}

	// Token: 0x06007BAD RID: 31661 RVA: 0x001A1620 File Offset: 0x0019F820
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		this.CurrentActivityId = data.Id;
		return new ActivityDailyAdventureData();
	}

	// Token: 0x06007BAE RID: 31662 RVA: 0x001A1633 File Offset: 0x0019F833
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add<int, int>(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
	}

	// Token: 0x06007BAF RID: 31663 RVA: 0x001A1651 File Offset: 0x0019F851
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
	}

	// Token: 0x06007BB0 RID: 31664 RVA: 0x001A166F File Offset: 0x0019F86F
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.DailyAdventureTaskUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnDailyAdventureTaskUpdateNotify));
	}

	// Token: 0x06007BB1 RID: 31665 RVA: 0x001A168D File Offset: 0x0019F88D
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.DailyAdventureTaskUpdateNotify);
	}

	// Token: 0x06007BB2 RID: 31666 RVA: 0x001A169F File Offset: 0x0019F89F
	[NullableContext(2)]
	protected ActivityDailyAdventureData GetDailyAdventureData()
	{
		return ActivityModel.Instance.GetActivityById(this.CurrentActivityId) as ActivityDailyAdventureData;
	}

	// Token: 0x06007BB3 RID: 31667 RVA: 0x001A16B8 File Offset: 0x0019F8B8
	public int GetDefaultMapMarkId()
	{
		ActivityDailyAdventureData dailyAdventureData = this.GetDailyAdventureData();
		if (dailyAdventureData == null)
		{
			return 0;
		}
		return dailyAdventureData.GetDefaultMapMarkId();
	}

	// Token: 0x06007BB4 RID: 31668 RVA: 0x001A16D8 File Offset: 0x0019F8D8
	private void OnCommonItemCountAnyChange(int configId, int count)
	{
		if (configId != 13)
		{
			return;
		}
		ActivityDailyAdventureData dailyAdventureData = this.GetDailyAdventureData();
		if (dailyAdventureData == null)
		{
			return;
		}
		dailyAdventureData.SetProgressPoint(count);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, dailyAdventureData.Id);
	}

	// Token: 0x06007BB5 RID: 31669 RVA: 0x001A1714 File Offset: 0x0019F914
	[NullableContext(2)]
	private void OnDailyAdventureTaskUpdateNotify(IMessage msg, Net.CallbackStatus _)
	{
		DailyAdventureTaskUpdateNotify dailyAdventureTaskUpdateNotify = (DailyAdventureTaskUpdateNotify)msg;
		ActivityDailyAdventureData dailyAdventureData = this.GetDailyAdventureData();
		if (dailyAdventureData == null)
		{
			return;
		}
		foreach (DailyAdventureActivityTask dailyAdventureActivityTask in dailyAdventureTaskUpdateNotify.DailyAdventureActivityTasks)
		{
			dailyAdventureData.SetTaskInfo(dailyAdventureActivityTask.Id, new ERewardState?(ActivityDailyAdventureDefine.RewardStateResolver[dailyAdventureActivityTask.Status]), new int?(dailyAdventureActivityTask.Current));
		}
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, dailyAdventureData.Id);
	}

	// Token: 0x06007BB6 RID: 31670 RVA: 0x001A17B0 File Offset: 0x0019F9B0
	public void RequestTaskReward(int id)
	{
		DailyAdventureTaskRewardRequest dailyAdventureTaskRewardRequest = DailyAdventureTaskRewardRequest.Create();
		dailyAdventureTaskRewardRequest.Id = id;
		Net.Instance.Call(ERequestMessageId.DailyAdventureTaskRewardRequest, dailyAdventureTaskRewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			DailyAdventureTaskRewardResponse dailyAdventureTaskRewardResponse = (DailyAdventureTaskRewardResponse)msg;
			if (dailyAdventureTaskRewardResponse == null)
			{
				return;
			}
			if (dailyAdventureTaskRewardResponse.ErrorCode != ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(dailyAdventureTaskRewardResponse.ErrorCode, 16686, null, true, true);
				return;
			}
			ActivityDailyAdventureData dailyAdventureData = this.GetDailyAdventureData();
			if (dailyAdventureData == null)
			{
				return;
			}
			dailyAdventureData.SetTaskInfo(id, new ERewardState?(ERewardState.FinishedAndClaimed), null);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, dailyAdventureData.Id);
		}, 0);
	}

	// Token: 0x06007BB7 RID: 31671 RVA: 0x001A1800 File Offset: 0x0019FA00
	public void RequestPointReward(int id)
	{
		DailyAdventurePtRewardRequest dailyAdventurePtRewardRequest = DailyAdventurePtRewardRequest.Create();
		dailyAdventurePtRewardRequest.Id = id;
		Net.Instance.Call(ERequestMessageId.DailyAdventurePtRewardRequest, dailyAdventurePtRewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			DailyAdventurePtRewardResponse dailyAdventurePtRewardResponse = (DailyAdventurePtRewardResponse)msg;
			if (dailyAdventurePtRewardResponse == null)
			{
				return;
			}
			if (dailyAdventurePtRewardResponse.ErrorCode != ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(dailyAdventurePtRewardResponse.ErrorCode, 16430, null, true, true);
				return;
			}
			ActivityDailyAdventureData dailyAdventureData = this.GetDailyAdventureData();
			if (dailyAdventureData == null)
			{
				return;
			}
			dailyAdventureData.SetPointReward(id, true);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, dailyAdventureData.Id);
		}, 0);
	}

	// Token: 0x17000A8F RID: 2703
	// (get) Token: 0x06007BB8 RID: 31672 RVA: 0x001A1850 File Offset: 0x0019FA50
	public static ActivityDailyAdventureController Instance
	{
		get
		{
			return ActivityDailyAdventureController._Instance;
		}
	}

	// Token: 0x06007BB9 RID: 31673 RVA: 0x001A1857 File Offset: 0x0019FA57
	public static ActivityDailyAdventureController GetOrCreateInstance()
	{
		if (ActivityDailyAdventureController._Instance == null)
		{
			ActivityDailyAdventureController.CreateInstance();
		}
		return ActivityDailyAdventureController._Instance;
	}

	// Token: 0x06007BBA RID: 31674 RVA: 0x001A186B File Offset: 0x0019FA6B
	public static bool CreateInstance()
	{
		if (ActivityDailyAdventureController._Instance != null)
		{
			return true;
		}
		ActivityDailyAdventureController._Instance = new ActivityDailyAdventureController();
		return true;
	}

	// Token: 0x06007BBB RID: 31675 RVA: 0x001A1881 File Offset: 0x0019FA81
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06007BBC RID: 31676 RVA: 0x001A1883 File Offset: 0x0019FA83
	public static void ResetStaticDefaultValue()
	{
		ActivityDailyAdventureController._Instance = null;
	}

	// Token: 0x06007BBD RID: 31677 RVA: 0x001A188B File Offset: 0x0019FA8B
	static ActivityDailyAdventureController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityDailyAdventureController.CreateStaticDefaultValue), new Action(ActivityDailyAdventureController.ResetStaticDefaultValue));
	}

	// Token: 0x040038A6 RID: 14502
	public int CurrentActivityId;

	// Token: 0x040038A7 RID: 14503
	[Nullable(2)]
	private static ActivityDailyAdventureController _Instance;
}
