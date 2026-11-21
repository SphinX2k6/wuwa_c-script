using System;

namespace CSharpScript.Game.Module.Kurotato
{
	// Token: 0x020046CE RID: 18126
	public interface IKurotatoMediumItemGridData
	{
		// Token: 0x17005BD2 RID: 23506
		// (get) Token: 0x0602D90A RID: 186634
		// (set) Token: 0x0602D90B RID: 186635
		EKurotatoCardType Type { get; set; }

		// Token: 0x17005BD3 RID: 23507
		// (get) Token: 0x0602D90C RID: 186636
		// (set) Token: 0x0602D90D RID: 186637
		int Id { get; set; }

		// Token: 0x17005BD4 RID: 23508
		// (get) Token: 0x0602D90E RID: 186638
		// (set) Token: 0x0602D90F RID: 186639
		int IncId { get; set; }

		// Token: 0x17005BD5 RID: 23509
		// (get) Token: 0x0602D910 RID: 186640
		// (set) Token: 0x0602D911 RID: 186641
		int Count { get; set; }

		// Token: 0x17005BD6 RID: 23510
		// (get) Token: 0x0602D912 RID: 186642
		// (set) Token: 0x0602D913 RID: 186643
		int? PreWaveDealtDamage { get; set; }
	}
}
