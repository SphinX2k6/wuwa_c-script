using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02003500 RID: 13568
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class EntityOwnerConfig : ConfigBase
{
	// Token: 0x0601DBEE RID: 121838 RVA: 0x008555CC File Offset: 0x008537CC
	public EntityOwnerData? GetEntityOwnerConfig(string guid)
	{
		EntityOwnerData? config = ConfigEntityOwnerDataByGuid.GetConfig(guid, true);
		if (config == null)
		{
			return null;
		}
		return config;
	}

	// Token: 0x0601DBEF RID: 121839 RVA: 0x008555F8 File Offset: 0x008537F8
	public EntityOwnerData? CheckEntityOwnerConfig(string guid)
	{
		IReadOnlyList<EntityOwnerData> configList = ConfigEntityOwnerDataById.GetConfigList(guid, true);
		if (configList == null || configList.Count == 0)
		{
			return null;
		}
		return new EntityOwnerData?(configList[0]);
	}

	// Token: 0x17002902 RID: 10498
	// (get) Token: 0x0601DBF0 RID: 121840 RVA: 0x0085562E File Offset: 0x0085382E
	public static EntityOwnerConfig Instance
	{
		get
		{
			return EntityOwnerConfig._Instance;
		}
	}

	// Token: 0x0601DBF1 RID: 121841 RVA: 0x00855635 File Offset: 0x00853835
	public static EntityOwnerConfig GetOrCreateInstance()
	{
		if (EntityOwnerConfig._Instance == null)
		{
			EntityOwnerConfig.CreateInstance();
		}
		return EntityOwnerConfig._Instance;
	}

	// Token: 0x0601DBF2 RID: 121842 RVA: 0x00855649 File Offset: 0x00853849
	public static bool CreateInstance()
	{
		if (EntityOwnerConfig._Instance != null)
		{
			return true;
		}
		EntityOwnerConfig._Instance = new EntityOwnerConfig();
		return true;
	}

	// Token: 0x0601DBF3 RID: 121843 RVA: 0x0085565F File Offset: 0x0085385F
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601DBF4 RID: 121844 RVA: 0x00855661 File Offset: 0x00853861
	public static void ResetStaticDefaultValue()
	{
		EntityOwnerConfig._Instance = null;
	}

	// Token: 0x0601DBF5 RID: 121845 RVA: 0x00855669 File Offset: 0x00853869
	static EntityOwnerConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(EntityOwnerConfig.CreateStaticDefaultValue), new Action(EntityOwnerConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400E988 RID: 59784
	[Nullable(2)]
	private static EntityOwnerConfig _Instance;
}
