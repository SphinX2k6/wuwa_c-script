using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x02001974 RID: 6516
[NullableContext(1)]
[Nullable(0)]
public class SmallItemGridDisableComponent : SmallItemGridComponent
{
	// Token: 0x0600BECD RID: 48845 RVA: 0x002B2B80 File Offset: 0x002B0D80
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

	// Token: 0x0600BECE RID: 48846 RVA: 0x002B2BC8 File Offset: 0x002B0DC8
	protected override void OnRefresh(object bVisible)
	{
		this.SetActive((bVisible as bool?).GetValueOrDefault());
	}

	// Token: 0x0600BECF RID: 48847 RVA: 0x002B2BF0 File Offset: 0x002B0DF0
	public void SetSpriteColor(string hexColor)
	{
		FColor color = FColor.FromHex(hexColor);
		base.GetSprite(0).SetColor(color);
	}

	// Token: 0x0600BED0 RID: 48848 RVA: 0x002B2C11 File Offset: 0x002B0E11
	protected override string GetResourceId()
	{
		return "UiItem_SmallItemDark";
	}

	// Token: 0x0600BED1 RID: 48849 RVA: 0x002B2C18 File Offset: 0x002B0E18
	public override EItemGridComponentLayoutLevel GetLayoutLevel()
	{
		return EItemGridComponentLayoutLevel.Bottom;
	}

	// Token: 0x02007EC1 RID: 32449
	[NullableContext(0)]
	private class EChildType
	{
		// Token: 0x040296FB RID: 169723
		public const int Sprite = 0;
	}
}
