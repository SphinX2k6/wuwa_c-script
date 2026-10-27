using System;
using System.Runtime.CompilerServices;

// Token: 0x0200295E RID: 10590
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ScreenShotController : ControllerBase
{
	// Token: 0x06015E52 RID: 89682 RVA: 0x00586489 File Offset: 0x00584689
	protected override bool OnClear()
	{
		ScreenShotManager.Clear();
		return true;
	}

	// Token: 0x06015E53 RID: 89683 RVA: 0x00586491 File Offset: 0x00584691
	protected override bool OnLeaveLevel()
	{
		ScreenShotManager.Clear();
		return true;
	}

	// Token: 0x17001D82 RID: 7554
	// (get) Token: 0x06015E54 RID: 89684 RVA: 0x00586499 File Offset: 0x00584699
	public static ScreenShotController Instance
	{
		get
		{
			return ScreenShotController._Instance;
		}
	}

	// Token: 0x06015E55 RID: 89685 RVA: 0x005864A0 File Offset: 0x005846A0
	public static ScreenShotController GetOrCreateInstance()
	{
		if (ScreenShotController._Instance == null)
		{
			ScreenShotController.CreateInstance();
		}
		return ScreenShotController._Instance;
	}

	// Token: 0x06015E56 RID: 89686 RVA: 0x005864B4 File Offset: 0x005846B4
	public static bool CreateInstance()
	{
		if (ScreenShotController._Instance != null)
		{
			return true;
		}
		ScreenShotController._Instance = new ScreenShotController();
		return true;
	}

	// Token: 0x06015E57 RID: 89687 RVA: 0x005864CA File Offset: 0x005846CA
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06015E58 RID: 89688 RVA: 0x005864CC File Offset: 0x005846CC
	public static void ResetStaticDefaultValue()
	{
		ScreenShotController._Instance = null;
	}

	// Token: 0x06015E59 RID: 89689 RVA: 0x005864D4 File Offset: 0x005846D4
	static ScreenShotController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ScreenShotController.CreateStaticDefaultValue), new Action(ScreenShotController.ResetStaticDefaultValue));
	}

	// Token: 0x0400A2F8 RID: 41720
	[Nullable(2)]
	private static ScreenShotController _Instance;
}
