using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005785 RID: 22405
	public class IProbabilityRefreshItemT
	{
		// Token: 0x1700A71F RID: 42783
		// (get) Token: 0x060258FF RID: 153855 RVA: 0x0052E75D File Offset: 0x0052C95D
		// (set) Token: 0x06025900 RID: 153856 RVA: 0x0052E765 File Offset: 0x0052C965
		public int Probability { get; set; }

		// Token: 0x1700A720 RID: 42784
		// (get) Token: 0x06025901 RID: 153857 RVA: 0x0052E76E File Offset: 0x0052C96E
		// (set) Token: 0x06025902 RID: 153858 RVA: 0x0052E776 File Offset: 0x0052C976
		public int RefreshEntityId { get; set; }

		// Token: 0x1700A721 RID: 42785
		// (get) Token: 0x06025903 RID: 153859 RVA: 0x0052E77F File Offset: 0x0052C97F
		// (set) Token: 0x06025904 RID: 153860 RVA: 0x0052E787 File Offset: 0x0052C987
		public IConditionGroupT AdditionalCondition { get; set; }

		// Token: 0x06025905 RID: 153861 RVA: 0x0052E790 File Offset: 0x0052C990
		public IProbabilityRefreshItemT()
		{
			this.Probability = 0;
			this.RefreshEntityId = 0;
			this.AdditionalCondition = null;
		}
	}
}
