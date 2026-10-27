using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003FB1 RID: 16305
	public class IPosRollbackConfigT
	{
		// Token: 0x170071DE RID: 29150
		// (get) Token: 0x060174F6 RID: 95478 RVA: 0x0035C4E4 File Offset: 0x0035A6E4
		// (set) Token: 0x060174F7 RID: 95479 RVA: 0x0035C4EC File Offset: 0x0035A6EC
		public int RangeEntityId { get; set; }

		// Token: 0x170071DF RID: 29151
		// (get) Token: 0x060174F8 RID: 95480 RVA: 0x0035C4F5 File Offset: 0x0035A6F5
		// (set) Token: 0x060174F9 RID: 95481 RVA: 0x0035C4FD File Offset: 0x0035A6FD
		public int PositionEntityId { get; set; }

		// Token: 0x170071E0 RID: 29152
		// (get) Token: 0x060174FA RID: 95482 RVA: 0x0035C506 File Offset: 0x0035A706
		// (set) Token: 0x060174FB RID: 95483 RVA: 0x0035C50E File Offset: 0x0035A70E
		public bool GravityFlip { get; set; }

		// Token: 0x170071E1 RID: 29153
		// (get) Token: 0x060174FC RID: 95484 RVA: 0x0035C517 File Offset: 0x0035A717
		// (set) Token: 0x060174FD RID: 95485 RVA: 0x0035C51F File Offset: 0x0035A71F
		public byte NullMask { get; set; }

		// Token: 0x060174FE RID: 95486 RVA: 0x0035C528 File Offset: 0x0035A728
		public IPosRollbackConfigT()
		{
			this.RangeEntityId = 0;
			this.PositionEntityId = 0;
			this.GravityFlip = false;
			this.NullMask = 0;
		}
	}
}
