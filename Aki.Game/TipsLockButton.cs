using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000DAA RID: 3498
public class TipsLockButton : UiPanelBase
{
	// Token: 0x06008F02 RID: 36610 RVA: 0x002B0509 File Offset: 0x002AE709
	[NullableContext(1)]
	public TipsLockButton(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x06008F03 RID: 36611 RVA: 0x002B0520 File Offset: 0x002AE720
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

	// Token: 0x06008F04 RID: 36612 RVA: 0x002B05E9 File Offset: 0x002AE7E9
	protected override void OnStart()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		extendToggle.CanExecuteChange.Unbind();
		extendToggle.CanExecuteChange.Bind(new Func<bool>(this.OnCanExecuteChange));
	}

	// Token: 0x06008F05 RID: 36613 RVA: 0x002B0613 File Offset: 0x002AE813
	private bool OnCanExecuteChange()
	{
		return this.CanClickLockButton == null || this.CanClickLockButton(this.IncId);
	}

	// Token: 0x06008F06 RID: 36614 RVA: 0x002B0630 File Offset: 0x002AE830
	protected override void OnBeforeShow()
	{
		EventSystem.Instance.Add(EEventName.OnItemFuncValueChange, new Action<int>(this.RefreshFuncState));
	}

	// Token: 0x06008F07 RID: 36615 RVA: 0x002B064E File Offset: 0x002AE84E
	protected override void OnBeforeHide()
	{
		EventSystem.Instance.Remove(EEventName.OnItemFuncValueChange, new Action<int>(this.RefreshFuncState));
	}

	// Token: 0x06008F08 RID: 36616 RVA: 0x002B066C File Offset: 0x002AE86C
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

	// Token: 0x06008F09 RID: 36617 RVA: 0x002B0690 File Offset: 0x002AE890
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

	// Token: 0x06008F0A RID: 36618 RVA: 0x002B0728 File Offset: 0x002AE928
	public void SetDeprecateToggleVisible(bool state)
	{
		base.GetExtendToggle(1).RootUIComp.Get().SetUIActive(state);
	}

	// Token: 0x06008F0B RID: 36619 RVA: 0x002B074F File Offset: 0x002AE94F
	private void RefreshFuncState(int incId)
	{
		if (incId != this.IncId)
		{
			return;
		}
		this.RefreshUi(incId);
	}

	// Token: 0x06008F0C RID: 36620 RVA: 0x002B0764 File Offset: 0x002AE964
	private void LockButtonClick(EToggleState toggleState)
	{
		AttributeItemData attributeItemData = InventoryModel.Instance.GetAttributeItemData(this.IncId);
		if (attributeItemData == null)
		{
			return;
		}
		InventoryController.Instance.ItemLockRequest(this.IncId, !attributeItemData.GetIsLock());
	}

	// Token: 0x06008F0D RID: 36621 RVA: 0x002B07A0 File Offset: 0x002AE9A0
	private void OnDeprecateToggleClick(EToggleState toggleState)
	{
		AttributeItemData attributeItemData = InventoryModel.Instance.GetAttributeItemData(this.IncId);
		if (attributeItemData == null)
		{
			return;
		}
		InventoryController.Instance.ItemDeprecateRequest(this.IncId, !attributeItemData.GetIsDeprecated());
	}

	// Token: 0x040055A3 RID: 21923
	private int IncId;

	// Token: 0x040055A4 RID: 21924
	[Nullable(2)]
	private Func<int, bool> CanClickLockButton;

	// Token: 0x02006FEE RID: 28654
	private class ETipsLockButtonNode
	{
		// Token: 0x040248EA RID: 149738
		public const int LockToggle = 0;

		// Token: 0x040248EB RID: 149739
		public const int DeprecateToggle = 1;
	}
}
