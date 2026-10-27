using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AD0 RID: 23248
	public class ITrampleTipTypeT
	{
		// Token: 0x1700AF37 RID: 44855
		// (get) Token: 0x06027A5C RID: 162396 RVA: 0x005742F2 File Offset: 0x005724F2
		// (set) Token: 0x06027A5D RID: 162397 RVA: 0x005742FA File Offset: 0x005724FA
		public ETrampleTipType Type { get; set; }

		// Token: 0x06027A5E RID: 162398 RVA: 0x00574303 File Offset: 0x00572503
		public ITrampleTipTypeT()
		{
			this.Type = ETrampleTipType.CountDownTextTip;
		}
	}
}
