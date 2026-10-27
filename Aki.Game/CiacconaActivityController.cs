using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x020011DD RID: 4573
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class CiacconaActivityController : ActivityControllerBase
{
	// Token: 0x060079DD RID: 31197 RVA: 0x0019A710 File Offset: 0x00198910
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x060079DE RID: 31198 RVA: 0x0019A713 File Offset: 0x00198913
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x060079DF RID: 31199 RVA: 0x0019A715 File Offset: 0x00198915
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_ActivityXiaMain";
	}

	// Token: 0x060079E0 RID: 31200 RVA: 0x0019A71C File Offset: 0x0019891C
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new CiacconaActivitySubView();
	}

	// Token: 0x060079E1 RID: 31201 RVA: 0x0019A723 File Offset: 0x00198923
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		return new CiacconaActivityData();
	}

	// Token: 0x17000A69 RID: 2665
	// (get) Token: 0x060079E2 RID: 31202 RVA: 0x0019A72A File Offset: 0x0019892A
	public static CiacconaActivityController Instance
	{
		get
		{
			return CiacconaActivityController._Instance;
		}
	}

	// Token: 0x060079E3 RID: 31203 RVA: 0x0019A731 File Offset: 0x00198931
	public static CiacconaActivityController GetOrCreateInstance()
	{
		if (CiacconaActivityController._Instance == null)
		{
			CiacconaActivityController.CreateInstance();
		}
		return CiacconaActivityController._Instance;
	}

	// Token: 0x060079E4 RID: 31204 RVA: 0x0019A745 File Offset: 0x00198945
	public static bool CreateInstance()
	{
		if (CiacconaActivityController._Instance != null)
		{
			return true;
		}
		CiacconaActivityController._Instance = new CiacconaActivityController();
		return true;
	}

	// Token: 0x060079E5 RID: 31205 RVA: 0x0019A75B File Offset: 0x0019895B
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060079E6 RID: 31206 RVA: 0x0019A75D File Offset: 0x0019895D
	public static void ResetStaticDefaultValue()
	{
		CiacconaActivityController._Instance = null;
	}

	// Token: 0x060079E7 RID: 31207 RVA: 0x0019A765 File Offset: 0x00198965
	static CiacconaActivityController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CiacconaActivityController.CreateStaticDefaultValue), new Action(CiacconaActivityController.ResetStaticDefaultValue));
	}

	// Token: 0x040037FD RID: 14333
	[Nullable(2)]
	private static CiacconaActivityController _Instance;
}
