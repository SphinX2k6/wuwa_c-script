using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E07 RID: 24071
	public class IInitNpcPerformStateT
	{
		// Token: 0x1700B419 RID: 46105
		// (get) Token: 0x06029346 RID: 168774 RVA: 0x005A704A File Offset: 0x005A524A
		// (set) Token: 0x06029347 RID: 168775 RVA: 0x005A7052 File Offset: 0x005A5252
		public string Type { get; set; }

		// Token: 0x1700B41A RID: 46106
		// (get) Token: 0x06029348 RID: 168776 RVA: 0x005A705B File Offset: 0x005A525B
		// (set) Token: 0x06029349 RID: 168777 RVA: 0x005A7063 File Offset: 0x005A5263
		public string State { get; set; }

		// Token: 0x0602934A RID: 168778 RVA: 0x005A706C File Offset: 0x005A526C
		public IInitNpcPerformStateT()
		{
			this.Type = null;
			this.State = null;
		}
	}
}
