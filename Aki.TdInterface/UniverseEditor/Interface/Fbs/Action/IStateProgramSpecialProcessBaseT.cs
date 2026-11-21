using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007996 RID: 31126
	public class IStateProgramSpecialProcessBaseT
	{
		// Token: 0x1700E460 RID: 58464
		// (get) Token: 0x06036DA4 RID: 224676 RVA: 0x007565D2 File Offset: 0x007547D2
		// (set) Token: 0x06036DA5 RID: 224677 RVA: 0x007565DA File Offset: 0x007547DA
		public ELogicProgramSpecialProcess Type { get; set; }

		// Token: 0x06036DA6 RID: 224678 RVA: 0x007565E3 File Offset: 0x007547E3
		public IStateProgramSpecialProcessBaseT()
		{
			this.Type = ELogicProgramSpecialProcess.ChangeTeamOptimization;
		}
	}
}
