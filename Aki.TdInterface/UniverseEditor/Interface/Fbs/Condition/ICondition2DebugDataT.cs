using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020050C8 RID: 20680
	public class ICondition2DebugDataT
	{
		// Token: 0x1700943A RID: 37946
		// (get) Token: 0x06020675 RID: 132725 RVA: 0x0047CC9B File Offset: 0x0047AE9B
		// (set) Token: 0x06020676 RID: 132726 RVA: 0x0047CCA3 File Offset: 0x0047AEA3
		public EConditionLogicType Type { get; set; }

		// Token: 0x1700943B RID: 37947
		// (get) Token: 0x06020677 RID: 132727 RVA: 0x0047CCAC File Offset: 0x0047AEAC
		// (set) Token: 0x06020678 RID: 132728 RVA: 0x0047CCB4 File Offset: 0x0047AEB4
		public IConditionGroupT Condition2Group { get; set; }

		// Token: 0x06020679 RID: 132729 RVA: 0x0047CCBD File Offset: 0x0047AEBD
		public ICondition2DebugDataT()
		{
			this.Type = EConditionLogicType.BaseAccessQuest;
			this.Condition2Group = null;
		}
	}
}
