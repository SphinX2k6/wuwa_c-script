using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041EE RID: 16878
	public class ITrackCustomBoardT
	{
		// Token: 0x170077C4 RID: 30660
		// (get) Token: 0x06018E54 RID: 101972 RVA: 0x003951D9 File Offset: 0x003933D9
		// (set) Token: 0x06018E55 RID: 101973 RVA: 0x003951E1 File Offset: 0x003933E1
		public IPhoneMessageBoardConfigT TrackPhoneMessageBoard { get; set; }

		// Token: 0x170077C5 RID: 30661
		// (get) Token: 0x06018E56 RID: 101974 RVA: 0x003951EA File Offset: 0x003933EA
		// (set) Token: 0x06018E57 RID: 101975 RVA: 0x003951F2 File Offset: 0x003933F2
		public ITrackQuestBranchBoardConfigT TrackQuestBranchBoard { get; set; }

		// Token: 0x170077C6 RID: 30662
		// (get) Token: 0x06018E58 RID: 101976 RVA: 0x003951FB File Offset: 0x003933FB
		// (set) Token: 0x06018E59 RID: 101977 RVA: 0x00395203 File Offset: 0x00393403
		public ISheriffAnomalyProgressBoardConfigT SheriffAnomalyProgressBoard { get; set; }

		// Token: 0x170077C7 RID: 30663
		// (get) Token: 0x06018E5A RID: 101978 RVA: 0x0039520C File Offset: 0x0039340C
		// (set) Token: 0x06018E5B RID: 101979 RVA: 0x00395214 File Offset: 0x00393414
		public ISheriffReasoningBoardConfigT SheriffReasoningBoard { get; set; }

		// Token: 0x170077C8 RID: 30664
		// (get) Token: 0x06018E5C RID: 101980 RVA: 0x0039521D File Offset: 0x0039341D
		// (set) Token: 0x06018E5D RID: 101981 RVA: 0x00395225 File Offset: 0x00393425
		public ISheriffMainBoardConfigT SheriffMainBoard { get; set; }

		// Token: 0x170077C9 RID: 30665
		// (get) Token: 0x06018E5E RID: 101982 RVA: 0x0039522E File Offset: 0x0039342E
		// (set) Token: 0x06018E5F RID: 101983 RVA: 0x00395236 File Offset: 0x00393436
		public ISheriffClueDetailBoardConfigT SheriffClueDetailBoard { get; set; }

		// Token: 0x170077CA RID: 30666
		// (get) Token: 0x06018E60 RID: 101984 RVA: 0x0039523F File Offset: 0x0039343F
		// (set) Token: 0x06018E61 RID: 101985 RVA: 0x00395247 File Offset: 0x00393447
		public ITrackReturnDungeonT TrackReturnDungeon { get; set; }

		// Token: 0x06018E62 RID: 101986 RVA: 0x00395250 File Offset: 0x00393450
		public ITrackCustomBoardT()
		{
			this.TrackPhoneMessageBoard = null;
			this.TrackQuestBranchBoard = null;
			this.SheriffAnomalyProgressBoard = null;
			this.SheriffReasoningBoard = null;
			this.SheriffMainBoard = null;
			this.SheriffClueDetailBoard = null;
			this.TrackReturnDungeon = null;
		}
	}
}
