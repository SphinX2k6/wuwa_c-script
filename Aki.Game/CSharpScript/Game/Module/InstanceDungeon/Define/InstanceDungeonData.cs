using System;
using Aki.Config;

namespace CSharpScript.Game.Module.InstanceDungeon.Define
{
	// Token: 0x020058B9 RID: 22713
	public class InstanceDungeonData
	{
		// Token: 0x06039C22 RID: 236578 RVA: 0x00DBA044 File Offset: 0x00DB8244
		public InstanceDungeonData(int shareId)
		{
			this.ShareId = shareId;
			InstanceEnterControl? countConfig = InstanceDungeonConfig.Instance.GetCountConfig(this.ShareId);
			this.LimitChallengeTimes = ((countConfig != null) ? countConfig.GetValueOrDefault().EnterCount : 0);
			this.CostTypeInternal = (EInstanceCostType)((countConfig != null) ? countConfig.GetValueOrDefault().EnterCountConsumeType : 0);
		}

		// Token: 0x17008A9E RID: 35486
		// (get) Token: 0x06039C23 RID: 236579 RVA: 0x00DBA0B1 File Offset: 0x00DB82B1
		// (set) Token: 0x06039C24 RID: 236580 RVA: 0x00DBA0B9 File Offset: 0x00DB82B9
		public int ChallengedTimes
		{
			get
			{
				return this.ChallengedTimesInternal;
			}
			set
			{
				this.ChallengedTimesInternal = value;
			}
		}

		// Token: 0x17008A9F RID: 35487
		// (get) Token: 0x06039C25 RID: 236581 RVA: 0x00DBA0C2 File Offset: 0x00DB82C2
		public EInstanceCostType CostType
		{
			get
			{
				return this.CostTypeInternal;
			}
		}

		// Token: 0x17008AA0 RID: 35488
		// (get) Token: 0x06039C26 RID: 236582 RVA: 0x00DBA0CA File Offset: 0x00DB82CA
		public int LimitChallengedTimes
		{
			get
			{
				return this.LimitChallengeTimes;
			}
		}

		// Token: 0x17008AA1 RID: 35489
		// (get) Token: 0x06039C27 RID: 236583 RVA: 0x00DBA0D4 File Offset: 0x00DB82D4
		public int LeftChallengedTimes
		{
			get
			{
				int num = this.LimitChallengedTimes - this.ChallengedTimesInternal;
				if (num < 0)
				{
					return 0;
				}
				return num;
			}
		}

		// Token: 0x17008AA2 RID: 35490
		// (get) Token: 0x06039C28 RID: 236584 RVA: 0x00DBA0F6 File Offset: 0x00DB82F6
		public bool CanRepeatChallenge
		{
			get
			{
				return this.LimitChallengedTimes <= 0;
			}
		}

		// Token: 0x17008AA3 RID: 35491
		// (get) Token: 0x06039C29 RID: 236585 RVA: 0x00DBA104 File Offset: 0x00DB8304
		public bool CanChallenge
		{
			get
			{
				return this.CanRepeatChallenge || (this.CostTypeInternal == EInstanceCostType.ComeTimeNotReward || this.CostTypeInternal == EInstanceCostType.RewardTimeNotReward) || this.ChallengedTimes < this.LimitChallengedTimes;
			}
		}

		// Token: 0x17008AA4 RID: 35492
		// (get) Token: 0x06039C2A RID: 236586 RVA: 0x00DBA134 File Offset: 0x00DB8334
		public bool CanReward
		{
			get
			{
				if (this.CanRepeatChallenge)
				{
					return true;
				}
				if (this.CostTypeInternal == EInstanceCostType.ComeTimeNotComing || this.CostTypeInternal == EInstanceCostType.RewardTimeNotComing)
				{
					return true;
				}
				if (this.CostTypeInternal == EInstanceCostType.ComeTimeNotReward)
				{
					return this.ChallengedTimes <= this.LimitChallengedTimes;
				}
				return this.ChallengedTimes < this.LimitChallengedTimes;
			}
		}

		// Token: 0x0401E293 RID: 123539
		private readonly int ShareId;

		// Token: 0x0401E294 RID: 123540
		private readonly int LimitChallengeTimes;

		// Token: 0x0401E295 RID: 123541
		private readonly EInstanceCostType CostTypeInternal;

		// Token: 0x0401E296 RID: 123542
		private int ChallengedTimesInternal;
	}
}
