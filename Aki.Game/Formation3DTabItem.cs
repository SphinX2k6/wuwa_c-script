using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020010BD RID: 4285
[NullableContext(1)]
[Nullable(0)]
internal class Formation3DTabItem : EditFormationTabItem
{
	// Token: 0x0600AA02 RID: 43522 RVA: 0x00321F99 File Offset: 0x00320199
	public Formation3DTabItem(Func<int, bool> isCurrentTab) : base(false)
	{
		this.IsCurrentTab = isCurrentTab;
	}

	// Token: 0x0600AA03 RID: 43523 RVA: 0x00321FA9 File Offset: 0x003201A9
	protected override void OnRefresh(CommonTabItemData data, bool isSelected, int gridIndex)
	{
		base.OnRefresh(data, isSelected, gridIndex);
		this.GetTabToggle().SetToggleStateForce(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		base.ShowTeamBattleTips(this.IsCurrentTab(gridIndex + 1));
	}

	// Token: 0x0600AA04 RID: 43524 RVA: 0x00321FDD File Offset: 0x003201DD
	public override void OnSelected(bool fireEvent)
	{
		this.GetTabToggle().SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
		if (fireEvent)
		{
			this.SelectedCallBack(base.GridIndex);
		}
	}

	// Token: 0x0600AA05 RID: 43525 RVA: 0x00322002 File Offset: 0x00320202
	public override void OnDeselected(bool fireEvent)
	{
		this.GetTabToggle().SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x040062AC RID: 25260
	private readonly Func<int, bool> IsCurrentTab;
}
