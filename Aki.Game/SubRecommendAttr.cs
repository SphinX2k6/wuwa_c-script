using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001999 RID: 6553
[NullableContext(1)]
[Nullable(0)]
internal class SubRecommendAttr : UiPanelBase
{
	// Token: 0x06010275 RID: 66165 RVA: 0x004B5C4C File Offset: 0x004B3E4C
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

	// Token: 0x06010276 RID: 66166 RVA: 0x004B5CC9 File Offset: 0x004B3EC9
	protected override void OnStart()
	{
		this.Layout = new GenericLayout<AttrContent, RecommendItemData>(base.GetVerticalLayout(0), new Func<AttrContent>(this.InitItem), null, false, true);
	}

	// Token: 0x06010277 RID: 66167 RVA: 0x004B5CEC File Offset: 0x004B3EEC
	private AttrContent InitItem()
	{
		return new AttrContent();
	}

	// Token: 0x06010278 RID: 66168 RVA: 0x004B5CF3 File Offset: 0x004B3EF3
	private void OnClickToggleAll(EToggleState state)
	{
		Action<EToggleState> onToggleAllCallback = this.OnToggleAllCallback;
		if (onToggleAllCallback == null)
		{
			return;
		}
		onToggleAllCallback(state);
	}

	// Token: 0x06010279 RID: 66169 RVA: 0x004B5D06 File Offset: 0x004B3F06
	public void SetToggleAllState(bool isAllSelected)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(2);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleState(isAllSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x0601027A RID: 66170 RVA: 0x004B5D24 File Offset: 0x004B3F24
	public void Refresh(List<RecommendItemData> data)
	{
		GenericLayout<AttrContent, RecommendItemData> layout = this.Layout;
		if (layout == null)
		{
			return;
		}
		layout.RefreshByData(data, null, false);
	}

	// Token: 0x04008F51 RID: 36689
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<AttrContent, RecommendItemData> Layout;

	// Token: 0x04008F52 RID: 36690
	[Nullable(2)]
	public Action<EToggleState> OnToggleAllCallback;
}
