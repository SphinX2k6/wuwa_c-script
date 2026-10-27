using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004974 RID: 18804
	public class IBaseAccessQuestDebugDataT
	{
		// Token: 0x170087D3 RID: 34771
		// (get) Token: 0x0601D4FC RID: 120060 RVA: 0x00422627 File Offset: 0x00420827
		// (set) Token: 0x0601D4FD RID: 120061 RVA: 0x0042262F File Offset: 0x0042082F
		public EConditionLogicType Type { get; set; }

		// Token: 0x170087D4 RID: 34772
		// (get) Token: 0x0601D4FE RID: 120062 RVA: 0x00422638 File Offset: 0x00420838
		// (set) Token: 0x0601D4FF RID: 120063 RVA: 0x00422640 File Offset: 0x00420840
		public IAccessQuestConditionT BaseAccessQuestConditionGroup { get; set; }

		// Token: 0x0601D500 RID: 120064 RVA: 0x00422649 File Offset: 0x00420849
		public IBaseAccessQuestDebugDataT()
		{
			this.Type = EConditionLogicType.BaseAccessQuest;
			this.BaseAccessQuestConditionGroup = null;
		}
	}
}
