using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001615 RID: 5653
	public enum PinballStateChangeReasonPb
	{
		// Token: 0x0400BFBC RID: 49084
		[OriginalName("SettlePreSubmit_AllTeamDeadNoRevive")]
		SettlePreSubmitAllTeamDeadNoRevive,
		// Token: 0x0400BFBD RID: 49085
		[OriginalName("SettlePreSubmit_AllTeamDeadHaveRevive")]
		SettlePreSubmitAllTeamDeadHaveRevive,
		// Token: 0x0400BFBE RID: 49086
		[OriginalName("SettlePreSubmit_TimeZero")]
		SettlePreSubmitTimeZero,
		// Token: 0x0400BFBF RID: 49087
		[OriginalName("SettlePreSubmit_WaveClear")]
		SettlePreSubmitWaveClear,
		// Token: 0x0400BFC0 RID: 49088
		[OriginalName("InProgress_FirstStart")]
		InProgressFirstStart = 10,
		// Token: 0x0400BFC1 RID: 49089
		[OriginalName("InProgress_AllTeamRevive")]
		InProgressAllTeamRevive,
		// Token: 0x0400BFC2 RID: 49090
		[OriginalName("SettleFinish_Quit")]
		SettleFinishQuit = 21,
		// Token: 0x0400BFC3 RID: 49091
		[OriginalName("SettleFinish_LeaveScene")]
		SettleFinishLeaveScene,
		// Token: 0x0400BFC4 RID: 49092
		[OriginalName("SettleFinish_BonusFullWin")]
		SettleFinishBonusFullWin,
		// Token: 0x0400BFC5 RID: 49093
		[OriginalName("Gm")]
		Gm = 15
	}
}
