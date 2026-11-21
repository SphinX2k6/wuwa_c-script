using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E37 RID: 24119
	public class IRefreshOnHostInteractT
	{
		// Token: 0x1700B1CA RID: 45514
		// (get) Token: 0x060284B3 RID: 165043 RVA: 0x005825DA File Offset: 0x005807DA
		// (set) Token: 0x060284B4 RID: 165044 RVA: 0x005825E2 File Offset: 0x005807E2
		public ERewardDropType Type { get; set; }

		// Token: 0x060284B5 RID: 165045 RVA: 0x005825EB File Offset: 0x005807EB
		public IRefreshOnHostInteractT()
		{
			this.Type = ERewardDropType.Death;
		}
	}
}
