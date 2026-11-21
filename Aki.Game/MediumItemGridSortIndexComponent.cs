using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x02000DF1 RID: 3569
public class MediumItemGridSortIndexComponent : MediumItemGridComponent
{
	// Token: 0x060090BC RID: 37052 RVA: 0x002B60F0 File Offset: 0x002B42F0
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

	// Token: 0x060090BD RID: 37053 RVA: 0x002B6138 File Offset: 0x002B4338
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemSortNum";
	}

	// Token: 0x060090BE RID: 37054 RVA: 0x002B6140 File Offset: 0x002B4340
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

	// Token: 0x02007027 RID: 28711
	private class EChildType
	{
		// Token: 0x040249B0 RID: 149936
		public const int SortIndexText = 0;
	}
}
