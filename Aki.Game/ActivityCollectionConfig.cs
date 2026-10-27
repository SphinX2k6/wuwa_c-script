using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020011E2 RID: 4578
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class ActivityCollectionConfig : ConfigBase
{
	// Token: 0x06007A0F RID: 31247 RVA: 0x0019B3A4 File Offset: 0x001995A4
	public GatherActivity GetActivityCollectionConfig(int id)
	{
		return ConfigGatherActivityById.GetConfig(id, true).Value;
	}

	// Token: 0x06007A10 RID: 31248 RVA: 0x0019B3C0 File Offset: 0x001995C0
	public IReadOnlyList<GatherActivity> GetAllActivityCollectionConfig()
	{
		return ConfigGatherActivityAll.GetConfigList(true);
	}

	// Token: 0x17000A6A RID: 2666
	// (get) Token: 0x06007A11 RID: 31249 RVA: 0x0019B3C8 File Offset: 0x001995C8
	public static ActivityCollectionConfig Instance
	{
		get
		{
			return ActivityCollectionConfig._Instance;
		}
	}

	// Token: 0x06007A12 RID: 31250 RVA: 0x0019B3CF File Offset: 0x001995CF
	public static ActivityCollectionConfig GetOrCreateInstance()
	{
		if (ActivityCollectionConfig._Instance == null)
		{
			ActivityCollectionConfig.CreateInstance();
		}
		return ActivityCollectionConfig._Instance;
	}

	// Token: 0x06007A13 RID: 31251 RVA: 0x0019B3E3 File Offset: 0x001995E3
	public static bool CreateInstance()
	{
		if (ActivityCollectionConfig._Instance != null)
		{
			return true;
		}
		ActivityCollectionConfig._Instance = new ActivityCollectionConfig();
		return true;
	}

	// Token: 0x06007A14 RID: 31252 RVA: 0x0019B3F9 File Offset: 0x001995F9
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06007A15 RID: 31253 RVA: 0x0019B3FB File Offset: 0x001995FB
	public static void ResetStaticDefaultValue()
	{
		ActivityCollectionConfig._Instance = null;
	}

	// Token: 0x06007A16 RID: 31254 RVA: 0x0019B403 File Offset: 0x00199603
	static ActivityCollectionConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityCollectionConfig.CreateStaticDefaultValue), new Action(ActivityCollectionConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04003808 RID: 14344
	[Nullable(2)]
	private static ActivityCollectionConfig _Instance;
}
