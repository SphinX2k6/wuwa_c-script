using System;
using System.Runtime.CompilerServices;

// Token: 0x02001ED9 RID: 7897
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ScreenShotController : ControllerBase
{
	// Token: 0x06013856 RID: 79958 RVA: 0x005B1489 File Offset: 0x005AF689
	protected override bool OnClear()
	{
		ScreenShotManager.Clear();
		return true;
	}

	// Token: 0x06013857 RID: 79959 RVA: 0x005B1491 File Offset: 0x005AF691
	protected override bool OnLeaveLevel()
	{
		ScreenShotManager.Clear();
		return true;
	}

	// Token: 0x17001DDB RID: 7643
	// (get) Token: 0x06013858 RID: 79960 RVA: 0x005B1499 File Offset: 0x005AF699
	public static ScreenShotController Instance
	{
		get
		{
			return ScreenShotController._Instance;
		}
	}

	// Token: 0x06013859 RID: 79961 RVA: 0x005B14A0 File Offset: 0x005AF6A0
	public static ScreenShotController GetOrCreateInstance()
	{
		if (ScreenShotController._Instance == null)
		{
			ScreenShotController.CreateInstance();
		}
		return ScreenShotController._Instance;
	}

	// Token: 0x0601385A RID: 79962 RVA: 0x005B14B4 File Offset: 0x005AF6B4
	public static bool CreateInstance()
	{
		if (ScreenShotController._Instance != null)
		{
			return true;
		}
		ScreenShotController._Instance = new ScreenShotController();
		return true;
	}

	// Token: 0x0601385B RID: 79963 RVA: 0x005B14CA File Offset: 0x005AF6CA
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601385C RID: 79964 RVA: 0x005B14CC File Offset: 0x005AF6CC
	public static void ResetStaticDefaultValue()
	{
		ScreenShotController._Instance = null;
	}

	// Token: 0x0601385D RID: 79965 RVA: 0x005B14D4 File Offset: 0x005AF6D4
	static ScreenShotController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ScreenShotController.CreateStaticDefaultValue), new Action(ScreenShotController.ResetStaticDefaultValue));
	}

	// Token: 0x0400A6E2 RID: 42722
	[Nullable(2)]
	private static ScreenShotController _Instance;
}
