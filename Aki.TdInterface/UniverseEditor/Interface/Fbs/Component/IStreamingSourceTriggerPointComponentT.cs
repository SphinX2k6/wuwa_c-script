using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005FEB RID: 24555
	public class IStreamingSourceTriggerPointComponentT
	{
		// Token: 0x1700B610 RID: 46608
		// (get) Token: 0x060295F6 RID: 169462 RVA: 0x005A5D97 File Offset: 0x005A3F97
		// (set) Token: 0x060295F7 RID: 169463 RVA: 0x005A5D9F File Offset: 0x005A3F9F
		public bool Disabled { get; set; }

		// Token: 0x1700B611 RID: 46609
		// (get) Token: 0x060295F8 RID: 169464 RVA: 0x005A5DA8 File Offset: 0x005A3FA8
		// (set) Token: 0x060295F9 RID: 169465 RVA: 0x005A5DB0 File Offset: 0x005A3FB0
		public int Radius { get; set; }

		// Token: 0x1700B612 RID: 46610
		// (get) Token: 0x060295FA RID: 169466 RVA: 0x005A5DB9 File Offset: 0x005A3FB9
		// (set) Token: 0x060295FB RID: 169467 RVA: 0x005A5DC1 File Offset: 0x005A3FC1
		public TStreamingSourceConfigUnion StreamingSource { get; set; }

		// Token: 0x1700B613 RID: 46611
		// (get) Token: 0x060295FC RID: 169468 RVA: 0x005A5DCA File Offset: 0x005A3FCA
		// (set) Token: 0x060295FD RID: 169469 RVA: 0x005A5DD2 File Offset: 0x005A3FD2
		public byte NullMask { get; set; }

		// Token: 0x060295FE RID: 169470 RVA: 0x005A5DDB File Offset: 0x005A3FDB
		public IStreamingSourceTriggerPointComponentT()
		{
			this.Disabled = false;
			this.Radius = 0;
			this.StreamingSource = null;
			this.NullMask = 0;
		}
	}
}
