using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002DA5 RID: 11685
public class PreloadBulletConfig
{
	// Token: 0x0400B5F6 RID: 46582
	public EBulletPreloadSource Source;

	// Token: 0x0400B5F7 RID: 46583
	public int ModelId;

	// Token: 0x0400B5F8 RID: 46584
	public int EntityId;

	// Token: 0x0400B5F9 RID: 46585
	[Nullable(2)]
	public UDataTable DataTable;

	// Token: 0x0400B5FA RID: 46586
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public string[] RowNames;

	// Token: 0x0400B5FB RID: 46587
	public int CurIndex;
}
