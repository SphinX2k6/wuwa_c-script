using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020044FA RID: 17658
	public class IRogueTowerTrialSystemVarT
	{
		// Token: 0x17007AF5 RID: 31477
		// (get) Token: 0x060198E5 RID: 104677 RVA: 0x003A4D63 File Offset: 0x003A2F63
		// (set) Token: 0x060198E6 RID: 104678 RVA: 0x003A4D6B File Offset: 0x003A2F6B
		public ERogueTowerTrialSystemVarType VarType { get; set; }

		// Token: 0x17007AF6 RID: 31478
		// (get) Token: 0x060198E7 RID: 104679 RVA: 0x003A4D74 File Offset: 0x003A2F74
		// (set) Token: 0x060198E8 RID: 104680 RVA: 0x003A4D7C File Offset: 0x003A2F7C
		public TVarRefUnion VarRef { get; set; }

		// Token: 0x060198E9 RID: 104681 RVA: 0x003A4D85 File Offset: 0x003A2F85
		public IRogueTowerTrialSystemVarT()
		{
			this.VarType = ERogueTowerTrialSystemVarType.KillBoss1;
			this.VarRef = null;
		}
	}
}
