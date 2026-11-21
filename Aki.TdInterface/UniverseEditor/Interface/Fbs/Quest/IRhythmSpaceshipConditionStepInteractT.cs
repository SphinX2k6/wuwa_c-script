using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020044EE RID: 17646
	public class IRhythmSpaceshipConditionStepInteractT
	{
		// Token: 0x17007AE2 RID: 31458
		// (get) Token: 0x06019882 RID: 104578 RVA: 0x003A417A File Offset: 0x003A237A
		// (set) Token: 0x06019883 RID: 104579 RVA: 0x003A4182 File Offset: 0x003A2382
		public ERhythmSpaceshipConditionStep Type { get; set; }

		// Token: 0x06019884 RID: 104580 RVA: 0x003A418B File Offset: 0x003A238B
		public IRhythmSpaceshipConditionStepInteractT()
		{
			this.Type = ERhythmSpaceshipConditionStep.Interact;
		}
	}
}
