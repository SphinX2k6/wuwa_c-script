using System;
using System.Collections.Generic;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002481 RID: 9345
public class PhantomInteractListItemSlotIndexPanel : UiPanelBase
{
	// Token: 0x06012C08 RID: 76808 RVA: 0x004A026A File Offset: 0x0049E46A
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText))
		};
	}

	// Token: 0x06012C09 RID: 76809 RVA: 0x004A0290 File Offset: 0x0049E490
	public void SetIndex(int index)
	{
		UUIText text = base.GetText(0);
		if (text != null)
		{
			text.SetText(index.ToString(), true);
		}
	}

	// Token: 0x020089F7 RID: 35319
	private enum EComponent
	{
		// Token: 0x0402CCE1 RID: 183521
		TxtNum
	}
}
