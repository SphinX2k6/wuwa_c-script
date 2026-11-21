using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004647 RID: 17991
	public class ITrackCustomBoardT
	{
		// Token: 0x17007DF1 RID: 32241
		// (get) Token: 0x0601A5AC RID: 107948 RVA: 0x003C06F9 File Offset: 0x003BE8F9
		// (set) Token: 0x0601A5AD RID: 107949 RVA: 0x003C0701 File Offset: 0x003BE901
		public IPhoneMessageBoardConfigT TrackPhoneMessageBoard { get; set; }

		// Token: 0x17007DF2 RID: 32242
		// (get) Token: 0x0601A5AE RID: 107950 RVA: 0x003C070A File Offset: 0x003BE90A
		// (set) Token: 0x0601A5AF RID: 107951 RVA: 0x003C0712 File Offset: 0x003BE912
		public ITrackQuestBranchBoardConfigT TrackQuestBranchBoard { get; set; }

		// Token: 0x17007DF3 RID: 32243
		// (get) Token: 0x0601A5B0 RID: 107952 RVA: 0x003C071B File Offset: 0x003BE91B
		// (set) Token: 0x0601A5B1 RID: 107953 RVA: 0x003C0723 File Offset: 0x003BE923
		public ISheriffAnomalyProgressBoardConfigT SheriffAnomalyProgressBoard { get; set; }

		// Token: 0x17007DF4 RID: 32244
		// (get) Token: 0x0601A5B2 RID: 107954 RVA: 0x003C072C File Offset: 0x003BE92C
		// (set) Token: 0x0601A5B3 RID: 107955 RVA: 0x003C0734 File Offset: 0x003BE934
		public ISheriffReasoningBoardConfigT SheriffReasoningBoard { get; set; }

		// Token: 0x17007DF5 RID: 32245
		// (get) Token: 0x0601A5B4 RID: 107956 RVA: 0x003C073D File Offset: 0x003BE93D
		// (set) Token: 0x0601A5B5 RID: 107957 RVA: 0x003C0745 File Offset: 0x003BE945
		public ISheriffMainBoardConfigT SheriffMainBoard { get; set; }

		// Token: 0x17007DF6 RID: 32246
		// (get) Token: 0x0601A5B6 RID: 107958 RVA: 0x003C074E File Offset: 0x003BE94E
		// (set) Token: 0x0601A5B7 RID: 107959 RVA: 0x003C0756 File Offset: 0x003BE956
		public ISheriffClueDetailBoardConfigT SheriffClueDetailBoard { get; set; }

		// Token: 0x17007DF7 RID: 32247
		// (get) Token: 0x0601A5B8 RID: 107960 RVA: 0x003C075F File Offset: 0x003BE95F
		// (set) Token: 0x0601A5B9 RID: 107961 RVA: 0x003C0767 File Offset: 0x003BE967
		public ITrackReturnDungeonT TrackReturnDungeon { get; set; }

		// Token: 0x17007DF8 RID: 32248
		// (get) Token: 0x0601A5BA RID: 107962 RVA: 0x003C0770 File Offset: 0x003BE970
		// (set) Token: 0x0601A5BB RID: 107963 RVA: 0x003C0778 File Offset: 0x003BE978
		public ITrackHandBookBoardConfigT TrackHandBookBoard { get; set; }

		// Token: 0x0601A5BC RID: 107964 RVA: 0x003C0781 File Offset: 0x003BE981
		public ITrackCustomBoardT()
		{
			this.TrackPhoneMessageBoard = null;
			this.TrackQuestBranchBoard = null;
			this.SheriffAnomalyProgressBoard = null;
			this.SheriffReasoningBoard = null;
			this.SheriffMainBoard = null;
			this.SheriffClueDetailBoard = null;
			this.TrackReturnDungeon = null;
			this.TrackHandBookBoard = null;
		}
	}
}
