using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02000EB4 RID: 3764
[NullableContext(2)]
[Nullable(0)]
public class PotatoEntityModel : PotatoEntityBaseModel, IPotatoCombatInfo, IStaticVariableResetter
{
	// Token: 0x170006FE RID: 1790
	// (get) Token: 0x06005CFC RID: 23804 RVA: 0x00111446 File Offset: 0x0010F646
	// (set) Token: 0x06005CFD RID: 23805 RVA: 0x0011144E File Offset: 0x0010F64E
	public EPotatoEntityType EntityType { get; set; }

	// Token: 0x170006FF RID: 1791
	// (get) Token: 0x06005CFE RID: 23806 RVA: 0x00111457 File Offset: 0x0010F657
	// (set) Token: 0x06005CFF RID: 23807 RVA: 0x0011145F File Offset: 0x0010F65F
	public int Uid { get; set; }

	// Token: 0x17000700 RID: 1792
	// (get) Token: 0x06005D00 RID: 23808 RVA: 0x00111468 File Offset: 0x0010F668
	// (set) Token: 0x06005D01 RID: 23809 RVA: 0x00111470 File Offset: 0x0010F670
	public int OwnerId { get; set; }

	// Token: 0x17000701 RID: 1793
	// (get) Token: 0x06005D02 RID: 23810 RVA: 0x00111479 File Offset: 0x0010F679
	// (set) Token: 0x06005D03 RID: 23811 RVA: 0x00111481 File Offset: 0x0010F681
	public int TemplateId { get; set; }

	// Token: 0x17000702 RID: 1794
	// (get) Token: 0x06005D04 RID: 23812 RVA: 0x0011148A File Offset: 0x0010F68A
	// (set) Token: 0x06005D05 RID: 23813 RVA: 0x00111492 File Offset: 0x0010F692
	public int CombatId { get; set; }

	// Token: 0x17000703 RID: 1795
	// (get) Token: 0x06005D06 RID: 23814 RVA: 0x0011149B File Offset: 0x0010F69B
	// (set) Token: 0x06005D07 RID: 23815 RVA: 0x001114A3 File Offset: 0x0010F6A3
	public int SubTypeId { get; set; }

	// Token: 0x17000704 RID: 1796
	// (get) Token: 0x06005D08 RID: 23816 RVA: 0x001114AC File Offset: 0x0010F6AC
	// (set) Token: 0x06005D09 RID: 23817 RVA: 0x001114B4 File Offset: 0x0010F6B4
	public string PrefabPath { get; set; }

	// Token: 0x17000705 RID: 1797
	// (get) Token: 0x06005D0A RID: 23818 RVA: 0x001114BD File Offset: 0x0010F6BD
	// (set) Token: 0x06005D0B RID: 23819 RVA: 0x001114C5 File Offset: 0x0010F6C5
	public string AssetPath { get; set; }

	// Token: 0x17000706 RID: 1798
	// (get) Token: 0x06005D0C RID: 23820 RVA: 0x001114CE File Offset: 0x0010F6CE
	// (set) Token: 0x06005D0D RID: 23821 RVA: 0x001114D6 File Offset: 0x0010F6D6
	public int PropertyId { get; set; }

	// Token: 0x17000707 RID: 1799
	// (get) Token: 0x06005D0E RID: 23822 RVA: 0x001114DF File Offset: 0x0010F6DF
	// (set) Token: 0x06005D0F RID: 23823 RVA: 0x001114E7 File Offset: 0x0010F6E7
	public int? SplineId { get; set; }

	// Token: 0x17000708 RID: 1800
	// (get) Token: 0x06005D10 RID: 23824 RVA: 0x001114F0 File Offset: 0x0010F6F0
	// (set) Token: 0x06005D11 RID: 23825 RVA: 0x001114F8 File Offset: 0x0010F6F8
	public Dictionary<int, int> BuffIdLayers { get; set; }

	// Token: 0x17000709 RID: 1801
	// (get) Token: 0x06005D12 RID: 23826 RVA: 0x00111501 File Offset: 0x0010F701
	// (set) Token: 0x06005D13 RID: 23827 RVA: 0x00111509 File Offset: 0x0010F709
	public Dictionary<int, int> AttributeMap { get; set; }

	// Token: 0x1700070A RID: 1802
	// (get) Token: 0x06005D14 RID: 23828 RVA: 0x00111512 File Offset: 0x0010F712
	// (set) Token: 0x06005D15 RID: 23829 RVA: 0x0011151A File Offset: 0x0010F71A
	[Nullable(1)]
	public global::Vector Position { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x1700070B RID: 1803
	// (get) Token: 0x06005D16 RID: 23830 RVA: 0x00111523 File Offset: 0x0010F723
	// (set) Token: 0x06005D17 RID: 23831 RVA: 0x0011152B File Offset: 0x0010F72B
	[Nullable(1)]
	public global::Rotator Rotation { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x06005D18 RID: 23832 RVA: 0x00111534 File Offset: 0x0010F734
	public PotatoEntityModel()
	{
		this.Position = global::Vector.Create(0.0, 0.0, 0.0);
		this.Rotation = global::Rotator.Create(0f, 0f, 0f);
	}

	// Token: 0x06005D19 RID: 23833 RVA: 0x00111587 File Offset: 0x0010F787
	static PotatoEntityModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PotatoEntityModel.CreateStaticDefaultValue), new Action(PotatoEntityModel.ResetStaticDefaultValue));
	}

	// Token: 0x06005D1A RID: 23834 RVA: 0x001115A6 File Offset: 0x0010F7A6
	public static void CreateStaticDefaultValue()
	{
		PotatoEntityModel.EntityPool = new Pool<PotatoEntityModel>(100, () => new PotatoEntityModel(), null);
	}

	// Token: 0x06005D1B RID: 23835 RVA: 0x001115D4 File Offset: 0x0010F7D4
	public static void ResetStaticDefaultValue()
	{
		PotatoEntityModel.EntityPool = null;
	}

	// Token: 0x06005D1C RID: 23836 RVA: 0x001115DC File Offset: 0x0010F7DC
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

	// Token: 0x06005D1D RID: 23837 RVA: 0x0011161D File Offset: 0x0010F81D
	public new static void Clear()
	{
		PotatoEntityModel.EntityPool.Clear();
	}

	// Token: 0x06005D1E RID: 23838 RVA: 0x0011162C File Offset: 0x0010F82C
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

	// Token: 0x06005D1F RID: 23839 RVA: 0x0011175C File Offset: 0x0010F95C
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

	// Token: 0x06005D20 RID: 23840 RVA: 0x00111845 File Offset: 0x0010FA45
	public bool IsValid()
	{
		return this.Uid > 0;
	}

	// Token: 0x06005D21 RID: 23841 RVA: 0x00111850 File Offset: 0x0010FA50
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

	// Token: 0x06005D22 RID: 23842 RVA: 0x001118F2 File Offset: 0x0010FAF2
	public virtual void Release()
	{
		this.Reset();
		PotatoEntityModel.EntityPool.Put(this);
	}

	// Token: 0x06005D23 RID: 23843 RVA: 0x00111908 File Offset: 0x0010FB08
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

	// Token: 0x04002A6C RID: 10860
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static Pool<PotatoEntityModel> EntityPool;
}
