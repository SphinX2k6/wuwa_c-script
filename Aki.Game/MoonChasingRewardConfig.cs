using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x0200135B RID: 4955
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class MoonChasingRewardConfig : ConfigBase
{
	// Token: 0x06008A10 RID: 35344 RVA: 0x001D8160 File Offset: 0x001D6360
	public IReadOnlyList<TrackMoonTargetType> GetAllRewardTargetTypeList()
	{
		return ConfigTrackMoonTargetTypeAll.GetConfigList(true);
	}

	// Token: 0x06008A11 RID: 35345 RVA: 0x001D8168 File Offset: 0x001D6368
	public TrackMoonTarget GetRewardTargetById(int id)
	{
		return ConfigTrackMoonTargetById.GetConfig(id, true).Value;
	}

	// Token: 0x17000BBF RID: 3007
	// (get) Token: 0x06008A12 RID: 35346 RVA: 0x001D8184 File Offset: 0x001D6384
	public static MoonChasingRewardConfig Instance
	{
		get
		{
			return MoonChasingRewardConfig._Instance;
		}
	}

	// Token: 0x06008A13 RID: 35347 RVA: 0x001D818B File Offset: 0x001D638B
	public static MoonChasingRewardConfig GetOrCreateInstance()
	{
		if (MoonChasingRewardConfig._Instance == null)
		{
			MoonChasingRewardConfig.CreateInstance();
		}
		return MoonChasingRewardConfig._Instance;
	}

	// Token: 0x06008A14 RID: 35348 RVA: 0x001D819F File Offset: 0x001D639F
	public static bool CreateInstance()
	{
		if (MoonChasingRewardConfig._Instance != null)
		{
			return true;
		}
		MoonChasingRewardConfig._Instance = new MoonChasingRewardConfig();
		return true;
	}

	// Token: 0x06008A15 RID: 35349 RVA: 0x001D81B5 File Offset: 0x001D63B5
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06008A16 RID: 35350 RVA: 0x001D81B7 File Offset: 0x001D63B7
	public static void ResetStaticDefaultValue()
	{
		MoonChasingRewardConfig._Instance = null;
	}

	// Token: 0x06008A17 RID: 35351 RVA: 0x001D81BF File Offset: 0x001D63BF
	static MoonChasingRewardConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MoonChasingRewardConfig.CreateStaticDefaultValue), new Action(MoonChasingRewardConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04003D91 RID: 15761
	[Nullable(2)]
	private static MoonChasingRewardConfig _Instance;
}
