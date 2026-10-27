using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020010C4 RID: 4292
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class AdvanceNoticeConfig : ConfigBase
{
	// Token: 0x06006FDD RID: 28637 RVA: 0x0016C97C File Offset: 0x0016AB7C
	public AdvertisingPageInfo GetAdvertisingPageInfoById(int id)
	{
		return ConfigAdvertisingPageInfoById.GetConfig(id, true).Value;
	}

	// Token: 0x06006FDE RID: 28638 RVA: 0x0016C998 File Offset: 0x0016AB98
	public AdvertisingPageInfo GetAdvertisingPageInfoByActivityId(int activityId)
	{
		return ConfigAdvertisingPageInfoByActivityId.GetConfig(activityId, true).Value;
	}

	// Token: 0x06006FDF RID: 28639 RVA: 0x0016C9B4 File Offset: 0x0016ABB4
	public AdvertisingTabInfo GetAdvertisingTabInfoById(int id)
	{
		return ConfigAdvertisingTabInfoById.GetConfig(id, true).Value;
	}

	// Token: 0x06006FE0 RID: 28640 RVA: 0x0016C9D0 File Offset: 0x0016ABD0
	public AdvertisingTabCharacter GetAdvertisingTabCharacterById(int childTabId)
	{
		return ConfigAdvertisingTabCharacterById.GetConfig(childTabId, true).Value;
	}

	// Token: 0x06006FE1 RID: 28641 RVA: 0x0016C9EC File Offset: 0x0016ABEC
	public AdvertisingTabEnemy GetAdvertisingTabEnemyById(int childTabId)
	{
		return ConfigAdvertisingTabEnemyById.GetConfig(childTabId, true).Value;
	}

	// Token: 0x06006FE2 RID: 28642 RVA: 0x0016CA08 File Offset: 0x0016AC08
	public AdvertisingTabStory GetAdvertisingTabStoryById(int childTabId)
	{
		return ConfigAdvertisingTabStoryById.GetConfig(childTabId, true).Value;
	}

	// Token: 0x06006FE3 RID: 28643 RVA: 0x0016CA24 File Offset: 0x0016AC24
	public AdvertisingTabRegion GetAdvertisingTabRegionById(int childTabId)
	{
		return ConfigAdvertisingTabRegionById.GetConfig(childTabId, true).Value;
	}

	// Token: 0x06006FE4 RID: 28644 RVA: 0x0016CA40 File Offset: 0x0016AC40
	public AdvertisingTabCostume GetAdvertisingTabCostumeById(int childTabId)
	{
		return ConfigAdvertisingTabCostumeById.GetConfig(childTabId, true).Value;
	}

	// Token: 0x06006FE5 RID: 28645 RVA: 0x0016CA5C File Offset: 0x0016AC5C
	public AdvertisingTabActivity GetAdvertisingTabActivityById(int childTabId)
	{
		return ConfigAdvertisingTabActivityById.GetConfig(childTabId, true).Value;
	}

	// Token: 0x06006FE6 RID: 28646 RVA: 0x0016CA78 File Offset: 0x0016AC78
	public AdvertisingTabSystem GetAdvertisingTabSystemById(int childTabId)
	{
		return ConfigAdvertisingTabSystemById.GetConfig(childTabId, true).Value;
	}

	// Token: 0x06006FE7 RID: 28647 RVA: 0x0016CA94 File Offset: 0x0016AC94
	public AdvertisingUrlConfig GetAdvertisingUrlConfigById(int id)
	{
		return ConfigAdvertisingUrlConfigById.GetConfig(id, true).Value;
	}

	// Token: 0x1700097C RID: 2428
	// (get) Token: 0x06006FE8 RID: 28648 RVA: 0x0016CAB0 File Offset: 0x0016ACB0
	public static AdvanceNoticeConfig Instance
	{
		get
		{
			return AdvanceNoticeConfig._Instance;
		}
	}

	// Token: 0x06006FE9 RID: 28649 RVA: 0x0016CAB7 File Offset: 0x0016ACB7
	public static AdvanceNoticeConfig GetOrCreateInstance()
	{
		if (AdvanceNoticeConfig._Instance == null)
		{
			AdvanceNoticeConfig.CreateInstance();
		}
		return AdvanceNoticeConfig._Instance;
	}

	// Token: 0x06006FEA RID: 28650 RVA: 0x0016CACB File Offset: 0x0016ACCB
	public static bool CreateInstance()
	{
		if (AdvanceNoticeConfig._Instance != null)
		{
			return true;
		}
		AdvanceNoticeConfig._Instance = new AdvanceNoticeConfig();
		return true;
	}

	// Token: 0x06006FEB RID: 28651 RVA: 0x0016CAE1 File Offset: 0x0016ACE1
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06006FEC RID: 28652 RVA: 0x0016CAE3 File Offset: 0x0016ACE3
	public static void ResetStaticDefaultValue()
	{
		AdvanceNoticeConfig._Instance = null;
	}

	// Token: 0x06006FED RID: 28653 RVA: 0x0016CAEB File Offset: 0x0016ACEB
	static AdvanceNoticeConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(AdvanceNoticeConfig.CreateStaticDefaultValue), new Action(AdvanceNoticeConfig.ResetStaticDefaultValue));
	}

	// Token: 0x040033EF RID: 13295
	[Nullable(2)]
	private static AdvanceNoticeConfig _Instance;
}
