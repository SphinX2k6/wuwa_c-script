using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02000344 RID: 836
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class MotorcycleArrowConfig : ConfigBase
{
	// Token: 0x06002EF4 RID: 12020 RVA: 0x00112CE2 File Offset: 0x00110EE2
	protected override bool OnInit()
	{
		return true;
	}

	// Token: 0x06002EF5 RID: 12021 RVA: 0x00112CE5 File Offset: 0x00110EE5
	protected override bool OnClear()
	{
		return true;
	}

	// Token: 0x06002EF6 RID: 12022 RVA: 0x00112CE8 File Offset: 0x00110EE8
	public MotorFightMainLevel? GetLevelByInstId(int id)
	{
		return ConfigMotorFightMainLevelByInstId.GetConfig(id, true);
	}

	// Token: 0x06002EF7 RID: 12023 RVA: 0x00112CF1 File Offset: 0x00110EF1
	public MotorFightMainLevel? GetLevelByLevelId(int id)
	{
		return ConfigMotorFightMainLevelByLevelId.GetConfig(id, true);
	}

	// Token: 0x06002EF8 RID: 12024 RVA: 0x00112CFA File Offset: 0x00110EFA
	public MotorFightRole? GetMotorFightRoleById(int id)
	{
		return ConfigMotorFightRoleById.GetConfig(id, true);
	}

	// Token: 0x06002EF9 RID: 12025 RVA: 0x00112D03 File Offset: 0x00110F03
	public MotorFightSubLevel? GetSubLevelByInstId(int id)
	{
		return ConfigMotorFightSubLevelBySubLevelId.GetConfig(id, true);
	}

	// Token: 0x06002EFA RID: 12026 RVA: 0x00112D0C File Offset: 0x00110F0C
	public MotorFightWaveGroup? GetMotorFightWaveGroupById(int id)
	{
		return ConfigMotorFightWaveGroupById.GetConfig(id, true);
	}

	// Token: 0x06002EFB RID: 12027 RVA: 0x00112D15 File Offset: 0x00110F15
	public MotorFightWave? GetMotorFightWaveById(int id)
	{
		return ConfigMotorFightWaveByWaveId.GetConfig(id, true);
	}

	// Token: 0x06002EFC RID: 12028 RVA: 0x00112D1E File Offset: 0x00110F1E
	public MotorFightMonsterRefresh? GetMonsterRefreshById(int id)
	{
		return ConfigMotorFightMonsterRefreshById.GetConfig(id, true);
	}

	// Token: 0x06002EFD RID: 12029 RVA: 0x00112D27 File Offset: 0x00110F27
	public MotorFightBossRefresh? GetBossRefreshById(int id)
	{
		return ConfigMotorFightBossRefreshById.GetConfig(id, true);
	}

	// Token: 0x06002EFE RID: 12030 RVA: 0x00112D30 File Offset: 0x00110F30
	public MotorMonster? GetMonsterConfigById(int id)
	{
		return ConfigMotorMonsterById.GetConfig(id, true);
	}

	// Token: 0x06002EFF RID: 12031 RVA: 0x00112D39 File Offset: 0x00110F39
	public MotorFightBuffGateRefresh? GetBuffRefreshByRefreshId(int id)
	{
		return ConfigMotorFightBuffGateRefreshById.GetConfig(id, true);
	}

	// Token: 0x06002F00 RID: 12032 RVA: 0x00112D42 File Offset: 0x00110F42
	public MotorFightBuffGate? GetBuffGateConfigById(int id)
	{
		return ConfigMotorFightBuffGateById.GetConfig(id, true);
	}

	// Token: 0x06002F01 RID: 12033 RVA: 0x00112D4C File Offset: 0x00110F4C
	public MotorFightBuffGate? GetBuffGateByRefreshId(int id)
	{
		MotorFightBuffGateRefresh? buffRefreshByRefreshId = this.GetBuffRefreshByRefreshId(id);
		if (buffRefreshByRefreshId == null)
		{
			return null;
		}
		return this.GetBuffGateConfigById(buffRefreshByRefreshId.Value.BuffGateId);
	}

	// Token: 0x06002F02 RID: 12034 RVA: 0x00112D89 File Offset: 0x00110F89
	public MotorFightBuffEffect? GetBuffEffectById(int id)
	{
		return ConfigMotorFightBuffEffectById.GetConfig(id, true);
	}

	// Token: 0x06002F03 RID: 12035 RVA: 0x00112D92 File Offset: 0x00110F92
	public MotorFightItem? GetCollectionItemConfigById(int id)
	{
		return ConfigMotorFightItemById.GetConfig(id, true);
	}

	// Token: 0x06002F04 RID: 12036 RVA: 0x00112D9B File Offset: 0x00110F9B
	public MotorFightItemType? GetCollectionTypeConfigById(int id)
	{
		return ConfigMotorFightItemTypeById.GetConfig(id, true);
	}

	// Token: 0x06002F05 RID: 12037 RVA: 0x00112DA4 File Offset: 0x00110FA4
	public MotorFightQuality? GetMotorFightQuality(int id)
	{
		return ConfigMotorFightQualityById.GetConfig(id, true);
	}

	// Token: 0x170006CD RID: 1741
	// (get) Token: 0x06002F06 RID: 12038 RVA: 0x00112DAD File Offset: 0x00110FAD
	public static MotorcycleArrowConfig Instance
	{
		get
		{
			return MotorcycleArrowConfig._Instance;
		}
	}

	// Token: 0x06002F07 RID: 12039 RVA: 0x00112DB4 File Offset: 0x00110FB4
	public static MotorcycleArrowConfig GetOrCreateInstance()
	{
		if (MotorcycleArrowConfig._Instance == null)
		{
			MotorcycleArrowConfig.CreateInstance();
		}
		return MotorcycleArrowConfig._Instance;
	}

	// Token: 0x06002F08 RID: 12040 RVA: 0x00112DC8 File Offset: 0x00110FC8
	public static bool CreateInstance()
	{
		if (MotorcycleArrowConfig._Instance != null)
		{
			return true;
		}
		MotorcycleArrowConfig._Instance = new MotorcycleArrowConfig();
		return true;
	}

	// Token: 0x06002F09 RID: 12041 RVA: 0x00112DDE File Offset: 0x00110FDE
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06002F0A RID: 12042 RVA: 0x00112DE0 File Offset: 0x00110FE0
	public static void ResetStaticDefaultValue()
	{
		MotorcycleArrowConfig._Instance = null;
	}

	// Token: 0x06002F0B RID: 12043 RVA: 0x00112DE8 File Offset: 0x00110FE8
	static MotorcycleArrowConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MotorcycleArrowConfig.CreateStaticDefaultValue), new Action(MotorcycleArrowConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04002A4E RID: 10830
	[Nullable(2)]
	private static MotorcycleArrowConfig _Instance;
}
