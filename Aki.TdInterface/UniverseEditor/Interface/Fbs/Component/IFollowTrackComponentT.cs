using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005815 RID: 22549
	public class IFollowTrackComponentT
	{
		// Token: 0x1700A33A RID: 41786
		// (get) Token: 0x060247CD RID: 149453 RVA: 0x00503871 File Offset: 0x00501A71
		// (set) Token: 0x060247CE RID: 149454 RVA: 0x00503879 File Offset: 0x00501A79
		public bool Disabled { get; set; }

		// Token: 0x1700A33B RID: 41787
		// (get) Token: 0x060247CF RID: 149455 RVA: 0x00503882 File Offset: 0x00501A82
		// (set) Token: 0x060247D0 RID: 149456 RVA: 0x0050388A File Offset: 0x00501A8A
		public float Range { get; set; }

		// Token: 0x1700A33C RID: 41788
		// (get) Token: 0x060247D1 RID: 149457 RVA: 0x00503893 File Offset: 0x00501A93
		// (set) Token: 0x060247D2 RID: 149458 RVA: 0x0050389B File Offset: 0x00501A9B
		public int SplineEntityId { get; set; }

		// Token: 0x1700A33D RID: 41789
		// (get) Token: 0x060247D3 RID: 149459 RVA: 0x005038A4 File Offset: 0x00501AA4
		// (set) Token: 0x060247D4 RID: 149460 RVA: 0x005038AC File Offset: 0x00501AAC
		public TFollowTrackEndOptionUnion EndType { get; set; }

		// Token: 0x1700A33E RID: 41790
		// (get) Token: 0x060247D5 RID: 149461 RVA: 0x005038B5 File Offset: 0x00501AB5
		// (set) Token: 0x060247D6 RID: 149462 RVA: 0x005038BD File Offset: 0x00501ABD
		public byte NullMask { get; set; }

		// Token: 0x060247D7 RID: 149463 RVA: 0x005038C6 File Offset: 0x00501AC6
		public IFollowTrackComponentT()
		{
			this.Disabled = false;
			this.Range = 0f;
			this.SplineEntityId = 0;
			this.EndType = null;
			this.NullMask = 0;
		}
	}
}
