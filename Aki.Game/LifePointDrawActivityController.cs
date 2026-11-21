using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

// Token: 0x02000746 RID: 1862
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class LifePointDrawActivityController : ActivityControllerBase
{
	// Token: 0x06005594 RID: 21908 RVA: 0x001C1D88 File Offset: 0x001BFF88
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x06005595 RID: 21909 RVA: 0x001C1D8A File Offset: 0x001BFF8A
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_ActivityColorfulMain";
	}

	// Token: 0x06005596 RID: 21910 RVA: 0x001C1D91 File Offset: 0x001BFF91
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new LifePointSubView();
	}

	// Token: 0x06005597 RID: 21911 RVA: 0x001C1D98 File Offset: 0x001BFF98
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		return new LifePointDrawActivityData();
	}

	// Token: 0x06005598 RID: 21912 RVA: 0x001C1D9F File Offset: 0x001BFF9F
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x06005599 RID: 21913 RVA: 0x001C1DA2 File Offset: 0x001BFFA2
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.LifePointChallengeUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnLifePointUpdate));
	}

	// Token: 0x0600559A RID: 21914 RVA: 0x001C1DC0 File Offset: 0x001BFFC0
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.LifePointChallengeUpdateNotify);
	}

	// Token: 0x0600559B RID: 21915 RVA: 0x001C1DD2 File Offset: 0x001BFFD2
	[NullableContext(2)]
	private LifePointDrawActivityData GetActivityDataById(int id)
	{
		if (ActivityModel.Instance.GetActivityById(id) == null)
		{
			return null;
		}
		return ActivityModel.Instance.GetActivityById(id) as LifePointDrawActivityData;
	}

	// Token: 0x0600559C RID: 21916 RVA: 0x001C1DF4 File Offset: 0x001BFFF4
	[NullableContext(2)]
	private void OnLifePointUpdate(IMessage msg, Net.CallbackStatus _)
	{
		LifePointChallengeUpdateNotify lifePointChallengeUpdateNotify = (LifePointChallengeUpdateNotify)msg;
		List<int> list = new List<int>();
		List<int> list2 = new List<int>();
		foreach (LifePointChallengeData lifePointChallengeData in lifePointChallengeUpdateNotify.Challenges)
		{
			LifePointChallenge value = LifePointDrawConfig.Instance.GetLifePointChallengeById(lifePointChallengeData.ChallengeId).Value;
			LifePointDrawActivityData activityDataById = this.GetActivityDataById(value.ActivityId);
			if (activityDataById != null)
			{
				activityDataById.OnLifePointChallengeDataUpdate(lifePointChallengeData);
				EventSystem.Instance.Emit<int>(EEventName.RefreshLifePointDrawChallengeRedDot, lifePointChallengeData.ChallengeId);
			}
			if (!list2.Contains(value.GroupId))
			{
				list2.Add(value.GroupId);
			}
			if (!list.Contains(value.ActivityId))
			{
				list.Add(value.ActivityId);
			}
		}
		foreach (int p in list)
		{
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, p);
		}
		foreach (int p2 in list2)
		{
			EventSystem.Instance.Emit<int>(EEventName.RefreshLifePointDrawGroupRedDot, p2);
		}
	}

	// Token: 0x0600559D RID: 21917 RVA: 0x001C1F6C File Offset: 0x001C016C
	public void RequestStartChallenge(int activityId, int challengeId)
	{
		LifePointChallengeStartRequest lifePointChallengeStartRequest = LifePointChallengeStartRequest.Create();
		lifePointChallengeStartRequest.Id = challengeId;
		LifePointDrawModel.Instance.CurrentChallengeFinishState = LifePointDrawModel.Instance.GetChallengeFinishState(activityId, challengeId);
		Net.Instance.Call(ERequestMessageId.LifePointChallengeStartRequest, lifePointChallengeStartRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			LifePointChallengeStartResponse lifePointChallengeStartResponse = (LifePointChallengeStartResponse)msg;
			if (lifePointChallengeStartResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(lifePointChallengeStartResponse.ErrorCode, 22206, null, true, true);
			}
		}, 0);
	}

	// Token: 0x0600559E RID: 21918 RVA: 0x001C1FCC File Offset: 0x001C01CC
	[NullableContext(0)]
	public UniTask<bool> OpenLifePointDrawActivityView()
	{
		LifePointDrawActivityController.<OpenLifePointDrawActivityView>d__10 <OpenLifePointDrawActivityView>d__;
		<OpenLifePointDrawActivityView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<OpenLifePointDrawActivityView>d__.<>1__state = -1;
		<OpenLifePointDrawActivityView>d__.<>t__builder.Start<LifePointDrawActivityController.<OpenLifePointDrawActivityView>d__10>(ref <OpenLifePointDrawActivityView>d__);
		return <OpenLifePointDrawActivityView>d__.<>t__builder.Task;
	}

	// Token: 0x17000B4C RID: 2892
	// (get) Token: 0x0600559F RID: 21919 RVA: 0x001C2007 File Offset: 0x001C0207
	public static LifePointDrawActivityController Instance
	{
		get
		{
			return LifePointDrawActivityController._Instance;
		}
	}

	// Token: 0x060055A0 RID: 21920 RVA: 0x001C200E File Offset: 0x001C020E
	public static LifePointDrawActivityController GetOrCreateInstance()
	{
		if (LifePointDrawActivityController._Instance == null)
		{
			LifePointDrawActivityController.CreateInstance();
		}
		return LifePointDrawActivityController._Instance;
	}

	// Token: 0x060055A1 RID: 21921 RVA: 0x001C2022 File Offset: 0x001C0222
	public static bool CreateInstance()
	{
		if (LifePointDrawActivityController._Instance != null)
		{
			return true;
		}
		LifePointDrawActivityController._Instance = new LifePointDrawActivityController();
		return true;
	}

	// Token: 0x060055A2 RID: 21922 RVA: 0x001C2038 File Offset: 0x001C0238
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060055A3 RID: 21923 RVA: 0x001C203A File Offset: 0x001C023A
	public static void ResetStaticDefaultValue()
	{
		LifePointDrawActivityController._Instance = null;
	}

	// Token: 0x060055A4 RID: 21924 RVA: 0x001C2042 File Offset: 0x001C0242
	static LifePointDrawActivityController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(LifePointDrawActivityController.CreateStaticDefaultValue), new Action(LifePointDrawActivityController.ResetStaticDefaultValue));
	}

	// Token: 0x04003B69 RID: 15209
	[Nullable(2)]
	private static LifePointDrawActivityController _Instance;
}
