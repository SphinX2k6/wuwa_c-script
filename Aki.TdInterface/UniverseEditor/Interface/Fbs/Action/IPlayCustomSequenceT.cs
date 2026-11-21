using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200744F RID: 29775
	public class IPlayCustomSequenceT
	{
		// Token: 0x1700DAC5 RID: 56005
		// (get) Token: 0x060341E1 RID: 213473 RVA: 0x00705BEB File Offset: 0x00703DEB
		// (set) Token: 0x060341E2 RID: 213474 RVA: 0x00705BF3 File Offset: 0x00703DF3
		public int CustomSeqId { get; set; }

		// Token: 0x1700DAC6 RID: 56006
		// (get) Token: 0x060341E3 RID: 213475 RVA: 0x00705BFC File Offset: 0x00703DFC
		// (set) Token: 0x060341E4 RID: 213476 RVA: 0x00705C04 File Offset: 0x00703E04
		public List<int> WhoIds { get; set; }

		// Token: 0x1700DAC7 RID: 56007
		// (get) Token: 0x060341E5 RID: 213477 RVA: 0x00705C0D File Offset: 0x00703E0D
		// (set) Token: 0x060341E6 RID: 213478 RVA: 0x00705C15 File Offset: 0x00703E15
		public bool ResetCamera { get; set; }

		// Token: 0x1700DAC8 RID: 56008
		// (get) Token: 0x060341E7 RID: 213479 RVA: 0x00705C1E File Offset: 0x00703E1E
		// (set) Token: 0x060341E8 RID: 213480 RVA: 0x00705C26 File Offset: 0x00703E26
		public byte NullMask { get; set; }

		// Token: 0x060341E9 RID: 213481 RVA: 0x00705C2F File Offset: 0x00703E2F
		public IPlayCustomSequenceT()
		{
			this.CustomSeqId = 0;
			this.WhoIds = null;
			this.ResetCamera = false;
			this.NullMask = 0;
		}
	}
}
