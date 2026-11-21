using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020009DD RID: 2525
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class ActivityTowerGuideConfig : ConfigBase
{
	// Token: 0x06006E45 RID: 28229 RVA: 0x00220B23 File Offset: 0x0021ED23
	public TowerGuide? GetTowerGuideById(int id)
	{
		return ConfigTowerGuideById.GetConfig(id, true);
	}

	// Token: 0x17000D65 RID: 3429
	// (get) Token: 0x06006E46 RID: 28230 RVA: 0x00220B2C File Offset: 0x0021ED2C
	public static ActivityTowerGuideConfig Instance
	{
		get
		{
			return ActivityTowerGuideConfig._Instance;
		}
	}

	// Token: 0x06006E47 RID: 28231 RVA: 0x00220B33 File Offset: 0x0021ED33
	public static ActivityTowerGuideConfig GetOrCreateInstance()
	{
		if (ActivityTowerGuideConfig._Instance == null)
		{
			ActivityTowerGuideConfig.CreateInstance();
		}
		return ActivityTowerGuideConfig._Instance;
	}

	// Token: 0x06006E48 RID: 28232 RVA: 0x00220B47 File Offset: 0x0021ED47
	public static bool CreateInstance()
	{
		if (ActivityTowerGuideConfig._Instance != null)
		{
			return true;
		}
		ActivityTowerGuideConfig._Instance = new ActivityTowerGuideConfig();
		return true;
	}

	// Token: 0x06006E49 RID: 28233 RVA: 0x00220B5D File Offset: 0x0021ED5D
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06006E4A RID: 28234 RVA: 0x00220B5F File Offset: 0x0021ED5F
	public static void ResetStaticDefaultValue()
	{
		ActivityTowerGuideConfig._Instance = null;
	}

	// Token: 0x06006E4B RID: 28235 RVA: 0x00220B67 File Offset: 0x0021ED67
	static ActivityTowerGuideConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityTowerGuideConfig.CreateStaticDefaultValue), new Action(ActivityTowerGuideConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04004499 RID: 17561
	[Nullable(2)]
	private static ActivityTowerGuideConfig _Instance;
}
