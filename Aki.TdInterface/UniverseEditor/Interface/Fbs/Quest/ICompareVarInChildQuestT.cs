using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041BE RID: 16830
	public class ICompareVarInChildQuestT
	{
		// Token: 0x17007252 RID: 29266
		// (get) Token: 0x0601745C RID: 95324 RVA: 0x00352979 File Offset: 0x00350B79
		// (set) Token: 0x0601745D RID: 95325 RVA: 0x00352981 File Offset: 0x00350B81
		public TVarRefUnion Var1 { get; set; }

		// Token: 0x17007253 RID: 29267
		// (get) Token: 0x0601745E RID: 95326 RVA: 0x0035298A File Offset: 0x00350B8A
		// (set) Token: 0x0601745F RID: 95327 RVA: 0x00352992 File Offset: 0x00350B92
		public ECompare Compare { get; set; }

		// Token: 0x17007254 RID: 29268
		// (get) Token: 0x06017460 RID: 95328 RVA: 0x0035299B File Offset: 0x00350B9B
		// (set) Token: 0x06017461 RID: 95329 RVA: 0x003529A3 File Offset: 0x00350BA3
		public TVarRefUnion Var2 { get; set; }

		// Token: 0x06017462 RID: 95330 RVA: 0x003529AC File Offset: 0x00350BAC
		public ICompareVarInChildQuestT()
		{
			this.Var1 = null;
			this.Compare = ECompare.Eq;
			this.Var2 = null;
		}
	}
}
