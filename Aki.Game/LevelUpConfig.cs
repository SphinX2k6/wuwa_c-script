using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02002065 RID: 8293
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class LevelUpConfig : ConfigBase
{
	// Token: 0x06010523 RID: 66851 RVA: 0x003FBCE8 File Offset: 0x003F9EE8
	public int? GetExpBarAnimationLength()
	{
		return ConfigCommonParamById.GetIntConfig("LevelUpAnimationLength");
	}

	// Token: 0x06010524 RID: 66852 RVA: 0x003FBCF4 File Offset: 0x003F9EF4
	public int? GetLevelUpViewCloseDelay()
	{
		return ConfigCommonParamById.GetIntConfig("LevelUpViewCloseDelay");
	}

	// Token: 0x06010525 RID: 66853 RVA: 0x003FBD00 File Offset: 0x003F9F00
	public int? GetMaxExpCloseDelay()
	{
		return ConfigCommonParamById.GetIntConfig("MaxExpCloseDelay");
	}

	// Token: 0x06010526 RID: 66854 RVA: 0x003FBD0C File Offset: 0x003F9F0C
	public int? GetHiddenLevelUpLevel()
	{
		return ConfigCommonParamById.GetIntConfig("HiddenLevelUpView");
	}

	// Token: 0x1700141C RID: 5148
	// (get) Token: 0x06010527 RID: 66855 RVA: 0x003FBD18 File Offset: 0x003F9F18
	public static LevelUpConfig Instance
	{
		get
		{
			return LevelUpConfig._Instance;
		}
	}

	// Token: 0x06010528 RID: 66856 RVA: 0x003FBD1F File Offset: 0x003F9F1F
	public static LevelUpConfig GetOrCreateInstance()
	{
		if (LevelUpConfig._Instance == null)
		{
			LevelUpConfig.CreateInstance();
		}
		return LevelUpConfig._Instance;
	}

	// Token: 0x06010529 RID: 66857 RVA: 0x003FBD33 File Offset: 0x003F9F33
	public static bool CreateInstance()
	{
		if (LevelUpConfig._Instance != null)
		{
			return true;
		}
		LevelUpConfig._Instance = new LevelUpConfig();
		return true;
	}

	// Token: 0x0601052A RID: 66858 RVA: 0x003FBD49 File Offset: 0x003F9F49
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601052B RID: 66859 RVA: 0x003FBD4B File Offset: 0x003F9F4B
	public static void ResetStaticDefaultValue()
	{
		LevelUpConfig._Instance = null;
	}

	// Token: 0x0601052C RID: 66860 RVA: 0x003FBD53 File Offset: 0x003F9F53
	static LevelUpConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(LevelUpConfig.CreateStaticDefaultValue), new Action(LevelUpConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400789F RID: 30879
	[Nullable(2)]
	private static LevelUpConfig _Instance;
}
