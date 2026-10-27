using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041F1 RID: 16881
	public class ITrackCustomBoardOnBtLogicNodeT
	{
		// Token: 0x170077D0 RID: 30672
		// (get) Token: 0x06018E78 RID: 102008 RVA: 0x003957C9 File Offset: 0x003939C9
		// (set) Token: 0x06018E79 RID: 102009 RVA: 0x003957D1 File Offset: 0x003939D1
		public IFastReturnMapPosT FastReturnMapPos { get; set; }

		// Token: 0x170077D1 RID: 30673
		// (get) Token: 0x06018E7A RID: 102010 RVA: 0x003957DA File Offset: 0x003939DA
		// (set) Token: 0x06018E7B RID: 102011 RVA: 0x003957E2 File Offset: 0x003939E2
		public ISheriffAnomalyProgressBoardConfigT SheriffAnomalyProgressBoard { get; set; }

		// Token: 0x170077D2 RID: 30674
		// (get) Token: 0x06018E7C RID: 102012 RVA: 0x003957EB File Offset: 0x003939EB
		// (set) Token: 0x06018E7D RID: 102013 RVA: 0x003957F3 File Offset: 0x003939F3
		public ISheriffMainBoardConfigT SheriffMainBoard { get; set; }

		// Token: 0x170077D3 RID: 30675
		// (get) Token: 0x06018E7E RID: 102014 RVA: 0x003957FC File Offset: 0x003939FC
		// (set) Token: 0x06018E7F RID: 102015 RVA: 0x00395804 File Offset: 0x00393A04
		public ISheriffClueDetailBoardConfigT SheriffClueDetailBoard { get; set; }

		// Token: 0x06018E80 RID: 102016 RVA: 0x0039580D File Offset: 0x00393A0D
		public ITrackCustomBoardOnBtLogicNodeT()
		{
			this.FastReturnMapPos = null;
			this.SheriffAnomalyProgressBoard = null;
			this.SheriffMainBoard = null;
			this.SheriffClueDetailBoard = null;
		}
	}
}
