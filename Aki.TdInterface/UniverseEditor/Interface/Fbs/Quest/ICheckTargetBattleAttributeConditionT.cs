using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D74 RID: 15732
	public class ICheckTargetBattleAttributeConditionT
	{
		// Token: 0x17006BFA RID: 27642
		// (get) Token: 0x06015C7D RID: 89213 RVA: 0x00323FCB File Offset: 0x003221CB
		// (set) Token: 0x06015C7E RID: 89214 RVA: 0x00323FD3 File Offset: 0x003221D3
		public EChildQuest Type { get; set; }

		// Token: 0x17006BFB RID: 27643
		// (get) Token: 0x06015C7F RID: 89215 RVA: 0x00323FDC File Offset: 0x003221DC
		// (set) Token: 0x06015C80 RID: 89216 RVA: 0x00323FE4 File Offset: 0x003221E4
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x17006BFC RID: 27644
		// (get) Token: 0x06015C81 RID: 89217 RVA: 0x00323FED File Offset: 0x003221ED
		// (set) Token: 0x06015C82 RID: 89218 RVA: 0x00323FF5 File Offset: 0x003221F5
		public EConditionCount Count { get; set; }

		// Token: 0x17006BFD RID: 27645
		// (get) Token: 0x06015C83 RID: 89219 RVA: 0x00323FFE File Offset: 0x003221FE
		// (set) Token: 0x06015C84 RID: 89220 RVA: 0x00324006 File Offset: 0x00322206
		public List<TTargetBattleAttributeUnion> Option { get; set; }

		// Token: 0x06015C85 RID: 89221 RVA: 0x0032400F File Offset: 0x0032220F
		public ICheckTargetBattleAttributeConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.Count = EConditionCount.All;
			this.Option = null;
		}
	}
}
