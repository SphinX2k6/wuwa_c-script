using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02000EC8 RID: 3784
[NullableContext(2)]
[Nullable(0)]
public class SurvivorsRogueActivityEntityModel : SurvivorsRogueEntityModel, ISurvivorsRogueActivityEntityInfo, ISurvivorsRogueCombatInfo, ISurvivorsRogueConfigInfo
{
	// Token: 0x17000738 RID: 1848
	// (get) Token: 0x06005DFB RID: 24059 RVA: 0x00114EE5 File Offset: 0x001130E5
	// (set) Token: 0x06005DFC RID: 24060 RVA: 0x00114EED File Offset: 0x001130ED
	public int ConfigId { get; set; }

	// Token: 0x17000739 RID: 1849
	// (get) Token: 0x06005DFD RID: 24061 RVA: 0x00114EF6 File Offset: 0x001130F6
	// (set) Token: 0x06005DFE RID: 24062 RVA: 0x00114EFE File Offset: 0x001130FE
	public ESurvivorsRogueMonsterDeathType DeathType { get; set; }

	// Token: 0x1700073A RID: 1850
	// (get) Token: 0x06005DFF RID: 24063 RVA: 0x00114F07 File Offset: 0x00113107
	// (set) Token: 0x06005E00 RID: 24064 RVA: 0x00114F0F File Offset: 0x0011310F
	public int BuffRadius { get; set; }

	// Token: 0x1700073B RID: 1851
	// (get) Token: 0x06005E01 RID: 24065 RVA: 0x00114F18 File Offset: 0x00113118
	// (set) Token: 0x06005E02 RID: 24066 RVA: 0x00114F20 File Offset: 0x00113120
	public int[] BuffIds { get; set; }

	// Token: 0x1700073C RID: 1852
	// (get) Token: 0x06005E03 RID: 24067 RVA: 0x00114F29 File Offset: 0x00113129
	// (set) Token: 0x06005E04 RID: 24068 RVA: 0x00114F31 File Offset: 0x00113131
	public int[] SpawnIds { get; set; }

	// Token: 0x1700073D RID: 1853
	// (get) Token: 0x06005E05 RID: 24069 RVA: 0x00114F3A File Offset: 0x0011313A
	// (set) Token: 0x06005E06 RID: 24070 RVA: 0x00114F42 File Offset: 0x00113142
	public int PolluteRadius { get; set; }

	// Token: 0x06005E07 RID: 24071 RVA: 0x00114F4B File Offset: 0x0011314B
	static SurvivorsRogueActivityEntityModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SurvivorsRogueActivityEntityModel.CreateStaticDefaultValue), new Action(SurvivorsRogueActivityEntityModel.ResetStaticDefaultValue));
	}

	// Token: 0x06005E08 RID: 24072 RVA: 0x00114F6A File Offset: 0x0011316A
	public new static void CreateStaticDefaultValue()
	{
		SurvivorsRogueActivityEntityModel.ActivityEntityPool = new Pool<SurvivorsRogueActivityEntityModel>(100, () => new SurvivorsRogueActivityEntityModel(), null);
	}

	// Token: 0x06005E09 RID: 24073 RVA: 0x00114F98 File Offset: 0x00113198
	public new static void ResetStaticDefaultValue()
	{
		SurvivorsRogueActivityEntityModel.ActivityEntityPool = null;
	}

	// Token: 0x06005E0A RID: 24074 RVA: 0x00114FA0 File Offset: 0x001131A0
	[NullableContext(1)]
	public static SurvivorsRogueActivityEntityModel InitFromConfigId(int configId)
	{
		SurvivorsRogueActivityEntityModel survivorsRogueActivityEntityModel = SurvivorsRogueActivityEntityModel.ActivityEntityPool.Get();
		if (survivorsRogueActivityEntityModel == null)
		{
			survivorsRogueActivityEntityModel = SurvivorsRogueActivityEntityModel.ActivityEntityPool.Create();
		}
		if (survivorsRogueActivityEntityModel != null)
		{
			survivorsRogueActivityEntityModel.ConfigId = configId;
		}
		return survivorsRogueActivityEntityModel;
	}

	// Token: 0x06005E0B RID: 24075 RVA: 0x00114FD4 File Offset: 0x001131D4
	[NullableContext(1)]
	[return: Nullable(2)]
	public new static ISurvivorsRogueCombatInfo BuildModel(EntityPb entityData, Dictionary<string, EntityComponentPb> componentDataMap)
	{
		if (!componentDataMap.ContainsKey("SimpleCombatComponentPb") || !componentDataMap.ContainsKey("ActivityComponentPb"))
		{
			return null;
		}
		EntityComponentPb entityComponentPb;
		if (!componentDataMap.TryGetValue("ActivityComponentPb", out entityComponentPb) || ((entityComponentPb != null) ? entityComponentPb.ActivityComponentPb : null) == null)
		{
			return null;
		}
		SurvivorsRogueActivityEntityModel survivorsRogueActivityEntityModel = SurvivorsRogueActivityEntityModel.ActivityEntityPool.Get();
		if (survivorsRogueActivityEntityModel == null)
		{
			survivorsRogueActivityEntityModel = SurvivorsRogueActivityEntityModel.ActivityEntityPool.Create();
		}
		if (survivorsRogueActivityEntityModel != null)
		{
			survivorsRogueActivityEntityModel.InitFromProto(entityData, componentDataMap);
		}
		return survivorsRogueActivityEntityModel;
	}

	// Token: 0x06005E0C RID: 24076 RVA: 0x00115041 File Offset: 0x00113241
	public new static void Clear()
	{
		SurvivorsRogueActivityEntityModel.ActivityEntityPool.Clear();
	}

	// Token: 0x06005E0D RID: 24077 RVA: 0x00115050 File Offset: 0x00113250
	[NullableContext(1)]
	protected override void InitFromProto(EntityPb entityData, Dictionary<string, EntityComponentPb> componentDataMap)
	{
		base.InitFromProto(entityData, componentDataMap);
		ActivityComponentPb activityComponentPb = componentDataMap["ActivityComponentPb"].ActivityComponentPb;
		this.ConfigId = activityComponentPb.ConfigId;
		if (activityComponentPb.SurvivorsMonsterPbData != null)
		{
			base.EntityType = ESurvivorsRogueEntityType.Monster;
			this.DeathType = ESurvivorsRogueMonsterDeathType.Normal;
			this.BuffRadius = 0;
			this.BuffIds = null;
			this.SpawnIds = null;
			this.PolluteRadius = 0;
			return;
		}
		if (activityComponentPb.SurvivorsPlayerCharacterPbData != null)
		{
			base.EntityType = ESurvivorsRogueEntityType.PlayerCharacter;
			return;
		}
		if (activityComponentPb.SurvivorsWeaponPbData != null)
		{
			base.EntityType = ESurvivorsRogueEntityType.Weapon;
			return;
		}
		if (activityComponentPb.SurvivorsGoldenCoinPbData != null)
		{
			base.EntityType = ESurvivorsRogueEntityType.GoldenCoin;
		}
	}

	// Token: 0x06005E0E RID: 24078 RVA: 0x001150E4 File Offset: 0x001132E4
	[NullableContext(1)]
	public override void Update(ISurvivorsRogueCombatInfo other)
	{
		base.Update(other);
		ISurvivorsRogueActivityEntityInfo survivorsRogueActivityEntityInfo = (ISurvivorsRogueActivityEntityInfo)other;
		this.ConfigId = survivorsRogueActivityEntityInfo.ConfigId;
		this.DeathType = survivorsRogueActivityEntityInfo.DeathType;
		this.BuffRadius = survivorsRogueActivityEntityInfo.BuffRadius;
		this.BuffIds = survivorsRogueActivityEntityInfo.BuffIds;
		this.SpawnIds = survivorsRogueActivityEntityInfo.SpawnIds;
		this.PolluteRadius = survivorsRogueActivityEntityInfo.PolluteRadius;
	}

	// Token: 0x06005E0F RID: 24079 RVA: 0x00115147 File Offset: 0x00113347
	public new virtual void Reset()
	{
		base.Reset();
		this.ConfigId = 0;
		this.DeathType = ESurvivorsRogueMonsterDeathType.Normal;
		this.BuffRadius = 0;
		this.BuffIds = null;
		this.SpawnIds = null;
		this.PolluteRadius = 0;
	}

	// Token: 0x06005E10 RID: 24080 RVA: 0x00115179 File Offset: 0x00113379
	public new virtual void Release()
	{
		this.Reset();
		SurvivorsRogueActivityEntityModel.ActivityEntityPool.Put(this);
	}

	// Token: 0x06005E11 RID: 24081 RVA: 0x00115190 File Offset: 0x00113390
	[NullableContext(1)]
	public new ISurvivorsRogueCombatInfo Clone()
	{
		SurvivorsRogueActivityEntityModel survivorsRogueActivityEntityModel = SurvivorsRogueActivityEntityModel.ActivityEntityPool.Get();
		if (survivorsRogueActivityEntityModel == null)
		{
			survivorsRogueActivityEntityModel = SurvivorsRogueActivityEntityModel.ActivityEntityPool.Create();
		}
		if (survivorsRogueActivityEntityModel != null)
		{
			survivorsRogueActivityEntityModel.Update(this);
		}
		return survivorsRogueActivityEntityModel;
	}

	// Token: 0x04002AC6 RID: 10950
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static Pool<SurvivorsRogueActivityEntityModel> ActivityEntityPool;
}
