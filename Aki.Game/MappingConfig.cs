using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02000CBB RID: 3259
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class MappingConfig : ConfigBase
{
	// Token: 0x0600881D RID: 34845 RVA: 0x00295C73 File Offset: 0x00293E73
	public string GetWeaponConfComment(string name)
	{
		return ConfigMultiTextLang.GetLocalTextNew(name, null) ?? "";
	}

	// Token: 0x0600881E RID: 34846 RVA: 0x00295C85 File Offset: 0x00293E85
	public IReadOnlyList<Mapping> GetWeaponConfList()
	{
		return ConfigMappingBySheetNameAndFieldName.GetConfigList("WeaponConf", "WeaponType", true);
	}

	// Token: 0x17000F45 RID: 3909
	// (get) Token: 0x0600881F RID: 34847 RVA: 0x00295C97 File Offset: 0x00293E97
	public static MappingConfig Instance
	{
		get
		{
			return MappingConfig._Instance;
		}
	}

	// Token: 0x06008820 RID: 34848 RVA: 0x00295C9E File Offset: 0x00293E9E
	public static MappingConfig GetOrCreateInstance()
	{
		if (MappingConfig._Instance == null)
		{
			MappingConfig.CreateInstance();
		}
		return MappingConfig._Instance;
	}

	// Token: 0x06008821 RID: 34849 RVA: 0x00295CB2 File Offset: 0x00293EB2
	public static bool CreateInstance()
	{
		if (MappingConfig._Instance != null)
		{
			return true;
		}
		MappingConfig._Instance = new MappingConfig();
		return true;
	}

	// Token: 0x06008822 RID: 34850 RVA: 0x00295CC8 File Offset: 0x00293EC8
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06008823 RID: 34851 RVA: 0x00295CCA File Offset: 0x00293ECA
	public static void ResetStaticDefaultValue()
	{
		MappingConfig._Instance = null;
	}

	// Token: 0x06008824 RID: 34852 RVA: 0x00295CD2 File Offset: 0x00293ED2
	static MappingConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MappingConfig.CreateStaticDefaultValue), new Action(MappingConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04005214 RID: 21012
	[Nullable(2)]
	private static MappingConfig _Instance;
}
