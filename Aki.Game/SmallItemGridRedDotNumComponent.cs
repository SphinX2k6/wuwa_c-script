using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x0200198C RID: 6540
public class SmallItemGridRedDotNumComponent : SmallItemGridComponent
{
	// Token: 0x0600BF1F RID: 48927 RVA: 0x002B3434 File Offset: 0x002B1634
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

	// Token: 0x0600BF20 RID: 48928 RVA: 0x002B347C File Offset: 0x002B167C
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

	// Token: 0x0600BF21 RID: 48929 RVA: 0x002B34BF File Offset: 0x002B16BF
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemRedDotNum";
	}

	// Token: 0x0600BF22 RID: 48930 RVA: 0x002B34C6 File Offset: 0x002B16C6
	public override EItemGridComponentLayoutLevel GetLayoutLevel()
	{
		return EItemGridComponentLayoutLevel.Top;
	}

	// Token: 0x02007ECA RID: 32458
	private enum EChildType
	{
		// Token: 0x0402970C RID: 169740
		TxtContent
	}
}
