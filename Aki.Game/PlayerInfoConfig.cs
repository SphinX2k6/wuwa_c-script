using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020025EC RID: 9708
[NullableContext(2)]
[Nullable(0)]
[Config(0)]
public class PlayerInfoConfig : ConfigBase
{
	// Token: 0x06013BCF RID: 80847 RVA: 0x004F341C File Offset: 0x004F161C
	public bool GetIsUseAccountName()
	{
		return ConfigCommonParamById.GetBoolConfig("player_use_accountname").GetValueOrDefault(true);
	}

	// Token: 0x06013BD0 RID: 80848 RVA: 0x004F343C File Offset: 0x004F163C
	public string GetMaleIconPath()
	{
		return ConfigCommonParamById.GetStringConfig("player_male_headicon");
	}

	// Token: 0x06013BD1 RID: 80849 RVA: 0x004F3448 File Offset: 0x004F1648
	public string GetFemaleIconPath()
	{
		return ConfigCommonParamById.GetStringConfig("player_female_headicon");
	}

	// Token: 0x06013BD2 RID: 80850 RVA: 0x004F3454 File Offset: 0x004F1654
	public string GetMaleStandPath()
	{
		return ConfigCommonParamById.GetStringConfig("player_male_stand");
	}

	// Token: 0x06013BD3 RID: 80851 RVA: 0x004F3460 File Offset: 0x004F1660
	public string GetFemaleStandPath()
	{
		return ConfigCommonParamById.GetStringConfig("player_female_stand");
	}

	// Token: 0x06013BD4 RID: 80852 RVA: 0x004F346C File Offset: 0x004F166C
	[NullableContext(1)]
	public string GetPlayerBigIconPath(int iconId)
	{
		return ConfigHeadIconById.GetConfig(iconId, true).Value.BigIconPath;
	}

	// Token: 0x06013BD5 RID: 80853 RVA: 0x004F3490 File Offset: 0x004F1690
	public string GetPlayerIconPath(int iconId)
	{
		HeadIcon? config = ConfigHeadIconById.GetConfig(iconId, true);
		if (config == null)
		{
			return null;
		}
		return config.GetValueOrDefault().IconPath;
	}

	// Token: 0x1700194E RID: 6478
	// (get) Token: 0x06013BD6 RID: 80854 RVA: 0x004F34BF File Offset: 0x004F16BF
	[Nullable(1)]
	public static PlayerInfoConfig Instance
	{
		[NullableContext(1)]
		get
		{
			return PlayerInfoConfig._Instance;
		}
	}

	// Token: 0x06013BD7 RID: 80855 RVA: 0x004F34C6 File Offset: 0x004F16C6
	[NullableContext(1)]
	public static PlayerInfoConfig GetOrCreateInstance()
	{
		if (PlayerInfoConfig._Instance == null)
		{
			PlayerInfoConfig.CreateInstance();
		}
		return PlayerInfoConfig._Instance;
	}

	// Token: 0x06013BD8 RID: 80856 RVA: 0x004F34DA File Offset: 0x004F16DA
	public static bool CreateInstance()
	{
		if (PlayerInfoConfig._Instance != null)
		{
			return true;
		}
		PlayerInfoConfig._Instance = new PlayerInfoConfig();
		return true;
	}

	// Token: 0x06013BD9 RID: 80857 RVA: 0x004F34F0 File Offset: 0x004F16F0
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06013BDA RID: 80858 RVA: 0x004F34F2 File Offset: 0x004F16F2
	public static void ResetStaticDefaultValue()
	{
		PlayerInfoConfig._Instance = null;
	}

	// Token: 0x06013BDB RID: 80859 RVA: 0x004F34FA File Offset: 0x004F16FA
	static PlayerInfoConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PlayerInfoConfig.CreateStaticDefaultValue), new Action(PlayerInfoConfig.ResetStaticDefaultValue));
	}

	// Token: 0x040094CD RID: 38093
	private static PlayerInfoConfig _Instance;
}
