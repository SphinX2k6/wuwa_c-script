using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x020010D6 RID: 4310
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class FragmentMemoryActivityController : ActivityControllerBase
{
	// Token: 0x0600ABC1 RID: 43969 RVA: 0x0032A31C File Offset: 0x0032851C
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x0600ABC2 RID: 43970 RVA: 0x0032A31E File Offset: 0x0032851E
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_ActivityProcessMemory";
	}

	// Token: 0x0600ABC3 RID: 43971 RVA: 0x0032A325 File Offset: 0x00328525
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new FragmentMemorySubView();
	}

	// Token: 0x0600ABC4 RID: 43972 RVA: 0x0032A32C File Offset: 0x0032852C
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		return new FragmentMemoryActivityData();
	}

	// Token: 0x0600ABC5 RID: 43973 RVA: 0x0032A333 File Offset: 0x00328533
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x170011D9 RID: 4569
	// (get) Token: 0x0600ABC6 RID: 43974 RVA: 0x0032A336 File Offset: 0x00328536
	public static FragmentMemoryActivityController Instance
	{
		get
		{
			return FragmentMemoryActivityController._Instance;
		}
	}

	// Token: 0x0600ABC7 RID: 43975 RVA: 0x0032A33D File Offset: 0x0032853D
	public static FragmentMemoryActivityController GetOrCreateInstance()
	{
		if (FragmentMemoryActivityController._Instance == null)
		{
			FragmentMemoryActivityController.CreateInstance();
		}
		return FragmentMemoryActivityController._Instance;
	}

	// Token: 0x0600ABC8 RID: 43976 RVA: 0x0032A351 File Offset: 0x00328551
	public static bool CreateInstance()
	{
		if (FragmentMemoryActivityController._Instance != null)
		{
			return true;
		}
		FragmentMemoryActivityController._Instance = new FragmentMemoryActivityController();
		return true;
	}

	// Token: 0x0600ABC9 RID: 43977 RVA: 0x0032A367 File Offset: 0x00328567
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600ABCA RID: 43978 RVA: 0x0032A369 File Offset: 0x00328569
	public static void ResetStaticDefaultValue()
	{
		FragmentMemoryActivityController._Instance = null;
	}

	// Token: 0x0600ABCB RID: 43979 RVA: 0x0032A371 File Offset: 0x00328571
	static FragmentMemoryActivityController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FragmentMemoryActivityController.CreateStaticDefaultValue), new Action(FragmentMemoryActivityController.ResetStaticDefaultValue));
	}

	// Token: 0x04006351 RID: 25425
	[Nullable(2)]
	private static FragmentMemoryActivityController _Instance;
}
