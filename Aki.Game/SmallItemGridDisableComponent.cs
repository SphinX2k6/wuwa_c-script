using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x02000E31 RID: 3633
[NullableContext(1)]
[Nullable(0)]
public class SmallItemGridDisableComponent : SmallItemGridComponent
{
	// Token: 0x060092D5 RID: 37589 RVA: 0x002BDB04 File Offset: 0x002BBD04
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

	// Token: 0x060092D6 RID: 37590 RVA: 0x002BDB4C File Offset: 0x002BBD4C
	protected override void OnRefresh(object bVisible)
	{
		this.SetActive((bVisible as bool?).GetValueOrDefault());
	}

	// Token: 0x060092D7 RID: 37591 RVA: 0x002BDB74 File Offset: 0x002BBD74
	public void SetSpriteColor(string hexColor)
	{
		FColor color = FColor.FromHex(hexColor);
		base.GetSprite(0).SetColor(color);
	}

	// Token: 0x060092D8 RID: 37592 RVA: 0x002BDB95 File Offset: 0x002BBD95
	protected override string GetResourceId()
	{
		return "UiItem_SmallItemDark";
	}

	// Token: 0x060092D9 RID: 37593 RVA: 0x002BDB9C File Offset: 0x002BBD9C
	public override EItemGridComponentLayoutLevel GetLayoutLevel()
	{
		return EItemGridComponentLayoutLevel.Bottom;
	}

	// Token: 0x02007050 RID: 28752
	[NullableContext(0)]
	private class EChildType
	{
		// Token: 0x04024A38 RID: 150072
		public const int Sprite = 0;
	}
}
