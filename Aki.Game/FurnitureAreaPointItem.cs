using System;
using System.Collections.Generic;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000FBF RID: 4031
public class FurnitureAreaPointItem : GridProxyAbstract<bool>
{
	// Token: 0x0600672F RID: 26415 RVA: 0x001466B3 File Offset: 0x001448B3
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle))
		};
	}

	// Token: 0x06006730 RID: 26416 RVA: 0x001466D6 File Offset: 0x001448D6
	public override void Refresh(bool isSelected, bool isSelected2, int gridIndex)
	{
		this.IsSelected = isSelected;
		this.RefreshItemToggle();
	}

	// Token: 0x06006731 RID: 26417 RVA: 0x001466E5 File Offset: 0x001448E5
	public void RefreshItemToggle()
	{
		base.GetExtendToggle(0).SetToggleState(this.IsSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x04002EC8 RID: 11976
	private bool IsSelected;
}
