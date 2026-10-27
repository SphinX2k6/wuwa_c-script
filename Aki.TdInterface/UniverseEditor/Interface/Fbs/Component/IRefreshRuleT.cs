using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005833 RID: 22579
	public class IRefreshRuleT
	{
		// Token: 0x1700A8A9 RID: 43177
		// (get) Token: 0x06025FA5 RID: 155557 RVA: 0x0053C5C6 File Offset: 0x0053A7C6
		// (set) Token: 0x06025FA6 RID: 155558 RVA: 0x0053C5CE File Offset: 0x0053A7CE
		public ERefreshRule Type { get; set; }

		// Token: 0x06025FA7 RID: 155559 RVA: 0x0053C5D7 File Offset: 0x0053A7D7
		public IRefreshRuleT()
		{
			this.Type = ERefreshRule.CD;
		}
	}
}
