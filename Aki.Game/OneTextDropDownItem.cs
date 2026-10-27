using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x0200181E RID: 6174
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class OneTextDropDownItem : DropDownItemBase<TableTextArgNew>
{
	// Token: 0x0600B51D RID: 46365 RVA: 0x0028E295 File Offset: 0x0028C495
	public OneTextDropDownItem(UUIItem uiItem) : base(uiItem)
	{
	}

	// Token: 0x0600B51E RID: 46366 RVA: 0x0028E2A0 File Offset: 0x0028C4A0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600B51F RID: 46367 RVA: 0x0028E309 File Offset: 0x0028C509
	[NullableContext(2)]
	protected override UUIExtendToggle GetDropDownToggle()
	{
		return base.GetExtendToggle(0);
	}

	// Token: 0x0600B520 RID: 46368 RVA: 0x0028E312 File Offset: 0x0028C512
	protected override void OnShowDropDownItemBase(TableTextArgNew tableText)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), tableText.TextKey, tableText.Params);
	}

	// Token: 0x02007E0A RID: 32266
	[NullableContext(0)]
	private class ECompDefine
	{
		// Token: 0x040293FC RID: 168956
		public const int Toggle = 0;

		// Token: 0x040293FD RID: 168957
		public const int Content = 1;
	}
}
