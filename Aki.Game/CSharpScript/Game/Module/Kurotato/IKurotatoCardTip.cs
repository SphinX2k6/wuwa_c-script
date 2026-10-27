using System;

namespace CSharpScript.Game.Module.Kurotato
{
	// Token: 0x020056FB RID: 22267
	public interface IKurotatoCardTip
	{
		// Token: 0x1700881C RID: 34844
		// (get) Token: 0x06038A20 RID: 231968
		// (set) Token: 0x06038A21 RID: 231969
		EKurotatoCardType CardType { get; set; }

		// Token: 0x1700881D RID: 34845
		// (get) Token: 0x06038A22 RID: 231970
		// (set) Token: 0x06038A23 RID: 231971
		int SelectId { get; set; }

		// Token: 0x1700881E RID: 34846
		// (get) Token: 0x06038A24 RID: 231972
		// (set) Token: 0x06038A25 RID: 231973
		bool? IsConfigId { get; set; }
	}
}
