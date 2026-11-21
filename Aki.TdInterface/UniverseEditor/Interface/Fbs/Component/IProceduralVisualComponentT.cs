using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D9E RID: 23966
	public class IProceduralVisualComponentT
	{
		// Token: 0x1700B05E RID: 45150
		// (get) Token: 0x06027EAB RID: 163499 RVA: 0x005759DD File Offset: 0x00573BDD
		// (set) Token: 0x06027EAC RID: 163500 RVA: 0x005759E5 File Offset: 0x00573BE5
		public bool Disabled { get; set; }

		// Token: 0x1700B05F RID: 45151
		// (get) Token: 0x06027EAD RID: 163501 RVA: 0x005759EE File Offset: 0x00573BEE
		// (set) Token: 0x06027EAE RID: 163502 RVA: 0x005759F6 File Offset: 0x00573BF6
		public List<TProceduralVisualUnion> Configs { get; set; }

		// Token: 0x1700B060 RID: 45152
		// (get) Token: 0x06027EAF RID: 163503 RVA: 0x005759FF File Offset: 0x00573BFF
		// (set) Token: 0x06027EB0 RID: 163504 RVA: 0x00575A07 File Offset: 0x00573C07
		public byte NullMask { get; set; }

		// Token: 0x06027EB1 RID: 163505 RVA: 0x00575A10 File Offset: 0x00573C10
		public IProceduralVisualComponentT()
		{
			this.Disabled = false;
			this.Configs = null;
			this.NullMask = 0;
		}
	}
}
