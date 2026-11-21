using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A05 RID: 18949
	public class IRollBlockItemQuantumObstacleT
	{
		// Token: 0x170084E0 RID: 34016
		// (get) Token: 0x0601C6AC RID: 116396 RVA: 0x004037F0 File Offset: 0x004019F0
		// (set) Token: 0x0601C6AD RID: 116397 RVA: 0x004037F8 File Offset: 0x004019F8
		public ERollBlockItemType Type { get; set; }

		// Token: 0x170084E1 RID: 34017
		// (get) Token: 0x0601C6AE RID: 116398 RVA: 0x00403801 File Offset: 0x00401A01
		// (set) Token: 0x0601C6AF RID: 116399 RVA: 0x00403809 File Offset: 0x00401A09
		public bool InitActive { get; set; }

		// Token: 0x0601C6B0 RID: 116400 RVA: 0x00403812 File Offset: 0x00401A12
		public IRollBlockItemQuantumObstacleT()
		{
			this.Type = ERollBlockItemType.BreakableObstacle;
			this.InitActive = false;
		}
	}
}
