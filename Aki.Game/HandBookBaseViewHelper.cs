using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020012A7 RID: 4775
[NullableContext(1)]
[Nullable(0)]
public static class HandBookBaseViewHelper
{
	// Token: 0x0600BD0F RID: 48399 RVA: 0x0037E3B8 File Offset: 0x0037C5B8
	public static ILayoutItem<HandBookInfoTextItem> InitInfoItem(object content, UUIItem uiItem, int index)
	{
		HandBookInfoTextItem value = new HandBookInfoTextItem((string)content, uiItem);
		return new LayoutItem<HandBookInfoTextItem>
		{
			Key = index,
			Value = value
		};
	}

	// Token: 0x0600BD10 RID: 48400 RVA: 0x0037E3EC File Offset: 0x0037C5EC
	public static ILayoutItem<HandBookContentItem> InitContentItem(object data, UUIItem uiItem, int index)
	{
		HandBookContentItem value = new HandBookContentItem((HandBookContentItemData)data, uiItem);
		return new LayoutItem<HandBookContentItem>
		{
			Key = index,
			Value = value
		};
	}

	// Token: 0x0600BD11 RID: 48401 RVA: 0x0037E41E File Offset: 0x0037C61E
	public static AttributeItem InitAttributeItem()
	{
		return new AttributeItem();
	}
}
