using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Reward;

namespace CSharpScript.Game.Module.MingSu
{
	// Token: 0x020043AE RID: 17326
	public class DarkCoastDeliveryLevelData
	{
		// Token: 0x0602BC6F RID: 179311 RVA: 0x00C4B293 File Offset: 0x00C49493
		public DarkCoastDeliveryLevelData(DarkCoastDelivery config, int goal, int dropId)
		{
			this.Config = config;
			this.Id = config.Id;
			this.Goal = goal;
			this.DropId = dropId;
		}

		// Token: 0x0602BC70 RID: 179312 RVA: 0x00C4B2BD File Offset: 0x00C494BD
		private void InitRewardItems()
		{
			this.RewardItems = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(this.DropId);
		}

		// Token: 0x0602BC71 RID: 179313 RVA: 0x00C4B2D5 File Offset: 0x00C494D5
		public void SetDefeatedGuardState(bool state)
		{
			this.DefeatedGuard = state;
		}

		// Token: 0x0602BC72 RID: 179314 RVA: 0x00C4B2DE File Offset: 0x00C494DE
		public void SetReceivedGuardRewardState(bool state)
		{
			this.ReceivedGuardReward = state;
		}

		// Token: 0x0602BC73 RID: 179315 RVA: 0x00C4B2E7 File Offset: 0x00C494E7
		public void SetIsUnLockState(int level)
		{
			this.IsUnLock = (this.Id <= level);
		}

		// Token: 0x0602BC74 RID: 179316 RVA: 0x00C4B2FB File Offset: 0x00C494FB
		public bool GetIsUnLock()
		{
			return this.IsUnLock;
		}

		// Token: 0x0602BC75 RID: 179317 RVA: 0x00C4B303 File Offset: 0x00C49503
		public void SetReceiveRewardState(bool state)
		{
			this.IsReceiveReward = state;
		}

		// Token: 0x0602BC76 RID: 179318 RVA: 0x00C4B30C File Offset: 0x00C4950C
		public MingSuDefine.EDarkCoastDeliveryLevelDataState GetDarkCoastDeliveryGuardState()
		{
			if (this.ReceivedGuardReward)
			{
				return MingSuDefine.EDarkCoastDeliveryLevelDataState.Received;
			}
			if (this.DefeatedGuard)
			{
				return MingSuDefine.EDarkCoastDeliveryLevelDataState.Passed;
			}
			if (this.IsUnLock)
			{
				return MingSuDefine.EDarkCoastDeliveryLevelDataState.UnLock;
			}
			return MingSuDefine.EDarkCoastDeliveryLevelDataState.Lock;
		}

		// Token: 0x0602BC77 RID: 179319 RVA: 0x00C4B32D File Offset: 0x00C4952D
		public EActivityRewardState GetDarkCoastDeliveryRewardState()
		{
			if (this.IsReceiveReward)
			{
				return EActivityRewardState.Claimed;
			}
			if (this.IsUnLock)
			{
				return EActivityRewardState.Enable;
			}
			return EActivityRewardState.Disabled;
		}

		// Token: 0x0602BC78 RID: 179320 RVA: 0x00C4B344 File Offset: 0x00C49544
		[NullableContext(1)]
		public List<TItem> GetRewardItems()
		{
			if (this.RewardItems == null)
			{
				this.InitRewardItems();
			}
			return this.RewardItems;
		}

		// Token: 0x0401799A RID: 96666
		public readonly int Id;

		// Token: 0x0401799B RID: 96667
		public readonly DarkCoastDelivery Config;

		// Token: 0x0401799C RID: 96668
		private readonly int DropId;

		// Token: 0x0401799D RID: 96669
		public readonly int Goal;

		// Token: 0x0401799E RID: 96670
		private bool DefeatedGuard;

		// Token: 0x0401799F RID: 96671
		private bool ReceivedGuardReward;

		// Token: 0x040179A0 RID: 96672
		private bool IsUnLock;

		// Token: 0x040179A1 RID: 96673
		private bool IsReceiveReward;

		// Token: 0x040179A2 RID: 96674
		[Nullable(2)]
		private List<TItem> RewardItems;
	}
}
