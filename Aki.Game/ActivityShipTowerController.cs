using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x02001502 RID: 5378
[NullableContext(1)]
[Nullable(0)]
public class ActivityShipTowerController : ActivityControllerBase
{
	// Token: 0x06009963 RID: 39267 RVA: 0x00213485 File Offset: 0x00211685
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x06009964 RID: 39268 RVA: 0x00213488 File Offset: 0x00211688
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x06009965 RID: 39269 RVA: 0x0021348A File Offset: 0x0021168A
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_ActivityMowingTower2";
	}

	// Token: 0x06009966 RID: 39270 RVA: 0x00213491 File Offset: 0x00211691
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new ActivitySubViewShipTower();
	}

	// Token: 0x06009967 RID: 39271 RVA: 0x00213498 File Offset: 0x00211698
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		this.Data = new ActivityShipTowerData();
		return this.Data;
	}

	// Token: 0x06009968 RID: 39272 RVA: 0x002134AB File Offset: 0x002116AB
	protected override void OnRegisterNetEvent()
	{
	}

	// Token: 0x06009969 RID: 39273 RVA: 0x002134AD File Offset: 0x002116AD
	protected override void OnUnRegisterNetEvent()
	{
	}

	// Token: 0x0600996A RID: 39274 RVA: 0x002134AF File Offset: 0x002116AF
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.OpenActivityViewShipTower, new Action(this.OpenMainView));
	}

	// Token: 0x0600996B RID: 39275 RVA: 0x002134CD File Offset: 0x002116CD
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OpenActivityViewShipTower, new Action(this.OpenMainView));
	}

	// Token: 0x0600996C RID: 39276 RVA: 0x002134EB File Offset: 0x002116EB
	private void OpenMainView()
	{
		ActivityController instance = ActivityController.Instance;
		ActivityShipTowerData data = this.Data;
		instance.OpenActivityById((data != null) ? data.Id : 0, EActivityViewOpenType.Other, null, null);
	}

	// Token: 0x0600996D RID: 39277 RVA: 0x00213510 File Offset: 0x00211710
	public static void RefreshActivityRedDot()
	{
		foreach (ActivityBaseData activityBaseData in ActivityModel.Instance.GetCurrentActivitiesByType(ActivityType.SlashAndTowerLevelPlay))
		{
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, activityBaseData.Id);
		}
	}

	// Token: 0x17000D2E RID: 3374
	// (get) Token: 0x0600996E RID: 39278 RVA: 0x00213578 File Offset: 0x00211778
	public static ActivityShipTowerController Instance
	{
		get
		{
			return ActivityShipTowerController._Instance;
		}
	}

	// Token: 0x0600996F RID: 39279 RVA: 0x0021357F File Offset: 0x0021177F
	public static ActivityShipTowerController GetOrCreateInstance()
	{
		if (ActivityShipTowerController._Instance == null)
		{
			ActivityShipTowerController.CreateInstance();
		}
		return ActivityShipTowerController._Instance;
	}

	// Token: 0x06009970 RID: 39280 RVA: 0x00213593 File Offset: 0x00211793
	public static bool CreateInstance()
	{
		if (ActivityShipTowerController._Instance != null)
		{
			return true;
		}
		ActivityShipTowerController._Instance = new ActivityShipTowerController();
		return true;
	}

	// Token: 0x06009971 RID: 39281 RVA: 0x002135A9 File Offset: 0x002117A9
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06009972 RID: 39282 RVA: 0x002135AB File Offset: 0x002117AB
	public static void ResetStaticDefaultValue()
	{
		ActivityShipTowerController._Instance = null;
	}

	// Token: 0x06009973 RID: 39283 RVA: 0x002135B3 File Offset: 0x002117B3
	static ActivityShipTowerController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityShipTowerController.CreateStaticDefaultValue), new Action(ActivityShipTowerController.ResetStaticDefaultValue));
	}

	// Token: 0x0400436E RID: 17262
	[Nullable(2)]
	public ActivityShipTowerData Data;

	// Token: 0x0400436F RID: 17263
	[Nullable(2)]
	private static ActivityShipTowerController _Instance;
}
