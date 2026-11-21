using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005044 RID: 20548
	public class ICheckTetrisEndlessScoreT
	{
		// Token: 0x1700930C RID: 37644
		// (get) Token: 0x060201CB RID: 131531 RVA: 0x0047454C File Offset: 0x0047274C
		// (set) Token: 0x060201CC RID: 131532 RVA: 0x00474554 File Offset: 0x00472754
		public ECondition Type { get; set; }

		// Token: 0x1700930D RID: 37645
		// (get) Token: 0x060201CD RID: 131533 RVA: 0x0047455D File Offset: 0x0047275D
		// (set) Token: 0x060201CE RID: 131534 RVA: 0x00474565 File Offset: 0x00472765
		public int DungeonId { get; set; }

		// Token: 0x1700930E RID: 37646
		// (get) Token: 0x060201CF RID: 131535 RVA: 0x0047456E File Offset: 0x0047276E
		// (set) Token: 0x060201D0 RID: 131536 RVA: 0x00474576 File Offset: 0x00472776
		public ECompare Compare { get; set; }

		// Token: 0x1700930F RID: 37647
		// (get) Token: 0x060201D1 RID: 131537 RVA: 0x0047457F File Offset: 0x0047277F
		// (set) Token: 0x060201D2 RID: 131538 RVA: 0x00474587 File Offset: 0x00472787
		public int TargetScore { get; set; }

		// Token: 0x060201D3 RID: 131539 RVA: 0x00474590 File Offset: 0x00472790
		public ICheckTetrisEndlessScoreT()
		{
			this.Type = ECondition.CompareVar;
			this.DungeonId = 0;
			this.Compare = ECompare.Eq;
			this.TargetScore = 0;
		}
	}
}
