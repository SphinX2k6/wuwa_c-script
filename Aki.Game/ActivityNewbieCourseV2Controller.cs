using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using Google.Protobuf;

// Token: 0x0200084B RID: 2123
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ActivityNewbieCourseV2Controller : ActivityControllerBase
{
	// Token: 0x0600602E RID: 24622 RVA: 0x001EB392 File Offset: 0x001E9592
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add<int, int, int, int, int, int, int>(EEventName.OnPlayerLevelChanged, new Action<int, int, int, int, int, int, int>(this.OnPlayerLevelChanged));
	}

	// Token: 0x0600602F RID: 24623 RVA: 0x001EB3B0 File Offset: 0x001E95B0
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove<int, int, int, int, int, int, int>(EEventName.OnPlayerLevelChanged, new Action<int, int, int, int, int, int, int>(this.OnPlayerLevelChanged));
	}

	// Token: 0x06006030 RID: 24624 RVA: 0x001EB3CE File Offset: 0x001E95CE
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.NewbieCourseV2RewardNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRewardNotify));
	}

	// Token: 0x06006031 RID: 24625 RVA: 0x001EB3EC File Offset: 0x001E95EC
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.NewbieCourseV2RewardNotify);
	}

	// Token: 0x06006032 RID: 24626 RVA: 0x001EB3FE File Offset: 0x001E95FE
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x06006033 RID: 24627 RVA: 0x001EB400 File Offset: 0x001E9600
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_NewcomerSynesthesiaLevelMain";
	}

	// Token: 0x06006034 RID: 24628 RVA: 0x001EB407 File Offset: 0x001E9607
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new ActivitySubViewNewbieCourseV2();
	}

	// Token: 0x06006035 RID: 24629 RVA: 0x001EB40E File Offset: 0x001E960E
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		this.DataId = data.Id;
		return new ActivityNewbieCourseV2Data();
	}

	// Token: 0x06006036 RID: 24630 RVA: 0x001EB421 File Offset: 0x001E9621
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x06006037 RID: 24631 RVA: 0x001EB424 File Offset: 0x001E9624
	protected override bool OnClear()
	{
		this.DataId = 0;
		return true;
	}

	// Token: 0x06006038 RID: 24632 RVA: 0x001EB430 File Offset: 0x001E9630
	public void RequestRewards(IReadOnlyList<int> targetLevels, int? activityId = null)
	{
		int dataId = activityId ?? this.DataId;
		if (targetLevels == null || targetLevels.Count <= 0 || dataId == 0)
		{
			return;
		}
		NewbieCourseV2RewardRequest newbieCourseV2RewardRequest = NewbieCourseV2RewardRequest.Create();
		newbieCourseV2RewardRequest.ActivityId = dataId;
		foreach (int item in targetLevels)
		{
			newbieCourseV2RewardRequest.Level.Add(item);
		}
		Net.Instance.Call(ERequestMessageId.NewbieCourseV2RewardRequest, newbieCourseV2RewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			NewbieCourseV2RewardResponse newbieCourseV2RewardResponse = (NewbieCourseV2RewardResponse)msg;
			if (newbieCourseV2RewardResponse == null)
			{
				return;
			}
			Aki.Protocol.ErrorCode errorCode = newbieCourseV2RewardResponse.ErrorCode;
			if (errorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(errorCode, 16170, null, true, true);
				return;
			}
			ActivityNewbieCourseV2Data activityNewbieCourseV2Data = ActivityModel.Instance.GetActivityById(dataId) as ActivityNewbieCourseV2Data;
			if (activityNewbieCourseV2Data == null || activityNewbieCourseV2Data.Type != ActivityType.NewbieCourseV2)
			{
				return;
			}
			foreach (int level in targetLevels)
			{
				activityNewbieCourseV2Data.AddReceivedData(level);
			}
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, dataId);
		}, 0);
	}

	// Token: 0x06006039 RID: 24633 RVA: 0x001EB500 File Offset: 0x001E9700
	public void RequestReward(int targetLevel, int? activityId = null)
	{
		this.RequestRewards(new <>z__ReadOnlySingleElementList<int>(targetLevel), activityId);
	}

	// Token: 0x0600603A RID: 24634 RVA: 0x001EB510 File Offset: 0x001E9710
	public void RequestAllClaimableRewards(int? activityId = null)
	{
		int num = activityId ?? this.DataId;
		if (num == 0)
		{
			return;
		}
		ActivityNewbieCourseV2Data activityNewbieCourseV2Data = ActivityModel.Instance.GetActivityById(num) as ActivityNewbieCourseV2Data;
		if (activityNewbieCourseV2Data == null || activityNewbieCourseV2Data.Type != ActivityType.NewbieCourseV2)
		{
			return;
		}
		List<int> list = new List<int>();
		foreach (NewbieCourseV2 newbieCourseV in ActivityNewbieCourseV2Config.Instance.GetConfigList(num))
		{
			if (activityNewbieCourseV2Data.GetRewardState(newbieCourseV.TargetLevel) == ENewbieCourseV2ItemState.CanReceive)
			{
				list.Add(newbieCourseV.TargetLevel);
			}
		}
		this.RequestRewards(list, new int?(num));
	}

	// Token: 0x0600603B RID: 24635 RVA: 0x001EB5D0 File Offset: 0x001E97D0
	private void OnPlayerLevelChanged(int lastLevel, int currentLevel, int currentExp, int lastExp, int addExp, int currentMaxExp, int lastMaxExp)
	{
		if (this.DataId == 0)
		{
			return;
		}
		ActivityBaseData activityById = ActivityModel.Instance.GetActivityById(this.DataId);
		if (activityById == null || activityById.Type != ActivityType.NewbieCourseV2)
		{
			return;
		}
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.DataId);
	}

	// Token: 0x0600603C RID: 24636 RVA: 0x001EB61C File Offset: 0x001E981C
	[NullableContext(2)]
	private void OnRewardNotify(IMessage msg, Net.CallbackStatus status)
	{
		NewbieCourseV2RewardNotify newbieCourseV2RewardNotify = (NewbieCourseV2RewardNotify)msg;
		if (newbieCourseV2RewardNotify.ActivityId != this.DataId)
		{
			return;
		}
		ActivityNewbieCourseV2Data activityNewbieCourseV2Data = ActivityModel.Instance.GetActivityById(this.DataId) as ActivityNewbieCourseV2Data;
		if (activityNewbieCourseV2Data == null || activityNewbieCourseV2Data.Type != ActivityType.NewbieCourseV2)
		{
			return;
		}
		activityNewbieCourseV2Data.SetReceiveData(newbieCourseV2RewardNotify.HadTakeReward);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.DataId);
	}

	// Token: 0x17000C02 RID: 3074
	// (get) Token: 0x0600603D RID: 24637 RVA: 0x001EB685 File Offset: 0x001E9885
	public static ActivityNewbieCourseV2Controller Instance
	{
		get
		{
			return ActivityNewbieCourseV2Controller._Instance;
		}
	}

	// Token: 0x0600603E RID: 24638 RVA: 0x001EB68C File Offset: 0x001E988C
	public static ActivityNewbieCourseV2Controller GetOrCreateInstance()
	{
		if (ActivityNewbieCourseV2Controller._Instance == null)
		{
			ActivityNewbieCourseV2Controller.CreateInstance();
		}
		return ActivityNewbieCourseV2Controller._Instance;
	}

	// Token: 0x0600603F RID: 24639 RVA: 0x001EB6A0 File Offset: 0x001E98A0
	public static bool CreateInstance()
	{
		if (ActivityNewbieCourseV2Controller._Instance != null)
		{
			return true;
		}
		ActivityNewbieCourseV2Controller._Instance = new ActivityNewbieCourseV2Controller();
		return true;
	}

	// Token: 0x06006040 RID: 24640 RVA: 0x001EB6B6 File Offset: 0x001E98B6
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06006041 RID: 24641 RVA: 0x001EB6B8 File Offset: 0x001E98B8
	public static void ResetStaticDefaultValue()
	{
		ActivityNewbieCourseV2Controller._Instance = null;
	}

	// Token: 0x06006042 RID: 24642 RVA: 0x001EB6C0 File Offset: 0x001E98C0
	static ActivityNewbieCourseV2Controller()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityNewbieCourseV2Controller.CreateStaticDefaultValue), new Action(ActivityNewbieCourseV2Controller.ResetStaticDefaultValue));
	}

	// Token: 0x04003EFB RID: 16123
	private int DataId;

	// Token: 0x04003EFC RID: 16124
	[Nullable(2)]
	private static ActivityNewbieCourseV2Controller _Instance;
}
