using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001240 RID: 4672
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class DangoMonopolyResultRoundItem : GridProxyAbstract<DangoMonopolyBoardData>
{
	// Token: 0x06007E9E RID: 32414 RVA: 0x001AD130 File Offset: 0x001AB330
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

	// Token: 0x06007E9F RID: 32415 RVA: 0x001AD198 File Offset: 0x001AB398
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

	// Token: 0x06007EA0 RID: 32416 RVA: 0x001AD1ED File Offset: 0x001AB3ED
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

	// Token: 0x06007EA1 RID: 32417 RVA: 0x001AD210 File Offset: 0x001AB410
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

	// Token: 0x06007EA2 RID: 32418 RVA: 0x001AD23E File Offset: 0x001AB43E
	public override void OnDeselected(bool fireEvent)
	{
		UUIExtendToggle selfToggle = this.GetSelfToggle();
		if (selfToggle == null)
		{
			return;
		}
		selfToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x06007EA3 RID: 32419 RVA: 0x001AD255 File Offset: 0x001AB455
	public UUIExtendToggle GetSelfToggle()
	{
		return base.GetExtendToggle(0);
	}

	// Token: 0x040039A4 RID: 14756
	private DangoMonopolyBoardData ItemData;

	// Token: 0x040039A5 RID: 14757
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<DangoMonopolyBoardData> ClickCallBack;

	// Token: 0x02007845 RID: 30789
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04027A2B RID: 162347
		ToggleSelf,
		// Token: 0x04027A2C RID: 162348
		TxtIndex
	}
}
