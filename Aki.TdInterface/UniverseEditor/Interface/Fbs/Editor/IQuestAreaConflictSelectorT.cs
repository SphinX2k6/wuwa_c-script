using System;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x0200489C RID: 18588
	public class IQuestAreaConflictSelectorT
	{
		// Token: 0x170086CE RID: 34510
		// (get) Token: 0x0601D02A RID: 118826 RVA: 0x00419144 File Offset: 0x00417344
		// (set) Token: 0x0601D02B RID: 118827 RVA: 0x0041914C File Offset: 0x0041734C
		public EAreaConflictSelector Type { get; set; }

		// Token: 0x170086CF RID: 34511
		// (get) Token: 0x0601D02C RID: 118828 RVA: 0x00419155 File Offset: 0x00417355
		// (set) Token: 0x0601D02D RID: 118829 RVA: 0x0041915D File Offset: 0x0041735D
		public int Id { get; set; }

		// Token: 0x0601D02E RID: 118830 RVA: 0x00419166 File Offset: 0x00417366
		public IQuestAreaConflictSelectorT()
		{
			this.Type = EAreaConflictSelector.Quest;
			this.Id = 0;
		}
	}
}
