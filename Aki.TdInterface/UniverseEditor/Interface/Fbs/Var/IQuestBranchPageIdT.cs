using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003EBA RID: 16058
	public class IQuestBranchPageIdT
	{
		// Token: 0x17006CBC RID: 27836
		// (get) Token: 0x06015BB2 RID: 89010 RVA: 0x00320C70 File Offset: 0x0031EE70
		// (set) Token: 0x06015BB3 RID: 89011 RVA: 0x00320C78 File Offset: 0x0031EE78
		public ESystemVarName Type { get; set; }

		// Token: 0x17006CBD RID: 27837
		// (get) Token: 0x06015BB4 RID: 89012 RVA: 0x00320C81 File Offset: 0x0031EE81
		// (set) Token: 0x06015BB5 RID: 89013 RVA: 0x00320C89 File Offset: 0x0031EE89
		public int QuestBranchPageId { get; set; }

		// Token: 0x06015BB6 RID: 89014 RVA: 0x00320C92 File Offset: 0x0031EE92
		public IQuestBranchPageIdT()
		{
			this.Type = ESystemVarName.CommonHotFixVar;
			this.QuestBranchPageId = 0;
		}
	}
}
