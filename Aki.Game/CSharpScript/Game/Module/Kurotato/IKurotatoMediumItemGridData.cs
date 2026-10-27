using System;

namespace CSharpScript.Game.Module.Kurotato
{
	// Token: 0x020056F7 RID: 22263
	public interface IKurotatoMediumItemGridData
	{
		// Token: 0x1700880A RID: 34826
		// (get) Token: 0x060389FA RID: 231930
		// (set) Token: 0x060389FB RID: 231931
		EKurotatoCardType Type { get; set; }

		// Token: 0x1700880B RID: 34827
		// (get) Token: 0x060389FC RID: 231932
		// (set) Token: 0x060389FD RID: 231933
		int Id { get; set; }

		// Token: 0x1700880C RID: 34828
		// (get) Token: 0x060389FE RID: 231934
		// (set) Token: 0x060389FF RID: 231935
		int IncId { get; set; }

		// Token: 0x1700880D RID: 34829
		// (get) Token: 0x06038A00 RID: 231936
		// (set) Token: 0x06038A01 RID: 231937
		int Count { get; set; }

		// Token: 0x1700880E RID: 34830
		// (get) Token: 0x06038A02 RID: 231938
		// (set) Token: 0x06038A03 RID: 231939
		int? PreWaveDealtDamage { get; set; }
	}
}
