using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02000EC2 RID: 3778
public abstract class SurvivorsRogueEntityBaseModel
{
	// Token: 0x06005DA1 RID: 23969 RVA: 0x001149E3 File Offset: 0x00112BE3
	[NullableContext(1)]
	[return: Nullable(2)]
	public static ISurvivorsRogueCombatInfo BuildModel(EntityPb entityData, Dictionary<string, EntityComponentPb> componentDataMap)
	{
		return null;
	}

	// Token: 0x06005DA2 RID: 23970 RVA: 0x001149E6 File Offset: 0x00112BE6
	public static void Clear()
	{
	}
}
