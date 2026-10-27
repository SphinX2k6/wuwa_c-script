using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E20 RID: 28192
	public class IReignsAddBuffT
	{
		// Token: 0x1700D224 RID: 53796
		// (get) Token: 0x06031D0D RID: 204045 RVA: 0x006BE74E File Offset: 0x006BC94E
		// (set) Token: 0x06031D0E RID: 204046 RVA: 0x006BE756 File Offset: 0x006BC956
		public int BuffId { get; set; }

		// Token: 0x06031D0F RID: 204047 RVA: 0x006BE75F File Offset: 0x006BC95F
		public IReignsAddBuffT()
		{
			this.BuffId = 0;
		}
	}
}
