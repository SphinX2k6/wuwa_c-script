using System;

namespace CSharpScript.Game.Module.Kurotato
{
	// Token: 0x020056F5 RID: 22261
	public interface IKurotatoSmallItemGridData
	{
		// Token: 0x170087FA RID: 34810
		// (get) Token: 0x060389D9 RID: 231897
		// (set) Token: 0x060389DA RID: 231898
		EKurotatoCardType Type { get; set; }

		// Token: 0x170087FB RID: 34811
		// (get) Token: 0x060389DB RID: 231899
		// (set) Token: 0x060389DC RID: 231900
		int Id { get; set; }

		// Token: 0x170087FC RID: 34812
		// (get) Token: 0x060389DD RID: 231901
		// (set) Token: 0x060389DE RID: 231902
		int IncId { get; set; }

		// Token: 0x170087FD RID: 34813
		// (get) Token: 0x060389DF RID: 231903
		// (set) Token: 0x060389E0 RID: 231904
		int Count { get; set; }

		// Token: 0x170087FE RID: 34814
		// (get) Token: 0x060389E1 RID: 231905
		// (set) Token: 0x060389E2 RID: 231906
		bool? PlayComposeFx { get; set; }

		// Token: 0x170087FF RID: 34815
		// (get) Token: 0x060389E3 RID: 231907
		// (set) Token: 0x060389E4 RID: 231908
		bool? ShowArrow { get; set; }

		// Token: 0x17008800 RID: 34816
		// (get) Token: 0x060389E5 RID: 231909
		// (set) Token: 0x060389E6 RID: 231910
		bool? IsReceived { get; set; }

		// Token: 0x17008801 RID: 34817
		// (get) Token: 0x060389E7 RID: 231911
		// (set) Token: 0x060389E8 RID: 231912
		bool? IsShowCount { get; set; }
	}
}
