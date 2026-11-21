using System;
using System.Runtime.CompilerServices;

// Token: 0x02001EA6 RID: 7846
public static class RouletteGridGenerator
{
	// Token: 0x0601360E RID: 79374 RVA: 0x005A79D4 File Offset: 0x005A5BD4
	[NullableContext(1)]
	public static RouletteGridBase GetGenerator(ERouletteGridType gridType)
	{
		switch (gridType)
		{
		case ERouletteGridType.Explore:
			return new RouletteGridExplore();
		case ERouletteGridType.Function:
			return new RouletteGridFunction();
		case ERouletteGridType.EquipItem:
			return new RouletteGridEquipItem();
		default:
			return new RouletteGridExplore();
		}
	}
}
