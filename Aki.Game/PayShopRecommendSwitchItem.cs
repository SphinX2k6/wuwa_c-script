using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200238C RID: 9100
[NullableContext(1)]
[Nullable(0)]
public class PayShopRecommendSwitchItem : CommonTabItemBase, ITabViewRegister
{
	// Token: 0x06012313 RID: 74515 RVA: 0x0047A9B8 File Offset: 0x00478BB8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.OnExtendToggleToggle));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06012314 RID: 74516 RVA: 0x0047AAA0 File Offset: 0x00478CA0
	public override void Refresh(CommonTabItemData data, bool isSelected, int gridIndex)
	{
		this.CurrentData = data;
		this.OnRefresh(data, isSelected, gridIndex);
		this.GetTabToggle().RootUIComp.Get().SetUIActive(false);
		this.GetTabToggle().RootUIComp.Get().SetUIActive(true);
	}

	// Token: 0x06012315 RID: 74517 RVA: 0x0047AAEF File Offset: 0x00478CEF
	protected override void OnStart()
	{
		base.OnStart();
		base.GetExtendToggle(1).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x06012316 RID: 74518 RVA: 0x0047AB08 File Offset: 0x00478D08
	protected override void OnBeforeHide()
	{
		this.UnBindRedDot();
	}

	// Token: 0x06012317 RID: 74519 RVA: 0x0047AB10 File Offset: 0x00478D10
	public void RegisterViewModule(UiTabViewBase tabView)
	{
		tabView.AddUiTabViewBehavior<UiTabSequence>().SetRootItem(tabView);
	}

	// Token: 0x06012318 RID: 74520 RVA: 0x0047AB1E File Offset: 0x00478D1E
	private void OnExtendToggleToggle(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked)
		{
			this.SelectedCallBack(base.GridIndex);
		}
	}

	// Token: 0x06012319 RID: 74521 RVA: 0x0047AB37 File Offset: 0x00478D37
	protected override void OnSetToggleState(EToggleState state, bool bFire)
	{
		base.GetExtendToggle(1).SetToggleStateForce(state, bFire, false, false);
	}

	// Token: 0x0601231A RID: 74522 RVA: 0x0047AB49 File Offset: 0x00478D49
	protected override void OnRefresh(CommonTabItemData data, bool isSelected, int gridIndex)
	{
		if (data.Data != null)
		{
			base.UpdateTabIcon(data.Data.GetIcon());
		}
	}

	// Token: 0x0601231B RID: 74523 RVA: 0x0047AB64 File Offset: 0x00478D64
	protected override void OnUpdateTabIcon(string iconPath)
	{
	}

	// Token: 0x0601231C RID: 74524 RVA: 0x0047AB66 File Offset: 0x00478D66
	protected override UUIExtendToggle GetTabToggle()
	{
		return base.GetExtendToggle(1);
	}

	// Token: 0x0601231D RID: 74525 RVA: 0x0047AB70 File Offset: 0x00478D70
	public void UpdateView(PayShopDefine.EPayShopTabType payShopId, int tabId)
	{
		PayShopTabData payShopTabDataByPayShopIdAndTabId = PayShopModel.Instance.GetPayShopTabDataByPayShopIdAndTabId(payShopId, tabId);
		base.GetText(0).SetText((payShopTabDataByPayShopIdAndTabId != null) ? payShopTabDataByPayShopIdAndTabId.Name : "", true);
		this.RootItem.SetUIActive(payShopTabDataByPayShopIdAndTabId != null && payShopTabDataByPayShopIdAndTabId.Enable);
	}

	// Token: 0x0601231E RID: 74526 RVA: 0x0047ABBE File Offset: 0x00478DBE
	public void UpdateTitle(string title)
	{
		base.GetText(0).SetText(title, true);
	}

	// Token: 0x0601231F RID: 74527 RVA: 0x0047ABD0 File Offset: 0x00478DD0
	public void UpdateTabImage(string tabImage)
	{
		base.SetTextureByPath(tabImage, base.GetTexture(3), null, null);
	}

	// Token: 0x06012320 RID: 74528 RVA: 0x0047ABF8 File Offset: 0x00478DF8
	public void BindRedDot(ERedDotName redDotName, int tabId = 0)
	{
		this.UnBindRedDot();
		UUIItem item = base.GetItem(2);
		this.RedDotName = new ERedDotName?(redDotName);
		this.TabId = tabId;
		RedDotController.Instance.BindRedDot(redDotName, item, null, tabId);
	}

	// Token: 0x06012321 RID: 74529 RVA: 0x0047AC34 File Offset: 0x00478E34
	public void UnBindRedDot()
	{
		if (this.RedDotName != null)
		{
			RedDotController.Instance.UnBindGivenUi(this.RedDotName.Value, base.GetItem(2), this.TabId);
			this.RedDotName = null;
			this.TabId = 0;
		}
	}

	// Token: 0x0400898D RID: 35213
	private ERedDotName? RedDotName;

	// Token: 0x0400898E RID: 35214
	private int TabId;

	// Token: 0x0200892E RID: 35118
	[NullableContext(0)]
	private class EPayShopSwitchItem
	{
		// Token: 0x0402C982 RID: 182658
		public const int Name = 0;

		// Token: 0x0402C983 RID: 182659
		public const int SwitchToggle = 1;

		// Token: 0x0402C984 RID: 182660
		public const int RedDot = 2;

		// Token: 0x0402C985 RID: 182661
		public const int TextureImage = 3;
	}
}
