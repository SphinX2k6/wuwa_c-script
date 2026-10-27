using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x0200198A RID: 6538
[NullableContext(1)]
[Nullable(0)]
public class SmallItemGridReceivedComponent : SmallItemGridComponent
{
	// Token: 0x0600BF16 RID: 48918 RVA: 0x002B338C File Offset: 0x002B158C
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

	// Token: 0x0600BF17 RID: 48919 RVA: 0x002B33D4 File Offset: 0x002B15D4
	protected override void OnRefresh(object bVisible)
	{
		this.SetActive((bVisible as bool?).GetValueOrDefault());
	}

	// Token: 0x0600BF18 RID: 48920 RVA: 0x002B33FA File Offset: 0x002B15FA
	public void SetSpriteColor(string hexColor)
	{
		base.GetSprite(0).SetColor(FColor.FromHex(hexColor));
	}

	// Token: 0x0600BF19 RID: 48921 RVA: 0x002B340E File Offset: 0x002B160E
	protected override string GetResourceId()
	{
		return "UiItem_ItemBReceived";
	}

	// Token: 0x0600BF1A RID: 48922 RVA: 0x002B3415 File Offset: 0x002B1615
	public override EItemGridComponentLayoutLevel GetLayoutLevel()
	{
		return EItemGridComponentLayoutLevel.Top;
	}

	// Token: 0x02007EC9 RID: 32457
	[NullableContext(0)]
	private class EChildType
	{
		// Token: 0x0402970A RID: 169738
		public const int Sprite = 0;
	}
}
