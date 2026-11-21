using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02001958 RID: 6488
public class PhantomInteractDropDownItem : DropDownItemBase<int>
{
	// Token: 0x06010064 RID: 65636 RVA: 0x004AC374 File Offset: 0x004AA574
	[NullableContext(1)]
	public PhantomInteractDropDownItem(UUIItem uiItem) : base(uiItem)
	{
	}

	// Token: 0x06010065 RID: 65637 RVA: 0x004AC37D File Offset: 0x004AA57D
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
	}

	// Token: 0x06010066 RID: 65638 RVA: 0x004AC3B6 File Offset: 0x004AA5B6
	[NullableContext(2)]
	protected override UUIExtendToggle GetDropDownToggle()
	{
		return base.GetExtendToggle(0);
	}

	// Token: 0x06010067 RID: 65639 RVA: 0x004AC3C0 File Offset: 0x004AA5C0
	protected override void OnShowDropDownItemBase(int data)
	{
		UUIText text = base.GetText(1);
		string textStringId = PhantomInteractDropDownItemOptionTextId.TextIds[data];
		LguiUtil.Instance.SetLocalTextNew(text, textStringId, Array.Empty<object>());
	}

	// Token: 0x02007B74 RID: 31604
	private enum EComponent
	{
		// Token: 0x04027FC4 RID: 163780
		TogOption,
		// Token: 0x04027FC5 RID: 163781
		TxtOption
	}
}
