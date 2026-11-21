using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using Google.Protobuf;

// Token: 0x020006BF RID: 1727
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ActivityDailyAdventureController : ActivityControllerBase
{
	// Token: 0x06004F3F RID: 20287 RVA: 0x001AA2C5 File Offset: 0x001A84C5
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x06004F40 RID: 20288 RVA: 0x001AA2C8 File Offset: 0x001A84C8
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x06004F41 RID: 20289 RVA: 0x001AA2CA File Offset: 0x001A84CA
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_ActivityDailyAdventure";
	}

	// Token: 0x06004F42 RID: 20290 RVA: 0x001AA2D1 File Offset: 0x001A84D1
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new ActivitySubViewDailyAdventure();
	}

	// Token: 0x06004F43 RID: 20291 RVA: 0x001AA2D8 File Offset: 0x001A84D8
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		this.CurrentActivityId = data.Id;
		return new ActivityDailyAdventureData();
	}

	// Token: 0x06004F44 RID: 20292 RVA: 0x001AA2EB File Offset: 0x001A84EB
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add<int, int>(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
	}

	// Token: 0x06004F45 RID: 20293 RVA: 0x001AA309 File Offset: 0x001A8509
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
	}

	// Token: 0x06004F46 RID: 20294 RVA: 0x001AA327 File Offset: 0x001A8527
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.DailyAdventureTaskUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnDailyAdventureTaskUpdateNotify));
	}

	// Token: 0x06004F47 RID: 20295 RVA: 0x001AA345 File Offset: 0x001A8545
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.DailyAdventureTaskUpdateNotify);
	}

	// Token: 0x06004F48 RID: 20296 RVA: 0x001AA357 File Offset: 0x001A8557
	[NullableContext(2)]
	protected ActivityDailyAdventureData GetDailyAdventureData()
	{
		return ActivityModel.Instance.GetActivityById(this.CurrentActivityId) as ActivityDailyAdventureData;
	}

	// Token: 0x06004F49 RID: 20297 RVA: 0x001AA370 File Offset: 0x001A8570
	public int GetDefaultMapMarkId()
	{
		ActivityDailyAdventureData dailyAdventureData = this.GetDailyAdventureData();
		if (dailyAdventureData == null)
		{
			return 0;
		}
		return dailyAdventureData.GetDefaultMapMarkId();
	}

	// Token: 0x06004F4A RID: 20298 RVA: 0x001AA390 File Offset: 0x001A8590
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

	// Token: 0x06004F4B RID: 20299 RVA: 0x001AA3CC File Offset: 0x001A85CC
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

	// Token: 0x06004F4C RID: 20300 RVA: 0x001AA468 File Offset: 0x001A8668
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(dailyAdventureTaskRewardResponse.ErrorCode, 17499, null, true, true);
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

	// Token: 0x06004F4D RID: 20301 RVA: 0x001AA4B8 File Offset: 0x001A86B8
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(dailyAdventurePtRewardResponse.ErrorCode, 17678, null, true, true);
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

	// Token: 0x17000AAF RID: 2735
	// (get) Token: 0x06004F4E RID: 20302 RVA: 0x001AA508 File Offset: 0x001A8708
	public static ActivityDailyAdventureController Instance
	{
		get
		{
			return ActivityDailyAdventureController._Instance;
		}
	}

	// Token: 0x06004F4F RID: 20303 RVA: 0x001AA50F File Offset: 0x001A870F
	public static ActivityDailyAdventureController GetOrCreateInstance()
	{
		if (ActivityDailyAdventureController._Instance == null)
		{
			ActivityDailyAdventureController.CreateInstance();
		}
		return ActivityDailyAdventureController._Instance;
	}

	// Token: 0x06004F50 RID: 20304 RVA: 0x001AA523 File Offset: 0x001A8723
	public static bool CreateInstance()
	{
		if (ActivityDailyAdventureController._Instance != null)
		{
			return true;
		}
		ActivityDailyAdventureController._Instance = new ActivityDailyAdventureController();
		return true;
	}

	// Token: 0x06004F51 RID: 20305 RVA: 0x001AA539 File Offset: 0x001A8739
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06004F52 RID: 20306 RVA: 0x001AA53B File Offset: 0x001A873B
	public static void ResetStaticDefaultValue()
	{
		ActivityDailyAdventureController._Instance = null;
	}

	// Token: 0x06004F53 RID: 20307 RVA: 0x001AA543 File Offset: 0x001A8743
	static ActivityDailyAdventureController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityDailyAdventureController.CreateStaticDefaultValue), new Action(ActivityDailyAdventureController.ResetStaticDefaultValue));
	}

	// Token: 0x0400393F RID: 14655
	public int CurrentActivityId;

	// Token: 0x04003940 RID: 14656
	[Nullable(2)]
	private static ActivityDailyAdventureController _Instance;
}
