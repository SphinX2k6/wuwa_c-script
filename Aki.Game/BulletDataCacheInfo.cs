using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002DA6 RID: 11686
public class BulletDataCacheInfo
{
	// Token: 0x0400B5FC RID: 46588
	[Nullable(1)]
	public Dictionary<string, BulletDataMain> BulletDataMap = new Dictionary<string, BulletDataMain>();

	// Token: 0x0400B5FD RID: 46589
	[Nullable(2)]
	public UDataTable DataTable;

	// Token: 0x0400B5FE RID: 46590
	public int EntityCount;
}
