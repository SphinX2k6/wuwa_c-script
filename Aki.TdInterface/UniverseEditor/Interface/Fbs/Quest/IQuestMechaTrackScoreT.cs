using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003FF0 RID: 16368
	public class IQuestMechaTrackScoreT
	{
		// Token: 0x170072E4 RID: 29412
		// (get) Token: 0x06017938 RID: 96568 RVA: 0x0036680B File Offset: 0x00364A0B
		// (set) Token: 0x06017939 RID: 96569 RVA: 0x00366813 File Offset: 0x00364A13
		public EStatisticsEventType Type { get; set; }

		// Token: 0x170072E5 RID: 29413
		// (get) Token: 0x0601793A RID: 96570 RVA: 0x0036681C File Offset: 0x00364A1C
		// (set) Token: 0x0601793B RID: 96571 RVA: 0x00366824 File Offset: 0x00364A24
		public TVarRefUnion Var { get; set; }

		// Token: 0x170072E6 RID: 29414
		// (get) Token: 0x0601793C RID: 96572 RVA: 0x0036682D File Offset: 0x00364A2D
		// (set) Token: 0x0601793D RID: 96573 RVA: 0x00366835 File Offset: 0x00364A35
		public int ScoreGroupId { get; set; }

		// Token: 0x170072E7 RID: 29415
		// (get) Token: 0x0601793E RID: 96574 RVA: 0x0036683E File Offset: 0x00364A3E
		// (set) Token: 0x0601793F RID: 96575 RVA: 0x00366846 File Offset: 0x00364A46
		public List<TMechaTrackScoreDetectionTypeUnion> DetectionTypes { get; set; }

		// Token: 0x06017940 RID: 96576 RVA: 0x0036684F File Offset: 0x00364A4F
		public IQuestMechaTrackScoreT()
		{
			this.Type = EStatisticsEventType.Collect;
			this.Var = null;
			this.ScoreGroupId = 0;
			this.DetectionTypes = null;
		}
	}
}
