using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020007EE RID: 2030
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class MoonChasingHandbookConfig : ConfigBase
{
	// Token: 0x06005CA8 RID: 23720 RVA: 0x001DDB64 File Offset: 0x001DBD64
	public TrackMoonHandbookReward? GetHandbookRewardById(int rewardId)
	{
		return ConfigTrackMoonHandbookRewardById.GetConfig(rewardId, true);
	}

	// Token: 0x06005CA9 RID: 23721 RVA: 0x001DDB6D File Offset: 0x001DBD6D
	public IReadOnlyList<TrackMoonHandbookReward> GetHandbookRewardList()
	{
		return ConfigTrackMoonHandbookRewardAll.GetConfigList(true) ?? new List<TrackMoonHandbookReward>();
	}

	// Token: 0x17000BC6 RID: 3014
	// (get) Token: 0x06005CAA RID: 23722 RVA: 0x001DDB7E File Offset: 0x001DBD7E
	public static MoonChasingHandbookConfig Instance
	{
		get
		{
			return MoonChasingHandbookConfig._Instance;
		}
	}

	// Token: 0x06005CAB RID: 23723 RVA: 0x001DDB85 File Offset: 0x001DBD85
	public static MoonChasingHandbookConfig GetOrCreateInstance()
	{
		if (MoonChasingHandbookConfig._Instance == null)
		{
			MoonChasingHandbookConfig.CreateInstance();
		}
		return MoonChasingHandbookConfig._Instance;
	}

	// Token: 0x06005CAC RID: 23724 RVA: 0x001DDB99 File Offset: 0x001DBD99
	public static bool CreateInstance()
	{
		if (MoonChasingHandbookConfig._Instance != null)
		{
			return true;
		}
		MoonChasingHandbookConfig._Instance = new MoonChasingHandbookConfig();
		return true;
	}

	// Token: 0x06005CAD RID: 23725 RVA: 0x001DDBAF File Offset: 0x001DBDAF
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06005CAE RID: 23726 RVA: 0x001DDBB1 File Offset: 0x001DBDB1
	public static void ResetStaticDefaultValue()
	{
		MoonChasingHandbookConfig._Instance = null;
	}

	// Token: 0x06005CAF RID: 23727 RVA: 0x001DDBB9 File Offset: 0x001DBDB9
	static MoonChasingHandbookConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MoonChasingHandbookConfig.CreateStaticDefaultValue), new Action(MoonChasingHandbookConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04003DB5 RID: 15797
	[Nullable(2)]
	private static MoonChasingHandbookConfig _Instance;
}
