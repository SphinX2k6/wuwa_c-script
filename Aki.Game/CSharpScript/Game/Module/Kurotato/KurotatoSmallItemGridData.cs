using System;

namespace CSharpScript.Game.Module.Kurotato
{
	// Token: 0x020046CD RID: 18125
	public class KurotatoSmallItemGridData : IKurotatoSmallItemGridData
	{
		// Token: 0x17005BCA RID: 23498
		// (get) Token: 0x0602D8F9 RID: 186617 RVA: 0x00CBEC32 File Offset: 0x00CBCE32
		// (set) Token: 0x0602D8FA RID: 186618 RVA: 0x00CBEC3A File Offset: 0x00CBCE3A
		public EKurotatoCardType Type { get; set; }

		// Token: 0x17005BCB RID: 23499
		// (get) Token: 0x0602D8FB RID: 186619 RVA: 0x00CBEC43 File Offset: 0x00CBCE43
		// (set) Token: 0x0602D8FC RID: 186620 RVA: 0x00CBEC4B File Offset: 0x00CBCE4B
		public int Id { get; set; }

		// Token: 0x17005BCC RID: 23500
		// (get) Token: 0x0602D8FD RID: 186621 RVA: 0x00CBEC54 File Offset: 0x00CBCE54
		// (set) Token: 0x0602D8FE RID: 186622 RVA: 0x00CBEC5C File Offset: 0x00CBCE5C
		public int IncId { get; set; }

		// Token: 0x17005BCD RID: 23501
		// (get) Token: 0x0602D8FF RID: 186623 RVA: 0x00CBEC65 File Offset: 0x00CBCE65
		// (set) Token: 0x0602D900 RID: 186624 RVA: 0x00CBEC6D File Offset: 0x00CBCE6D
		public int Count { get; set; }

		// Token: 0x17005BCE RID: 23502
		// (get) Token: 0x0602D901 RID: 186625 RVA: 0x00CBEC76 File Offset: 0x00CBCE76
		// (set) Token: 0x0602D902 RID: 186626 RVA: 0x00CBEC7E File Offset: 0x00CBCE7E
		public bool? PlayComposeFx { get; set; }

		// Token: 0x17005BCF RID: 23503
		// (get) Token: 0x0602D903 RID: 186627 RVA: 0x00CBEC87 File Offset: 0x00CBCE87
		// (set) Token: 0x0602D904 RID: 186628 RVA: 0x00CBEC8F File Offset: 0x00CBCE8F
		public bool? ShowArrow { get; set; }

		// Token: 0x17005BD0 RID: 23504
		// (get) Token: 0x0602D905 RID: 186629 RVA: 0x00CBEC98 File Offset: 0x00CBCE98
		// (set) Token: 0x0602D906 RID: 186630 RVA: 0x00CBECA0 File Offset: 0x00CBCEA0
		public bool? IsReceived { get; set; }

		// Token: 0x17005BD1 RID: 23505
		// (get) Token: 0x0602D907 RID: 186631 RVA: 0x00CBECA9 File Offset: 0x00CBCEA9
		// (set) Token: 0x0602D908 RID: 186632 RVA: 0x00CBECB1 File Offset: 0x00CBCEB1
		public bool? IsShowCount { get; set; }
	}
}
