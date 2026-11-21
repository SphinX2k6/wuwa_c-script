using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200509B RID: 20635
	public class ICompareLiftConditionT
	{
		// Token: 0x170093C9 RID: 37833
		// (get) Token: 0x060204B2 RID: 132274 RVA: 0x0047940C File Offset: 0x0047760C
		// (set) Token: 0x060204B3 RID: 132275 RVA: 0x00479414 File Offset: 0x00477614
		public ECondition Type { get; set; }

		// Token: 0x170093CA RID: 37834
		// (get) Token: 0x060204B4 RID: 132276 RVA: 0x0047941D File Offset: 0x0047761D
		// (set) Token: 0x060204B5 RID: 132277 RVA: 0x00479425 File Offset: 0x00477625
		public bool IsSelf { get; set; }

		// Token: 0x170093CB RID: 37835
		// (get) Token: 0x060204B6 RID: 132278 RVA: 0x0047942E File Offset: 0x0047762E
		// (set) Token: 0x060204B7 RID: 132279 RVA: 0x00479436 File Offset: 0x00477636
		public int EntityId { get; set; }

		// Token: 0x170093CC RID: 37836
		// (get) Token: 0x060204B8 RID: 132280 RVA: 0x0047943F File Offset: 0x0047763F
		// (set) Token: 0x060204B9 RID: 132281 RVA: 0x00479447 File Offset: 0x00477647
		public ECompare Compare { get; set; }

		// Token: 0x170093CD RID: 37837
		// (get) Token: 0x060204BA RID: 132282 RVA: 0x00479450 File Offset: 0x00477650
		// (set) Token: 0x060204BB RID: 132283 RVA: 0x00479458 File Offset: 0x00477658
		public int Location { get; set; }

		// Token: 0x170093CE RID: 37838
		// (get) Token: 0x060204BC RID: 132284 RVA: 0x00479461 File Offset: 0x00477661
		// (set) Token: 0x060204BD RID: 132285 RVA: 0x00479469 File Offset: 0x00477669
		public byte NullMask { get; set; }

		// Token: 0x060204BE RID: 132286 RVA: 0x00479472 File Offset: 0x00477672
		public ICompareLiftConditionT()
		{
			this.Type = ECondition.CompareVar;
			this.IsSelf = false;
			this.EntityId = 0;
			this.Compare = ECompare.Eq;
			this.Location = 0;
			this.NullMask = 0;
		}
	}
}
