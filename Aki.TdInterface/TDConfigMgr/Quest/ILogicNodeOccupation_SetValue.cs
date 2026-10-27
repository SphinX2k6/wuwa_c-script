using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001000 RID: 4096
	[NullableContext(1)]
	[Nullable(0)]
	public class ILogicNodeOccupation_SetValue
	{
		// Token: 0x0400371A RID: 14106
		public List<string> Occupations;

		// Token: 0x0400371B RID: 14107
		public string TidDesc;

		// Token: 0x0400371C RID: 14108
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> ExitActions;

		// Token: 0x0400371D RID: 14109
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> ReenterActions;

		// Token: 0x0400371E RID: 14110
		[Nullable(2)]
		public List<int> BanInteractEntities;

		// Token: 0x0400371F RID: 14111
		public bool? ReclaimOccupationWhenEnter;

		// Token: 0x04003720 RID: 14112
		[Nullable(2)]
		public string EdTidDesc;
	}
}
