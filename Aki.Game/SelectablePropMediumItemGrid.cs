using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Inventory;

// Token: 0x0200195D RID: 6493
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class SelectablePropMediumItemGrid : LoopScrollMediumItemGrid<SelectablePropData>
{
	// Token: 0x0600BDE3 RID: 48611 RVA: 0x002AEDD0 File Offset: 0x002ACFD0
	public override void OnSelected(bool fireEvent)
	{
		if (fireEvent)
		{
			SelectablePropData selectablePropData = this.SelectablePropData;
			if (selectablePropData != null && selectablePropData.IsSelectFrameFollowClick)
			{
				this.SetSelected(true, true);
				return;
			}
			LongPressButton reduceButton = new LongPressButton
			{
				IsVisible = new bool?(true),
				LongPressConfigId = new LongPressButtonItem.ELongPressConfigId?(LongPressButtonItem.ELongPressConfigId.LongPressOne)
			};
			this.SetSelected(true, true);
			base.SetReduceButton(reduceButton);
		}
	}

	// Token: 0x0600BDE4 RID: 48612 RVA: 0x002AEE2A File Offset: 0x002AD02A
	public override void OnDeselected(bool fireEvent)
	{
		this.SetSelected(false, true);
	}

	// Token: 0x0600BDE5 RID: 48613 RVA: 0x002AEE34 File Offset: 0x002AD034
	public override void SetSelected(bool bSelected, bool bForce = false)
	{
		this.RefreshUi(this.SelectablePropData);
		base.SetSelected(bSelected, bForce);
	}

	// Token: 0x0600BDE6 RID: 48614 RVA: 0x002AEE4A File Offset: 0x002AD04A
	protected override void OnStart()
	{
		this.GetItemGridExtendToggle().FocusListenerDelegate.Bind(new Action(this.ShowItemTips));
	}

	// Token: 0x0600BDE7 RID: 48615 RVA: 0x002AEE68 File Offset: 0x002AD068
	protected override void OnBeforeDestroy()
	{
		this.GetItemGridExtendToggle().FocusListenerDelegate.Unbind();
		this.OnAfterApplyCallback = null;
	}

	// Token: 0x0600BDE8 RID: 48616 RVA: 0x002AEE81 File Offset: 0x002AD081
	private void ShowItemTips()
	{
		EventSystem.Instance.Emit<int, int>(EEventName.OnSelectItemAdd, this.SelectablePropData.ItemId, this.SelectablePropData.IncId);
	}

	// Token: 0x0600BDE9 RID: 48617 RVA: 0x002AEEA9 File Offset: 0x002AD0A9
	protected override void OnRefresh(SelectablePropData data, bool isSelected, int gridIndex)
	{
		this.SelectablePropData = data;
		this.SetSelected(data.IsSelectFrameFollowClick ? isSelected : (data.SelectedCount > 0), true);
		if (this.OnAfterApplyCallback != null)
		{
			this.OnAfterApplyCallback(this);
		}
	}

	// Token: 0x0600BDEA RID: 48618 RVA: 0x002AEEE4 File Offset: 0x002AD0E4
	public virtual void RefreshUi(SelectablePropData data)
	{
		this.SelectablePropData = data;
		InventoryModel instance = InventoryModel.Instance;
		int incId = data.IncId;
		int itemId = data.ItemId;
		InventoryDefine.EItemDataType itemDataType = data.ItemDataType;
		ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(itemId);
		if (itemConfigData == null)
		{
			return;
		}
		ItemDataBase itemDataBase;
		if (incId > 0)
		{
			itemDataBase = instance.GetAttributeItemData(incId);
		}
		else
		{
			itemDataBase = instance.GetCommonItemData(itemId, 0);
		}
		if (itemDataBase == null)
		{
			return;
		}
		int selectedCount = this.SelectablePropData.SelectedCount;
		int count = this.SelectablePropData.Count;
		PropMediumItemGrid propMediumItemGrid = new PropMediumItemGrid
		{
			Data = data,
			ItemConfigId = new int?(itemId),
			StarLevel = new int?(itemConfigData.QualityId),
			ReduceButtonInfo = new LongPressButton
			{
				IsVisible = new bool?(selectedCount > 0),
				LongPressConfigId = new LongPressButtonItem.ELongPressConfigId?(LongPressButtonItem.ELongPressConfigId.LongPressOne)
			},
			IsLockVisible = new bool?(itemDataBase.GetIsLock()),
			IsDeprecate = new bool?(itemDataBase.GetIsDeprecated())
		};
		switch (itemDataType)
		{
		case InventoryDefine.EItemDataType.CommonItem:
			propMediumItemGrid.BuffIconType = new EMediumItemGridBuffType?((EMediumItemGridBuffType)itemConfigData.ItemBuffType);
			propMediumItemGrid.IsOmitBottomText = new bool?(false);
			if (selectedCount > 0)
			{
				propMediumItemGrid.BottomTextId = "Text_ItemEnoughText_Text";
				propMediumItemGrid.BottomTextParameter = new object[]
				{
					selectedCount,
					count
				};
				goto IL_2AA;
			}
			propMediumItemGrid.BottomText = count.ToString();
			goto IL_2AA;
		case InventoryDefine.EItemDataType.WeaponItem:
		{
			WeaponInstance weaponDataByIncId = WeaponModel.Instance.GetWeaponDataByIncId(incId);
			if (weaponDataByIncId != null)
			{
				int resonanceLevel = weaponDataByIncId.GetResonanceLevel();
				propMediumItemGrid.Level = new int?(resonanceLevel);
				propMediumItemGrid.BottomTextId = "Text_LevelShow_Text";
				propMediumItemGrid.BottomTextParameter = new object[]
				{
					weaponDataByIncId.GetLevel()
				};
				goto IL_2AA;
			}
			goto IL_2AA;
		}
		case InventoryDefine.EItemDataType.PhantomItem:
		{
			PhantomBattleData phantomBattleData = PhantomBattleModel.Instance.GetPhantomBattleData(incId);
			if (phantomBattleData != null)
			{
				propMediumItemGrid.ItemConfigId = new int?(phantomBattleData.GetConfigId(true));
				propMediumItemGrid.QualityId = new int?(phantomBattleData.GetQuality());
				propMediumItemGrid.Level = new int?(phantomBattleData.GetCost());
				propMediumItemGrid.IsLevelTextUseChangeColor = new bool?(true);
				propMediumItemGrid.BottomTextId = "VisionLevel";
				propMediumItemGrid.BottomTextParameter = new object[]
				{
					phantomBattleData.GetPhantomLevel()
				};
				propMediumItemGrid.VisionFetterGroupId = new int?(phantomBattleData.GetFetterGroupId());
				propMediumItemGrid.IsOmitBottomText = new bool?(true);
				goto IL_2AA;
			}
			goto IL_2AA;
		}
		}
		if (selectedCount > 0)
		{
			propMediumItemGrid.BottomTextId = "Text_ItemEnoughText_Text";
			propMediumItemGrid.BottomTextParameter = new object[]
			{
				selectedCount,
				count
			};
		}
		else
		{
			propMediumItemGrid.BottomText = count.ToString();
		}
		IL_2AA:
		base.Apply<PropMediumItemGrid>(propMediumItemGrid);
	}

	// Token: 0x0600BDEB RID: 48619 RVA: 0x002AF1A4 File Offset: 0x002AD3A4
	public virtual void RefreshCostCount()
	{
		if (this.SelectablePropData == null)
		{
			return;
		}
		InventoryDefine.EItemDataType itemDataType = this.SelectablePropData.ItemDataType;
		int selectedCount = this.SelectablePropData.SelectedCount;
		int count = this.SelectablePropData.Count;
		switch (itemDataType)
		{
		case InventoryDefine.EItemDataType.CommonItem:
			if (selectedCount > 0)
			{
				base.SetBottomTextId("Text_ItemEnoughText_Text", new object[]
				{
					selectedCount,
					count
				});
				return;
			}
			base.SetBottomText(this.SelectablePropData.Count.ToString());
			return;
		case InventoryDefine.EItemDataType.WeaponItem:
		case InventoryDefine.EItemDataType.PhantomItem:
			return;
		}
		if (selectedCount > 0)
		{
			base.SetBottomTextId("Text_ItemEnoughText_Text", new object[]
			{
				selectedCount,
				count
			});
			return;
		}
		base.SetBottomText(this.SelectablePropData.Count.ToString());
	}

	// Token: 0x0600BDEC RID: 48620 RVA: 0x002AF279 File Offset: 0x002AD479
	public void BindAfterApply(Action<SelectablePropMediumItemGrid> onAfterApplyCallback)
	{
		this.OnAfterApplyCallback = onAfterApplyCallback;
	}

	// Token: 0x040055AA RID: 21930
	[Nullable(2)]
	public SelectablePropData SelectablePropData;

	// Token: 0x040055AB RID: 21931
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<SelectablePropMediumItemGrid> OnAfterApplyCallback;
}
