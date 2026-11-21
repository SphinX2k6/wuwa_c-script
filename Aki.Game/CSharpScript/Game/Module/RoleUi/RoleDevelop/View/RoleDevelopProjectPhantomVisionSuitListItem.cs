using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop.View
{
	// Token: 0x02003D0E RID: 15630
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoleDevelopProjectPhantomVisionSuitListItem : LoopScrollSmallItemGrid<RoleDevelopPhantomVisionSuitListItemData>
	{
		// Token: 0x06028013 RID: 163859 RVA: 0x00B3290C File Offset: 0x00B30B0C
		protected override void OnRefresh(RoleDevelopPhantomVisionSuitListItemData data, bool isSelected, int gridIndex)
		{
			this.ItemData = data;
			if (data.RewardData != null)
			{
				this.RefreshRewardItem(data.RewardData);
				return;
			}
			if (data.MonsterData != null)
			{
				this.RefreshMonsterItem(data.MonsterData);
			}
		}

		// Token: 0x06028014 RID: 163860 RVA: 0x00B32940 File Offset: 0x00B30B40
		private void RefreshRewardItem(DropRewardItemData data)
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

		// Token: 0x06028015 RID: 163861 RVA: 0x00B329A8 File Offset: 0x00B30BA8
		private void RefreshMonsterItem(PhantomMonsterItemData data)
		{
			bool flag = HandBookModel.Instance.GetHandBookInfo(EHandBookTabType.Phantom, data.MonsterId) != null;
			CalabashDevelopReward? calabashDevelopRewardByMonsterId = CalabashConfig.Instance.GetCalabashDevelopRewardByMonsterId(data.MonsterId);
			if (calabashDevelopRewardByMonsterId == null)
			{
				return;
			}
			int? itemConfigId = null;
			if (data.QualityId > 0)
			{
				int[] phantomItemIdArrayByMonsterId = PhantomBattleModel.Instance.GetPhantomItemIdArrayByMonsterId(data.MonsterId);
				itemConfigId = new int?(phantomItemIdArrayByMonsterId[data.QualityId - 1]);
			}
			PhantomSmallItemGrid parameters = new PhantomSmallItemGrid
			{
				Data = data,
				ItemConfigId = itemConfigId,
				BottomText = "",
				IsNotFoundVisible = new bool?(!flag),
				MonsterId = new int?(calabashDevelopRewardByMonsterId.Value.MonsterInfoId),
				IconHidden = new bool?(!flag)
			};
			base.Apply<PhantomSmallItemGrid>(parameters);
		}

		// Token: 0x06028016 RID: 163862 RVA: 0x00B32A7C File Offset: 0x00B30C7C
		protected override void OnExtendToggleClicked()
		{
			RoleDevelopPhantomVisionSuitListItemData itemData = this.ItemData;
			if (itemData == null)
			{
				return;
			}
			if (itemData.RewardData != null)
			{
				ItemController.Instance.OpenItemTipsByItemId(itemData.RewardData.ItemId, true, null, false);
				return;
			}
			if (itemData.MonsterData != null)
			{
				AdventureGuideController.Instance.TryJumpToTargetViewByMonsterId(itemData.MonsterData.MonsterId, null);
			}
		}

		// Token: 0x06028017 RID: 163863 RVA: 0x00B32AD3 File Offset: 0x00B30CD3
		protected override bool OnCanExecuteChange()
		{
			return false;
		}

		// Token: 0x04015C7E RID: 89214
		private RoleDevelopPhantomVisionSuitListItemData ItemData;
	}
}
