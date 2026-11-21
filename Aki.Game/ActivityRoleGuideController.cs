using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02000976 RID: 2422
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ActivityRoleGuideController : ActivityControllerBase
{
	// Token: 0x06006A44 RID: 27204 RVA: 0x00211DB3 File Offset: 0x0020FFB3
	protected override void OnAddEvents()
	{
	}

	// Token: 0x06006A45 RID: 27205 RVA: 0x00211DB5 File Offset: 0x0020FFB5
	protected override void OnRemoveEvents()
	{
	}

	// Token: 0x06006A46 RID: 27206 RVA: 0x00211DB7 File Offset: 0x0020FFB7
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_ActivityRoleGuide";
	}

	// Token: 0x06006A47 RID: 27207 RVA: 0x00211DBE File Offset: 0x0020FFBE
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new ActivitySubViewRoleGuide();
	}

	// Token: 0x06006A48 RID: 27208 RVA: 0x00211DC5 File Offset: 0x0020FFC5
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		this.CurrentActivityId = data.Id;
		return new ActivityRoleGuideData();
	}

	// Token: 0x06006A49 RID: 27209 RVA: 0x00211DD8 File Offset: 0x0020FFD8
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x06006A4A RID: 27210 RVA: 0x00211DDA File Offset: 0x0020FFDA
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x17000D2A RID: 3370
	// (get) Token: 0x06006A4B RID: 27211 RVA: 0x00211DDD File Offset: 0x0020FFDD
	public static ActivityRoleGuideController Instance
	{
		get
		{
			return ActivityRoleGuideController._Instance;
		}
	}

	// Token: 0x06006A4C RID: 27212 RVA: 0x00211DE4 File Offset: 0x0020FFE4
	public static ActivityRoleGuideController GetOrCreateInstance()
	{
		if (ActivityRoleGuideController._Instance == null)
		{
			ActivityRoleGuideController.CreateInstance();
		}
		return ActivityRoleGuideController._Instance;
	}

	// Token: 0x06006A4D RID: 27213 RVA: 0x00211DF8 File Offset: 0x0020FFF8
	public static bool CreateInstance()
	{
		if (ActivityRoleGuideController._Instance != null)
		{
			return true;
		}
		ActivityRoleGuideController._Instance = new ActivityRoleGuideController();
		return true;
	}

	// Token: 0x06006A4E RID: 27214 RVA: 0x00211E0E File Offset: 0x0021000E
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06006A4F RID: 27215 RVA: 0x00211E10 File Offset: 0x00210010
	public static void ResetStaticDefaultValue()
	{
		ActivityRoleGuideController._Instance = null;
	}

	// Token: 0x06006A50 RID: 27216 RVA: 0x00211E18 File Offset: 0x00210018
	static ActivityRoleGuideController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityRoleGuideController.CreateStaticDefaultValue), new Action(ActivityRoleGuideController.ResetStaticDefaultValue));
	}

	// Token: 0x0400430F RID: 17167
	public int CurrentActivityId;

	// Token: 0x04004310 RID: 17168
	[Nullable(2)]
	private static ActivityRoleGuideController _Instance;
}
