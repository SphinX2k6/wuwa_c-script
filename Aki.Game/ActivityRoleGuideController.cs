using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x020014C2 RID: 5314
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ActivityRoleGuideController : ActivityControllerBase
{
	// Token: 0x060096AF RID: 38575 RVA: 0x00208E47 File Offset: 0x00207047
	protected override void OnAddEvents()
	{
	}

	// Token: 0x060096B0 RID: 38576 RVA: 0x00208E49 File Offset: 0x00207049
	protected override void OnRemoveEvents()
	{
	}

	// Token: 0x060096B1 RID: 38577 RVA: 0x00208E4B File Offset: 0x0020704B
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_ActivityRoleGuide";
	}

	// Token: 0x060096B2 RID: 38578 RVA: 0x00208E52 File Offset: 0x00207052
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new ActivitySubViewRoleGuide();
	}

	// Token: 0x060096B3 RID: 38579 RVA: 0x00208E59 File Offset: 0x00207059
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		this.CurrentActivityId = data.Id;
		return new ActivityRoleGuideData();
	}

	// Token: 0x060096B4 RID: 38580 RVA: 0x00208E6C File Offset: 0x0020706C
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x060096B5 RID: 38581 RVA: 0x00208E6E File Offset: 0x0020706E
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x17000D0A RID: 3338
	// (get) Token: 0x060096B6 RID: 38582 RVA: 0x00208E71 File Offset: 0x00207071
	public static ActivityRoleGuideController Instance
	{
		get
		{
			return ActivityRoleGuideController._Instance;
		}
	}

	// Token: 0x060096B7 RID: 38583 RVA: 0x00208E78 File Offset: 0x00207078
	public static ActivityRoleGuideController GetOrCreateInstance()
	{
		if (ActivityRoleGuideController._Instance == null)
		{
			ActivityRoleGuideController.CreateInstance();
		}
		return ActivityRoleGuideController._Instance;
	}

	// Token: 0x060096B8 RID: 38584 RVA: 0x00208E8C File Offset: 0x0020708C
	public static bool CreateInstance()
	{
		if (ActivityRoleGuideController._Instance != null)
		{
			return true;
		}
		ActivityRoleGuideController._Instance = new ActivityRoleGuideController();
		return true;
	}

	// Token: 0x060096B9 RID: 38585 RVA: 0x00208EA2 File Offset: 0x002070A2
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060096BA RID: 38586 RVA: 0x00208EA4 File Offset: 0x002070A4
	public static void ResetStaticDefaultValue()
	{
		ActivityRoleGuideController._Instance = null;
	}

	// Token: 0x060096BB RID: 38587 RVA: 0x00208EAC File Offset: 0x002070AC
	static ActivityRoleGuideController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityRoleGuideController.CreateStaticDefaultValue), new Action(ActivityRoleGuideController.ResetStaticDefaultValue));
	}

	// Token: 0x04004277 RID: 17015
	public int CurrentActivityId;

	// Token: 0x04004278 RID: 17016
	[Nullable(2)]
	private static ActivityRoleGuideController _Instance;
}
