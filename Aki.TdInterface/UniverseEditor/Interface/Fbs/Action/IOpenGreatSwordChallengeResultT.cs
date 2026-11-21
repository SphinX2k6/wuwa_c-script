using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200736B RID: 29547
	public class IOpenGreatSwordChallengeResultT
	{
		// Token: 0x1700D8BA RID: 55482
		// (get) Token: 0x0603391D RID: 211229 RVA: 0x006F350D File Offset: 0x006F170D
		// (set) Token: 0x0603391E RID: 211230 RVA: 0x006F3515 File Offset: 0x006F1715
		public ESystemType Type { get; set; }

		// Token: 0x1700D8BB RID: 55483
		// (get) Token: 0x0603391F RID: 211231 RVA: 0x006F351E File Offset: 0x006F171E
		// (set) Token: 0x06033920 RID: 211232 RVA: 0x006F3526 File Offset: 0x006F1726
		public int Id { get; set; }

		// Token: 0x1700D8BC RID: 55484
		// (get) Token: 0x06033921 RID: 211233 RVA: 0x006F352F File Offset: 0x006F172F
		// (set) Token: 0x06033922 RID: 211234 RVA: 0x006F3537 File Offset: 0x006F1737
		public TVarRefUnion ReturnVar { get; set; }

		// Token: 0x06033923 RID: 211235 RVA: 0x006F3540 File Offset: 0x006F1740
		public IOpenGreatSwordChallengeResultT()
		{
			this.Type = ESystemType.Shop;
			this.Id = 0;
			this.ReturnVar = null;
		}
	}
}
