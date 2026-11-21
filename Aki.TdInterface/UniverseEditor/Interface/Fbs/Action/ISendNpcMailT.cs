using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007739 RID: 30521
	public class ISendNpcMailT
	{
		// Token: 0x1700DFC1 RID: 57281
		// (get) Token: 0x060358D7 RID: 219351 RVA: 0x0072D8F6 File Offset: 0x0072BAF6
		// (set) Token: 0x060358D8 RID: 219352 RVA: 0x0072D8FE File Offset: 0x0072BAFE
		public int MailId { get; set; }

		// Token: 0x060358D9 RID: 219353 RVA: 0x0072D907 File Offset: 0x0072BB07
		public ISendNpcMailT()
		{
			this.MailId = 0;
		}
	}
}
