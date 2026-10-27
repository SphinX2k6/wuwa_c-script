using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007497 RID: 29847
	public class ITuningStandBubbleConfigT
	{
		// Token: 0x1700E2A4 RID: 58020
		// (get) Token: 0x06036416 RID: 222230 RVA: 0x007602BF File Offset: 0x0075E4BF
		// (set) Token: 0x06036417 RID: 222231 RVA: 0x007602C7 File Offset: 0x0075E4C7
		public ETuningStandBubbleTriggerType TriggerType { get; set; }

		// Token: 0x1700E2A5 RID: 58021
		// (get) Token: 0x06036418 RID: 222232 RVA: 0x007602D0 File Offset: 0x0075E4D0
		// (set) Token: 0x06036419 RID: 222233 RVA: 0x007602D8 File Offset: 0x0075E4D8
		public IPlayFlowT Flow { get; set; }

		// Token: 0x0603641A RID: 222234 RVA: 0x007602E1 File Offset: 0x0075E4E1
		public ITuningStandBubbleConfigT()
		{
			this.TriggerType = ETuningStandBubbleTriggerType.Enter;
			this.Flow = null;
		}
	}
}
