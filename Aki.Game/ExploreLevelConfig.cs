using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001A90 RID: 6800
[NullableContext(2)]
[Nullable(0)]
[Config(0)]
public class ExploreLevelConfig : ConfigBase
{
	// Token: 0x0600C8B5 RID: 51381 RVA: 0x002DC7B5 File Offset: 0x002DA9B5
	public IReadOnlyList<ExploreReward> GetExploreRewardListByCountry(int countryId)
	{
		return ConfigExploreRewardByCountry.GetConfigList(countryId, true);
	}

	// Token: 0x0600C8B6 RID: 51382 RVA: 0x002DC7BE File Offset: 0x002DA9BE
	public IReadOnlyList<ExploreScore> GetExploreScoreConfigList()
	{
		return ConfigExploreScoreAll.GetConfigList(true);
	}

	// Token: 0x0600C8B7 RID: 51383 RVA: 0x002DC7C8 File Offset: 0x002DA9C8
	public Dictionary<int, int> GetDropShowInfo(int dropId)
	{
		DropPackage? config = ConfigDropPackageById.GetConfig(dropId, true);
		if (config == null)
		{
			return null;
		}
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		for (int i = 0; i < config.Value.DropPreviewLength; i++)
		{
			DicIntInt? dicIntInt = config.Value.DropPreview(i);
			dictionary[dicIntInt.Value.Key] = dicIntInt.Value.Value;
		}
		return dictionary;
	}

	// Token: 0x17001074 RID: 4212
	// (get) Token: 0x0600C8B8 RID: 51384 RVA: 0x002DC842 File Offset: 0x002DAA42
	[Nullable(1)]
	public static ExploreLevelConfig Instance
	{
		[NullableContext(1)]
		get
		{
			return ExploreLevelConfig._Instance;
		}
	}

	// Token: 0x0600C8B9 RID: 51385 RVA: 0x002DC849 File Offset: 0x002DAA49
	[NullableContext(1)]
	public static ExploreLevelConfig GetOrCreateInstance()
	{
		if (ExploreLevelConfig._Instance == null)
		{
			ExploreLevelConfig.CreateInstance();
		}
		return ExploreLevelConfig._Instance;
	}

	// Token: 0x0600C8BA RID: 51386 RVA: 0x002DC85D File Offset: 0x002DAA5D
	public static bool CreateInstance()
	{
		if (ExploreLevelConfig._Instance != null)
		{
			return true;
		}
		ExploreLevelConfig._Instance = new ExploreLevelConfig();
		return true;
	}

	// Token: 0x0600C8BB RID: 51387 RVA: 0x002DC873 File Offset: 0x002DAA73
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600C8BC RID: 51388 RVA: 0x002DC875 File Offset: 0x002DAA75
	public static void ResetStaticDefaultValue()
	{
		ExploreLevelConfig._Instance = null;
	}

	// Token: 0x0600C8BD RID: 51389 RVA: 0x002DC87D File Offset: 0x002DAA7D
	static ExploreLevelConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ExploreLevelConfig.CreateStaticDefaultValue), new Action(ExploreLevelConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04005C7E RID: 23678
	private static ExploreLevelConfig _Instance;
}
