using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F71 RID: 20337
	public class ICategoryMatchingSucceedBaseT
	{
		// Token: 0x170092F4 RID: 37620
		// (get) Token: 0x0602046F RID: 132207 RVA: 0x0047DDC3 File Offset: 0x0047BFC3
		// (set) Token: 0x06020470 RID: 132208 RVA: 0x0047DDCB File Offset: 0x0047BFCB
		public bool IsSilent { get; set; }

		// Token: 0x170092F5 RID: 37621
		// (get) Token: 0x06020471 RID: 132209 RVA: 0x0047DDD4 File Offset: 0x0047BFD4
		// (set) Token: 0x06020472 RID: 132210 RVA: 0x0047DDDC File Offset: 0x0047BFDC
		public bool IsDestroy { get; set; }

		// Token: 0x170092F6 RID: 37622
		// (get) Token: 0x06020473 RID: 132211 RVA: 0x0047DDE5 File Offset: 0x0047BFE5
		// (set) Token: 0x06020474 RID: 132212 RVA: 0x0047DDED File Offset: 0x0047BFED
		public bool SyncAdsorbatePerformance { get; set; }

		// Token: 0x170092F7 RID: 37623
		// (get) Token: 0x06020475 RID: 132213 RVA: 0x0047DDF6 File Offset: 0x0047BFF6
		// (set) Token: 0x06020476 RID: 132214 RVA: 0x0047DDFE File Offset: 0x0047BFFE
		public string ChangeSelfState { get; set; }

		// Token: 0x170092F8 RID: 37624
		// (get) Token: 0x06020477 RID: 132215 RVA: 0x0047DE07 File Offset: 0x0047C007
		// (set) Token: 0x06020478 RID: 132216 RVA: 0x0047DE0F File Offset: 0x0047C00F
		public IEntityStateT ChangeItemState { get; set; }

		// Token: 0x170092F9 RID: 37625
		// (get) Token: 0x06020479 RID: 132217 RVA: 0x0047DE18 File Offset: 0x0047C018
		// (set) Token: 0x0602047A RID: 132218 RVA: 0x0047DE20 File Offset: 0x0047C020
		public int DelayDischarge { get; set; }

		// Token: 0x170092FA RID: 37626
		// (get) Token: 0x0602047B RID: 132219 RVA: 0x0047DE29 File Offset: 0x0047C029
		// (set) Token: 0x0602047C RID: 132220 RVA: 0x0047DE31 File Offset: 0x0047C031
		public IEntityStateT ChangeItemStateAfterDischarged { get; set; }

		// Token: 0x170092FB RID: 37627
		// (get) Token: 0x0602047D RID: 132221 RVA: 0x0047DE3A File Offset: 0x0047C03A
		// (set) Token: 0x0602047E RID: 132222 RVA: 0x0047DE42 File Offset: 0x0047C042
		public string ChangeSelfStateAfterDischarged { get; set; }

		// Token: 0x170092FC RID: 37628
		// (get) Token: 0x0602047F RID: 132223 RVA: 0x0047DE4B File Offset: 0x0047C04B
		// (set) Token: 0x06020480 RID: 132224 RVA: 0x0047DE53 File Offset: 0x0047C053
		public byte NullMask { get; set; }

		// Token: 0x06020481 RID: 132225 RVA: 0x0047DE5C File Offset: 0x0047C05C
		public ICategoryMatchingSucceedBaseT()
		{
			this.IsSilent = false;
			this.IsDestroy = false;
			this.SyncAdsorbatePerformance = false;
			this.ChangeSelfState = null;
			this.ChangeItemState = null;
			this.DelayDischarge = 0;
			this.ChangeItemStateAfterDischarged = null;
			this.ChangeSelfStateAfterDischarged = null;
			this.NullMask = 0;
		}
	}
}
