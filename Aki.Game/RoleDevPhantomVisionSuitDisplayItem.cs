using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;

// Token: 0x0200280C RID: 10252
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RoleDevPhantomVisionSuitDisplayItem : LoopScrollSmallItemGrid<IRoleDevPhantomSuitDisplayItemData>
{
	// Token: 0x0601509F RID: 86175 RVA: 0x00553A08 File Offset: 0x00551C08
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

	// Token: 0x060150A0 RID: 86176 RVA: 0x00553A43 File Offset: 0x00551C43
	public override void OnSelected(bool fireEvent)
	{
		this.SetSelected(true, false);
	}

	// Token: 0x060150A1 RID: 86177 RVA: 0x00553A4D File Offset: 0x00551C4D
	public override void OnDeselected(bool fireEvent)
	{
		this.SetSelected(false, true);
	}

	// Token: 0x060150A2 RID: 86178 RVA: 0x00553A58 File Offset: 0x00551C58
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

	// Token: 0x060150A3 RID: 86179 RVA: 0x00553AC0 File Offset: 0x00551CC0
	protected override void OnExtendToggleClicked()
	{
		IRoleDevPhantomSuitDisplayItemData itemData = this.ItemData;
		IDropRewardItemData dropRewardItemData = (itemData != null) ? itemData.RewardData : null;
		if (dropRewardItemData != null)
		{
			ItemController.Instance.OpenItemTipsByItemId(dropRewardItemData.ItemId, true, null);
			return;
		}
		IRoleDevPhantomSuitDisplayItemData itemData2 = this.ItemData;
		IPhantomMonsterItemData phantomMonsterItemData = (itemData2 != null) ? itemData2.MonsterData : null;
		if (phantomMonsterItemData != null)
		{
			AdventureGuideController.Instance.TryJumpToTargetViewByMonsterId(phantomMonsterItemData.MonsterId, null);
		}
	}

	// Token: 0x060150A4 RID: 86180 RVA: 0x00553B20 File Offset: 0x00551D20
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

	// Token: 0x060150A5 RID: 86181 RVA: 0x00553CB8 File Offset: 0x00551EB8
	protected override bool OnCanExecuteChange()
	{
		return false;
	}

	// Token: 0x04009E27 RID: 40487
	[Nullable(2)]
	private IRoleDevPhantomSuitDisplayItemData ItemData;
}
