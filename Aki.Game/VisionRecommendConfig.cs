using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02002448 RID: 9288
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class VisionRecommendConfig : ConfigBase
{
	// Token: 0x06012A08 RID: 76296 RVA: 0x00498DE8 File Offset: 0x00496FE8
	[NullableContext(2)]
	public IReadOnlyList<PhantomOneKeyEquip> GetAllVisionEquipPlanConfig()
	{
		return ConfigPhantomOneKeyEquipAll.GetConfigList(true);
	}

	// Token: 0x17001825 RID: 6181
	// (get) Token: 0x06012A09 RID: 76297 RVA: 0x00498DF0 File Offset: 0x00496FF0
	public static VisionRecommendConfig Instance
	{
		get
		{
			return VisionRecommendConfig._Instance;
		}
	}

	// Token: 0x06012A0A RID: 76298 RVA: 0x00498DF7 File Offset: 0x00496FF7
	public static VisionRecommendConfig GetOrCreateInstance()
	{
		if (VisionRecommendConfig._Instance == null)
		{
			VisionRecommendConfig.CreateInstance();
		}
		return VisionRecommendConfig._Instance;
	}

	// Token: 0x06012A0B RID: 76299 RVA: 0x00498E0B File Offset: 0x0049700B
	public static bool CreateInstance()
	{
		if (VisionRecommendConfig._Instance != null)
		{
			return true;
		}
		VisionRecommendConfig._Instance = new VisionRecommendConfig();
		return true;
	}

	// Token: 0x06012A0C RID: 76300 RVA: 0x00498E21 File Offset: 0x00497021
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06012A0D RID: 76301 RVA: 0x00498E23 File Offset: 0x00497023
	public static void ResetStaticDefaultValue()
	{
		VisionRecommendConfig._Instance = null;
	}

	// Token: 0x06012A0E RID: 76302 RVA: 0x00498E2B File Offset: 0x0049702B
	static VisionRecommendConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(VisionRecommendConfig.CreateStaticDefaultValue), new Action(VisionRecommendConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04008C61 RID: 35937
	[Nullable(2)]
	private static VisionRecommendConfig _Instance;
}
