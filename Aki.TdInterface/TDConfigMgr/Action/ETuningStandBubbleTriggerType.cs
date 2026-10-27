using System;
using CSharpScript.Core.Common;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020016E8 RID: 5864
	[EnumExtensions]
	public enum ETuningStandBubbleTriggerType
	{
		// Token: 0x04004F4E RID: 20302
		Enter,
		// Token: 0x04004F4F RID: 20303
		StartLink,
		// Token: 0x04004F50 RID: 20304
		InvalidLink,
		// Token: 0x04004F51 RID: 20305
		LinkUp,
		// Token: 0x04004F52 RID: 20306
		LinkMiss,
		// Token: 0x04004F53 RID: 20307
		LinkComplete,
		// Token: 0x04004F54 RID: 20308
		Reset,
		// Token: 0x04004F55 RID: 20309
		TooLong
	}
}
