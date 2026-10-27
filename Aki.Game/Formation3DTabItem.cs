using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02001BFE RID: 7166
[NullableContext(1)]
[Nullable(0)]
internal class Formation3DTabItem : EditFormationTabItem
{
	// Token: 0x0600D5EF RID: 54767 RVA: 0x00316CC1 File Offset: 0x00314EC1
	public Formation3DTabItem(Func<int, bool> isCurrentTab) : base(false)
	{
		this.IsCurrentTab = isCurrentTab;
	}

	// Token: 0x0600D5F0 RID: 54768 RVA: 0x00316CD1 File Offset: 0x00314ED1
	protected override void OnRefresh(CommonTabItemData data, bool isSelected, int gridIndex)
	{
		base.OnRefresh(data, isSelected, gridIndex);
		this.GetTabToggle().SetToggleStateForce(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		base.ShowTeamBattleTips(this.IsCurrentTab(gridIndex + 1));
	}

	// Token: 0x0600D5F1 RID: 54769 RVA: 0x00316D05 File Offset: 0x00314F05
	public override void OnSelected(bool fireEvent)
	{
		this.GetTabToggle().SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
		if (fireEvent)
		{
			this.SelectedCallBack(base.GridIndex);
		}
	}

	// Token: 0x0600D5F2 RID: 54770 RVA: 0x00316D2A File Offset: 0x00314F2A
	public override void OnDeselected(bool fireEvent)
	{
		this.GetTabToggle().SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x040061DA RID: 25050
	private readonly Func<int, bool> IsCurrentTab;
}
