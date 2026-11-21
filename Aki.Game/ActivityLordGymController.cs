using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x0200076D RID: 1901
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ActivityLordGymController : ActivityControllerBase
{
	// Token: 0x0600574B RID: 22347 RVA: 0x001C9AFD File Offset: 0x001C7CFD
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x0600574C RID: 22348 RVA: 0x001C9B00 File Offset: 0x001C7D00
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x0600574D RID: 22349 RVA: 0x001C9B02 File Offset: 0x001C7D02
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_LordGym35Main";
	}

	// Token: 0x0600574E RID: 22350 RVA: 0x001C9B09 File Offset: 0x001C7D09
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new LordGymThird5ActivitySubView();
	}

	// Token: 0x0600574F RID: 22351 RVA: 0x001C9B10 File Offset: 0x001C7D10
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		return new LordGymActivityData();
	}

	// Token: 0x06005750 RID: 22352 RVA: 0x001C9B18 File Offset: 0x001C7D18
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

	// Token: 0x17000B53 RID: 2899
	// (get) Token: 0x06005751 RID: 22353 RVA: 0x001C9B78 File Offset: 0x001C7D78
	public static ActivityLordGymController Instance
	{
		get
		{
			return ActivityLordGymController._Instance;
		}
	}

	// Token: 0x06005752 RID: 22354 RVA: 0x001C9B7F File Offset: 0x001C7D7F
	public static ActivityLordGymController GetOrCreateInstance()
	{
		if (ActivityLordGymController._Instance == null)
		{
			ActivityLordGymController.CreateInstance();
		}
		return ActivityLordGymController._Instance;
	}

	// Token: 0x06005753 RID: 22355 RVA: 0x001C9B93 File Offset: 0x001C7D93
	public static bool CreateInstance()
	{
		if (ActivityLordGymController._Instance != null)
		{
			return true;
		}
		ActivityLordGymController._Instance = new ActivityLordGymController();
		return true;
	}

	// Token: 0x06005754 RID: 22356 RVA: 0x001C9BA9 File Offset: 0x001C7DA9
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06005755 RID: 22357 RVA: 0x001C9BAB File Offset: 0x001C7DAB
	public static void ResetStaticDefaultValue()
	{
		ActivityLordGymController._Instance = null;
	}

	// Token: 0x06005756 RID: 22358 RVA: 0x001C9BB3 File Offset: 0x001C7DB3
	static ActivityLordGymController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityLordGymController.CreateStaticDefaultValue), new Action(ActivityLordGymController.ResetStaticDefaultValue));
	}

	// Token: 0x04003BD8 RID: 15320
	[Nullable(2)]
	private static ActivityLordGymController _Instance;
}
