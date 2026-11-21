using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001538 RID: 5432
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class LevelUpConfig : ConfigBase
{
	// Token: 0x0600D98B RID: 55691 RVA: 0x00408130 File Offset: 0x00406330
	public int? GetExpBarAnimationLength()
	{
		return ConfigCommonParamById.GetIntConfig("LevelUpAnimationLength");
	}

	// Token: 0x0600D98C RID: 55692 RVA: 0x0040813C File Offset: 0x0040633C
	public int? GetLevelUpViewCloseDelay()
	{
		return ConfigCommonParamById.GetIntConfig("LevelUpViewCloseDelay");
	}

	// Token: 0x0600D98D RID: 55693 RVA: 0x00408148 File Offset: 0x00406348
	public int? GetMaxExpCloseDelay()
	{
		return ConfigCommonParamById.GetIntConfig("MaxExpCloseDelay");
	}

	// Token: 0x0600D98E RID: 55694 RVA: 0x00408154 File Offset: 0x00406354
	public int? GetHiddenLevelUpLevel()
	{
		return ConfigCommonParamById.GetIntConfig("HiddenLevelUpView");
	}

	// Token: 0x17001449 RID: 5193
	// (get) Token: 0x0600D98F RID: 55695 RVA: 0x00408160 File Offset: 0x00406360
	public static LevelUpConfig Instance
	{
		get
		{
			return LevelUpConfig._Instance;
		}
	}

	// Token: 0x0600D990 RID: 55696 RVA: 0x00408167 File Offset: 0x00406367
	public static LevelUpConfig GetOrCreateInstance()
	{
		if (LevelUpConfig._Instance == null)
		{
			LevelUpConfig.CreateInstance();
		}
		return LevelUpConfig._Instance;
	}

	// Token: 0x0600D991 RID: 55697 RVA: 0x0040817B File Offset: 0x0040637B
	public static bool CreateInstance()
	{
		if (LevelUpConfig._Instance != null)
		{
			return true;
		}
		LevelUpConfig._Instance = new LevelUpConfig();
		return true;
	}

	// Token: 0x0600D992 RID: 55698 RVA: 0x00408191 File Offset: 0x00406391
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600D993 RID: 55699 RVA: 0x00408193 File Offset: 0x00406393
	public static void ResetStaticDefaultValue()
	{
		LevelUpConfig._Instance = null;
	}

	// Token: 0x0600D994 RID: 55700 RVA: 0x0040819B File Offset: 0x0040639B
	static LevelUpConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(LevelUpConfig.CreateStaticDefaultValue), new Action(LevelUpConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04007988 RID: 31112
	[Nullable(2)]
	private static LevelUpConfig _Instance;
}
