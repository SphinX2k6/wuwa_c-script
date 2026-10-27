using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

// Token: 0x02002D2C RID: 11564
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class WeeklyChallengeController : UiControllerBase
{
	// Token: 0x060184EE RID: 99566 RVA: 0x00630334 File Offset: 0x0062E534
	protected override bool OnInit()
	{
		return true;
	}

	// Token: 0x060184EF RID: 99567 RVA: 0x00630337 File Offset: 0x0062E537
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.WeeklyFrameworkInfoUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnReceiveWeeklyFrameworkUpdateNotify));
	}

	// Token: 0x060184F0 RID: 99568 RVA: 0x00630355 File Offset: 0x0062E555
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.WeeklyFrameworkInfoUpdateNotify);
	}

	// Token: 0x060184F1 RID: 99569 RVA: 0x00630367 File Offset: 0x0062E567
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.OnLoadingNetDataDone, new Action(this.OnLoadingNetDataDone));
	}

	// Token: 0x060184F2 RID: 99570 RVA: 0x00630385 File Offset: 0x0062E585
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OnLoadingNetDataDone, new Action(this.OnLoadingNetDataDone));
	}

	// Token: 0x060184F3 RID: 99571 RVA: 0x006303A3 File Offset: 0x0062E5A3
	private void OnLoadingNetDataDone()
	{
		WeeklyChallengeModel.Instance.InitGoalData();
		this.RequestWeeklyFrameworkInfo().Forget<bool>();
	}

	// Token: 0x060184F4 RID: 99572 RVA: 0x006303BC File Offset: 0x0062E5BC
	[NullableContext(0)]
	public UniTask<bool> RequestWeeklyFrameworkInfo()
	{
		WeeklyChallengeController.<RequestWeeklyFrameworkInfo>d__6 <RequestWeeklyFrameworkInfo>d__;
		<RequestWeeklyFrameworkInfo>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<RequestWeeklyFrameworkInfo>d__.<>1__state = -1;
		<RequestWeeklyFrameworkInfo>d__.<>t__builder.Start<WeeklyChallengeController.<RequestWeeklyFrameworkInfo>d__6>(ref <RequestWeeklyFrameworkInfo>d__);
		return <RequestWeeklyFrameworkInfo>d__.<>t__builder.Task;
	}

	// Token: 0x060184F5 RID: 99573 RVA: 0x006303F8 File Offset: 0x0062E5F8
	public void RequestWeeklyFrameworkScoreReward(List<int> taskIds)
	{
		WeeklyChallengeController.<>c__DisplayClass7_0 CS$<>8__locals1 = new WeeklyChallengeController.<>c__DisplayClass7_0();
		CS$<>8__locals1.taskIds = taskIds;
		WeeklyFrameworkScoreRewardRequest weeklyFrameworkScoreRewardRequest = WeeklyFrameworkScoreRewardRequest.Create();
		weeklyFrameworkScoreRewardRequest.TaskIds.AddRange(CS$<>8__locals1.taskIds);
		Net.Instance.Call(ERequestMessageId.WeeklyFrameworkScoreRewardRequest, weeklyFrameworkScoreRewardRequest, new Action<IMessage, Net.CallbackStatus>(CS$<>8__locals1.<RequestWeeklyFrameworkScoreReward>g__ResponseAction|0), 0);
	}

	// Token: 0x060184F6 RID: 99574 RVA: 0x00630448 File Offset: 0x0062E648
	[NullableContext(2)]
	private void OnReceiveWeeklyFrameworkUpdateNotify(IMessage msg, Net.CallbackStatus _)
	{
		WeeklyFrameworkInfoUpdateNotify weeklyFrameworkInfoUpdateNotify = (WeeklyFrameworkInfoUpdateNotify)msg;
		WeeklyChallengeModel.Instance.RefreshData(weeklyFrameworkInfoUpdateNotify.FrameworkInfo);
	}

	// Token: 0x170020C5 RID: 8389
	// (get) Token: 0x060184F7 RID: 99575 RVA: 0x0063046C File Offset: 0x0062E66C
	public static WeeklyChallengeController Instance
	{
		get
		{
			return WeeklyChallengeController._Instance;
		}
	}

	// Token: 0x060184F8 RID: 99576 RVA: 0x00630473 File Offset: 0x0062E673
	public static WeeklyChallengeController GetOrCreateInstance()
	{
		if (WeeklyChallengeController._Instance == null)
		{
			WeeklyChallengeController.CreateInstance();
		}
		return WeeklyChallengeController._Instance;
	}

	// Token: 0x060184F9 RID: 99577 RVA: 0x00630487 File Offset: 0x0062E687
	public static bool CreateInstance()
	{
		if (WeeklyChallengeController._Instance != null)
		{
			return true;
		}
		WeeklyChallengeController._Instance = new WeeklyChallengeController();
		return true;
	}

	// Token: 0x060184FA RID: 99578 RVA: 0x0063049D File Offset: 0x0062E69D
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060184FB RID: 99579 RVA: 0x0063049F File Offset: 0x0062E69F
	public static void ResetStaticDefaultValue()
	{
		WeeklyChallengeController._Instance = null;
	}

	// Token: 0x060184FC RID: 99580 RVA: 0x006304A7 File Offset: 0x0062E6A7
	static WeeklyChallengeController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(WeeklyChallengeController.CreateStaticDefaultValue), new Action(WeeklyChallengeController.ResetStaticDefaultValue));
	}

	// Token: 0x0400B489 RID: 46217
	[Nullable(2)]
	private static WeeklyChallengeController _Instance;
}
