using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x0200192D RID: 6445
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class VisionRecommendConfig : ConfigBase
{
	// Token: 0x0600FEBE RID: 65214 RVA: 0x004A63D5 File Offset: 0x004A45D5
	[NullableContext(2)]
	public IReadOnlyList<PhantomOneKeyEquip> GetAllVisionEquipPlanConfig()
	{
		return ConfigPhantomOneKeyEquipAll.GetConfigList(true);
	}

	// Token: 0x1700185F RID: 6239
	// (get) Token: 0x0600FEBF RID: 65215 RVA: 0x004A63DD File Offset: 0x004A45DD
	public static VisionRecommendConfig Instance
	{
		get
		{
			return VisionRecommendConfig._Instance;
		}
	}

	// Token: 0x0600FEC0 RID: 65216 RVA: 0x004A63E4 File Offset: 0x004A45E4
	public static VisionRecommendConfig GetOrCreateInstance()
	{
		if (VisionRecommendConfig._Instance == null)
		{
			VisionRecommendConfig.CreateInstance();
		}
		return VisionRecommendConfig._Instance;
	}

	// Token: 0x0600FEC1 RID: 65217 RVA: 0x004A63F8 File Offset: 0x004A45F8
	public static bool CreateInstance()
	{
		if (VisionRecommendConfig._Instance != null)
		{
			return true;
		}
		VisionRecommendConfig._Instance = new VisionRecommendConfig();
		return true;
	}

	// Token: 0x0600FEC2 RID: 65218 RVA: 0x004A640E File Offset: 0x004A460E
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600FEC3 RID: 65219 RVA: 0x004A6410 File Offset: 0x004A4610
	public static void ResetStaticDefaultValue()
	{
		VisionRecommendConfig._Instance = null;
	}

	// Token: 0x0600FEC4 RID: 65220 RVA: 0x004A6418 File Offset: 0x004A4618
	static VisionRecommendConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(VisionRecommendConfig.CreateStaticDefaultValue), new Action(VisionRecommendConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04008DA8 RID: 36264
	[Nullable(2)]
	private static VisionRecommendConfig _Instance;
}
