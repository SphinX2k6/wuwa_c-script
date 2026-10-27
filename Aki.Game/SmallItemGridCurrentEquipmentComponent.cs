using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x02001970 RID: 6512
[NullableContext(1)]
[Nullable(0)]
public class SmallItemGridCurrentEquipmentComponent : SmallItemGridVisibleComponent
{
	// Token: 0x0600BEBD RID: 48829 RVA: 0x002B2884 File Offset: 0x002B0A84
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600BEBE RID: 48830 RVA: 0x002B28F0 File Offset: 0x002B0AF0
	protected override void OnStart()
	{
		FColor color = FColor.FromHex("D5A831FF");
		base.GetSprite(0).SetColor(color);
		FColor color2 = FColor.FromHex("FFFFFFFF");
		base.GetSprite(1).SetColor(color2);
	}

	// Token: 0x0600BEBF RID: 48831 RVA: 0x002B292D File Offset: 0x002B0B2D
	[NullableContext(2)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemSelTick";
	}

	// Token: 0x0600BEC0 RID: 48832 RVA: 0x002B2934 File Offset: 0x002B0B34
	protected override void OnRefresh(object bVisible)
	{
		base.OnRefresh(bVisible);
		base.SetUiActive((bool)bVisible);
	}

	// Token: 0x0600BEC1 RID: 48833 RVA: 0x002B2949 File Offset: 0x002B0B49
	public override EItemGridComponentLayoutLevel GetLayoutLevel()
	{
		return EItemGridComponentLayoutLevel.Bottom;
	}

	// Token: 0x040055C4 RID: 21956
	private const string BG_COLOR = "D5A831FF";

	// Token: 0x040055C5 RID: 21957
	private const string TOP_COLOR = "FFFFFFFF";

	// Token: 0x02007EBF RID: 32447
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x040296F6 RID: 169718
		Sprite,
		// Token: 0x040296F7 RID: 169719
		TopSprite
	}
}
