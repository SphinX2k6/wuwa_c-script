using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E1F RID: 24095
	public class IRefreshComponentT
	{
		// Token: 0x1700B19C RID: 45468
		// (get) Token: 0x060283E2 RID: 164834 RVA: 0x00580D59 File Offset: 0x0057EF59
		// (set) Token: 0x060283E3 RID: 164835 RVA: 0x00580D61 File Offset: 0x0057EF61
		public bool Disabled { get; set; }

		// Token: 0x1700B19D RID: 45469
		// (get) Token: 0x060283E4 RID: 164836 RVA: 0x00580D6A File Offset: 0x0057EF6A
		// (set) Token: 0x060283E5 RID: 164837 RVA: 0x00580D72 File Offset: 0x0057EF72
		public TRefreshRuleUnion RefreshRule { get; set; }

		// Token: 0x1700B19E RID: 45470
		// (get) Token: 0x060283E6 RID: 164838 RVA: 0x00580D7B File Offset: 0x0057EF7B
		// (set) Token: 0x060283E7 RID: 164839 RVA: 0x00580D83 File Offset: 0x0057EF83
		public bool IsDisableRefreshAfterDroppingReward { get; set; }

		// Token: 0x1700B19F RID: 45471
		// (get) Token: 0x060283E8 RID: 164840 RVA: 0x00580D8C File Offset: 0x0057EF8C
		// (set) Token: 0x060283E9 RID: 164841 RVA: 0x00580D94 File Offset: 0x0057EF94
		public bool IsResetOnDungeonRestart { get; set; }

		// Token: 0x1700B1A0 RID: 45472
		// (get) Token: 0x060283EA RID: 164842 RVA: 0x00580D9D File Offset: 0x0057EF9D
		// (set) Token: 0x060283EB RID: 164843 RVA: 0x00580DA5 File Offset: 0x0057EFA5
		public byte NullMask { get; set; }

		// Token: 0x060283EC RID: 164844 RVA: 0x00580DAE File Offset: 0x0057EFAE
		public IRefreshComponentT()
		{
			this.Disabled = false;
			this.RefreshRule = null;
			this.IsDisableRefreshAfterDroppingReward = false;
			this.IsResetOnDungeonRestart = false;
			this.NullMask = 0;
		}
	}
}
