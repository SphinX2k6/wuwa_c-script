using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02000578 RID: 1400
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class AdvanceNoticeConfig : ConfigBase
{
	// Token: 0x06004373 RID: 17267 RVA: 0x00175338 File Offset: 0x00173538
	public AdvertisingPageInfo GetAdvertisingPageInfoById(int id)
	{
		return ConfigAdvertisingPageInfoById.GetConfig(id, true).Value;
	}

	// Token: 0x06004374 RID: 17268 RVA: 0x00175354 File Offset: 0x00173554
	public AdvertisingPageInfo GetAdvertisingPageInfoByActivityId(int activityId)
	{
		return ConfigAdvertisingPageInfoByActivityId.GetConfig(activityId, true).Value;
	}

	// Token: 0x06004375 RID: 17269 RVA: 0x00175370 File Offset: 0x00173570
	public AdvertisingTabInfo GetAdvertisingTabInfoById(int id)
	{
		return ConfigAdvertisingTabInfoById.GetConfig(id, true).Value;
	}

	// Token: 0x06004376 RID: 17270 RVA: 0x0017538C File Offset: 0x0017358C
	public AdvertisingTabCharacter GetAdvertisingTabCharacterById(int childTabId)
	{
		return ConfigAdvertisingTabCharacterById.GetConfig(childTabId, true).Value;
	}

	// Token: 0x06004377 RID: 17271 RVA: 0x001753A8 File Offset: 0x001735A8
	public AdvertisingTabEnemy GetAdvertisingTabEnemyById(int childTabId)
	{
		return ConfigAdvertisingTabEnemyById.GetConfig(childTabId, true).Value;
	}

	// Token: 0x06004378 RID: 17272 RVA: 0x001753C4 File Offset: 0x001735C4
	public AdvertisingTabStory GetAdvertisingTabStoryById(int childTabId)
	{
		return ConfigAdvertisingTabStoryById.GetConfig(childTabId, true).Value;
	}

	// Token: 0x06004379 RID: 17273 RVA: 0x001753E0 File Offset: 0x001735E0
	public AdvertisingTabRegion GetAdvertisingTabRegionById(int childTabId)
	{
		return ConfigAdvertisingTabRegionById.GetConfig(childTabId, true).Value;
	}

	// Token: 0x0600437A RID: 17274 RVA: 0x001753FC File Offset: 0x001735FC
	public AdvertisingTabCostume GetAdvertisingTabCostumeById(int childTabId)
	{
		return ConfigAdvertisingTabCostumeById.GetConfig(childTabId, true).Value;
	}

	// Token: 0x0600437B RID: 17275 RVA: 0x00175418 File Offset: 0x00173618
	public AdvertisingTabActivity GetAdvertisingTabActivityById(int childTabId)
	{
		return ConfigAdvertisingTabActivityById.GetConfig(childTabId, true).Value;
	}

	// Token: 0x0600437C RID: 17276 RVA: 0x00175434 File Offset: 0x00173634
	public AdvertisingTabSystem GetAdvertisingTabSystemById(int childTabId)
	{
		return ConfigAdvertisingTabSystemById.GetConfig(childTabId, true).Value;
	}

	// Token: 0x0600437D RID: 17277 RVA: 0x00175450 File Offset: 0x00173650
	public AdvertisingUrlConfig GetAdvertisingUrlConfigById(int id)
	{
		return ConfigAdvertisingUrlConfigById.GetConfig(id, true).Value;
	}

	// Token: 0x1700099C RID: 2460
	// (get) Token: 0x0600437E RID: 17278 RVA: 0x0017546C File Offset: 0x0017366C
	public static AdvanceNoticeConfig Instance
	{
		get
		{
			return AdvanceNoticeConfig._Instance;
		}
	}

	// Token: 0x0600437F RID: 17279 RVA: 0x00175473 File Offset: 0x00173673
	public static AdvanceNoticeConfig GetOrCreateInstance()
	{
		if (AdvanceNoticeConfig._Instance == null)
		{
			AdvanceNoticeConfig.CreateInstance();
		}
		return AdvanceNoticeConfig._Instance;
	}

	// Token: 0x06004380 RID: 17280 RVA: 0x00175487 File Offset: 0x00173687
	public static bool CreateInstance()
	{
		if (AdvanceNoticeConfig._Instance != null)
		{
			return true;
		}
		AdvanceNoticeConfig._Instance = new AdvanceNoticeConfig();
		return true;
	}

	// Token: 0x06004381 RID: 17281 RVA: 0x0017549D File Offset: 0x0017369D
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06004382 RID: 17282 RVA: 0x0017549F File Offset: 0x0017369F
	public static void ResetStaticDefaultValue()
	{
		AdvanceNoticeConfig._Instance = null;
	}

	// Token: 0x06004383 RID: 17283 RVA: 0x001754A7 File Offset: 0x001736A7
	static AdvanceNoticeConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(AdvanceNoticeConfig.CreateStaticDefaultValue), new Action(AdvanceNoticeConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04003488 RID: 13448
	[Nullable(2)]
	private static AdvanceNoticeConfig _Instance;
}
