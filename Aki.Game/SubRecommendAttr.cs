using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020024B2 RID: 9394
[NullableContext(1)]
[Nullable(0)]
internal class SubRecommendAttr : UiPanelBase
{
	// Token: 0x06012DB5 RID: 77237 RVA: 0x004A8098 File Offset: 0x004A6298
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIExtendToggle))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(2, new Action<EToggleState>(this.OnClickToggleAll))
		};
	}

	// Token: 0x06012DB6 RID: 77238 RVA: 0x004A8115 File Offset: 0x004A6315
	protected override void OnStart()
	{
		this.Layout = new GenericLayout<AttrContent, RecommendItemData>(base.GetVerticalLayout(0), new Func<AttrContent>(this.InitItem), null, false, true);
	}

	// Token: 0x06012DB7 RID: 77239 RVA: 0x004A8138 File Offset: 0x004A6338
	private AttrContent InitItem()
	{
		return new AttrContent();
	}

	// Token: 0x06012DB8 RID: 77240 RVA: 0x004A813F File Offset: 0x004A633F
	private void OnClickToggleAll(EToggleState state)
	{
		Action<EToggleState> onToggleAllCallback = this.OnToggleAllCallback;
		if (onToggleAllCallback == null)
		{
			return;
		}
		onToggleAllCallback(state);
	}

	// Token: 0x06012DB9 RID: 77241 RVA: 0x004A8152 File Offset: 0x004A6352
	public void SetToggleAllState(bool isAllSelected)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(2);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleState(isAllSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x06012DBA RID: 77242 RVA: 0x004A8170 File Offset: 0x004A6370
	public void Refresh(List<RecommendItemData> data)
	{
		GenericLayout<AttrContent, RecommendItemData> layout = this.Layout;
		if (layout == null)
		{
			return;
		}
		layout.RefreshByData(data, null, false);
	}

	// Token: 0x04008E07 RID: 36359
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<AttrContent, RecommendItemData> Layout;

	// Token: 0x04008E08 RID: 36360
	[Nullable(2)]
	public Action<EToggleState> OnToggleAllCallback;
}
