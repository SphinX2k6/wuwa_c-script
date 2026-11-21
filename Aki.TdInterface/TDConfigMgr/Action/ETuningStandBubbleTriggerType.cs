using System;
using CSharpScript.Core.Common;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001864 RID: 6244
	[EnumExtensions]
	public enum ETuningStandBubbleTriggerType
	{
		// Token: 0x0400537B RID: 21371
		Enter,
		// Token: 0x0400537C RID: 21372
		StartLink,
		// Token: 0x0400537D RID: 21373
		InvalidLink,
		// Token: 0x0400537E RID: 21374
		LinkUp,
		// Token: 0x0400537F RID: 21375
		LinkMiss,
		// Token: 0x04005380 RID: 21376
		LinkComplete,
		// Token: 0x04005381 RID: 21377
		Reset,
		// Token: 0x04005382 RID: 21378
		TooLong
	}
}
