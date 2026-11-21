using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using UnrealEngine;

// Token: 0x02000F1A RID: 3866
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class DangoAbyssSelectableComponent<[Nullable(0)] T> : SelectableComponent<T> where T : ItemDataBase
{
	// Token: 0x06009AA9 RID: 39593 RVA: 0x002DE0AA File Offset: 0x002DC2AA
	public DangoAbyssSelectableComponent(bool stateForEquip)
	{
		this.StateForEquip = stateForEquip;
	}

	// Token: 0x06009AAA RID: 39594 RVA: 0x002DE0C0 File Offset: 0x002DC2C0
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

	// Token: 0x06009AAB RID: 39595 RVA: 0x002DE124 File Offset: 0x002DC324
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

	// Token: 0x06009AAC RID: 39596 RVA: 0x002DE228 File Offset: 0x002DC428
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

	// Token: 0x04005C53 RID: 23635
	private readonly bool StateForEquip = true;
}
