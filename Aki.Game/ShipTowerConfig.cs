using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02002979 RID: 10617
[NullableContext(2)]
[Nullable(0)]
[Config(0)]
public class ShipTowerConfig : ConfigBase
{
	// Token: 0x06016002 RID: 90114 RVA: 0x0058E76C File Offset: 0x0058C96C
	public SlashAndTowerCfg? GetStageCfgById(int id)
	{
		return new SlashAndTowerCfg?(ConfigSlashAndTowerCfgById.GetConfig(id, true).Value);
	}

	// Token: 0x06016003 RID: 90115 RVA: 0x0058E78D File Offset: 0x0058C98D
	public IReadOnlyList<SlashTowerShowStage> GetAllShowStageCfg()
	{
		return ConfigSlashTowerShowStageAll.GetConfigList(true);
	}

	// Token: 0x06016004 RID: 90116 RVA: 0x0058E798 File Offset: 0x0058C998
	public SlashTowerStageInfo? GetStageInfoCfgByInstId(int instId)
	{
		return new SlashTowerStageInfo?(ConfigSlashTowerStageInfoByInstId.GetConfig(instId, true).Value);
	}

	// Token: 0x06016005 RID: 90117 RVA: 0x0058E7B9 File Offset: 0x0058C9B9
	public IReadOnlyList<SlashAndTowerCfg> GetStageCfgBySeason(int season)
	{
		return ConfigSlashAndTowerCfgBySeason.GetConfigList(season, true);
	}

	// Token: 0x06016006 RID: 90118 RVA: 0x0058E7C2 File Offset: 0x0058C9C2
	public IReadOnlyList<SlashAndTowerReward> GetChallengeRewardCfgBySeason(int season)
	{
		return ConfigSlashAndTowerRewardByBelongToSeason.GetConfigList(season, true);
	}

	// Token: 0x06016007 RID: 90119 RVA: 0x0058E7CB File Offset: 0x0058C9CB
	public IReadOnlyList<SlashBuffToItem> GetAllBuffCfg()
	{
		return ConfigSlashBuffToItemAll.GetConfigList(true);
	}

	// Token: 0x06016008 RID: 90120 RVA: 0x0058E7D4 File Offset: 0x0058C9D4
	public SlashBuffToItem? GetBuffCfgById(int id)
	{
		return new SlashBuffToItem?(ConfigSlashBuffToItemById.GetConfig(id, true).Value);
	}

	// Token: 0x06016009 RID: 90121 RVA: 0x0058E7F8 File Offset: 0x0058C9F8
	public SlashBuffToItem? GetBuffCfgByItemId(int itemId)
	{
		return new SlashBuffToItem?(ConfigSlashBuffToItemByItemId.GetConfig(itemId, true).Value);
	}

	// Token: 0x0601600A RID: 90122 RVA: 0x0058E819 File Offset: 0x0058CA19
	public IReadOnlyList<SlashBuffToItem> GetBuffCfgBySeason(int season)
	{
		return ConfigSlashBuffToItemBySeason.GetConfigList(season, true);
	}

	// Token: 0x0601600B RID: 90123 RVA: 0x0058E824 File Offset: 0x0058CA24
	public SlashBuffToItem? GetBuffCfgByItemIdAndSeason(int itemId, int season)
	{
		return new SlashBuffToItem?(ConfigSlashBuffToItemByItemIdAndSeason.GetConfig(itemId, season, true).Value);
	}

	// Token: 0x0601600C RID: 90124 RVA: 0x0058E846 File Offset: 0x0058CA46
	public IReadOnlyList<SlashBuffToItem> GetBuffCfgByItemIdList(int itemId)
	{
		return ConfigSlashBuffToItemByItemIdList.GetConfigList(itemId, true);
	}

	// Token: 0x0601600D RID: 90125 RVA: 0x0058E850 File Offset: 0x0058CA50
	public SlashTowerTagInfo? GetWordInfoCfgById(int id)
	{
		return new SlashTowerTagInfo?(ConfigSlashTowerTagInfoById.GetConfig(id, true).Value);
	}

	// Token: 0x0601600E RID: 90126 RVA: 0x0058E874 File Offset: 0x0058CA74
	public SlashAndTowerSeason? GetSeasonCfgById(int id)
	{
		return new SlashAndTowerSeason?(ConfigSlashAndTowerSeasonById.GetConfig(id, true).Value);
	}

	// Token: 0x17001D90 RID: 7568
	// (get) Token: 0x0601600F RID: 90127 RVA: 0x0058E895 File Offset: 0x0058CA95
	[Nullable(1)]
	public static ShipTowerConfig Instance
	{
		[NullableContext(1)]
		get
		{
			return ShipTowerConfig._Instance;
		}
	}

	// Token: 0x06016010 RID: 90128 RVA: 0x0058E89C File Offset: 0x0058CA9C
	[NullableContext(1)]
	public static ShipTowerConfig GetOrCreateInstance()
	{
		if (ShipTowerConfig._Instance == null)
		{
			ShipTowerConfig.CreateInstance();
		}
		return ShipTowerConfig._Instance;
	}

	// Token: 0x06016011 RID: 90129 RVA: 0x0058E8B0 File Offset: 0x0058CAB0
	public static bool CreateInstance()
	{
		if (ShipTowerConfig._Instance != null)
		{
			return true;
		}
		ShipTowerConfig._Instance = new ShipTowerConfig();
		return true;
	}

	// Token: 0x06016012 RID: 90130 RVA: 0x0058E8C6 File Offset: 0x0058CAC6
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06016013 RID: 90131 RVA: 0x0058E8C8 File Offset: 0x0058CAC8
	public static void ResetStaticDefaultValue()
	{
		ShipTowerConfig._Instance = null;
	}

	// Token: 0x06016014 RID: 90132 RVA: 0x0058E8D0 File Offset: 0x0058CAD0
	static ShipTowerConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ShipTowerConfig.CreateStaticDefaultValue), new Action(ShipTowerConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400A3A2 RID: 41890
	private static ShipTowerConfig _Instance;
}
