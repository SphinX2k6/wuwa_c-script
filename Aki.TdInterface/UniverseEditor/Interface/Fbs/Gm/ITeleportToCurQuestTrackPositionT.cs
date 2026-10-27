using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x020046BB RID: 18107
	public class ITeleportToCurQuestTrackPositionT
	{
		// Token: 0x170080A4 RID: 32932
		// (get) Token: 0x0601B857 RID: 112727 RVA: 0x003E7E2C File Offset: 0x003E602C
		// (set) Token: 0x0601B858 RID: 112728 RVA: 0x003E7E34 File Offset: 0x003E6034
		public EGmCommand Type { get; set; }

		// Token: 0x170080A5 RID: 32933
		// (get) Token: 0x0601B859 RID: 112729 RVA: 0x003E7E3D File Offset: 0x003E603D
		// (set) Token: 0x0601B85A RID: 112730 RVA: 0x003E7E45 File Offset: 0x003E6045
		public int NodeId { get; set; }

		// Token: 0x170080A6 RID: 32934
		// (get) Token: 0x0601B85B RID: 112731 RVA: 0x003E7E4E File Offset: 0x003E604E
		// (set) Token: 0x0601B85C RID: 112732 RVA: 0x003E7E56 File Offset: 0x003E6056
		public int NodeIndex { get; set; }

		// Token: 0x170080A7 RID: 32935
		// (get) Token: 0x0601B85D RID: 112733 RVA: 0x003E7E5F File Offset: 0x003E605F
		// (set) Token: 0x0601B85E RID: 112734 RVA: 0x003E7E67 File Offset: 0x003E6067
		public byte NullMask { get; set; }

		// Token: 0x0601B85F RID: 112735 RVA: 0x003E7E70 File Offset: 0x003E6070
		public ITeleportToCurQuestTrackPositionT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
			this.NodeId = 0;
			this.NodeIndex = 0;
			this.NullMask = 0;
		}
	}
}
