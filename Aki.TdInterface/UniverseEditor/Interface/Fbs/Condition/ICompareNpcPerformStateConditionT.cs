using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020050A4 RID: 20644
	public class ICompareNpcPerformStateConditionT
	{
		// Token: 0x170093DA RID: 37850
		// (get) Token: 0x060204FA RID: 132346 RVA: 0x00479A9F File Offset: 0x00477C9F
		// (set) Token: 0x060204FB RID: 132347 RVA: 0x00479AA7 File Offset: 0x00477CA7
		public ECondition Type { get; set; }

		// Token: 0x170093DB RID: 37851
		// (get) Token: 0x060204FC RID: 132348 RVA: 0x00479AB0 File Offset: 0x00477CB0
		// (set) Token: 0x060204FD RID: 132349 RVA: 0x00479AB8 File Offset: 0x00477CB8
		public int EntityId { get; set; }

		// Token: 0x170093DC RID: 37852
		// (get) Token: 0x060204FE RID: 132350 RVA: 0x00479AC1 File Offset: 0x00477CC1
		// (set) Token: 0x060204FF RID: 132351 RVA: 0x00479AC9 File Offset: 0x00477CC9
		public ECompare Compare { get; set; }

		// Token: 0x170093DD RID: 37853
		// (get) Token: 0x06020500 RID: 132352 RVA: 0x00479AD2 File Offset: 0x00477CD2
		// (set) Token: 0x06020501 RID: 132353 RVA: 0x00479ADA File Offset: 0x00477CDA
		public string State { get; set; }

		// Token: 0x06020502 RID: 132354 RVA: 0x00479AE3 File Offset: 0x00477CE3
		public ICompareNpcPerformStateConditionT()
		{
			this.Type = ECondition.CompareVar;
			this.EntityId = 0;
			this.Compare = ECompare.Eq;
			this.State = null;
		}
	}
}
