using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004AD2 RID: 19154
	public class IGmSetLevelPlaySwitchForceT
	{
		// Token: 0x1700863D RID: 34365
		// (get) Token: 0x0601CD8E RID: 118158 RVA: 0x0040FF2A File Offset: 0x0040E12A
		// (set) Token: 0x0601CD8F RID: 118159 RVA: 0x0040FF32 File Offset: 0x0040E132
		public EGmCommand Type { get; set; }

		// Token: 0x1700863E RID: 34366
		// (get) Token: 0x0601CD90 RID: 118160 RVA: 0x0040FF3B File Offset: 0x0040E13B
		// (set) Token: 0x0601CD91 RID: 118161 RVA: 0x0040FF43 File Offset: 0x0040E143
		public int LevelPlayId { get; set; }

		// Token: 0x1700863F RID: 34367
		// (get) Token: 0x0601CD92 RID: 118162 RVA: 0x0040FF4C File Offset: 0x0040E14C
		// (set) Token: 0x0601CD93 RID: 118163 RVA: 0x0040FF54 File Offset: 0x0040E154
		public bool IsOpen { get; set; }

		// Token: 0x0601CD94 RID: 118164 RVA: 0x0040FF5D File Offset: 0x0040E15D
		public IGmSetLevelPlaySwitchForceT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
			this.LevelPlayId = 0;
			this.IsOpen = false;
		}
	}
}
