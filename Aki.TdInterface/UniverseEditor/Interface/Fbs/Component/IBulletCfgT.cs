using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F38 RID: 20280
	public class IBulletCfgT
	{
		// Token: 0x1700922E RID: 37422
		// (get) Token: 0x060201B5 RID: 131509 RVA: 0x00477999 File Offset: 0x00475B99
		// (set) Token: 0x060201B6 RID: 131510 RVA: 0x004779A1 File Offset: 0x00475BA1
		public List<TBulletCreateConditionUnion> CreateConditions { get; set; }

		// Token: 0x060201B7 RID: 131511 RVA: 0x004779AA File Offset: 0x00475BAA
		public IBulletCfgT()
		{
			this.CreateConditions = null;
		}
	}
}
