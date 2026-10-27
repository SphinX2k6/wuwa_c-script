using System;

namespace CSharpScript.Game.Module.Kurotato
{
	// Token: 0x020056EE RID: 22254
	public class KurotatoAttrSelectCardData : IKurotatoAttrSelectCardData
	{
		// Token: 0x170087DE RID: 34782
		// (get) Token: 0x0603899D RID: 231837 RVA: 0x00D7051A File Offset: 0x00D6E71A
		// (set) Token: 0x0603899E RID: 231838 RVA: 0x00D70522 File Offset: 0x00D6E722
		public int ItemId { get; set; }

		// Token: 0x170087DF RID: 34783
		// (get) Token: 0x0603899F RID: 231839 RVA: 0x00D7052B File Offset: 0x00D6E72B
		// (set) Token: 0x060389A0 RID: 231840 RVA: 0x00D70533 File Offset: 0x00D6E733
		public int SelectionId { get; set; }

		// Token: 0x170087E0 RID: 34784
		// (get) Token: 0x060389A1 RID: 231841 RVA: 0x00D7053C File Offset: 0x00D6E73C
		// (set) Token: 0x060389A2 RID: 231842 RVA: 0x00D70544 File Offset: 0x00D6E744
		public bool IsRecommend { get; set; }

		// Token: 0x170087E1 RID: 34785
		// (get) Token: 0x060389A3 RID: 231843 RVA: 0x00D7054D File Offset: 0x00D6E74D
		// (set) Token: 0x060389A4 RID: 231844 RVA: 0x00D70555 File Offset: 0x00D6E755
		public EKurotatoAttrSelectType SelectType { get; set; }
	}
}
