using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x0200136F RID: 4975
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ActivityMotorGiftController : ActivityControllerBase
{
	// Token: 0x06008AC8 RID: 35528 RVA: 0x001DA559 File Offset: 0x001D8759
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.MotorDiyFullOutlookUpdate, new Action(this.OnMotorOutlookUpdate));
	}

	// Token: 0x06008AC9 RID: 35529 RVA: 0x001DA577 File Offset: 0x001D8777
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.MotorDiyFullOutlookUpdate, new Action(this.OnMotorOutlookUpdate));
	}

	// Token: 0x06008ACA RID: 35530 RVA: 0x001DA598 File Offset: 0x001D8798
	private void OnMotorOutlookUpdate()
	{
		List<ActivityBaseData> currentActivitiesByType = ActivityModel.Instance.GetCurrentActivitiesByType(ActivityType.PurePreviewActivity);
		if (currentActivitiesByType == null || currentActivitiesByType.Count == 0)
		{
			return;
		}
		foreach (ActivityBaseData activityBaseData in currentActivitiesByType)
		{
			EventSystem.Instance.Emit<int>(EEventName.ActivityViewRefreshCurrent, activityBaseData.Id);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, activityBaseData.Id);
		}
	}

	// Token: 0x06008ACB RID: 35531 RVA: 0x001DA624 File Offset: 0x001D8824
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x06008ACC RID: 35532 RVA: 0x001DA626 File Offset: 0x001D8826
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_ActivityMotoSkinMain";
	}

	// Token: 0x06008ACD RID: 35533 RVA: 0x001DA62D File Offset: 0x001D882D
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new ActivityMotorGiftSubView();
	}

	// Token: 0x06008ACE RID: 35534 RVA: 0x001DA634 File Offset: 0x001D8834
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		return new ActivityMotorGiftData();
	}

	// Token: 0x06008ACF RID: 35535 RVA: 0x001DA63B File Offset: 0x001D883B
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x17000BC4 RID: 3012
	// (get) Token: 0x06008AD0 RID: 35536 RVA: 0x001DA63E File Offset: 0x001D883E
	public static ActivityMotorGiftController Instance
	{
		get
		{
			return ActivityMotorGiftController._Instance;
		}
	}

	// Token: 0x06008AD1 RID: 35537 RVA: 0x001DA645 File Offset: 0x001D8845
	public static ActivityMotorGiftController GetOrCreateInstance()
	{
		if (ActivityMotorGiftController._Instance == null)
		{
			ActivityMotorGiftController.CreateInstance();
		}
		return ActivityMotorGiftController._Instance;
	}

	// Token: 0x06008AD2 RID: 35538 RVA: 0x001DA659 File Offset: 0x001D8859
	public static bool CreateInstance()
	{
		if (ActivityMotorGiftController._Instance != null)
		{
			return true;
		}
		ActivityMotorGiftController._Instance = new ActivityMotorGiftController();
		return true;
	}

	// Token: 0x06008AD3 RID: 35539 RVA: 0x001DA66F File Offset: 0x001D886F
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06008AD4 RID: 35540 RVA: 0x001DA671 File Offset: 0x001D8871
	public static void ResetStaticDefaultValue()
	{
		ActivityMotorGiftController._Instance = null;
	}

	// Token: 0x06008AD5 RID: 35541 RVA: 0x001DA679 File Offset: 0x001D8879
	static ActivityMotorGiftController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityMotorGiftController.CreateStaticDefaultValue), new Action(ActivityMotorGiftController.ResetStaticDefaultValue));
	}

	// Token: 0x04003DC4 RID: 15812
	[Nullable(2)]
	private static ActivityMotorGiftController _Instance;
}
