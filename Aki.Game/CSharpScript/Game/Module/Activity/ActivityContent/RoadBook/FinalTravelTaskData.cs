using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RoadBook
{
	// Token: 0x020061C8 RID: 25032
	public class FinalTravelTaskData
	{
		// Token: 0x17009228 RID: 37416
		// (get) Token: 0x0603F3B1 RID: 258993 RVA: 0x00F47166 File Offset: 0x00F45366
		public int Current
		{
			get
			{
				return this.FinishedIdSet.Count;
			}
		}

		// Token: 0x0603F3B2 RID: 258994 RVA: 0x00F47173 File Offset: 0x00F45373
		public bool CanReceive()
		{
			return !this.IsReceived && this.Current == this.Target;
		}

		// Token: 0x04020F3A RID: 134970
		public int Target = 1;

		// Token: 0x04020F3B RID: 134971
		[Nullable(1)]
		public HashSet<int> FinishedIdSet = new HashSet<int>();

		// Token: 0x04020F3C RID: 134972
		public bool IsReceived;
	}
}
