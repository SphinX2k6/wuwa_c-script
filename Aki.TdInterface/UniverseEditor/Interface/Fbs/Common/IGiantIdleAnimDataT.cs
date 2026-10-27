using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005DBF RID: 23999
	public class IGiantIdleAnimDataT
	{
		// Token: 0x1700B3B0 RID: 46000
		// (get) Token: 0x0602913E RID: 168254 RVA: 0x005A3A0C File Offset: 0x005A1C0C
		// (set) Token: 0x0602913F RID: 168255 RVA: 0x005A3A14 File Offset: 0x005A1C14
		public EGiantAnimationType Type { get; set; }

		// Token: 0x1700B3B1 RID: 46001
		// (get) Token: 0x06029140 RID: 168256 RVA: 0x005A3A1D File Offset: 0x005A1C1D
		// (set) Token: 0x06029141 RID: 168257 RVA: 0x005A3A25 File Offset: 0x005A1C25
		public EGiantIdleType IdleType { get; set; }

		// Token: 0x06029142 RID: 168258 RVA: 0x005A3A2E File Offset: 0x005A1C2E
		public IGiantIdleAnimDataT()
		{
			this.Type = EGiantAnimationType.Idle;
			this.IdleType = EGiantIdleType.Common;
		}
	}
}
