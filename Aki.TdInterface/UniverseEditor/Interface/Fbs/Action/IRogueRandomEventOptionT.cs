using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200766A RID: 30314
	public class IRogueRandomEventOptionT
	{
		// Token: 0x1700DE8E RID: 56974
		// (get) Token: 0x060352F9 RID: 217849 RVA: 0x00723A9D File Offset: 0x00721C9D
		// (set) Token: 0x060352FA RID: 217850 RVA: 0x00723AA5 File Offset: 0x00721CA5
		public ESystemOptionType Type { get; set; }

		// Token: 0x1700DE8F RID: 56975
		// (get) Token: 0x060352FB RID: 217851 RVA: 0x00723AAE File Offset: 0x00721CAE
		// (set) Token: 0x060352FC RID: 217852 RVA: 0x00723AB6 File Offset: 0x00721CB6
		public List<ISystemOptionT> SystemOptions { get; set; }

		// Token: 0x1700DE90 RID: 56976
		// (get) Token: 0x060352FD RID: 217853 RVA: 0x00723ABF File Offset: 0x00721CBF
		// (set) Token: 0x060352FE RID: 217854 RVA: 0x00723AC7 File Offset: 0x00721CC7
		public bool KeepPreTalkItem { get; set; }

		// Token: 0x1700DE91 RID: 56977
		// (get) Token: 0x060352FF RID: 217855 RVA: 0x00723AD0 File Offset: 0x00721CD0
		// (set) Token: 0x06035300 RID: 217856 RVA: 0x00723AD8 File Offset: 0x00721CD8
		public int EventId { get; set; }

		// Token: 0x1700DE92 RID: 56978
		// (get) Token: 0x06035301 RID: 217857 RVA: 0x00723AE1 File Offset: 0x00721CE1
		// (set) Token: 0x06035302 RID: 217858 RVA: 0x00723AE9 File Offset: 0x00721CE9
		public byte NullMask { get; set; }

		// Token: 0x06035303 RID: 217859 RVA: 0x00723AF2 File Offset: 0x00721CF2
		public IRogueRandomEventOptionT()
		{
			this.Type = ESystemOptionType.RogueRandomEvent;
			this.SystemOptions = null;
			this.KeepPreTalkItem = false;
			this.EventId = 0;
			this.NullMask = 0;
		}
	}
}
