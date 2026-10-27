using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004AFD RID: 19197
	public class ICheckPlayerRelativeDistanceT
	{
		// Token: 0x17008B3E RID: 35646
		// (get) Token: 0x0601E2E7 RID: 123623 RVA: 0x0043B899 File Offset: 0x00439A99
		// (set) Token: 0x0601E2E8 RID: 123624 RVA: 0x0043B8A1 File Offset: 0x00439AA1
		public ECondition Type { get; set; }

		// Token: 0x17008B3F RID: 35647
		// (get) Token: 0x0601E2E9 RID: 123625 RVA: 0x0043B8AA File Offset: 0x00439AAA
		// (set) Token: 0x0601E2EA RID: 123626 RVA: 0x0043B8B2 File Offset: 0x00439AB2
		public int TargetEntityId { get; set; }

		// Token: 0x17008B40 RID: 35648
		// (get) Token: 0x0601E2EB RID: 123627 RVA: 0x0043B8BB File Offset: 0x00439ABB
		// (set) Token: 0x0601E2EC RID: 123628 RVA: 0x0043B8C3 File Offset: 0x00439AC3
		public List<IDistanceRangeT> ValidDistanceRanges { get; set; }

		// Token: 0x0601E2ED RID: 123629 RVA: 0x0043B8CC File Offset: 0x00439ACC
		public ICheckPlayerRelativeDistanceT()
		{
			this.Type = ECondition.CompareVar;
			this.TargetEntityId = 0;
			this.ValidDistanceRanges = null;
		}
	}
}
