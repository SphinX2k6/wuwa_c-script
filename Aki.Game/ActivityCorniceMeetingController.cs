using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Google.Protobuf;

// Token: 0x020006A5 RID: 1701
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ActivityCorniceMeetingController : ActivityControllerBase
{
	// Token: 0x06004E30 RID: 20016 RVA: 0x001A5B9E File Offset: 0x001A3D9E
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x06004E31 RID: 20017 RVA: 0x001A5BA0 File Offset: 0x001A3DA0
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_AbnormalData";
	}

	// Token: 0x06004E32 RID: 20018 RVA: 0x001A5BA7 File Offset: 0x001A3DA7
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.CorniceChallengeEndNotify, new Action<IMessage, Net.CallbackStatus>(this.OnChallengeEndNotify));
	}

	// Token: 0x06004E33 RID: 20019 RVA: 0x001A5BC5 File Offset: 0x001A3DC5
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.CorniceChallengeEndNotify);
	}

	// Token: 0x06004E34 RID: 20020 RVA: 0x001A5BD8 File Offset: 0x001A3DD8
	[NullableContext(2)]
	private void OnChallengeEndNotify(IMessage msg, Net.CallbackStatus _)
	{
		CorniceChallengeEndNotify corniceChallengeEndNotify = (CorniceChallengeEndNotify)msg;
		ActivityCorniceMeetingData currentActivityData = this.GetCurrentActivityData();
		if (currentActivityData == null)
		{
			return;
		}
		ActivityCorniceMeetingLevelEntryData levelEntryData = currentActivityData.GetLevelEntryData(corniceChallengeEndNotify.LevelPlayId);
		if (levelEntryData == null)
		{
			return;
		}
		if (corniceChallengeEndNotify.NewScoreRecord)
		{
			levelEntryData.MaxScore = corniceChallengeEndNotify.Score;
		}
		levelEntryData.CurrentScore = corniceChallengeEndNotify.Score;
		if (corniceChallengeEndNotify.NewRemainingTimeRecord)
		{
			levelEntryData.RemainTime = corniceChallengeEndNotify.RemainingTime;
		}
		EventSystem.Instance.Emit<int>(EEventName.RefreshCorniceMeetingRedDot, corniceChallengeEndNotify.LevelPlayId);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, ActivityCorniceMeetingConfig.Instance.GetCorniceMeetingChallengeConfig(corniceChallengeEndNotify.LevelPlayId).Value.ActivityId);
		UiManager.Instance.OpenView(EUiViewName.CorniceMeetingSettleView, corniceChallengeEndNotify, null);
	}

	// Token: 0x06004E35 RID: 20021 RVA: 0x001A5C94 File Offset: 0x001A3E94
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new ActivitySubViewCorniceMeeting();
	}

	// Token: 0x06004E36 RID: 20022 RVA: 0x001A5C9B File Offset: 0x001A3E9B
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		this.ActivityId = data.Id;
		return new ActivityCorniceMeetingData();
	}

	// Token: 0x06004E37 RID: 20023 RVA: 0x001A5CAE File Offset: 0x001A3EAE
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x06004E38 RID: 20024 RVA: 0x001A5CB1 File Offset: 0x001A3EB1
	[NullableContext(2)]
	public ActivityCorniceMeetingData GetCurrentActivityData()
	{
		return ActivityModel.Instance.GetActivityById(this.ActivityId) as ActivityCorniceMeetingData;
	}

	// Token: 0x06004E39 RID: 20025 RVA: 0x001A5CC8 File Offset: 0x001A3EC8
	public void MultiCorniceMeetingRewardRequest(int activityId, Dictionary<int, List<int>> scoreList, Action callback)
	{
		MulCorniceMeetingRewardRequest mulCorniceMeetingRewardRequest = MulCorniceMeetingRewardRequest.Create();
		mulCorniceMeetingRewardRequest.ActivityId = activityId;
		foreach (KeyValuePair<int, List<int>> keyValuePair in scoreList)
		{
			int key = keyValuePair.Key;
			List<int> value = keyValuePair.Value;
			CorniceMeetingRewardScoreList corniceMeetingRewardScoreList = CorniceMeetingRewardScoreList.Create();
			corniceMeetingRewardScoreList.ScoreIndexes.AddRange(value);
			mulCorniceMeetingRewardRequest.CorniceMeetingRewardScoreLists[key] = corniceMeetingRewardScoreList;
		}
		Net.Instance.Call(ERequestMessageId.MulCorniceMeetingRewardRequest, mulCorniceMeetingRewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			MulCorniceMeetingRewardResponse mulCorniceMeetingRewardResponse = (MulCorniceMeetingRewardResponse)msg;
			if (mulCorniceMeetingRewardResponse != null && mulCorniceMeetingRewardResponse.ErrorCode != ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(mulCorniceMeetingRewardResponse.ErrorCode, 20556, null, true, true);
				return;
			}
			ActivityCorniceMeetingData currentActivityData = this.GetCurrentActivityData();
			foreach (KeyValuePair<int, List<int>> keyValuePair2 in scoreList)
			{
				int key2 = keyValuePair2.Key;
				foreach (int score in keyValuePair2.Value)
				{
					currentActivityData.UpdateRewarded(key2, score);
				}
				EventSystem.Instance.Emit<int>(EEventName.RefreshCorniceMeetingRedDot, key2);
			}
			Action callback2 = callback;
			if (callback2 == null)
			{
				return;
			}
			callback2();
		}, 0);
	}

	// Token: 0x06004E3A RID: 20026 RVA: 0x001A5D90 File Offset: 0x001A3F90
	public void CorniceMeetingChallengeTransRequest(int levelPlayId)
	{
		CorniceChallengeTransRequest corniceChallengeTransRequest = CorniceChallengeTransRequest.Create();
		corniceChallengeTransRequest.LevelPlayId = levelPlayId;
		Net.Instance.Call(ERequestMessageId.CorniceChallengeTransRequest, corniceChallengeTransRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			CorniceChallengeTransResponse corniceChallengeTransResponse = (CorniceChallengeTransResponse)msg;
			if (corniceChallengeTransResponse != null && corniceChallengeTransResponse.ErrorCode != ErrorCode.Success && corniceChallengeTransResponse.ErrorCode != ErrorCode.ErrPlayerIsTeleportCanNotDoTeleport)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(corniceChallengeTransResponse.ErrorCode, 23951, null, true, true);
			}
		}, 0);
	}

	// Token: 0x17000A9C RID: 2716
	// (get) Token: 0x06004E3B RID: 20027 RVA: 0x001A5DDA File Offset: 0x001A3FDA
	public static ActivityCorniceMeetingController Instance
	{
		get
		{
			return ActivityCorniceMeetingController._Instance;
		}
	}

	// Token: 0x06004E3C RID: 20028 RVA: 0x001A5DE1 File Offset: 0x001A3FE1
	public static ActivityCorniceMeetingController GetOrCreateInstance()
	{
		if (ActivityCorniceMeetingController._Instance == null)
		{
			ActivityCorniceMeetingController.CreateInstance();
		}
		return ActivityCorniceMeetingController._Instance;
	}

	// Token: 0x06004E3D RID: 20029 RVA: 0x001A5DF5 File Offset: 0x001A3FF5
	public static bool CreateInstance()
	{
		if (ActivityCorniceMeetingController._Instance != null)
		{
			return true;
		}
		ActivityCorniceMeetingController._Instance = new ActivityCorniceMeetingController();
		return true;
	}

	// Token: 0x06004E3E RID: 20030 RVA: 0x001A5E0B File Offset: 0x001A400B
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06004E3F RID: 20031 RVA: 0x001A5E0D File Offset: 0x001A400D
	public static void ResetStaticDefaultValue()
	{
		ActivityCorniceMeetingController._Instance = null;
	}

	// Token: 0x06004E40 RID: 20032 RVA: 0x001A5E15 File Offset: 0x001A4015
	static ActivityCorniceMeetingController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityCorniceMeetingController.CreateStaticDefaultValue), new Action(ActivityCorniceMeetingController.ResetStaticDefaultValue));
	}

	// Token: 0x040038CA RID: 14538
	public int ActivityId;

	// Token: 0x040038CB RID: 14539
	[Nullable(2)]
	private static ActivityCorniceMeetingController _Instance;
}
