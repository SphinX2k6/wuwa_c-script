using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02001506 RID: 5382
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ActivitySoarController : ActivityControllerBase
{
	// Token: 0x06009991 RID: 39313 RVA: 0x00213CCC File Offset: 0x00211ECC
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x06009992 RID: 39314 RVA: 0x00213CCE File Offset: 0x00211ECE
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x06009993 RID: 39315 RVA: 0x00213CD1 File Offset: 0x00211ED1
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_ActivitySoar";
	}

	// Token: 0x06009994 RID: 39316 RVA: 0x00213CD8 File Offset: 0x00211ED8
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new ActivitySoarSubView();
	}

	// Token: 0x06009995 RID: 39317 RVA: 0x00213CDF File Offset: 0x00211EDF
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		return new ActivitySoarData();
	}

	// Token: 0x06009996 RID: 39318 RVA: 0x00213CE8 File Offset: 0x00211EE8
	public override void OnActivityFirstUnlock(ActivityBaseData data)
	{
		int questId = (data as ActivitySoarData).GetQuestId();
		if (QuestNewModel.Instance.CheckQuestFinished(questId))
		{
			return;
		}
		if (!QuestNewModel.Instance.IsTrackingQuest(questId))
		{
			QuestNewController.Instance.RequestTrackQuest(questId, true, ERequestTrackOperate.Auto, ESetTrackReason.None, null);
		}
	}

	// Token: 0x17000D2F RID: 3375
	// (get) Token: 0x06009997 RID: 39319 RVA: 0x00213D2C File Offset: 0x00211F2C
	public static ActivitySoarController Instance
	{
		get
		{
			return ActivitySoarController._Instance;
		}
	}

	// Token: 0x06009998 RID: 39320 RVA: 0x00213D33 File Offset: 0x00211F33
	public static ActivitySoarController GetOrCreateInstance()
	{
		if (ActivitySoarController._Instance == null)
		{
			ActivitySoarController.CreateInstance();
		}
		return ActivitySoarController._Instance;
	}

	// Token: 0x06009999 RID: 39321 RVA: 0x00213D47 File Offset: 0x00211F47
	public static bool CreateInstance()
	{
		if (ActivitySoarController._Instance != null)
		{
			return true;
		}
		ActivitySoarController._Instance = new ActivitySoarController();
		return true;
	}

	// Token: 0x0600999A RID: 39322 RVA: 0x00213D5D File Offset: 0x00211F5D
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600999B RID: 39323 RVA: 0x00213D5F File Offset: 0x00211F5F
	public static void ResetStaticDefaultValue()
	{
		ActivitySoarController._Instance = null;
	}

	// Token: 0x0600999C RID: 39324 RVA: 0x00213D67 File Offset: 0x00211F67
	static ActivitySoarController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivitySoarController.CreateStaticDefaultValue), new Action(ActivitySoarController.ResetStaticDefaultValue));
	}

	// Token: 0x04004374 RID: 17268
	[Nullable(2)]
	private static ActivitySoarController _Instance;
}
