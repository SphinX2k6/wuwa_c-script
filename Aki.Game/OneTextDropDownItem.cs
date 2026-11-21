using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x02000CD7 RID: 3287
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class OneTextDropDownItem : DropDownItemBase<TableTextArgNew>
{
	// Token: 0x06008908 RID: 35080 RVA: 0x002989B5 File Offset: 0x00296BB5
	public OneTextDropDownItem(UUIItem uiItem) : base(uiItem)
	{
	}

	// Token: 0x06008909 RID: 35081 RVA: 0x002989C0 File Offset: 0x00296BC0
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

	// Token: 0x0600890A RID: 35082 RVA: 0x00298A29 File Offset: 0x00296C29
	[NullableContext(2)]
	protected override UUIExtendToggle GetDropDownToggle()
	{
		return base.GetExtendToggle(0);
	}

	// Token: 0x0600890B RID: 35083 RVA: 0x00298A32 File Offset: 0x00296C32
	protected override void OnShowDropDownItemBase(TableTextArgNew tableText)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), tableText.TextKey, tableText.Params);
	}

	// Token: 0x02006F90 RID: 28560
	[NullableContext(0)]
	private class ECompDefine
	{
		// Token: 0x04024727 RID: 149287
		public const int Toggle = 0;

		// Token: 0x04024728 RID: 149288
		public const int Content = 1;
	}
}
