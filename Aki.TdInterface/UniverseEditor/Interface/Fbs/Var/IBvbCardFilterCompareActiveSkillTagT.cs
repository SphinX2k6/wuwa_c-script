using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E15 RID: 15893
	public class IBvbCardFilterCompareActiveSkillTagT
	{
		// Token: 0x17006B55 RID: 27477
		// (get) Token: 0x060155E0 RID: 87520 RVA: 0x00316208 File Offset: 0x00314408
		// (set) Token: 0x060155E1 RID: 87521 RVA: 0x00316210 File Offset: 0x00314410
		public EBvbCardFilterType Type { get; set; }

		// Token: 0x17006B56 RID: 27478
		// (get) Token: 0x060155E2 RID: 87522 RVA: 0x00316219 File Offset: 0x00314419
		// (set) Token: 0x060155E3 RID: 87523 RVA: 0x00316221 File Offset: 0x00314421
		public int ActiveSkillTag { get; set; }

		// Token: 0x060155E4 RID: 87524 RVA: 0x0031622A File Offset: 0x0031442A
		public IBvbCardFilterCompareActiveSkillTagT()
		{
			this.Type = EBvbCardFilterType.CompareCost;
			this.ActiveSkillTag = 0;
		}
	}
}
