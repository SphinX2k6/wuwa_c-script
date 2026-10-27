using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using UnrealEngine;

// Token: 0x020021D3 RID: 8659
public class MailDropDownTitle : TitleItemBase<MailFilter>
{
	// Token: 0x06010DC8 RID: 69064 RVA: 0x0041A14A File Offset: 0x0041834A
	[NullableContext(1)]
	public MailDropDownTitle(UUIItem uiItem) : base(uiItem)
	{
	}

	// Token: 0x06010DC9 RID: 69065 RVA: 0x0041A154 File Offset: 0x00418354
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06010DCA RID: 69066 RVA: 0x0041A1C0 File Offset: 0x004183C0
	[NullableContext(1)]
	public override void ShowTemp(MailFilter data, DropDownItemBase<MailFilter> selectedItemObj)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.Name, Array.Empty<object>());
		MailDropDownItem mailDropDownItem = selectedItemObj as MailDropDownItem;
		base.GetText(1).SetText(mailDropDownItem.GetTitleText(), true);
	}

	// Token: 0x0200871D RID: 34589
	private class EComponents
	{
		// Token: 0x0402BF02 RID: 179970
		public const int TxtName = 0;

		// Token: 0x0402BF03 RID: 179971
		public const int TxtCount = 1;
	}
}
