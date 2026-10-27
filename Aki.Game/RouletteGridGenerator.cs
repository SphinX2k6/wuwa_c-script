using System;
using System.Runtime.CompilerServices;

// Token: 0x0200292B RID: 10539
public static class RouletteGridGenerator
{
	// Token: 0x06015C09 RID: 89097 RVA: 0x0057C994 File Offset: 0x0057AB94
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
