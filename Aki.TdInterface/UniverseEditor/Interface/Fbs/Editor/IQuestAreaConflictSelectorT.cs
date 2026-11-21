using System;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004D01 RID: 19713
	public class IQuestAreaConflictSelectorT
	{
		// Token: 0x17008D16 RID: 36118
		// (get) Token: 0x0601E817 RID: 124951 RVA: 0x004458E0 File Offset: 0x00443AE0
		// (set) Token: 0x0601E818 RID: 124952 RVA: 0x004458E8 File Offset: 0x00443AE8
		public EAreaConflictSelector Type { get; set; }

		// Token: 0x17008D17 RID: 36119
		// (get) Token: 0x0601E819 RID: 124953 RVA: 0x004458F1 File Offset: 0x00443AF1
		// (set) Token: 0x0601E81A RID: 124954 RVA: 0x004458F9 File Offset: 0x00443AF9
		public int Id { get; set; }

		// Token: 0x0601E81B RID: 124955 RVA: 0x00445902 File Offset: 0x00443B02
		public IQuestAreaConflictSelectorT()
		{
			this.Type = EAreaConflictSelector.Quest;
			this.Id = 0;
		}
	}
}
