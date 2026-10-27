using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001734 RID: 5940
	public class ForceOccupations_SetValue
	{
		// Token: 0x0400502F RID: 20527
		public EOccupationActionType OccupationType;

		// Token: 0x04005030 RID: 20528
		[Nullable(1)]
		public List<string> Occupations;
	}
}
