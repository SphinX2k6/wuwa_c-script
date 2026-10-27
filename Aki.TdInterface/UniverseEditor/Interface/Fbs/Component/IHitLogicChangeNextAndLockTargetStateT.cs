using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005399 RID: 21401
	public class IHitLogicChangeNextAndLockTargetStateT
	{
		// Token: 0x17009D41 RID: 40257
		// (get) Token: 0x060230CC RID: 143564 RVA: 0x004DA57B File Offset: 0x004D877B
		// (set) Token: 0x060230CD RID: 143565 RVA: 0x004DA583 File Offset: 0x004D8783
		public EHitLogicType Type { get; set; }

		// Token: 0x17009D42 RID: 40258
		// (get) Token: 0x060230CE RID: 143566 RVA: 0x004DA58C File Offset: 0x004D878C
		// (set) Token: 0x060230CF RID: 143567 RVA: 0x004DA594 File Offset: 0x004D8794
		public string TargetState { get; set; }

		// Token: 0x060230D0 RID: 143568 RVA: 0x004DA59D File Offset: 0x004D879D
		public IHitLogicChangeNextAndLockTargetStateT()
		{
			this.Type = EHitLogicType.ChangeNextState;
			this.TargetState = null;
		}
	}
}
