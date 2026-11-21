using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005944 RID: 22852
	[NullableContext(1)]
	[Nullable(0)]
	public class ScratchTicketRoundResult
	{
		// Token: 0x17006BDF RID: 27615
		// (get) Token: 0x060384EE RID: 230638 RVA: 0x00FBE4BE File Offset: 0x00FBC6BE
		// (set) Token: 0x060384EF RID: 230639 RVA: 0x00FBE4C6 File Offset: 0x00FBC6C6
		public List<ScratchTicketRewardResult> RewardList { get; set; } = new List<ScratchTicketRewardResult>();

		// Token: 0x17006BE0 RID: 27616
		// (get) Token: 0x060384F0 RID: 230640 RVA: 0x00FBE4CF File Offset: 0x00FBC6CF
		// (set) Token: 0x060384F1 RID: 230641 RVA: 0x00FBE4D7 File Offset: 0x00FBC6D7
		public float DelayInterval { get; set; }

		// Token: 0x17006BE1 RID: 27617
		// (get) Token: 0x060384F2 RID: 230642 RVA: 0x00FBE4E0 File Offset: 0x00FBC6E0
		// (set) Token: 0x060384F3 RID: 230643 RVA: 0x00FBE4E8 File Offset: 0x00FBC6E8
		public string SequenceName { get; set; }
	}
}
