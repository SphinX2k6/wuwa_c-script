using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002473 RID: 9331
public class PhantomInteractDropDownItem : DropDownItemBase<int>
{
	// Token: 0x06012BAC RID: 76716 RVA: 0x0049EC08 File Offset: 0x0049CE08
	[NullableContext(1)]
	public PhantomInteractDropDownItem(UUIItem uiItem) : base(uiItem)
	{
	}

	// Token: 0x06012BAD RID: 76717 RVA: 0x0049EC11 File Offset: 0x0049CE11
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
	}

	// Token: 0x06012BAE RID: 76718 RVA: 0x0049EC4A File Offset: 0x0049CE4A
	[NullableContext(2)]
	protected override UUIExtendToggle GetDropDownToggle()
	{
		return base.GetExtendToggle(0);
	}

	// Token: 0x06012BAF RID: 76719 RVA: 0x0049EC54 File Offset: 0x0049CE54
	protected override void OnShowDropDownItemBase(int data)
	{
		UUIText text = base.GetText(1);
		string textStringId = PhantomInteractDropDownItemOptionTextId.TextIds[data];
		LguiUtil.Instance.SetLocalTextNew(text, textStringId, Array.Empty<object>());
	}

	// Token: 0x020089ED RID: 35309
	private enum EComponent
	{
		// Token: 0x0402CCAE RID: 183470
		TogOption,
		// Token: 0x0402CCAF RID: 183471
		TxtOption
	}
}
