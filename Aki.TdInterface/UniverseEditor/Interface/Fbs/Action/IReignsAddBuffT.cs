using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200759E RID: 30110
	public class IReignsAddBuffT
	{
		// Token: 0x1700DD73 RID: 56691
		// (get) Token: 0x06034D23 RID: 216355 RVA: 0x0071A0D6 File Offset: 0x007182D6
		// (set) Token: 0x06034D24 RID: 216356 RVA: 0x0071A0DE File Offset: 0x007182DE
		public int BuffId { get; set; }

		// Token: 0x06034D25 RID: 216357 RVA: 0x0071A0E7 File Offset: 0x007182E7
		public IReignsAddBuffT()
		{
			this.BuffId = 0;
		}
	}
}
