using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BB3 RID: 27571
	public class INpcExitCurrentInteractT
	{
		// Token: 0x1700CCEF RID: 52463
		// (get) Token: 0x060306FB RID: 198395 RVA: 0x00693F82 File Offset: 0x00692182
		// (set) Token: 0x060306FC RID: 198396 RVA: 0x00693F8A File Offset: 0x0069218A
		public ENpcLeisureInteract Type { get; set; }

		// Token: 0x1700CCF0 RID: 52464
		// (get) Token: 0x060306FD RID: 198397 RVA: 0x00693F93 File Offset: 0x00692193
		// (set) Token: 0x060306FE RID: 198398 RVA: 0x00693F9B File Offset: 0x0069219B
		public bool KeepState { get; set; }

		// Token: 0x1700CCF1 RID: 52465
		// (get) Token: 0x060306FF RID: 198399 RVA: 0x00693FA4 File Offset: 0x006921A4
		// (set) Token: 0x06030700 RID: 198400 RVA: 0x00693FAC File Offset: 0x006921AC
		public byte NullMask { get; set; }

		// Token: 0x06030701 RID: 198401 RVA: 0x00693FB5 File Offset: 0x006921B5
		public INpcExitCurrentInteractT()
		{
			this.Type = ENpcLeisureInteract.SitDown;
			this.KeepState = false;
			this.NullMask = 0;
		}
	}
}
