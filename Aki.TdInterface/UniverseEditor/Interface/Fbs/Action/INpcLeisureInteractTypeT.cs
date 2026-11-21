using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007326 RID: 29478
	public class INpcLeisureInteractTypeT
	{
		// Token: 0x1700D80F RID: 55311
		// (get) Token: 0x0603367D RID: 210557 RVA: 0x006EE446 File Offset: 0x006EC646
		// (set) Token: 0x0603367E RID: 210558 RVA: 0x006EE44E File Offset: 0x006EC64E
		public ENpcLeisureInteract Type { get; set; }

		// Token: 0x1700D810 RID: 55312
		// (get) Token: 0x0603367F RID: 210559 RVA: 0x006EE457 File Offset: 0x006EC657
		// (set) Token: 0x06033680 RID: 210560 RVA: 0x006EE45F File Offset: 0x006EC65F
		public bool KeepState { get; set; }

		// Token: 0x1700D811 RID: 55313
		// (get) Token: 0x06033681 RID: 210561 RVA: 0x006EE468 File Offset: 0x006EC668
		// (set) Token: 0x06033682 RID: 210562 RVA: 0x006EE470 File Offset: 0x006EC670
		public byte NullMask { get; set; }

		// Token: 0x06033683 RID: 210563 RVA: 0x006EE479 File Offset: 0x006EC679
		public INpcLeisureInteractTypeT()
		{
			this.Type = ENpcLeisureInteract.SitDown;
			this.KeepState = false;
			this.NullMask = 0;
		}
	}
}
