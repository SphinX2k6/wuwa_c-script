using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005916 RID: 22806
	public class IHitLogicChangeByPartHitT
	{
		// Token: 0x1700A56E RID: 42350
		// (get) Token: 0x06025144 RID: 151876 RVA: 0x00516F07 File Offset: 0x00515107
		// (set) Token: 0x06025145 RID: 151877 RVA: 0x00516F0F File Offset: 0x0051510F
		public EHitLogicType Type { get; set; }

		// Token: 0x1700A56F RID: 42351
		// (get) Token: 0x06025146 RID: 151878 RVA: 0x00516F18 File Offset: 0x00515118
		// (set) Token: 0x06025147 RID: 151879 RVA: 0x00516F20 File Offset: 0x00515120
		public List<IPartHitConfigT> PartHitConfig { get; set; }

		// Token: 0x06025148 RID: 151880 RVA: 0x00516F29 File Offset: 0x00515129
		public IHitLogicChangeByPartHitT()
		{
			this.Type = EHitLogicType.ChangeNextState;
			this.PartHitConfig = null;
		}
	}
}
