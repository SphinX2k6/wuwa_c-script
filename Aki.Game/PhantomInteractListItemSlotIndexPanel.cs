using System;
using System.Collections.Generic;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001966 RID: 6502
public class PhantomInteractListItemSlotIndexPanel : UiPanelBase
{
	// Token: 0x060100BF RID: 65727 RVA: 0x004AD9C2 File Offset: 0x004ABBC2
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText))
		};
	}

	// Token: 0x060100C0 RID: 65728 RVA: 0x004AD9E8 File Offset: 0x004ABBE8
	public void SetIndex(int index)
	{
		UUIText text = base.GetText(0);
		if (text != null)
		{
			text.SetText(index.ToString(), true);
		}
	}

	// Token: 0x02007B7E RID: 31614
	private enum EComponent
	{
		// Token: 0x04027FF7 RID: 163831
		TxtNum
	}
}
