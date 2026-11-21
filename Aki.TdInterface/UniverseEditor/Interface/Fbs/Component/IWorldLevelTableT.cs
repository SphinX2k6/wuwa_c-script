using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020061AF RID: 25007
	public class IWorldLevelTableT
	{
		// Token: 0x1700BA7D RID: 47741
		// (get) Token: 0x0602A81B RID: 174107 RVA: 0x005CC27A File Offset: 0x005CA47A
		// (set) Token: 0x0602A81C RID: 174108 RVA: 0x005CC282 File Offset: 0x005CA482
		public EWorldLevelBonus Type { get; set; }

		// Token: 0x1700BA7E RID: 47742
		// (get) Token: 0x0602A81D RID: 174109 RVA: 0x005CC28B File Offset: 0x005CA48B
		// (set) Token: 0x0602A81E RID: 174110 RVA: 0x005CC293 File Offset: 0x005CA493
		public int WorldLevelBonusId { get; set; }

		// Token: 0x1700BA7F RID: 47743
		// (get) Token: 0x0602A81F RID: 174111 RVA: 0x005CC29C File Offset: 0x005CA49C
		// (set) Token: 0x0602A820 RID: 174112 RVA: 0x005CC2A4 File Offset: 0x005CA4A4
		public byte NullMask { get; set; }

		// Token: 0x0602A821 RID: 174113 RVA: 0x005CC2AD File Offset: 0x005CA4AD
		public IWorldLevelTableT()
		{
			this.Type = EWorldLevelBonus.WorldLevelTable;
			this.WorldLevelBonusId = 0;
			this.NullMask = 0;
		}
	}
}
