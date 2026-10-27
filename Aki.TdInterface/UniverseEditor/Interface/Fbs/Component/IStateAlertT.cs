using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200599C RID: 22940
	public class IStateAlertT
	{
		// Token: 0x1700AC26 RID: 44070
		// (get) Token: 0x06026DA6 RID: 159142 RVA: 0x00558D3B File Offset: 0x00556F3B
		// (set) Token: 0x06026DA7 RID: 159143 RVA: 0x00558D43 File Offset: 0x00556F43
		public string State { get; set; }

		// Token: 0x1700AC27 RID: 44071
		// (get) Token: 0x06026DA8 RID: 159144 RVA: 0x00558D4C File Offset: 0x00556F4C
		// (set) Token: 0x06026DA9 RID: 159145 RVA: 0x00558D54 File Offset: 0x00556F54
		public int Alert { get; set; }

		// Token: 0x06026DAA RID: 159146 RVA: 0x00558D5D File Offset: 0x00556F5D
		public IStateAlertT()
		{
			this.State = null;
			this.Alert = 0;
		}
	}
}
