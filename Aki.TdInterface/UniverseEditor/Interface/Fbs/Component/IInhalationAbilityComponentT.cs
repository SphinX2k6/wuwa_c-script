using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200597F RID: 22911
	public class IInhalationAbilityComponentT
	{
		// Token: 0x1700A66C RID: 42604
		// (get) Token: 0x06025597 RID: 152983 RVA: 0x0052041D File Offset: 0x0051E61D
		// (set) Token: 0x06025598 RID: 152984 RVA: 0x00520425 File Offset: 0x0051E625
		public bool Disabled { get; set; }

		// Token: 0x1700A66D RID: 42605
		// (get) Token: 0x06025599 RID: 152985 RVA: 0x0052042E File Offset: 0x0051E62E
		// (set) Token: 0x0602559A RID: 152986 RVA: 0x00520436 File Offset: 0x0051E636
		public List<IInhalationConfigT> InhalationConfigs { get; set; }

		// Token: 0x1700A66E RID: 42606
		// (get) Token: 0x0602559B RID: 152987 RVA: 0x0052043F File Offset: 0x0051E63F
		// (set) Token: 0x0602559C RID: 152988 RVA: 0x00520447 File Offset: 0x0051E647
		public byte NullMask { get; set; }

		// Token: 0x0602559D RID: 152989 RVA: 0x00520450 File Offset: 0x0051E650
		public IInhalationAbilityComponentT()
		{
			this.Disabled = false;
			this.InhalationConfigs = null;
			this.NullMask = 0;
		}
	}
}
