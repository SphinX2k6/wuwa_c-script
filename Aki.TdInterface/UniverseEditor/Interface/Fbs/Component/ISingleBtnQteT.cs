using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F22 RID: 24354
	public class ISingleBtnQteT
	{
		// Token: 0x1700B427 RID: 46119
		// (get) Token: 0x06028E24 RID: 167460 RVA: 0x0059612E File Offset: 0x0059432E
		// (set) Token: 0x06028E25 RID: 167461 RVA: 0x00596136 File Offset: 0x00594336
		public EQteType Type { get; set; }

		// Token: 0x1700B428 RID: 46120
		// (get) Token: 0x06028E26 RID: 167462 RVA: 0x0059613F File Offset: 0x0059433F
		// (set) Token: 0x06028E27 RID: 167463 RVA: 0x00596147 File Offset: 0x00594347
		public int QteId { get; set; }

		// Token: 0x1700B429 RID: 46121
		// (get) Token: 0x06028E28 RID: 167464 RVA: 0x00596150 File Offset: 0x00594350
		// (set) Token: 0x06028E29 RID: 167465 RVA: 0x00596158 File Offset: 0x00594358
		public IQteCallbackT SuccessCallback { get; set; }

		// Token: 0x1700B42A RID: 46122
		// (get) Token: 0x06028E2A RID: 167466 RVA: 0x00596161 File Offset: 0x00594361
		// (set) Token: 0x06028E2B RID: 167467 RVA: 0x00596169 File Offset: 0x00594369
		public IQteCallbackT FailureCallback { get; set; }

		// Token: 0x06028E2C RID: 167468 RVA: 0x00596172 File Offset: 0x00594372
		public ISingleBtnQteT()
		{
			this.Type = EQteType.SingleBtn;
			this.QteId = 0;
			this.SuccessCallback = null;
			this.FailureCallback = null;
		}
	}
}
