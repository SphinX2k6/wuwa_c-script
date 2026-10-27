using System;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004884 RID: 18564
	public class ILevelPlayAreaConflictSelectorT
	{
		// Token: 0x170086A1 RID: 34465
		// (get) Token: 0x0601CF4E RID: 118606 RVA: 0x0041782A File Offset: 0x00415A2A
		// (set) Token: 0x0601CF4F RID: 118607 RVA: 0x00417832 File Offset: 0x00415A32
		public EAreaConflictSelector Type { get; set; }

		// Token: 0x170086A2 RID: 34466
		// (get) Token: 0x0601CF50 RID: 118608 RVA: 0x0041783B File Offset: 0x00415A3B
		// (set) Token: 0x0601CF51 RID: 118609 RVA: 0x00417843 File Offset: 0x00415A43
		public int Id { get; set; }

		// Token: 0x170086A3 RID: 34467
		// (get) Token: 0x0601CF52 RID: 118610 RVA: 0x0041784C File Offset: 0x00415A4C
		// (set) Token: 0x0601CF53 RID: 118611 RVA: 0x00417854 File Offset: 0x00415A54
		public bool CheckEnterArea { get; set; }

		// Token: 0x0601CF54 RID: 118612 RVA: 0x0041785D File Offset: 0x00415A5D
		public ILevelPlayAreaConflictSelectorT()
		{
			this.Type = EAreaConflictSelector.Quest;
			this.Id = 0;
			this.CheckEnterArea = false;
		}
	}
}
