using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.MediumItemGrid;

// Token: 0x0200176E RID: 5998
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class VisionRefineMediumItemGrid : LoopScrollMediumItemGrid<PhantomItemData>
{
	// Token: 0x0600ADE9 RID: 44521 RVA: 0x00272FC7 File Offset: 0x002711C7
	protected override void OnStart()
	{
		base.OnStart();
		this.GetItemGridExtendToggle().FocusListenerDelegate.Bind(new Action(this.ShowItemTips));
	}

	// Token: 0x0600ADEA RID: 44522 RVA: 0x00272FEB File Offset: 0x002711EB
	protected override void OnBeforeDestroy()
	{
		base.OnBeforeDestroy();
		this.GetItemGridExtendToggle().FocusListenerDelegate.Unbind();
	}

	// Token: 0x0600ADEB RID: 44523 RVA: 0x00273003 File Offset: 0x00271203
	[NullableContext(1)]
	protected override void OnRefresh(PhantomItemData data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		this.RefreshPrivate(data);
	}

	// Token: 0x0600ADEC RID: 44524 RVA: 0x00273014 File Offset: 0x00271214
	[NullableContext(1)]
	private void RefreshPrivate(PhantomItemData data)
	{
		int uniqueId = data.GetUniqueId();
		PhantomBattleData phantomBattleData = PhantomBattleModel.Instance.GetPhantomBattleData(uniqueId);
		if (phantomBattleData == null)
		{
			return;
		}
		int itemDataType = (int)data.GetItemDataType();
		PropMediumItemGrid propMediumItemGrid = new PropMediumItemGrid
		{
			Data = data,
			ItemConfigId = new int?(data.GetConfigId()),
			IsLockVisible = new bool?(data.GetIsLock()),
			IsDeprecate = new bool?(data.GetIsDeprecated()),
			StarLevel = new int?(data.GetQuality())
		};
		if (itemDataType == 3)
		{
			PropMediumItemGrid propMediumItemGrid2 = propMediumItemGrid;
			Func<EVisionRefineRefineType> getRefineType = this.GetRefineType;
			EVisionRefineRefineType evisionRefineRefineType = (getRefineType != null) ? getRefineType() : EVisionRefineRefineType.Main;
			propMediumItemGrid2.ItemConfigId = new int?(phantomBattleData.GetConfigId(true));
			propMediumItemGrid2.QualityId = new int?(phantomBattleData.GetQuality());
			propMediumItemGrid2.Level = new int?(phantomBattleData.GetCost());
			propMediumItemGrid2.IsLevelTextUseChangeColor = new bool?(true);
			propMediumItemGrid2.BottomTextId = "VisionLevel";
			propMediumItemGrid2.BottomTextParameter = new object[]
			{
				phantomBattleData.GetPhantomLevel()
			};
			propMediumItemGrid2.VisionFetterGroupId = new int?(phantomBattleData.GetFetterGroupId());
			propMediumItemGrid2.IsOmitBottomText = new bool?(true);
			propMediumItemGrid2.IsDisable = new bool?(!phantomBattleData.GetVisionIfCanRefine(evisionRefineRefineType));
			bool flag = false;
			if (this.CheckSelectByView != null)
			{
				flag = this.CheckSelectByView(data);
			}
			if (evisionRefineRefineType != EVisionRefineRefineType.Main && !flag && PhantomBattleController.Instance.CheckIsEquip(uniqueId))
			{
				int uniqueId2 = phantomBattleData.GetUniqueId();
				int? equipRole = PhantomBattleController.Instance.GetEquipRole(uniqueId2);
				bool value = PhantomBattleModel.Instance.CheckPhantomIsMain(uniqueId2);
				propMediumItemGrid2.VisionRoleHeadInfo = new VisionRoleHeadInfo
				{
					RoleConfigId = equipRole,
					VisionUniqueId = new int?(uniqueId2)
				};
				propMediumItemGrid2.IsMainVisionVisible = new bool?(value);
			}
			Func<PhantomItemData, bool> checkFocusByView = this.CheckFocusByView;
			this.SetSelected((checkFocusByView != null) ? checkFocusByView(data) : flag, true);
			bool value2 = flag && phantomBattleData.GetVisionIfCanRefine(evisionRefineRefineType);
			if (evisionRefineRefineType != EVisionRefineRefineType.Main)
			{
				if (evisionRefineRefineType == EVisionRefineRefineType.Sub)
				{
					propMediumItemGrid2.ReduceButtonInfo = new LongPressButton
					{
						IsVisible = new bool?(false)
					};
					propMediumItemGrid2.IsWarning = new bool?(false);
					propMediumItemGrid2.IsGreenSelected = new bool?(value2);
				}
			}
			else
			{
				propMediumItemGrid2.ReduceButtonInfo = new LongPressButton
				{
					IsVisible = new bool?(value2)
				};
				bool value3 = false;
				if (this.CheckWarningByView != null)
				{
					value3 = this.CheckWarningByView(this.ItemData);
				}
				propMediumItemGrid2.IsWarning = new bool?(value3);
				propMediumItemGrid2.IsGreenSelected = new bool?(false);
			}
			Func<PhantomItemData, int> getSelectedCountByView = this.GetSelectedCountByView;
			int selectedCount = (getSelectedCountByView != null) ? getSelectedCountByView(data) : 0;
			propMediumItemGrid2.StackDisplayInfo = new PhantomStackDisplay
			{
				StackCount = data.GetStackCount(),
				SelectedCount = selectedCount,
				CanStack = PhantomStackUtil.CanStackWithSameSpec(phantomBattleData)
			};
		}
		else
		{
			propMediumItemGrid.BottomText = data.GetCount().ToString();
		}
		base.Apply<PropMediumItemGrid>(propMediumItemGrid);
	}

	// Token: 0x0600ADED RID: 44525 RVA: 0x002732DB File Offset: 0x002714DB
	[NullableContext(1)]
	public void RefreshByView(PhantomItemData data)
	{
		this.RefreshPrivate(data);
	}

	// Token: 0x0600ADEE RID: 44526 RVA: 0x002732E4 File Offset: 0x002714E4
	private void ShowItemTips()
	{
		PhantomItemData itemData = this.ItemData;
		if (itemData == null)
		{
			return;
		}
		EventSystem.Instance.Emit<int, int>(EEventName.OnSelectItemAdd, itemData.GetConfigId(), itemData.GetUniqueId());
	}

	// Token: 0x17000E70 RID: 3696
	// (get) Token: 0x0600ADEF RID: 44527 RVA: 0x00273318 File Offset: 0x00271518
	private PhantomItemData ItemData
	{
		get
		{
			return this.Data as PhantomItemData;
		}
	}

	// Token: 0x04004F04 RID: 20228
	public Func<PhantomItemData, bool> CheckSelectByView;

	// Token: 0x04004F05 RID: 20229
	public Func<PhantomItemData, bool> CheckFocusByView;

	// Token: 0x04004F06 RID: 20230
	public Func<PhantomItemData, bool> CheckWarningByView;

	// Token: 0x04004F07 RID: 20231
	public Func<PhantomItemData, int> GetSelectedCountByView;

	// Token: 0x04004F08 RID: 20232
	public Func<EVisionRefineRefineType> GetRefineType;
}
