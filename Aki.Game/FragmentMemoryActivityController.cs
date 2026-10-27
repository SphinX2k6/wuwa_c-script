using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02001C17 RID: 7191
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class FragmentMemoryActivityController : ActivityControllerBase
{
	// Token: 0x0600D7AD RID: 55213 RVA: 0x0031EFCC File Offset: 0x0031D1CC
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x0600D7AE RID: 55214 RVA: 0x0031EFCE File Offset: 0x0031D1CE
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_ActivityProcessMemory";
	}

	// Token: 0x0600D7AF RID: 55215 RVA: 0x0031EFD5 File Offset: 0x0031D1D5
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new FragmentMemorySubView();
	}

	// Token: 0x0600D7B0 RID: 55216 RVA: 0x0031EFDC File Offset: 0x0031D1DC
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		return new FragmentMemoryActivityData();
	}

	// Token: 0x0600D7B1 RID: 55217 RVA: 0x0031EFE3 File Offset: 0x0031D1E3
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x170011B3 RID: 4531
	// (get) Token: 0x0600D7B2 RID: 55218 RVA: 0x0031EFE6 File Offset: 0x0031D1E6
	public static FragmentMemoryActivityController Instance
	{
		get
		{
			return FragmentMemoryActivityController._Instance;
		}
	}

	// Token: 0x0600D7B3 RID: 55219 RVA: 0x0031EFED File Offset: 0x0031D1ED
	public static FragmentMemoryActivityController GetOrCreateInstance()
	{
		if (FragmentMemoryActivityController._Instance == null)
		{
			FragmentMemoryActivityController.CreateInstance();
		}
		return FragmentMemoryActivityController._Instance;
	}

	// Token: 0x0600D7B4 RID: 55220 RVA: 0x0031F001 File Offset: 0x0031D201
	public static bool CreateInstance()
	{
		if (FragmentMemoryActivityController._Instance != null)
		{
			return true;
		}
		FragmentMemoryActivityController._Instance = new FragmentMemoryActivityController();
		return true;
	}

	// Token: 0x0600D7B5 RID: 55221 RVA: 0x0031F017 File Offset: 0x0031D217
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600D7B6 RID: 55222 RVA: 0x0031F019 File Offset: 0x0031D219
	public static void ResetStaticDefaultValue()
	{
		FragmentMemoryActivityController._Instance = null;
	}

	// Token: 0x0600D7B7 RID: 55223 RVA: 0x0031F021 File Offset: 0x0031D221
	static FragmentMemoryActivityController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FragmentMemoryActivityController.CreateStaticDefaultValue), new Action(FragmentMemoryActivityController.ResetStaticDefaultValue));
	}

	// Token: 0x0400627F RID: 25215
	[Nullable(2)]
	private static FragmentMemoryActivityController _Instance;
}
