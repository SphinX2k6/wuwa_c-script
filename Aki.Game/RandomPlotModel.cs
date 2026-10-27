using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200273F RID: 10047
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class RandomPlotModel : ModelBase
{
	// Token: 0x17001AFD RID: 6909
	// (get) Token: 0x060149CC RID: 84428 RVA: 0x005376D4 File Offset: 0x005358D4
	public static RandomPlotModel Instance
	{
		get
		{
			return RandomPlotModel._Instance;
		}
	}

	// Token: 0x060149CD RID: 84429 RVA: 0x005376DB File Offset: 0x005358DB
	public static RandomPlotModel GetOrCreateInstance()
	{
		if (RandomPlotModel._Instance == null)
		{
			RandomPlotModel.CreateInstance();
		}
		return RandomPlotModel._Instance;
	}

	// Token: 0x060149CE RID: 84430 RVA: 0x005376EF File Offset: 0x005358EF
	public static bool CreateInstance()
	{
		if (RandomPlotModel._Instance != null)
		{
			return true;
		}
		RandomPlotModel._Instance = new RandomPlotModel();
		return true;
	}

	// Token: 0x060149CF RID: 84431 RVA: 0x00537705 File Offset: 0x00535905
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060149D0 RID: 84432 RVA: 0x00537707 File Offset: 0x00535907
	public static void ResetStaticDefaultValue()
	{
		RandomPlotModel._Instance = null;
	}

	// Token: 0x060149D1 RID: 84433 RVA: 0x0053770F File Offset: 0x0053590F
	static RandomPlotModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RandomPlotModel.CreateStaticDefaultValue), new Action(RandomPlotModel.ResetStaticDefaultValue));
	}

	// Token: 0x04009ADC RID: 39644
	public Dictionary<int, RandomPlotItem> RandomPlotMap = new Dictionary<int, RandomPlotItem>();

	// Token: 0x04009ADD RID: 39645
	public Dictionary<int, int[]> InstanceTriggerGroupMap = new Dictionary<int, int[]>();

	// Token: 0x04009ADE RID: 39646
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Dictionary<int, IRandomPlotCondition> InstanceConditionMap;

	// Token: 0x04009ADF RID: 39647
	[Nullable(2)]
	private static RandomPlotModel _Instance;
}
