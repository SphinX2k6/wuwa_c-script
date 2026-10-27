using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200195F RID: 6495
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class VisionRecoverySelectableComponent<[Nullable(0)] T> : SelectableComponent<T> where T : ItemDataBase
{
	// Token: 0x0600BDF1 RID: 48625 RVA: 0x002AF518 File Offset: 0x002AD718
	protected override SelectablePropMediumItemGrid InitItem()
	{
		SelectablePropVisionRecoveryItemGrid selectablePropVisionRecoveryItemGrid = new SelectablePropVisionRecoveryItemGrid();
		selectablePropVisionRecoveryItemGrid.BindLongPress(LongPressButtonItem.ELongPressConfigId.LongPressOne, delegate(bool _1, ItemGridBase _2, [Nullable(2)] object _3)
		{
			if (this.TryOpenStackCountPopup(_1, _2, _3))
			{
				return;
			}
			base.AddFunction(_1, _2, _3);
		}, new Func<ItemGridBase, object, bool>(base.CanItemLongPress));
		selectablePropVisionRecoveryItemGrid.BindReduceLongPress(delegate(bool _1, MediumItemGrid _2, object _3)
		{
			if (this.TryClearStackSelection(_1, _2, _3))
			{
				return;
			}
			base.ReduceFunction(_1, _2, _3);
		});
		selectablePropVisionRecoveryItemGrid.BindAfterApply(new Action<SelectablePropMediumItemGrid>(base.OnAfterApplyMediumItemGrid));
		selectablePropVisionRecoveryItemGrid.BindOnCanExecuteChange(new Func<object, bool, EToggleState, bool>(this.OnRecoveryCanExecuteChange));
		return selectablePropVisionRecoveryItemGrid;
	}

	// Token: 0x0600BDF2 RID: 48626 RVA: 0x002AF580 File Offset: 0x002AD780
	[NullableContext(2)]
	private bool OnRecoveryCanExecuteChange(object data, bool isForceSelected, EToggleState state)
	{
		SelectablePropData selectablePropData = data as SelectablePropData;
		return (selectablePropData == null || this.GetStackItemData(selectablePropData.IncId) == null) && base.OnCanExecuteChange(data, isForceSelected, state);
	}

	// Token: 0x0600BDF3 RID: 48627 RVA: 0x002AF5B0 File Offset: 0x002AD7B0
	protected override bool CanAddMaterial(SelectablePropData propData, bool isShowTip = false)
	{
		PhantomBattleData phantomBattleData = PhantomBattleModel.Instance.GetPhantomBattleData(propData.IncId);
		if (phantomBattleData == null)
		{
			return false;
		}
		if (phantomBattleData.GetPhantomLevel() > 0 || phantomBattleData.GetExp() > 0)
		{
			if (isShowTip)
			{
				ScrollingTipsController.Instance.ShowTipsById("Text_EchoFull_Text", Array.Empty<object>());
			}
			return false;
		}
		if (propData.GetIsLock())
		{
			if (isShowTip)
			{
				ScrollingTipsController.Instance.ShowTipsById("WeaponLockTipsText", Array.Empty<object>());
			}
			return false;
		}
		if (propData.OnlyGold && phantomBattleData.GetQuality() < 5)
		{
			if (isShowTip)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("DirectionalFusion_OnlyGold", Array.Empty<object>());
			}
			return false;
		}
		ISelectedData selectedData = base.GetSelectedData(propData);
		if (this.GetStackItemData(propData.IncId) != null)
		{
			if (selectedData != null && selectedData.SelectedCount > 0)
			{
				return true;
			}
			if (PhantomStackUtil.GetSelectedUnitCount(this.SelectedDataList) >= this.MaxSize)
			{
				if (isShowTip)
				{
					ScrollingTipsController.Instance.ShowTipsById("Text_EchoLimit_Text", Array.Empty<object>());
				}
				return false;
			}
			return true;
		}
		else
		{
			if (selectedData != null && selectedData.SelectedCount > 0 && selectedData.SelectedCount == propData.Count)
			{
				return false;
			}
			if (selectedData == null && PhantomStackUtil.GetSelectedUnitCount(this.SelectedDataList) >= this.MaxSize)
			{
				if (isShowTip)
				{
					ScrollingTipsController.Instance.ShowTipsById("Text_EchoLimit_Text", Array.Empty<object>());
				}
				return false;
			}
			return this.Data.CheckIfCanAddFunction == null || this.Data.CheckIfCanAddFunction(this.SelectedDataList, propData.IncId, propData.ItemId, 1);
		}
	}

	// Token: 0x0600BDF4 RID: 48628 RVA: 0x002AF71C File Offset: 0x002AD91C
	private bool TryClearStackSelection(bool isShortPress, ItemGridBase itemGrid, [Nullable(2)] object data)
	{
		SelectablePropData selectablePropData = data as SelectablePropData;
		if (selectablePropData == null)
		{
			return false;
		}
		if (this.GetStackItemData(selectablePropData.IncId) == null)
		{
			return false;
		}
		if (!isShortPress)
		{
			return true;
		}
		base.MoveSelectFrameTo(selectablePropData);
		this.SetStackSelectedCount(selectablePropData, itemGrid, 0);
		return true;
	}

	// Token: 0x0600BDF5 RID: 48629 RVA: 0x002AF75C File Offset: 0x002AD95C
	private bool TryOpenStackCountPopup(bool isShortPress, ItemGridBase itemGrid, [Nullable(2)] object data)
	{
		SelectablePropData propData = data as SelectablePropData;
		if (propData == null)
		{
			return false;
		}
		PhantomItemData stackItemData = this.GetStackItemData(propData.IncId);
		if (stackItemData == null)
		{
			return false;
		}
		if (!isShortPress)
		{
			return true;
		}
		if (UiManager.Instance.IsViewOpen(EUiViewName.PhantomStackCountPopupView))
		{
			return true;
		}
		EventSystem.Instance.Emit<int, int>(EEventName.OnSelectItemAdd, propData.ItemId, propData.IncId);
		if (!this.CanAddMaterial(propData, true))
		{
			return true;
		}
		base.MoveSelectFrameTo(propData);
		ISelectedData selectedData = base.GetSelectedData(propData);
		int num = (selectedData != null) ? selectedData.SelectedCount : 0;
		int num2 = this.MaxSize - (PhantomStackUtil.GetSelectedUnitCount(this.SelectedDataList) - num);
		int num3 = (stackItemData.GetStackCount() < num2) ? stackItemData.GetStackCount() : num2;
		if (num3 <= 0)
		{
			return true;
		}
		UiManager.Instance.OpenView(EUiViewName.PhantomStackCountPopupView, new PhantomStackCountPopupData
		{
			IncId = propData.IncId,
			MaxCount = num3,
			MinCount = 0,
			InitCount = ((num > 0) ? num : 1),
			OnConfirm = delegate(int count)
			{
				this.SetStackSelectedCount(propData, itemGrid, count);
			}
		}, null);
		return true;
	}

	// Token: 0x0600BDF6 RID: 48630 RVA: 0x002AF8A4 File Offset: 0x002ADAA4
	private void SetStackSelectedCount(SelectablePropData propData, ItemGridBase itemGrid, int count)
	{
		ISelectedData selectedData = base.GetSelectedData(propData);
		if (count <= 0)
		{
			if (selectedData != null)
			{
				base.RemoveSelectedDataByIncId(propData.IncId);
			}
			propData.SelectedCount = 0;
		}
		else if (selectedData == null)
		{
			propData.SelectedCount = count;
			this.SelectedDataList.Add(propData);
		}
		else
		{
			selectedData.SelectedCount = count;
			propData.SelectedCount = count;
		}
		base.UpdateChangeItemSelectList();
		EventSystem.Instance.Emit<int, int>(EEventName.OnSelectItemAdd, propData.ItemId, propData.IncId);
		SelectablePropMediumItemGrid selectablePropMediumItemGrid = itemGrid as SelectablePropMediumItemGrid;
		if (selectablePropMediumItemGrid == null)
		{
			return;
		}
		selectablePropMediumItemGrid.RefreshUi(propData);
		base.RefreshSelectFrame(selectablePropMediumItemGrid, count > 0);
	}

	// Token: 0x0600BDF7 RID: 48631 RVA: 0x002AF93C File Offset: 0x002ADB3C
	[NullableContext(2)]
	private PhantomItemData GetStackItemData(int incId)
	{
		PhantomItemData phantomItemData = InventoryModel.Instance.GetPhantomItemData(incId);
		if (phantomItemData == null || !phantomItemData.IsStack())
		{
			return null;
		}
		return phantomItemData;
	}
}
