using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02000EA7 RID: 3751
[NullableContext(2)]
[Nullable(0)]
public class PinballBattleEntityModel : PinballBattleEntityBaseModel, IPinballBattleCombatInfo, IStaticVariableResetter
{
	// Token: 0x170006D6 RID: 1750
	// (get) Token: 0x06005C76 RID: 23670 RVA: 0x00110684 File Offset: 0x0010E884
	// (set) Token: 0x06005C77 RID: 23671 RVA: 0x0011068C File Offset: 0x0010E88C
	public EPinballBattleEntityType EntityType { get; set; }

	// Token: 0x170006D7 RID: 1751
	// (get) Token: 0x06005C78 RID: 23672 RVA: 0x00110695 File Offset: 0x0010E895
	// (set) Token: 0x06005C79 RID: 23673 RVA: 0x0011069D File Offset: 0x0010E89D
	public int Uid { get; set; }

	// Token: 0x170006D8 RID: 1752
	// (get) Token: 0x06005C7A RID: 23674 RVA: 0x001106A6 File Offset: 0x0010E8A6
	// (set) Token: 0x06005C7B RID: 23675 RVA: 0x001106AE File Offset: 0x0010E8AE
	public int OwnerId { get; set; }

	// Token: 0x170006D9 RID: 1753
	// (get) Token: 0x06005C7C RID: 23676 RVA: 0x001106B7 File Offset: 0x0010E8B7
	// (set) Token: 0x06005C7D RID: 23677 RVA: 0x001106BF File Offset: 0x0010E8BF
	public int TemplateId { get; set; }

	// Token: 0x170006DA RID: 1754
	// (get) Token: 0x06005C7E RID: 23678 RVA: 0x001106C8 File Offset: 0x0010E8C8
	// (set) Token: 0x06005C7F RID: 23679 RVA: 0x001106D0 File Offset: 0x0010E8D0
	public int CombatId { get; set; }

	// Token: 0x170006DB RID: 1755
	// (get) Token: 0x06005C80 RID: 23680 RVA: 0x001106D9 File Offset: 0x0010E8D9
	// (set) Token: 0x06005C81 RID: 23681 RVA: 0x001106E1 File Offset: 0x0010E8E1
	public int SubTypeId { get; set; }

	// Token: 0x170006DC RID: 1756
	// (get) Token: 0x06005C82 RID: 23682 RVA: 0x001106EA File Offset: 0x0010E8EA
	// (set) Token: 0x06005C83 RID: 23683 RVA: 0x001106F2 File Offset: 0x0010E8F2
	public string PrefabPath { get; set; }

	// Token: 0x170006DD RID: 1757
	// (get) Token: 0x06005C84 RID: 23684 RVA: 0x001106FB File Offset: 0x0010E8FB
	// (set) Token: 0x06005C85 RID: 23685 RVA: 0x00110703 File Offset: 0x0010E903
	public string AssetPath { get; set; }

	// Token: 0x170006DE RID: 1758
	// (get) Token: 0x06005C86 RID: 23686 RVA: 0x0011070C File Offset: 0x0010E90C
	// (set) Token: 0x06005C87 RID: 23687 RVA: 0x00110714 File Offset: 0x0010E914
	public int PropertyId { get; set; }

	// Token: 0x170006DF RID: 1759
	// (get) Token: 0x06005C88 RID: 23688 RVA: 0x0011071D File Offset: 0x0010E91D
	// (set) Token: 0x06005C89 RID: 23689 RVA: 0x00110725 File Offset: 0x0010E925
	public int? SplineId { get; set; }

	// Token: 0x170006E0 RID: 1760
	// (get) Token: 0x06005C8A RID: 23690 RVA: 0x0011072E File Offset: 0x0010E92E
	// (set) Token: 0x06005C8B RID: 23691 RVA: 0x00110736 File Offset: 0x0010E936
	public Dictionary<int, int> BuffIdLayers { get; set; }

	// Token: 0x170006E1 RID: 1761
	// (get) Token: 0x06005C8C RID: 23692 RVA: 0x0011073F File Offset: 0x0010E93F
	// (set) Token: 0x06005C8D RID: 23693 RVA: 0x00110747 File Offset: 0x0010E947
	public Dictionary<int, int> AttributeMap { get; set; }

	// Token: 0x170006E2 RID: 1762
	// (get) Token: 0x06005C8E RID: 23694 RVA: 0x00110750 File Offset: 0x0010E950
	// (set) Token: 0x06005C8F RID: 23695 RVA: 0x00110758 File Offset: 0x0010E958
	[Nullable(1)]
	public global::Vector Position { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x170006E3 RID: 1763
	// (get) Token: 0x06005C90 RID: 23696 RVA: 0x00110761 File Offset: 0x0010E961
	// (set) Token: 0x06005C91 RID: 23697 RVA: 0x00110769 File Offset: 0x0010E969
	[Nullable(1)]
	public global::Rotator Rotation { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x06005C92 RID: 23698 RVA: 0x00110774 File Offset: 0x0010E974
	public PinballBattleEntityModel()
	{
		this.Position = global::Vector.Create(0.0, 0.0, 0.0);
		this.Rotation = global::Rotator.Create(0f, 0f, 0f);
	}

	// Token: 0x06005C93 RID: 23699 RVA: 0x001107C7 File Offset: 0x0010E9C7
	static PinballBattleEntityModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PinballBattleEntityModel.CreateStaticDefaultValue), new Action(PinballBattleEntityModel.ResetStaticDefaultValue));
	}

	// Token: 0x06005C94 RID: 23700 RVA: 0x001107E6 File Offset: 0x0010E9E6
	public static void CreateStaticDefaultValue()
	{
		PinballBattleEntityModel.EntityPool = new Pool<PinballBattleEntityModel>(100, () => new PinballBattleEntityModel(), null);
	}

	// Token: 0x06005C95 RID: 23701 RVA: 0x00110814 File Offset: 0x0010EA14
	public static void ResetStaticDefaultValue()
	{
		PinballBattleEntityModel.EntityPool = null;
	}

	// Token: 0x06005C96 RID: 23702 RVA: 0x0011081C File Offset: 0x0010EA1C
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

	// Token: 0x06005C97 RID: 23703 RVA: 0x0011085D File Offset: 0x0010EA5D
	public new static void Clear()
	{
		PinballBattleEntityModel.EntityPool.Clear();
	}

	// Token: 0x06005C98 RID: 23704 RVA: 0x0011086C File Offset: 0x0010EA6C
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

	// Token: 0x06005C99 RID: 23705 RVA: 0x0011099C File Offset: 0x0010EB9C
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

	// Token: 0x06005C9A RID: 23706 RVA: 0x00110A85 File Offset: 0x0010EC85
	public bool IsValid()
	{
		return this.Uid > 0;
	}

	// Token: 0x06005C9B RID: 23707 RVA: 0x00110A90 File Offset: 0x0010EC90
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

	// Token: 0x06005C9C RID: 23708 RVA: 0x00110B32 File Offset: 0x0010ED32
	public virtual void Release()
	{
		this.Reset();
		PinballBattleEntityModel.EntityPool.Put(this);
	}

	// Token: 0x06005C9D RID: 23709 RVA: 0x00110B48 File Offset: 0x0010ED48
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

	// Token: 0x04002A43 RID: 10819
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static Pool<PinballBattleEntityModel> EntityPool;
}
