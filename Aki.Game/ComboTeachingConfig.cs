using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02000C79 RID: 3193
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class ComboTeachingConfig : ConfigBase
{
	// Token: 0x06008572 RID: 34162 RVA: 0x0028D53F File Offset: 0x0028B73F
	public ComboTeaching? GetComboTeachingConfig(int comboId)
	{
		return ConfigComboTeachingById.GetConfig(comboId, true);
	}

	// Token: 0x06008573 RID: 34163 RVA: 0x0028D548 File Offset: 0x0028B748
	public ComboTeachingCondition? GetComboTeachingConditionConfig(int comboConditionId)
	{
		return ConfigComboTeachingConditionById.GetConfig(comboConditionId, true);
	}

	// Token: 0x17000EE0 RID: 3808
	// (get) Token: 0x06008574 RID: 34164 RVA: 0x0028D551 File Offset: 0x0028B751
	public static ComboTeachingConfig Instance
	{
		get
		{
			return ComboTeachingConfig._Instance;
		}
	}

	// Token: 0x06008575 RID: 34165 RVA: 0x0028D558 File Offset: 0x0028B758
	public static ComboTeachingConfig GetOrCreateInstance()
	{
		if (ComboTeachingConfig._Instance == null)
		{
			ComboTeachingConfig.CreateInstance();
		}
		return ComboTeachingConfig._Instance;
	}

	// Token: 0x06008576 RID: 34166 RVA: 0x0028D56C File Offset: 0x0028B76C
	public static bool CreateInstance()
	{
		if (ComboTeachingConfig._Instance != null)
		{
			return true;
		}
		ComboTeachingConfig._Instance = new ComboTeachingConfig();
		return true;
	}

	// Token: 0x06008577 RID: 34167 RVA: 0x0028D582 File Offset: 0x0028B782
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06008578 RID: 34168 RVA: 0x0028D584 File Offset: 0x0028B784
	public static void ResetStaticDefaultValue()
	{
		ComboTeachingConfig._Instance = null;
	}

	// Token: 0x06008579 RID: 34169 RVA: 0x0028D58C File Offset: 0x0028B78C
	static ComboTeachingConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ComboTeachingConfig.CreateStaticDefaultValue), new Action(ComboTeachingConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04005135 RID: 20789
	[Nullable(2)]
	private static ComboTeachingConfig _Instance;
}
