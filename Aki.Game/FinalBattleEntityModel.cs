using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

// Token: 0x02000E6F RID: 3695
[NullableContext(2)]
[Nullable(0)]
public class FinalBattleEntityModel : IFinalBattleActivityEntityInfo, IFinalBattleCombatInfo, IStaticVariableResetter
{
	// Token: 0x1700066F RID: 1647
	// (get) Token: 0x060059D4 RID: 22996 RVA: 0x00105B6C File Offset: 0x00103D6C
	// (set) Token: 0x060059D5 RID: 22997 RVA: 0x00105B74 File Offset: 0x00103D74
	public EFinalBattleEntityType EntityType { get; set; } = EFinalBattleEntityType.Monster;

	// Token: 0x17000670 RID: 1648
	// (get) Token: 0x060059D6 RID: 22998 RVA: 0x00105B7D File Offset: 0x00103D7D
	// (set) Token: 0x060059D7 RID: 22999 RVA: 0x00105B85 File Offset: 0x00103D85
	public int Uid { get; set; }

	// Token: 0x17000671 RID: 1649
	// (get) Token: 0x060059D8 RID: 23000 RVA: 0x00105B8E File Offset: 0x00103D8E
	// (set) Token: 0x060059D9 RID: 23001 RVA: 0x00105B96 File Offset: 0x00103D96
	public int OwnerId { get; set; }

	// Token: 0x17000672 RID: 1650
	// (get) Token: 0x060059DA RID: 23002 RVA: 0x00105B9F File Offset: 0x00103D9F
	// (set) Token: 0x060059DB RID: 23003 RVA: 0x00105BA7 File Offset: 0x00103DA7
	public int TemplateId { get; set; }

	// Token: 0x17000673 RID: 1651
	// (get) Token: 0x060059DC RID: 23004 RVA: 0x00105BB0 File Offset: 0x00103DB0
	// (set) Token: 0x060059DD RID: 23005 RVA: 0x00105BB8 File Offset: 0x00103DB8
	public int CombatId { get; set; }

	// Token: 0x17000674 RID: 1652
	// (get) Token: 0x060059DE RID: 23006 RVA: 0x00105BC1 File Offset: 0x00103DC1
	// (set) Token: 0x060059DF RID: 23007 RVA: 0x00105BC9 File Offset: 0x00103DC9
	public int SubTypeId { get; set; }

	// Token: 0x17000675 RID: 1653
	// (get) Token: 0x060059E0 RID: 23008 RVA: 0x00105BD2 File Offset: 0x00103DD2
	// (set) Token: 0x060059E1 RID: 23009 RVA: 0x00105BDA File Offset: 0x00103DDA
	public string PrefabPath { get; set; }

	// Token: 0x17000676 RID: 1654
	// (get) Token: 0x060059E2 RID: 23010 RVA: 0x00105BE3 File Offset: 0x00103DE3
	// (set) Token: 0x060059E3 RID: 23011 RVA: 0x00105BEB File Offset: 0x00103DEB
	public string AssetPath { get; set; }

	// Token: 0x17000677 RID: 1655
	// (get) Token: 0x060059E4 RID: 23012 RVA: 0x00105BF4 File Offset: 0x00103DF4
	// (set) Token: 0x060059E5 RID: 23013 RVA: 0x00105BFC File Offset: 0x00103DFC
	public int PropertyId { get; set; }

	// Token: 0x17000678 RID: 1656
	// (get) Token: 0x060059E6 RID: 23014 RVA: 0x00105C05 File Offset: 0x00103E05
	// (set) Token: 0x060059E7 RID: 23015 RVA: 0x00105C0D File Offset: 0x00103E0D
	public int? SplineId { get; set; }

	// Token: 0x17000679 RID: 1657
	// (get) Token: 0x060059E8 RID: 23016 RVA: 0x00105C16 File Offset: 0x00103E16
	// (set) Token: 0x060059E9 RID: 23017 RVA: 0x00105C1E File Offset: 0x00103E1E
	public Dictionary<int, int> BuffIdLayers { get; set; }

	// Token: 0x1700067A RID: 1658
	// (get) Token: 0x060059EA RID: 23018 RVA: 0x00105C27 File Offset: 0x00103E27
	// (set) Token: 0x060059EB RID: 23019 RVA: 0x00105C2F File Offset: 0x00103E2F
	public Dictionary<int, int> AttributeMap { get; set; }

	// Token: 0x1700067B RID: 1659
	// (get) Token: 0x060059EC RID: 23020 RVA: 0x00105C38 File Offset: 0x00103E38
	// (set) Token: 0x060059ED RID: 23021 RVA: 0x00105C40 File Offset: 0x00103E40
	[Nullable(1)]
	public global::Vector Position { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x1700067C RID: 1660
	// (get) Token: 0x060059EE RID: 23022 RVA: 0x00105C49 File Offset: 0x00103E49
	// (set) Token: 0x060059EF RID: 23023 RVA: 0x00105C51 File Offset: 0x00103E51
	[Nullable(1)]
	public global::Rotator Rotation { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x1700067D RID: 1661
	// (get) Token: 0x060059F0 RID: 23024 RVA: 0x00105C5A File Offset: 0x00103E5A
	// (set) Token: 0x060059F1 RID: 23025 RVA: 0x00105C62 File Offset: 0x00103E62
	public int ConfigId { get; set; }

	// Token: 0x060059F2 RID: 23026 RVA: 0x00105C6C File Offset: 0x00103E6C
	public FinalBattleEntityModel()
	{
		this.Position = global::Vector.Create(0.0, 0.0, 0.0);
		this.Rotation = global::Rotator.Create(0f, 0f, 0f);
	}

	// Token: 0x060059F3 RID: 23027 RVA: 0x00105CC6 File Offset: 0x00103EC6
	static FinalBattleEntityModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FinalBattleEntityModel.CreateStaticDefaultValue), new Action(FinalBattleEntityModel.ResetStaticDefaultValue));
	}

	// Token: 0x060059F4 RID: 23028 RVA: 0x00105CE5 File Offset: 0x00103EE5
	public static void CreateStaticDefaultValue()
	{
		FinalBattleEntityModel.EntityPool = new Pool<FinalBattleEntityModel>(100, () => new FinalBattleEntityModel(), null);
	}

	// Token: 0x060059F5 RID: 23029 RVA: 0x00105D13 File Offset: 0x00103F13
	public static void ResetStaticDefaultValue()
	{
		FinalBattleEntityModel.EntityPool = null;
	}

	// Token: 0x060059F6 RID: 23030 RVA: 0x00105D1C File Offset: 0x00103F1C
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

	// Token: 0x060059F7 RID: 23031 RVA: 0x00105D5A File Offset: 0x00103F5A
	public static void Clear()
	{
		FinalBattleEntityModel.EntityPool.Clear();
	}

	// Token: 0x060059F8 RID: 23032 RVA: 0x00105D68 File Offset: 0x00103F68
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

	// Token: 0x060059F9 RID: 23033 RVA: 0x00105F5C File Offset: 0x0010415C
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

	// Token: 0x060059FA RID: 23034 RVA: 0x00106062 File Offset: 0x00104262
	public bool IsValid()
	{
		return this.Uid > 0;
	}

	// Token: 0x060059FB RID: 23035 RVA: 0x00106070 File Offset: 0x00104270
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

	// Token: 0x060059FC RID: 23036 RVA: 0x00106120 File Offset: 0x00104320
	public void Release()
	{
		this.Reset();
		FinalBattleEntityModel.EntityPool.Put(this);
	}

	// Token: 0x060059FD RID: 23037 RVA: 0x00106134 File Offset: 0x00104334
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

	// Token: 0x0400291A RID: 10522
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static Pool<FinalBattleEntityModel> EntityPool;
}
