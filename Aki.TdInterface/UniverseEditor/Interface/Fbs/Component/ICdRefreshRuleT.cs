using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F74 RID: 20340
	public class ICdRefreshRuleT
	{
		// Token: 0x17009300 RID: 37632
		// (get) Token: 0x06020493 RID: 132243 RVA: 0x0047E128 File Offset: 0x0047C328
		// (set) Token: 0x06020494 RID: 132244 RVA: 0x0047E130 File Offset: 0x0047C330
		public ERefreshRule Type { get; set; }

		// Token: 0x17009301 RID: 37633
		// (get) Token: 0x06020495 RID: 132245 RVA: 0x0047E139 File Offset: 0x0047C339
		// (set) Token: 0x06020496 RID: 132246 RVA: 0x0047E141 File Offset: 0x0047C341
		public int Cd { get; set; }

		// Token: 0x06020497 RID: 132247 RVA: 0x0047E14A File Offset: 0x0047C34A
		public ICdRefreshRuleT()
		{
			this.Type = ERefreshRule.CD;
			this.Cd = 0;
		}
	}
}
