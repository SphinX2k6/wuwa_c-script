using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02000325 RID: 805
public class FinalBattleEntityModelBuilder
{
	// Token: 0x06002D95 RID: 11669 RVA: 0x0010DE12 File Offset: 0x0010C012
	[NullableContext(1)]
	[return: Nullable(2)]
	public static IFinalBattleCombatInfo Get(EntityPb entityData, Dictionary<string, EntityComponentPb> componentDataMap)
	{
		return FinalBattleEntityModel.BuildModel(entityData, componentDataMap);
	}

	// Token: 0x06002D96 RID: 11670 RVA: 0x0010DE1B File Offset: 0x0010C01B
	public static void Clear()
	{
		FinalBattleEntityModel.Clear();
	}
}
