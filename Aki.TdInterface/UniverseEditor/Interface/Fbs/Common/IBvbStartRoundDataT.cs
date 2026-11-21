using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020063A2 RID: 25506
	public class IBvbStartRoundDataT
	{
		// Token: 0x1700BC82 RID: 48258
		// (get) Token: 0x0602B500 RID: 177408 RVA: 0x005E761A File Offset: 0x005E581A
		// (set) Token: 0x0602B501 RID: 177409 RVA: 0x005E7622 File Offset: 0x005E5822
		public EBvbEventName Type { get; set; }

		// Token: 0x0602B502 RID: 177410 RVA: 0x005E762B File Offset: 0x005E582B
		public IBvbStartRoundDataT()
		{
			this.Type = EBvbEventName.AIEvolution;
		}
	}
}
