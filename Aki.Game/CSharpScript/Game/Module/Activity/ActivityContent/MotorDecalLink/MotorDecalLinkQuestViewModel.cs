using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorDecalLink
{
	// Token: 0x020053B5 RID: 21429
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorDecalLinkQuestViewModel
	{
		// Token: 0x0401C1B5 RID: 115125
		public int TaskId;

		// Token: 0x0401C1B6 RID: 115126
		public int IpId;

		// Token: 0x0401C1B7 RID: 115127
		public int ActivityId;

		// Token: 0x0401C1B8 RID: 115128
		public int Current;

		// Token: 0x0401C1B9 RID: 115129
		public int Target = 1;

		// Token: 0x0401C1BA RID: 115130
		public EActivityTaskState Status = EActivityTaskState.Active;

		// Token: 0x0401C1BB RID: 115131
		public string TaskName = "";

		// Token: 0x0401C1BC RID: 115132
		public Dictionary<int, int> RewardInfo = new Dictionary<int, int>();

		// Token: 0x0401C1BD RID: 115133
		public int AccessId;
	}
}
