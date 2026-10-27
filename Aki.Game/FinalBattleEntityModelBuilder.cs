using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02000E70 RID: 3696
public class FinalBattleEntityModelBuilder
{
	// Token: 0x060059FE RID: 23038 RVA: 0x00106162 File Offset: 0x00104362
	[NullableContext(1)]
	[return: Nullable(2)]
	public static IFinalBattleCombatInfo Get(EntityPb entityData, Dictionary<string, EntityComponentPb> componentDataMap)
	{
		return FinalBattleEntityModel.BuildModel(entityData, componentDataMap);
	}

	// Token: 0x060059FF RID: 23039 RVA: 0x0010616B File Offset: 0x0010436B
	public static void Clear()
	{
		FinalBattleEntityModel.Clear();
	}
}
