using System;

namespace CSharpScript.Game.Module.Kurotato
{
	// Token: 0x020046CC RID: 18124
	public interface IKurotatoSmallItemGridData
	{
		// Token: 0x17005BC2 RID: 23490
		// (get) Token: 0x0602D8E9 RID: 186601
		// (set) Token: 0x0602D8EA RID: 186602
		EKurotatoCardType Type { get; set; }

		// Token: 0x17005BC3 RID: 23491
		// (get) Token: 0x0602D8EB RID: 186603
		// (set) Token: 0x0602D8EC RID: 186604
		int Id { get; set; }

		// Token: 0x17005BC4 RID: 23492
		// (get) Token: 0x0602D8ED RID: 186605
		// (set) Token: 0x0602D8EE RID: 186606
		int IncId { get; set; }

		// Token: 0x17005BC5 RID: 23493
		// (get) Token: 0x0602D8EF RID: 186607
		// (set) Token: 0x0602D8F0 RID: 186608
		int Count { get; set; }

		// Token: 0x17005BC6 RID: 23494
		// (get) Token: 0x0602D8F1 RID: 186609
		// (set) Token: 0x0602D8F2 RID: 186610
		bool? PlayComposeFx { get; set; }

		// Token: 0x17005BC7 RID: 23495
		// (get) Token: 0x0602D8F3 RID: 186611
		// (set) Token: 0x0602D8F4 RID: 186612
		bool? ShowArrow { get; set; }

		// Token: 0x17005BC8 RID: 23496
		// (get) Token: 0x0602D8F5 RID: 186613
		// (set) Token: 0x0602D8F6 RID: 186614
		bool? IsReceived { get; set; }

		// Token: 0x17005BC9 RID: 23497
		// (get) Token: 0x0602D8F7 RID: 186615
		// (set) Token: 0x0602D8F8 RID: 186616
		bool? IsShowCount { get; set; }
	}
}
