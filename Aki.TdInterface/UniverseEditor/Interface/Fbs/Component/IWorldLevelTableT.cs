using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B99 RID: 23449
	public class IWorldLevelTableT
	{
		// Token: 0x1700B135 RID: 45365
		// (get) Token: 0x06028257 RID: 164439 RVA: 0x005847EA File Offset: 0x005829EA
		// (set) Token: 0x06028258 RID: 164440 RVA: 0x005847F2 File Offset: 0x005829F2
		public EWorldLevelBonus Type { get; set; }

		// Token: 0x1700B136 RID: 45366
		// (get) Token: 0x06028259 RID: 164441 RVA: 0x005847FB File Offset: 0x005829FB
		// (set) Token: 0x0602825A RID: 164442 RVA: 0x00584803 File Offset: 0x00582A03
		public int WorldLevelBonusId { get; set; }

		// Token: 0x1700B137 RID: 45367
		// (get) Token: 0x0602825B RID: 164443 RVA: 0x0058480C File Offset: 0x00582A0C
		// (set) Token: 0x0602825C RID: 164444 RVA: 0x00584814 File Offset: 0x00582A14
		public byte NullMask { get; set; }

		// Token: 0x0602825D RID: 164445 RVA: 0x0058481D File Offset: 0x00582A1D
		public IWorldLevelTableT()
		{
			this.Type = EWorldLevelBonus.WorldLevelTable;
			this.WorldLevelBonusId = 0;
			this.NullMask = 0;
		}
	}
}
