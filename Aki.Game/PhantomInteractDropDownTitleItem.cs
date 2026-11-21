using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02001959 RID: 6489
public class PhantomInteractDropDownTitleItem : TitleItemBase<int>
{
	// Token: 0x06010068 RID: 65640 RVA: 0x004AC3EE File Offset: 0x004AA5EE
	[NullableContext(1)]
	public PhantomInteractDropDownTitleItem(UUIItem uiItem) : base(uiItem)
	{
	}

	// Token: 0x06010069 RID: 65641 RVA: 0x004AC3F7 File Offset: 0x004AA5F7
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText))
		};
	}

	// Token: 0x0601006A RID: 65642 RVA: 0x004AC41C File Offset: 0x004AA61C
	[NullableContext(1)]
	public override void ShowTemp(int data, DropDownItemBase<int> selectedItemObj)
	{
		UUIText text = base.GetText(0);
		string textStringId = PhantomInteractDropDownItemOptionTextId.TextIds[data];
		LguiUtil.Instance.SetLocalTextNew(text, textStringId, Array.Empty<object>());
	}

	// Token: 0x02007B75 RID: 31605
	private enum EComponent
	{
		// Token: 0x04027FC7 RID: 163783
		TxtOption
	}
}
