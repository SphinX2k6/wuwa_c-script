using System;

namespace CSharpScript.Game.Module.Kurotato
{
	// Token: 0x020046D2 RID: 18130
	public interface IKurotatoCardTip
	{
		// Token: 0x17005BE4 RID: 23524
		// (get) Token: 0x0602D930 RID: 186672
		// (set) Token: 0x0602D931 RID: 186673
		EKurotatoCardType CardType { get; set; }

		// Token: 0x17005BE5 RID: 23525
		// (get) Token: 0x0602D932 RID: 186674
		// (set) Token: 0x0602D933 RID: 186675
		int SelectId { get; set; }

		// Token: 0x17005BE6 RID: 23526
		// (get) Token: 0x0602D934 RID: 186676
		// (set) Token: 0x0602D935 RID: 186677
		bool? IsConfigId { get; set; }
	}
}
