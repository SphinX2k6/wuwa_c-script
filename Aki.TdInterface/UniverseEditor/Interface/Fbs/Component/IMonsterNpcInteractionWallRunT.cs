using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005594 RID: 21908
	public class IMonsterNpcInteractionWallRunT
	{
		// Token: 0x1700A1DA RID: 41434
		// (get) Token: 0x0602444F RID: 148559 RVA: 0x0050201A File Offset: 0x0050021A
		// (set) Token: 0x06024450 RID: 148560 RVA: 0x00502022 File Offset: 0x00500222
		public EMonsterNpcInteractionType Type { get; set; }

		// Token: 0x06024451 RID: 148561 RVA: 0x0050202B File Offset: 0x0050022B
		public IMonsterNpcInteractionWallRunT()
		{
			this.Type = EMonsterNpcInteractionType.WallRun;
		}
	}
}
