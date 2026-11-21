using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200500E RID: 20494
	public class ICheckSheriffUnlockEndingT
	{
		// Token: 0x170092A3 RID: 37539
		// (get) Token: 0x0601FFDD RID: 131037 RVA: 0x00470A46 File Offset: 0x0046EC46
		// (set) Token: 0x0601FFDE RID: 131038 RVA: 0x00470A4E File Offset: 0x0046EC4E
		public ECondition Type { get; set; }

		// Token: 0x170092A4 RID: 37540
		// (get) Token: 0x0601FFDF RID: 131039 RVA: 0x00470A57 File Offset: 0x0046EC57
		// (set) Token: 0x0601FFE0 RID: 131040 RVA: 0x00470A5F File Offset: 0x0046EC5F
		public int AnomalyId { get; set; }

		// Token: 0x170092A5 RID: 37541
		// (get) Token: 0x0601FFE1 RID: 131041 RVA: 0x00470A68 File Offset: 0x0046EC68
		// (set) Token: 0x0601FFE2 RID: 131042 RVA: 0x00470A70 File Offset: 0x0046EC70
		public int EndingId { get; set; }

		// Token: 0x0601FFE3 RID: 131043 RVA: 0x00470A79 File Offset: 0x0046EC79
		public ICheckSheriffUnlockEndingT()
		{
			this.Type = ECondition.CompareVar;
			this.AnomalyId = 0;
			this.EndingId = 0;
		}
	}
}
