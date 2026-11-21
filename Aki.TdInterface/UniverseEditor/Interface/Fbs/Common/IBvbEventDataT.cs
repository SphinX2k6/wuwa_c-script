using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006384 RID: 25476
	public class IBvbEventDataT
	{
		// Token: 0x1700BC66 RID: 48230
		// (get) Token: 0x0602B428 RID: 177192 RVA: 0x005E61FA File Offset: 0x005E43FA
		// (set) Token: 0x0602B429 RID: 177193 RVA: 0x005E6202 File Offset: 0x005E4402
		public EBvbEventName Type { get; set; }

		// Token: 0x0602B42A RID: 177194 RVA: 0x005E620B File Offset: 0x005E440B
		public IBvbEventDataT()
		{
			this.Type = EBvbEventName.AIEvolution;
		}
	}
}
