using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x020012B9 RID: 4793
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ActivityLordGymController : ActivityControllerBase
{
	// Token: 0x060083B0 RID: 33712 RVA: 0x001C0CA1 File Offset: 0x001BEEA1
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x060083B1 RID: 33713 RVA: 0x001C0CA4 File Offset: 0x001BEEA4
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x060083B2 RID: 33714 RVA: 0x001C0CA6 File Offset: 0x001BEEA6
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_LordGym35Main";
	}

	// Token: 0x060083B3 RID: 33715 RVA: 0x001C0CAD File Offset: 0x001BEEAD
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new LordGymThird5ActivitySubView();
	}

	// Token: 0x060083B4 RID: 33716 RVA: 0x001C0CB4 File Offset: 0x001BEEB4
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		return new LordGymActivityData();
	}

	// Token: 0x060083B5 RID: 33717 RVA: 0x001C0CBC File Offset: 0x001BEEBC
	public LordGymActivityData GetCurrentActivityData()
	{
		List<ActivityBaseData> currentActivitiesByType = ActivityModel.Instance.GetCurrentActivitiesByType(ActivityType.NewLordGym);
		LordGymActivityData result = null;
		if (currentActivitiesByType != null)
		{
			foreach (ActivityBaseData activityBaseData in currentActivitiesByType)
			{
				result = (activityBaseData as LordGymActivityData);
			}
		}
		return result;
	}

	// Token: 0x17000B33 RID: 2867
	// (get) Token: 0x060083B6 RID: 33718 RVA: 0x001C0D1C File Offset: 0x001BEF1C
	public static ActivityLordGymController Instance
	{
		get
		{
			return ActivityLordGymController._Instance;
		}
	}

	// Token: 0x060083B7 RID: 33719 RVA: 0x001C0D23 File Offset: 0x001BEF23
	public static ActivityLordGymController GetOrCreateInstance()
	{
		if (ActivityLordGymController._Instance == null)
		{
			ActivityLordGymController.CreateInstance();
		}
		return ActivityLordGymController._Instance;
	}

	// Token: 0x060083B8 RID: 33720 RVA: 0x001C0D37 File Offset: 0x001BEF37
	public static bool CreateInstance()
	{
		if (ActivityLordGymController._Instance != null)
		{
			return true;
		}
		ActivityLordGymController._Instance = new ActivityLordGymController();
		return true;
	}

	// Token: 0x060083B9 RID: 33721 RVA: 0x001C0D4D File Offset: 0x001BEF4D
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060083BA RID: 33722 RVA: 0x001C0D4F File Offset: 0x001BEF4F
	public static void ResetStaticDefaultValue()
	{
		ActivityLordGymController._Instance = null;
	}

	// Token: 0x060083BB RID: 33723 RVA: 0x001C0D57 File Offset: 0x001BEF57
	static ActivityLordGymController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityLordGymController.CreateStaticDefaultValue), new Action(ActivityLordGymController.ResetStaticDefaultValue));
	}

	// Token: 0x04003B40 RID: 15168
	[Nullable(2)]
	private static ActivityLordGymController _Instance;
}
