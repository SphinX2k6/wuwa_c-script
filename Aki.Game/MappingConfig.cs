using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001802 RID: 6146
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class MappingConfig : ConfigBase
{
	// Token: 0x0600B432 RID: 46130 RVA: 0x0028B553 File Offset: 0x00289753
	public string GetWeaponConfComment(string name)
	{
		return ConfigMultiTextLang.GetLocalTextNew(name, null) ?? "";
	}

	// Token: 0x0600B433 RID: 46131 RVA: 0x0028B565 File Offset: 0x00289765
	public IReadOnlyList<Mapping> GetWeaponConfList()
	{
		return ConfigMappingBySheetNameAndFieldName.GetConfigList("WeaponConf", "WeaponType", true);
	}

	// Token: 0x17000F22 RID: 3874
	// (get) Token: 0x0600B434 RID: 46132 RVA: 0x0028B577 File Offset: 0x00289777
	public static MappingConfig Instance
	{
		get
		{
			return MappingConfig._Instance;
		}
	}

	// Token: 0x0600B435 RID: 46133 RVA: 0x0028B57E File Offset: 0x0028977E
	public static MappingConfig GetOrCreateInstance()
	{
		if (MappingConfig._Instance == null)
		{
			MappingConfig.CreateInstance();
		}
		return MappingConfig._Instance;
	}

	// Token: 0x0600B436 RID: 46134 RVA: 0x0028B592 File Offset: 0x00289792
	public static bool CreateInstance()
	{
		if (MappingConfig._Instance != null)
		{
			return true;
		}
		MappingConfig._Instance = new MappingConfig();
		return true;
	}

	// Token: 0x0600B437 RID: 46135 RVA: 0x0028B5A8 File Offset: 0x002897A8
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600B438 RID: 46136 RVA: 0x0028B5AA File Offset: 0x002897AA
	public static void ResetStaticDefaultValue()
	{
		MappingConfig._Instance = null;
	}

	// Token: 0x0600B439 RID: 46137 RVA: 0x0028B5B2 File Offset: 0x002897B2
	static MappingConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MappingConfig.CreateStaticDefaultValue), new Action(MappingConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04005169 RID: 20841
	[Nullable(2)]
	private static MappingConfig _Instance;
}
