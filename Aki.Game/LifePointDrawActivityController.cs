using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

// Token: 0x02001292 RID: 4754
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class LifePointDrawActivityController : ActivityControllerBase
{
	// Token: 0x060081FD RID: 33277 RVA: 0x001B90B8 File Offset: 0x001B72B8
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x060081FE RID: 33278 RVA: 0x001B90BA File Offset: 0x001B72BA
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_ActivityColorfulMain";
	}

	// Token: 0x060081FF RID: 33279 RVA: 0x001B90C1 File Offset: 0x001B72C1
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new LifePointSubView();
	}

	// Token: 0x06008200 RID: 33280 RVA: 0x001B90C8 File Offset: 0x001B72C8
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		return new LifePointDrawActivityData();
	}

	// Token: 0x06008201 RID: 33281 RVA: 0x001B90CF File Offset: 0x001B72CF
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x06008202 RID: 33282 RVA: 0x001B90D2 File Offset: 0x001B72D2
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.LifePointChallengeUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnLifePointUpdate));
	}

	// Token: 0x06008203 RID: 33283 RVA: 0x001B90F0 File Offset: 0x001B72F0
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.LifePointChallengeUpdateNotify);
	}

	// Token: 0x06008204 RID: 33284 RVA: 0x001B9102 File Offset: 0x001B7302
	[NullableContext(2)]
	private LifePointDrawActivityData GetActivityDataById(int id)
	{
		if (ActivityModel.Instance.GetActivityById(id) == null)
		{
			return null;
		}
		return ActivityModel.Instance.GetActivityById(id) as LifePointDrawActivityData;
	}

	// Token: 0x06008205 RID: 33285 RVA: 0x001B9124 File Offset: 0x001B7324
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

	// Token: 0x06008206 RID: 33286 RVA: 0x001B929C File Offset: 0x001B749C
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(lifePointChallengeStartResponse.ErrorCode, 29239, null, true, true);
			}
		}, 0);
	}

	// Token: 0x06008207 RID: 33287 RVA: 0x001B92FC File Offset: 0x001B74FC
	[NullableContext(0)]
	public UniTask<bool> OpenLifePointDrawActivityView()
	{
		LifePointDrawActivityController.<OpenLifePointDrawActivityView>d__10 <OpenLifePointDrawActivityView>d__;
		<OpenLifePointDrawActivityView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<OpenLifePointDrawActivityView>d__.<>1__state = -1;
		<OpenLifePointDrawActivityView>d__.<>t__builder.Start<LifePointDrawActivityController.<OpenLifePointDrawActivityView>d__10>(ref <OpenLifePointDrawActivityView>d__);
		return <OpenLifePointDrawActivityView>d__.<>t__builder.Task;
	}

	// Token: 0x17000B2C RID: 2860
	// (get) Token: 0x06008208 RID: 33288 RVA: 0x001B9337 File Offset: 0x001B7537
	public static LifePointDrawActivityController Instance
	{
		get
		{
			return LifePointDrawActivityController._Instance;
		}
	}

	// Token: 0x06008209 RID: 33289 RVA: 0x001B933E File Offset: 0x001B753E
	public static LifePointDrawActivityController GetOrCreateInstance()
	{
		if (LifePointDrawActivityController._Instance == null)
		{
			LifePointDrawActivityController.CreateInstance();
		}
		return LifePointDrawActivityController._Instance;
	}

	// Token: 0x0600820A RID: 33290 RVA: 0x001B9352 File Offset: 0x001B7552
	public static bool CreateInstance()
	{
		if (LifePointDrawActivityController._Instance != null)
		{
			return true;
		}
		LifePointDrawActivityController._Instance = new LifePointDrawActivityController();
		return true;
	}

	// Token: 0x0600820B RID: 33291 RVA: 0x001B9368 File Offset: 0x001B7568
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600820C RID: 33292 RVA: 0x001B936A File Offset: 0x001B756A
	public static void ResetStaticDefaultValue()
	{
		LifePointDrawActivityController._Instance = null;
	}

	// Token: 0x0600820D RID: 33293 RVA: 0x001B9372 File Offset: 0x001B7572
	static LifePointDrawActivityController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(LifePointDrawActivityController.CreateStaticDefaultValue), new Action(LifePointDrawActivityController.ResetStaticDefaultValue));
	}

	// Token: 0x04003AD1 RID: 15057
	[Nullable(2)]
	private static LifePointDrawActivityController _Instance;
}
