using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A22 RID: 18978
	public class ICheckFinishLoadingT
	{
		// Token: 0x17008961 RID: 35169
		// (get) Token: 0x0601DB25 RID: 121637 RVA: 0x0042D777 File Offset: 0x0042B977
		// (set) Token: 0x0601DB26 RID: 121638 RVA: 0x0042D77F File Offset: 0x0042B97F
		public ECondition Type { get; set; }

		// Token: 0x17008962 RID: 35170
		// (get) Token: 0x0601DB27 RID: 121639 RVA: 0x0042D788 File Offset: 0x0042B988
		// (set) Token: 0x0601DB28 RID: 121640 RVA: 0x0042D790 File Offset: 0x0042B990
		public IAllPlayerTypeT CheckTarget { get; set; }

		// Token: 0x0601DB29 RID: 121641 RVA: 0x0042D799 File Offset: 0x0042B999
		public ICheckFinishLoadingT()
		{
			this.Type = ECondition.CompareVar;
			this.CheckTarget = null;
		}
	}
}
