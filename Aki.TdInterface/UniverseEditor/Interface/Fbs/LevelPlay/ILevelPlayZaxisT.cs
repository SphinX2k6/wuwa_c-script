using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200451F RID: 17695
	public class ILevelPlayZaxisT
	{
		// Token: 0x17007D71 RID: 32113
		// (get) Token: 0x0601A989 RID: 108937 RVA: 0x003CC05E File Offset: 0x003CA25E
		// (set) Token: 0x0601A98A RID: 108938 RVA: 0x003CC066 File Offset: 0x003CA266
		public int Up { get; set; }

		// Token: 0x17007D72 RID: 32114
		// (get) Token: 0x0601A98B RID: 108939 RVA: 0x003CC06F File Offset: 0x003CA26F
		// (set) Token: 0x0601A98C RID: 108940 RVA: 0x003CC077 File Offset: 0x003CA277
		public int Down { get; set; }

		// Token: 0x17007D73 RID: 32115
		// (get) Token: 0x0601A98D RID: 108941 RVA: 0x003CC080 File Offset: 0x003CA280
		// (set) Token: 0x0601A98E RID: 108942 RVA: 0x003CC088 File Offset: 0x003CA288
		public byte NullMask { get; set; }

		// Token: 0x0601A98F RID: 108943 RVA: 0x003CC091 File Offset: 0x003CA291
		public ILevelPlayZaxisT()
		{
			this.Up = 0;
			this.Down = 0;
			this.NullMask = 0;
		}
	}
}
