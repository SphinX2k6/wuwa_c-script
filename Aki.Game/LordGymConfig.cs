using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x0200166C RID: 5740
[NullableContext(2)]
[Nullable(0)]
[Config(0)]
public class LordGymConfig : ConfigBase
{
	// Token: 0x0600DF74 RID: 57204 RVA: 0x004199B0 File Offset: 0x00417BB0
	public LordGym? GetLordGymConfig(int lordId)
	{
		return ConfigLordGymById.GetConfig(lordId, true);
	}

	// Token: 0x0600DF75 RID: 57205 RVA: 0x004199B9 File Offset: 0x00417BB9
	public IReadOnlyList<LordGym> GetLordGymAllConfig()
	{
		return ConfigLordGymAll.GetConfigList(true);
	}

	// Token: 0x0600DF76 RID: 57206 RVA: 0x004199C1 File Offset: 0x00417BC1
	public IReadOnlyList<LordGym> GetLordGymAllConfigByDifficulty(int difficulty)
	{
		return ConfigLordGymByDifficulty.GetConfigList(difficulty, true);
	}

	// Token: 0x0600DF77 RID: 57207 RVA: 0x004199CA File Offset: 0x00417BCA
	public IReadOnlyList<LordGymEntrance> GetLordGymEntranceAllConfig()
	{
		return ConfigLordGymEntranceAll.GetConfigList(true);
	}

	// Token: 0x0600DF78 RID: 57208 RVA: 0x004199D2 File Offset: 0x00417BD2
	public LordGymEntrance? GetLordGymEntranceConfig(int lordEntranceId)
	{
		return ConfigLordGymEntranceById.GetConfig(lordEntranceId, true);
	}

	// Token: 0x0600DF79 RID: 57209 RVA: 0x004199DC File Offset: 0x00417BDC
	public int[] GetLordGymEntranceLordList(int lordEntranceId)
	{
		LordGymEntrance? config = ConfigLordGymEntranceById.GetConfig(lordEntranceId, true);
		if (config != null)
		{
			return config.Value.LordGymList();
		}
		return null;
	}

	// Token: 0x0600DF7A RID: 57210 RVA: 0x00419A0C File Offset: 0x00417C0C
	public string GetLordGymEntranceName(int lordEntranceId)
	{
		LordGymEntrance? config = ConfigLordGymEntranceById.GetConfig(lordEntranceId, true);
		if (config != null)
		{
			return config.Value.EntranceTitle;
		}
		return null;
	}

	// Token: 0x0600DF7B RID: 57211 RVA: 0x00419A3C File Offset: 0x00417C3C
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

	// Token: 0x1700155E RID: 5470
	// (get) Token: 0x0600DF7C RID: 57212 RVA: 0x00419AB5 File Offset: 0x00417CB5
	[Nullable(1)]
	public static LordGymConfig Instance
	{
		[NullableContext(1)]
		get
		{
			return LordGymConfig._Instance;
		}
	}

	// Token: 0x0600DF7D RID: 57213 RVA: 0x00419ABC File Offset: 0x00417CBC
	[NullableContext(1)]
	public static LordGymConfig GetOrCreateInstance()
	{
		if (LordGymConfig._Instance == null)
		{
			LordGymConfig.CreateInstance();
		}
		return LordGymConfig._Instance;
	}

	// Token: 0x0600DF7E RID: 57214 RVA: 0x00419AD0 File Offset: 0x00417CD0
	public static bool CreateInstance()
	{
		if (LordGymConfig._Instance != null)
		{
			return true;
		}
		LordGymConfig._Instance = new LordGymConfig();
		return true;
	}

	// Token: 0x0600DF7F RID: 57215 RVA: 0x00419AE6 File Offset: 0x00417CE6
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600DF80 RID: 57216 RVA: 0x00419AE8 File Offset: 0x00417CE8
	public static void ResetStaticDefaultValue()
	{
		LordGymConfig._Instance = null;
	}

	// Token: 0x0600DF81 RID: 57217 RVA: 0x00419AF0 File Offset: 0x00417CF0
	static LordGymConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(LordGymConfig.CreateStaticDefaultValue), new Action(LordGymConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04008045 RID: 32837
	private static LordGymConfig _Instance;
}
