using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BB6 RID: 27574
	public class INpcFollowConfigT
	{
		// Token: 0x1700CCF5 RID: 52469
		// (get) Token: 0x06030713 RID: 198419 RVA: 0x00694286 File Offset: 0x00692486
		// (set) Token: 0x06030714 RID: 198420 RVA: 0x0069428E File Offset: 0x0069248E
		public IPerformerRangeBoundaryActionTriggerT PerformerWhenEnter { get; set; }

		// Token: 0x1700CCF6 RID: 52470
		// (get) Token: 0x06030715 RID: 198421 RVA: 0x00694297 File Offset: 0x00692497
		// (set) Token: 0x06030716 RID: 198422 RVA: 0x0069429F File Offset: 0x0069249F
		public IPerformerRangeBoundaryActionTriggerT PerformerWhenExit { get; set; }

		// Token: 0x06030717 RID: 198423 RVA: 0x006942A8 File Offset: 0x006924A8
		public INpcFollowConfigT()
		{
			this.PerformerWhenEnter = null;
			this.PerformerWhenExit = null;
		}
	}
}
