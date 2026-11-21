using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004B0E RID: 19214
	public class ISkipToQuestNodeT
	{
		// Token: 0x170086B8 RID: 34488
		// (get) Token: 0x0601CF7A RID: 118650 RVA: 0x00412F7F File Offset: 0x0041117F
		// (set) Token: 0x0601CF7B RID: 118651 RVA: 0x00412F87 File Offset: 0x00411187
		public EGmCommand Type { get; set; }

		// Token: 0x170086B9 RID: 34489
		// (get) Token: 0x0601CF7C RID: 118652 RVA: 0x00412F90 File Offset: 0x00411190
		// (set) Token: 0x0601CF7D RID: 118653 RVA: 0x00412F98 File Offset: 0x00411198
		public IChildQuestConditionT Quest { get; set; }

		// Token: 0x170086BA RID: 34490
		// (get) Token: 0x0601CF7E RID: 118654 RVA: 0x00412FA1 File Offset: 0x004111A1
		// (set) Token: 0x0601CF7F RID: 118655 RVA: 0x00412FA9 File Offset: 0x004111A9
		public bool IsTeleport { get; set; }

		// Token: 0x170086BB RID: 34491
		// (get) Token: 0x0601CF80 RID: 118656 RVA: 0x00412FB2 File Offset: 0x004111B2
		// (set) Token: 0x0601CF81 RID: 118657 RVA: 0x00412FBA File Offset: 0x004111BA
		public bool IsFastMode { get; set; }

		// Token: 0x0601CF82 RID: 118658 RVA: 0x00412FC3 File Offset: 0x004111C3
		public ISkipToQuestNodeT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
			this.Quest = null;
			this.IsTeleport = false;
			this.IsFastMode = false;
		}
	}
}
