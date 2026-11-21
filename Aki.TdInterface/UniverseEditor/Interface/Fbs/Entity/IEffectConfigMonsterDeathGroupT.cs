using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004BF6 RID: 19446
	public class IEffectConfigMonsterDeathGroupT
	{
		// Token: 0x170089A6 RID: 35238
		// (get) Token: 0x0601DB42 RID: 121666 RVA: 0x0042AD73 File Offset: 0x00428F73
		// (set) Token: 0x0601DB43 RID: 121667 RVA: 0x0042AD7B File Offset: 0x00428F7B
		public EEffectConfigType Type { get; set; }

		// Token: 0x170089A7 RID: 35239
		// (get) Token: 0x0601DB44 RID: 121668 RVA: 0x0042AD84 File Offset: 0x00428F84
		// (set) Token: 0x0601DB45 RID: 121669 RVA: 0x0042AD8C File Offset: 0x00428F8C
		public List<IMonsterTagDeathEffectDataT> EffectGroup { get; set; }

		// Token: 0x0601DB46 RID: 121670 RVA: 0x0042AD95 File Offset: 0x00428F95
		public IEffectConfigMonsterDeathGroupT()
		{
			this.Type = EEffectConfigType.Death;
			this.EffectGroup = null;
		}
	}
}
