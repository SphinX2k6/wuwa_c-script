using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001431 RID: 5169
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class ActivityPrizeDrawingConfig : ConfigBase
{
	// Token: 0x060091E4 RID: 37348 RVA: 0x001F31F6 File Offset: 0x001F13F6
	public KujiActivity? GetKujiActivityByActivityId(int activityId)
	{
		return ConfigKujiActivityByActivityId.GetConfig(activityId, true);
	}

	// Token: 0x060091E5 RID: 37349 RVA: 0x001F31FF File Offset: 0x001F13FF
	public KujiAwardsGroup? GetKujiAwardsGroupById(int id)
	{
		return ConfigKujiAwardsGroupById.GetConfig(id, true);
	}

	// Token: 0x060091E6 RID: 37350 RVA: 0x001F3208 File Offset: 0x001F1408
	[NullableContext(2)]
	public IReadOnlyList<KujiAwardsGroup> GetKujiAwardsGroupByKujiId(int kujiId)
	{
		return ConfigKujiAwardsGroupByKujiId.GetConfigList(kujiId, true);
	}

	// Token: 0x060091E7 RID: 37351 RVA: 0x001F3211 File Offset: 0x001F1411
	public KujiQuest? GetKujiQuestConfigById(int id)
	{
		return ConfigKujiQuestById.GetConfig(id, true);
	}

	// Token: 0x060091E8 RID: 37352 RVA: 0x001F321A File Offset: 0x001F141A
	[NullableContext(2)]
	public IReadOnlyList<KujiQuest> GetKujiQuestConfigByKujiId(int kujiId)
	{
		return ConfigKujiQuestByKujiId.GetConfigList(kujiId, true);
	}

	// Token: 0x17000CC8 RID: 3272
	// (get) Token: 0x060091E9 RID: 37353 RVA: 0x001F3223 File Offset: 0x001F1423
	public static ActivityPrizeDrawingConfig Instance
	{
		get
		{
			return ActivityPrizeDrawingConfig._Instance;
		}
	}

	// Token: 0x060091EA RID: 37354 RVA: 0x001F322A File Offset: 0x001F142A
	public static ActivityPrizeDrawingConfig GetOrCreateInstance()
	{
		if (ActivityPrizeDrawingConfig._Instance == null)
		{
			ActivityPrizeDrawingConfig.CreateInstance();
		}
		return ActivityPrizeDrawingConfig._Instance;
	}

	// Token: 0x060091EB RID: 37355 RVA: 0x001F323E File Offset: 0x001F143E
	public static bool CreateInstance()
	{
		if (ActivityPrizeDrawingConfig._Instance != null)
		{
			return true;
		}
		ActivityPrizeDrawingConfig._Instance = new ActivityPrizeDrawingConfig();
		return true;
	}

	// Token: 0x060091EC RID: 37356 RVA: 0x001F3254 File Offset: 0x001F1454
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060091ED RID: 37357 RVA: 0x001F3256 File Offset: 0x001F1456
	public static void ResetStaticDefaultValue()
	{
		ActivityPrizeDrawingConfig._Instance = null;
	}

	// Token: 0x060091EE RID: 37358 RVA: 0x001F325E File Offset: 0x001F145E
	static ActivityPrizeDrawingConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityPrizeDrawingConfig.CreateStaticDefaultValue), new Action(ActivityPrizeDrawingConfig.ResetStaticDefaultValue));
	}

	// Token: 0x040040A1 RID: 16545
	[Nullable(2)]
	private static ActivityPrizeDrawingConfig _Instance;
}
