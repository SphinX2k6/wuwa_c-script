using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.FixProcessor;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041CD RID: 16845
	public class IConditionSelectorBtNodeSlotT
	{
		// Token: 0x170072C3 RID: 29379
		// (get) Token: 0x060175BF RID: 95679 RVA: 0x00356C56 File Offset: 0x00354E56
		// (set) Token: 0x060175C0 RID: 95680 RVA: 0x00356C5E File Offset: 0x00354E5E
		public IConditionGroupT Condition { get; set; }

		// Token: 0x170072C4 RID: 29380
		// (get) Token: 0x060175C1 RID: 95681 RVA: 0x00356C67 File Offset: 0x00354E67
		// (set) Token: 0x060175C2 RID: 95682 RVA: 0x00356C6F File Offset: 0x00354E6F
		public TBtNodeUnion Node { get; set; }

		// Token: 0x170072C5 RID: 29381
		// (get) Token: 0x060175C3 RID: 95683 RVA: 0x00356C78 File Offset: 0x00354E78
		// (set) Token: 0x060175C4 RID: 95684 RVA: 0x00356C80 File Offset: 0x00354E80
		public IPerformanceSettingT PerformanceSetting { get; set; }

		// Token: 0x060175C5 RID: 95685 RVA: 0x00356C89 File Offset: 0x00354E89
		public IConditionSelectorBtNodeSlotT()
		{
			this.Condition = null;
			this.Node = null;
			this.PerformanceSetting = null;
		}
	}
}
