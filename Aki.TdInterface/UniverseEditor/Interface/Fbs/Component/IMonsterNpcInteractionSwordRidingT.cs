using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B2F RID: 23343
	public class IMonsterNpcInteractionSwordRidingT
	{
		// Token: 0x1700AA5F RID: 43615
		// (get) Token: 0x0602664A RID: 157258 RVA: 0x0054241A File Offset: 0x0054061A
		// (set) Token: 0x0602664B RID: 157259 RVA: 0x00542422 File Offset: 0x00540622
		public EMonsterNpcInteractionType Type { get; set; }

		// Token: 0x0602664C RID: 157260 RVA: 0x0054242B File Offset: 0x0054062B
		public IMonsterNpcInteractionSwordRidingT()
		{
			this.Type = EMonsterNpcInteractionType.WallRun;
		}
	}
}
