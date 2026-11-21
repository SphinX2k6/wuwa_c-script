using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005383 RID: 21379
	public class IAiAlertNotifyComponentT
	{
		// Token: 0x17009705 RID: 38661
		// (get) Token: 0x06021519 RID: 136473 RVA: 0x00498DC7 File Offset: 0x00496FC7
		// (set) Token: 0x0602151A RID: 136474 RVA: 0x00498DCF File Offset: 0x00496FCF
		public bool Disabled { get; set; }

		// Token: 0x17009706 RID: 38662
		// (get) Token: 0x0602151B RID: 136475 RVA: 0x00498DD8 File Offset: 0x00496FD8
		// (set) Token: 0x0602151C RID: 136476 RVA: 0x00498DE0 File Offset: 0x00496FE0
		public IExtraAiAlertT ExtraAiAlert { get; set; }

		// Token: 0x17009707 RID: 38663
		// (get) Token: 0x0602151D RID: 136477 RVA: 0x00498DE9 File Offset: 0x00496FE9
		// (set) Token: 0x0602151E RID: 136478 RVA: 0x00498DF1 File Offset: 0x00496FF1
		public List<int> ExcludeEntities { get; set; }

		// Token: 0x17009708 RID: 38664
		// (get) Token: 0x0602151F RID: 136479 RVA: 0x00498DFA File Offset: 0x00496FFA
		// (set) Token: 0x06021520 RID: 136480 RVA: 0x00498E02 File Offset: 0x00497002
		public string AlertSound { get; set; }

		// Token: 0x17009709 RID: 38665
		// (get) Token: 0x06021521 RID: 136481 RVA: 0x00498E0B File Offset: 0x0049700B
		// (set) Token: 0x06021522 RID: 136482 RVA: 0x00498E13 File Offset: 0x00497013
		public byte NullMask { get; set; }

		// Token: 0x06021523 RID: 136483 RVA: 0x00498E1C File Offset: 0x0049701C
		public IAiAlertNotifyComponentT()
		{
			this.Disabled = false;
			this.ExtraAiAlert = null;
			this.ExcludeEntities = null;
			this.AlertSound = null;
			this.NullMask = 0;
		}
	}
}
