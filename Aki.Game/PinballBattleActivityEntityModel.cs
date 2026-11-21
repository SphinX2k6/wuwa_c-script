using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x0200035D RID: 861
[NullableContext(1)]
[Nullable(0)]
public class PinballBattleActivityEntityModel : PinballBattleEntityModel, IPinballBattleActivityEntityInfo, IPinballBattleCombatInfo, IPinballBattleConfigInfo
{
	// Token: 0x17000708 RID: 1800
	// (get) Token: 0x06003035 RID: 12341 RVA: 0x00118815 File Offset: 0x00116A15
	// (set) Token: 0x06003036 RID: 12342 RVA: 0x0011881D File Offset: 0x00116A1D
	public int ConfigId { get; set; }

	// Token: 0x17000709 RID: 1801
	// (get) Token: 0x06003037 RID: 12343 RVA: 0x00118826 File Offset: 0x00116A26
	// (set) Token: 0x06003038 RID: 12344 RVA: 0x0011882E File Offset: 0x00116A2E
	public EPinballBattleMonsterDeathType DeathType { get; set; }

	// Token: 0x06003039 RID: 12345 RVA: 0x00118837 File Offset: 0x00116A37
	static PinballBattleActivityEntityModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PinballBattleActivityEntityModel.CreateStaticDefaultValue), new Action(PinballBattleActivityEntityModel.ResetStaticDefaultValue));
	}

	// Token: 0x0600303A RID: 12346 RVA: 0x00118856 File Offset: 0x00116A56
	public new static void CreateStaticDefaultValue()
	{
		PinballBattleActivityEntityModel.ActivityEntityPool = new Pool<PinballBattleActivityEntityModel>(100, () => new PinballBattleActivityEntityModel(), null);
	}

	// Token: 0x0600303B RID: 12347 RVA: 0x00118884 File Offset: 0x00116A84
	public new static void ResetStaticDefaultValue()
	{
		PinballBattleActivityEntityModel.ActivityEntityPool = null;
	}

	// Token: 0x0600303C RID: 12348 RVA: 0x0011888C File Offset: 0x00116A8C
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

	// Token: 0x0600303D RID: 12349 RVA: 0x001188C0 File Offset: 0x00116AC0
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

	// Token: 0x0600303E RID: 12350 RVA: 0x0011892D File Offset: 0x00116B2D
	public new static void Clear()
	{
		PinballBattleActivityEntityModel.ActivityEntityPool.Clear();
	}

	// Token: 0x0600303F RID: 12351 RVA: 0x0011893C File Offset: 0x00116B3C
	protected override void InitFromProto(EntityPb entityData, Dictionary<string, EntityComponentPb> componentDataMap)
	{
		base.InitFromProto(entityData, componentDataMap);
		ActivityComponentPb activityComponentPb = componentDataMap["ActivityComponentPb"].ActivityComponentPb;
		this.ConfigId = activityComponentPb.ConfigId;
	}

	// Token: 0x06003040 RID: 12352 RVA: 0x00118970 File Offset: 0x00116B70
	public override void Update(IPinballBattleCombatInfo other)
	{
		base.Update(other);
		IPinballBattleActivityEntityInfo pinballBattleActivityEntityInfo = (IPinballBattleActivityEntityInfo)other;
		this.ConfigId = pinballBattleActivityEntityInfo.ConfigId;
		this.DeathType = pinballBattleActivityEntityInfo.DeathType;
	}

	// Token: 0x06003041 RID: 12353 RVA: 0x001189A3 File Offset: 0x00116BA3
	public override void Reset()
	{
		base.Reset();
		this.ConfigId = 0;
		this.DeathType = EPinballBattleMonsterDeathType.Normal;
	}

	// Token: 0x06003042 RID: 12354 RVA: 0x001189B9 File Offset: 0x00116BB9
	public override void Release()
	{
		this.Reset();
		PinballBattleActivityEntityModel.ActivityEntityPool.Put(this);
	}

	// Token: 0x06003043 RID: 12355 RVA: 0x001189D0 File Offset: 0x00116BD0
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

	// Token: 0x04002AE1 RID: 10977
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static Pool<PinballBattleActivityEntityModel> ActivityEntityPool;
}
