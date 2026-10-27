using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Reward;

namespace CSharpScript.Game.Module.MingSu
{
	// Token: 0x020053CB RID: 21451
	public class DarkCoastDeliveryLevelData
	{
		// Token: 0x06036D29 RID: 224553 RVA: 0x00CFC1EB File Offset: 0x00CFA3EB
		public DarkCoastDeliveryLevelData(DarkCoastDelivery config, int goal, int dropId)
		{
			this.Config = config;
			this.Id = config.Id;
			this.Goal = goal;
			this.DropId = dropId;
		}

		// Token: 0x06036D2A RID: 224554 RVA: 0x00CFC215 File Offset: 0x00CFA415
		private void InitRewardItems()
		{
			this.RewardItems = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(this.DropId);
		}

		// Token: 0x06036D2B RID: 224555 RVA: 0x00CFC22D File Offset: 0x00CFA42D
		public void SetDefeatedGuardState(bool state)
		{
			this.DefeatedGuard = state;
		}

		// Token: 0x06036D2C RID: 224556 RVA: 0x00CFC236 File Offset: 0x00CFA436
		public void SetReceivedGuardRewardState(bool state)
		{
			this.ReceivedGuardReward = state;
		}

		// Token: 0x06036D2D RID: 224557 RVA: 0x00CFC23F File Offset: 0x00CFA43F
		public void SetIsUnLockState(int level)
		{
			this.IsUnLock = (this.Id <= level);
		}

		// Token: 0x06036D2E RID: 224558 RVA: 0x00CFC253 File Offset: 0x00CFA453
		public bool GetIsUnLock()
		{
			return this.IsUnLock;
		}

		// Token: 0x06036D2F RID: 224559 RVA: 0x00CFC25B File Offset: 0x00CFA45B
		public void SetReceiveRewardState(bool state)
		{
			this.IsReceiveReward = state;
		}

		// Token: 0x06036D30 RID: 224560 RVA: 0x00CFC264 File Offset: 0x00CFA464
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

		// Token: 0x06036D31 RID: 224561 RVA: 0x00CFC285 File Offset: 0x00CFA485
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

		// Token: 0x06036D32 RID: 224562 RVA: 0x00CFC29C File Offset: 0x00CFA49C
		[NullableContext(1)]
		public List<TItem> GetRewardItems()
		{
			if (this.RewardItems == null)
			{
				this.InitRewardItems();
			}
			return this.RewardItems;
		}

		// Token: 0x0401CF02 RID: 118530
		public readonly int Id;

		// Token: 0x0401CF03 RID: 118531
		public readonly DarkCoastDelivery Config;

		// Token: 0x0401CF04 RID: 118532
		private readonly int DropId;

		// Token: 0x0401CF05 RID: 118533
		public readonly int Goal;

		// Token: 0x0401CF06 RID: 118534
		private bool DefeatedGuard;

		// Token: 0x0401CF07 RID: 118535
		private bool ReceivedGuardReward;

		// Token: 0x0401CF08 RID: 118536
		private bool IsUnLock;

		// Token: 0x0401CF09 RID: 118537
		private bool IsReceiveReward;

		// Token: 0x0401CF0A RID: 118538
		[Nullable(2)]
		private List<TItem> RewardItems;
	}
}
