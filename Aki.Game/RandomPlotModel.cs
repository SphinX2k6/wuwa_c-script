using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001C2A RID: 7210
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class RandomPlotModel : ModelBase
{
	// Token: 0x17001B35 RID: 6965
	// (get) Token: 0x06011EAE RID: 73390 RVA: 0x005463E0 File Offset: 0x005445E0
	public static RandomPlotModel Instance
	{
		get
		{
			return RandomPlotModel._Instance;
		}
	}

	// Token: 0x06011EAF RID: 73391 RVA: 0x005463E7 File Offset: 0x005445E7
	public static RandomPlotModel GetOrCreateInstance()
	{
		if (RandomPlotModel._Instance == null)
		{
			RandomPlotModel.CreateInstance();
		}
		return RandomPlotModel._Instance;
	}

	// Token: 0x06011EB0 RID: 73392 RVA: 0x005463FB File Offset: 0x005445FB
	public static bool CreateInstance()
	{
		if (RandomPlotModel._Instance != null)
		{
			return true;
		}
		RandomPlotModel._Instance = new RandomPlotModel();
		return true;
	}

	// Token: 0x06011EB1 RID: 73393 RVA: 0x00546411 File Offset: 0x00544611
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06011EB2 RID: 73394 RVA: 0x00546413 File Offset: 0x00544613
	public static void ResetStaticDefaultValue()
	{
		RandomPlotModel._Instance = null;
	}

	// Token: 0x06011EB3 RID: 73395 RVA: 0x0054641B File Offset: 0x0054461B
	static RandomPlotModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RandomPlotModel.CreateStaticDefaultValue), new Action(RandomPlotModel.ResetStaticDefaultValue));
	}

	// Token: 0x04009C34 RID: 39988
	public Dictionary<int, RandomPlotItem> RandomPlotMap = new Dictionary<int, RandomPlotItem>();

	// Token: 0x04009C35 RID: 39989
	public Dictionary<int, int[]> InstanceTriggerGroupMap = new Dictionary<int, int[]>();

	// Token: 0x04009C36 RID: 39990
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Dictionary<int, IRandomPlotCondition> InstanceConditionMap;

	// Token: 0x04009C37 RID: 39991
	[Nullable(2)]
	private static RandomPlotModel _Instance;
}
