using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02002A75 RID: 10869
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class EntityOwnerConfig : ConfigBase
{
	// Token: 0x0601B905 RID: 112901 RVA: 0x0087DA20 File Offset: 0x0087BC20
	public EntityOwnerData? GetEntityOwnerConfig(string guid)
	{
		EntityOwnerData? config = ConfigEntityOwnerDataByGuid.GetConfig(guid, true);
		if (config == null)
		{
			return null;
		}
		return config;
	}

	// Token: 0x0601B906 RID: 112902 RVA: 0x0087DA4C File Offset: 0x0087BC4C
	public EntityOwnerData? CheckEntityOwnerConfig(string guid)
	{
		IReadOnlyList<EntityOwnerData> configList = ConfigEntityOwnerDataById.GetConfigList(guid, true);
		if (configList == null || configList.Count == 0)
		{
			return null;
		}
		return new EntityOwnerData?(configList[0]);
	}

	// Token: 0x17002C9B RID: 11419
	// (get) Token: 0x0601B907 RID: 112903 RVA: 0x0087DA82 File Offset: 0x0087BC82
	public static EntityOwnerConfig Instance
	{
		get
		{
			return EntityOwnerConfig._Instance;
		}
	}

	// Token: 0x0601B908 RID: 112904 RVA: 0x0087DA89 File Offset: 0x0087BC89
	public static EntityOwnerConfig GetOrCreateInstance()
	{
		if (EntityOwnerConfig._Instance == null)
		{
			EntityOwnerConfig.CreateInstance();
		}
		return EntityOwnerConfig._Instance;
	}

	// Token: 0x0601B909 RID: 112905 RVA: 0x0087DA9D File Offset: 0x0087BC9D
	public static bool CreateInstance()
	{
		if (EntityOwnerConfig._Instance != null)
		{
			return true;
		}
		EntityOwnerConfig._Instance = new EntityOwnerConfig();
		return true;
	}

	// Token: 0x0601B90A RID: 112906 RVA: 0x0087DAB3 File Offset: 0x0087BCB3
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601B90B RID: 112907 RVA: 0x0087DAB5 File Offset: 0x0087BCB5
	public static void ResetStaticDefaultValue()
	{
		EntityOwnerConfig._Instance = null;
	}

	// Token: 0x0601B90C RID: 112908 RVA: 0x0087DABD File Offset: 0x0087BCBD
	static EntityOwnerConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(EntityOwnerConfig.CreateStaticDefaultValue), new Action(EntityOwnerConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400EE43 RID: 60995
	[Nullable(2)]
	private static EntityOwnerConfig _Instance;
}
