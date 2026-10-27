using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.WorldMap.SubViews.Common.TipList;

namespace CSharpScript.Game.Module.WorldMap.SubViews.Fishing
{
	// Token: 0x02004823 RID: 18467
	public class WorldMapFishingCageTipListPanel : WorldMapSecondaryTipListPanel
	{
		// Token: 0x06030583 RID: 198019 RVA: 0x00B38D20 File Offset: 0x00B36F20
		[NullableContext(1)]
		protected override WorldMapSecondaryTipListItem CreateListItem()
		{
			return new WorldMapFishingCageTipListItem();
		}
	}
}
