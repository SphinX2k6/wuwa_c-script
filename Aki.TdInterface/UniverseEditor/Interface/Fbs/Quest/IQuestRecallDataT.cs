using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200444F RID: 17487
	public class IQuestRecallDataT
	{
		// Token: 0x1700793C RID: 31036
		// (get) Token: 0x06019149 RID: 102729 RVA: 0x00393D2D File Offset: 0x00391F2D
		// (set) Token: 0x0601914A RID: 102730 RVA: 0x00393D35 File Offset: 0x00391F35
		public ERecallDataType Type { get; set; }

		// Token: 0x1700793D RID: 31037
		// (get) Token: 0x0601914B RID: 102731 RVA: 0x00393D3E File Offset: 0x00391F3E
		// (set) Token: 0x0601914C RID: 102732 RVA: 0x00393D46 File Offset: 0x00391F46
		public int Id { get; set; }

		// Token: 0x1700793E RID: 31038
		// (get) Token: 0x0601914D RID: 102733 RVA: 0x00393D4F File Offset: 0x00391F4F
		// (set) Token: 0x0601914E RID: 102734 RVA: 0x00393D57 File Offset: 0x00391F57
		public IQuestRecallConfigT RecallConfig { get; set; }

		// Token: 0x0601914F RID: 102735 RVA: 0x00393D60 File Offset: 0x00391F60
		public IQuestRecallDataT()
		{
			this.Type = ERecallDataType.LevelPlay;
			this.Id = 0;
			this.RecallConfig = null;
		}
	}
}
