using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005DCE RID: 24014
	public class IGiantSpecialAnimDataT
	{
		// Token: 0x1700B3C6 RID: 46022
		// (get) Token: 0x060291A6 RID: 168358 RVA: 0x005A4453 File Offset: 0x005A2653
		// (set) Token: 0x060291A7 RID: 168359 RVA: 0x005A445B File Offset: 0x005A265B
		public EGiantAnimationType Type { get; set; }

		// Token: 0x1700B3C7 RID: 46023
		// (get) Token: 0x060291A8 RID: 168360 RVA: 0x005A4464 File Offset: 0x005A2664
		// (set) Token: 0x060291A9 RID: 168361 RVA: 0x005A446C File Offset: 0x005A266C
		public string MontagePath { get; set; }

		// Token: 0x1700B3C8 RID: 46024
		// (get) Token: 0x060291AA RID: 168362 RVA: 0x005A4475 File Offset: 0x005A2675
		// (set) Token: 0x060291AB RID: 168363 RVA: 0x005A447D File Offset: 0x005A267D
		public bool IsCanBeInterrupt { get; set; }

		// Token: 0x1700B3C9 RID: 46025
		// (get) Token: 0x060291AC RID: 168364 RVA: 0x005A4486 File Offset: 0x005A2686
		// (set) Token: 0x060291AD RID: 168365 RVA: 0x005A448E File Offset: 0x005A268E
		public byte NullMask { get; set; }

		// Token: 0x060291AE RID: 168366 RVA: 0x005A4497 File Offset: 0x005A2697
		public IGiantSpecialAnimDataT()
		{
			this.Type = EGiantAnimationType.Idle;
			this.MontagePath = null;
			this.IsCanBeInterrupt = false;
			this.NullMask = 0;
		}
	}
}
