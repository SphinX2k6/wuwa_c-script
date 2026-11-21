using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.WorldMap.SubViews.Common.TipList;

namespace CSharpScript.Game.Module.WorldMap.SubViews.Fishing
{
	// Token: 0x02003754 RID: 14164
	public class WorldMapFishingCageTipListPanel : WorldMapSecondaryTipListPanel
	{
		// Token: 0x06024D53 RID: 150867 RVA: 0x00A68DEC File Offset: 0x00A66FEC
		[NullableContext(1)]
		protected override WorldMapSecondaryTipListItem CreateListItem()
		{
			return new WorldMapFishingCageTipListItem();
		}
	}
}
