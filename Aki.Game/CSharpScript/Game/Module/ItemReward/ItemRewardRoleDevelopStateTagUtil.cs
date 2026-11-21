using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi.RoleDevelop;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020047C1 RID: 18369
	[NullableContext(1)]
	[Nullable(0)]
	public class ItemRewardRoleDevelopStateTagUtil
	{
		// Token: 0x0602E253 RID: 189011 RVA: 0x00CDFD70 File Offset: 0x00CDDF70
		private static EItemRequirementState? GetRewardExpItemDevelopUpgradeState(int itemId)
		{
			IRoleDevelopExpStateProvider roleDevelopExpStateProvider = RoleDevelopModel.Instance as IRoleDevelopExpStateProvider;
			if (roleDevelopExpStateProvider == null)
			{
				return null;
			}
			Func<int, EItemRequirementState?> getExpItemRequirementState = roleDevelopExpStateProvider.GetExpItemRequirementState;
			if (getExpItemRequirementState == null)
			{
				return null;
			}
			return getExpItemRequirementState(itemId);
		}

		// Token: 0x0602E254 RID: 189012 RVA: 0x00CDFDB0 File Offset: 0x00CDDFB0
		private static ERoleDevelopStateTagType? ConvertRequirementStateToTagType(EItemRequirementState? state)
		{
			if (state != null)
			{
				switch (state.GetValueOrDefault())
				{
				case EItemRequirementState.Satisfied:
					return new ERoleDevelopStateTagType?(ERoleDevelopStateTagType.Completed);
				case EItemRequirementState.Supplement:
					return new ERoleDevelopStateTagType?(ERoleDevelopStateTagType.CanBeFilled);
				case EItemRequirementState.NotSatisfied:
					return new ERoleDevelopStateTagType?(ERoleDevelopStateTagType.Lack);
				}
			}
			return null;
		}

		// Token: 0x0602E255 RID: 189013 RVA: 0x00CDFE00 File Offset: 0x00CDE000
		private static ERoleDevelopStateTagType? GetRewardRoleDevelopStateTagType(RewardItemData rewardItemData)
		{
			RoleDevelopModel instance = RoleDevelopModel.Instance;
			RoleDevConfig instance2 = RoleDevConfig.Instance;
			if (instance == null || instance2 == null || instance.DevTargetRoleId == 0)
			{
				return null;
			}
			int configId = rewardItemData.ConfigId;
			if (!instance.IsDevelopRoleNeedItem(configId))
			{
				return null;
			}
			RoleDevItemJumpGroup? itemJumpGroupConfig = instance2.GetItemJumpGroupConfig(configId);
			int? num = (itemJumpGroupConfig != null) ? new int?(itemJumpGroupConfig.GetValueOrDefault().ItemType) : null;
			if (num.GetValueOrDefault() == 1 || num.GetValueOrDefault() == 2)
			{
				ERoleDevelopStateTagType? result = ItemRewardRoleDevelopStateTagUtil.ConvertRequirementStateToTagType(ItemRewardRoleDevelopStateTagUtil.GetRewardExpItemDevelopUpgradeState(configId));
				if (result != null)
				{
					return result;
				}
			}
			int developRoleNeedItemCount = instance.GetDevelopRoleNeedItemCount(configId);
			if (developRoleNeedItemCount <= 0)
			{
				return null;
			}
			if (InventoryModel.Instance.GetItemCountByConfigId(configId, 0) >= developRoleNeedItemCount)
			{
				return new ERoleDevelopStateTagType?(ERoleDevelopStateTagType.Completed);
			}
			if (instance.IsDevelopRoleNeedItemCanBeSupplemented(configId))
			{
				return new ERoleDevelopStateTagType?(ERoleDevelopStateTagType.CanBeFilled);
			}
			return new ERoleDevelopStateTagType?(ERoleDevelopStateTagType.Lack);
		}

		// Token: 0x0602E256 RID: 189014 RVA: 0x00CDFEF4 File Offset: 0x00CDE0F4
		public static void FillRewardRoleDevelopStateTagType(List<RewardItemData> rewardItemDataList)
		{
			RoleDevelopModel instance = RoleDevelopModel.Instance;
			if (instance == null || instance.DevTargetRoleId == 0)
			{
				return;
			}
			foreach (RewardItemData rewardItemData in rewardItemDataList)
			{
				ERoleDevelopStateTagType? rewardRoleDevelopStateTagType = ItemRewardRoleDevelopStateTagUtil.GetRewardRoleDevelopStateTagType(rewardItemData);
				if (rewardRoleDevelopStateTagType != null)
				{
					rewardItemData.SetRoleDevelopStateTagType(rewardRoleDevelopStateTagType);
				}
			}
		}
	}
}
