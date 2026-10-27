using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x0200133A RID: 4922
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class MoonChasingHandbookConfig : ConfigBase
{
	// Token: 0x0600890D RID: 35085 RVA: 0x001D4CF8 File Offset: 0x001D2EF8
	public TrackMoonHandbookReward? GetHandbookRewardById(int rewardId)
	{
		return ConfigTrackMoonHandbookRewardById.GetConfig(rewardId, true);
	}

	// Token: 0x0600890E RID: 35086 RVA: 0x001D4D01 File Offset: 0x001D2F01
	public IReadOnlyList<TrackMoonHandbookReward> GetHandbookRewardList()
	{
		return ConfigTrackMoonHandbookRewardAll.GetConfigList(true) ?? new List<TrackMoonHandbookReward>();
	}

	// Token: 0x17000BA6 RID: 2982
	// (get) Token: 0x0600890F RID: 35087 RVA: 0x001D4D12 File Offset: 0x001D2F12
	public static MoonChasingHandbookConfig Instance
	{
		get
		{
			return MoonChasingHandbookConfig._Instance;
		}
	}

	// Token: 0x06008910 RID: 35088 RVA: 0x001D4D19 File Offset: 0x001D2F19
	public static MoonChasingHandbookConfig GetOrCreateInstance()
	{
		if (MoonChasingHandbookConfig._Instance == null)
		{
			MoonChasingHandbookConfig.CreateInstance();
		}
		return MoonChasingHandbookConfig._Instance;
	}

	// Token: 0x06008911 RID: 35089 RVA: 0x001D4D2D File Offset: 0x001D2F2D
	public static bool CreateInstance()
	{
		if (MoonChasingHandbookConfig._Instance != null)
		{
			return true;
		}
		MoonChasingHandbookConfig._Instance = new MoonChasingHandbookConfig();
		return true;
	}

	// Token: 0x06008912 RID: 35090 RVA: 0x001D4D43 File Offset: 0x001D2F43
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06008913 RID: 35091 RVA: 0x001D4D45 File Offset: 0x001D2F45
	public static void ResetStaticDefaultValue()
	{
		MoonChasingHandbookConfig._Instance = null;
	}

	// Token: 0x06008914 RID: 35092 RVA: 0x001D4D4D File Offset: 0x001D2F4D
	static MoonChasingHandbookConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MoonChasingHandbookConfig.CreateStaticDefaultValue), new Action(MoonChasingHandbookConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04003D1D RID: 15645
	[Nullable(2)]
	private static MoonChasingHandbookConfig _Instance;
}
