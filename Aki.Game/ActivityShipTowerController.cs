using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x020009BA RID: 2490
[NullableContext(1)]
[Nullable(0)]
public class ActivityShipTowerController : ActivityControllerBase
{
	// Token: 0x06006D3D RID: 27965 RVA: 0x0021D19D File Offset: 0x0021B39D
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x06006D3E RID: 27966 RVA: 0x0021D1A0 File Offset: 0x0021B3A0
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x06006D3F RID: 27967 RVA: 0x0021D1A2 File Offset: 0x0021B3A2
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_ActivityMowingTower2";
	}

	// Token: 0x06006D40 RID: 27968 RVA: 0x0021D1A9 File Offset: 0x0021B3A9
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new ActivitySubViewShipTower();
	}

	// Token: 0x06006D41 RID: 27969 RVA: 0x0021D1B0 File Offset: 0x0021B3B0
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		this.Data = new ActivityShipTowerData();
		return this.Data;
	}

	// Token: 0x06006D42 RID: 27970 RVA: 0x0021D1C3 File Offset: 0x0021B3C3
	protected override void OnRegisterNetEvent()
	{
	}

	// Token: 0x06006D43 RID: 27971 RVA: 0x0021D1C5 File Offset: 0x0021B3C5
	protected override void OnUnRegisterNetEvent()
	{
	}

	// Token: 0x06006D44 RID: 27972 RVA: 0x0021D1C7 File Offset: 0x0021B3C7
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.OpenActivityViewShipTower, new Action(this.OpenMainView));
	}

	// Token: 0x06006D45 RID: 27973 RVA: 0x0021D1E5 File Offset: 0x0021B3E5
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OpenActivityViewShipTower, new Action(this.OpenMainView));
	}

	// Token: 0x06006D46 RID: 27974 RVA: 0x0021D203 File Offset: 0x0021B403
	private void OpenMainView()
	{
		ActivityController instance = ActivityController.Instance;
		ActivityShipTowerData data = this.Data;
		instance.OpenActivityById((data != null) ? data.Id : 0, EActivityViewOpenType.Other, null, null);
	}

	// Token: 0x06006D47 RID: 27975 RVA: 0x0021D228 File Offset: 0x0021B428
	public static void RefreshActivityRedDot()
	{
		foreach (ActivityBaseData activityBaseData in ActivityModel.Instance.GetCurrentActivitiesByType(ActivityType.SlashAndTowerLevelPlay))
		{
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, activityBaseData.Id);
		}
	}

	// Token: 0x17000D4F RID: 3407
	// (get) Token: 0x06006D48 RID: 27976 RVA: 0x0021D290 File Offset: 0x0021B490
	public static ActivityShipTowerController Instance
	{
		get
		{
			return ActivityShipTowerController._Instance;
		}
	}

	// Token: 0x06006D49 RID: 27977 RVA: 0x0021D297 File Offset: 0x0021B497
	public static ActivityShipTowerController GetOrCreateInstance()
	{
		if (ActivityShipTowerController._Instance == null)
		{
			ActivityShipTowerController.CreateInstance();
		}
		return ActivityShipTowerController._Instance;
	}

	// Token: 0x06006D4A RID: 27978 RVA: 0x0021D2AB File Offset: 0x0021B4AB
	public static bool CreateInstance()
	{
		if (ActivityShipTowerController._Instance != null)
		{
			return true;
		}
		ActivityShipTowerController._Instance = new ActivityShipTowerController();
		return true;
	}

	// Token: 0x06006D4B RID: 27979 RVA: 0x0021D2C1 File Offset: 0x0021B4C1
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06006D4C RID: 27980 RVA: 0x0021D2C3 File Offset: 0x0021B4C3
	public static void ResetStaticDefaultValue()
	{
		ActivityShipTowerController._Instance = null;
	}

	// Token: 0x06006D4D RID: 27981 RVA: 0x0021D2CB File Offset: 0x0021B4CB
	static ActivityShipTowerController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityShipTowerController.CreateStaticDefaultValue), new Action(ActivityShipTowerController.ResetStaticDefaultValue));
	}

	// Token: 0x04004413 RID: 17427
	[Nullable(2)]
	public ActivityShipTowerData Data;

	// Token: 0x04004414 RID: 17428
	[Nullable(2)]
	private static ActivityShipTowerController _Instance;
}
