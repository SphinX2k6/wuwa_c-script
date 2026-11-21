using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020019A7 RID: 6567
[NullableContext(1)]
[Nullable(0)]
internal class VisionEquipmentRecommendItemTop : UiPanelBase
{
	// Token: 0x0601029C RID: 66204 RVA: 0x004B6618 File Offset: 0x004B4818
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUILayoutBase))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle))
		};
	}

	// Token: 0x0601029D RID: 66205 RVA: 0x004B667F File Offset: 0x004B487F
	private void OnClickToggle(EToggleState state)
	{
		Action<EToggleState> onToggleClickCallback = this.OnToggleClickCallback;
		if (onToggleClickCallback == null)
		{
			return;
		}
		onToggleClickCallback(state);
	}

	// Token: 0x0601029E RID: 66206 RVA: 0x004B6692 File Offset: 0x004B4892
	public void SetToggleState(EToggleState state)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleState(state, false, false, false);
	}

	// Token: 0x0601029F RID: 66207 RVA: 0x004B66AA File Offset: 0x004B48AA
	protected override void OnStart()
	{
		this.Layout = new GenericLayout<FetterIconItem, IVisionNewRecommendFetterItemData>(base.GetLayoutBase(1), new Func<FetterIconItem>(this.InitElementItem), null, false, true);
	}

	// Token: 0x060102A0 RID: 66208 RVA: 0x004B66CD File Offset: 0x004B48CD
	private FetterIconItem InitElementItem()
	{
		return new FetterIconItem();
	}

	// Token: 0x060102A1 RID: 66209 RVA: 0x004B66D4 File Offset: 0x004B48D4
	public void Refresh(List<IVisionNewRecommendFetterItemData> data)
	{
		GenericLayout<FetterIconItem, IVisionNewRecommendFetterItemData> layout = this.Layout;
		if (layout == null)
		{
			return;
		}
		layout.RefreshByData(data, null, false);
	}

	// Token: 0x04008F7A RID: 36730
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<FetterIconItem, IVisionNewRecommendFetterItemData> Layout;

	// Token: 0x04008F7B RID: 36731
	[Nullable(2)]
	public Action<EToggleState> OnToggleClickCallback;
}
