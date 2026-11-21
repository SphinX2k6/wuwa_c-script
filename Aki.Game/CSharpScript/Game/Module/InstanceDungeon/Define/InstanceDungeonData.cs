using System;
using Aki.Config;

namespace CSharpScript.Game.Module.InstanceDungeon.Define
{
	// Token: 0x02004891 RID: 18577
	public class InstanceDungeonData
	{
		// Token: 0x0602EB45 RID: 191301 RVA: 0x00D08F5C File Offset: 0x00D0715C
		public InstanceDungeonData(int shareId)
		{
			this.ShareId = shareId;
			InstanceEnterControl? countConfig = InstanceDungeonConfig.Instance.GetCountConfig(this.ShareId);
			this.LimitChallengeTimes = ((countConfig != null) ? countConfig.GetValueOrDefault().EnterCount : 0);
			this.CostTypeInternal = (EInstanceCostType)((countConfig != null) ? countConfig.GetValueOrDefault().EnterCountConsumeType : 0);
		}

		// Token: 0x17005E6A RID: 24170
		// (get) Token: 0x0602EB46 RID: 191302 RVA: 0x00D08FC9 File Offset: 0x00D071C9
		// (set) Token: 0x0602EB47 RID: 191303 RVA: 0x00D08FD1 File Offset: 0x00D071D1
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

		// Token: 0x17005E6B RID: 24171
		// (get) Token: 0x0602EB48 RID: 191304 RVA: 0x00D08FDA File Offset: 0x00D071DA
		public EInstanceCostType CostType
		{
			get
			{
				return this.CostTypeInternal;
			}
		}

		// Token: 0x17005E6C RID: 24172
		// (get) Token: 0x0602EB49 RID: 191305 RVA: 0x00D08FE2 File Offset: 0x00D071E2
		public int LimitChallengedTimes
		{
			get
			{
				return this.LimitChallengeTimes;
			}
		}

		// Token: 0x17005E6D RID: 24173
		// (get) Token: 0x0602EB4A RID: 191306 RVA: 0x00D08FEC File Offset: 0x00D071EC
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

		// Token: 0x17005E6E RID: 24174
		// (get) Token: 0x0602EB4B RID: 191307 RVA: 0x00D0900E File Offset: 0x00D0720E
		public bool CanRepeatChallenge
		{
			get
			{
				return this.LimitChallengedTimes <= 0;
			}
		}

		// Token: 0x17005E6F RID: 24175
		// (get) Token: 0x0602EB4C RID: 191308 RVA: 0x00D0901C File Offset: 0x00D0721C
		public bool CanChallenge
		{
			get
			{
				return this.CanRepeatChallenge || (this.CostTypeInternal == EInstanceCostType.ComeTimeNotReward || this.CostTypeInternal == EInstanceCostType.RewardTimeNotReward) || this.ChallengedTimes < this.LimitChallengedTimes;
			}
		}

		// Token: 0x17005E70 RID: 24176
		// (get) Token: 0x0602EB4D RID: 191309 RVA: 0x00D0904C File Offset: 0x00D0724C
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

		// Token: 0x04018D30 RID: 101680
		private readonly int ShareId;

		// Token: 0x04018D31 RID: 101681
		private readonly int LimitChallengeTimes;

		// Token: 0x04018D32 RID: 101682
		private readonly EInstanceCostType CostTypeInternal;

		// Token: 0x04018D33 RID: 101683
		private int ChallengedTimesInternal;
	}
}
