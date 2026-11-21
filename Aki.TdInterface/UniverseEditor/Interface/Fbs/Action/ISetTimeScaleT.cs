using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007864 RID: 30820
	public class ISetTimeScaleT
	{
		// Token: 0x1700E210 RID: 57872
		// (get) Token: 0x0603634C RID: 222028 RVA: 0x00742D89 File Offset: 0x00740F89
		// (set) Token: 0x0603634D RID: 222029 RVA: 0x00742D91 File Offset: 0x00740F91
		public ISetGlobalTimeScaleT Config { get; set; }

		// Token: 0x0603634E RID: 222030 RVA: 0x00742D9A File Offset: 0x00740F9A
		public ISetTimeScaleT()
		{
			this.Config = null;
		}
	}
}
