using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020022FF RID: 8959
public class PreloadBulletConfig
{
	// Token: 0x0400B96C RID: 47468
	public EBulletPreloadSource Source;

	// Token: 0x0400B96D RID: 47469
	public int ModelId;

	// Token: 0x0400B96E RID: 47470
	public int EntityId;

	// Token: 0x0400B96F RID: 47471
	[Nullable(2)]
	public UDataTable DataTable;

	// Token: 0x0400B970 RID: 47472
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public string[] RowNames;

	// Token: 0x0400B971 RID: 47473
	public int CurIndex;
}
