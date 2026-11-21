using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x02000DF2 RID: 3570
public class MediumItemGridSpriteIconComponent : MediumItemGridComponent
{
	// Token: 0x060090C0 RID: 37056 RVA: 0x002B6190 File Offset: 0x002B4390
	protected unsafe override void OnRegisterComponent()
	{
		int num = 1;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int index = 0;
		*span[index] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x060090C1 RID: 37057 RVA: 0x002B61D8 File Offset: 0x002B43D8
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemSprite";
	}

	// Token: 0x060090C2 RID: 37058 RVA: 0x002B61E0 File Offset: 0x002B43E0
	[NullableContext(2)]
	protected override void OnRefresh(object data)
	{
		string text = data as string;
		if (text == null || string.IsNullOrEmpty(text))
		{
			this.SetActive(false);
			return;
		}
		UUISprite sprite = base.GetSprite(0);
		this.SetSpriteByPath(text, sprite, false, null, null);
		this.SetActive(true);
	}

	// Token: 0x02007028 RID: 28712
	private class EChildType
	{
		// Token: 0x040249B1 RID: 149937
		public const int SpriteIcon = 0;
	}
}
