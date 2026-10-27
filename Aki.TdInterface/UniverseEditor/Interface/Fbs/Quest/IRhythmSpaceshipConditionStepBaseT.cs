using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020040A7 RID: 16551
	public class IRhythmSpaceshipConditionStepBaseT
	{
		// Token: 0x170074D7 RID: 29911
		// (get) Token: 0x060181C3 RID: 98755 RVA: 0x00379FB6 File Offset: 0x003781B6
		// (set) Token: 0x060181C4 RID: 98756 RVA: 0x00379FBE File Offset: 0x003781BE
		public ERhythmSpaceshipConditionStep Type { get; set; }

		// Token: 0x060181C5 RID: 98757 RVA: 0x00379FC7 File Offset: 0x003781C7
		public IRhythmSpaceshipConditionStepBaseT()
		{
			this.Type = ERhythmSpaceshipConditionStep.Interact;
		}
	}
}
