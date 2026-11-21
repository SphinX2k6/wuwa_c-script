using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x0200037D RID: 893
[NullableContext(2)]
[Nullable(0)]
public class SurvivorsRogueActivityEntityModel : SurvivorsRogueEntityModel, ISurvivorsRogueActivityEntityInfo, ISurvivorsRogueCombatInfo, ISurvivorsRogueConfigInfo
{
	// Token: 0x1700075C RID: 1884
	// (get) Token: 0x06003192 RID: 12690 RVA: 0x0011CBC5 File Offset: 0x0011ADC5
	// (set) Token: 0x06003193 RID: 12691 RVA: 0x0011CBCD File Offset: 0x0011ADCD
	public int ConfigId { get; set; }

	// Token: 0x1700075D RID: 1885
	// (get) Token: 0x06003194 RID: 12692 RVA: 0x0011CBD6 File Offset: 0x0011ADD6
	// (set) Token: 0x06003195 RID: 12693 RVA: 0x0011CBDE File Offset: 0x0011ADDE
	public ESurvivorsRogueMonsterDeathType DeathType { get; set; }

	// Token: 0x1700075E RID: 1886
	// (get) Token: 0x06003196 RID: 12694 RVA: 0x0011CBE7 File Offset: 0x0011ADE7
	// (set) Token: 0x06003197 RID: 12695 RVA: 0x0011CBEF File Offset: 0x0011ADEF
	public int BuffRadius { get; set; }

	// Token: 0x1700075F RID: 1887
	// (get) Token: 0x06003198 RID: 12696 RVA: 0x0011CBF8 File Offset: 0x0011ADF8
	// (set) Token: 0x06003199 RID: 12697 RVA: 0x0011CC00 File Offset: 0x0011AE00
	public int[] BuffIds { get; set; }

	// Token: 0x17000760 RID: 1888
	// (get) Token: 0x0600319A RID: 12698 RVA: 0x0011CC09 File Offset: 0x0011AE09
	// (set) Token: 0x0600319B RID: 12699 RVA: 0x0011CC11 File Offset: 0x0011AE11
	public int[] SpawnIds { get; set; }

	// Token: 0x17000761 RID: 1889
	// (get) Token: 0x0600319C RID: 12700 RVA: 0x0011CC1A File Offset: 0x0011AE1A
	// (set) Token: 0x0600319D RID: 12701 RVA: 0x0011CC22 File Offset: 0x0011AE22
	public int PolluteRadius { get; set; }

	// Token: 0x0600319E RID: 12702 RVA: 0x0011CC2B File Offset: 0x0011AE2B
	static SurvivorsRogueActivityEntityModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SurvivorsRogueActivityEntityModel.CreateStaticDefaultValue), new Action(SurvivorsRogueActivityEntityModel.ResetStaticDefaultValue));
	}

	// Token: 0x0600319F RID: 12703 RVA: 0x0011CC4A File Offset: 0x0011AE4A
	public new static void CreateStaticDefaultValue()
	{
		SurvivorsRogueActivityEntityModel.ActivityEntityPool = new Pool<SurvivorsRogueActivityEntityModel>(100, () => new SurvivorsRogueActivityEntityModel(), null);
	}

	// Token: 0x060031A0 RID: 12704 RVA: 0x0011CC78 File Offset: 0x0011AE78
	public new static void ResetStaticDefaultValue()
	{
		SurvivorsRogueActivityEntityModel.ActivityEntityPool = null;
	}

	// Token: 0x060031A1 RID: 12705 RVA: 0x0011CC80 File Offset: 0x0011AE80
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

	// Token: 0x060031A2 RID: 12706 RVA: 0x0011CCB4 File Offset: 0x0011AEB4
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

	// Token: 0x060031A3 RID: 12707 RVA: 0x0011CD21 File Offset: 0x0011AF21
	public new static void Clear()
	{
		SurvivorsRogueActivityEntityModel.ActivityEntityPool.Clear();
	}

	// Token: 0x060031A4 RID: 12708 RVA: 0x0011CD30 File Offset: 0x0011AF30
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

	// Token: 0x060031A5 RID: 12709 RVA: 0x0011CDC4 File Offset: 0x0011AFC4
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

	// Token: 0x060031A6 RID: 12710 RVA: 0x0011CE27 File Offset: 0x0011B027
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

	// Token: 0x060031A7 RID: 12711 RVA: 0x0011CE59 File Offset: 0x0011B059
	public new virtual void Release()
	{
		this.Reset();
		SurvivorsRogueActivityEntityModel.ActivityEntityPool.Put(this);
	}

	// Token: 0x060031A8 RID: 12712 RVA: 0x0011CE70 File Offset: 0x0011B070
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

	// Token: 0x04002B61 RID: 11105
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static Pool<SurvivorsRogueActivityEntityModel> ActivityEntityPool;
}
