using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200135F RID: 4959
public class RewardMainTabItem : CommonTabItemBase, ITabViewRegister
{
	// Token: 0x06008A22 RID: 35362 RVA: 0x001D856C File Offset: 0x001D676C
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

	// Token: 0x06008A23 RID: 35363 RVA: 0x001D85D3 File Offset: 0x001D67D3
	protected override void OnStart()
	{
		this.SetRedDotVisible(false);
	}

	// Token: 0x06008A24 RID: 35364 RVA: 0x001D85DC File Offset: 0x001D67DC
	[NullableContext(1)]
	public void RegisterViewModule(UiTabViewBase tabView)
	{
		tabView.AddUiTabViewBehavior<UiTabSequence>().SetRootItem(tabView);
	}

	// Token: 0x06008A25 RID: 35365 RVA: 0x001D85EA File Offset: 0x001D67EA
	public void SetRedDotVisible(bool bVisible)
	{
		base.GetItem(1).SetUIActive(bVisible);
	}

	// Token: 0x06008A26 RID: 35366 RVA: 0x001D85F9 File Offset: 0x001D67F9
	[NullableContext(1)]
	protected override void OnUpdateTabIcon(string iconPath)
	{
	}

	// Token: 0x06008A27 RID: 35367 RVA: 0x001D85FB File Offset: 0x001D67FB
	protected override void OnSetToggleState(EToggleState state, bool bFire)
	{
		base.GetExtendToggle(0).SetToggleState(state, bFire, false, false);
	}

	// Token: 0x06008A28 RID: 35368 RVA: 0x001D860E File Offset: 0x001D680E
	[NullableContext(1)]
	protected override UUIExtendToggle GetTabToggle()
	{
		return base.GetExtendToggle(0);
	}

	// Token: 0x06008A29 RID: 35369 RVA: 0x001D8617 File Offset: 0x001D6817
	protected void OnToggle(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked && this.SelectedCallBack != null)
		{
			this.SelectedCallBack(this.TabIndex);
		}
	}

	// Token: 0x04003D9B RID: 15771
	public int TabIndex;

	// Token: 0x020079C1 RID: 31169
	private class EComponentDefine
	{
		// Token: 0x04028156 RID: 164182
		public const int Toggle = 0;

		// Token: 0x04028157 RID: 164183
		public const int RedDot = 1;
	}
}
