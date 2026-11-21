using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F39 RID: 28473
	public class IGmActionContextT
	{
		// Token: 0x1700D0AF RID: 53423
		// (get) Token: 0x06031468 RID: 201832 RVA: 0x006ACECD File Offset: 0x006AB0CD
		// (set) Token: 0x06031469 RID: 201833 RVA: 0x006ACED5 File Offset: 0x006AB0D5
		public string Type { get; set; }

		// Token: 0x0603146A RID: 201834 RVA: 0x006ACEDE File Offset: 0x006AB0DE
		public IGmActionContextT()
		{
			this.Type = null;
		}
	}
}
