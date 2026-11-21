using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02000BD7 RID: 3031
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class CalabashConfig : ConfigBase
{
	// Token: 0x06007ECF RID: 32463 RVA: 0x00270EB0 File Offset: 0x0026F0B0
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

	// Token: 0x06007ED0 RID: 32464 RVA: 0x00270F08 File Offset: 0x0026F108
	[NullableContext(2)]
	public IReadOnlyList<CalabashLevel> GetCalabashConfigList()
	{
		return ConfigCalabashLevelAll.GetConfigList(true);
	}

	// Token: 0x06007ED1 RID: 32465 RVA: 0x00270F10 File Offset: 0x0026F110
	public string GetCalabashQuality(int level)
	{
		return this.GetCalabashConfigByLevel(level).Value.QualityDescription;
	}

	// Token: 0x06007ED2 RID: 32466 RVA: 0x00270F34 File Offset: 0x0026F134
	[NullableContext(2)]
	public IReadOnlyList<CalabashDevelopReward> GetCalabashDevelopList()
	{
		return ConfigCalabashDevelopRewardAll.GetConfigList(true);
	}

	// Token: 0x06007ED3 RID: 32467 RVA: 0x00270F3C File Offset: 0x0026F13C
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

	// Token: 0x06007ED4 RID: 32468 RVA: 0x00270F98 File Offset: 0x0026F198
	public string GetMonsterNameByMonsterId(int monsterId)
	{
		return ConfigMultiTextLang.GetLocalTextNew(ConfigMonsterInfoById.GetConfig(this.GetCalabashDevelopRewardByMonsterId(monsterId).Value.MonsterInfoId, true).Value.Name, null) ?? "";
	}

	// Token: 0x06007ED5 RID: 32469 RVA: 0x00270FE4 File Offset: 0x0026F1E4
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

	// Token: 0x06007ED6 RID: 32470 RVA: 0x00271038 File Offset: 0x0026F238
	public int GetCalabashConditionExp(int id)
	{
		return this.GetCalabashConditionRewardExp(this.GetCalabashConditionById(id));
	}

	// Token: 0x06007ED7 RID: 32471 RVA: 0x00271048 File Offset: 0x0026F248
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

	// Token: 0x06007ED8 RID: 32472 RVA: 0x002710A0 File Offset: 0x0026F2A0
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

	// Token: 0x06007ED9 RID: 32473 RVA: 0x002710FC File Offset: 0x0026F2FC
	public ConditionGroup? GetConditionInfo(int upConditionId)
	{
		return ConfigConditionGroupById.GetConfig(upConditionId, true);
	}

	// Token: 0x17000E2D RID: 3629
	// (get) Token: 0x06007EDA RID: 32474 RVA: 0x00271108 File Offset: 0x0026F308
	public int MaxTipCd
	{
		get
		{
			return ConfigCommonParamById.GetIntConfig("VisionUnlockDisplayTime").Value;
		}
	}

	// Token: 0x17000E2E RID: 3630
	// (get) Token: 0x06007EDB RID: 32475 RVA: 0x00271128 File Offset: 0x0026F328
	public int DelayTime
	{
		get
		{
			return ConfigCommonParamById.GetIntConfig("VisionUnlockDelayTime").Value;
		}
	}

	// Token: 0x06007EDC RID: 32476 RVA: 0x00271148 File Offset: 0x0026F348
	public int GetVisionBatchRecoveryMaxCount()
	{
		return ConfigCommonParamById.GetIntConfig("PhantomRefiningMaxCount").Value;
	}

	// Token: 0x06007EDD RID: 32477 RVA: 0x00271167 File Offset: 0x0026F367
	[NullableContext(2)]
	public IReadOnlyList<CalabashDevelopReward> GetCalabashRewardListByAreaId(int areaId)
	{
		return ConfigCalabashDevelopRewardByInteractAreaId.GetConfigList(areaId, true);
	}

	// Token: 0x06007EDE RID: 32478 RVA: 0x00271170 File Offset: 0x0026F370
	[NullableContext(2)]
	public IReadOnlyList<PhantomDirectRefining> GetPhantomDirectRefiningAll()
	{
		return ConfigPhantomDirectRefiningAll.GetConfigList(true);
	}

	// Token: 0x17000E2F RID: 3631
	// (get) Token: 0x06007EDF RID: 32479 RVA: 0x00271178 File Offset: 0x0026F378
	public static CalabashConfig Instance
	{
		get
		{
			return CalabashConfig._Instance;
		}
	}

	// Token: 0x06007EE0 RID: 32480 RVA: 0x0027117F File Offset: 0x0026F37F
	public static CalabashConfig GetOrCreateInstance()
	{
		if (CalabashConfig._Instance == null)
		{
			CalabashConfig.CreateInstance();
		}
		return CalabashConfig._Instance;
	}

	// Token: 0x06007EE1 RID: 32481 RVA: 0x00271193 File Offset: 0x0026F393
	public static bool CreateInstance()
	{
		if (CalabashConfig._Instance != null)
		{
			return true;
		}
		CalabashConfig._Instance = new CalabashConfig();
		return true;
	}

	// Token: 0x06007EE2 RID: 32482 RVA: 0x002711A9 File Offset: 0x0026F3A9
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06007EE3 RID: 32483 RVA: 0x002711AB File Offset: 0x0026F3AB
	public static void ResetStaticDefaultValue()
	{
		CalabashConfig._Instance = null;
	}

	// Token: 0x06007EE4 RID: 32484 RVA: 0x002711B3 File Offset: 0x0026F3B3
	static CalabashConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CalabashConfig.CreateStaticDefaultValue), new Action(CalabashConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04004E35 RID: 20021
	[Nullable(2)]
	private static CalabashConfig _Instance;
}
