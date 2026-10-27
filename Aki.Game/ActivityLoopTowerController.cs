using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x020012B6 RID: 4790
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ActivityLoopTowerController : ActivityControllerBase
{
	// Token: 0x0600838F RID: 33679 RVA: 0x001C05C8 File Offset: 0x001BE7C8
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x06008390 RID: 33680 RVA: 0x001C05CB File Offset: 0x001BE7CB
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x06008391 RID: 33681 RVA: 0x001C05CD File Offset: 0x001BE7CD
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_ActivityLoopTower";
	}

	// Token: 0x06008392 RID: 33682 RVA: 0x001C05D4 File Offset: 0x001BE7D4
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new ActivitySubViewLoopTower();
	}

	// Token: 0x06008393 RID: 33683 RVA: 0x001C05DB File Offset: 0x001BE7DB
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		return new ActivityLoopTowerData();
	}

	// Token: 0x06008394 RID: 33684 RVA: 0x001C05E2 File Offset: 0x001BE7E2
	protected override void OnRegisterNetEvent()
	{
	}

	// Token: 0x06008395 RID: 33685 RVA: 0x001C05E4 File Offset: 0x001BE7E4
	protected override void OnUnRegisterNetEvent()
	{
	}

	// Token: 0x17000B32 RID: 2866
	// (get) Token: 0x06008396 RID: 33686 RVA: 0x001C05E6 File Offset: 0x001BE7E6
	public static ActivityLoopTowerController Instance
	{
		get
		{
			return ActivityLoopTowerController._Instance;
		}
	}

	// Token: 0x06008397 RID: 33687 RVA: 0x001C05ED File Offset: 0x001BE7ED
	public static ActivityLoopTowerController GetOrCreateInstance()
	{
		if (ActivityLoopTowerController._Instance == null)
		{
			ActivityLoopTowerController.CreateInstance();
		}
		return ActivityLoopTowerController._Instance;
	}

	// Token: 0x06008398 RID: 33688 RVA: 0x001C0601 File Offset: 0x001BE801
	public static bool CreateInstance()
	{
		if (ActivityLoopTowerController._Instance != null)
		{
			return true;
		}
		ActivityLoopTowerController._Instance = new ActivityLoopTowerController();
		return true;
	}

	// Token: 0x06008399 RID: 33689 RVA: 0x001C0617 File Offset: 0x001BE817
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600839A RID: 33690 RVA: 0x001C0619 File Offset: 0x001BE819
	public static void ResetStaticDefaultValue()
	{
		ActivityLoopTowerController._Instance = null;
	}

	// Token: 0x0600839B RID: 33691 RVA: 0x001C0621 File Offset: 0x001BE821
	static ActivityLoopTowerController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityLoopTowerController.CreateStaticDefaultValue), new Action(ActivityLoopTowerController.ResetStaticDefaultValue));
	}

	// Token: 0x04003B39 RID: 15161
	public int CurrentActivityId;

	// Token: 0x04003B3A RID: 15162
	[Nullable(2)]
	private static ActivityLoopTowerController _Instance;
}
