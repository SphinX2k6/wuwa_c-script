using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020008E5 RID: 2277
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class ActivityPrizeDrawingConfig : ConfigBase
{
	// Token: 0x06006579 RID: 25977 RVA: 0x001FBD32 File Offset: 0x001F9F32
	public KujiActivity? GetKujiActivityByActivityId(int activityId)
	{
		return ConfigKujiActivityByActivityId.GetConfig(activityId, true);
	}

	// Token: 0x0600657A RID: 25978 RVA: 0x001FBD3B File Offset: 0x001F9F3B
	public KujiAwardsGroup? GetKujiAwardsGroupById(int id)
	{
		return ConfigKujiAwardsGroupById.GetConfig(id, true);
	}

	// Token: 0x0600657B RID: 25979 RVA: 0x001FBD44 File Offset: 0x001F9F44
	[NullableContext(2)]
	public IReadOnlyList<KujiAwardsGroup> GetKujiAwardsGroupByKujiId(int kujiId)
	{
		return ConfigKujiAwardsGroupByKujiId.GetConfigList(kujiId, true);
	}

	// Token: 0x0600657C RID: 25980 RVA: 0x001FBD4D File Offset: 0x001F9F4D
	public KujiQuest? GetKujiQuestConfigById(int id)
	{
		return ConfigKujiQuestById.GetConfig(id, true);
	}

	// Token: 0x0600657D RID: 25981 RVA: 0x001FBD56 File Offset: 0x001F9F56
	[NullableContext(2)]
	public IReadOnlyList<KujiQuest> GetKujiQuestConfigByKujiId(int kujiId)
	{
		return ConfigKujiQuestByKujiId.GetConfigList(kujiId, true);
	}

	// Token: 0x17000CE8 RID: 3304
	// (get) Token: 0x0600657E RID: 25982 RVA: 0x001FBD5F File Offset: 0x001F9F5F
	public static ActivityPrizeDrawingConfig Instance
	{
		get
		{
			return ActivityPrizeDrawingConfig._Instance;
		}
	}

	// Token: 0x0600657F RID: 25983 RVA: 0x001FBD66 File Offset: 0x001F9F66
	public static ActivityPrizeDrawingConfig GetOrCreateInstance()
	{
		if (ActivityPrizeDrawingConfig._Instance == null)
		{
			ActivityPrizeDrawingConfig.CreateInstance();
		}
		return ActivityPrizeDrawingConfig._Instance;
	}

	// Token: 0x06006580 RID: 25984 RVA: 0x001FBD7A File Offset: 0x001F9F7A
	public static bool CreateInstance()
	{
		if (ActivityPrizeDrawingConfig._Instance != null)
		{
			return true;
		}
		ActivityPrizeDrawingConfig._Instance = new ActivityPrizeDrawingConfig();
		return true;
	}

	// Token: 0x06006581 RID: 25985 RVA: 0x001FBD90 File Offset: 0x001F9F90
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06006582 RID: 25986 RVA: 0x001FBD92 File Offset: 0x001F9F92
	public static void ResetStaticDefaultValue()
	{
		ActivityPrizeDrawingConfig._Instance = null;
	}

	// Token: 0x06006583 RID: 25987 RVA: 0x001FBD9A File Offset: 0x001F9F9A
	static ActivityPrizeDrawingConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityPrizeDrawingConfig.CreateStaticDefaultValue), new Action(ActivityPrizeDrawingConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04004139 RID: 16697
	[Nullable(2)]
	private static ActivityPrizeDrawingConfig _Instance;
}
