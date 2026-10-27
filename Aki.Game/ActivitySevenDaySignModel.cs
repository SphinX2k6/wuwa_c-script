using System;
using System.Runtime.CompilerServices;

// Token: 0x02001500 RID: 5376
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class ActivitySevenDaySignModel : ModelBase
{
	// Token: 0x0600994F RID: 39247 RVA: 0x00213149 File Offset: 0x00211349
	protected override bool OnInit()
	{
		return true;
	}

	// Token: 0x06009950 RID: 39248 RVA: 0x0021314C File Offset: 0x0021134C
	protected override bool OnClear()
	{
		return true;
	}

	// Token: 0x17000D2D RID: 3373
	// (get) Token: 0x06009951 RID: 39249 RVA: 0x0021314F File Offset: 0x0021134F
	public static ActivitySevenDaySignModel Instance
	{
		get
		{
			return ActivitySevenDaySignModel._Instance;
		}
	}

	// Token: 0x06009952 RID: 39250 RVA: 0x00213156 File Offset: 0x00211356
	public static ActivitySevenDaySignModel GetOrCreateInstance()
	{
		if (ActivitySevenDaySignModel._Instance == null)
		{
			ActivitySevenDaySignModel.CreateInstance();
		}
		return ActivitySevenDaySignModel._Instance;
	}

	// Token: 0x06009953 RID: 39251 RVA: 0x0021316A File Offset: 0x0021136A
	public static bool CreateInstance()
	{
		if (ActivitySevenDaySignModel._Instance != null)
		{
			return true;
		}
		ActivitySevenDaySignModel._Instance = new ActivitySevenDaySignModel();
		return true;
	}

	// Token: 0x06009954 RID: 39252 RVA: 0x00213180 File Offset: 0x00211380
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06009955 RID: 39253 RVA: 0x00213182 File Offset: 0x00211382
	public static void ResetStaticDefaultValue()
	{
		ActivitySevenDaySignModel._Instance = null;
	}

	// Token: 0x06009956 RID: 39254 RVA: 0x0021318A File Offset: 0x0021138A
	static ActivitySevenDaySignModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivitySevenDaySignModel.CreateStaticDefaultValue), new Action(ActivitySevenDaySignModel.ResetStaticDefaultValue));
	}

	// Token: 0x04004369 RID: 17257
	[Nullable(2)]
	private static ActivitySevenDaySignModel _Instance;
}
