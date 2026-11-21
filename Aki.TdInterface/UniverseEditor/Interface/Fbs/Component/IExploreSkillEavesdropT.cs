using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005746 RID: 22342
	public class IExploreSkillEavesdropT
	{
		// Token: 0x1700A15C RID: 41308
		// (get) Token: 0x06023F56 RID: 147286 RVA: 0x004F1623 File Offset: 0x004EF823
		// (set) Token: 0x06023F57 RID: 147287 RVA: 0x004F162B File Offset: 0x004EF82B
		public EExploreSkillInteractType Type { get; set; }

		// Token: 0x1700A15D RID: 41309
		// (get) Token: 0x06023F58 RID: 147288 RVA: 0x004F1634 File Offset: 0x004EF834
		// (set) Token: 0x06023F59 RID: 147289 RVA: 0x004F163C File Offset: 0x004EF83C
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x1700A15E RID: 41310
		// (get) Token: 0x06023F5A RID: 147290 RVA: 0x004F1645 File Offset: 0x004EF845
		// (set) Token: 0x06023F5B RID: 147291 RVA: 0x004F164D File Offset: 0x004EF84D
		public IVectorInfoT InteractOffset { get; set; }

		// Token: 0x06023F5C RID: 147292 RVA: 0x004F1656 File Offset: 0x004EF856
		public IExploreSkillEavesdropT()
		{
			this.Type = EExploreSkillInteractType.PullGiant;
			this.Actions = null;
			this.InteractOffset = null;
		}
	}
}
