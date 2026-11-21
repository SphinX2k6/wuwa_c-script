using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001DDE RID: 7646
public static class FavorExpItemFactory
{
	// Token: 0x06012EA7 RID: 77479 RVA: 0x0058B0F8 File Offset: 0x005892F8
	[NullableContext(1)]
	public static ILayoutItem<RoleFavorHintItem> InitFavorExpItem(object roleFavorHintData, UUIItem uiItem, int index)
	{
		RoleFavorHintItem value = new RoleFavorHintItem((RoleFavorHintData)roleFavorHintData, uiItem);
		return new LayoutItem<RoleFavorHintItem>
		{
			Key = index,
			Value = value
		};
	}
}
