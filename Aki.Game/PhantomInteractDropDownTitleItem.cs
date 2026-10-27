using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002474 RID: 9332
public class PhantomInteractDropDownTitleItem : TitleItemBase<int>
{
	// Token: 0x06012BB0 RID: 76720 RVA: 0x0049EC82 File Offset: 0x0049CE82
	[NullableContext(1)]
	public PhantomInteractDropDownTitleItem(UUIItem uiItem) : base(uiItem)
	{
	}

	// Token: 0x06012BB1 RID: 76721 RVA: 0x0049EC8B File Offset: 0x0049CE8B
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText))
		};
	}

	// Token: 0x06012BB2 RID: 76722 RVA: 0x0049ECB0 File Offset: 0x0049CEB0
	[NullableContext(1)]
	public override void ShowTemp(int data, DropDownItemBase<int> selectedItemObj)
	{
		UUIText text = base.GetText(0);
		string textStringId = PhantomInteractDropDownItemOptionTextId.TextIds[data];
		LguiUtil.Instance.SetLocalTextNew(text, textStringId, Array.Empty<object>());
	}

	// Token: 0x020089EE RID: 35310
	private enum EComponent
	{
		// Token: 0x0402CCB1 RID: 183473
		TxtOption
	}
}
