using System;

namespace CSharpScript.Game.Module.Kurotato
{
	// Token: 0x020046C4 RID: 18116
	public interface IKurotatoAttrSelectCardData
	{
		// Token: 0x17005BA2 RID: 23458
		// (get) Token: 0x0602D8A5 RID: 186533
		// (set) Token: 0x0602D8A6 RID: 186534
		int ItemId { get; set; }

		// Token: 0x17005BA3 RID: 23459
		// (get) Token: 0x0602D8A7 RID: 186535
		// (set) Token: 0x0602D8A8 RID: 186536
		int SelectionId { get; set; }

		// Token: 0x17005BA4 RID: 23460
		// (get) Token: 0x0602D8A9 RID: 186537
		// (set) Token: 0x0602D8AA RID: 186538
		bool IsRecommend { get; set; }

		// Token: 0x17005BA5 RID: 23461
		// (get) Token: 0x0602D8AB RID: 186539
		// (set) Token: 0x0602D8AC RID: 186540
		EKurotatoAttrSelectType SelectType { get; set; }
	}
}
