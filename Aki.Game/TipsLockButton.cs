using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020018F1 RID: 6385
public class TipsLockButton : UiPanelBase
{
	// Token: 0x0600BB18 RID: 47896 RVA: 0x002A5DA9 File Offset: 0x002A3FA9
	[NullableContext(1)]
	public TipsLockButton(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x0600BB19 RID: 47897 RVA: 0x002A5DC0 File Offset: 0x002A3FC0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIExtendToggle));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.LockButtonClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.OnDeprecateToggleClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600BB1A RID: 47898 RVA: 0x002A5E89 File Offset: 0x002A4089
	protected override void OnStart()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		extendToggle.CanExecuteChange.Unbind();
		extendToggle.CanExecuteChange.Bind(new Func<bool>(this.OnCanExecuteChange));
	}

	// Token: 0x0600BB1B RID: 47899 RVA: 0x002A5EB3 File Offset: 0x002A40B3
	private bool OnCanExecuteChange()
	{
		return this.CanClickLockButton == null || this.CanClickLockButton(this.IncId);
	}

	// Token: 0x0600BB1C RID: 47900 RVA: 0x002A5ED0 File Offset: 0x002A40D0
	protected override void OnBeforeShow()
	{
		EventSystem.Instance.Add(EEventName.OnItemFuncValueChange, new Action<int>(this.RefreshFuncState));
	}

	// Token: 0x0600BB1D RID: 47901 RVA: 0x002A5EEE File Offset: 0x002A40EE
	protected override void OnBeforeHide()
	{
		EventSystem.Instance.Remove(EEventName.OnItemFuncValueChange, new Action<int>(this.RefreshFuncState));
	}

	// Token: 0x0600BB1E RID: 47902 RVA: 0x002A5F0C File Offset: 0x002A410C
	[NullableContext(2)]
	public void Refresh(int incId, Func<int, bool> canClickFunction = null)
	{
		this.IncId = incId;
		this.RefreshUi(incId);
		if (canClickFunction != null)
		{
			this.CanClickLockButton = canClickFunction;
			return;
		}
		this.CanClickLockButton = null;
	}

	// Token: 0x0600BB1F RID: 47903 RVA: 0x002A5F30 File Offset: 0x002A4130
	private void RefreshUi(int incId)
	{
		AttributeItemData attributeItemData = InventoryModel.Instance.GetAttributeItemData(incId);
		if (attributeItemData == null)
		{
			return;
		}
		base.GetExtendToggle(0).RootUIComp.Get().SetUIActive(attributeItemData.CanLock());
		base.GetExtendToggle(1).RootUIComp.Get().SetUIActive(attributeItemData.CanDeprecate());
		EToggleState state = attributeItemData.GetIsLock() ? EToggleState.ETT_UnChecked : EToggleState.ETT_Checked;
		base.GetExtendToggle(0).SetToggleStateForce(state, false, false, false);
		EToggleState state2 = attributeItemData.GetIsDeprecated() ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(1).SetToggleStateForce(state2, false, false, false);
	}

	// Token: 0x0600BB20 RID: 47904 RVA: 0x002A5FC8 File Offset: 0x002A41C8
	public void SetDeprecateToggleVisible(bool state)
	{
		base.GetExtendToggle(1).RootUIComp.Get().SetUIActive(state);
	}

	// Token: 0x0600BB21 RID: 47905 RVA: 0x002A5FEF File Offset: 0x002A41EF
	private void RefreshFuncState(int incId)
	{
		if (incId != this.IncId)
		{
			return;
		}
		this.RefreshUi(incId);
	}

	// Token: 0x0600BB22 RID: 47906 RVA: 0x002A6004 File Offset: 0x002A4204
	private void LockButtonClick(EToggleState toggleState)
	{
		AttributeItemData attributeItemData = InventoryModel.Instance.GetAttributeItemData(this.IncId);
		if (attributeItemData == null)
		{
			return;
		}
		InventoryController.Instance.ItemLockRequest(this.IncId, !attributeItemData.GetIsLock());
	}

	// Token: 0x0600BB23 RID: 47907 RVA: 0x002A6040 File Offset: 0x002A4240
	private void OnDeprecateToggleClick(EToggleState toggleState)
	{
		AttributeItemData attributeItemData = InventoryModel.Instance.GetAttributeItemData(this.IncId);
		if (attributeItemData == null)
		{
			return;
		}
		InventoryController.Instance.ItemDeprecateRequest(this.IncId, !attributeItemData.GetIsDeprecated());
	}

	// Token: 0x040054F8 RID: 21752
	private int IncId;

	// Token: 0x040054F9 RID: 21753
	[Nullable(2)]
	private Func<int, bool> CanClickLockButton;

	// Token: 0x02007E67 RID: 32359
	private class ETipsLockButtonNode
	{
		// Token: 0x040295BE RID: 169406
		public const int LockToggle = 0;

		// Token: 0x040295BF RID: 169407
		public const int DeprecateToggle = 1;
	}
}
