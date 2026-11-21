using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004AD5 RID: 19157
	public class IGmSetLevelPlayUpdateForceT
	{
		// Token: 0x17008644 RID: 34372
		// (get) Token: 0x0601CDA8 RID: 118184 RVA: 0x004101BE File Offset: 0x0040E3BE
		// (set) Token: 0x0601CDA9 RID: 118185 RVA: 0x004101C6 File Offset: 0x0040E3C6
		public EGmCommand Type { get; set; }

		// Token: 0x17008645 RID: 34373
		// (get) Token: 0x0601CDAA RID: 118186 RVA: 0x004101CF File Offset: 0x0040E3CF
		// (set) Token: 0x0601CDAB RID: 118187 RVA: 0x004101D7 File Offset: 0x0040E3D7
		public int LevelPlayId { get; set; }

		// Token: 0x17008646 RID: 34374
		// (get) Token: 0x0601CDAC RID: 118188 RVA: 0x004101E0 File Offset: 0x0040E3E0
		// (set) Token: 0x0601CDAD RID: 118189 RVA: 0x004101E8 File Offset: 0x0040E3E8
		public bool IsTeleport { get; set; }

		// Token: 0x0601CDAE RID: 118190 RVA: 0x004101F1 File Offset: 0x0040E3F1
		public IGmSetLevelPlayUpdateForceT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
			this.LevelPlayId = 0;
			this.IsTeleport = false;
		}
	}
}
