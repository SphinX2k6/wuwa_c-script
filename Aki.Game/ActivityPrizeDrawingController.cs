using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.PrizeDrawing;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02001432 RID: 5170
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ActivityPrizeDrawingController : ActivityControllerBase
{
	// Token: 0x17000CC9 RID: 3273
	// (get) Token: 0x060091F0 RID: 37360 RVA: 0x001F3285 File Offset: 0x001F1485
	[Nullable(2)]
	public ActivityPrizeDrawingData ActivityData
	{
		[NullableContext(2)]
		get
		{
			return ActivityModel.Instance.GetActivityById(this.ActivityId) as ActivityPrizeDrawingData;
		}
	}

	// Token: 0x060091F1 RID: 37361 RVA: 0x001F329C File Offset: 0x001F149C
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x060091F2 RID: 37362 RVA: 0x001F329E File Offset: 0x001F149E
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_PrizeDrawingActivity";
	}

	// Token: 0x060091F3 RID: 37363 RVA: 0x001F32A5 File Offset: 0x001F14A5
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new ActivityPrizeDrawingSubView();
	}

	// Token: 0x060091F4 RID: 37364 RVA: 0x001F32AC File Offset: 0x001F14AC
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		this.ActivityId = data.Id;
		return new ActivityPrizeDrawingData();
	}

	// Token: 0x060091F5 RID: 37365 RVA: 0x001F32BF File Offset: 0x001F14BF
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x060091F6 RID: 37366 RVA: 0x001F32C2 File Offset: 0x001F14C2
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add<int, QuestState, EQuestStatusUpdateReason>(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.OnQuestStateChanged));
		EventSystem.Instance.Add<TQuest>(EEventName.OnAddNewQuest, new Action<TQuest>(this.OnAddNewQuest));
	}

	// Token: 0x060091F7 RID: 37367 RVA: 0x001F32FC File Offset: 0x001F14FC
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove<int, QuestState, EQuestStatusUpdateReason>(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.OnQuestStateChanged));
		EventSystem.Instance.Remove<TQuest>(EEventName.OnAddNewQuest, new Action<TQuest>(this.OnAddNewQuest));
	}

	// Token: 0x060091F8 RID: 37368 RVA: 0x001F3338 File Offset: 0x001F1538
	[NullableContext(0)]
	protected override UniTask<bool> OnOpenSubView(EUiViewName viewName, int activityId = 0)
	{
		ActivityPrizeDrawingController.<OnOpenSubView>d__10 <OnOpenSubView>d__;
		<OnOpenSubView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<OnOpenSubView>d__.<>4__this = this;
		<OnOpenSubView>d__.viewName = viewName;
		<OnOpenSubView>d__.<>1__state = -1;
		<OnOpenSubView>d__.<>t__builder.Start<ActivityPrizeDrawingController.<OnOpenSubView>d__10>(ref <OnOpenSubView>d__);
		return <OnOpenSubView>d__.<>t__builder.Task;
	}

	// Token: 0x060091F9 RID: 37369 RVA: 0x001F3383 File Offset: 0x001F1583
	private void OnQuestStateChanged(int questId, QuestState state, EQuestStatusUpdateReason reason)
	{
		if (state != QuestState.Finish)
		{
			return;
		}
		ActivityPrizeDrawingData activityData = this.ActivityData;
		if (activityData == null)
		{
			return;
		}
		activityData.QuestCompletedNotify(questId);
	}

	// Token: 0x060091FA RID: 37370 RVA: 0x001F339C File Offset: 0x001F159C
	private void OnAddNewQuest(TQuest quest)
	{
		Quest quest2 = quest as Quest;
		if (quest2 == null)
		{
			return;
		}
		ActivityPrizeDrawingData activityData = this.ActivityData;
		if (activityData == null)
		{
			return;
		}
		activityData.QuestAddNotify(quest2.Id);
	}

	// Token: 0x060091FB RID: 37371 RVA: 0x001F33CC File Offset: 0x001F15CC
	[return: Nullable(new byte[]
	{
		0,
		2
	})]
	public UniTask<WuWuKujiGachaResponse> GachaRequest()
	{
		ActivityPrizeDrawingController.<GachaRequest>d__13 <GachaRequest>d__;
		<GachaRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder<WuWuKujiGachaResponse>.Create();
		<GachaRequest>d__.<>4__this = this;
		<GachaRequest>d__.<>1__state = -1;
		<GachaRequest>d__.<>t__builder.Start<ActivityPrizeDrawingController.<GachaRequest>d__13>(ref <GachaRequest>d__);
		return <GachaRequest>d__.<>t__builder.Task;
	}

	// Token: 0x17000CCA RID: 3274
	// (get) Token: 0x060091FC RID: 37372 RVA: 0x001F340F File Offset: 0x001F160F
	public static ActivityPrizeDrawingController Instance
	{
		get
		{
			return ActivityPrizeDrawingController._Instance;
		}
	}

	// Token: 0x060091FD RID: 37373 RVA: 0x001F3416 File Offset: 0x001F1616
	public static ActivityPrizeDrawingController GetOrCreateInstance()
	{
		if (ActivityPrizeDrawingController._Instance == null)
		{
			ActivityPrizeDrawingController.CreateInstance();
		}
		return ActivityPrizeDrawingController._Instance;
	}

	// Token: 0x060091FE RID: 37374 RVA: 0x001F342A File Offset: 0x001F162A
	public static bool CreateInstance()
	{
		if (ActivityPrizeDrawingController._Instance != null)
		{
			return true;
		}
		ActivityPrizeDrawingController._Instance = new ActivityPrizeDrawingController();
		return true;
	}

	// Token: 0x060091FF RID: 37375 RVA: 0x001F3440 File Offset: 0x001F1640
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06009200 RID: 37376 RVA: 0x001F3442 File Offset: 0x001F1642
	public static void ResetStaticDefaultValue()
	{
		ActivityPrizeDrawingController._Instance = null;
	}

	// Token: 0x06009201 RID: 37377 RVA: 0x001F344A File Offset: 0x001F164A
	static ActivityPrizeDrawingController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityPrizeDrawingController.CreateStaticDefaultValue), new Action(ActivityPrizeDrawingController.ResetStaticDefaultValue));
	}

	// Token: 0x040040A2 RID: 16546
	public int ActivityId;

	// Token: 0x040040A3 RID: 16547
	[Nullable(2)]
	private static ActivityPrizeDrawingController _Instance;
}
