using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004B23 RID: 19235
	public class ITeleportToCurQuestTrackPositionT
	{
		// Token: 0x170086E5 RID: 34533
		// (get) Token: 0x0601D02C RID: 118828 RVA: 0x004140C8 File Offset: 0x004122C8
		// (set) Token: 0x0601D02D RID: 118829 RVA: 0x004140D0 File Offset: 0x004122D0
		public EGmCommand Type { get; set; }

		// Token: 0x170086E6 RID: 34534
		// (get) Token: 0x0601D02E RID: 118830 RVA: 0x004140D9 File Offset: 0x004122D9
		// (set) Token: 0x0601D02F RID: 118831 RVA: 0x004140E1 File Offset: 0x004122E1
		public int NodeId { get; set; }

		// Token: 0x170086E7 RID: 34535
		// (get) Token: 0x0601D030 RID: 118832 RVA: 0x004140EA File Offset: 0x004122EA
		// (set) Token: 0x0601D031 RID: 118833 RVA: 0x004140F2 File Offset: 0x004122F2
		public int NodeIndex { get; set; }

		// Token: 0x170086E8 RID: 34536
		// (get) Token: 0x0601D032 RID: 118834 RVA: 0x004140FB File Offset: 0x004122FB
		// (set) Token: 0x0601D033 RID: 118835 RVA: 0x00414103 File Offset: 0x00412303
		public byte NullMask { get; set; }

		// Token: 0x0601D034 RID: 118836 RVA: 0x0041410C File Offset: 0x0041230C
		public ITeleportToCurQuestTrackPositionT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
			this.NodeId = 0;
			this.NodeIndex = 0;
			this.NullMask = 0;
		}
	}
}
