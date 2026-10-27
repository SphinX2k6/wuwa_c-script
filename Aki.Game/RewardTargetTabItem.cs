using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001363 RID: 4963
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RewardTargetTabItem : GridProxyAbstract<RewardTabData>
{
	// Token: 0x06008A4B RID: 35403 RVA: 0x001D8C78 File Offset: 0x001D6E78
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

	// Token: 0x06008A4C RID: 35404 RVA: 0x001D8CF8 File Offset: 0x001D6EF8
	public void SetToggleState(bool bSelect, bool bFire)
	{
		EToggleState state = bSelect ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(1).SetToggleState(state, bFire, false, false);
	}

	// Token: 0x06008A4D RID: 35405 RVA: 0x001D8D1E File Offset: 0x001D6F1E
	private void SetRedDotVisible(bool bVisible)
	{
		base.GetItem(2).SetUIActive(bVisible);
	}

	// Token: 0x06008A4E RID: 35406 RVA: 0x001D8D2D File Offset: 0x001D6F2D
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

	// Token: 0x06008A4F RID: 35407 RVA: 0x001D8D64 File Offset: 0x001D6F64
	public void RefreshRedDot()
	{
		bool redDotVisible = this.TabData != null && this.TabData.RefreshRedDot != null && this.TabData.RefreshRedDot(this.TabIndex + 1);
		this.SetRedDotVisible(redDotVisible);
	}

	// Token: 0x06008A50 RID: 35408 RVA: 0x001D8DA9 File Offset: 0x001D6FA9
	private void OnTabToggle(EToggleState state)
	{
		if (this.TabData != null && this.TabData.ClickedCallback != null)
		{
			this.TabData.ClickedCallback(this.TabIndex);
		}
	}

	// Token: 0x04003DA3 RID: 15779
	private RewardTabData TabData;

	// Token: 0x04003DA4 RID: 15780
	private int TabIndex = -1;

	// Token: 0x020079CA RID: 31178
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x04028176 RID: 164214
		public const int Name = 0;

		// Token: 0x04028177 RID: 164215
		public const int Toggle = 1;

		// Token: 0x04028178 RID: 164216
		public const int RedDot = 2;
	}
}
