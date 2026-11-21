using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200464A RID: 17994
	public class ITrackCustomBoardOnBtLogicNodeT
	{
		// Token: 0x17007DFE RID: 32254
		// (get) Token: 0x0601A5D2 RID: 107986 RVA: 0x003C0D29 File Offset: 0x003BEF29
		// (set) Token: 0x0601A5D3 RID: 107987 RVA: 0x003C0D31 File Offset: 0x003BEF31
		public IFastReturnMapPosT FastReturnMapPos { get; set; }

		// Token: 0x17007DFF RID: 32255
		// (get) Token: 0x0601A5D4 RID: 107988 RVA: 0x003C0D3A File Offset: 0x003BEF3A
		// (set) Token: 0x0601A5D5 RID: 107989 RVA: 0x003C0D42 File Offset: 0x003BEF42
		public ISheriffAnomalyProgressBoardConfigT SheriffAnomalyProgressBoard { get; set; }

		// Token: 0x17007E00 RID: 32256
		// (get) Token: 0x0601A5D6 RID: 107990 RVA: 0x003C0D4B File Offset: 0x003BEF4B
		// (set) Token: 0x0601A5D7 RID: 107991 RVA: 0x003C0D53 File Offset: 0x003BEF53
		public ISheriffMainBoardConfigT SheriffMainBoard { get; set; }

		// Token: 0x17007E01 RID: 32257
		// (get) Token: 0x0601A5D8 RID: 107992 RVA: 0x003C0D5C File Offset: 0x003BEF5C
		// (set) Token: 0x0601A5D9 RID: 107993 RVA: 0x003C0D64 File Offset: 0x003BEF64
		public ISheriffClueDetailBoardConfigT SheriffClueDetailBoard { get; set; }

		// Token: 0x0601A5DA RID: 107994 RVA: 0x003C0D6D File Offset: 0x003BEF6D
		public ITrackCustomBoardOnBtLogicNodeT()
		{
			this.FastReturnMapPos = null;
			this.SheriffAnomalyProgressBoard = null;
			this.SheriffMainBoard = null;
			this.SheriffClueDetailBoard = null;
		}
	}
}
