using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x020009BE RID: 2494
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ActivitySoarController : ActivityControllerBase
{
	// Token: 0x06006D6B RID: 28011 RVA: 0x0021D9E8 File Offset: 0x0021BBE8
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x06006D6C RID: 28012 RVA: 0x0021D9EA File Offset: 0x0021BBEA
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x06006D6D RID: 28013 RVA: 0x0021D9ED File Offset: 0x0021BBED
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_ActivitySoar";
	}

	// Token: 0x06006D6E RID: 28014 RVA: 0x0021D9F4 File Offset: 0x0021BBF4
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new ActivitySoarSubView();
	}

	// Token: 0x06006D6F RID: 28015 RVA: 0x0021D9FB File Offset: 0x0021BBFB
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		return new ActivitySoarData();
	}

	// Token: 0x06006D70 RID: 28016 RVA: 0x0021DA02 File Offset: 0x0021BC02
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add<int, QuestState, EQuestStatusUpdateReason>(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.OnQuestStateChange));
	}

	// Token: 0x06006D71 RID: 28017 RVA: 0x0021DA20 File Offset: 0x0021BC20
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove<int, QuestState, EQuestStatusUpdateReason>(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.OnQuestStateChange));
		this.PendingAutoTrackQuestId = 0;
	}

	// Token: 0x06006D72 RID: 28018 RVA: 0x0021DA48 File Offset: 0x0021BC48
	public override void OnActivityFirstUnlock(ActivityBaseData data)
	{
		ActivitySoarData activitySoarData = data as ActivitySoarData;
		this.TryAutoTrackQuest(activitySoarData.GetQuestId());
	}

	// Token: 0x06006D73 RID: 28019 RVA: 0x0021DA68 File Offset: 0x0021BC68
	private void OnQuestStateChange(int questId, QuestState state, EQuestStatusUpdateReason _)
	{
		if (questId != this.PendingAutoTrackQuestId)
		{
			return;
		}
		if (state == QuestState.Finish || state == QuestState.Delete)
		{
			this.PendingAutoTrackQuestId = 0;
			return;
		}
		if (state != QuestState.Progress)
		{
			return;
		}
		this.TryAutoTrackQuest(questId);
	}

	// Token: 0x06006D74 RID: 28020 RVA: 0x0021DA90 File Offset: 0x0021BC90
	private void TryAutoTrackQuest(int questId)
	{
		QuestNewModel instance = QuestNewModel.Instance;
		if (instance.CheckQuestFinished(questId) || instance.IsTrackingQuest(questId))
		{
			this.PendingAutoTrackQuestId = 0;
			return;
		}
		if (instance.GetQuest(questId) == null)
		{
			this.PendingAutoTrackQuestId = questId;
			return;
		}
		this.PendingAutoTrackQuestId = 0;
		QuestNewController.Instance.RequestTrackQuest(questId, true, ERequestTrackOperate.Auto, ESetTrackReason.None, null);
	}

	// Token: 0x17000D50 RID: 3408
	// (get) Token: 0x06006D75 RID: 28021 RVA: 0x0021DAE5 File Offset: 0x0021BCE5
	public static ActivitySoarController Instance
	{
		get
		{
			return ActivitySoarController._Instance;
		}
	}

	// Token: 0x06006D76 RID: 28022 RVA: 0x0021DAEC File Offset: 0x0021BCEC
	public static ActivitySoarController GetOrCreateInstance()
	{
		if (ActivitySoarController._Instance == null)
		{
			ActivitySoarController.CreateInstance();
		}
		return ActivitySoarController._Instance;
	}

	// Token: 0x06006D77 RID: 28023 RVA: 0x0021DB00 File Offset: 0x0021BD00
	public static bool CreateInstance()
	{
		if (ActivitySoarController._Instance != null)
		{
			return true;
		}
		ActivitySoarController._Instance = new ActivitySoarController();
		return true;
	}

	// Token: 0x06006D78 RID: 28024 RVA: 0x0021DB16 File Offset: 0x0021BD16
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06006D79 RID: 28025 RVA: 0x0021DB18 File Offset: 0x0021BD18
	public static void ResetStaticDefaultValue()
	{
		ActivitySoarController._Instance = null;
	}

	// Token: 0x06006D7A RID: 28026 RVA: 0x0021DB20 File Offset: 0x0021BD20
	static ActivitySoarController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivitySoarController.CreateStaticDefaultValue), new Action(ActivitySoarController.ResetStaticDefaultValue));
	}

	// Token: 0x04004419 RID: 17433
	private int PendingAutoTrackQuestId;

	// Token: 0x0400441A RID: 17434
	[Nullable(2)]
	private static ActivitySoarController _Instance;
}
