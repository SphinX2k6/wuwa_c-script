using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x02000DD4 RID: 3540
public class MediumItemGridLeftUpperIconComponent : MediumItemGridComponent
{
	// Token: 0x06009029 RID: 36905 RVA: 0x002B4C44 File Offset: 0x002B2E44
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

	// Token: 0x0600902A RID: 36906 RVA: 0x002B4C8C File Offset: 0x002B2E8C
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemElement";
	}

	// Token: 0x0600902B RID: 36907 RVA: 0x002B4C94 File Offset: 0x002B2E94
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

	// Token: 0x02007012 RID: 28690
	private class EChildType
	{
		// Token: 0x04024985 RID: 149893
		public const int ElementTexture = 0;
	}
}
