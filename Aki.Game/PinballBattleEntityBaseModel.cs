using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02000EA2 RID: 3746
public abstract class PinballBattleEntityBaseModel
{
	// Token: 0x06005C4C RID: 23628 RVA: 0x00110677 File Offset: 0x0010E877
	[NullableContext(1)]
	[return: Nullable(2)]
	public static IPinballBattleCombatInfo BuildModel(EntityPb entityData, Dictionary<string, EntityComponentPb> componentDataMap)
	{
		return null;
	}

	// Token: 0x06005C4D RID: 23629 RVA: 0x0011067A File Offset: 0x0010E87A
	public static void Clear()
	{
	}
}
