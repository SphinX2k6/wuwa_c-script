using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200112C RID: 4396
	public class ILogicNodeOccupation_SetValue
	{
		// Token: 0x04003A52 RID: 14930
		public List<string> Occupations;

		// Token: 0x04003A53 RID: 14931
		public string TidDesc;

		// Token: 0x04003A54 RID: 14932
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> ExitActions;

		// Token: 0x04003A55 RID: 14933
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> ReenterActions;

		// Token: 0x04003A56 RID: 14934
		[Nullable(2)]
		public List<int> BanInteractEntities;

		// Token: 0x04003A57 RID: 14935
		public bool? ReclaimOccupationWhenEnter;

		// Token: 0x04003A58 RID: 14936
		[Nullable(2)]
		public string EdTidDesc;
	}
}
