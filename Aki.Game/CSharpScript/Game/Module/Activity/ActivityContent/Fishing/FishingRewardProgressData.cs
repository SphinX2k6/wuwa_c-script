using System;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x020054FA RID: 21754
	public class FishingRewardProgressData
	{
		// Token: 0x06035EB9 RID: 220857 RVA: 0x00F0F510 File Offset: 0x00F0D710
		public FishingRewardProgressData(int id, int goal)
		{
			this.Id = id;
			this.Goal = goal;
		}

		// Token: 0x06035EBA RID: 220858 RVA: 0x00F0F526 File Offset: 0x00F0D726
		public bool IsFulfilled()
		{
			return this.State == SignState.Unlock || this.State == SignState.IsReceive;
		}

		// Token: 0x06035EBB RID: 220859 RVA: 0x00F0F53C File Offset: 0x00F0D73C
		public bool IsReceivable()
		{
			return this.State == SignState.Unlock;
		}

		// Token: 0x06035EBC RID: 220860 RVA: 0x00F0F547 File Offset: 0x00F0D747
		public bool IsDone()
		{
			return this.State == SignState.IsReceive;
		}

		// Token: 0x0401C7F9 RID: 116729
		public int Id;

		// Token: 0x0401C7FA RID: 116730
		public int Goal;

		// Token: 0x0401C7FB RID: 116731
		public SignState State;
	}
}
