using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x02000DF4 RID: 3572
public class MediumItemGridSubIconComponent : MediumItemGridComponent
{
	// Token: 0x060090CB RID: 37067 RVA: 0x002B643F File Offset: 0x002B463F
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemAIcon";
	}

	// Token: 0x060090CC RID: 37068 RVA: 0x002B6448 File Offset: 0x002B4648
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

	// Token: 0x060090CD RID: 37069 RVA: 0x002B6490 File Offset: 0x002B4690
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

	// Token: 0x060090CE RID: 37070 RVA: 0x002B64CB File Offset: 0x002B46CB
	public override EItemGridComponentLayoutLevel GetLayoutLevel()
	{
		return EItemGridComponentLayoutLevel.UnderText;
	}

	// Token: 0x0200702A RID: 28714
	private class EChildType
	{
		// Token: 0x040249B4 RID: 149940
		public const int TextureIcon = 0;
	}
}
