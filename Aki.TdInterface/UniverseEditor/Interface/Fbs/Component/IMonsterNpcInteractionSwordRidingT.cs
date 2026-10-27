using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005591 RID: 21905
	public class IMonsterNpcInteractionSwordRidingT
	{
		// Token: 0x1700A1D7 RID: 41431
		// (get) Token: 0x0602443D RID: 148541 RVA: 0x00501EA2 File Offset: 0x005000A2
		// (set) Token: 0x0602443E RID: 148542 RVA: 0x00501EAA File Offset: 0x005000AA
		public EMonsterNpcInteractionType Type { get; set; }

		// Token: 0x0602443F RID: 148543 RVA: 0x00501EB3 File Offset: 0x005000B3
		public IMonsterNpcInteractionSwordRidingT()
		{
			this.Type = EMonsterNpcInteractionType.WallRun;
		}
	}
}
