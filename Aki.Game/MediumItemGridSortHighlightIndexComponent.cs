using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x02001934 RID: 6452
public class MediumItemGridSortHighlightIndexComponent : MediumItemGridComponent
{
	// Token: 0x0600BCBD RID: 48317 RVA: 0x002AB584 File Offset: 0x002A9784
	protected unsafe override void OnRegisterComponent()
	{
		int num = 1;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int index = 0;
		*span[index] = new ValueTuple<int, Type>(0, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600BCBE RID: 48318 RVA: 0x002AB5CC File Offset: 0x002A97CC
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemSortNumYellow";
	}

	// Token: 0x0600BCBF RID: 48319 RVA: 0x002AB5D4 File Offset: 0x002A97D4
	[NullableContext(2)]
	protected override void OnRefresh(object data)
	{
		if (data is int)
		{
			int num = (int)data;
			if (num != 0)
			{
				UUIText text = base.GetText(0);
				if (text != null)
				{
					text.SetText(num.ToString(), true);
				}
				this.SetActive(true);
				return;
			}
		}
		this.SetActive(false);
	}

	// Token: 0x02007E99 RID: 32409
	private class EChildType
	{
		// Token: 0x04029677 RID: 169591
		public const int SortIndexText = 0;
	}
}
