using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using UnrealEngine;

// Token: 0x020021D2 RID: 8658
[NullableContext(1)]
[Nullable(0)]
public abstract class MailDropDownItem : DropDownItemBase<MailFilter>
{
	// Token: 0x06010DC2 RID: 69058 RVA: 0x0041A091 File Offset: 0x00418291
	public MailDropDownItem(UUIItem uiItem) : base(uiItem)
	{
	}

	// Token: 0x06010DC3 RID: 69059 RVA: 0x0041A09C File Offset: 0x0041829C
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

	// Token: 0x06010DC4 RID: 69060 RVA: 0x0041A131 File Offset: 0x00418331
	[NullableContext(2)]
	protected override UUIExtendToggle GetDropDownToggle()
	{
		return base.GetExtendToggle(0);
	}

	// Token: 0x06010DC5 RID: 69061 RVA: 0x0041A13A File Offset: 0x0041833A
	protected void SetMailCount(string count)
	{
		base.GetText(2).SetText(count, true);
	}

	// Token: 0x06010DC6 RID: 69062
	public abstract string GetTitleText();

	// Token: 0x06010DC7 RID: 69063
	public abstract MailData[] GetFilteredMailList();
}
