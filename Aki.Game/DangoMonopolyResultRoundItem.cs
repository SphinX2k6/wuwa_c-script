using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020006F4 RID: 1780
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class DangoMonopolyResultRoundItem : GridProxyAbstract<DangoMonopolyBoardData>
{
	// Token: 0x06005235 RID: 21045 RVA: 0x001B5DE8 File Offset: 0x001B3FE8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle))
		};
	}

	// Token: 0x06005236 RID: 21046 RVA: 0x001B5E50 File Offset: 0x001B4050
	public override void Refresh(DangoMonopolyBoardData data, bool isSelected, int gridIndex)
	{
		this.ItemData = data;
		UUIText text = base.GetText(1);
		if (text != null)
		{
			text.SetText(this.ItemData.GetPosition().ToString(), true);
		}
		UUIExtendToggle selfToggle = this.GetSelfToggle();
		if (selfToggle == null)
		{
			return;
		}
		selfToggle.SetToggleState(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x06005237 RID: 21047 RVA: 0x001B5EA5 File Offset: 0x001B40A5
	private void OnClickToggle(EToggleState toggleState)
	{
		if (toggleState == EToggleState.ETT_Checked)
		{
			IScrollViewDelegate<IGridProxy<DangoMonopolyBoardData>, DangoMonopolyBoardData> scrollViewDelegate = base.ScrollViewDelegate;
			if (scrollViewDelegate == null)
			{
				return;
			}
			scrollViewDelegate.SelectGridProxy(base.GridIndex, base.DisplayIndex, false);
		}
	}

	// Token: 0x06005238 RID: 21048 RVA: 0x001B5EC8 File Offset: 0x001B40C8
	public override void OnSelected(bool fireEvent)
	{
		UUIExtendToggle selfToggle = this.GetSelfToggle();
		if (selfToggle != null)
		{
			selfToggle.SetToggleState(EToggleState.ETT_Checked, false, false, false);
		}
		Action<DangoMonopolyBoardData> clickCallBack = this.ClickCallBack;
		if (clickCallBack == null)
		{
			return;
		}
		clickCallBack(this.ItemData);
	}

	// Token: 0x06005239 RID: 21049 RVA: 0x001B5EF6 File Offset: 0x001B40F6
	public override void OnDeselected(bool fireEvent)
	{
		UUIExtendToggle selfToggle = this.GetSelfToggle();
		if (selfToggle == null)
		{
			return;
		}
		selfToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x0600523A RID: 21050 RVA: 0x001B5F0D File Offset: 0x001B410D
	public UUIExtendToggle GetSelfToggle()
	{
		return base.GetExtendToggle(0);
	}

	// Token: 0x04003A3C RID: 14908
	private DangoMonopolyBoardData ItemData;

	// Token: 0x04003A3D RID: 14909
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<DangoMonopolyBoardData> ClickCallBack;

	// Token: 0x020069D0 RID: 27088
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04022D5C RID: 142684
		ToggleSelf,
		// Token: 0x04022D5D RID: 142685
		TxtIndex
	}
}
