using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200707D RID: 28797
	public class ISetStateMachineBlendAnimTypeT
	{
		// Token: 0x1700D600 RID: 54784
		// (get) Token: 0x06032FCB RID: 208843 RVA: 0x006E09E4 File Offset: 0x006DEBE4
		// (set) Token: 0x06032FCC RID: 208844 RVA: 0x006E09EC File Offset: 0x006DEBEC
		public EBlendAnimType Type { get; set; }

		// Token: 0x1700D601 RID: 54785
		// (get) Token: 0x06032FCD RID: 208845 RVA: 0x006E09F5 File Offset: 0x006DEBF5
		// (set) Token: 0x06032FCE RID: 208846 RVA: 0x006E09FD File Offset: 0x006DEBFD
		public EBlendAnimState State { get; set; }

		// Token: 0x06032FCF RID: 208847 RVA: 0x006E0A06 File Offset: 0x006DEC06
		public ISetStateMachineBlendAnimTypeT()
		{
			this.Type = EBlendAnimType.StateMachine;
			this.State = EBlendAnimState.CombatIdle;
		}
	}
}
