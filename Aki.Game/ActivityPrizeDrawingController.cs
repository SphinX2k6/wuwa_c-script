using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.PrizeDrawing;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x020008E6 RID: 2278
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ActivityPrizeDrawingController : ActivityControllerBase
{
	// Token: 0x17000CE9 RID: 3305
	// (get) Token: 0x06006585 RID: 25989 RVA: 0x001FBDC1 File Offset: 0x001F9FC1
	[Nullable(2)]
	public ActivityPrizeDrawingData ActivityData
	{
		[NullableContext(2)]
		get
		{
			return ActivityModel.Instance.GetActivityById(this.ActivityId) as ActivityPrizeDrawingData;
		}
	}

	// Token: 0x06006586 RID: 25990 RVA: 0x001FBDD8 File Offset: 0x001F9FD8
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x06006587 RID: 25991 RVA: 0x001FBDDA File Offset: 0x001F9FDA
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_PrizeDrawingActivity";
	}

	// Token: 0x06006588 RID: 25992 RVA: 0x001FBDE1 File Offset: 0x001F9FE1
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new ActivityPrizeDrawingSubView();
	}

	// Token: 0x06006589 RID: 25993 RVA: 0x001FBDE8 File Offset: 0x001F9FE8
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		this.ActivityId = data.Id;
		return new ActivityPrizeDrawingData();
	}

	// Token: 0x0600658A RID: 25994 RVA: 0x001FBDFB File Offset: 0x001F9FFB
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x0600658B RID: 25995 RVA: 0x001FBDFE File Offset: 0x001F9FFE
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add<int, QuestState, EQuestStatusUpdateReason>(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.OnQuestStateChanged));
		EventSystem.Instance.Add<TQuest>(EEventName.OnAddNewQuest, new Action<TQuest>(this.OnAddNewQuest));
	}

	// Token: 0x0600658C RID: 25996 RVA: 0x001FBE38 File Offset: 0x001FA038
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove<int, QuestState, EQuestStatusUpdateReason>(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.OnQuestStateChanged));
		EventSystem.Instance.Remove<TQuest>(EEventName.OnAddNewQuest, new Action<TQuest>(this.OnAddNewQuest));
	}

	// Token: 0x0600658D RID: 25997 RVA: 0x001FBE74 File Offset: 0x001FA074
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

	// Token: 0x0600658E RID: 25998 RVA: 0x001FBEBF File Offset: 0x001FA0BF
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

	// Token: 0x0600658F RID: 25999 RVA: 0x001FBED8 File Offset: 0x001FA0D8
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

	// Token: 0x06006590 RID: 26000 RVA: 0x001FBF08 File Offset: 0x001FA108
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

	// Token: 0x17000CEA RID: 3306
	// (get) Token: 0x06006591 RID: 26001 RVA: 0x001FBF4B File Offset: 0x001FA14B
	public static ActivityPrizeDrawingController Instance
	{
		get
		{
			return ActivityPrizeDrawingController._Instance;
		}
	}

	// Token: 0x06006592 RID: 26002 RVA: 0x001FBF52 File Offset: 0x001FA152
	public static ActivityPrizeDrawingController GetOrCreateInstance()
	{
		if (ActivityPrizeDrawingController._Instance == null)
		{
			ActivityPrizeDrawingController.CreateInstance();
		}
		return ActivityPrizeDrawingController._Instance;
	}

	// Token: 0x06006593 RID: 26003 RVA: 0x001FBF66 File Offset: 0x001FA166
	public static bool CreateInstance()
	{
		if (ActivityPrizeDrawingController._Instance != null)
		{
			return true;
		}
		ActivityPrizeDrawingController._Instance = new ActivityPrizeDrawingController();
		return true;
	}

	// Token: 0x06006594 RID: 26004 RVA: 0x001FBF7C File Offset: 0x001FA17C
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06006595 RID: 26005 RVA: 0x001FBF7E File Offset: 0x001FA17E
	public static void ResetStaticDefaultValue()
	{
		ActivityPrizeDrawingController._Instance = null;
	}

	// Token: 0x06006596 RID: 26006 RVA: 0x001FBF86 File Offset: 0x001FA186
	static ActivityPrizeDrawingController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityPrizeDrawingController.CreateStaticDefaultValue), new Action(ActivityPrizeDrawingController.ResetStaticDefaultValue));
	}

	// Token: 0x0400413A RID: 16698
	public int ActivityId;

	// Token: 0x0400413B RID: 16699
	[Nullable(2)]
	private static ActivityPrizeDrawingController _Instance;
}
