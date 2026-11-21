using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002300 RID: 8960
[NullableContext(1)]
[Nullable(0)]
public class BulletDataCacheInfo
{
	// Token: 0x0400B972 RID: 47474
	public Dictionary<string, BulletDataMain> BulletDataMap = new Dictionary<string, BulletDataMain>();

	// Token: 0x0400B973 RID: 47475
	public Dictionary<string, UDataTable> BulletDataSourceMap = new Dictionary<string, UDataTable>();

	// Token: 0x0400B974 RID: 47476
	public int EntityCount;
}
