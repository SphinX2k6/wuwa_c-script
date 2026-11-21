using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004494 RID: 17556
	public class IQuestStatisticsPlayerTriggerMotionT
	{
		// Token: 0x170079F4 RID: 31220
		// (get) Token: 0x06019480 RID: 103552 RVA: 0x0039BAFD File Offset: 0x00399CFD
		// (set) Token: 0x06019481 RID: 103553 RVA: 0x0039BB05 File Offset: 0x00399D05
		public EStatisticsEventType Type { get; set; }

		// Token: 0x170079F5 RID: 31221
		// (get) Token: 0x06019482 RID: 103554 RVA: 0x0039BB0E File Offset: 0x00399D0E
		// (set) Token: 0x06019483 RID: 103555 RVA: 0x0039BB16 File Offset: 0x00399D16
		public TVarRefUnion Var { get; set; }

		// Token: 0x170079F6 RID: 31222
		// (get) Token: 0x06019484 RID: 103556 RVA: 0x0039BB1F File Offset: 0x00399D1F
		// (set) Token: 0x06019485 RID: 103557 RVA: 0x0039BB27 File Offset: 0x00399D27
		public EPlayerTriggerMotion MotionType { get; set; }

		// Token: 0x06019486 RID: 103558 RVA: 0x0039BB30 File Offset: 0x00399D30
		public IQuestStatisticsPlayerTriggerMotionT()
		{
			this.Type = EStatisticsEventType.Collect;
			this.Var = null;
			this.MotionType = EPlayerTriggerMotion.GroundSprint;
		}
	}
}
