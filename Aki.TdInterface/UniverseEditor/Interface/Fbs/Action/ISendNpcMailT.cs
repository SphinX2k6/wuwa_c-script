using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F73 RID: 28531
	public class ISendNpcMailT
	{
		// Token: 0x1700D3F2 RID: 54258
		// (get) Token: 0x06032687 RID: 206471 RVA: 0x006CDF3E File Offset: 0x006CC13E
		// (set) Token: 0x06032688 RID: 206472 RVA: 0x006CDF46 File Offset: 0x006CC146
		public int MailId { get; set; }

		// Token: 0x06032689 RID: 206473 RVA: 0x006CDF4F File Offset: 0x006CC14F
		public ISendNpcMailT()
		{
			this.MailId = 0;
		}
	}
}
