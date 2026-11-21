using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E3A RID: 24122
	public class IRefreshRuleT
	{
		// Token: 0x1700B1CD RID: 45517
		// (get) Token: 0x060284C5 RID: 165061 RVA: 0x00582752 File Offset: 0x00580952
		// (set) Token: 0x060284C6 RID: 165062 RVA: 0x0058275A File Offset: 0x0058095A
		public ERefreshRule Type { get; set; }

		// Token: 0x060284C7 RID: 165063 RVA: 0x00582763 File Offset: 0x00580963
		public IRefreshRuleT()
		{
			this.Type = ERefreshRule.CD;
		}
	}
}
