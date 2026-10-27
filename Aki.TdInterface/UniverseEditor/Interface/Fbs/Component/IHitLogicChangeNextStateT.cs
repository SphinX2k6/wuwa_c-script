using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200539C RID: 21404
	public class IHitLogicChangeNextStateT
	{
		// Token: 0x17009D45 RID: 40261
		// (get) Token: 0x060230E0 RID: 143584 RVA: 0x004DA716 File Offset: 0x004D8916
		// (set) Token: 0x060230E1 RID: 143585 RVA: 0x004DA71E File Offset: 0x004D891E
		public EHitLogicType Type { get; set; }

		// Token: 0x060230E2 RID: 143586 RVA: 0x004DA727 File Offset: 0x004D8927
		public IHitLogicChangeNextStateT()
		{
			this.Type = EHitLogicType.ChangeNextState;
		}
	}
}
