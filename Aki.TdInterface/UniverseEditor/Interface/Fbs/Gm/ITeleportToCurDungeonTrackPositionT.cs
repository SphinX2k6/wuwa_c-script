using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x020046B5 RID: 18101
	public class ITeleportToCurDungeonTrackPositionT
	{
		// Token: 0x17008090 RID: 32912
		// (get) Token: 0x0601B817 RID: 112663 RVA: 0x003E776C File Offset: 0x003E596C
		// (set) Token: 0x0601B818 RID: 112664 RVA: 0x003E7774 File Offset: 0x003E5974
		public EGmCommand Type { get; set; }

		// Token: 0x17008091 RID: 32913
		// (get) Token: 0x0601B819 RID: 112665 RVA: 0x003E777D File Offset: 0x003E597D
		// (set) Token: 0x0601B81A RID: 112666 RVA: 0x003E7785 File Offset: 0x003E5985
		public int NodeId { get; set; }

		// Token: 0x17008092 RID: 32914
		// (get) Token: 0x0601B81B RID: 112667 RVA: 0x003E778E File Offset: 0x003E598E
		// (set) Token: 0x0601B81C RID: 112668 RVA: 0x003E7796 File Offset: 0x003E5996
		public int NodeIndex { get; set; }

		// Token: 0x17008093 RID: 32915
		// (get) Token: 0x0601B81D RID: 112669 RVA: 0x003E779F File Offset: 0x003E599F
		// (set) Token: 0x0601B81E RID: 112670 RVA: 0x003E77A7 File Offset: 0x003E59A7
		public byte NullMask { get; set; }

		// Token: 0x0601B81F RID: 112671 RVA: 0x003E77B0 File Offset: 0x003E59B0
		public ITeleportToCurDungeonTrackPositionT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
			this.NodeId = 0;
			this.NodeIndex = 0;
			this.NullMask = 0;
		}
	}
}
