using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02000F4F RID: 3919
[NullableContext(2)]
[Nullable(0)]
[Config(0)]
public class ExploreLevelConfig : ConfigBase
{
	// Token: 0x06009CC6 RID: 40134 RVA: 0x002E78E9 File Offset: 0x002E5AE9
	public IReadOnlyList<ExploreReward> GetExploreRewardListByCountry(int countryId)
	{
		return ConfigExploreRewardByCountry.GetConfigList(countryId, true);
	}

	// Token: 0x06009CC7 RID: 40135 RVA: 0x002E78F2 File Offset: 0x002E5AF2
	public IReadOnlyList<ExploreScore> GetExploreScoreConfigList()
	{
		return ConfigExploreScoreAll.GetConfigList(true);
	}

	// Token: 0x06009CC8 RID: 40136 RVA: 0x002E78FC File Offset: 0x002E5AFC
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

	// Token: 0x17001099 RID: 4249
	// (get) Token: 0x06009CC9 RID: 40137 RVA: 0x002E7976 File Offset: 0x002E5B76
	[Nullable(1)]
	public static ExploreLevelConfig Instance
	{
		[NullableContext(1)]
		get
		{
			return ExploreLevelConfig._Instance;
		}
	}

	// Token: 0x06009CCA RID: 40138 RVA: 0x002E797D File Offset: 0x002E5B7D
	[NullableContext(1)]
	public static ExploreLevelConfig GetOrCreateInstance()
	{
		if (ExploreLevelConfig._Instance == null)
		{
			ExploreLevelConfig.CreateInstance();
		}
		return ExploreLevelConfig._Instance;
	}

	// Token: 0x06009CCB RID: 40139 RVA: 0x002E7991 File Offset: 0x002E5B91
	public static bool CreateInstance()
	{
		if (ExploreLevelConfig._Instance != null)
		{
			return true;
		}
		ExploreLevelConfig._Instance = new ExploreLevelConfig();
		return true;
	}

	// Token: 0x06009CCC RID: 40140 RVA: 0x002E79A7 File Offset: 0x002E5BA7
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06009CCD RID: 40141 RVA: 0x002E79A9 File Offset: 0x002E5BA9
	public static void ResetStaticDefaultValue()
	{
		ExploreLevelConfig._Instance = null;
	}

	// Token: 0x06009CCE RID: 40142 RVA: 0x002E79B1 File Offset: 0x002E5BB1
	static ExploreLevelConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ExploreLevelConfig.CreateStaticDefaultValue), new Action(ExploreLevelConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04005D4D RID: 23885
	private static ExploreLevelConfig _Instance;
}
