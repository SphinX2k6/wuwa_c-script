using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x02001938 RID: 6456
public class MediumItemGridSubIconComponent : MediumItemGridComponent
{
	// Token: 0x0600BCD0 RID: 48336 RVA: 0x002AB973 File Offset: 0x002A9B73
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemAIcon";
	}

	// Token: 0x0600BCD1 RID: 48337 RVA: 0x002AB97C File Offset: 0x002A9B7C
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

	// Token: 0x0600BCD2 RID: 48338 RVA: 0x002AB9C4 File Offset: 0x002A9BC4
	[NullableContext(2)]
	protected override void OnRefresh(object data)
	{
		string text = data as string;
		if (text == null)
		{
			return;
		}
		bool flag = !string.IsNullOrEmpty(text);
		this.SetActive(flag);
		if (flag)
		{
			base.SetTextureShowUntilLoaded(text, base.GetTexture(0), null);
		}
	}

	// Token: 0x0600BCD3 RID: 48339 RVA: 0x002AB9FF File Offset: 0x002A9BFF
	public override EItemGridComponentLayoutLevel GetLayoutLevel()
	{
		return EItemGridComponentLayoutLevel.UnderText;
	}

	// Token: 0x02007E9D RID: 32413
	private class EChildType
	{
		// Token: 0x0402967C RID: 169596
		public const int TextureIcon = 0;
	}
}
