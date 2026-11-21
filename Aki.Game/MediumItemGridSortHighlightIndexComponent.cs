using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x02000DF0 RID: 3568
public class MediumItemGridSortHighlightIndexComponent : MediumItemGridComponent
{
	// Token: 0x060090B8 RID: 37048 RVA: 0x002B6050 File Offset: 0x002B4250
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

	// Token: 0x060090B9 RID: 37049 RVA: 0x002B6098 File Offset: 0x002B4298
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemSortNumYellow";
	}

	// Token: 0x060090BA RID: 37050 RVA: 0x002B60A0 File Offset: 0x002B42A0
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

	// Token: 0x02007026 RID: 28710
	private class EChildType
	{
		// Token: 0x040249AF RID: 149935
		public const int SortIndexText = 0;
	}
}
