using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F4E RID: 16206
	public class IMowBuffDistributeT
	{
		// Token: 0x170070B5 RID: 28853
		// (get) Token: 0x060170BA RID: 94394 RVA: 0x00352B04 File Offset: 0x00350D04
		// (set) Token: 0x060170BB RID: 94395 RVA: 0x00352B0C File Offset: 0x00350D0C
		public EShowUiType Type { get; set; }

		// Token: 0x170070B6 RID: 28854
		// (get) Token: 0x060170BC RID: 94396 RVA: 0x00352B15 File Offset: 0x00350D15
		// (set) Token: 0x060170BD RID: 94397 RVA: 0x00352B1D File Offset: 0x00350D1D
		public int BoardId { get; set; }

		// Token: 0x060170BE RID: 94398 RVA: 0x00352B26 File Offset: 0x00350D26
		public IMowBuffDistributeT()
		{
			this.Type = EShowUiType.All;
			this.BoardId = 0;
		}
	}
}
