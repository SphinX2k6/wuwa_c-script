using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02000EB5 RID: 3765
[NullableContext(2)]
[Nullable(0)]
public class PotatoActivityEntityModel : PotatoEntityModel, IPotatoActivityEntityInfo, IPotatoCombatInfo, IPotatoConfigInfo
{
	// Token: 0x1700070C RID: 1804
	// (get) Token: 0x06005D24 RID: 23844 RVA: 0x00111939 File Offset: 0x0010FB39
	// (set) Token: 0x06005D25 RID: 23845 RVA: 0x00111941 File Offset: 0x0010FB41
	public int ConfigId { get; set; }

	// Token: 0x1700070D RID: 1805
	// (get) Token: 0x06005D26 RID: 23846 RVA: 0x0011194A File Offset: 0x0010FB4A
	// (set) Token: 0x06005D27 RID: 23847 RVA: 0x00111952 File Offset: 0x0010FB52
	public EPotatoMonsterDeathType DeathType { get; set; }

	// Token: 0x1700070E RID: 1806
	// (get) Token: 0x06005D28 RID: 23848 RVA: 0x0011195B File Offset: 0x0010FB5B
	// (set) Token: 0x06005D29 RID: 23849 RVA: 0x00111963 File Offset: 0x0010FB63
	public int BuffRadius { get; set; }

	// Token: 0x1700070F RID: 1807
	// (get) Token: 0x06005D2A RID: 23850 RVA: 0x0011196C File Offset: 0x0010FB6C
	// (set) Token: 0x06005D2B RID: 23851 RVA: 0x00111974 File Offset: 0x0010FB74
	public int[] BuffIds { get; set; }

	// Token: 0x17000710 RID: 1808
	// (get) Token: 0x06005D2C RID: 23852 RVA: 0x0011197D File Offset: 0x0010FB7D
	// (set) Token: 0x06005D2D RID: 23853 RVA: 0x00111985 File Offset: 0x0010FB85
	public int[] SpawnIds { get; set; }

	// Token: 0x17000711 RID: 1809
	// (get) Token: 0x06005D2E RID: 23854 RVA: 0x0011198E File Offset: 0x0010FB8E
	// (set) Token: 0x06005D2F RID: 23855 RVA: 0x00111996 File Offset: 0x0010FB96
	public int PolluteRadius { get; set; }

	// Token: 0x17000712 RID: 1810
	// (get) Token: 0x06005D30 RID: 23856 RVA: 0x0011199F File Offset: 0x0010FB9F
	// (set) Token: 0x06005D31 RID: 23857 RVA: 0x001119A7 File Offset: 0x0010FBA7
	public int IncId { get; set; }

	// Token: 0x17000713 RID: 1811
	// (get) Token: 0x06005D32 RID: 23858 RVA: 0x001119B0 File Offset: 0x0010FBB0
	// (set) Token: 0x06005D33 RID: 23859 RVA: 0x001119B8 File Offset: 0x0010FBB8
	public int SpawnConfigId { get; set; }

	// Token: 0x17000714 RID: 1812
	// (get) Token: 0x06005D34 RID: 23860 RVA: 0x001119C1 File Offset: 0x0010FBC1
	// (set) Token: 0x06005D35 RID: 23861 RVA: 0x001119C9 File Offset: 0x0010FBC9
	public int SpawnConfigGroupIndex { get; set; }

	// Token: 0x06005D36 RID: 23862 RVA: 0x001119D2 File Offset: 0x0010FBD2
	static PotatoActivityEntityModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PotatoActivityEntityModel.CreateStaticDefaultValue), new Action(PotatoActivityEntityModel.ResetStaticDefaultValue));
	}

	// Token: 0x06005D37 RID: 23863 RVA: 0x001119F1 File Offset: 0x0010FBF1
	public new static void CreateStaticDefaultValue()
	{
		PotatoActivityEntityModel.ActivityEntityPool = new Pool<PotatoActivityEntityModel>(100, () => new PotatoActivityEntityModel(), null);
	}

	// Token: 0x06005D38 RID: 23864 RVA: 0x00111A1F File Offset: 0x0010FC1F
	public new static void ResetStaticDefaultValue()
	{
		PotatoActivityEntityModel.ActivityEntityPool = null;
	}

	// Token: 0x06005D39 RID: 23865 RVA: 0x00111A28 File Offset: 0x0010FC28
	[NullableContext(1)]
	public static PotatoActivityEntityModel InitFromConfigId(int configId)
	{
		PotatoActivityEntityModel potatoActivityEntityModel = PotatoActivityEntityModel.ActivityEntityPool.Get();
		if (potatoActivityEntityModel == null)
		{
			potatoActivityEntityModel = PotatoActivityEntityModel.ActivityEntityPool.Create();
		}
		if (potatoActivityEntityModel != null)
		{
			potatoActivityEntityModel.ConfigId = configId;
		}
		return potatoActivityEntityModel;
	}

	// Token: 0x06005D3A RID: 23866 RVA: 0x00111A5C File Offset: 0x0010FC5C
	[NullableContext(1)]
	[return: Nullable(2)]
	public new static IPotatoCombatInfo BuildModel(EntityPb entityData, Dictionary<string, EntityComponentPb> componentDataMap)
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
		PotatoActivityEntityModel potatoActivityEntityModel = PotatoActivityEntityModel.ActivityEntityPool.Get();
		if (potatoActivityEntityModel == null)
		{
			potatoActivityEntityModel = PotatoActivityEntityModel.ActivityEntityPool.Create();
		}
		if (potatoActivityEntityModel != null)
		{
			potatoActivityEntityModel.InitFromProto(entityData, componentDataMap);
		}
		return potatoActivityEntityModel;
	}

	// Token: 0x06005D3B RID: 23867 RVA: 0x00111AC9 File Offset: 0x0010FCC9
	public new static void Clear()
	{
		PotatoActivityEntityModel.ActivityEntityPool.Clear();
	}

	// Token: 0x06005D3C RID: 23868 RVA: 0x00111AD8 File Offset: 0x0010FCD8
	[NullableContext(1)]
	protected override void InitFromProto(EntityPb entityData, Dictionary<string, EntityComponentPb> componentDataMap)
	{
		base.InitFromProto(entityData, componentDataMap);
		ActivityComponentPb activityComponentPb = componentDataMap["ActivityComponentPb"].ActivityComponentPb;
		this.ConfigId = activityComponentPb.ConfigId;
		if (activityComponentPb.KurotatoMonsterEntityPbData != null)
		{
			base.EntityType = EPotatoEntityType.Monster;
			this.DeathType = EPotatoMonsterDeathType.Normal;
			this.BuffRadius = 0;
			this.BuffIds = null;
			this.SpawnIds = null;
			this.PolluteRadius = 0;
			this.SpawnConfigId = activityComponentPb.KurotatoMonsterEntityPbData.SpawnConfigId;
			this.SpawnConfigGroupIndex = activityComponentPb.KurotatoMonsterEntityPbData.SpawnConfigGroupIndex;
			return;
		}
		if (activityComponentPb.KurotatoCharacterEntityPbData != null)
		{
			base.EntityType = EPotatoEntityType.PlayerCharacter;
			return;
		}
		if (activityComponentPb.KurotatoWeaponEntityPbData != null)
		{
			base.EntityType = EPotatoEntityType.Weapon;
			this.IncId = activityComponentPb.KurotatoWeaponEntityPbData.IncId;
			return;
		}
		if (activityComponentPb.KurotatoDropEntityPbData != null)
		{
			base.EntityType = EPotatoEntityType.GoldenCoin;
			return;
		}
		if (activityComponentPb.KurotatoStructureEntityPbData != null)
		{
			base.EntityType = EPotatoEntityType.Structure;
		}
	}

	// Token: 0x06005D3D RID: 23869 RVA: 0x00111BB0 File Offset: 0x0010FDB0
	[NullableContext(1)]
	public override void Update(IPotatoCombatInfo other)
	{
		base.Update(other);
		IPotatoActivityEntityInfo potatoActivityEntityInfo = (IPotatoActivityEntityInfo)other;
		this.ConfigId = potatoActivityEntityInfo.ConfigId;
		this.DeathType = potatoActivityEntityInfo.DeathType;
		this.BuffRadius = potatoActivityEntityInfo.BuffRadius;
		this.BuffIds = potatoActivityEntityInfo.BuffIds;
		this.SpawnIds = potatoActivityEntityInfo.SpawnIds;
		this.PolluteRadius = potatoActivityEntityInfo.PolluteRadius;
		this.SpawnConfigId = potatoActivityEntityInfo.SpawnConfigId;
		this.SpawnConfigGroupIndex = potatoActivityEntityInfo.SpawnConfigGroupIndex;
	}

	// Token: 0x06005D3E RID: 23870 RVA: 0x00111C2B File Offset: 0x0010FE2B
	public override void Reset()
	{
		base.Reset();
		this.ConfigId = 0;
		this.DeathType = EPotatoMonsterDeathType.Normal;
		this.BuffRadius = 0;
		this.BuffIds = null;
		this.SpawnIds = null;
		this.PolluteRadius = 0;
		this.SpawnConfigId = 0;
		this.SpawnConfigGroupIndex = 0;
	}

	// Token: 0x06005D3F RID: 23871 RVA: 0x00111C6B File Offset: 0x0010FE6B
	public override void Release()
	{
		this.Reset();
		PotatoActivityEntityModel.ActivityEntityPool.Put(this);
	}

	// Token: 0x06005D40 RID: 23872 RVA: 0x00111C80 File Offset: 0x0010FE80
	[NullableContext(1)]
	public override IPotatoCombatInfo Clone()
	{
		PotatoActivityEntityModel potatoActivityEntityModel = PotatoActivityEntityModel.ActivityEntityPool.Get();
		if (potatoActivityEntityModel == null)
		{
			potatoActivityEntityModel = PotatoActivityEntityModel.ActivityEntityPool.Create();
		}
		if (potatoActivityEntityModel != null)
		{
			potatoActivityEntityModel.Update(this);
		}
		return potatoActivityEntityModel;
	}

	// Token: 0x04002A76 RID: 10870
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static Pool<PotatoActivityEntityModel> ActivityEntityPool;
}
