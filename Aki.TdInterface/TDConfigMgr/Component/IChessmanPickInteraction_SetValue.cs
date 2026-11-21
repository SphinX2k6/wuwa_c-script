using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000263 RID: 611
	public class IChessmanPickInteraction_SetValue
	{
		// Token: 0x04000ACA RID: 2762
		public EPickInteraction Type;

		// Token: 0x04000ACB RID: 2763
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> CheckedActions;

		// Token: 0x04000ACC RID: 2764
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> UncheckedActions;

		// Token: 0x04000ACD RID: 2765
		public int TargetChessboard;

		// Token: 0x04000ACE RID: 2766
		[Nullable(2)]
		public string AvailablePosEffect;
	}
}
