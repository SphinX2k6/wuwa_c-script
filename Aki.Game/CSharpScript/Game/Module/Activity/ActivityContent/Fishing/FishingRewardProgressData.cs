using System;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x0200657C RID: 25980
	public class FishingRewardProgressData
	{
		// Token: 0x060411F4 RID: 266740 RVA: 0x00FC855C File Offset: 0x00FC675C
		public FishingRewardProgressData(int id, int goal)
		{
			this.Id = id;
			this.Goal = goal;
		}

		// Token: 0x060411F5 RID: 266741 RVA: 0x00FC8572 File Offset: 0x00FC6772
		public bool IsFulfilled()
		{
			return this.State == SignState.Unlock || this.State == SignState.IsReceive;
		}

		// Token: 0x060411F6 RID: 266742 RVA: 0x00FC8588 File Offset: 0x00FC6788
		public bool IsReceivable()
		{
			return this.State == SignState.Unlock;
		}

		// Token: 0x060411F7 RID: 266743 RVA: 0x00FC8593 File Offset: 0x00FC6793
		public bool IsDone()
		{
			return this.State == SignState.IsReceive;
		}

		// Token: 0x04021EC8 RID: 138952
		public int Id;

		// Token: 0x04021EC9 RID: 138953
		public int Goal;

		// Token: 0x04021ECA RID: 138954
		public SignState State;
	}
}
