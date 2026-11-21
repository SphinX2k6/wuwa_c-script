using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x0200036A RID: 874
[NullableContext(2)]
[Nullable(0)]
public class PotatoActivityEntityModel : PotatoEntityModel, IPotatoActivityEntityInfo, IPotatoCombatInfo, IPotatoConfigInfo
{
	// Token: 0x17000730 RID: 1840
	// (get) Token: 0x060030BB RID: 12475 RVA: 0x001195D5 File Offset: 0x001177D5
	// (set) Token: 0x060030BC RID: 12476 RVA: 0x001195DD File Offset: 0x001177DD
	public int ConfigId { get; set; }

	// Token: 0x17000731 RID: 1841
	// (get) Token: 0x060030BD RID: 12477 RVA: 0x001195E6 File Offset: 0x001177E6
	// (set) Token: 0x060030BE RID: 12478 RVA: 0x001195EE File Offset: 0x001177EE
	public EPotatoMonsterDeathType DeathType { get; set; }

	// Token: 0x17000732 RID: 1842
	// (get) Token: 0x060030BF RID: 12479 RVA: 0x001195F7 File Offset: 0x001177F7
	// (set) Token: 0x060030C0 RID: 12480 RVA: 0x001195FF File Offset: 0x001177FF
	public int BuffRadius { get; set; }

	// Token: 0x17000733 RID: 1843
	// (get) Token: 0x060030C1 RID: 12481 RVA: 0x00119608 File Offset: 0x00117808
	// (set) Token: 0x060030C2 RID: 12482 RVA: 0x00119610 File Offset: 0x00117810
	public int[] BuffIds { get; set; }

	// Token: 0x17000734 RID: 1844
	// (get) Token: 0x060030C3 RID: 12483 RVA: 0x00119619 File Offset: 0x00117819
	// (set) Token: 0x060030C4 RID: 12484 RVA: 0x00119621 File Offset: 0x00117821
	public int[] SpawnIds { get; set; }

	// Token: 0x17000735 RID: 1845
	// (get) Token: 0x060030C5 RID: 12485 RVA: 0x0011962A File Offset: 0x0011782A
	// (set) Token: 0x060030C6 RID: 12486 RVA: 0x00119632 File Offset: 0x00117832
	public int PolluteRadius { get; set; }

	// Token: 0x17000736 RID: 1846
	// (get) Token: 0x060030C7 RID: 12487 RVA: 0x0011963B File Offset: 0x0011783B
	// (set) Token: 0x060030C8 RID: 12488 RVA: 0x00119643 File Offset: 0x00117843
	public int IncId { get; set; }

	// Token: 0x17000737 RID: 1847
	// (get) Token: 0x060030C9 RID: 12489 RVA: 0x0011964C File Offset: 0x0011784C
	// (set) Token: 0x060030CA RID: 12490 RVA: 0x00119654 File Offset: 0x00117854
	public int SpawnConfigId { get; set; }

	// Token: 0x17000738 RID: 1848
	// (get) Token: 0x060030CB RID: 12491 RVA: 0x0011965D File Offset: 0x0011785D
	// (set) Token: 0x060030CC RID: 12492 RVA: 0x00119665 File Offset: 0x00117865
	public int SpawnConfigGroupIndex { get; set; }

	// Token: 0x060030CD RID: 12493 RVA: 0x0011966E File Offset: 0x0011786E
	static PotatoActivityEntityModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PotatoActivityEntityModel.CreateStaticDefaultValue), new Action(PotatoActivityEntityModel.ResetStaticDefaultValue));
	}

	// Token: 0x060030CE RID: 12494 RVA: 0x0011968D File Offset: 0x0011788D
	public new static void CreateStaticDefaultValue()
	{
		PotatoActivityEntityModel.ActivityEntityPool = new Pool<PotatoActivityEntityModel>(100, () => new PotatoActivityEntityModel(), null);
	}

	// Token: 0x060030CF RID: 12495 RVA: 0x001196BB File Offset: 0x001178BB
	public new static void ResetStaticDefaultValue()
	{
		PotatoActivityEntityModel.ActivityEntityPool = null;
	}

	// Token: 0x060030D0 RID: 12496 RVA: 0x001196C4 File Offset: 0x001178C4
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

	// Token: 0x060030D1 RID: 12497 RVA: 0x001196F8 File Offset: 0x001178F8
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

	// Token: 0x060030D2 RID: 12498 RVA: 0x00119765 File Offset: 0x00117965
	public new static void Clear()
	{
		PotatoActivityEntityModel.ActivityEntityPool.Clear();
	}

	// Token: 0x060030D3 RID: 12499 RVA: 0x00119774 File Offset: 0x00117974
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

	// Token: 0x060030D4 RID: 12500 RVA: 0x0011984C File Offset: 0x00117A4C
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

	// Token: 0x060030D5 RID: 12501 RVA: 0x001198C7 File Offset: 0x00117AC7
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

	// Token: 0x060030D6 RID: 12502 RVA: 0x00119907 File Offset: 0x00117B07
	public override void Release()
	{
		this.Reset();
		PotatoActivityEntityModel.ActivityEntityPool.Put(this);
	}

	// Token: 0x060030D7 RID: 12503 RVA: 0x0011991C File Offset: 0x00117B1C
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

	// Token: 0x04002B11 RID: 11025
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static Pool<PotatoActivityEntityModel> ActivityEntityPool;
}
