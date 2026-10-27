using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using UnrealEngine;

// Token: 0x02001A5B RID: 6747
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class DangoAbyssSelectableComponent<[Nullable(0)] T> : SelectableComponent<T> where T : ItemDataBase
{
	// Token: 0x0600C699 RID: 50841 RVA: 0x002D2FA4 File Offset: 0x002D11A4
	public DangoAbyssSelectableComponent(bool stateForEquip)
	{
		this.StateForEquip = stateForEquip;
	}

	// Token: 0x0600C69A RID: 50842 RVA: 0x002D2FBC File Offset: 0x002D11BC
	[PreserveBaseOverrides]
	protected new virtual DangoAbyssItemPropMediumItemGrid InitItem()
	{
		DangoAbyssItemPropMediumItemGrid dangoAbyssItemPropMediumItemGrid = new DangoAbyssItemPropMediumItemGrid();
		dangoAbyssItemPropMediumItemGrid.StateForEquip = this.StateForEquip;
		dangoAbyssItemPropMediumItemGrid.BindReduceLongPress(delegate(bool _1, MediumItemGrid _2, object _3)
		{
			base.ReduceFunction(_1, _2, _3);
		});
		dangoAbyssItemPropMediumItemGrid.BindLongPress(LongPressButtonItem.ELongPressConfigId.LongPressOne, delegate(bool _1, ItemGridBase _2, [Nullable(2)] object _3)
		{
			base.AddFunction(_1, _2, _3);
		}, new Func<ItemGridBase, object, bool>(base.CanItemLongPress));
		dangoAbyssItemPropMediumItemGrid.BindOnCanExecuteChange(new Func<object, bool, EToggleState, bool>(base.OnCanExecuteChange));
		return dangoAbyssItemPropMediumItemGrid;
	}

	// Token: 0x0600C69B RID: 50843 RVA: 0x002D3020 File Offset: 0x002D1220
	protected override bool CanAddMaterial(SelectablePropData propData, bool isShowTip = false)
	{
		AbyssPluginItemInfo pluginItemInfoById = DangoAbyssModel.Instance.GetPluginItemInfoById(propData.IncId);
		if (pluginItemInfoById.GetIsLock() && !this.StateForEquip)
		{
			if (isShowTip)
			{
				ScrollingTipsController.Instance.ShowTipsById("WeaponLockTipsText", Array.Empty<object>());
			}
			return false;
		}
		if (!pluginItemInfoById.GetCanRecovery() && !this.StateForEquip)
		{
			if (isShowTip)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("EquipLockTipsText", Array.Empty<object>());
			}
			return false;
		}
		ISelectedData selectedData = base.GetSelectedData(propData);
		if (selectedData != null)
		{
			int selectedCount = selectedData.SelectedCount;
			if (selectedData.SelectedCount == propData.Count)
			{
				return false;
			}
		}
		if (selectedData == null && this.SelectedDataList.Count >= this.MaxSize && !this.Data.IsSingleSelected)
		{
			if (isShowTip)
			{
				ScrollingTipsController.Instance.ShowTipsById("WeaponFullMaterialText", Array.Empty<object>());
			}
			return false;
		}
		return this.Data.CheckIfCanAddFunction == null || this.Data.CheckIfCanAddFunction(this.SelectedDataList, propData.IncId, propData.ItemId, 1);
	}

	// Token: 0x0600C69C RID: 50844 RVA: 0x002D3124 File Offset: 0x002D1324
	public void RemoveAndRefresh(int uniqueId)
	{
		int loopScrollViewIndex = base.GetLoopScrollViewIndex(uniqueId, -1);
		AbyssPluginItemInfo pluginItemInfoById = DangoAbyssModel.Instance.GetPluginItemInfoById(uniqueId);
		if (loopScrollViewIndex < 0 || pluginItemInfoById == null)
		{
			return;
		}
		if (pluginItemInfoById.GetIsLock())
		{
			base.RemoveSelectedDataByIncId(uniqueId);
		}
		base.RefreshAllByDisplay();
		base.UpdateChangeItemSelectList();
	}

	// Token: 0x04005B84 RID: 23428
	private readonly bool StateForEquip = true;
}
