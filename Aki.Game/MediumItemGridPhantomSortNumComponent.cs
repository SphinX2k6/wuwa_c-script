using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x02000DDE RID: 3550
public class MediumItemGridPhantomSortNumComponent : MediumItemGridComponent
{
	// Token: 0x06009066 RID: 36966 RVA: 0x002B522C File Offset: 0x002B342C
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

	// Token: 0x06009067 RID: 36967 RVA: 0x002B5274 File Offset: 0x002B3474
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemBSortNumA";
	}

	// Token: 0x06009068 RID: 36968 RVA: 0x002B527C File Offset: 0x002B347C
	[NullableContext(2)]
	protected override void OnRefresh(object data)
	{
		if (data is int)
		{
			int num = (int)data;
			UUIText text = base.GetText(0);
			if (text != null)
			{
				text.SetText(num.ToString(), true);
			}
			this.SetActive(num > 0);
			return;
		}
	}

	// Token: 0x02007015 RID: 28693
	private class EComponent
	{
		// Token: 0x04024990 RID: 149904
		public const int TxtSortNum = 0;
	}
}
