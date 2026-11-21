using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CB7 RID: 27831
	public class IEnableAlertUiT
	{
		// Token: 0x1700CC2A RID: 52266
		// (get) Token: 0x0602FF80 RID: 196480 RVA: 0x006876DA File Offset: 0x006858DA
		// (set) Token: 0x0602FF81 RID: 196481 RVA: 0x006876E2 File Offset: 0x006858E2
		public EAlertSystemOption Type { get; set; }

		// Token: 0x1700CC2B RID: 52267
		// (get) Token: 0x0602FF82 RID: 196482 RVA: 0x006876EB File Offset: 0x006858EB
		// (set) Token: 0x0602FF83 RID: 196483 RVA: 0x006876F3 File Offset: 0x006858F3
		public int AreaId { get; set; }

		// Token: 0x1700CC2C RID: 52268
		// (get) Token: 0x0602FF84 RID: 196484 RVA: 0x006876FC File Offset: 0x006858FC
		// (set) Token: 0x0602FF85 RID: 196485 RVA: 0x00687704 File Offset: 0x00685904
		public bool IsEnable { get; set; }

		// Token: 0x0602FF86 RID: 196486 RVA: 0x0068770D File Offset: 0x0068590D
		public IEnableAlertUiT()
		{
			this.Type = EAlertSystemOption.EnableAlertArea;
			this.AreaId = 0;
			this.IsEnable = false;
		}
	}
}
