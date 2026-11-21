using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001871 RID: 6257
[NullableContext(1)]
[Nullable(0)]
public class PayShopRecommendSwitchItem : CommonTabItemBase, ITabViewRegister
{
	// Token: 0x0600F7C5 RID: 63429 RVA: 0x00487D08 File Offset: 0x00485F08
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

	// Token: 0x0600F7C6 RID: 63430 RVA: 0x00487DF0 File Offset: 0x00485FF0
	public override void Refresh(CommonTabItemData data, bool isSelected, int gridIndex)
	{
		this.CurrentData = data;
		this.OnRefresh(data, isSelected, gridIndex);
		this.GetTabToggle().RootUIComp.Get().SetUIActive(false);
		this.GetTabToggle().RootUIComp.Get().SetUIActive(true);
	}

	// Token: 0x0600F7C7 RID: 63431 RVA: 0x00487E3F File Offset: 0x0048603F
	protected override void OnStart()
	{
		base.OnStart();
		base.GetExtendToggle(1).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x0600F7C8 RID: 63432 RVA: 0x00487E58 File Offset: 0x00486058
	protected override void OnBeforeHide()
	{
		this.UnBindRedDot();
	}

	// Token: 0x0600F7C9 RID: 63433 RVA: 0x00487E60 File Offset: 0x00486060
	public void RegisterViewModule(UiTabViewBase tabView)
	{
		tabView.AddUiTabViewBehavior<UiTabSequence>().SetRootItem(tabView);
	}

	// Token: 0x0600F7CA RID: 63434 RVA: 0x00487E6E File Offset: 0x0048606E
	private void OnExtendToggleToggle(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked)
		{
			this.SelectedCallBack(base.GridIndex);
		}
	}

	// Token: 0x0600F7CB RID: 63435 RVA: 0x00487E87 File Offset: 0x00486087
	protected override void OnSetToggleState(EToggleState state, bool bFire)
	{
		base.GetExtendToggle(1).SetToggleStateForce(state, bFire, false, false);
	}

	// Token: 0x0600F7CC RID: 63436 RVA: 0x00487E99 File Offset: 0x00486099
	protected override void OnRefresh(CommonTabItemData data, bool isSelected, int gridIndex)
	{
		if (data.Data != null)
		{
			base.UpdateTabIcon(data.Data.GetIcon());
		}
	}

	// Token: 0x0600F7CD RID: 63437 RVA: 0x00487EB4 File Offset: 0x004860B4
	protected override void OnUpdateTabIcon(string iconPath)
	{
	}

	// Token: 0x0600F7CE RID: 63438 RVA: 0x00487EB6 File Offset: 0x004860B6
	protected override UUIExtendToggle GetTabToggle()
	{
		return base.GetExtendToggle(1);
	}

	// Token: 0x0600F7CF RID: 63439 RVA: 0x00487EC0 File Offset: 0x004860C0
	public void UpdateView(PayShopDefine.EPayShopTabType payShopId, int tabId)
	{
		PayShopTabData payShopTabDataByPayShopIdAndTabId = PayShopModel.Instance.GetPayShopTabDataByPayShopIdAndTabId(payShopId, tabId);
		base.GetText(0).SetText((payShopTabDataByPayShopIdAndTabId != null) ? payShopTabDataByPayShopIdAndTabId.Name : "", true);
		this.RootItem.SetUIActive(payShopTabDataByPayShopIdAndTabId != null && payShopTabDataByPayShopIdAndTabId.Enable);
	}

	// Token: 0x0600F7D0 RID: 63440 RVA: 0x00487F0E File Offset: 0x0048610E
	public void UpdateTitle(string title)
	{
		base.GetText(0).SetText(title, true);
	}

	// Token: 0x0600F7D1 RID: 63441 RVA: 0x00487F20 File Offset: 0x00486120
	public void UpdateTabImage(string tabImage)
	{
		base.SetTextureByPath(tabImage, base.GetTexture(3), null, null);
	}

	// Token: 0x0600F7D2 RID: 63442 RVA: 0x00487F48 File Offset: 0x00486148
	public void BindRedDot(ERedDotName redDotName, int tabId = 0)
	{
		this.UnBindRedDot();
		UUIItem item = base.GetItem(2);
		this.RedDotName = new ERedDotName?(redDotName);
		this.TabId = tabId;
		RedDotController.Instance.BindRedDot(redDotName, item, null, tabId);
	}

	// Token: 0x0600F7D3 RID: 63443 RVA: 0x00487F84 File Offset: 0x00486184
	public void UnBindRedDot()
	{
		if (this.RedDotName != null)
		{
			RedDotController.Instance.UnBindGivenUi(this.RedDotName.Value, base.GetItem(2), this.TabId);
			this.RedDotName = null;
			this.TabId = 0;
		}
	}

	// Token: 0x04008AD4 RID: 35540
	private ERedDotName? RedDotName;

	// Token: 0x04008AD5 RID: 35541
	private int TabId;

	// Token: 0x02007AB9 RID: 31417
	[NullableContext(0)]
	private class EPayShopSwitchItem
	{
		// Token: 0x04027CA0 RID: 162976
		public const int Name = 0;

		// Token: 0x04027CA1 RID: 162977
		public const int SwitchToggle = 1;

		// Token: 0x04027CA2 RID: 162978
		public const int RedDot = 2;

		// Token: 0x04027CA3 RID: 162979
		public const int TextureImage = 3;
	}
}
