using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;

// Token: 0x02001D87 RID: 7559
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RoleDevPhantomVisionSuitDisplayItem : LoopScrollSmallItemGrid<IRoleDevPhantomSuitDisplayItemData>
{
	// Token: 0x06012A9F RID: 76447 RVA: 0x0057E7DC File Offset: 0x0057C9DC
	protected override void OnRefresh(IRoleDevPhantomSuitDisplayItemData data, bool isSelected, int gridIndex)
	{
		this.ItemData = data;
		if (data.RewardData != null)
		{
			this.RefreshRewardItem(data.RewardData);
		}
		else if (data.MonsterData != null)
		{
			this.RefreshMonsterItem(data.MonsterData);
		}
		this.SetSelected(isSelected, false);
	}

	// Token: 0x06012AA0 RID: 76448 RVA: 0x0057E817 File Offset: 0x0057CA17
	public override void OnSelected(bool fireEvent)
	{
		this.SetSelected(true, false);
	}

	// Token: 0x06012AA1 RID: 76449 RVA: 0x0057E821 File Offset: 0x0057CA21
	public override void OnDeselected(bool fireEvent)
	{
		this.SetSelected(false, true);
	}

	// Token: 0x06012AA2 RID: 76450 RVA: 0x0057E82C File Offset: 0x0057CA2C
	private void RefreshRewardItem(IDropRewardItemData data)
	{
		if (InventoryConfig.Instance.GetItemConfigData(data.ItemId) == null)
		{
			return;
		}
		PropSmallItemGrid parameters = new PropSmallItemGrid
		{
			Data = data,
			BottomText = ((data.Count == 0) ? "" : data.Count.ToString()),
			ItemConfigId = new int?(data.ItemId)
		};
		base.Apply<PropSmallItemGrid>(parameters);
	}

	// Token: 0x06012AA3 RID: 76451 RVA: 0x0057E894 File Offset: 0x0057CA94
	protected override void OnExtendToggleClicked()
	{
		IRoleDevPhantomSuitDisplayItemData itemData = this.ItemData;
		IDropRewardItemData dropRewardItemData = (itemData != null) ? itemData.RewardData : null;
		if (dropRewardItemData != null)
		{
			ItemController.Instance.OpenItemTipsByItemId(dropRewardItemData.ItemId, true, null, false);
			return;
		}
		IRoleDevPhantomSuitDisplayItemData itemData2 = this.ItemData;
		IPhantomMonsterItemData phantomMonsterItemData = (itemData2 != null) ? itemData2.MonsterData : null;
		if (phantomMonsterItemData != null)
		{
			AdventureGuideController.Instance.TryJumpToTargetViewByMonsterId(phantomMonsterItemData.MonsterId, null);
		}
	}

	// Token: 0x06012AA4 RID: 76452 RVA: 0x0057E8F4 File Offset: 0x0057CAF4
	private void RefreshMonsterItem(IPhantomMonsterItemData data)
	{
		bool flag = HandBookModel.Instance.GetHandBookInfo(EHandBookTabType.Phantom, data.MonsterId) != null;
		RoleInstance roleInstanceById = RoleModel.Instance.GetRoleInstanceById(data.RoleId);
		int? visionRoleHeadInfo = null;
		if (roleInstanceById != null)
		{
			RolePhantomData phantomData = roleInstanceById.GetPhantomData();
			Dictionary<int, PhantomDataBase> dictionary = (phantomData != null) ? phantomData.GetDataMap() : null;
			if (dictionary != null)
			{
				foreach (KeyValuePair<int, PhantomDataBase> keyValuePair in dictionary)
				{
					PhantomDataBase value = keyValuePair.Value;
					if (value != null && value.GetConfig().MonsterId == data.MonsterId)
					{
						visionRoleHeadInfo = new int?(roleInstanceById.GetRoleId());
						break;
					}
				}
			}
		}
		CalabashDevelopReward? calabashDevelopRewardByMonsterId = CalabashConfig.Instance.GetCalabashDevelopRewardByMonsterId(data.MonsterId);
		if (calabashDevelopRewardByMonsterId == null)
		{
			return;
		}
		int? itemConfigId = null;
		if (data.QualityId > 0)
		{
			int[] phantomItemIdArrayByMonsterId = PhantomBattleModel.Instance.GetPhantomItemIdArrayByMonsterId(data.MonsterId);
			if (phantomItemIdArrayByMonsterId != null && phantomItemIdArrayByMonsterId.Length != 0 && data.QualityId - 1 < phantomItemIdArrayByMonsterId.Length)
			{
				itemConfigId = new int?(phantomItemIdArrayByMonsterId[data.QualityId - 1]);
			}
		}
		PhantomSmallItemGrid parameters = new PhantomSmallItemGrid
		{
			Data = data,
			ItemConfigId = itemConfigId,
			BottomText = "",
			IsNotFoundVisible = new bool?(!flag),
			MonsterId = new int?(calabashDevelopRewardByMonsterId.Value.MonsterInfoId),
			IconHidden = new bool?(!flag),
			VisionRoleHeadInfo = visionRoleHeadInfo
		};
		base.Apply<PhantomSmallItemGrid>(parameters);
	}

	// Token: 0x06012AA5 RID: 76453 RVA: 0x0057EA8C File Offset: 0x0057CC8C
	protected override bool OnCanExecuteChange()
	{
		return false;
	}

	// Token: 0x0400A210 RID: 41488
	[Nullable(2)]
	private IRoleDevPhantomSuitDisplayItemData ItemData;
}
