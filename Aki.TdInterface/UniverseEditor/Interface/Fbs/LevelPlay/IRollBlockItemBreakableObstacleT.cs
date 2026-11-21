using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020049FF RID: 18943
	public class IRollBlockItemBreakableObstacleT
	{
		// Token: 0x170084CF RID: 33999
		// (get) Token: 0x0601C672 RID: 116338 RVA: 0x004031FD File Offset: 0x004013FD
		// (set) Token: 0x0601C673 RID: 116339 RVA: 0x00403205 File Offset: 0x00401405
		public ERollBlockItemType Type { get; set; }

		// Token: 0x170084D0 RID: 34000
		// (get) Token: 0x0601C674 RID: 116340 RVA: 0x0040320E File Offset: 0x0040140E
		// (set) Token: 0x0601C675 RID: 116341 RVA: 0x00403216 File Offset: 0x00401416
		public int Key { get; set; }

		// Token: 0x170084D1 RID: 34001
		// (get) Token: 0x0601C676 RID: 116342 RVA: 0x0040321F File Offset: 0x0040141F
		// (set) Token: 0x0601C677 RID: 116343 RVA: 0x00403227 File Offset: 0x00401427
		public IRollBlockPathT Path { get; set; }

		// Token: 0x0601C678 RID: 116344 RVA: 0x00403230 File Offset: 0x00401430
		public IRollBlockItemBreakableObstacleT()
		{
			this.Type = ERollBlockItemType.BreakableObstacle;
			this.Key = 0;
			this.Path = null;
		}
	}
}
