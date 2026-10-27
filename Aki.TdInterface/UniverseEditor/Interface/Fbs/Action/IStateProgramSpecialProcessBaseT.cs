using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071C1 RID: 29121
	public class IStateProgramSpecialProcessBaseT
	{
		// Token: 0x1700D867 RID: 55399
		// (get) Token: 0x06033AA2 RID: 211618 RVA: 0x006F5272 File Offset: 0x006F3472
		// (set) Token: 0x06033AA3 RID: 211619 RVA: 0x006F527A File Offset: 0x006F347A
		public ELogicProgramSpecialProcess Type { get; set; }

		// Token: 0x06033AA4 RID: 211620 RVA: 0x006F5283 File Offset: 0x006F3483
		public IStateProgramSpecialProcessBaseT()
		{
			this.Type = ELogicProgramSpecialProcess.ChangeTeamOptimization;
		}
	}
}
