using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x02000823 RID: 2083
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ActivityMotorGiftController : ActivityControllerBase
{
	// Token: 0x06005E63 RID: 24163 RVA: 0x001E33B5 File Offset: 0x001E15B5
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.MotorDiyFullOutlookUpdate, new Action(this.OnMotorOutlookUpdate));
	}

	// Token: 0x06005E64 RID: 24164 RVA: 0x001E33D3 File Offset: 0x001E15D3
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.MotorDiyFullOutlookUpdate, new Action(this.OnMotorOutlookUpdate));
	}

	// Token: 0x06005E65 RID: 24165 RVA: 0x001E33F4 File Offset: 0x001E15F4
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

	// Token: 0x06005E66 RID: 24166 RVA: 0x001E3480 File Offset: 0x001E1680
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x06005E67 RID: 24167 RVA: 0x001E3482 File Offset: 0x001E1682
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_ActivityMotoSkinMain";
	}

	// Token: 0x06005E68 RID: 24168 RVA: 0x001E3489 File Offset: 0x001E1689
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new ActivityMotorGiftSubView();
	}

	// Token: 0x06005E69 RID: 24169 RVA: 0x001E3490 File Offset: 0x001E1690
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		return new ActivityMotorGiftData();
	}

	// Token: 0x06005E6A RID: 24170 RVA: 0x001E3497 File Offset: 0x001E1697
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x17000BE4 RID: 3044
	// (get) Token: 0x06005E6B RID: 24171 RVA: 0x001E349A File Offset: 0x001E169A
	public static ActivityMotorGiftController Instance
	{
		get
		{
			return ActivityMotorGiftController._Instance;
		}
	}

	// Token: 0x06005E6C RID: 24172 RVA: 0x001E34A1 File Offset: 0x001E16A1
	public static ActivityMotorGiftController GetOrCreateInstance()
	{
		if (ActivityMotorGiftController._Instance == null)
		{
			ActivityMotorGiftController.CreateInstance();
		}
		return ActivityMotorGiftController._Instance;
	}

	// Token: 0x06005E6D RID: 24173 RVA: 0x001E34B5 File Offset: 0x001E16B5
	public static bool CreateInstance()
	{
		if (ActivityMotorGiftController._Instance != null)
		{
			return true;
		}
		ActivityMotorGiftController._Instance = new ActivityMotorGiftController();
		return true;
	}

	// Token: 0x06005E6E RID: 24174 RVA: 0x001E34CB File Offset: 0x001E16CB
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06005E6F RID: 24175 RVA: 0x001E34CD File Offset: 0x001E16CD
	public static void ResetStaticDefaultValue()
	{
		ActivityMotorGiftController._Instance = null;
	}

	// Token: 0x06005E70 RID: 24176 RVA: 0x001E34D5 File Offset: 0x001E16D5
	static ActivityMotorGiftController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityMotorGiftController.CreateStaticDefaultValue), new Action(ActivityMotorGiftController.ResetStaticDefaultValue));
	}

	// Token: 0x04003E5C RID: 15964
	[Nullable(2)]
	private static ActivityMotorGiftController _Instance;
}
