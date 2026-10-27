using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200023C RID: 572
	public class IChessmanPickInteraction_SetValue
	{
		// Token: 0x04000A40 RID: 2624
		public EPickInteraction Type;

		// Token: 0x04000A41 RID: 2625
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> CheckedActions;

		// Token: 0x04000A42 RID: 2626
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> UncheckedActions;

		// Token: 0x04000A43 RID: 2627
		public int TargetChessboard;

		// Token: 0x04000A44 RID: 2628
		[Nullable(2)]
		public string AvailablePosEffect;
	}
}
