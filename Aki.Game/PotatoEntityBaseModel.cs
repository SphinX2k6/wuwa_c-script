using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02000EAF RID: 3759
public abstract class PotatoEntityBaseModel
{
	// Token: 0x06005CC4 RID: 23748 RVA: 0x00111439 File Offset: 0x0010F639
	[NullableContext(1)]
	[return: Nullable(2)]
	public static IPotatoCombatInfo BuildModel(EntityPb entityData, Dictionary<string, EntityComponentPb> componentDataMap)
	{
		return null;
	}

	// Token: 0x06005CC5 RID: 23749 RVA: 0x0011143C File Offset: 0x0010F63C
	public static void Clear()
	{
	}
}
