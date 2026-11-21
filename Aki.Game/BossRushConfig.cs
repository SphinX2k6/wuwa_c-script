using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x0200066A RID: 1642
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class BossRushConfig : ConfigBase
{
	// Token: 0x06004BE7 RID: 19431 RVA: 0x0019C38B File Offset: 0x0019A58B
	public BossRushActivity? GetBossRushActivityConfigById(int id)
	{
		return ConfigBossRushActivityById.GetConfig(id, true);
	}

	// Token: 0x06004BE8 RID: 19432 RVA: 0x0019C394 File Offset: 0x0019A594
	public BossRushActivity? GetBossRushByActivityIdAndInstanceId(int id, int instanceId)
	{
		IReadOnlyList<BossRushActivity> configList = ConfigBossRushActivityByActivityIdAndInstanceId.GetConfigList(id, instanceId, true);
		if (configList == null || configList.Count == 0)
		{
			return null;
		}
		return new BossRushActivity?(configList[0]);
	}

	// Token: 0x06004BE9 RID: 19433 RVA: 0x0019C3CB File Offset: 0x0019A5CB
	public BossRushBuff? GetBossRushBuffConfigById(int id)
	{
		return ConfigBossRushBuffById.GetConfig(id, true);
	}

	// Token: 0x06004BEA RID: 19434 RVA: 0x0019C3D4 File Offset: 0x0019A5D4
	public BossRushScore? GetBossRushScoreConfigById(int id)
	{
		return ConfigBossRushScoreById.GetConfig(id, true);
	}

	// Token: 0x06004BEB RID: 19435 RVA: 0x0019C3DD File Offset: 0x0019A5DD
	public int GetBossRushMarkTypeByActivityId(int id)
	{
		return 0;
	}

	// Token: 0x06004BEC RID: 19436 RVA: 0x0019C3E0 File Offset: 0x0019A5E0
	public int GetBossRushMarkByActivityId(int id)
	{
		BossRushMapMark? config = ConfigBossRushMapMarkByActivityId.GetConfig(id, true);
		if (config == null)
		{
			return 0;
		}
		return config.Value.MarkId;
	}

	// Token: 0x06004BED RID: 19437 RVA: 0x0019C410 File Offset: 0x0019A610
	public BossRushTaskConfig GetBossRushTaskConfig(int id)
	{
		BossRushTaskConfig? config = ConfigBossRushTaskConfigByTaskId.GetConfig(id, true);
		if (config == null)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(37, 1);
			defaultInterpolatedStringHandler.AppendLiteral("BossRushTaskConfig not found for id: ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(id);
			throw new Exception(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		return config.Value;
	}

	// Token: 0x06004BEE RID: 19438 RVA: 0x0019C460 File Offset: 0x0019A660
	public IReadOnlyList<BossRushTaskTab> GetBossRushTabListByActivityId(int id)
	{
		IReadOnlyList<BossRushTaskTab> configList = ConfigBossRushTaskTabAll.GetConfigList(true);
		IReadOnlyList<BossRushTaskConfig> configList2 = ConfigBossRushTaskConfigAll.GetConfigList(true);
		if (configList == null || configList2 == null)
		{
			return new List<BossRushTaskTab>();
		}
		List<BossRushTaskTab> list = new List<BossRushTaskTab>();
		foreach (BossRushTaskTab item in configList)
		{
			if (item.ActivityId == id)
			{
				list.Add(item);
			}
		}
		return list;
	}

	// Token: 0x06004BEF RID: 19439 RVA: 0x0019C4D8 File Offset: 0x0019A6D8
	public BossRushTaskTab? GetBossRushTabByTabId(int id)
	{
		return ConfigBossRushTaskTabByTabId.GetConfig(id, true);
	}

	// Token: 0x06004BF0 RID: 19440 RVA: 0x0019C4E4 File Offset: 0x0019A6E4
	public BossRushBuffDesc? GetBossRushBuffDescByClassLevel(int buffId, int classLevel)
	{
		BossRushBuff? bossRushBuffConfigById = this.GetBossRushBuffConfigById(buffId);
		if (bossRushBuffConfigById == null)
		{
			return null;
		}
		int[] array = bossRushBuffConfigById.Value.PopDescIdList();
		if (array.Length > classLevel)
		{
			return ConfigBossRushBuffDescById.GetConfig(array[classLevel], true);
		}
		return null;
	}

	// Token: 0x17000A6B RID: 2667
	// (get) Token: 0x06004BF1 RID: 19441 RVA: 0x0019C535 File Offset: 0x0019A735
	public static BossRushConfig Instance
	{
		get
		{
			return BossRushConfig._Instance;
		}
	}

	// Token: 0x06004BF2 RID: 19442 RVA: 0x0019C53C File Offset: 0x0019A73C
	public static BossRushConfig GetOrCreateInstance()
	{
		if (BossRushConfig._Instance == null)
		{
			BossRushConfig.CreateInstance();
		}
		return BossRushConfig._Instance;
	}

	// Token: 0x06004BF3 RID: 19443 RVA: 0x0019C550 File Offset: 0x0019A750
	public static bool CreateInstance()
	{
		if (BossRushConfig._Instance != null)
		{
			return true;
		}
		BossRushConfig._Instance = new BossRushConfig();
		return true;
	}

	// Token: 0x06004BF4 RID: 19444 RVA: 0x0019C566 File Offset: 0x0019A766
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06004BF5 RID: 19445 RVA: 0x0019C568 File Offset: 0x0019A768
	public static void ResetStaticDefaultValue()
	{
		BossRushConfig._Instance = null;
	}

	// Token: 0x06004BF6 RID: 19446 RVA: 0x0019C570 File Offset: 0x0019A770
	static BossRushConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BossRushConfig.CreateStaticDefaultValue), new Action(BossRushConfig.ResetStaticDefaultValue));
	}

	// Token: 0x040037FB RID: 14331
	[Nullable(2)]
	private static BossRushConfig _Instance;
}
