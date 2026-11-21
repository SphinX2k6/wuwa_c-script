using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x0200035C RID: 860
[NullableContext(2)]
[Nullable(0)]
public class PinballBattleEntityModel : PinballBattleEntityBaseModel, IPinballBattleCombatInfo, IStaticVariableResetter
{
	// Token: 0x170006FA RID: 1786
	// (get) Token: 0x0600300D RID: 12301 RVA: 0x00118320 File Offset: 0x00116520
	// (set) Token: 0x0600300E RID: 12302 RVA: 0x00118328 File Offset: 0x00116528
	public EPinballBattleEntityType EntityType { get; set; }

	// Token: 0x170006FB RID: 1787
	// (get) Token: 0x0600300F RID: 12303 RVA: 0x00118331 File Offset: 0x00116531
	// (set) Token: 0x06003010 RID: 12304 RVA: 0x00118339 File Offset: 0x00116539
	public int Uid { get; set; }

	// Token: 0x170006FC RID: 1788
	// (get) Token: 0x06003011 RID: 12305 RVA: 0x00118342 File Offset: 0x00116542
	// (set) Token: 0x06003012 RID: 12306 RVA: 0x0011834A File Offset: 0x0011654A
	public int OwnerId { get; set; }

	// Token: 0x170006FD RID: 1789
	// (get) Token: 0x06003013 RID: 12307 RVA: 0x00118353 File Offset: 0x00116553
	// (set) Token: 0x06003014 RID: 12308 RVA: 0x0011835B File Offset: 0x0011655B
	public int TemplateId { get; set; }

	// Token: 0x170006FE RID: 1790
	// (get) Token: 0x06003015 RID: 12309 RVA: 0x00118364 File Offset: 0x00116564
	// (set) Token: 0x06003016 RID: 12310 RVA: 0x0011836C File Offset: 0x0011656C
	public int CombatId { get; set; }

	// Token: 0x170006FF RID: 1791
	// (get) Token: 0x06003017 RID: 12311 RVA: 0x00118375 File Offset: 0x00116575
	// (set) Token: 0x06003018 RID: 12312 RVA: 0x0011837D File Offset: 0x0011657D
	public int SubTypeId { get; set; }

	// Token: 0x17000700 RID: 1792
	// (get) Token: 0x06003019 RID: 12313 RVA: 0x00118386 File Offset: 0x00116586
	// (set) Token: 0x0600301A RID: 12314 RVA: 0x0011838E File Offset: 0x0011658E
	public string PrefabPath { get; set; }

	// Token: 0x17000701 RID: 1793
	// (get) Token: 0x0600301B RID: 12315 RVA: 0x00118397 File Offset: 0x00116597
	// (set) Token: 0x0600301C RID: 12316 RVA: 0x0011839F File Offset: 0x0011659F
	public string AssetPath { get; set; }

	// Token: 0x17000702 RID: 1794
	// (get) Token: 0x0600301D RID: 12317 RVA: 0x001183A8 File Offset: 0x001165A8
	// (set) Token: 0x0600301E RID: 12318 RVA: 0x001183B0 File Offset: 0x001165B0
	public int PropertyId { get; set; }

	// Token: 0x17000703 RID: 1795
	// (get) Token: 0x0600301F RID: 12319 RVA: 0x001183B9 File Offset: 0x001165B9
	// (set) Token: 0x06003020 RID: 12320 RVA: 0x001183C1 File Offset: 0x001165C1
	public int? SplineId { get; set; }

	// Token: 0x17000704 RID: 1796
	// (get) Token: 0x06003021 RID: 12321 RVA: 0x001183CA File Offset: 0x001165CA
	// (set) Token: 0x06003022 RID: 12322 RVA: 0x001183D2 File Offset: 0x001165D2
	public Dictionary<int, int> BuffIdLayers { get; set; }

	// Token: 0x17000705 RID: 1797
	// (get) Token: 0x06003023 RID: 12323 RVA: 0x001183DB File Offset: 0x001165DB
	// (set) Token: 0x06003024 RID: 12324 RVA: 0x001183E3 File Offset: 0x001165E3
	public Dictionary<int, int> AttributeMap { get; set; }

	// Token: 0x17000706 RID: 1798
	// (get) Token: 0x06003025 RID: 12325 RVA: 0x001183EC File Offset: 0x001165EC
	// (set) Token: 0x06003026 RID: 12326 RVA: 0x001183F4 File Offset: 0x001165F4
	[Nullable(1)]
	public global::Vector Position { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x17000707 RID: 1799
	// (get) Token: 0x06003027 RID: 12327 RVA: 0x001183FD File Offset: 0x001165FD
	// (set) Token: 0x06003028 RID: 12328 RVA: 0x00118405 File Offset: 0x00116605
	[Nullable(1)]
	public global::Rotator Rotation { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x06003029 RID: 12329 RVA: 0x00118410 File Offset: 0x00116610
	public PinballBattleEntityModel()
	{
		this.Position = global::Vector.Create(0.0, 0.0, 0.0);
		this.Rotation = global::Rotator.Create(0f, 0f, 0f);
	}

	// Token: 0x0600302A RID: 12330 RVA: 0x00118463 File Offset: 0x00116663
	static PinballBattleEntityModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PinballBattleEntityModel.CreateStaticDefaultValue), new Action(PinballBattleEntityModel.ResetStaticDefaultValue));
	}

	// Token: 0x0600302B RID: 12331 RVA: 0x00118482 File Offset: 0x00116682
	public static void CreateStaticDefaultValue()
	{
		PinballBattleEntityModel.EntityPool = new Pool<PinballBattleEntityModel>(100, () => new PinballBattleEntityModel(), null);
	}

	// Token: 0x0600302C RID: 12332 RVA: 0x001184B0 File Offset: 0x001166B0
	public static void ResetStaticDefaultValue()
	{
		PinballBattleEntityModel.EntityPool = null;
	}

	// Token: 0x0600302D RID: 12333 RVA: 0x001184B8 File Offset: 0x001166B8
	[NullableContext(1)]
	[return: Nullable(2)]
	public new static IPinballBattleCombatInfo BuildModel(EntityPb entityData, Dictionary<string, EntityComponentPb> componentDataMap)
	{
		if (!componentDataMap.ContainsKey("SimpleCombatComponentPb"))
		{
			return null;
		}
		PinballBattleEntityModel pinballBattleEntityModel = PinballBattleEntityModel.EntityPool.Get();
		if (pinballBattleEntityModel == null)
		{
			pinballBattleEntityModel = PinballBattleEntityModel.EntityPool.Create();
		}
		if (pinballBattleEntityModel != null)
		{
			pinballBattleEntityModel.InitFromProto(entityData, componentDataMap);
		}
		return pinballBattleEntityModel;
	}

	// Token: 0x0600302E RID: 12334 RVA: 0x001184F9 File Offset: 0x001166F9
	public new static void Clear()
	{
		PinballBattleEntityModel.EntityPool.Clear();
	}

	// Token: 0x0600302F RID: 12335 RVA: 0x00118508 File Offset: 0x00116708
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
			this.Position.Set((double)(-(double)pos.X), (double)pos.Y, (double)pos.Z);
		}
		Aki.Protocol.Rotator rot = entityData.Rot;
		if (rot != null)
		{
			this.Rotation.Set(rot.Pitch, rot.Yaw, rot.Roll);
		}
	}

	// Token: 0x06003030 RID: 12336 RVA: 0x00118638 File Offset: 0x00116838
	[NullableContext(1)]
	public virtual void Update(IPinballBattleCombatInfo other)
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

	// Token: 0x06003031 RID: 12337 RVA: 0x00118721 File Offset: 0x00116921
	public bool IsValid()
	{
		return this.Uid > 0;
	}

	// Token: 0x06003032 RID: 12338 RVA: 0x0011872C File Offset: 0x0011692C
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

	// Token: 0x06003033 RID: 12339 RVA: 0x001187CE File Offset: 0x001169CE
	public virtual void Release()
	{
		this.Reset();
		PinballBattleEntityModel.EntityPool.Put(this);
	}

	// Token: 0x06003034 RID: 12340 RVA: 0x001187E4 File Offset: 0x001169E4
	[NullableContext(1)]
	public virtual IPinballBattleCombatInfo Clone()
	{
		PinballBattleEntityModel pinballBattleEntityModel = PinballBattleEntityModel.EntityPool.Get();
		if (pinballBattleEntityModel == null)
		{
			pinballBattleEntityModel = PinballBattleEntityModel.EntityPool.Create();
		}
		if (pinballBattleEntityModel != null)
		{
			pinballBattleEntityModel.Update(this);
		}
		return pinballBattleEntityModel;
	}

	// Token: 0x04002ADE RID: 10974
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static Pool<PinballBattleEntityModel> EntityPool;
}
