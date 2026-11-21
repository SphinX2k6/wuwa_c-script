using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005098 RID: 20632
	public class ICompareLevelPlayRewardStateConditionT
	{
		// Token: 0x170093C0 RID: 37824
		// (get) Token: 0x06020494 RID: 132244 RVA: 0x00479070 File Offset: 0x00477270
		// (set) Token: 0x06020495 RID: 132245 RVA: 0x00479078 File Offset: 0x00477278
		public ECondition Type { get; set; }

		// Token: 0x170093C1 RID: 37825
		// (get) Token: 0x06020496 RID: 132246 RVA: 0x00479081 File Offset: 0x00477281
		// (set) Token: 0x06020497 RID: 132247 RVA: 0x00479089 File Offset: 0x00477289
		public ECompare Compare { get; set; }

		// Token: 0x06020498 RID: 132248 RVA: 0x00479092 File Offset: 0x00477292
		public ICompareLevelPlayRewardStateConditionT()
		{
			this.Type = ECondition.CompareVar;
			this.Compare = ECompare.Eq;
		}
	}
}
