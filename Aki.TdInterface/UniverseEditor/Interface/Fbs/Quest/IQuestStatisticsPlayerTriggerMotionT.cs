using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004053 RID: 16467
	public class IQuestStatisticsPlayerTriggerMotionT
	{
		// Token: 0x170073F2 RID: 29682
		// (get) Token: 0x06017DE7 RID: 97767 RVA: 0x00371D09 File Offset: 0x0036FF09
		// (set) Token: 0x06017DE8 RID: 97768 RVA: 0x00371D11 File Offset: 0x0036FF11
		public EStatisticsEventType Type { get; set; }

		// Token: 0x170073F3 RID: 29683
		// (get) Token: 0x06017DE9 RID: 97769 RVA: 0x00371D1A File Offset: 0x0036FF1A
		// (set) Token: 0x06017DEA RID: 97770 RVA: 0x00371D22 File Offset: 0x0036FF22
		public TVarRefUnion Var { get; set; }

		// Token: 0x170073F4 RID: 29684
		// (get) Token: 0x06017DEB RID: 97771 RVA: 0x00371D2B File Offset: 0x0036FF2B
		// (set) Token: 0x06017DEC RID: 97772 RVA: 0x00371D33 File Offset: 0x0036FF33
		public EPlayerTriggerMotion MotionType { get; set; }

		// Token: 0x06017DED RID: 97773 RVA: 0x00371D3C File Offset: 0x0036FF3C
		public IQuestStatisticsPlayerTriggerMotionT()
		{
			this.Type = EStatisticsEventType.Collect;
			this.Var = null;
			this.MotionType = EPlayerTriggerMotion.GroundSprint;
		}
	}
}
