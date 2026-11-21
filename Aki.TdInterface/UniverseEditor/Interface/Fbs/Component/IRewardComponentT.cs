using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E75 RID: 24181
	public class IRewardComponentT
	{
		// Token: 0x1700B273 RID: 45683
		// (get) Token: 0x06028771 RID: 165745 RVA: 0x00588A7A File Offset: 0x00586C7A
		// (set) Token: 0x06028772 RID: 165746 RVA: 0x00588A82 File Offset: 0x00586C82
		public bool Disabled { get; set; }

		// Token: 0x1700B274 RID: 45684
		// (get) Token: 0x06028773 RID: 165747 RVA: 0x00588A8B File Offset: 0x00586C8B
		// (set) Token: 0x06028774 RID: 165748 RVA: 0x00588A93 File Offset: 0x00586C93
		public int RewardId { get; set; }

		// Token: 0x1700B275 RID: 45685
		// (get) Token: 0x06028775 RID: 165749 RVA: 0x00588A9C File Offset: 0x00586C9C
		// (set) Token: 0x06028776 RID: 165750 RVA: 0x00588AA4 File Offset: 0x00586CA4
		public ERewardType RewardType { get; set; }

		// Token: 0x1700B276 RID: 45686
		// (get) Token: 0x06028777 RID: 165751 RVA: 0x00588AAD File Offset: 0x00586CAD
		// (set) Token: 0x06028778 RID: 165752 RVA: 0x00588AB5 File Offset: 0x00586CB5
		public EDropEvent DropOnEvent { get; set; }

		// Token: 0x1700B277 RID: 45687
		// (get) Token: 0x06028779 RID: 165753 RVA: 0x00588ABE File Offset: 0x00586CBE
		// (set) Token: 0x0602877A RID: 165754 RVA: 0x00588AC6 File Offset: 0x00586CC6
		public IRewardRefreshConfigT RefreshConfig { get; set; }

		// Token: 0x1700B278 RID: 45688
		// (get) Token: 0x0602877B RID: 165755 RVA: 0x00588ACF File Offset: 0x00586CCF
		// (set) Token: 0x0602877C RID: 165756 RVA: 0x00588AD7 File Offset: 0x00586CD7
		public List<int> RewardIdList { get; set; }

		// Token: 0x1700B279 RID: 45689
		// (get) Token: 0x0602877D RID: 165757 RVA: 0x00588AE0 File Offset: 0x00586CE0
		// (set) Token: 0x0602877E RID: 165758 RVA: 0x00588AE8 File Offset: 0x00586CE8
		public byte NullMask { get; set; }

		// Token: 0x0602877F RID: 165759 RVA: 0x00588AF1 File Offset: 0x00586CF1
		public IRewardComponentT()
		{
			this.Disabled = false;
			this.RewardId = 0;
			this.RewardType = ERewardType.Nearby;
			this.DropOnEvent = EDropEvent.All;
			this.RefreshConfig = null;
			this.RewardIdList = null;
			this.NullMask = 0;
		}
	}
}
