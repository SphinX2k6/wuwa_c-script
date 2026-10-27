using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020040AD RID: 16557
	public class IRhythmSpaceshipConditionStepInteractT
	{
		// Token: 0x170074DC RID: 29916
		// (get) Token: 0x060181E1 RID: 98785 RVA: 0x0037A22A File Offset: 0x0037842A
		// (set) Token: 0x060181E2 RID: 98786 RVA: 0x0037A232 File Offset: 0x00378432
		public ERhythmSpaceshipConditionStep Type { get; set; }

		// Token: 0x060181E3 RID: 98787 RVA: 0x0037A23B File Offset: 0x0037843B
		public IRhythmSpaceshipConditionStepInteractT()
		{
			this.Type = ERhythmSpaceshipConditionStep.Interact;
		}
	}
}
