using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x02000E47 RID: 3655
[NullableContext(1)]
[Nullable(0)]
public class SmallItemGridReceivedComponent : SmallItemGridComponent
{
	// Token: 0x0600931E RID: 37662 RVA: 0x002BE310 File Offset: 0x002BC510
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

	// Token: 0x0600931F RID: 37663 RVA: 0x002BE358 File Offset: 0x002BC558
	protected override void OnRefresh(object bVisible)
	{
		this.SetActive((bVisible as bool?).GetValueOrDefault());
	}

	// Token: 0x06009320 RID: 37664 RVA: 0x002BE37E File Offset: 0x002BC57E
	public void SetSpriteColor(string hexColor)
	{
		base.GetSprite(0).SetColor(FColor.FromHex(hexColor));
	}

	// Token: 0x06009321 RID: 37665 RVA: 0x002BE392 File Offset: 0x002BC592
	protected override string GetResourceId()
	{
		return "UiItem_ItemBReceived";
	}

	// Token: 0x06009322 RID: 37666 RVA: 0x002BE399 File Offset: 0x002BC599
	public override EItemGridComponentLayoutLevel GetLayoutLevel()
	{
		return EItemGridComponentLayoutLevel.Top;
	}

	// Token: 0x02007058 RID: 28760
	[NullableContext(0)]
	private class EChildType
	{
		// Token: 0x04024A47 RID: 150087
		public const int Sprite = 0;
	}
}
