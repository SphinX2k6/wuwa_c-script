using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E2B RID: 20011
	public class IBaseAccessQuestDebugDataT
	{
		// Token: 0x17008E8E RID: 36494
		// (get) Token: 0x0601EF21 RID: 126753 RVA: 0x00452ADB File Offset: 0x00450CDB
		// (set) Token: 0x0601EF22 RID: 126754 RVA: 0x00452AE3 File Offset: 0x00450CE3
		public EConditionLogicType Type { get; set; }

		// Token: 0x17008E8F RID: 36495
		// (get) Token: 0x0601EF23 RID: 126755 RVA: 0x00452AEC File Offset: 0x00450CEC
		// (set) Token: 0x0601EF24 RID: 126756 RVA: 0x00452AF4 File Offset: 0x00450CF4
		public IAccessQuestConditionT BaseAccessQuestConditionGroup { get; set; }

		// Token: 0x0601EF25 RID: 126757 RVA: 0x00452AFD File Offset: 0x00450CFD
		public IBaseAccessQuestDebugDataT()
		{
			this.Type = EConditionLogicType.BaseAccessQuest;
			this.BaseAccessQuestConditionGroup = null;
		}
	}
}
