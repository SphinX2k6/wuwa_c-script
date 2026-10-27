using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E76 RID: 24182
	public class TCsvOutAreaBorderDataT
	{
		// Token: 0x1700B4C6 RID: 46278
		// (get) Token: 0x060296C8 RID: 169672 RVA: 0x005AD527 File Offset: 0x005AB727
		// (set) Token: 0x060296C9 RID: 169673 RVA: 0x005AD52F File Offset: 0x005AB72F
		public int Id { get; set; }

		// Token: 0x1700B4C7 RID: 46279
		// (get) Token: 0x060296CA RID: 169674 RVA: 0x005AD538 File Offset: 0x005AB738
		// (set) Token: 0x060296CB RID: 169675 RVA: 0x005AD540 File Offset: 0x005AB740
		public IOutAreaBorderTimerConfigT Data { get; set; }

		// Token: 0x060296CC RID: 169676 RVA: 0x005AD549 File Offset: 0x005AB749
		public TCsvOutAreaBorderDataT()
		{
			this.Id = 0;
			this.Data = null;
		}
	}
}
