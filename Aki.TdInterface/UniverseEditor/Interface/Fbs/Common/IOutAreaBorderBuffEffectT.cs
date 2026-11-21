using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006450 RID: 25680
	public class IOutAreaBorderBuffEffectT
	{
		// Token: 0x1700BD9B RID: 48539
		// (get) Token: 0x0602BA50 RID: 178768 RVA: 0x005F0F5B File Offset: 0x005EF15B
		// (set) Token: 0x0602BA51 RID: 178769 RVA: 0x005F0F63 File Offset: 0x005EF163
		public EOutAreaBorderEffectType Type { get; set; }

		// Token: 0x1700BD9C RID: 48540
		// (get) Token: 0x0602BA52 RID: 178770 RVA: 0x005F0F6C File Offset: 0x005EF16C
		// (set) Token: 0x0602BA53 RID: 178771 RVA: 0x005F0F74 File Offset: 0x005EF174
		public List<int> BuffIdList { get; set; }

		// Token: 0x0602BA54 RID: 178772 RVA: 0x005F0F7D File Offset: 0x005EF17D
		public IOutAreaBorderBuffEffectT()
		{
			this.Type = EOutAreaBorderEffectType.BuffId;
			this.BuffIdList = null;
		}
	}
}
