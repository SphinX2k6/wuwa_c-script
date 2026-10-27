using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001525 RID: 5413
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class ActivityTowerGuideConfig : ConfigBase
{
	// Token: 0x06009A67 RID: 39527 RVA: 0x00216D87 File Offset: 0x00214F87
	public TowerGuide? GetTowerGuideById(int id)
	{
		return ConfigTowerGuideById.GetConfig(id, true);
	}

	// Token: 0x17000D44 RID: 3396
	// (get) Token: 0x06009A68 RID: 39528 RVA: 0x00216D90 File Offset: 0x00214F90
	public static ActivityTowerGuideConfig Instance
	{
		get
		{
			return ActivityTowerGuideConfig._Instance;
		}
	}

	// Token: 0x06009A69 RID: 39529 RVA: 0x00216D97 File Offset: 0x00214F97
	public static ActivityTowerGuideConfig GetOrCreateInstance()
	{
		if (ActivityTowerGuideConfig._Instance == null)
		{
			ActivityTowerGuideConfig.CreateInstance();
		}
		return ActivityTowerGuideConfig._Instance;
	}

	// Token: 0x06009A6A RID: 39530 RVA: 0x00216DAB File Offset: 0x00214FAB
	public static bool CreateInstance()
	{
		if (ActivityTowerGuideConfig._Instance != null)
		{
			return true;
		}
		ActivityTowerGuideConfig._Instance = new ActivityTowerGuideConfig();
		return true;
	}

	// Token: 0x06009A6B RID: 39531 RVA: 0x00216DC1 File Offset: 0x00214FC1
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06009A6C RID: 39532 RVA: 0x00216DC3 File Offset: 0x00214FC3
	public static void ResetStaticDefaultValue()
	{
		ActivityTowerGuideConfig._Instance = null;
	}

	// Token: 0x06009A6D RID: 39533 RVA: 0x00216DCB File Offset: 0x00214FCB
	static ActivityTowerGuideConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityTowerGuideConfig.CreateStaticDefaultValue), new Action(ActivityTowerGuideConfig.ResetStaticDefaultValue));
	}

	// Token: 0x040043F3 RID: 17395
	[Nullable(2)]
	private static ActivityTowerGuideConfig _Instance;
}
