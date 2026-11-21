using System;

namespace CSharpScript.Game.Module.Kurotato
{
	// Token: 0x020046CF RID: 18127
	public class KurotatoMediumItemGridData : IKurotatoMediumItemGridData
	{
		// Token: 0x17005BD7 RID: 23511
		// (get) Token: 0x0602D914 RID: 186644 RVA: 0x00CBECC2 File Offset: 0x00CBCEC2
		// (set) Token: 0x0602D915 RID: 186645 RVA: 0x00CBECCA File Offset: 0x00CBCECA
		public EKurotatoCardType Type { get; set; }

		// Token: 0x17005BD8 RID: 23512
		// (get) Token: 0x0602D916 RID: 186646 RVA: 0x00CBECD3 File Offset: 0x00CBCED3
		// (set) Token: 0x0602D917 RID: 186647 RVA: 0x00CBECDB File Offset: 0x00CBCEDB
		public int Id { get; set; }

		// Token: 0x17005BD9 RID: 23513
		// (get) Token: 0x0602D918 RID: 186648 RVA: 0x00CBECE4 File Offset: 0x00CBCEE4
		// (set) Token: 0x0602D919 RID: 186649 RVA: 0x00CBECEC File Offset: 0x00CBCEEC
		public int IncId { get; set; }

		// Token: 0x17005BDA RID: 23514
		// (get) Token: 0x0602D91A RID: 186650 RVA: 0x00CBECF5 File Offset: 0x00CBCEF5
		// (set) Token: 0x0602D91B RID: 186651 RVA: 0x00CBECFD File Offset: 0x00CBCEFD
		public int Count { get; set; }

		// Token: 0x17005BDB RID: 23515
		// (get) Token: 0x0602D91C RID: 186652 RVA: 0x00CBED06 File Offset: 0x00CBCF06
		// (set) Token: 0x0602D91D RID: 186653 RVA: 0x00CBED0E File Offset: 0x00CBCF0E
		public int? PreWaveDealtDamage { get; set; }
	}
}
