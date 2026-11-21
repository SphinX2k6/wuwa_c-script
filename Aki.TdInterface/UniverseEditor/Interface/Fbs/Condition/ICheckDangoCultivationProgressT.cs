using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E73 RID: 20083
	public class ICheckDangoCultivationProgressT
	{
		// Token: 0x17008F3D RID: 36669
		// (get) Token: 0x0601F1B7 RID: 127415 RVA: 0x0045729F File Offset: 0x0045549F
		// (set) Token: 0x0601F1B8 RID: 127416 RVA: 0x004572A7 File Offset: 0x004554A7
		public ECondition Type { get; set; }

		// Token: 0x17008F3E RID: 36670
		// (get) Token: 0x0601F1B9 RID: 127417 RVA: 0x004572B0 File Offset: 0x004554B0
		// (set) Token: 0x0601F1BA RID: 127418 RVA: 0x004572B8 File Offset: 0x004554B8
		public ICountDangoOverTargetLevelT CheckType { get; set; }

		// Token: 0x0601F1BB RID: 127419 RVA: 0x004572C1 File Offset: 0x004554C1
		public ICheckDangoCultivationProgressT()
		{
			this.Type = ECondition.CompareVar;
			this.CheckType = null;
		}
	}
}
