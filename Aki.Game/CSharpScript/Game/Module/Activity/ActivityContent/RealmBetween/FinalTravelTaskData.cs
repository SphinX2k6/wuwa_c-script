using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RealmBetween
{
	// Token: 0x0200626B RID: 25195
	public class FinalTravelTaskData
	{
		// Token: 0x1700926B RID: 37483
		// (get) Token: 0x0603F729 RID: 259881 RVA: 0x00F56887 File Offset: 0x00F54A87
		public int Current
		{
			get
			{
				return this.FinishedIdSet.Count;
			}
		}

		// Token: 0x0603F72A RID: 259882 RVA: 0x00F56894 File Offset: 0x00F54A94
		public bool CanReceive()
		{
			return !this.IsReceived && this.Current == this.Target;
		}

		// Token: 0x04021248 RID: 135752
		public int Target = 1;

		// Token: 0x04021249 RID: 135753
		[Nullable(1)]
		public HashSet<int> FinishedIdSet = new HashSet<int>();

		// Token: 0x0402124A RID: 135754
		public bool IsReceived;
	}
}
