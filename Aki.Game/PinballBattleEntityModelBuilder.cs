using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x0200035E RID: 862
public class PinballBattleEntityModelBuilder
{
	// Token: 0x06003045 RID: 12357 RVA: 0x00118A0C File Offset: 0x00116C0C
	[NullableContext(1)]
	[return: Nullable(2)]
	public static IPinballBattleCombatInfo Get(EntityPb entityData, Dictionary<string, EntityComponentPb> componentDataMap)
	{
		IPinballBattleCombatInfo pinballBattleCombatInfo = PinballBattleActivityEntityModel.BuildModel(entityData, componentDataMap);
		if (pinballBattleCombatInfo != null)
		{
			return pinballBattleCombatInfo;
		}
		pinballBattleCombatInfo = PinballBattleEntityModel.BuildModel(entityData, componentDataMap);
		if (pinballBattleCombatInfo != null)
		{
			return pinballBattleCombatInfo;
		}
		return null;
	}

	// Token: 0x06003046 RID: 12358 RVA: 0x00118A34 File Offset: 0x00116C34
	public static void Clear()
	{
		PinballBattleActivityEntityModel.Clear();
		PinballBattleEntityModel.Clear();
	}
}
