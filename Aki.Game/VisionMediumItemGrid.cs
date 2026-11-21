using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.WheelTower;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.RoleUi;
using UnrealEngine;

// Token: 0x020019B8 RID: 6584
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class VisionMediumItemGrid : LoopScrollMediumItemGrid<PhantomBattleData>
{
	// Token: 0x06010400 RID: 66560 RVA: 0x004BEE64 File Offset: 0x004BD064
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

	// Token: 0x06010401 RID: 66561 RVA: 0x004BEE9C File Offset: 0x004BD09C
	public void SetOnPointDownCallBack(Action<VisionMediumItemGrid, PhantomBattleData> call)
	{
		this.OnPointDownCallBack = call;
	}

	// Token: 0x06010402 RID: 66562 RVA: 0x004BEEA5 File Offset: 0x004BD0A5
	public void SetOnPointUpCallBack(Action<VisionMediumItemGrid, PhantomBattleData> call)
	{
		this.OnPointUpCallBack = call;
	}

	// Token: 0x06010403 RID: 66563 RVA: 0x004BEEAE File Offset: 0x004BD0AE
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

	// Token: 0x06010404 RID: 66564 RVA: 0x004BEECF File Offset: 0x004BD0CF
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

	// Token: 0x06010405 RID: 66565 RVA: 0x004BEEF0 File Offset: 0x004BD0F0
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

	// Token: 0x06010406 RID: 66566 RVA: 0x004BEF16 File Offset: 0x004BD116
	public void SetClickToggleEvent(Action<PhantomBattleData, int> call)
	{
		this.OnClickCallBack = call;
	}

	// Token: 0x06010407 RID: 66567 RVA: 0x004BEF20 File Offset: 0x004BD120
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

	// Token: 0x06010408 RID: 66568 RVA: 0x004BEF99 File Offset: 0x004BD199
	public override void OnDeselected(bool fireEvent)
	{
		if (this.GetItemGridExtendToggle().ToggleState != EToggleState.ETT_UnChecked)
		{
			this.SetSelected(false, true);
		}
	}

	// Token: 0x06010409 RID: 66569 RVA: 0x004BEFB0 File Offset: 0x004BD1B0
	public void SetOnRefreshEvent(Action<VisionMediumItemGrid> call)
	{
		this.OnRefreshCallBack = call;
	}

	// Token: 0x0601040A RID: 66570 RVA: 0x004BEFB9 File Offset: 0x004BD1B9
	public bool CheckSelectedState(PhantomBattleData currentSelectData)
	{
		return currentSelectData == this.CurrentData;
	}

	// Token: 0x0601040B RID: 66571 RVA: 0x004BEFC8 File Offset: 0x004BD1C8
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

	// Token: 0x0601040C RID: 66572 RVA: 0x004BF270 File Offset: 0x004BD470
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

	// Token: 0x04009001 RID: 36865
	[Nullable(2)]
	private PhantomBattleData CurrentData;

	// Token: 0x04009002 RID: 36866
	private int CurrentIndex;

	// Token: 0x04009003 RID: 36867
	public ERoleViewSource Source;

	// Token: 0x04009004 RID: 36868
	public int RoleId;

	// Token: 0x04009005 RID: 36869
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<PhantomBattleData, int> OnClickCallBack;

	// Token: 0x04009006 RID: 36870
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<VisionMediumItemGrid> OnRefreshCallBack;

	// Token: 0x04009007 RID: 36871
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Action<VisionMediumItemGrid, PhantomBattleData> OnPointDownCallBack;

	// Token: 0x04009008 RID: 36872
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Action<VisionMediumItemGrid, PhantomBattleData> OnPointUpCallBack;
}
