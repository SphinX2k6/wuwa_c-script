using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020011B6 RID: 4534
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class BossRushConfig : ConfigBase
{
	// Token: 0x06007850 RID: 30800 RVA: 0x001937BF File Offset: 0x001919BF
	public BossRushActivity? GetBossRushActivityConfigById(int id)
	{
		return ConfigBossRushActivityById.GetConfig(id, true);
	}

	// Token: 0x06007851 RID: 30801 RVA: 0x001937C8 File Offset: 0x001919C8
	public BossRushActivity? GetBossRushByActivityIdAndInstanceId(int id, int instanceId)
	{
		IReadOnlyList<BossRushActivity> configList = ConfigBossRushActivityByActivityIdAndInstanceId.GetConfigList(id, instanceId, true);
		if (configList == null || configList.Count == 0)
		{
			return null;
		}
		return new BossRushActivity?(configList[0]);
	}

	// Token: 0x06007852 RID: 30802 RVA: 0x001937FF File Offset: 0x001919FF
	public BossRushBuff? GetBossRushBuffConfigById(int id)
	{
		return ConfigBossRushBuffById.GetConfig(id, true);
	}

	// Token: 0x06007853 RID: 30803 RVA: 0x00193808 File Offset: 0x00191A08
	public BossRushScore? GetBossRushScoreConfigById(int id)
	{
		return ConfigBossRushScoreById.GetConfig(id, true);
	}

	// Token: 0x06007854 RID: 30804 RVA: 0x00193811 File Offset: 0x00191A11
	public int GetBossRushMarkTypeByActivityId(int id)
	{
		return 0;
	}

	// Token: 0x06007855 RID: 30805 RVA: 0x00193814 File Offset: 0x00191A14
	public int GetBossRushMarkByActivityId(int id)
	{
		BossRushMapMark? config = ConfigBossRushMapMarkByActivityId.GetConfig(id, true);
		if (config == null)
		{
			return 0;
		}
		return config.Value.MarkId;
	}

	// Token: 0x06007856 RID: 30806 RVA: 0x00193844 File Offset: 0x00191A44
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

	// Token: 0x06007857 RID: 30807 RVA: 0x00193894 File Offset: 0x00191A94
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

	// Token: 0x06007858 RID: 30808 RVA: 0x0019390C File Offset: 0x00191B0C
	public BossRushTaskTab? GetBossRushTabByTabId(int id)
	{
		return ConfigBossRushTaskTabByTabId.GetConfig(id, true);
	}

	// Token: 0x06007859 RID: 30809 RVA: 0x00193918 File Offset: 0x00191B18
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

	// Token: 0x17000A4B RID: 2635
	// (get) Token: 0x0600785A RID: 30810 RVA: 0x00193969 File Offset: 0x00191B69
	public static BossRushConfig Instance
	{
		get
		{
			return BossRushConfig._Instance;
		}
	}

	// Token: 0x0600785B RID: 30811 RVA: 0x00193970 File Offset: 0x00191B70
	public static BossRushConfig GetOrCreateInstance()
	{
		if (BossRushConfig._Instance == null)
		{
			BossRushConfig.CreateInstance();
		}
		return BossRushConfig._Instance;
	}

	// Token: 0x0600785C RID: 30812 RVA: 0x00193984 File Offset: 0x00191B84
	public static bool CreateInstance()
	{
		if (BossRushConfig._Instance != null)
		{
			return true;
		}
		BossRushConfig._Instance = new BossRushConfig();
		return true;
	}

	// Token: 0x0600785D RID: 30813 RVA: 0x0019399A File Offset: 0x00191B9A
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600785E RID: 30814 RVA: 0x0019399C File Offset: 0x00191B9C
	public static void ResetStaticDefaultValue()
	{
		BossRushConfig._Instance = null;
	}

	// Token: 0x0600785F RID: 30815 RVA: 0x001939A4 File Offset: 0x00191BA4
	static BossRushConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BossRushConfig.CreateStaticDefaultValue), new Action(BossRushConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04003762 RID: 14178
	[Nullable(2)]
	private static BossRushConfig _Instance;
}
