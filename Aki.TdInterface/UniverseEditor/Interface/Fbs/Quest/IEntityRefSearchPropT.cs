using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004248 RID: 16968
	public class IEntityRefSearchPropT
	{
		// Token: 0x170073B2 RID: 29618
		// (get) Token: 0x060179DD RID: 96733 RVA: 0x0035E62F File Offset: 0x0035C82F
		// (set) Token: 0x060179DE RID: 96734 RVA: 0x0035E637 File Offset: 0x0035C837
		public string SearchText { get; set; }

		// Token: 0x170073B3 RID: 29619
		// (get) Token: 0x060179DF RID: 96735 RVA: 0x0035E640 File Offset: 0x0035C840
		// (set) Token: 0x060179E0 RID: 96736 RVA: 0x0035E648 File Offset: 0x0035C848
		public int ResultCount { get; set; }

		// Token: 0x170073B4 RID: 29620
		// (get) Token: 0x060179E1 RID: 96737 RVA: 0x0035E651 File Offset: 0x0035C851
		// (set) Token: 0x060179E2 RID: 96738 RVA: 0x0035E659 File Offset: 0x0035C859
		public int ResultIndex { get; set; }

		// Token: 0x170073B5 RID: 29621
		// (get) Token: 0x060179E3 RID: 96739 RVA: 0x0035E662 File Offset: 0x0035C862
		// (set) Token: 0x060179E4 RID: 96740 RVA: 0x0035E66A File Offset: 0x0035C86A
		public byte NullMask { get; set; }

		// Token: 0x060179E5 RID: 96741 RVA: 0x0035E673 File Offset: 0x0035C873
		public IEntityRefSearchPropT()
		{
			this.SearchText = null;
			this.ResultCount = 0;
			this.ResultIndex = 0;
			this.NullMask = 0;
		}
	}
}
