using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x02001925 RID: 6437
public class MediumItemGridPhantomSortNumComponent : MediumItemGridComponent
{
	// Token: 0x0600BC7C RID: 48252 RVA: 0x002AAAD0 File Offset: 0x002A8CD0
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

	// Token: 0x0600BC7D RID: 48253 RVA: 0x002AAB18 File Offset: 0x002A8D18
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemBSortNumA";
	}

	// Token: 0x0600BC7E RID: 48254 RVA: 0x002AAB20 File Offset: 0x002A8D20
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

	// Token: 0x02007E8E RID: 32398
	private class EComponent
	{
		// Token: 0x04029664 RID: 169572
		public const int TxtSortNum = 0;
	}
}
