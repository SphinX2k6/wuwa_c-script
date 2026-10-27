using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058A7 RID: 22695
	public class ISceneBulletGroupT
	{
		// Token: 0x1700A9EE RID: 43502
		// (get) Token: 0x060264A2 RID: 156834 RVA: 0x0054746F File Offset: 0x0054566F
		// (set) Token: 0x060264A3 RID: 156835 RVA: 0x00547477 File Offset: 0x00545677
		public string EntityState { get; set; }

		// Token: 0x1700A9EF RID: 43503
		// (get) Token: 0x060264A4 RID: 156836 RVA: 0x00547480 File Offset: 0x00545680
		// (set) Token: 0x060264A5 RID: 156837 RVA: 0x00547488 File Offset: 0x00545688
		public long BulletId { get; set; }

		// Token: 0x1700A9F0 RID: 43504
		// (get) Token: 0x060264A6 RID: 156838 RVA: 0x00547491 File Offset: 0x00545691
		// (set) Token: 0x060264A7 RID: 156839 RVA: 0x00547499 File Offset: 0x00545699
		public IVectorInfoT Range { get; set; }

		// Token: 0x1700A9F1 RID: 43505
		// (get) Token: 0x060264A8 RID: 156840 RVA: 0x005474A2 File Offset: 0x005456A2
		// (set) Token: 0x060264A9 RID: 156841 RVA: 0x005474AA File Offset: 0x005456AA
		public IVectorInfoT Offset { get; set; }

		// Token: 0x1700A9F2 RID: 43506
		// (get) Token: 0x060264AA RID: 156842 RVA: 0x005474B3 File Offset: 0x005456B3
		// (set) Token: 0x060264AB RID: 156843 RVA: 0x005474BB File Offset: 0x005456BB
		public ITrafficBulletLogicT CustomBulletLogic { get; set; }

		// Token: 0x060264AC RID: 156844 RVA: 0x005474C4 File Offset: 0x005456C4
		public ISceneBulletGroupT()
		{
			this.EntityState = null;
			this.BulletId = 0L;
			this.Range = null;
			this.Offset = null;
			this.CustomBulletLogic = null;
		}
	}
}
