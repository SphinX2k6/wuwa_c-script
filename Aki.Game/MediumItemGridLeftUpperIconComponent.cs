using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x0200191B RID: 6427
public class MediumItemGridLeftUpperIconComponent : MediumItemGridComponent
{
	// Token: 0x0600BC3F RID: 48191 RVA: 0x002AA4E8 File Offset: 0x002A86E8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 1;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int index = 0;
		*span[index] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600BC40 RID: 48192 RVA: 0x002AA530 File Offset: 0x002A8730
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemElement";
	}

	// Token: 0x0600BC41 RID: 48193 RVA: 0x002AA538 File Offset: 0x002A8738
	[NullableContext(2)]
	protected override void OnRefresh(object data)
	{
		string text = data as string;
		if (text == null || string.IsNullOrEmpty(text))
		{
			this.SetActive(false);
			return;
		}
		UUITexture texture = base.GetTexture(0);
		base.SetTextureShowUntilLoaded(text, texture, null);
		this.SetActive(true);
	}

	// Token: 0x02007E8B RID: 32395
	private class EChildType
	{
		// Token: 0x04029659 RID: 169561
		public const int ElementTexture = 0;
	}
}
