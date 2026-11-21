using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02000364 RID: 868
public abstract class PotatoEntityBaseModel
{
	// Token: 0x0600305B RID: 12379 RVA: 0x001190D5 File Offset: 0x001172D5
	[NullableContext(1)]
	[return: Nullable(2)]
	public static IPotatoCombatInfo BuildModel(EntityPb entityData, Dictionary<string, EntityComponentPb> componentDataMap)
	{
		return null;
	}

	// Token: 0x0600305C RID: 12380 RVA: 0x001190D8 File Offset: 0x001172D8
	public static void Clear()
	{
	}
}
