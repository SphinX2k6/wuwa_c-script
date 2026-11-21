using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020044E8 RID: 17640
	public class IRhythmSpaceshipConditionStepBaseT
	{
		// Token: 0x17007ADD RID: 31453
		// (get) Token: 0x06019864 RID: 104548 RVA: 0x003A3F06 File Offset: 0x003A2106
		// (set) Token: 0x06019865 RID: 104549 RVA: 0x003A3F0E File Offset: 0x003A210E
		public ERhythmSpaceshipConditionStep Type { get; set; }

		// Token: 0x06019866 RID: 104550 RVA: 0x003A3F17 File Offset: 0x003A2117
		public IRhythmSpaceshipConditionStepBaseT()
		{
			this.Type = ERhythmSpaceshipConditionStep.Interact;
		}
	}
}
