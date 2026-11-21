using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004FDB RID: 20443
	public class ICheckPlayerSkillReadyConditionT
	{
		// Token: 0x17009245 RID: 37445
		// (get) Token: 0x0601FE45 RID: 130629 RVA: 0x0046DD3B File Offset: 0x0046BF3B
		// (set) Token: 0x0601FE46 RID: 130630 RVA: 0x0046DD43 File Offset: 0x0046BF43
		public ECondition Type { get; set; }

		// Token: 0x17009246 RID: 37446
		// (get) Token: 0x0601FE47 RID: 130631 RVA: 0x0046DD4C File Offset: 0x0046BF4C
		// (set) Token: 0x0601FE48 RID: 130632 RVA: 0x0046DD54 File Offset: 0x0046BF54
		public TSkillReadyOptionUnion SkillOption { get; set; }

		// Token: 0x0601FE49 RID: 130633 RVA: 0x0046DD5D File Offset: 0x0046BF5D
		public ICheckPlayerSkillReadyConditionT()
		{
			this.Type = ECondition.CompareVar;
			this.SkillOption = null;
		}
	}
}
