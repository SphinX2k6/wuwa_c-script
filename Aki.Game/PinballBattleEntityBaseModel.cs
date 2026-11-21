using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02000357 RID: 855
public abstract class PinballBattleEntityBaseModel
{
	// Token: 0x06002FE3 RID: 12259 RVA: 0x00118313 File Offset: 0x00116513
	[NullableContext(1)]
	[return: Nullable(2)]
	public static IPinballBattleCombatInfo BuildModel(EntityPb entityData, Dictionary<string, EntityComponentPb> componentDataMap)
	{
		return null;
	}

	// Token: 0x06002FE4 RID: 12260 RVA: 0x00118316 File Offset: 0x00116516
	public static void Clear()
	{
	}
}
