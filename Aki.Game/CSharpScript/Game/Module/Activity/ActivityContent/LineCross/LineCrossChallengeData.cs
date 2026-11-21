using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.LineCross
{
	// Token: 0x020054DD RID: 21725
	public class LineCrossChallengeData
	{
		// Token: 0x06035D42 RID: 220482 RVA: 0x00F09D39 File Offset: 0x00F07F39
		public int GetId()
		{
			return this.Id;
		}

		// Token: 0x06035D43 RID: 220483 RVA: 0x00F09D41 File Offset: 0x00F07F41
		public bool GetHasGetReward()
		{
			return this.HasGetReward;
		}

		// Token: 0x06035D44 RID: 220484 RVA: 0x00F09D49 File Offset: 0x00F07F49
		public long GetOpenTime()
		{
			return this.OpenTime / 1000L;
		}

		// Token: 0x06035D45 RID: 220485 RVA: 0x00F09D58 File Offset: 0x00F07F58
		public int GetRewardId()
		{
			return this.RewardId;
		}

		// Token: 0x06035D46 RID: 220486 RVA: 0x00F09D60 File Offset: 0x00F07F60
		public int GetEntityConfigId()
		{
			return this.EntityConfigId;
		}

		// Token: 0x06035D47 RID: 220487 RVA: 0x00F09D68 File Offset: 0x00F07F68
		public bool GetPreChallengeState()
		{
			return this.PreChallengeState;
		}

		// Token: 0x06035D48 RID: 220488 RVA: 0x00F09D70 File Offset: 0x00F07F70
		[NullableContext(1)]
		public void Phrase(LineCrossChallengeData data)
		{
			this.Id = data.ChallengeId;
			this.HasGetReward = data.Rewarded;
			this.OpenTime = data.OpenTime;
			this.RewardId = data.RewardId;
			this.EntityConfigId = data.EntityConfigId;
			this.PreChallengeState = data.PreChallenged;
		}

		// Token: 0x0401C799 RID: 116633
		private int Id;

		// Token: 0x0401C79A RID: 116634
		private bool HasGetReward;

		// Token: 0x0401C79B RID: 116635
		private long OpenTime;

		// Token: 0x0401C79C RID: 116636
		private int RewardId;

		// Token: 0x0401C79D RID: 116637
		private int EntityConfigId;

		// Token: 0x0401C79E RID: 116638
		private bool PreChallengeState;
	}
}
