using System;

namespace CSharpScript.Game.Module.PermanentRogue
{
	// Token: 0x020052F3 RID: 21235
	public interface IIllustratedTokenDataInfo
	{
		// Token: 0x17008310 RID: 33552
		// (get) Token: 0x060365A1 RID: 222625
		// (set) Token: 0x060365A2 RID: 222626
		int ConfigId { get; set; }

		// Token: 0x17008311 RID: 33553
		// (get) Token: 0x060365A3 RID: 222627
		// (set) Token: 0x060365A4 RID: 222628
		int CollectionIndex { get; set; }

		// Token: 0x17008312 RID: 33554
		// (get) Token: 0x060365A5 RID: 222629
		// (set) Token: 0x060365A6 RID: 222630
		bool IsLock { get; set; }

		// Token: 0x17008313 RID: 33555
		// (get) Token: 0x060365A7 RID: 222631
		// (set) Token: 0x060365A8 RID: 222632
		bool HasRedDot { get; set; }

		// Token: 0x17008314 RID: 33556
		// (get) Token: 0x060365A9 RID: 222633
		// (set) Token: 0x060365AA RID: 222634
		bool IsSelectOn { get; set; }
	}
}
