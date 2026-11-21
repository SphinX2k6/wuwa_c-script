using System;
using System.Runtime.CompilerServices;

// Token: 0x02002150 RID: 8528
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class TowerDayConfig : ConfigBase
{
	// Token: 0x17001FBE RID: 8126
	// (get) Token: 0x06014F0A RID: 85770 RVA: 0x00619581 File Offset: 0x00617781
	public static TowerDayConfig Instance
	{
		get
		{
			return TowerDayConfig._Instance;
		}
	}

	// Token: 0x06014F0B RID: 85771 RVA: 0x00619588 File Offset: 0x00617788
	public static TowerDayConfig GetOrCreateInstance()
	{
		if (TowerDayConfig._Instance == null)
		{
			TowerDayConfig.CreateInstance();
		}
		return TowerDayConfig._Instance;
	}

	// Token: 0x06014F0C RID: 85772 RVA: 0x0061959C File Offset: 0x0061779C
	public static bool CreateInstance()
	{
		if (TowerDayConfig._Instance != null)
		{
			return true;
		}
		TowerDayConfig._Instance = new TowerDayConfig();
		return true;
	}

	// Token: 0x06014F0D RID: 85773 RVA: 0x006195B2 File Offset: 0x006177B2
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06014F0E RID: 85774 RVA: 0x006195B4 File Offset: 0x006177B4
	public static void ResetStaticDefaultValue()
	{
		TowerDayConfig._Instance = null;
	}

	// Token: 0x06014F0F RID: 85775 RVA: 0x006195BC File Offset: 0x006177BC
	static TowerDayConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TowerDayConfig.CreateStaticDefaultValue), new Action(TowerDayConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400B273 RID: 45683
	[Nullable(2)]
	private static TowerDayConfig _Instance;
}
