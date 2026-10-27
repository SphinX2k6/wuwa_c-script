using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Google.Protobuf;

// Token: 0x020014D2 RID: 5330
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ActivityRunController : ActivityControllerBase
{
	// Token: 0x0600976A RID: 38762 RVA: 0x0020B74E File Offset: 0x0020994E
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return UiManager.Instance.IsViewOpen(EUiViewName.ActivityRunView);
	}

	// Token: 0x0600976B RID: 38763 RVA: 0x0020B75F File Offset: 0x0020995F
	protected override void OnOpenView(ActivityBaseData data)
	{
		UiManager.Instance.OpenView(EUiViewName.ActivityRunView, data, null);
	}

	// Token: 0x0600976C RID: 38764 RVA: 0x0020B772 File Offset: 0x00209972
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_Running";
	}

	// Token: 0x0600976D RID: 38765 RVA: 0x0020B779 File Offset: 0x00209979
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new ActivitySubViewRun();
	}

	// Token: 0x0600976E RID: 38766 RVA: 0x0020B780 File Offset: 0x00209980
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		return new ActivityRun();
	}

	// Token: 0x0600976F RID: 38767 RVA: 0x0020B787 File Offset: 0x00209987
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add<int, IReadOnlyList<int>>(EEventName.OnReceiveActivityData, new Action<int, IReadOnlyList<int>>(this.OnReceiveActivityData));
	}

	// Token: 0x06009770 RID: 38768 RVA: 0x0020B7A5 File Offset: 0x002099A5
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove<int, IReadOnlyList<int>>(EEventName.OnReceiveActivityData, new Action<int, IReadOnlyList<int>>(this.OnReceiveActivityData));
	}

	// Token: 0x06009771 RID: 38769 RVA: 0x0020B7C3 File Offset: 0x002099C3
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.ParkourChallengeOpenNotify, new Action<IMessage, Net.CallbackStatus>(this.OnParkourChallengeOpenNotify));
		Net.Instance.Register(ENotifyMessageId.ParkourChallengeEndNotify, new Action<IMessage, Net.CallbackStatus>(this.OnParkourChallengeEndNotify));
	}

	// Token: 0x06009772 RID: 38770 RVA: 0x0020B7FD File Offset: 0x002099FD
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.ParkourChallengeOpenNotify);
		Net.Instance.UnRegister(ENotifyMessageId.ParkourChallengeEndNotify);
	}

	// Token: 0x06009773 RID: 38771 RVA: 0x0020B820 File Offset: 0x00209A20
	public void SelectDefaultChallengeId(ActivityBaseData baseData)
	{
		int defaultOpenUiChallengeIndex = ActivityRunModel.Instance.GetDefaultOpenUiChallengeIndex(baseData);
		ActivityRunModel.Instance.SetStartViewSelectIndex(defaultOpenUiChallengeIndex);
	}

	// Token: 0x06009774 RID: 38772 RVA: 0x0020B844 File Offset: 0x00209A44
	private void RequestChallengeInfo()
	{
		ParkourChallengeRequest message = ParkourChallengeRequest.Create();
		Net.Instance.Call(ERequestMessageId.ParkourChallengeRequest, message, delegate(IMessage msg, Net.CallbackStatus _)
		{
			ParkourChallengeResponse data = (ParkourChallengeResponse)msg;
			ActivityRunModel.Instance.OnReceiveMessageData(data);
		}, 0);
	}

	// Token: 0x06009775 RID: 38773 RVA: 0x0020B888 File Offset: 0x00209A88
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(parkourChallengeTakeResponse.ErrorCode, 23450, null, true, true);
				return;
			}
			ActivityRunModel.Instance.OnGetChallengeReward(challengeId, scoreIndex);
		}, 0);
	}

	// Token: 0x06009776 RID: 38774 RVA: 0x0020B8E4 File Offset: 0x00209AE4
	[NullableContext(2)]
	private void OnParkourChallengeOpenNotify(IMessage msg, Net.CallbackStatus _)
	{
		ParkourChallengeOpenNotify message = (ParkourChallengeOpenNotify)msg;
		ActivityRunModel.Instance.OnReceiveChallengeOpenNotify(message);
	}

	// Token: 0x06009777 RID: 38775 RVA: 0x0020B904 File Offset: 0x00209B04
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

	// Token: 0x06009778 RID: 38776 RVA: 0x0020B9BC File Offset: 0x00209BBC
	public void RequestTransToParkourChallenge(int challengeId)
	{
		ParkourChallengeTransRequest parkourChallengeTransRequest = ParkourChallengeTransRequest.Create();
		parkourChallengeTransRequest.ChallengeId = challengeId;
		Net.Instance.Call(ERequestMessageId.ParkourChallengeTransRequest, parkourChallengeTransRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			ParkourChallengeTransResponse parkourChallengeTransResponse = (ParkourChallengeTransResponse)msg;
			if (parkourChallengeTransResponse.ErrorCode != ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(parkourChallengeTransResponse.ErrorCode, 23607, null, true, true);
				return;
			}
			UiManager.Instance.CloseView(EUiViewName.ActivityRunSuccessView, null);
			UiManager.Instance.CloseView(EUiViewName.ActivityRunFailView, null);
		}, 0);
	}

	// Token: 0x06009779 RID: 38777 RVA: 0x0020BA06 File Offset: 0x00209C06
	private void OnReceiveActivityData(int type, IReadOnlyList<int> activityIds)
	{
		if (type == 0)
		{
			this.RequestChallengeInfo();
		}
	}

	// Token: 0x17000D11 RID: 3345
	// (get) Token: 0x0600977A RID: 38778 RVA: 0x0020BA11 File Offset: 0x00209C11
	public static ActivityRunController Instance
	{
		get
		{
			return ActivityRunController._Instance;
		}
	}

	// Token: 0x0600977B RID: 38779 RVA: 0x0020BA18 File Offset: 0x00209C18
	public static ActivityRunController GetOrCreateInstance()
	{
		if (ActivityRunController._Instance == null)
		{
			ActivityRunController.CreateInstance();
		}
		return ActivityRunController._Instance;
	}

	// Token: 0x0600977C RID: 38780 RVA: 0x0020BA2C File Offset: 0x00209C2C
	public static bool CreateInstance()
	{
		if (ActivityRunController._Instance != null)
		{
			return true;
		}
		ActivityRunController._Instance = new ActivityRunController();
		return true;
	}

	// Token: 0x0600977D RID: 38781 RVA: 0x0020BA42 File Offset: 0x00209C42
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600977E RID: 38782 RVA: 0x0020BA44 File Offset: 0x00209C44
	public static void ResetStaticDefaultValue()
	{
		ActivityRunController._Instance = null;
	}

	// Token: 0x0600977F RID: 38783 RVA: 0x0020BA4C File Offset: 0x00209C4C
	static ActivityRunController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityRunController.CreateStaticDefaultValue), new Action(ActivityRunController.ResetStaticDefaultValue));
	}

	// Token: 0x040042AC RID: 17068
	[Nullable(2)]
	private static ActivityRunController _Instance;
}
