using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorDecalLink
{
	// Token: 0x02006437 RID: 25655
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorDecalLinkQuestViewModel
	{
		// Token: 0x04021886 RID: 137350
		public int TaskId;

		// Token: 0x04021887 RID: 137351
		public int IpId;

		// Token: 0x04021888 RID: 137352
		public int ActivityId;

		// Token: 0x04021889 RID: 137353
		public int Current;

		// Token: 0x0402188A RID: 137354
		public int Target = 1;

		// Token: 0x0402188B RID: 137355
		public EActivityTaskState Status = EActivityTaskState.Active;

		// Token: 0x0402188C RID: 137356
		public string TaskName = "";

		// Token: 0x0402188D RID: 137357
		public Dictionary<int, int> RewardInfo = new Dictionary<int, int>();

		// Token: 0x0402188E RID: 137358
		public int AccessId;
	}
}
