using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004944 RID: 18756
	public enum ENodeStatusType : byte
	{
		// Token: 0x0400D0D5 RID: 53461
		NotActive,
		// Token: 0x0400D0D6 RID: 53462
		BeforeActivate,
		// Token: 0x0400D0D7 RID: 53463
		Activated,
		// Token: 0x0400D0D8 RID: 53464
		Completing,
		// Token: 0x0400D0D9 RID: 53465
		CompletedSuccess,
		// Token: 0x0400D0DA RID: 53466
		CompletedFailed,
		// Token: 0x0400D0DB RID: 53467
		Suspend,
		// Token: 0x0400D0DC RID: 53468
		Destroy
	}
}
