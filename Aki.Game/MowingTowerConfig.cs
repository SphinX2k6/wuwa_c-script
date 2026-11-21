using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x0200082E RID: 2094
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class MowingTowerConfig : ConfigBase
{
	// Token: 0x06005F22 RID: 24354 RVA: 0x001E646F File Offset: 0x001E466F
	public MowTowerLevelsRe? GetBossMowingTowerConfigById(int id)
	{
		return ConfigMowTowerLevelsReById.GetConfig(id, true);
	}

	// Token: 0x06005F23 RID: 24355 RVA: 0x001E6478 File Offset: 0x001E4678
	public MowTowerRewardRe? GetMowingTowerRewardById(int id)
	{
		return ConfigMowTowerRewardReById.GetConfig(id, true);
	}

	// Token: 0x06005F24 RID: 24356 RVA: 0x001E6481 File Offset: 0x001E4681
	public MowTowerBuffRe? GetMowingTowerBuffById(int id)
	{
		return ConfigMowTowerBuffReById.GetConfig(id, true);
	}

	// Token: 0x17000BFE RID: 3070
	// (get) Token: 0x06005F25 RID: 24357 RVA: 0x001E648A File Offset: 0x001E468A
	public static MowingTowerConfig Instance
	{
		get
		{
			return MowingTowerConfig._Instance;
		}
	}

	// Token: 0x06005F26 RID: 24358 RVA: 0x001E6491 File Offset: 0x001E4691
	public static MowingTowerConfig GetOrCreateInstance()
	{
		if (MowingTowerConfig._Instance == null)
		{
			MowingTowerConfig.CreateInstance();
		}
		return MowingTowerConfig._Instance;
	}

	// Token: 0x06005F27 RID: 24359 RVA: 0x001E64A5 File Offset: 0x001E46A5
	public static bool CreateInstance()
	{
		if (MowingTowerConfig._Instance != null)
		{
			return true;
		}
		MowingTowerConfig._Instance = new MowingTowerConfig();
		return true;
	}

	// Token: 0x06005F28 RID: 24360 RVA: 0x001E64BB File Offset: 0x001E46BB
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06005F29 RID: 24361 RVA: 0x001E64BD File Offset: 0x001E46BD
	public static void ResetStaticDefaultValue()
	{
		MowingTowerConfig._Instance = null;
	}

	// Token: 0x06005F2A RID: 24362 RVA: 0x001E64C5 File Offset: 0x001E46C5
	static MowingTowerConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MowingTowerConfig.CreateStaticDefaultValue), new Action(MowingTowerConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04003E80 RID: 16000
	[Nullable(2)]
	private static MowingTowerConfig _Instance;
}
