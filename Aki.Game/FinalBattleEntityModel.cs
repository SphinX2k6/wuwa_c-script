using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

// Token: 0x02000324 RID: 804
[NullableContext(2)]
[Nullable(0)]
public class FinalBattleEntityModel : IFinalBattleActivityEntityInfo, IFinalBattleCombatInfo, IStaticVariableResetter
{
	// Token: 0x17000693 RID: 1683
	// (get) Token: 0x06002D6B RID: 11627 RVA: 0x0010D81C File Offset: 0x0010BA1C
	// (set) Token: 0x06002D6C RID: 11628 RVA: 0x0010D824 File Offset: 0x0010BA24
	public EFinalBattleEntityType EntityType { get; set; } = EFinalBattleEntityType.Monster;

	// Token: 0x17000694 RID: 1684
	// (get) Token: 0x06002D6D RID: 11629 RVA: 0x0010D82D File Offset: 0x0010BA2D
	// (set) Token: 0x06002D6E RID: 11630 RVA: 0x0010D835 File Offset: 0x0010BA35
	public int Uid { get; set; }

	// Token: 0x17000695 RID: 1685
	// (get) Token: 0x06002D6F RID: 11631 RVA: 0x0010D83E File Offset: 0x0010BA3E
	// (set) Token: 0x06002D70 RID: 11632 RVA: 0x0010D846 File Offset: 0x0010BA46
	public int OwnerId { get; set; }

	// Token: 0x17000696 RID: 1686
	// (get) Token: 0x06002D71 RID: 11633 RVA: 0x0010D84F File Offset: 0x0010BA4F
	// (set) Token: 0x06002D72 RID: 11634 RVA: 0x0010D857 File Offset: 0x0010BA57
	public int TemplateId { get; set; }

	// Token: 0x17000697 RID: 1687
	// (get) Token: 0x06002D73 RID: 11635 RVA: 0x0010D860 File Offset: 0x0010BA60
	// (set) Token: 0x06002D74 RID: 11636 RVA: 0x0010D868 File Offset: 0x0010BA68
	public int CombatId { get; set; }

	// Token: 0x17000698 RID: 1688
	// (get) Token: 0x06002D75 RID: 11637 RVA: 0x0010D871 File Offset: 0x0010BA71
	// (set) Token: 0x06002D76 RID: 11638 RVA: 0x0010D879 File Offset: 0x0010BA79
	public int SubTypeId { get; set; }

	// Token: 0x17000699 RID: 1689
	// (get) Token: 0x06002D77 RID: 11639 RVA: 0x0010D882 File Offset: 0x0010BA82
	// (set) Token: 0x06002D78 RID: 11640 RVA: 0x0010D88A File Offset: 0x0010BA8A
	public string PrefabPath { get; set; }

	// Token: 0x1700069A RID: 1690
	// (get) Token: 0x06002D79 RID: 11641 RVA: 0x0010D893 File Offset: 0x0010BA93
	// (set) Token: 0x06002D7A RID: 11642 RVA: 0x0010D89B File Offset: 0x0010BA9B
	public string AssetPath { get; set; }

	// Token: 0x1700069B RID: 1691
	// (get) Token: 0x06002D7B RID: 11643 RVA: 0x0010D8A4 File Offset: 0x0010BAA4
	// (set) Token: 0x06002D7C RID: 11644 RVA: 0x0010D8AC File Offset: 0x0010BAAC
	public int PropertyId { get; set; }

	// Token: 0x1700069C RID: 1692
	// (get) Token: 0x06002D7D RID: 11645 RVA: 0x0010D8B5 File Offset: 0x0010BAB5
	// (set) Token: 0x06002D7E RID: 11646 RVA: 0x0010D8BD File Offset: 0x0010BABD
	public int? SplineId { get; set; }

	// Token: 0x1700069D RID: 1693
	// (get) Token: 0x06002D7F RID: 11647 RVA: 0x0010D8C6 File Offset: 0x0010BAC6
	// (set) Token: 0x06002D80 RID: 11648 RVA: 0x0010D8CE File Offset: 0x0010BACE
	public Dictionary<int, int> BuffIdLayers { get; set; }

	// Token: 0x1700069E RID: 1694
	// (get) Token: 0x06002D81 RID: 11649 RVA: 0x0010D8D7 File Offset: 0x0010BAD7
	// (set) Token: 0x06002D82 RID: 11650 RVA: 0x0010D8DF File Offset: 0x0010BADF
	public Dictionary<int, int> AttributeMap { get; set; }

	// Token: 0x1700069F RID: 1695
	// (get) Token: 0x06002D83 RID: 11651 RVA: 0x0010D8E8 File Offset: 0x0010BAE8
	// (set) Token: 0x06002D84 RID: 11652 RVA: 0x0010D8F0 File Offset: 0x0010BAF0
	[Nullable(1)]
	public global::Vector Position { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x170006A0 RID: 1696
	// (get) Token: 0x06002D85 RID: 11653 RVA: 0x0010D8F9 File Offset: 0x0010BAF9
	// (set) Token: 0x06002D86 RID: 11654 RVA: 0x0010D901 File Offset: 0x0010BB01
	[Nullable(1)]
	public global::Rotator Rotation { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x170006A1 RID: 1697
	// (get) Token: 0x06002D87 RID: 11655 RVA: 0x0010D90A File Offset: 0x0010BB0A
	// (set) Token: 0x06002D88 RID: 11656 RVA: 0x0010D912 File Offset: 0x0010BB12
	public int ConfigId { get; set; }

	// Token: 0x06002D89 RID: 11657 RVA: 0x0010D91C File Offset: 0x0010BB1C
	public FinalBattleEntityModel()
	{
		this.Position = global::Vector.Create(0.0, 0.0, 0.0);
		this.Rotation = global::Rotator.Create(0f, 0f, 0f);
	}

	// Token: 0x06002D8A RID: 11658 RVA: 0x0010D976 File Offset: 0x0010BB76
	static FinalBattleEntityModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FinalBattleEntityModel.CreateStaticDefaultValue), new Action(FinalBattleEntityModel.ResetStaticDefaultValue));
	}

	// Token: 0x06002D8B RID: 11659 RVA: 0x0010D995 File Offset: 0x0010BB95
	public static void CreateStaticDefaultValue()
	{
		FinalBattleEntityModel.EntityPool = new Pool<FinalBattleEntityModel>(100, () => new FinalBattleEntityModel(), null);
	}

	// Token: 0x06002D8C RID: 11660 RVA: 0x0010D9C3 File Offset: 0x0010BBC3
	public static void ResetStaticDefaultValue()
	{
		FinalBattleEntityModel.EntityPool = null;
	}

	// Token: 0x06002D8D RID: 11661 RVA: 0x0010D9CC File Offset: 0x0010BBCC
	[NullableContext(1)]
	[return: Nullable(2)]
	public static IFinalBattleCombatInfo BuildModel(EntityPb entityData, Dictionary<string, EntityComponentPb> componentDataMap)
	{
		if (!componentDataMap.ContainsKey("SimpleCombatComponentPb"))
		{
			return null;
		}
		FinalBattleEntityModel finalBattleEntityModel = FinalBattleEntityModel.EntityPool.Get();
		if (finalBattleEntityModel == null)
		{
			finalBattleEntityModel = FinalBattleEntityModel.EntityPool.Create();
		}
		finalBattleEntityModel.InitFromProto(entityData, componentDataMap);
		return finalBattleEntityModel;
	}

	// Token: 0x06002D8E RID: 11662 RVA: 0x0010DA0A File Offset: 0x0010BC0A
	public static void Clear()
	{
		FinalBattleEntityModel.EntityPool.Clear();
	}

	// Token: 0x06002D8F RID: 11663 RVA: 0x0010DA18 File Offset: 0x0010BC18
	[NullableContext(1)]
	protected void InitFromProto(EntityPb entityData, Dictionary<string, EntityComponentPb> componentDataMap)
	{
		SimpleCombatComponentPb simpleCombatComponentPb = componentDataMap["SimpleCombatComponentPb"].SimpleCombatComponentPb;
		EntityComponentPb entityComponentPb;
		GpuEntityComponentPb gpuEntityComponentPb = componentDataMap.TryGetValue("GpuEntityComponentPb", out entityComponentPb) ? entityComponentPb.GpuEntityComponentPb : null;
		this.EntityType = EFinalBattleEntityType.Monster;
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
		this.ConfigId = ((gpuEntityComponentPb != null) ? gpuEntityComponentPb.ConfigId : 0);
		if (((gpuEntityComponentPb != null) ? gpuEntityComponentPb.GpuMonsterEntityPbData : null) != null)
		{
			this.EntityType = EFinalBattleEntityType.Monster;
			GPUMonster? config = ConfigGPUMonsterById.GetConfig(this.ConfigId, true);
			this.PropertyId = ((config != null) ? config.GetValueOrDefault().Prop : 0);
		}
		else if (((gpuEntityComponentPb != null) ? gpuEntityComponentPb.GpuRolePbEntityData : null) != null)
		{
			this.EntityType = EFinalBattleEntityType.Role;
			GPURole? config2 = ConfigGPURoleById.GetConfig(this.ConfigId, true);
			this.PropertyId = ((config2 != null) ? config2.GetValueOrDefault().Prop : 0);
		}
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

	// Token: 0x06002D90 RID: 11664 RVA: 0x0010DC0C File Offset: 0x0010BE0C
	[NullableContext(1)]
	public void Update(IFinalBattleCombatInfo other)
	{
		this.EntityType = other.EntityType;
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
		this.ConfigId = ((IFinalBattleActivityEntityInfo)other).ConfigId;
	}

	// Token: 0x06002D91 RID: 11665 RVA: 0x0010DD12 File Offset: 0x0010BF12
	public bool IsValid()
	{
		return this.Uid > 0;
	}

	// Token: 0x06002D92 RID: 11666 RVA: 0x0010DD20 File Offset: 0x0010BF20
	public void Reset()
	{
		this.EntityType = EFinalBattleEntityType.Monster;
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
		this.ConfigId = 0;
	}

	// Token: 0x06002D93 RID: 11667 RVA: 0x0010DDD0 File Offset: 0x0010BFD0
	public void Release()
	{
		this.Reset();
		FinalBattleEntityModel.EntityPool.Put(this);
	}

	// Token: 0x06002D94 RID: 11668 RVA: 0x0010DDE4 File Offset: 0x0010BFE4
	[NullableContext(1)]
	public IFinalBattleCombatInfo Clone()
	{
		FinalBattleEntityModel finalBattleEntityModel = FinalBattleEntityModel.EntityPool.Get();
		if (finalBattleEntityModel == null)
		{
			finalBattleEntityModel = FinalBattleEntityModel.EntityPool.Create();
		}
		finalBattleEntityModel.Update(this);
		return finalBattleEntityModel;
	}

	// Token: 0x040029B5 RID: 10677
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static Pool<FinalBattleEntityModel> EntityPool;
}
