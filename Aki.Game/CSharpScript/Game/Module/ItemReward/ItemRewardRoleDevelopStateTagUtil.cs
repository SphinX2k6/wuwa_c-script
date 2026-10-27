using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi.RoleDevelop;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020057EA RID: 22506
	[NullableContext(1)]
	[Nullable(0)]
	public class ItemRewardRoleDevelopStateTagUtil
	{
		// Token: 0x0603933F RID: 234303 RVA: 0x00D90F28 File Offset: 0x00D8F128
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

		// Token: 0x06039340 RID: 234304 RVA: 0x00D90F68 File Offset: 0x00D8F168
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

		// Token: 0x06039341 RID: 234305 RVA: 0x00D90FB8 File Offset: 0x00D8F1B8
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

		// Token: 0x06039342 RID: 234306 RVA: 0x00D910AC File Offset: 0x00D8F2AC
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
