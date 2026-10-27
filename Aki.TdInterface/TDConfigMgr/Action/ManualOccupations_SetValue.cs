using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020D2 RID: 8402
	public class ManualOccupations_SetValue
	{
		// Token: 0x04006E9E RID: 28318
		public EOccupationActionType OccupationType;

		// Token: 0x04006E9F RID: 28319
		[Nullable(1)]
		public List<string> Occupations;
	}
}
