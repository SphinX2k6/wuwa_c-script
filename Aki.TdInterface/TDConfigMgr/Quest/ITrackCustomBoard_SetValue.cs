using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020012EB RID: 4843
	[NullableContext(2)]
	[Nullable(0)]
	public class ITrackCustomBoard_SetValue
	{
		// Token: 0x0400412A RID: 16682
		public IPhoneMessageBoardConfig TrackPhoneMessageBoard;

		// Token: 0x0400412B RID: 16683
		public ITrackQuestBranchBoardConfig TrackQuestBranchBoard;

		// Token: 0x0400412C RID: 16684
		public ISheriffAnomalyProgressBoardConfig SheriffAnomalyProgressBoard;

		// Token: 0x0400412D RID: 16685
		public ISheriffReasoningBoardConfig SheriffReasoningBoard;

		// Token: 0x0400412E RID: 16686
		public ISheriffMainBoardConfig SheriffMainBoard;

		// Token: 0x0400412F RID: 16687
		public ISheriffClueDetailBoardConfig SheriffClueDetailBoard;

		// Token: 0x04004130 RID: 16688
		public ITrackReturnDungeon TrackReturnDungeon;

		// Token: 0x04004131 RID: 16689
		public ITrackHandBookBoardConfig TrackHandBookBoard;
	}
}
