using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002863 RID: 10339
public static class FavorExpItemFactory
{
	// Token: 0x060154A9 RID: 87209 RVA: 0x0056039C File Offset: 0x0055E59C
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
