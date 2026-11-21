using System;
using System.Runtime.CompilerServices;

// Token: 0x020009B8 RID: 2488
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class ActivitySevenDaySignModel : ModelBase
{
	// Token: 0x06006D29 RID: 27945 RVA: 0x0021CE61 File Offset: 0x0021B061
	protected override bool OnInit()
	{
		return true;
	}

	// Token: 0x06006D2A RID: 27946 RVA: 0x0021CE64 File Offset: 0x0021B064
	protected override bool OnClear()
	{
		return true;
	}

	// Token: 0x17000D4E RID: 3406
	// (get) Token: 0x06006D2B RID: 27947 RVA: 0x0021CE67 File Offset: 0x0021B067
	public static ActivitySevenDaySignModel Instance
	{
		get
		{
			return ActivitySevenDaySignModel._Instance;
		}
	}

	// Token: 0x06006D2C RID: 27948 RVA: 0x0021CE6E File Offset: 0x0021B06E
	public static ActivitySevenDaySignModel GetOrCreateInstance()
	{
		if (ActivitySevenDaySignModel._Instance == null)
		{
			ActivitySevenDaySignModel.CreateInstance();
		}
		return ActivitySevenDaySignModel._Instance;
	}

	// Token: 0x06006D2D RID: 27949 RVA: 0x0021CE82 File Offset: 0x0021B082
	public static bool CreateInstance()
	{
		if (ActivitySevenDaySignModel._Instance != null)
		{
			return true;
		}
		ActivitySevenDaySignModel._Instance = new ActivitySevenDaySignModel();
		return true;
	}

	// Token: 0x06006D2E RID: 27950 RVA: 0x0021CE98 File Offset: 0x0021B098
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06006D2F RID: 27951 RVA: 0x0021CE9A File Offset: 0x0021B09A
	public static void ResetStaticDefaultValue()
	{
		ActivitySevenDaySignModel._Instance = null;
	}

	// Token: 0x06006D30 RID: 27952 RVA: 0x0021CEA2 File Offset: 0x0021B0A2
	static ActivitySevenDaySignModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivitySevenDaySignModel.CreateStaticDefaultValue), new Action(ActivitySevenDaySignModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400440E RID: 17422
	[Nullable(2)]
	private static ActivitySevenDaySignModel _Instance;
}
