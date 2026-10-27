using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x02001936 RID: 6454
public class MediumItemGridSpriteIconComponent : MediumItemGridComponent
{
	// Token: 0x0600BCC5 RID: 48325 RVA: 0x002AB6C4 File Offset: 0x002A98C4
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

	// Token: 0x0600BCC6 RID: 48326 RVA: 0x002AB70C File Offset: 0x002A990C
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemSprite";
	}

	// Token: 0x0600BCC7 RID: 48327 RVA: 0x002AB714 File Offset: 0x002A9914
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

	// Token: 0x02007E9B RID: 32411
	private class EChildType
	{
		// Token: 0x04029679 RID: 169593
		public const int SpriteIcon = 0;
	}
}
