using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200313F RID: 12607
public static class FightDataTableUtil
{
	// Token: 0x0601B1E1 RID: 111073 RVA: 0x00760020 File Offset: 0x0075E220
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public static IReadOnlyList<UDataTable> BuildCommonTables([Nullable(new byte[]
	{
		1,
		2
	})] params UDataTable[] tables)
	{
		List<UDataTable> list = new List<UDataTable>();
		foreach (UDataTable udataTable in tables)
		{
			if (udataTable != null)
			{
				list.Add(udataTable);
			}
		}
		if (list.Count <= 0)
		{
			return null;
		}
		return list;
	}
}
