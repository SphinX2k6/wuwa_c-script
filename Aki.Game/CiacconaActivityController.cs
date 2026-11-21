using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02000691 RID: 1681
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class CiacconaActivityController : ActivityControllerBase
{
	// Token: 0x06004D74 RID: 19828 RVA: 0x001A33C0 File Offset: 0x001A15C0
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x06004D75 RID: 19829 RVA: 0x001A33C3 File Offset: 0x001A15C3
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x06004D76 RID: 19830 RVA: 0x001A33C5 File Offset: 0x001A15C5
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_ActivityXiaMain";
	}

	// Token: 0x06004D77 RID: 19831 RVA: 0x001A33CC File Offset: 0x001A15CC
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new CiacconaActivitySubView();
	}

	// Token: 0x06004D78 RID: 19832 RVA: 0x001A33D3 File Offset: 0x001A15D3
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		return new CiacconaActivityData();
	}

	// Token: 0x17000A89 RID: 2697
	// (get) Token: 0x06004D79 RID: 19833 RVA: 0x001A33DA File Offset: 0x001A15DA
	public static CiacconaActivityController Instance
	{
		get
		{
			return CiacconaActivityController._Instance;
		}
	}

	// Token: 0x06004D7A RID: 19834 RVA: 0x001A33E1 File Offset: 0x001A15E1
	public static CiacconaActivityController GetOrCreateInstance()
	{
		if (CiacconaActivityController._Instance == null)
		{
			CiacconaActivityController.CreateInstance();
		}
		return CiacconaActivityController._Instance;
	}

	// Token: 0x06004D7B RID: 19835 RVA: 0x001A33F5 File Offset: 0x001A15F5
	public static bool CreateInstance()
	{
		if (CiacconaActivityController._Instance != null)
		{
			return true;
		}
		CiacconaActivityController._Instance = new CiacconaActivityController();
		return true;
	}

	// Token: 0x06004D7C RID: 19836 RVA: 0x001A340B File Offset: 0x001A160B
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06004D7D RID: 19837 RVA: 0x001A340D File Offset: 0x001A160D
	public static void ResetStaticDefaultValue()
	{
		CiacconaActivityController._Instance = null;
	}

	// Token: 0x06004D7E RID: 19838 RVA: 0x001A3415 File Offset: 0x001A1615
	static CiacconaActivityController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CiacconaActivityController.CreateStaticDefaultValue), new Action(CiacconaActivityController.ResetStaticDefaultValue));
	}

	// Token: 0x04003896 RID: 14486
	[Nullable(2)]
	private static CiacconaActivityController _Instance;
}
