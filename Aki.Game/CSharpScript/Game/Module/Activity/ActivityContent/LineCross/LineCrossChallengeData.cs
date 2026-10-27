using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.LineCross
{
	// Token: 0x0200655F RID: 25951
	public class LineCrossChallengeData
	{
		// Token: 0x0604107D RID: 266365 RVA: 0x00FC2D51 File Offset: 0x00FC0F51
		public int GetId()
		{
			return this.Id;
		}

		// Token: 0x0604107E RID: 266366 RVA: 0x00FC2D59 File Offset: 0x00FC0F59
		public bool GetHasGetReward()
		{
			return this.HasGetReward;
		}

		// Token: 0x0604107F RID: 266367 RVA: 0x00FC2D61 File Offset: 0x00FC0F61
		public long GetOpenTime()
		{
			return this.OpenTime / 1000L;
		}

		// Token: 0x06041080 RID: 266368 RVA: 0x00FC2D70 File Offset: 0x00FC0F70
		public int GetRewardId()
		{
			return this.RewardId;
		}

		// Token: 0x06041081 RID: 266369 RVA: 0x00FC2D78 File Offset: 0x00FC0F78
		public int GetEntityConfigId()
		{
			return this.EntityConfigId;
		}

		// Token: 0x06041082 RID: 266370 RVA: 0x00FC2D80 File Offset: 0x00FC0F80
		public bool GetPreChallengeState()
		{
			return this.PreChallengeState;
		}

		// Token: 0x06041083 RID: 266371 RVA: 0x00FC2D88 File Offset: 0x00FC0F88
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

		// Token: 0x04021E68 RID: 138856
		private int Id;

		// Token: 0x04021E69 RID: 138857
		private bool HasGetReward;

		// Token: 0x04021E6A RID: 138858
		private long OpenTime;

		// Token: 0x04021E6B RID: 138859
		private int RewardId;

		// Token: 0x04021E6C RID: 138860
		private int EntityConfigId;

		// Token: 0x04021E6D RID: 138861
		private bool PreChallengeState;
	}
}
