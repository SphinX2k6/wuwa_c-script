using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E78 RID: 24184
	public class IRewardRefreshConfigT
	{
		// Token: 0x1700B27F RID: 45695
		// (get) Token: 0x0602879E RID: 165790 RVA: 0x0058912F File Offset: 0x0058732F
		// (set) Token: 0x0602879F RID: 165791 RVA: 0x00589137 File Offset: 0x00587337
		public TRefreshConditionUnion RefreshCondition { get; set; }

		// Token: 0x1700B280 RID: 45696
		// (get) Token: 0x060287A0 RID: 165792 RVA: 0x00589140 File Offset: 0x00587340
		// (set) Token: 0x060287A1 RID: 165793 RVA: 0x00589148 File Offset: 0x00587348
		public TRefreshRuleUnion RefreshType { get; set; }

		// Token: 0x1700B281 RID: 45697
		// (get) Token: 0x060287A2 RID: 165794 RVA: 0x00589151 File Offset: 0x00587351
		// (set) Token: 0x060287A3 RID: 165795 RVA: 0x00589159 File Offset: 0x00587359
		public int MaxCount { get; set; }

		// Token: 0x1700B282 RID: 45698
		// (get) Token: 0x060287A4 RID: 165796 RVA: 0x00589162 File Offset: 0x00587362
		// (set) Token: 0x060287A5 RID: 165797 RVA: 0x0058916A File Offset: 0x0058736A
		public byte NullMask { get; set; }

		// Token: 0x060287A6 RID: 165798 RVA: 0x00589173 File Offset: 0x00587373
		public IRewardRefreshConfigT()
		{
			this.RefreshCondition = null;
			this.RefreshType = null;
			this.MaxCount = 0;
			this.NullMask = 0;
		}
	}
}
