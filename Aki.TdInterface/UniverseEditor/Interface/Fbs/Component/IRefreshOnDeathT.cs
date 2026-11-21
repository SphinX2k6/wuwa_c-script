using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E34 RID: 24116
	public class IRefreshOnDeathT
	{
		// Token: 0x1700B1C7 RID: 45511
		// (get) Token: 0x060284A1 RID: 165025 RVA: 0x00582462 File Offset: 0x00580662
		// (set) Token: 0x060284A2 RID: 165026 RVA: 0x0058246A File Offset: 0x0058066A
		public ERewardDropType Type { get; set; }

		// Token: 0x060284A3 RID: 165027 RVA: 0x00582473 File Offset: 0x00580673
		public IRefreshOnDeathT()
		{
			this.Type = ERewardDropType.Death;
		}
	}
}
