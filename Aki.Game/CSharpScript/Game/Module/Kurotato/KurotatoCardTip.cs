using System;

namespace CSharpScript.Game.Module.Kurotato
{
	// Token: 0x020056FC RID: 22268
	public class KurotatoCardTip : IKurotatoCardTip
	{
		// Token: 0x1700881F RID: 34847
		// (get) Token: 0x06038A26 RID: 231974 RVA: 0x00D70783 File Offset: 0x00D6E983
		// (set) Token: 0x06038A27 RID: 231975 RVA: 0x00D7078B File Offset: 0x00D6E98B
		public EKurotatoCardType CardType { get; set; }

		// Token: 0x17008820 RID: 34848
		// (get) Token: 0x06038A28 RID: 231976 RVA: 0x00D70794 File Offset: 0x00D6E994
		// (set) Token: 0x06038A29 RID: 231977 RVA: 0x00D7079C File Offset: 0x00D6E99C
		public int SelectId { get; set; }

		// Token: 0x17008821 RID: 34849
		// (get) Token: 0x06038A2A RID: 231978 RVA: 0x00D707A5 File Offset: 0x00D6E9A5
		// (set) Token: 0x06038A2B RID: 231979 RVA: 0x00D707AD File Offset: 0x00D6E9AD
		public bool? IsConfigId { get; set; }
	}
}
