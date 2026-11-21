using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001EF4 RID: 7924
[NullableContext(2)]
[Nullable(0)]
[Config(0)]
public class ShipTowerConfig : ConfigBase
{
	// Token: 0x06013A08 RID: 80392 RVA: 0x005B9730 File Offset: 0x005B7930
	public SlashAndTowerCfg? GetStageCfgById(int id)
	{
		return new SlashAndTowerCfg?(ConfigSlashAndTowerCfgById.GetConfig(id, true).Value);
	}

	// Token: 0x06013A09 RID: 80393 RVA: 0x005B9751 File Offset: 0x005B7951
	public IReadOnlyList<SlashTowerShowStage> GetAllShowStageCfg()
	{
		return ConfigSlashTowerShowStageAll.GetConfigList(true);
	}

	// Token: 0x06013A0A RID: 80394 RVA: 0x005B975C File Offset: 0x005B795C
	public SlashTowerStageInfo? GetStageInfoCfgByInstId(int instId)
	{
		return new SlashTowerStageInfo?(ConfigSlashTowerStageInfoByInstId.GetConfig(instId, true).Value);
	}

	// Token: 0x06013A0B RID: 80395 RVA: 0x005B977D File Offset: 0x005B797D
	public IReadOnlyList<SlashAndTowerCfg> GetStageCfgBySeason(int season)
	{
		return ConfigSlashAndTowerCfgBySeason.GetConfigList(season, true);
	}

	// Token: 0x06013A0C RID: 80396 RVA: 0x005B9786 File Offset: 0x005B7986
	public IReadOnlyList<SlashAndTowerReward> GetChallengeRewardCfgBySeason(int season)
	{
		return ConfigSlashAndTowerRewardByBelongToSeason.GetConfigList(season, true);
	}

	// Token: 0x06013A0D RID: 80397 RVA: 0x005B978F File Offset: 0x005B798F
	public IReadOnlyList<SlashBuffToItem> GetAllBuffCfg()
	{
		return ConfigSlashBuffToItemAll.GetConfigList(true);
	}

	// Token: 0x06013A0E RID: 80398 RVA: 0x005B9798 File Offset: 0x005B7998
	public SlashBuffToItem? GetBuffCfgById(int id)
	{
		return new SlashBuffToItem?(ConfigSlashBuffToItemById.GetConfig(id, true).Value);
	}

	// Token: 0x06013A0F RID: 80399 RVA: 0x005B97BC File Offset: 0x005B79BC
	public SlashBuffToItem? GetBuffCfgByItemId(int itemId)
	{
		return new SlashBuffToItem?(ConfigSlashBuffToItemByItemId.GetConfig(itemId, true).Value);
	}

	// Token: 0x06013A10 RID: 80400 RVA: 0x005B97DD File Offset: 0x005B79DD
	public IReadOnlyList<SlashBuffToItem> GetBuffCfgBySeason(int season)
	{
		return ConfigSlashBuffToItemBySeason.GetConfigList(season, true);
	}

	// Token: 0x06013A11 RID: 80401 RVA: 0x005B97E8 File Offset: 0x005B79E8
	public SlashBuffToItem? GetBuffCfgByItemIdAndSeason(int itemId, int season)
	{
		return new SlashBuffToItem?(ConfigSlashBuffToItemByItemIdAndSeason.GetConfig(itemId, season, true).Value);
	}

	// Token: 0x06013A12 RID: 80402 RVA: 0x005B980A File Offset: 0x005B7A0A
	public IReadOnlyList<SlashBuffToItem> GetBuffCfgByItemIdList(int itemId)
	{
		return ConfigSlashBuffToItemByItemIdList.GetConfigList(itemId, true);
	}

	// Token: 0x06013A13 RID: 80403 RVA: 0x005B9814 File Offset: 0x005B7A14
	public SlashTowerTagInfo? GetWordInfoCfgById(int id)
	{
		return new SlashTowerTagInfo?(ConfigSlashTowerTagInfoById.GetConfig(id, true).Value);
	}

	// Token: 0x06013A14 RID: 80404 RVA: 0x005B9838 File Offset: 0x005B7A38
	public SlashAndTowerSeason? GetSeasonCfgById(int id)
	{
		return new SlashAndTowerSeason?(ConfigSlashAndTowerSeasonById.GetConfig(id, true).Value);
	}

	// Token: 0x17001DE9 RID: 7657
	// (get) Token: 0x06013A15 RID: 80405 RVA: 0x005B9859 File Offset: 0x005B7A59
	[Nullable(1)]
	public static ShipTowerConfig Instance
	{
		[NullableContext(1)]
		get
		{
			return ShipTowerConfig._Instance;
		}
	}

	// Token: 0x06013A16 RID: 80406 RVA: 0x005B9860 File Offset: 0x005B7A60
	[NullableContext(1)]
	public static ShipTowerConfig GetOrCreateInstance()
	{
		if (ShipTowerConfig._Instance == null)
		{
			ShipTowerConfig.CreateInstance();
		}
		return ShipTowerConfig._Instance;
	}

	// Token: 0x06013A17 RID: 80407 RVA: 0x005B9874 File Offset: 0x005B7A74
	public static bool CreateInstance()
	{
		if (ShipTowerConfig._Instance != null)
		{
			return true;
		}
		ShipTowerConfig._Instance = new ShipTowerConfig();
		return true;
	}

	// Token: 0x06013A18 RID: 80408 RVA: 0x005B988A File Offset: 0x005B7A8A
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06013A19 RID: 80409 RVA: 0x005B988C File Offset: 0x005B7A8C
	public static void ResetStaticDefaultValue()
	{
		ShipTowerConfig._Instance = null;
	}

	// Token: 0x06013A1A RID: 80410 RVA: 0x005B9894 File Offset: 0x005B7A94
	static ShipTowerConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ShipTowerConfig.CreateStaticDefaultValue), new Action(ShipTowerConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400A78C RID: 42892
	private static ShipTowerConfig _Instance;
}
