using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02000369 RID: 873
[NullableContext(2)]
[Nullable(0)]
public class PotatoEntityModel : PotatoEntityBaseModel, IPotatoCombatInfo, IStaticVariableResetter
{
	// Token: 0x17000722 RID: 1826
	// (get) Token: 0x06003093 RID: 12435 RVA: 0x001190E2 File Offset: 0x001172E2
	// (set) Token: 0x06003094 RID: 12436 RVA: 0x001190EA File Offset: 0x001172EA
	public EPotatoEntityType EntityType { get; set; }

	// Token: 0x17000723 RID: 1827
	// (get) Token: 0x06003095 RID: 12437 RVA: 0x001190F3 File Offset: 0x001172F3
	// (set) Token: 0x06003096 RID: 12438 RVA: 0x001190FB File Offset: 0x001172FB
	public int Uid { get; set; }

	// Token: 0x17000724 RID: 1828
	// (get) Token: 0x06003097 RID: 12439 RVA: 0x00119104 File Offset: 0x00117304
	// (set) Token: 0x06003098 RID: 12440 RVA: 0x0011910C File Offset: 0x0011730C
	public int OwnerId { get; set; }

	// Token: 0x17000725 RID: 1829
	// (get) Token: 0x06003099 RID: 12441 RVA: 0x00119115 File Offset: 0x00117315
	// (set) Token: 0x0600309A RID: 12442 RVA: 0x0011911D File Offset: 0x0011731D
	public int TemplateId { get; set; }

	// Token: 0x17000726 RID: 1830
	// (get) Token: 0x0600309B RID: 12443 RVA: 0x00119126 File Offset: 0x00117326
	// (set) Token: 0x0600309C RID: 12444 RVA: 0x0011912E File Offset: 0x0011732E
	public int CombatId { get; set; }

	// Token: 0x17000727 RID: 1831
	// (get) Token: 0x0600309D RID: 12445 RVA: 0x00119137 File Offset: 0x00117337
	// (set) Token: 0x0600309E RID: 12446 RVA: 0x0011913F File Offset: 0x0011733F
	public int SubTypeId { get; set; }

	// Token: 0x17000728 RID: 1832
	// (get) Token: 0x0600309F RID: 12447 RVA: 0x00119148 File Offset: 0x00117348
	// (set) Token: 0x060030A0 RID: 12448 RVA: 0x00119150 File Offset: 0x00117350
	public string PrefabPath { get; set; }

	// Token: 0x17000729 RID: 1833
	// (get) Token: 0x060030A1 RID: 12449 RVA: 0x00119159 File Offset: 0x00117359
	// (set) Token: 0x060030A2 RID: 12450 RVA: 0x00119161 File Offset: 0x00117361
	public string AssetPath { get; set; }

	// Token: 0x1700072A RID: 1834
	// (get) Token: 0x060030A3 RID: 12451 RVA: 0x0011916A File Offset: 0x0011736A
	// (set) Token: 0x060030A4 RID: 12452 RVA: 0x00119172 File Offset: 0x00117372
	public int PropertyId { get; set; }

	// Token: 0x1700072B RID: 1835
	// (get) Token: 0x060030A5 RID: 12453 RVA: 0x0011917B File Offset: 0x0011737B
	// (set) Token: 0x060030A6 RID: 12454 RVA: 0x00119183 File Offset: 0x00117383
	public int? SplineId { get; set; }

	// Token: 0x1700072C RID: 1836
	// (get) Token: 0x060030A7 RID: 12455 RVA: 0x0011918C File Offset: 0x0011738C
	// (set) Token: 0x060030A8 RID: 12456 RVA: 0x00119194 File Offset: 0x00117394
	public Dictionary<int, int> BuffIdLayers { get; set; }

	// Token: 0x1700072D RID: 1837
	// (get) Token: 0x060030A9 RID: 12457 RVA: 0x0011919D File Offset: 0x0011739D
	// (set) Token: 0x060030AA RID: 12458 RVA: 0x001191A5 File Offset: 0x001173A5
	public Dictionary<int, int> AttributeMap { get; set; }

	// Token: 0x1700072E RID: 1838
	// (get) Token: 0x060030AB RID: 12459 RVA: 0x001191AE File Offset: 0x001173AE
	// (set) Token: 0x060030AC RID: 12460 RVA: 0x001191B6 File Offset: 0x001173B6
	[Nullable(1)]
	public global::Vector Position { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x1700072F RID: 1839
	// (get) Token: 0x060030AD RID: 12461 RVA: 0x001191BF File Offset: 0x001173BF
	// (set) Token: 0x060030AE RID: 12462 RVA: 0x001191C7 File Offset: 0x001173C7
	[Nullable(1)]
	public global::Rotator Rotation { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x060030AF RID: 12463 RVA: 0x001191D0 File Offset: 0x001173D0
	public PotatoEntityModel()
	{
		this.Position = global::Vector.Create(0.0, 0.0, 0.0);
		this.Rotation = global::Rotator.Create(0f, 0f, 0f);
	}

	// Token: 0x060030B0 RID: 12464 RVA: 0x00119223 File Offset: 0x00117423
	static PotatoEntityModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PotatoEntityModel.CreateStaticDefaultValue), new Action(PotatoEntityModel.ResetStaticDefaultValue));
	}

	// Token: 0x060030B1 RID: 12465 RVA: 0x00119242 File Offset: 0x00117442
	public static void CreateStaticDefaultValue()
	{
		PotatoEntityModel.EntityPool = new Pool<PotatoEntityModel>(100, () => new PotatoEntityModel(), null);
	}

	// Token: 0x060030B2 RID: 12466 RVA: 0x00119270 File Offset: 0x00117470
	public static void ResetStaticDefaultValue()
	{
		PotatoEntityModel.EntityPool = null;
	}

	// Token: 0x060030B3 RID: 12467 RVA: 0x00119278 File Offset: 0x00117478
	[NullableContext(1)]
	[return: Nullable(2)]
	public new static IPotatoCombatInfo BuildModel(EntityPb entityData, Dictionary<string, EntityComponentPb> componentDataMap)
	{
		if (!componentDataMap.ContainsKey("SimpleCombatComponentPb"))
		{
			return null;
		}
		PotatoEntityModel potatoEntityModel = PotatoEntityModel.EntityPool.Get();
		if (potatoEntityModel == null)
		{
			potatoEntityModel = PotatoEntityModel.EntityPool.Create();
		}
		if (potatoEntityModel != null)
		{
			potatoEntityModel.InitFromProto(entityData, componentDataMap);
		}
		return potatoEntityModel;
	}

	// Token: 0x060030B4 RID: 12468 RVA: 0x001192B9 File Offset: 0x001174B9
	public new static void Clear()
	{
		PotatoEntityModel.EntityPool.Clear();
	}

	// Token: 0x060030B5 RID: 12469 RVA: 0x001192C8 File Offset: 0x001174C8
	[NullableContext(1)]
	protected virtual void InitFromProto(EntityPb entityData, Dictionary<string, EntityComponentPb> componentDataMap)
	{
		SimpleCombatComponentPb simpleCombatComponentPb = componentDataMap["SimpleCombatComponentPb"].SimpleCombatComponentPb;
		this.Uid = (int)MathUtils.Instance.LongToNumber(entityData.Id);
		this.OwnerId = (int)MathUtils.Instance.LongToNumber(entityData.OwnerIncId);
		this.TemplateId = entityData.ConfigId;
		this.CombatId = 0;
		this.SubTypeId = simpleCombatComponentPb.SubTypeId;
		this.PrefabPath = null;
		this.AssetPath = null;
		this.PropertyId = 0;
		this.SplineId = ((simpleCombatComponentPb.SplineConfigId != 0) ? new int?(simpleCombatComponentPb.SplineConfigId) : null);
		this.BuffIdLayers = ((simpleCombatComponentPb.BuffLayers != null) ? new Dictionary<int, int>(simpleCombatComponentPb.BuffLayers) : null);
		this.AttributeMap = ((simpleCombatComponentPb.AttributeMap != null) ? new Dictionary<int, int>(simpleCombatComponentPb.AttributeMap) : null);
		Aki.Protocol.Vector pos = entityData.Pos;
		if (pos != null)
		{
			this.Position.Set((double)pos.X, (double)pos.Y, (double)pos.Z);
		}
		Aki.Protocol.Rotator rot = entityData.Rot;
		if (rot != null)
		{
			this.Rotation.Set(rot.Pitch, rot.Yaw, rot.Roll);
		}
	}

	// Token: 0x060030B6 RID: 12470 RVA: 0x001193F8 File Offset: 0x001175F8
	[NullableContext(1)]
	public virtual void Update(IPotatoCombatInfo other)
	{
		this.Uid = other.Uid;
		this.OwnerId = other.OwnerId;
		this.TemplateId = other.TemplateId;
		this.CombatId = other.CombatId;
		this.SubTypeId = other.SubTypeId;
		this.PrefabPath = other.PrefabPath;
		this.AssetPath = other.AssetPath;
		this.PropertyId = other.PropertyId;
		this.SplineId = other.SplineId;
		this.BuffIdLayers = other.BuffIdLayers;
		this.AttributeMap = other.AttributeMap;
		this.Position.Set(other.Position.X, other.Position.Y, other.Position.Z);
		this.Rotation.Set(other.Rotation.Pitch, other.Rotation.Yaw, other.Rotation.Roll);
	}

	// Token: 0x060030B7 RID: 12471 RVA: 0x001194E1 File Offset: 0x001176E1
	public bool IsValid()
	{
		return this.Uid > 0;
	}

	// Token: 0x060030B8 RID: 12472 RVA: 0x001194EC File Offset: 0x001176EC
	public virtual void Reset()
	{
		this.Uid = 0;
		this.OwnerId = 0;
		this.TemplateId = 0;
		this.CombatId = 0;
		this.SubTypeId = 0;
		this.PrefabPath = null;
		this.AssetPath = null;
		this.PropertyId = 0;
		this.SplineId = null;
		this.BuffIdLayers = null;
		this.AttributeMap = null;
		this.Position.Set(0.0, 0.0, 0.0);
		this.Rotation.Set(0f, 0f, 0f);
	}

	// Token: 0x060030B9 RID: 12473 RVA: 0x0011958E File Offset: 0x0011778E
	public virtual void Release()
	{
		this.Reset();
		PotatoEntityModel.EntityPool.Put(this);
	}

	// Token: 0x060030BA RID: 12474 RVA: 0x001195A4 File Offset: 0x001177A4
	[NullableContext(1)]
	public virtual IPotatoCombatInfo Clone()
	{
		PotatoEntityModel potatoEntityModel = PotatoEntityModel.EntityPool.Get();
		if (potatoEntityModel == null)
		{
			potatoEntityModel = PotatoEntityModel.EntityPool.Create();
		}
		if (potatoEntityModel != null)
		{
			potatoEntityModel.Update(this);
		}
		return potatoEntityModel;
	}

	// Token: 0x04002B07 RID: 11015
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static Pool<PotatoEntityModel> EntityPool;
}
