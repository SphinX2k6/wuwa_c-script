using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using UnrealEngine;

// Token: 0x020016B7 RID: 5815
public class MailDropDownTitle : TitleItemBase<MailFilter>
{
	// Token: 0x0600E259 RID: 57945 RVA: 0x00426A2A File Offset: 0x00424C2A
	[NullableContext(1)]
	public MailDropDownTitle(UUIItem uiItem) : base(uiItem)
	{
	}

	// Token: 0x0600E25A RID: 57946 RVA: 0x00426A34 File Offset: 0x00424C34
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

	// Token: 0x0600E25B RID: 57947 RVA: 0x00426AA0 File Offset: 0x00424CA0
	[NullableContext(1)]
	public override void ShowTemp(MailFilter data, DropDownItemBase<MailFilter> selectedItemObj)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.Name, Array.Empty<object>());
		MailDropDownItem mailDropDownItem = selectedItemObj as MailDropDownItem;
		base.GetText(1).SetText(mailDropDownItem.GetTitleText(), true);
	}

	// Token: 0x020078A6 RID: 30886
	private class EComponents
	{
		// Token: 0x0402721B RID: 160283
		public const int TxtName = 0;

		// Token: 0x0402721C RID: 160284
		public const int TxtCount = 1;
	}
}
