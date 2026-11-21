using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RoadBook
{
	// Token: 0x02005146 RID: 20806
	public class FinalTravelTaskData
	{
		// Token: 0x1700658A RID: 25994
		// (get) Token: 0x06034072 RID: 213106 RVA: 0x00E8E0BE File Offset: 0x00E8C2BE
		public int Current
		{
			get
			{
				return this.FinishedIdSet.Count;
			}
		}

		// Token: 0x06034073 RID: 213107 RVA: 0x00E8E0CB File Offset: 0x00E8C2CB
		public bool CanReceive()
		{
			return !this.IsReceived && this.Current == this.Target;
		}

		// Token: 0x0401B869 RID: 112745
		public int Target = 1;

		// Token: 0x0401B86A RID: 112746
		[Nullable(1)]
		public HashSet<int> FinishedIdSet = new HashSet<int>();

		// Token: 0x0401B86B RID: 112747
		public bool IsReceived;
	}
}
