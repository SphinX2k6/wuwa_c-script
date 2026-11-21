using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C8A RID: 31882
	public class ITuningStandBubbleConfigT
	{
		// Token: 0x1700EEC3 RID: 61123
		// (get) Token: 0x06039803 RID: 235523 RVA: 0x007C307B File Offset: 0x007C127B
		// (set) Token: 0x06039804 RID: 235524 RVA: 0x007C3083 File Offset: 0x007C1283
		public ETuningStandBubbleTriggerType TriggerType { get; set; }

		// Token: 0x1700EEC4 RID: 61124
		// (get) Token: 0x06039805 RID: 235525 RVA: 0x007C308C File Offset: 0x007C128C
		// (set) Token: 0x06039806 RID: 235526 RVA: 0x007C3094 File Offset: 0x007C1294
		public IPlayFlowT Flow { get; set; }

		// Token: 0x06039807 RID: 235527 RVA: 0x007C309D File Offset: 0x007C129D
		public ITuningStandBubbleConfigT()
		{
			this.TriggerType = ETuningStandBubbleTriggerType.Enter;
			this.Flow = null;
		}
	}
}
