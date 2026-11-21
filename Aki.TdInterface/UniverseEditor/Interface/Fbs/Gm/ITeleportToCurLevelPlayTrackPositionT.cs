using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004B20 RID: 19232
	public class ITeleportToCurLevelPlayTrackPositionT
	{
		// Token: 0x170086DB RID: 34523
		// (get) Token: 0x0601D00C RID: 118796 RVA: 0x00413D86 File Offset: 0x00411F86
		// (set) Token: 0x0601D00D RID: 118797 RVA: 0x00413D8E File Offset: 0x00411F8E
		public EGmCommand Type { get; set; }

		// Token: 0x170086DC RID: 34524
		// (get) Token: 0x0601D00E RID: 118798 RVA: 0x00413D97 File Offset: 0x00411F97
		// (set) Token: 0x0601D00F RID: 118799 RVA: 0x00413D9F File Offset: 0x00411F9F
		public int LevelPlayId { get; set; }

		// Token: 0x170086DD RID: 34525
		// (get) Token: 0x0601D010 RID: 118800 RVA: 0x00413DA8 File Offset: 0x00411FA8
		// (set) Token: 0x0601D011 RID: 118801 RVA: 0x00413DB0 File Offset: 0x00411FB0
		public int NodeId { get; set; }

		// Token: 0x170086DE RID: 34526
		// (get) Token: 0x0601D012 RID: 118802 RVA: 0x00413DB9 File Offset: 0x00411FB9
		// (set) Token: 0x0601D013 RID: 118803 RVA: 0x00413DC1 File Offset: 0x00411FC1
		public int NodeIndex { get; set; }

		// Token: 0x170086DF RID: 34527
		// (get) Token: 0x0601D014 RID: 118804 RVA: 0x00413DCA File Offset: 0x00411FCA
		// (set) Token: 0x0601D015 RID: 118805 RVA: 0x00413DD2 File Offset: 0x00411FD2
		public byte NullMask { get; set; }

		// Token: 0x0601D016 RID: 118806 RVA: 0x00413DDB File Offset: 0x00411FDB
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
