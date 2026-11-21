using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020060E9 RID: 24809
	public class ITreasureBoxComponentT
	{
		// Token: 0x1700B889 RID: 47241
		// (get) Token: 0x0602A04C RID: 172108 RVA: 0x005BC384 File Offset: 0x005BA584
		// (set) Token: 0x0602A04D RID: 172109 RVA: 0x005BC38C File Offset: 0x005BA58C
		public bool Disabled { get; set; }

		// Token: 0x1700B88A RID: 47242
		// (get) Token: 0x0602A04E RID: 172110 RVA: 0x005BC395 File Offset: 0x005BA595
		// (set) Token: 0x0602A04F RID: 172111 RVA: 0x005BC39D File Offset: 0x005BA59D
		public int TypeId { get; set; }

		// Token: 0x1700B88B RID: 47243
		// (get) Token: 0x0602A050 RID: 172112 RVA: 0x005BC3A6 File Offset: 0x005BA5A6
		// (set) Token: 0x0602A051 RID: 172113 RVA: 0x005BC3AE File Offset: 0x005BA5AE
		public bool IsSupportDiscoverDevice { get; set; }

		// Token: 0x1700B88C RID: 47244
		// (get) Token: 0x0602A052 RID: 172114 RVA: 0x005BC3B7 File Offset: 0x005BA5B7
		// (set) Token: 0x0602A053 RID: 172115 RVA: 0x005BC3BF File Offset: 0x005BA5BF
		public byte NullMask { get; set; }

		// Token: 0x0602A054 RID: 172116 RVA: 0x005BC3C8 File Offset: 0x005BA5C8
		public ITreasureBoxComponentT()
		{
			this.Disabled = false;
			this.TypeId = 0;
			this.IsSupportDiscoverDevice = false;
			this.NullMask = 0;
		}
	}
}
