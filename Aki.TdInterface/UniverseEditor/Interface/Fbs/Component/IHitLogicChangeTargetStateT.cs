using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005925 RID: 22821
	public class IHitLogicChangeTargetStateT
	{
		// Token: 0x1700A582 RID: 42370
		// (get) Token: 0x060251B6 RID: 151990 RVA: 0x00517B44 File Offset: 0x00515D44
		// (set) Token: 0x060251B7 RID: 151991 RVA: 0x00517B4C File Offset: 0x00515D4C
		public EHitLogicType Type { get; set; }

		// Token: 0x1700A583 RID: 42371
		// (get) Token: 0x060251B8 RID: 151992 RVA: 0x00517B55 File Offset: 0x00515D55
		// (set) Token: 0x060251B9 RID: 151993 RVA: 0x00517B5D File Offset: 0x00515D5D
		public List<IConditionHitConfigWithBulletT> TargetBulletHitConfigs { get; set; }

		// Token: 0x1700A584 RID: 42372
		// (get) Token: 0x060251BA RID: 151994 RVA: 0x00517B66 File Offset: 0x00515D66
		// (set) Token: 0x060251BB RID: 151995 RVA: 0x00517B6E File Offset: 0x00515D6E
		public List<IConditionHitConfigT> OtherBulletsHitConfig { get; set; }

		// Token: 0x060251BC RID: 151996 RVA: 0x00517B77 File Offset: 0x00515D77
		public IHitLogicChangeTargetStateT()
		{
			this.Type = EHitLogicType.ChangeNextState;
			this.TargetBulletHitConfigs = null;
			this.OtherBulletsHitConfig = null;
		}
	}
}
