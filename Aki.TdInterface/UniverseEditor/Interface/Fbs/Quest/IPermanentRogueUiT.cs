using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F78 RID: 16248
	public class IPermanentRogueUiT
	{
		// Token: 0x1700716C RID: 29036
		// (get) Token: 0x06017316 RID: 94998 RVA: 0x00358C9A File Offset: 0x00356E9A
		// (set) Token: 0x06017317 RID: 94999 RVA: 0x00358CA2 File Offset: 0x00356EA2
		public EShowUiType Type { get; set; }

		// Token: 0x1700716D RID: 29037
		// (get) Token: 0x06017318 RID: 95000 RVA: 0x00358CAB File Offset: 0x00356EAB
		// (set) Token: 0x06017319 RID: 95001 RVA: 0x00358CB3 File Offset: 0x00356EB3
		public ERogueUiType UiType { get; set; }

		// Token: 0x1700716E RID: 29038
		// (get) Token: 0x0601731A RID: 95002 RVA: 0x00358CBC File Offset: 0x00356EBC
		// (set) Token: 0x0601731B RID: 95003 RVA: 0x00358CC4 File Offset: 0x00356EC4
		public int BindId { get; set; }

		// Token: 0x0601731C RID: 95004 RVA: 0x00358CCD File Offset: 0x00356ECD
		public IPermanentRogueUiT()
		{
			this.Type = EShowUiType.All;
			this.UiType = ERogueUiType.None;
			this.BindId = 0;
		}
	}
}
