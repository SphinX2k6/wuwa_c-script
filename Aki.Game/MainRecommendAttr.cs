using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200199D RID: 6557
[NullableContext(1)]
[Nullable(0)]
internal class MainRecommendAttr : UiPanelBase
{
	// Token: 0x06010281 RID: 66177 RVA: 0x004B5DC4 File Offset: 0x004B3FC4
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

	// Token: 0x06010282 RID: 66178 RVA: 0x004B5E41 File Offset: 0x004B4041
	protected override void OnStart()
	{
		this.Layout = new GenericLayout<MainRecommendAttrItem, IMainRecommendAttrItemData>(base.GetVerticalLayout(0), new Func<MainRecommendAttrItem>(this.InitItem), base.GetItem(1).GetOwner() as AUIBaseActor, false, true);
	}

	// Token: 0x06010283 RID: 66179 RVA: 0x004B5E74 File Offset: 0x004B4074
	private MainRecommendAttrItem InitItem()
	{
		return new MainRecommendAttrItem();
	}

	// Token: 0x06010284 RID: 66180 RVA: 0x004B5E7B File Offset: 0x004B407B
	private void OnClickToggleAll(EToggleState state)
	{
		Action<EToggleState> onToggleAllCallback = this.OnToggleAllCallback;
		if (onToggleAllCallback == null)
		{
			return;
		}
		onToggleAllCallback(state);
	}

	// Token: 0x06010285 RID: 66181 RVA: 0x004B5E8E File Offset: 0x004B408E
	public void SetToggleAllState(bool isAllSelected)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(2);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleState(isAllSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x06010286 RID: 66182 RVA: 0x004B5EAC File Offset: 0x004B40AC
	public void Refresh(List<IMainRecommendAttrItemData> data)
	{
		GenericLayout<MainRecommendAttrItem, IMainRecommendAttrItemData> layout = this.Layout;
		if (layout == null)
		{
			return;
		}
		layout.RefreshByData(data, null, false);
	}

	// Token: 0x04008F5B RID: 36699
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<MainRecommendAttrItem, IMainRecommendAttrItemData> Layout;

	// Token: 0x04008F5C RID: 36700
	[Nullable(2)]
	public Action<EToggleState> OnToggleAllCallback;
}
