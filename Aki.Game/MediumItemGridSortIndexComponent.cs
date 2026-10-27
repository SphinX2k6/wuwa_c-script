using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x02001935 RID: 6453
public class MediumItemGridSortIndexComponent : MediumItemGridComponent
{
	// Token: 0x0600BCC1 RID: 48321 RVA: 0x002AB624 File Offset: 0x002A9824
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

	// Token: 0x0600BCC2 RID: 48322 RVA: 0x002AB66C File Offset: 0x002A986C
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemSortNum";
	}

	// Token: 0x0600BCC3 RID: 48323 RVA: 0x002AB674 File Offset: 0x002A9874
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

	// Token: 0x02007E9A RID: 32410
	private class EChildType
	{
		// Token: 0x04029678 RID: 169592
		public const int SortIndexText = 0;
	}
}
