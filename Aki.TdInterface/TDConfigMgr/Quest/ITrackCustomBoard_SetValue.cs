using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020011B1 RID: 4529
	[NullableContext(2)]
	[Nullable(0)]
	public class ITrackCustomBoard_SetValue
	{
		// Token: 0x04003DC0 RID: 15808
		public IPhoneMessageBoardConfig TrackPhoneMessageBoard;

		// Token: 0x04003DC1 RID: 15809
		public ITrackQuestBranchBoardConfig TrackQuestBranchBoard;

		// Token: 0x04003DC2 RID: 15810
		public ISheriffAnomalyProgressBoardConfig SheriffAnomalyProgressBoard;

		// Token: 0x04003DC3 RID: 15811
		public ISheriffReasoningBoardConfig SheriffReasoningBoard;

		// Token: 0x04003DC4 RID: 15812
		public ISheriffMainBoardConfig SheriffMainBoard;

		// Token: 0x04003DC5 RID: 15813
		public ISheriffClueDetailBoardConfig SheriffClueDetailBoard;

		// Token: 0x04003DC6 RID: 15814
		public ITrackReturnDungeon TrackReturnDungeon;
	}
}
