using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020017C0 RID: 6080
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class ComboTeachingConfig : ConfigBase
{
	// Token: 0x0600B18A RID: 45450 RVA: 0x00282FA7 File Offset: 0x002811A7
	public ComboTeaching? GetComboTeachingConfig(int comboId)
	{
		return ConfigComboTeachingById.GetConfig(comboId, true);
	}

	// Token: 0x0600B18B RID: 45451 RVA: 0x00282FB0 File Offset: 0x002811B0
	public ComboTeachingCondition? GetComboTeachingConditionConfig(int comboConditionId)
	{
		return ConfigComboTeachingConditionById.GetConfig(comboConditionId, true);
	}

	// Token: 0x17000EBD RID: 3773
	// (get) Token: 0x0600B18C RID: 45452 RVA: 0x00282FB9 File Offset: 0x002811B9
	public static ComboTeachingConfig Instance
	{
		get
		{
			return ComboTeachingConfig._Instance;
		}
	}

	// Token: 0x0600B18D RID: 45453 RVA: 0x00282FC0 File Offset: 0x002811C0
	public static ComboTeachingConfig GetOrCreateInstance()
	{
		if (ComboTeachingConfig._Instance == null)
		{
			ComboTeachingConfig.CreateInstance();
		}
		return ComboTeachingConfig._Instance;
	}

	// Token: 0x0600B18E RID: 45454 RVA: 0x00282FD4 File Offset: 0x002811D4
	public static bool CreateInstance()
	{
		if (ComboTeachingConfig._Instance != null)
		{
			return true;
		}
		ComboTeachingConfig._Instance = new ComboTeachingConfig();
		return true;
	}

	// Token: 0x0600B18F RID: 45455 RVA: 0x00282FEA File Offset: 0x002811EA
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600B190 RID: 45456 RVA: 0x00282FEC File Offset: 0x002811EC
	public static void ResetStaticDefaultValue()
	{
		ComboTeachingConfig._Instance = null;
	}

	// Token: 0x0600B191 RID: 45457 RVA: 0x00282FF4 File Offset: 0x002811F4
	static ComboTeachingConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ComboTeachingConfig.CreateStaticDefaultValue), new Action(ComboTeachingConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400508B RID: 20619
	[Nullable(2)]
	private static ComboTeachingConfig _Instance;
}
