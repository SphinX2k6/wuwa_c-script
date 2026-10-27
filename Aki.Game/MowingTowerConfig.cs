using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x0200137A RID: 4986
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class MowingTowerConfig : ConfigBase
{
	// Token: 0x06008B87 RID: 35719 RVA: 0x001DD633 File Offset: 0x001DB833
	public MowTowerLevelsRe? GetBossMowingTowerConfigById(int id)
	{
		return ConfigMowTowerLevelsReById.GetConfig(id, true);
	}

	// Token: 0x06008B88 RID: 35720 RVA: 0x001DD63C File Offset: 0x001DB83C
	public MowTowerRewardRe? GetMowingTowerRewardById(int id)
	{
		return ConfigMowTowerRewardReById.GetConfig(id, true);
	}

	// Token: 0x06008B89 RID: 35721 RVA: 0x001DD645 File Offset: 0x001DB845
	public MowTowerBuffRe? GetMowingTowerBuffById(int id)
	{
		return ConfigMowTowerBuffReById.GetConfig(id, true);
	}

	// Token: 0x17000BDE RID: 3038
	// (get) Token: 0x06008B8A RID: 35722 RVA: 0x001DD64E File Offset: 0x001DB84E
	public static MowingTowerConfig Instance
	{
		get
		{
			return MowingTowerConfig._Instance;
		}
	}

	// Token: 0x06008B8B RID: 35723 RVA: 0x001DD655 File Offset: 0x001DB855
	public static MowingTowerConfig GetOrCreateInstance()
	{
		if (MowingTowerConfig._Instance == null)
		{
			MowingTowerConfig.CreateInstance();
		}
		return MowingTowerConfig._Instance;
	}

	// Token: 0x06008B8C RID: 35724 RVA: 0x001DD669 File Offset: 0x001DB869
	public static bool CreateInstance()
	{
		if (MowingTowerConfig._Instance != null)
		{
			return true;
		}
		MowingTowerConfig._Instance = new MowingTowerConfig();
		return true;
	}

	// Token: 0x06008B8D RID: 35725 RVA: 0x001DD67F File Offset: 0x001DB87F
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06008B8E RID: 35726 RVA: 0x001DD681 File Offset: 0x001DB881
	public static void ResetStaticDefaultValue()
	{
		MowingTowerConfig._Instance = null;
	}

	// Token: 0x06008B8F RID: 35727 RVA: 0x001DD689 File Offset: 0x001DB889
	static MowingTowerConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MowingTowerConfig.CreateStaticDefaultValue), new Action(MowingTowerConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04003DE8 RID: 15848
	[Nullable(2)]
	private static MowingTowerConfig _Instance;
}
