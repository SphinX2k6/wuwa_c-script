using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000817 RID: 2071
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RewardTargetTabItem : GridProxyAbstract<RewardTabData>
{
	// Token: 0x06005DE6 RID: 24038 RVA: 0x001E1AD4 File Offset: 0x001DFCD4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.OnTabToggle))
		};
	}

	// Token: 0x06005DE7 RID: 24039 RVA: 0x001E1B54 File Offset: 0x001DFD54
	public void SetToggleState(bool bSelect, bool bFire)
	{
		EToggleState state = bSelect ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(1).SetToggleState(state, bFire, false, false);
	}

	// Token: 0x06005DE8 RID: 24040 RVA: 0x001E1B7A File Offset: 0x001DFD7A
	private void SetRedDotVisible(bool bVisible)
	{
		base.GetItem(2).SetUIActive(bVisible);
	}

	// Token: 0x06005DE9 RID: 24041 RVA: 0x001E1B89 File Offset: 0x001DFD89
	public override void Refresh(RewardTabData data, bool isSelected, int gridIndex)
	{
		this.TabData = data;
		this.TabIndex = data.Index;
		if (data.NameTextId != null)
		{
			base.GetText(0).ShowTextNew(data.NameTextId);
		}
		this.RefreshRedDot();
	}

	// Token: 0x06005DEA RID: 24042 RVA: 0x001E1BC0 File Offset: 0x001DFDC0
	public void RefreshRedDot()
	{
		bool redDotVisible = this.TabData != null && this.TabData.RefreshRedDot != null && this.TabData.RefreshRedDot(this.TabIndex + 1);
		this.SetRedDotVisible(redDotVisible);
	}

	// Token: 0x06005DEB RID: 24043 RVA: 0x001E1C05 File Offset: 0x001DFE05
	private void OnTabToggle(EToggleState state)
	{
		if (this.TabData != null && this.TabData.ClickedCallback != null)
		{
			this.TabData.ClickedCallback(this.TabIndex);
		}
	}

	// Token: 0x04003E3B RID: 15931
	private RewardTabData TabData;

	// Token: 0x04003E3C RID: 15932
	private int TabIndex = -1;

	// Token: 0x02006B54 RID: 27476
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x040234A3 RID: 144547
		public const int Name = 0;

		// Token: 0x040234A4 RID: 144548
		public const int Toggle = 1;

		// Token: 0x040234A5 RID: 144549
		public const int RedDot = 2;
	}
}
