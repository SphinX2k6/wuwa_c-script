using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x020046B8 RID: 18104
	public class ITeleportToCurLevelPlayTrackPositionT
	{
		// Token: 0x1700809A RID: 32922
		// (get) Token: 0x0601B837 RID: 112695 RVA: 0x003E7AEA File Offset: 0x003E5CEA
		// (set) Token: 0x0601B838 RID: 112696 RVA: 0x003E7AF2 File Offset: 0x003E5CF2
		public EGmCommand Type { get; set; }

		// Token: 0x1700809B RID: 32923
		// (get) Token: 0x0601B839 RID: 112697 RVA: 0x003E7AFB File Offset: 0x003E5CFB
		// (set) Token: 0x0601B83A RID: 112698 RVA: 0x003E7B03 File Offset: 0x003E5D03
		public int LevelPlayId { get; set; }

		// Token: 0x1700809C RID: 32924
		// (get) Token: 0x0601B83B RID: 112699 RVA: 0x003E7B0C File Offset: 0x003E5D0C
		// (set) Token: 0x0601B83C RID: 112700 RVA: 0x003E7B14 File Offset: 0x003E5D14
		public int NodeId { get; set; }

		// Token: 0x1700809D RID: 32925
		// (get) Token: 0x0601B83D RID: 112701 RVA: 0x003E7B1D File Offset: 0x003E5D1D
		// (set) Token: 0x0601B83E RID: 112702 RVA: 0x003E7B25 File Offset: 0x003E5D25
		public int NodeIndex { get; set; }

		// Token: 0x1700809E RID: 32926
		// (get) Token: 0x0601B83F RID: 112703 RVA: 0x003E7B2E File Offset: 0x003E5D2E
		// (set) Token: 0x0601B840 RID: 112704 RVA: 0x003E7B36 File Offset: 0x003E5D36
		public byte NullMask { get; set; }

		// Token: 0x0601B841 RID: 112705 RVA: 0x003E7B3F File Offset: 0x003E5D3F
		public ITeleportToCurLevelPlayTrackPositionT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
			this.LevelPlayId = 0;
			this.NodeId = 0;
			this.NodeIndex = 0;
			this.NullMask = 0;
		}
	}
}
