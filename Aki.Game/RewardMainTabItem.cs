using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000813 RID: 2067
public class RewardMainTabItem : CommonTabItemBase, ITabViewRegister
{
	// Token: 0x06005DBD RID: 23997 RVA: 0x001E13C8 File Offset: 0x001DF5C8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggle))
		};
	}

	// Token: 0x06005DBE RID: 23998 RVA: 0x001E142F File Offset: 0x001DF62F
	protected override void OnStart()
	{
		this.SetRedDotVisible(false);
	}

	// Token: 0x06005DBF RID: 23999 RVA: 0x001E1438 File Offset: 0x001DF638
	[NullableContext(1)]
	public void RegisterViewModule(UiTabViewBase tabView)
	{
		tabView.AddUiTabViewBehavior<UiTabSequence>().SetRootItem(tabView);
	}

	// Token: 0x06005DC0 RID: 24000 RVA: 0x001E1446 File Offset: 0x001DF646
	public void SetRedDotVisible(bool bVisible)
	{
		base.GetItem(1).SetUIActive(bVisible);
	}

	// Token: 0x06005DC1 RID: 24001 RVA: 0x001E1455 File Offset: 0x001DF655
	[NullableContext(1)]
	protected override void OnUpdateTabIcon(string iconPath)
	{
	}

	// Token: 0x06005DC2 RID: 24002 RVA: 0x001E1457 File Offset: 0x001DF657
	protected override void OnSetToggleState(EToggleState state, bool bFire)
	{
		base.GetExtendToggle(0).SetToggleState(state, bFire, false, false);
	}

	// Token: 0x06005DC3 RID: 24003 RVA: 0x001E146A File Offset: 0x001DF66A
	[NullableContext(1)]
	protected override UUIExtendToggle GetTabToggle()
	{
		return base.GetExtendToggle(0);
	}

	// Token: 0x06005DC4 RID: 24004 RVA: 0x001E1473 File Offset: 0x001DF673
	protected void OnToggle(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked && this.SelectedCallBack != null)
		{
			this.SelectedCallBack(this.TabIndex);
		}
	}

	// Token: 0x04003E33 RID: 15923
	public int TabIndex;

	// Token: 0x02006B4B RID: 27467
	private class EComponentDefine
	{
		// Token: 0x04023483 RID: 144515
		public const int Toggle = 0;

		// Token: 0x04023484 RID: 144516
		public const int RedDot = 1;
	}
}
