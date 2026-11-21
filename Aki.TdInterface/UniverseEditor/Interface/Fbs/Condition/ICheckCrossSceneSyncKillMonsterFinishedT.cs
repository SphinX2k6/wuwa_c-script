using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E6A RID: 20074
	public class ICheckCrossSceneSyncKillMonsterFinishedT
	{
		// Token: 0x17008F28 RID: 36648
		// (get) Token: 0x0601F165 RID: 127333 RVA: 0x00456944 File Offset: 0x00454B44
		// (set) Token: 0x0601F166 RID: 127334 RVA: 0x0045694C File Offset: 0x00454B4C
		public ECondition Type { get; set; }

		// Token: 0x17008F29 RID: 36649
		// (get) Token: 0x0601F167 RID: 127335 RVA: 0x00456955 File Offset: 0x00454B55
		// (set) Token: 0x0601F168 RID: 127336 RVA: 0x0045695D File Offset: 0x00454B5D
		public int SyncId { get; set; }

		// Token: 0x17008F2A RID: 36650
		// (get) Token: 0x0601F169 RID: 127337 RVA: 0x00456966 File Offset: 0x00454B66
		// (set) Token: 0x0601F16A RID: 127338 RVA: 0x0045696E File Offset: 0x00454B6E
		public int EntityBundleId { get; set; }

		// Token: 0x17008F2B RID: 36651
		// (get) Token: 0x0601F16B RID: 127339 RVA: 0x00456977 File Offset: 0x00454B77
		// (set) Token: 0x0601F16C RID: 127340 RVA: 0x0045697F File Offset: 0x00454B7F
		public ECompare Compare { get; set; }

		// Token: 0x0601F16D RID: 127341 RVA: 0x00456988 File Offset: 0x00454B88
		public ICheckCrossSceneSyncKillMonsterFinishedT()
		{
			this.Type = ECondition.CompareVar;
			this.SyncId = 0;
			this.EntityBundleId = 0;
			this.Compare = ECompare.Eq;
		}
	}
}
