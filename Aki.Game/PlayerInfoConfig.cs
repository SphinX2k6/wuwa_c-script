using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001AD7 RID: 6871
[NullableContext(2)]
[Nullable(0)]
[Config(0)]
public class PlayerInfoConfig : ConfigBase
{
	// Token: 0x060110B1 RID: 69809 RVA: 0x00502194 File Offset: 0x00500394
	public bool GetIsUseAccountName()
	{
		return ConfigCommonParamById.GetBoolConfig("player_use_accountname").GetValueOrDefault(true);
	}

	// Token: 0x060110B2 RID: 69810 RVA: 0x005021B4 File Offset: 0x005003B4
	public string GetMaleIconPath()
	{
		return ConfigCommonParamById.GetStringConfig("player_male_headicon");
	}

	// Token: 0x060110B3 RID: 69811 RVA: 0x005021C0 File Offset: 0x005003C0
	public string GetFemaleIconPath()
	{
		return ConfigCommonParamById.GetStringConfig("player_female_headicon");
	}

	// Token: 0x060110B4 RID: 69812 RVA: 0x005021CC File Offset: 0x005003CC
	public string GetMaleStandPath()
	{
		return ConfigCommonParamById.GetStringConfig("player_male_stand");
	}

	// Token: 0x060110B5 RID: 69813 RVA: 0x005021D8 File Offset: 0x005003D8
	public string GetFemaleStandPath()
	{
		return ConfigCommonParamById.GetStringConfig("player_female_stand");
	}

	// Token: 0x060110B6 RID: 69814 RVA: 0x005021E4 File Offset: 0x005003E4
	[NullableContext(1)]
	public string GetPlayerBigIconPath(int iconId)
	{
		return ConfigHeadIconById.GetConfig(iconId, true).Value.BigIconPath;
	}

	// Token: 0x060110B7 RID: 69815 RVA: 0x00502208 File Offset: 0x00500408
	public string GetPlayerIconPath(int iconId)
	{
		HeadIcon? config = ConfigHeadIconById.GetConfig(iconId, true);
		if (config == null)
		{
			return null;
		}
		return config.GetValueOrDefault().IconPath;
	}

	// Token: 0x17001986 RID: 6534
	// (get) Token: 0x060110B8 RID: 69816 RVA: 0x00502237 File Offset: 0x00500437
	[Nullable(1)]
	public static PlayerInfoConfig Instance
	{
		[NullableContext(1)]
		get
		{
			return PlayerInfoConfig._Instance;
		}
	}

	// Token: 0x060110B9 RID: 69817 RVA: 0x0050223E File Offset: 0x0050043E
	[NullableContext(1)]
	public static PlayerInfoConfig GetOrCreateInstance()
	{
		if (PlayerInfoConfig._Instance == null)
		{
			PlayerInfoConfig.CreateInstance();
		}
		return PlayerInfoConfig._Instance;
	}

	// Token: 0x060110BA RID: 69818 RVA: 0x00502252 File Offset: 0x00500452
	public static bool CreateInstance()
	{
		if (PlayerInfoConfig._Instance != null)
		{
			return true;
		}
		PlayerInfoConfig._Instance = new PlayerInfoConfig();
		return true;
	}

	// Token: 0x060110BB RID: 69819 RVA: 0x00502268 File Offset: 0x00500468
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060110BC RID: 69820 RVA: 0x0050226A File Offset: 0x0050046A
	public static void ResetStaticDefaultValue()
	{
		PlayerInfoConfig._Instance = null;
	}

	// Token: 0x060110BD RID: 69821 RVA: 0x00502272 File Offset: 0x00500472
	static PlayerInfoConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PlayerInfoConfig.CreateStaticDefaultValue), new Action(PlayerInfoConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04009624 RID: 38436
	private static PlayerInfoConfig _Instance;
}
