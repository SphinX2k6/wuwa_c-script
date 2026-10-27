using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020024C0 RID: 9408
[NullableContext(1)]
[Nullable(0)]
internal class VisionEquipmentRecommendItemTop : UiPanelBase
{
	// Token: 0x06012DDC RID: 77276 RVA: 0x004A8A64 File Offset: 0x004A6C64
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

	// Token: 0x06012DDD RID: 77277 RVA: 0x004A8ACB File Offset: 0x004A6CCB
	private void OnClickToggle(EToggleState state)
	{
		Action<EToggleState> onToggleClickCallback = this.OnToggleClickCallback;
		if (onToggleClickCallback == null)
		{
			return;
		}
		onToggleClickCallback(state);
	}

	// Token: 0x06012DDE RID: 77278 RVA: 0x004A8ADE File Offset: 0x004A6CDE
	public void SetToggleState(EToggleState state)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleState(state, false, false, false);
	}

	// Token: 0x06012DDF RID: 77279 RVA: 0x004A8AF6 File Offset: 0x004A6CF6
	protected override void OnStart()
	{
		this.Layout = new GenericLayout<FetterIconItem, IVisionNewRecommendFetterItemData>(base.GetLayoutBase(1), new Func<FetterIconItem>(this.InitElementItem), null, false, true);
	}

	// Token: 0x06012DE0 RID: 77280 RVA: 0x004A8B19 File Offset: 0x004A6D19
	private FetterIconItem InitElementItem()
	{
		return new FetterIconItem();
	}

	// Token: 0x06012DE1 RID: 77281 RVA: 0x004A8B20 File Offset: 0x004A6D20
	public void Refresh(List<IVisionNewRecommendFetterItemData> data)
	{
		GenericLayout<FetterIconItem, IVisionNewRecommendFetterItemData> layout = this.Layout;
		if (layout == null)
		{
			return;
		}
		layout.RefreshByData(data, null, false);
	}

	// Token: 0x04008E30 RID: 36400
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<FetterIconItem, IVisionNewRecommendFetterItemData> Layout;

	// Token: 0x04008E31 RID: 36401
	[Nullable(2)]
	public Action<EToggleState> OnToggleClickCallback;
}
