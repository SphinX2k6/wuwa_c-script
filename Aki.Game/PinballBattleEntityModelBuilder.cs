using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02000EA9 RID: 3753
public class PinballBattleEntityModelBuilder
{
	// Token: 0x06005CAE RID: 23726 RVA: 0x00110D70 File Offset: 0x0010EF70
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

	// Token: 0x06005CAF RID: 23727 RVA: 0x00110D98 File Offset: 0x0010EF98
	public static void Clear()
	{
		PinballBattleActivityEntityModel.Clear();
		PinballBattleEntityModel.Clear();
	}
}
