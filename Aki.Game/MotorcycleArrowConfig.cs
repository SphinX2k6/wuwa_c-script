using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02000E8F RID: 3727
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class MotorcycleArrowConfig : ConfigBase
{
	// Token: 0x06005B5D RID: 23389 RVA: 0x0010B04A File Offset: 0x0010924A
	protected override bool OnInit()
	{
		return true;
	}

	// Token: 0x06005B5E RID: 23390 RVA: 0x0010B04D File Offset: 0x0010924D
	protected override bool OnClear()
	{
		return true;
	}

	// Token: 0x06005B5F RID: 23391 RVA: 0x0010B050 File Offset: 0x00109250
	public MotorFightMainLevel? GetLevelByInstId(int id)
	{
		return ConfigMotorFightMainLevelByInstId.GetConfig(id, true);
	}

	// Token: 0x06005B60 RID: 23392 RVA: 0x0010B059 File Offset: 0x00109259
	public MotorFightMainLevel? GetLevelByLevelId(int id)
	{
		return ConfigMotorFightMainLevelByLevelId.GetConfig(id, true);
	}

	// Token: 0x06005B61 RID: 23393 RVA: 0x0010B062 File Offset: 0x00109262
	public MotorFightRole? GetMotorFightRoleById(int id)
	{
		return ConfigMotorFightRoleById.GetConfig(id, true);
	}

	// Token: 0x06005B62 RID: 23394 RVA: 0x0010B06B File Offset: 0x0010926B
	public MotorFightSubLevel? GetSubLevelByInstId(int id)
	{
		return ConfigMotorFightSubLevelBySubLevelId.GetConfig(id, true);
	}

	// Token: 0x06005B63 RID: 23395 RVA: 0x0010B074 File Offset: 0x00109274
	public MotorFightWaveGroup? GetMotorFightWaveGroupById(int id)
	{
		return ConfigMotorFightWaveGroupById.GetConfig(id, true);
	}

	// Token: 0x06005B64 RID: 23396 RVA: 0x0010B07D File Offset: 0x0010927D
	public MotorFightWave? GetMotorFightWaveById(int id)
	{
		return ConfigMotorFightWaveByWaveId.GetConfig(id, true);
	}

	// Token: 0x06005B65 RID: 23397 RVA: 0x0010B086 File Offset: 0x00109286
	public MotorFightMonsterRefresh? GetMonsterRefreshById(int id)
	{
		return ConfigMotorFightMonsterRefreshById.GetConfig(id, true);
	}

	// Token: 0x06005B66 RID: 23398 RVA: 0x0010B08F File Offset: 0x0010928F
	public MotorFightBossRefresh? GetBossRefreshById(int id)
	{
		return ConfigMotorFightBossRefreshById.GetConfig(id, true);
	}

	// Token: 0x06005B67 RID: 23399 RVA: 0x0010B098 File Offset: 0x00109298
	public MotorMonster? GetMonsterConfigById(int id)
	{
		return ConfigMotorMonsterById.GetConfig(id, true);
	}

	// Token: 0x06005B68 RID: 23400 RVA: 0x0010B0A1 File Offset: 0x001092A1
	public MotorFightBuffGateRefresh? GetBuffRefreshByRefreshId(int id)
	{
		return ConfigMotorFightBuffGateRefreshById.GetConfig(id, true);
	}

	// Token: 0x06005B69 RID: 23401 RVA: 0x0010B0AA File Offset: 0x001092AA
	public MotorFightBuffGate? GetBuffGateConfigById(int id)
	{
		return ConfigMotorFightBuffGateById.GetConfig(id, true);
	}

	// Token: 0x06005B6A RID: 23402 RVA: 0x0010B0B4 File Offset: 0x001092B4
	public MotorFightBuffGate? GetBuffGateByRefreshId(int id)
	{
		MotorFightBuffGateRefresh? buffRefreshByRefreshId = this.GetBuffRefreshByRefreshId(id);
		if (buffRefreshByRefreshId == null)
		{
			return null;
		}
		return this.GetBuffGateConfigById(buffRefreshByRefreshId.Value.BuffGateId);
	}

	// Token: 0x06005B6B RID: 23403 RVA: 0x0010B0F1 File Offset: 0x001092F1
	public MotorFightBuffEffect? GetBuffEffectById(int id)
	{
		return ConfigMotorFightBuffEffectById.GetConfig(id, true);
	}

	// Token: 0x06005B6C RID: 23404 RVA: 0x0010B0FA File Offset: 0x001092FA
	public MotorFightItem? GetCollectionItemConfigById(int id)
	{
		return ConfigMotorFightItemById.GetConfig(id, true);
	}

	// Token: 0x06005B6D RID: 23405 RVA: 0x0010B103 File Offset: 0x00109303
	public MotorFightItemType? GetCollectionTypeConfigById(int id)
	{
		return ConfigMotorFightItemTypeById.GetConfig(id, true);
	}

	// Token: 0x06005B6E RID: 23406 RVA: 0x0010B10C File Offset: 0x0010930C
	public MotorFightQuality? GetMotorFightQuality(int id)
	{
		return ConfigMotorFightQualityById.GetConfig(id, true);
	}

	// Token: 0x170006A9 RID: 1705
	// (get) Token: 0x06005B6F RID: 23407 RVA: 0x0010B115 File Offset: 0x00109315
	public static MotorcycleArrowConfig Instance
	{
		get
		{
			return MotorcycleArrowConfig._Instance;
		}
	}

	// Token: 0x06005B70 RID: 23408 RVA: 0x0010B11C File Offset: 0x0010931C
	public static MotorcycleArrowConfig GetOrCreateInstance()
	{
		if (MotorcycleArrowConfig._Instance == null)
		{
			MotorcycleArrowConfig.CreateInstance();
		}
		return MotorcycleArrowConfig._Instance;
	}

	// Token: 0x06005B71 RID: 23409 RVA: 0x0010B130 File Offset: 0x00109330
	public static bool CreateInstance()
	{
		if (MotorcycleArrowConfig._Instance != null)
		{
			return true;
		}
		MotorcycleArrowConfig._Instance = new MotorcycleArrowConfig();
		return true;
	}

	// Token: 0x06005B72 RID: 23410 RVA: 0x0010B146 File Offset: 0x00109346
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06005B73 RID: 23411 RVA: 0x0010B148 File Offset: 0x00109348
	public static void ResetStaticDefaultValue()
	{
		MotorcycleArrowConfig._Instance = null;
	}

	// Token: 0x06005B74 RID: 23412 RVA: 0x0010B150 File Offset: 0x00109350
	static MotorcycleArrowConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MotorcycleArrowConfig.CreateStaticDefaultValue), new Action(MotorcycleArrowConfig.ResetStaticDefaultValue));
	}

	// Token: 0x040029B3 RID: 10675
	[Nullable(2)]
	private static MotorcycleArrowConfig _Instance;
}
