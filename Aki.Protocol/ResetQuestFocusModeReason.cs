using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200161D RID: 5661
	public enum ResetQuestFocusModeReason
	{
		// Token: 0x0400BFF6 RID: 49142
		[OriginalName("EnterSealedArea")]
		EnterSealedArea,
		// Token: 0x0400BFF7 RID: 49143
		[OriginalName("ForceOccupyFail")]
		ForceOccupyFail,
		// Token: 0x0400BFF8 RID: 49144
		[OriginalName("EnterMultiMode")]
		EnterMultiMode,
		// Token: 0x0400BFF9 RID: 49145
		[OriginalName("BtSuspend")]
		BtSuspend,
		// Token: 0x0400BFFA RID: 49146
		[OriginalName("EnterSpecialScene")]
		EnterSpecialScene,
		// Token: 0x0400BFFB RID: 49147
		[OriginalName("ClientRequest")]
		ClientRequest,
		// Token: 0x0400BFFC RID: 49148
		[OriginalName("QuestFinish")]
		QuestFinish,
		// Token: 0x0400BFFD RID: 49149
		[OriginalName("LoginEventCheck")]
		LoginEventCheck,
		// Token: 0x0400BFFE RID: 49150
		[OriginalName("GmRequest")]
		GmRequest
	}
}
