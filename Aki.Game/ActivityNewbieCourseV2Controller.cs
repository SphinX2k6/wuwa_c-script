using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using Google.Protobuf;

// Token: 0x02001397 RID: 5015
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ActivityNewbieCourseV2Controller : ActivityControllerBase
{
	// Token: 0x06008C94 RID: 35988 RVA: 0x001E2566 File Offset: 0x001E0766
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add<int, int, int, int, int, int, int>(EEventName.OnPlayerLevelChanged, new Action<int, int, int, int, int, int, int>(this.OnPlayerLevelChanged));
	}

	// Token: 0x06008C95 RID: 35989 RVA: 0x001E2584 File Offset: 0x001E0784
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove<int, int, int, int, int, int, int>(EEventName.OnPlayerLevelChanged, new Action<int, int, int, int, int, int, int>(this.OnPlayerLevelChanged));
	}

	// Token: 0x06008C96 RID: 35990 RVA: 0x001E25A2 File Offset: 0x001E07A2
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.NewbieCourseV2RewardNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRewardNotify));
	}

	// Token: 0x06008C97 RID: 35991 RVA: 0x001E25C0 File Offset: 0x001E07C0
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.NewbieCourseV2RewardNotify);
	}

	// Token: 0x06008C98 RID: 35992 RVA: 0x001E25D2 File Offset: 0x001E07D2
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x06008C99 RID: 35993 RVA: 0x001E25D4 File Offset: 0x001E07D4
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_NewcomerSynesthesiaLevelMain";
	}

	// Token: 0x06008C9A RID: 35994 RVA: 0x001E25DB File Offset: 0x001E07DB
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new ActivitySubViewNewbieCourseV2();
	}

	// Token: 0x06008C9B RID: 35995 RVA: 0x001E25E2 File Offset: 0x001E07E2
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		this.DataId = data.Id;
		return new ActivityNewbieCourseV2Data();
	}

	// Token: 0x06008C9C RID: 35996 RVA: 0x001E25F5 File Offset: 0x001E07F5
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x06008C9D RID: 35997 RVA: 0x001E25F8 File Offset: 0x001E07F8
	protected override bool OnClear()
	{
		this.DataId = 0;
		return true;
	}

	// Token: 0x06008C9E RID: 35998 RVA: 0x001E2604 File Offset: 0x001E0804
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
			Aki.Protocol.ErrorCode errorCode = ActivityNewbieCourseV2Controller.ReadResponseErrorCode(newbieCourseV2RewardResponse);
			if (errorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(errorCode, 21399, null, true, true);
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

	// Token: 0x06008C9F RID: 35999 RVA: 0x001E26D4 File Offset: 0x001E08D4
	public void RequestReward(int targetLevel, int? activityId = null)
	{
		this.RequestRewards(new <>z__ReadOnlySingleElementList<int>(targetLevel), activityId);
	}

	// Token: 0x06008CA0 RID: 36000 RVA: 0x001E26E4 File Offset: 0x001E08E4
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

	// Token: 0x06008CA1 RID: 36001 RVA: 0x001E27A4 File Offset: 0x001E09A4
	private static Aki.Protocol.ErrorCode ReadResponseErrorCode(NewbieCourseV2RewardResponse response)
	{
		Type type = response.GetType();
		foreach (string name in new string[]
		{
			"ErrorCode",
			"Error",
			"Code"
		})
		{
			PropertyInfo property = type.GetProperty(name);
			if (!(property == null))
			{
				object value = property.GetValue(response);
				if (value is Aki.Protocol.ErrorCode)
				{
					return (Aki.Protocol.ErrorCode)value;
				}
				if (value is int)
				{
					return (Aki.Protocol.ErrorCode)((int)value);
				}
			}
		}
		return Aki.Protocol.ErrorCode.UnKnownError;
	}

	// Token: 0x06008CA2 RID: 36002 RVA: 0x001E2834 File Offset: 0x001E0A34
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

	// Token: 0x06008CA3 RID: 36003 RVA: 0x001E2880 File Offset: 0x001E0A80
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
		activityNewbieCourseV2Data.SetReceiveData(newbieCourseV2RewardNotify.HadTakeReward.ToArray<int>());
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.DataId);
	}

	// Token: 0x17000BE2 RID: 3042
	// (get) Token: 0x06008CA4 RID: 36004 RVA: 0x001E28EE File Offset: 0x001E0AEE
	public static ActivityNewbieCourseV2Controller Instance
	{
		get
		{
			return ActivityNewbieCourseV2Controller._Instance;
		}
	}

	// Token: 0x06008CA5 RID: 36005 RVA: 0x001E28F5 File Offset: 0x001E0AF5
	public static ActivityNewbieCourseV2Controller GetOrCreateInstance()
	{
		if (ActivityNewbieCourseV2Controller._Instance == null)
		{
			ActivityNewbieCourseV2Controller.CreateInstance();
		}
		return ActivityNewbieCourseV2Controller._Instance;
	}

	// Token: 0x06008CA6 RID: 36006 RVA: 0x001E2909 File Offset: 0x001E0B09
	public static bool CreateInstance()
	{
		if (ActivityNewbieCourseV2Controller._Instance != null)
		{
			return true;
		}
		ActivityNewbieCourseV2Controller._Instance = new ActivityNewbieCourseV2Controller();
		return true;
	}

	// Token: 0x06008CA7 RID: 36007 RVA: 0x001E291F File Offset: 0x001E0B1F
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06008CA8 RID: 36008 RVA: 0x001E2921 File Offset: 0x001E0B21
	public static void ResetStaticDefaultValue()
	{
		ActivityNewbieCourseV2Controller._Instance = null;
	}

	// Token: 0x06008CA9 RID: 36009 RVA: 0x001E2929 File Offset: 0x001E0B29
	static ActivityNewbieCourseV2Controller()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityNewbieCourseV2Controller.CreateStaticDefaultValue), new Action(ActivityNewbieCourseV2Controller.ResetStaticDefaultValue));
	}

	// Token: 0x04003E63 RID: 15971
	private int DataId;

	// Token: 0x04003E64 RID: 15972
	[Nullable(2)]
	private static ActivityNewbieCourseV2Controller _Instance;
}
