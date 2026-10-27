using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop.View
{
	// Token: 0x02004D45 RID: 19781
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoleDevelopProjectPhantomVisionSuitListItem : LoopScrollSmallItemGrid<RoleDevelopPhantomVisionSuitListItemData>
	{
		// Token: 0x060331B0 RID: 209328 RVA: 0x00BE95E9 File Offset: 0x00BE77E9
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

		// Token: 0x060331B1 RID: 209329 RVA: 0x00BE961C File Offset: 0x00BE781C
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

		// Token: 0x060331B2 RID: 209330 RVA: 0x00BE9684 File Offset: 0x00BE7884
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

		// Token: 0x060331B3 RID: 209331 RVA: 0x00BE9758 File Offset: 0x00BE7958
		protected override void OnExtendToggleClicked()
		{
			RoleDevelopPhantomVisionSuitListItemData itemData = this.ItemData;
			if (itemData == null)
			{
				return;
			}
			if (itemData.RewardData != null)
			{
				ItemController.Instance.OpenItemTipsByItemId(itemData.RewardData.ItemId, true, null);
				return;
			}
			if (itemData.MonsterData != null)
			{
				AdventureGuideController.Instance.TryJumpToTargetViewByMonsterId(itemData.MonsterData.MonsterId, null);
			}
		}

		// Token: 0x060331B4 RID: 209332 RVA: 0x00BE97AE File Offset: 0x00BE79AE
		protected override bool OnCanExecuteChange()
		{
			return false;
		}

		// Token: 0x0401B2AD RID: 111277
		private RoleDevelopPhantomVisionSuitListItemData ItemData;
	}
}
