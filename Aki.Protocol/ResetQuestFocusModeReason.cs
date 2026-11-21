using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001690 RID: 5776
	public enum ResetQuestFocusModeReason
	{
		// Token: 0x0400C4F0 RID: 50416
		[OriginalName("EnterSealedArea")]
		EnterSealedArea,
		// Token: 0x0400C4F1 RID: 50417
		[OriginalName("ForceOccupyFail")]
		ForceOccupyFail,
		// Token: 0x0400C4F2 RID: 50418
		[OriginalName("EnterMultiMode")]
		EnterMultiMode,
		// Token: 0x0400C4F3 RID: 50419
		[OriginalName("BtSuspend")]
		BtSuspend,
		// Token: 0x0400C4F4 RID: 50420
		[OriginalName("EnterSpecialScene")]
		EnterSpecialScene,
		// Token: 0x0400C4F5 RID: 50421
		[OriginalName("ClientRequest")]
		ClientRequest,
		// Token: 0x0400C4F6 RID: 50422
		[OriginalName("QuestFinish")]
		QuestFinish,
		// Token: 0x0400C4F7 RID: 50423
		[OriginalName("LoginEventCheck")]
		LoginEventCheck,
		// Token: 0x0400C4F8 RID: 50424
		[OriginalName("GmRequest")]
		GmRequest
	}
}
