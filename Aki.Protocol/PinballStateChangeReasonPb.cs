using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001688 RID: 5768
	public enum PinballStateChangeReasonPb
	{
		// Token: 0x0400C4B6 RID: 50358
		[OriginalName("SettlePreSubmit_AllTeamDeadNoRevive")]
		SettlePreSubmitAllTeamDeadNoRevive,
		// Token: 0x0400C4B7 RID: 50359
		[OriginalName("SettlePreSubmit_AllTeamDeadHaveRevive")]
		SettlePreSubmitAllTeamDeadHaveRevive,
		// Token: 0x0400C4B8 RID: 50360
		[OriginalName("SettlePreSubmit_TimeZero")]
		SettlePreSubmitTimeZero,
		// Token: 0x0400C4B9 RID: 50361
		[OriginalName("SettlePreSubmit_WaveClear")]
		SettlePreSubmitWaveClear,
		// Token: 0x0400C4BA RID: 50362
		[OriginalName("InProgress_FirstStart")]
		InProgressFirstStart = 10,
		// Token: 0x0400C4BB RID: 50363
		[OriginalName("InProgress_AllTeamRevive")]
		InProgressAllTeamRevive,
		// Token: 0x0400C4BC RID: 50364
		[OriginalName("SettleFinish_Quit")]
		SettleFinishQuit = 21,
		// Token: 0x0400C4BD RID: 50365
		[OriginalName("SettleFinish_LeaveScene")]
		SettleFinishLeaveScene,
		// Token: 0x0400C4BE RID: 50366
		[OriginalName("SettleFinish_BonusFullWin")]
		SettleFinishBonusFullWin,
		// Token: 0x0400C4BF RID: 50367
		[OriginalName("Gm")]
		Gm = 15
	}
}
