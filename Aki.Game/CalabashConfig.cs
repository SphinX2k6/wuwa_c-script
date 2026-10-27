using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x0200171F RID: 5919
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class CalabashConfig : ConfigBase
{
	// Token: 0x0600AAED RID: 43757 RVA: 0x00266AD8 File Offset: 0x00264CD8
	public CalabashLevel? GetCalabashConfigByLevel(int level)
	{
		CalabashLevel? config = ConfigCalabashLevelByLevel.GetConfig(level, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Calabash;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "获取鸣域终端配置失败，请检查配置表";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("level", level);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return config;
	}

	// Token: 0x0600AAEE RID: 43758 RVA: 0x00266B30 File Offset: 0x00264D30
	[NullableContext(2)]
	public IReadOnlyList<CalabashLevel> GetCalabashConfigList()
	{
		return ConfigCalabashLevelAll.GetConfigList(true);
	}

	// Token: 0x0600AAEF RID: 43759 RVA: 0x00266B38 File Offset: 0x00264D38
	public string GetCalabashQuality(int level)
	{
		return this.GetCalabashConfigByLevel(level).Value.QualityDescription;
	}

	// Token: 0x0600AAF0 RID: 43760 RVA: 0x00266B5C File Offset: 0x00264D5C
	[NullableContext(2)]
	public IReadOnlyList<CalabashDevelopReward> GetCalabashDevelopList()
	{
		return ConfigCalabashDevelopRewardAll.GetConfigList(true);
	}

	// Token: 0x0600AAF1 RID: 43761 RVA: 0x00266B64 File Offset: 0x00264D64
	public CalabashDevelopReward? GetCalabashDevelopRewardByMonsterId(int monsterId)
	{
		CalabashDevelopReward? config = ConfigCalabashDevelopRewardByMonsterId.GetConfig(monsterId, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Calabash;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "获取鸣域终端养成奖励配置失败, 请检查配置表";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("MonsterId", monsterId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		return new CalabashDevelopReward?(config.Value);
	}

	// Token: 0x0600AAF2 RID: 43762 RVA: 0x00266BC0 File Offset: 0x00264DC0
	public string GetMonsterNameByMonsterId(int monsterId)
	{
		return ConfigMultiTextLang.GetLocalTextNew(ConfigMonsterInfoById.GetConfig(this.GetCalabashDevelopRewardByMonsterId(monsterId).Value.MonsterInfoId, true).Value.Name, null) ?? "";
	}

	// Token: 0x0600AAF3 RID: 43763 RVA: 0x00266C0C File Offset: 0x00264E0C
	public CalabashDevelopCondition GetCalabashConditionById(int id)
	{
		CalabashDevelopCondition? config = ConfigCalabashDevelopConditionById.GetConfig(id, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Calabash;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "获取鸣域终端养成条件配置失败, 请检查配置表";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		return config.Value;
	}

	// Token: 0x0600AAF4 RID: 43764 RVA: 0x00266C60 File Offset: 0x00264E60
	public int GetCalabashConditionExp(int id)
	{
		return this.GetCalabashConditionRewardExp(this.GetCalabashConditionById(id));
	}

	// Token: 0x0600AAF5 RID: 43765 RVA: 0x00266C70 File Offset: 0x00264E70
	public int GetCalabashConditionRewardExp(CalabashDevelopCondition config)
	{
		Dictionary<int, int> dictionary = config.RewardExp();
		if (dictionary == null)
		{
			return 0;
		}
		int? intConfig = ConfigCommonParamById.GetIntConfig("CalabashExpItemId");
		int? num = intConfig;
		int num2 = 0;
		if (num.GetValueOrDefault() == num2 & num != null)
		{
			return 0;
		}
		int result;
		if (!dictionary.TryGetValue(intConfig.Value, out result))
		{
			result = 0;
		}
		return result;
	}

	// Token: 0x0600AAF6 RID: 43766 RVA: 0x00266CC8 File Offset: 0x00264EC8
	public int GetCalabashMaxLevel()
	{
		IEnumerable<CalabashLevel> calabashConfigList = this.GetCalabashConfigList();
		int num = 0;
		foreach (CalabashLevel calabashLevel in calabashConfigList)
		{
			if (num < calabashLevel.Level)
			{
				num = calabashLevel.Level;
			}
		}
		return num;
	}

	// Token: 0x0600AAF7 RID: 43767 RVA: 0x00266D24 File Offset: 0x00264F24
	public ConditionGroup? GetConditionInfo(int upConditionId)
	{
		return ConfigConditionGroupById.GetConfig(upConditionId, true);
	}

	// Token: 0x17000E0C RID: 3596
	// (get) Token: 0x0600AAF8 RID: 43768 RVA: 0x00266D30 File Offset: 0x00264F30
	public int MaxTipCd
	{
		get
		{
			return ConfigCommonParamById.GetIntConfig("VisionUnlockDisplayTime").Value;
		}
	}

	// Token: 0x17000E0D RID: 3597
	// (get) Token: 0x0600AAF9 RID: 43769 RVA: 0x00266D50 File Offset: 0x00264F50
	public int DelayTime
	{
		get
		{
			return ConfigCommonParamById.GetIntConfig("VisionUnlockDelayTime").Value;
		}
	}

	// Token: 0x0600AAFA RID: 43770 RVA: 0x00266D70 File Offset: 0x00264F70
	public int GetVisionBatchRecoveryMaxCount()
	{
		return ConfigCommonParamById.GetIntConfig("PhantomRefiningMaxCount").Value;
	}

	// Token: 0x0600AAFB RID: 43771 RVA: 0x00266D8F File Offset: 0x00264F8F
	[NullableContext(2)]
	public IReadOnlyList<CalabashDevelopReward> GetCalabashRewardListByAreaId(int areaId)
	{
		return ConfigCalabashDevelopRewardByInteractAreaId.GetConfigList(areaId, true);
	}

	// Token: 0x0600AAFC RID: 43772 RVA: 0x00266D98 File Offset: 0x00264F98
	[NullableContext(2)]
	public IReadOnlyList<PhantomDirectRefining> GetPhantomDirectRefiningAll()
	{
		return ConfigPhantomDirectRefiningAll.GetConfigList(true);
	}

	// Token: 0x17000E0E RID: 3598
	// (get) Token: 0x0600AAFD RID: 43773 RVA: 0x00266DA0 File Offset: 0x00264FA0
	public static CalabashConfig Instance
	{
		get
		{
			return CalabashConfig._Instance;
		}
	}

	// Token: 0x0600AAFE RID: 43774 RVA: 0x00266DA7 File Offset: 0x00264FA7
	public static CalabashConfig GetOrCreateInstance()
	{
		if (CalabashConfig._Instance == null)
		{
			CalabashConfig.CreateInstance();
		}
		return CalabashConfig._Instance;
	}

	// Token: 0x0600AAFF RID: 43775 RVA: 0x00266DBB File Offset: 0x00264FBB
	public static bool CreateInstance()
	{
		if (CalabashConfig._Instance != null)
		{
			return true;
		}
		CalabashConfig._Instance = new CalabashConfig();
		return true;
	}

	// Token: 0x0600AB00 RID: 43776 RVA: 0x00266DD1 File Offset: 0x00264FD1
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600AB01 RID: 43777 RVA: 0x00266DD3 File Offset: 0x00264FD3
	public static void ResetStaticDefaultValue()
	{
		CalabashConfig._Instance = null;
	}

	// Token: 0x0600AB02 RID: 43778 RVA: 0x00266DDB File Offset: 0x00264FDB
	static CalabashConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CalabashConfig.CreateStaticDefaultValue), new Action(CalabashConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04004D8E RID: 19854
	[Nullable(2)]
	private static CalabashConfig _Instance;
}
