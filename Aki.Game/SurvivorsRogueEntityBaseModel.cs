using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02000377 RID: 887
public abstract class SurvivorsRogueEntityBaseModel
{
	// Token: 0x06003138 RID: 12600 RVA: 0x0011C6C3 File Offset: 0x0011A8C3
	[NullableContext(1)]
	[return: Nullable(2)]
	public static ISurvivorsRogueCombatInfo BuildModel(EntityPb entityData, Dictionary<string, EntityComponentPb> componentDataMap)
	{
		return null;
	}

	// Token: 0x06003139 RID: 12601 RVA: 0x0011C6C6 File Offset: 0x0011A8C6
	public static void Clear()
	{
	}
}
