using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Item;

// Token: 0x02000D18 RID: 3352
[NullableContext(2)]
[Nullable(0)]
public class PhantomConfirmMediumItemGrid : LoopScrollMediumItemGrid<int>
{
	// Token: 0x06008AE2 RID: 35554 RVA: 0x0029FF98 File Offset: 0x0029E198
	protected override void OnExtendToggleClicked()
	{
		ItemController.Instance.OpenItemTipsByItemUid(this.CurrentData.GetUniqueId(), this.CurrentData.GetConfigId(false), true, null);
	}

	// Token: 0x06008AE3 RID: 35555 RVA: 0x0029FFC0 File Offset: 0x0029E1C0
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

	// Token: 0x06008AE4 RID: 35556 RVA: 0x002A0145 File Offset: 0x0029E345
	public PhantomBattleData GetCurrentData()
	{
		return this.CurrentData;
	}

	// Token: 0x0400534B RID: 21323
	private PhantomBattleData CurrentData;
}
