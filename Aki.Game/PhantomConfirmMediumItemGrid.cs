using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Item;

// Token: 0x0200185F RID: 6239
[NullableContext(2)]
[Nullable(0)]
public class PhantomConfirmMediumItemGrid : LoopScrollMediumItemGrid<int>
{
	// Token: 0x0600B6F9 RID: 46841 RVA: 0x00295874 File Offset: 0x00293A74
	protected override void OnExtendToggleClicked()
	{
		ItemController.Instance.OpenItemTipsByItemUid(this.CurrentData.GetUniqueId(), this.CurrentData.GetConfigId(false), true, null);
	}

	// Token: 0x0600B6FA RID: 46842 RVA: 0x0029589C File Offset: 0x00293A9C
	protected override void OnRefresh(int uniqueId, bool isSelected, int gridIndex)
	{
		InventoryModel instance = InventoryModel.Instance;
		PhantomBattleData phantomBattleData = PhantomBattleModel.Instance.GetPhantomDataBase(uniqueId) as PhantomBattleData;
		if (phantomBattleData == null)
		{
			return;
		}
		this.CurrentData = phantomBattleData;
		PhantomItemData phantomItemData = instance.GetPhantomItemData(uniqueId);
		int quality = phantomBattleData.GetQuality();
		PhantomMediumItemGrid phantomMediumItemGrid = new PhantomMediumItemGrid
		{
			Data = phantomBattleData,
			ItemConfigId = new int?(phantomBattleData.GetConfigId(true)),
			BottomText = "+" + phantomBattleData.GetPhantomLevel().ToString(),
			StarLevel = new int?(quality),
			QualityId = new int?(quality),
			IsLockVisible = new bool?(phantomItemData.GetIsLock()),
			IsDeprecate = new bool?(phantomItemData.GetIsDeprecated()),
			IsRedDotVisible = new bool?(false),
			IsNewVisible = new bool?(false),
			Level = new int?(phantomBattleData.GetCost()),
			IsLevelTextUseChangeColor = new bool?(true),
			FetterGroupId = new int?(phantomBattleData.GetFetterGroupId())
		};
		phantomMediumItemGrid.StackDisplayInfo = new PhantomStackDisplay
		{
			StackCount = phantomItemData.GetStackCount(),
			SelectedCount = 0,
			CanStack = PhantomStackUtil.CanStackWithSameSpec(phantomBattleData)
		};
		if (PhantomBattleController.Instance.CheckIsEquip(uniqueId))
		{
			int? equipRole = PhantomBattleController.Instance.GetEquipRole(uniqueId);
			bool value = PhantomBattleModel.Instance.CheckPhantomIsMain(uniqueId);
			phantomMediumItemGrid.VisionRoleHeadInfo = new VisionRoleHeadInfo
			{
				RoleConfigId = equipRole,
				VisionUniqueId = new int?(uniqueId)
			};
			phantomMediumItemGrid.IsMainVisionVisible = new bool?(value);
		}
		base.Apply<PhantomMediumItemGrid>(phantomMediumItemGrid);
	}

	// Token: 0x0600B6FB RID: 46843 RVA: 0x00295A21 File Offset: 0x00293C21
	public PhantomBattleData GetCurrentData()
	{
		return this.CurrentData;
	}

	// Token: 0x040052A0 RID: 21152
	private PhantomBattleData CurrentData;
}
