using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x0200637E RID: 25470
	public class IBvbBurnBuffTimeUpDataT
	{
		// Token: 0x1700BC60 RID: 48224
		// (get) Token: 0x0602B404 RID: 177156 RVA: 0x005E5F0A File Offset: 0x005E410A
		// (set) Token: 0x0602B405 RID: 177157 RVA: 0x005E5F12 File Offset: 0x005E4112
		public EBvbEventName Type { get; set; }

		// Token: 0x0602B406 RID: 177158 RVA: 0x005E5F1B File Offset: 0x005E411B
		public IBvbBurnBuffTimeUpDataT()
		{
			this.Type = EBvbEventName.AIEvolution;
		}
	}
}
