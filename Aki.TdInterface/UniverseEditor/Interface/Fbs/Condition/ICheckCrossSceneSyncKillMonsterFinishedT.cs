using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020049B0 RID: 18864
	public class ICheckCrossSceneSyncKillMonsterFinishedT
	{
		// Token: 0x17008866 RID: 34918
		// (get) Token: 0x0601D726 RID: 120614 RVA: 0x004261FC File Offset: 0x004243FC
		// (set) Token: 0x0601D727 RID: 120615 RVA: 0x00426204 File Offset: 0x00424404
		public ECondition Type { get; set; }

		// Token: 0x17008867 RID: 34919
		// (get) Token: 0x0601D728 RID: 120616 RVA: 0x0042620D File Offset: 0x0042440D
		// (set) Token: 0x0601D729 RID: 120617 RVA: 0x00426215 File Offset: 0x00424415
		public int SyncId { get; set; }

		// Token: 0x17008868 RID: 34920
		// (get) Token: 0x0601D72A RID: 120618 RVA: 0x0042621E File Offset: 0x0042441E
		// (set) Token: 0x0601D72B RID: 120619 RVA: 0x00426226 File Offset: 0x00424426
		public int EntityBundleId { get; set; }

		// Token: 0x17008869 RID: 34921
		// (get) Token: 0x0601D72C RID: 120620 RVA: 0x0042622F File Offset: 0x0042442F
		// (set) Token: 0x0601D72D RID: 120621 RVA: 0x00426237 File Offset: 0x00424437
		public ECompare Compare { get; set; }

		// Token: 0x0601D72E RID: 120622 RVA: 0x00426240 File Offset: 0x00424440
		public ICheckCrossSceneSyncKillMonsterFinishedT()
		{
			this.Type = ECondition.CompareVar;
			this.SyncId = 0;
			this.EntityBundleId = 0;
			this.Compare = ECompare.Eq;
		}
	}
}
