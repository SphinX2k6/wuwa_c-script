using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200459D RID: 17821
	public class IRollBlockItemQuantumObstacleT
	{
		// Token: 0x17007E9F RID: 32415
		// (get) Token: 0x0601AED7 RID: 110295 RVA: 0x003D7554 File Offset: 0x003D5754
		// (set) Token: 0x0601AED8 RID: 110296 RVA: 0x003D755C File Offset: 0x003D575C
		public ERollBlockItemType Type { get; set; }

		// Token: 0x17007EA0 RID: 32416
		// (get) Token: 0x0601AED9 RID: 110297 RVA: 0x003D7565 File Offset: 0x003D5765
		// (set) Token: 0x0601AEDA RID: 110298 RVA: 0x003D756D File Offset: 0x003D576D
		public bool InitActive { get; set; }

		// Token: 0x0601AEDB RID: 110299 RVA: 0x003D7576 File Offset: 0x003D5776
		public IRollBlockItemQuantumObstacleT()
		{
			this.Type = ERollBlockItemType.BreakableObstacle;
			this.InitActive = false;
		}
	}
}
