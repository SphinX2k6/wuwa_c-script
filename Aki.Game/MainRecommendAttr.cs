using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020024B6 RID: 9398
[NullableContext(1)]
[Nullable(0)]
internal class MainRecommendAttr : UiPanelBase
{
	// Token: 0x06012DC1 RID: 77249 RVA: 0x004A8210 File Offset: 0x004A6410
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

	// Token: 0x06012DC2 RID: 77250 RVA: 0x004A828D File Offset: 0x004A648D
	protected override void OnStart()
	{
		this.Layout = new GenericLayout<MainRecommendAttrItem, IMainRecommendAttrItemData>(base.GetVerticalLayout(0), new Func<MainRecommendAttrItem>(this.InitItem), base.GetItem(1).GetOwner() as AUIBaseActor, false, true);
	}

	// Token: 0x06012DC3 RID: 77251 RVA: 0x004A82C0 File Offset: 0x004A64C0
	private MainRecommendAttrItem InitItem()
	{
		return new MainRecommendAttrItem();
	}

	// Token: 0x06012DC4 RID: 77252 RVA: 0x004A82C7 File Offset: 0x004A64C7
	private void OnClickToggleAll(EToggleState state)
	{
		Action<EToggleState> onToggleAllCallback = this.OnToggleAllCallback;
		if (onToggleAllCallback == null)
		{
			return;
		}
		onToggleAllCallback(state);
	}

	// Token: 0x06012DC5 RID: 77253 RVA: 0x004A82DA File Offset: 0x004A64DA
	public void SetToggleAllState(bool isAllSelected)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(2);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleState(isAllSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x06012DC6 RID: 77254 RVA: 0x004A82F8 File Offset: 0x004A64F8
	public void Refresh(List<IMainRecommendAttrItemData> data)
	{
		GenericLayout<MainRecommendAttrItem, IMainRecommendAttrItemData> layout = this.Layout;
		if (layout == null)
		{
			return;
		}
		layout.RefreshByData(data, null, false);
	}

	// Token: 0x04008E11 RID: 36369
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<MainRecommendAttrItem, IMainRecommendAttrItemData> Layout;

	// Token: 0x04008E12 RID: 36370
	[Nullable(2)]
	public Action<EToggleState> OnToggleAllCallback;
}
