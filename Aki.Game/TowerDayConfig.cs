using System;
using System.Runtime.CompilerServices;

// Token: 0x02002BD5 RID: 11221
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class TowerDayConfig : ConfigBase
{
	// Token: 0x17001F66 RID: 8038
	// (get) Token: 0x060174D9 RID: 95449 RVA: 0x005ECA45 File Offset: 0x005EAC45
	public static TowerDayConfig Instance
	{
		get
		{
			return TowerDayConfig._Instance;
		}
	}

	// Token: 0x060174DA RID: 95450 RVA: 0x005ECA4C File Offset: 0x005EAC4C
	public static TowerDayConfig GetOrCreateInstance()
	{
		if (TowerDayConfig._Instance == null)
		{
			TowerDayConfig.CreateInstance();
		}
		return TowerDayConfig._Instance;
	}

	// Token: 0x060174DB RID: 95451 RVA: 0x005ECA60 File Offset: 0x005EAC60
	public static bool CreateInstance()
	{
		if (TowerDayConfig._Instance != null)
		{
			return true;
		}
		TowerDayConfig._Instance = new TowerDayConfig();
		return true;
	}

	// Token: 0x060174DC RID: 95452 RVA: 0x005ECA76 File Offset: 0x005EAC76
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060174DD RID: 95453 RVA: 0x005ECA78 File Offset: 0x005EAC78
	public static void ResetStaticDefaultValue()
	{
		TowerDayConfig._Instance = null;
	}

	// Token: 0x060174DE RID: 95454 RVA: 0x005ECA80 File Offset: 0x005EAC80
	static TowerDayConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TowerDayConfig.CreateStaticDefaultValue), new Action(TowerDayConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400AE6E RID: 44654
	[Nullable(2)]
	private static TowerDayConfig _Instance;
}
