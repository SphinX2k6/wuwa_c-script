using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007849 RID: 30793
	public class ISetStateMachineBlendAnimTypeT
	{
		// Token: 0x1700E1E3 RID: 57827
		// (get) Token: 0x0603626D RID: 221805 RVA: 0x00740FF0 File Offset: 0x0073F1F0
		// (set) Token: 0x0603626E RID: 221806 RVA: 0x00740FF8 File Offset: 0x0073F1F8
		public EBlendAnimType Type { get; set; }

		// Token: 0x1700E1E4 RID: 57828
		// (get) Token: 0x0603626F RID: 221807 RVA: 0x00741001 File Offset: 0x0073F201
		// (set) Token: 0x06036270 RID: 221808 RVA: 0x00741009 File Offset: 0x0073F209
		public EBlendAnimState State { get; set; }

		// Token: 0x06036271 RID: 221809 RVA: 0x00741012 File Offset: 0x0073F212
		public ISetStateMachineBlendAnimTypeT()
		{
			this.Type = EBlendAnimType.StateMachine;
			this.State = EBlendAnimState.CombatIdle;
		}
	}
}
