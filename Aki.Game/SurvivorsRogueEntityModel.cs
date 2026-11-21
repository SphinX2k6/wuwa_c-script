using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x0200037C RID: 892
[NullableContext(2)]
[Nullable(0)]
public class SurvivorsRogueEntityModel : SurvivorsRogueEntityBaseModel, ISurvivorsRogueCombatInfo, IStaticVariableResetter
{
	// Token: 0x1700074E RID: 1870
	// (get) Token: 0x0600316A RID: 12650 RVA: 0x0011C6D0 File Offset: 0x0011A8D0
	// (set) Token: 0x0600316B RID: 12651 RVA: 0x0011C6D8 File Offset: 0x0011A8D8
	public ESurvivorsRogueEntityType EntityType { get; set; }

	// Token: 0x1700074F RID: 1871
	// (get) Token: 0x0600316C RID: 12652 RVA: 0x0011C6E1 File Offset: 0x0011A8E1
	// (set) Token: 0x0600316D RID: 12653 RVA: 0x0011C6E9 File Offset: 0x0011A8E9
	public int Uid { get; set; }

	// Token: 0x17000750 RID: 1872
	// (get) Token: 0x0600316E RID: 12654 RVA: 0x0011C6F2 File Offset: 0x0011A8F2
	// (set) Token: 0x0600316F RID: 12655 RVA: 0x0011C6FA File Offset: 0x0011A8FA
	public int OwnerId { get; set; }

	// Token: 0x17000751 RID: 1873
	// (get) Token: 0x06003170 RID: 12656 RVA: 0x0011C703 File Offset: 0x0011A903
	// (set) Token: 0x06003171 RID: 12657 RVA: 0x0011C70B File Offset: 0x0011A90B
	public int TemplateId { get; set; }

	// Token: 0x17000752 RID: 1874
	// (get) Token: 0x06003172 RID: 12658 RVA: 0x0011C714 File Offset: 0x0011A914
	// (set) Token: 0x06003173 RID: 12659 RVA: 0x0011C71C File Offset: 0x0011A91C
	public int CombatId { get; set; }

	// Token: 0x17000753 RID: 1875
	// (get) Token: 0x06003174 RID: 12660 RVA: 0x0011C725 File Offset: 0x0011A925
	// (set) Token: 0x06003175 RID: 12661 RVA: 0x0011C72D File Offset: 0x0011A92D
	public int SubTypeId { get; set; }

	// Token: 0x17000754 RID: 1876
	// (get) Token: 0x06003176 RID: 12662 RVA: 0x0011C736 File Offset: 0x0011A936
	// (set) Token: 0x06003177 RID: 12663 RVA: 0x0011C73E File Offset: 0x0011A93E
	public string PrefabPath { get; set; }

	// Token: 0x17000755 RID: 1877
	// (get) Token: 0x06003178 RID: 12664 RVA: 0x0011C747 File Offset: 0x0011A947
	// (set) Token: 0x06003179 RID: 12665 RVA: 0x0011C74F File Offset: 0x0011A94F
	public string AssetPath { get; set; }

	// Token: 0x17000756 RID: 1878
	// (get) Token: 0x0600317A RID: 12666 RVA: 0x0011C758 File Offset: 0x0011A958
	// (set) Token: 0x0600317B RID: 12667 RVA: 0x0011C760 File Offset: 0x0011A960
	public int PropertyId { get; set; }

	// Token: 0x17000757 RID: 1879
	// (get) Token: 0x0600317C RID: 12668 RVA: 0x0011C769 File Offset: 0x0011A969
	// (set) Token: 0x0600317D RID: 12669 RVA: 0x0011C771 File Offset: 0x0011A971
	public int? SplineId { get; set; }

	// Token: 0x17000758 RID: 1880
	// (get) Token: 0x0600317E RID: 12670 RVA: 0x0011C77A File Offset: 0x0011A97A
	// (set) Token: 0x0600317F RID: 12671 RVA: 0x0011C782 File Offset: 0x0011A982
	public Dictionary<int, int> BuffIdLayers { get; set; }

	// Token: 0x17000759 RID: 1881
	// (get) Token: 0x06003180 RID: 12672 RVA: 0x0011C78B File Offset: 0x0011A98B
	// (set) Token: 0x06003181 RID: 12673 RVA: 0x0011C793 File Offset: 0x0011A993
	public Dictionary<int, int> AttributeMap { get; set; }

	// Token: 0x1700075A RID: 1882
	// (get) Token: 0x06003182 RID: 12674 RVA: 0x0011C79C File Offset: 0x0011A99C
	// (set) Token: 0x06003183 RID: 12675 RVA: 0x0011C7A4 File Offset: 0x0011A9A4
	[Nullable(1)]
	public global::Vector Position { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x1700075B RID: 1883
	// (get) Token: 0x06003184 RID: 12676 RVA: 0x0011C7AD File Offset: 0x0011A9AD
	// (set) Token: 0x06003185 RID: 12677 RVA: 0x0011C7B5 File Offset: 0x0011A9B5
	[Nullable(1)]
	public global::Rotator Rotation { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x06003186 RID: 12678 RVA: 0x0011C7C0 File Offset: 0x0011A9C0
	public SurvivorsRogueEntityModel()
	{
		this.Position = global::Vector.Create(0.0, 0.0, 0.0);
		this.Rotation = global::Rotator.Create(0f, 0f, 0f);
	}

	// Token: 0x06003187 RID: 12679 RVA: 0x0011C813 File Offset: 0x0011AA13
	static SurvivorsRogueEntityModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SurvivorsRogueEntityModel.CreateStaticDefaultValue), new Action(SurvivorsRogueEntityModel.ResetStaticDefaultValue));
	}

	// Token: 0x06003188 RID: 12680 RVA: 0x0011C832 File Offset: 0x0011AA32
	public static void CreateStaticDefaultValue()
	{
		SurvivorsRogueEntityModel.EntityPool = new Pool<SurvivorsRogueEntityModel>(100, () => new SurvivorsRogueEntityModel(), null);
	}

	// Token: 0x06003189 RID: 12681 RVA: 0x0011C860 File Offset: 0x0011AA60
	public static void ResetStaticDefaultValue()
	{
		SurvivorsRogueEntityModel.EntityPool = null;
	}

	// Token: 0x0600318A RID: 12682 RVA: 0x0011C868 File Offset: 0x0011AA68
	[NullableContext(1)]
	[return: Nullable(2)]
	public new static ISurvivorsRogueCombatInfo BuildModel(EntityPb entityData, Dictionary<string, EntityComponentPb> componentDataMap)
	{
		if (!componentDataMap.ContainsKey("SimpleCombatComponentPb"))
		{
			return null;
		}
		SurvivorsRogueEntityModel survivorsRogueEntityModel = SurvivorsRogueEntityModel.EntityPool.Get();
		if (survivorsRogueEntityModel == null)
		{
			survivorsRogueEntityModel = SurvivorsRogueEntityModel.EntityPool.Create();
		}
		if (survivorsRogueEntityModel != null)
		{
			survivorsRogueEntityModel.InitFromProto(entityData, componentDataMap);
		}
		return survivorsRogueEntityModel;
	}

	// Token: 0x0600318B RID: 12683 RVA: 0x0011C8A9 File Offset: 0x0011AAA9
	public new static void Clear()
	{
		SurvivorsRogueEntityModel.EntityPool.Clear();
	}

	// Token: 0x0600318C RID: 12684 RVA: 0x0011C8B8 File Offset: 0x0011AAB8
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

	// Token: 0x0600318D RID: 12685 RVA: 0x0011C9E8 File Offset: 0x0011ABE8
	[NullableContext(1)]
	public virtual void Update(ISurvivorsRogueCombatInfo other)
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

	// Token: 0x0600318E RID: 12686 RVA: 0x0011CAD1 File Offset: 0x0011ACD1
	public bool IsValid()
	{
		return this.Uid > 0;
	}

	// Token: 0x0600318F RID: 12687 RVA: 0x0011CADC File Offset: 0x0011ACDC
	public void Reset()
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

	// Token: 0x06003190 RID: 12688 RVA: 0x0011CB7E File Offset: 0x0011AD7E
	public void Release()
	{
		this.Reset();
		SurvivorsRogueEntityModel.EntityPool.Put(this);
	}

	// Token: 0x06003191 RID: 12689 RVA: 0x0011CB94 File Offset: 0x0011AD94
	[NullableContext(1)]
	public ISurvivorsRogueCombatInfo Clone()
	{
		SurvivorsRogueEntityModel survivorsRogueEntityModel = SurvivorsRogueEntityModel.EntityPool.Get();
		if (survivorsRogueEntityModel == null)
		{
			survivorsRogueEntityModel = SurvivorsRogueEntityModel.EntityPool.Create();
		}
		if (survivorsRogueEntityModel != null)
		{
			survivorsRogueEntityModel.Update(this);
		}
		return survivorsRogueEntityModel;
	}

	// Token: 0x04002B5A RID: 11098
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static Pool<SurvivorsRogueEntityModel> EntityPool;
}
