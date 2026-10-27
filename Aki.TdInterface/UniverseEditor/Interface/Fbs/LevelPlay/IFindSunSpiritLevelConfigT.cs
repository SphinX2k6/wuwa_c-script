using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020044C8 RID: 17608
	public class IFindSunSpiritLevelConfigT
	{
		// Token: 0x17007C48 RID: 31816
		// (get) Token: 0x0601A50C RID: 107788 RVA: 0x003C1EF7 File Offset: 0x003C00F7
		// (set) Token: 0x0601A50D RID: 107789 RVA: 0x003C1EFF File Offset: 0x003C00FF
		public IFindSunSpiritGridConfigT GridConfig { get; set; }

		// Token: 0x17007C49 RID: 31817
		// (get) Token: 0x0601A50E RID: 107790 RVA: 0x003C1F08 File Offset: 0x003C0108
		// (set) Token: 0x0601A50F RID: 107791 RVA: 0x003C1F10 File Offset: 0x003C0110
		public int MaxJumpHeight { get; set; }

		// Token: 0x17007C4A RID: 31818
		// (get) Token: 0x0601A510 RID: 107792 RVA: 0x003C1F19 File Offset: 0x003C0119
		// (set) Token: 0x0601A511 RID: 107793 RVA: 0x003C1F21 File Offset: 0x003C0121
		public int MaxTimes { get; set; }

		// Token: 0x17007C4B RID: 31819
		// (get) Token: 0x0601A512 RID: 107794 RVA: 0x003C1F2A File Offset: 0x003C012A
		// (set) Token: 0x0601A513 RID: 107795 RVA: 0x003C1F32 File Offset: 0x003C0132
		public byte NullMask { get; set; }

		// Token: 0x0601A514 RID: 107796 RVA: 0x003C1F3B File Offset: 0x003C013B
		public IFindSunSpiritLevelConfigT()
		{
			this.GridConfig = null;
			this.MaxJumpHeight = 0;
			this.MaxTimes = 0;
			this.NullMask = 0;
		}
	}
}
