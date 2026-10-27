using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D71 RID: 23921
	public class ICharacterAirCurrentConfigT
	{
		// Token: 0x1700B329 RID: 45865
		// (get) Token: 0x06028EBE RID: 167614 RVA: 0x0059F034 File Offset: 0x0059D234
		// (set) Token: 0x06028EBF RID: 167615 RVA: 0x0059F03C File Offset: 0x0059D23C
		public long BulletId { get; set; }

		// Token: 0x1700B32A RID: 45866
		// (get) Token: 0x06028EC0 RID: 167616 RVA: 0x0059F045 File Offset: 0x0059D245
		// (set) Token: 0x06028EC1 RID: 167617 RVA: 0x0059F04D File Offset: 0x0059D24D
		public IVectorInfoT Range { get; set; }

		// Token: 0x1700B32B RID: 45867
		// (get) Token: 0x06028EC2 RID: 167618 RVA: 0x0059F056 File Offset: 0x0059D256
		// (set) Token: 0x06028EC3 RID: 167619 RVA: 0x0059F05E File Offset: 0x0059D25E
		public IVectorInfoT Offset { get; set; }

		// Token: 0x06028EC4 RID: 167620 RVA: 0x0059F067 File Offset: 0x0059D267
		public ICharacterAirCurrentConfigT()
		{
			this.BulletId = 0L;
			this.Range = null;
			this.Offset = null;
		}
	}
}
