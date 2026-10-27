using System;
using System.Collections.Generic;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020012BF RID: 4799
public class LordGymPageDot : GridProxyAbstract<int>
{
	// Token: 0x060083D3 RID: 33747 RVA: 0x001C138A File Offset: 0x001BF58A
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle))
		};
	}

	// Token: 0x060083D4 RID: 33748 RVA: 0x001C13AD File Offset: 0x001BF5AD
	public override void Refresh(int data, bool isSelected, int gridIndex)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x060083D5 RID: 33749 RVA: 0x001C13CA File Offset: 0x001BF5CA
	public override void OnSelected(bool fireEvent)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
	}

	// Token: 0x060083D6 RID: 33750 RVA: 0x001C13E1 File Offset: 0x001BF5E1
	public override void OnDeselected(bool fireEvent)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
	}
}
