using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02002188 RID: 8584
[NullableContext(2)]
[Nullable(0)]
[Config(0)]
public class LordGymConfig : ConfigBase
{
	// Token: 0x06010AE3 RID: 68323 RVA: 0x0040D0D4 File Offset: 0x0040B2D4
	public LordGym? GetLordGymConfig(int lordId)
	{
		return ConfigLordGymById.GetConfig(lordId, true);
	}

	// Token: 0x06010AE4 RID: 68324 RVA: 0x0040D0DD File Offset: 0x0040B2DD
	public IReadOnlyList<LordGym> GetLordGymAllConfig()
	{
		return ConfigLordGymAll.GetConfigList(true);
	}

	// Token: 0x06010AE5 RID: 68325 RVA: 0x0040D0E5 File Offset: 0x0040B2E5
	public IReadOnlyList<LordGym> GetLordGymAllConfigByDifficulty(int difficulty)
	{
		return ConfigLordGymByDifficulty.GetConfigList(difficulty, true);
	}

	// Token: 0x06010AE6 RID: 68326 RVA: 0x0040D0EE File Offset: 0x0040B2EE
	public IReadOnlyList<LordGymEntrance> GetLordGymEntranceAllConfig()
	{
		return ConfigLordGymEntranceAll.GetConfigList(true);
	}

	// Token: 0x06010AE7 RID: 68327 RVA: 0x0040D0F6 File Offset: 0x0040B2F6
	public LordGymEntrance? GetLordGymEntranceConfig(int lordEntranceId)
	{
		return ConfigLordGymEntranceById.GetConfig(lordEntranceId, true);
	}

	// Token: 0x06010AE8 RID: 68328 RVA: 0x0040D100 File Offset: 0x0040B300
	public int[] GetLordGymEntranceLordList(int lordEntranceId)
	{
		LordGymEntrance? config = ConfigLordGymEntranceById.GetConfig(lordEntranceId, true);
		if (config != null)
		{
			return config.Value.LordGymList();
		}
		return null;
	}

	// Token: 0x06010AE9 RID: 68329 RVA: 0x0040D130 File Offset: 0x0040B330
	public string GetLordGymEntranceName(int lordEntranceId)
	{
		LordGymEntrance? config = ConfigLordGymEntranceById.GetConfig(lordEntranceId, true);
		if (config != null)
		{
			return config.Value.EntranceTitle;
		}
		return null;
	}

	// Token: 0x06010AEA RID: 68330 RVA: 0x0040D160 File Offset: 0x0040B360
	public List<LordGymFilterType> GetAllLordGymFilterTypeConfig()
	{
		List<LordGymFilterType> list = ConfigCommon.ToList<LordGymFilterType>(ConfigLordGymFilterTypeAll.GetConfigList(true));
		if (list != null)
		{
			List<LordGymFilterType> list2 = new List<LordGymFilterType>();
			for (int i = 0; i < list.Count; i++)
			{
				if (list[i].IsEnable)
				{
					list2.Add(list[i]);
				}
			}
			list2.Sort((LordGymFilterType a, LordGymFilterType b) => a.Id - b.Id);
			return list2;
		}
		return list;
	}

	// Token: 0x17001527 RID: 5415
	// (get) Token: 0x06010AEB RID: 68331 RVA: 0x0040D1D9 File Offset: 0x0040B3D9
	[Nullable(1)]
	public static LordGymConfig Instance
	{
		[NullableContext(1)]
		get
		{
			return LordGymConfig._Instance;
		}
	}

	// Token: 0x06010AEC RID: 68332 RVA: 0x0040D1E0 File Offset: 0x0040B3E0
	[NullableContext(1)]
	public static LordGymConfig GetOrCreateInstance()
	{
		if (LordGymConfig._Instance == null)
		{
			LordGymConfig.CreateInstance();
		}
		return LordGymConfig._Instance;
	}

	// Token: 0x06010AED RID: 68333 RVA: 0x0040D1F4 File Offset: 0x0040B3F4
	public static bool CreateInstance()
	{
		if (LordGymConfig._Instance != null)
		{
			return true;
		}
		LordGymConfig._Instance = new LordGymConfig();
		return true;
	}

	// Token: 0x06010AEE RID: 68334 RVA: 0x0040D20A File Offset: 0x0040B40A
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06010AEF RID: 68335 RVA: 0x0040D20C File Offset: 0x0040B40C
	public static void ResetStaticDefaultValue()
	{
		LordGymConfig._Instance = null;
	}

	// Token: 0x06010AF0 RID: 68336 RVA: 0x0040D214 File Offset: 0x0040B414
	static LordGymConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(LordGymConfig.CreateStaticDefaultValue), new Action(LordGymConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04007EFE RID: 32510
	private static LordGymConfig _Instance;
}
