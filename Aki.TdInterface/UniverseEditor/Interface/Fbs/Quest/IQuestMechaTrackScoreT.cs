using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004431 RID: 17457
	public class IQuestMechaTrackScoreT
	{
		// Token: 0x170078E6 RID: 30950
		// (get) Token: 0x06018FD1 RID: 102353 RVA: 0x003905FF File Offset: 0x0038E7FF
		// (set) Token: 0x06018FD2 RID: 102354 RVA: 0x00390607 File Offset: 0x0038E807
		public EStatisticsEventType Type { get; set; }

		// Token: 0x170078E7 RID: 30951
		// (get) Token: 0x06018FD3 RID: 102355 RVA: 0x00390610 File Offset: 0x0038E810
		// (set) Token: 0x06018FD4 RID: 102356 RVA: 0x00390618 File Offset: 0x0038E818
		public TVarRefUnion Var { get; set; }

		// Token: 0x170078E8 RID: 30952
		// (get) Token: 0x06018FD5 RID: 102357 RVA: 0x00390621 File Offset: 0x0038E821
		// (set) Token: 0x06018FD6 RID: 102358 RVA: 0x00390629 File Offset: 0x0038E829
		public int ScoreGroupId { get; set; }

		// Token: 0x170078E9 RID: 30953
		// (get) Token: 0x06018FD7 RID: 102359 RVA: 0x00390632 File Offset: 0x0038E832
		// (set) Token: 0x06018FD8 RID: 102360 RVA: 0x0039063A File Offset: 0x0038E83A
		public List<TMechaTrackScoreDetectionTypeUnion> DetectionTypes { get; set; }

		// Token: 0x06018FD9 RID: 102361 RVA: 0x00390643 File Offset: 0x0038E843
		public IQuestMechaTrackScoreT()
		{
			this.Type = EStatisticsEventType.Collect;
			this.Var = null;
			this.ScoreGroupId = 0;
			this.DetectionTypes = null;
		}
	}
}
