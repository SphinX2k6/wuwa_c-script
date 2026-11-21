using System;

namespace CSharpScript.Game.Module.Kurotato
{
	// Token: 0x020046D3 RID: 18131
	public class KurotatoCardTip : IKurotatoCardTip
	{
		// Token: 0x17005BE7 RID: 23527
		// (get) Token: 0x0602D936 RID: 186678 RVA: 0x00CBED6B File Offset: 0x00CBCF6B
		// (set) Token: 0x0602D937 RID: 186679 RVA: 0x00CBED73 File Offset: 0x00CBCF73
		public EKurotatoCardType CardType { get; set; }

		// Token: 0x17005BE8 RID: 23528
		// (get) Token: 0x0602D938 RID: 186680 RVA: 0x00CBED7C File Offset: 0x00CBCF7C
		// (set) Token: 0x0602D939 RID: 186681 RVA: 0x00CBED84 File Offset: 0x00CBCF84
		public int SelectId { get; set; }

		// Token: 0x17005BE9 RID: 23529
		// (get) Token: 0x0602D93A RID: 186682 RVA: 0x00CBED8D File Offset: 0x00CBCF8D
		// (set) Token: 0x0602D93B RID: 186683 RVA: 0x00CBED95 File Offset: 0x00CBCF95
		public bool? IsConfigId { get; set; }
	}
}
