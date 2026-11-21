using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020050CE RID: 20686
	public class IConditionDebugDataT
	{
		// Token: 0x17009440 RID: 37952
		// (get) Token: 0x060207CB RID: 133067 RVA: 0x0047F962 File Offset: 0x0047DB62
		// (set) Token: 0x060207CC RID: 133068 RVA: 0x0047F96A File Offset: 0x0047DB6A
		public EConditionLogicType Type { get; set; }

		// Token: 0x060207CD RID: 133069 RVA: 0x0047F973 File Offset: 0x0047DB73
		public IConditionDebugDataT()
		{
			this.Type = EConditionLogicType.BaseAccessQuest;
		}
	}
}
