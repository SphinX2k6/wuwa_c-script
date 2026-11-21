using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200545B RID: 21595
	public class IBuffAreaT
	{
		// Token: 0x1700998D RID: 39309
		// (get) Token: 0x06021E86 RID: 138886 RVA: 0x004AC84F File Offset: 0x004AAA4F
		// (set) Token: 0x06021E87 RID: 138887 RVA: 0x004AC857 File Offset: 0x004AAA57
		public EEffectAreaType Type { get; set; }

		// Token: 0x1700998E RID: 39310
		// (get) Token: 0x06021E88 RID: 138888 RVA: 0x004AC860 File Offset: 0x004AAA60
		// (set) Token: 0x06021E89 RID: 138889 RVA: 0x004AC868 File Offset: 0x004AAA68
		public List<IBuffAreaStateConfigT> BuffConfigs { get; set; }

		// Token: 0x06021E8A RID: 138890 RVA: 0x004AC871 File Offset: 0x004AAA71
		public IBuffAreaT()
		{
			this.Type = EEffectAreaType.BuffArea;
			this.BuffConfigs = null;
		}
	}
}
