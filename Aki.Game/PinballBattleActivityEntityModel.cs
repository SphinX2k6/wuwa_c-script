using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02000EA8 RID: 3752
[NullableContext(1)]
[Nullable(0)]
public class PinballBattleActivityEntityModel : PinballBattleEntityModel, IPinballBattleActivityEntityInfo, IPinballBattleCombatInfo, IPinballBattleConfigInfo
{
	// Token: 0x170006E4 RID: 1764
	// (get) Token: 0x06005C9E RID: 23710 RVA: 0x00110B79 File Offset: 0x0010ED79
	// (set) Token: 0x06005C9F RID: 23711 RVA: 0x00110B81 File Offset: 0x0010ED81
	public int ConfigId { get; set; }

	// Token: 0x170006E5 RID: 1765
	// (get) Token: 0x06005CA0 RID: 23712 RVA: 0x00110B8A File Offset: 0x0010ED8A
	// (set) Token: 0x06005CA1 RID: 23713 RVA: 0x00110B92 File Offset: 0x0010ED92
	public EPinballBattleMonsterDeathType DeathType { get; set; }

	// Token: 0x06005CA2 RID: 23714 RVA: 0x00110B9B File Offset: 0x0010ED9B
	static PinballBattleActivityEntityModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PinballBattleActivityEntityModel.CreateStaticDefaultValue), new Action(PinballBattleActivityEntityModel.ResetStaticDefaultValue));
	}

	// Token: 0x06005CA3 RID: 23715 RVA: 0x00110BBA File Offset: 0x0010EDBA
	public new static void CreateStaticDefaultValue()
	{
		PinballBattleActivityEntityModel.ActivityEntityPool = new Pool<PinballBattleActivityEntityModel>(100, () => new PinballBattleActivityEntityModel(), null);
	}

	// Token: 0x06005CA4 RID: 23716 RVA: 0x00110BE8 File Offset: 0x0010EDE8
	public new static void ResetStaticDefaultValue()
	{
		PinballBattleActivityEntityModel.ActivityEntityPool = null;
	}

	// Token: 0x06005CA5 RID: 23717 RVA: 0x00110BF0 File Offset: 0x0010EDF0
	public static PinballBattleActivityEntityModel InitFromConfigId(int configId)
	{
		PinballBattleActivityEntityModel pinballBattleActivityEntityModel = PinballBattleActivityEntityModel.ActivityEntityPool.Get();
		if (pinballBattleActivityEntityModel == null)
		{
			pinballBattleActivityEntityModel = PinballBattleActivityEntityModel.ActivityEntityPool.Create();
		}
		if (pinballBattleActivityEntityModel != null)
		{
			pinballBattleActivityEntityModel.ConfigId = configId;
		}
		return pinballBattleActivityEntityModel;
	}

	// Token: 0x06005CA6 RID: 23718 RVA: 0x00110C24 File Offset: 0x0010EE24
	[return: Nullable(2)]
	public new static IPinballBattleCombatInfo BuildModel(EntityPb entityData, Dictionary<string, EntityComponentPb> componentDataMap)
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
		PinballBattleActivityEntityModel pinballBattleActivityEntityModel = PinballBattleActivityEntityModel.ActivityEntityPool.Get();
		if (pinballBattleActivityEntityModel == null)
		{
			pinballBattleActivityEntityModel = PinballBattleActivityEntityModel.ActivityEntityPool.Create();
		}
		if (pinballBattleActivityEntityModel != null)
		{
			pinballBattleActivityEntityModel.InitFromProto(entityData, componentDataMap);
		}
		return pinballBattleActivityEntityModel;
	}

	// Token: 0x06005CA7 RID: 23719 RVA: 0x00110C91 File Offset: 0x0010EE91
	public new static void Clear()
	{
		PinballBattleActivityEntityModel.ActivityEntityPool.Clear();
	}

	// Token: 0x06005CA8 RID: 23720 RVA: 0x00110CA0 File Offset: 0x0010EEA0
	protected override void InitFromProto(EntityPb entityData, Dictionary<string, EntityComponentPb> componentDataMap)
	{
		base.InitFromProto(entityData, componentDataMap);
		ActivityComponentPb activityComponentPb = componentDataMap["ActivityComponentPb"].ActivityComponentPb;
		this.ConfigId = activityComponentPb.ConfigId;
	}

	// Token: 0x06005CA9 RID: 23721 RVA: 0x00110CD4 File Offset: 0x0010EED4
	public override void Update(IPinballBattleCombatInfo other)
	{
		base.Update(other);
		IPinballBattleActivityEntityInfo pinballBattleActivityEntityInfo = (IPinballBattleActivityEntityInfo)other;
		this.ConfigId = pinballBattleActivityEntityInfo.ConfigId;
		this.DeathType = pinballBattleActivityEntityInfo.DeathType;
	}

	// Token: 0x06005CAA RID: 23722 RVA: 0x00110D07 File Offset: 0x0010EF07
	public override void Reset()
	{
		base.Reset();
		this.ConfigId = 0;
		this.DeathType = EPinballBattleMonsterDeathType.Normal;
	}

	// Token: 0x06005CAB RID: 23723 RVA: 0x00110D1D File Offset: 0x0010EF1D
	public override void Release()
	{
		this.Reset();
		PinballBattleActivityEntityModel.ActivityEntityPool.Put(this);
	}

	// Token: 0x06005CAC RID: 23724 RVA: 0x00110D34 File Offset: 0x0010EF34
	public override IPinballBattleCombatInfo Clone()
	{
		PinballBattleActivityEntityModel pinballBattleActivityEntityModel = PinballBattleActivityEntityModel.ActivityEntityPool.Get();
		if (pinballBattleActivityEntityModel == null)
		{
			pinballBattleActivityEntityModel = PinballBattleActivityEntityModel.ActivityEntityPool.Create();
		}
		if (pinballBattleActivityEntityModel != null)
		{
			pinballBattleActivityEntityModel.Update(this);
		}
		return pinballBattleActivityEntityModel;
	}

	// Token: 0x04002A46 RID: 10822
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static Pool<PinballBattleActivityEntityModel> ActivityEntityPool;
}
