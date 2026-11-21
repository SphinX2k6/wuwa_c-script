using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B32 RID: 23346
	public class IMonsterNpcInteractionWallRunT
	{
		// Token: 0x1700AA62 RID: 43618
		// (get) Token: 0x0602665C RID: 157276 RVA: 0x00542592 File Offset: 0x00540792
		// (set) Token: 0x0602665D RID: 157277 RVA: 0x0054259A File Offset: 0x0054079A
		public EMonsterNpcInteractionType Type { get; set; }

		// Token: 0x0602665E RID: 157278 RVA: 0x005425A3 File Offset: 0x005407A3
		public IMonsterNpcInteractionWallRunT()
		{
			this.Type = EMonsterNpcInteractionType.WallRun;
		}
	}
}
