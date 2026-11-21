using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007CA2 RID: 31906
	public class IUiStyleBaseOfLevelDT
	{
		// Token: 0x1700EEDE RID: 61150
		// (get) Token: 0x060398E5 RID: 235749 RVA: 0x007C482A File Offset: 0x007C2A2A
		// (set) Token: 0x060398E6 RID: 235750 RVA: 0x007C4832 File Offset: 0x007C2A32
		public EUiStyleTypeOfLevelD Type { get; set; }

		// Token: 0x060398E7 RID: 235751 RVA: 0x007C483B File Offset: 0x007C2A3B
		public IUiStyleBaseOfLevelDT()
		{
			this.Type = EUiStyleTypeOfLevelD.GiantSubtitle;
		}
	}
}
