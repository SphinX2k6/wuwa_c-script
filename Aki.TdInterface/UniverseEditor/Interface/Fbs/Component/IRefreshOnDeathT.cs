using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200582D RID: 22573
	public class IRefreshOnDeathT
	{
		// Token: 0x1700A8A3 RID: 43171
		// (get) Token: 0x06025F81 RID: 155521 RVA: 0x0053C2D6 File Offset: 0x0053A4D6
		// (set) Token: 0x06025F82 RID: 155522 RVA: 0x0053C2DE File Offset: 0x0053A4DE
		public ERewardDropType Type { get; set; }

		// Token: 0x06025F83 RID: 155523 RVA: 0x0053C2E7 File Offset: 0x0053A4E7
		public IRefreshOnDeathT()
		{
			this.Type = ERewardDropType.Death;
		}
	}
}
