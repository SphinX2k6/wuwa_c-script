using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200427B RID: 17019
	public class IFinishKurotatoConditionT
	{
		// Token: 0x1700742B RID: 29739
		// (get) Token: 0x06017BEF RID: 97263 RVA: 0x003633D9 File Offset: 0x003615D9
		// (set) Token: 0x06017BF0 RID: 97264 RVA: 0x003633E1 File Offset: 0x003615E1
		public EChildQuest Type { get; set; }

		// Token: 0x1700742C RID: 29740
		// (get) Token: 0x06017BF1 RID: 97265 RVA: 0x003633EA File Offset: 0x003615EA
		// (set) Token: 0x06017BF2 RID: 97266 RVA: 0x003633F2 File Offset: 0x003615F2
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x1700742D RID: 29741
		// (get) Token: 0x06017BF3 RID: 97267 RVA: 0x003633FB File Offset: 0x003615FB
		// (set) Token: 0x06017BF4 RID: 97268 RVA: 0x00363403 File Offset: 0x00361603
		public TKurotatoConditionStepUnion Step { get; set; }

		// Token: 0x1700742E RID: 29742
		// (get) Token: 0x06017BF5 RID: 97269 RVA: 0x0036340C File Offset: 0x0036160C
		// (set) Token: 0x06017BF6 RID: 97270 RVA: 0x00363414 File Offset: 0x00361614
		public TVarRefUnion Batch { get; set; }

		// Token: 0x06017BF7 RID: 97271 RVA: 0x0036341D File Offset: 0x0036161D
		public IFinishKurotatoConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.Step = null;
			this.Batch = null;
		}
	}
}
