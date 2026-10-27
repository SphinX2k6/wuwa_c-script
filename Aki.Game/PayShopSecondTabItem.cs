using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200238E RID: 9102
public class PayShopSecondTabItem : UiPanelBase
{
	// Token: 0x06012326 RID: 74534 RVA: 0x0047ACDD File Offset: 0x00478EDD
	[NullableContext(1)]
	public PayShopSecondTabItem(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x06012327 RID: 74535 RVA: 0x0047ACF4 File Offset: 0x00478EF4
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

	// Token: 0x06012328 RID: 74536 RVA: 0x0047AD9A File Offset: 0x00478F9A
	protected override void OnStart()
	{
		this.Toggle = base.GetExtendToggle(2);
		this.Toggle.CanExecuteChange.Bind(new Func<bool>(this.CanExecuteChange));
		this.SetToggleState(false);
	}

	// Token: 0x06012329 RID: 74537 RVA: 0x0047ADCC File Offset: 0x00478FCC
	protected override void OnBeforeDestroy()
	{
		this.SetToggleState(false);
		this.Toggle.CanExecuteChange.Unbind();
	}

	// Token: 0x0601232A RID: 74538 RVA: 0x0047ADE5 File Offset: 0x00478FE5
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

	// Token: 0x0601232B RID: 74539 RVA: 0x0047AE08 File Offset: 0x00479008
	private bool CanExecuteChange()
	{
		EToggleState toggleState = this.Toggle.GetToggleState();
		return !this.IsSelected || toggleState != EToggleState.ETT_Checked;
	}

	// Token: 0x0601232C RID: 74540 RVA: 0x0047AE30 File Offset: 0x00479030
	public void SetName(PayShopDefine.EPayShopTabType payShopId, int tabId)
	{
		this.TabId = tabId;
		PayShopTabData payShopTabDataByPayShopIdAndTabId = PayShopModel.Instance.GetPayShopTabDataByPayShopIdAndTabId(payShopId, tabId);
		base.GetText(0).SetText((payShopTabDataByPayShopIdAndTabId != null) ? payShopTabDataByPayShopIdAndTabId.Name : "", true);
	}

	// Token: 0x0601232D RID: 74541 RVA: 0x0047AE6E File Offset: 0x0047906E
	[NullableContext(1)]
	public void SetToggleFunction(Action<int> callBack)
	{
		this.ToggleFunction = callBack;
	}

	// Token: 0x0601232E RID: 74542 RVA: 0x0047AE78 File Offset: 0x00479078
	public void SetToggleState(bool bSelected)
	{
		this.IsSelected = bSelected;
		EToggleState state = bSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		this.Toggle.SetToggleState(state, false, false, false);
	}

	// Token: 0x0400898F RID: 35215
	protected int TabId;

	// Token: 0x04008990 RID: 35216
	protected bool IsSelected;

	// Token: 0x04008991 RID: 35217
	[Nullable(2)]
	protected Action<int> ToggleFunction;

	// Token: 0x04008992 RID: 35218
	[Nullable(2)]
	protected UUIExtendToggle Toggle;

	// Token: 0x02008930 RID: 35120
	private class EPayShopSecondTabItemDefine
	{
		// Token: 0x0402C988 RID: 182664
		public const int Name = 0;

		// Token: 0x0402C989 RID: 182665
		public const int RedDotActor = 1;

		// Token: 0x0402C98A RID: 182666
		public const int Toggle = 2;
	}
}
