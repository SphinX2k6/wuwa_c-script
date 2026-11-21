using System;
using System.Collections.Generic;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000474 RID: 1140
public class FurnitureAreaPointItem : GridProxyAbstract<bool>
{
	// Token: 0x06003AC7 RID: 15047 RVA: 0x0014EF77 File Offset: 0x0014D177
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle))
		};
	}

	// Token: 0x06003AC8 RID: 15048 RVA: 0x0014EF9A File Offset: 0x0014D19A
	public override void Refresh(bool isSelected, bool isSelected2, int gridIndex)
	{
		this.IsSelected = isSelected;
		this.RefreshItemToggle();
	}

	// Token: 0x06003AC9 RID: 15049 RVA: 0x0014EFA9 File Offset: 0x0014D1A9
	public void RefreshItemToggle()
	{
		base.GetExtendToggle(0).SetToggleState(this.IsSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x04002F61 RID: 12129
	private bool IsSelected;
}
