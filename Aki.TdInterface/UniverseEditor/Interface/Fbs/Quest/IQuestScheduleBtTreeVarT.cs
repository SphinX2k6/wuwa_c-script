using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004455 RID: 17493
	public class IQuestScheduleBtTreeVarT
	{
		// Token: 0x1700794C RID: 31052
		// (get) Token: 0x06019188 RID: 102792 RVA: 0x0039464D File Offset: 0x0039284D
		// (set) Token: 0x06019189 RID: 102793 RVA: 0x00394655 File Offset: 0x00392855
		public EQuestScheduleType Type { get; set; }

		// Token: 0x1700794D RID: 31053
		// (get) Token: 0x0601918A RID: 102794 RVA: 0x0039465E File Offset: 0x0039285E
		// (set) Token: 0x0601918B RID: 102795 RVA: 0x00394666 File Offset: 0x00392866
		public TVarRefUnion Var { get; set; }

		// Token: 0x1700794E RID: 31054
		// (get) Token: 0x0601918C RID: 102796 RVA: 0x0039466F File Offset: 0x0039286F
		// (set) Token: 0x0601918D RID: 102797 RVA: 0x00394677 File Offset: 0x00392877
		public IWordArtConfigT ShowAsWordArt { get; set; }

		// Token: 0x0601918E RID: 102798 RVA: 0x00394680 File Offset: 0x00392880
		public IQuestScheduleBtTreeVarT()
		{
			this.Type = EQuestScheduleType.None;
			this.Var = null;
			this.ShowAsWordArt = null;
		}
	}
}
