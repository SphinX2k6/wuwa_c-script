using System;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041B5 RID: 16821
	public class ICompareActorVarInChildQuestT
	{
		// Token: 0x1700723C RID: 29244
		// (get) Token: 0x060173F2 RID: 95218 RVA: 0x003518C4 File Offset: 0x0034FAC4
		// (set) Token: 0x060173F3 RID: 95219 RVA: 0x003518CC File Offset: 0x0034FACC
		public IActorRefT ActorRef { get; set; }

		// Token: 0x1700723D RID: 29245
		// (get) Token: 0x060173F4 RID: 95220 RVA: 0x003518D5 File Offset: 0x0034FAD5
		// (set) Token: 0x060173F5 RID: 95221 RVA: 0x003518DD File Offset: 0x0034FADD
		public string Var1 { get; set; }

		// Token: 0x1700723E RID: 29246
		// (get) Token: 0x060173F6 RID: 95222 RVA: 0x003518E6 File Offset: 0x0034FAE6
		// (set) Token: 0x060173F7 RID: 95223 RVA: 0x003518EE File Offset: 0x0034FAEE
		public ECompare Compare { get; set; }

		// Token: 0x1700723F RID: 29247
		// (get) Token: 0x060173F8 RID: 95224 RVA: 0x003518F7 File Offset: 0x0034FAF7
		// (set) Token: 0x060173F9 RID: 95225 RVA: 0x003518FF File Offset: 0x0034FAFF
		public TVarRefUnion Var2 { get; set; }

		// Token: 0x060173FA RID: 95226 RVA: 0x00351908 File Offset: 0x0034FB08
		public ICompareActorVarInChildQuestT()
		{
			this.ActorRef = null;
			this.Var1 = null;
			this.Compare = ECompare.Eq;
			this.Var2 = null;
		}
	}
}
