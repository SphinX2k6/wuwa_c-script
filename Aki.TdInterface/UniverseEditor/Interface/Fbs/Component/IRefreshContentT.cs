using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005821 RID: 22561
	public class IRefreshContentT
	{
		// Token: 0x1700A884 RID: 43140
		// (get) Token: 0x06025EFC RID: 155388 RVA: 0x0053B0D6 File Offset: 0x005392D6
		// (set) Token: 0x06025EFD RID: 155389 RVA: 0x0053B0DE File Offset: 0x005392DE
		public ERefreshContent Type { get; set; }

		// Token: 0x06025EFE RID: 155390 RVA: 0x0053B0E7 File Offset: 0x005392E7
		public IRefreshContentT()
		{
			this.Type = ERefreshContent.All;
		}
	}
}
