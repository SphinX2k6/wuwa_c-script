using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x02005EA0 RID: 24224
	public class ICommonBtActionInfoT
	{
		// Token: 0x1700B507 RID: 46343
		// (get) Token: 0x06029800 RID: 169984 RVA: 0x005AFBAB File Offset: 0x005ADDAB
		// (set) Token: 0x06029801 RID: 169985 RVA: 0x005AFBB3 File Offset: 0x005ADDB3
		public int TaskId { get; set; }

		// Token: 0x1700B508 RID: 46344
		// (get) Token: 0x06029802 RID: 169986 RVA: 0x005AFBBC File Offset: 0x005ADDBC
		// (set) Token: 0x06029803 RID: 169987 RVA: 0x005AFBC4 File Offset: 0x005ADDC4
		public IActionInfoT Action { get; set; }

		// Token: 0x06029804 RID: 169988 RVA: 0x005AFBCD File Offset: 0x005ADDCD
		public ICommonBtActionInfoT()
		{
			this.TaskId = 0;
			this.Action = null;
		}
	}
}
