using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x02000E2D RID: 3629
[NullableContext(1)]
[Nullable(0)]
public class SmallItemGridCurrentEquipmentComponent : SmallItemGridVisibleComponent
{
	// Token: 0x060092C5 RID: 37573 RVA: 0x002BD808 File Offset: 0x002BBA08
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

	// Token: 0x060092C6 RID: 37574 RVA: 0x002BD874 File Offset: 0x002BBA74
	protected override void OnStart()
	{
		FColor color = FColor.FromHex("D5A831FF");
		base.GetSprite(0).SetColor(color);
		FColor color2 = FColor.FromHex("FFFFFFFF");
		base.GetSprite(1).SetColor(color2);
	}

	// Token: 0x060092C7 RID: 37575 RVA: 0x002BD8B1 File Offset: 0x002BBAB1
	[NullableContext(2)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemSelTick";
	}

	// Token: 0x060092C8 RID: 37576 RVA: 0x002BD8B8 File Offset: 0x002BBAB8
	protected override void OnRefresh(object bVisible)
	{
		base.OnRefresh(bVisible);
		base.SetUiActive((bool)bVisible);
	}

	// Token: 0x060092C9 RID: 37577 RVA: 0x002BD8CD File Offset: 0x002BBACD
	public override EItemGridComponentLayoutLevel GetLayoutLevel()
	{
		return EItemGridComponentLayoutLevel.Bottom;
	}

	// Token: 0x04005671 RID: 22129
	private const string BG_COLOR = "D5A831FF";

	// Token: 0x04005672 RID: 22130
	private const string TOP_COLOR = "FFFFFFFF";

	// Token: 0x0200704E RID: 28750
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04024A33 RID: 150067
		Sprite,
		// Token: 0x04024A34 RID: 150068
		TopSprite
	}
}
