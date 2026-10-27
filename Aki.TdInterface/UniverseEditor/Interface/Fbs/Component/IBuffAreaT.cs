using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F29 RID: 20265
	public class IBuffAreaT
	{
		// Token: 0x1700920B RID: 37387
		// (get) Token: 0x06020116 RID: 131350 RVA: 0x004764BB File Offset: 0x004746BB
		// (set) Token: 0x06020117 RID: 131351 RVA: 0x004764C3 File Offset: 0x004746C3
		public EEffectAreaType Type { get; set; }

		// Token: 0x1700920C RID: 37388
		// (get) Token: 0x06020118 RID: 131352 RVA: 0x004764CC File Offset: 0x004746CC
		// (set) Token: 0x06020119 RID: 131353 RVA: 0x004764D4 File Offset: 0x004746D4
		public List<IBuffAreaStateConfigT> BuffConfigs { get; set; }

		// Token: 0x0602011A RID: 131354 RVA: 0x004764DD File Offset: 0x004746DD
		public IBuffAreaT()
		{
			this.Type = EEffectAreaType.BuffArea;
			this.BuffConfigs = null;
		}
	}
}
