using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020015E3 RID: 5603
	public enum JokerActionType
	{
		// Token: 0x0400BDC0 RID: 48576
		[OriginalName("EnterNewRound")]
		EnterNewRound,
		// Token: 0x0400BDC1 RID: 48577
		[OriginalName("DrawCard")]
		DrawCard,
		// Token: 0x0400BDC2 RID: 48578
		[OriginalName("PlayCard")]
		PlayCard,
		// Token: 0x0400BDC3 RID: 48579
		[OriginalName("TriggerSkill")]
		TriggerSkill,
		// Token: 0x0400BDC4 RID: 48580
		[OriginalName("ExecSkill")]
		ExecSkill,
		// Token: 0x0400BDC5 RID: 48581
		[OriginalName("SettleResult")]
		SettleResult,
		// Token: 0x0400BDC6 RID: 48582
		[OriginalName("HealthHpRefresh")]
		HealthHpRefresh,
		// Token: 0x0400BDC7 RID: 48583
		[OriginalName("DisPlayCard")]
		DisPlayCard
	}
}
