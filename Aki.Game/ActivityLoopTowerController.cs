using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x0200076A RID: 1898
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ActivityLoopTowerController : ActivityControllerBase
{
	// Token: 0x06005726 RID: 22310 RVA: 0x001C9358 File Offset: 0x001C7558
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x06005727 RID: 22311 RVA: 0x001C935B File Offset: 0x001C755B
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x06005728 RID: 22312 RVA: 0x001C935D File Offset: 0x001C755D
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_ActivityLoopTower";
	}

	// Token: 0x06005729 RID: 22313 RVA: 0x001C9364 File Offset: 0x001C7564
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new ActivitySubViewLoopTower();
	}

	// Token: 0x0600572A RID: 22314 RVA: 0x001C936B File Offset: 0x001C756B
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		return new ActivityLoopTowerData();
	}

	// Token: 0x0600572B RID: 22315 RVA: 0x001C9372 File Offset: 0x001C7572
	protected override void OnRegisterNetEvent()
	{
	}

	// Token: 0x0600572C RID: 22316 RVA: 0x001C9374 File Offset: 0x001C7574
	protected override void OnUnRegisterNetEvent()
	{
	}

	// Token: 0x17000B52 RID: 2898
	// (get) Token: 0x0600572D RID: 22317 RVA: 0x001C9376 File Offset: 0x001C7576
	public static ActivityLoopTowerController Instance
	{
		get
		{
			return ActivityLoopTowerController._Instance;
		}
	}

	// Token: 0x0600572E RID: 22318 RVA: 0x001C937D File Offset: 0x001C757D
	public static ActivityLoopTowerController GetOrCreateInstance()
	{
		if (ActivityLoopTowerController._Instance == null)
		{
			ActivityLoopTowerController.CreateInstance();
		}
		return ActivityLoopTowerController._Instance;
	}

	// Token: 0x0600572F RID: 22319 RVA: 0x001C9391 File Offset: 0x001C7591
	public static bool CreateInstance()
	{
		if (ActivityLoopTowerController._Instance != null)
		{
			return true;
		}
		ActivityLoopTowerController._Instance = new ActivityLoopTowerController();
		return true;
	}

	// Token: 0x06005730 RID: 22320 RVA: 0x001C93A7 File Offset: 0x001C75A7
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06005731 RID: 22321 RVA: 0x001C93A9 File Offset: 0x001C75A9
	public static void ResetStaticDefaultValue()
	{
		ActivityLoopTowerController._Instance = null;
	}

	// Token: 0x06005732 RID: 22322 RVA: 0x001C93B1 File Offset: 0x001C75B1
	static ActivityLoopTowerController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityLoopTowerController.CreateStaticDefaultValue), new Action(ActivityLoopTowerController.ResetStaticDefaultValue));
	}

	// Token: 0x04003BD1 RID: 15313
	public int CurrentActivityId;

	// Token: 0x04003BD2 RID: 15314
	[Nullable(2)]
	private static ActivityLoopTowerController _Instance;
}
