using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using UnrealEngine;

// Token: 0x020016B6 RID: 5814
[NullableContext(1)]
[Nullable(0)]
public abstract class MailDropDownItem : DropDownItemBase<MailFilter>
{
	// Token: 0x0600E253 RID: 57939 RVA: 0x00426971 File Offset: 0x00424B71
	public MailDropDownItem(UUIItem uiItem) : base(uiItem)
	{
	}

	// Token: 0x0600E254 RID: 57940 RVA: 0x0042697C File Offset: 0x00424B7C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>();
	}

	// Token: 0x0600E255 RID: 57941 RVA: 0x00426A11 File Offset: 0x00424C11
	[NullableContext(2)]
	protected override UUIExtendToggle GetDropDownToggle()
	{
		return base.GetExtendToggle(0);
	}

	// Token: 0x0600E256 RID: 57942 RVA: 0x00426A1A File Offset: 0x00424C1A
	protected void SetMailCount(string count)
	{
		base.GetText(2).SetText(count, true);
	}

	// Token: 0x0600E257 RID: 57943
	public abstract string GetTitleText();

	// Token: 0x0600E258 RID: 57944
	public abstract MailData[] GetFilteredMailList();
}
