using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F6E RID: 20334
	public class ICategoryMatchingSucceedT
	{
		// Token: 0x170092DF RID: 37599
		// (get) Token: 0x06020435 RID: 132149 RVA: 0x0047D5DF File Offset: 0x0047B7DF
		// (set) Token: 0x06020436 RID: 132150 RVA: 0x0047D5E7 File Offset: 0x0047B7E7
		public bool IsSilent { get; set; }

		// Token: 0x170092E0 RID: 37600
		// (get) Token: 0x06020437 RID: 132151 RVA: 0x0047D5F0 File Offset: 0x0047B7F0
		// (set) Token: 0x06020438 RID: 132152 RVA: 0x0047D5F8 File Offset: 0x0047B7F8
		public bool IsDestroy { get; set; }

		// Token: 0x170092E1 RID: 37601
		// (get) Token: 0x06020439 RID: 132153 RVA: 0x0047D601 File Offset: 0x0047B801
		// (set) Token: 0x0602043A RID: 132154 RVA: 0x0047D609 File Offset: 0x0047B809
		public bool SyncAdsorbatePerformance { get; set; }

		// Token: 0x170092E2 RID: 37602
		// (get) Token: 0x0602043B RID: 132155 RVA: 0x0047D612 File Offset: 0x0047B812
		// (set) Token: 0x0602043C RID: 132156 RVA: 0x0047D61A File Offset: 0x0047B81A
		public string ChangeSelfState { get; set; }

		// Token: 0x170092E3 RID: 37603
		// (get) Token: 0x0602043D RID: 132157 RVA: 0x0047D623 File Offset: 0x0047B823
		// (set) Token: 0x0602043E RID: 132158 RVA: 0x0047D62B File Offset: 0x0047B82B
		public IEntityStateT ChangeItemState { get; set; }

		// Token: 0x170092E4 RID: 37604
		// (get) Token: 0x0602043F RID: 132159 RVA: 0x0047D634 File Offset: 0x0047B834
		// (set) Token: 0x06020440 RID: 132160 RVA: 0x0047D63C File Offset: 0x0047B83C
		public int DelayDischarge { get; set; }

		// Token: 0x170092E5 RID: 37605
		// (get) Token: 0x06020441 RID: 132161 RVA: 0x0047D645 File Offset: 0x0047B845
		// (set) Token: 0x06020442 RID: 132162 RVA: 0x0047D64D File Offset: 0x0047B84D
		public IEntityStateT ChangeItemStateAfterDischarged { get; set; }

		// Token: 0x170092E6 RID: 37606
		// (get) Token: 0x06020443 RID: 132163 RVA: 0x0047D656 File Offset: 0x0047B856
		// (set) Token: 0x06020444 RID: 132164 RVA: 0x0047D65E File Offset: 0x0047B85E
		public string ChangeSelfStateAfterDischarged { get; set; }

		// Token: 0x170092E7 RID: 37607
		// (get) Token: 0x06020445 RID: 132165 RVA: 0x0047D667 File Offset: 0x0047B867
		// (set) Token: 0x06020446 RID: 132166 RVA: 0x0047D66F File Offset: 0x0047B86F
		public IItemChangeAdsorbateStateT ChangeAdsorbateState { get; set; }

		// Token: 0x170092E8 RID: 37608
		// (get) Token: 0x06020447 RID: 132167 RVA: 0x0047D678 File Offset: 0x0047B878
		// (set) Token: 0x06020448 RID: 132168 RVA: 0x0047D680 File Offset: 0x0047B880
		public string DischargeSequence { get; set; }

		// Token: 0x170092E9 RID: 37609
		// (get) Token: 0x06020449 RID: 132169 RVA: 0x0047D689 File Offset: 0x0047B889
		// (set) Token: 0x0602044A RID: 132170 RVA: 0x0047D691 File Offset: 0x0047B891
		public byte NullMask { get; set; }

		// Token: 0x0602044B RID: 132171 RVA: 0x0047D69C File Offset: 0x0047B89C
		public ICategoryMatchingSucceedT()
		{
			this.IsSilent = false;
			this.IsDestroy = false;
			this.SyncAdsorbatePerformance = false;
			this.ChangeSelfState = null;
			this.ChangeItemState = null;
			this.DelayDischarge = 0;
			this.ChangeItemStateAfterDischarged = null;
			this.ChangeSelfStateAfterDischarged = null;
			this.ChangeAdsorbateState = null;
			this.DischargeSequence = null;
			this.NullMask = 0;
		}
	}
}
