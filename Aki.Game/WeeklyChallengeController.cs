using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

// Token: 0x02002286 RID: 8838
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class WeeklyChallengeController : UiControllerBase
{
	// Token: 0x06015D90 RID: 89488 RVA: 0x00656348 File Offset: 0x00654548
	protected override bool OnInit()
	{
		return true;
	}

	// Token: 0x06015D91 RID: 89489 RVA: 0x0065634B File Offset: 0x0065454B
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.WeeklyFrameworkInfoUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnReceiveWeeklyFrameworkUpdateNotify));
	}

	// Token: 0x06015D92 RID: 89490 RVA: 0x00656369 File Offset: 0x00654569
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.WeeklyFrameworkInfoUpdateNotify);
	}

	// Token: 0x06015D93 RID: 89491 RVA: 0x0065637B File Offset: 0x0065457B
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.OnLoadingNetDataDone, new Action(this.OnLoadingNetDataDone));
	}

	// Token: 0x06015D94 RID: 89492 RVA: 0x00656399 File Offset: 0x00654599
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OnLoadingNetDataDone, new Action(this.OnLoadingNetDataDone));
	}

	// Token: 0x06015D95 RID: 89493 RVA: 0x006563B7 File Offset: 0x006545B7
	private void OnLoadingNetDataDone()
	{
		WeeklyChallengeModel.Instance.InitGoalData();
		this.RequestWeeklyFrameworkInfo().Forget<bool>();
	}

	// Token: 0x06015D96 RID: 89494 RVA: 0x006563D0 File Offset: 0x006545D0
	[NullableContext(0)]
	public UniTask<bool> RequestWeeklyFrameworkInfo()
	{
		WeeklyChallengeController.<RequestWeeklyFrameworkInfo>d__6 <RequestWeeklyFrameworkInfo>d__;
		<RequestWeeklyFrameworkInfo>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<RequestWeeklyFrameworkInfo>d__.<>1__state = -1;
		<RequestWeeklyFrameworkInfo>d__.<>t__builder.Start<WeeklyChallengeController.<RequestWeeklyFrameworkInfo>d__6>(ref <RequestWeeklyFrameworkInfo>d__);
		return <RequestWeeklyFrameworkInfo>d__.<>t__builder.Task;
	}

	// Token: 0x06015D97 RID: 89495 RVA: 0x0065640C File Offset: 0x0065460C
	public void RequestWeeklyFrameworkScoreReward(List<int> taskIds)
	{
		WeeklyChallengeController.<>c__DisplayClass7_0 CS$<>8__locals1 = new WeeklyChallengeController.<>c__DisplayClass7_0();
		CS$<>8__locals1.taskIds = taskIds;
		WeeklyFrameworkScoreRewardRequest weeklyFrameworkScoreRewardRequest = WeeklyFrameworkScoreRewardRequest.Create();
		weeklyFrameworkScoreRewardRequest.TaskIds.AddRange(CS$<>8__locals1.taskIds);
		Net.Instance.Call(ERequestMessageId.WeeklyFrameworkScoreRewardRequest, weeklyFrameworkScoreRewardRequest, new Action<IMessage, Net.CallbackStatus>(CS$<>8__locals1.<RequestWeeklyFrameworkScoreReward>g__ResponseAction|0), 0);
	}

	// Token: 0x06015D98 RID: 89496 RVA: 0x0065645C File Offset: 0x0065465C
	[NullableContext(2)]
	private void OnReceiveWeeklyFrameworkUpdateNotify(IMessage msg, Net.CallbackStatus _)
	{
		WeeklyFrameworkInfoUpdateNotify weeklyFrameworkInfoUpdateNotify = (WeeklyFrameworkInfoUpdateNotify)msg;
		WeeklyChallengeModel.Instance.RefreshData(weeklyFrameworkInfoUpdateNotify.FrameworkInfo);
	}

	// Token: 0x17002120 RID: 8480
	// (get) Token: 0x06015D99 RID: 89497 RVA: 0x00656480 File Offset: 0x00654680
	public static WeeklyChallengeController Instance
	{
		get
		{
			return WeeklyChallengeController._Instance;
		}
	}

	// Token: 0x06015D9A RID: 89498 RVA: 0x00656487 File Offset: 0x00654687
	public static WeeklyChallengeController GetOrCreateInstance()
	{
		if (WeeklyChallengeController._Instance == null)
		{
			WeeklyChallengeController.CreateInstance();
		}
		return WeeklyChallengeController._Instance;
	}

	// Token: 0x06015D9B RID: 89499 RVA: 0x0065649B File Offset: 0x0065469B
	public static bool CreateInstance()
	{
		if (WeeklyChallengeController._Instance != null)
		{
			return true;
		}
		WeeklyChallengeController._Instance = new WeeklyChallengeController();
		return true;
	}

	// Token: 0x06015D9C RID: 89500 RVA: 0x006564B1 File Offset: 0x006546B1
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06015D9D RID: 89501 RVA: 0x006564B3 File Offset: 0x006546B3
	public static void ResetStaticDefaultValue()
	{
		WeeklyChallengeController._Instance = null;
	}

	// Token: 0x06015D9E RID: 89502 RVA: 0x006564BB File Offset: 0x006546BB
	static WeeklyChallengeController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(WeeklyChallengeController.CreateStaticDefaultValue), new Action(WeeklyChallengeController.ResetStaticDefaultValue));
	}

	// Token: 0x0400B7FE RID: 47102
	[Nullable(2)]
	private static WeeklyChallengeController _Instance;
}
