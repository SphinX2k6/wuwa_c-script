using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Google.Protobuf;

// Token: 0x020011F1 RID: 4593
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ActivityCorniceMeetingController : ActivityControllerBase
{
	// Token: 0x06007A99 RID: 31385 RVA: 0x0019CEF6 File Offset: 0x0019B0F6
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x06007A9A RID: 31386 RVA: 0x0019CEF8 File Offset: 0x0019B0F8
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_AbnormalData";
	}

	// Token: 0x06007A9B RID: 31387 RVA: 0x0019CEFF File Offset: 0x0019B0FF
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.CorniceChallengeEndNotify, new Action<IMessage, Net.CallbackStatus>(this.OnChallengeEndNotify));
	}

	// Token: 0x06007A9C RID: 31388 RVA: 0x0019CF1D File Offset: 0x0019B11D
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.CorniceChallengeEndNotify);
	}

	// Token: 0x06007A9D RID: 31389 RVA: 0x0019CF30 File Offset: 0x0019B130
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

	// Token: 0x06007A9E RID: 31390 RVA: 0x0019CFEC File Offset: 0x0019B1EC
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new ActivitySubViewCorniceMeeting();
	}

	// Token: 0x06007A9F RID: 31391 RVA: 0x0019CFF3 File Offset: 0x0019B1F3
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		this.ActivityId = data.Id;
		return new ActivityCorniceMeetingData();
	}

	// Token: 0x06007AA0 RID: 31392 RVA: 0x0019D006 File Offset: 0x0019B206
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x06007AA1 RID: 31393 RVA: 0x0019D009 File Offset: 0x0019B209
	[NullableContext(2)]
	public ActivityCorniceMeetingData GetCurrentActivityData()
	{
		return ActivityModel.Instance.GetActivityById(this.ActivityId) as ActivityCorniceMeetingData;
	}

	// Token: 0x06007AA2 RID: 31394 RVA: 0x0019D020 File Offset: 0x0019B220
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(mulCorniceMeetingRewardResponse.ErrorCode, 28733, null, true, true);
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

	// Token: 0x06007AA3 RID: 31395 RVA: 0x0019D0E8 File Offset: 0x0019B2E8
	public void CorniceMeetingChallengeTransRequest(int levelPlayId)
	{
		CorniceChallengeTransRequest corniceChallengeTransRequest = CorniceChallengeTransRequest.Create();
		corniceChallengeTransRequest.LevelPlayId = levelPlayId;
		Net.Instance.Call(ERequestMessageId.CorniceChallengeTransRequest, corniceChallengeTransRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			CorniceChallengeTransResponse corniceChallengeTransResponse = (CorniceChallengeTransResponse)msg;
			if (corniceChallengeTransResponse != null && corniceChallengeTransResponse.ErrorCode != ErrorCode.Success && corniceChallengeTransResponse.ErrorCode != ErrorCode.ErrPlayerIsTeleportCanNotDoTeleport)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(corniceChallengeTransResponse.ErrorCode, 29837, null, true, true);
			}
		}, 0);
	}

	// Token: 0x17000A7C RID: 2684
	// (get) Token: 0x06007AA4 RID: 31396 RVA: 0x0019D132 File Offset: 0x0019B332
	public static ActivityCorniceMeetingController Instance
	{
		get
		{
			return ActivityCorniceMeetingController._Instance;
		}
	}

	// Token: 0x06007AA5 RID: 31397 RVA: 0x0019D139 File Offset: 0x0019B339
	public static ActivityCorniceMeetingController GetOrCreateInstance()
	{
		if (ActivityCorniceMeetingController._Instance == null)
		{
			ActivityCorniceMeetingController.CreateInstance();
		}
		return ActivityCorniceMeetingController._Instance;
	}

	// Token: 0x06007AA6 RID: 31398 RVA: 0x0019D14D File Offset: 0x0019B34D
	public static bool CreateInstance()
	{
		if (ActivityCorniceMeetingController._Instance != null)
		{
			return true;
		}
		ActivityCorniceMeetingController._Instance = new ActivityCorniceMeetingController();
		return true;
	}

	// Token: 0x06007AA7 RID: 31399 RVA: 0x0019D163 File Offset: 0x0019B363
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06007AA8 RID: 31400 RVA: 0x0019D165 File Offset: 0x0019B365
	public static void ResetStaticDefaultValue()
	{
		ActivityCorniceMeetingController._Instance = null;
	}

	// Token: 0x06007AA9 RID: 31401 RVA: 0x0019D16D File Offset: 0x0019B36D
	static ActivityCorniceMeetingController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityCorniceMeetingController.CreateStaticDefaultValue), new Action(ActivityCorniceMeetingController.ResetStaticDefaultValue));
	}

	// Token: 0x04003831 RID: 14385
	public int ActivityId;

	// Token: 0x04003832 RID: 14386
	[Nullable(2)]
	private static ActivityCorniceMeetingController _Instance;
}
