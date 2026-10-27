using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200313C RID: 12604
public class FightDataTableSnapshot
{
	// Token: 0x0400D2FC RID: 54012
	[Nullable(2)]
	public UDataTable SelfTable;

	// Token: 0x0400D2FD RID: 54013
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public IReadOnlyList<UDataTable> CommonTables;

	// Token: 0x0400D2FE RID: 54014
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public IReadOnlyList<UDataTable> ExtraTables;
}
