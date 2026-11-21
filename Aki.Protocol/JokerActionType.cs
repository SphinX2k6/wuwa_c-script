using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001655 RID: 5717
	public enum JokerActionType
	{
		// Token: 0x0400C2B4 RID: 49844
		[OriginalName("EnterNewRound")]
		EnterNewRound,
		// Token: 0x0400C2B5 RID: 49845
		[OriginalName("DrawCard")]
		DrawCard,
		// Token: 0x0400C2B6 RID: 49846
		[OriginalName("PlayCard")]
		PlayCard,
		// Token: 0x0400C2B7 RID: 49847
		[OriginalName("TriggerSkill")]
		TriggerSkill,
		// Token: 0x0400C2B8 RID: 49848
		[OriginalName("ExecSkill")]
		ExecSkill,
		// Token: 0x0400C2B9 RID: 49849
		[OriginalName("SettleResult")]
		SettleResult,
		// Token: 0x0400C2BA RID: 49850
		[OriginalName("HealthHpRefresh")]
		HealthHpRefresh,
		// Token: 0x0400C2BB RID: 49851
		[OriginalName("DisPlayCard")]
		DisPlayCard
	}
}
