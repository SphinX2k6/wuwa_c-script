using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200546A RID: 21610
	public class IBulletCfgT
	{
		// Token: 0x170099B0 RID: 39344
		// (get) Token: 0x06021F25 RID: 139045 RVA: 0x004ADD2D File Offset: 0x004ABF2D
		// (set) Token: 0x06021F26 RID: 139046 RVA: 0x004ADD35 File Offset: 0x004ABF35
		public List<TBulletCreateConditionUnion> CreateConditions { get; set; }

		// Token: 0x06021F27 RID: 139047 RVA: 0x004ADD3E File Offset: 0x004ABF3E
		public IBulletCfgT()
		{
			this.CreateConditions = null;
		}
	}
}
