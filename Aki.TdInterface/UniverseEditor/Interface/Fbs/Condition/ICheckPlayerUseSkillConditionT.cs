using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004FE1 RID: 20449
	public class ICheckPlayerUseSkillConditionT
	{
		// Token: 0x17009252 RID: 37458
		// (get) Token: 0x0601FE81 RID: 130689 RVA: 0x0046E565 File Offset: 0x0046C765
		// (set) Token: 0x0601FE82 RID: 130690 RVA: 0x0046E56D File Offset: 0x0046C76D
		public ECondition Type { get; set; }

		// Token: 0x17009253 RID: 37459
		// (get) Token: 0x0601FE83 RID: 130691 RVA: 0x0046E576 File Offset: 0x0046C776
		// (set) Token: 0x0601FE84 RID: 130692 RVA: 0x0046E57E File Offset: 0x0046C77E
		public ECommonMatchType CheckType { get; set; }

		// Token: 0x17009254 RID: 37460
		// (get) Token: 0x0601FE85 RID: 130693 RVA: 0x0046E587 File Offset: 0x0046C787
		// (set) Token: 0x0601FE86 RID: 130694 RVA: 0x0046E58F File Offset: 0x0046C78F
		public List<ISkillUseTypeRoleSkillT> CheckSkills { get; set; }

		// Token: 0x0601FE87 RID: 130695 RVA: 0x0046E598 File Offset: 0x0046C798
		public ICheckPlayerUseSkillConditionT()
		{
			this.Type = ECondition.CompareVar;
			this.CheckType = ECommonMatchType.MatchAll;
			this.CheckSkills = null;
		}
	}
}
