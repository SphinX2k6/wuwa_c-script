using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001DE5 RID: 7653
[NullableContext(1)]
[Nullable(0)]
public static class HandBookBaseViewHelper
{
	// Token: 0x0600E8F0 RID: 59632 RVA: 0x003726B0 File Offset: 0x003708B0
	public static ILayoutItem<HandBookInfoTextItem> InitInfoItem(object content, UUIItem uiItem, int index)
	{
		HandBookInfoTextItem value = new HandBookInfoTextItem((string)content, uiItem);
		return new LayoutItem<HandBookInfoTextItem>
		{
			Key = index,
			Value = value
		};
	}

	// Token: 0x0600E8F1 RID: 59633 RVA: 0x003726E4 File Offset: 0x003708E4
	public static ILayoutItem<HandBookContentItem> InitContentItem(object data, UUIItem uiItem, int index)
	{
		HandBookContentItem value = new HandBookContentItem((HandBookContentItemData)data, uiItem);
		return new LayoutItem<HandBookContentItem>
		{
			Key = index,
			Value = value
		};
	}

	// Token: 0x0600E8F2 RID: 59634 RVA: 0x00372716 File Offset: 0x00370916
	public static AttributeItem InitAttributeItem()
	{
		return new AttributeItem();
	}
}
