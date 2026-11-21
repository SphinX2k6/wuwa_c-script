using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x02000E49 RID: 3657
public class SmallItemGridRedDotNumComponent : SmallItemGridComponent
{
	// Token: 0x06009327 RID: 37671 RVA: 0x002BE3B8 File Offset: 0x002BC5B8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 1;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int index = 0;
		*span[index] = new ValueTuple<int, Type>(0, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06009328 RID: 37672 RVA: 0x002BE400 File Offset: 0x002BC600
	[NullableContext(2)]
	protected override void OnRefresh(object tempData)
	{
		if (tempData is int)
		{
			int num = (int)tempData;
			if (num > 0)
			{
				base.GetText(0).SetText(num.ToString(), true);
				this.SetActive(true);
				return;
			}
		}
		this.SetActive(false);
	}

	// Token: 0x06009329 RID: 37673 RVA: 0x002BE443 File Offset: 0x002BC643
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemRedDotNum";
	}

	// Token: 0x0600932A RID: 37674 RVA: 0x002BE44A File Offset: 0x002BC64A
	public override EItemGridComponentLayoutLevel GetLayoutLevel()
	{
		return EItemGridComponentLayoutLevel.Top;
	}

	// Token: 0x02007059 RID: 28761
	private enum EChildType
	{
		// Token: 0x04024A49 RID: 150089
		TxtContent
	}
}
