using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001873 RID: 6259
public class PayShopSecondTabItem : UiPanelBase
{
	// Token: 0x0600F7D8 RID: 63448 RVA: 0x0048802D File Offset: 0x0048622D
	[NullableContext(1)]
	public PayShopSecondTabItem(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x0600F7D9 RID: 63449 RVA: 0x00488044 File Offset: 0x00486244
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(2, new Action<EToggleState>(this.ToggleClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600F7DA RID: 63450 RVA: 0x004880EA File Offset: 0x004862EA
	protected override void OnStart()
	{
		this.Toggle = base.GetExtendToggle(2);
		this.Toggle.CanExecuteChange.Bind(new Func<bool>(this.CanExecuteChange));
		this.SetToggleState(false);
	}

	// Token: 0x0600F7DB RID: 63451 RVA: 0x0048811C File Offset: 0x0048631C
	protected override void OnBeforeDestroy()
	{
		this.SetToggleState(false);
		this.Toggle.CanExecuteChange.Unbind();
	}

	// Token: 0x0600F7DC RID: 63452 RVA: 0x00488135 File Offset: 0x00486335
	private void ToggleClick(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked)
		{
			this.IsSelected = true;
			Action<int> toggleFunction = this.ToggleFunction;
			if (toggleFunction == null)
			{
				return;
			}
			toggleFunction(this.TabId);
		}
	}

	// Token: 0x0600F7DD RID: 63453 RVA: 0x00488158 File Offset: 0x00486358
	private bool CanExecuteChange()
	{
		EToggleState toggleState = this.Toggle.GetToggleState();
		return !this.IsSelected || toggleState != EToggleState.ETT_Checked;
	}

	// Token: 0x0600F7DE RID: 63454 RVA: 0x00488180 File Offset: 0x00486380
	public void SetName(PayShopDefine.EPayShopTabType payShopId, int tabId)
	{
		this.TabId = tabId;
		PayShopTabData payShopTabDataByPayShopIdAndTabId = PayShopModel.Instance.GetPayShopTabDataByPayShopIdAndTabId(payShopId, tabId);
		base.GetText(0).SetText((payShopTabDataByPayShopIdAndTabId != null) ? payShopTabDataByPayShopIdAndTabId.Name : "", true);
	}

	// Token: 0x0600F7DF RID: 63455 RVA: 0x004881BE File Offset: 0x004863BE
	[NullableContext(1)]
	public void SetToggleFunction(Action<int> callBack)
	{
		this.ToggleFunction = callBack;
	}

	// Token: 0x0600F7E0 RID: 63456 RVA: 0x004881C8 File Offset: 0x004863C8
	public void SetToggleState(bool bSelected)
	{
		this.IsSelected = bSelected;
		EToggleState state = bSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		this.Toggle.SetToggleState(state, false, false, false);
	}

	// Token: 0x04008AD6 RID: 35542
	protected int TabId;

	// Token: 0x04008AD7 RID: 35543
	protected bool IsSelected;

	// Token: 0x04008AD8 RID: 35544
	[Nullable(2)]
	protected Action<int> ToggleFunction;

	// Token: 0x04008AD9 RID: 35545
	[Nullable(2)]
	protected UUIExtendToggle Toggle;

	// Token: 0x02007ABB RID: 31419
	private class EPayShopSecondTabItemDefine
	{
		// Token: 0x04027CA6 RID: 162982
		public const int Name = 0;

		// Token: 0x04027CA7 RID: 162983
		public const int RedDotActor = 1;

		// Token: 0x04027CA8 RID: 162984
		public const int Toggle = 2;
	}
}
