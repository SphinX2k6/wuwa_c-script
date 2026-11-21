using System;

namespace Aki.UniverseEditor.Interface.Fbs.Physics
{
	// Token: 0x020047A2 RID: 18338
	public class IAcmLimitedT
	{
		// Token: 0x17007FC5 RID: 32709
		// (get) Token: 0x0601AFF7 RID: 110583 RVA: 0x003D3538 File Offset: 0x003D1738
		// (set) Token: 0x0601AFF8 RID: 110584 RVA: 0x003D3540 File Offset: 0x003D1740
		public EAngularConstraintMotion Type { get; set; }

		// Token: 0x17007FC6 RID: 32710
		// (get) Token: 0x0601AFF9 RID: 110585 RVA: 0x003D3549 File Offset: 0x003D1749
		// (set) Token: 0x0601AFFA RID: 110586 RVA: 0x003D3551 File Offset: 0x003D1751
		public int LimitValue { get; set; }

		// Token: 0x0601AFFB RID: 110587 RVA: 0x003D355A File Offset: 0x003D175A
		public IAcmLimitedT()
		{
			this.Type = EAngularConstraintMotion.ACM_Free;
			this.LimitValue = 0;
		}
	}
}
