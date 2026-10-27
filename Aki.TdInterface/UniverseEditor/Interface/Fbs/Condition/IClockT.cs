using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B81 RID: 19329
	public class IClockT
	{
		// Token: 0x17008C43 RID: 35907
		// (get) Token: 0x0601E763 RID: 124771 RVA: 0x00443D10 File Offset: 0x00441F10
		// (set) Token: 0x0601E764 RID: 124772 RVA: 0x00443D18 File Offset: 0x00441F18
		public EVisibleCondition Type { get; set; }

		// Token: 0x17008C44 RID: 35908
		// (get) Token: 0x0601E765 RID: 124773 RVA: 0x00443D21 File Offset: 0x00441F21
		// (set) Token: 0x0601E766 RID: 124774 RVA: 0x00443D29 File Offset: 0x00441F29
		public ECompare Compare { get; set; }

		// Token: 0x17008C45 RID: 35909
		// (get) Token: 0x0601E767 RID: 124775 RVA: 0x00443D32 File Offset: 0x00441F32
		// (set) Token: 0x0601E768 RID: 124776 RVA: 0x00443D3A File Offset: 0x00441F3A
		public int Start { get; set; }

		// Token: 0x17008C46 RID: 35910
		// (get) Token: 0x0601E769 RID: 124777 RVA: 0x00443D43 File Offset: 0x00441F43
		// (set) Token: 0x0601E76A RID: 124778 RVA: 0x00443D4B File Offset: 0x00441F4B
		public int End { get; set; }

		// Token: 0x0601E76B RID: 124779 RVA: 0x00443D54 File Offset: 0x00441F54
		public IClockT()
		{
			this.Type = EVisibleCondition.Weather;
			this.Compare = ECompare.Eq;
			this.Start = 0;
			this.End = 0;
		}
	}
}
