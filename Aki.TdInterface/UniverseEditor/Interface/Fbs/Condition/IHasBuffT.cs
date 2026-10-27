using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C32 RID: 19506
	public class IHasBuffT
	{
		// Token: 0x17008DB4 RID: 36276
		// (get) Token: 0x0601EE9D RID: 126621 RVA: 0x0045365B File Offset: 0x0045185B
		// (set) Token: 0x0601EE9E RID: 126622 RVA: 0x00453663 File Offset: 0x00451863
		public ECondition Type { get; set; }

		// Token: 0x17008DB5 RID: 36277
		// (get) Token: 0x0601EE9F RID: 126623 RVA: 0x0045366C File Offset: 0x0045186C
		// (set) Token: 0x0601EEA0 RID: 126624 RVA: 0x00453674 File Offset: 0x00451874
		public long BuffId { get; set; }

		// Token: 0x17008DB6 RID: 36278
		// (get) Token: 0x0601EEA1 RID: 126625 RVA: 0x0045367D File Offset: 0x0045187D
		// (set) Token: 0x0601EEA2 RID: 126626 RVA: 0x00453685 File Offset: 0x00451885
		public ECompare Compare { get; set; }

		// Token: 0x17008DB7 RID: 36279
		// (get) Token: 0x0601EEA3 RID: 126627 RVA: 0x0045368E File Offset: 0x0045188E
		// (set) Token: 0x0601EEA4 RID: 126628 RVA: 0x00453696 File Offset: 0x00451896
		public TOnlinePlayerConditionTargetUnion OnlinePlayerConditionTargetOption { get; set; }

		// Token: 0x0601EEA5 RID: 126629 RVA: 0x0045369F File Offset: 0x0045189F
		public IHasBuffT()
		{
			this.Type = ECondition.CompareVar;
			this.BuffId = 0L;
			this.Compare = ECompare.Eq;
			this.OnlinePlayerConditionTargetOption = null;
		}
	}
}
