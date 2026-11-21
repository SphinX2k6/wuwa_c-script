using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Google.Protobuf;

// Token: 0x0200098A RID: 2442
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ActivityRunController : ActivityControllerBase
{
	// Token: 0x06006B44 RID: 27460 RVA: 0x0021548E File Offset: 0x0021368E
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return UiManager.Instance.IsViewOpen(EUiViewName.ActivityRunView);
	}

	// Token: 0x06006B45 RID: 27461 RVA: 0x0021549F File Offset: 0x0021369F
	protected override void OnOpenView(ActivityBaseData data)
	{
		UiManager.Instance.OpenView(EUiViewName.ActivityRunView, data, null);
	}

	// Token: 0x06006B46 RID: 27462 RVA: 0x002154B2 File Offset: 0x002136B2
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_Running";
	}

	// Token: 0x06006B47 RID: 27463 RVA: 0x002154B9 File Offset: 0x002136B9
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new ActivitySubViewRun();
	}

	// Token: 0x06006B48 RID: 27464 RVA: 0x002154C0 File Offset: 0x002136C0
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		return new ActivityRun();
	}

	// Token: 0x06006B49 RID: 27465 RVA: 0x002154C7 File Offset: 0x002136C7
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add<int, IReadOnlyList<int>>(EEventName.OnReceiveActivityData, new Action<int, IReadOnlyList<int>>(this.OnReceiveActivityData));
	}

	// Token: 0x06006B4A RID: 27466 RVA: 0x002154E5 File Offset: 0x002136E5
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove<int, IReadOnlyList<int>>(EEventName.OnReceiveActivityData, new Action<int, IReadOnlyList<int>>(this.OnReceiveActivityData));
	}

	// Token: 0x06006B4B RID: 27467 RVA: 0x00215503 File Offset: 0x00213703
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.ParkourChallengeOpenNotify, new Action<IMessage, Net.CallbackStatus>(this.OnParkourChallengeOpenNotify));
		Net.Instance.Register(ENotifyMessageId.ParkourChallengeEndNotify, new Action<IMessage, Net.CallbackStatus>(this.OnParkourChallengeEndNotify));
	}

	// Token: 0x06006B4C RID: 27468 RVA: 0x0021553D File Offset: 0x0021373D
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.ParkourChallengeOpenNotify);
		Net.Instance.UnRegister(ENotifyMessageId.ParkourChallengeEndNotify);
	}

	// Token: 0x06006B4D RID: 27469 RVA: 0x00215560 File Offset: 0x00213760
	public void SelectDefaultChallengeId(ActivityBaseData baseData)
	{
		int defaultOpenUiChallengeIndex = ActivityRunModel.Instance.GetDefaultOpenUiChallengeIndex(baseData);
		ActivityRunModel.Instance.SetStartViewSelectIndex(defaultOpenUiChallengeIndex);
	}

	// Token: 0x06006B4E RID: 27470 RVA: 0x00215584 File Offset: 0x00213784
	private void RequestChallengeInfo()
	{
		ParkourChallengeRequest message = ParkourChallengeRequest.Create();
		Net.Instance.Call(ERequestMessageId.ParkourChallengeRequest, message, delegate(IMessage msg, Net.CallbackStatus _)
		{
			ParkourChallengeResponse data = (ParkourChallengeResponse)msg;
			ActivityRunModel.Instance.OnReceiveMessageData(data);
		}, 0);
	}

	// Token: 0x06006B4F RID: 27471 RVA: 0x002155C8 File Offset: 0x002137C8
	public void RequestTakeChallengeReward(int challengeId, int scoreIndex)
	{
		ParkourChallengeTakeRequest parkourChallengeTakeRequest = ParkourChallengeTakeRequest.Create();
		parkourChallengeTakeRequest.ChallengeId = challengeId;
		parkourChallengeTakeRequest.ScoreIndex = scoreIndex;
		Net.Instance.Call(ERequestMessageId.ParkourChallengeTakeRequest, parkourChallengeTakeRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			ParkourChallengeTakeResponse parkourChallengeTakeResponse = (ParkourChallengeTakeResponse)msg;
			if (parkourChallengeTakeResponse.ErrorCode != ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(parkourChallengeTakeResponse.ErrorCode, 21667, null, true, true);
				return;
			}
			ActivityRunModel.Instance.OnGetChallengeReward(challengeId, scoreIndex);
		}, 0);
	}

	// Token: 0x06006B50 RID: 27472 RVA: 0x00215624 File Offset: 0x00213824
	[NullableContext(2)]
	private void OnParkourChallengeOpenNotify(IMessage msg, Net.CallbackStatus _)
	{
		ParkourChallengeOpenNotify message = (ParkourChallengeOpenNotify)msg;
		ActivityRunModel.Instance.OnReceiveChallengeOpenNotify(message);
	}

	// Token: 0x06006B51 RID: 27473 RVA: 0x00215644 File Offset: 0x00213844
	[NullableContext(2)]
	private void OnParkourChallengeEndNotify(IMessage msg, Net.CallbackStatus _)
	{
		ParkourChallengeEndNotify parkourChallengeEndNotify = (ParkourChallengeEndNotify)msg;
		if (!parkourChallengeEndNotify.IsComplete)
		{
			RunEndData runEndData = new RunEndData();
			runEndData.Phrase(parkourChallengeEndNotify);
			UiManager.Instance.OpenView(EUiViewName.ActivityRunFailView, runEndData, null);
			return;
		}
		ActivityRunData activityRunData = ActivityRunModel.Instance.GetActivityRunData(parkourChallengeEndNotify.ChallengeId);
		if (activityRunData == null)
		{
			return;
		}
		int miniTime = activityRunData.GetMiniTime();
		int maxScore = activityRunData.GetMaxScore();
		activityRunData.OnChallengeEnd(parkourChallengeEndNotify);
		int miniTime2 = activityRunData.GetMiniTime();
		int maxScore2 = activityRunData.GetMaxScore();
		bool ifNewRecord = false;
		if (miniTime2 < miniTime || maxScore < maxScore2 || miniTime == 0)
		{
			ifNewRecord = true;
		}
		RunEndData runEndData2 = new RunEndData();
		runEndData2.Phrase(parkourChallengeEndNotify);
		runEndData2.SetIfNewRecord(ifNewRecord);
		UiManager.Instance.OpenView(EUiViewName.ActivityRunSuccessView, runEndData2, null);
	}

	// Token: 0x06006B52 RID: 27474 RVA: 0x002156FC File Offset: 0x002138FC
	public void RequestTransToParkourChallenge(int challengeId)
	{
		ParkourChallengeTransRequest parkourChallengeTransRequest = ParkourChallengeTransRequest.Create();
		parkourChallengeTransRequest.ChallengeId = challengeId;
		Net.Instance.Call(ERequestMessageId.ParkourChallengeTransRequest, parkourChallengeTransRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			ParkourChallengeTransResponse parkourChallengeTransResponse = (ParkourChallengeTransResponse)msg;
			if (parkourChallengeTransResponse.ErrorCode != ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(parkourChallengeTransResponse.ErrorCode, 16542, null, true, true);
				return;
			}
			UiManager.Instance.CloseView(EUiViewName.ActivityRunSuccessView, null);
			UiManager.Instance.CloseView(EUiViewName.ActivityRunFailView, null);
		}, 0);
	}

	// Token: 0x06006B53 RID: 27475 RVA: 0x00215746 File Offset: 0x00213946
	private void OnReceiveActivityData(int type, IReadOnlyList<int> activityIds)
	{
		if (type == 0)
		{
			this.RequestChallengeInfo();
		}
	}

	// Token: 0x17000D32 RID: 3378
	// (get) Token: 0x06006B54 RID: 27476 RVA: 0x00215751 File Offset: 0x00213951
	public static ActivityRunController Instance
	{
		get
		{
			return ActivityRunController._Instance;
		}
	}

	// Token: 0x06006B55 RID: 27477 RVA: 0x00215758 File Offset: 0x00213958
	public static ActivityRunController GetOrCreateInstance()
	{
		if (ActivityRunController._Instance == null)
		{
			ActivityRunController.CreateInstance();
		}
		return ActivityRunController._Instance;
	}

	// Token: 0x06006B56 RID: 27478 RVA: 0x0021576C File Offset: 0x0021396C
	public static bool CreateInstance()
	{
		if (ActivityRunController._Instance != null)
		{
			return true;
		}
		ActivityRunController._Instance = new ActivityRunController();
		return true;
	}

	// Token: 0x06006B57 RID: 27479 RVA: 0x00215782 File Offset: 0x00213982
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06006B58 RID: 27480 RVA: 0x00215784 File Offset: 0x00213984
	public static void ResetStaticDefaultValue()
	{
		ActivityRunController._Instance = null;
	}

	// Token: 0x06006B59 RID: 27481 RVA: 0x0021578C File Offset: 0x0021398C
	static ActivityRunController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityRunController.CreateStaticDefaultValue), new Action(ActivityRunController.ResetStaticDefaultValue));
	}

	// Token: 0x04004351 RID: 17233
	[Nullable(2)]
	private static ActivityRunController _Instance;
}
