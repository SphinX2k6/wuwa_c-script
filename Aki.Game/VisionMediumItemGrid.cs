using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.WheelTower;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.RoleUi;
using UnrealEngine;

// Token: 0x020024D1 RID: 9425
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class VisionMediumItemGrid : LoopScrollMediumItemGrid<PhantomBattleData>
{
	// Token: 0x06012F41 RID: 77633 RVA: 0x004B1265 File Offset: 0x004AF465
	protected override void OnStart()
	{
		base.BindOnExtendToggleStateChanged(delegate(MediumItemGridExtendCallback _)
		{
			this.OnClickEvent();
		});
		base.BindOnExtendTogglePress(delegate(MediumItemGridExtendCallback _)
		{
			this.OnToggleDown();
		});
		base.BindOnExtendToggleRelease(delegate(MediumItemGridExtendCallback _)
		{
			this.OnToggleUp();
		});
	}

	// Token: 0x06012F42 RID: 77634 RVA: 0x004B129D File Offset: 0x004AF49D
	public void SetOnPointDownCallBack(Action<VisionMediumItemGrid, PhantomBattleData> call)
	{
		this.OnPointDownCallBack = call;
	}

	// Token: 0x06012F43 RID: 77635 RVA: 0x004B12A6 File Offset: 0x004AF4A6
	public void SetOnPointUpCallBack(Action<VisionMediumItemGrid, PhantomBattleData> call)
	{
		this.OnPointUpCallBack = call;
	}

	// Token: 0x06012F44 RID: 77636 RVA: 0x004B12AF File Offset: 0x004AF4AF
	private void OnToggleDown()
	{
		if (this.CurrentData != null)
		{
			Action<VisionMediumItemGrid, PhantomBattleData> onPointDownCallBack = this.OnPointDownCallBack;
			if (onPointDownCallBack == null)
			{
				return;
			}
			onPointDownCallBack(this, this.CurrentData);
		}
	}

	// Token: 0x06012F45 RID: 77637 RVA: 0x004B12D0 File Offset: 0x004AF4D0
	private void OnToggleUp()
	{
		if (this.CurrentData != null)
		{
			Action<VisionMediumItemGrid, PhantomBattleData> onPointUpCallBack = this.OnPointUpCallBack;
			if (onPointUpCallBack == null)
			{
				return;
			}
			onPointUpCallBack(this, this.CurrentData);
		}
	}

	// Token: 0x06012F46 RID: 77638 RVA: 0x004B12F1 File Offset: 0x004AF4F1
	private void OnClickEvent()
	{
		if (this.CurrentData != null)
		{
			Action<PhantomBattleData, int> onClickCallBack = this.OnClickCallBack;
			if (onClickCallBack == null)
			{
				return;
			}
			onClickCallBack(this.CurrentData, this.CurrentIndex);
		}
	}

	// Token: 0x06012F47 RID: 77639 RVA: 0x004B1317 File Offset: 0x004AF517
	public void SetClickToggleEvent(Action<PhantomBattleData, int> call)
	{
		this.OnClickCallBack = call;
	}

	// Token: 0x06012F48 RID: 77640 RVA: 0x004B1320 File Offset: 0x004AF520
	public override void OnSelected(bool fireEvent)
	{
		if (this.GetItemGridExtendToggle().ToggleState != EToggleState.ETT_Checked)
		{
			this.SetSelected(true, false);
		}
		base.SetNewVisible(new bool?(false));
		if (this.CurrentData != null)
		{
			base.SetRedDotVisible(new bool?(PhantomBattleModel.Instance.GetMonsterSkinListHasNew(this.CurrentData.GetConfigId(false))));
			InventoryModel.Instance.RemoveNewAttributeItem(this.CurrentData.GetUniqueId());
			InventoryModel.Instance.SaveNewAttributeItemUniqueIdList();
		}
	}

	// Token: 0x06012F49 RID: 77641 RVA: 0x004B1399 File Offset: 0x004AF599
	public override void OnDeselected(bool fireEvent)
	{
		if (this.GetItemGridExtendToggle().ToggleState != EToggleState.ETT_UnChecked)
		{
			this.SetSelected(false, true);
		}
	}

	// Token: 0x06012F4A RID: 77642 RVA: 0x004B13B0 File Offset: 0x004AF5B0
	public void SetOnRefreshEvent(Action<VisionMediumItemGrid> call)
	{
		this.OnRefreshCallBack = call;
	}

	// Token: 0x06012F4B RID: 77643 RVA: 0x004B13B9 File Offset: 0x004AF5B9
	public bool CheckSelectedState(PhantomBattleData currentSelectData)
	{
		return currentSelectData == this.CurrentData;
	}

	// Token: 0x06012F4C RID: 77644 RVA: 0x004B13C8 File Offset: 0x004AF5C8
	protected override void OnRefresh(PhantomBattleData data, bool isSelected, int gridIndex)
	{
		this.CurrentData = data;
		this.CurrentIndex = gridIndex;
		InventoryModel instance = InventoryModel.Instance;
		int uniqueId = data.GetUniqueId();
		bool flag = instance.IsNewAttributeItem(uniqueId);
		PhantomItemData phantomItemData = instance.GetPhantomItemData(uniqueId);
		if (phantomItemData == null)
		{
			return;
		}
		List<VisionSlotData> currentSlotData = data.GetCurrentSlotData();
		int quality = data.GetQuality();
		bool value = !flag && PhantomBattleModel.Instance.GetMonsterSkinListHasNew(data.GetConfigId(false));
		MediumWarningPanelInfo warningPanelInfo = this.GetWarningPanelInfo(data);
		PhantomMediumItemGrid phantomMediumItemGrid = new PhantomMediumItemGrid
		{
			Data = data,
			ItemConfigId = new int?(data.GetConfigId(true)),
			BottomText = "+" + data.GetPhantomLevel().ToString(),
			StarLevel = new int?(quality),
			QualityId = new int?(quality),
			IsLockVisible = new bool?(phantomItemData.GetIsLock()),
			IsDeprecate = new bool?(phantomItemData.GetIsDeprecated()),
			IsRedDotVisible = new bool?(value),
			IsNewVisible = new bool?(flag),
			Level = new int?(data.GetCost()),
			IsLevelTextUseChangeColor = new bool?(true),
			FetterGroupId = new int?(data.GetFetterGroupId()),
			WarningPanelInfo = warningPanelInfo
		};
		phantomMediumItemGrid.StackDisplayInfo = new PhantomStackDisplay
		{
			StackCount = phantomItemData.GetStackCount(),
			SelectedCount = 0,
			CanStack = PhantomStackUtil.CanStackWithSameSpec(data)
		};
		if (currentSlotData.Count > 0)
		{
			VisionSlotData visionSlotData = currentSlotData[0];
			EVisionSlotState evisionSlotState = (visionSlotData != null) ? visionSlotData.SlotState : EVisionSlotState.UnlockAndNoProp;
			EVisionSlotState evisionSlotState2;
			if (currentSlotData.Count <= 1)
			{
				evisionSlotState2 = EVisionSlotState.UnlockAndNoProp;
			}
			else
			{
				VisionSlotData visionSlotData2 = currentSlotData[1];
				evisionSlotState2 = ((visionSlotData2 != null) ? visionSlotData2.SlotState : EVisionSlotState.UnlockAndNoProp);
			}
			EVisionSlotState evisionSlotState3 = evisionSlotState2;
			EVisionSlotState evisionSlotState4;
			if (currentSlotData.Count <= 2)
			{
				evisionSlotState4 = EVisionSlotState.UnlockAndNoProp;
			}
			else
			{
				VisionSlotData visionSlotData3 = currentSlotData[2];
				evisionSlotState4 = ((visionSlotData3 != null) ? visionSlotData3.SlotState : EVisionSlotState.UnlockAndNoProp);
			}
			EVisionSlotState evisionSlotState5 = evisionSlotState4;
			switch (quality)
			{
			case 3:
				phantomMediumItemGrid.VisionSlotStateList = new int[]
				{
					(int)evisionSlotState
				};
				break;
			case 4:
				phantomMediumItemGrid.VisionSlotStateList = new int[]
				{
					(int)evisionSlotState,
					(int)evisionSlotState3
				};
				break;
			case 5:
				phantomMediumItemGrid.VisionSlotStateList = new int[]
				{
					(int)evisionSlotState,
					(int)evisionSlotState3,
					(int)evisionSlotState5
				};
				break;
			}
		}
		if (PhantomBattleController.Instance.CheckIsEquip(uniqueId))
		{
			int? equipRole = PhantomBattleController.Instance.GetEquipRole(uniqueId);
			bool value2 = PhantomBattleModel.Instance.CheckPhantomIsMain(uniqueId);
			phantomMediumItemGrid.VisionRoleHeadInfo = new VisionRoleHeadInfo
			{
				RoleConfigId = equipRole,
				VisionUniqueId = new int?(uniqueId)
			};
			phantomMediumItemGrid.IsMainVisionVisible = new bool?(value2);
		}
		base.Apply<PhantomMediumItemGrid>(phantomMediumItemGrid);
		if (this.GetItemGridExtendToggle().ToggleState != EToggleState.ETT_UnChecked)
		{
			this.SetSelected(false, true);
		}
		Action<VisionMediumItemGrid> onRefreshCallBack = this.OnRefreshCallBack;
		if (onRefreshCallBack == null)
		{
			return;
		}
		onRefreshCallBack(this);
	}

	// Token: 0x06012F4D RID: 77645 RVA: 0x004B1670 File Offset: 0x004AF870
	[return: Nullable(2)]
	private MediumWarningPanelInfo GetWarningPanelInfo(PhantomBattleData data)
	{
		if (this.Source == ERoleViewSource.WheelTower)
		{
			int incrId = data.GetIncrId();
			EnergyInfo selectedEnergyInfo = WheelTowerModel.Instance.SelectedEnergyInfo;
			if (!selectedEnergyInfo.GetPhantomCanUse(incrId, this.RoleId))
			{
				int phantomOccupyRoleId = selectedEnergyInfo.GetPhantomOccupyRoleId(incrId, this.RoleId);
				Aki.Config.RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(phantomOccupyRoleId);
				string multiText = TextConfig.Instance.GetMultiText("WheelTower_Occupy_Tip", Array.Empty<string>());
				return new MediumWarningPanelInfo
				{
					TipText = multiText,
					IconPath = roleConfig.Value.Card
				};
			}
		}
		return null;
	}

	// Token: 0x04008EB7 RID: 36535
	[Nullable(2)]
	private PhantomBattleData CurrentData;

	// Token: 0x04008EB8 RID: 36536
	private int CurrentIndex;

	// Token: 0x04008EB9 RID: 36537
	public ERoleViewSource Source;

	// Token: 0x04008EBA RID: 36538
	public int RoleId;

	// Token: 0x04008EBB RID: 36539
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<PhantomBattleData, int> OnClickCallBack;

	// Token: 0x04008EBC RID: 36540
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<VisionMediumItemGrid> OnRefreshCallBack;

	// Token: 0x04008EBD RID: 36541
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Action<VisionMediumItemGrid, PhantomBattleData> OnPointDownCallBack;

	// Token: 0x04008EBE RID: 36542
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Action<VisionMediumItemGrid, PhantomBattleData> OnPointUpCallBack;
}
