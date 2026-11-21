using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02000696 RID: 1686
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class ActivityCollectionConfig : ConfigBase
{
	// Token: 0x06004DA6 RID: 19878 RVA: 0x001A4050 File Offset: 0x001A2250
	public GatherActivity GetActivityCollectionConfig(int id)
	{
		return ConfigGatherActivityById.GetConfig(id, true).Value;
	}

	// Token: 0x06004DA7 RID: 19879 RVA: 0x001A406C File Offset: 0x001A226C
	public IReadOnlyList<GatherActivity> GetAllActivityCollectionConfig()
	{
		return ConfigGatherActivityAll.GetConfigList(true);
	}

	// Token: 0x17000A8A RID: 2698
	// (get) Token: 0x06004DA8 RID: 19880 RVA: 0x001A4074 File Offset: 0x001A2274
	public static ActivityCollectionConfig Instance
	{
		get
		{
			return ActivityCollectionConfig._Instance;
		}
	}

	// Token: 0x06004DA9 RID: 19881 RVA: 0x001A407B File Offset: 0x001A227B
	public static ActivityCollectionConfig GetOrCreateInstance()
	{
		if (ActivityCollectionConfig._Instance == null)
		{
			ActivityCollectionConfig.CreateInstance();
		}
		return ActivityCollectionConfig._Instance;
	}

	// Token: 0x06004DAA RID: 19882 RVA: 0x001A408F File Offset: 0x001A228F
	public static bool CreateInstance()
	{
		if (ActivityCollectionConfig._Instance != null)
		{
			return true;
		}
		ActivityCollectionConfig._Instance = new ActivityCollectionConfig();
		return true;
	}

	// Token: 0x06004DAB RID: 19883 RVA: 0x001A40A5 File Offset: 0x001A22A5
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06004DAC RID: 19884 RVA: 0x001A40A7 File Offset: 0x001A22A7
	public static void ResetStaticDefaultValue()
	{
		ActivityCollectionConfig._Instance = null;
	}

	// Token: 0x06004DAD RID: 19885 RVA: 0x001A40AF File Offset: 0x001A22AF
	static ActivityCollectionConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityCollectionConfig.CreateStaticDefaultValue), new Action(ActivityCollectionConfig.ResetStaticDefaultValue));
	}

	// Token: 0x040038A1 RID: 14497
	[Nullable(2)]
	private static ActivityCollectionConfig _Instance;
}
