using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003AB8 RID: 15032
	public class IQuestBranchPageIdT
	{
		// Token: 0x17006721 RID: 26401
		// (get) Token: 0x06014708 RID: 83720 RVA: 0x002FA9E0 File Offset: 0x002F8BE0
		// (set) Token: 0x06014709 RID: 83721 RVA: 0x002FA9E8 File Offset: 0x002F8BE8
		public ESystemVarName Type { get; set; }

		// Token: 0x17006722 RID: 26402
		// (get) Token: 0x0601470A RID: 83722 RVA: 0x002FA9F1 File Offset: 0x002F8BF1
		// (set) Token: 0x0601470B RID: 83723 RVA: 0x002FA9F9 File Offset: 0x002F8BF9
		public int QuestBranchPageId { get; set; }

		// Token: 0x0601470C RID: 83724 RVA: 0x002FAA02 File Offset: 0x002F8C02
		public IQuestBranchPageIdT()
		{
			this.Type = ESystemVarName.CommonHotFixVar;
			this.QuestBranchPageId = 0;
		}
	}
}
