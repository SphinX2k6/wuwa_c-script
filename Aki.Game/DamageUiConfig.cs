using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001A04 RID: 6660
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class DamageUiConfig : ConfigBase
{
	// Token: 0x0600C2E9 RID: 49897 RVA: 0x002C0E4D File Offset: 0x002BF04D
	[NullableContext(2)]
	public IReadOnlyList<DamageText> GetAllDamageTextConfig()
	{
		return ConfigDamageTextAll.GetConfigList(true);
	}

	// Token: 0x0600C2EA RID: 49898 RVA: 0x002C0E55 File Offset: 0x002BF055
	[NullableContext(2)]
	public IReadOnlyList<DamageTextArea> GetAllDamageTextArea()
	{
		return ConfigDamageTextAreaAll.GetConfigList(true);
	}

	// Token: 0x17001048 RID: 4168
	// (get) Token: 0x0600C2EB RID: 49899 RVA: 0x002C0E5D File Offset: 0x002BF05D
	public static DamageUiConfig Instance
	{
		get
		{
			return DamageUiConfig._Instance;
		}
	}

	// Token: 0x0600C2EC RID: 49900 RVA: 0x002C0E64 File Offset: 0x002BF064
	public static DamageUiConfig GetOrCreateInstance()
	{
		if (DamageUiConfig._Instance == null)
		{
			DamageUiConfig.CreateInstance();
		}
		return DamageUiConfig._Instance;
	}

	// Token: 0x0600C2ED RID: 49901 RVA: 0x002C0E78 File Offset: 0x002BF078
	public static bool CreateInstance()
	{
		if (DamageUiConfig._Instance != null)
		{
			return true;
		}
		DamageUiConfig._Instance = new DamageUiConfig();
		return true;
	}

	// Token: 0x0600C2EE RID: 49902 RVA: 0x002C0E8E File Offset: 0x002BF08E
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600C2EF RID: 49903 RVA: 0x002C0E90 File Offset: 0x002BF090
	public static void ResetStaticDefaultValue()
	{
		DamageUiConfig._Instance = null;
	}

	// Token: 0x0600C2F0 RID: 49904 RVA: 0x002C0E98 File Offset: 0x002BF098
	static DamageUiConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(DamageUiConfig.CreateStaticDefaultValue), new Action(DamageUiConfig.ResetStaticDefaultValue));
	}

	// Token: 0x040059E8 RID: 23016
	[Nullable(2)]
	private static DamageUiConfig _Instance;
}
